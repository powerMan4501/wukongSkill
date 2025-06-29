using System.Collections.Generic;
using ResB1;

namespace b1;

public class OSSSettingData
{
	public Dictionary<string, string> LocalSettingDict = new Dictionary<string, string>();

	public Dictionary<UISettingConfigType, string> CloudSettingDict = new Dictionary<UISettingConfigType, string>();
}
