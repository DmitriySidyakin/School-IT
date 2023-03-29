using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BruteForceSample
{
    public class BruteForce : IEnumerator<string>
    {
        public string Current {

            get {
                string result = "";

                for(int i = 0; i < CurrentPosition.Length; i++)
                {
                    result += Alphabet[CurrentPosition[i]];
                }

                return result;
            }
        }
        int[] CurrentPosition;

        object IEnumerator.Current => throw new NotImplementedException();
        protected int[] MinValue;
        protected int[] MaxValue;
        protected char[] Alphabet;
        public BruteForce(string alphabet, int[] minValue, int[] maxValue)
        {
            this.Alphabet = alphabet.ToCharArray();

            // Проверка на то, что minValue, maxValue содержит только допустимые символы алфавита 
            foreach (var min in minValue)
            {
                if(min < 0 && min > alphabet.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("minValue");
                }
            }

            foreach (var max in maxValue)
            {
                if (max < 0 && max > alphabet.Length - 1)
                {
                    throw new ArgumentOutOfRangeException("maxValue");
                }
            }

            // Проверка на то, что minValue и maxValue имеют смысл соответствия
            if (minValue.Length < maxValue.Length)
            {
                this.MinValue = minValue;
                this.MaxValue = maxValue;
                this.CurrentPosition = (int[])minValue.Clone();
            }
            else
            {
                // Проверка на то, что аргументы заданы верно.
                
                // Если начальная комбинация больше конечной ...
                if(minValue.Length > maxValue.Length)
                {
                    throw new ArgumentOutOfRangeException("minValue, maxValue");
                }

                // Если комбинации равны ...
                for (int i = 0; i < maxValue.Length; i++)
                {
                    if (minValue[i] < maxValue[i])
                        break;
                    if (minValue[i] > maxValue[i])
                        throw new ArgumentOutOfRangeException("minValue, maxValue");
                }

                this.MinValue = minValue;
                this.MaxValue = maxValue;
                this.CurrentPosition = (int[])minValue.Clone();
            }
        }

        public void Dispose() { }

        public bool MoveNext()
        {
            if (!HasNext()) return false;

            CurrentPosition[0]++;

            for (int i = 0; i < CurrentPosition.Length; i++)
            {
                if(CurrentPosition[i] >= Alphabet.Length)
                {
                    if (!(CurrentPosition.Length - 1 <= i + 1))
                        CurrentPosition.Append(0);

                    CurrentPosition[i + 1]++;
                    CurrentPosition[i] = 0;
                }
            }

            return true;
        }

        public bool HasNext()
        {
            if (CurrentPosition.Length <= MaxValue.Length)
                return true;

            if (CurrentPosition.Length > MaxValue.Length)
                return false;

            int i;
            for(i = 0; i < MaxValue.Length - 1; i++)
            {
                if (CurrentPosition[i] != MaxValue[i])
                    break;
            }

            return i == MaxValue.Length - 1 ? true : false;
        }

        public void Reset()
        {
            this.CurrentPosition = (int[])MinValue.Clone();
        }
    }
}