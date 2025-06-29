using System.Runtime.InteropServices;
using System.Runtime.Serialization;

namespace System;

[Serializable]
[ComVisible(true)]
public class DuplicateWaitObjectException : ArgumentException
{
	private static volatile string _duplicateWaitObjectMessage;

	private static string DuplicateWaitObjectMessage
	{
		get
		{
			if (_duplicateWaitObjectMessage == null)
			{
				_duplicateWaitObjectMessage = Environment.GetResourceString("Arg_DuplicateWaitObjectException");
			}
			return _duplicateWaitObjectMessage;
		}
	}

	public DuplicateWaitObjectException()
		: base(DuplicateWaitObjectMessage)
	{
		SetErrorCode(-2146233047);
	}

	public DuplicateWaitObjectException(string parameterName)
		: base(DuplicateWaitObjectMessage, parameterName)
	{
		SetErrorCode(-2146233047);
	}

	public DuplicateWaitObjectException(string parameterName, string message)
		: base(message, parameterName)
	{
		SetErrorCode(-2146233047);
	}

	public DuplicateWaitObjectException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233047);
	}

	protected DuplicateWaitObjectException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
