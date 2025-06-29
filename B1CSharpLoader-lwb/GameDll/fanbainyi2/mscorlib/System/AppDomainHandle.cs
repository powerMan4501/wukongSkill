namespace System;

internal struct AppDomainHandle
{
	private IntPtr m_appDomainHandle;

	internal AppDomainHandle(IntPtr domainHandle)
	{
		m_appDomainHandle = domainHandle;
	}
}
