using System.Runtime.Remoting.Activation;
using System.Runtime.Remoting.Channels;
using System.Runtime.Remoting.Contexts;
using System.Runtime.Remoting.Lifetime;
using System.Security;
using System.Threading;

namespace System.Runtime.Remoting;

internal class DomainSpecificRemotingData
{
	private const int ACTIVATION_INITIALIZING = 1;

	private const int ACTIVATION_INITIALIZED = 2;

	private const int ACTIVATOR_LISTENING = 4;

	[SecurityCritical]
	private LocalActivator _LocalActivator;

	private ActivationListener _ActivationListener;

	private IContextProperty[] _appDomainProperties;

	private int _flags;

	private object _ConfigLock;

	private ChannelServicesData _ChannelServicesData;

	private LeaseManager _LeaseManager;

	private ReaderWriterLock _IDTableLock;

	internal LeaseManager LeaseManager
	{
		get
		{
			return _LeaseManager;
		}
		set
		{
			_LeaseManager = value;
		}
	}

	internal object ConfigLock => _ConfigLock;

	internal ReaderWriterLock IDTableLock => _IDTableLock;

	internal LocalActivator LocalActivator
	{
		[SecurityCritical]
		get
		{
			return _LocalActivator;
		}
		[SecurityCritical]
		set
		{
			_LocalActivator = value;
		}
	}

	internal ActivationListener ActivationListener
	{
		get
		{
			return _ActivationListener;
		}
		set
		{
			_ActivationListener = value;
		}
	}

	internal bool InitializingActivation
	{
		get
		{
			return (_flags & 1) == 1;
		}
		set
		{
			if (value)
			{
				_flags |= 1;
			}
			else
			{
				_flags &= -2;
			}
		}
	}

	internal bool ActivationInitialized
	{
		get
		{
			return (_flags & 2) == 2;
		}
		set
		{
			if (value)
			{
				_flags |= 2;
			}
			else
			{
				_flags &= -3;
			}
		}
	}

	internal bool ActivatorListening
	{
		get
		{
			return (_flags & 4) == 4;
		}
		set
		{
			if (value)
			{
				_flags |= 4;
			}
			else
			{
				_flags &= -5;
			}
		}
	}

	internal IContextProperty[] AppDomainContextProperties => _appDomainProperties;

	internal ChannelServicesData ChannelServicesData => _ChannelServicesData;

	internal DomainSpecificRemotingData()
	{
		_flags = 0;
		_ConfigLock = new object();
		_ChannelServicesData = new ChannelServicesData();
		_IDTableLock = new ReaderWriterLock();
		_appDomainProperties = new IContextProperty[1];
		_appDomainProperties[0] = new LeaseLifeTimeServiceProperty();
	}
}
