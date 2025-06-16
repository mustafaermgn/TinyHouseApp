using System;
using System.Data;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Microsoft.Data.SqlClient;
using TinyHouseApp.Helpers;

namespace TinyHouseApp.Forms
{
    public partial class HouseForm : Form
    {
        private int _ownerId;
        private int? _houseId;
        private string _imagePath;

        public HouseForm(int ownerId, int? houseId = null)
        {
            InitializeComponent();
            _ownerId = ownerId;
            _houseId = houseId;
            _imagePath = null;

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

            var imgs = DBHelper.GetHouseImages(_houseId.Value);
            if (imgs.Rows.Count > 0)
            {
                _imagePath = imgs.Rows[0]["ImagePath"].ToString();
                if (File.Exists(_imagePath))
                {
                    pbPreview.Image = Image.FromFile(_imagePath);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var title = txtTitle.Text.Trim();
            var desc = txtDesc.Text.Trim();
            var price = numPrice.Value;
            var loc = txtLocation.Text.Trim();
            var active = chkActive.Checked;

            int houseId;
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
                houseId = _houseId.Value;
            }
            else
            {
                object obj = DBHelper.ExecuteScalar(@"
                    INSERT INTO Houses(OwnerID,Title,Description,PricePerNight,Location,IsActive)
                    VALUES(@o,@t,@d,@p,@l,@a); SELECT SCOPE_IDENTITY();",
                    new SqlParameter("@o", _ownerId),
                    new SqlParameter("@t", title),
                    new SqlParameter("@d", desc),
                    new SqlParameter("@p", price),
                    new SqlParameter("@l", loc),
                    new SqlParameter("@a", active)
                );
                houseId = Convert.ToInt32(obj);
            }

            if (!string.IsNullOrEmpty(_imagePath))
            {
                DBHelper.AddHouseImage(houseId, _imagePath);
            }

            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void chkActive_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panelFooter_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {
            using (var ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;*.gif|All Files|*.*";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    _imagePath = ofd.FileName;
                    if (File.Exists(_imagePath))
                    {
                        pbPreview.Image = Image.FromFile(_imagePath);
                    }
                }
            }
        }
    }
}
