using System.Collections.Generic;
using Microsoft.Win32.SafeHandles;

namespace System.Security.Cryptography;

internal sealed class BCryptAlgorithmHandleCache
{
	[SecurityCritical]
	private Dictionary<string, WeakReference> m_algorithmHandles;

	[SecurityCritical]
	public BCryptAlgorithmHandleCache()
	{
		m_algorithmHandles = new Dictionary<string, WeakReference>();
	}

	[SecuritySafeCritical]
	public SafeBCryptAlgorithmHandle GetCachedAlgorithmHandle(string algorithm, string implementation)
	{
		string key = algorithm + implementation;
		SafeBCryptAlgorithmHandle safeBCryptAlgorithmHandle = null;
		if (m_algorithmHandles.ContainsKey(key) && m_algorithmHandles[key].Target is SafeBCryptAlgorithmHandle result)
		{
			return result;
		}
		safeBCryptAlgorithmHandle = BCryptNative.OpenAlgorithm(algorithm, implementation);
		m_algorithmHandles[key] = new WeakReference(safeBCryptAlgorithmHandle);
		return safeBCryptAlgorithmHandle;
	}
}
