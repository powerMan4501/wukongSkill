using System.Diagnostics;

namespace System.Collections;

[DebuggerDisplay("{value}", Name = "[{key}]", Type = "")]
internal class KeyValuePairs
{
	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object key;

	[DebuggerBrowsable(DebuggerBrowsableState.Never)]
	private object value;

	public object Key => key;

	public object Value => value;

	public KeyValuePairs(object key, object value)
	{
		this.value = value;
		this.key = key;
	}
}
