using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBGC_OnlineAssistData
{
	bool IsInAssist();

	ECrusadeState GetCrusadeState(string UnitGuid);
}
