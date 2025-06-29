using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_EQSObjRunInstantWithCustomParams(UEnvQuery EnvQueryObj, AActor Querier, List<FGSEnvNamedValue> NamedParams, out List<FVector> Locations, out List<float> Scores);
