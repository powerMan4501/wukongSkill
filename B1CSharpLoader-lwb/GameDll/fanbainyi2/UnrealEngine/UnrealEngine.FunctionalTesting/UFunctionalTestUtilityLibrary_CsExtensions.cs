using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

public static class UFunctionalTestUtilityLibrary_CsExtensions
{
	public static UTraceQueryTestResults TraceChannelTestUtil(this UWorld WorldContextObject, FTraceChannelTestBatchOptions BatchOptions, FVector Start, FVector End, float SphereCapsuleRadius, float CapsuleHalfHeight, FVector BoxHalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, List<EObjectTypeQuery> ObjectTypes, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, bool bIgnoreSelf, EDrawDebugTrace DrawDebugType, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return UFunctionalTestUtilityLibrary.TraceChannelTestUtil(WorldContextObject, BatchOptions, Start, End, SphereCapsuleRadius, CapsuleHalfHeight, BoxHalfSize, Orientation, TraceChannel, ObjectTypes, ProfileName, bTraceComplex, ActorsToIgnore, bIgnoreSelf, DrawDebugType, TraceColor, TraceHitColor, DrawTime);
	}
}
