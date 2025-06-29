using GUR.Runtime;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_UnitStatePredic(EBGUUnitState UnitState, bool NeedForceUpdate = false, float Time = -1f);
