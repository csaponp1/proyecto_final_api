using Microsoft.EntityFrameworkCore;
namespace api_empresa.Models{
    class Conexion : DbContext {
         public Conexion (DbContextOptions<Conexion> options) : base(options){}
        public DbSet<Productos> Productos {get;set;}
         

    }
    class Conectar{
        private const string cadenaConexion = "server=localhost;port=3306;database=bd_final_csapon;userid=usr_empresa_3;pwd=lasviejas!123";
        public static Conexion Create(){
            var constructor = new DbContextOptionsBuilder<Conexion>();
            constructor.UseMySQL(cadenaConexion);
            var cn = new Conexion(constructor.Options);
            return cn;
        }
    }
}