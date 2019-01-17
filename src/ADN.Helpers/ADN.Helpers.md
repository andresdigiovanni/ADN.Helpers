<a name='assembly'></a>
# ADN.Helpers

## Contents

- [ArrayHelper](#T-ADN-Helpers-Data-ArrayHelper 'ADN.Helpers.Data.ArrayHelper')
  - [ArrayEqual\`\`1(first,second)](#M-ADN-Helpers-Data-ArrayHelper-ArrayEqual``1-``0[],``0[]- 'ADN.Helpers.Data.ArrayHelper.ArrayEqual``1(``0[],``0[])')
  - [Combine\`\`1(first,second)](#M-ADN-Helpers-Data-ArrayHelper-Combine``1-``0[],``0[]- 'ADN.Helpers.Data.ArrayHelper.Combine``1(``0[],``0[])')
  - [SetAllValues\`\`1(array,value)](#M-ADN-Helpers-Data-ArrayHelper-SetAllValues``1-``0[],``0- 'ADN.Helpers.Data.ArrayHelper.SetAllValues``1(``0[],``0)')
  - [SplitByNumberOfDivisions\`\`1(array,numberOfDivisions)](#M-ADN-Helpers-Data-ArrayHelper-SplitByNumberOfDivisions``1-``0[],System-Int32- 'ADN.Helpers.Data.ArrayHelper.SplitByNumberOfDivisions``1(``0[],System.Int32)')
  - [SplitByNumberOfElementsInDivision\`\`1(array,elementsInDivision)](#M-ADN-Helpers-Data-ArrayHelper-SplitByNumberOfElementsInDivision``1-``0[],System-Int32- 'ADN.Helpers.Data.ArrayHelper.SplitByNumberOfElementsInDivision``1(``0[],System.Int32)')
  - [SubArray\`\`1(array,index,length)](#M-ADN-Helpers-Data-ArrayHelper-SubArray``1-``0[],System-Int32,System-Int32- 'ADN.Helpers.Data.ArrayHelper.SubArray``1(``0[],System.Int32,System.Int32)')
- [Average](#T-ADN-Helpers-Utils-Average 'ADN.Helpers.Utils.Average')
  - [RunningAverage(previousAvg,count,currentValue)](#M-ADN-Helpers-Utils-Average-RunningAverage-System-Double,System-Int32,System-Double- 'ADN.Helpers.Utils.Average.RunningAverage(System.Double,System.Int32,System.Double)')
- [Base64Helper](#T-ADN-Helpers-Data-Base64Helper 'ADN.Helpers.Data.Base64Helper')
  - [Base64Decode(base64EncodedData)](#M-ADN-Helpers-Data-Base64Helper-Base64Decode-System-String- 'ADN.Helpers.Data.Base64Helper.Base64Decode(System.String)')
  - [Base64Encode(plainText)](#M-ADN-Helpers-Data-Base64Helper-Base64Encode-System-String- 'ADN.Helpers.Data.Base64Helper.Base64Encode(System.String)')
- [ByteHelper](#T-ADN-Helpers-Data-ByteHelper 'ADN.Helpers.Data.ByteHelper')
  - [BytesToHexa(bytes,separator)](#M-ADN-Helpers-Data-ByteHelper-BytesToHexa-System-Byte[],System-String- 'ADN.Helpers.Data.ByteHelper.BytesToHexa(System.Byte[],System.String)')
  - [BytesToString(bytes)](#M-ADN-Helpers-Data-ByteHelper-BytesToString-System-Byte[]- 'ADN.Helpers.Data.ByteHelper.BytesToString(System.Byte[])')
  - [HexaToBytes(value,separator)](#M-ADN-Helpers-Data-ByteHelper-HexaToBytes-System-String,System-String- 'ADN.Helpers.Data.ByteHelper.HexaToBytes(System.String,System.String)')
  - [StringToBytes(value)](#M-ADN-Helpers-Data-ByteHelper-StringToBytes-System-String- 'ADN.Helpers.Data.ByteHelper.StringToBytes(System.String)')
- [DataTableHelper](#T-ADN-Helpers-Data-DataTableHelper 'ADN.Helpers.Data.DataTableHelper')
  - [ToHtmlTable(dataTable,tableCssClasses)](#M-ADN-Helpers-Data-DataTableHelper-ToHtmlTable-System-Data-DataTable,ADN-Helpers-Data-DataTableHelper-TableCssClasses- 'ADN.Helpers.Data.DataTableHelper.ToHtmlTable(System.Data.DataTable,ADN.Helpers.Data.DataTableHelper.TableCssClasses)')
- [DateTimeHelper](#T-ADN-Helpers-Data-DateTimeHelper 'ADN.Helpers.Data.DateTimeHelper')
  - [DateTimeToUnixTimeStamp(date)](#M-ADN-Helpers-Data-DateTimeHelper-DateTimeToUnixTimeStamp-System-DateTime- 'ADN.Helpers.Data.DateTimeHelper.DateTimeToUnixTimeStamp(System.DateTime)')
  - [UnixTimeStampToDateTime(unixTimestamp)](#M-ADN-Helpers-Data-DateTimeHelper-UnixTimeStampToDateTime-System-Int64- 'ADN.Helpers.Data.DateTimeHelper.UnixTimeStampToDateTime(System.Int64)')
- [DirectoryHelper](#T-ADN-Helpers-IO-DirectoryHelper 'ADN.Helpers.IO.DirectoryHelper')
  - [CopyDirectory(source,destination,overwrite)](#M-ADN-Helpers-IO-DirectoryHelper-CopyDirectory-System-String,System-String,System-Boolean- 'ADN.Helpers.IO.DirectoryHelper.CopyDirectory(System.String,System.String,System.Boolean)')
- [EnumHelper](#T-ADN-Helpers-Data-EnumHelper 'ADN.Helpers.Data.EnumHelper')
  - [GetEnumValue(enumType,name,ignoreCase)](#M-ADN-Helpers-Data-EnumHelper-GetEnumValue-System-Type,System-String,System-Boolean- 'ADN.Helpers.Data.EnumHelper.GetEnumValue(System.Type,System.String,System.Boolean)')
- [FileHelper](#T-ADN-Helpers-IO-FileHelper 'ADN.Helpers.IO.FileHelper')
  - [IsFileOpen(file,fileAccess)](#M-ADN-Helpers-IO-FileHelper-IsFileOpen-System-String,System-IO-FileAccess- 'ADN.Helpers.IO.FileHelper.IsFileOpen(System.String,System.IO.FileAccess)')
- [Filter](#T-ADN-Helpers-Utils-Filter 'ADN.Helpers.Utils.Filter')
  - [#ctor(length)](#M-ADN-Helpers-Utils-Filter-#ctor-System-Int32- 'ADN.Helpers.Utils.Filter.#ctor(System.Int32)')
  - [Add(value)](#M-ADN-Helpers-Utils-Filter-Add-System-Double- 'ADN.Helpers.Utils.Filter.Add(System.Double)')
  - [Clear()](#M-ADN-Helpers-Utils-Filter-Clear 'ADN.Helpers.Utils.Filter.Clear')
- [IntegerHelper](#T-ADN-Helpers-Data-IntegerHelper 'ADN.Helpers.Data.IntegerHelper')
  - [RoundNumber(value,step)](#M-ADN-Helpers-Data-IntegerHelper-RoundNumber-System-Double,System-Int32- 'ADN.Helpers.Data.IntegerHelper.RoundNumber(System.Double,System.Int32)')
  - [RoundNumber(value,step,min,max)](#M-ADN-Helpers-Data-IntegerHelper-RoundNumber-System-Double,System-Int32,System-Int32,System-Int32- 'ADN.Helpers.Data.IntegerHelper.RoundNumber(System.Double,System.Int32,System.Int32,System.Int32)')
- [ListHelper](#T-ADN-Helpers-Data-ListHelper 'ADN.Helpers.Data.ListHelper')
  - [IndexOfMax\`\`1(values)](#M-ADN-Helpers-Data-ListHelper-IndexOfMax``1-System-Collections-Generic-IList{``0}- 'ADN.Helpers.Data.ListHelper.IndexOfMax``1(System.Collections.Generic.IList{``0})')
  - [IndexOfMin\`\`1(values)](#M-ADN-Helpers-Data-ListHelper-IndexOfMin``1-System-Collections-Generic-IList{``0}- 'ADN.Helpers.Data.ListHelper.IndexOfMin``1(System.Collections.Generic.IList{``0})')
  - [Median(values)](#M-ADN-Helpers-Data-ListHelper-Median-System-Collections-Generic-IEnumerable{System-Double}- 'ADN.Helpers.Data.ListHelper.Median(System.Collections.Generic.IEnumerable{System.Double})')
  - [Shuffle\`\`1(values)](#M-ADN-Helpers-Data-ListHelper-Shuffle``1-System-Collections-Generic-IList{``0}- 'ADN.Helpers.Data.ListHelper.Shuffle``1(System.Collections.Generic.IList{``0})')
- [Range](#T-ADN-Helpers-Utils-Range 'ADN.Helpers.Utils.Range')
  - [Intersection(max1,min1,max2,min2,maxR,minR)](#M-ADN-Helpers-Utils-Range-Intersection-System-Double,System-Double,System-Double,System-Double,System-Double@,System-Double@- 'ADN.Helpers.Utils.Range.Intersection(System.Double,System.Double,System.Double,System.Double,System.Double@,System.Double@)')
- [StringHelper](#T-ADN-Helpers-Data-StringHelper 'ADN.Helpers.Data.StringHelper')
  - [Left(str,length)](#M-ADN-Helpers-Data-StringHelper-Left-System-String,System-Int32- 'ADN.Helpers.Data.StringHelper.Left(System.String,System.Int32)')
  - [Mid(str,startIndex,length)](#M-ADN-Helpers-Data-StringHelper-Mid-System-String,System-Int32,System-Int32- 'ADN.Helpers.Data.StringHelper.Mid(System.String,System.Int32,System.Int32)')
  - [Right(str,length)](#M-ADN-Helpers-Data-StringHelper-Right-System-String,System-Int32- 'ADN.Helpers.Data.StringHelper.Right(System.String,System.Int32)')

<a name='T-ADN-Helpers-Data-ArrayHelper'></a>
## ArrayHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

<a name='M-ADN-Helpers-Data-ArrayHelper-ArrayEqual``1-``0[],``0[]-'></a>
### ArrayEqual\`\`1(first,second) `method`

##### Summary

Checks if the Arrays are equal.

##### Returns

Returns `true`if all element match and `false`otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [\`\`0[]](#T-``0[] '``0[]') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that contains data to compare with. |
| second | [\`\`0[]](#T-``0[] '``0[]') | The [Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array')that contains data to compare to. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Array type. |

##### Example

```csharp
var first= new double[] { 0, 0, 0, 0, 0 };
var second = new double[] { 0, 0, 0, 0, 0 };
var result = first.ArrayEqual(second);
/*
result is true
*/ 
```

<a name='M-ADN-Helpers-Data-ArrayHelper-Combine``1-``0[],``0[]-'></a>
### Combine\`\`1(first,second) `method`

##### Summary

Combine the Arrays.

##### Returns

T[].

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| first | [\`\`0[]](#T-``0[] '``0[]') | First element to combine. |
| second | [\`\`0[]](#T-``0[] '``0[]') | Second element to combine. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | Array type. |

##### Example

```csharp
var first= new double[] { 0, 1, 2 };
var second = new double[] { 3, 4, 5 };
var result = first.Combine(second);
/*
result contains the values { 0, 1, 2, 3, 4, 5 }
*/ 
```

<a name='M-ADN-Helpers-Data-ArrayHelper-SetAllValues``1-``0[],``0-'></a>
### SetAllValues\`\`1(array,value) `method`

##### Summary

Sets all values.

##### Returns

A reference to the changed array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The one-dimensional, zero-based array. |
| value | [\`\`0](#T-``0 '``0') | The value. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be modified. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Array is null or empty. |

##### Example

```csharp
var array = new double[] { 0, 0, 0, 0, 0 };
var result = array.SetAllValues(1);
/*
result contains the values { 1, 1, 1, 1, 1 }
*/ 
```

<a name='M-ADN-Helpers-Data-ArrayHelper-SplitByNumberOfDivisions``1-``0[],System-Int32-'></a>
### SplitByNumberOfDivisions\`\`1(array,numberOfDivisions) `method`

##### Summary

Split an array into subarrays by specifying the number of divisions.

##### Returns

Subarrays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Array to split. |
| numberOfDivisions | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of divisions. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be split. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Array is null or empty. |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Number of divisions is zero. |

##### Example

```csharp
var array = new double[] { 0, 1, 2 };
var numberOfDivisions = 2;
var result = array.SplitByNumberOfDivisions(numberOfDivisions);
/*
result contains the values { { 0, 1 }, { 2 } }
*/ 
```

<a name='M-ADN-Helpers-Data-ArrayHelper-SplitByNumberOfElementsInDivision``1-``0[],System-Int32-'></a>
### SplitByNumberOfElementsInDivision\`\`1(array,elementsInDivision) `method`

##### Summary

Split an array into subarrays by specifying the number of elements in each division.

##### Returns

Subarrays.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | Array to split. |
| elementsInDivision | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Elements in each division. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be split. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | Array is null or empty. |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | Number of elements in division is zero. |

##### Example

```csharp
var array = new double[] { 0, 1, 2 };
var elementsInDivision = 2;
var result = array.SplitByNumberOfElementsInDivision(elementsInDivision);
/*
result contains the values { { 0, 1 }, { 2 } }
*/ 
```

<a name='M-ADN-Helpers-Data-ArrayHelper-SubArray``1-``0[],System-Int32,System-Int32-'></a>
### SubArray\`\`1(array,index,length) `method`

##### Summary

Subs the array.

##### Returns

T[].

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| array | [\`\`0[]](#T-``0[] '``0[]') | The data. |
| index | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The index. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | The length. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the array that will be modified. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | array is null or empty. |
| [System.ArgumentOutOfRangeException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentOutOfRangeException 'System.ArgumentOutOfRangeException') | index or length is out of range. |

##### Example

```csharp
var array = new double[] { 0, 1, 2, 3, 4, 5 };
var index = 1;
var length = 4;
var result = array.SubArray(index, length);
/*
result contains the values { 1, 2, 3, 4 }
*/ 
```

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

<a name='T-ADN-Helpers-Data-Base64Helper'></a>
## Base64Helper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of methods for Base64 strings.

<a name='M-ADN-Helpers-Data-Base64Helper-Base64Decode-System-String-'></a>
### Base64Decode(base64EncodedData) `method`

##### Summary

Converts the specified string, which encodes binary data as base-64 digits, to an equivalent plain text string.

##### Returns

Plain text string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| base64EncodedData | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String encoded with base-64 digits. |

##### Example

```csharp
var value = "MDEyMzQ1Njc4OQ==";
var result = value.Base64Decode();
/*
result is "0123456789"
*/ 
```

<a name='M-ADN-Helpers-Data-Base64Helper-Base64Encode-System-String-'></a>
### Base64Encode(plainText) `method`

##### Summary

Converts the value of a plain text string to its equivalent string representation that is encoded with base-64 digits.

##### Returns

String encoded with base-64 digits.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| plainText | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Plain text string. |

##### Example

```csharp
var value = "0123456789";
var result = value.Base64Encode();
/*
result is "MDEyMzQ1Njc4OQ=="
*/ 
```

<a name='T-ADN-Helpers-Data-ByteHelper'></a>
## ByteHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [Byte](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte 'System.Byte')[Array](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Array 'System.Array').

<a name='M-ADN-Helpers-Data-ByteHelper-BytesToHexa-System-Byte[],System-String-'></a>
### BytesToHexa(bytes,separator) `method`

##### Summary

Converts the numeric value of a byte array to its equivalent hexadecimal string.

##### Returns

Hexadecimal string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The value. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hexadecimal values separator. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | bytes is null |

##### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var separator = "-";
var result = array.BytesToHexa(separator);
/*
result is "30-31-32-33-34"
*/ 
```

<a name='M-ADN-Helpers-Data-ByteHelper-BytesToString-System-Byte[]-'></a>
### BytesToString(bytes) `method`

##### Summary

Decodes a sequence of bytes from the specified byte array into a string.

##### Returns

A string that contains the results of decoding the specified sequence of bytes.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| bytes | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | The byte array containing the sequence of bytes to decode. |

##### Example

```csharp
var array = new byte[] { 48, 49, 50, 51, 52 };
var result = array.BytesToString();
/*
result is "01234"
*/ 
```

##### Remarks

Equivalent to System.Text.Encoding.UTF8.GetString().

<a name='M-ADN-Helpers-Data-ByteHelper-HexaToBytes-System-String,System-String-'></a>
### HexaToBytes(value,separator) `method`

##### Summary

Converts the hexadecimal string to its quivalent numeric value byte array.

##### Returns

Byte array.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The value. |
| separator | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Hexadecimal values separator. |

##### Example

```csharp
var value = "30-31-32-33-34";
var separator = "-";
var result = value.HexaToBytes(separator);
/*
result contains the values { 48, 49, 50, 51, 52 }
*/ 
```

<a name='M-ADN-Helpers-Data-ByteHelper-StringToBytes-System-String-'></a>
### StringToBytes(value) `method`

##### Summary

Encodes a set of characters into a sequence of bytes.

##### Returns

A byte array containing the results of encoding the specified set of characters.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | The character array containing the characters to encode. |

##### Example

```csharp
var value = "01234";
var result = value.StringToBytes();
/*
result contains the values { 48, 49, 50, 51, 52 }
*/ 
```

##### Remarks

Equivalent to System.Text.Encoding.UTF8.GetBytes().

<a name='T-ADN-Helpers-Data-DataTableHelper'></a>
## DataTableHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable').

<a name='M-ADN-Helpers-Data-DataTableHelper-ToHtmlTable-System-Data-DataTable,ADN-Helpers-Data-DataTableHelper-TableCssClasses-'></a>
### ToHtmlTable(dataTable,tableCssClasses) `method`

##### Summary

Convert a DataTable to the equivalent HTML table.

##### Returns

HTML table.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| dataTable | [System.Data.DataTable](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Data.DataTable 'System.Data.DataTable') | DataTable to convert. |
| tableCssClasses | [ADN.Helpers.Data.DataTableHelper.TableCssClasses](#T-ADN-Helpers-Data-DataTableHelper-TableCssClasses 'ADN.Helpers.Data.DataTableHelper.TableCssClasses') | Optional parameter. CSS classes. |

##### Example

```csharp
DataTable table = new DataTable(new DataTableHelper.TableCssClasses()
{
    Table = new string[] { "c-table" },
    Tr = new string[] { "c-tr-1", "c-tr-2" },
    Th = new string[] { "c-th" },
    Td = new string[] { "c-td" },
});
// populate table
var result = table.ToHtmlTable(); 
```

<a name='T-ADN-Helpers-Data-DateTimeHelper'></a>
## DateTimeHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime').

<a name='M-ADN-Helpers-Data-DateTimeHelper-DateTimeToUnixTimeStamp-System-DateTime-'></a>
### DateTimeToUnixTimeStamp(date) `method`

##### Summary

Converts DateTime to unix time stamp.

##### Returns

The unix time stamp.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| date | [System.DateTime](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DateTime 'System.DateTime') | The DateTime. |

##### Example

```csharp
DateTime date = DateTime.Parse("02/16/2008 12:15:12", new CultureInfo("en-US"));
var result = date.DateTimeToUnixTimeStamp();
/*
result is 1203164112
*/ 
```

<a name='M-ADN-Helpers-Data-DateTimeHelper-UnixTimeStampToDateTime-System-Int64-'></a>
### UnixTimeStampToDateTime(unixTimestamp) `method`

##### Summary

Converts unix time stamp to DateTime.

##### Returns

The DateTime.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| unixTimestamp | [System.Int64](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int64 'System.Int64') | The unix time stamp. |

##### Example

```csharp
long unixTimestamp = 1203164112;
var result = unixTimestamp.UnixTimeStampToDateTime().ToString("MM/dd/yyyy HH:mm:ss");
/*
result is 02/16/2008 12:15:12
*/ 
```

<a name='T-ADN-Helpers-IO-DirectoryHelper'></a>
## DirectoryHelper `type`

##### Namespace

ADN.Helpers.IO

##### Summary

A static class of extension methods for [Directory](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.Directory 'System.IO.Directory').

<a name='M-ADN-Helpers-IO-DirectoryHelper-CopyDirectory-System-String,System-String,System-Boolean-'></a>
### CopyDirectory(source,destination,overwrite) `method`

##### Summary

Copy files from the source folder to destination folder overwriting the content

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| source | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Source folder |
| destination | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | Destination folder |
| overwrite | [System.Boolean](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Boolean 'System.Boolean') | Overwrite destination file |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.IO.DirectoryNotFoundException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.DirectoryNotFoundException 'System.IO.DirectoryNotFoundException') | Source directory does not exist or could not be found. |

##### Example

```csharp
var source = "sourceDir";
var destination = "destDir";
var overwrite = true;
DirectoryHelper.CopyDirectory(source, destination, overwrite); 
```

##### Remarks

This method check if is posible to override a file and retry it

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

<a name='T-ADN-Helpers-IO-FileHelper'></a>
## FileHelper `type`

##### Namespace

ADN.Helpers.IO

##### Summary

A static class of extension methods for [File](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.File 'System.IO.File').

<a name='M-ADN-Helpers-IO-FileHelper-IsFileOpen-System-String,System-IO-FileAccess-'></a>
### IsFileOpen(file,fileAccess) `method`

##### Summary

Check if a file is open.

##### Returns

True if file is open, false otherwise.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| file | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | File name. |
| fileAccess | [System.IO.FileAccess](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.IO.FileAccess 'System.IO.FileAccess') | File access. |

##### Example

```csharp
var file= "foo";
var fileAccess = FileAccess.ReadWrite;
var fileIsOpen = FileHelper.IsFileOpen(file, fileAccess)
/*
fileIsOpen is true if file is open, false otherwise.
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

<a name='T-ADN-Helpers-Data-IntegerHelper'></a>
## IntegerHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32').

<a name='M-ADN-Helpers-Data-IntegerHelper-RoundNumber-System-Double,System-Int32-'></a>
### RoundNumber(value,step) `method`

##### Summary

Rounds a value to the nearest integer with the given step.

##### Returns

The number nearest to value that is multiple of the given step.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | A double-precision floating-point number to be rounded. |
| step | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Step number to round. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | step is zero. |

##### Example

```csharp
double value = 12;
int step = 5;
var result = value.RoundNumber(step);
/*
result is 10
*/ 
```

<a name='M-ADN-Helpers-Data-IntegerHelper-RoundNumber-System-Double,System-Int32,System-Int32,System-Int32-'></a>
### RoundNumber(value,step,min,max) `method`

##### Summary

Rounds a value to the nearest integer with the given step and within the determined range.

##### Returns

The number nearest to value that is multiple of the given step and within the determined range.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| value | [System.Double](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Double 'System.Double') | A double-precision floating-point number to be rounded. |
| step | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Step number to round. |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Minimum value. |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Maximum value. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.DivideByZeroException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.DivideByZeroException 'System.DivideByZeroException') | step is zero. |

##### Example

```csharp
double value = 12;
int step = 5;
int min = 0;
int max = 20;
var result = value.RoundNumber(step, min, max);
/*
result is 10
*/ 
```

<a name='T-ADN-Helpers-Data-ListHelper'></a>
## ListHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [List\`1](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.List`1 'System.Collections.Generic.List`1').

<a name='M-ADN-Helpers-Data-ListHelper-IndexOfMax``1-System-Collections-Generic-IList{``0}-'></a>
### IndexOfMax\`\`1(values) `method`

##### Summary

Find the index of the maximum value of the list.

##### Returns

Index of the maximum value of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | List is null or empty. |

##### Example

```csharp
var values = new double[] { 10, 11, 12, 13, 12, 11, 10 };
var result = values.IndexOfMax();
/*
result is 3
*/ 
```

<a name='M-ADN-Helpers-Data-ListHelper-IndexOfMin``1-System-Collections-Generic-IList{``0}-'></a>
### IndexOfMin\`\`1(values) `method`

##### Summary

Find the index of the minimum value of the list.

##### Returns

Index of the minimum value of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | List is null or empty. |

##### Example

```csharp
var values = new double[] { 13, 12, 11, 10, 11, 12, 13 };
var result = values.IndexOfMin();
/*
result is 3
*/ 
```

<a name='M-ADN-Helpers-Data-ListHelper-Median-System-Collections-Generic-IEnumerable{System-Double}-'></a>
### Median(values) `method`

##### Summary

Gets the value of the middle element of the list after sorted.

##### Returns

Index of the middle element.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IEnumerable{System.Double}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IEnumerable 'System.Collections.Generic.IEnumerable{System.Double}') | The list of elements. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | List is null or empty. |

##### Example

```csharp
var values = new double[] { 2, 3, 5, 1, 4 };
var result = values.Median();
/*
result is 3
*/ 
```

<a name='M-ADN-Helpers-Data-ListHelper-Shuffle``1-System-Collections-Generic-IList{``0}-'></a>
### Shuffle\`\`1(values) `method`

##### Summary

Shuffle the elements of the list.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| values | [System.Collections.Generic.IList{\`\`0}](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Collections.Generic.IList 'System.Collections.Generic.IList{``0}') | The list of elements. |

##### Generic Types

| Name | Description |
| ---- | ----------- |
| T | The type of the elements of the list. |

##### Exceptions

| Name | Description |
| ---- | ----------- |
| [System.ArgumentNullException](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.ArgumentNullException 'System.ArgumentNullException') | List is null or empty. |

##### Example

```csharp
var values = new double[] { 0, 1, 2, 3, 4, 5 };
values.Shuffle(); 
```

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

<a name='T-ADN-Helpers-Data-StringHelper'></a>
## StringHelper `type`

##### Namespace

ADN.Helpers.Data

##### Summary

A static class of extension methods for [String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String').

<a name='M-ADN-Helpers-Data-StringHelper-Left-System-String,System-Int32-'></a>
### Left(str,length) `method`

##### Summary

Returns a string containing a specified number of characters from the left side of a string.

##### Returns

Returns a string containing a specified number of characters from the left side of a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which the leftmost characters are returned. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Numeric expression indicating how many characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Left(length);
/*
result is "abcde"
*/ 
```

<a name='M-ADN-Helpers-Data-StringHelper-Mid-System-String,System-Int32,System-Int32-'></a>
### Mid(str,startIndex,length) `method`

##### Summary

Returns a string that contains a specified number of characters starting from a specified position in a string.

##### Returns

A string that consists of the specified number of characters starting from the specified position in the string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which characters are returned. |
| startIndex | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Starting position of the characters to return. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Number of characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var startIndex = 3;
var length = 5;
var result = value.Mid(startIndex, length);
/*
result is "defgh"
*/ 
```

<a name='M-ADN-Helpers-Data-StringHelper-Right-System-String,System-Int32-'></a>
### Right(str,length) `method`

##### Summary

Returns a string containing a specified number of characters from the right side of a string.

##### Returns

Returns a string containing a specified number of characters from the right side of a string.

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| str | [System.String](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.String 'System.String') | String expression from which the rightmost characters are returned. |
| length | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Numeric expression indicating how many characters to return. |

##### Example

```csharp
var value = "abcdefghij";
var length = 5;
var result = value.Right(length);
/*
result is "fghij"
*/ 
```
