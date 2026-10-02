namespace FlexSpace.BLL
{
    public class negocio
    {
    public enum TipoCliente 
        { 
            Estandar, 
            VIP 
        }
        public enum TipoPuesto 
        { 
            EscritorioIndividual,
            SalaReuniones,
            CabinaPrivada 
        }
        public enum EstadoReserva 
        {
            Confirmada,
            Cancelada,
            Finalizada 
        }

        public class Cliente
        {
            public int Id { get; set; }
            public string Nombre { get; set; }
            public string Email { get; set; }
            public TipoCliente TipoCliente { get; set; }
            public int SancionesActivas { get; set; }
        }





    }
}
