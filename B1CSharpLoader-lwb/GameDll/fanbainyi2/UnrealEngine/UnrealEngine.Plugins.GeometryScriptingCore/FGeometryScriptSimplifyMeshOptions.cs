using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptSimplifyMeshOptions
{
	private static bool Method_IsValid;

	private static FFieldAddress Method_PropertyAddress;

	private static int Method_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:Method")]
	public EGeometryScriptRemoveMeshSimplificationType Method;

	private static bool AllowSeamCollapse_IsValid;

	private static FFieldAddress AllowSeamCollapse_PropertyAddress;

	private static int AllowSeamCollapse_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:bAllowSeamCollapse")]
	public bool AllowSeamCollapse;

	private static bool AllowSeamSmoothing_IsValid;

	private static FFieldAddress AllowSeamSmoothing_PropertyAddress;

	private static int AllowSeamSmoothing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:bAllowSeamSmoothing")]
	public bool AllowSeamSmoothing;

	private static bool AllowSeamSplits_IsValid;

	private static FFieldAddress AllowSeamSplits_PropertyAddress;

	private static int AllowSeamSplits_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:bAllowSeamSplits")]
	public bool AllowSeamSplits;

	private static bool PreserveVertexPositions_IsValid;

	private static FFieldAddress PreserveVertexPositions_PropertyAddress;

	private static int PreserveVertexPositions_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:bPreserveVertexPositions")]
	public bool PreserveVertexPositions;

	private static bool RetainQuadricMemory_IsValid;

	private static FFieldAddress RetainQuadricMemory_PropertyAddress;

	private static int RetainQuadricMemory_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions:bRetainQuadricMemory")]
	public bool RetainQuadricMemory;

	private static bool FGeometryScriptSimplifyMeshOptions_IsValid;

	private static int FGeometryScriptSimplifyMeshOptions_StructSize;

	public FGeometryScriptSimplifyMeshOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptSimplifyMeshOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptSimplifyMeshOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptSimplifyMeshOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptSimplifyMeshOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptSimplifyMeshOptions(nativeBuffer + arrayIndex * FGeometryScriptSimplifyMeshOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptSimplifyMeshOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptSimplifyMeshOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSimplifyMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions");
			return;
		}
		EnumMarshaler<EGeometryScriptRemoveMeshSimplificationType>.ToNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address, Method);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowSeamCollapse_Offset), 0, AllowSeamCollapse_PropertyAddress.Address, AllowSeamCollapse);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowSeamSmoothing_Offset), 0, AllowSeamSmoothing_PropertyAddress.Address, AllowSeamSmoothing);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowSeamSplits_Offset), 0, AllowSeamSplits_PropertyAddress.Address, AllowSeamSplits);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, PreserveVertexPositions_Offset), 0, PreserveVertexPositions_PropertyAddress.Address, PreserveVertexPositions);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RetainQuadricMemory_Offset), 0, RetainQuadricMemory_PropertyAddress.Address, RetainQuadricMemory);
	}

	public FGeometryScriptSimplifyMeshOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptSimplifyMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions");
			Method = EGeometryScriptRemoveMeshSimplificationType.StandardQEM;
			AllowSeamCollapse = false;
			AllowSeamSmoothing = false;
			AllowSeamSplits = false;
			PreserveVertexPositions = false;
			RetainQuadricMemory = false;
		}
		else
		{
			Method = EnumMarshaler<EGeometryScriptRemoveMeshSimplificationType>.FromNative(IntPtr.Add(nativeStruct, Method_Offset), 0, Method_PropertyAddress.Address);
			AllowSeamCollapse = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowSeamCollapse_Offset), 0, AllowSeamCollapse_PropertyAddress.Address);
			AllowSeamSmoothing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowSeamSmoothing_Offset), 0, AllowSeamSmoothing_PropertyAddress.Address);
			AllowSeamSplits = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowSeamSplits_Offset), 0, AllowSeamSplits_PropertyAddress.Address);
			PreserveVertexPositions = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, PreserveVertexPositions_Offset), 0, PreserveVertexPositions_PropertyAddress.Address);
			RetainQuadricMemory = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RetainQuadricMemory_Offset), 0, RetainQuadricMemory_PropertyAddress.Address);
		}
	}

	static FGeometryScriptSimplifyMeshOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptSimplifyMeshOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptSimplifyMeshOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions");
		FGeometryScriptSimplifyMeshOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Method_PropertyAddress, intPtr, "Method");
		Method_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Method");
		Method_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Method", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSeamCollapse_PropertyAddress, intPtr, "bAllowSeamCollapse");
		AllowSeamCollapse_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSeamCollapse");
		AllowSeamCollapse_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSeamCollapse", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSeamSmoothing_PropertyAddress, intPtr, "bAllowSeamSmoothing");
		AllowSeamSmoothing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSeamSmoothing");
		AllowSeamSmoothing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSeamSmoothing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSeamSplits_PropertyAddress, intPtr, "bAllowSeamSplits");
		AllowSeamSplits_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSeamSplits");
		AllowSeamSplits_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSeamSplits", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref PreserveVertexPositions_PropertyAddress, intPtr, "bPreserveVertexPositions");
		PreserveVertexPositions_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bPreserveVertexPositions");
		PreserveVertexPositions_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bPreserveVertexPositions", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RetainQuadricMemory_PropertyAddress, intPtr, "bRetainQuadricMemory");
		RetainQuadricMemory_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRetainQuadricMemory");
		RetainQuadricMemory_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRetainQuadricMemory", Classes.FBoolProperty);
		FGeometryScriptSimplifyMeshOptions_IsValid = intPtr != IntPtr.Zero && Method_IsValid && AllowSeamCollapse_IsValid && AllowSeamSmoothing_IsValid && AllowSeamSplits_IsValid && PreserveVertexPositions_IsValid && RetainQuadricMemory_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptSimplifyMeshOptions", FGeometryScriptSimplifyMeshOptions_IsValid);
	}
}
