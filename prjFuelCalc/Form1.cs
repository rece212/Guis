namespace prjFuelCalc
{
    public partial class Form1 : Form
    {
        public String[,] arrFuelPricesMarch = { { "R20.19", "R20.30", "R18.53", "R18.60", "R12.54" }
                                              , { "R19.40","R19.47","R17.70","R17.84","R11.52"} };
        public String[,] arrFuelPricesApril = { { "R25.64", "R26.27", "R28.60", "R28.81", "R27.60" }
                                              , { "R25.37","R25.44","R27.77","R28.05","R26.43"} };

        public double[,] arrFuelPricesMarchDouble = {
                                                    { 20.19, 20.30, 18.53, 18.60, 12.54 },
                                                    { 19.40, 19.47, 17.70, 17.84, 11.52 }
                                                };

        public double[,] arrFuelPricesAprilDouble = {
                                                    { 25.64, 26.27, 28.60, 28.81, 27.60 },
                                                    { 25.37, 25.44, 27.77, 28.05, 26.43 }
                                                };
        public Form1()
        {
            InitializeComponent();
            String[] FuelType = { "93 Petrol", "95 Petrol", "Diesel 0.05% (wholesale)",
                "Diesel 0.005% (wholesale)", "Illuminating Paraffin" };
            cmbFuelType.Items.AddRange(FuelType);
            rbCostal.Checked = true;
        }
        private void btnCalc_Click(object sender, EventArgs e)
        {
            try
            {
                int iArea = 0;// this gives us the area ( so for the Array if its 0
                              // for Inland or 1 for costal
                if (rbCostal.Checked)
                    iArea = 1;
                else iArea = 0;

                double dblL = Convert.ToDouble(txtL.Text);
                int iFuelType = cmbFuelType.SelectedIndex;

                if (cbApril.Checked)
                {
                    double dblCalulcator = arrFuelPricesAprilDouble[iArea, iFuelType] * dblL;
                    rtbOutput.Text = "The fuel price for April - " + cmbFuelType.Text + " is R"
                        + dblCalulcator;
                }
                else
                {
                    double dblCalulcator = arrFuelPricesMarchDouble[iArea, iFuelType] * dblL;
                    rtbOutput.Text = "The fuel price for March - " + cmbFuelType.Text + " is R"
                        + dblCalulcator;
                  txtL.Text= ""; // this is to clear the text box after the calculation



                }

            }
            catch (IndexOutOfRangeException ex)
            {
                MessageBox.Show("Why you not selecting from the combo box ?");
                cmbFuelType.Focus();
            }
            catch (FormatException fe)
            {
                MessageBox.Show("Does that look like a number to you");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Don't be a tool , click the Tool :) " + ex.ToString());
            }

        }
    }
}