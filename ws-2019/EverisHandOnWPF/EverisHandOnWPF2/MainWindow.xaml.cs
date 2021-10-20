using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Channels;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using EverisHandOnWPF2.Models;

namespace EverisHandOnWPF2
{
    /// <summary>
    /// Interação lógica para MainWindow.xam
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        public void BtnSalvarClick(object sender, EventArgs e)
        {
            Clientes cli = new Cliente();
            cli.NomeCliente = nomeCliente.text;
            cli.Genero = cmbGenero.SelectedValue.ToString();
            cli.GeneroAventura = chbAventura.IsChecked == true;
            cli.GeneroOutros = chbOutros.IsChecked == true;
            cli.GeneroRomance = chbRomance.IsChecked == true;
            cli.GeneroTerror = chbTerror.IsChecked == true;
            if (rdCasado.IsChecked == true)
            {
                cli.EstadoCivil = "Casado";
            }
            else if (rdSolteiro.IsChecked == true)
            {
                cli.EstadoCivil = "Solteiro";
            }
            else if (rdDivorciado.IsChecked == true)
            {
                cli.EstadoCivil = "Divorciado";
            }
            else if (rdViuvo.IsChecked == true)
            { 
                cli.EstadoCivil = "Viuvo";
            }
            cli.DataNascimento=dpDataNascimento.SelectDate??Date.Time.MinValue;
            // Regra de Negocio
            MessageBox.Show("Nome do Cliente: " + cli.NomeCliente, "Teste", MessageBoxButton.OK, MessageBoxButton)
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {

        }
        private void ListView_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Cliente cliente = listaClientes.SelectedValue as cliente;
        }
    }
}
