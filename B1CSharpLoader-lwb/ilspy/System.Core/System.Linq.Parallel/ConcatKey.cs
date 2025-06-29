using System.Collections.Generic;

namespace System.Linq.Parallel;

internal struct ConcatKey<TLeftKey, TRightKey>
{
	private class ConcatKeyComparer : IComparer<ConcatKey<TLeftKey, TRightKey>>
	{
		private IComparer<TLeftKey> m_leftComparer;

		private IComparer<TRightKey> m_rightComparer;

		internal ConcatKeyComparer(IComparer<TLeftKey> leftComparer, IComparer<TRightKey> rightComparer)
		{
			m_leftComparer = leftComparer;
			m_rightComparer = rightComparer;
		}

		public int Compare(ConcatKey<TLeftKey, TRightKey> x, ConcatKey<TLeftKey, TRightKey> y)
		{
			if (x.m_isLeft != y.m_isLeft)
			{
				if (!x.m_isLeft)
				{
					return 1;
				}
				return -1;
			}
			if (x.m_isLeft)
			{
				return m_leftComparer.Compare(x.m_leftKey, y.m_leftKey);
			}
			return m_rightComparer.Compare(x.m_rightKey, y.m_rightKey);
		}
	}

	private readonly TLeftKey m_leftKey;

	private readonly TRightKey m_rightKey;

	private readonly bool m_isLeft;

	private ConcatKey(TLeftKey leftKey, TRightKey rightKey, bool isLeft)
	{
		m_leftKey = leftKey;
		m_rightKey = rightKey;
		m_isLeft = isLeft;
	}

	internal static ConcatKey<TLeftKey, TRightKey> MakeLeft(TLeftKey leftKey)
	{
		return new ConcatKey<TLeftKey, TRightKey>(leftKey, default(TRightKey), isLeft: true);
	}

	internal static ConcatKey<TLeftKey, TRightKey> MakeRight(TRightKey rightKey)
	{
		return new ConcatKey<TLeftKey, TRightKey>(default(TLeftKey), rightKey, isLeft: false);
	}

	internal static IComparer<ConcatKey<TLeftKey, TRightKey>> MakeComparer(IComparer<TLeftKey> leftComparer, IComparer<TRightKey> rightComparer)
	{
		return new ConcatKeyComparer(leftComparer, rightComparer);
	}
}
