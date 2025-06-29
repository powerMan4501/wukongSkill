using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum NumberStyles
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	AllowLeadingWhite = 1,
	[__DynamicallyInvokable]
	AllowTrailingWhite = 2,
	[__DynamicallyInvokable]
	AllowLeadingSign = 4,
	[__DynamicallyInvokable]
	AllowTrailingSign = 8,
	[__DynamicallyInvokable]
	AllowParentheses = 0x10,
	[__DynamicallyInvokable]
	AllowDecimalPoint = 0x20,
	[__DynamicallyInvokable]
	AllowThousands = 0x40,
	[__DynamicallyInvokable]
	AllowExponent = 0x80,
	[__DynamicallyInvokable]
	AllowCurrencySymbol = 0x100,
	[__DynamicallyInvokable]
	AllowHexSpecifier = 0x200,
	[__DynamicallyInvokable]
	Integer = 7,
	[__DynamicallyInvokable]
	HexNumber = 0x203,
	[__DynamicallyInvokable]
	Number = 0x6F,
	[__DynamicallyInvokable]
	Float = 0xA7,
	[__DynamicallyInvokable]
	Currency = 0x17F,
	[__DynamicallyInvokable]
	Any = 0x1FF
}
