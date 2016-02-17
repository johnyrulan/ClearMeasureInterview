using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClearMeasureInterview.PrintNumLib
{
    public class FizzBuzz
    {
        private int _upperbound;
        private IDictionary<int, string> _wordList;
        private bool _isWordListSorted;

        public FizzBuzz(int upperBound) : this(upperBound, null) {  }

        public FizzBuzz(int upperBound, IDictionary<int, string> wordList)
        {
            if (upperBound < 1)
            {
                throw new ArgumentException("The upperbound must be atleast one or greater.");
            }

            _upperbound = upperBound;

            if (wordList != null)
            {
                _wordList = wordList;
                _isWordListSorted = false;
            }

            else
            {
                _wordList = new Dictionary<int, string>();
                _isWordListSorted = true;
            }
        }

        public IEnumerable<string> CalculateFizzBuzzNumbers()
        {   
            // If the Dictionary is not sorted, sort it by descending 
            // so that it is optimized when searching through the dictionary
            if (!_isWordListSorted)
            {
                _wordList = _wordList.OrderByDescending(w => w.Key)
                                     .ToDictionary(w => w.Key, w => w.Value);

                _isWordListSorted = true;
            }

            for (int i = 1; i <= _upperbound; i++)
            {
                var highestMultiple = _wordList.Where(w => i % w.Key == 0)
                                               .Select(w => w.Value)
                                               .FirstOrDefault();

                yield return (highestMultiple != null) ? highestMultiple : i.ToString();
            }
        }
    }
}
