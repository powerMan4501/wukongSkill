using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetMatsLayerParam(int LayerMappingIdx, FName LayerMappingName, FName ParamName, in MaterialParamInfo NewMPI, bool ForceUpdateDefaultValue);
