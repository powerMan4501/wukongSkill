using b1.EventDelDefine;
using BtlShare;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_UnitDebugCompImpl : UActorCompBaseCS
{
	private BUC_UnitDebugData UnitDebugData;

	private BUC_AttrContainer AttrContainer;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	public override void OnAttach()
	{
		UnitDebugData = RequireWritableData<BUC_UnitDebugData>();
		AttrContainer = BGU_DataUtil.GetReadOnlyData<BUC_AttrContainer>(Owner);
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		base.BUSEventCollection.Evt_SetSkillPreviewConfig += new Del_SetSkillPreviewConfig(OnSetSkillPreviewConfig);
		base.BUSEventCollection.Evt_OnSetZangBaBaOwner += new Del_Void_Actor(OnSetZangBaBaOwner);
		base.BUSEventCollection.Evt_EnableDrawSkillArea += new Del_Void_Bool(OnEnableDrawSkillArea);
	}

	public override void PreBeginPlay()
	{
		base.PreBeginPlay();
		UnitDebugData.DrawSkillEffectArea = false;
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
		InitVerboseLog();
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (!DebugConfig.DebugWidget)
		{
			return;
		}
		AActor owner = GetOwner();
		if (!(owner == null) && !(owner == UnrealGameplayData?.GetFirstLocalPlayerController().GetControlledPawn()))
		{
			if (UnitDebugData.DebugActor != null)
			{
				owner.GetActorEyesViewPoint(out var _, out var OutRotation);
				UnitDebugData.DebugActor.SightPerceptionDebugSector.SetWorldRotation(OutRotation, bSweep: false, out var _, bTeleport: false);
			}
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("OnlineAttr", $"HP : {AttrContainer.GetFloatValue(EBGUAttrFloat.Hp)}");
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("OnlineAttr", $"ATK: {AttrContainer.GetFloatValue(EBGUAttrFloat.Atk)}", 1);
			base.BUSEventCollection.Evt_UpdateDebugUIInfo.Invoke("OnlineAttr", $"DEF: {AttrContainer.GetFloatValue(EBGUAttrFloat.Def)}", 2);
		}
	}

	private void InitVerboseLog()
	{
		if (UnitDebugData.bLogVerbose)
		{
			base.BUSEventCollection.Evt_DebugEnableVerboseLog.Invoke();
		}
	}

	private void OnEnableDrawSkillArea(bool bIsEnabled)
	{
		UnitDebugData.DrawSkillEffectArea = bIsEnabled;
		UnitDebugData.DrawBuffArea = bIsEnabled;
	}

	private void OnSetZangBaBaOwner(AActor ZBBActor)
	{
		UnitDebugData.ZBBOwner = ZBBActor;
	}

	private void OnSetSkillPreviewConfig(FSkillPreviewConfig SkillPreviewConfig)
	{
		UnitDebugData.DrawSweepCheckSphere = SkillPreviewConfig.bDrawSweepCheckSphere;
		UnitDebugData.DrawSkillEffectArea = SkillPreviewConfig.bDrawSkillEffectArea;
		UnitDebugData.DrawBuffArea = SkillPreviewConfig.bDrawBuffArea;
		UnitDebugData.DrawBulletCollision = SkillPreviewConfig.bDrawBulletCollision;
		UnitDebugData.DrawBulletDestroyPos = SkillPreviewConfig.bDrawBulletDestroyPos;
	}
}
