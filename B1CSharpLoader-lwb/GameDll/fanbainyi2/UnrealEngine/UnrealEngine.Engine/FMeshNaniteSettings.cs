using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/Engine.MeshNaniteSettings", "Engine", UnrealModuleType.Engine)]
public struct FMeshNaniteSettings
{
	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:bEnabled")]
	public bool Enabled;

	private static bool PreserveArea_IsValid;

	private static FFieldAddress PreserveArea_PropertyAddress;

	private static int PreserveArea_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:bPreserveArea")]
	public bool PreserveArea;

	private static bool PositionPrecision_IsValid;

	private static int PositionPrecision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:PositionPrecision")]
	public int PositionPrecision;

	private static bool KeepPercentTriangles_IsValid;

	private static int KeepPercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:KeepPercentTriangles")]
	public float KeepPercentTriangles;

	private static bool TrimRelativeError_IsValid;

	private static int TrimRelativeError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:TrimRelativeError")]
	public float TrimRelativeError;

	private static bool FallbackPercentTriangles_IsValid;

	private static int FallbackPercentTriangles_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:FallbackPercentTriangles")]
	public float FallbackPercentTriangles;

	private static bool FallbackRelativeError_IsValid;

	private static int FallbackRelativeError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MeshNaniteSettings:FallbackRelativeError")]
	public float FallbackRelativeError;

	private static bool FMeshNaniteSettings_IsValid;

	private static int FMeshNaniteSettings_StructSize;

	public FMeshNaniteSettings Copy()
	{
		return this;
	}

	public static FMeshNaniteSettings FromNative(IntPtr nativeBuffer)
	{
		return new FMeshNaniteSettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FMeshNaniteSettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FMeshNaniteSettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FMeshNaniteSettings(nativeBuffer + arrayIndex * FMeshNaniteSettings_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FMeshNaniteSettings value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FMeshNaniteSettings_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FMeshNaniteSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshNaniteSettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PreserveArea_Offset), 0, PreserveArea_PropertyAddress.Address, PreserveArea);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PositionPrecision_Offset), PositionPrecision);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, KeepPercentTriangles_Offset), KeepPercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, TrimRelativeError_Offset), TrimRelativeError);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FallbackPercentTriangles_Offset), FallbackPercentTriangles);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FallbackRelativeError_Offset), FallbackRelativeError);
	}

	public FMeshNaniteSettings(IntPtr nativeStruct)
	{
		if (!FMeshNaniteSettings_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.MeshNaniteSettings");
			Enabled = false;
			PreserveArea = false;
			PositionPrecision = 0;
			KeepPercentTriangles = 0f;
			TrimRelativeError = 0f;
			FallbackPercentTriangles = 0f;
			FallbackRelativeError = 0f;
		}
		else
		{
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			PreserveArea = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PreserveArea_Offset), 0, PreserveArea_PropertyAddress.Address);
			PositionPrecision = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PositionPrecision_Offset));
			KeepPercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, KeepPercentTriangles_Offset));
			TrimRelativeError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, TrimRelativeError_Offset));
			FallbackPercentTriangles = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FallbackPercentTriangles_Offset));
			FallbackRelativeError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FallbackRelativeError_Offset));
		}
	}

	static FMeshNaniteSettings()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FMeshNaniteSettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FMeshNaniteSettings));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.MeshNaniteSettings");
		FMeshNaniteSettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PreserveArea_PropertyAddress, intPtr, "bPreserveArea");
		PreserveArea_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPreserveArea");
		PreserveArea_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPreserveArea", Classes.FBoolProperty);
		PositionPrecision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PositionPrecision");
		PositionPrecision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PositionPrecision", Classes.FIntProperty);
		KeepPercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "KeepPercentTriangles");
		KeepPercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "KeepPercentTriangles", Classes.FFloatProperty);
		TrimRelativeError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TrimRelativeError");
		TrimRelativeError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TrimRelativeError", Classes.FFloatProperty);
		FallbackPercentTriangles_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackPercentTriangles");
		FallbackPercentTriangles_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackPercentTriangles", Classes.FFloatProperty);
		FallbackRelativeError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackRelativeError");
		FallbackRelativeError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackRelativeError", Classes.FFloatProperty);
		FMeshNaniteSettings_IsValid = intPtr != IntPtr.Zero && Enabled_IsValid && PreserveArea_IsValid && PositionPrecision_IsValid && KeepPercentTriangles_IsValid && TrimRelativeError_IsValid && FallbackPercentTriangles_IsValid && FallbackRelativeError_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.MeshNaniteSettings", FMeshNaniteSettings_IsValid);
	}
}
