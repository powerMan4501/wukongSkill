using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetVectorProperty(EPropType PropType, in FVector Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false);
