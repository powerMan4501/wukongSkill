using BtlB1;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBPC_TransData
{
	SpellType DefaultSpellType { get; }

	int GetBirthPoint();

	int GetLastControlUnitResID();

	bool GetIsTrans();

	EPlayerTransBeginType GetCurEnterTransReason();

	bool IsPlotTrans();
}
