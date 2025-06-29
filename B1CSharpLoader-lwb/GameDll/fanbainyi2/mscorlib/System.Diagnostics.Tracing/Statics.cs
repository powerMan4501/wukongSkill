using System.Collections.Generic;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;

namespace System.Diagnostics.Tracing;

internal static class Statics
{
	public const byte DefaultLevel = 5;

	public const byte TraceLoggingChannel = 11;

	public const byte InTypeMask = 31;

	public const byte InTypeFixedCountFlag = 32;

	public const byte InTypeVariableCountFlag = 64;

	public const byte InTypeCustomCountFlag = 96;

	public const byte InTypeCountMask = 96;

	public const byte InTypeChainFlag = 128;

	public const byte OutTypeMask = 127;

	public const byte OutTypeChainFlag = 128;

	public const EventTags EventTagsMask = (EventTags)268435455;

	public static readonly TraceLoggingDataType IntPtrType = ((IntPtr.Size == 8) ? TraceLoggingDataType.Int64 : TraceLoggingDataType.Int32);

	public static readonly TraceLoggingDataType UIntPtrType = ((IntPtr.Size == 8) ? TraceLoggingDataType.UInt64 : TraceLoggingDataType.UInt32);

	public static readonly TraceLoggingDataType HexIntPtrType = ((IntPtr.Size == 8) ? TraceLoggingDataType.HexInt64 : TraceLoggingDataType.HexInt32);

	public static byte[] MetadataForString(string name, int prefixSize, int suffixSize, int additionalSize)
	{
		CheckName(name);
		int num = Encoding.UTF8.GetByteCount(name) + 3 + prefixSize + suffixSize;
		byte[] array = new byte[num];
		ushort num2 = checked((ushort)(num + additionalSize));
		array[0] = (byte)num2;
		array[1] = (byte)(num2 >> 8);
		Encoding.UTF8.GetBytes(name, 0, name.Length, array, 2 + prefixSize);
		return array;
	}

	public static void EncodeTags(int tags, ref int pos, byte[] metadata)
	{
		int num = tags & 0xFFFFFFF;
		bool flag;
		do
		{
			byte b = (byte)((num >> 21) & 0x7F);
			flag = (num & 0x1FFFFF) != 0;
			b |= (byte)(flag ? 128 : 0);
			num <<= 7;
			if (metadata != null)
			{
				metadata[pos] = b;
			}
			pos++;
		}
		while (flag);
	}

	public static byte Combine(int settingValue, byte defaultValue)
	{
		if ((byte)settingValue != settingValue)
		{
			return defaultValue;
		}
		return (byte)settingValue;
	}

	public static byte Combine(int settingValue1, int settingValue2, byte defaultValue)
	{
		if ((byte)settingValue1 != settingValue1)
		{
			if ((byte)settingValue2 != settingValue2)
			{
				return defaultValue;
			}
			return (byte)settingValue2;
		}
		return (byte)settingValue1;
	}

	public static int Combine(int settingValue1, int settingValue2)
	{
		if ((byte)settingValue1 != settingValue1)
		{
			return settingValue2;
		}
		return settingValue1;
	}

	public static void CheckName(string name)
	{
		if (name != null && 0 <= name.IndexOf('\0'))
		{
			throw new ArgumentOutOfRangeException("name");
		}
	}

	public static bool ShouldOverrideFieldName(string fieldName)
	{
		if (fieldName.Length <= 2)
		{
			return fieldName[0] == '_';
		}
		return false;
	}

	public static TraceLoggingDataType MakeDataType(TraceLoggingDataType baseType, EventFieldFormat format)
	{
		return (TraceLoggingDataType)((int)(baseType & (TraceLoggingDataType)31) | ((int)format << 8));
	}

	public static TraceLoggingDataType Format8(EventFieldFormat format, TraceLoggingDataType native)
	{
		return format switch
		{
			EventFieldFormat.Default => native, 
			EventFieldFormat.String => TraceLoggingDataType.Char8, 
			EventFieldFormat.Boolean => TraceLoggingDataType.Boolean8, 
			EventFieldFormat.Hexadecimal => TraceLoggingDataType.HexInt8, 
			_ => MakeDataType(native, format), 
		};
	}

	public static TraceLoggingDataType Format16(EventFieldFormat format, TraceLoggingDataType native)
	{
		return format switch
		{
			EventFieldFormat.Default => native, 
			EventFieldFormat.String => TraceLoggingDataType.Char16, 
			EventFieldFormat.Hexadecimal => TraceLoggingDataType.HexInt16, 
			_ => MakeDataType(native, format), 
		};
	}

	public static TraceLoggingDataType Format32(EventFieldFormat format, TraceLoggingDataType native)
	{
		return format switch
		{
			EventFieldFormat.Default => native, 
			EventFieldFormat.Boolean => TraceLoggingDataType.Boolean32, 
			EventFieldFormat.Hexadecimal => TraceLoggingDataType.HexInt32, 
			EventFieldFormat.HResult => TraceLoggingDataType.HResult, 
			_ => MakeDataType(native, format), 
		};
	}

	public static TraceLoggingDataType Format64(EventFieldFormat format, TraceLoggingDataType native)
	{
		return format switch
		{
			EventFieldFormat.Default => native, 
			EventFieldFormat.Hexadecimal => TraceLoggingDataType.HexInt64, 
			_ => MakeDataType(native, format), 
		};
	}

	public static TraceLoggingDataType FormatPtr(EventFieldFormat format, TraceLoggingDataType native)
	{
		return format switch
		{
			EventFieldFormat.Default => native, 
			EventFieldFormat.Hexadecimal => HexIntPtrType, 
			_ => MakeDataType(native, format), 
		};
	}

	public static object CreateInstance(Type type, params object[] parameters)
	{
		return Activator.CreateInstance(type, parameters);
	}

	public static bool IsValueType(Type type)
	{
		return type.IsValueType;
	}

	public static bool IsEnum(Type type)
	{
		return type.IsEnum;
	}

	public static IEnumerable<PropertyInfo> GetProperties(Type type)
	{
		return type.GetProperties();
	}

	public static MethodInfo GetGetMethod(PropertyInfo propInfo)
	{
		return propInfo.GetGetMethod();
	}

	public static MethodInfo GetDeclaredStaticMethod(Type declaringType, string name)
	{
		return declaringType.GetMethod(name, BindingFlags.DeclaredOnly | BindingFlags.Static | BindingFlags.NonPublic);
	}

	public static bool HasCustomAttribute(PropertyInfo propInfo, Type attributeType)
	{
		object[] customAttributes = propInfo.GetCustomAttributes(attributeType, inherit: false);
		return customAttributes.Length != 0;
	}

	public static AttributeType GetCustomAttribute<AttributeType>(PropertyInfo propInfo) where AttributeType : Attribute
	{
		AttributeType result = null;
		object[] customAttributes = propInfo.GetCustomAttributes(typeof(AttributeType), inherit: false);
		if (customAttributes.Length != 0)
		{
			return (AttributeType)customAttributes[0];
		}
		return result;
	}

	public static AttributeType GetCustomAttribute<AttributeType>(Type type) where AttributeType : Attribute
	{
		AttributeType result = null;
		object[] customAttributes = type.GetCustomAttributes(typeof(AttributeType), inherit: false);
		if (customAttributes.Length != 0)
		{
			return (AttributeType)customAttributes[0];
		}
		return result;
	}

	public static Type[] GetGenericArguments(Type type)
	{
		return type.GetGenericArguments();
	}

	public static Type FindEnumerableElementType(Type type)
	{
		Type type2 = null;
		if (IsGenericMatch(type, typeof(IEnumerable<>)))
		{
			type2 = GetGenericArguments(type)[0];
		}
		else
		{
			Type[] array = type.FindInterfaces(IsGenericMatch, typeof(IEnumerable<>));
			Type[] array2 = array;
			foreach (Type type3 in array2)
			{
				if (type2 != null)
				{
					type2 = null;
					break;
				}
				type2 = GetGenericArguments(type3)[0];
			}
		}
		return type2;
	}

	public static bool IsGenericMatch(Type type, object openType)
	{
		if (type.IsGenericType)
		{
			return type.GetGenericTypeDefinition() == (Type)openType;
		}
		return false;
	}

	public static Delegate CreateDelegate(Type delegateType, MethodInfo methodInfo)
	{
		return Delegate.CreateDelegate(delegateType, methodInfo);
	}

	public static TraceLoggingTypeInfo GetTypeInfoInstance(Type dataType, List<Type> recursionCheck)
	{
		if (dataType == typeof(int))
		{
			return TraceLoggingTypeInfo<int>.Instance;
		}
		if (dataType == typeof(long))
		{
			return TraceLoggingTypeInfo<long>.Instance;
		}
		if (dataType == typeof(string))
		{
			return TraceLoggingTypeInfo<string>.Instance;
		}
		MethodInfo declaredStaticMethod = GetDeclaredStaticMethod(typeof(TraceLoggingTypeInfo<>).MakeGenericType(dataType), "GetInstance");
		object obj = declaredStaticMethod.Invoke(null, new object[1] { recursionCheck });
		return (TraceLoggingTypeInfo)obj;
	}

	public static TraceLoggingTypeInfo<DataType> CreateDefaultTypeInfo<DataType>(List<Type> recursionCheck)
	{
		Type typeFromHandle = typeof(DataType);
		if (recursionCheck.Contains(typeFromHandle))
		{
			throw new NotSupportedException(Environment.GetResourceString("EventSource_RecursiveTypeDefinition"));
		}
		recursionCheck.Add(typeFromHandle);
		EventDataAttribute customAttribute = GetCustomAttribute<EventDataAttribute>(typeFromHandle);
		TraceLoggingTypeInfo traceLoggingTypeInfo;
		if (customAttribute != null || GetCustomAttribute<CompilerGeneratedAttribute>(typeFromHandle) != null)
		{
			TypeAnalysis typeAnalysis = new TypeAnalysis(typeFromHandle, customAttribute, recursionCheck);
			traceLoggingTypeInfo = new InvokeTypeInfo<DataType>(typeAnalysis);
		}
		else if (typeFromHandle.IsArray)
		{
			Type elementType = typeFromHandle.GetElementType();
			traceLoggingTypeInfo = ((elementType == typeof(bool)) ? new BooleanArrayTypeInfo() : ((elementType == typeof(byte)) ? new ByteArrayTypeInfo() : ((elementType == typeof(sbyte)) ? new SByteArrayTypeInfo() : ((elementType == typeof(short)) ? new Int16ArrayTypeInfo() : ((elementType == typeof(ushort)) ? new UInt16ArrayTypeInfo() : ((elementType == typeof(int)) ? new Int32ArrayTypeInfo() : ((elementType == typeof(uint)) ? new UInt32ArrayTypeInfo() : ((elementType == typeof(long)) ? new Int64ArrayTypeInfo() : ((elementType == typeof(ulong)) ? new UInt64ArrayTypeInfo() : ((elementType == typeof(char)) ? new CharArrayTypeInfo() : ((elementType == typeof(double)) ? new DoubleArrayTypeInfo() : ((elementType == typeof(float)) ? new SingleArrayTypeInfo() : ((elementType == typeof(IntPtr)) ? new IntPtrArrayTypeInfo() : ((elementType == typeof(UIntPtr)) ? new UIntPtrArrayTypeInfo() : ((!(elementType == typeof(Guid))) ? ((TraceLoggingTypeInfo)(TraceLoggingTypeInfo<DataType>)CreateInstance(typeof(ArrayTypeInfo<>).MakeGenericType(elementType), GetTypeInfoInstance(elementType, recursionCheck))) : ((TraceLoggingTypeInfo)new GuidArrayTypeInfo()))))))))))))))));
		}
		else if (IsEnum(typeFromHandle))
		{
			Type underlyingType = Enum.GetUnderlyingType(typeFromHandle);
			if (underlyingType == typeof(int))
			{
				traceLoggingTypeInfo = new EnumInt32TypeInfo<DataType>();
			}
			else if (underlyingType == typeof(uint))
			{
				traceLoggingTypeInfo = new EnumUInt32TypeInfo<DataType>();
			}
			else if (underlyingType == typeof(byte))
			{
				traceLoggingTypeInfo = new EnumByteTypeInfo<DataType>();
			}
			else if (underlyingType == typeof(sbyte))
			{
				traceLoggingTypeInfo = new EnumSByteTypeInfo<DataType>();
			}
			else if (underlyingType == typeof(short))
			{
				traceLoggingTypeInfo = new EnumInt16TypeInfo<DataType>();
			}
			else if (underlyingType == typeof(ushort))
			{
				traceLoggingTypeInfo = new EnumUInt16TypeInfo<DataType>();
			}
			else if (underlyingType == typeof(long))
			{
				traceLoggingTypeInfo = new EnumInt64TypeInfo<DataType>();
			}
			else
			{
				if (!(underlyingType == typeof(ulong)))
				{
					throw new NotSupportedException(Environment.GetResourceString("EventSource_NotSupportedEnumType", typeFromHandle.Name, underlyingType.Name));
				}
				traceLoggingTypeInfo = new EnumUInt64TypeInfo<DataType>();
			}
		}
		else if (typeFromHandle == typeof(string))
		{
			traceLoggingTypeInfo = new StringTypeInfo();
		}
		else if (typeFromHandle == typeof(bool))
		{
			traceLoggingTypeInfo = new BooleanTypeInfo();
		}
		else if (typeFromHandle == typeof(byte))
		{
			traceLoggingTypeInfo = new ByteTypeInfo();
		}
		else if (typeFromHandle == typeof(sbyte))
		{
			traceLoggingTypeInfo = new SByteTypeInfo();
		}
		else if (typeFromHandle == typeof(short))
		{
			traceLoggingTypeInfo = new Int16TypeInfo();
		}
		else if (typeFromHandle == typeof(ushort))
		{
			traceLoggingTypeInfo = new UInt16TypeInfo();
		}
		else if (typeFromHandle == typeof(int))
		{
			traceLoggingTypeInfo = new Int32TypeInfo();
		}
		else if (typeFromHandle == typeof(uint))
		{
			traceLoggingTypeInfo = new UInt32TypeInfo();
		}
		else if (typeFromHandle == typeof(long))
		{
			traceLoggingTypeInfo = new Int64TypeInfo();
		}
		else if (typeFromHandle == typeof(ulong))
		{
			traceLoggingTypeInfo = new UInt64TypeInfo();
		}
		else if (typeFromHandle == typeof(char))
		{
			traceLoggingTypeInfo = new CharTypeInfo();
		}
		else if (typeFromHandle == typeof(double))
		{
			traceLoggingTypeInfo = new DoubleTypeInfo();
		}
		else if (typeFromHandle == typeof(float))
		{
			traceLoggingTypeInfo = new SingleTypeInfo();
		}
		else if (typeFromHandle == typeof(DateTime))
		{
			traceLoggingTypeInfo = new DateTimeTypeInfo();
		}
		else if (typeFromHandle == typeof(decimal))
		{
			traceLoggingTypeInfo = new DecimalTypeInfo();
		}
		else if (typeFromHandle == typeof(IntPtr))
		{
			traceLoggingTypeInfo = new IntPtrTypeInfo();
		}
		else if (typeFromHandle == typeof(UIntPtr))
		{
			traceLoggingTypeInfo = new UIntPtrTypeInfo();
		}
		else if (typeFromHandle == typeof(Guid))
		{
			traceLoggingTypeInfo = new GuidTypeInfo();
		}
		else if (typeFromHandle == typeof(TimeSpan))
		{
			traceLoggingTypeInfo = new TimeSpanTypeInfo();
		}
		else if (typeFromHandle == typeof(DateTimeOffset))
		{
			traceLoggingTypeInfo = new DateTimeOffsetTypeInfo();
		}
		else if (typeFromHandle == typeof(EmptyStruct))
		{
			traceLoggingTypeInfo = new NullTypeInfo<EmptyStruct>();
		}
		else if (IsGenericMatch(typeFromHandle, typeof(KeyValuePair<, >)))
		{
			Type[] genericArguments = GetGenericArguments(typeFromHandle);
			traceLoggingTypeInfo = (TraceLoggingTypeInfo<DataType>)CreateInstance(typeof(KeyValuePairTypeInfo<, >).MakeGenericType(genericArguments[0], genericArguments[1]), recursionCheck);
		}
		else if (IsGenericMatch(typeFromHandle, typeof(Nullable<>)))
		{
			Type[] genericArguments2 = GetGenericArguments(typeFromHandle);
			traceLoggingTypeInfo = (TraceLoggingTypeInfo<DataType>)CreateInstance(typeof(NullableTypeInfo<>).MakeGenericType(genericArguments2[0]), recursionCheck);
		}
		else
		{
			Type type = FindEnumerableElementType(typeFromHandle);
			if (!(type != null))
			{
				throw new ArgumentException(Environment.GetResourceString("EventSource_NonCompliantTypeError", typeFromHandle.Name));
			}
			traceLoggingTypeInfo = (TraceLoggingTypeInfo<DataType>)CreateInstance(typeof(EnumerableTypeInfo<, >).MakeGenericType(typeFromHandle, type), GetTypeInfoInstance(type, recursionCheck));
		}
		return (TraceLoggingTypeInfo<DataType>)traceLoggingTypeInfo;
	}
}
