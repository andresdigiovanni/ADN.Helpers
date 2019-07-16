# ADN.Helpers

# Content

- [Average](#T:ADN.Helpers.Average)

  - [RunningAverage(previousAvg, count, currentValue)](#Average.RunningAverage(previousAvg,count,currentValue))

- [EnumHelper](#T:ADN.Helpers.EnumHelper)

  - [GetEnumValue(enumType, name, ignoreCase)](#EnumHelper.GetEnumValue(enumType,name,ignoreCase))

- [Filter](#T:ADN.Helpers.Filter)

  - [Constructor(length)](#Filter.#ctor(length))

  - [Add(value)](#Filter.Add(value))

  - [Clear](#Filter.Clear)

- [Range](#T:ADN.Helpers.Range)

  - [Intersection(max1, min1, max2, min2, maxR, minR)](#Range.Intersection(max1,min1,max2,min2,maxR,minR))

- [ReflectiveSubclassEnumerator](#T:ADN.Helpers.ReflectiveSubclassEnumerator)

  - [GetEnumerableOfType`<T>(constructorArgs)](#ReflectiveSubclassEnumerator.GetEnumerableOfType`<T>(constructorArgs))

<a name='T:ADN.Helpers.Average'></a>


## Average

A static class to calculate averages.


#### Example

```csharp
double avg = 0;
int count = 0;
double value;

// insert first element
count++;
value = 1;

avg = Average.RunningAverage(avg, count, value);
/*
avg is 1
*/

// insert second element
count++;
value = 3;

avg = Average.RunningAverage(avg, count, value);
/*
avg is 2
*/
```

<a name='Average.RunningAverage(previousAvg,count,currentValue)'></a>


### RunningAverage(previousAvg, count, currentValue)

Calculate average.


#### Parameters

| Name | Description |
| ---- | ----------- |
| previousAvg | *System.Double*<br>Previous average. |

#### Parameters

| count | *System.Int32*<br>Number of elements with the new value. |

#### Parameters

| currentValue | *System.Double*<br>New value. |


#### Returns

Average.

*System.DivideByZeroException:* Number of elements is zero.

<a name='T:ADN.Helpers.EnumHelper'></a>


## EnumHelper

A static class of extension methods for .

<a name='EnumHelper.GetEnumValue(enumType,name,ignoreCase)'></a>


### GetEnumValue(enumType, name, ignoreCase)

Get enum value.


#### Parameters

| Name | Description |
| ---- | ----------- |
| enumType | *System.Type*<br>Enum type. |

#### Parameters

| name | *System.String*<br>Enum text value. |

#### Parameters

| ignoreCase | *System.Boolean*<br>Ignore case sensitive. |


#### Returns

Enum value.

*System.ArgumentException:* name is not a value in enumType.


#### Example

```csharp
enum Foo
{
A, B, C, D
}
var value = "A";
var type = typeof(Foo);
var ignoreCase = true;
var result = EnumHelper.GetEnumValue(type, value, ignoreCase);

/*
result is Foo.A
*/
```

<a name='T:ADN.Helpers.Filter'></a>


## Filter

Class to calculate filtered values.

<a name='Filter.#ctor(length)'></a>


### Constructor(length)

Class constructor.


#### Parameters

| Name | Description |
| ---- | ----------- |
| length | *System.Int32*<br>Number of last elements introduced to filter. |

*System.ArgumentException:* Param must be strictly positive.

<a name='Filter.Add(value)'></a>


### Add(value)

Add new element to filter.


#### Parameters

| Name | Description |
| ---- | ----------- |
| value | *System.Double*<br>New value. |


#### Returns

Filtered value.


#### Example

```csharp
var length = 3;
var filter = new Filter(length);
double result;

result = filter.Add(1);
//result is 1
result = filter.Add(2);
//result is 1.5
result = filter.Add(2);
//result is 1.67
result = filter.Add(2);
//result is 2
result = filter.Add(3);
//result is 2.33
result = filter.Add(3);
//result is 2.67
result = filter.Add(3);
//result is 3
```

<a name='Filter.Clear'></a>


### Clear

Remove all values from the filter queue.

<a name='T:ADN.Helpers.Range'></a>


## Range

A static class of utilities for ranges.

<a name='Range.Intersection(max1,min1,max2,min2,maxR,minR)'></a>


### Intersection(max1, min1, max2, min2, maxR, minR)

Calculate the intersection of the given ranges.


#### Parameters

| Name | Description |
| ---- | ----------- |
| max1 | *System.Double*<br>Maximum value of the first rank. |

#### Parameters

| min1 | *System.Double*<br>Minimum value of the first rank. |

#### Parameters

| max2 | *System.Double*<br>Maximum value of the second rank. |

#### Parameters

| min2 | *System.Double*<br>Minimum value of the second rank. |

#### Parameters

| maxR | *System.Double@*<br>Maximum value of the intersection range. |

#### Parameters

| minR | *System.Double@*<br>Minimum value of the intersection range. |


#### Returns

True if intersection exists, false otherwise.


#### Example

```csharp
double max1 = 20;
double min1 = 15;
double max2 = 21;
double min2 = 16;
double maxRresult;
double minRresult;
var result = Range.Intersection(max1, min1, max2, min2, out maxRresult, out minRresult);

/*
result is true
maxRresult is 20
minRresult is 16
*/
```

<a name='T:ADN.Helpers.ReflectiveSubclassEnumerator'></a>


## ReflectiveSubclassEnumerator

A static class of reflective enumerator.

<a name='ReflectiveSubclassEnumerator.GetEnumerableOfType`<T>(constructorArgs)'></a>


### GetEnumerableOfType`<T>(constructorArgs)

Gets all subclasses of the given abstract class.


#### Parameters

| Name | Description |
| ---- | ----------- |
| constructorArgs | *System.Object[]*<br>An array of arguments that match in number, order, and type the parameters of the constructor to invoke. If args is an empty array or null, the constructor that takes no parameters (the default constructor) is invoked. |


#### Returns

List of references to the newly created objects.


#### Example

```csharp
public class AbsFoo {}
public class Foo1 : AbsFoo { }
public class Foo2 : AbsFoo { }

var result = ReflectiveSubclassEnumerator.GetEnumerableOfType<AbsFoo>(null).ToList();

/*
result is [ Foo1, Foo2 ]
*/
```

