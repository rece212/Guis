namespace prjHelloWIndows
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
            lblOutput = new Label();
            btnPressMe = new Button();
            cbTest = new CheckBox();
            txtOutput = new TextBox();
            rtbTestOneTwoThree = new RichTextBox();
            rbSelect = new RadioButton();
            rbFour = new RadioButton();
            SuspendLayout();
            // 
            // lblOutput
            // 
            lblOutput.AutoSize = true;
            lblOutput.Location = new Point(296, 91);
            lblOutput.Name = "lblOutput";
            lblOutput.Size = new Size(135, 15);
            lblOutput.TabIndex = 0;
            lblOutput.Text = "I will be adding text here";
            // 
            // btnPressMe
            // 
            btnPressMe.Location = new Point(224, 202);
            btnPressMe.Name = "btnPressMe";
            btnPressMe.Size = new Size(312, 23);
            btnPressMe.TabIndex = 1;
            btnPressMe.Text = "Click me for something to happen";
            btnPressMe.UseVisualStyleBackColor = true;
            btnPressMe.Click += btnPressMe_Click;
            // 
            // cbTest
            // 
            cbTest.AutoSize = true;
            cbTest.Location = new Point(224, 176);
            cbTest.Name = "cbTest";
            cbTest.Size = new Size(138, 19);
            cbTest.TabIndex = 2;
            cbTest.Text = "Check me if you dear";
            cbTest.UseVisualStyleBackColor = true;
            // 
            // txtOutput
            // 
            txtOutput.BackColor = SystemColors.HotTrack;
            txtOutput.Location = new Point(284, 130);
            txtOutput.Name = "txtOutput";
            txtOutput.Size = new Size(191, 23);
            txtOutput.TabIndex = 3;
            // 
            // rtbTestOneTwoThree
            // 
            rtbTestOneTwoThree.Location = new Point(192, 245);
            rtbTestOneTwoThree.Name = "rtbTestOneTwoThree";
            rtbTestOneTwoThree.Size = new Size(408, 96);
            rtbTestOneTwoThree.TabIndex = 4;
            rtbTestOneTwoThree.Text = "";
            // 
            // rbSelect
            // 
            rbSelect.AutoSize = true;
            rbSelect.Location = new Point(416, 175);
            rbSelect.Name = "rbSelect";
            rbSelect.Size = new Size(78, 19);
            rbSelect.TabIndex = 5;
            rbSelect.TabStop = true;
            rbSelect.Text = "Radio one";
            rbSelect.UseVisualStyleBackColor = true;
            // 
            // rbFour
            // 
            rbFour.AutoSize = true;
            rbFour.Location = new Point(515, 175);
            rbFour.Name = "rbFour";
            rbFour.Size = new Size(85, 19);
            rbFour.TabIndex = 6;
            rbFour.TabStop = true;
            rbFour.Text = "radio Three";
            rbFour.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 369);
            Controls.Add(rbFour);
            Controls.Add(rbSelect);
            Controls.Add(rtbTestOneTwoThree);
            Controls.Add(txtOutput);
            Controls.Add(cbTest);
            Controls.Add(btnPressMe);
            Controls.Add(lblOutput);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblOutput;
        private Button btnPressMe;
        private CheckBox cbTest;
        private TextBox txtOutput;
        private RichTextBox rtbTestOneTwoThree;
        private RadioButton rbSelect;
        private RadioButton rbFour;
    }
}
