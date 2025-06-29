using BtlB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUIANone : BUInteractActionTemplate
{
	public BUIANone()
	{
		ParamIntNum = 0;
		ParamStringNum = 0;
	}

	public override bool DoInteractAction(int InteractiveActorID, AActor User, AActor InteractiveActor, FUStInteractionMappingDesc Action)
	{
		return true;
	}
}
