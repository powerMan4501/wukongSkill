using System.Runtime.InteropServices;

namespace System.Reflection.Emit;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public enum OperandType
{
	[__DynamicallyInvokable]
	InlineBrTarget = 0,
	[__DynamicallyInvokable]
	InlineField = 1,
	[__DynamicallyInvokable]
	InlineI = 2,
	[__DynamicallyInvokable]
	InlineI8 = 3,
	[__DynamicallyInvokable]
	InlineMethod = 4,
	[__DynamicallyInvokable]
	InlineNone = 5,
	[Obsolete("This API has been deprecated. http://go.microsoft.com/fwlink/?linkid=14202")]
	InlinePhi = 6,
	[__DynamicallyInvokable]
	InlineR = 7,
	[__DynamicallyInvokable]
	InlineSig = 9,
	[__DynamicallyInvokable]
	InlineString = 10,
	[__DynamicallyInvokable]
	InlineSwitch = 11,
	[__DynamicallyInvokable]
	InlineTok = 12,
	[__DynamicallyInvokable]
	InlineType = 13,
	[__DynamicallyInvokable]
	InlineVar = 14,
	[__DynamicallyInvokable]
	ShortInlineBrTarget = 15,
	[__DynamicallyInvokable]
	ShortInlineI = 16,
	[__DynamicallyInvokable]
	ShortInlineR = 17,
	[__DynamicallyInvokable]
	ShortInlineVar = 18
}
