using System.Collections.Generic;
using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_PartMgrData
{
	int PartRuleID { get; }

	int DefaultPartRuleID { get; }

	int ShowUIPartID { get; }

	bool GetPartInfo(int PartID, out PartInfoData PartInfoOut);

	bool GetAllPartInfo(out Dictionary<int, PartInfoData> PartInfoDataDic);

	bool IsPartBreakInCurrentStage(int PartID);

	bool IsPartCompletelyBreak(int PartID);

	bool IsPartActive(int PartID);

	int GetPartCurrentStage(int PartID);

	bool GetValidLastBreakOrDamagedPartInfo(out int BreakOrDamagedPartID, out bool IsTriggerBreak, out string BreakerGUID);

	bool CanInterruptLastPartBreak(int PartID);
}
