using System.Collections.Generic;
using GUR.Runtime;
using ResB1;

namespace b1;

[NeedToUI]
public interface IBUC_TransGuideData
{
	Dictionary<int, TransInputUITipsDesc> TransGuideDict { get; set; }

	GSBindProp<bool> CanShowUI { get; set; }

	int GetResId();
}
