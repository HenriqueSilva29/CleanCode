using AutoMapper;
using backend.Infrastructure.Data.Repositories;

namespace backend.Core.Rules
{
    public class PreparoRegras
    {

        private readonly ReceitaRepository _receitaRepositoy;
        private readonly IMapper _mapper;
        public PreparoRegras(ReceitaRepository receitaRepositoy, IMapper mapper)
        {
            _receitaRepositoy = receitaRepositoy;
            _mapper = mapper;
        }



    }
}
