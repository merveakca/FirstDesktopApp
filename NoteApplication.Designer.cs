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
            comboBox1 = new ComboBox();
            SuspendLayout();
            // 
            // comboBox1
            // 
            comboBox1.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "Hatırlatmalar", "Özel Günler", "Toplantılar", "Resmi Tatiller" });
            comboBox1.Location = new Point(194, 86);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(182, 33);
            comboBox1.TabIndex = 0;
            comboBox1.SelectedIndexChanged += f;
            // 
            // NoteApplication
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 989);
            Controls.Add(comboBox1);
            Name = "NoteApplication";
            Text = "NoteApplication";
            ResumeLayout(false);
        }

        #endregion

        private ComboBox comboBox1;
    }
}