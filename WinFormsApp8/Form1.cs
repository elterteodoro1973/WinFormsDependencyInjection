using TaskManager.API.Data.Configurations;
using TaskManager.API.Data.Repositories;
using TaskManager.API.Models;

namespace WinFormsApp8
{
    public partial class Form1 : Form
    {
        private ITarefasRepository _tarefasRepository;

        public Form1(ITarefasRepository tarefasRepository)
        {
            InitializeComponent();
            _tarefasRepository = tarefasRepository;            
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            var tarefa = new Tarefa(txtNome1.Text, txtDetalhe1.Text);

            _tarefasRepository.Adicionar(tarefa);
            this.Abrir_Click(sender , e);
        }

        private void Abrir_Click(object sender, EventArgs e)
        {
            var tarefas = _tarefasRepository.Buscar().ToList();
            dataGridView1.DataSource = tarefas;
        }
    }
}
