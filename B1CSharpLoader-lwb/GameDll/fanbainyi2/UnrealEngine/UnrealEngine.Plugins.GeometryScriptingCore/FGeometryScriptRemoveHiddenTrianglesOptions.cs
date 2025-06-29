using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptRemoveHiddenTrianglesOptions
{
	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:Method")]
	public EGeometryScriptRemoveHiddenTrianglesMethod Method;

	private static bool SamplesPerTriangle_IsValid;

	private static int SamplesPerTriangle_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:SamplesPerTriangle")]
	public int SamplesPerTriangle;

	private static bool ShrinkSelection_IsValid;

	private static int ShrinkSelection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:ShrinkSelection")]
	public int ShrinkSelection;

	private static bool WindingIsoValue_IsValid;

	private static int WindingIsoValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:WindingIsoValue")]
	public float WindingIsoValue;

	private static bool RaysPerSample_IsValid;

	private static int RaysPerSample_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:RaysPerSample")]
	public int RaysPerSample;

	private static bool NormalOffset_IsValid;

	private static int NormalOffset_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:NormalOffset")]
	public float NormalOffset;

	private static bool CompactResult_IsValid;

	private static FFieldAddress CompactResult_PropertyAddress;

	private static int CompactResult_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions:bCompactResult")]
	public bool CompactResult;

	private static bool FGeometryScriptRemoveHiddenTrianglesOptions_IsValid;

	private static int FGeometryScriptRemoveHiddenTrianglesOptions_StructSize;

	public FGeometryScriptRemoveHiddenTrianglesOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptRemoveHiddenTrianglesOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptRemoveHiddenTrianglesOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptRemoveHiddenTrianglesOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptRemoveHiddenTrianglesOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptRemoveHiddenTrianglesOptions(nativeBuffer + arrayIndex * FGeometryScriptRemoveHiddenTrianglesOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptRemoveHiddenTrianglesOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptRemoveHiddenTrianglesOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRemoveHiddenTrianglesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions");
			return;
		}
		EnumMarshaler<EGeometryScriptRemoveHiddenTrianglesMethod>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, SamplesPerTriangle_Offset), SamplesPerTriangle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, ShrinkSelection_Offset), ShrinkSelection);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, WindingIsoValue_Offset), WindingIsoValue);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, RaysPerSample_Offset), RaysPerSample);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NormalOffset_Offset), NormalOffset);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CompactResult_Offset), 0, CompactResult_PropertyAddress.Address, CompactResult);
	}

	public FGeometryScriptRemoveHiddenTrianglesOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptRemoveHiddenTrianglesOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions");
			Method = EGeometryScriptRemoveHiddenTrianglesMethod.FastWindingNumber;
			SamplesPerTriangle = 0;
			ShrinkSelection = 0;
			WindingIsoValue = 0f;
			RaysPerSample = 0;
			NormalOffset = 0f;
			CompactResult = false;
		}
		else
		{
			Method = EnumMarshaler<EGeometryScriptRemoveHiddenTrianglesMethod>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
			SamplesPerTriangle = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, SamplesPerTriangle_Offset));
			ShrinkSelection = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, ShrinkSelection_Offset));
			WindingIsoValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, WindingIsoValue_Offset));
			RaysPerSample = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, RaysPerSample_Offset));
			NormalOffset = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NormalOffset_Offset));
			CompactResult = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CompactResult_Offset), 0, CompactResult_PropertyAddress.Address);
		}
	}

	static FGeometryScriptRemoveHiddenTrianglesOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptRemoveHiddenTrianglesOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptRemoveHiddenTrianglesOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions");
		FGeometryScriptRemoveHiddenTrianglesOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FEnumProperty);
		SamplesPerTriangle_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SamplesPerTriangle");
		SamplesPerTriangle_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SamplesPerTriangle", Classes.FIntProperty);
		ShrinkSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ShrinkSelection");
		ShrinkSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ShrinkSelection", Classes.FIntProperty);
		WindingIsoValue_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "WindingIsoValue");
		WindingIsoValue_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "WindingIsoValue", Classes.FFloatProperty);
		RaysPerSample_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RaysPerSample");
		RaysPerSample_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RaysPerSample", Classes.FIntProperty);
		NormalOffset_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NormalOffset");
		NormalOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NormalOffset", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref CompactResult_PropertyAddress, intPtr, "bCompactResult");
		CompactResult_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCompactResult");
		CompactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCompactResult", Classes.FBoolProperty);
		FGeometryScriptRemoveHiddenTrianglesOptions_IsValid = intPtr != IntPtr.Zero && Method_IsValid && SamplesPerTriangle_IsValid && ShrinkSelection_IsValid && WindingIsoValue_IsValid && RaysPerSample_IsValid && NormalOffset_IsValid && CompactResult_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptRemoveHiddenTrianglesOptions", FGeometryScriptRemoveHiddenTrianglesOptions_IsValid);
	}
}
