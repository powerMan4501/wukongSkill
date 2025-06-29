using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate void Del_SetCollisionResponseProperty(EPropType PropType, Dictionary<ECollisionChannel, ECollisionResponseType> Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false);
