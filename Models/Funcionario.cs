namespace CrudCsApi.Models
{
    public class Funcionario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Inscricao { get; set; }
        public int CodigoOcupacao { get; set; }
        public byte Foto { get; set; }
    }
}