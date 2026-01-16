using System;

namespace src
{
    public class Collatz
    {
        private bool CheckForEscapeSequenz (uint nCurrentNumber)
        {
            bool bResult = false;

            switch (nCurrentNumber)
            {
                case 1:
                    bResult = true;
                    break;
                case 2: 
                    bResult = true;
                    break;
                case 4: 
                    bResult = true;
                    break;
					case 0:
						bResult = true;
						break;
                default:
                    break;
            }

            return bResult;
        }

        private void AddEscapeSequenzToNumbers(List<uint> vnNumbers)
        {
            vnNumbers.Add(2);
            vnNumbers.Add(1);
        }

        private uint NumberIsEven (uint nCurrentNumber)
        {
            return nCurrentNumber / 2;
        }

        private uint NumberIsOdd (uint nCurrentNumber)
        {
            nCurrentNumber = 3 * nCurrentNumber;
            nCurrentNumber++;
            return nCurrentNumber;
        }

        public List<uint> CalcNumbers (uint nStartNumber)
        {
            List<uint> vnNumbers = new List<uint>();

            if(!CheckForEscapeSequenz(nStartNumber))
            {
                vnNumbers.Add(nStartNumber);

                while (!CheckForEscapeSequenz(nStartNumber))
                {
                    if (nStartNumber % 2 == 0) {
                        nStartNumber = NumberIsEven(nStartNumber);
                        vnNumbers.Add(nStartNumber);
                    } else {
                        nStartNumber = NumberIsOdd(nStartNumber);
                        vnNumbers.Add(nStartNumber);
                    }
                } 
            } 
                
            AddEscapeSequenzToNumbers(vnNumbers);
  
            return vnNumbers;
        }
    }
}