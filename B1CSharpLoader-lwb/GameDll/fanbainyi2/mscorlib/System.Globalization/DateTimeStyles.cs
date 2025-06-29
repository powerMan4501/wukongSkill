using System.Runtime.InteropServices;

namespace System.Globalization;

[Serializable]
[Flags]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum DateTimeStyles
{
	[__DynamicallyInvokable]
	None = 0,
	[__DynamicallyInvokable]
	AllowLeadingWhite = 1,
	[__DynamicallyInvokable]
	AllowTrailingWhite = 2,
	[__DynamicallyInvokable]
	AllowInnerWhite = 4,
	[__DynamicallyInvokable]
	AllowWhiteSpaces = 7,
	[__DynamicallyInvokable]
	NoCurrentDateDefault = 8,
	[__DynamicallyInvokable]
	AdjustToUniversal = 0x10,
	[__DynamicallyInvokable]
	AssumeLocal = 0x20,
	[__DynamicallyInvokable]
	AssumeUniversal = 0x40,
	[__DynamicallyInvokable]
	RoundtripKind = 0x80
}
