using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Average_Form
{
    public partial class Form1 : Form
    {//declare variables
        private int MarkSubject1;
        private int MarkSubject2;
        private int result;

        private int intvalidation;

        //declare and initialize variables
        private bool bsubject1 = false;
        private bool bsubject2 = false;
        private bool bresult = false;

        public Form1()
        {
            InitializeComponent();
            //initialise variables  on form constructors
            MarkSubject1 = 0;
            MarkSubject2 = 0;

            //change attribute
            txtAverage.ReadOnly = true;

        }

        private void txtmarksubject1_validating(object sender, CancelEventArgs e)
        {//clear error provider
            errorProvider1.SetError(txtmarksubject1, "");
            bsubject1 = false;
            if (!int.TryParse(txtmarksubject1.Text, out intvalidation))
            {
                bsubject1 = true;
                errorProvider1.SetError(txtmarksubject1, "Please fill the required area");
            }

        }

        private void txtmarksubject2_validating(object sender, CancelEventArgs e)
        {//clear error provider
            errorProvider2.SetError(txtmarksubject2, "");
            bsubject2 = false;
            if (!int.TryParse(txtmarksubject2.Text, out intvalidation))
            {
                bsubject2 = true;
                errorProvider2.SetError(txtmarksubject2, "Please fill the required area");
            }

        }

        private void txtResult_validating(object sender, CancelEventArgs e)
        {//clear error provider
            errorProvider3.SetError(txtAverage, "");
            bresult = false;
            if (!int.TryParse(txtAverage.Text, out intvalidation))
            {
                bresult = true;
                errorProvider3.SetError(txtAverage, "Please fill the required area");
            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            try
            {
                if (bsubject1 == false && bsubject2 == false)
                {
                    MarkSubject1 = int.Parse(txtmarksubject1.Text);
                    MarkSubject2 = int.Parse(txtmarksubject2.Text);

                    result = ((MarkSubject1 + MarkSubject2) / 2);
                    txtAverage.Text = result.ToString();
                    if (result >= 0 && result < 40)
                    {
                        labelMark.Text = "Grade F";
                    }
                    else if (result >= 40 && result < 65)
                    {
                        labelMark.Text = "Grade C";

                    }
                    else if (result >= 65 && result < 75)
                    {
                        labelMark.Text = "Grade B";
                    }
                    else if (result >= 75 && result <= 100)
                    {
                        labelMark.Text = "Grade A";
                    }
                    else if (result > 100)
                    {
                        labelMark.Text = "Invalid Mark Submited";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
    

