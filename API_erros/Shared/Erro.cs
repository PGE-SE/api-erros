using System;

namespace API_erros.Shared
{
    public class Erro 
    {
        public int ErroId { get; set; }
        public string ErroDescription { get; set; }
        public string Path { get; set; }
    }
}
