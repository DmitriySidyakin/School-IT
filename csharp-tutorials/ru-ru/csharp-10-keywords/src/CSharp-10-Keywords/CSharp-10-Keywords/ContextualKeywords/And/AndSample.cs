using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_10_Keywords.ContextualKeywords.And
{
    internal class AndSample
    {
        public static string HowOldIsMen(uint daysOld) => daysOld switch
        {
            <= 10 => "Новорождённые",
            >10 and <= 365 => "Грудной ребёнок",
            > 365 and <= (365 * 3) => "Раннее детство",
            > (365 * 3) and <= (365 * 7) => "Первый период детства",
            > (365 * 7) and <= (365 * 12) => "Второй период детства",
            > (365 * 12) and <= (365 * 16) => "Подростковый возраст",
            > (365 * 16) and <= (365 * 21) => "Юношеский возраст",
            > (365 * 21) and <= (365 * 35) => "Средний возраст (первый период)",
            > (365 * 35) and <= (365 * 60) => "Средний возраст (второй период)",
            > (365 * 60) and <= (365 * 75) => "Пожилые люди",
            > (365 * 75) and <= (365 * 90) => "Старческий возраст",
            > (365 * 90) => "Долгожители",
        };
    }
}
