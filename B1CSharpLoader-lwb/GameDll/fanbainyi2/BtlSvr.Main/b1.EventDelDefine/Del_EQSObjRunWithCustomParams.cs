using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate int Del_EQSObjRunWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, EBGURunEQSObjReason Reason, List<FGSEnvNamedValue> EQSParamList, Action<List<FVector>, List<float>, FGSEQSExParam, int> CallBack);
