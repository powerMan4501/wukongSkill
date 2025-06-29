using System.Collections.Generic;
using ResB1;
using UnrealEngine.Runtime;

namespace b1;

public class BGW_MainDisplayTemplate : BGW_GameSettingTemplateBase
{
	public override void ApplyFirstSetting(UObject WorldContext, UISettingConfigType SettingType, int DefaultValue)
	{
		List<FGSMonitorInfo> allMonitorListCache = BGW_SettingMgrV2.GetAllMonitorListCache();
		for (int i = 0; i < allMonitorListCache.Count; i++)
		{
			if (allMonitorListCache[i].IsPrimary)
			{
				string iD = allMonitorListCache[i].ID;
				UB1Util.SetMainMonitorID(iD);
				UGSE_SystemSettingsFuncLib.SetMonitorAsPrimary(iD);
				UGSE_GSGameSettingsFuncLib.ApplyGSGameResolutionSettings(bSaveSettings: true);
				break;
			}
		}
	}
}
