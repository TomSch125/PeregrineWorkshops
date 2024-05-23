namespace ShapeForms
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
            chkTraingle = new CheckBox();
            chkRectangle = new CheckBox();
            chkCircle = new CheckBox();
            btnCalc = new Button();
            lblArea = new Label();
            lblPerimeter = new Label();
            lblA = new Label();
            lblB = new Label();
            lblC = new Label();
            spinA = new NumericUpDown();
            spinB = new NumericUpDown();
            spinC = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)spinA).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinB).BeginInit();
            ((System.ComponentModel.ISupportInitialize)spinC).BeginInit();
            SuspendLayout();
            // 
            // chkTraingle
            // 
            chkTraingle.AutoSize = true;
            chkTraingle.Location = new Point(272, 36);
            chkTraingle.Name = "chkTraingle";
            chkTraingle.Size = new Size(84, 24);
            chkTraingle.TabIndex = 0;
            chkTraingle.Text = "Trinagle";
            chkTraingle.UseVisualStyleBackColor = true;
            chkTraingle.CheckedChanged += chkTraingle_CheckedChanged;
            // 
            // chkRectangle
            // 
            chkRectangle.AutoSize = true;
            chkRectangle.Location = new Point(432, 36);
            chkRectangle.Name = "chkRectangle";
            chkRectangle.Size = new Size(97, 24);
            chkRectangle.TabIndex = 1;
            chkRectangle.Text = "Rectangle";
            chkRectangle.UseVisualStyleBackColor = true;
            chkRectangle.CheckedChanged += chkRectangle_CheckedChanged;
            // 
            // chkCircle
            // 
            chkCircle.AutoSize = true;
            chkCircle.Location = new Point(615, 36);
            chkCircle.Name = "chkCircle";
            chkCircle.Size = new Size(68, 24);
            chkCircle.TabIndex = 2;
            chkCircle.Text = "Circle";
            chkCircle.UseVisualStyleBackColor = true;
            chkCircle.CheckedChanged += chkCircle_CheckedChanged;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(435, 291);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(94, 29);
            btnCalc.TabIndex = 3;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // lblArea
            // 
            lblArea.AutoSize = true;
            lblArea.Location = new Point(394, 363);
            lblArea.Name = "lblArea";
            lblArea.Size = new Size(50, 20);
            lblArea.TabIndex = 4;
            lblArea.Text = "label1";
            // 
            // lblPerimeter
            // 
            lblPerimeter.AutoSize = true;
            lblPerimeter.Location = new Point(394, 435);
            lblPerimeter.Name = "lblPerimeter";
            lblPerimeter.Size = new Size(50, 20);
            lblPerimeter.TabIndex = 5;
            lblPerimeter.Text = "label1";
            lblPerimeter.Click += label1_Click_1;
            // 
            // lblA
            // 
            lblA.AutoSize = true;
            lblA.Location = new Point(362, 118);
            lblA.Name = "lblA";
            lblA.Size = new Size(50, 20);
            lblA.TabIndex = 6;
            lblA.Text = "label1";
            lblA.Click += lblA_Click;
            // 
            // lblB
            // 
            lblB.AutoSize = true;
            lblB.Location = new Point(362, 162);
            lblB.Name = "lblB";
            lblB.Size = new Size(50, 20);
            lblB.TabIndex = 7;
            lblB.Text = "label1";
            // 
            // lblC
            // 
            lblC.AutoSize = true;
            lblC.Location = new Point(362, 202);
            lblC.Name = "lblC";
            lblC.Size = new Size(50, 20);
            lblC.TabIndex = 8;
            lblC.Text = "label1";
            // 
            // spinA
            // 
            spinA.Location = new Point(435, 116);
            spinA.Name = "spinA";
            spinA.Size = new Size(150, 27);
            spinA.TabIndex = 9;
            // 
            // spinB
            // 
            spinB.Location = new Point(435, 155);
            spinB.Name = "spinB";
            spinB.Size = new Size(150, 27);
            spinB.TabIndex = 10;
            // 
            // spinC
            // 
            spinC.Location = new Point(435, 195);
            spinC.Name = "spinC";
            spinC.Size = new Size(150, 27);
            spinC.TabIndex = 11;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(975, 547);
            Controls.Add(spinC);
            Controls.Add(spinB);
            Controls.Add(spinA);
            Controls.Add(lblC);
            Controls.Add(lblB);
            Controls.Add(lblA);
            Controls.Add(lblPerimeter);
            Controls.Add(lblArea);
            Controls.Add(btnCalc);
            Controls.Add(chkCircle);
            Controls.Add(chkRectangle);
            Controls.Add(chkTraingle);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)spinA).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinB).EndInit();
            ((System.ComponentModel.ISupportInitialize)spinC).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox chkTraingle;
        private CheckBox chkRectangle;
        private CheckBox chkCircle;
        private Button btnCalc;
        private Label lblArea;
        private Label lblPerimeter;
        private Label lblA;
        private Label lblB;
        private Label lblC;
        private NumericUpDown spinA;
        private NumericUpDown spinB;
        private NumericUpDown spinC;
    }
}
