namespace TinyHouseApp.Forms
{
    partial class RenterForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvHousesAvail;
        private System.Windows.Forms.Button btnReserve;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.Button btnComment;
        private System.Windows.Forms.PictureBox pbHouseImage;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RenterForm));
            dgvHousesAvail = new DataGridView();
            btnReserve = new Button();
            btnPay = new Button();
            btnComment = new Button();
            pbHouseImage = new PictureBox();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)dgvHousesAvail).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pbHouseImage).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dgvHousesAvail
            // 
            dgvHousesAvail.AllowUserToAddRows = false;
            dgvHousesAvail.AllowUserToDeleteRows = false;
            dgvHousesAvail.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dgvHousesAvail.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvHousesAvail.BackgroundColor = Color.LightGray;
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
            dgvHousesAvail.Location = new Point(14, 16);
            dgvHousesAvail.Margin = new Padding(3, 4, 3, 4);
            dgvHousesAvail.MultiSelect = false;
            dgvHousesAvail.Name = "dgvHousesAvail";
            dgvHousesAvail.ReadOnly = true;
            dgvHousesAvail.RowHeadersWidth = 51;
            dgvHousesAvail.RowTemplate.Height = 30;
            dgvHousesAvail.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvHousesAvail.Size = new Size(813, 675);
            dgvHousesAvail.TabIndex = 0;
            dgvHousesAvail.SelectionChanged += dgvHousesAvail_SelectionChanged;
            // 
            // btnReserve
            // 
            btnReserve.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            btnReserve.BackColor = Color.FromArgb(0, 123, 255);
            btnReserve.FlatStyle = FlatStyle.Flat;
            btnReserve.Font = new Font("Segoe UI", 10F, FontStyle.Bold);
            btnReserve.ForeColor = Color.White;
            btnReserve.Location = new Point(847, 173);
            btnReserve.Margin = new Padding(3, 4, 3, 4);
            btnReserve.Name = "btnReserve";
            btnReserve.Size = new Size(149, 53);
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
            btnPay.Location = new Point(847, 253);
            btnPay.Margin = new Padding(3, 4, 3, 4);
            btnPay.Name = "btnPay";
            btnPay.Size = new Size(149, 53);
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
            btnComment.Location = new Point(847, 333);
            btnComment.Margin = new Padding(3, 4, 3, 4);
            btnComment.Name = "btnComment";
            btnComment.Size = new Size(149, 53);
            btnComment.TabIndex = 3;
            btnComment.Text = "Yorum Yap";
            btnComment.UseVisualStyleBackColor = false;
            btnComment.Click += btnComment_Click;
            //
            // pbHouseImage
            //
            pbHouseImage.BorderStyle = BorderStyle.FixedSingle;
            pbHouseImage.Location = new Point(847, 16);
            pbHouseImage.Name = "pbHouseImage";
            pbHouseImage.Size = new Size(149, 140);
            pbHouseImage.SizeMode = PictureBoxSizeMode.StretchImage;
            pbHouseImage.TabIndex = 4;
            pbHouseImage.TabStop = false;
            //
            // pictureBox1
            //
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(-111, -25);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1207, 798);
            pictureBox1.TabIndex = 5;
            pictureBox1.TabStop = false;
            // 
            // RenterForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(1018, 715);
            Controls.Add(btnComment);
            Controls.Add(btnPay);
            Controls.Add(btnReserve);
            Controls.Add(pbHouseImage);
            Controls.Add(dgvHousesAvail);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Margin = new Padding(3, 4, 3, 4);
            MaximizeBox = false;
            Name = "RenterForm";
            Text = "Kiracı Paneli";
            ((System.ComponentModel.ISupportInitialize)dgvHousesAvail).EndInit();
            ((System.ComponentModel.ISupportInitialize)pbHouseImage).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }
        private PictureBox pictureBox1;
    }
}
