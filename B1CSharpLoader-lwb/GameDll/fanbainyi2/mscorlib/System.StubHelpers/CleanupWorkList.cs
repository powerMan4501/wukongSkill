using System.Collections.Generic;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.StubHelpers;

[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
[SecurityCritical]
internal sealed class CleanupWorkList
{
	private List<CleanupWorkListElement> m_list = new List<CleanupWorkListElement>();

	public void Add(CleanupWorkListElement elem)
	{
		m_list.Add(elem);
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	public void Destroy()
	{
		for (int num = m_list.Count - 1; num >= 0; num--)
		{
			if (m_list[num].m_owned)
			{
				StubHelpers.SafeHandleRelease(m_list[num].m_handle);
			}
		}
	}
}
