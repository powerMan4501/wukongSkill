using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4101)]
[BlueprintType]
[UMetaPath("/Script/Engine.PredictProjectilePathResult", "Engine", UnrealModuleType.Engine)]
public struct FPredictProjectilePathResult
{
	private static bool PathData_IsValid;

	private static FFieldAddress PathData_PropertyAddress;

	private static int PathData_Offset;

	[UProperty(Flags = (PropFlags)4503599627502101uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathResult:PathData")]
	public List<FPredictProjectilePathPointData> PathData;

	private static bool LastTraceDestination_IsValid;

	private static int LastTraceDestination_Offset;

	[UProperty(Flags = (PropFlags)4503668346978325uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathResult:LastTraceDestination")]
	public FPredictProjectilePathPointData LastTraceDestination;

	private static bool HitResult_IsValid;

	private static int HitResult_Offset;

	[UProperty(Flags = (PropFlags)4504219176534037uL)]
	[UMetaPath("/Script/Engine.PredictProjectilePathResult:HitResult")]
	public FHitResult HitResult;

	private static bool FPredictProjectilePathResult_IsValid;

	private static int FPredictProjectilePathResult_StructSize;

	public FPredictProjectilePathResult Copy()
	{
		FPredictProjectilePathResult result = this;
		if (PathData != null)
		{
			result.PathData = new List<FPredictProjectilePathPointData>(PathData);
		}
		return result;
	}

	public static FPredictProjectilePathResult FromNative(IntPtr nativeBuffer)
	{
		return new FPredictProjectilePathResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPredictProjectilePathResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPredictProjectilePathResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPredictProjectilePathResult(nativeBuffer + arrayIndex * FPredictProjectilePathResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPredictProjectilePathResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPredictProjectilePathResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathResult");
			return;
		}
		new TArrayCopyMarshaler<FPredictProjectilePathPointData>(1, PathData_PropertyAddress, CachedMarshalingDelegates<FPredictProjectilePathPointData, FPredictProjectilePathPointData>.FromNative, CachedMarshalingDelegates<FPredictProjectilePathPointData, FPredictProjectilePathPointData>.ToNative).ToNative(IntPtr.Add(nativeStruct, PathData_Offset), PathData);
		FPredictProjectilePathPointData.ToNative(IntPtr.Add(nativeStruct, LastTraceDestination_Offset), LastTraceDestination);
		FHitResult.ToNative(IntPtr.Add(nativeStruct, HitResult_Offset), HitResult);
	}

	public FPredictProjectilePathResult(IntPtr nativeStruct)
	{
		if (!FPredictProjectilePathResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.PredictProjectilePathResult");
			PathData = null;
			LastTraceDestination = default(FPredictProjectilePathPointData);
			HitResult = default(FHitResult);
		}
		else
		{
			PathData = new TArrayCopyMarshaler<FPredictProjectilePathPointData>(1, PathData_PropertyAddress, CachedMarshalingDelegates<FPredictProjectilePathPointData, FPredictProjectilePathPointData>.FromNative, CachedMarshalingDelegates<FPredictProjectilePathPointData, FPredictProjectilePathPointData>.ToNative).FromNative(IntPtr.Add(nativeStruct, PathData_Offset));
			LastTraceDestination = FPredictProjectilePathPointData.FromNative(IntPtr.Add(nativeStruct, LastTraceDestination_Offset));
			HitResult = FHitResult.FromNative(IntPtr.Add(nativeStruct, HitResult_Offset));
		}
	}

	static FPredictProjectilePathResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPredictProjectilePathResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPredictProjectilePathResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.PredictProjectilePathResult");
		FPredictProjectilePathResult_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref PathData_PropertyAddress, intPtr, "PathData");
		PathData_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathData");
		PathData_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathData", Classes.FArrayProperty);
		LastTraceDestination_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastTraceDestination");
		LastTraceDestination_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastTraceDestination", Classes.FStructProperty);
		HitResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitResult");
		HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitResult", Classes.FStructProperty);
		FPredictProjectilePathResult_IsValid = intPtr != IntPtr.Zero && PathData_IsValid && LastTraceDestination_IsValid && HitResult_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.PredictProjectilePathResult", FPredictProjectilePathResult_IsValid);
	}
}
