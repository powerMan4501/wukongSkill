using System.Collections.Generic;

namespace System.Runtime.CompilerServices;

[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Parameter | AttributeTargets.ReturnValue)]
[global::__DynamicallyInvokable]
public sealed class DynamicAttribute : Attribute
{
	private readonly bool[] _transformFlags;

	[global::__DynamicallyInvokable]
	public IList<bool> TransformFlags
	{
		[global::__DynamicallyInvokable]
		get
		{
			return Array.AsReadOnly(_transformFlags);
		}
	}

	[global::__DynamicallyInvokable]
	public DynamicAttribute()
	{
		_transformFlags = new bool[1] { true };
	}

	[global::__DynamicallyInvokable]
	public DynamicAttribute(bool[] transformFlags)
	{
		if (transformFlags == null)
		{
			throw new ArgumentNullException("transformFlags");
		}
		_transformFlags = transformFlags;
	}
}
