using Microsoft.EntityFrameworkCore;

namespace Api.Models
{
    // Models/Produto.cs
    public class Produto
    {
        public int Id { get; set; }
        public string Nome { get; set; }

        [Precision(10, 2)] // <- Adiciona precisão: até 10 dígitos, com 2 casas decimais
        public decimal Preco { get; set; }
    }

}
