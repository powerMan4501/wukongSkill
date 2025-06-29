using System.Runtime.InteropServices;

namespace System.Runtime.Serialization.Formatters;

[Serializable]
[ComVisible(true)]
public enum FormatterTypeStyle
{
	TypesWhenNeeded,
	TypesAlways,
	XsdString
}
