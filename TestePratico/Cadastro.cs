using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace TestePratico
{
    public partial class Cadastro : Form
    {
        private List<Aluno> alunos = new List<Aluno>();
        private string caminhoArquivo = @"C:\dadosxml\alunos.xml";

        public Cadastro()
        {
            InitializeComponent();
            InitializeTrackBar();
            CarregarDados();
        }

        private void InitializeTrackBar()
        {
            trackBarFrequencia.Minimum = 0;
            trackBarFrequencia.Maximum = 100;
            trackBarFrequencia.TickFrequency = 10;
            trackBarFrequencia.Value = 0;

            UpdateLabel(trackBarFrequencia.Value);
            trackBarFrequencia.Scroll += TrackBarFrequencia_Scroll;
        }

        private void TrackBarFrequencia_Scroll(object sender, EventArgs e)
        {
            UpdateLabel(trackBarFrequencia.Value);
        }

        private void UpdateLabel(int value)
        {
            labelFrequencia.Text = $"{value}%";
        }

        private void BtnCadastro_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(TxtbNomeAluno.Text) ||
                CbNota1.SelectedItem == null ||
                CbNota2.SelectedItem == null ||
                CbNota3.SelectedItem == null ||
                CbNota4.SelectedItem == null ||
                CbNota5.SelectedItem == null)
            {
                MessageBox.Show("Por favor, preencha todos os campos antes de cadastrar o aluno.", "Campos incompletos", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            try
            {
                string nome = TxtbNomeAluno.Text;
                List<int> notas = new List<int>
                {
                    int.Parse(CbNota1.SelectedItem.ToString()),
                    int.Parse(CbNota2.SelectedItem.ToString()),
                    int.Parse(CbNota3.SelectedItem.ToString()),
                    int.Parse(CbNota4.SelectedItem.ToString()),
                    int.Parse(CbNota5.SelectedItem.ToString())
                };
                int frequencia = trackBarFrequencia.Value;

                alunos.Add(new Aluno
                {
                    Nome = nome,
                    Notas = notas,
                    Frequencia = frequencia
                });

                SalvarDados();

                MessageBox.Show("Aluno cadastrado com sucesso!", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                LimparCampos();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao cadastrar aluno: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LimparCampos()
        {
            TxtbNomeAluno.Clear();
            CbNota1.SelectedIndex = -1;
            CbNota2.SelectedIndex = -1;
            CbNota3.SelectedIndex = -1;
            CbNota4.SelectedIndex = -1;
            CbNota5.SelectedIndex = -1;
            trackBarFrequencia.Value = 0;
            UpdateLabel(0);
        }

        private void BtnVoltar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SalvarDados()
        {
            try
            {
              
                string diretorio = Path.GetDirectoryName(caminhoArquivo);
                if (!Directory.Exists(diretorio))
                {
                    Directory.CreateDirectory(diretorio);
                }

                XmlSerializer serializer = new XmlSerializer(typeof(List<Aluno>));
                using (StreamWriter writer = new StreamWriter(caminhoArquivo))
                {
                    serializer.Serialize(writer, alunos);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao salvar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CarregarDados()
        {
            try
            {
                if (File.Exists(caminhoArquivo))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Aluno>));
                    using (StreamReader reader = new StreamReader(caminhoArquivo))
                    {
                        alunos = (List<Aluno>)serializer.Deserialize(reader);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar dados: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
