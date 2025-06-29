using System.Collections.Generic;

namespace System.Net;

internal abstract class BaseWebProxyFinder : IWebProxyFinder, IDisposable
{
	protected enum AutoWebProxyState
	{
		Uninitialized,
		DiscoveryFailure,
		DownloadFailure,
		CompilationFailure,
		UnrecognizedScheme,
		Completed
	}

	private AutoWebProxyState state;

	private AutoWebProxyScriptEngine engine;

	public bool IsValid
	{
		get
		{
			if (state != AutoWebProxyState.Completed)
			{
				return state == AutoWebProxyState.Uninitialized;
			}
			return true;
		}
	}

	public bool IsUnrecognizedScheme => state == AutoWebProxyState.UnrecognizedScheme;

	protected AutoWebProxyState State
	{
		get
		{
			return state;
		}
		set
		{
			state = value;
		}
	}

	protected AutoWebProxyScriptEngine Engine => engine;

	public BaseWebProxyFinder(AutoWebProxyScriptEngine engine)
	{
		this.engine = engine;
	}

	public abstract bool GetProxies(Uri destination, out IList<string> proxyList);

	public abstract void Abort();

	public virtual void Reset()
	{
		State = AutoWebProxyState.Uninitialized;
	}

	public void Dispose()
	{
		Dispose(disposing: true);
	}

	protected abstract void Dispose(bool disposing);
}
