using System;
using System.Collections.Generic;
using System.Linq;

namespace ADN.Helpers.Utils
{
    /// <summary>
    /// Class to calculate filtered values.
    /// </summary>
    public class Filter
    {
        private readonly int _filterLength;
        private Queue<double> _queueData = new Queue<double>();
        private double _mean = 0;


        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="length">Number of last elements introduced to filter.</param>
        /// <exception cref="ArgumentException">Param must be strictly positive.</exception>
        public Filter(int length)
        {
            // Check arguments
            if (length <= 0)
            {
                throw (new ArgumentException("param must be strictly positive"));
            }

            _filterLength = length;
        }

        /// <summary>
        /// Remove all values from the filter queue.
        /// </summary>
        public void Clear()
        {
            _queueData.Clear();
            _mean = 0;
        }

        /// <summary>
        /// Add new element to filter.
        /// </summary>
        /// <param name="value">New value.</param>
        /// <returns>Filtered value.</returns>
        /// <example>
        /// <code lang="csharp">
        /// var length = 3;
        /// var filter = new Filter(length);
        /// double result;
        /// 
        /// result = filter.Add(1);
        /// //result is 1
        /// result = filter.Add(2);
        /// //result is 1.5
        /// result = filter.Add(2);
        /// //result is 1.67
        /// result = filter.Add(2);
        /// //result is 2
        /// result = filter.Add(3);
        /// //result is 2.33
        /// result = filter.Add(3);
        /// //result is 2.67
        /// result = filter.Add(3);
        /// //result is 3
        /// </code>
        /// </example>
        public double Add(double value)
        {

            _queueData.Enqueue(value);
            _mean += value;

            if (_queueData.Count() > _filterLength)
            {
                _mean -= _queueData.Dequeue();
            }

            return _mean / _queueData.Count();
        }
    }
}
