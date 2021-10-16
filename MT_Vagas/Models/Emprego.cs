




namespace MT_Vagas.Models
{
    public class Emprego
    {
        public string NomeCategoria { get; set; }

        public Emprego()
        {

        }

        public Emprego(Categoria categoria)
        {
            NomeCategoria = categoria.Nome;
        }
    }
}
