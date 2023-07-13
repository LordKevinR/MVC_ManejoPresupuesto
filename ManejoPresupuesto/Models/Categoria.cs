using System.ComponentModel.DataAnnotations;

namespace ManejoPresupuesto.Models
{
	public class Categoria
	{
        public int Id { get; set; }
		[Required(ErrorMessage = "El campo {0} es requerido")]
		[StringLength(maximumLength: 50, ErrorMessage = "El campo {0} solo puede contener un maximo de 50 caracteres")]
		public string Nombre { get; set; }

		[Display(Name = "Tipo Operación")]
		public TipoOperacion TipoOperacionId { get; set;}

        public int UsuarioId { get; set; }

    }
}
