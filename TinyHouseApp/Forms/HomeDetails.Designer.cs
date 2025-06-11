namespace TinyHouseApp.Forms
{
    partial class HomeDetails
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dgwReservations = new DataGridView();
            reservationIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            houseIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            renterIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            startDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            endDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            statusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            paymentStatusDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationBindingSource = new BindingSource(components);
            dgwComments = new DataGridView();
            commentIDDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            reservationIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            renterIDDataGridViewTextBoxColumn1 = new DataGridViewTextBoxColumn();
            ratingDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentTextDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentDateDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            commentBindingSource = new BindingSource(components);
            label1 = new Label();
            label2 = new Label();
            btnAccept = new Button();
            btnDecline = new Button();
            btnComments = new Button();
            ((System.ComponentModel.ISupportInitialize)dgwReservations).BeginInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dgwComments).BeginInit();
            ((System.ComponentModel.ISupportInitialize)commentBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dgwReservations
            // 
            dgwReservations.AutoGenerateColumns = false;
            dgwReservations.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwReservations.Columns.AddRange(new DataGridViewColumn[] { reservationIDDataGridViewTextBoxColumn, houseIDDataGridViewTextBoxColumn, renterIDDataGridViewTextBoxColumn, startDateDataGridViewTextBoxColumn, endDateDataGridViewTextBoxColumn, statusDataGridViewTextBoxColumn, paymentStatusDataGridViewTextBoxColumn });
            dgwReservations.DataSource = reservationBindingSource;
            dgwReservations.Location = new Point(12, 42);
            dgwReservations.Name = "dgwReservations";
            dgwReservations.RowHeadersWidth = 62;
            dgwReservations.Size = new Size(1115, 361);
            dgwReservations.TabIndex = 0;
            // 
            // reservationIDDataGridViewTextBoxColumn
            // 
            reservationIDDataGridViewTextBoxColumn.DataPropertyName = "ReservationID";
            reservationIDDataGridViewTextBoxColumn.HeaderText = "ReservationID";
            reservationIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            reservationIDDataGridViewTextBoxColumn.Name = "reservationIDDataGridViewTextBoxColumn";
            reservationIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // houseIDDataGridViewTextBoxColumn
            // 
            houseIDDataGridViewTextBoxColumn.DataPropertyName = "HouseID";
            houseIDDataGridViewTextBoxColumn.HeaderText = "HouseID";
            houseIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            houseIDDataGridViewTextBoxColumn.Name = "houseIDDataGridViewTextBoxColumn";
            houseIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // renterIDDataGridViewTextBoxColumn
            // 
            renterIDDataGridViewTextBoxColumn.DataPropertyName = "RenterID";
            renterIDDataGridViewTextBoxColumn.HeaderText = "RenterID";
            renterIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            renterIDDataGridViewTextBoxColumn.Name = "renterIDDataGridViewTextBoxColumn";
            renterIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // startDateDataGridViewTextBoxColumn
            // 
            startDateDataGridViewTextBoxColumn.DataPropertyName = "StartDate";
            startDateDataGridViewTextBoxColumn.HeaderText = "StartDate";
            startDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            startDateDataGridViewTextBoxColumn.Name = "startDateDataGridViewTextBoxColumn";
            startDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // endDateDataGridViewTextBoxColumn
            // 
            endDateDataGridViewTextBoxColumn.DataPropertyName = "EndDate";
            endDateDataGridViewTextBoxColumn.HeaderText = "EndDate";
            endDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            endDateDataGridViewTextBoxColumn.Name = "endDateDataGridViewTextBoxColumn";
            endDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // statusDataGridViewTextBoxColumn
            // 
            statusDataGridViewTextBoxColumn.DataPropertyName = "Status";
            statusDataGridViewTextBoxColumn.HeaderText = "Status";
            statusDataGridViewTextBoxColumn.MinimumWidth = 8;
            statusDataGridViewTextBoxColumn.Name = "statusDataGridViewTextBoxColumn";
            statusDataGridViewTextBoxColumn.Width = 150;
            // 
            // paymentStatusDataGridViewTextBoxColumn
            // 
            paymentStatusDataGridViewTextBoxColumn.DataPropertyName = "PaymentStatus";
            paymentStatusDataGridViewTextBoxColumn.HeaderText = "PaymentStatus";
            paymentStatusDataGridViewTextBoxColumn.MinimumWidth = 8;
            paymentStatusDataGridViewTextBoxColumn.Name = "paymentStatusDataGridViewTextBoxColumn";
            paymentStatusDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationBindingSource
            // 
            reservationBindingSource.DataSource = typeof(Models.Reservation);
            // 
            // dgwComments
            // 
            dgwComments.AutoGenerateColumns = false;
            dgwComments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgwComments.Columns.AddRange(new DataGridViewColumn[] { commentIDDataGridViewTextBoxColumn, reservationIDDataGridViewTextBoxColumn1, renterIDDataGridViewTextBoxColumn1, ratingDataGridViewTextBoxColumn, commentTextDataGridViewTextBoxColumn, commentDateDataGridViewTextBoxColumn });
            dgwComments.DataSource = commentBindingSource;
            dgwComments.Location = new Point(12, 454);
            dgwComments.Name = "dgwComments";
            dgwComments.RowHeadersWidth = 62;
            dgwComments.Size = new Size(965, 303);
            dgwComments.TabIndex = 1;
            // 
            // commentIDDataGridViewTextBoxColumn
            // 
            commentIDDataGridViewTextBoxColumn.DataPropertyName = "CommentID";
            commentIDDataGridViewTextBoxColumn.HeaderText = "CommentID";
            commentIDDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentIDDataGridViewTextBoxColumn.Name = "commentIDDataGridViewTextBoxColumn";
            commentIDDataGridViewTextBoxColumn.Width = 150;
            // 
            // reservationIDDataGridViewTextBoxColumn1
            // 
            reservationIDDataGridViewTextBoxColumn1.DataPropertyName = "ReservationID";
            reservationIDDataGridViewTextBoxColumn1.HeaderText = "ReservationID";
            reservationIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            reservationIDDataGridViewTextBoxColumn1.Name = "reservationIDDataGridViewTextBoxColumn1";
            reservationIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // renterIDDataGridViewTextBoxColumn1
            // 
            renterIDDataGridViewTextBoxColumn1.DataPropertyName = "RenterID";
            renterIDDataGridViewTextBoxColumn1.HeaderText = "RenterID";
            renterIDDataGridViewTextBoxColumn1.MinimumWidth = 8;
            renterIDDataGridViewTextBoxColumn1.Name = "renterIDDataGridViewTextBoxColumn1";
            renterIDDataGridViewTextBoxColumn1.Width = 150;
            // 
            // ratingDataGridViewTextBoxColumn
            // 
            ratingDataGridViewTextBoxColumn.DataPropertyName = "Rating";
            ratingDataGridViewTextBoxColumn.HeaderText = "Rating";
            ratingDataGridViewTextBoxColumn.MinimumWidth = 8;
            ratingDataGridViewTextBoxColumn.Name = "ratingDataGridViewTextBoxColumn";
            ratingDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentTextDataGridViewTextBoxColumn
            // 
            commentTextDataGridViewTextBoxColumn.DataPropertyName = "CommentText";
            commentTextDataGridViewTextBoxColumn.HeaderText = "CommentText";
            commentTextDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentTextDataGridViewTextBoxColumn.Name = "commentTextDataGridViewTextBoxColumn";
            commentTextDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentDateDataGridViewTextBoxColumn
            // 
            commentDateDataGridViewTextBoxColumn.DataPropertyName = "CommentDate";
            commentDateDataGridViewTextBoxColumn.HeaderText = "CommentDate";
            commentDateDataGridViewTextBoxColumn.MinimumWidth = 8;
            commentDateDataGridViewTextBoxColumn.Name = "commentDateDataGridViewTextBoxColumn";
            commentDateDataGridViewTextBoxColumn.Width = 150;
            // 
            // commentBindingSource
            // 
            commentBindingSource.DataSource = typeof(Models.Comment);
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI Black", 18F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(360, -9);
            label1.Name = "label1";
            label1.Size = new Size(433, 48);
            label1.TabIndex = 2;
            label1.Text = "REZARVASYON LİSTESİ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI Black", 16F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label2.Location = new Point(453, 406);
            label2.Name = "label2";
            label2.Size = new Size(167, 45);
            label2.TabIndex = 3;
            label2.Text = "Yorumlar";
            // 
            // btnAccept
            // 
            btnAccept.BackColor = Color.LimeGreen;
            btnAccept.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnAccept.ForeColor = SystemColors.ActiveCaptionText;
            btnAccept.Location = new Point(1178, 65);
            btnAccept.Name = "btnAccept";
            btnAccept.Size = new Size(125, 53);
            btnAccept.TabIndex = 4;
            btnAccept.Text = "Onayla";
            btnAccept.UseVisualStyleBackColor = false;
            btnAccept.Click += btnAccept_Click;
            // 
            // btnDecline
            // 
            btnDecline.BackColor = Color.DarkRed;
            btnDecline.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnDecline.ForeColor = SystemColors.ActiveCaptionText;
            btnDecline.Location = new Point(1178, 124);
            btnDecline.Name = "btnDecline";
            btnDecline.Size = new Size(125, 47);
            btnDecline.TabIndex = 5;
            btnDecline.Text = "Reddet";
            btnDecline.UseVisualStyleBackColor = false;
            btnDecline.Click += btnDecline_Click;
            // 
            // btnComments
            // 
            btnComments.BackColor = SystemColors.Highlight;
            btnComments.Font = new Font("Segoe UI Black", 9F, FontStyle.Bold, GraphicsUnit.Point, 162);
            btnComments.Location = new Point(1178, 177);
            btnComments.Name = "btnComments";
            btnComments.Size = new Size(125, 47);
            btnComments.TabIndex = 6;
            btnComments.Text = "Yorumlar";
            btnComments.UseVisualStyleBackColor = false;
            btnComments.Click += btnComments_Click;
            // 
            // HomeDetails
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1373, 775);
            Controls.Add(btnComments);
            Controls.Add(btnDecline);
            Controls.Add(btnAccept);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dgwComments);
            Controls.Add(dgwReservations);
            Name = "HomeDetails";
            Text = "HomeDetails";
            ((System.ComponentModel.ISupportInitialize)dgwReservations).EndInit();
            ((System.ComponentModel.ISupportInitialize)reservationBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dgwComments).EndInit();
            ((System.ComponentModel.ISupportInitialize)commentBindingSource).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dgwReservations;
        private DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn houseIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn startDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn endDateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn statusDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn paymentStatusDataGridViewTextBoxColumn;
        private BindingSource reservationBindingSource;
        private DataGridView dgwComments;
        private DataGridViewTextBoxColumn commentIDDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn reservationIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn renterIDDataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn ratingDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentTextDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn commentDateDataGridViewTextBoxColumn;
        private BindingSource commentBindingSource;
        private Label label1;
        private Label label2;
        private Button btnAccept;
        private Button btnDecline;
        private Button btnComments;
    }
}