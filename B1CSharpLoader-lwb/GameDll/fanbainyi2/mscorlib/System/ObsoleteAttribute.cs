using System.Runtime.InteropServices;

namespace System;

[Serializable]
[AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct | AttributeTargets.Enum | AttributeTargets.Constructor | AttributeTargets.Method | AttributeTargets.Property | AttributeTargets.Field | AttributeTargets.Event | AttributeTargets.Interface | AttributeTargets.Delegate, Inherited = false)]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class ObsoleteAttribute : Attribute
{
	private string _message;

	private bool _error;

	[__DynamicallyInvokable]
	public string Message
	{
		[__DynamicallyInvokable]
		get
		{
			return _message;
		}
	}

	[__DynamicallyInvokable]
	public bool IsError
	{
		[__DynamicallyInvokable]
		get
		{
			return _error;
		}
	}

	[__DynamicallyInvokable]
	public ObsoleteAttribute()
	{
		_message = null;
		_error = false;
	}

	[__DynamicallyInvokable]
	public ObsoleteAttribute(string message)
	{
		_message = message;
		_error = false;
	}

	[__DynamicallyInvokable]
	public ObsoleteAttribute(string message, bool error)
	{
		_message = message;
		_error = error;
	}
}
