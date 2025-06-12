namespace TinyHouseApp.Forms
{
    partial class CommentForm
    {
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lblRating;
        private System.Windows.Forms.NumericUpDown numRating;
        private System.Windows.Forms.Label lblComment;
        private System.Windows.Forms.TextBox txtComment;
        private System.Windows.Forms.Button btnAddComment;
        private System.Windows.Forms.Panel panelHeader;
        private System.Windows.Forms.Label lblHeader;
        private System.Windows.Forms.Panel panelForm;

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
            dgvReservations = new DataGridView();
            lblRating = new Label();
            numRating = new NumericUpDown();
            lblComment = new Label();
            txtComment = new TextBox();
            btnAddComment = new Button();
            panelHeader = new Panel();
            lblHeader = new Label();
            panelForm = new Panel();
            ((System.ComponentModel.ISupportInitialize)dgvReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numRating).BeginInit();
            panelHeader.SuspendLayout();
            panelForm.SuspendLayout();
            SuspendLayout();
            // 
            // dgvReservations
            // 
            dgvReservations.AllowUserToAddRows = false;
            dgvReservations.AllowUserToDeleteRows = false;
            dgvReservations.Anchor = AnchorStyles.Top | AnchorStyles.Left | AnchorStyles.Right;
            dgvReservations.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvReservations.BackgroundColor = Color.White;
            dgvReservations.BorderStyle = BorderStyle.None;
            dgvReservations.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dgvReservations.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.SteelBlue;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle1.ForeColor = Color.White;
            dataGridViewCellStyle1.Padding = new Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = Color.SteelBlue;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dgvReservations.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dgvReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = SystemColors.Window;
            dataGridViewCellStyle2.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dgvReservations.DefaultCellStyle = dataGridViewCellStyle2;
            dgvReservations.EnableHeadersVisualStyles = false;
            dgvReservations.GridColor = Color.Gainsboro;
            dgvReservations.Location = new Point(20, 20);
            dgvReservations.MultiSelect = false;
            dgvReservations.Name = "dgvReservations";
            dgvReservations.ReadOnly = true;
            dgvReservations.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = SystemColors.Control;
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            dataGridViewCellStyle3.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = Color.LightSteelBlue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dgvReservations.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            dgvReservations.RowHeadersWidth = 62;
            dgvReservations.RowTemplate.Height = 30;
            dgvReservations.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvReservations.Size = new Size(825, 250);
            dgvReservations.TabIndex = 0;
            // 
            // lblRating
            // 
            lblRating.AutoSize = true;
            lblRating.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblRating.Location = new Point(20, 290);
            lblRating.Name = "lblRating";
            lblRating.Size = new Size(106, 28);
            lblRating.TabIndex = 1;
            lblRating.Text = "Puan (1-5):";
            // 
            // numRating
            // 
            numRating.BorderStyle = BorderStyle.FixedSingle;
            numRating.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            numRating.Location = new Point(145, 290);
            numRating.Maximum = new decimal(new int[] { 5, 0, 0, 0 });
            numRating.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            numRating.Name = "numRating";
            numRating.Size = new Size(60, 33);
            numRating.TabIndex = 2;
            numRating.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // lblComment
            // 
            lblComment.AutoSize = true;
            lblComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            lblComment.Location = new Point(20, 330);
            lblComment.Name = "lblComment";
            lblComment.Size = new Size(72, 28);
            lblComment.TabIndex = 3;
            lblComment.Text = "Yorum:";
            // 
            // txtComment
            // 
            txtComment.BorderStyle = BorderStyle.FixedSingle;
            txtComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            txtComment.Location = new Point(20, 350);
            txtComment.Multiline = true;
            txtComment.Name = "txtComment";
            txtComment.Size = new Size(830, 120);
            txtComment.TabIndex = 4;
            // 
            // btnAddComment
            // 
            btnAddComment.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            btnAddComment.BackColor = Color.SteelBlue;
            btnAddComment.FlatAppearance.BorderSize = 0;
            btnAddComment.FlatStyle = FlatStyle.Flat;
            btnAddComment.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 162);
            btnAddComment.ForeColor = Color.White;
            btnAddComment.ImageAlign = ContentAlignment.MiddleLeft;
            btnAddComment.Location = new Point(223, 290);
            btnAddComment.Name = "btnAddComment";
            btnAddComment.Size = new Size(150, 40);
            btnAddComment.TabIndex = 5;
            btnAddComment.Text = "   Yorum Ekle";
            btnAddComment.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAddComment.UseVisualStyleBackColor = false;
            btnAddComment.Click += btnAddComment_Click;
            // 
            // panelHeader
            // 
            panelHeader.BackColor = Color.SteelBlue;
            panelHeader.Controls.Add(lblHeader);
            panelHeader.Dock = DockStyle.Top;
            panelHeader.Location = new Point(0, 0);
            panelHeader.Name = "panelHeader";
            panelHeader.Size = new Size(895, 60);
            panelHeader.TabIndex = 6;
            // 
            // lblHeader
            // 
            lblHeader.AutoSize = true;
            lblHeader.Font = new Font("Segoe UI", 14F, FontStyle.Bold, GraphicsUnit.Point, 162);
            lblHeader.ForeColor = Color.White;
            lblHeader.Location = new Point(20, 18);
            lblHeader.Name = "lblHeader";
            lblHeader.Size = new Size(156, 38);
            lblHeader.TabIndex = 0;
            lblHeader.Text = "Yorum Yap";
            // 
            // panelForm
            // 
            panelForm.BackColor = Color.White;
            panelForm.Controls.Add(dgvReservations);
            panelForm.Controls.Add(lblRating);
            panelForm.Controls.Add(numRating);
            panelForm.Controls.Add(lblComment);
            panelForm.Controls.Add(txtComment);
            panelForm.Controls.Add(btnAddComment);
            panelForm.Dock = DockStyle.Fill;
            panelForm.Location = new Point(0, 60);
            panelForm.Name = "panelForm";
            panelForm.Padding = new Padding(20);
            panelForm.Size = new Size(895, 560);
            panelForm.TabIndex = 7;
            // 
            // CommentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            ClientSize = new Size(895, 620);
            Controls.Add(panelForm);
            Controls.Add(panelHeader);
            Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point, 162);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            MinimizeBox = false;
            Name = "CommentForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TinyHouse - Yorum Yap";
            ((System.ComponentModel.ISupportInitialize)dgvReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)numRating).EndInit();
            panelHeader.ResumeLayout(false);
            panelHeader.PerformLayout();
            panelForm.ResumeLayout(false);
            panelForm.PerformLayout();
            ResumeLayout(false);
        }
    }
}