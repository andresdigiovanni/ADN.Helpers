using ADN.Helpers.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xunit;

namespace ADN.Helpers.Tests.Data
{
    public class ListHelperTest
    {
        [Theory]
        [ClassData(typeof(IndexOfMaxData))]
        public void IndexOfMax(double[] values, int expected)
        {
            var result = values.IndexOfMax();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IndexOfMax_Exception_Value_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.IndexOfMax(new double[] { }));
        }

        [Fact]
        public void IndexOfMax_Exception_Value_Null()
        {
            List<double> list = null;
            Assert.Throws<ArgumentNullException>(() => list.IndexOfMax());
        }

        [Theory]
        [ClassData(typeof(IndexOfMinData))]
        public void IndexOfMin(double[] values, int expected)
        {
            var result = values.IndexOfMin();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void IndexOfMin_Exception_Value_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.IndexOfMin(new double[] { }));
        }

        [Fact]
        public void IndexOfMin_Exception_Value_Null()
        {
            List<double> list = null;
            Assert.Throws<ArgumentNullException>(() => list.IndexOfMin());
        }

        [Theory]
        [ClassData(typeof(IsSameData))]
        public void IsSame(double[] first, double[] second, bool expected)
        {
            var result = first.IsSame(second);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(ShuffleData))]
        public void Shuffle(double[] values)
        {
            double[] original = new double[values.Length];
            Array.Copy(values, 0, original, 0, values.Length);

            values.Shuffle();

            // check length
            bool ok = values.Length == original.Length;

            if (ok)
            {
                ok = false;

                if (values.Length == 1)
                {
                    ok = true;
                }
                else
                {
                    // check shuffle
                    for (int i = 0; i < values.Length; i++)
                    {
                        if (values[i] != original[i])
                        {
                            ok = true;
                            break;
                        }
                    }
                }

                // check same elements
                for (int i = 0; i < values.Length; i++)
                {
                    int countValues = 0;
                    int countOriginal = 0;

                    for (int j = 0; j < values.Length; j++)
                    {
                        if (values[j] == values[i])
                        {
                            countValues++;
                        }
                    }

                    for (int j = 0; j < original.Length; j++)
                    {
                        if (original[j] == values[i])
                        {
                            countOriginal++;
                        }
                    }

                    if (countValues != countOriginal)
                    {
                        ok = false;
                        break;
                    }
                }
            }

            Assert.True(ok);
        }

        [Fact]
        public void Shuffle_Exception_Value_Empty()
        {
            double[] values = new double[] { };

            Assert.Throws<ArgumentNullException>(() => values.Shuffle());
        }

        [Fact]
        public void Shuffle_Exception_Value_Null()
        {
            int[] values = null;

            Assert.Throws<ArgumentNullException>(() => values.Shuffle());
        }

        [Theory]
        [ClassData(typeof(MedianData))]
        public void Median(double[] values, double expected)
        {
            var result = values.Median();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Median_Exception_Value_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.Median(new double[] { }));
        }

        [Fact]
        public void Median_Exception_Value_Null()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.Median(null));
        }

        [Theory]
        [ClassData(typeof(MeanData))]
        public void Mean(double[] values, double expected)
        {
            List<double> list = new List<double>();
            list.AddRange(values);
            var result = list.Mean();

            Assert.Equal(expected, result);
        }

        [Fact]
        public void Mean_Exception_Value_Empty()
        {
            List<double> list = new List<double>();
            Assert.Throws<ArgumentNullException>(() => list.Mean());
        }

        [Fact]
        public void Mean_Exception_Value_Null()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.Mean(null));
        }

        [Theory]
        [ClassData(typeof(MeanDelimitedData))]
        public void MeanDelimited(double[] values, int start, int end, double expected)
        {
            List<double> list = new List<double>();
            list.AddRange(values);
            var result = list.Mean(start, end);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void MeanDelimited_Exception_Value_Empty()
        {
            List<double> list = new List<double>();
            Assert.Throws<ArgumentNullException>(() => list.Mean(0, 0));
        }

        [Fact]
        public void MeanDelimited_Exception_Value_Null()
        {
            Assert.Throws<ArgumentNullException>(() => ListHelper.Mean(null, 0, 0));
        }

        [Fact]
        public void MeanDelimited_Exception_Start_OutOfRange()
        {
            List<double> list = new List<double>() { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Mean(1, 0));
        }

        [Fact]
        public void MeanDelimited_Exception_Start_OutOfRange_Bottom()
        {
            List<double> list = new List<double>() { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Mean(-1, 1));
        }

        [Fact]
        public void MeanDelimited_Exception_Start_OutOfRange_Up()
        {
            List<double> list = new List<double>() { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Mean(2, 1));
        }

        [Fact]
        public void MeanDelimited_Exception_End_OutOfRange_Bottom()
        {
            List<double> list = new List<double>() { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Mean(0, -1));
        }

        [Fact]
        public void MeanDelimited_Exception_End_OutOfRange_Up()
        {
            List<double> list = new List<double>() { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => list.Mean(0, 2));
        }

        public class IndexOfMaxData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 9 };
                yield return new object[] { new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 0 };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 4, 3, 2, 1, 0 }, 5 };
                yield return new object[] { new double[] { 0, 0, 1, 1, 2, 2, 1, 1, 0, 0 }, 5 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class IndexOfMinData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0 };
                yield return new object[] { new double[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }, 9 };
                yield return new object[] { new double[] { 5, 4, 3, 2, 1, 0, 1, 2, 3, 4, 5 }, 5 };
                yield return new object[] { new double[] { 2, 2, 1, 1, 0, 0, 1, 1, 2, 2 }, 5 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class ShuffleData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 } };
                yield return new object[] { new double[] { 0, 0, 1, 1, 2, 2, 3, 3, 4, 4, 5, 5 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class IsSameData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, new double[] { }, true };
                yield return new object[] { new double[] { 0 }, new double[] { 0 }, true };
                yield return new object[] { new double[] { 0, 1 }, new double[] { 0, 1 }, true };
                yield return new object[] { new double[] { 0, 1 }, new double[] { 1, 0 }, true };
                yield return new object[] { new double[] { 0 }, new double[] { 0, 1 }, false };
                yield return new object[] { new double[] { 0, 1 }, new double[] { 0 }, false };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class MedianData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, 0 };
                yield return new object[] { new double[] { 1 }, 1 };
                yield return new object[] { new double[] { 2, 3, 5, 1, 4 }, 3 };
                yield return new object[] { new double[] { 2, 1, 4, 5, 3, 0 }, 2.5 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class MeanData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, 0 };
                yield return new object[] { new double[] { 1 }, 1 };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 4.5 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class MeanDelimitedData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, 0, 0, 0 };
                yield return new object[] { new double[] { 1 }, 0, 0, 1 };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 9, 4.5 };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 1, 8, 4.5 };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }, 0, 5, 2.5 };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
