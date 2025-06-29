using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MissingMethodException : MissingMemberException, ISerializable
{
	[__DynamicallyInvokable]
	public override string Message
	{
		[SecuritySafeCritical]
		[__DynamicallyInvokable]
		get
		{
			if (ClassName == null)
			{
				return base.Message;
			}
			return Environment.GetResourceString("MissingMethod_Name", ClassName + "." + MemberName + ((Signature != null) ? (" " + MissingMemberException.FormatSignature(Signature)) : ""));
		}
	}

	[__DynamicallyInvokable]
	public MissingMethodException()
		: base(Environment.GetResourceString("Arg_MissingMethodException"))
	{
		SetErrorCode(-2146233069);
	}

	[__DynamicallyInvokable]
	public MissingMethodException(string message)
		: base(message)
	{
		SetErrorCode(-2146233069);
	}

	[__DynamicallyInvokable]
	public MissingMethodException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233069);
	}

	protected MissingMethodException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	private MissingMethodException(string className, string methodName, byte[] signature)
	{
		ClassName = className;
		MemberName = methodName;
		Signature = signature;
	}

	public MissingMethodException(string className, string methodName)
	{
		ClassName = className;
		MemberName = methodName;
	}
}
