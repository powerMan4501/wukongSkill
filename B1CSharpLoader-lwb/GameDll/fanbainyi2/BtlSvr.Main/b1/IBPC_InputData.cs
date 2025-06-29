namespace b1;

public interface IBPC_InputData
{
	bool DebugDraw { get; }

	float GetInputValue(GSBattleActionEn BattleActionEn);

	InputAxisPeriod GetInputAxisPeriodData(int ActionId);
}
