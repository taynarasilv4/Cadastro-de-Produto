
namespace Cadastro_de_Produto
{
    public partial class Form1 : Form
    {
        List<Produto> produtos = new List<Produto>();
        public Form1()
        {
            InitializeComponent();
            lb_ValorVenda.Text = "0.00";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Produto produto = new Produto();
            produto.Descricao = tx_Descricao.Text;
            produto.Codigo = tx_Codigo.Text;
            double precoAquisicao = Convert.ToDouble(tx_PrecoAquisicao.Text);
            double lucro = Convert.ToDouble(tx_Lucro.Text);
            double valorVenda = precoAquisicao + (precoAquisicao * lucro / 100);
            produto.ValorVenda = valorVenda;
            produto.PrecoAquisicao = precoAquisicao;
            produto.Lucro = lucro;
            lb_ValorVenda.Text = valorVenda.ToString();
            produtos.Add(produto);

            dataGridView1.DataSource = null;
            dataGridView1.Refresh();
            dataGridView1.DataSource = produtos;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            tx_Descricao.Clear();
            tx_Codigo.Clear();
            tx_PrecoAquisicao.Clear();
            tx_Lucro.Clear();
            lb_ValorVenda.Text = "";
        }
    }
}
