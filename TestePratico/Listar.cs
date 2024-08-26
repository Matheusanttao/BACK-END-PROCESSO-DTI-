using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using System.Xml.Serialization;
using System.IO;
using System.Drawing;

namespace TestePratico
{
    public partial class Listar : Form
    {
        private List<Aluno> alunos;
        private string caminhoArquivo = @"C:\dadosxml\alunos.xml";

        public Listar()
        {
            InitializeComponent();
            alunos = CarregarDados();
            PreencherDataGridView();
            AjustarEstiloDataGridView();
        }

        private void PreencherDataGridView()
        {
            // Configurar Parte 1
            DgvParte1.ColumnCount = 3;
            DgvParte1.Columns[0].Name = "Nome do Aluno";
            DgvParte1.Columns[1].Name = "Média de Notas";
            DgvParte1.Columns[2].Name = "Frequência (%)";

            // Ajustar largura das colunas
            DgvParte1.Columns[0].Width = 250; 
            DgvParte1.Columns[1].Width = 150; 
            DgvParte1.Columns[2].Width = 150; 

            // Ajustar a altura das linhas
            DgvParte1.RowTemplate.Height = 30;

            // Preencher Parte 1 com dados dos alunos
            if (alunos.Count == 0)
            {
                DgvParte1.Rows.Add("Nenhum aluno cadastrado", "", "");
            }
            else
            {
                foreach (var aluno in alunos)
                {
                    DgvParte1.Rows.Add(aluno.Nome, aluno.MediaNotas.ToString("F2"), aluno.Frequencia);
                }
            }

            // Configurar Parte 2
            DgvParte2.ColumnCount = 1;
            DgvParte2.Columns[0].Name = "Informações";

            // Ajustar largura da coluna
            DgvParte2.Columns[0].Width = 600; // Largura da coluna Informações

            // Ajustar a altura das linhas
            DgvParte2.RowTemplate.Height = 30;

            ExibirDadosParte2();
        }

        private void AjustarEstiloDataGridView()
        {
            // Definir a fonte das células
            Font tamanhoFonte = new Font("Arial", 12); // Fonte maior para as células
            Color corFundoCabecalho = Color.LightSteelBlue;
            Color corFundoCelulas = Color.WhiteSmoke;
            Color corBorda = Color.LightGray;
            Color corFonte = Color.Black;

            // Aplicar a fonte às células dos DataGridView
            DgvParte1.DefaultCellStyle.Font = tamanhoFonte;
            DgvParte2.DefaultCellStyle.Font = tamanhoFonte;

            // Aplicar a fonte aos cabeçalhos das colunas
            DgvParte1.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);
            DgvParte2.ColumnHeadersDefaultCellStyle.Font = new Font("Arial", 12, FontStyle.Bold);

            // Estilo dos cabeçalhos
            DgvParte1.ColumnHeadersDefaultCellStyle.BackColor = corFundoCabecalho;
            DgvParte2.ColumnHeadersDefaultCellStyle.BackColor = corFundoCabecalho;
            DgvParte1.ColumnHeadersDefaultCellStyle.ForeColor = corFonte;
            DgvParte2.ColumnHeadersDefaultCellStyle.ForeColor = corFonte;

            // Estilo das células
            DgvParte1.DefaultCellStyle.BackColor = corFundoCelulas;
            DgvParte2.DefaultCellStyle.BackColor = corFundoCelulas;
            DgvParte1.DefaultCellStyle.ForeColor = corFonte;
            DgvParte2.DefaultCellStyle.ForeColor = corFonte;

            // Ajustar a aparência das bordas
            DgvParte1.BorderStyle = BorderStyle.FixedSingle;
            DgvParte2.BorderStyle = BorderStyle.FixedSingle;
            DgvParte1.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            DgvParte2.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
        }

        private void ExibirDadosParte2()
        {
            if (alunos.Count == 0)
            {
                DgvParte2.Rows.Add("Nenhum aluno cadastrado");
                return;
            }

            if (alunos.Any(a => a.Notas.Count < 5))
            {
                MessageBox.Show("Todos os alunos devem ter notas para todas as disciplinas.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Calcular a média da turma em cada disciplina
            double mediaNota1 = alunos.Average(a => a.Notas[0]);
            double mediaNota2 = alunos.Average(a => a.Notas[1]);
            double mediaNota3 = alunos.Average(a => a.Notas[2]);
            double mediaNota4 = alunos.Average(a => a.Notas[3]);
            double mediaNota5 = alunos.Average(a => a.Notas[4]);

            // Adicionar a média da turma ao DataGridView
            DgvParte2.Rows.Add($"Média da Turma: Nota 1: {mediaNota1:F2}, Nota 2: {mediaNota2:F2}, Nota 3: {mediaNota3:F2}, Nota 4: {mediaNota4:F2}, Nota 5: {mediaNota5:F2}");

            // Listar alunos com média acima da média da turma
            double mediaGeral = alunos.Average(a => a.MediaNotas);
            var alunosAcimaMedia = alunos.Where(a => a.MediaNotas > mediaGeral).Select(a => a.Nome).ToList();
            var alunosFrequenciaBaixa = alunos.Where(a => a.Frequencia < 75).Select(a => a.Nome).ToList();

            // Adicionar listas ao DataGridView
            DgvParte2.Rows.Add($"Alunos Acima da Média: {string.Join(", ", alunosAcimaMedia)}");
            DgvParte2.Rows.Add($"Alunos com Frequência Baixa: {string.Join(", ", alunosFrequenciaBaixa)}");
        }

        private List<Aluno> CarregarDados()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Aluno>));
                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        return (List<Aluno>)serializer.Deserialize(reader);
                    }
                }
                return new List<Aluno>();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return new List<Aluno>();
            }
        }

        

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }

}

