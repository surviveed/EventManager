using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EventManager.Entities
{
    public class UsuarioPapel
    {
        [Key, Column("usuario_id", Order = 0)]
        [ForeignKey("Usuario")]
        public int UsuarioId { get; set; }

        public virtual Usuario Usuario { get; set; }

        [Key, Column("papel_id", Order = 1)]
        [ForeignKey("Papel")]
        public int PapelId { get; set; }

        public virtual Papel Papel { get; set; }
    }
}
