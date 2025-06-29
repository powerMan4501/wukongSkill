using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal interface IBGC_SimpleOverlapMgrData
{
	ESimpleOverlapResult GetSimpleOverlapActorsByMask(AActor Owner, FVector InOriginalLocation, int Mask, float SphereRadius, float RectWidth, float RectLength, FVector2D RectRotation, bool IsSphere, out List<AActor> OutList, bool UseEntRadiusCheck = true);
}
