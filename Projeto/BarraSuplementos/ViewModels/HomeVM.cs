using BarraSuplementos.Models;

namespace BarraSuplementos.ViewModels;

public class HomeVM
{
    public List<Produto> Produtos { get; set; }
    public List<Categoria> Categorias { get; set; }
}
