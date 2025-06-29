using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_NotifyBeginSyncAnimationOnGuest(List<int> PreAnimationSyncStateGuestBuffList, float TotalDuration, AActor Host, float NotifyBeginTime);
