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
            cbchose = new ComboBox();
            txtNote = new TextBox();
            lbNote = new Label();
            btnSave = new Button();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            btnDelete = new Button();
            dtNoteDate = new DateTimePicker();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            lbNotes = new ListBox();
            SuspendLayout();
            // 
            // cbchose
            // 
            cbchose.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbchose.BackColor = SystemColors.ButtonFace;
            cbchose.ForeColor = SystemColors.ActiveCaptionText;
            cbchose.FormattingEnabled = true;
            cbchose.Items.AddRange(new object[] { "Hatırlatmalar", "Özel Günler", "Resmi Tatiller", "Toplantılar" });
            cbchose.Location = new Point(25, 245);
            cbchose.Margin = new Padding(5);
            cbchose.Name = "cbchose";
            cbchose.Size = new Size(324, 53);
            cbchose.TabIndex = 0;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(25, 401);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(860, 123);
            txtNote.TabIndex = 1;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(25, 574);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(145, 45);
            lbNote.TabIndex = 2;
            lbNote.Text = "Notlarım";
            // 
            // btnSave
            // 
            btnSave.BackColor = Color.Orchid;
            btnSave.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnSave.ForeColor = SystemColors.ButtonHighlight;
            btnSave.Location = new Point(891, 459);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(118, 65);
            btnSave.TabIndex = 5;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // btnDelete
            // 
            btnDelete.BackColor = Color.Orchid;
            btnDelete.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            btnDelete.ForeColor = SystemColors.ButtonHighlight;
            btnDelete.Location = new Point(1277, 921);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(117, 65);
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
            dtNoteDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Point);
            dtNoteDate.Location = new Point(483, 248);
            dtNoteDate.Name = "dtNoteDate";
            dtNoteDate.ShowCheckBox = true;
            dtNoteDate.ShowUpDown = true;
            dtNoteDate.Size = new Size(497, 45);
            dtNoteDate.TabIndex = 9;
            dtNoteDate.Value = new DateTime(2023, 8, 7, 2, 33, 4, 0);
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(22, 119);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(402, 62);
            txtTitle.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(483, 195);
            label1.Name = "label1";
            label1.Size = new Size(187, 45);
            label1.TabIndex = 11;
            label1.Text = "Not Takvimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 195);
            label2.Name = "label2";
            label2.Size = new Size(225, 45);
            label2.TabIndex = 12;
            label2.Text = "Not Kategorisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 71);
            label3.Name = "label3";
            label3.Size = new Size(174, 45);
            label3.TabIndex = 13;
            label3.Text = "Not Başlığı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(22, 353);
            label4.Name = "label4";
            label4.Size = new Size(341, 45);
            label4.TabIndex = 14;
            label4.Text = "Notunuzu Oluşturunuz";
            // 
            // lbNotes
            // 
            lbNotes.FormattingEnabled = true;
            lbNotes.ItemHeight = 45;
            lbNotes.Location = new Point(25, 622);
            lbNotes.Name = "lbNotes";
            lbNotes.Size = new Size(1246, 364);
            lbNotes.TabIndex = 15;
            // 
            // NoteApplication
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1422, 1041);
            Controls.Add(lbNotes);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(dtNoteDate);
            Controls.Add(btnDelete);
            Controls.Add(btnSave);
            Controls.Add(lbNote);
            Controls.Add(txtNote);
            Controls.Add(cbchose);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NoteApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApplication";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbchose;
        private TextBox txtNote;
        private Label lbNote;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private Button btnDelete;
        private DateTimePicker dtNoteDate;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private ListBox lbNotes;
    }
}