using System.IO;
using System.Runtime.Serialization;
using System.Security.Permissions;

namespace System.Net;

[Serializable]
[global::__DynamicallyInvokable]
public abstract class WebResponse : MarshalByRefObject, ISerializable, IDisposable
{
	private bool m_IsCacheFresh;

	private bool m_IsFromCache;

	public virtual bool IsFromCache => m_IsFromCache;

	internal bool InternalSetFromCache
	{
		set
		{
			m_IsFromCache = value;
		}
	}

	internal virtual bool IsCacheFresh => m_IsCacheFresh;

	internal bool InternalSetIsCacheFresh
	{
		set
		{
			m_IsCacheFresh = value;
		}
	}

	public virtual bool IsMutuallyAuthenticated => false;

	[global::__DynamicallyInvokable]
	public virtual long ContentLength
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual string ContentType
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
		set
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Uri ResponseUri
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual WebHeaderCollection Headers
	{
		[global::__DynamicallyInvokable]
		get
		{
			throw ExceptionHelper.PropertyNotImplementedException;
		}
	}

	[global::__DynamicallyInvokable]
	public virtual bool SupportsHeaders
	{
		[global::__DynamicallyInvokable]
		get
		{
			return false;
		}
	}

	[global::__DynamicallyInvokable]
	protected WebResponse()
	{
	}

	protected WebResponse(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	[SecurityPermission(SecurityAction.LinkDemand, Flags = SecurityPermissionFlag.SerializationFormatter, SerializationFormatter = true)]
	void ISerializable.GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
		GetObjectData(serializationInfo, streamingContext);
	}

	[SecurityPermission(SecurityAction.Demand, SerializationFormatter = true)]
	protected virtual void GetObjectData(SerializationInfo serializationInfo, StreamingContext streamingContext)
	{
	}

	public virtual void Close()
	{
	}

	[global::__DynamicallyInvokable]
	public void Dispose()
	{
		Dispose(disposing: true);
		GC.SuppressFinalize(this);
	}

	[global::__DynamicallyInvokable]
	protected virtual void Dispose(bool disposing)
	{
		if (!disposing)
		{
			return;
		}
		try
		{
			Close();
		}
		catch
		{
		}
	}

	[global::__DynamicallyInvokable]
	public virtual Stream GetResponseStream()
	{
		throw ExceptionHelper.MethodNotImplementedException;
	}
}
