using ADN.Helpers.Data;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace ADN.Helpers.Tests.Data
{
    public class ArrayHelperTest
    {
        [Theory]
        [ClassData(typeof(ArrayEqualData))]
        public void ArrayEqual(double[] first, double[] second, bool expected)
        {
            var result = ArrayHelper.ArrayEqual(first, second);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(CombineData))]
        public void Combine(double[] first, double[] second, double[] expected)
        {
            var result = ArrayHelper.Combine(first, second);

            Assert.Equal(expected, result);
        }

        [Theory]
        [ClassData(typeof(SetAllValuesData))]
        public void SetAllValues(double[] value, double setter, double[] expected)
        {
            var result = value.SetAllValues(setter);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SetAllValues_Exception_value_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SetAllValues(new double[] { }, 0));
        }

        [Fact]
        public void SetAllValues_Exception_value_Null()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SetAllValues(null, 0));
        }

        [Theory]
        [ClassData(typeof(SplitByNumberOfDivisionsData))]
        public void SplitByNumberOfDivisions(double[] value, int numberOfDivisions, double[][] expected)
        {
            var result = value.SplitByNumberOfDivisions(numberOfDivisions);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitByNumberOfDivisions_Exception_value_Null()
        {
            double[] value = null;
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SplitByNumberOfDivisions(value, 1));
        }

        [Fact]
        public void SplitByNumberOfDivisions_Exception_ZeroDivisions()
        {
            Assert.Throws<DivideByZeroException>(() => ArrayHelper.SplitByNumberOfDivisions(new double[0], 0));
        }

        [Theory]
        [ClassData(typeof(SplitByNumberOfElementsInDivisionData))]
        public void SplitByNumberOfElementsInDivision(double[] value, int elementsInDivision, double[][] expected)
        {
            var result = value.SplitByNumberOfElementsInDivision(elementsInDivision);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SplitByNumberOfElementsInDivision_Exception_value_Null()
        {
            double[] value = null;
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SplitByNumberOfElementsInDivision(value, 1));
        }

        [Fact]
        public void SplitByNumberOfElementsInDivision_Exception_ZeroDivisions()
        {
            Assert.Throws<DivideByZeroException>(() => ArrayHelper.SplitByNumberOfElementsInDivision(new double[0], 0));
        }

        [Theory]
        [ClassData(typeof(SubArrayData))]
        public void SubArray(double[] value, int index, int length, double[] expected)
        {
            var result = ArrayHelper.SubArray(value, index, length);

            Assert.Equal(expected, result);
        }

        [Fact]
        public void SubArray_Exception_value_Empty()
        {
            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SubArray(new double[] { }, 0, 1));
        }

        [Fact]
        public void SubArray_Exception_value_Null()
        {
            double[] list = null;

            Assert.Throws<ArgumentNullException>(() => ArrayHelper.SubArray(list, 0, 1));
        }

        [Fact]
        public void SubArray_Exception_Array_OutOfRange_Bottom()
        {
            double[] list = new double[] { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayHelper.SubArray(list, -1, 1));
        }

        [Fact]
        public void SubArray_Exception_Array_OutOfRange_Top()
        {
            double[] list = new double[] { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayHelper.SubArray(list, 2, 1));
        }

        [Fact]
        public void SubArray_Exception_Length_OutOfRange_Bottom()
        {
            double[] list = new double[] { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayHelper.SubArray(list, 0, -1));
        }

        [Fact]
        public void SubArray_Exception_Length_OutOfRange_Top()
        {
            double[] list = new double[] { 0, 1 };
            Assert.Throws<ArgumentOutOfRangeException>(() => ArrayHelper.SubArray(list, 0, 3));
        }

        public class ArrayEqualData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, new double[] { 0 }, true };
                yield return new object[] { new double[] { 0, 1 }, new double[] { 0, 1 }, true };
                yield return new object[] { new double[] { 0 }, new double[] { 0, 1 }, false };
                yield return new object[] { new double[] { }, new double[] { }, true };
                yield return new object[] { new double[] { }, new double[] { 0 }, false };
                yield return new object[] { new double[] { 0 }, new double[] { }, false };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class CombineData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2 }, new double[] { 3, 4, 5 }, new double[] { 0, 1, 2, 3, 4, 5 } };
                yield return new object[] { new double[] { 0 }, new double[] { }, new double[] { 0 } };
                yield return new object[] { new double[] { }, new double[] { 0 }, new double[] { 0 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SetAllValuesData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0 }, 1, new double[] { 1 } };
                yield return new object[] { new double[] { 0, 0, 0, 0, 0 }, 1, new double[] { 1, 1, 1, 1, 1 } };
                yield return new object[] { new double[] { 0, 0, 0, 0, 0 }, 1.2, new double[] { 1.2, 1.2, 1.2, 1.2, 1.2 } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SplitByNumberOfDivisionsData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, 1,
                    new double[0][]
                };
                yield return new object[] { new double[] { 0 }, 1,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0 }, 2,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 1,
                    new double[][] {
                        new double[] { 0, 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 2,
                    new double[][] {
                        new double[] { 0 },
                        new double[] { 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1, 2 }, 2,
                    new double[][] {
                        new double[] { 0, 1 },
                        new double[] { 2 }
                    }
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SplitByNumberOfElementsInDivisionData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { }, 1,
                    new double[0][]
                };
                yield return new object[] { new double[] { 0 }, 1,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0 }, 2,
                    new double[][] {
                        new double[] { 0 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 1,
                    new double[][] {
                        new double[] { 0 },
                        new double[] { 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1 }, 2,
                    new double[][] {
                        new double[] { 0, 1 }
                    }
                };
                yield return new object[] { new double[] { 0, 1, 2 }, 2,
                    new double[][] {
                        new double[] { 0, 1 },
                        new double[] { 2 }
                    }
                };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }

        public class SubArrayData : IEnumerable<object[]>
        {
            public IEnumerator<object[]> GetEnumerator()
            {
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 6, new double[] { 0, 1, 2, 3, 4, 5 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 1, 4, new double[] { 1, 2, 3, 4 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 1, new double[] { 0 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 5, 1, new double[] { 5 } };
                yield return new object[] { new double[] { 0, 1, 2, 3, 4, 5 }, 0, 0, new double[] { } };
            }

            IEnumerator IEnumerable.GetEnumerator() => GetEnumerator();
        }
    }
}
