using UnrealEngine.Runtime;

namespace b1;

public class FSMState_GI_Loading_PlayerTeleportToTemplatetargetPos : FSMState_GI_LoadingBase
{
	public float CheckTime;

	public bool ShowEnsure;

	public override void Init(FSMRuntimeInstance_GI_Loading RuntimeInstance, FCalliopeNode Node, object InputParams)
	{
		base.Init(RuntimeInstance, Node, InputParams);
	}

	public override void OnEnter()
	{
		CheckTime = 10f;
		if (UBGWFunctionLibrary.IsDistanceStreamingValid(Context.GameInst))
		{
			Teleport();
		}
	}

	public void Teleport()
	{
		ABGPPlayerController aBGPPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Context.GameInst) as ABGPPlayerController;
		if (!aBGPPlayerController.IsNullOrDestroyed())
		{
			aBGPPlayerController.IsInTeleport = true;
		}
		UBGWFunctionLibraryCS.GetPlayerControllerByRoleId(Context.GameInst, Context.TeleportTemplate.PlayerRoleId).GetControlledPawn().SetActorTransform(Context.TeleportTemplate.ChoosePlayerTeleportTransform(), bSweep: false, out var _, bTeleport: false);
		base.OwningInstance.TriggerEvent(EGI_Loading.Finish);
	}

	public override int OnTick(float Delta)
	{
		if (UBGWFunctionLibrary.IsDistanceStreamingValid(Context.GameInst))
		{
			Teleport();
		}
		if (!ShowEnsure && CheckTime > 0f)
		{
			CheckTime -= Delta;
			if (CheckTime <= 0f)
			{
				ShowEnsure = true;
				GSEUtil.Ensure(Condition: true, "Teleport Wait Streaming Resume TimeOut!!!");
			}
		}
		return 100;
	}

	public override void OnExit()
	{
	}
}
