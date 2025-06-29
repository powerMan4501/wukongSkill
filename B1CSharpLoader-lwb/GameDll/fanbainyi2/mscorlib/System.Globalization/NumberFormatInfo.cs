using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;
using System.Threading;

namespace System.Globalization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class NumberFormatInfo : ICloneable, IFormatProvider
{
	private static volatile NumberFormatInfo invariantInfo;

	internal int[] numberGroupSizes = new int[1] { 3 };

	internal int[] currencyGroupSizes = new int[1] { 3 };

	internal int[] percentGroupSizes = new int[1] { 3 };

	internal string positiveSign = "+";

	internal string negativeSign = "-";

	internal string numberDecimalSeparator = ".";

	internal string numberGroupSeparator = ",";

	internal string currencyGroupSeparator = ",";

	internal string currencyDecimalSeparator = ".";

	internal string currencySymbol = "¤";

	internal string ansiCurrencySymbol;

	internal string nanSymbol = "NaN";

	internal string positiveInfinitySymbol = "Infinity";

	internal string negativeInfinitySymbol = "-Infinity";

	internal string percentDecimalSeparator = ".";

	internal string percentGroupSeparator = ",";

	internal string percentSymbol = "%";

	internal string perMilleSymbol = "‰";

	[OptionalField(VersionAdded = 2)]
	internal string[] nativeDigits = new string[10] { "0", "1", "2", "3", "4", "5", "6", "7", "8", "9" };

	[OptionalField(VersionAdded = 1)]
	internal int m_dataItem;

	internal int numberDecimalDigits = 2;

	internal int currencyDecimalDigits = 2;

	internal int currencyPositivePattern;

	internal int currencyNegativePattern;

	internal int numberNegativePattern = 1;

	internal int percentPositivePattern;

	internal int percentNegativePattern;

	internal int percentDecimalDigits = 2;

	[OptionalField(VersionAdded = 2)]
	internal int digitSubstitution = 1;

	internal bool isReadOnly;

	[OptionalField(VersionAdded = 1)]
	internal bool m_useUserOverride;

	[OptionalField(VersionAdded = 2)]
	internal bool m_isInvariant;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsNumber = true;

	[OptionalField(VersionAdded = 1)]
	internal bool validForParseAsCurrency = true;

	private const NumberStyles InvalidNumberStyles = ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier);

	[__DynamicallyInvokable]
	public static NumberFormatInfo InvariantInfo
	{
		[__DynamicallyInvokable]
		get
		{
			if (invariantInfo == null)
			{
				NumberFormatInfo numberFormatInfo = new NumberFormatInfo();
				numberFormatInfo.m_isInvariant = true;
				invariantInfo = ReadOnly(numberFormatInfo);
			}
			return invariantInfo;
		}
	}

	[__DynamicallyInvokable]
	public int CurrencyDecimalDigits
	{
		[__DynamicallyInvokable]
		get
		{
			return currencyDecimalDigits;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 99)
			{
				throw new ArgumentOutOfRangeException("CurrencyDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 99));
			}
			VerifyWritable();
			currencyDecimalDigits = value;
		}
	}

	[__DynamicallyInvokable]
	public string CurrencyDecimalSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return currencyDecimalSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyDecimalSeparator(value, "CurrencyDecimalSeparator");
			currencyDecimalSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public bool IsReadOnly
	{
		[__DynamicallyInvokable]
		get
		{
			return isReadOnly;
		}
	}

	[__DynamicallyInvokable]
	public int[] CurrencyGroupSizes
	{
		[__DynamicallyInvokable]
		get
		{
			return (int[])currencyGroupSizes.Clone();
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("CurrencyGroupSizes", Environment.GetResourceString("ArgumentNull_Obj"));
			}
			VerifyWritable();
			int[] groupSize = (int[])value.Clone();
			CheckGroupSize("CurrencyGroupSizes", groupSize);
			currencyGroupSizes = groupSize;
		}
	}

	[__DynamicallyInvokable]
	public int[] NumberGroupSizes
	{
		[__DynamicallyInvokable]
		get
		{
			return (int[])numberGroupSizes.Clone();
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("NumberGroupSizes", Environment.GetResourceString("ArgumentNull_Obj"));
			}
			VerifyWritable();
			int[] groupSize = (int[])value.Clone();
			CheckGroupSize("NumberGroupSizes", groupSize);
			numberGroupSizes = groupSize;
		}
	}

	[__DynamicallyInvokable]
	public int[] PercentGroupSizes
	{
		[__DynamicallyInvokable]
		get
		{
			return (int[])percentGroupSizes.Clone();
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PercentGroupSizes", Environment.GetResourceString("ArgumentNull_Obj"));
			}
			VerifyWritable();
			int[] groupSize = (int[])value.Clone();
			CheckGroupSize("PercentGroupSizes", groupSize);
			percentGroupSizes = groupSize;
		}
	}

	[__DynamicallyInvokable]
	public string CurrencyGroupSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return currencyGroupSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyGroupSeparator(value, "CurrencyGroupSeparator");
			currencyGroupSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public string CurrencySymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return currencySymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("CurrencySymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			currencySymbol = value;
		}
	}

	[__DynamicallyInvokable]
	public static NumberFormatInfo CurrentInfo
	{
		[__DynamicallyInvokable]
		get
		{
			CultureInfo currentCulture = Thread.CurrentThread.CurrentCulture;
			if (!currentCulture.m_isInherited)
			{
				NumberFormatInfo numInfo = currentCulture.numInfo;
				if (numInfo != null)
				{
					return numInfo;
				}
			}
			return (NumberFormatInfo)currentCulture.GetFormat(typeof(NumberFormatInfo));
		}
	}

	[__DynamicallyInvokable]
	public string NaNSymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return nanSymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("NaNSymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			nanSymbol = value;
		}
	}

	[__DynamicallyInvokable]
	public int CurrencyNegativePattern
	{
		[__DynamicallyInvokable]
		get
		{
			return currencyNegativePattern;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 15)
			{
				throw new ArgumentOutOfRangeException("CurrencyNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 15));
			}
			VerifyWritable();
			currencyNegativePattern = value;
		}
	}

	[__DynamicallyInvokable]
	public int NumberNegativePattern
	{
		[__DynamicallyInvokable]
		get
		{
			return numberNegativePattern;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 4)
			{
				throw new ArgumentOutOfRangeException("NumberNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 4));
			}
			VerifyWritable();
			numberNegativePattern = value;
		}
	}

	[__DynamicallyInvokable]
	public int PercentPositivePattern
	{
		[__DynamicallyInvokable]
		get
		{
			return percentPositivePattern;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 3)
			{
				throw new ArgumentOutOfRangeException("PercentPositivePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 3));
			}
			VerifyWritable();
			percentPositivePattern = value;
		}
	}

	[__DynamicallyInvokable]
	public int PercentNegativePattern
	{
		[__DynamicallyInvokable]
		get
		{
			return percentNegativePattern;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 11)
			{
				throw new ArgumentOutOfRangeException("PercentNegativePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 11));
			}
			VerifyWritable();
			percentNegativePattern = value;
		}
	}

	[__DynamicallyInvokable]
	public string NegativeInfinitySymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return negativeInfinitySymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("NegativeInfinitySymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			negativeInfinitySymbol = value;
		}
	}

	[__DynamicallyInvokable]
	public string NegativeSign
	{
		[__DynamicallyInvokable]
		get
		{
			return negativeSign;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("NegativeSign", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			negativeSign = value;
		}
	}

	[__DynamicallyInvokable]
	public int NumberDecimalDigits
	{
		[__DynamicallyInvokable]
		get
		{
			return numberDecimalDigits;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 99)
			{
				throw new ArgumentOutOfRangeException("NumberDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 99));
			}
			VerifyWritable();
			numberDecimalDigits = value;
		}
	}

	[__DynamicallyInvokable]
	public string NumberDecimalSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return numberDecimalSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyDecimalSeparator(value, "NumberDecimalSeparator");
			numberDecimalSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public string NumberGroupSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return numberGroupSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyGroupSeparator(value, "NumberGroupSeparator");
			numberGroupSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public int CurrencyPositivePattern
	{
		[__DynamicallyInvokable]
		get
		{
			return currencyPositivePattern;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 3)
			{
				throw new ArgumentOutOfRangeException("CurrencyPositivePattern", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 3));
			}
			VerifyWritable();
			currencyPositivePattern = value;
		}
	}

	[__DynamicallyInvokable]
	public string PositiveInfinitySymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return positiveInfinitySymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PositiveInfinitySymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			positiveInfinitySymbol = value;
		}
	}

	[__DynamicallyInvokable]
	public string PositiveSign
	{
		[__DynamicallyInvokable]
		get
		{
			return positiveSign;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PositiveSign", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			positiveSign = value;
		}
	}

	[__DynamicallyInvokable]
	public int PercentDecimalDigits
	{
		[__DynamicallyInvokable]
		get
		{
			return percentDecimalDigits;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value < 0 || value > 99)
			{
				throw new ArgumentOutOfRangeException("PercentDecimalDigits", string.Format(CultureInfo.CurrentCulture, Environment.GetResourceString("ArgumentOutOfRange_Range"), 0, 99));
			}
			VerifyWritable();
			percentDecimalDigits = value;
		}
	}

	[__DynamicallyInvokable]
	public string PercentDecimalSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return percentDecimalSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyDecimalSeparator(value, "PercentDecimalSeparator");
			percentDecimalSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public string PercentGroupSeparator
	{
		[__DynamicallyInvokable]
		get
		{
			return percentGroupSeparator;
		}
		[__DynamicallyInvokable]
		set
		{
			VerifyWritable();
			VerifyGroupSeparator(value, "PercentGroupSeparator");
			percentGroupSeparator = value;
		}
	}

	[__DynamicallyInvokable]
	public string PercentSymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return percentSymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PercentSymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			percentSymbol = value;
		}
	}

	[__DynamicallyInvokable]
	public string PerMilleSymbol
	{
		[__DynamicallyInvokable]
		get
		{
			return perMilleSymbol;
		}
		[__DynamicallyInvokable]
		set
		{
			if (value == null)
			{
				throw new ArgumentNullException("PerMilleSymbol", Environment.GetResourceString("ArgumentNull_String"));
			}
			VerifyWritable();
			perMilleSymbol = value;
		}
	}

	[ComVisible(false)]
	public string[] NativeDigits
	{
		get
		{
			return (string[])nativeDigits.Clone();
		}
		set
		{
			VerifyWritable();
			VerifyNativeDigits(value, "NativeDigits");
			nativeDigits = value;
		}
	}

	[ComVisible(false)]
	public DigitShapes DigitSubstitution
	{
		get
		{
			return (DigitShapes)digitSubstitution;
		}
		set
		{
			VerifyWritable();
			VerifyDigitSubstitution(value, "DigitSubstitution");
			digitSubstitution = (int)value;
		}
	}

	[__DynamicallyInvokable]
	public NumberFormatInfo()
		: this(null)
	{
	}

	[OnSerializing]
	private void OnSerializing(StreamingContext ctx)
	{
		if (numberDecimalSeparator != numberGroupSeparator)
		{
			validForParseAsNumber = true;
		}
		else
		{
			validForParseAsNumber = false;
		}
		if (numberDecimalSeparator != numberGroupSeparator && numberDecimalSeparator != currencyGroupSeparator && currencyDecimalSeparator != numberGroupSeparator && currencyDecimalSeparator != currencyGroupSeparator)
		{
			validForParseAsCurrency = true;
		}
		else
		{
			validForParseAsCurrency = false;
		}
	}

	[OnDeserializing]
	private void OnDeserializing(StreamingContext ctx)
	{
	}

	[OnDeserialized]
	private void OnDeserialized(StreamingContext ctx)
	{
	}

	private static void VerifyDecimalSeparator(string decSep, string propertyName)
	{
		if (decSep == null)
		{
			throw new ArgumentNullException(propertyName, Environment.GetResourceString("ArgumentNull_String"));
		}
		if (decSep.Length == 0)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_EmptyDecString"));
		}
	}

	private static void VerifyGroupSeparator(string groupSep, string propertyName)
	{
		if (groupSep == null)
		{
			throw new ArgumentNullException(propertyName, Environment.GetResourceString("ArgumentNull_String"));
		}
	}

	private static void VerifyNativeDigits(string[] nativeDig, string propertyName)
	{
		if (nativeDig == null)
		{
			throw new ArgumentNullException(propertyName, Environment.GetResourceString("ArgumentNull_Array"));
		}
		if (nativeDig.Length != 10)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNativeDigitCount"), propertyName);
		}
		for (int i = 0; i < nativeDig.Length; i++)
		{
			if (nativeDig[i] == null)
			{
				throw new ArgumentNullException(propertyName, Environment.GetResourceString("ArgumentNull_ArrayValue"));
			}
			if (nativeDig[i].Length != 1)
			{
				if (nativeDig[i].Length != 2)
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNativeDigitValue"), propertyName);
				}
				if (!char.IsSurrogatePair(nativeDig[i][0], nativeDig[i][1]))
				{
					throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNativeDigitValue"), propertyName);
				}
			}
			if (CharUnicodeInfo.GetDecimalDigitValue(nativeDig[i], 0) != i && CharUnicodeInfo.GetUnicodeCategory(nativeDig[i], 0) != UnicodeCategory.PrivateUse)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNativeDigitValue"), propertyName);
			}
		}
	}

	private static void VerifyDigitSubstitution(DigitShapes digitSub, string propertyName)
	{
		if ((uint)digitSub > 2u)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidDigitSubstitution"), propertyName);
		}
	}

	[SecuritySafeCritical]
	internal NumberFormatInfo(CultureData cultureData)
	{
		if (cultureData != null)
		{
			cultureData.GetNFIValues(this);
			if (cultureData.IsInvariantCulture)
			{
				m_isInvariant = true;
			}
		}
	}

	private void VerifyWritable()
	{
		if (isReadOnly)
		{
			throw new InvalidOperationException(Environment.GetResourceString("InvalidOperation_ReadOnly"));
		}
	}

	[__DynamicallyInvokable]
	public static NumberFormatInfo GetInstance(IFormatProvider formatProvider)
	{
		if (formatProvider is CultureInfo { m_isInherited: false, numInfo: var numInfo } cultureInfo)
		{
			if (numInfo != null)
			{
				return numInfo;
			}
			return cultureInfo.NumberFormat;
		}
		if (formatProvider is NumberFormatInfo result)
		{
			return result;
		}
		if (formatProvider != null && formatProvider.GetFormat(typeof(NumberFormatInfo)) is NumberFormatInfo result2)
		{
			return result2;
		}
		return CurrentInfo;
	}

	[__DynamicallyInvokable]
	public object Clone()
	{
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)MemberwiseClone();
		numberFormatInfo.isReadOnly = false;
		return numberFormatInfo;
	}

	internal static void CheckGroupSize(string propName, int[] groupSize)
	{
		for (int i = 0; i < groupSize.Length; i++)
		{
			if (groupSize[i] < 1)
			{
				if (i == groupSize.Length - 1 && groupSize[i] == 0)
				{
					break;
				}
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidGroupSize"), propName);
			}
			if (groupSize[i] > 9)
			{
				throw new ArgumentException(Environment.GetResourceString("Argument_InvalidGroupSize"), propName);
			}
		}
	}

	[__DynamicallyInvokable]
	public object GetFormat(Type formatType)
	{
		if (!(formatType == typeof(NumberFormatInfo)))
		{
			return null;
		}
		return this;
	}

	[__DynamicallyInvokable]
	public static NumberFormatInfo ReadOnly(NumberFormatInfo nfi)
	{
		if (nfi == null)
		{
			throw new ArgumentNullException("nfi");
		}
		if (nfi.IsReadOnly)
		{
			return nfi;
		}
		NumberFormatInfo numberFormatInfo = (NumberFormatInfo)nfi.MemberwiseClone();
		numberFormatInfo.isReadOnly = true;
		return numberFormatInfo;
	}

	internal static void ValidateParseStyleInteger(NumberStyles style)
	{
		if ((style & ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNumberStyles"), "style");
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None && (style & ~NumberStyles.HexNumber) != NumberStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_InvalidHexStyle"));
		}
	}

	internal static void ValidateParseStyleFloatingPoint(NumberStyles style)
	{
		if ((style & ~(NumberStyles.Any | NumberStyles.AllowHexSpecifier)) != NumberStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Argument_InvalidNumberStyles"), "style");
		}
		if ((style & NumberStyles.AllowHexSpecifier) != NumberStyles.None)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_HexStyleNotSupported"));
		}
	}
}
