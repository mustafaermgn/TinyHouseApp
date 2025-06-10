using System;
using System.Data;
using System.Windows.Forms;
using System.Collections.Generic;
using System.IO;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class HouseForm : Form
    {
        private int _ownerId;
        private int? _houseId;
        private readonly List<string> _selectedImages = new();

        public HouseForm(int ownerId, int? houseId = null)
        {
            InitializeComponent();
            _ownerId = ownerId;
            _houseId = houseId;

            if (_houseId.HasValue)
            {
                LoadHouse();
                btnSave.Text = "Güncelle";
            }
        }

        private void LoadHouse()
        {
            var dt = DBHelper.GetDataTable("SELECT * FROM Houses WHERE HouseID=@h",
                new SqlParameter("@h", _houseId.Value));
            if (dt.Rows.Count == 0) return;
            var row = dt.Rows[0];
            txtTitle.Text = row["Title"].ToString();
            txtDesc.Text = row["Description"].ToString();
            numPrice.Value = (decimal)row["PricePerNight"];
            txtLocation.Text = row["Location"].ToString();
            chkActive.Checked = (bool)row["IsActive"];
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var desc = txtDesc.Text.Trim();
            var price = numPrice.Value;
            var loc = txtLocation.Text.Trim();
            var active = chkActive.Checked;

            if (_houseId.HasValue)
            {
                DBHelper.ExecuteNonQuery(@"
                    UPDATE Houses SET Title=@t, Description=@d, PricePerNight=@p, Location=@l, IsActive=@a
                    WHERE HouseID=@h",
                    new SqlParameter("@t", title),
                    new SqlParameter("@d", desc),
                    new SqlParameter("@p", price),
                    new SqlParameter("@l", loc),
                    new SqlParameter("@a", active),
                    new SqlParameter("@h", _houseId.Value)
                );
            }
            else
            {
                _houseId = Convert.ToInt32(DBHelper.ExecuteScalar(@"
                    INSERT INTO Houses(OwnerID,Title,Description,PricePerNight,Location,IsActive)
                    VALUES(@o,@t,@d,@p,@l,@a); SELECT SCOPE_IDENTITY();",
                    new SqlParameter("@o", _ownerId),
                    new SqlParameter("@t", title),
                    new SqlParameter("@d", desc),
                    new SqlParameter("@p", price),
                    new SqlParameter("@l", loc),
                    new SqlParameter("@a", active)
                ));
            }

            SaveImages();

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void SaveImages()
        {
            if (!_houseId.HasValue || _selectedImages.Count == 0) return;

            var imgDir = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "images");
            Directory.CreateDirectory(imgDir);

            foreach (var img in _selectedImages)
            {
                var fileName = Guid.NewGuid() + Path.GetExtension(img);
                var dest = Path.Combine(imgDir, fileName);
                File.Copy(img, dest, true);
                DBHelper.AddHouseImage(_houseId.Value, dest);
            }
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnAddImage_Click(object sender, EventArgs e)
        {
            using var dlg = new OpenFileDialog();
            dlg.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            dlg.Multiselect = true;
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                foreach (var f in dlg.FileNames)
                {
                    _selectedImages.Add(f);
                    lstImages.Items.Add(Path.GetFileName(f));
                }
            }
        }
    }
}
