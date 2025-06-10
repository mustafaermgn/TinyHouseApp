namespace TinyHouseApp.Forms
{
    partial class PaymentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Label lblInfo;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            dgvReservations = new DataGridView();
            btnPay = new Button();
            lblInfo = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            SuspendLayout();

            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvReservations.Location = new Point(12, 12);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(880, 460);
            dgvReservations.TabIndex = 0;
            dgvReservations.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            dgvReservations.RowTemplate.Height = 30;
            dgvReservations.BackgroundColor = System.Drawing.Color.White;
            dgvReservations.GridColor = System.Drawing.Color.LightGray;
            dgvReservations.BorderStyle = BorderStyle.FixedSingle;
            dgvReservations.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.FromArgb(240, 240, 240);
            dgvReservations.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Segoe UI", 9.5F, System.Drawing.FontStyle.Bold);
            dgvReservations.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dgvReservations.EnableHeadersVisualStyles = false;

            // 
            // lblInfo
            // 
            lblInfo.AutoSize = true;
            lblInfo.Location = new Point(12, 485);
            lblInfo.Name = "lblInfo";
            lblInfo.Size = new Size(350, 20);
            lblInfo.TabIndex = 1;
            lblInfo.Text = "Seçili rezervasyonun toplam tutarı otomatik hesaplanır.";
            lblInfo.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Italic);
            lblInfo.ForeColor = System.Drawing.Color.DimGray;

            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnPay.Location = new Point(792, 480);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(100, 35);
            btnPay.TabIndex = 2;
            btnPay.Text = "Öde";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.BackColor = System.Drawing.Color.FromArgb(0, 123, 255);
            btnPay.ForeColor = System.Drawing.Color.White;
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new System.Drawing.Font("Segoe UI", 10F, System.Drawing.FontStyle.Bold);
            btnPay.Click += btnPay_Click;

            // 
            // PaymentForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(904, 530);
            Controls.Add(btnPay);
            Controls.Add(lblInfo);
            Controls.Add(dgvReservations);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "PaymentForm";
            Text = "Ödeme Yap";
            BackColor = System.Drawing.Color.WhiteSmoke;

            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

    }
}
