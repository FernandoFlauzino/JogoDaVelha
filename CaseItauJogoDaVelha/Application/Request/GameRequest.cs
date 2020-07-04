using CaseItauJogoDaVelha.Application.Enumerator;
using System;
using System.Collections.Generic;

namespace CaseItauJogoDaVelha.Application.Request
{
    public class GameRequest
    {

        private const int maxLenght = 3;

        internal List<List<Player>> Matrix { get; set; } = new List<List<Player>>();

        public List<List<string>> MatrixRequest { get; set; }


        internal bool IsValid()
        {
            var result = true;

            //validar se tem 3 linhas
            if (MatrixRequest.Count != maxLenght)
                result = false;


            //validar se cada linha tem 3 colunas
            foreach (var item in MatrixRequest)
            {
                if (item.Count != maxLenght)
                {
                    result = false;
                    break;
                }
            }

            if (result)
            {
                //preencher a Matrix com os valores do Enum
                for (int row = 0; row < MatrixRequest.Count; row++)
                {
                    var list = new List<Player>();

                    for (int column = 0; column < MatrixRequest[row].Count; column++)
                    {
                        if(!PlayerEnum.IsMemberEnum(MatrixRequest[row][column]))
                        {
                            //valores diferente de  X ou O  recebe o valor E (empty)
                            MatrixRequest[row][column] = Player.E.ToString();
                        }

                        var item = (Player)Enum.Parse(typeof(Player), MatrixRequest[row][column], true);

                        list.Add(item);
                    }

                    Matrix.Add(list);
                }

            }

            return result;
        }


    }
}
