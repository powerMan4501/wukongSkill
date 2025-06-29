using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Property, Inherited = true)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class IndexerNameAttribute : Attribute
{
	[__DynamicallyInvokable]
	public IndexerNameAttribute(string indexerName)
	{
	}
}
