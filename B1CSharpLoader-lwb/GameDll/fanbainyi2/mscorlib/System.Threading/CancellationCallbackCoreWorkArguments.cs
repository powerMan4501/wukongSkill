namespace System.Threading;

internal struct CancellationCallbackCoreWorkArguments
{
	internal SparselyPopulatedArrayFragment<CancellationCallbackInfo> m_currArrayFragment;

	internal int m_currArrayIndex;

	public CancellationCallbackCoreWorkArguments(SparselyPopulatedArrayFragment<CancellationCallbackInfo> currArrayFragment, int currArrayIndex)
	{
		m_currArrayFragment = currArrayFragment;
		m_currArrayIndex = currArrayIndex;
	}
}
