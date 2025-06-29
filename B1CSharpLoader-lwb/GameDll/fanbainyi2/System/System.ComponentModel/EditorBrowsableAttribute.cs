namespace System.ComponentModel;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate)]
[global::__DynamicallyInvokable]
public sealed class EditorBrowsableAttribute : Attribute
{
	private EditorBrowsableState browsableState;

	[global::__DynamicallyInvokable]
	public EditorBrowsableState State
	{
		[global::__DynamicallyInvokable]
		get
		{
			return browsableState;
		}
	}

	[global::__DynamicallyInvokable]
	public EditorBrowsableAttribute(EditorBrowsableState state)
	{
		browsableState = state;
	}

	public EditorBrowsableAttribute()
		: this(EditorBrowsableState.Always)
	{
	}

	[global::__DynamicallyInvokable]
	public override bool Equals(object obj)
	{
		if (obj == this)
		{
			return true;
		}
		if (obj is EditorBrowsableAttribute editorBrowsableAttribute)
		{
			return editorBrowsableAttribute.browsableState == browsableState;
		}
		return false;
	}

	[global::__DynamicallyInvokable]
	public override int GetHashCode()
	{
		return base.GetHashCode();
	}
}
