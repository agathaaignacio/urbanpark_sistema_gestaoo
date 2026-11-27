using BackUrbanPark.Model.DTO;
using BackUrbanPark.Repository;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrmUrbanPark
{
    public partial class frmRegistrarEntrada : Form
    {
        private string _numVaga;
        private int _idVaga;

        public frmRegistrarEntrada()
        {
            InitializeComponent();
        }

        public frmRegistrarEntrada(string numVaga, int idVaga) : this()
        {
            _numVaga = numVaga;
            _idVaga = idVaga;
        }

        private void frmRegistrarEntrada_Load(object sender, EventArgs e)
        {
            txtVagaSelecionada.Text = _numVaga;
            txtVagaSelecionada.Enabled = false;
        }

        private void btnBuscarPorPlaca_Click(object sender, EventArgs e)
        {
            DadosEntradaVeiculo? dadosVeiculo = new DadosEntradaVeiculo();

            dadosVeiculo = EntradaRepository.BuscarDadosPorPlaca(mskPlacaveiculo.Text);

            if(dadosVeiculo == null)
            {
                MessageBox.Show("Veículo não encontrado", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                
                return;
            }

            txtNomeCliente.Text = dadosVeiculo.NomeCliente;
            txtCorModelo.Text = $"{dadosVeiculo.Cor} | {dadosVeiculo.Modelo}";
        }
    }
}
