namespace b1.EventDelDefine;

public delegate void Del_TriggerMPCScalarParamTick(string MPCPath, string ParamName, string CurveFloatPath, float TotalTime, float OriValue, bool CoverLastTrigger = true);
