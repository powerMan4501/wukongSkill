using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Threading;

namespace System;

[Serializable]
[ComVisible(true)]
[__DynamicallyInvokable]
public class OperationCanceledException : SystemException
{
	[NonSerialized]
	private CancellationToken _cancellationToken;

	[__DynamicallyInvokable]
	public CancellationToken CancellationToken
	{
		[__DynamicallyInvokable]
		get
		{
			return _cancellationToken;
		}
		private set
		{
			_cancellationToken = value;
		}
	}

	[__DynamicallyInvokable]
	public OperationCanceledException()
		: base(Environment.GetResourceString("OperationCanceled"))
	{
		SetErrorCode(-2146233029);
	}

	[__DynamicallyInvokable]
	public OperationCanceledException(string message)
		: base(message)
	{
		SetErrorCode(-2146233029);
	}

	[__DynamicallyInvokable]
	public OperationCanceledException(string message, Exception innerException)
		: base(message, innerException)
	{
		SetErrorCode(-2146233029);
	}

	[__DynamicallyInvokable]
	public OperationCanceledException(CancellationToken token)
		: this()
	{
		CancellationToken = token;
	}

	[__DynamicallyInvokable]
	public OperationCanceledException(string message, CancellationToken token)
		: this(message)
	{
		CancellationToken = token;
	}

	[__DynamicallyInvokable]
	public OperationCanceledException(string message, Exception innerException, CancellationToken token)
		: this(message, innerException)
	{
		CancellationToken = token;
	}

	protected OperationCanceledException(SerializationInfo info, StreamingContext context)
		: base(info, context)
	{
	}
}
