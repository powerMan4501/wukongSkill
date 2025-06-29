namespace System.Runtime;

[AttributeUsage(AttributeTargets.Constructor | AttributeTargets.Method, AllowMultiple = false, Inherited = false)]
public sealed class TargetedPatchingOptOutAttribute : Attribute
{
	private string m_reason;

	public string Reason => m_reason;

	public TargetedPatchingOptOutAttribute(string reason)
	{
		m_reason = reason;
	}

	private TargetedPatchingOptOutAttribute()
	{
	}
}
