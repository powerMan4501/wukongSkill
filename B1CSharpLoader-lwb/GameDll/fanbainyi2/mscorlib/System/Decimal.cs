using System.Globalization;
using System.Runtime.CompilerServices;
using System.Runtime.ConstrainedExecution;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Versioning;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[NonVersionable]
[__DynamicallyInvokable]
public struct Decimal : IFormattable, IComparable, IConvertible, IDeserializationCallback, IComparable<decimal>, IEquatable<decimal>
{
	private const int SignMask = int.MinValue;

	private const byte DECIMAL_NEG = 128;

	private const byte DECIMAL_ADD = 0;

	private const int ScaleMask = 16711680;

	private const int ScaleShift = 16;

	private const int MaxInt32Scale = 9;

	private static uint[] Powers10 = new uint[10] { 1u, 10u, 100u, 1000u, 10000u, 100000u, 1000000u, 10000000u, 100000000u, 1000000000u };

	[__DynamicallyInvokable]
	public const decimal Zero = 0m;

	[__DynamicallyInvokable]
	public const decimal One = 1m;

	[__DynamicallyInvokable]
	public const decimal MinusOne = -1m;

	[__DynamicallyInvokable]
	public const decimal MaxValue = 79228162514264337593543950335m;

	[__DynamicallyInvokable]
	public const decimal MinValue = -79228162514264337593543950335m;

	private const decimal NearNegativeZero = -0.000000000000000000000000001m;

	private const decimal NearPositiveZero = 0.000000000000000000000000001m;

	private int flags;

	private int hi;

	private int lo;

	private int mid;

	[__DynamicallyInvokable]
	public Decimal(int value)
	{
		int num = value;
		if (num >= 0)
		{
			flags = 0;
		}
		else
		{
			flags = int.MinValue;
			num = -num;
		}
		lo = num;
		mid = 0;
		hi = 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public Decimal(uint value)
	{
		flags = 0;
		lo = (int)value;
		mid = 0;
		hi = 0;
	}

	[__DynamicallyInvokable]
	public Decimal(long value)
	{
		long num = value;
		if (num >= 0)
		{
			flags = 0;
		}
		else
		{
			flags = int.MinValue;
			num = -num;
		}
		lo = (int)num;
		mid = (int)(num >> 32);
		hi = 0;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public Decimal(ulong value)
	{
		flags = 0;
		lo = (int)value;
		mid = (int)(value >> 32);
		hi = 0;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern Decimal(float value);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public extern Decimal(double value);

	internal Decimal(Currency value)
	{
		decimal num = Currency.ToDecimal(value);
		lo = num.lo;
		mid = num.mid;
		hi = num.hi;
		flags = num.flags;
	}

	[__DynamicallyInvokable]
	public static long ToOACurrency(decimal value)
	{
		return new Currency(value).ToOACurrency();
	}

	[__DynamicallyInvokable]
	public static decimal FromOACurrency(long cy)
	{
		return Currency.ToDecimal(Currency.FromOACurrency(cy));
	}

	[__DynamicallyInvokable]
	public Decimal(int[] bits)
	{
		lo = 0;
		mid = 0;
		hi = 0;
		flags = 0;
		SetBits(bits);
	}

	private void SetBits(int[] bits)
	{
		if (bits == null)
		{
			throw new ArgumentNullException("bits");
		}
		if (bits.Length == 4)
		{
			int num = bits[3];
			if ((num & 0x7F00FFFF) == 0 && (num & 0xFF0000) <= 1835008)
			{
				lo = bits[0];
				mid = bits[1];
				hi = bits[2];
				flags = num;
				return;
			}
		}
		throw new ArgumentException(Environment.GetResourceString("Arg_DecBitCtor"));
	}

	[__DynamicallyInvokable]
	public Decimal(int lo, int mid, int hi, bool isNegative, byte scale)
	{
		if (scale > 28)
		{
			throw new ArgumentOutOfRangeException("scale", Environment.GetResourceString("ArgumentOutOfRange_DecimalScale"));
		}
		this.lo = lo;
		this.mid = mid;
		this.hi = hi;
		flags = scale << 16;
		if (isNegative)
		{
			flags |= int.MinValue;
		}
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		try
		{
			SetBits(GetBits(this));
		}
		catch (ArgumentException innerException)
		{
			throw new SerializationException(Environment.GetResourceString("Overflow_Decimal"), innerException);
		}
	}

	void IDeserializationCallback.OnDeserialization(object sender)
	{
		try
		{
			SetBits(GetBits(this));
		}
		catch (ArgumentException innerException)
		{
			throw new SerializationException(Environment.GetResourceString("Overflow_Decimal"), innerException);
		}
	}

	private Decimal(int lo, int mid, int hi, int flags)
	{
		if ((flags & 0x7F00FFFF) == 0 && (flags & 0xFF0000) <= 1835008)
		{
			this.lo = lo;
			this.mid = mid;
			this.hi = hi;
			this.flags = flags;
			return;
		}
		throw new ArgumentException(Environment.GetResourceString("Arg_DecBitCtor"));
	}

	internal static decimal Abs(decimal d)
	{
		return new decimal(d.lo, d.mid, d.hi, d.flags & 0x7FFFFFFF);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Add(decimal d1, decimal d2)
	{
		FCallAddSub(ref d1, ref d2, 0);
		return d1;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallAddSub(ref decimal d1, ref decimal d2, byte bSign);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallAddSubOverflowed(ref decimal d1, ref decimal d2, byte bSign, ref bool overflowed);

	[__DynamicallyInvokable]
	public static decimal Ceiling(decimal d)
	{
		return -Floor(-d);
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static int Compare(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2);
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static extern int FCallCompare(ref decimal d1, ref decimal d2);

	[SecuritySafeCritical]
	public int CompareTo(object value)
	{
		if (value == null)
		{
			return 1;
		}
		if (!(value is decimal d))
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_MustBeDecimal"));
		}
		return FCallCompare(ref this, ref d);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public int CompareTo(decimal value)
	{
		return FCallCompare(ref this, ref value);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Divide(decimal d1, decimal d2)
	{
		FCallDivide(ref d1, ref d2);
		return d1;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallDivide(ref decimal d1, ref decimal d2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallDivideOverflowed(ref decimal d1, ref decimal d2, ref bool overflowed);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override bool Equals(object value)
	{
		if (value is decimal d)
		{
			return FCallCompare(ref this, ref d) == 0;
		}
		return false;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public bool Equals(decimal value)
	{
		return FCallCompare(ref this, ref value) == 0;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override extern int GetHashCode();

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool Equals(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) == 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Floor(decimal d)
	{
		FCallFloor(ref d);
		return d;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallFloor(ref decimal d);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public override string ToString()
	{
		return Number.FormatDecimal(this, null, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format)
	{
		return Number.FormatDecimal(this, format, NumberFormatInfo.CurrentInfo);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(IFormatProvider provider)
	{
		return Number.FormatDecimal(this, null, NumberFormatInfo.GetInstance(provider));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public string ToString(string format, IFormatProvider provider)
	{
		return Number.FormatDecimal(this, format, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static decimal Parse(string s)
	{
		return Number.ParseDecimal(s, NumberStyles.Number, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static decimal Parse(string s, NumberStyles style)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Number.ParseDecimal(s, style, NumberFormatInfo.CurrentInfo);
	}

	[__DynamicallyInvokable]
	public static decimal Parse(string s, IFormatProvider provider)
	{
		return Number.ParseDecimal(s, NumberStyles.Number, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static decimal Parse(string s, NumberStyles style, IFormatProvider provider)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Number.ParseDecimal(s, style, NumberFormatInfo.GetInstance(provider));
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, out decimal result)
	{
		return Number.TryParseDecimal(s, NumberStyles.Number, NumberFormatInfo.CurrentInfo, out result);
	}

	[__DynamicallyInvokable]
	public static bool TryParse(string s, NumberStyles style, IFormatProvider provider, out decimal result)
	{
		NumberFormatInfo.ValidateParseStyleFloatingPoint(style);
		return Number.TryParseDecimal(s, style, NumberFormatInfo.GetInstance(provider), out result);
	}

	[__DynamicallyInvokable]
	public static int[] GetBits(decimal d)
	{
		return new int[4] { d.lo, d.mid, d.hi, d.flags };
	}

	internal static void GetBytes(decimal d, byte[] buffer)
	{
		buffer[0] = (byte)d.lo;
		buffer[1] = (byte)(d.lo >> 8);
		buffer[2] = (byte)(d.lo >> 16);
		buffer[3] = (byte)(d.lo >> 24);
		buffer[4] = (byte)d.mid;
		buffer[5] = (byte)(d.mid >> 8);
		buffer[6] = (byte)(d.mid >> 16);
		buffer[7] = (byte)(d.mid >> 24);
		buffer[8] = (byte)d.hi;
		buffer[9] = (byte)(d.hi >> 8);
		buffer[10] = (byte)(d.hi >> 16);
		buffer[11] = (byte)(d.hi >> 24);
		buffer[12] = (byte)d.flags;
		buffer[13] = (byte)(d.flags >> 8);
		buffer[14] = (byte)(d.flags >> 16);
		buffer[15] = (byte)(d.flags >> 24);
	}

	internal static decimal ToDecimal(byte[] buffer)
	{
		int num = buffer[0] | (buffer[1] << 8) | (buffer[2] << 16) | (buffer[3] << 24);
		int num2 = buffer[4] | (buffer[5] << 8) | (buffer[6] << 16) | (buffer[7] << 24);
		int num3 = buffer[8] | (buffer[9] << 8) | (buffer[10] << 16) | (buffer[11] << 24);
		int num4 = buffer[12] | (buffer[13] << 8) | (buffer[14] << 16) | (buffer[15] << 24);
		return new decimal(num, num2, num3, num4);
	}

	private static void InternalAddUInt32RawUnchecked(ref decimal value, uint i)
	{
		uint num = (uint)value.lo;
		uint num2 = (uint)(value.lo = (int)(num + i));
		if (num2 < num || num2 < i)
		{
			num = (uint)value.mid;
			num2 = (uint)(value.mid = (int)(num + 1));
			if (num2 < num || num2 < 1)
			{
				value.hi++;
			}
		}
	}

	private static uint InternalDivRemUInt32(ref decimal value, uint divisor)
	{
		uint num = 0u;
		if (value.hi != 0)
		{
			ulong num2 = (uint)value.hi;
			value.hi = (int)(num2 / divisor);
			num = (uint)(num2 % divisor);
		}
		if (value.mid != 0 || num != 0)
		{
			ulong num2 = ((ulong)num << 32) | (uint)value.mid;
			value.mid = (int)(num2 / divisor);
			num = (uint)(num2 % divisor);
		}
		if (value.lo != 0 || num != 0)
		{
			ulong num2 = ((ulong)num << 32) | (uint)value.lo;
			value.lo = (int)(num2 / divisor);
			num = (uint)(num2 % divisor);
		}
		return num;
	}

	private static void InternalRoundFromZero(ref decimal d, int decimalCount)
	{
		int num = (d.flags & 0xFF0000) >> 16;
		int num2 = num - decimalCount;
		if (num2 > 0)
		{
			uint num4;
			uint num5;
			do
			{
				int num3 = ((num2 > 9) ? 9 : num2);
				num4 = Powers10[num3];
				num5 = InternalDivRemUInt32(ref d, num4);
				num2 -= num3;
			}
			while (num2 > 0);
			if (num5 >= num4 >> 1)
			{
				InternalAddUInt32RawUnchecked(ref d, 1u);
			}
			d.flags = ((decimalCount << 16) & 0xFF0000) | (d.flags & int.MinValue);
		}
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static decimal Max(decimal d1, decimal d2)
	{
		if (FCallCompare(ref d1, ref d2) < 0)
		{
			return d2;
		}
		return d1;
	}

	[SecuritySafeCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	internal static decimal Min(decimal d1, decimal d2)
	{
		if (FCallCompare(ref d1, ref d2) >= 0)
		{
			return d2;
		}
		return d1;
	}

	[__DynamicallyInvokable]
	public static decimal Remainder(decimal d1, decimal d2)
	{
		d2.flags = (d2.flags & 0x7FFFFFFF) | (d1.flags & int.MinValue);
		if (Abs(d1) < Abs(d2))
		{
			return d1;
		}
		d1 -= d2;
		if (d1 == 0m)
		{
			d1.flags = (d1.flags & 0x7FFFFFFF) | (d2.flags & int.MinValue);
		}
		decimal num = Truncate(d1 / d2);
		decimal num2 = num * d2;
		decimal num3 = d1 - num2;
		if ((d1.flags & int.MinValue) != (num3.flags & int.MinValue))
		{
			if (-0.000000000000000000000000001m <= num3 && num3 <= 0.000000000000000000000000001m)
			{
				num3.flags = (num3.flags & 0x7FFFFFFF) | (d1.flags & int.MinValue);
			}
			else
			{
				num3 += d2;
			}
		}
		return num3;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Multiply(decimal d1, decimal d2)
	{
		FCallMultiply(ref d1, ref d2);
		return d1;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallMultiply(ref decimal d1, ref decimal d2);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallMultiplyOverflowed(ref decimal d1, ref decimal d2, ref bool overflowed);

	[__DynamicallyInvokable]
	public static decimal Negate(decimal d)
	{
		return new decimal(d.lo, d.mid, d.hi, d.flags ^ int.MinValue);
	}

	public static decimal Round(decimal d)
	{
		return Round(d, 0);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Round(decimal d, int decimals)
	{
		FCallRound(ref d, decimals);
		return d;
	}

	public static decimal Round(decimal d, MidpointRounding mode)
	{
		return Round(d, 0, mode);
	}

	[SecuritySafeCritical]
	public static decimal Round(decimal d, int decimals, MidpointRounding mode)
	{
		if (decimals < 0 || decimals > 28)
		{
			throw new ArgumentOutOfRangeException("decimals", Environment.GetResourceString("ArgumentOutOfRange_DecimalRound"));
		}
		switch (mode)
		{
		default:
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidEnumValue", mode, "MidpointRounding"), "mode");
		case MidpointRounding.ToEven:
			FCallRound(ref d, decimals);
			break;
		case MidpointRounding.AwayFromZero:
			InternalRoundFromZero(ref d, decimals);
			break;
		}
		return d;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallRound(ref decimal d, int decimals);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Subtract(decimal d1, decimal d2)
	{
		FCallAddSub(ref d1, ref d2, 128);
		return d1;
	}

	[__DynamicallyInvokable]
	public static byte ToByte(decimal value)
	{
		uint num;
		try
		{
			num = ToUInt32(value);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"), innerException);
		}
		if (num < 0 || num > 255)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Byte"));
		}
		return (byte)num;
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static sbyte ToSByte(decimal value)
	{
		int num;
		try
		{
			num = ToInt32(value);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"), innerException);
		}
		if (num < -128 || num > 127)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_SByte"));
		}
		return (sbyte)num;
	}

	[__DynamicallyInvokable]
	public static short ToInt16(decimal value)
	{
		int num;
		try
		{
			num = ToInt32(value);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"), innerException);
		}
		if (num < -32768 || num > 32767)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Int16"));
		}
		return (short)num;
	}

	[SecuritySafeCritical]
	internal static Currency ToCurrency(decimal d)
	{
		Currency result = default(Currency);
		FCallToCurrency(ref result, d);
		return result;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallToCurrency(ref Currency result, decimal d);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern double ToDouble(decimal d);

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	internal static extern int FCallToInt32(decimal d);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static int ToInt32(decimal d)
	{
		if ((d.flags & 0xFF0000) != 0)
		{
			FCallTruncate(ref d);
		}
		if (d.hi == 0 && d.mid == 0)
		{
			int num = d.lo;
			if (d.flags >= 0)
			{
				if (num >= 0)
				{
					return num;
				}
			}
			else
			{
				num = -num;
				if (num <= 0)
				{
					return num;
				}
			}
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_Int32"));
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static long ToInt64(decimal d)
	{
		if ((d.flags & 0xFF0000) != 0)
		{
			FCallTruncate(ref d);
		}
		if (d.hi == 0)
		{
			long num = (d.lo & 0xFFFFFFFFu) | ((long)d.mid << 32);
			if (d.flags >= 0)
			{
				if (num >= 0)
				{
					return num;
				}
			}
			else
			{
				num = -num;
				if (num <= 0)
				{
					return num;
				}
			}
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_Int64"));
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ushort ToUInt16(decimal value)
	{
		uint num;
		try
		{
			num = ToUInt32(value);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"), innerException);
		}
		if (num < 0 || num > 65535)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_UInt16"));
		}
		return (ushort)num;
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static uint ToUInt32(decimal d)
	{
		if ((d.flags & 0xFF0000) != 0)
		{
			FCallTruncate(ref d);
		}
		if (d.hi == 0 && d.mid == 0)
		{
			uint num = (uint)d.lo;
			if (d.flags >= 0 || num == 0)
			{
				return num;
			}
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_UInt32"));
	}

	[SecuritySafeCritical]
	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static ulong ToUInt64(decimal d)
	{
		if ((d.flags & 0xFF0000) != 0)
		{
			FCallTruncate(ref d);
		}
		if (d.hi == 0)
		{
			ulong num = (uint)d.lo | ((ulong)(uint)d.mid << 32);
			if (d.flags >= 0 || num == 0L)
			{
				return num;
			}
		}
		throw new OverflowException(Environment.GetResourceString("Overflow_UInt64"));
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static extern float ToSingle(decimal d);

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal Truncate(decimal d)
	{
		FCallTruncate(ref d);
		return d;
	}

	[MethodImpl(MethodImplOptions.InternalCall)]
	[SecurityCritical]
	private static extern void FCallTruncate(ref decimal d);

	[__DynamicallyInvokable]
	public static implicit operator decimal(byte value)
	{
		return new decimal(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static implicit operator decimal(sbyte value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static implicit operator decimal(short value)
	{
		return new decimal(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static implicit operator decimal(ushort value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static implicit operator decimal(char value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static implicit operator decimal(int value)
	{
		return new decimal(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static implicit operator decimal(uint value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static implicit operator decimal(long value)
	{
		return new decimal(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static implicit operator decimal(ulong value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator decimal(float value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator decimal(double value)
	{
		return new decimal(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator byte(decimal value)
	{
		return ToByte(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static explicit operator sbyte(decimal value)
	{
		return ToSByte(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator char(decimal value)
	{
		try
		{
			return (char)ToUInt16(value);
		}
		catch (OverflowException innerException)
		{
			throw new OverflowException(Environment.GetResourceString("Overflow_Char"), innerException);
		}
	}

	[__DynamicallyInvokable]
	public static explicit operator short(decimal value)
	{
		return ToInt16(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static explicit operator ushort(decimal value)
	{
		return ToUInt16(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator int(decimal value)
	{
		return ToInt32(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static explicit operator uint(decimal value)
	{
		return ToUInt32(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator long(decimal value)
	{
		return ToInt64(value);
	}

	[CLSCompliant(false)]
	[__DynamicallyInvokable]
	public static explicit operator ulong(decimal value)
	{
		return ToUInt64(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator float(decimal value)
	{
		return ToSingle(value);
	}

	[__DynamicallyInvokable]
	public static explicit operator double(decimal value)
	{
		return ToDouble(value);
	}

	[__DynamicallyInvokable]
	public static decimal operator +(decimal d)
	{
		return d;
	}

	[__DynamicallyInvokable]
	public static decimal operator -(decimal d)
	{
		return Negate(d);
	}

	[__DynamicallyInvokable]
	public static decimal operator ++(decimal d)
	{
		return Add(d, 1m);
	}

	[__DynamicallyInvokable]
	public static decimal operator --(decimal d)
	{
		return Subtract(d, 1m);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal operator +(decimal d1, decimal d2)
	{
		FCallAddSub(ref d1, ref d2, 0);
		return d1;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal operator -(decimal d1, decimal d2)
	{
		FCallAddSub(ref d1, ref d2, 128);
		return d1;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal operator *(decimal d1, decimal d2)
	{
		FCallMultiply(ref d1, ref d2);
		return d1;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static decimal operator /(decimal d1, decimal d2)
	{
		FCallDivide(ref d1, ref d2);
		return d1;
	}

	[__DynamicallyInvokable]
	public static decimal operator %(decimal d1, decimal d2)
	{
		return Remainder(d1, d2);
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator ==(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) == 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator !=(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) != 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator <(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) < 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator <=(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) <= 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator >(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) > 0;
	}

	[SecuritySafeCritical]
	[__DynamicallyInvokable]
	public static bool operator >=(decimal d1, decimal d2)
	{
		return FCallCompare(ref d1, ref d2) >= 0;
	}

	public TypeCode GetTypeCode()
	{
		return TypeCode.Decimal;
	}

	[__DynamicallyInvokable]
	bool IConvertible.ToBoolean(IFormatProvider provider)
	{
		return Convert.ToBoolean(this);
	}

	[__DynamicallyInvokable]
	char IConvertible.ToChar(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Decimal", "Char"));
	}

	[__DynamicallyInvokable]
	sbyte IConvertible.ToSByte(IFormatProvider provider)
	{
		return Convert.ToSByte(this);
	}

	[__DynamicallyInvokable]
	byte IConvertible.ToByte(IFormatProvider provider)
	{
		return Convert.ToByte(this);
	}

	[__DynamicallyInvokable]
	short IConvertible.ToInt16(IFormatProvider provider)
	{
		return Convert.ToInt16(this);
	}

	[__DynamicallyInvokable]
	ushort IConvertible.ToUInt16(IFormatProvider provider)
	{
		return Convert.ToUInt16(this);
	}

	[__DynamicallyInvokable]
	int IConvertible.ToInt32(IFormatProvider provider)
	{
		return Convert.ToInt32(this);
	}

	[__DynamicallyInvokable]
	uint IConvertible.ToUInt32(IFormatProvider provider)
	{
		return Convert.ToUInt32(this);
	}

	[__DynamicallyInvokable]
	long IConvertible.ToInt64(IFormatProvider provider)
	{
		return Convert.ToInt64(this);
	}

	[__DynamicallyInvokable]
	ulong IConvertible.ToUInt64(IFormatProvider provider)
	{
		return Convert.ToUInt64(this);
	}

	[__DynamicallyInvokable]
	float IConvertible.ToSingle(IFormatProvider provider)
	{
		return Convert.ToSingle(this);
	}

	[__DynamicallyInvokable]
	double IConvertible.ToDouble(IFormatProvider provider)
	{
		return Convert.ToDouble(this);
	}

	[__DynamicallyInvokable]
	decimal IConvertible.ToDecimal(IFormatProvider provider)
	{
		return this;
	}

	[__DynamicallyInvokable]
	DateTime IConvertible.ToDateTime(IFormatProvider provider)
	{
		throw new InvalidCastException(Environment.GetResourceString("InvalidCast_FromTo", "Decimal", "DateTime"));
	}

	[__DynamicallyInvokable]
	object IConvertible.ToType(Type type, IFormatProvider provider)
	{
		return Convert.DefaultToType(this, type, provider);
	}
}
