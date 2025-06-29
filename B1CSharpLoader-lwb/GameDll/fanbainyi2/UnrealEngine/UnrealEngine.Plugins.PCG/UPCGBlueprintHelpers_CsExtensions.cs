using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

public static class UPCGBlueprintHelpers_CsExtensions
{
	public static void SetLocalCenter(this ref FPCGPoint InPoint, FVector InLocalCenter)
	{
		UPCGBlueprintHelpers.SetLocalCenter(ref InPoint, InLocalCenter);
	}

	public static void SetExtents(this ref FPCGPoint InPoint, FVector InExtents)
	{
		UPCGBlueprintHelpers.SetExtents(ref InPoint, InExtents);
	}

	public static FBox GetTransformedBounds(this FPCGPoint InPoint)
	{
		return UPCGBlueprintHelpers.GetTransformedBounds(InPoint);
	}

	public static long GetTaskId(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetTaskId(ref Context);
	}

	public static AActor GetTargetActor(this ref FPCGContext Context, UPCGSpatialData SpatialData)
	{
		return UPCGBlueprintHelpers.GetTargetActor(ref Context, SpatialData);
	}

	public static UPCGSettings GetSettings(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetSettings(ref Context);
	}

	public static FRandomStream GetRandomStream(this FPCGPoint InPoint, UPCGSettings OptionalSettings, UPCGComponent OptionalComponent)
	{
		return UPCGBlueprintHelpers.GetRandomStream(InPoint, OptionalSettings, OptionalComponent);
	}

	public static UPCGComponent GetOriginalComponent(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetOriginalComponent(ref Context);
	}

	public static FVector GetLocalCenter(this FPCGPoint InPoint)
	{
		return UPCGBlueprintHelpers.GetLocalCenter(InPoint);
	}

	public static UPCGData GetInputData(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetInputData(ref Context);
	}

	public static FVector GetExtents(this FPCGPoint InPoint)
	{
		return UPCGBlueprintHelpers.GetExtents(InPoint);
	}

	public static UPCGComponent GetComponent(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetComponent(ref Context);
	}

	public static FBox GetActorLocalBoundsPCG(this AActor InActor, bool bIgnorePCGCreatedComponents = true)
	{
		return UPCGBlueprintHelpers.GetActorLocalBoundsPCG(InActor, bIgnorePCGCreatedComponents);
	}

	public static UPCGData GetActorData(this ref FPCGContext Context)
	{
		return UPCGBlueprintHelpers.GetActorData(ref Context);
	}

	public static FBox GetActorBoundsPCG(this AActor InActor, bool bIgnorePCGCreatedComponents = true)
	{
		return UPCGBlueprintHelpers.GetActorBoundsPCG(InActor, bIgnorePCGCreatedComponents);
	}

	public static UPCGData CreatePCGDataFromActor(this AActor InActor, bool bParseActor = true)
	{
		return UPCGBlueprintHelpers.CreatePCGDataFromActor(InActor, bParseActor);
	}
}
