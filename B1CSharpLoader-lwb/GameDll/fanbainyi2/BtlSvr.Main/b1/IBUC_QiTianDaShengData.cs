using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_QiTianDaShengData
{
	EDaShengStage DaShengStage { get; }

	bool bIsBanTrans2DaSheng { get; }

	float DaShengDurationTimer { get; }

	float DaShengDurationTotalTime { get; }
}
