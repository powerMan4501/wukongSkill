using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_WakeUpPartnersInSameTeam(HashSet<int> TeamIDList, AActor CatchedTarget);
