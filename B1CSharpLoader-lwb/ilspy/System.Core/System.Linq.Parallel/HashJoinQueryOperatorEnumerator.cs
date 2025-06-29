using System.Collections.Generic;
using System.Threading;

namespace System.Linq.Parallel;

internal class HashJoinQueryOperatorEnumerator<TLeftInput, TLeftKey, TRightInput, THashKey, TOutput> : QueryOperatorEnumerator<TOutput, TLeftKey>
{
	private class Mutables
	{
		internal TLeftInput m_currentLeft;

		internal TLeftKey m_currentLeftKey;

		internal HashLookup<THashKey, Pair<TRightInput, ListChunk<TRightInput>>> m_rightHashLookup;

		internal ListChunk<TRightInput> m_currentRightMatches;

		internal int m_currentRightMatchesIndex;

		internal int m_outputLoopCount;
	}

	private readonly QueryOperatorEnumerator<Pair<TLeftInput, THashKey>, TLeftKey> m_leftSource;

	private readonly QueryOperatorEnumerator<Pair<TRightInput, THashKey>, int> m_rightSource;

	private readonly Func<TLeftInput, TRightInput, TOutput> m_singleResultSelector;

	private readonly Func<TLeftInput, IEnumerable<TRightInput>, TOutput> m_groupResultSelector;

	private readonly IEqualityComparer<THashKey> m_keyComparer;

	private readonly CancellationToken m_cancellationToken;

	private Mutables m_mutables;

	internal HashJoinQueryOperatorEnumerator(QueryOperatorEnumerator<Pair<TLeftInput, THashKey>, TLeftKey> leftSource, QueryOperatorEnumerator<Pair<TRightInput, THashKey>, int> rightSource, Func<TLeftInput, TRightInput, TOutput> singleResultSelector, Func<TLeftInput, IEnumerable<TRightInput>, TOutput> groupResultSelector, IEqualityComparer<THashKey> keyComparer, CancellationToken cancellationToken)
	{
		m_leftSource = leftSource;
		m_rightSource = rightSource;
		m_singleResultSelector = singleResultSelector;
		m_groupResultSelector = groupResultSelector;
		m_keyComparer = keyComparer;
		m_cancellationToken = cancellationToken;
	}

	internal override bool MoveNext(ref TOutput currentElement, ref TLeftKey currentKey)
	{
		Mutables mutables = m_mutables;
		if (mutables == null)
		{
			mutables = (m_mutables = new Mutables());
			mutables.m_rightHashLookup = new HashLookup<THashKey, Pair<TRightInput, ListChunk<TRightInput>>>(m_keyComparer);
			Pair<TRightInput, THashKey> currentElement2 = default(Pair<TRightInput, THashKey>);
			int currentKey2 = 0;
			int num = 0;
			while (m_rightSource.MoveNext(ref currentElement2, ref currentKey2))
			{
				if ((num++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				TRightInput first = currentElement2.First;
				THashKey second = currentElement2.Second;
				if (second == null)
				{
					continue;
				}
				Pair<TRightInput, ListChunk<TRightInput>> value = default(Pair<TRightInput, ListChunk<TRightInput>>);
				if (!mutables.m_rightHashLookup.TryGetValue(second, ref value))
				{
					value = new Pair<TRightInput, ListChunk<TRightInput>>(first, null);
					if (m_groupResultSelector != null)
					{
						value.Second = new ListChunk<TRightInput>(2);
						value.Second.Add(first);
					}
					mutables.m_rightHashLookup.Add(second, value);
				}
				else
				{
					if (value.Second == null)
					{
						value.Second = new ListChunk<TRightInput>(2);
						mutables.m_rightHashLookup[second] = value;
					}
					value.Second.Add(first);
				}
			}
		}
		ListChunk<TRightInput> currentRightMatches = mutables.m_currentRightMatches;
		if (currentRightMatches != null && mutables.m_currentRightMatchesIndex == currentRightMatches.Count)
		{
			currentRightMatches = (mutables.m_currentRightMatches = currentRightMatches.Next);
			mutables.m_currentRightMatchesIndex = 0;
		}
		if (mutables.m_currentRightMatches == null)
		{
			Pair<TLeftInput, THashKey> currentElement3 = default(Pair<TLeftInput, THashKey>);
			TLeftKey currentKey3 = default(TLeftKey);
			while (m_leftSource.MoveNext(ref currentElement3, ref currentKey3))
			{
				if ((mutables.m_outputLoopCount++ & 0x3F) == 0)
				{
					CancellationState.ThrowIfCanceled(m_cancellationToken);
				}
				Pair<TRightInput, ListChunk<TRightInput>> value2 = default(Pair<TRightInput, ListChunk<TRightInput>>);
				TLeftInput first2 = currentElement3.First;
				THashKey second2 = currentElement3.Second;
				if (second2 != null && mutables.m_rightHashLookup.TryGetValue(second2, ref value2) && m_singleResultSelector != null)
				{
					mutables.m_currentRightMatches = value2.Second;
					mutables.m_currentRightMatchesIndex = 0;
					currentElement = m_singleResultSelector(first2, value2.First);
					currentKey = currentKey3;
					if (value2.Second != null)
					{
						mutables.m_currentLeft = first2;
						mutables.m_currentLeftKey = currentKey3;
					}
					return true;
				}
				if (m_groupResultSelector != null)
				{
					IEnumerable<TRightInput> enumerable = value2.Second;
					if (enumerable == null)
					{
						enumerable = ParallelEnumerable.Empty<TRightInput>();
					}
					currentElement = m_groupResultSelector(first2, enumerable);
					currentKey = currentKey3;
					return true;
				}
			}
			return false;
		}
		currentElement = m_singleResultSelector(mutables.m_currentLeft, mutables.m_currentRightMatches.m_chunk[mutables.m_currentRightMatchesIndex]);
		currentKey = mutables.m_currentLeftKey;
		mutables.m_currentRightMatchesIndex++;
		return true;
	}

	protected override void Dispose(bool disposing)
	{
		m_leftSource.Dispose();
		m_rightSource.Dispose();
	}
}
