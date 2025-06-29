using System.Threading;

namespace System.Net;

internal class CallbackClosure
{
	private AsyncCallback savedCallback;

	private ExecutionContext savedContext;

	internal AsyncCallback AsyncCallback => savedCallback;

	internal ExecutionContext Context => savedContext;

	internal CallbackClosure(ExecutionContext context, AsyncCallback callback)
	{
		if (callback != null)
		{
			savedCallback = callback;
			savedContext = context;
		}
	}

	internal bool IsCompatible(AsyncCallback callback)
	{
		if (callback == null || savedCallback == null)
		{
			return false;
		}
		if (!object.Equals(savedCallback, callback))
		{
			return false;
		}
		return true;
	}
}
