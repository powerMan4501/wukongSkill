using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingCore;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions", "GeometryScriptingCore", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptIsSameMeshOptions
{
	private static bool CheckConnectivity_IsValid;

	private static FFieldAddress CheckConnectivity_PropertyAddress;

	private static int CheckConnectivity_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckConnectivity")]
	public bool CheckConnectivity;

	private static bool CheckEdgeIDs_IsValid;

	private static FFieldAddress CheckEdgeIDs_PropertyAddress;

	private static int CheckEdgeIDs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckEdgeIDs")]
	public bool CheckEdgeIDs;

	private static bool CheckNormals_IsValid;

	private static FFieldAddress CheckNormals_PropertyAddress;

	private static int CheckNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckNormals")]
	public bool CheckNormals;

	private static bool CheckColors_IsValid;

	private static FFieldAddress CheckColors_PropertyAddress;

	private static int CheckColors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckColors")]
	public bool CheckColors;

	private static bool CheckUVs_IsValid;

	private static FFieldAddress CheckUVs_PropertyAddress;

	private static int CheckUVs_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckUVs")]
	public bool CheckUVs;

	private static bool CheckGroups_IsValid;

	private static FFieldAddress CheckGroups_PropertyAddress;

	private static int CheckGroups_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckGroups")]
	public bool CheckGroups;

	private static bool CheckAttributes_IsValid;

	private static FFieldAddress CheckAttributes_PropertyAddress;

	private static int CheckAttributes_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:bCheckAttributes")]
	public bool CheckAttributes;

	private static bool Epsilon_IsValid;

	private static int Epsilon_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions:Epsilon")]
	public float Epsilon;

	private static bool FGeometryScriptIsSameMeshOptions_IsValid;

	private static int FGeometryScriptIsSameMeshOptions_StructSize;

	public FGeometryScriptIsSameMeshOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptIsSameMeshOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptIsSameMeshOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptIsSameMeshOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptIsSameMeshOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptIsSameMeshOptions(nativeBuffer + arrayIndex * FGeometryScriptIsSameMeshOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptIsSameMeshOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptIsSameMeshOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIsSameMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckConnectivity_Offset), 0, CheckConnectivity_PropertyAddress.Address, CheckConnectivity);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckEdgeIDs_Offset), 0, CheckEdgeIDs_PropertyAddress.Address, CheckEdgeIDs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckNormals_Offset), 0, CheckNormals_PropertyAddress.Address, CheckNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckColors_Offset), 0, CheckColors_PropertyAddress.Address, CheckColors);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckUVs_Offset), 0, CheckUVs_PropertyAddress.Address, CheckUVs);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckGroups_Offset), 0, CheckGroups_PropertyAddress.Address, CheckGroups);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CheckAttributes_Offset), 0, CheckAttributes_PropertyAddress.Address, CheckAttributes);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Epsilon_Offset), Epsilon);
	}

	public FGeometryScriptIsSameMeshOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptIsSameMeshOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions");
			CheckConnectivity = false;
			CheckEdgeIDs = false;
			CheckNormals = false;
			CheckColors = false;
			CheckUVs = false;
			CheckGroups = false;
			CheckAttributes = false;
			Epsilon = 0f;
		}
		else
		{
			CheckConnectivity = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckConnectivity_Offset), 0, CheckConnectivity_PropertyAddress.Address);
			CheckEdgeIDs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckEdgeIDs_Offset), 0, CheckEdgeIDs_PropertyAddress.Address);
			CheckNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckNormals_Offset), 0, CheckNormals_PropertyAddress.Address);
			CheckColors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckColors_Offset), 0, CheckColors_PropertyAddress.Address);
			CheckUVs = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckUVs_Offset), 0, CheckUVs_PropertyAddress.Address);
			CheckGroups = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckGroups_Offset), 0, CheckGroups_PropertyAddress.Address);
			CheckAttributes = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CheckAttributes_Offset), 0, CheckAttributes_PropertyAddress.Address);
			Epsilon = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Epsilon_Offset));
		}
	}

	static FGeometryScriptIsSameMeshOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptIsSameMeshOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptIsSameMeshOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions");
		FGeometryScriptIsSameMeshOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref CheckConnectivity_PropertyAddress, intPtr, "bCheckConnectivity");
		CheckConnectivity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckConnectivity");
		CheckConnectivity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckConnectivity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckEdgeIDs_PropertyAddress, intPtr, "bCheckEdgeIDs");
		CheckEdgeIDs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckEdgeIDs");
		CheckEdgeIDs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckEdgeIDs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckNormals_PropertyAddress, intPtr, "bCheckNormals");
		CheckNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckNormals");
		CheckNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckColors_PropertyAddress, intPtr, "bCheckColors");
		CheckColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckColors");
		CheckColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckColors", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckUVs_PropertyAddress, intPtr, "bCheckUVs");
		CheckUVs_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckUVs");
		CheckUVs_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckUVs", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckGroups_PropertyAddress, intPtr, "bCheckGroups");
		CheckGroups_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckGroups");
		CheckGroups_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckGroups", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CheckAttributes_PropertyAddress, intPtr, "bCheckAttributes");
		CheckAttributes_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bCheckAttributes");
		CheckAttributes_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bCheckAttributes", Classes.FBoolProperty);
		Epsilon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Epsilon");
		Epsilon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Epsilon", Classes.FFloatProperty);
		FGeometryScriptIsSameMeshOptions_IsValid = intPtr != IntPtr.Zero && CheckConnectivity_IsValid && CheckEdgeIDs_IsValid && CheckNormals_IsValid && CheckColors_IsValid && CheckUVs_IsValid && CheckGroups_IsValid && CheckAttributes_IsValid && Epsilon_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingCore.GeometryScriptIsSameMeshOptions", FGeometryScriptIsSameMeshOptions_IsValid);
	}
}
