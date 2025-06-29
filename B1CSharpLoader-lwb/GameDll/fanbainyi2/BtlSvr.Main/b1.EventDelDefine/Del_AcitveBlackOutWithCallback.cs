using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_AcitveBlackOutWithCallback(bool IsActive, Del_Void Callback = null, float DelayTime = -1f, FColor Color = default(FColor), bool IsPauseWorld = true);
