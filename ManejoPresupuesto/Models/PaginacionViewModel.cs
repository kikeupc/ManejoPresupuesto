namespace ManejoPresupuesto.Models
{
    public class PaginacionViewModel
    {
        public int Pagina { get; set; } = 1;
        private int recordsPorpagina = 10;
        private readonly int cantidadMaximaRecordsPorPagina = 50;

        public int RecordsPorPagina
        {
            get
            { 
                return recordsPorpagina;
            }
            set
            {
                recordsPorpagina = (value > cantidadMaximaRecordsPorPagina) ?
                    cantidadMaximaRecordsPorPagina : value;
            }
        }

        public int RecordsASaltar => recordsPorpagina * (Pagina - 1);
    }
}
