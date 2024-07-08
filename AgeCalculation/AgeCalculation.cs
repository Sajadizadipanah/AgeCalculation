using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Globalization;

namespace AgeCalculation
{
    public partial class AgeCalculation : Form
    {
        public AgeCalculation()
        {
            InitializeComponent();
        }

        private void AgeCalculation_Load(object sender, EventArgs e)
        {
            birthTextBox.Focus();
            ageTextBox.Text = "محاسبه سن شما";
        }

        private void exitButton_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void resetButton_Click(object sender, EventArgs e)
        {

        }

        private void calculationButton_Click(object sender, EventArgs e)
        {
            //var birthDay = birthTextBox.Text;

            if (birthTextBox.Text == string.Empty )
            {
                var errorMessage =
                   "لطفا سن خود را به شمسی وارد نمائید";
                MessageBox.Show(text: errorMessage);

                birthTextBox.Focus();

                return;
            }
            int Age = System.Convert.ToInt32(birthTextBox.Text);
            if ( Age > 1403 || Age < 1295)
            {
                var errorMessage =
                   "لطفا سن خود را به درستی وارد نمائید";
                MessageBox.Show(text: errorMessage);

                birthTextBox.Focus();

                return;
            }
          
            PersianCalendar p = new PersianCalendar();
            DateTime dt = DateTime.Now;
            int y;
            y = p.GetYear(dt);
            int BirthDay = y -Age;
            var birthDay = BirthDay;
            ageTextBox.Text = birthDay.ToString();

        }


       
        

        private void birthTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
