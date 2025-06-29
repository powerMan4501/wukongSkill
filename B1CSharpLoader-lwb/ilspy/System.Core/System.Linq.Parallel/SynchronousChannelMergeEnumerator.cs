namespace System.Linq.Parallel;

internal sealed class SynchronousChannelMergeEnumerator<T> : MergeEnumerator<T>
{
	private SynchronousChannel<T>[] m_channels;

	private int m_channelIndex;

	private T m_currentElement;

	public override T Current
	{
		get
		{
			if (m_channelIndex == -1 || m_channelIndex == m_channels.Length)
			{
				throw new InvalidOperationException(SR.GetString("PLINQ_CommonEnumerator_Current_NotStarted"));
			}
			return m_currentElement;
		}
	}

	internal SynchronousChannelMergeEnumerator(QueryTaskGroupState taskGroupState, SynchronousChannel<T>[] channels)
		: base(taskGroupState)
	{
		m_channels = channels;
		m_channelIndex = -1;
	}

	public override bool MoveNext()
	{
		if (m_channelIndex == -1)
		{
			m_channelIndex = 0;
		}
		while (m_channelIndex != m_channels.Length)
		{
			SynchronousChannel<T> synchronousChannel = m_channels[m_channelIndex];
			if (synchronousChannel.Count == 0)
			{
				m_channelIndex++;
				continue;
			}
			m_currentElement = synchronousChannel.Dequeue();
			return true;
		}
		return false;
	}
}
