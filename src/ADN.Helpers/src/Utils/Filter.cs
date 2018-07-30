using System;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Helpers.Utils
{
    public class Filter
    {
        private int _filterLength;
        private Queue<double> _queueData = new Queue<double>();
        private double _mean = 0;


        public Filter(int length)
        {
            // Check arguments
            if (length <= 0)
            {
                throw (new ArgumentException("param must be strictly positive"));
            }

            _filterLength = length;
        }

        public void Clear()
        {
            _queueData.Clear();
            _mean = 0;
        }

        public double Add(double value)
        {

            _queueData.Enqueue(value);
            _mean += value;

            if (_queueData.Count() > _filterLength)
            {
                _mean -= _queueData.Dequeue();
            }

            value = _mean / _queueData.Count();

            return value;
        }
    }
}
