using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AlembicLibrary;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings", "AlembicLibrary", UnrealModuleType.EnginePlugin)]
public struct FAbcNormalGenerationSettings
{
	private static bool ForceOneSmoothingGroupPerObject_IsValid;

	private static FFieldAddress ForceOneSmoothingGroupPerObject_PropertyAddress;

	private static int ForceOneSmoothingGroupPerObject_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings:bForceOneSmoothingGroupPerObject")]
	public bool ForceOneSmoothingGroupPerObject;

	private static bool HardEdgeAngleThreshold_IsValid;

	private static int HardEdgeAngleThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings:HardEdgeAngleThreshold")]
	public float HardEdgeAngleThreshold;

	private static bool RecomputeNormals_IsValid;

	private static FFieldAddress RecomputeNormals_PropertyAddress;

	private static int RecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings:bRecomputeNormals")]
	public bool RecomputeNormals;

	private static bool IgnoreDegenerateTriangles_IsValid;

	private static FFieldAddress IgnoreDegenerateTriangles_PropertyAddress;

	private static int IgnoreDegenerateTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings:bIgnoreDegenerateTriangles")]
	public bool IgnoreDegenerateTriangles;

	private static bool SkipComputingTangents_IsValid;

	private static FFieldAddress SkipComputingTangents_PropertyAddress;

	private static int SkipComputingTangents_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/AlembicLibrary.AbcNormalGenerationSettings:bSkipComputingTangents")]
	public bool SkipComputingTangents;

	private static bool FAbcNormalGenerationSettings_IsValid;

	private static int FAbcNormalGenerationSettings_StructSize;

	public FAbcNormalGenerationSettings Copy()
	{
		return this;
	}

	public static FAbcNormalGenerationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FAbcNormalGenerationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAbcNormalGenerationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAbcNormalGenerationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAbcNormalGenerationSettings(nativeBuffer + arrayIndex * FAbcNormalGenerationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAbcNormalGenerationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAbcNormalGenerationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAbcNormalGenerationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcNormalGenerationSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ForceOneSmoothingGroupPerObject_Offset), 0, ForceOneSmoothingGroupPerObject_PropertyAddress.Address, ForceOneSmoothingGroupPerObject);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, HardEdgeAngleThreshold_Offset), HardEdgeAngleThreshold);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address, RecomputeNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreDegenerateTriangles_Offset), 0, IgnoreDegenerateTriangles_PropertyAddress.Address, IgnoreDegenerateTriangles);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SkipComputingTangents_Offset), 0, SkipComputingTangents_PropertyAddress.Address, SkipComputingTangents);
	}

	public FAbcNormalGenerationSettings(IntPtr nativeStruct)
	{
		if (!FAbcNormalGenerationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AlembicLibrary.AbcNormalGenerationSettings");
			ForceOneSmoothingGroupPerObject = false;
			HardEdgeAngleThreshold = 0f;
			RecomputeNormals = false;
			IgnoreDegenerateTriangles = false;
			SkipComputingTangents = false;
		}
		else
		{
			ForceOneSmoothingGroupPerObject = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ForceOneSmoothingGroupPerObject_Offset), 0, ForceOneSmoothingGroupPerObject_PropertyAddress.Address);
			HardEdgeAngleThreshold = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, HardEdgeAngleThreshold_Offset));
			RecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RecomputeNormals_Offset), 0, RecomputeNormals_PropertyAddress.Address);
			IgnoreDegenerateTriangles = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreDegenerateTriangles_Offset), 0, IgnoreDegenerateTriangles_PropertyAddress.Address);
			SkipComputingTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SkipComputingTangents_Offset), 0, SkipComputingTangents_PropertyAddress.Address);
		}
	}

	static FAbcNormalGenerationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAbcNormalGenerationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAbcNormalGenerationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AlembicLibrary.AbcNormalGenerationSettings");
		FAbcNormalGenerationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ForceOneSmoothingGroupPerObject_PropertyAddress, intPtr, "bForceOneSmoothingGroupPerObject");
		ForceOneSmoothingGroupPerObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceOneSmoothingGroupPerObject");
		ForceOneSmoothingGroupPerObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceOneSmoothingGroupPerObject", Classes.FBoolProperty);
		HardEdgeAngleThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HardEdgeAngleThreshold");
		HardEdgeAngleThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HardEdgeAngleThreshold", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RecomputeNormals_PropertyAddress, intPtr, "bRecomputeNormals");
		RecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRecomputeNormals");
		RecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRecomputeNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreDegenerateTriangles_PropertyAddress, intPtr, "bIgnoreDegenerateTriangles");
		IgnoreDegenerateTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreDegenerateTriangles");
		IgnoreDegenerateTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreDegenerateTriangles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SkipComputingTangents_PropertyAddress, intPtr, "bSkipComputingTangents");
		SkipComputingTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSkipComputingTangents");
		SkipComputingTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSkipComputingTangents", Classes.FBoolProperty);
		FAbcNormalGenerationSettings_IsValid = intPtr != IntPtr.Zero && ForceOneSmoothingGroupPerObject_IsValid && HardEdgeAngleThreshold_IsValid && RecomputeNormals_IsValid && IgnoreDegenerateTriangles_IsValid && SkipComputingTangents_IsValid;
		NativeReflection.LogStructIsValid("/Script/AlembicLibrary.AbcNormalGenerationSettings", FAbcNormalGenerationSettings_IsValid);
	}
}
