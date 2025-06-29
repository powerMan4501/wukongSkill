using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.Plugins.DonAINavigation;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/DonAINavigation.DonNavigationPathFindingResult", "DonAINavigation", UnrealModuleType.GamePlugin)]
public struct FDonNavigationPathFindingResult
{
	private static bool PathCost_IsValid;

	private static int PathCost_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationPathFindingResult:PathCost")]
	public float PathCost;

	private static bool PathLength_IsValid;

	private static int PathLength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationPathFindingResult:PathLength")]
	public float PathLength;

	private static bool PathPoints_IsValid;

	private static FFieldAddress PathPoints_PropertyAddress;

	private static int PathPoints_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/DonAINavigation.DonNavigationPathFindingResult:PathPoints")]
	public List<FVector> PathPoints;

	private static bool FDonNavigationPathFindingResult_IsValid;

	private static int FDonNavigationPathFindingResult_StructSize;

	public FDonNavigationPathFindingResult Copy()
	{
		FDonNavigationPathFindingResult result = this;
		if (PathPoints != null)
		{
			result.PathPoints = new List<FVector>(PathPoints);
		}
		return result;
	}

	public static FDonNavigationPathFindingResult FromNative(IntPtr nativeBuffer)
	{
		return new FDonNavigationPathFindingResult(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDonNavigationPathFindingResult value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDonNavigationPathFindingResult FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDonNavigationPathFindingResult(nativeBuffer + arrayIndex * FDonNavigationPathFindingResult_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDonNavigationPathFindingResult value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDonNavigationPathFindingResult_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDonNavigationPathFindingResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DonNavigationPathFindingResult");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PathCost_Offset), PathCost);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PathLength_Offset), PathLength);
		new TArrayCopyMarshaler<FVector>(1, PathPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).ToNative(IntPtr.Add(nativeStruct, PathPoints_Offset), PathPoints);
	}

	public FDonNavigationPathFindingResult(IntPtr nativeStruct)
	{
		if (!FDonNavigationPathFindingResult_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/DonAINavigation.DonNavigationPathFindingResult");
			PathCost = 0f;
			PathLength = 0f;
			PathPoints = null;
		}
		else
		{
			PathCost = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PathCost_Offset));
			PathLength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PathLength_Offset));
			PathPoints = new TArrayCopyMarshaler<FVector>(1, PathPoints_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(nativeStruct, PathPoints_Offset));
		}
	}

	static FDonNavigationPathFindingResult()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDonNavigationPathFindingResult)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDonNavigationPathFindingResult));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/DonAINavigation.DonNavigationPathFindingResult");
		FDonNavigationPathFindingResult_StructSize = NativeReflection.GetStructSize(intPtr);
		PathCost_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathCost");
		PathCost_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathCost", Classes.FFloatProperty);
		PathLength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathLength");
		PathLength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathLength", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref PathPoints_PropertyAddress, intPtr, "PathPoints");
		PathPoints_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PathPoints");
		PathPoints_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PathPoints", Classes.FArrayProperty);
		FDonNavigationPathFindingResult_IsValid = intPtr != IntPtr.Zero && PathCost_IsValid && PathLength_IsValid && PathPoints_IsValid;
		NativeReflection.LogStructIsValid("/Script/DonAINavigation.DonNavigationPathFindingResult", FDonNavigationPathFindingResult_IsValid);
	}
}
