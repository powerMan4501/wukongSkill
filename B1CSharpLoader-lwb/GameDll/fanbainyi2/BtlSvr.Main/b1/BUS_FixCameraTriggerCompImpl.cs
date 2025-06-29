using b1.EventDelDefine;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_FixCameraTriggerCompImpl : BUS_TriggerBaseComp
{
	private b1.BUC_FixCameraTriggerData FixCameraTriggerData;

	private b1.BUC_FixCameraTriggerConfigData FixCameraTriggerConfigData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		base.OnAttach();
		FixCameraTriggerData = RequireWritableData<b1.BUC_FixCameraTriggerData>();
		FixCameraTriggerConfigData = RequireWritableData<b1.BUC_FixCameraTriggerConfigData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BGSEventCollection.Evt_BGS_SwitchHero += new Del_BGS_Void(OnSwitchHero);
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		base.BGSEventCollection.Evt_BGS_SwitchHero -= new Del_BGS_Void(OnSwitchHero);
	}

	public override void OnEnter_TriggeredEvent()
	{
		if (CanReTrigger())
		{
			FixCameraTriggerData.TriggerCount++;
			APlayerController firstLocalPlayerController = UnrealGameplayData.GetFirstLocalPlayerController();
			if (!(FixCameraTriggerConfigData.TargetCamera == null) && !(firstLocalPlayerController == null))
			{
				FixCameraTriggerData.PlayerViewTarget = firstLocalPlayerController.GetViewTarget();
				BGU_CommonUtil.GetCurrentPlayer(GetOwner(), out var Player);
				UCameraComponent componentByClass = Player.GetComponentByClass<UCameraComponent>();
				UCameraComponent componentByClass2 = FixCameraTriggerConfigData.TargetCamera.GetComponentByClass<UCameraComponent>();
				componentByClass2.SetWorldLocationAndRotation(componentByClass.GetWorldLocation() + FixCameraTriggerConfigData.TargetCameraOffset, componentByClass.GetWorldRotation(), bSweep: false, out var _, bTeleport: false);
				componentByClass2.SetProjectionMode(componentByClass.ProjectionMode);
				componentByClass2.SetFieldOfView(componentByClass.FieldOfView);
				componentByClass2.SetAspectRatio(componentByClass.AspectRatio);
				firstLocalPlayerController.SetViewTargetWithBlend(FixCameraTriggerConfigData.TargetCamera);
			}
		}
	}

	public override void OnEnter_UnTriggeredEvent()
	{
		if (CanReTrigger() && FixCameraTriggerData.TriggerCount % 2 == 1)
		{
			FixCameraTriggerData.TriggerCount++;
			APlayerController firstLocalPlayerController = UnrealGameplayData.GetFirstLocalPlayerController();
			if (!(FixCameraTriggerData.PlayerViewTarget == null) && !(firstLocalPlayerController == null))
			{
				firstLocalPlayerController.SetViewTargetWithBlend(FixCameraTriggerData.PlayerViewTarget, FixCameraTriggerConfigData.BlendCameraDuration, FixCameraTriggerConfigData.BlendFunction, FixCameraTriggerConfigData.BlendExp);
			}
		}
	}

	public override bool CanReTrigger()
	{
		if (FixCameraTriggerConfigData.CanRetriggerCount != -1)
		{
			return FixCameraTriggerData.TriggerCount < FixCameraTriggerConfigData.CanRetriggerCount;
		}
		return true;
	}

	private void OnSwitchHero()
	{
		if (GameplayTagExtension.IsTag(base.CurrentState.StateTag, BGW_FlowUtils.TriggerTag.State_Triggered))
		{
			APlayerController firstLocalPlayerController = UnrealGameplayData.GetFirstLocalPlayerController();
			if (!(FixCameraTriggerConfigData.TargetCamera == null) && !(firstLocalPlayerController == null))
			{
				FixCameraTriggerData.PlayerViewTarget = firstLocalPlayerController.GetViewTarget();
				firstLocalPlayerController.SetViewTargetWithBlend(FixCameraTriggerConfigData.TargetCamera);
			}
		}
	}
}
