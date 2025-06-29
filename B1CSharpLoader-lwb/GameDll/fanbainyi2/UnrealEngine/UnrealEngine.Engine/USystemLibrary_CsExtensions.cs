using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class USystemLibrary_CsExtensions
{
	public static void UnloadPrimaryAsset(this FPrimaryAssetId PrimaryAssetId)
	{
		USystemLibrary.UnloadPrimaryAsset(PrimaryAssetId);
	}

	public static bool SphereTraceSingleForObjects(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceSingleForObjects(WorldContextObject, Start, End, Radius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereTraceSingleByProfile(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceSingleByProfile(WorldContextObject, Start, End, Radius, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereTraceSingle(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceSingle(WorldContextObject, Start, End, Radius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereTraceMultiForObjects(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceMultiForObjects(WorldContextObject, Start, End, Radius, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereTraceMultiByProfile(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceMultiByProfile(WorldContextObject, Start, End, Radius, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereTraceMulti(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.SphereTraceMulti(WorldContextObject, Start, End, Radius, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool SphereOverlapComponents(this UWorld WorldContextObject, FVector SpherePos, float SphereRadius, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ComponentClassFilter, List<AActor> ActorsToIgnore, out List<UPrimitiveComponent> OutComponents)
	{
		return USystemLibrary.SphereOverlapComponents(WorldContextObject, SpherePos, SphereRadius, ObjectTypes, ComponentClassFilter, ActorsToIgnore, out OutComponents);
	}

	public static bool SphereOverlapActors(this UWorld WorldContextObject, FVector SpherePos, float SphereRadius, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ActorClassFilter, List<AActor> ActorsToIgnore, out List<AActor> OutActors)
	{
		return USystemLibrary.SphereOverlapActors(WorldContextObject, SpherePos, SphereRadius, ObjectTypes, ActorClassFilter, ActorsToIgnore, out OutActors);
	}

	public static void SetSuppressViewportTransitionMessage(this UWorld WorldContextObject, bool bState)
	{
		USystemLibrary.SetSuppressViewportTransitionMessage(WorldContextObject, bState);
	}

	public static void RetriggerableDelay(this UWorld WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
	{
		USystemLibrary.RetriggerableDelay(WorldContextObject, Duration, LatentInfo);
	}

	public static void QuitGame(this UWorld WorldContextObject, APlayerController SpecificPlayer, EQuitPreference QuitPreference, bool bIgnorePlatformRestrictions)
	{
		USystemLibrary.QuitGame(WorldContextObject, SpecificPlayer, QuitPreference, bIgnorePlatformRestrictions);
	}

	public static void PrintText(this UWorld WorldContextObject, FText InText, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration, FName Key)
	{
		USystemLibrary.PrintText(WorldContextObject, InText, bPrintToScreen, bPrintToLog, TextColor, Duration, Key);
	}

	public static void PrintString(this UWorld WorldContextObject, string InString, bool bPrintToScreen, bool bPrintToLog, FLinearColor TextColor, float Duration, FName Key)
	{
		USystemLibrary.PrintString(WorldContextObject, InString, bPrintToScreen, bPrintToLog, TextColor, Duration, Key);
	}

	public static bool LineTraceSingleForObjects(this UWorld WorldContextObject, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceSingleForObjects(WorldContextObject, Start, End, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceSingleByProfile(this UWorld WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceSingleByProfile(WorldContextObject, Start, End, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceSingle(this UWorld WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceSingle(WorldContextObject, Start, End, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceOnlyCheck(this UWorld WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceOnlyCheck(WorldContextObject, Start, End, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceMultiForObjects(this UWorld WorldContextObject, FVector Start, FVector End, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceMultiForObjects(WorldContextObject, Start, End, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceMultiByProfile(this UWorld WorldContextObject, FVector Start, FVector End, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceMultiByProfile(WorldContextObject, Start, End, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool LineTraceMulti(this UWorld WorldContextObject, FVector Start, FVector End, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.LineTraceMulti(WorldContextObject, Start, End, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static void UnPauseTimerHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		USystemLibrary.UnPauseTimerHandle(WorldContextObject, Handle);
	}

	public static void UnPauseTimer(this UObject Object, string FunctionName)
	{
		USystemLibrary.UnPauseTimer(Object, FunctionName);
	}

	public static bool TimerExistsHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		return USystemLibrary.TimerExistsHandle(WorldContextObject, Handle);
	}

	public static bool TimerExists(this UObject Object, string FunctionName)
	{
		return USystemLibrary.TimerExists(Object, FunctionName);
	}

	public static FTimerHandle SetTimerForNextTick(this UObject Object, string FunctionName)
	{
		return USystemLibrary.SetTimerForNextTick(Object, FunctionName);
	}

	public static FTimerHandle SetTimer(this UObject Object, string FunctionName, float Time, bool bLooping, float InitialStartDelay = 0f, float InitialStartDelayVariance = 0f)
	{
		return USystemLibrary.SetTimer(Object, FunctionName, Time, bLooping, InitialStartDelay, InitialStartDelayVariance);
	}

	public static void PauseTimerHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		USystemLibrary.PauseTimerHandle(WorldContextObject, Handle);
	}

	public static void PauseTimer(this UObject Object, string FunctionName)
	{
		USystemLibrary.PauseTimer(Object, FunctionName);
	}

	public static bool IsTimerPausedHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		return USystemLibrary.IsTimerPausedHandle(WorldContextObject, Handle);
	}

	public static bool IsTimerPaused(this UObject Object, string FunctionName)
	{
		return USystemLibrary.IsTimerPaused(Object, FunctionName);
	}

	public static bool IsTimerActiveHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		return USystemLibrary.IsTimerActiveHandle(WorldContextObject, Handle);
	}

	public static bool IsTimerActive(this UObject Object, string FunctionName)
	{
		return USystemLibrary.IsTimerActive(Object, FunctionName);
	}

	public static float GetTimerRemainingTimeHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		return USystemLibrary.GetTimerRemainingTimeHandle(WorldContextObject, Handle);
	}

	public static float GetTimerRemainingTime(this UObject Object, string FunctionName)
	{
		return USystemLibrary.GetTimerRemainingTime(Object, FunctionName);
	}

	public static float GetTimerElapsedTimeHandle(this UWorld WorldContextObject, FTimerHandle Handle)
	{
		return USystemLibrary.GetTimerElapsedTimeHandle(WorldContextObject, Handle);
	}

	public static float GetTimerElapsedTime(this UObject Object, string FunctionName)
	{
		return USystemLibrary.GetTimerElapsedTime(Object, FunctionName);
	}

	public static void ClearTimer(this UObject Object, string FunctionName)
	{
		USystemLibrary.ClearTimer(Object, FunctionName);
	}

	public static void ClearAndInvalidateTimerHandle(this UWorld WorldContextObject, ref FTimerHandle Handle)
	{
		USystemLibrary.ClearAndInvalidateTimerHandle(WorldContextObject, ref Handle);
	}

	public static bool IsValidPrimaryAssetType(this FPrimaryAssetType PrimaryAssetType)
	{
		return USystemLibrary.IsValidPrimaryAssetType(PrimaryAssetType);
	}

	public static bool IsValidPrimaryAssetId(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.IsValidPrimaryAssetId(PrimaryAssetId);
	}

	public static bool IsStandalone(this UWorld WorldContextObject)
	{
		return USystemLibrary.IsStandalone(WorldContextObject);
	}

	public static bool IsServer(this UWorld WorldContextObject)
	{
		return USystemLibrary.IsServer(WorldContextObject);
	}

	public static bool IsDedicatedServer(this UWorld WorldContextObject)
	{
		return USystemLibrary.IsDedicatedServer(WorldContextObject);
	}

	public static bool HasMultipleLocalPlayers(this UWorld WorldContextObject)
	{
		return USystemLibrary.HasMultipleLocalPlayers(WorldContextObject);
	}

	public static TSoftObject<UObject> GetSoftObjectReferenceFromPrimaryAssetId(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.GetSoftObjectReferenceFromPrimaryAssetId(PrimaryAssetId);
	}

	public static TSoftClass<UObject> GetSoftClassReferenceFromPrimaryAssetId(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.GetSoftClassReferenceFromPrimaryAssetId(PrimaryAssetId);
	}

	public static void GetPrimaryAssetIdList(this FPrimaryAssetType PrimaryAssetType, out List<FPrimaryAssetId> OutPrimaryAssetIdList)
	{
		USystemLibrary.GetPrimaryAssetIdList(PrimaryAssetType, out OutPrimaryAssetIdList);
	}

	public static UObject GetObjectFromPrimaryAssetId(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.GetObjectFromPrimaryAssetId(PrimaryAssetId);
	}

	public static float GetGameTimeInSeconds(this UWorld WorldContextObject)
	{
		return USystemLibrary.GetGameTimeInSeconds(WorldContextObject);
	}

	public static bool GetCurrentBundleState(this FPrimaryAssetId PrimaryAssetId, bool bForceCurrentState, out List<FName> OutBundles)
	{
		return USystemLibrary.GetCurrentBundleState(PrimaryAssetId, bForceCurrentState, out OutBundles);
	}

	public static TSubclassOf<UObject> GetClassFromPrimaryAssetId(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.GetClassFromPrimaryAssetId(PrimaryAssetId);
	}

	public static void FlushPersistentDebugLines(this UWorld WorldContextObject)
	{
		USystemLibrary.FlushPersistentDebugLines(WorldContextObject);
	}

	public static void FlushDebugStrings(this UWorld WorldContextObject)
	{
		USystemLibrary.FlushDebugStrings(WorldContextObject);
	}

	public static void ExecuteConsoleCommand(this UWorld WorldContextObject, string Command, APlayerController SpecificPlayer)
	{
		USystemLibrary.ExecuteConsoleCommand(WorldContextObject, Command, SpecificPlayer);
	}

	public static void DrawDebugString(this UWorld WorldContextObject, FVector TextLocation, string Text, AActor TestBaseActor, FLinearColor TextColor, float Duration)
	{
		USystemLibrary.DrawDebugString(WorldContextObject, TextLocation, Text, TestBaseActor, TextColor, Duration);
	}

	public static void DrawDebugSphere(this UWorld WorldContextObject, FVector Center, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness)
	{
		USystemLibrary.DrawDebugSphere(WorldContextObject, Center, Radius, Segments, LineColor, Duration, Thickness);
	}

	public static void DrawDebugPoint(this UWorld WorldContextObject, FVector Position, float Size, FLinearColor PointColor, float Duration = 0f)
	{
		USystemLibrary.DrawDebugPoint(WorldContextObject, Position, Size, PointColor, Duration);
	}

	public static void DrawDebugPlane(this UWorld WorldContextObject, FPlane PlaneCoordinates, FVector Location, float Size, FLinearColor PlaneColor, float Duration)
	{
		USystemLibrary.DrawDebugPlane(WorldContextObject, PlaneCoordinates, Location, Size, PlaneColor, Duration);
	}

	public static void DrawDebugLine(this UWorld WorldContextObject, FVector LineStart, FVector LineEnd, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
	{
		USystemLibrary.DrawDebugLine(WorldContextObject, LineStart, LineEnd, LineColor, Duration, Thickness);
	}

	public static void DrawDebugFrustum(this UWorld WorldContextObject, FTransform FrustumTransform, FLinearColor FrustumColor, float Duration, float Thickness)
	{
		USystemLibrary.DrawDebugFrustum(WorldContextObject, FrustumTransform, FrustumColor, Duration, Thickness);
	}

	public static void DrawDebugFloatHistoryTransform(this UWorld WorldContextObject, FDebugFloatHistory FloatHistory, FTransform DrawTransform, FVector2D DrawSize, FLinearColor DrawColor, float Duration)
	{
		USystemLibrary.DrawDebugFloatHistoryTransform(WorldContextObject, FloatHistory, DrawTransform, DrawSize, DrawColor, Duration);
	}

	public static void DrawDebugFloatHistoryLocation(this UWorld WorldContextObject, FDebugFloatHistory FloatHistory, FVector DrawLocation, FVector2D DrawSize, FLinearColor DrawColor, float Duration)
	{
		USystemLibrary.DrawDebugFloatHistoryLocation(WorldContextObject, FloatHistory, DrawLocation, DrawSize, DrawColor, Duration);
	}

	public static void DrawDebugCylinder(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, int Segments, FLinearColor LineColor, float Duration, float Thickness)
	{
		USystemLibrary.DrawDebugCylinder(WorldContextObject, Start, End, Radius, Segments, LineColor, Duration, Thickness);
	}

	public static void DrawDebugCoordinateSystem(this UWorld WorldContextObject, FVector AxisLoc, FRotator AxisRot, float Scale = 1f, float Duration = 0f, float Thickness = 0f)
	{
		USystemLibrary.DrawDebugCoordinateSystem(WorldContextObject, AxisLoc, AxisRot, Scale, Duration, Thickness);
	}

	public static void DrawDebugConeInDegrees(this UWorld WorldContextObject, FVector Origin, FVector Direction, float Length, float AngleWidth, float AngleHeight, int NumSides, FLinearColor LineColor, float Duration, float Thickness)
	{
		USystemLibrary.DrawDebugConeInDegrees(WorldContextObject, Origin, Direction, Length, AngleWidth, AngleHeight, NumSides, LineColor, Duration, Thickness);
	}

	public static void DrawDebugCircle(this UWorld WorldContextObject, FVector Center, float Radius, int NumSegments, FLinearColor LineColor, float Duration, float Thickness, FVector YAxis, FVector ZAxis, bool bDrawAxis)
	{
		USystemLibrary.DrawDebugCircle(WorldContextObject, Center, Radius, NumSegments, LineColor, Duration, Thickness, YAxis, ZAxis, bDrawAxis);
	}

	public static void DrawDebugCapsule(this UWorld WorldContextObject, FVector Center, float HalfHeight, float Radius, FRotator Rotation, FLinearColor LineColor, float Duration, float Thickness)
	{
		USystemLibrary.DrawDebugCapsule(WorldContextObject, Center, HalfHeight, Radius, Rotation, LineColor, Duration, Thickness);
	}

	public static void DrawDebugBox(this UWorld WorldContextObject, FVector Center, FVector Extent, FLinearColor LineColor, FRotator Rotation, float Duration = 0f, float Thickness = 0f)
	{
		USystemLibrary.DrawDebugBox(WorldContextObject, Center, Extent, LineColor, Rotation, Duration, Thickness);
	}

	public static void DrawDebugArrow(this UWorld WorldContextObject, FVector LineStart, FVector LineEnd, float ArrowSize, FLinearColor LineColor, float Duration = 0f, float Thickness = 0f)
	{
		USystemLibrary.DrawDebugArrow(WorldContextObject, LineStart, LineEnd, ArrowSize, LineColor, Duration, Thickness);
	}

	public static void DelayUntilNextTick(this UWorld WorldContextObject, FLatentActionInfo LatentInfo)
	{
		USystemLibrary.DelayUntilNextTick(WorldContextObject, LatentInfo);
	}

	public static void Delay(this UWorld WorldContextObject, float Duration, FLatentActionInfo LatentInfo)
	{
		USystemLibrary.Delay(WorldContextObject, Duration, LatentInfo);
	}

	public static string Conv_PrimaryAssetTypeToString(this FPrimaryAssetType PrimaryAssetType)
	{
		return USystemLibrary.Conv_PrimaryAssetTypeToString(PrimaryAssetType);
	}

	public static string Conv_PrimaryAssetIdToString(this FPrimaryAssetId PrimaryAssetId)
	{
		return USystemLibrary.Conv_PrimaryAssetIdToString(PrimaryAssetId);
	}

	public static bool CapsuleTraceSingleForObjects(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceSingleForObjects(WorldContextObject, Start, End, Radius, HalfHeight, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleTraceSingleByProfile(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceSingleByProfile(WorldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleTraceSingle(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceSingle(WorldContextObject, Start, End, Radius, HalfHeight, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleTraceMultiForObjects(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceMultiForObjects(WorldContextObject, Start, End, Radius, HalfHeight, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleTraceMultiByProfile(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceMultiByProfile(WorldContextObject, Start, End, Radius, HalfHeight, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleTraceMulti(this UWorld WorldContextObject, FVector Start, FVector End, float Radius, float HalfHeight, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.CapsuleTraceMulti(WorldContextObject, Start, End, Radius, HalfHeight, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool CapsuleOverlapComponents(this UWorld WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ComponentClassFilter, List<AActor> ActorsToIgnore, out List<UPrimitiveComponent> OutComponents)
	{
		return USystemLibrary.CapsuleOverlapComponents(WorldContextObject, CapsulePos, Radius, HalfHeight, ObjectTypes, ComponentClassFilter, ActorsToIgnore, out OutComponents);
	}

	public static bool CapsuleOverlapActors(this UWorld WorldContextObject, FVector CapsulePos, float Radius, float HalfHeight, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ActorClassFilter, List<AActor> ActorsToIgnore, out List<AActor> OutActors)
	{
		return USystemLibrary.CapsuleOverlapActors(WorldContextObject, CapsulePos, Radius, HalfHeight, ObjectTypes, ActorClassFilter, ActorsToIgnore, out OutActors);
	}

	public static bool BoxTraceSingleForObjects(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceSingleForObjects(WorldContextObject, Start, End, HalfSize, Orientation, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxTraceSingleByProfile(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceSingleByProfile(WorldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxTraceSingle(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out FHitResult OutHit, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceSingle(WorldContextObject, Start, End, HalfSize, Orientation, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHit, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxTraceMultiForObjects(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, List<EObjectTypeQuery> ObjectTypes, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceMultiForObjects(WorldContextObject, Start, End, HalfSize, Orientation, ObjectTypes, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxTraceMultiByProfile(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, FName ProfileName, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceMultiByProfile(WorldContextObject, Start, End, HalfSize, Orientation, ProfileName, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxTraceMulti(this UWorld WorldContextObject, FVector Start, FVector End, FVector HalfSize, FRotator Orientation, ETraceTypeQuery TraceChannel, bool bTraceComplex, List<AActor> ActorsToIgnore, EDrawDebugTrace DrawDebugType, out List<FHitResult> OutHits, bool bIgnoreSelf, FLinearColor TraceColor, FLinearColor TraceHitColor, float DrawTime)
	{
		return USystemLibrary.BoxTraceMulti(WorldContextObject, Start, End, HalfSize, Orientation, TraceChannel, bTraceComplex, ActorsToIgnore, DrawDebugType, out OutHits, bIgnoreSelf, TraceColor, TraceHitColor, DrawTime);
	}

	public static bool BoxOverlapComponents(this UWorld WorldContextObject, FVector BoxPos, FVector Extent, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ComponentClassFilter, List<AActor> ActorsToIgnore, out List<UPrimitiveComponent> OutComponents)
	{
		return USystemLibrary.BoxOverlapComponents(WorldContextObject, BoxPos, Extent, ObjectTypes, ComponentClassFilter, ActorsToIgnore, out OutComponents);
	}

	public static bool BoxOverlapActors(this UWorld WorldContextObject, FVector BoxPos, FVector BoxExtent, List<EObjectTypeQuery> ObjectTypes, TSubclassOf<UObject> ActorClassFilter, List<AActor> ActorsToIgnore, out List<AActor> OutActors)
	{
		return USystemLibrary.BoxOverlapActors(WorldContextObject, BoxPos, BoxExtent, ObjectTypes, ActorClassFilter, ActorsToIgnore, out OutActors);
	}
}
