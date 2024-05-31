namespace ChatClient
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
            splitContainer1 = new SplitContainer();
            splitContainer4 = new SplitContainer();
            Nick = new Label();
            splitContainer5 = new SplitContainer();
            txtNick = new TextBox();
            btnSignIn = new Button();
            splitContainer2 = new SplitContainer();
            splitContainer3 = new SplitContainer();
            txtMessage = new TextBox();
            btnSend = new Button();
            txtMessageHistory = new Label();
            ((System.ComponentModel.ISupportInitialize)splitContainer1).BeginInit();
            splitContainer1.Panel1.SuspendLayout();
            splitContainer1.Panel2.SuspendLayout();
            splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer4).BeginInit();
            splitContainer4.Panel1.SuspendLayout();
            splitContainer4.Panel2.SuspendLayout();
            splitContainer4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer5).BeginInit();
            splitContainer5.Panel1.SuspendLayout();
            splitContainer5.Panel2.SuspendLayout();
            splitContainer5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer2).BeginInit();
            splitContainer2.Panel1.SuspendLayout();
            splitContainer2.Panel2.SuspendLayout();
            splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer3).BeginInit();
            splitContainer3.Panel1.SuspendLayout();
            splitContainer3.Panel2.SuspendLayout();
            splitContainer3.SuspendLayout();
            SuspendLayout();
            // 
            // splitContainer1
            // 
            splitContainer1.BorderStyle = BorderStyle.Fixed3D;
            splitContainer1.Dock = DockStyle.Fill;
            splitContainer1.Location = new Point(0, 0);
            splitContainer1.Name = "splitContainer1";
            splitContainer1.Orientation = Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            splitContainer1.Panel1.Controls.Add(splitContainer4);
            // 
            // splitContainer1.Panel2
            // 
            splitContainer1.Panel2.Controls.Add(splitContainer2);
            splitContainer1.Size = new Size(1408, 843);
            splitContainer1.SplitterDistance = 90;
            splitContainer1.TabIndex = 0;
            splitContainer1.SplitterMoved += splitContainer1_SplitterMoved;
            // 
            // splitContainer4
            // 
            splitContainer4.BorderStyle = BorderStyle.Fixed3D;
            splitContainer4.Dock = DockStyle.Fill;
            splitContainer4.Location = new Point(0, 0);
            splitContainer4.Name = "splitContainer4";
            // 
            // splitContainer4.Panel1
            // 
            splitContainer4.Panel1.Controls.Add(Nick);
            // 
            // splitContainer4.Panel2
            // 
            splitContainer4.Panel2.Controls.Add(splitContainer5);
            splitContainer4.Size = new Size(1408, 90);
            splitContainer4.SplitterDistance = 266;
            splitContainer4.TabIndex = 0;
            // 
            // Nick
            // 
            Nick.AutoSize = true;
            Nick.Dock = DockStyle.Right;
            Nick.Location = new Point(224, 0);
            Nick.Name = "Nick";
            Nick.Size = new Size(38, 20);
            Nick.TabIndex = 0;
            Nick.Text = "Nick";
            Nick.Click += lblName_Click;
            // 
            // splitContainer5
            // 
            splitContainer5.BorderStyle = BorderStyle.Fixed3D;
            splitContainer5.Dock = DockStyle.Fill;
            splitContainer5.Location = new Point(0, 0);
            splitContainer5.Name = "splitContainer5";
            // 
            // splitContainer5.Panel1
            // 
            splitContainer5.Panel1.Controls.Add(txtNick);
            // 
            // splitContainer5.Panel2
            // 
            splitContainer5.Panel2.Controls.Add(btnSignIn);
            splitContainer5.Size = new Size(1138, 90);
            splitContainer5.SplitterDistance = 836;
            splitContainer5.TabIndex = 0;
            // 
            // txtNick
            // 
            txtNick.Dock = DockStyle.Fill;
            txtNick.Location = new Point(0, 0);
            txtNick.Name = "txtNick";
            txtNick.Size = new Size(832, 27);
            txtNick.TabIndex = 0;
            // 
            // btnSignIn
            // 
            btnSignIn.Dock = DockStyle.Fill;
            btnSignIn.Location = new Point(0, 0);
            btnSignIn.Name = "btnSignIn";
            btnSignIn.Size = new Size(294, 86);
            btnSignIn.TabIndex = 0;
            btnSignIn.Text = "Sign In";
            btnSignIn.UseVisualStyleBackColor = true;
            btnSignIn.Click += btnSignIn_Click;
            // 
            // splitContainer2
            // 
            splitContainer2.BorderStyle = BorderStyle.Fixed3D;
            splitContainer2.Dock = DockStyle.Fill;
            splitContainer2.Location = new Point(0, 0);
            splitContainer2.Name = "splitContainer2";
            splitContainer2.Orientation = Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            splitContainer2.Panel1.Controls.Add(txtMessageHistory);
            // 
            // splitContainer2.Panel2
            // 
            splitContainer2.Panel2.Controls.Add(splitContainer3);
            splitContainer2.Panel2.Paint += splitContainer2_Panel2_Paint;
            splitContainer2.Size = new Size(1408, 749);
            splitContainer2.SplitterDistance = 635;
            splitContainer2.TabIndex = 1;
            // 
            // splitContainer3
            // 
            splitContainer3.BorderStyle = BorderStyle.Fixed3D;
            splitContainer3.Dock = DockStyle.Fill;
            splitContainer3.Location = new Point(0, 0);
            splitContainer3.Name = "splitContainer3";
            // 
            // splitContainer3.Panel1
            // 
            splitContainer3.Panel1.Controls.Add(txtMessage);
            splitContainer3.Panel1.Paint += splitContainer3_Panel1_Paint;
            // 
            // splitContainer3.Panel2
            // 
            splitContainer3.Panel2.Controls.Add(btnSend);
            splitContainer3.Size = new Size(1408, 110);
            splitContainer3.SplitterDistance = 903;
            splitContainer3.TabIndex = 0;
            // 
            // txtMessage
            // 
            txtMessage.Dock = DockStyle.Fill;
            txtMessage.Location = new Point(0, 0);
            txtMessage.Name = "txtMessage";
            txtMessage.Size = new Size(899, 27);
            txtMessage.TabIndex = 0;
            // 
            // btnSend
            // 
            btnSend.Dock = DockStyle.Fill;
            btnSend.Location = new Point(0, 0);
            btnSend.Name = "btnSend";
            btnSend.Size = new Size(497, 106);
            btnSend.TabIndex = 0;
            btnSend.Text = "Send";
            btnSend.UseVisualStyleBackColor = true;
            btnSend.Click += btnSend_Click;
            // 
            // txtMessageHistory
            // 
            txtMessageHistory.AutoSize = true;
            txtMessageHistory.Dock = DockStyle.Fill;
            txtMessageHistory.Location = new Point(0, 0);
            txtMessageHistory.Name = "txtMessageHistory";
            txtMessageHistory.Size = new Size(0, 20);
            txtMessageHistory.TabIndex = 0;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1408, 843);
            Controls.Add(splitContainer1);
            Name = "Form1";
            Text = "Form1";
            splitContainer1.Panel1.ResumeLayout(false);
            splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer1).EndInit();
            splitContainer1.ResumeLayout(false);
            splitContainer4.Panel1.ResumeLayout(false);
            splitContainer4.Panel1.PerformLayout();
            splitContainer4.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer4).EndInit();
            splitContainer4.ResumeLayout(false);
            splitContainer5.Panel1.ResumeLayout(false);
            splitContainer5.Panel1.PerformLayout();
            splitContainer5.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer5).EndInit();
            splitContainer5.ResumeLayout(false);
            splitContainer2.Panel1.ResumeLayout(false);
            splitContainer2.Panel1.PerformLayout();
            splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer2).EndInit();
            splitContainer2.ResumeLayout(false);
            splitContainer3.Panel1.ResumeLayout(false);
            splitContainer3.Panel1.PerformLayout();
            splitContainer3.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer3).EndInit();
            splitContainer3.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private SplitContainer splitContainer1;
        private SplitContainer splitContainer2;
        private SplitContainer splitContainer3;
        private SplitContainer splitContainer4;
        private Label Nick;
        private SplitContainer splitContainer5;
        private Button btnSignIn;
        private TextBox txtNick;
        private TextBox txtMessage;
        private Button btnSend;
        private Label txtMessageHistory;
    }
}
