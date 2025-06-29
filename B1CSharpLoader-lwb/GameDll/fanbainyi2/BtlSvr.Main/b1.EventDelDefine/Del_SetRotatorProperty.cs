using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_SetRotatorProperty(EPropType PropType, in FRotator Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false);
