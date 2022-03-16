using DiarioGeneral.Entidades;
using System.Collections.Generic;
using System.Windows;

namespace DiarioGeneral.UI.Registros
{
    /// <summary>
    /// Interaction logic for rDiario.xaml
    /// </summary>
    public partial class rDiario : Window
    {
        public rDiario()
        {
            InitializeComponent();
            //creamos una lista para guardar 
            List<Diarios> diarios = new();

            //Agregamos los Resultados de la entrada de diario del 3
            diarios.Add(new Diarios("03/12/2022", 1003, "Efectivo Banco", 0, 7500000, 0));
            diarios.Add(new Diarios("03/12/2022", 01, "Banco Quisquellano", 7500000, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#1", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("03/12/2022", 3000, "Capital", 0, 0, 7500000));
            diarios.Add(new Diarios("Entrada/Diario#1", 0, "Registro De Capital", 0, 0, 0));

            diarios.Add(new Diarios("03/12/2022", 5000, "Compras", 0, 25500, 0));
            diarios.Add(new Diarios("Entrada/Diario#2", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("03/12/2022", 1003, "Efectivo Banco", 0, 0, 5100));
            diarios.Add(new Diarios("03/12/2022", 01, "Banco Quisquellano", 5100, 0, 0));
            diarios.Add(new Diarios("03/12/2022", 2002, "Cuentas Por Pagar", 0, 0, 20400));
            diarios.Add(new Diarios("03/12/2022", 01, "Estevan Toro", 20400, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#2", 0, "Registro De Compra De Mercancia", 0, 0, 0));

            //Agregamos los Resultados de la entrada de diario del 9
            diarios.Add(new Diarios("09/12/2022", 1000, "Efectivo Caja", 0, 12896, 0));
            diarios.Add(new Diarios("09/12/2022", 1005, "Cuantas Por Cobrar a Clientes", 0, 19334, 0));
            diarios.Add(new Diarios("Entrada/Diario#3", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("09/12/2022", 4000, "Venta", 0, 0, 32240));
            diarios.Add(new Diarios("Entrada/Diario#3", 0, "Registro De Venta", 0, 0, 0));

            diarios.Add(new Diarios("09/12/2022", 1003, "Efectivo Banco", 0, 12896, 0));
            diarios.Add(new Diarios("09/12/2022", 01, "Banco Quisquellano", 12896, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#4", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("09/12/2022", 1000, "Efectivo Caja", 0, 0, 12896));
            diarios.Add(new Diarios("Entrada/Diario#4", 0, "Registro De Deposito", 0, 0, 0));

            //Agregamos los Resultados de la entrada de diario del 12
            diarios.Add(new Diarios("12/12/2022", 3000, "Capital", 0, 0, 1500000));
            diarios.Add(new Diarios("12/12/2022", 01, "Estaban Toro", 1500000, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#5", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("12/12/2022", 1003, "Efectivo Banco", 0, 0, 1500000));
            diarios.Add(new Diarios("12/12/2022", 01, "Banco Quisquellano", 1500000, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#5", 0, "Registro De Disminucion de Aporte", 0, 0, 0));

            //Agregamos los Resultados de la entrada de diario del 24
            diarios.Add(new Diarios("12/24/2022", 1203, "Equipo De Oficina", 0, 10400, 0));
            diarios.Add(new Diarios("Entrada/Diario#6", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("12/24/2022", 1003, "Efectivo Banco", 0, 0, 10400));
            diarios.Add(new Diarios("12/24/2022", 02, "Banco Dominicano", 10400, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#5", 0, "Registro De Compra", 0, 0, 0));

            //Agregamos los Resultados de la entrada de diario del dia 31
            diarios.Add(new Diarios("12/31/2022", 6100, "Gastos Generales y Adm", 0, 14280, 0));
            diarios.Add(new Diarios("12/31/2022", 01, "Sueldo", 8160, 0, 0));
            diarios.Add(new Diarios("12/31/2022", 07, "Publicidad", 3120, 0, 0));
            diarios.Add(new Diarios("12/31/2022", 18, "Seguridad", 3000, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#7", 0, "@", 0, 0, 0));
            diarios.Add(new Diarios("12/31/2022", 1003, "Efectivo Banco", 0, 0, 14280));
            diarios.Add(new Diarios("12/31/2022", 01, "Banco Dominicano", 14280, 0, 0));
            diarios.Add(new Diarios("Entrada/Diario#7", 0, "Registro De Pagos", 0, 0, 0));

            DetalleDataGrid.ItemsSource = diarios;
        }
    }
}
