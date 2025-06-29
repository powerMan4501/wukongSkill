using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.HairStrandsCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview", "HairStrandsCore", UnrealModuleType.EnginePlugin)]
public struct FGroomHairGroupPreview
{
	private static bool GroupName_IsValid;

	private static int GroupName_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:GroupName")]
	public FName GroupName;

	private static bool GroupID_IsValid;

	private static int GroupID_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:GroupID")]
	public int GroupID;

	private static bool CurveCount_IsValid;

	private static int CurveCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:CurveCount")]
	public int CurveCount;

	private static bool GuideCount_IsValid;

	private static int GuideCount_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:GuideCount")]
	public int GuideCount;

	private static bool HasPrecomputedWeights_IsValid;

	private static FFieldAddress HasPrecomputedWeights_PropertyAddress;

	private static int HasPrecomputedWeights_Offset;

	[UProperty(Flags = (PropFlags)6755469234405893uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:bHasPrecomputedWeights")]
	public bool HasPrecomputedWeights;

	private static bool InterpolationSettings_IsValid;

	private static int InterpolationSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/HairStrandsCore.GroomHairGroupPreview:InterpolationSettings")]
	public FHairGroupsInterpolation InterpolationSettings;

	private static bool FGroomHairGroupPreview_IsValid;

	private static int FGroomHairGroupPreview_StructSize;

	public FGroomHairGroupPreview Copy()
	{
		return this;
	}

	public static FGroomHairGroupPreview FromNative(IntPtr nativeBuffer)
	{
		return new FGroomHairGroupPreview(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGroomHairGroupPreview value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGroomHairGroupPreview FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGroomHairGroupPreview(nativeBuffer + arrayIndex * FGroomHairGroupPreview_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGroomHairGroupPreview value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGroomHairGroupPreview_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGroomHairGroupPreview_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomHairGroupPreview");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, GroupName_Offset), GroupName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GroupID_Offset), GroupID);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, CurveCount_Offset), CurveCount);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, GuideCount_Offset), GuideCount);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HasPrecomputedWeights_Offset), 0, HasPrecomputedWeights_PropertyAddress.Address, HasPrecomputedWeights);
		FHairGroupsInterpolation.ToNative(IntPtr.Add(nativeStruct, InterpolationSettings_Offset), InterpolationSettings);
	}

	public FGroomHairGroupPreview(IntPtr nativeStruct)
	{
		if (!FGroomHairGroupPreview_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/HairStrandsCore.GroomHairGroupPreview");
			GroupName = default(FName);
			GroupID = 0;
			CurveCount = 0;
			GuideCount = 0;
			HasPrecomputedWeights = false;
			InterpolationSettings = default(FHairGroupsInterpolation);
		}
		else
		{
			GroupName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, GroupName_Offset));
			GroupID = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GroupID_Offset));
			CurveCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, CurveCount_Offset));
			GuideCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, GuideCount_Offset));
			HasPrecomputedWeights = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HasPrecomputedWeights_Offset), 0, HasPrecomputedWeights_PropertyAddress.Address);
			InterpolationSettings = FHairGroupsInterpolation.FromNative(IntPtr.Add(nativeStruct, InterpolationSettings_Offset));
		}
	}

	static FGroomHairGroupPreview()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGroomHairGroupPreview)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGroomHairGroupPreview));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/HairStrandsCore.GroomHairGroupPreview");
		FGroomHairGroupPreview_StructSize = NativeReflection.GetStructSize(intPtr);
		GroupName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupName");
		GroupName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupName", Classes.FNameProperty);
		GroupID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GroupID");
		GroupID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GroupID", Classes.FIntProperty);
		CurveCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CurveCount");
		CurveCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CurveCount", Classes.FIntProperty);
		GuideCount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "GuideCount");
		GuideCount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "GuideCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref HasPrecomputedWeights_PropertyAddress, intPtr, "bHasPrecomputedWeights");
		HasPrecomputedWeights_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHasPrecomputedWeights");
		HasPrecomputedWeights_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHasPrecomputedWeights", Classes.FBoolProperty);
		InterpolationSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpolationSettings");
		InterpolationSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpolationSettings", Classes.FStructProperty);
		FGroomHairGroupPreview_IsValid = intPtr != IntPtr.Zero && GroupName_IsValid && GroupID_IsValid && CurveCount_IsValid && GuideCount_IsValid && HasPrecomputedWeights_IsValid && InterpolationSettings_IsValid;
		NativeReflection.LogStructIsValid("/Script/HairStrandsCore.GroomHairGroupPreview", FGroomHairGroupPreview_IsValid);
	}
}
