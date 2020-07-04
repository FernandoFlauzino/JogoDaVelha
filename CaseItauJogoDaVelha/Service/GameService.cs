using CaseItauJogoDaVelha.Application.Enumerator;
using CaseItauJogoDaVelha.Application.Helper;
using CaseItauJogoDaVelha.Application.Interface;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace CaseItauJogoDaVelha.Service
{
    public class GameService : IGameService
    {
        public Task<string> HasWinner(List<List<Player>> matrix)
        {
            var message = Constants.messageHasNotWinner;

           var result = CheckWinner(matrix);

            switch (result)
            {
                case Player.X:
                    message = Constants.messageWinnerX;
                    break;
                case Player.O:
                    message = Constants.messageWinnerO;
                    break;
               
            }

            return Task.FromResult(message);
        }

        private Player CheckWinner(List<List<Player>> matrix)
        {
            //check rows
            for (int rows = 0; rows < matrix.Count; rows++)
            {
                if (matrix[rows][0] == matrix[rows][1] && matrix[rows][0] == matrix[rows][2])
                {
                    if (matrix[rows][0] != Player.E)
                    {
                        return matrix[rows][0];
                    }
                }
            }

            //check columns
            for (int col = 0; col < matrix.Count; col++)
            {
                if (matrix[0][col] == matrix[1][col] && matrix[0][col] == matrix[2][col])
                {
                    if (matrix[0][col] != Player.E)
                    {
                        return matrix[0][col];
                    }
                }
            }


            //check diagonal
            if (matrix[0][0] == matrix[1][1] && matrix[0][0] == matrix[2][2])
            {
                if (matrix[0][0] != Player.E)
                {
                    return matrix[0][0];
                }
            }

            if (matrix[0][2] == matrix[1][1] && matrix[0][2] == matrix[2][0])
            {
                if (matrix[0][2] != Player.E)
                {
                    return matrix[0][2];
                }
            }

            return Player.E;
        }

       
    }
}
