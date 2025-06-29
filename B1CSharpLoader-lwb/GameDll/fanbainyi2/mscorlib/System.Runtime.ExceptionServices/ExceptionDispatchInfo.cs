namespace System.Runtime.ExceptionServices;

[__DynamicallyInvokable]
public sealed class ExceptionDispatchInfo
{
	private Exception m_Exception;

	private string m_remoteStackTrace;

	private object m_stackTrace;

	private object m_dynamicMethods;

	private UIntPtr m_IPForWatsonBuckets;

	private object m_WatsonBuckets;

	internal UIntPtr IPForWatsonBuckets => m_IPForWatsonBuckets;

	internal object WatsonBuckets => m_WatsonBuckets;

	internal object BinaryStackTraceArray => m_stackTrace;

	internal object DynamicMethodArray => m_dynamicMethods;

	internal string RemoteStackTrace => m_remoteStackTrace;

	[__DynamicallyInvokable]
	public Exception SourceException
	{
		[__DynamicallyInvokable]
		get
		{
			return m_Exception;
		}
	}

	private ExceptionDispatchInfo(Exception exception)
	{
		m_Exception = exception;
		m_remoteStackTrace = exception.RemoteStackTrace;
		m_Exception.GetStackTracesDeepCopy(out var currentStackTrace, out var dynamicMethodArray);
		m_stackTrace = currentStackTrace;
		m_dynamicMethods = dynamicMethodArray;
		m_IPForWatsonBuckets = exception.IPForWatsonBuckets;
		m_WatsonBuckets = exception.WatsonBuckets;
	}

	[__DynamicallyInvokable]
	public static ExceptionDispatchInfo Capture(Exception source)
	{
		if (source == null)
		{
			throw new ArgumentNullException("source", Environment.GetResourceString("ArgumentNull_Obj"));
		}
		return new ExceptionDispatchInfo(source);
	}

	[__DynamicallyInvokable]
	public void Throw()
	{
		m_Exception.RestoreExceptionDispatchInfo(this);
		throw m_Exception;
	}
}
