using System.Windows.Forms;

namespace _6월12일_2
{
    public partial class Form1 : Form
    {
        class Product
        {
            public string Name { get; set; }
            public int Price { get; set; }
        }

        public Form1()
        {
            InitializeComponent();

            //데이터 소스 선택
            var datasource = new List<Product>
            {
                new Product() { Name = "고구마", Price = 500},
                new Product() { Name = "감자", Price = 600},
                new Product() { Name = "호박", Price = 700}
            };

            var datasource1 = new List<Product>
            {
                new Product() { Name = "딸기", Price = 550},
                new Product() { Name = "포도", Price = 650},
                new Product() { Name = "바나나", Price = 750}
            };


            //콤보박스 설정
            comboBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Price";
            comboBox1.DataSource = datasource;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;

            //리스트 박스 설정
            listBox1.DisplayMember = "Name";
            comboBox1.ValueMember = "Price";
            listBox1.DataSource = datasource1;
            listBox1.SelectedIndexChanged += listBox1_SelectedIndexChanged;
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label2.Text =
            comboBox1.SelectedIndex
            + ":" + comboBox1.SelectedValue
            + ":" + ((Product)comboBox1.SelectedItem).Name;
            int comboBoxValue = comboBox1.SelectedIndex;
            int listBoxValue = comboBox1.SelectedIndex;
            int sum = comboBoxValue + listBoxValue;
            label6.Text = sum.ToString();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            label4.Text =
            listBox1.SelectedIndex
            + ":" + listBox1.SelectedValue
            + ":" + ((Product)listBox1.SelectedItem).Name;
            int comboBoxValue = comboBox1.SelectedIndex;
            int listBoxValue = comboBox1.SelectedIndex;
            int sum = comboBoxValue + listBoxValue;
            label6.Text = sum.ToString();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*dataGridView1.Datasource = datasource;*/
        }
        private void label6_Click(object sender, EventArgs e){}
    }
}