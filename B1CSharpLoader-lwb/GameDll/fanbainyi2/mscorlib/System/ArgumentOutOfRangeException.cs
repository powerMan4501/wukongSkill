using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Security;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class ArgumentOutOfRangeException : ArgumentException, ISerializable
{
	private static volatile string _rangeMessage;

	private object m_actualValue;

	private static string RangeMessage
	{
		get
		{
			if (_rangeMessage == null)
			{
				_rangeMessage = Environment.GetResourceString("Arg_ArgumentOutOfRangeException");
			}
			return _rangeMessage;
		}
	}

	[__DynamicallyInvokable]
	public override string Message
	{
		[__DynamicallyInvokable]
		get
		{
			string message = base.Message;
			if (m_actualValue != null)
			{
				string resourceString = Environment.GetResourceString("ArgumentOutOfRange_ActualValue", m_actualValue.ToString());
				if (message == null)
				{
					return resourceString;
				}
				return message + Environment.NewLine + resourceString;
			}
			return message;
		}
	}

	[__DynamicallyInvokable]
	public virtual object ActualValue
	{
		[__DynamicallyInvokable]
		get
		{
			return m_actualValue;
		}
	}

	[__DynamicallyInvokable]
	public ArgumentOutOfRangeException()
		: base(RangeMessage)
	{
		SetErrorCode(-2146233086);
	}

	[__DynamicallyInvokable]
	public ArgumentOutOfRangeException(string paramName)
		: base(RangeMessage, paramName)
	{
		SetErrorCode(-2146233086);
	}

	[__DynamicallyInvokable]
	public ArgumentOutOfRangeException(string paramName, string message)
		: base(message, paramName)
	{
		SetErrorCode(-2146233086);
	}

	[__DynamicallyInvokable]
	public ArgumentOutOfRangeException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233086);
	}

	[__DynamicallyInvokable]
	public ArgumentOutOfRangeException(string paramName, object actualValue, string message)
		: base(message, paramName)
	{
		m_actualValue = actualValue;
		SetErrorCode(-2146233086);
	}

	[SecurityCritical]
	public override void GetObjectData(SerializationInfo info, StreamingContext context)
	{
		if (info == null)
		{
			throw new ArgumentNullException("info");
		}
		base.GetObjectData(info, context);
		info.AddValue("ActualValue", m_actualValue, typeof(object));
	}

	protected ArgumentOutOfRangeException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
		m_actualValue = info.GetValue("ActualValue", typeof(object));
	}
}
