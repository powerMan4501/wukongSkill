using System.Runtime.InteropServices;
using System.Security;

namespace System.StubHelpers;

[SecurityCritical]
internal sealed class CleanupWorkListElement
{
	public SafeHandle m_handle;

	public bool m_owned;

	public CleanupWorkListElement(SafeHandle handle)
	{
		m_handle = handle;
	}
}
