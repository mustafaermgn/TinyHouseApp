namespace TinyHouseApp.Forms
{
    partial class RenterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHousesAvail;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnComment;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            dgvHousesAvail = new DataGridView();
            btnReserve = new Button();
            btnPay = new Button();
            btnComment = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvHousesAvail).BeginInit();
            SuspendLayout();
            // 
            // dgvHousesAvail
            // 
            dgvHousesAvail.AllowUserToAddRows = false;
            dgvHousesAvail.AllowUserToDeleteRows = false;
            dgvHousesAvail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHousesAvail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHousesAvail.BackgroundColor = Color.White;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(240, 240, 240);
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.5F, FontStyle.Bold);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvHousesAvail.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvHousesAvail.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvHousesAvail.EnableHeadersVisualStyles = false;
            dgvHousesAvail.Font = new Font("Segoe UI", 9F);
            dgvHousesAvail.GridColor = Color.LightGray;
            dgvHousesAvail.Location = new Point(12, 12);
            dgvHousesAvail.MultiSelect = false;
            dgvHousesAvail.Name = "dgvHousesAvail";
            dgvHousesAvail.ReadOnly = true;
            dgvHousesAvail.RowTemplate.Height = 30;
            dgvHousesAvail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHousesAvail.Size = new Size(711, 506);
            dgvHousesAvail.TabIndex = 0;
            // 
            // btnReserve
            // 
            btnReserve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReserve.BackColor = Color.FromArgb(0, 123, 255);
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReserve.ForeColor = Color.White;
            btnReserve.Location = new Point(741, 130);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(130, 40);
            btnReserve.TabIndex = 1;
            btnReserve.Text = "Rezervasyon Yap";
            btnReserve.UseVisualStyleBackColor = false;
            btnReserve.Click += btnReserve_Click;
            // 
            // btnPay
            // 
            btnPay.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnPay.BackColor = Color.FromArgb(40, 167, 69);
            btnPay.FlatStyle = FlatStyle.Flat;
            btnPay.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnPay.ForeColor = Color.White;
            btnPay.Location = new Point(741, 190);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(130, 40);
            btnPay.TabIndex = 2;
            btnPay.Text = "Ödeme Yap";
            btnPay.UseVisualStyleBackColor = false;
            btnPay.Click += btnPay_Click;
            // 
            // btnComment
            // 
            btnComment.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnComment.BackColor = Color.FromArgb(255, 193, 7);
            btnComment.FlatStyle = FlatStyle.Flat;
            btnComment.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnComment.ForeColor = Color.Black;
            btnComment.Location = new Point(741, 250);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(130, 40);
            btnComment.TabIndex = 3;
            btnComment.Text = "Yorum Yap";
            btnComment.UseVisualStyleBackColor = false;
            btnComment.Click += btnComment_Click;
            // 
            // RenterForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(891, 536);
            Controls.Add(btnComment);
            Controls.Add(btnPay);
            Controls.Add(btnReserve);
            Controls.Add(dgvHousesAvail);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            Name = "RenterForm";
            Text = "Kiracı Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvHousesAvail).EndInit();
            ResumeLayout(false);
        }

    }
}
