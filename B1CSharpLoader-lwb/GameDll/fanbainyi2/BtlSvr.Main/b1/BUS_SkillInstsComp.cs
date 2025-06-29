using b1.EventDelDefine;
using CommB1;
using UnrealEngine.Engine;

namespace b1;

internal class BUS_SkillInstsComp : UActorCompBaseCS
{
	private BUC_SkillInstsData SkillInstsData;

	private IBGC_UnrealGameplayData UnrealGameplayData;

	private IBUC_AIData AIData;

	public override void OnAttach()
	{
		SkillInstsData = RequireWritableData<BUC_SkillInstsData>();
		UnrealGameplayData = RequireReadOnlyGameStateData<IBGC_UnrealGameplayData, BGC_UnrealGameplayData>();
		AIData = RequireReadOnlyData<IBUC_AIData, BUC_AIData>();
		base.BUSEventCollection.Evt_ResetAllTurnSkillIDs += new Del_Void(OnResetAllTurnSkillIDs);
		base.BUSEventCollection.Evt_ResetAllMoveSkillIDs += new Del_Void(OnResetAllMoveSkillIDs);
		base.BUSEventCollection.Evt_GMLoadSnapshotAttr += new Del_GMLoadSnapshotAttr(LoadSnapshotAttr);
	}

	private void LoadSnapshotAttr(EffectAttrList EffectAttrList, CustomAttrList CustomAttrList)
	{
		if (CustomAttrList != null)
		{
			float timeSeconds = UnrealGameplayData.GetTimeSeconds();
			for (int i = 0; i < CustomAttrList.Attrs.Count; i++)
			{
				CustomAttrFloat customAttrFloat = CustomAttrList.Attrs[i];
				SkillInstsData.SetLastSkillCastTime(customAttrFloat.Type, timeSeconds - customAttrFloat.Value);
				base.BUSEventCollection.Evt_SnapShotRecoverSkillCD.Invoke(customAttrFloat.Type);
			}
		}
	}

	public override void PreBeginPlay()
	{
		InitSkillInstsData();
		OnResetAllTurnSkillIDs();
		OnResetAllMoveSkillIDs();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		SkillInstsData.OwnerActor = null;
	}

	private void OnResetAllTurnSkillIDs()
	{
		SkillInstsData.SetTurnSkillID(TurnSkillType.LeftSmall, AIData.DefaultLeftSmallTurnSkillID);
		SkillInstsData.SetTurnSkillID(TurnSkillType.RightSmall, AIData.DefaultRightSmallTurnSkillID);
		SkillInstsData.SetTurnSkillID(TurnSkillType.LeftBig, AIData.DefaultLeftBigTurnSkillID);
		SkillInstsData.SetTurnSkillID(TurnSkillType.RightBig, AIData.DefaultRightBigTurnSkillID);
	}

	private void OnResetAllMoveSkillIDs()
	{
		SkillInstsData.SetMoveSkillID(TurnSkillType.LeftSmall, AIData.DefaultLeftSmallMoveSkillID);
		SkillInstsData.SetMoveSkillID(TurnSkillType.RightSmall, AIData.DefaultRightSmallMoveSkillID);
		SkillInstsData.SetMoveSkillID(TurnSkillType.LeftBig, AIData.DefaultLeftBigMoveSkillID);
		SkillInstsData.SetMoveSkillID(TurnSkillType.RightBig, AIData.DefaultRightBigMoveSkillID);
	}

	private void InitSkillInstsData()
	{
		SkillInstsData.OwnerActor = GetOwner();
	}
}
