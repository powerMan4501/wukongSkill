using GUR.Runtime;

namespace b1.EventDelDefine;

[GSPredictable]
public delegate void Del_UnitStateTrigger(EBUStateTrigger TriggerID, float Time, bool NeedForceUpdate = false);
