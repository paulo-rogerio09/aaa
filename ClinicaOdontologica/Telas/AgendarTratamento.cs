using ClinicaOdontologica.Entidades;
using ClinicaOdontologica.Telas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;
using System.Xml;

namespace ClinicaOdontologica.Telas
{
    public partial class AgendarTratamento : Form
    {
        private List<Tratamento> agendamento = new List<Tratamento>();
        public AgendarTratamento()
        {
            InitializeComponent();
        }

        private void cb_tratameto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void bt_excluir_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void bt_novo_Click(object sender, EventArgs e)
        {
            string ArquivoXml = "C:\\Users\\pedro\\source\\repos\\teste.XML";
            XElement XML = XElement.Load(ArquivoXml);

            var nomeElements = XML.Descendants("Nome");

            foreach (var nomeElement in nomeElements)
            {
                cb_clientes.Items.Add("Nome: " + nomeElement.Value);
            }

            cb_clientes.Enabled = true;
            cb_data.Enabled = true;
            cb_tratameto.Enabled = true;
            mb_data.Enabled = true;
        }

        private void AgendarTratamento_Load(object sender, EventArgs e)
        {

        }

        private void mask_data_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void ok_Click(object sender, EventArgs e)
        {
            Tratamento t = new Tratamento();
            try
            {
                
                t.Data = mb_data.Text;
                t.Horario = cb_data.Text;
                t.Horario = cb_data.Text;
                t.TipoTratamento = cb_tratameto.Text;



                agendamento.Add(t);
                dataGridView1.DataSource = null;
                dataGridView1.Refresh();
                dataGridView1.DataSource = agendamento;
            }
            catch (Exception ex)
            {
                
                MessageBox.Show("Há um erro de digitação. Tente novamente!");
            }
        }
    }
}
