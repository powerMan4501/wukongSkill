using System.Runtime.InteropServices;

namespace System.Reflection;

[ComVisible(true)]
[__DynamicallyInvokable]
public class LocalVariableInfo
{
	private RuntimeType m_type;

	private int m_isPinned;

	private int m_localIndex;

	[__DynamicallyInvokable]
	public virtual Type LocalType
	{
		[__DynamicallyInvokable]
		get
		{
			return m_type;
		}
	}

	[__DynamicallyInvokable]
	public virtual bool IsPinned
	{
		[__DynamicallyInvokable]
		get
		{
			return m_isPinned != 0;
		}
	}

	[__DynamicallyInvokable]
	public virtual int LocalIndex
	{
		[__DynamicallyInvokable]
		get
		{
			return m_localIndex;
		}
	}

	[__DynamicallyInvokable]
	protected LocalVariableInfo()
	{
	}

	[__DynamicallyInvokable]
	public override string ToString()
	{
		string text = LocalType.ToString() + " (" + LocalIndex + ")";
		if (IsPinned)
		{
			text += " (pinned)";
		}
		return text;
	}
}
