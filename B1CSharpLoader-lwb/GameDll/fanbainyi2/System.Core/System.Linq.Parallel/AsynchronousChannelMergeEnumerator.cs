namespace System.Linq.Parallel;

internal sealed class AsynchronousChannelMergeEnumerator<T> : MergeEnumerator<T>
{
	private AsynchronousChannel<T>[] m_channels;

	private IntValueEvent m_consumerEvent;

	private bool[] m_done;

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

	internal AsynchronousChannelMergeEnumerator(QueryTaskGroupState taskGroupState, AsynchronousChannel<T>[] channels, IntValueEvent consumerEvent)
		: base(taskGroupState)
	{
		m_channels = channels;
		m_channelIndex = -1;
		m_done = new bool[m_channels.Length];
		m_consumerEvent = consumerEvent;
	}

	public override bool MoveNext()
	{
		int num = m_channelIndex;
		if (num == -1)
		{
			num = (m_channelIndex = 0);
		}
		if (num == m_channels.Length)
		{
			return false;
		}
		if (!m_done[num] && m_channels[num].TryDequeue(ref m_currentElement))
		{
			m_channelIndex = (num + 1) % m_channels.Length;
			return true;
		}
		return MoveNextSlowPath();
	}

	private bool MoveNextSlowPath()
	{
		int num = 0;
		int num2 = m_channelIndex;
		int channelIndex;
		while ((channelIndex = m_channelIndex) != m_channels.Length)
		{
			AsynchronousChannel<T> asynchronousChannel = m_channels[channelIndex];
			bool flag = m_done[channelIndex];
			if (!flag && asynchronousChannel.TryDequeue(ref m_currentElement))
			{
				m_channelIndex = (channelIndex + 1) % m_channels.Length;
				return true;
			}
			if (!flag && asynchronousChannel.IsDone)
			{
				if (!asynchronousChannel.IsChunkBufferEmpty)
				{
					bool flag2 = asynchronousChannel.TryDequeue(ref m_currentElement);
					return true;
				}
				m_done[channelIndex] = true;
				flag = true;
				asynchronousChannel.Dispose();
			}
			if (flag && ++num == m_channels.Length)
			{
				channelIndex = (m_channelIndex = m_channels.Length);
				break;
			}
			channelIndex = (m_channelIndex = (channelIndex + 1) % m_channels.Length);
			if (channelIndex != num2)
			{
				continue;
			}
			try
			{
				num = 0;
				for (int i = 0; i < m_channels.Length; i++)
				{
					bool isDone = false;
					if (!m_done[i] && m_channels[i].TryDequeue(ref m_currentElement, ref isDone))
					{
						return true;
					}
					if (isDone)
					{
						if (!m_done[i])
						{
							m_done[i] = true;
						}
						if (++num == m_channels.Length)
						{
							channelIndex = (m_channelIndex = m_channels.Length);
							break;
						}
					}
				}
				if (channelIndex == m_channels.Length)
				{
					break;
				}
				m_consumerEvent.Wait();
				channelIndex = (m_channelIndex = m_consumerEvent.Value);
				m_consumerEvent.Reset();
				num2 = channelIndex;
				num = 0;
				continue;
			}
			finally
			{
				for (int j = 0; j < m_channels.Length; j++)
				{
					if (!m_done[j])
					{
						m_channels[j].DoneWithDequeueWait();
					}
				}
			}
		}
		m_taskGroupState.QueryEnd(userInitiatedDispose: false);
		return false;
	}

	public override void Dispose()
	{
		if (m_consumerEvent != null)
		{
			base.Dispose();
			m_consumerEvent.Dispose();
			m_consumerEvent = null;
		}
	}
}
