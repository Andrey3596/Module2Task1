namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            textN.Text = Properties.Settings.Default.textN.ToString();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            int n;
            try 
            {
                n = int.Parse(this.textN.Text);
            }
            catch (FormatException) 
            {
                return; 
            }

            //  передаем введенные значения в параметры
            Properties.Settings.Default.textN = n;
            Properties.Settings.Default.Save(); // сохраняем 


            MessageBox.Show(Logic.FindFirstGreaterThanN(n));
        }
    }

    public class Logic
    {
        public static string FindFirstGreaterThanN(int n)
        {
            string answer = "";
            for (int i = 1; i <= n; i++)
            {
                if (i * i > n)
                {
                    answer += n.ToString();
                    break;
                }
                answer += (i * i) + " ";
            }
            return answer;
        }
    }
}
