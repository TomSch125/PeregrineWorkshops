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
            lblUsed = new Label();
            splitContainer1 = new SplitContainer();
            splitContainer2 = new SplitContainer();
            tableLayoutPanel1 = new TableLayoutPanel();
            tableLayoutPanel2 = new TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            tableLayoutPanel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblPic
            // 
            lblPic.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblPic.AutoSize = true;
            lblPic.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPic.Location = new Point(375, 0);
            lblPic.Name = "lblPic";
            lblPic.Size = new Size(76, 455);
            lblPic.TabIndex = 0;
            lblPic.Text = "label1";
            lblPic.TextAlign = ContentAlignment.TopCenter;
            // 
            // btnRestart
            // 
            btnRestart.Dock = DockStyle.Top;
            btnRestart.Location = new Point(0, 0);
            btnRestart.MaximumSize = new Size(200, 27);
            btnRestart.Name = "btnRestart";
            btnRestart.Size = new Size(200, 27);
            btnRestart.TabIndex = 1;
            btnRestart.Text = "Restart";
            btnRestart.UseVisualStyleBackColor = true;
            btnRestart.Click += btnRestart_Click;
            // 
            // lblCurrent
            // 
            lblCurrent.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblCurrent.AutoSize = true;
            lblCurrent.Font = new Font("Segoe UI", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCurrent.Location = new Point(368, 455);
            lblCurrent.Name = "lblCurrent";
            lblCurrent.Size = new Size(90, 86);
            lblCurrent.TabIndex = 2;
            lblCurrent.Text = "Current";
            // 
            // btnSubmit
            // 
            btnSubmit.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            btnSubmit.Location = new Point(633, 3);
            btnSubmit.MaximumSize = new Size(100, 27);
            btnSubmit.Name = "btnSubmit";
            btnSubmit.Size = new Size(100, 27);
            btnSubmit.TabIndex = 3;
            btnSubmit.Text = "Submit";
            btnSubmit.UseVisualStyleBackColor = true;
            btnSubmit.Click += btnSubmit_Click;
            // 
            // LetterBox
            // 
            LetterBox.Location = new Point(217, 3);
            LetterBox.Name = "LetterBox";
            LetterBox.Size = new Size(221, 27);
            LetterBox.TabIndex = 4;
            LetterBox.TextChanged += LetterBox_TextChanged;
            // 
            // lblChar
            // 
            lblChar.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            lblChar.AutoSize = true;
            lblChar.Location = new Point(161, 0);
            lblChar.Name = "lblChar";
            lblChar.Size = new Size(50, 20);
            lblChar.TabIndex = 5;
            lblChar.Text = "Guess:";
            // 
            // lblWin
            // 
            lblWin.Anchor = AnchorStyles.Top | AnchorStyles.Bottom;
            lblWin.AutoSize = true;
            lblWin.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblWin.Location = new Point(374, 627);
            lblWin.Name = "lblWin";
            lblWin.Size = new Size(79, 89);
            lblWin.TabIndex = 6;
            lblWin.Text = "Win";
            // 
            // lblUsed
            // 
            lblUsed.AutoSize = true;
            lblUsed.Dock = DockStyle.Top;
            lblUsed.Font = new Font("Segoe UI", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUsed.ForeColor = Color.Red;
            lblUsed.Location = new Point(0, 0);
            lblUsed.Name = "lblUsed";
            lblUsed.Size = new Size(52, 23);
            lblUsed.TabIndex = 7;
            lblUsed.Text = "Used:";
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(btnRestart);
            splitContainer1.Panel1.Paint += splitContainer1_Panel1_Paint_1;
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1393, 720);
            splitContainer1.SplitterDistance = 214;
            splitContainer1.TabIndex = 8;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(tableLayoutPanel1);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(lblUsed);
            splitContainer2.Size = new Size(1175, 720);
            splitContainer2.SplitterDistance = 831;
            splitContainer2.TabIndex = 8;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.BackColor = SystemColors.ButtonFace;
            tableLayoutPanel1.ColumnCount = 1;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            tableLayoutPanel1.Controls.Add(lblWin, 0, 3);
            tableLayoutPanel1.Controls.Add(lblCurrent, 0, 1);
            tableLayoutPanel1.Controls.Add(lblPic, 0, 0);
            tableLayoutPanel1.Controls.Add(tableLayoutPanel2, 0, 2);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 4;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 63.6703873F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1098728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.1098728F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 12.10987F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            tableLayoutPanel1.Size = new Size(827, 716);
            tableLayoutPanel1.TabIndex = 7;
            tableLayoutPanel1.Paint += tableLayoutPanel1_Paint;
            // 
            // tableLayoutPanel2
            // 
            tableLayoutPanel2.ColumnCount = 3;
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 26.1083736F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 40.49261F));
            tableLayoutPanel2.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 33.3333321F));
            tableLayoutPanel2.Controls.Add(LetterBox, 1, 0);
            tableLayoutPanel2.Controls.Add(lblChar, 0, 0);
            tableLayoutPanel2.Controls.Add(btnSubmit, 2, 0);
            tableLayoutPanel2.Dock = DockStyle.Fill;
            tableLayoutPanel2.Location = new Point(3, 544);
            tableLayoutPanel2.Name = "tableLayoutPanel2";
            tableLayoutPanel2.RowCount = 1;
            tableLayoutPanel2.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            tableLayoutPanel2.Size = new Size(821, 80);
            tableLayoutPanel2.TabIndex = 7;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1393, 720);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel2.ResumeLayout(false);
            splitContainer2.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            tableLayoutPanel2.ResumeLayout(false);
            tableLayoutPanel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblPic;
        private Button btnRestart;
        private Label lblCurrent;
        private Button btnSubmit;
        private TextBox LetterBox;
        private Label lblChar;
        private Label lblWin;
        private Label lblUsed;
        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private TableLayoutPanel tableLayoutPanel1;
        private TableLayoutPanel tableLayoutPanel2;
    }
}
