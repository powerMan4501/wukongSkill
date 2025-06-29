using BtlShare;

namespace b1;

internal class BUS_SaveInitDataCompSimple : UActorCompBaseCS
{
	private BUC_ActorInitData ActorInitData { get; set; }

	private IBUC_GuidData GuidData { get; set; }

	private EBGUResetType FinalResetType { get; set; }

	public override void OnAttach()
	{
		ActorInitData = RequireWritableData<BUC_ActorInitData>();
		GuidData = RequireReadOnlyData<IBUC_GuidData, BUC_GuidData>();
	}

	public override void PreBeginPlay()
	{
		ActorInitData.PersistentDataDontResetOnNewGamePlus = ActorInitData.PersistentDataDontResetOnNewGamePlusFromConfig;
		InitFinalResetType();
		if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(GetOwner()))
		{
			string finalGuid = GuidData.GetFinalGuid();
			base.BGWEventCollection.Evt_SaveActorInitData(finalGuid, ActorInitData, FinalResetType);
		}
	}

	private void InitFinalResetType()
	{
		FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(BGU_DataUtil.GetActorResID(GetOwner()));
		FinalResetType = ActorInitData.ActorResetType;
		if (FinalResetType == EBGUResetType.None)
		{
			FinalResetType = unitCommDesc?.ResetType ?? ActorInitData.ActorResetType;
		}
	}
}
