namespace TinyHouseApp.Forms
{
    partial class HostForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHouses;
        private System.Windows.Forms.Button btnAddHouse;
        private System.Windows.Forms.Button btnEditHouse;
        private System.Windows.Forms.Button btnDeleteHouse;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelControls;
        private System.Windows.Forms.Panel panelGrid;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HostForm));
            dgvHouses = new DataGridView();
            btnAddHouse = new Button();
            btnEditHouse = new Button();
            btnDeleteHouse = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelControls = new Panel();
            btnDetay = new Button();
            panelGrid = new Panel();
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHouses).BeginInit();
            panelHeader.SuspendLayout();
            panelControls.SuspendLayout();
            panelGrid.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            SuspendLayout();
            // 
            // dgvHouses
            // 
            dgvHouses.AllowUserToAddRows = false;
            dgvHouses.AllowUserToDeleteRows = false;
            dgvHouses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHouses.BackgroundColor = Color.White;
            dgvHouses.BorderStyle = BorderStyle.None;
            dgvHouses.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvHouses.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHouses.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvHouses.DefaultCellStyle = dataGridViewCellStyle2;
            dgvHouses.Dock = DockStyle.Fill;
            dgvHouses.EnableHeadersVisualStyles = false;
            dgvHouses.GridColor = Color.Gainsboro;
            dgvHouses.Location = new Point(0, 0);
            dgvHouses.Name = "dgvHouses";
            dgvHouses.ReadOnly = true;
            dgvHouses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvHouses.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvHouses.RowHeadersWidth = 62;
            dgvHouses.RowTemplate.Height = 30;
            dgvHouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHouses.Size = new Size(866, 540);
            dgvHouses.TabIndex = 0;
            // 
            // btnAddHouse
            // 
            btnAddHouse.BackColor = Color.SteelBlue;
            btnAddHouse.FlatAppearance.BorderSize = 0;
            btnAddHouse.FlatStyle = FlatStyle.Flat;
            btnAddHouse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddHouse.ForeColor = Color.White;
            btnAddHouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddHouse.Location = new Point(20, 20);
            btnAddHouse.Name = "btnAddHouse";
            btnAddHouse.Size = new Size(150, 40);
            btnAddHouse.TabIndex = 1;
            btnAddHouse.Text = "   Ev Ekle";
            btnAddHouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddHouse.UseVisualStyleBackColor = false;
            btnAddHouse.Click += btnAddHouse_Click;
            // 
            // btnEditHouse
            // 
            btnEditHouse.BackColor = Color.SteelBlue;
            btnEditHouse.FlatAppearance.BorderSize = 0;
            btnEditHouse.FlatStyle = FlatStyle.Flat;
            btnEditHouse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnEditHouse.ForeColor = Color.White;
            btnEditHouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditHouse.Location = new Point(20, 80);
            btnEditHouse.Name = "btnEditHouse";
            btnEditHouse.Size = new Size(150, 40);
            btnEditHouse.TabIndex = 2;
            btnEditHouse.Text = "   Düzenle";
            btnEditHouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnEditHouse.UseVisualStyleBackColor = false;
            btnEditHouse.Click += btnEditHouse_Click;
            // 
            // btnDeleteHouse
            // 
            btnDeleteHouse.BackColor = Color.Firebrick;
            btnDeleteHouse.FlatAppearance.BorderSize = 0;
            btnDeleteHouse.FlatStyle = FlatStyle.Flat;
            btnDeleteHouse.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnDeleteHouse.ForeColor = Color.White;
            btnDeleteHouse.ImageAlign = ContentAlignment.MiddleLeft;
            btnDeleteHouse.Location = new Point(20, 140);
            btnDeleteHouse.Name = "btnDeleteHouse";
            btnDeleteHouse.Size = new Size(150, 40);
            btnDeleteHouse.TabIndex = 3;
            btnDeleteHouse.Text = "   Sil";
            btnDeleteHouse.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnDeleteHouse.UseVisualStyleBackColor = false;
            btnDeleteHouse.Click += btnDeleteHouse_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(1060, 74);
            panelHeader.TabIndex = 4;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(12, 19);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(143, 32);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Host Paneli";
            // 
            // panelControls
            // 
            panelControls.BackColor = Color.WhiteSmoke;
            panelControls.Controls.Add(btnDetay);
            panelControls.Controls.Add(btnAddHouse);
            panelControls.Controls.Add(btnEditHouse);
            panelControls.Controls.Add(btnDeleteHouse);
            panelControls.Controls.Add(pictureBox2);
            panelControls.Controls.Add(pictureBox3);
            panelControls.Dock = DockStyle.Right;
            panelControls.Location = new Point(866, 74);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(194, 540);
            panelControls.TabIndex = 5;
            // 
            // btnDetay
            // 
            btnDetay.BackColor = Color.GreenYellow;
            btnDetay.Location = new Point(20, 200);
            btnDetay.Name = "btnDetay";
            btnDetay.Size = new Size(150, 40);
            btnDetay.TabIndex = 4;
            btnDetay.Text = "Detay Getir";
            btnDetay.UseVisualStyleBackColor = false;
            btnDetay.Click += btnDetay_Click;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvHouses);
            panelGrid.Controls.Add(pictureBox1);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 74);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(866, 540);
            panelGrid.TabIndex = 6;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(515, 49);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(662, 392);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.Image = (Image)resources.GetObject("pictureBox2.Image");
            pictureBox2.Location = new Point(0, 158);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(245, 406);
            pictureBox2.TabIndex = 5;
            pictureBox2.TabStop = false;
            pictureBox2.Click += pictureBox2_Click;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = (Image)resources.GetObject("pictureBox3.Image");
            pictureBox3.Location = new Point(0, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(228, 167);
            pictureBox3.TabIndex = 6;
            pictureBox3.TabStop = false;
            // 
            // HostForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(1060, 614);
            Controls.Add(panelGrid);
            Controls.Add(panelControls);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            MinimumSize = new Size(800, 600);
            Name = "HostForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyHouse - Host Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvHouses).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelControls.ResumeLayout(false);
            panelGrid.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ResumeLayout(false);
        }
        private Button btnDetay;
        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
    }
}