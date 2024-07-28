using Refit;

namespace AMS3A_Correios.Interface
{
    public interface IViaCepRefit
    {
        [Get("/ws/{cep}/json")]
        Task<ApiResponse<Addres>> ObterDados(string cep);
    }
}
