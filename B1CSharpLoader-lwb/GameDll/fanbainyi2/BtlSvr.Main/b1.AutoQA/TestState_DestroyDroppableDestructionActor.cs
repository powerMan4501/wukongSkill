using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.AutoQA;

public class TestState_DestroyDroppableDestructionActor : AutoTestNodeLib.TestState_Node
{
	private readonly string ActorName;

	private readonly string ActorLevel;

	public TestState_DestroyDroppableDestructionActor(UObject WorldContext, string ActorName, string ActorLevel)
	{
		base.WorldContext = WorldContext;
		this.ActorName = ActorName;
		this.ActorLevel = ActorLevel;
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		AActor[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<AActor>(WorldContext);
		foreach (AActor aActor in allActorsOfClass)
		{
			if (aActor.GetName() == ActorName && (ActorLevel == null || aActor.GetLevel().GetOutermost().GetName()
				.Contains(ActorLevel)))
			{
				BGUCharacterCS attacker = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn() as BGUCharacterCS;
				BUS_EventCollectionCS.Get(aActor)?.Evt_HitDestructible.Invoke(attacker, EGSHitDestructibleStrengthLevel.Heavy, EGSHitDestructibleDirection.AttackerRelativeDirection, default(FEffectInstReq), 1000f);
				Description = "打破了可破碎物" + ActorName;
				return AutoTestNodeLib.NodeState.Succeeded;
			}
		}
		Description = "找不到可破碎物" + ActorName;
		return AutoTestNodeLib.NodeState.Failed;
	}
}
