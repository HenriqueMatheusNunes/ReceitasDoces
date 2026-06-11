namespace SistemaReceitas.Models
{
    public class Ingredientes
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        public string  Quantidade { get; set; }

        public int  ReceitaID { get; set; }


    }
}
