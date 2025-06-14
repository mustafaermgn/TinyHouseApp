namespace TinyHouseApp.Forms
{
    partial class ReservationForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.Label lblStartDate;
        private System.Windows.Forms.DateTimePicker dtpStart;
        private System.Windows.Forms.Label lblEndDate;
        private System.Windows.Forms.DateTimePicker dtpEnd;
        private System.Windows.Forms.Button btnReserve;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReservationForm));
            lblStartDate = new Label();
            dtpStart = new DateTimePicker();
            lblEndDate = new Label();
            dtpEnd = new DateTimePicker();
            btnReserve = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(25, 25);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(85, 23);
            lblStartDate.TabIndex = 0;
            lblStartDate.Text = "Başlangıç:";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(120, 22);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(190, 30);
            dtpStart.TabIndex = 0;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(25, 70);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(45, 23);
            lblEndDate.TabIndex = 1;
            lblEndDate.Text = "Bitiş:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(120, 67);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(190, 30);
            dtpEnd.TabIndex = 1;
            // 
            // btnReserve
            // 
            btnReserve.BackColor = Color.FromArgb(0, 123, 255);
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReserve.ForeColor = Color.White;
            btnReserve.Location = new Point(120, 110);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(190, 35);
            btnReserve.TabIndex = 2;
            btnReserve.Text = "Rezerve Et";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-25, -95);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(442, 371);
            pictureBox1.TabIndex = 3;
            pictureBox1.TabStop = false;
            // 
            // ReservationForm
            // 
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(350, 180);
            Controls.Add(lblStartDate);
            Controls.Add(dtpStart);
            Controls.Add(lblEndDate);
            Controls.Add(dtpEnd);
            Controls.Add(btnReserve);
            Controls.Add(pictureBox1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "ReservationForm";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Rezervasyon Yap";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }
        private PictureBox pictureBox1;
    }
}
