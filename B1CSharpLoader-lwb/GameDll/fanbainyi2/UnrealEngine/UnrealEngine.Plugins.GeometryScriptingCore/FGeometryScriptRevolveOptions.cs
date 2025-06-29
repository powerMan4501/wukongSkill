using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRevolveOptions
{
	private static bool RevolveDegrees_IsValid;

	private static int RevolveDegrees_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:RevolveDegrees")]
	public float RevolveDegrees;

	private static bool DegreeOffset_IsValid;

	private static int DegreeOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:DegreeOffset")]
	public float DegreeOffset;

	private static bool ReverseDirection_IsValid;

	private static FFieldAddress ReverseDirection_PropertyAddress;

	private static int ReverseDirection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:bReverseDirection")]
	public bool ReverseDirection;

	private static bool HardNormals_IsValid;

	private static FFieldAddress HardNormals_PropertyAddress;

	private static int HardNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:bHardNormals")]
	public bool HardNormals;

	private static bool HardNormalAngle_IsValid;

	private static int HardNormalAngle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:HardNormalAngle")]
	public float HardNormalAngle;

	private static bool ProfileAtMidpoint_IsValid;

	private static FFieldAddress ProfileAtMidpoint_PropertyAddress;

	private static int ProfileAtMidpoint_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:bProfileAtMidpoint")]
	public bool ProfileAtMidpoint;

	private static bool FillPartialRevolveEndcaps_IsValid;

	private static FFieldAddress FillPartialRevolveEndcaps_PropertyAddress;

	private static int FillPartialRevolveEndcaps_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions:bFillPartialRevolveEndcaps")]
	public bool FillPartialRevolveEndcaps;

	private static bool FGeometryScriptRevolveOptions_IsValid;

	private static int FGeometryScriptRevolveOptions_StructSize;

	public FGeometryScriptRevolveOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptRevolveOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRevolveOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRevolveOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRevolveOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRevolveOptions(nativeBuffer + arrayIndex * FGeometryScriptRevolveOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRevolveOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRevolveOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRevolveOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, RevolveDegrees_Offset), RevolveDegrees);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DegreeOffset_Offset), DegreeOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ReverseDirection_Offset), 0, ReverseDirection_PropertyAddress.Address, ReverseDirection);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, HardNormals_Offset), 0, HardNormals_PropertyAddress.Address, HardNormals);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HardNormalAngle_Offset), HardNormalAngle);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ProfileAtMidpoint_Offset), 0, ProfileAtMidpoint_PropertyAddress.Address, ProfileAtMidpoint);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, FillPartialRevolveEndcaps_Offset), 0, FillPartialRevolveEndcaps_PropertyAddress.Address, FillPartialRevolveEndcaps);
	}

	public FGeometryScriptRevolveOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRevolveOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions");
			RevolveDegrees = 0f;
			DegreeOffset = 0f;
			ReverseDirection = false;
			HardNormals = false;
			HardNormalAngle = 0f;
			ProfileAtMidpoint = false;
			FillPartialRevolveEndcaps = false;
		}
		else
		{
			RevolveDegrees = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, RevolveDegrees_Offset));
			DegreeOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DegreeOffset_Offset));
			ReverseDirection = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ReverseDirection_Offset), 0, ReverseDirection_PropertyAddress.Address);
			HardNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, HardNormals_Offset), 0, HardNormals_PropertyAddress.Address);
			HardNormalAngle = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HardNormalAngle_Offset));
			ProfileAtMidpoint = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ProfileAtMidpoint_Offset), 0, ProfileAtMidpoint_PropertyAddress.Address);
			FillPartialRevolveEndcaps = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, FillPartialRevolveEndcaps_Offset), 0, FillPartialRevolveEndcaps_PropertyAddress.Address);
		}
	}

	static FGeometryScriptRevolveOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRevolveOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRevolveOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions");
		FGeometryScriptRevolveOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		RevolveDegrees_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RevolveDegrees");
		RevolveDegrees_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RevolveDegrees", Classes.FFloatProperty);
		DegreeOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DegreeOffset");
		DegreeOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DegreeOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ReverseDirection_PropertyAddress, intPtr, "bReverseDirection");
		ReverseDirection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bReverseDirection");
		ReverseDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bReverseDirection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref HardNormals_PropertyAddress, intPtr, "bHardNormals");
		HardNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bHardNormals");
		HardNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bHardNormals", Classes.FBoolProperty);
		HardNormalAngle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HardNormalAngle");
		HardNormalAngle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HardNormalAngle", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ProfileAtMidpoint_PropertyAddress, intPtr, "bProfileAtMidpoint");
		ProfileAtMidpoint_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bProfileAtMidpoint");
		ProfileAtMidpoint_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bProfileAtMidpoint", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref FillPartialRevolveEndcaps_PropertyAddress, intPtr, "bFillPartialRevolveEndcaps");
		FillPartialRevolveEndcaps_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bFillPartialRevolveEndcaps");
		FillPartialRevolveEndcaps_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bFillPartialRevolveEndcaps", Classes.FBoolProperty);
		FGeometryScriptRevolveOptions_IsValid = intPtr != IntPtr.Zero && RevolveDegrees_IsValid && DegreeOffset_IsValid && ReverseDirection_IsValid && HardNormals_IsValid && HardNormalAngle_IsValid && ProfileAtMidpoint_IsValid && FillPartialRevolveEndcaps_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRevolveOptions", FGeometryScriptRevolveOptions_IsValid);
	}
}
