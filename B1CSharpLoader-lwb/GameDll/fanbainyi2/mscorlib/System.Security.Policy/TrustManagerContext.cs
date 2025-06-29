using System.Runtime.InteropServices;

namespace System.Security.Policy;

[ComVisible(true)]
public class TrustManagerContext
{
	private bool m_ignorePersistedDecision;

	private TrustManagerUIContext m_uiContext;

	private bool m_noPrompt;

	private bool m_keepAlive;

	private bool m_persist;

	private ApplicationIdentity m_appId;

	public virtual TrustManagerUIContext UIContext
	{
		get
		{
			return m_uiContext;
		}
		set
		{
			m_uiContext = value;
		}
	}

	public virtual bool NoPrompt
	{
		get
		{
			return m_noPrompt;
		}
		set
		{
			m_noPrompt = value;
		}
	}

	public virtual bool IgnorePersistedDecision
	{
		get
		{
			return m_ignorePersistedDecision;
		}
		set
		{
			m_ignorePersistedDecision = value;
		}
	}

	public virtual bool KeepAlive
	{
		get
		{
			return m_keepAlive;
		}
		set
		{
			m_keepAlive = value;
		}
	}

	public virtual bool Persist
	{
		get
		{
			return m_persist;
		}
		set
		{
			m_persist = value;
		}
	}

	public virtual ApplicationIdentity PreviousApplicationIdentity
	{
		get
		{
			return m_appId;
		}
		set
		{
			m_appId = value;
		}
	}

	public TrustManagerContext()
		: this(TrustManagerUIContext.Run)
	{
	}

	public TrustManagerContext(TrustManagerUIContext uiContext)
	{
		m_ignorePersistedDecision = false;
		m_uiContext = uiContext;
		m_keepAlive = false;
		m_persist = true;
	}
}
