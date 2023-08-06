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
            txtBoxNote = new TextBox();
            button1 = new Button();
            dateTimePicker1 = new DateTimePicker();
            txtTitle = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            SuspendLayout();
            // 
            // cbchose
            // 
            cbchose.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbchose.BackColor = SystemColors.ButtonFace;
            cbchose.ForeColor = SystemColors.ActiveCaptionText;
            cbchose.FormattingEnabled = true;
            cbchose.Items.AddRange(new object[] { "Hatırlatmalar", "Özel Günler", "Resmi Tatiller", "Toplantılar" });
            cbchose.Location = new Point(138, 222);
            cbchose.Margin = new Padding(5);
            cbchose.Name = "cbchose";
            cbchose.Size = new Size(324, 53);
            cbchose.TabIndex = 0;
            cbchose.SelectedIndexChanged += f;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(138, 381);
            txtNote.Multiline = true;
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(860, 123);
            txtNote.TabIndex = 1;
            txtNote.TextChanged += textBox1_TextChanged;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(138, 581);
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
            btnSave.Location = new Point(1015, 439);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 65);
            btnSave.TabIndex = 5;
            btnSave.Text = "Ekle";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // txtBoxNote
            // 
            txtBoxNote.Location = new Point(138, 629);
            txtBoxNote.Multiline = true;
            txtBoxNote.Name = "txtBoxNote";
            txtBoxNote.Size = new Size(860, 408);
            txtBoxNote.TabIndex = 6;
            // 
            // button1
            // 
            button1.BackColor = Color.Orchid;
            button1.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point);
            button1.ForeColor = SystemColors.ButtonHighlight;
            button1.Location = new Point(1015, 972);
            button1.Name = "button1";
            button1.Size = new Size(170, 65);
            button1.TabIndex = 7;
            button1.Text = "Sil";
            button1.UseVisualStyleBackColor = false;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.CalendarForeColor = SystemColors.ActiveCaptionText;
            dateTimePicker1.CalendarMonthBackground = Color.LightGoldenrodYellow;
            dateTimePicker1.CalendarTitleBackColor = Color.BlueViolet;
            dateTimePicker1.Location = new Point(501, 225);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.ShowCheckBox = true;
            dateTimePicker1.ShowUpDown = true;
            dateTimePicker1.Size = new Size(497, 50);
            dateTimePicker1.TabIndex = 9;
            dateTimePicker1.Value = new DateTime(2023, 8, 7, 2, 33, 4, 0);
            dateTimePicker1.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // txtTitle
            // 
            txtTitle.Location = new Point(138, 74);
            txtTitle.Multiline = true;
            txtTitle.Name = "txtTitle";
            txtTitle.Size = new Size(860, 62);
            txtTitle.TabIndex = 10;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(512, 177);
            label1.Name = "label1";
            label1.Size = new Size(187, 45);
            label1.TabIndex = 11;
            label1.Text = "Not Takvimi";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(138, 177);
            label2.Name = "label2";
            label2.Size = new Size(225, 45);
            label2.TabIndex = 12;
            label2.Text = "Not Kategorisi";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(138, 26);
            label3.Name = "label3";
            label3.Size = new Size(174, 45);
            label3.TabIndex = 13;
            label3.Text = "Not Başlığı";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(149, 333);
            label4.Name = "label4";
            label4.Size = new Size(341, 45);
            label4.TabIndex = 14;
            label4.Text = "Notunuzu Oluşturunuz";
            // 
            // NoteApplication
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.LightPink;
            ClientSize = new Size(1422, 1134);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtTitle);
            Controls.Add(dateTimePicker1);
            Controls.Add(button1);
            Controls.Add(txtBoxNote);
            Controls.Add(btnSave);
            Controls.Add(lbNote);
            Controls.Add(txtNote);
            Controls.Add(cbchose);
            Font = new Font("Segoe UI", 16F, FontStyle.Regular, GraphicsUnit.Point);
            Margin = new Padding(5);
            Name = "NoteApplication";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "NoteApplication";
            Load += NoteApplication_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cbchose;
        private TextBox txtNote;
        private Label lbNote;
        private Button btnSave;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private TextBox txtBoxNote;
        private Button button1;
        private DateTimePicker dateTimePicker1;
        private TextBox txtTitle;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
    }
}