namespace DBFirst
{
    public partial class Form1 : Form
    {
        TransactionDbContext _dbContext;
        public Form1()
        {
            InitializeComponent();

            _dbContext = new TransactionDbContext();
        }

        private void CargarGrid()
        {
            dataGridView1.DataSource = _dbContext.Clientes.ToList();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarGrid();
        }
    }
}
