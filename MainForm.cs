using EstoqueProdutos.Telas_Produtos;
using System.Data;

namespace EstoqueProdutos
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            AtualizarLabelContagem();
        }



        private void AtualizarLabelContagem()
        {
            lblContagem.Text = "Total de produtos: " + dtgProdutos.Rows.Count;
        }

        private async void btnPesquisar_Click(object sender, EventArgs e)
        {
            DataTable result = await SQLServer.Procedures.PesquisarProduto.ObterTodosProdutos(BarraProgresso());

            dtgProdutos.Rows.Clear();

            if (result.Rows.Count > 0)
                foreach (DataRow row in result.Rows)
                    dtgProdutos.Rows.Add(row[0], row[1], row[3], row[4], "R$ " + row[2], row[5]);
        }

        private IProgress<int> BarraProgresso()
        {
            progressBar.Visible = true;
            progressBar.Value = new Random().Next(1, 10);

            IProgress<int> progress = new Progress<int>(value =>
            {
                progressBar.Value = value;
            });

            return progress;
        }

        private void dtgProdutos_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {
            AtualizarLabelContagem();
        }

        private void btnCadastrarProduto_Click(object sender, EventArgs e)
        {
            FrmCadastroProduto frmCadastroProduto = new();
            frmCadastroProduto.ShowDialog();
        }
    }
}