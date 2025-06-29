using System.Security;

namespace System.IO.IsolatedStorage;

[SecurityCritical]
public class IsolatedStorageSecurityState : SecurityState
{
	private long m_UsedSize;

	private long m_Quota;

	private IsolatedStorageSecurityOptions m_Options;

	public IsolatedStorageSecurityOptions Options => m_Options;

	public long UsedSize => m_UsedSize;

	public long Quota
	{
		get
		{
			return m_Quota;
		}
		set
		{
			m_Quota = value;
		}
	}

	internal static IsolatedStorageSecurityState CreateStateToIncreaseQuotaForApplication(long newQuota, long usedSize)
	{
		IsolatedStorageSecurityState isolatedStorageSecurityState = new IsolatedStorageSecurityState();
		isolatedStorageSecurityState.m_Options = IsolatedStorageSecurityOptions.IncreaseQuotaForApplication;
		isolatedStorageSecurityState.m_Quota = newQuota;
		isolatedStorageSecurityState.m_UsedSize = usedSize;
		return isolatedStorageSecurityState;
	}

	[SecurityCritical]
	private IsolatedStorageSecurityState()
	{
	}

	[SecurityCritical]
	public override void EnsureState()
	{
		if (!IsStateAvailable())
		{
			throw new IsolatedStorageException(Environment.GetResourceString("IsolatedStorage_Operation"));
		}
	}
}
