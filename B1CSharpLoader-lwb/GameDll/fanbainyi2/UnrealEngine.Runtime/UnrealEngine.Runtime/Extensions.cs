using System;
using System.Collections.Generic;
using System.Reflection;

namespace UnrealEngine.Runtime;

internal static class Extensions
{
	public static bool IsSameOrSubclassOfGeneric(this Type type, Type c)
	{
		while (type != null && type != typeof(object))
		{
			if ((type.IsGenericType ? type.GetGenericTypeDefinition() : type) == c)
			{
				return true;
			}
			type = type.BaseType;
		}
		return false;
	}

	public static bool IsSameOrSubclassOf(this Type type, Type c)
	{
		if (!(type == c))
		{
			return type.IsSubclassOf(c);
		}
		return true;
	}

	public static MethodInfo GetFirstMethod(this Type type, string methodName)
	{
		return type.GetFirstMethod(methodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public static MethodInfo GetFirstMethod(this Type type, string methodName, BindingFlags bindingFlags)
	{
		MethodInfo[] methods = type.GetMethods(bindingFlags);
		foreach (MethodInfo methodInfo in methods)
		{
			if (methodInfo.Name == methodName)
			{
				return methodInfo;
			}
		}
		return null;
	}

	public static MethodInfo GetMethodUnique(this Type type, string methodName)
	{
		return type.GetMethodUnique(methodName, BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);
	}

	public static MethodInfo GetMethodUnique(this Type type, string methodName, BindingFlags bindingFlags)
	{
		MethodInfo methodInfo = null;
		MethodInfo[] methods = type.GetMethods(bindingFlags);
		foreach (MethodInfo methodInfo2 in methods)
		{
			if (methodInfo2.Name == methodName)
			{
				if (methodInfo == null)
				{
					methodInfo = methodInfo2;
					return methodInfo2;
				}
				return null;
			}
		}
		return methodInfo;
	}

	public static string RemoveFromStart(this string str, string prefix)
	{
		if (prefix == null || !str.StartsWith(prefix))
		{
			return str;
		}
		return str.Substring(prefix.Length);
	}

	public static string RemoveFromEnd(this string str, string suffix)
	{
		if (suffix == null || !str.EndsWith(suffix))
		{
			return str;
		}
		return str.Substring(0, str.Length - suffix.Length);
	}

	public static void RemoveAtSwap<T>(this List<T> collection, int index)
	{
		collection[index] = collection[collection.Count - 1];
		collection.RemoveAt(collection.Count - 1);
	}

	public static void RemoveAtSwapEx<T>(this List<T> collection, ref int index, ref int indexField)
	{
		collection.RemoveAtSwap(index);
		indexField = index;
		index = -1;
	}

	public static void RemoveSwap<T>(this List<T> collection, T item)
	{
		collection[collection.IndexOf(item)] = collection[collection.Count - 1];
		collection.RemoveAt(collection.Count - 1);
	}

	public static Dictionary<string, ulong> GetEnumNamesValues(this Type type)
	{
		byte calculatedEnumByteSize;
		return type.GetEnumNamesValues(out calculatedEnumByteSize);
	}

	public static Dictionary<string, ulong> GetEnumNamesValues(this Type type, out byte calculatedEnumByteSize)
	{
		if (!type.IsEnum)
		{
			throw new Exception("Attempting to get the enum byte size from a non-enum type");
		}
		Dictionary<string, ulong> dictionary = new Dictionary<string, ulong>();
		calculatedEnumByteSize = 1;
		switch (Type.GetTypeCode(type.GetEnumUnderlyingType()))
		{
		case TypeCode.SByte:
			foreach (object value in Enum.GetValues(type))
			{
				byte b2 = (byte)(sbyte)value;
				dictionary[value.ToString()] = b2;
			}
			break;
		case TypeCode.Int16:
			foreach (object value2 in Enum.GetValues(type))
			{
				ushort num6 = (ushort)(short)value2;
				dictionary[value2.ToString()] = num6;
				if (num6 > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		case TypeCode.Int32:
			foreach (object value3 in Enum.GetValues(type))
			{
				uint num5 = (uint)(int)value3;
				dictionary[value3.ToString()] = num5;
				if (num5 > 65535)
				{
					calculatedEnumByteSize = 4;
				}
				else if (num5 > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		case TypeCode.Int64:
			foreach (object value4 in Enum.GetValues(type))
			{
				ulong num4 = (ulong)(long)value4;
				dictionary[value4.ToString()] = num4;
				if (num4 > uint.MaxValue)
				{
					calculatedEnumByteSize = 8;
				}
				else if (num4 > 65535)
				{
					calculatedEnumByteSize = 4;
				}
				else if (num4 > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		case TypeCode.Byte:
			foreach (object value5 in Enum.GetValues(type))
			{
				byte b = (byte)value5;
				dictionary[value5.ToString()] = b;
			}
			break;
		case TypeCode.UInt16:
			foreach (object value6 in Enum.GetValues(type))
			{
				ushort num3 = (ushort)value6;
				dictionary[value6.ToString()] = num3;
				if (num3 > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		case TypeCode.UInt32:
			foreach (object value7 in Enum.GetValues(type))
			{
				uint num2 = (uint)value7;
				dictionary[value7.ToString()] = num2;
				if (num2 > 65535)
				{
					calculatedEnumByteSize = 4;
				}
				else if (num2 > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		case TypeCode.UInt64:
			foreach (object value8 in Enum.GetValues(type))
			{
				ulong num = (ulong)value8;
				dictionary[value8.ToString()] = num;
				if (num > uint.MaxValue)
				{
					calculatedEnumByteSize = 8;
				}
				else if (num > 65535)
				{
					calculatedEnumByteSize = 4;
				}
				else if (num > 255)
				{
					calculatedEnumByteSize = 2;
				}
			}
			break;
		}
		return dictionary;
	}

	public static byte GetEnumByteSize(this Type type)
	{
		if (!type.IsEnum)
		{
			throw new Exception("Attempting to get the enum byte size from a non-enum type");
		}
		byte result = 1;
		switch (Type.GetTypeCode(type.GetEnumUnderlyingType()))
		{
		case TypeCode.SByte:
		case TypeCode.Byte:
			result = 1;
			break;
		case TypeCode.Int16:
			foreach (short value in Enum.GetValues(type))
			{
				if ((ushort)value > 255)
				{
					result = 2;
					break;
				}
			}
			break;
		case TypeCode.Int32:
			foreach (int value2 in Enum.GetValues(type))
			{
				if ((uint)value2 > 65535u)
				{
					result = 4;
					break;
				}
				if ((uint)value2 > 255u)
				{
					result = 2;
				}
			}
			break;
		case TypeCode.Int64:
			foreach (long value3 in Enum.GetValues(type))
			{
				if ((ulong)value3 > 4294967295uL)
				{
					result = 8;
					break;
				}
				if ((ulong)value3 > 65535uL)
				{
					result = 4;
				}
				else if ((ulong)value3 > 255uL)
				{
					result = 2;
				}
			}
			break;
		case TypeCode.UInt16:
			foreach (ushort value4 in Enum.GetValues(type))
			{
				if (value4 > 255)
				{
					result = 2;
					break;
				}
			}
			break;
		case TypeCode.UInt32:
			foreach (uint value5 in Enum.GetValues(type))
			{
				if (value5 > 65535)
				{
					result = 4;
					break;
				}
				if (value5 > 255)
				{
					result = 2;
				}
			}
			break;
		case TypeCode.UInt64:
			foreach (ulong value6 in Enum.GetValues(type))
			{
				if (value6 > uint.MaxValue)
				{
					result = 8;
					break;
				}
				if (value6 > 65535)
				{
					result = 4;
				}
				else if (value6 > 255)
				{
					result = 2;
				}
			}
			break;
		}
		return result;
	}
}
