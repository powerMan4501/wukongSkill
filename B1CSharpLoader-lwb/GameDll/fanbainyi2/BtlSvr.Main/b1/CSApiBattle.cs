using b1.ECS;

namespace b1;

public class CSApiBattle : GameInstanceSystemBase
{
	private CSMessageQueue MsgQueue = new CSMessageQueue(1048576);

	public override bool bTickEnabled => true;

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		MsgQueue.DispatchAllMessage();
	}

	public override void OnShutdown()
	{
		MsgQueue.Dispose();
	}

	public void RegisterCSEventHandler<T>(Entity Ent, CSMessageQueue.OnMessage Handler) where T : unmanaged
	{
		MsgQueue.RegisterForEntityMessage<T>(Ent, Handler);
	}

	public void UnregisterCSEventHandler<T>(Entity Ent, CSMessageQueue.OnMessage Handler) where T : unmanaged
	{
		MsgQueue.UnregisterForEntityMessage<T>(Ent, Handler);
	}

	internal void EnqueueMessage<T>(ref T Msg) where T : unmanaged
	{
		MsgQueue.EnqueueMessage(ref Msg);
	}

	internal void EnqueueMessageForEntity<T>(Entity Ent, ref T Msg) where T : unmanaged
	{
		MsgQueue.EnqueueMessageForEntity(Ent, ref Msg);
	}

	public void GetApi()
	{
	}
}
