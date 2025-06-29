using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_ABPNPCAnimData : IBUC_ABPNPCAnimData
{
	public List<UAnimSequence> AnimIdleList { get; set; }

	public void Init(IBUC_ABPCommonSettingData CommonData)
	{
		AnimIdleList = new List<UAnimSequence>();
	}
}
