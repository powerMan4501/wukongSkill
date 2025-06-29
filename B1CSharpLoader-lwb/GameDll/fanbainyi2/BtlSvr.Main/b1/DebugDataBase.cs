namespace b1;

public abstract class DebugDataBase
{
	public EDebugDrawType DebugDrawType;

	public float DestroyTime;

	protected DebugDataBase(EDebugDrawType InDebugDrawType, float InDestroyTime)
	{
		DebugDrawType = InDebugDrawType;
		DestroyTime = InDestroyTime;
	}
}
