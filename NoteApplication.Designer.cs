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
            SuspendLayout();
            // 
            // cbchose
            // 
            cbchose.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            cbchose.BackColor = SystemColors.ActiveCaption;
            cbchose.ForeColor = SystemColors.ActiveCaptionText;
            cbchose.FormattingEnabled = true;
            cbchose.Items.AddRange(new object[] { "Hatırlatmalar", "Özel Günler", "Resmi Tatiller", "Toplantılar" });
            cbchose.Location = new Point(138, 104);
            cbchose.Margin = new Padding(5);
            cbchose.Name = "cbchose";
            cbchose.Size = new Size(324, 53);
            cbchose.TabIndex = 0;
            cbchose.SelectedIndexChanged += f;
            // 
            // txtNote
            // 
            txtNote.Location = new Point(138, 244);
            txtNote.Name = "txtNote";
            txtNote.Size = new Size(254, 50);
            txtNote.TabIndex = 1;
            txtNote.TextChanged += textBox1_TextChanged;
            // 
            // lbNote
            // 
            lbNote.AutoSize = true;
            lbNote.Location = new Point(138, 176);
            lbNote.Name = "lbNote";
            lbNote.Size = new Size(145, 45);
            lbNote.TabIndex = 2;
            lbNote.Text = "Notlarım";
            // 
            // btnSave
            // 
            btnSave.BackColor = SystemColors.ButtonFace;
            btnSave.Location = new Point(138, 323);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(170, 65);
            btnSave.TabIndex = 5;
            btnSave.Text = "Kaydet";
            btnSave.UseVisualStyleBackColor = false;
            btnSave.Click += btnSave_Click;
            // 
            // NoteApplication
            // 
            AutoScaleDimensions = new SizeF(18F, 45F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(958, 711);
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
    }
}