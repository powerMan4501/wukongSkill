using System.Security;

namespace System.Runtime.InteropServices;

[StructLayout(LayoutKind.Explicit)]
[SecurityCritical]
internal struct Variant
{
	private struct TypeUnion
	{
		internal ushort _vt;

		internal ushort _wReserved1;

		internal ushort _wReserved2;

		internal ushort _wReserved3;

		internal UnionTypes _unionTypes;
	}

	private struct Record
	{
		private IntPtr _record;

		private IntPtr _recordInfo;
	}

	[StructLayout(LayoutKind.Explicit)]
	private struct UnionTypes
	{
		[FieldOffset(0)]
		internal sbyte _i1;

		[FieldOffset(0)]
		internal short _i2;

		[FieldOffset(0)]
		internal int _i4;

		[FieldOffset(0)]
		internal long _i8;

		[FieldOffset(0)]
		internal byte _ui1;

		[FieldOffset(0)]
		internal ushort _ui2;

		[FieldOffset(0)]
		internal uint _ui4;

		[FieldOffset(0)]
		internal ulong _ui8;

		[FieldOffset(0)]
		internal int _int;

		[FieldOffset(0)]
		internal uint _uint;

		[FieldOffset(0)]
		internal short _bool;

		[FieldOffset(0)]
		internal int _error;

		[FieldOffset(0)]
		internal float _r4;

		[FieldOffset(0)]
		internal double _r8;

		[FieldOffset(0)]
		internal long _cy;

		[FieldOffset(0)]
		internal double _date;

		[FieldOffset(0)]
		internal IntPtr _bstr;

		[FieldOffset(0)]
		internal IntPtr _unknown;

		[FieldOffset(0)]
		internal IntPtr _dispatch;

		[FieldOffset(0)]
		internal IntPtr _pvarVal;

		[FieldOffset(0)]
		internal IntPtr _byref;

		[FieldOffset(0)]
		internal Record _record;
	}

	[FieldOffset(0)]
	private TypeUnion _typeUnion;

	[FieldOffset(0)]
	private decimal _decimal;

	public VarEnum VariantType
	{
		get
		{
			return (VarEnum)_typeUnion._vt;
		}
		set
		{
			_typeUnion._vt = (ushort)value;
		}
	}

	internal bool IsEmpty => _typeUnion._vt == 0;

	internal bool IsByRef => (_typeUnion._vt & 0x4000) != 0;

	public sbyte AsI1
	{
		get
		{
			return _typeUnion._unionTypes._i1;
		}
		set
		{
			VariantType = VarEnum.VT_I1;
			_typeUnion._unionTypes._i1 = value;
		}
	}

	public short AsI2
	{
		get
		{
			return _typeUnion._unionTypes._i2;
		}
		set
		{
			VariantType = VarEnum.VT_I2;
			_typeUnion._unionTypes._i2 = value;
		}
	}

	public int AsI4
	{
		get
		{
			return _typeUnion._unionTypes._i4;
		}
		set
		{
			VariantType = VarEnum.VT_I4;
			_typeUnion._unionTypes._i4 = value;
		}
	}

	public long AsI8
	{
		get
		{
			return _typeUnion._unionTypes._i8;
		}
		set
		{
			VariantType = VarEnum.VT_I8;
			_typeUnion._unionTypes._i8 = value;
		}
	}

	public byte AsUi1
	{
		get
		{
			return _typeUnion._unionTypes._ui1;
		}
		set
		{
			VariantType = VarEnum.VT_UI1;
			_typeUnion._unionTypes._ui1 = value;
		}
	}

	public ushort AsUi2
	{
		get
		{
			return _typeUnion._unionTypes._ui2;
		}
		set
		{
			VariantType = VarEnum.VT_UI2;
			_typeUnion._unionTypes._ui2 = value;
		}
	}

	public uint AsUi4
	{
		get
		{
			return _typeUnion._unionTypes._ui4;
		}
		set
		{
			VariantType = VarEnum.VT_UI4;
			_typeUnion._unionTypes._ui4 = value;
		}
	}

	public ulong AsUi8
	{
		get
		{
			return _typeUnion._unionTypes._ui8;
		}
		set
		{
			VariantType = VarEnum.VT_UI8;
			_typeUnion._unionTypes._ui8 = value;
		}
	}

	public int AsInt
	{
		get
		{
			return _typeUnion._unionTypes._int;
		}
		set
		{
			VariantType = VarEnum.VT_INT;
			_typeUnion._unionTypes._int = value;
		}
	}

	public uint AsUint
	{
		get
		{
			return _typeUnion._unionTypes._uint;
		}
		set
		{
			VariantType = VarEnum.VT_UINT;
			_typeUnion._unionTypes._uint = value;
		}
	}

	public bool AsBool
	{
		get
		{
			return _typeUnion._unionTypes._bool != 0;
		}
		set
		{
			VariantType = VarEnum.VT_BOOL;
			_typeUnion._unionTypes._bool = (short)(value ? (-1) : 0);
		}
	}

	public int AsError
	{
		get
		{
			return _typeUnion._unionTypes._error;
		}
		set
		{
			VariantType = VarEnum.VT_ERROR;
			_typeUnion._unionTypes._error = value;
		}
	}

	public float AsR4
	{
		get
		{
			return _typeUnion._unionTypes._r4;
		}
		set
		{
			VariantType = VarEnum.VT_R4;
			_typeUnion._unionTypes._r4 = value;
		}
	}

	public double AsR8
	{
		get
		{
			return _typeUnion._unionTypes._r8;
		}
		set
		{
			VariantType = VarEnum.VT_R8;
			_typeUnion._unionTypes._r8 = value;
		}
	}

	public decimal AsDecimal
	{
		get
		{
			Variant variant = this;
			variant._typeUnion._vt = 0;
			return variant._decimal;
		}
		set
		{
			VariantType = VarEnum.VT_DECIMAL;
			_decimal = value;
			_typeUnion._vt = 14;
		}
	}

	public decimal AsCy
	{
		get
		{
			return decimal.FromOACurrency(_typeUnion._unionTypes._cy);
		}
		set
		{
			VariantType = VarEnum.VT_CY;
			_typeUnion._unionTypes._cy = decimal.ToOACurrency(value);
		}
	}

	public DateTime AsDate
	{
		get
		{
			return DateTime.FromOADate(_typeUnion._unionTypes._date);
		}
		set
		{
			VariantType = VarEnum.VT_DATE;
			_typeUnion._unionTypes._date = value.ToOADate();
		}
	}

	public string AsBstr
	{
		get
		{
			return Marshal.PtrToStringBSTR(_typeUnion._unionTypes._bstr);
		}
		set
		{
			VariantType = VarEnum.VT_BSTR;
			_typeUnion._unionTypes._bstr = Marshal.StringToBSTR(value);
		}
	}

	public object AsUnknown
	{
		get
		{
			if (_typeUnion._unionTypes._unknown == IntPtr.Zero)
			{
				return null;
			}
			return Marshal.GetObjectForIUnknown(_typeUnion._unionTypes._unknown);
		}
		set
		{
			VariantType = VarEnum.VT_UNKNOWN;
			if (value == null)
			{
				_typeUnion._unionTypes._unknown = IntPtr.Zero;
			}
			else
			{
				_typeUnion._unionTypes._unknown = Marshal.GetIUnknownForObject(value);
			}
		}
	}

	public object AsDispatch
	{
		get
		{
			if (_typeUnion._unionTypes._dispatch == IntPtr.Zero)
			{
				return null;
			}
			return Marshal.GetObjectForIUnknown(_typeUnion._unionTypes._dispatch);
		}
		set
		{
			VariantType = VarEnum.VT_DISPATCH;
			if (value == null)
			{
				_typeUnion._unionTypes._dispatch = IntPtr.Zero;
			}
			else
			{
				_typeUnion._unionTypes._dispatch = Marshal.GetIDispatchForObject(value);
			}
		}
	}

	internal IntPtr AsByRefVariant => _typeUnion._unionTypes._pvarVal;

	internal static bool IsPrimitiveType(VarEnum varEnum)
	{
		switch (varEnum)
		{
		case VarEnum.VT_I2:
		case VarEnum.VT_I4:
		case VarEnum.VT_R4:
		case VarEnum.VT_R8:
		case VarEnum.VT_DATE:
		case VarEnum.VT_BSTR:
		case VarEnum.VT_BOOL:
		case VarEnum.VT_DECIMAL:
		case VarEnum.VT_I1:
		case VarEnum.VT_UI1:
		case VarEnum.VT_UI2:
		case VarEnum.VT_UI4:
		case VarEnum.VT_I8:
		case VarEnum.VT_UI8:
		case VarEnum.VT_INT:
		case VarEnum.VT_UINT:
			return true;
		default:
			return false;
		}
	}

	public unsafe void CopyFromIndirect(object value)
	{
		VarEnum varEnum = VariantType & (VarEnum)(-16385);
		if (value == null)
		{
			if (varEnum == VarEnum.VT_DISPATCH || varEnum == VarEnum.VT_UNKNOWN || varEnum == VarEnum.VT_BSTR)
			{
				*(IntPtr*)(void*)_typeUnion._unionTypes._byref = IntPtr.Zero;
			}
			return;
		}
		if (!AppContextSwitches.DoNotMarshalOutByrefSafeArrayOnInvoke && (varEnum & VarEnum.VT_ARRAY) != VarEnum.VT_EMPTY)
		{
			Variant variant = default(Variant);
			Marshal.GetNativeVariantForObject(value, (IntPtr)(&variant));
			*(IntPtr*)(void*)_typeUnion._unionTypes._byref = variant._typeUnion._unionTypes._byref;
			return;
		}
		switch (varEnum)
		{
		case VarEnum.VT_I1:
			*(sbyte*)(void*)_typeUnion._unionTypes._byref = (sbyte)value;
			break;
		case VarEnum.VT_UI1:
			*(byte*)(void*)_typeUnion._unionTypes._byref = (byte)value;
			break;
		case VarEnum.VT_I2:
			*(short*)(void*)_typeUnion._unionTypes._byref = (short)value;
			break;
		case VarEnum.VT_UI2:
			*(ushort*)(void*)_typeUnion._unionTypes._byref = (ushort)value;
			break;
		case VarEnum.VT_BOOL:
			*(short*)(void*)_typeUnion._unionTypes._byref = (short)(((bool)value) ? (-1) : 0);
			break;
		case VarEnum.VT_I4:
		case VarEnum.VT_INT:
			*(int*)(void*)_typeUnion._unionTypes._byref = (int)value;
			break;
		case VarEnum.VT_UI4:
		case VarEnum.VT_UINT:
			*(uint*)(void*)_typeUnion._unionTypes._byref = (uint)value;
			break;
		case VarEnum.VT_ERROR:
			*(int*)(void*)_typeUnion._unionTypes._byref = ((ErrorWrapper)value).ErrorCode;
			break;
		case VarEnum.VT_I8:
			*(long*)(void*)_typeUnion._unionTypes._byref = (long)value;
			break;
		case VarEnum.VT_UI8:
			*(ulong*)(void*)_typeUnion._unionTypes._byref = (ulong)value;
			break;
		case VarEnum.VT_R4:
			*(float*)(void*)_typeUnion._unionTypes._byref = (float)value;
			break;
		case VarEnum.VT_R8:
			*(double*)(void*)_typeUnion._unionTypes._byref = (double)value;
			break;
		case VarEnum.VT_DATE:
			*(double*)(void*)_typeUnion._unionTypes._byref = ((DateTime)value).ToOADate();
			break;
		case VarEnum.VT_UNKNOWN:
			*(IntPtr*)(void*)_typeUnion._unionTypes._byref = Marshal.GetIUnknownForObject(value);
			break;
		case VarEnum.VT_DISPATCH:
			*(IntPtr*)(void*)_typeUnion._unionTypes._byref = Marshal.GetIDispatchForObject(value);
			break;
		case VarEnum.VT_BSTR:
			*(IntPtr*)(void*)_typeUnion._unionTypes._byref = Marshal.StringToBSTR((string)value);
			break;
		case VarEnum.VT_CY:
			*(long*)(void*)_typeUnion._unionTypes._byref = decimal.ToOACurrency((decimal)value);
			break;
		case VarEnum.VT_DECIMAL:
			*(decimal*)(void*)_typeUnion._unionTypes._byref = (decimal)value;
			break;
		case VarEnum.VT_VARIANT:
			Marshal.GetNativeVariantForObject(value, _typeUnion._unionTypes._byref);
			break;
		default:
			throw new ArgumentException("invalid argument type");
		}
	}

	public unsafe object ToObject()
	{
		if (IsEmpty)
		{
			return null;
		}
		switch (VariantType)
		{
		case VarEnum.VT_NULL:
			return DBNull.Value;
		case VarEnum.VT_I1:
			return AsI1;
		case VarEnum.VT_I2:
			return AsI2;
		case VarEnum.VT_I4:
			return AsI4;
		case VarEnum.VT_I8:
			return AsI8;
		case VarEnum.VT_UI1:
			return AsUi1;
		case VarEnum.VT_UI2:
			return AsUi2;
		case VarEnum.VT_UI4:
			return AsUi4;
		case VarEnum.VT_UI8:
			return AsUi8;
		case VarEnum.VT_INT:
			return AsInt;
		case VarEnum.VT_UINT:
			return AsUint;
		case VarEnum.VT_BOOL:
			return AsBool;
		case VarEnum.VT_ERROR:
			return AsError;
		case VarEnum.VT_R4:
			return AsR4;
		case VarEnum.VT_R8:
			return AsR8;
		case VarEnum.VT_DECIMAL:
			return AsDecimal;
		case VarEnum.VT_CY:
			return AsCy;
		case VarEnum.VT_DATE:
			return AsDate;
		case VarEnum.VT_BSTR:
			return AsBstr;
		case VarEnum.VT_UNKNOWN:
			return AsUnknown;
		case VarEnum.VT_DISPATCH:
			return AsDispatch;
		default:
			try
			{
				fixed (Variant* ptr = &this)
				{
					void* ptr2 = ptr;
					return Marshal.GetObjectForNativeVariant((IntPtr)ptr2);
				}
			}
			catch (Exception inner)
			{
				throw new NotImplementedException("Variant.ToObject cannot handle" + VariantType, inner);
			}
		}
	}

	public unsafe void Clear()
	{
		VarEnum variantType = VariantType;
		if ((variantType & VarEnum.VT_BYREF) != VarEnum.VT_EMPTY)
		{
			VariantType = VarEnum.VT_EMPTY;
		}
		else if ((variantType & VarEnum.VT_ARRAY) != VarEnum.VT_EMPTY || variantType == VarEnum.VT_BSTR || variantType == VarEnum.VT_UNKNOWN || variantType == VarEnum.VT_DISPATCH || variantType == VarEnum.VT_VARIANT || variantType == VarEnum.VT_RECORD || variantType == VarEnum.VT_VARIANT)
		{
			fixed (Variant* ptr = &this)
			{
				void* ptr2 = ptr;
				NativeMethods.VariantClear((IntPtr)ptr2);
			}
		}
		else
		{
			VariantType = VarEnum.VT_EMPTY;
		}
	}

	public void SetAsNULL()
	{
		VariantType = VarEnum.VT_NULL;
	}
}
