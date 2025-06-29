using System;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSEngineExtent;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GSEngineExtent.GSBranchFilter", "GSEngineExtent", UnrealModuleType.GamePlugin)]
public struct FGSBranchFilter
{
	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.GSBranchFilter:BoneName")]
	public FName BoneName;

	private static bool BlendDepth_IsValid;

	private static int BlendDepth_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/GSEngineExtent.GSBranchFilter:BlendDepth")]
	public int BlendDepth;

	private static bool FGSBranchFilter_IsValid;

	private static int FGSBranchFilter_StructSize;

	public FGSBranchFilter Copy()
	{
		return this;
	}

	public static FGSBranchFilter FromNative(IntPtr nativeBuffer)
	{
		return new FGSBranchFilter(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGSBranchFilter value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGSBranchFilter FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGSBranchFilter(nativeBuffer + arrayIndex * FGSBranchFilter_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGSBranchFilter value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGSBranchFilter_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGSBranchFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.GSBranchFilter");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, BoneName_Offset), BoneName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, BlendDepth_Offset), BlendDepth);
	}

	public FGSBranchFilter(IntPtr nativeStruct)
	{
		if (!FGSBranchFilter_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GSEngineExtent.GSBranchFilter");
			BoneName = default(FName);
			BlendDepth = 0;
		}
		else
		{
			BoneName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, BoneName_Offset));
			BlendDepth = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, BlendDepth_Offset));
		}
	}

	static FGSBranchFilter()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGSBranchFilter)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGSBranchFilter));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GSEngineExtent.GSBranchFilter");
		FGSBranchFilter_StructSize = NativeReflection.GetStructSize(intPtr);
		BoneName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BoneName");
		BoneName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BoneName", Classes.FNameProperty);
		BlendDepth_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BlendDepth");
		BlendDepth_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BlendDepth", Classes.FIntProperty);
		FGSBranchFilter_IsValid = intPtr != IntPtr.Zero && BoneName_IsValid && BlendDepth_IsValid;
		NativeReflection.LogStructIsValid("/Script/GSEngineExtent.GSBranchFilter", FGSBranchFilter_IsValid);
	}
}
