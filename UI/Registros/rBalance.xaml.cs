using DiarioGeneral.Entidades;
using System.Collections.Generic;
using System.Windows;

namespace DiarioGeneral.UI.Registros
{
    /// <summary>
    /// Interaction logic for rBalance.xaml
    /// </summary>
    public partial class rBalance : Window
    {
        public rBalance()
        {
            InitializeComponent();
            //creamos una lista para guardar 
            List<Balances> balances = new();

            //Agregamos los Resultados
            balances.Add(new Balances(1003, "Efectivo Banco", 5983116, 0));
            balances.Add(new Balances(1005, "Cuentas Por Cobrar", 19344, 0));
            balances.Add(new Balances(1203, "Equipo De Oficina", 10400, 0));
            balances.Add(new Balances(2002, "Cuentas Por Pagar a Proveedores", 0, 20400));
            balances.Add(new Balances(3000, "Capital", 0, 6000000));
            balances.Add(new Balances(4000, "Ventas", 0, 32240));
            balances.Add(new Balances(5000, "Compras", 25500, 0));
            balances.Add(new Balances(6001, "Gastos Generales y Administrativos", 14280, 0));
            balances.Add(new Balances(1111, "Total", 6052640, 6052640));

            DetalleDataGrid.ItemsSource = balances;
        }
    }
}
