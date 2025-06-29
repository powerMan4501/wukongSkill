using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorScriptingMergeStaticMeshActorsOptions_Deprecated
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
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated:bSpawnMergedActor")]
	public bool SpawnMergedActor;

	private static bool BasePackageName_IsValid;

	private static int BasePackageName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated:BasePackageName")]
	public string BasePackageName;

	private static bool MeshMergingSettings_IsValid;

	private static int MeshMergingSettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated:MeshMergingSettings")]
	public FMeshMergingSettings MeshMergingSettings;

	private static bool FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_IsValid;

	private static int FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_StructSize;

	public FEditorScriptingMergeStaticMeshActorsOptions_Deprecated Copy()
	{
		return this;
	}

	public static FEditorScriptingMergeStaticMeshActorsOptions_Deprecated FromNative(IntPtr nativeBuffer)
	{
		return new FEditorScriptingMergeStaticMeshActorsOptions_Deprecated(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorScriptingMergeStaticMeshActorsOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorScriptingMergeStaticMeshActorsOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorScriptingMergeStaticMeshActorsOptions_Deprecated(nativeBuffer + arrayIndex * FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorScriptingMergeStaticMeshActorsOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnMergedActor_Offset), 0, SpawnMergedActor_PropertyAddress.Address, SpawnMergedActor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, BasePackageName_Offset), BasePackageName);
		FMeshMergingSettings.ToNative(IntPtr.Add(nativeStruct, MeshMergingSettings_Offset), MeshMergingSettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address, DestroySourceActors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset), NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address, RenameComponentsFromSource);
	}

	public FEditorScriptingMergeStaticMeshActorsOptions_Deprecated(IntPtr nativeStruct)
	{
		if (!FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated");
			SpawnMergedActor = false;
			BasePackageName = FStringMarshaler.DefaultString;
			MeshMergingSettings = default(FMeshMergingSettings);
			DestroySourceActors = false;
			NewActorLabel = FStringMarshaler.DefaultString;
			RenameComponentsFromSource = false;
		}
		else
		{
			SpawnMergedActor = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SpawnMergedActor_Offset), 0, SpawnMergedActor_PropertyAddress.Address);
			BasePackageName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, BasePackageName_Offset));
			MeshMergingSettings = FMeshMergingSettings.FromNative(IntPtr.Add(nativeStruct, MeshMergingSettings_Offset));
			DestroySourceActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address);
			NewActorLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset));
			RenameComponentsFromSource = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address);
		}
	}

	static FEditorScriptingMergeStaticMeshActorsOptions_Deprecated()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorScriptingMergeStaticMeshActorsOptions_Deprecated)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorScriptingMergeStaticMeshActorsOptions_Deprecated));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated");
		FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_StructSize = NativeReflection.GetStructSize(intPtr);
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
		MeshMergingSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MeshMergingSettings");
		MeshMergingSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MeshMergingSettings", Classes.FStructProperty);
		FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_IsValid = intPtr != IntPtr.Zero && SpawnMergedActor_IsValid && BasePackageName_IsValid && MeshMergingSettings_IsValid && DestroySourceActors_IsValid && NewActorLabel_IsValid && RenameComponentsFromSource_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorScriptingMergeStaticMeshActorsOptions_Deprecated", FEditorScriptingMergeStaticMeshActorsOptions_Deprecated_IsValid);
	}
}
