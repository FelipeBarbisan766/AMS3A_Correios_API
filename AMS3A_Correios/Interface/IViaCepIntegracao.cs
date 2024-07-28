namespace AMS3A_Correios.Interface
{
    public interface IViaCepIntegracao
    {
        Task<Addres> ObterDados(string cep);
    }
}
