namespace _5월12일_3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Button self = (Button)sender;
            self.Text = "저를 클릭했습니다.";
            textBox1.Text += "+";
            label.Text += "inch입력 : ";
        }

        //초 경과
        private int elapsedTime = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            elapsedTime++;
            textBox1.Text = elapsedTime + "초 경과";
            label1.Text = elapsedTime + "초 경과";
        }
        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}