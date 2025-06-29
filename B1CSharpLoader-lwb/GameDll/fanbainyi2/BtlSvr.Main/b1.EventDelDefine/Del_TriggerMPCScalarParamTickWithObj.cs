using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_TriggerMPCScalarParamTickWithObj(UMaterialParameterCollection MPC, string ParamName, UCurveFloat CurveFloat, float TotalTime, float OriValue, bool CoverLastTrigger = true);
