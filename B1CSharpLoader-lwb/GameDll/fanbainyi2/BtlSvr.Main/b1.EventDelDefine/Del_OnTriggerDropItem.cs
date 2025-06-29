using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_OnTriggerDropItem(AActor Actor, List<byte> AwardsBytes, DropReason DropReason, OverrideDropTempleteInfoClass OverrideDropTempleteInfo = null);
