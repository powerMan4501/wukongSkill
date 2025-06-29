using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_GlobalFXData
{
	public Dictionary<FName, FGlobalFXRef> FXTagMap { get; } = new Dictionary<FName, FGlobalFXRef>();

	public HashSet<FGlobalFXRef> NeedUpdateBulletPosArrayParamFXRefs { get; } = new HashSet<FGlobalFXRef>();
}
