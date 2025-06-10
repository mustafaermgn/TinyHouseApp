namespace TinyHouseApp.Forms
{
    partial class HouseForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.Label lblDesc;
        private System.Windows.Forms.TextBox txtDesc;
        private System.Windows.Forms.Label lblPrice;
        private System.Windows.Forms.NumericUpDown numPrice;
        private System.Windows.Forms.Label lblLocation;
        private System.Windows.Forms.TextBox txtLocation;
        private System.Windows.Forms.CheckBox chkActive;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelForm;
        private System.Windows.Forms.Panel panelFooter;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            lblTitle = new Label();
            txtTitle = new TextBox();
            lblDesc = new Label();
            txtDesc = new TextBox();
            lblPrice = new Label();
            numPrice = new NumericUpDown();
            lblLocation = new Label();
            txtLocation = new TextBox();
            chkActive = new CheckBox();
            btnSave = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelForm = new Panel();
            panelFooter = new Panel();
            ((System.ComponentModel.ISupportInitialize)numPrice).BeginInit();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblTitle.Location = new Point(259, 70);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(43, 17);
            lblTitle.TabIndex = 0;
            lblTitle.Text = "Başlık:";
            // 
            // txtTitle
            // 
            txtTitle.BorderStyle = BorderStyle.FixedSingle;
            txtTitle.Font = new Font("Segoe UI", 9.75F);
            txtTitle.Location = new Point(359, 67);
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(300, 25);
            txtTitle.TabIndex = 1;
            // 
            // lblDesc
            // 
            lblDesc.AutoSize = true;
            lblDesc.Font = new Font("Segoe UI", 9.75F);
            lblDesc.Location = new Point(259, 110);
            lblDesc.Name = "lblDesc";
            lblDesc.Size = new Size(62, 17);
            lblDesc.TabIndex = 2;
            lblDesc.Text = "Açıklama:";
            // 
            // txtDesc
            // 
            txtDesc.BorderStyle = BorderStyle.FixedSingle;
            txtDesc.Font = new Font("Segoe UI", 9.75F);
            txtDesc.Location = new Point(359, 107);
            txtDesc.Multiline = true;
            txtDesc.Name = "txtDesc";
            txtDesc.ScrollBars = ScrollBars.Vertical;
            txtDesc.Size = new Size(300, 100);
            txtDesc.TabIndex = 3;
            // 
            // lblPrice
            // 
            lblPrice.AutoSize = true;
            lblPrice.Font = new Font("Segoe UI", 9.75F);
            lblPrice.Location = new Point(259, 230);
            lblPrice.Name = "lblPrice";
            lblPrice.Size = new Size(83, 17);
            lblPrice.TabIndex = 4;
            lblPrice.Text = "Fiyat/Gecelik:";
            // 
            // numPrice
            // 
            numPrice.BorderStyle = BorderStyle.FixedSingle;
            numPrice.DecimalPlaces = 2;
            numPrice.Font = new Font("Segoe UI", 9.75F);
            numPrice.Location = new Point(359, 228);
            numPrice.Maximum = new decimal(new int[] { 10000, 0, 0, 0 });
            numPrice.Name = "numPrice";
            numPrice.Size = new Size(120, 25);
            numPrice.TabIndex = 5;
            // 
            // lblLocation
            // 
            lblLocation.AutoSize = true;
            lblLocation.Font = new Font("Segoe UI", 9.75F);
            lblLocation.Location = new Point(259, 270);
            lblLocation.Name = "lblLocation";
            lblLocation.Size = new Size(52, 17);
            lblLocation.TabIndex = 6;
            lblLocation.Text = "Konum:";
            // 
            // txtLocation
            // 
            txtLocation.BorderStyle = BorderStyle.FixedSingle;
            txtLocation.Font = new Font("Segoe UI", 9.75F);
            txtLocation.Location = new Point(359, 267);
            txtLocation.Name = "txtLocation";
            txtLocation.Size = new Size(300, 25);
            txtLocation.TabIndex = 7;
            // 
            // chkActive
            // 
            chkActive.AutoSize = true;
            chkActive.Font = new Font("Segoe UI", 9.75F);
            chkActive.Location = new Point(561, 313);
            chkActive.Name = "chkActive";
            chkActive.Size = new Size(76, 21);
            chkActive.TabIndex = 8;
            chkActive.Text = "Aktif mi?";
            chkActive.CheckedChanged += chkActive_CheckedChanged;
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.SteelBlue;
            btnSave.FlatAppearance.BorderSize = 0;
            btnSave.FlatStyle = FlatStyle.Flat;
            btnSave.Font = new Font("Segoe UI", 9.75F);
            btnSave.ForeColor = Color.White;
            btnSave.ImageAlign = ContentAlignment.MiddleLeft;
            btnSave.Location = new Point(409, 302);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(120, 40);
            btnSave.TabIndex = 0;
            btnSave.Text = "   Kaydet";
            btnSave.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(892, 60);
            panelHeader.TabIndex = 2;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(104, 25);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Ev Bilgileri";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(btnSave);
            panelForm.Controls.Add(lblTitle);
            panelForm.Controls.Add(txtTitle);
            panelForm.Controls.Add(lblDesc);
            panelForm.Controls.Add(txtDesc);
            panelForm.Controls.Add(lblPrice);
            panelForm.Controls.Add(numPrice);
            panelForm.Controls.Add(lblLocation);
            panelForm.Controls.Add(txtLocation);
            panelForm.Controls.Add(chkActive);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(892, 408);
            panelForm.TabIndex = 0;
            // 
            // panelFooter
            // 
            panelFooter.BackColor = Color.WhiteSmoke;
            panelFooter.Dock = DockStyle.Bottom;
            panelFooter.Location = new Point(0, 468);
            panelFooter.Name = "panelFooter";
            panelFooter.Size = new Size(892, 70);
            panelFooter.TabIndex = 1;
            // 
            // HouseForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(892, 538);
            Controls.Add(panelForm);
            Controls.Add(panelFooter);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9.75F);
            MinimumSize = new Size(450, 450);
            Name = "HouseForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyHouse - Ev Bilgileri";
            ((System.ComponentModel.ISupportInitialize)numPrice).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}