using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ArgumentException : SystemException, ISerializable
{
	private string m_paramName;

	[__DynamicallyInvokable]
	public override string Message
	{
		[__DynamicallyInvokable]
		get
		{
			string message = base.Message;
			if (!string.IsNullOrEmpty(m_paramName))
			{
				string resourceString = Environment.GetResourceString("Arg_ParamName_Name", m_paramName);
				return message + Environment.NewLine + resourceString;
			}
			return message;
		}
	}

	[__DynamicallyInvokable]
	public virtual string ParamName
	{
		[__DynamicallyInvokable]
		get
		{
			return m_paramName;
		}
	}

	[__DynamicallyInvokable]
	public ArgumentException()
		: base(Environment.GetResourceString("Arg_ArgumentException"))
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public ArgumentException(string message)
		: base(message)
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public ArgumentException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public ArgumentException(string message, string paramName, Exception innerException)
		: base(message, innerException)
	{
		m_paramName = paramName;
		SetErrorCode(-2147024809);
	}

	[__DynamicallyInvokable]
	public ArgumentException(string message, string paramName)
		: base(message)
	{
		m_paramName = paramName;
		SetErrorCode(-2147024809);
	}

	protected ArgumentException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		m_paramName = info.GetString("ParamName");
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("ParamName", m_paramName, typeof(string));
	}
}
