namespace b1;

public class FGSLevelStateRequestBatchInfo
{
	public int FirstID { get; private set; }

	public int LastID { get; private set; }

	public FGSLevelStateRequestBatchInfo(int firstId)
	{
		LastID = (FirstID = firstId);
	}

	public int Add()
	{
		return ++LastID;
	}
}
