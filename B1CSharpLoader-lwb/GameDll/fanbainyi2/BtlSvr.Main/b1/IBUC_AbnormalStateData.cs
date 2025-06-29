using GUR.Runtime;

namespace b1;

[NeedToUI]
public interface IBUC_AbnormalStateData
{
	float CurrentFrozenBrokenAccHP { get; }

	GSBindDictionary<EAbnormalStateType, FAbnormalStateUIInfo> AbnormalStateUIInfoDic { get; set; }
}
