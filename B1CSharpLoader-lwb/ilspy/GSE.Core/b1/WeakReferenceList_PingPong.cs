namespace b1;

public class WeakReferenceList_PingPong<T> where T : class
{
	private const int Count = 3;

	private WeakReferenceList<T>[] PingPong = new WeakReferenceList<T>[3];

	private int AddListIndex = 2;

	private int ConsumeListIndex = 1;

	private int ClearListIndex;

	public WeakReferenceList_PingPong()
	{
		for (int i = 0; i < 3; i++)
		{
			PingPong[i] = new WeakReferenceList<T>();
		}
	}

	public WeakReferenceList<T> GetAddList()
	{
		return PingPong[AddListIndex];
	}

	public WeakReferenceList<T> GetConsumeList()
	{
		return PingPong[ConsumeListIndex];
	}

	public WeakReferenceList<T> GetClearList()
	{
		return PingPong[ClearListIndex];
	}

	public void Switch_GameThread()
	{
		AddListIndex = (AddListIndex + 1) % 3;
		ConsumeListIndex = (ConsumeListIndex + 1) % 3;
		ClearListIndex = (ClearListIndex + 1) % 3;
	}
}
