using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public class WebException : InvalidOperationException, ISerializable
{
	private WebExceptionStatus m_Status = WebExceptionStatus.UnknownError;

	private WebResponse m_Response;

	[NonSerialized]
	private WebExceptionInternalStatus m_InternalStatus;

	[global::__DynamicallyInvokable]
	public WebExceptionStatus Status
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Status;
		}
	}

	[global::__DynamicallyInvokable]
	public WebResponse Response
	{
		[global::__DynamicallyInvokable]
		get
		{
			return m_Response;
		}
	}

	internal WebExceptionInternalStatus InternalStatus => m_InternalStatus;

	[global::__DynamicallyInvokable]
	public WebException()
	{
	}

	[global::__DynamicallyInvokable]
	public WebException(string message)
		: this(message, null)
	{
	}

	[global::__DynamicallyInvokable]
	public WebException(string message, Exception innerException)
		: base(message, innerException)
	{
	}

	[global::__DynamicallyInvokable]
	public WebException(string message, WebExceptionStatus status)
		: this(message, null, status, null)
	{
	}

	internal WebException(string message, WebExceptionStatus status, WebExceptionInternalStatus internalStatus, Exception innerException)
		: this(message, innerException, status, null, internalStatus)
	{
	}

	[global::__DynamicallyInvokable]
	public WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response)
		: this(message, null, innerException, status, response)
	{
	}

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response)
		: base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
	{
		m_Status = status;
		m_Response = response;
	}

	internal WebException(string message, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		: this(message, null, innerException, status, response, internalStatus)
	{
	}

	internal WebException(string message, string data, Exception innerException, WebExceptionStatus status, WebResponse response, WebExceptionInternalStatus internalStatus)
		: base(message + ((data != null) ? (": '" + data + "'") : ""), innerException)
	{
		m_Status = status;
		m_Response = response;
		m_InternalStatus = internalStatus;
	}

	protected WebException(SerializationInfo serializationInfo, StreamingContext streamingContext)
		: base(serializationInfo, streamingContext)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		GetObjectData(serializationInfo, streamingContext);
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter)]
	public override void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		base.GetObjectData(serializationInfo, streamingContext);
	}
}
