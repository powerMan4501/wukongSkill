using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BPC_ListenerMgrData : IBPC_ListenerMgrData, IPersistentECSData
{
	public AActor ListenerActor;

	public FVector ListenerPos { get; set; }

	public FVector GetListenerPos()
	{
		return ListenerPos;
	}
}
