namespace DiarioGeneral.Entidades
{
    class Balances
    {
        public int Cuenta { get; set; }
        public string Detalle { get; set; }
        public int Debito { get; set; }
        public int Credito { get; set; }

        public Balances(int cuenta, string detalle, int debito, int credito)
        {
            this.Cuenta = cuenta;
            this.Detalle = detalle;
            this.Debito = debito;
            this.Credito = credito;
        }
    }
}
