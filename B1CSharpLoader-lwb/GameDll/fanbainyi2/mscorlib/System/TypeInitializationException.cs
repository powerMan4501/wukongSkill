using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public sealed class TypeInitializationException : SystemException
{
	private string _typeName;

	[__DynamicallyInvokable]
	public string TypeName
	{
		[__DynamicallyInvokable]
		get
		{
			if (_typeName == null)
			{
				return string.Empty;
			}
			return _typeName;
		}
	}

	private TypeInitializationException()
		: base(Environment.GetResourceString("TypeInitialization_Default"))
	{
		SetErrorCode(-2146233036);
	}

	private TypeInitializationException(string message)
		: base(message)
	{
		SetErrorCode(-2146233036);
	}

	[__DynamicallyInvokable]
	public TypeInitializationException(string fullTypeName, Exception innerException)
		: base(Environment.GetResourceString("TypeInitialization_Type", fullTypeName), innerException)
	{
		_typeName = fullTypeName;
		SetErrorCode(-2146233036);
	}

	internal TypeInitializationException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		_typeName = info.GetString("TypeName");
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		base.GetObjectData(info, context);
		info.AddValue("TypeName", TypeName, typeof(string));
	}
}
