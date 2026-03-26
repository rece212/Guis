namespace prjFuelCalc
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            pictureBox1 = new PictureBox();
            cmbFuelType = new ComboBox();
            lblFuelType = new Label();
            rbInland = new RadioButton();
            rbCostal = new RadioButton();
            txtL = new TextBox();
            lblL = new Label();
            cbApril = new CheckBox();
            btnCalc = new Button();
            rtbOutput = new RichTextBox();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(6, 376);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(262, 201);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // cmbFuelType
            // 
            cmbFuelType.FormattingEnabled = true;
            cmbFuelType.Location = new Point(94, 36);
            cmbFuelType.Name = "cmbFuelType";
            cmbFuelType.Size = new Size(160, 23);
            cmbFuelType.TabIndex = 1;
            // 
            // lblFuelType
            // 
            lblFuelType.AutoSize = true;
            lblFuelType.Location = new Point(20, 39);
            lblFuelType.Name = "lblFuelType";
            lblFuelType.Size = new Size(55, 15);
            lblFuelType.TabIndex = 2;
            lblFuelType.Text = "Fuel type";
            // 
            // rbInland
            // 
            rbInland.AutoSize = true;
            rbInland.Location = new Point(196, 80);
            rbInland.Name = "rbInland";
            rbInland.Size = new Size(58, 19);
            rbInland.TabIndex = 3;
            rbInland.TabStop = true;
            rbInland.Text = "Inland";
            rbInland.UseVisualStyleBackColor = true;
            // 
            // rbCostal
            // 
            rbCostal.AutoSize = true;
            rbCostal.Location = new Point(103, 80);
            rbCostal.Name = "rbCostal";
            rbCostal.Size = new Size(64, 19);
            rbCostal.TabIndex = 4;
            rbCostal.TabStop = true;
            rbCostal.Text = "Coastal";
            rbCostal.UseVisualStyleBackColor = true;
            // 
            // txtL
            // 
            txtL.Location = new Point(103, 116);
            txtL.Name = "txtL";
            txtL.Size = new Size(151, 23);
            txtL.TabIndex = 5;
            // 
            // lblL
            // 
            lblL.AutoSize = true;
            lblL.Location = new Point(20, 119);
            lblL.Name = "lblL";
            lblL.Size = new Size(77, 15);
            lblL.TabIndex = 6;
            lblL.Text = "How many L ";
            // 
            // cbApril
            // 
            cbApril.AutoSize = true;
            cbApril.Location = new Point(20, 165);
            cbApril.Name = "cbApril";
            cbApril.Size = new Size(80, 19);
            cbApril.TabIndex = 7;
            cbApril.Text = "April Price";
            cbApril.UseVisualStyleBackColor = true;
            // 
            // btnCalc
            // 
            btnCalc.Location = new Point(140, 161);
            btnCalc.Name = "btnCalc";
            btnCalc.Size = new Size(75, 23);
            btnCalc.TabIndex = 8;
            btnCalc.Text = "Calculate";
            btnCalc.UseVisualStyleBackColor = true;
            btnCalc.Click += btnCalc_Click;
            // 
            // rtbOutput
            // 
            rtbOutput.Location = new Point(6, 202);
            rtbOutput.Name = "rtbOutput";
            rtbOutput.Size = new Size(250, 168);
            rtbOutput.TabIndex = 9;
            rtbOutput.Text = "";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(266, 576);
            Controls.Add(rtbOutput);
            Controls.Add(btnCalc);
            Controls.Add(cbApril);
            Controls.Add(lblL);
            Controls.Add(txtL);
            Controls.Add(rbCostal);
            Controls.Add(rbInland);
            Controls.Add(lblFuelType);
            Controls.Add(cmbFuelType);
            Controls.Add(pictureBox1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private ComboBox cmbFuelType;
        private Label lblFuelType;
        private RadioButton rbInland;
        private RadioButton rbCostal;
        private TextBox txtL;
        private Label lblL;
        private CheckBox cbApril;
        private Button btnCalc;
        private RichTextBox rtbOutput;
    }
}
