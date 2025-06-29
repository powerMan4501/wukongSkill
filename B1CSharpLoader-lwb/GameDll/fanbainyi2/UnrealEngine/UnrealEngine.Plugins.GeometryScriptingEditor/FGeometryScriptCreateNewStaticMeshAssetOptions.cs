using System;
using UnrealEngine.PhysicsCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GeometryScriptingEditor;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions", "GeometryScriptingEditor", UnrealModuleType.EnginePlugin)]
public struct FGeometryScriptCreateNewStaticMeshAssetOptions
{
	private static bool EnableRecomputeNormals_IsValid;

	private static FFieldAddress EnableRecomputeNormals_PropertyAddress;

	private static int EnableRecomputeNormals_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:bEnableRecomputeNormals")]
	public bool EnableRecomputeNormals;

	private static bool EnableRecomputeTangents_IsValid;

	private static FFieldAddress EnableRecomputeTangents_PropertyAddress;

	private static int EnableRecomputeTangents_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:bEnableRecomputeTangents")]
	public bool EnableRecomputeTangents;

	private static bool EnableNanite_IsValid;

	private static FFieldAddress EnableNanite_PropertyAddress;

	private static int EnableNanite_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:bEnableNanite")]
	public bool EnableNanite;

	private static bool NaniteProxyTrianglePercent_IsValid;

	private static int NaniteProxyTrianglePercent_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:NaniteProxyTrianglePercent")]
	public float NaniteProxyTrianglePercent;

	private static bool EnableCollision_IsValid;

	private static FFieldAddress EnableCollision_PropertyAddress;

	private static int EnableCollision_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:bEnableCollision")]
	public bool EnableCollision;

	private static bool CollisionMode_IsValid;

	private static FFieldAddress CollisionMode_PropertyAddress;

	private static int CollisionMode_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions:CollisionMode")]
	public ECollisionTraceFlag CollisionMode;

	private static bool FGeometryScriptCreateNewStaticMeshAssetOptions_IsValid;

	private static int FGeometryScriptCreateNewStaticMeshAssetOptions_StructSize;

	public FGeometryScriptCreateNewStaticMeshAssetOptions Copy()
	{
		return this;
	}

	public static FGeometryScriptCreateNewStaticMeshAssetOptions FromNative(IntPtr nativeBuffer)
	{
		return new FGeometryScriptCreateNewStaticMeshAssetOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FGeometryScriptCreateNewStaticMeshAssetOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FGeometryScriptCreateNewStaticMeshAssetOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FGeometryScriptCreateNewStaticMeshAssetOptions(nativeBuffer + arrayIndex * FGeometryScriptCreateNewStaticMeshAssetOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FGeometryScriptCreateNewStaticMeshAssetOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FGeometryScriptCreateNewStaticMeshAssetOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCreateNewStaticMeshAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRecomputeNormals_Offset), 0, EnableRecomputeNormals_PropertyAddress.Address, EnableRecomputeNormals);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableRecomputeTangents_Offset), 0, EnableRecomputeTangents_PropertyAddress.Address, EnableRecomputeTangents);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address, EnableNanite);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset), NaniteProxyTrianglePercent);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address, EnableCollision);
		EnumMarshaler<ECollisionTraceFlag>.ToNative(IntPtr.Add(nativeStruct, CollisionMode_Offset), 0, CollisionMode_PropertyAddress.Address, CollisionMode);
	}

	public FGeometryScriptCreateNewStaticMeshAssetOptions(IntPtr nativeStruct)
	{
		if (!FGeometryScriptCreateNewStaticMeshAssetOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions");
			EnableRecomputeNormals = false;
			EnableRecomputeTangents = false;
			EnableNanite = false;
			NaniteProxyTrianglePercent = 0f;
			EnableCollision = false;
			CollisionMode = ECollisionTraceFlag.CTF_UseDefault;
		}
		else
		{
			EnableRecomputeNormals = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRecomputeNormals_Offset), 0, EnableRecomputeNormals_PropertyAddress.Address);
			EnableRecomputeTangents = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableRecomputeTangents_Offset), 0, EnableRecomputeTangents_PropertyAddress.Address);
			EnableNanite = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableNanite_Offset), 0, EnableNanite_PropertyAddress.Address);
			NaniteProxyTrianglePercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, NaniteProxyTrianglePercent_Offset));
			EnableCollision = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, EnableCollision_Offset), 0, EnableCollision_PropertyAddress.Address);
			CollisionMode = EnumMarshaler<ECollisionTraceFlag>.FromNative(IntPtr.Add(nativeStruct, CollisionMode_Offset), 0, CollisionMode_PropertyAddress.Address);
		}
	}

	static FGeometryScriptCreateNewStaticMeshAssetOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FGeometryScriptCreateNewStaticMeshAssetOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FGeometryScriptCreateNewStaticMeshAssetOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions");
		FGeometryScriptCreateNewStaticMeshAssetOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref EnableRecomputeNormals_PropertyAddress, intPtr, "bEnableRecomputeNormals");
		EnableRecomputeNormals_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRecomputeNormals");
		EnableRecomputeNormals_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRecomputeNormals", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableRecomputeTangents_PropertyAddress, intPtr, "bEnableRecomputeTangents");
		EnableRecomputeTangents_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableRecomputeTangents");
		EnableRecomputeTangents_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableRecomputeTangents", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableNanite_PropertyAddress, intPtr, "bEnableNanite");
		EnableNanite_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableNanite");
		EnableNanite_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableNanite", Classes.FBoolProperty);
		NaniteProxyTrianglePercent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NaniteProxyTrianglePercent");
		NaniteProxyTrianglePercent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NaniteProxyTrianglePercent", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref EnableCollision_PropertyAddress, intPtr, "bEnableCollision");
		EnableCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnableCollision");
		EnableCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnableCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CollisionMode_PropertyAddress, intPtr, "CollisionMode");
		CollisionMode_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CollisionMode");
		CollisionMode_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CollisionMode", Classes.FByteProperty);
		FGeometryScriptCreateNewStaticMeshAssetOptions_IsValid = intPtr != IntPtr.Zero && EnableRecomputeNormals_IsValid && EnableRecomputeTangents_IsValid && EnableNanite_IsValid && NaniteProxyTrianglePercent_IsValid && EnableCollision_IsValid && CollisionMode_IsValid;
		NativeReflection.LogStructIsValid("/Script/GeometryScriptingEditor.GeometryScriptCreateNewStaticMeshAssetOptions", FGeometryScriptCreateNewStaticMeshAssetOptions_IsValid);
	}
}
