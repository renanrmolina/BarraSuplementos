using BarraSuplementos.ViewModels;

namespace BarraSuplementos.Services;

public interface IUsuarioService
{
    Task<UsuarioVM> GetUsuarioLogado();
}