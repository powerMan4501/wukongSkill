namespace b1;

public class DebugDrawMessage : DebugDataBase
{
	public string Message;

	public DebugDrawMessage(float InDestroyTime, string InMessage)
		: base(EDebugDrawType.Message, InDestroyTime)
	{
		Message = InMessage;
	}
}
