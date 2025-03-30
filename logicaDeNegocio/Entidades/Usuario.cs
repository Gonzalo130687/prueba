
namespace logicaDeNegocio.Entidades
{
   public class Usuario
    {
        public int Id { get;  set; }
        public string Email { get;  set; }
        public string Contrasena {  get; set; }

    
        public Usuario(int id, string email, string contrasena)
        {
            Id=id;
            Email = email;
            Contrasena = contrasena;
        }
    }
}
