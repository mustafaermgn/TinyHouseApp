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
            dgvHouses = new DataGridView();
            btnAddHouse = new Button();
            btnEditHouse = new Button();
            btnDeleteHouse = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelControls = new Panel();
            panelGrid = new Panel();
            btnDetay = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHouses).BeginInit();
            panelHeader.SuspendLayout();
            panelControls.SuspendLayout();
            panelGrid.SuspendLayout();
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
            dgvHouses.Size = new Size(694, 501);
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
            panelHeader.Size = new Size(894, 60);
            panelHeader.TabIndex = 4;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(165, 38);
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
            panelControls.Dock = DockStyle.Right;
            panelControls.Location = new Point(694, 60);
            panelControls.Name = "panelControls";
            panelControls.Size = new Size(200, 501);
            panelControls.TabIndex = 5;
            // 
            // panelGrid
            // 
            panelGrid.Controls.Add(dgvHouses);
            panelGrid.Dock = DockStyle.Fill;
            panelGrid.Location = new Point(0, 60);
            panelGrid.Name = "panelGrid";
            panelGrid.Size = new Size(694, 501);
            panelGrid.TabIndex = 6;
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
            // HostForm
            // 
            BackColor = Color.White;
            ClientSize = new Size(894, 561);
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
            ResumeLayout(false);
        }
        private Button btnDetay;
    }
}