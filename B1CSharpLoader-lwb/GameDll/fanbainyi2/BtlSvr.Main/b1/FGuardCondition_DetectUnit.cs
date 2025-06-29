using GurCalliopeState;
using UnrealEngine.Engine;

namespace b1;

public class FGuardCondition_DetectUnit : FGuardConditionBase
{
	public CalliopeCustom_DetectCondition DetectCondition { get; private set; }

	private EDetectedUnitType UnitType { get; set; }

	private string UnitGuid { get; set; }

	public override EGuardConditionType ConditionType => EGuardConditionType.DetectUnit;

	protected override void Clean()
	{
		DetectCondition = null;
	}

	public override bool Initial(EDetectedUnitType InUnitType, string InUnitGuid, CalliopeCustom_DetectCondition InDetectCondition)
	{
		DetectCondition = InDetectCondition;
		UnitType = InUnitType;
		UnitGuid = InUnitGuid;
		return true;
	}

	protected override void OnTick(float DeltaTime)
	{
		IBUC_CheckData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_CheckData>(GetDetectUnitActor());
		if (readOnlyData != null && readOnlyData.CheckDetectCondition(DetectCondition))
		{
			base.QueryState = EQueryState.QuerySuccess;
		}
	}

	public AActor GetDetectUnitActor()
	{
		if (base.Owner is AActor owner)
		{
			return BGUFunctionLibraryCS.GetDetectUnitActor(owner, UnitType, UnitGuid);
		}
		return null;
	}

	public override bool TryQuickFinishCondition()
	{
		return BUS_EventCollectionCS.Get(GetDetectUnitActor()).Evt_FinishDetectCondition.Invoke(DetectCondition);
	}
}
