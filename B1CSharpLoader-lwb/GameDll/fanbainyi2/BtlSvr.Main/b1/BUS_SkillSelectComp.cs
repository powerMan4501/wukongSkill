using System.Collections.Generic;
using b1.BGW;
using b1.EventDelDefine;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_SkillSelectComp : UActorCompBaseCS
{
	private readonly float SkillShapeScaleDelimiter = 50f;

	protected APlayerCameraManager PlayerCameraManager;

	protected USceneComponent RootCon;

	protected USceneComponent AttackRangeCon;

	protected BUC_SkillSelectHelperData SkillSelectHelperData;

	protected IBUC_SkillInputAssistData SkillInputAssistData;

	private b1.PlayerSelectUnitLogic SelectUnitLogic = new b1.PlayerSelectUnitLogic();

	public override void OnAttach()
	{
		SkillSelectHelperData = RequireWritableData<BUC_SkillSelectHelperData>();
		SkillInputAssistData = RequireReadOnlyData<IBUC_SkillInputAssistData, BUC_SkillInputAssistData>();
		base.BUSEventCollection.Evt_SkillDrag += new Del_SkillDrag(OnInputSkillDrag);
		base.BUSEventCollection.Evt_SkillDragByRealDirection += new Del_SkillDragByRealDirection(OnInputSkillDragByRealDirection);
		base.BUSEventCollection.Evt_SkillDragForceCancelled += new Del_Void(OnSkillForceCancelled);
		base.BUSEventCollection.Evt_HideAttackRange += new Del_Void(OnHideAttackRange);
		base.BUSEventCollection.Evt_ShowAttackRange += new Del_Void_Int(OnShowAttackRange);
		base.BUSEventCollection.Evt_ResetSkillSelectHelper += new Del_Void(OnResetSkillSelectHelper);
	}

	public override void PreBeginPlay()
	{
		SelectUnitLogic.InitSelectUnitData(RequireWritableData<b1.BUC_PlayerSelectUnitData>(), GetOwner());
	}

	public override void OnBeginPlay()
	{
		InitSceneComp();
		InitSkillHelperData();
		AttackRangeCon?.SetVisibility(bNewVisibility: false);
	}

	private void InitSceneComp()
	{
		PlayerCameraManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(GetOwner());
		List<UActorComponent> componentsByClass = GetOwner().GetComponentsByClass(UClass.GetClass<USceneComponent>());
		if (componentsByClass == null)
		{
			return;
		}
		foreach (UActorComponent item in componentsByClass)
		{
			if (RootCon == null && item.ComponentHasTag(B1GlobalFNames.RootCon))
			{
				RootCon = item as USceneComponent;
			}
			if (AttackRangeCon == null && item.ComponentHasTag(B1GlobalFNames.AttackRangeCon))
			{
				AttackRangeCon = item as USceneComponent;
			}
		}
	}

	private void InitSkillHelperData()
	{
		SkillSelectHelperData.DesiredSkillForwardDirection = FVector.ZeroVector;
		SkillSelectHelperData.WillCancelSkill = false;
		SkillSelectHelperData.HasAppliedCancelSkillEffect = false;
		SkillSelectHelperData.SkillShapeRelativeVec = FVector.ZeroVector;
		SkillSelectHelperData.CancelOnColor = new FVector4(1.0);
		SkillSelectHelperData.CancelOffColor = new FVector4(0.0, 0.47769999504089355, 1.0);
		SkillSelectHelperData.ShowingSelectUIName = "";
		if (AttackRangeCon == null)
		{
			return;
		}
		(AttackRangeCon.GetChildComponent(0) as UChildActorComponent).GetChildrenComponents(bIncludeAllDescendants: true, out var Children);
		foreach (USceneComponent item in Children)
		{
			UStaticMeshComponent uStaticMeshComponent = item as UStaticMeshComponent;
			if (uStaticMeshComponent != null)
			{
				SkillSelectHelperData.AttackRangeMesh = uStaticMeshComponent;
				break;
			}
		}
	}

	protected virtual void RefreshInputSkillDirection(int SkillID, in FVector InputSkillDir, float InputDisRatio)
	{
		SkillSelectHelperData.DesiredSkillForwardDirection = InputSkillDir;
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, GetOwner());
		if (playerSkillCtrlDesc == null || playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssNone)
		{
			return;
		}
		AActor owner = GetOwner();
		BUSkillSelectShapeTemplate skillSelectShapeTemplate = BGW_EffectTemplateList.Get(owner).GetSkillSelectShapeTemplate(playerSkillCtrlDesc.SmartSelectShapeType);
		if (playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssShootUi)
		{
			if (SkillSelectHelperData.ShowingSelectUIName.Length == 0)
			{
				base.BUSEventCollection.Evt_ActiveTPSReticle?.Invoke(P1: true);
				SkillSelectHelperData.ShowingSelectUIName = playerSkillCtrlDesc.SmartSelectUIName;
			}
			skillSelectShapeTemplate?.GetSkillSelectActorInfo(owner, SkillID, in InputSkillDir, InputDisRatio, out SkillSelectHelperData.DesiredSkillForwardDirection, out SkillSelectHelperData.SkillShapeRelativeVec);
			return;
		}
		if (SkillSelectHelperData.SkillSelectActor.IsNullOrDestroyed())
		{
			FVector Location = RootCon.GetWorldLocation();
			FRotator Rotation = FRotator.ZeroRotator;
			UClass uClass = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<UClass>(playerSkillCtrlDesc.SmartSelectHelpActorPath, ELoadResourceType.AsyncLoadAndCache);
			if (uClass != null)
			{
				SkillSelectHelperData.SkillSelectActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(owner.World, uClass, in Location, in Rotation);
				if (SkillSelectHelperData.SkillSelectActor.IsNullOrDestroyed())
				{
					return;
				}
				skillSelectShapeTemplate?.InitSkillSelectActor(owner, SkillSelectHelperData.SkillSelectActor, SkillID, out SkillSelectHelperData.SkillSelectMesh, out SkillSelectHelperData.SkillAuxiliaryMesh);
				SkillSelectHelperData.DesiredSkillForwardDirection = owner.GetActorForwardVector();
				if (playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssArrowToCircle)
				{
					base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: true);
				}
			}
		}
		if (!SkillSelectHelperData.SkillSelectActor.IsNullOrDestroyed() && skillSelectShapeTemplate != null)
		{
			skillSelectShapeTemplate.GetSkillSelectActorInfo(owner, SkillID, in InputSkillDir, InputDisRatio, out SkillSelectHelperData.DesiredSkillForwardDirection, out SkillSelectHelperData.SkillShapeRelativeVec);
			skillSelectShapeTemplate.RefreshSkillSelectActor(owner, SkillSelectHelperData.SkillSelectActor, SkillSelectHelperData.SkillSelectMesh, SkillSelectHelperData.SkillAuxiliaryMesh, RootCon.GetWorldLocation(), in SkillSelectHelperData.DesiredSkillForwardDirection, in SkillSelectHelperData.SkillShapeRelativeVec);
		}
	}

	private void OnInputSkillDrag(int SkillID, FVector2D TouchDirection, float WheelRatio, bool InWillCancelSkill)
	{
		SkillSelectHelperData.WillCancelSkill = InWillCancelSkill;
		FVector forwardVector = PlayerCameraManager.GetCameraRotation().GetForwardVector();
		forwardVector.Z = 0f;
		TouchDirection.Y = 0f - TouchDirection.Y;
		FVector2D zeroVector = FVector2D.ZeroVector;
		zeroVector.Y = 1f;
		float num = BGU_MoveUtil.GetRotateAngle2D(TouchDirection, zeroVector);
		if (TouchDirection.X < 0f)
		{
			num = ((num > 0f) ? (0f - num) : num);
		}
		FVector InputSkillDir = MathLib.RotateAngleAxis(forwardVector, num, FVector.UpVector);
		InputSkillDir.Normalize();
		RefreshInputSkillDirection(SkillID, in InputSkillDir, WheelRatio);
	}

	private void OnInputSkillDragByRealDirection(int SkillID, FVector RealSkillDirection, float DisRatio)
	{
		SkillSelectHelperData.WillCancelSkill = false;
		RefreshInputSkillDirection(SkillID, in RealSkillDirection, DisRatio);
	}

	protected void TickSkillSelectHelper()
	{
		if (SkillSelectHelperData.SkillSelectActor.IsNullOrDestroyed())
		{
			return;
		}
		if (SkillSelectHelperData.WillCancelSkill && !SkillSelectHelperData.HasAppliedCancelSkillEffect)
		{
			if (SkillSelectHelperData.SkillSelectMesh != null)
			{
				SkillSelectHelperData.SkillSelectMesh.SetVectorParameterValueOnMaterials(B1GlobalFNames.Color, SkillSelectHelperData.CancelOnColor);
			}
			if (SkillSelectHelperData.AttackRangeMesh != null)
			{
				SkillSelectHelperData.AttackRangeMesh.SetVectorParameterValueOnMaterials(B1GlobalFNames.Color, SkillSelectHelperData.CancelOnColor);
			}
			SkillSelectHelperData.HasAppliedCancelSkillEffect = true;
		}
		else if (!SkillSelectHelperData.WillCancelSkill && SkillSelectHelperData.HasAppliedCancelSkillEffect)
		{
			if (SkillSelectHelperData.SkillSelectMesh != null)
			{
				SkillSelectHelperData.SkillSelectMesh.SetVectorParameterValueOnMaterials(B1GlobalFNames.Color, SkillSelectHelperData.CancelOffColor);
			}
			if (SkillSelectHelperData.AttackRangeMesh != null)
			{
				SkillSelectHelperData.AttackRangeMesh.SetVectorParameterValueOnMaterials(B1GlobalFNames.Color, SkillSelectHelperData.CancelOffColor);
			}
			SkillSelectHelperData.HasAppliedCancelSkillEffect = false;
		}
	}

	private void OnSkillForceCancelled()
	{
		ResetSkillSelectHelper();
		AttackRangeCon?.SetVisibility(bNewVisibility: false, bPropagateToChildren: true);
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillInputAssistData.InputSelectingSkillID, GetOwner());
		if (playerSkillCtrlDesc != null && playerSkillCtrlDesc.SmartSelectShapeType == ESmartSelectShapeType.SssArrowToCircle)
		{
			base.BUSEventCollection.Evt_AIPauseBT.Invoke(P1: false);
		}
	}

	public override int GetTickGroupMask()
	{
		return 8;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		SelectUnitLogic.Tick(DeltaTime);
		TickSkillSelectHelper();
	}

	private void ResetSkillSelectHelper()
	{
		SkillSelectHelperData.SkillSelectMesh = null;
		SkillSelectHelperData.SkillAuxiliaryMesh = null;
		SkillSelectHelperData.SkillShapeRelativeVec = FVector.ZeroVector;
		SkillSelectHelperData.DesiredSkillForwardDirection = FVector.ZeroVector;
		SkillSelectHelperData.HasAppliedCancelSkillEffect = false;
		if (SkillSelectHelperData.AttackRangeMesh != null)
		{
			SkillSelectHelperData.AttackRangeMesh.SetVectorParameterValueOnMaterials(B1GlobalFNames.Color, SkillSelectHelperData.CancelOffColor);
		}
		if (SkillSelectHelperData.WillCancelSkill)
		{
			base.BUSEventCollection?.Evt_AIPauseBT.Invoke(P1: false);
			SkillSelectHelperData.WillCancelSkill = false;
		}
		DestorySkillSelectActor();
		if (SkillSelectHelperData.ShowingSelectUIName.Length > 0)
		{
			base.BUSEventCollection.Evt_ActiveTPSReticle?.Invoke(P1: false);
			SkillSelectHelperData.ShowingSelectUIName = "";
		}
	}

	protected virtual void DestorySkillSelectActor()
	{
		if (!SkillSelectHelperData.SkillSelectActor.IsNullOrDestroyed())
		{
			BGU_UnrealWorldUtil.DestroyActor(SkillSelectHelperData.SkillSelectActor);
		}
	}

	private void OnHideAttackRange()
	{
		AttackRangeCon?.SetVisibility(bNewVisibility: false, bPropagateToChildren: true);
	}

	private void OnShowAttackRange(int SkillID)
	{
		FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, GetOwner());
		if (playerSkillCtrlDesc != null)
		{
			AttackRangeCon?.SetVisibility(bNewVisibility: true, bPropagateToChildren: true);
			float num = playerSkillCtrlDesc.AttackRange / SkillShapeScaleDelimiter;
			FVector worldScale3D = new FVector(num, num, 1.0);
			AttackRangeCon?.SetWorldScale3D(worldScale3D);
		}
	}

	private void OnResetSkillSelectHelper()
	{
		ResetSkillSelectHelper();
	}
}
