using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptMeasureMeshDistanceOptions
{
	private static bool Symmetric_IsValid;

	private static FFieldAddress Symmetric_PropertyAddress;

	private static int Symmetric_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions:bSymmetric")]
	public bool Symmetric;

	private static bool FGeometryScriptMeasureMeshDistanceOptions_IsValid;

	private static int FGeometryScriptMeasureMeshDistanceOptions_StructSize;

	public FGeometryScriptMeasureMeshDistanceOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptMeasureMeshDistanceOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptMeasureMeshDistanceOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptMeasureMeshDistanceOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptMeasureMeshDistanceOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptMeasureMeshDistanceOptions(nativeBuffer + arrayIndex * FGeometryScriptMeasureMeshDistanceOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptMeasureMeshDistanceOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptMeasureMeshDistanceOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeasureMeshDistanceOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions");
		}
		else
		{
			BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Symmetric_Offset), 0, Symmetric_PropertyAddress.Address, Symmetric);
		}
	}

	public FGeometryScriptMeasureMeshDistanceOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptMeasureMeshDistanceOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions");
			Symmetric = false;
		}
		else
		{
			Symmetric = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Symmetric_Offset), 0, Symmetric_PropertyAddress.Address);
		}
	}

	static FGeometryScriptMeasureMeshDistanceOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptMeasureMeshDistanceOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptMeasureMeshDistanceOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions");
		FGeometryScriptMeasureMeshDistanceOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Symmetric_PropertyAddress, intPtr, "bSymmetric");
		Symmetric_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSymmetric");
		Symmetric_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSymmetric", Classes.FBoolProperty);
		FGeometryScriptMeasureMeshDistanceOptions_IsValid = intPtr != IntPtr.Zero && Symmetric_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptMeasureMeshDistanceOptions", FGeometryScriptMeasureMeshDistanceOptions_IsValid);
	}
}
