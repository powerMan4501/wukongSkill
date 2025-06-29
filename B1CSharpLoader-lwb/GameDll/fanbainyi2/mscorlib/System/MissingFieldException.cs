using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class MissingFieldException : MissingMemberException, ISerializable
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
			return Environment.GetResourceString("MissingField_Name", ((Signature != null) ? (MissingMemberException.FormatSignature(Signature) + " ") : "") + ClassName + "." + MemberName);
		}
	}

	[__DynamicallyInvokable]
	public MissingFieldException()
		: base(Environment.GetResourceString("Arg_MissingFieldException"))
	{
		SetErrorCode(-2146233071);
	}

	[__DynamicallyInvokable]
	public MissingFieldException(string message)
		: base(message)
	{
		SetErrorCode(-2146233071);
	}

	[__DynamicallyInvokable]
	public MissingFieldException(string message, Exception inner)
		: base(message, inner)
	{
		SetErrorCode(-2146233071);
	}

	protected MissingFieldException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}

	private MissingFieldException(string className, string fieldName, byte[] signature)
	{
		ClassName = className;
		MemberName = fieldName;
		Signature = signature;
	}

	public MissingFieldException(string className, string fieldName)
	{
		ClassName = className;
		MemberName = fieldName;
	}
}
