<a name='assembly'></a>
# ADN.Helpers

## Contents

- [Average](#T-ADN-Helpers-Utils-Average 'ADN.Helpers.Utils.Average')
  - [RunningAverage(previousAvg,count,currentValue)](#M-ADN-Helpers-Utils-Average-RunningAverage-System-Double,System-Int32,System-Double- 'ADN.Helpers.Utils.Average.RunningAverage(System.Double,System.Int32,System.Double)')
- [EnumHelper](#T-ADN-Helpers-Data-EnumHelper 'ADN.Helpers.Data.EnumHelper')
  - [GetEnumValue(enumType,name,ignoreCase)](#M-ADN-Helpers-Data-EnumHelper-GetEnumValue-System-Type,System-String,System-Boolean- 'ADN.Helpers.Data.EnumHelper.GetEnumValue(System.Type,System.String,System.Boolean)')
- [Filter](#T-ADN-Helpers-Utils-Filter 'ADN.Helpers.Utils.Filter')
  - [#ctor(length)](#M-ADN-Helpers-Utils-Filter-#ctor-System-Int32- 'ADN.Helpers.Utils.Filter.#ctor(System.Int32)')
  - [Add(value)](#M-ADN-Helpers-Utils-Filter-Add-System-Double- 'ADN.Helpers.Utils.Filter.Add(System.Double)')
  - [Clear()](#M-ADN-Helpers-Utils-Filter-Clear 'ADN.Helpers.Utils.Filter.Clear')
- [Range](#T-ADN-Helpers-Utils-Range 'ADN.Helpers.Utils.Range')
  - [Intersection(max1,min1,max2,min2,maxR,minR)](#M-ADN-Helpers-Utils-Range-Intersection-System-Double,System-Double,System-Double,System-Double,System-Double@,System-Double@- 'ADN.Helpers.Utils.Range.Intersection(System.Double,System.Double,System.Double,System.Double,System.Double@,System.Double@)')

<a name='T-ADN-Helpers-Utils-Average'></a>
## Average `type`

##### Namespace

ADN.Helpers.Utils

##### Summary

A static class to calculate averages.

##### Example

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

<a name='M-ADN-Helpers-Utils-Average-RunningAverage-System-Double,System-Int32,System-Double-'></a>
### RunningAverage(previousAvg,count,currentValue) `method`

##### Summary

Calculate average.

##### Returns

Average.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| previousAvg | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Previous average. |
| count | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of elements with the new value. |
| currentValue | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Number of elements is zero. |

<a name='T-ADN-Helpers-Data-EnumHelper'></a>
## EnumHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [Enum](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Enum 'System.Enum').

<a name='M-ADN-Helpers-Data-EnumHelper-GetEnumValue-System-Type,System-String,System-Boolean-'></a>
### GetEnumValue(enumType,name,ignoreCase) `method`

##### Summary

Get enum value.

##### Returns

Enum value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| enumType | [System.Type](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Type 'System.Type') | Enum type. |
| name | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Enum text value. |
| ignoreCase | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Ignore case sensitive. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | name is not a value in enumType. |

##### Example

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

<a name='T-ADN-Helpers-Utils-Filter'></a>
## Filter `type`

##### Namespace

ADN.Helpers.Utils

##### Summary

Class to calculate filtered values.

<a name='M-ADN-Helpers-Utils-Filter-#ctor-System-Int32-'></a>
### #ctor(length) `constructor`

##### Summary

Class constructor.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of last elements introduced to filter. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentException 'System.ArgumentException') | Param must be strictly positive. |

<a name='M-ADN-Helpers-Utils-Filter-Add-System-Double-'></a>
### Add(value) `method`

##### Summary

Add new element to filter.

##### Returns

Filtered value.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | New value. |

##### Example

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

<a name='M-ADN-Helpers-Utils-Filter-Clear'></a>
### Clear() `method`

##### Summary

Remove all values from the filter queue.

##### Parameters

This method has no parameters.

<a name='T-ADN-Helpers-Utils-Range'></a>
## Range `type`

##### Namespace

ADN.Helpers.Utils

##### Summary

A static class of utilities for ranges.

<a name='M-ADN-Helpers-Utils-Range-Intersection-System-Double,System-Double,System-Double,System-Double,System-Double@,System-Double@-'></a>
### Intersection(max1,min1,max2,min2,maxR,minR) `method`

##### Summary

Calculate the intersection of the given ranges.

##### Returns

True if intersection exists, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| max1 | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Maximum value of the first rank. |
| min1 | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Minimum value of the first rank. |
| max2 | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Maximum value of the second rank. |
| min2 | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | Minimum value of the second rank. |
| maxR | [System.Double@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double@ 'System.Double@') | Maximum value of the intersection range. |
| minR | [System.Double@](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double@ 'System.Double@') | Minimum value of the intersection range. |

##### Example

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
