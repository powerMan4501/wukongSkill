using System.Security;

namespace System.Runtime.Remoting.Contexts;

[Serializable]
internal class CallBackHelper
{
	internal const int RequestedFromEE = 1;

	internal const int XDomainTransition = 256;

	private int _flags;

	private IntPtr _privateData;

	internal bool IsEERequested
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
		}
	}

	internal bool IsCrossDomain
	{
		set
		{
			if (value)
			{
				_flags |= 256;
			}
		}
	}

	internal CallBackHelper(IntPtr privateData, bool bFromEE, int targetDomainID)
	{
		IsEERequested = bFromEE;
		IsCrossDomain = targetDomainID != 0;
		_privateData = privateData;
	}

	[SecurityCritical]
	internal void Func()
	{
		if (IsEERequested)
		{
			Context.ExecuteCallBackInEE(_privateData);
		}
	}
}
