namespace b1;

public class DebugDrawTable : DebugDataBase
{
	public string Message0;

	public string Message1;

	public DebugDrawTable(float InDestroyTime, string InMessage0, string InMessage1)
		: base(EDebugDrawType.Table, InDestroyTime)
	{
		Message0 = InMessage0;
		Message1 = InMessage1;
	}
}
