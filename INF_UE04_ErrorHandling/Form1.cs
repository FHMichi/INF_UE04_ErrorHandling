using System.Data;
using System.Globalization;

namespace INF_UE04_ErrorHandling
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            /*
            int i = 0;
            int j = 13;
            
            int m = j / i;
            this.Text = j.ToString();
            double y;
            y = ((i + j) / 2 + (m-2)) * 3 ;
           */

            try
            {
                int a, b, c;
                a = Convert.ToInt32(txtA.Text);
                b = Convert.ToInt32(txtB.Text);

                c = a / b;
                lblC.Text = c.ToString();
            }
            catch (Exception e1)
            {
                MessageBox.Show("Fehler: \n" + e1.Message);
            }
            
            
           
        }
    }
}
