using System.Diagnostics;

namespace AdoNet1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            ProductDAL _productDAL = new ProductDAL();
            LoadData(_productDAL);
        }

        private void LoadData(ProductDAL _productDAL)
        {
            List<Product> products = _productDAL.GetAll();

            dataGridView1.DataSource = products;
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void addBtn_Click(object sender, EventArgs e)
        {
            ProductDAL _productDAL = new ProductDAL();
            decimal price;
            int stock;

            if (decimal.TryParse(textBox2.Text, out price) && int.TryParse(textBox3.Text, out stock))
            {
                _productDAL.add(new Product
                {
                    name = textBox1.Text,
                    price = price,
                    stok = stock
                });

            }
            else
            {
                MessageBox.Show("Geçersiz fiyat veya stok deðeri girdiniz.");
            }
            LoadData(_productDAL);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox1.Clear();

        }

        private void button2_Click(object sender, EventArgs e)
        {
            ProductDAL _productDAL = new ProductDAL();
            decimal price;
            int stock;
            int id;
            int IdController = 0;
            if (int.TryParse(textBox4.Text, out id) && decimal.TryParse(textBox5.Text, out price) && int.TryParse(textBox6.Text, out stock))
            {

                if (_productDAL.GetByID(id) != 0)
                {

                    _productDAL.Update(new Product
                    {
                        Id = id,
                        price = price,
                        stok = stock
                    });
                    LoadData(_productDAL);
                }
                else
                {
                    MessageBox.Show("Bu ID'ye ait bir ürün bulunamadý.");
                }
            }
            else
            {
                MessageBox.Show("Geçersiz fiyat veya stok deðeri girdiniz.");
            }

            LoadData(_productDAL);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ProductDAL _productDAL = new ProductDAL();
            int id;
            int.TryParse(textBox7.Text, out id);
            if (_productDAL.GetByID(id)!=0)
            {
               
                _productDAL.Delete(id);
                LoadData(_productDAL);
            }
            else
            {
                MessageBox.Show("Bu ID'ye ait bir ürün bulunamadý.");
            }
            
        }
    }


}
