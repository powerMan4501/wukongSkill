using System.Configuration.Assemblies;
using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
public sealed class AssemblyAlgorithmIdAttribute : Attribute
{
	private uint m_algId;

	[CLSCompliant(false)]
	public uint AlgorithmId => m_algId;

	public AssemblyAlgorithmIdAttribute(AssemblyHashAlgorithm algorithmId)
	{
		m_algId = (uint)algorithmId;
	}

	[CLSCompliant(false)]
	public AssemblyAlgorithmIdAttribute(uint algorithmId)
	{
		m_algId = algorithmId;
	}
}
