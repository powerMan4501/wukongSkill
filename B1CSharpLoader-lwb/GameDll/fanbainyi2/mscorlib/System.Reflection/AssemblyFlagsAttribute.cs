using System.Runtime.InteropServices;

namespace System.Reflection;

[AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class AssemblyFlagsAttribute : Attribute
{
	private AssemblyNameFlags m_flags;

	[Obsolete("This property has been deprecated. Please use AssemblyFlags instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	[CLSCompliant(false)]
	public uint Flags => (uint)m_flags;

	[__DynamicallyInvokable]
	public int AssemblyFlags
	{
		[__DynamicallyInvokable]
		get
		{
			return (int)m_flags;
		}
	}

	[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	[CLSCompliant(false)]
	public AssemblyFlagsAttribute(uint flags)
	{
		m_flags = (AssemblyNameFlags)flags;
	}

	[Obsolete("This constructor has been deprecated. Please use AssemblyFlagsAttribute(AssemblyNameFlags) instead. http://go.microsoft.com/fwlink/?linkid=14202")]
	public AssemblyFlagsAttribute(int assemblyFlags)
	{
		m_flags = (AssemblyNameFlags)assemblyFlags;
	}

	[__DynamicallyInvokable]
	public AssemblyFlagsAttribute(AssemblyNameFlags assemblyFlags)
	{
		m_flags = assemblyFlags;
	}
}
