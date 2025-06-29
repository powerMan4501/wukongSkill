using System.Globalization;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Runtime.Remoting;
using System.Security;

namespace System;

[Serializable]
internal struct Variant
{
	private object m_objref;

	private int m_data1;

	private int m_data2;

	private int m_flags;

	internal const int CV_EMPTY = 0;

	internal const int CV_VOID = 1;

	internal const int CV_BOOLEAN = 2;

	internal const int CV_CHAR = 3;

	internal const int CV_I1 = 4;

	internal const int CV_U1 = 5;

	internal const int CV_I2 = 6;

	internal const int CV_U2 = 7;

	internal const int CV_I4 = 8;

	internal const int CV_U4 = 9;

	internal const int CV_I8 = 10;

	internal const int CV_U8 = 11;

	internal const int CV_R4 = 12;

	internal const int CV_R8 = 13;

	internal const int CV_STRING = 14;

	internal const int CV_PTR = 15;

	internal const int CV_DATETIME = 16;

	internal const int CV_TIMESPAN = 17;

	internal const int CV_OBJECT = 18;

	internal const int CV_DECIMAL = 19;

	internal const int CV_ENUM = 21;

	internal const int CV_MISSING = 22;

	internal const int CV_NULL = 23;

	internal const int CV_LAST = 24;

	internal const int TypeCodeBitMask = 65535;

	internal const int VTBitMask = -16777216;

	internal const int VTBitShift = 24;

	internal const int ArrayBitMask = 65536;

	internal const int EnumI1 = 1048576;

	internal const int EnumU1 = 2097152;

	internal const int EnumI2 = 3145728;

	internal const int EnumU2 = 4194304;

	internal const int EnumI4 = 5242880;

	internal const int EnumU4 = 6291456;

	internal const int EnumI8 = 7340032;

	internal const int EnumU8 = 8388608;

	internal const int EnumMask = 15728640;

	internal static readonly Type[] ClassTypes = new Type[23]
	{
		typeof(Empty),
		typeof(void),
		typeof(bool),
		typeof(char),
		typeof(sbyte),
		typeof(byte),
		typeof(short),
		typeof(ushort),
		typeof(int),
		typeof(uint),
		typeof(long),
		typeof(ulong),
		typeof(float),
		typeof(double),
		typeof(string),
		typeof(void),
		typeof(DateTime),
		typeof(TimeSpan),
		typeof(object),
		typeof(decimal),
		typeof(object),
		typeof(Missing),
		typeof(DBNull)
	};

	internal static readonly Variant Empty = default(Variant);

	internal static readonly Variant Missing = new Variant(22, Type.Missing, 0, 0);

	internal static readonly Variant DBNull = new Variant(23, System.DBNull.Value, 0, 0);

	internal int CVType => m_flags & 0xFFFF;

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern double GetR8FromVar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern float GetR4FromVar();

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void SetFieldsR4(float val);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void SetFieldsR8(double val);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal extern void SetFieldsObject(object val);

	internal long GetI8FromVar()
	{
		return ((long)m_data2 << 32) | (m_data1 & 0xFFFFFFFFu);
	}

	internal Variant(int flags, object or, int data1, int data2)
	{
		m_flags = flags;
		m_objref = or;
		m_data1 = data1;
		m_data2 = data2;
	}

	public Variant(bool val)
	{
		m_objref = null;
		m_flags = 2;
		m_data1 = (val ? 1 : 0);
		m_data2 = 0;
	}

	public Variant(sbyte val)
	{
		m_objref = null;
		m_flags = 4;
		m_data1 = val;
		m_data2 = (int)((long)val >> 32);
	}

	public Variant(byte val)
	{
		m_objref = null;
		m_flags = 5;
		m_data1 = val;
		m_data2 = 0;
	}

	public Variant(short val)
	{
		m_objref = null;
		m_flags = 6;
		m_data1 = val;
		m_data2 = (int)((long)val >> 32);
	}

	public Variant(ushort val)
	{
		m_objref = null;
		m_flags = 7;
		m_data1 = val;
		m_data2 = 0;
	}

	public Variant(char val)
	{
		m_objref = null;
		m_flags = 3;
		m_data1 = val;
		m_data2 = 0;
	}

	public Variant(int val)
	{
		m_objref = null;
		m_flags = 8;
		m_data1 = val;
		m_data2 = val >> 31;
	}

	public Variant(uint val)
	{
		m_objref = null;
		m_flags = 9;
		m_data1 = (int)val;
		m_data2 = 0;
	}

	public Variant(long val)
	{
		m_objref = null;
		m_flags = 10;
		m_data1 = (int)val;
		m_data2 = (int)(val >> 32);
	}

	public Variant(ulong val)
	{
		m_objref = null;
		m_flags = 11;
		m_data1 = (int)val;
		m_data2 = (int)(val >> 32);
	}

	[SecuritySafeCritical]
	public Variant(float val)
	{
		m_objref = null;
		m_flags = 12;
		m_data1 = 0;
		m_data2 = 0;
		SetFieldsR4(val);
	}

	[SecurityCritical]
	public Variant(double val)
	{
		m_objref = null;
		m_flags = 13;
		m_data1 = 0;
		m_data2 = 0;
		SetFieldsR8(val);
	}

	public Variant(DateTime val)
	{
		m_objref = null;
		m_flags = 16;
		ulong ticks = (ulong)val.Ticks;
		m_data1 = (int)ticks;
		m_data2 = (int)(ticks >> 32);
	}

	public Variant(decimal val)
	{
		m_objref = val;
		m_flags = 19;
		m_data1 = 0;
		m_data2 = 0;
	}

	[SecuritySafeCritical]
	public Variant(object obj)
	{
		m_data1 = 0;
		m_data2 = 0;
		VarEnum varEnum = VarEnum.VT_EMPTY;
		if (obj is DateTime)
		{
			m_objref = null;
			m_flags = 16;
			ulong ticks = (ulong)((DateTime)obj).Ticks;
			m_data1 = (int)ticks;
			m_data2 = (int)(ticks >> 32);
			return;
		}
		if (obj is string)
		{
			m_flags = 14;
			m_objref = obj;
			return;
		}
		if (obj == null)
		{
			this = Empty;
			return;
		}
		if (obj == System.DBNull.Value)
		{
			this = DBNull;
			return;
		}
		if (obj == Type.Missing)
		{
			this = Missing;
			return;
		}
		if (obj is Array)
		{
			m_flags = 65554;
			m_objref = obj;
			return;
		}
		m_flags = 0;
		m_objref = null;
		if (obj is UnknownWrapper)
		{
			varEnum = VarEnum.VT_UNKNOWN;
			obj = ((UnknownWrapper)obj).WrappedObject;
		}
		else if (obj is DispatchWrapper)
		{
			varEnum = VarEnum.VT_DISPATCH;
			obj = ((DispatchWrapper)obj).WrappedObject;
		}
		else if (obj is ErrorWrapper)
		{
			varEnum = VarEnum.VT_ERROR;
			obj = ((ErrorWrapper)obj).ErrorCode;
		}
		else if (obj is CurrencyWrapper)
		{
			varEnum = VarEnum.VT_CY;
			obj = ((CurrencyWrapper)obj).WrappedObject;
		}
		else if (obj is BStrWrapper)
		{
			varEnum = VarEnum.VT_BSTR;
			obj = ((BStrWrapper)obj).WrappedObject;
		}
		if (obj != null)
		{
			SetFieldsObject(obj);
		}
		if (varEnum != VarEnum.VT_EMPTY)
		{
			m_flags |= (int)varEnum << 24;
		}
	}

	[SecurityCritical]
	public unsafe Variant(void* voidPointer, Type pointerType)
	{
		if (pointerType == null)
		{
			throw new ArgumentNullException("pointerType");
		}
		if (!pointerType.IsPointer)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBePointer"), "pointerType");
		}
		m_objref = pointerType;
		m_flags = 15;
		m_data1 = (int)voidPointer;
		m_data2 = 0;
	}

	[SecuritySafeCritical]
	public object ToObject()
	{
		return CVType switch
		{
			0 => null, 
			2 => m_data1 != 0, 
			4 => (sbyte)m_data1, 
			5 => (byte)m_data1, 
			3 => (char)m_data1, 
			6 => (short)m_data1, 
			7 => (ushort)m_data1, 
			8 => m_data1, 
			9 => (uint)m_data1, 
			10 => GetI8FromVar(), 
			11 => (ulong)GetI8FromVar(), 
			12 => GetR4FromVar(), 
			13 => GetR8FromVar(), 
			16 => new DateTime(GetI8FromVar()), 
			17 => new TimeSpan(GetI8FromVar()), 
			21 => BoxEnum(), 
			22 => Type.Missing, 
			23 => System.DBNull.Value, 
			_ => m_objref, 
		};
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private extern object BoxEnum();

	[SecuritySafeCritical]
	internal static void MarshalHelperConvertObjectToVariant(object o, ref Variant v)
	{
		IConvertible convertible = (RemotingServices.IsTransparentProxy(o) ? null : (o as IConvertible));
		if (o == null)
		{
			v = Empty;
			return;
		}
		if (convertible == null)
		{
			v = new Variant(o);
			return;
		}
		IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
		switch (convertible.GetTypeCode())
		{
		case TypeCode.Empty:
			v = Empty;
			break;
		case TypeCode.Object:
			v = new Variant(o);
			break;
		case TypeCode.DBNull:
			v = DBNull;
			break;
		case TypeCode.Boolean:
			v = new Variant(convertible.ToBoolean(invariantCulture));
			break;
		case TypeCode.Char:
			v = new Variant(convertible.ToChar(invariantCulture));
			break;
		case TypeCode.SByte:
			v = new Variant(convertible.ToSByte(invariantCulture));
			break;
		case TypeCode.Byte:
			v = new Variant(convertible.ToByte(invariantCulture));
			break;
		case TypeCode.Int16:
			v = new Variant(convertible.ToInt16(invariantCulture));
			break;
		case TypeCode.UInt16:
			v = new Variant(convertible.ToUInt16(invariantCulture));
			break;
		case TypeCode.Int32:
			v = new Variant(convertible.ToInt32(invariantCulture));
			break;
		case TypeCode.UInt32:
			v = new Variant(convertible.ToUInt32(invariantCulture));
			break;
		case TypeCode.Int64:
			v = new Variant(convertible.ToInt64(invariantCulture));
			break;
		case TypeCode.UInt64:
			v = new Variant(convertible.ToUInt64(invariantCulture));
			break;
		case TypeCode.Single:
			v = new Variant(convertible.ToSingle(invariantCulture));
			break;
		case TypeCode.Double:
			v = new Variant(convertible.ToDouble(invariantCulture));
			break;
		case TypeCode.Decimal:
			v = new Variant(convertible.ToDecimal(invariantCulture));
			break;
		case TypeCode.DateTime:
			v = new Variant(convertible.ToDateTime(invariantCulture));
			break;
		case TypeCode.String:
			v = new Variant(convertible.ToString(invariantCulture));
			break;
		default:
			throw new NotSupportedException(Environment.GetResourceString("NotSupported_UnknownTypeCode", convertible.GetTypeCode()));
		}
	}

	internal static object MarshalHelperConvertVariantToObject(ref Variant v)
	{
		return v.ToObject();
	}

	[SecurityCritical]
	internal static void MarshalHelperCastVariant(object pValue, int vt, ref Variant v)
	{
		if (!(pValue is IConvertible convertible))
		{
			switch (vt)
			{
			case 9:
				v = new Variant(new DispatchWrapper(pValue));
				break;
			case 12:
				v = new Variant(pValue);
				break;
			case 13:
				v = new Variant(new UnknownWrapper(pValue));
				break;
			case 36:
				v = new Variant(pValue);
				break;
			case 8:
				if (pValue == null)
				{
					v = new Variant(null);
					v.m_flags = 14;
					break;
				}
				throw new InvalidCastException(Environment.GetResourceString("InvalidCast_CannotCoerceByRefVariant"));
			default:
				throw new InvalidCastException(Environment.GetResourceString("InvalidCast_CannotCoerceByRefVariant"));
			}
			return;
		}
		IFormatProvider invariantCulture = CultureInfo.InvariantCulture;
		switch (vt)
		{
		case 0:
			v = Empty;
			break;
		case 1:
			v = DBNull;
			break;
		case 2:
			v = new Variant(convertible.ToInt16(invariantCulture));
			break;
		case 3:
			v = new Variant(convertible.ToInt32(invariantCulture));
			break;
		case 4:
			v = new Variant(convertible.ToSingle(invariantCulture));
			break;
		case 5:
			v = new Variant(convertible.ToDouble(invariantCulture));
			break;
		case 6:
			v = new Variant(new CurrencyWrapper(convertible.ToDecimal(invariantCulture)));
			break;
		case 7:
			v = new Variant(convertible.ToDateTime(invariantCulture));
			break;
		case 8:
			v = new Variant(convertible.ToString(invariantCulture));
			break;
		case 9:
			v = new Variant(new DispatchWrapper(convertible));
			break;
		case 10:
			v = new Variant(new ErrorWrapper(convertible.ToInt32(invariantCulture)));
			break;
		case 11:
			v = new Variant(convertible.ToBoolean(invariantCulture));
			break;
		case 12:
			v = new Variant(convertible);
			break;
		case 13:
			v = new Variant(new UnknownWrapper(convertible));
			break;
		case 14:
			v = new Variant(convertible.ToDecimal(invariantCulture));
			break;
		case 16:
			v = new Variant(convertible.ToSByte(invariantCulture));
			break;
		case 17:
			v = new Variant(convertible.ToByte(invariantCulture));
			break;
		case 18:
			v = new Variant(convertible.ToUInt16(invariantCulture));
			break;
		case 19:
			v = new Variant(convertible.ToUInt32(invariantCulture));
			break;
		case 20:
			v = new Variant(convertible.ToInt64(invariantCulture));
			break;
		case 21:
			v = new Variant(convertible.ToUInt64(invariantCulture));
			break;
		case 22:
			v = new Variant(convertible.ToInt32(invariantCulture));
			break;
		case 23:
			v = new Variant(convertible.ToUInt32(invariantCulture));
			break;
		default:
			throw new InvalidCastException(Environment.GetResourceString("InvalidCast_CannotCoerceByRefVariant"));
		}
	}
}
