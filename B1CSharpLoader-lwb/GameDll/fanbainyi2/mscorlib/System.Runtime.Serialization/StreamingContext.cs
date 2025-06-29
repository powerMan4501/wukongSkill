using System.Runtime.InteropServices;

namespace System.Runtime.Serialization;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public struct StreamingContext
{
	internal object m_additionalContext;

	internal StreamingContextStates m_state;

	public object Context => m_additionalContext;

	public StreamingContextStates State => m_state;

	public StreamingContext(StreamingContextStates state)
		: this(state, null)
	{
	}

	public StreamingContext(StreamingContextStates state, object additional)
	{
		m_state = state;
		m_additionalContext = additional;
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is StreamingContext))
		{
			return false;
		}
		if (((StreamingContext)obj).m_additionalContext == m_additionalContext && ((StreamingContext)obj).m_state == m_state)
		{
			return true;
		}
		return false;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return (int)m_state;
	}
}
