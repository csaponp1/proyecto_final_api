using Microsoft.AspNetCore.Mvc;
using System.Linq;
using api_empresa.Models;
using System.Threading.Tasks;

//Controller, una clase 
namespace api_empresa.Controllers{
    [Route("api/[controller]")]
    public class ProductosController : Controller{
        //creo la variable dbConexion(conexion a mysql)
        private Conexion dbConexion;

        //Constructor (se ejecuta cuando se llama a la clase)
        public ProductosController(){
            //ejectuta de una vez la variable creada
            dbConexion = Conectar.Create();
        }
        //ver todo el listado de registros
        [HttpGet]
        public ActionResult Get(){
            return Ok(dbConexion.Productos.ToArray());
        }
        //ver solo un registro, con el id
        [HttpGet("{id}")]
        public ActionResult Get(int id){
            var productos = dbConexion.Productos.SingleOrDefault(a => a.idproductos == id);
            if(productos != null){
                return Ok(productos);
            }else{
                return NotFound();
            }
        }
        

    }
}