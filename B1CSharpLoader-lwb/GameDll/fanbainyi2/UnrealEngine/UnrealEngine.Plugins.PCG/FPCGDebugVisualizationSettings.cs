using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.PCG;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings", "PCG", UnrealModuleType.EnginePlugin)]
public struct FPCGDebugVisualizationSettings
{
	private static bool PointScale_IsValid;

	private static int PointScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings:PointScale")]
	public float PointScale;

	private static bool ScaleMethod_IsValid;

	private static FFieldAddress ScaleMethod_PropertyAddress;

	private static int ScaleMethod_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings:ScaleMethod")]
	public EPCGDebugVisScaleMethod ScaleMethod;

	private static bool PointMesh_IsValid;

	private static int PointMesh_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings:PointMesh")]
	public TSoftObject<UStaticMesh> PointMesh;

	private static bool MaterialOverride_IsValid;

	private static int MaterialOverride_Offset;

	[UProperty(Flags = (PropFlags)7881299347898373uL)]
	[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings:MaterialOverride")]
	public TSoftObject<UMaterialInterface> MaterialOverride;

	private static bool CheckForDuplicates_IsValid;

	private static FFieldAddress CheckForDuplicates_PropertyAddress;

	private static int CheckForDuplicates_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/PCG.PCGDebugVisualizationSettings:bCheckForDuplicates")]
	public bool CheckForDuplicates;

	private static bool FPCGDebugVisualizationSettings_IsValid;

	private static int FPCGDebugVisualizationSettings_StructSize;

	public FPCGDebugVisualizationSettings Copy()
	{
		return this;
	}

	public static FPCGDebugVisualizationSettings FromNative(IntPtr nativeBuffer)
	{
		return new FPCGDebugVisualizationSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FPCGDebugVisualizationSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FPCGDebugVisualizationSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FPCGDebugVisualizationSettings(nativeBuffer + arrayIndex * FPCGDebugVisualizationSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FPCGDebugVisualizationSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FPCGDebugVisualizationSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FPCGDebugVisualizationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDebugVisualizationSettings");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PointScale_Offset), PointScale);
		EnumMarshaler<EPCGDebugVisScaleMethod>.ToNative(IntPtr.Add(nativeStruct, ScaleMethod_Offset), 0, ScaleMethod_PropertyAddress.Address, ScaleMethod);
		TSoftObjectMarshaler<UStaticMesh>.ToNative(IntPtr.Add(nativeStruct, PointMesh_Offset), PointMesh);
		TSoftObjectMarshaler<UMaterialInterface>.ToNative(IntPtr.Add(nativeStruct, MaterialOverride_Offset), MaterialOverride);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckForDuplicates_Offset), 0, CheckForDuplicates_PropertyAddress.Address, CheckForDuplicates);
	}

	public FPCGDebugVisualizationSettings(IntPtr nativeStruct)
	{
		if (!FPCGDebugVisualizationSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/PCG.PCGDebugVisualizationSettings");
			PointScale = 0f;
			ScaleMethod = EPCGDebugVisScaleMethod.Relative;
			PointMesh = default(TSoftObject<UStaticMesh>);
			MaterialOverride = default(TSoftObject<UMaterialInterface>);
			CheckForDuplicates = false;
		}
		else
		{
			PointScale = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PointScale_Offset));
			ScaleMethod = EnumMarshaler<EPCGDebugVisScaleMethod>.FromNative(IntPtr.Add(nativeStruct, ScaleMethod_Offset), 0, ScaleMethod_PropertyAddress.Address);
			PointMesh = TSoftObjectMarshaler<UStaticMesh>.FromNative(IntPtr.Add(nativeStruct, PointMesh_Offset));
			MaterialOverride = TSoftObjectMarshaler<UMaterialInterface>.FromNative(IntPtr.Add(nativeStruct, MaterialOverride_Offset));
			CheckForDuplicates = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckForDuplicates_Offset), 0, CheckForDuplicates_PropertyAddress.Address);
		}
	}

	static FPCGDebugVisualizationSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FPCGDebugVisualizationSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FPCGDebugVisualizationSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/PCG.PCGDebugVisualizationSettings");
		FPCGDebugVisualizationSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		PointScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointScale");
		PointScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointScale", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ScaleMethod_PropertyAddress, intPtr, "ScaleMethod");
		ScaleMethod_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScaleMethod");
		ScaleMethod_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScaleMethod", Classes.FEnumProperty);
		PointMesh_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PointMesh");
		PointMesh_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PointMesh", Classes.FSoftObjectProperty);
		MaterialOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaterialOverride");
		MaterialOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaterialOverride", Classes.FSoftObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckForDuplicates_PropertyAddress, intPtr, "bCheckForDuplicates");
		CheckForDuplicates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckForDuplicates");
		CheckForDuplicates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckForDuplicates", Classes.FBoolProperty);
		FPCGDebugVisualizationSettings_IsValid = intPtr != IntPtr.Zero && PointScale_IsValid && ScaleMethod_IsValid && PointMesh_IsValid && MaterialOverride_IsValid && CheckForDuplicates_IsValid;
		NativeReflection.LogStructIsValid("/Script/PCG.PCGDebugVisualizationSettings", FPCGDebugVisualizationSettings_IsValid);
	}
}
