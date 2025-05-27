using AutoMapper;
using backend.Infrastructure.Data.Repositories;

namespace backend.Core.Rules
{
    public class PreparoRegras
    {

        private readonly ReceitaRepositoy _receitaRepositoy;
        private readonly IMapper _mapper;
        public PreparoRegras(ReceitaRepositoy receitaRepositoy, IMapper mapper)
        {
            _receitaRepositoy = receitaRepositoy;
            _mapper = mapper;
        }



    }
}
