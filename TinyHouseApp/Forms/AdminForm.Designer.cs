namespace TinyHouseApp.Forms
{
    partial class AdminForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabRoles;
        private System.Windows.Forms.TabPage tabUsers;
        private System.Windows.Forms.TabPage tabHouses;
        private System.Windows.Forms.TabPage tabReservations;
        private System.Windows.Forms.TabPage tabComments;

        // Rol sekmesi kontrolleri
        private System.Windows.Forms.DataGridView dgvRoles;
        private System.Windows.Forms.TextBox txtRoleName;
        private System.Windows.Forms.Button btnAddRole;
        private System.Windows.Forms.Label lblRoleName;
        private System.Windows.Forms.Panel panelRoleControls;

        // Diğer sekmeler
        private System.Windows.Forms.DataGridView dgvUsers;
        private System.Windows.Forms.DataGridView dgvHouses;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.DataGridView dgvComments;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;

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
            tabControl1 = new TabControl();
            tabRoles = new TabPage();
            panelRoleControls = new Panel();
            lblRoleName = new Label();
            txtRoleName = new TextBox();
            btnAddRole = new Button();
            dgvRoles = new DataGridView();
            tabUsers = new TabPage();
            dgvUsers = new DataGridView();
            tabHouses = new TabPage();
            dgvHouses = new DataGridView();
            tabReservations = new TabPage();
            dgvReservations = new DataGridView();
            tabComments = new TabPage();
            dgvComments = new DataGridView();
            panelHeader = new Panel();
            lblHeader = new Label();
            tabControl1.SuspendLayout();
            tabRoles.SuspendLayout();
            panelRoleControls.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).BeginInit();
            tabUsers.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvUsers).BeginInit();
            tabHouses.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvHouses).BeginInit();
            tabReservations.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            tabComments.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgvComments).BeginInit();
            panelHeader.SuspendLayout();
            SuspendLayout();
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabRoles);
            tabControl1.Controls.Add(tabUsers);
            tabControl1.Controls.Add(tabHouses);
            tabControl1.Controls.Add(tabReservations);
            tabControl1.Controls.Add(tabComments);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabControl1.ItemSize = new Size(120, 30);
            tabControl1.Location = new Point(0, 60);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(909, 484);
            tabControl1.TabIndex = 0;
            // 
            // tabRoles
            // 
            tabRoles.BackColor = Color.WhiteSmoke;
            tabRoles.Controls.Add(panelRoleControls);
            tabRoles.Controls.Add(dgvRoles);
            tabRoles.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            tabRoles.Location = new Point(4, 34);
            tabRoles.Name = "tabRoles";
            tabRoles.Padding = new Padding(5);
            tabRoles.Size = new Size(901, 446);
            tabRoles.TabIndex = 0;
            tabRoles.Text = "Roller";
            // 
            // panelRoleControls
            // 
            panelRoleControls.BackColor = Color.White;
            panelRoleControls.BorderStyle = BorderStyle.FixedSingle;
            panelRoleControls.Controls.Add(lblRoleName);
            panelRoleControls.Controls.Add(txtRoleName);
            panelRoleControls.Controls.Add(btnAddRole);
            panelRoleControls.Dock = DockStyle.Top;
            panelRoleControls.Location = new Point(5, 5);
            panelRoleControls.Name = "panelRoleControls";
            panelRoleControls.Size = new Size(891, 50);
            panelRoleControls.TabIndex = 3;
            // 
            // lblRoleName
            // 
            lblRoleName.AutoSize = true;
            lblRoleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRoleName.Location = new Point(15, 15);
            lblRoleName.Name = "lblRoleName";
            lblRoleName.Size = new Size(53, 17);
            lblRoleName.TabIndex = 3;
            lblRoleName.Text = "Rol Adı:";
            // 
            // txtRoleName
            // 
            txtRoleName.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtRoleName.Location = new Point(84, 12);
            txtRoleName.Name = "txtRoleName";
            txtRoleName.Size = new Size(250, 25);
            txtRoleName.TabIndex = 0;
            // 
            // btnAddRole
            // 
            btnAddRole.BackColor = Color.SteelBlue;
            btnAddRole.FlatAppearance.BorderSize = 0;
            btnAddRole.FlatStyle = FlatStyle.Flat;
            btnAddRole.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddRole.ForeColor = Color.White;
            btnAddRole.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddRole.Location = new Point(350, 10);
            btnAddRole.Name = "btnAddRole";
            btnAddRole.Size = new Size(120, 30);
            btnAddRole.TabIndex = 1;
            btnAddRole.Text = "   Rol Ekle";
            btnAddRole.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddRole.UseVisualStyleBackColor = false;
            btnAddRole.Click += btnAddRole_Click;
            // 
            // dgvRoles
            // 
            dgvRoles.AllowUserToAddRows = false;
            dgvRoles.AllowUserToDeleteRows = false;
            dgvRoles.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRoles.BackgroundColor = Color.White;
            dgvRoles.BorderStyle = BorderStyle.None;
            dgvRoles.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvRoles.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvRoles.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvRoles.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvRoles.DefaultCellStyle = dataGridViewCellStyle2;
            dgvRoles.Dock = DockStyle.Fill;
            dgvRoles.EnableHeadersVisualStyles = false;
            dgvRoles.GridColor = Color.Gainsboro;
            dgvRoles.Location = new Point(5, 5);
            dgvRoles.Name = "dgvRoles";
            dgvRoles.ReadOnly = true;
            dgvRoles.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvRoles.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvRoles.RowTemplate.Height = 30;
            dgvRoles.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvRoles.Size = new Size(891, 436);
            dgvRoles.TabIndex = 2;
            // 
            // tabUsers
            // 
            tabUsers.BackColor = Color.WhiteSmoke;
            tabUsers.Controls.Add(dgvUsers);
            tabUsers.Location = new Point(4, 34);
            tabUsers.Name = "tabUsers";
            tabUsers.Padding = new Padding(5);
            tabUsers.Size = new Size(992, 662);
            tabUsers.TabIndex = 1;
            tabUsers.Text = "Kullanıcılar";
            // 
            // dgvUsers
            // 
            dgvUsers.AllowUserToAddRows = false;
            dgvUsers.AllowUserToDeleteRows = false;
            dgvUsers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvUsers.BackgroundColor = Color.White;
            dgvUsers.BorderStyle = BorderStyle.None;
            dgvUsers.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvUsers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvUsers.Dock = DockStyle.Fill;
            dgvUsers.EnableHeadersVisualStyles = false;
            dgvUsers.GridColor = Color.Gainsboro;
            dgvUsers.Location = new Point(5, 5);
            dgvUsers.Name = "dgvUsers";
            dgvUsers.ReadOnly = true;
            dgvUsers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvUsers.RowTemplate.Height = 30;
            dgvUsers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvUsers.Size = new Size(982, 652);
            dgvUsers.TabIndex = 1;
            // 
            // tabHouses
            // 
            tabHouses.BackColor = Color.WhiteSmoke;
            tabHouses.Controls.Add(dgvHouses);
            tabHouses.Location = new Point(4, 34);
            tabHouses.Name = "tabHouses";
            tabHouses.Padding = new Padding(5);
            tabHouses.Size = new Size(992, 662);
            tabHouses.TabIndex = 2;
            tabHouses.Text = "Evler";
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
            dgvHouses.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHouses.Dock = DockStyle.Fill;
            dgvHouses.EnableHeadersVisualStyles = false;
            dgvHouses.GridColor = Color.Gainsboro;
            dgvHouses.Location = new Point(5, 5);
            dgvHouses.Name = "dgvHouses";
            dgvHouses.ReadOnly = true;
            dgvHouses.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvHouses.RowTemplate.Height = 30;
            dgvHouses.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHouses.Size = new Size(982, 652);
            dgvHouses.TabIndex = 1;
            // 
            // tabReservations
            // 
            tabReservations.BackColor = Color.WhiteSmoke;
            tabReservations.Controls.Add(dgvReservations);
            tabReservations.Location = new Point(4, 34);
            tabReservations.Name = "tabReservations";
            tabReservations.Padding = new Padding(5);
            tabReservations.Size = new Size(992, 662);
            tabReservations.TabIndex = 3;
            tabReservations.Text = "Rezervasyonlar";
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Dock = DockStyle.Fill;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.GridColor = Color.Gainsboro;
            dgvReservations.Location = new Point(5, 5);
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvReservations.RowTemplate.Height = 30;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(982, 652);
            dgvReservations.TabIndex = 1;
            // 
            // tabComments
            // 
            tabComments.BackColor = Color.WhiteSmoke;
            tabComments.Controls.Add(dgvComments);
            tabComments.Location = new Point(4, 34);
            tabComments.Name = "tabComments";
            tabComments.Padding = new Padding(5);
            tabComments.Size = new Size(992, 662);
            tabComments.TabIndex = 4;
            tabComments.Text = "Yorumlar";
            // 
            // dgvComments
            // 
            dgvComments.AllowUserToAddRows = false;
            dgvComments.AllowUserToDeleteRows = false;
            dgvComments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvComments.BackgroundColor = Color.White;
            dgvComments.BorderStyle = BorderStyle.None;
            dgvComments.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvComments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvComments.Dock = DockStyle.Fill;
            dgvComments.EnableHeadersVisualStyles = false;
            dgvComments.GridColor = Color.Gainsboro;
            dgvComments.Location = new Point(5, 5);
            dgvComments.Name = "dgvComments";
            dgvComments.ReadOnly = true;
            dgvComments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dgvComments.RowTemplate.Height = 30;
            dgvComments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvComments.Size = new Size(982, 652);
            dgvComments.TabIndex = 1;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(909, 60);
            panelHeader.TabIndex = 1;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(130, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Admin Paneli";
            // 
            // AdminForm
            // 
            ClientSize = new Size(909, 544);
            Controls.Add(tabControl1);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            Name = "AdminForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyHouse - Admin Paneli";
            tabControl1.ResumeLayout(false);
            tabRoles.ResumeLayout(false);
            panelRoleControls.ResumeLayout(false);
            panelRoleControls.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgvRoles).EndInit();
            tabUsers.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvUsers).EndInit();
            tabHouses.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvHouses).EndInit();
            tabReservations.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            tabComments.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dgvComments).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            ResumeLayout(false);
        }
    }
}