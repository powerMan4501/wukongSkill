using System.Runtime.InteropServices;

namespace System.Runtime.CompilerServices;

[Serializable]
[AttributeUsage(AttributeTargets.Assembly | AttributeTargets.Module | AttributeTargets.Class | AttributeTargets.Method)]
[ComVisible(true)]
[__DynamicallyInvokable]
public class CompilationRelaxationsAttribute : Attribute
{
	private int m_relaxations;

	[__DynamicallyInvokable]
	public int CompilationRelaxations
	{
		[__DynamicallyInvokable]
		get
		{
			return m_relaxations;
		}
	}

	[__DynamicallyInvokable]
	public CompilationRelaxationsAttribute(int relaxations)
	{
		m_relaxations = relaxations;
	}

	public CompilationRelaxationsAttribute(CompilationRelaxations relaxations)
	{
		m_relaxations = (int)relaxations;
	}
}
