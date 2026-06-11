namespace SistemaReceitas.Models
{
    public class Receita
    {
      
        public int Id { get; set; }
        public string Nome { get; set; }

        public string ModoPreparo { get; set; }

        public  string Status { get; set; }

        public DateTime DataCriacao { get; set; }

        public int  UsuarioID { get; set; }



    }
}
