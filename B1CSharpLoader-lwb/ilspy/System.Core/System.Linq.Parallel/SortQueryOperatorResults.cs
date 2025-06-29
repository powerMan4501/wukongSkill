namespace System.Linq.Parallel;

internal class SortQueryOperatorResults<TInputOutput, TSortKey> : QueryResults<TInputOutput>
{
	private class ChildResultsRecipient : IPartitionedStreamRecipient<TInputOutput>
	{
		private IPartitionedStreamRecipient<TInputOutput> m_outputRecipient;

		private SortQueryOperator<TInputOutput, TSortKey> m_op;

		private QuerySettings m_settings;

		internal ChildResultsRecipient(IPartitionedStreamRecipient<TInputOutput> outputRecipient, SortQueryOperator<TInputOutput, TSortKey> op, QuerySettings settings)
		{
			m_outputRecipient = outputRecipient;
			m_op = op;
			m_settings = settings;
		}

		public void Receive<TKey>(PartitionedStream<TInputOutput, TKey> childPartitionedStream)
		{
			m_op.WrapPartitionedStream(childPartitionedStream, m_outputRecipient, preferStriping: false, m_settings);
		}
	}

	protected QueryResults<TInputOutput> m_childQueryResults;

	private SortQueryOperator<TInputOutput, TSortKey> m_op;

	private QuerySettings m_settings;

	private bool m_preferStriping;

	internal override bool IsIndexible => false;

	internal SortQueryOperatorResults(QueryResults<TInputOutput> childQueryResults, SortQueryOperator<TInputOutput, TSortKey> op, QuerySettings settings, bool preferStriping)
	{
		m_childQueryResults = childQueryResults;
		m_op = op;
		m_settings = settings;
		m_preferStriping = preferStriping;
	}

	internal override void GivePartitionedStream(IPartitionedStreamRecipient<TInputOutput> recipient)
	{
		m_childQueryResults.GivePartitionedStream(new ChildResultsRecipient(recipient, m_op, m_settings));
	}
}
