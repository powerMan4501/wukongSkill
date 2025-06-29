using System.Collections.Generic;

namespace System.Linq.Parallel;

internal abstract class BinaryQueryOperator<TLeftInput, TRightInput, TOutput> : QueryOperator<TOutput>
{
	internal class BinaryQueryOperatorResults : QueryResults<TOutput>
	{
		private class LeftChildResultsRecipient : IPartitionedStreamRecipient<TLeftInput>
		{
			private IPartitionedStreamRecipient<TOutput> m_outputRecipient;

			private BinaryQueryOperatorResults m_results;

			private bool m_preferStriping;

			private QuerySettings m_settings;

			internal LeftChildResultsRecipient(IPartitionedStreamRecipient<TOutput> outputRecipient, BinaryQueryOperatorResults results, bool preferStriping, QuerySettings settings)
			{
				m_outputRecipient = outputRecipient;
				m_results = results;
				m_preferStriping = preferStriping;
				m_settings = settings;
			}

			public void Receive<TLeftKey>(PartitionedStream<TLeftInput, TLeftKey> source)
			{
				RightChildResultsRecipient<TLeftKey> recipient = new RightChildResultsRecipient<TLeftKey>(m_outputRecipient, m_results.m_op, source, m_preferStriping, m_settings);
				m_results.m_rightChildQueryResults.GivePartitionedStream(recipient);
			}
		}

		private class RightChildResultsRecipient<TLeftKey> : IPartitionedStreamRecipient<TRightInput>
		{
			private IPartitionedStreamRecipient<TOutput> m_outputRecipient;

			private PartitionedStream<TLeftInput, TLeftKey> m_leftPartitionedStream;

			private BinaryQueryOperator<TLeftInput, TRightInput, TOutput> m_op;

			private bool m_preferStriping;

			private QuerySettings m_settings;

			internal RightChildResultsRecipient(IPartitionedStreamRecipient<TOutput> outputRecipient, BinaryQueryOperator<TLeftInput, TRightInput, TOutput> op, PartitionedStream<TLeftInput, TLeftKey> leftPartitionedStream, bool preferStriping, QuerySettings settings)
			{
				m_outputRecipient = outputRecipient;
				m_op = op;
				m_preferStriping = preferStriping;
				m_leftPartitionedStream = leftPartitionedStream;
				m_settings = settings;
			}

			public void Receive<TRightKey>(PartitionedStream<TRightInput, TRightKey> rightPartitionedStream)
			{
				m_op.WrapPartitionedStream(m_leftPartitionedStream, rightPartitionedStream, m_outputRecipient, m_preferStriping, m_settings);
			}
		}

		protected QueryResults<TLeftInput> m_leftChildQueryResults;

		protected QueryResults<TRightInput> m_rightChildQueryResults;

		private BinaryQueryOperator<TLeftInput, TRightInput, TOutput> m_op;

		private QuerySettings m_settings;

		private bool m_preferStriping;

		internal BinaryQueryOperatorResults(QueryResults<TLeftInput> leftChildQueryResults, QueryResults<TRightInput> rightChildQueryResults, BinaryQueryOperator<TLeftInput, TRightInput, TOutput> op, QuerySettings settings, bool preferStriping)
		{
			m_leftChildQueryResults = leftChildQueryResults;
			m_rightChildQueryResults = rightChildQueryResults;
			m_op = op;
			m_settings = settings;
			m_preferStriping = preferStriping;
		}

		internal override void GivePartitionedStream(IPartitionedStreamRecipient<TOutput> recipient)
		{
			if (m_settings.ExecutionMode.Value == ParallelExecutionMode.Default && m_op.LimitsParallelism)
			{
				IEnumerable<TOutput> source = m_op.AsSequentialQuery(m_settings.CancellationState.ExternalCancellationToken);
				PartitionedStream<TOutput, int> partitionedStream = ExchangeUtilities.PartitionDataSource(source, m_settings.DegreeOfParallelism.Value, m_preferStriping);
				recipient.Receive(partitionedStream);
			}
			else if (IsIndexible)
			{
				PartitionedStream<TOutput, int> partitionedStream2 = ExchangeUtilities.PartitionDataSource(this, m_settings.DegreeOfParallelism.Value, m_preferStriping);
				recipient.Receive(partitionedStream2);
			}
			else
			{
				m_leftChildQueryResults.GivePartitionedStream(new LeftChildResultsRecipient(recipient, this, m_preferStriping, m_settings));
			}
		}
	}

	private readonly QueryOperator<TLeftInput> m_leftChild;

	private readonly QueryOperator<TRightInput> m_rightChild;

	private OrdinalIndexState m_indexState = OrdinalIndexState.Shuffled;

	internal QueryOperator<TLeftInput> LeftChild => m_leftChild;

	internal QueryOperator<TRightInput> RightChild => m_rightChild;

	internal sealed override OrdinalIndexState OrdinalIndexState => m_indexState;

	internal BinaryQueryOperator(ParallelQuery<TLeftInput> leftChild, ParallelQuery<TRightInput> rightChild)
		: this(QueryOperator<TLeftInput>.AsQueryOperator(leftChild), QueryOperator<TRightInput>.AsQueryOperator(rightChild))
	{
	}

	internal BinaryQueryOperator(QueryOperator<TLeftInput> leftChild, QueryOperator<TRightInput> rightChild)
		: base(isOrdered: false, leftChild.SpecifiedQuerySettings.Merge(rightChild.SpecifiedQuerySettings))
	{
		m_leftChild = leftChild;
		m_rightChild = rightChild;
	}

	protected void SetOrdinalIndex(OrdinalIndexState indexState)
	{
		m_indexState = indexState;
	}

	public abstract void WrapPartitionedStream<TLeftKey, TRightKey>(PartitionedStream<TLeftInput, TLeftKey> leftPartitionedStream, PartitionedStream<TRightInput, TRightKey> rightPartitionedStream, IPartitionedStreamRecipient<TOutput> outputRecipient, bool preferStriping, QuerySettings settings);
}
