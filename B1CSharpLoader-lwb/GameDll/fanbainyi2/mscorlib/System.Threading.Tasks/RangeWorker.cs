using System.Runtime.InteropServices;
using System.Security;

namespace System.Threading.Tasks;

[StructLayout(LayoutKind.Auto)]
internal struct RangeWorker
{
	internal readonly IndexRange[] m_indexRanges;

	internal int m_nCurrentIndexRange;

	internal long m_nStep;

	internal long m_nIncrementValue;

	internal readonly long m_nMaxIncrementValue;

	internal readonly bool _use32BitCurrentIndex;

	internal RangeWorker(IndexRange[] ranges, int nInitialRange, long nStep, bool use32BitCurrentIndex)
	{
		m_indexRanges = ranges;
		m_nCurrentIndexRange = nInitialRange;
		_use32BitCurrentIndex = use32BitCurrentIndex;
		m_nStep = nStep;
		m_nIncrementValue = nStep;
		m_nMaxIncrementValue = 16 * nStep;
	}

	[SecuritySafeCritical]
	internal unsafe bool FindNewWork(out long nFromInclusiveLocal, out long nToExclusiveLocal)
	{
		int num = m_indexRanges.Length;
		do
		{
			IndexRange indexRange = m_indexRanges[m_nCurrentIndexRange];
			if (indexRange.m_bRangeFinished == 0)
			{
				if (m_indexRanges[m_nCurrentIndexRange].m_nSharedCurrentIndexOffset == null)
				{
					Interlocked.CompareExchange(ref m_indexRanges[m_nCurrentIndexRange].m_nSharedCurrentIndexOffset, new Shared<long>(0L), null);
				}
				long num2;
				if (IntPtr.Size == 4 && _use32BitCurrentIndex)
				{
					fixed (long* value = &m_indexRanges[m_nCurrentIndexRange].m_nSharedCurrentIndexOffset.Value)
					{
						num2 = Interlocked.Add(ref *(int*)value, (int)m_nIncrementValue) - m_nIncrementValue;
					}
				}
				else
				{
					num2 = Interlocked.Add(ref m_indexRanges[m_nCurrentIndexRange].m_nSharedCurrentIndexOffset.Value, m_nIncrementValue) - m_nIncrementValue;
				}
				if (indexRange.m_nToExclusive - indexRange.m_nFromInclusive > num2)
				{
					nFromInclusiveLocal = indexRange.m_nFromInclusive + num2;
					nToExclusiveLocal = nFromInclusiveLocal + m_nIncrementValue;
					if (nToExclusiveLocal > indexRange.m_nToExclusive || nToExclusiveLocal < indexRange.m_nFromInclusive)
					{
						nToExclusiveLocal = indexRange.m_nToExclusive;
					}
					if (m_nIncrementValue < m_nMaxIncrementValue)
					{
						m_nIncrementValue *= 2L;
						if (m_nIncrementValue > m_nMaxIncrementValue)
						{
							m_nIncrementValue = m_nMaxIncrementValue;
						}
					}
					return true;
				}
				Interlocked.Exchange(ref m_indexRanges[m_nCurrentIndexRange].m_bRangeFinished, 1);
			}
			m_nCurrentIndexRange = (m_nCurrentIndexRange + 1) % m_indexRanges.Length;
			num--;
		}
		while (num > 0);
		nFromInclusiveLocal = 0L;
		nToExclusiveLocal = 0L;
		return false;
	}

	internal bool FindNewWork32(out int nFromInclusiveLocal32, out int nToExclusiveLocal32)
	{
		long nFromInclusiveLocal33;
		long nToExclusiveLocal33;
		bool result = FindNewWork(out nFromInclusiveLocal33, out nToExclusiveLocal33);
		nFromInclusiveLocal32 = (int)nFromInclusiveLocal33;
		nToExclusiveLocal32 = (int)nToExclusiveLocal33;
		return result;
	}
}
