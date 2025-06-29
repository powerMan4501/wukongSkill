using GurCalliopeState;

namespace b1;

public interface IBUC_CheckData
{
	bool CheckDetectCondition(FDetectConditionForCheck DetectCondition);

	bool CheckDetectCondition(CalliopeCustom_DetectCondition DetectCondition);

	bool CheckObserveCondition(FlowObserveCondition ObserveCondition);
}
