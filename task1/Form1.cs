namespace task1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show(this.textN.Text);
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
