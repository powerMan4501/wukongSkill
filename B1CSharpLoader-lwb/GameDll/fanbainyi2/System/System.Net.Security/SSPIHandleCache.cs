using System.Threading;

namespace System.Net.Security;

internal static class SSPIHandleCache
{
	private const int c_MaxCacheSize = 31;

	private static SafeCredentialReference[] _CacheSlots = new SafeCredentialReference[32];

	private static int _Current = -1;

	internal static void CacheCredential(SafeFreeCredentials newHandle)
	{
		try
		{
			SafeCredentialReference safeCredentialReference = SafeCredentialReference.CreateReference(newHandle);
			if (safeCredentialReference != null)
			{
				int num = Interlocked.Increment(ref _Current) & 0x1F;
				Interlocked.Exchange(ref _CacheSlots[num], safeCredentialReference)?.Close();
			}
		}
		catch (Exception exception)
		{
			NclUtilities.IsFatal(exception);
		}
	}
}
