using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public static class UBGUSelectUtil_CsExtensions
{
	public static int SelectBGUCharactersInRect(this UWorld WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		return UBGUSelectUtil.SelectBGUCharactersInRect(WorldContextObject, out OutActors, TargetBase, TargetCount, TargetFilter, Params);
	}

	public static int SelectBGUCharactersInCylinder(this UWorld WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		return UBGUSelectUtil.SelectBGUCharactersInCylinder(WorldContextObject, out OutActors, TargetBase, TargetCount, TargetFilter, Params);
	}

	public static int SelectBGUCharactersInCircle(this UWorld WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetCount, int TargetFilter, List<int> Params)
	{
		return UBGUSelectUtil.SelectBGUCharactersInCircle(WorldContextObject, out OutActors, TargetBase, TargetCount, TargetFilter, Params);
	}

	public static int MultiSphereTraceForObjects(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, float Radius, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out List<FHitResultSimple> HitResultList)
	{
		return UBGUSelectUtil.MultiSphereTraceForObjects(WorldContextObject, StartTrace, EndTrace, Radius, ObjectTypes, bDebug, out HitResultList);
	}

	public static bool LineTraceSingleForObjects(this UWorld WorldContextObject, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return UBGUSelectUtil.LineTraceSingleForObjects(WorldContextObject, Start, End, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static int LineTraceSimple(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, ETraceTypeQuery QueryChnl, bool bDebug, out FHitResultSimple HitResult, List<AActor> Ingnores, bool bTraceComplex = false)
	{
		return UBGUSelectUtil.LineTraceSimple(WorldContextObject, StartTrace, EndTrace, QueryChnl, bDebug, out HitResult, Ingnores, bTraceComplex);
	}

	public static int LineTraceOnlyCheck(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, ETraceTypeQuery QueryChnl, bool bDebug, out FHitResultSimple HitResult, List<AActor> Ingnores, bool bTraceComplex = false)
	{
		return UBGUSelectUtil.LineTraceOnlyCheck(WorldContextObject, StartTrace, EndTrace, QueryChnl, bDebug, out HitResult, Ingnores, bTraceComplex);
	}

	public static int LineTraceMultiByObjType(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out List<FHitResultSimple> HitResultList)
	{
		return UBGUSelectUtil.LineTraceMultiByObjType(WorldContextObject, StartTrace, EndTrace, ObjectTypes, bDebug, out HitResultList);
	}

	public static int LineTraceForObjectsTypeSimple(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out FHitResultSimple HitResult, bool bTraceComplex = false)
	{
		return UBGUSelectUtil.LineTraceForObjectsTypeSimple(WorldContextObject, StartTrace, EndTrace, ObjectTypes, bDebug, out HitResult, bTraceComplex);
	}

	public static int LineTraceForObjects(this UWorld WorldContextObject, FVector StartTrace, FVector EndTrace, List<EObjectTypeQuery> ObjectTypes, bool bDebug, out FHitResultSimple HitResult)
	{
		return UBGUSelectUtil.LineTraceForObjects(WorldContextObject, StartTrace, EndTrace, ObjectTypes, bDebug, out HitResult);
	}

	public static int BoxOverlapV2BGUCharacters(this UWorld WorldContextObject, FVector BoxPos, FQuat Rot, FVector BoxExtent, out List<ABGUCharacter> OutArray)
	{
		return UBGUSelectUtil.BoxOverlapV2BGUCharacters(WorldContextObject, BoxPos, Rot, BoxExtent, out OutArray);
	}

	public static int BoxOverlapBGUCharacters(this UWorld WorldContextObject, FVector BoxPos, FVector BoxExtent, out List<ABGUCharacter> OutArray, ECollisionChannel QueryChannel = ECollisionChannel.ECC_Pawn)
	{
		return UBGUSelectUtil.BoxOverlapBGUCharacters(WorldContextObject, BoxPos, BoxExtent, out OutArray, QueryChannel);
	}
}
