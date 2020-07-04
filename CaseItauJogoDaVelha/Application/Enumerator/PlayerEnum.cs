using System;

namespace CaseItauJogoDaVelha.Application.Enumerator
{
    public class PlayerEnum
    {
        public static bool IsMemberEnum(string field)
        {
            Enum.TryParse(typeof(Player), field, true, out var result);

            return result != null;
        }
    }

    public enum Player
    {
        X,
        O,
        E // indica que o valor esta vazio EMPTY
    }
}
