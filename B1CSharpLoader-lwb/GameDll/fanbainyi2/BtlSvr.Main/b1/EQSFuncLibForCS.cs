using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class EQSFuncLibForCS
{
	[UFunction]
	public static AActor GetActorByEQCType(EEQCType EEQCType, AActor QuerierActor)
	{
		AActor result = null;
		switch (EEQCType)
		{
		case EEQCType.None:
			result = null;
			break;
		case EEQCType.Target:
		{
			UnitLockTargetInfo targetInfo = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(QuerierActor).GetTargetInfo();
			if (targetInfo.LockTargetActor != null)
			{
				result = targetInfo.LockTargetActor;
			}
			break;
		}
		case EEQCType.Player:
			result = UGSE_EngineFuncLib.GetFirstLocalPlayerController(QuerierActor).GetControlledPawn();
			break;
		case EEQCType.Querier:
			result = QuerierActor;
			break;
		}
		return result;
	}
}
