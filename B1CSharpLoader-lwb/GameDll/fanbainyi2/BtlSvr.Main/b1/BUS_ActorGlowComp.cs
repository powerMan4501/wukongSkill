using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_ActorGlowComp : UActorCompBaseCS
{
	private UBUC_ACharacterComponent ChrComp;

	public override void OnBeginPlay()
	{
		base.BUSEventCollection.Evt_ActorGlowRequest += new Del_Void_Bool(OnActorGlowRequest);
		ChrComp = RequireWritableData<UBUC_ACharacterComponent>();
	}

	private void OnActorGlowRequest(bool bEnable)
	{
		USkeletalMeshComponent mesh = ChrComp.OwnerCharacter.Mesh;
		if (mesh != null && mesh.RenderCustomDepth != bEnable)
		{
			UGSE_RenderUtilFuncLib.SetRenderCustomDepth(ChrComp.OwnerCharacter, bEnable);
		}
	}
}
