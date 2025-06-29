namespace System.Text.RegularExpressions;

[Flags]
[global::__DynamicallyInvokable]
public enum RegexOptions
{
	[global::__DynamicallyInvokable]
	None = 0,
	[global::__DynamicallyInvokable]
	IgnoreCase = 1,
	[global::__DynamicallyInvokable]
	Multiline = 2,
	[global::__DynamicallyInvokable]
	ExplicitCapture = 4,
	[global::__DynamicallyInvokable]
	Compiled = 8,
	[global::__DynamicallyInvokable]
	Singleline = 0x10,
	[global::__DynamicallyInvokable]
	IgnorePatternWhitespace = 0x20,
	[global::__DynamicallyInvokable]
	RightToLeft = 0x40,
	[global::__DynamicallyInvokable]
	ECMAScript = 0x100,
	[global::__DynamicallyInvokable]
	CultureInvariant = 0x200
}
