namespace System.Runtime.InteropServices.WindowsRuntime;

[__DynamicallyInvokable]
public struct EventRegistrationToken
{
	internal ulong m_value;

	internal ulong Value => m_value;

	internal EventRegistrationToken(ulong value)
	{
		m_value = value;
	}

	[__DynamicallyInvokable]
	public static bool operator ==(EventRegistrationToken left, EventRegistrationToken right)
	{
		return left.Equals(right);
	}

	[__DynamicallyInvokable]
	public static bool operator !=(EventRegistrationToken left, EventRegistrationToken right)
	{
		return !left.Equals(right);
	}

	[__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (!(obj is EventRegistrationToken eventRegistrationToken))
		{
			return false;
		}
		return eventRegistrationToken.Value == Value;
	}

	[__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return m_value.GetHashCode();
	}
}
