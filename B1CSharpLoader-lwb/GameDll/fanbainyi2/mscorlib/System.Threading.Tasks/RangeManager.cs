namespace System.Threading.Tasks;

internal class RangeManager
{
	internal readonly IndexRange[] m_indexRanges;

	internal readonly bool _use32BitCurrentIndex;

	internal int m_nCurrentIndexRangeToAssign;

	internal long m_nStep;

	internal RangeManager(long nFromInclusive, long nToExclusive, long nStep, int nNumExpectedWorkers)
	{
		m_nCurrentIndexRangeToAssign = 0;
		m_nStep = nStep;
		if (nNumExpectedWorkers == 1)
		{
			nNumExpectedWorkers = 2;
		}
		ulong num = (ulong)(nToExclusive - nFromInclusive);
		ulong num2 = num / (ulong)nNumExpectedWorkers;
		num2 -= num2 % (ulong)nStep;
		if (num2 == 0L)
		{
			num2 = (ulong)nStep;
		}
		int num3 = (int)(num / num2);
		if (num % num2 != 0L)
		{
			num3++;
		}
		long num4 = (long)num2;
		_use32BitCurrentIndex = IntPtr.Size == 4 && num4 <= int.MaxValue;
		m_indexRanges = new IndexRange[num3];
		long num5 = nFromInclusive;
		for (int i = 0; i < num3; i++)
		{
			m_indexRanges[i].m_nFromInclusive = num5;
			m_indexRanges[i].m_nSharedCurrentIndexOffset = null;
			m_indexRanges[i].m_bRangeFinished = 0;
			num5 += num4;
			if (num5 < num5 - num4 || num5 > nToExclusive)
			{
				num5 = nToExclusive;
			}
			m_indexRanges[i].m_nToExclusive = num5;
		}
	}

	internal RangeWorker RegisterNewWorker()
	{
		int nInitialRange = (Interlocked.Increment(ref m_nCurrentIndexRangeToAssign) - 1) % m_indexRanges.Length;
		return new RangeWorker(m_indexRanges, nInitialRange, m_nStep, _use32BitCurrentIndex);
	}
}
