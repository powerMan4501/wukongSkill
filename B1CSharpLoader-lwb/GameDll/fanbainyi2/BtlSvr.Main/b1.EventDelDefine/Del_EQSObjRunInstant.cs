using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.EventDelDefine;

public delegate void Del_EQSObjRunInstant(UEnvQuery EnvQueryObj, AActor Querier, out List<FVector> Locations, out List<float> Scores);
