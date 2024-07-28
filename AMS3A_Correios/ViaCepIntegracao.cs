using AMS3A_Correios.Interface;

namespace AMS3A_Correios
{
    public class ViaCepIntegracao : IViaCepIntegracao
    {
        private readonly IViaCepRefit _viaCepRefit;

        public ViaCepIntegracao(IViaCepRefit viaCepRefit)
        {
            _viaCepRefit = viaCepRefit;
        }
    
        public async Task<Addres> ObterDados(string cep)
        {
            var responseData = await _viaCepRefit.ObterDados(cep);

            return responseData.Content;
        }
    }
}
