using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCopyMeshFromComponentOptions
{
	private static bool WantNormals_IsValid;

	private static FFieldAddress WantNormals_PropertyAddress;

	private static int WantNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions:bWantNormals")]
	public bool WantNormals;

	private static bool WantTangents_IsValid;

	private static FFieldAddress WantTangents_PropertyAddress;

	private static int WantTangents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions:bWantTangents")]
	public bool WantTangents;

	private static bool RequestedLOD_IsValid;

	private static int RequestedLOD_Offset;

	[UProperty(Flags = (PropFlags)4503668346847236uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions:RequestedLOD")]
	public FGeometryScriptMeshReadLOD RequestedLOD;

	private static bool FGeometryScriptCopyMeshFromComponentOptions_IsValid;

	private static int FGeometryScriptCopyMeshFromComponentOptions_StructSize;

	public FGeometryScriptCopyMeshFromComponentOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCopyMeshFromComponentOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCopyMeshFromComponentOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCopyMeshFromComponentOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCopyMeshFromComponentOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCopyMeshFromComponentOptions(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshFromComponentOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCopyMeshFromComponentOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCopyMeshFromComponentOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshFromComponentOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WantNormals_Offset), 0, WantNormals_PropertyAddress.Address, WantNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, WantTangents_Offset), 0, WantTangents_PropertyAddress.Address, WantTangents);
		FGeometryScriptMeshReadLOD.ToNative(IntPtr.Add(nativeStruct, RequestedLOD_Offset), RequestedLOD);
	}

	public FGeometryScriptCopyMeshFromComponentOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCopyMeshFromComponentOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions");
			WantNormals = false;
			WantTangents = false;
			RequestedLOD = default(FGeometryScriptMeshReadLOD);
		}
		else
		{
			WantNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WantNormals_Offset), 0, WantNormals_PropertyAddress.Address);
			WantTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, WantTangents_Offset), 0, WantTangents_PropertyAddress.Address);
			RequestedLOD = FGeometryScriptMeshReadLOD.FromNative(IntPtr.Add(nativeStruct, RequestedLOD_Offset));
		}
	}

	static FGeometryScriptCopyMeshFromComponentOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCopyMeshFromComponentOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCopyMeshFromComponentOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions");
		FGeometryScriptCopyMeshFromComponentOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref WantNormals_PropertyAddress, intPtr, "bWantNormals");
		WantNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWantNormals");
		WantNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWantNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WantTangents_PropertyAddress, intPtr, "bWantTangents");
		WantTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bWantTangents");
		WantTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bWantTangents", Classes.FBoolProperty);
		RequestedLOD_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "RequestedLOD");
		RequestedLOD_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "RequestedLOD", Classes.FStructProperty);
		FGeometryScriptCopyMeshFromComponentOptions_IsValid = intPtr != IntPtr.Zero && WantNormals_IsValid && WantTangents_IsValid && RequestedLOD_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptCopyMeshFromComponentOptions", FGeometryScriptCopyMeshFromComponentOptions_IsValid);
	}
}
