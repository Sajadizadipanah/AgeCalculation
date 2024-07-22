using System.Globalization;

namespace AgeCalculation;

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
        this.Dispose();
        System.Windows.Forms.Application.Exit();
    }

    private void resetButton_Click(object sender, EventArgs e)
    {
        Reset();
    }

    private void calculationButton_Click(object sender, EventArgs e)
    {
       
        if (birthTextBox.Text == string.Empty)
        {
            var errorMessage =
               "لطفا سن خود را به شمسی وارد نمائید";
            MessageBox.Show(text: errorMessage);
            birthTextBox.Text = string.Empty;
            ageTextBox.Text = "محاسبه سن شما";
            birthTextBox.Focus();
            return;
        }
        int Age = System.Convert.ToInt32(birthTextBox.Text);
        if (Age > 1403 || Age < 1295)
        {
            var errorMessage =
               "لطفا سن خود را به درستی وارد نمائید";
            MessageBox.Show(text: errorMessage);
            birthTextBox.Text = string.Empty;
            ageTextBox.Text = "محاسبه سن شما";
            birthTextBox.Focus();
            return;
        }

        PersianCalendar p = new PersianCalendar();
        DateTime dt = DateTime.Now;
        int y;
        y = p.GetYear(dt);
        int BirthDay = y - Age;
        var birthDay = BirthDay;
        ageTextBox.Text = birthDay.ToString();

    }

    private void Reset()
    {
        birthTextBox.Text = string.Empty;
        ageTextBox.Text = "محاسبه سن شما";
        birthTextBox.Focus();
       

    }
}
