namespace FirstDesktopApp
{
    partial class NoteApplication
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
            cbChose = new ComboBox();
            txtNote = new TextBox();
            lblNotes = new Label();
            btnSave = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            dtNoteDate = new DateTimePicker();
            txtTitle = new TextBox();
            lblDateTime = new Label();
            lblCategory = new Label();
            lblTitle = new Label();
            lblNote = new Label();
            lbNotes = new ListBox();
            SuspendLayout();
            // 
            // cbChose
            // 
            cbChose.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbChose.BackColor = SystemColors.ButtonFace;
            cbChose.ForeColor = SystemColors.ActiveCaptionText;
            cbChose.FormattingEnabled = true;
            cbChose.Items.AddRange(new object[] { "Hatırlatmalar", "Özel Günler", "Resmi Tatiller", "Toplantılar" });
            cbChose.Location = new Point(18, 174);
            cbChose.Name = "cbChose";
            cbChose.Size = new Size(235, 40);
            cbChose.TabIndex = 0;
            cbChose.Text = "Seçiniz";
            // 
            // txtNote
            // 
            txtNote.Location = new Point(16, 308);
            txtNote.Margin = new Padding(2, 3, 2, 3);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(622, 88);
            txtNote.TabIndex = 1;
            // 
            // lblNotes
            // 
            lblNotes.AutoSize = true;
            lblNotes.Location = new Point(40, 408);
            lblNotes.Margin = new Padding(2, 0, 2, 0);
            lblNotes.Name = "lblNotes";
            lblNotes.Size = new Size(107, 32);
            lblNotes.TabIndex = 2;
            lblNotes.Text = "Notlarım";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orchid;
            btnSave.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(643, 327);
            btnSave.Margin = new Padding(2, 3, 2, 3);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(85, 46);
            btnSave.TabIndex = 5;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orchid;
            btnDelete.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(922, 655);
            btnDelete.Margin = new Padding(2, 3, 2, 3);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(85, 46);
            btnDelete.TabIndex = 7;
            btnDelete.Text = "Sil";
            btnDelete.UseVisualStyleBackColor = false;
            btnDelete.Click += btnDelete_Click;
            // 
            // dtNoteDate
            // 
            dtNoteDate.CalendarForeColor = SystemColors.ActiveCaptionText;
            dtNoteDate.CalendarMonthBackground = Color.LightGoldenrodYellow;
            dtNoteDate.CalendarTitleBackColor = Color.BlueViolet;
            dtNoteDate.Enabled = false;
            dtNoteDate.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            dtNoteDate.Location = new Point(348, 176);
            dtNoteDate.Margin = new Padding(2, 3, 2, 3);
            dtNoteDate.Name = "dtNoteDate";
            dtNoteDate.ShowCheckBox = true;
            dtNoteDate.ShowUpDown = true;
            dtNoteDate.Size = new Size(360, 39);
            dtNoteDate.TabIndex = 9;
            dtNoteDate.Value = new DateTime(2023, 8, 7, 2, 33, 4, 0);
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(16, 84);
            txtTitle.Margin = new Padding(2, 3, 2, 3);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(292, 45);
            txtTitle.TabIndex = 10;
            // 
            // lblDateTime
            // 
            lblDateTime.AutoSize = true;
            lblDateTime.Location = new Point(348, 139);
            lblDateTime.Margin = new Padding(2, 0, 2, 0);
            lblDateTime.Name = "lblDateTime";
            lblDateTime.Size = new Size(140, 32);
            lblDateTime.TabIndex = 11;
            lblDateTime.Text = "Not Takvimi";
            // 
            // lblCategory
            // 
            lblCategory.AutoSize = true;
            lblCategory.Location = new Point(18, 139);
            lblCategory.Margin = new Padding(2, 0, 2, 0);
            lblCategory.Name = "lblCategory";
            lblCategory.Size = new Size(166, 32);
            lblCategory.TabIndex = 12;
            lblCategory.Text = "Not Kategorisi";
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Location = new Point(18, 51);
            lblTitle.Margin = new Padding(2, 0, 2, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(129, 32);
            lblTitle.TabIndex = 13;
            lblTitle.Text = "Not Başlığı";
            // 
            // lblNote
            // 
            lblNote.AutoSize = true;
            lblNote.Location = new Point(18, 250);
            lblNote.Margin = new Padding(2, 0, 2, 0);
            lblNote.Name = "lblNote";
            lblNote.Size = new Size(259, 32);
            lblNote.TabIndex = 14;
            lblNote.Text = "Notunuzu Oluşturunuz";
            // 
            // lbNotes
            // 
            lbNotes.FormattingEnabled = true;
            lbNotes.ItemHeight = 32;
            lbNotes.Location = new Point(16, 443);
            lbNotes.Margin = new Padding(2, 3, 2, 3);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(901, 260);
            lbNotes.TabIndex = 15;
            // 
            // NoteApplication
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1027, 740);
            Controls.Add(lbNotes);
            Controls.Add(lblNote);
            Controls.Add(lblTitle);
            Controls.Add(lblCategory);
            Controls.Add(lblDateTime);
            Controls.Add(txtTitle);
            Controls.Add(dtNoteDate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lblNotes);
            Controls.Add(txtNote);
            Controls.Add(cbChose);
            Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            Name = "NoteApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbChose;
        private TextBox txtNote;
        private Label lblNotes;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
        private DateTimePicker dtNoteDate;
        private TextBox txtTitle;
        private Label lblDateTime;
        private Label lblCategory;
        private Label lblTitle;
        private Label lblNote;
        private ListBox lbNotes;
    }
}