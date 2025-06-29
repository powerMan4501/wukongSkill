using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PostProcessMatData : IBUC_PostProcessMatData
{
	public Dictionary<int, List<UMaterialInterface>> NotifyMatsMapping { get; } = new Dictionary<int, List<UMaterialInterface>>();

	public Dictionary<int, BGWDataAsset_PostProcessMatSetting> NotifyDaMapping { get; } = new Dictionary<int, BGWDataAsset_PostProcessMatSetting>();
}
