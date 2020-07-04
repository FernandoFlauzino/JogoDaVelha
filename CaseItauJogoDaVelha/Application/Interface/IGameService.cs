using CaseItauJogoDaVelha.Application.Enumerator;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaseItauJogoDaVelha.Application.Interface
{
    public interface IGameService
    {
        public Task<string> HasWinner(List<List<Player>> matrix);
    }
}
