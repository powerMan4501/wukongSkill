using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorScriptingCreateProxyMeshActorOptions_Deprecated
{
	private static bool DestroySourceActors_IsValid;

	private static FFieldAddress DestroySourceActors_PropertyAddress;

	private static int DestroySourceActors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated:bDestroySourceActors")]
	public bool DestroySourceActors;

	private static bool NewActorLabel_IsValid;

	private static int NewActorLabel_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated:NewActorLabel")]
	public string NewActorLabel;

	private static bool RenameComponentsFromSource_IsValid;

	private static FFieldAddress RenameComponentsFromSource_PropertyAddress;

	private static int RenameComponentsFromSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated:bRenameComponentsFromSource")]
	public bool RenameComponentsFromSource;

	private static bool SpawnMergedActor_IsValid;

	private static FFieldAddress SpawnMergedActor_PropertyAddress;

	private static int SpawnMergedActor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated:bSpawnMergedActor")]
	public bool SpawnMergedActor;

	private static bool BasePackageName_IsValid;

	private static int BasePackageName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated:BasePackageName")]
	public string BasePackageName;

	private static bool MeshProxySettings_IsValid;

	private static int MeshProxySettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated:MeshProxySettings")]
	public FMeshProxySettings MeshProxySettings;

	private static bool FEditorScriptingCreateProxyMeshActorOptions_Deprecated_IsValid;

	private static int FEditorScriptingCreateProxyMeshActorOptions_Deprecated_StructSize;

	public FEditorScriptingCreateProxyMeshActorOptions_Deprecated Copy()
	{
		return this;
	}

	public static FEditorScriptingCreateProxyMeshActorOptions_Deprecated FromNative(IntPtr nativeBuffer)
	{
		return new FEditorScriptingCreateProxyMeshActorOptions_Deprecated(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorScriptingCreateProxyMeshActorOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorScriptingCreateProxyMeshActorOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorScriptingCreateProxyMeshActorOptions_Deprecated(nativeBuffer + arrayIndex * FEditorScriptingCreateProxyMeshActorOptions_Deprecated_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorScriptingCreateProxyMeshActorOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorScriptingCreateProxyMeshActorOptions_Deprecated_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorScriptingCreateProxyMeshActorOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnMergedActor_Offset), 0, SpawnMergedActor_PropertyAddress.Address, SpawnMergedActor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, BasePackageName_Offset), BasePackageName);
		FMeshProxySettings.ToNative(IntPtr.Add(nativeStruct, MeshProxySettings_Offset), MeshProxySettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address, DestroySourceActors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset), NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address, RenameComponentsFromSource);
	}

	public FEditorScriptingCreateProxyMeshActorOptions_Deprecated(IntPtr nativeStruct)
	{
		if (!FEditorScriptingCreateProxyMeshActorOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated");
			SpawnMergedActor = false;
			BasePackageName = FStringMarshaler.DefaultString;
			MeshProxySettings = default(FMeshProxySettings);
			DestroySourceActors = false;
			NewActorLabel = FStringMarshaler.DefaultString;
			RenameComponentsFromSource = false;
		}
		else
		{
			SpawnMergedActor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpawnMergedActor_Offset), 0, SpawnMergedActor_PropertyAddress.Address);
			BasePackageName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, BasePackageName_Offset));
			MeshProxySettings = FMeshProxySettings.FromNative(IntPtr.Add(nativeStruct, MeshProxySettings_Offset));
			DestroySourceActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address);
			NewActorLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset));
			RenameComponentsFromSource = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address);
		}
	}

	static FEditorScriptingCreateProxyMeshActorOptions_Deprecated()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorScriptingCreateProxyMeshActorOptions_Deprecated)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorScriptingCreateProxyMeshActorOptions_Deprecated));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated");
		FEditorScriptingCreateProxyMeshActorOptions_Deprecated_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DestroySourceActors_PropertyAddress, intPtr, "bDestroySourceActors");
		DestroySourceActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDestroySourceActors");
		DestroySourceActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDestroySourceActors", Classes.FBoolProperty);
		NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewActorLabel");
		NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameComponentsFromSource_PropertyAddress, intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenameComponentsFromSource", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnMergedActor_PropertyAddress, intPtr, "bSpawnMergedActor");
		SpawnMergedActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSpawnMergedActor");
		SpawnMergedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSpawnMergedActor", Classes.FBoolProperty);
		BasePackageName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BasePackageName");
		BasePackageName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BasePackageName", Classes.FStrProperty);
		MeshProxySettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshProxySettings");
		MeshProxySettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshProxySettings", Classes.FStructProperty);
		FEditorScriptingCreateProxyMeshActorOptions_Deprecated_IsValid = intPtr != IntPtr.Zero && SpawnMergedActor_IsValid && BasePackageName_IsValid && MeshProxySettings_IsValid && DestroySourceActors_IsValid && NewActorLabel_IsValid && RenameComponentsFromSource_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorScriptingCreateProxyMeshActorOptions_Deprecated", FEditorScriptingCreateProxyMeshActorOptions_Deprecated_IsValid);
	}
}
