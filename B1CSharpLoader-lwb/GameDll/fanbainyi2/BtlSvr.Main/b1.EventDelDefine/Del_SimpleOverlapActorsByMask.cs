using System.Collections.Generic;
using UnrealEngine.Engine;

namespace b1.EventDelDefine;

public delegate bool Del_SimpleOverlapActorsByMask(AActor Owner, List<int> Masks, float SphereRadius, float SquareSize, bool IsSphere, out List<AActor> OutActor);
