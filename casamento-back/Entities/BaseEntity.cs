using System.ComponentModel.DataAnnotations.Schema;

namespace casamento_back.Entities
{
    public class BaseEntity
    {
        [Column("id")]
        public int Id { get; set; }

        [Column("data_cadastro")]
        public DateTime DataCadastro { get; set; }
    }
}
