using System.Collections.Generic;
using System.Drawing;

namespace MemoryGame.Models.Enum
{
    /// <summary>
    /// 牌池
    /// </summary>
    public static class CardEnum
    {
        public static Bitmap question_mark = Properties.Resources.question_mark;
        public static Bitmap banana = Properties.Resources.banana;
        public static Bitmap baseball = Properties.Resources.baseball;
        public static Bitmap dices = Properties.Resources.dices;
        public static Bitmap fried_egg = Properties.Resources.fried_egg;
        public static Bitmap lemon = Properties.Resources.lemon;
        public static Bitmap tennis = Properties.Resources.tennis;
        public static Bitmap[] GetCards = new Bitmap[]
        {
            banana,
            baseball,
            dices,
            fried_egg,
            lemon,
            tennis
        };
    }
}
