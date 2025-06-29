using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_HandleAbnormal(EAbnormalStateType AbnormalType, AActor Attacker, EAccAbnormalValueType AccType, float IncreaseValue, int AbnormalLevel);
