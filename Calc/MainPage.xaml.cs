namespace Calc
{
    public partial class MainPage : ContentPage
    {
        Int128 ans = 0;
        Int128 a = 0;
        char amal = '+';
        private void AddNum(int n)
        {
            ans *= 10;
            ans += n;
            lb.Text = ans.ToString();
        }

        public MainPage()
        {
            InitializeComponent();
        }
        private void N(object sender, EventArgs e)
        {
            lb.Text = "Hali amal qo'shilmagan";
        }
        private void cls(object sender, EventArgs e)
        {
            lb.Text = "0";
            ans = 0;
            a = 0;
            amal = '+';
        }
        private void backspace(object sender, EventArgs e)
        {
            if (ans != 0) ans /= 10;
            lb.Text = ans.ToString();
        }
        private void N0(object sender, EventArgs e)
        {
            AddNum(0);
        }
        private void N1(object sender, EventArgs e)
        {
            AddNum(1);
        }
        private void N2(object sender, EventArgs e)
        {
            AddNum(2);
        }
        private void N3(object sender, EventArgs e)
        {
            AddNum(3);
        }
        private void N4(object sender, EventArgs e)
        {
            AddNum(4);
        }
        private void N5(object sender, EventArgs e)
        {
            AddNum(5);
        }
        private void N6(object sender, EventArgs e)
        {
            AddNum(6);
        }
        private void N7(object sender, EventArgs e)
        {
            AddNum(7);
        }
        private void N8(object sender, EventArgs e)
        {
            AddNum(8);
        }
        private void N9(object sender, EventArgs e)
        {
            AddNum(9);
        }
        private void divide(object sender, EventArgs e)
        {
            amal = '/';
            a = ans;
            ans = 0;
            lb.Text = "";
        }
        private void multiple(object sender, EventArgs e)
        {
            amal = '*';
            a = ans;
            ans = 0;
            lb.Text = "";
        }
        private void minus(object sender, EventArgs e)
        {
            amal = '-';
            a = ans;
            ans = 0;
            lb.Text = "";
        }
        private void plus(object sender, EventArgs e)
        {
            amal = '+';
            a = ans;
            ans = 0;
            lb.Text = "";
        }
        private void equal(object sender, EventArgs e)
        {
            if (amal == '-')
            {
                lb.Text = (a - ans).ToString();
                ans -= a;
                a = 0;
            }
            else if (amal == '*')
            {
                lb.Text = (a * ans).ToString();
                ans *= a;
                a = 0;
            }
            else if(amal == '/')
            {
                if (a != 0)
                {
                    lb.Text = (a / ans).ToString();
                    ans /= a;
                    a = 0;
                }
                else
                {
                    lb.Text = "WRONG!";
                    ans = 0;
                    a = 0;
                }
            }
            else
            {
                lb.Text = (a + ans).ToString();
                ans += a;
                a = 0;
            }
        }

    }

}
