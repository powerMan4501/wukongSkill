using System.Globalization;
using System.Runtime.CompilerServices;
using System.Security;

namespace System.Runtime.InteropServices.WindowsRuntime;

internal class CLRIPropertyValueImpl : IPropertyValue
{
	private PropertyType _type;

	private object _data;

	private static volatile Tuple<Type, PropertyType>[] s_numericScalarTypes;

	private static Tuple<Type, PropertyType>[] NumericScalarTypes
	{
		get
		{
			if (s_numericScalarTypes == null)
			{
				Tuple<Type, PropertyType>[] array = new Tuple<Type, PropertyType>[9]
				{
					new Tuple<Type, PropertyType>(typeof(byte), PropertyType.UInt8),
					new Tuple<Type, PropertyType>(typeof(short), PropertyType.Int16),
					new Tuple<Type, PropertyType>(typeof(ushort), PropertyType.UInt16),
					new Tuple<Type, PropertyType>(typeof(int), PropertyType.Int32),
					new Tuple<Type, PropertyType>(typeof(uint), PropertyType.UInt32),
					new Tuple<Type, PropertyType>(typeof(long), PropertyType.Int64),
					new Tuple<Type, PropertyType>(typeof(ulong), PropertyType.UInt64),
					new Tuple<Type, PropertyType>(typeof(float), PropertyType.Single),
					new Tuple<Type, PropertyType>(typeof(double), PropertyType.Double)
				};
				s_numericScalarTypes = array;
			}
			return s_numericScalarTypes;
		}
	}

	public PropertyType Type => _type;

	public bool IsNumericScalar => IsNumericScalarImpl(_type, _data);

	internal CLRIPropertyValueImpl(PropertyType type, object data)
	{
		_type = type;
		_data = data;
	}

	public override string ToString()
	{
		if (_data != null)
		{
			return _data.ToString();
		}
		return base.ToString();
	}

	public byte GetUInt8()
	{
		return CoerceScalarValue<byte>(PropertyType.UInt8);
	}

	public short GetInt16()
	{
		return CoerceScalarValue<short>(PropertyType.Int16);
	}

	public ushort GetUInt16()
	{
		return CoerceScalarValue<ushort>(PropertyType.UInt16);
	}

	public int GetInt32()
	{
		return CoerceScalarValue<int>(PropertyType.Int32);
	}

	public uint GetUInt32()
	{
		return CoerceScalarValue<uint>(PropertyType.UInt32);
	}

	public long GetInt64()
	{
		return CoerceScalarValue<long>(PropertyType.Int64);
	}

	public ulong GetUInt64()
	{
		return CoerceScalarValue<ulong>(PropertyType.UInt64);
	}

	public float GetSingle()
	{
		return CoerceScalarValue<float>(PropertyType.Single);
	}

	public double GetDouble()
	{
		return CoerceScalarValue<double>(PropertyType.Double);
	}

	public char GetChar16()
	{
		if (Type != PropertyType.Char16)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Char16"), -2147316576);
		}
		return (char)_data;
	}

	public bool GetBoolean()
	{
		if (Type != PropertyType.Boolean)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Boolean"), -2147316576);
		}
		return (bool)_data;
	}

	public string GetString()
	{
		return CoerceScalarValue<string>(PropertyType.String);
	}

	public object GetInspectable()
	{
		if (Type != PropertyType.Inspectable)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Inspectable"), -2147316576);
		}
		return _data;
	}

	public Guid GetGuid()
	{
		return CoerceScalarValue<Guid>(PropertyType.Guid);
	}

	public DateTimeOffset GetDateTime()
	{
		if (Type != PropertyType.DateTime)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "DateTime"), -2147316576);
		}
		return (DateTimeOffset)_data;
	}

	public TimeSpan GetTimeSpan()
	{
		if (Type != PropertyType.TimeSpan)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "TimeSpan"), -2147316576);
		}
		return (TimeSpan)_data;
	}

	[SecuritySafeCritical]
	public Point GetPoint()
	{
		if (Type != PropertyType.Point)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Point"), -2147316576);
		}
		return Unbox<Point>(IReferenceFactory.s_pointType);
	}

	[SecuritySafeCritical]
	public Size GetSize()
	{
		if (Type != PropertyType.Size)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Size"), -2147316576);
		}
		return Unbox<Size>(IReferenceFactory.s_sizeType);
	}

	[SecuritySafeCritical]
	public Rect GetRect()
	{
		if (Type != PropertyType.Rect)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Rect"), -2147316576);
		}
		return Unbox<Rect>(IReferenceFactory.s_rectType);
	}

	public byte[] GetUInt8Array()
	{
		return CoerceArrayValue<byte>(PropertyType.UInt8Array);
	}

	public short[] GetInt16Array()
	{
		return CoerceArrayValue<short>(PropertyType.Int16Array);
	}

	public ushort[] GetUInt16Array()
	{
		return CoerceArrayValue<ushort>(PropertyType.UInt16Array);
	}

	public int[] GetInt32Array()
	{
		return CoerceArrayValue<int>(PropertyType.Int32Array);
	}

	public uint[] GetUInt32Array()
	{
		return CoerceArrayValue<uint>(PropertyType.UInt32Array);
	}

	public long[] GetInt64Array()
	{
		return CoerceArrayValue<long>(PropertyType.Int64Array);
	}

	public ulong[] GetUInt64Array()
	{
		return CoerceArrayValue<ulong>(PropertyType.UInt64Array);
	}

	public float[] GetSingleArray()
	{
		return CoerceArrayValue<float>(PropertyType.SingleArray);
	}

	public double[] GetDoubleArray()
	{
		return CoerceArrayValue<double>(PropertyType.DoubleArray);
	}

	public char[] GetChar16Array()
	{
		if (Type != PropertyType.Char16Array)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Char16[]"), -2147316576);
		}
		return (char[])_data;
	}

	public bool[] GetBooleanArray()
	{
		if (Type != PropertyType.BooleanArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Boolean[]"), -2147316576);
		}
		return (bool[])_data;
	}

	public string[] GetStringArray()
	{
		return CoerceArrayValue<string>(PropertyType.StringArray);
	}

	public object[] GetInspectableArray()
	{
		if (Type != PropertyType.InspectableArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Inspectable[]"), -2147316576);
		}
		return (object[])_data;
	}

	public Guid[] GetGuidArray()
	{
		return CoerceArrayValue<Guid>(PropertyType.GuidArray);
	}

	public DateTimeOffset[] GetDateTimeArray()
	{
		if (Type != PropertyType.DateTimeArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "DateTimeOffset[]"), -2147316576);
		}
		return (DateTimeOffset[])_data;
	}

	public TimeSpan[] GetTimeSpanArray()
	{
		if (Type != PropertyType.TimeSpanArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "TimeSpan[]"), -2147316576);
		}
		return (TimeSpan[])_data;
	}

	[SecuritySafeCritical]
	public Point[] GetPointArray()
	{
		if (Type != PropertyType.PointArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Point[]"), -2147316576);
		}
		return UnboxArray<Point>(IReferenceFactory.s_pointType);
	}

	[SecuritySafeCritical]
	public Size[] GetSizeArray()
	{
		if (Type != PropertyType.SizeArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Size[]"), -2147316576);
		}
		return UnboxArray<Size>(IReferenceFactory.s_sizeType);
	}

	[SecuritySafeCritical]
	public Rect[] GetRectArray()
	{
		if (Type != PropertyType.RectArray)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, "Rect[]"), -2147316576);
		}
		return UnboxArray<Rect>(IReferenceFactory.s_rectType);
	}

	private T[] CoerceArrayValue<T>(PropertyType unboxType)
	{
		if (Type == unboxType)
		{
			return (T[])_data;
		}
		if (!(_data is Array array))
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", Type, typeof(T).MakeArrayType().Name), -2147316576);
		}
		PropertyType type = Type - 1024;
		T[] array2 = new T[array.Length];
		for (int i = 0; i < array.Length; i++)
		{
			try
			{
				array2[i] = CoerceScalarValue<T>(type, array.GetValue(i));
			}
			catch (InvalidCastException ex)
			{
				Exception ex2 = new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueArrayCoersion", Type, typeof(T).MakeArrayType().Name, i, ex.Message), ex);
				ex2.SetErrorCode(ex._HResult);
				throw ex2;
			}
		}
		return array2;
	}

	private T CoerceScalarValue<T>(PropertyType unboxType)
	{
		if (Type == unboxType)
		{
			return (T)_data;
		}
		return CoerceScalarValue<T>(Type, _data);
	}

	private static T CoerceScalarValue<T>(PropertyType type, object value)
	{
		if (!IsCoercable(type, value) && type != PropertyType.Inspectable)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", type, typeof(T).Name), -2147316576);
		}
		try
		{
			if (type == PropertyType.String && typeof(T) == typeof(Guid))
			{
				return (T)(object)Guid.Parse((string)value);
			}
			if (type == PropertyType.Guid && typeof(T) == typeof(string))
			{
				return (T)(object)((Guid)value).ToString("D", CultureInfo.InvariantCulture);
			}
			Tuple<Type, PropertyType>[] numericScalarTypes = NumericScalarTypes;
			foreach (Tuple<Type, PropertyType> tuple in numericScalarTypes)
			{
				if (tuple.Item1 == typeof(T))
				{
					return (T)Convert.ChangeType(value, typeof(T), CultureInfo.InvariantCulture);
				}
			}
		}
		catch (FormatException)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", type, typeof(T).Name), -2147316576);
		}
		catch (InvalidCastException)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", type, typeof(T).Name), -2147316576);
		}
		catch (OverflowException)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueCoersion", type, value, typeof(T).Name), -2147352566);
		}
		IPropertyValue propertyValue = value as IPropertyValue;
		if (type == PropertyType.Inspectable && propertyValue != null)
		{
			if (typeof(T) == typeof(byte))
			{
				return (T)(object)propertyValue.GetUInt8();
			}
			if (typeof(T) == typeof(short))
			{
				return (T)(object)propertyValue.GetInt16();
			}
			if (typeof(T) == typeof(ushort))
			{
				return (T)(object)propertyValue.GetUInt16();
			}
			if (typeof(T) == typeof(int))
			{
				return (T)(object)propertyValue.GetUInt32();
			}
			if (typeof(T) == typeof(uint))
			{
				return (T)(object)propertyValue.GetUInt32();
			}
			if (typeof(T) == typeof(long))
			{
				return (T)(object)propertyValue.GetInt64();
			}
			if (typeof(T) == typeof(ulong))
			{
				return (T)(object)propertyValue.GetUInt64();
			}
			if (typeof(T) == typeof(float))
			{
				return (T)(object)propertyValue.GetSingle();
			}
			if (typeof(T) == typeof(double))
			{
				return (T)(object)propertyValue.GetDouble();
			}
		}
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", type, typeof(T).Name), -2147316576);
	}

	private static bool IsCoercable(PropertyType type, object data)
	{
		if (type == PropertyType.Guid || type == PropertyType.String)
		{
			return true;
		}
		return IsNumericScalarImpl(type, data);
	}

	private static bool IsNumericScalarImpl(PropertyType type, object data)
	{
		if (data.GetType().IsEnum)
		{
			return true;
		}
		Tuple<Type, PropertyType>[] numericScalarTypes = NumericScalarTypes;
		foreach (Tuple<Type, PropertyType> tuple in numericScalarTypes)
		{
			if (tuple.Item2 == type)
			{
				return true;
			}
		}
		return false;
	}

	[SecurityCritical]
	private unsafe T Unbox<T>(Type expectedBoxedType) where T : struct
	{
		if (_data.GetType() != expectedBoxedType)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", _data.GetType(), expectedBoxedType.Name), -2147316576);
		}
		T val = new T();
		fixed (byte* data = &JitHelpers.GetPinningHelper(_data).m_data)
		{
			byte* dest = (byte*)(void*)JitHelpers.UnsafeCastToStackPointer(ref val);
			Buffer.Memcpy(dest, data, Marshal.SizeOf(val));
		}
		return val;
	}

	[SecurityCritical]
	private unsafe T[] UnboxArray<T>(Type expectedArrayElementType) where T : struct
	{
		if (!(_data is Array array) || _data.GetType().GetElementType() != expectedArrayElementType)
		{
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_WinRTIPropertyValueElement", _data.GetType(), expectedArrayElementType.MakeArrayType().Name), -2147316576);
		}
		T[] array2 = new T[array.Length];
		if (array2.Length != 0)
		{
			fixed (byte* data = &JitHelpers.GetPinningHelper(array).m_data)
			{
				fixed (byte* data2 = &JitHelpers.GetPinningHelper(array2).m_data)
				{
					byte* src = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement(array, 0);
					byte* dest = (byte*)(void*)Marshal.UnsafeAddrOfPinnedArrayElement(array2, 0);
					Buffer.Memcpy(dest, src, checked(Marshal.SizeOf(typeof(T)) * array2.Length));
				}
			}
		}
		return array2;
	}
}
