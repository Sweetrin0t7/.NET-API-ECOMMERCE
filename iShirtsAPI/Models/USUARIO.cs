using iShirtsAPI.Models.Enums;

namespace iShirtsAPI.Models
{
    public class USUARIO
    {
        public int ID_USUARIO { get; set; }
        public string EMAIL { get; set; }
        public string NOME { get; set; }
        public string SENHA { get; set; }
        public string CPF { get; set; }
        public CargoEnum CARGO { get; set; }
        public AtivoEnum ATIVO { get; set; }

    }
}
