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
            lblStartDate = new Label();
            dtpStart = new DateTimePicker();
            lblEndDate = new Label();
            dtpEnd = new DateTimePicker();
            btnReserve = new Button();
            SuspendLayout();

            // 
            // ReservationForm
            // 
            ClientSize = new Size(350, 180);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            StartPosition = FormStartPosition.CenterParent;
            Name = "ReservationForm";
            Text = "Rezervasyon Yap";
            BackColor = Color.WhiteSmoke;
            Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);

            // 
            // lblStartDate
            // 
            lblStartDate.AutoSize = true;
            lblStartDate.Location = new Point(25, 25);
            lblStartDate.Name = "lblStartDate";
            lblStartDate.Size = new Size(70, 19);
            lblStartDate.Text = "Başlangıç:";
            // 
            // dtpStart
            // 
            dtpStart.Format = DateTimePickerFormat.Short;
            dtpStart.Location = new Point(120, 22);
            dtpStart.Name = "dtpStart";
            dtpStart.Size = new Size(190, 25);
            dtpStart.TabIndex = 0;
            // 
            // lblEndDate
            // 
            lblEndDate.AutoSize = true;
            lblEndDate.Location = new Point(25, 70);
            lblEndDate.Name = "lblEndDate";
            lblEndDate.Size = new Size(31, 19);
            lblEndDate.Text = "Bitiş:";
            // 
            // dtpEnd
            // 
            dtpEnd.Format = DateTimePickerFormat.Short;
            dtpEnd.Location = new Point(120, 67);
            dtpEnd.Name = "dtpEnd";
            dtpEnd.Size = new Size(190, 25);
            dtpEnd.TabIndex = 1;
            // 
            // btnReserve
            // 
            btnReserve.Location = new Point(120, 110);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(190, 35);
            btnReserve.TabIndex = 2;
            btnReserve.Text = "Rezerve Et";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.BackColor = Color.FromArgb(0, 123, 255);
            btnReserve.ForeColor = Color.White;
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Segoe UI", 11F, FontStyle.Bold);
            btnReserve.Click += btnReserve_Click;

            // 
            // Add controls
            // 
            Controls.Add(lblStartDate);
            Controls.Add(dtpStart);
            Controls.Add(lblEndDate);
            Controls.Add(dtpEnd);
            Controls.Add(btnReserve);

            ResumeLayout(false);
            PerformLayout();
        }

    }
}
