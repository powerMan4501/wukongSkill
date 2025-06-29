using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetMatsParam(FName ParamName, in MaterialParamInfo NewMPI, bool ForceUpdateDefaultValue);
