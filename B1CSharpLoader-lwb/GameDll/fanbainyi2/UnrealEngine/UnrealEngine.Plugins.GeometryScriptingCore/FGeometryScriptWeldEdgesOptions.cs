using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptWeldEdgesOptions
{
	private static bool Tolerance_IsValid;

	private static int Tolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions:Tolerance")]
	public float Tolerance;

	private static bool OnlyUniquePairs_IsValid;

	private static FFieldAddress OnlyUniquePairs_PropertyAddress;

	private static int OnlyUniquePairs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions:bOnlyUniquePairs")]
	public bool OnlyUniquePairs;

	private static bool FGeometryScriptWeldEdgesOptions_IsValid;

	private static int FGeometryScriptWeldEdgesOptions_StructSize;

	public FGeometryScriptWeldEdgesOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptWeldEdgesOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptWeldEdgesOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptWeldEdgesOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptWeldEdgesOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptWeldEdgesOptions(nativeBuffer + arrayIndex * FGeometryScriptWeldEdgesOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptWeldEdgesOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptWeldEdgesOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptWeldEdgesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Tolerance_Offset), Tolerance);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OnlyUniquePairs_Offset), 0, OnlyUniquePairs_PropertyAddress.Address, OnlyUniquePairs);
	}

	public FGeometryScriptWeldEdgesOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptWeldEdgesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions");
			Tolerance = 0f;
			OnlyUniquePairs = false;
		}
		else
		{
			Tolerance = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Tolerance_Offset));
			OnlyUniquePairs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OnlyUniquePairs_Offset), 0, OnlyUniquePairs_PropertyAddress.Address);
		}
	}

	static FGeometryScriptWeldEdgesOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptWeldEdgesOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptWeldEdgesOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions");
		FGeometryScriptWeldEdgesOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tolerance");
		Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tolerance", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref OnlyUniquePairs_PropertyAddress, intPtr, "bOnlyUniquePairs");
		OnlyUniquePairs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOnlyUniquePairs");
		OnlyUniquePairs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOnlyUniquePairs", Classes.FBoolProperty);
		FGeometryScriptWeldEdgesOptions_IsValid = intPtr != IntPtr.Zero && Tolerance_IsValid && OnlyUniquePairs_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptWeldEdgesOptions", FGeometryScriptWeldEdgesOptions_IsValid);
	}
}
