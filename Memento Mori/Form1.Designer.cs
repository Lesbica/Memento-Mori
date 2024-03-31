namespace Memento_Mori
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnChangeText = new Button();
            btnSave = new Button();
            btnUndo = new Button();
            btnShowHistory = new Button();
            cbFonts = new ComboBox();
            cbColors = new ComboBox();
            txtEditor = new TextBox();
            SuspendLayout();
            // 
            // btnChangeText
            // 
            btnChangeText.Location = new Point(12, 190);
            btnChangeText.Name = "btnChangeText";
            btnChangeText.Size = new Size(134, 71);
            btnChangeText.TabIndex = 1;
            btnChangeText.Text = "Change Text";
            btnChangeText.UseVisualStyleBackColor = true;
            btnChangeText.Click += btnChangeText_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(152, 190);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(161, 71);
            btnSave.TabIndex = 2;
            btnSave.Text = "Save";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnUndo
            // 
            btnUndo.Location = new Point(319, 190);
            btnUndo.Name = "btnUndo";
            btnUndo.Size = new Size(172, 71);
            btnUndo.TabIndex = 3;
            btnUndo.Text = "Undo";
            btnUndo.UseVisualStyleBackColor = true;
            btnUndo.Click += btnUndo_Click;
            // 
            // btnShowHistory
            // 
            btnShowHistory.Location = new Point(497, 190);
            btnShowHistory.Name = "btnShowHistory";
            btnShowHistory.Size = new Size(161, 71);
            btnShowHistory.TabIndex = 4;
            btnShowHistory.Text = "Show History";
            btnShowHistory.UseVisualStyleBackColor = true;
            btnShowHistory.Click += btnShowHistory_Click;
            // 
            // cbFonts
            // 
            cbFonts.FormattingEnabled = true;
            cbFonts.Location = new Point(664, 12);
            cbFonts.Name = "cbFonts";
            cbFonts.Size = new Size(121, 23);
            cbFonts.TabIndex = 5;
            cbFonts.SelectedIndexChanged += ChangeFont;
            // 
            // cbColors
            // 
            cbColors.FormattingEnabled = true;
            cbColors.Location = new Point(664, 41);
            cbColors.Name = "cbColors";
            cbColors.Size = new Size(121, 23);
            cbColors.TabIndex = 6;
            cbColors.SelectedIndexChanged += ChangeColor;
            // 
            // txtEditor
            // 
            txtEditor.Location = new Point(12, 12);
            txtEditor.Multiline = true;
            txtEditor.Name = "txtEditor";
            txtEditor.Size = new Size(646, 172);
            txtEditor.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 286);
            Controls.Add(txtEditor);
            Controls.Add(cbColors);
            Controls.Add(cbFonts);
            Controls.Add(btnShowHistory);
            Controls.Add(btnUndo);
            Controls.Add(btnSave);
            Controls.Add(btnChangeText);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnChangeText;
        private Button btnSave;
        private Button btnUndo;
        private Button btnShowHistory;
        private ComboBox cbFonts;
        private ComboBox cbColors;
        private TextBox txtEditor;
    }
}
