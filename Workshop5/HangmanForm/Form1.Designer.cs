namespace HangmanForm
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
            lblPic = new Label();
            btnRestart = new Button();
            lblCurrent = new Label();
            btnSubmit = new Button();
            LetterBox = new TextBox();
            lblChar = new Label();
            lblWin = new Label();
            SuspendLayout();
            // 
            // lblPic
            // 
            lblPic.AutoSize = true;
            lblPic.Location = new Point(551, 152);
            lblPic.Name = "lblPic";
            lblPic.Size = new Size(50, 20);
            lblPic.TabIndex = 0;
            lblPic.Text = "label1";
            lblPic.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRestart
            // 
            btnRestart.Location = new Point(50, 33);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(94, 29);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblCurrent
            // 
            lblCurrent.AutoSize = true;
            lblCurrent.Location = new Point(551, 339);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(57, 20);
            lblCurrent.TabIndex = 2;
            lblCurrent.Text = "Current";
            // 
            // btnSubmit
            // 
            btnSubmit.Location = new Point(551, 529);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(94, 29);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // LetterBox
            // 
            LetterBox.Location = new Point(567, 459);
            LetterBox.Name = "LetterBox";
            LetterBox.Size = new Size(125, 27);
            LetterBox.TabIndex = 4;
            // 
            // lblChar
            // 
            lblChar.AutoSize = true;
            lblChar.Location = new Point(511, 462);
            lblChar.Name = "lblChar";
            lblChar.Size = new Size(50, 20);
            lblChar.TabIndex = 5;
            lblChar.Text = "Guess:";
            // 
            // lblWin
            // 
            lblWin.AutoSize = true;
            lblWin.Location = new Point(573, 629);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(35, 20);
            lblWin.TabIndex = 6;
            lblWin.Text = "Win";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1259, 740);
            Controls.Add(lblWin);
            Controls.Add(lblChar);
            Controls.Add(LetterBox);
            Controls.Add(btnSubmit);
            Controls.Add(lblCurrent);
            Controls.Add(btnRestart);
            Controls.Add(lblPic);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPic;
        private Button btnRestart;
        private Label lblCurrent;
        private Button btnSubmit;
        private TextBox LetterBox;
        private Label lblChar;
        private Label lblWin;
    }
}
