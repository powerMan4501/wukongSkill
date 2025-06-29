using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public interface IBUC_UnitHatredData
{
	UnitHatredTargetInfo GetHatredTargetInfo(AActor TargetID);

	GSBindList<UnitHatredTargetInfo> GetHatredTargetInfoList();

	GSBindList<Entity> GetPlayerHatredEntityList();

	bool GetEnableUpdateHatred();

	bool GetCanSetTargetByHatred();

	bool CheckHasHatredTarget(out int TargetNum);
}
