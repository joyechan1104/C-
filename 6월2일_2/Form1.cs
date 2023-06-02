namespace _6월2일_3
{
    public partial class Form1 : Form
    {
        class customform : Form
        {
            public customform()
            {
                this.Size = new Size(400, 300);
                this.Text = "제목 글자";
            }
        }

        public Form1()
        {
            InitializeComponent();
            IsMdiContainer = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult result;
            do
            {
                MessageBox.Show("내용");
                MessageBox.Show("내용", "제목");
                result = MessageBox.Show("내용", "제목", MessageBoxButtons.RetryCancel);
            } while (result == DialogResult.Retry);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            customform form = new customform();
            form.MdiParent = this;
            form.Show();
        }
    }
}