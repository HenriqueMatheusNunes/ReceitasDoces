namespace SistemaReceitas.Models
{
    public class Usuario
    {

        public int Id { get; set; }
        public string Username { get; set; }
        public string SenhaHash { get; set; }
        public bool IsAdmin { get; set; }
    }

    
}
