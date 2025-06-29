using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_BeginForSetCurveValueToHair(int InstID, EGSHairType HairType, TArrayReadWrite<FName> HairCompTagList, TArrayReadWrite<FGSFloatCurveToParam> FloatCurveParamList, float TotalDuration);
