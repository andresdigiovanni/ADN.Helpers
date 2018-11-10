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
        private int _filterLength;
        private Queue<double> _queueData = new Queue<double>();
        private double _mean = 0;


        /// <summary>
        /// Class constructor.
        /// </summary>
        /// <param name="length">Number of last elements introduced to filter.</param>
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
