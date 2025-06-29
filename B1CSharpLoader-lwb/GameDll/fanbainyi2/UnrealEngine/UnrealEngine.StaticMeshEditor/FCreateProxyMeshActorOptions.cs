using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.StaticMeshEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/StaticMeshEditor.CreateProxyMeshActorOptions", "StaticMeshEditor", UnrealModuleType.Engine)]
public struct FCreateProxyMeshActorOptions
{
	private static bool DestroySourceActors_IsValid;

	private static FFieldAddress DestroySourceActors_PropertyAddress;

	private static int DestroySourceActors_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bDestroySourceActors")]
	public bool DestroySourceActors;

	private static bool NewActorLabel_IsValid;

	private static int NewActorLabel_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:NewActorLabel")]
	public string NewActorLabel;

	private static bool RenameComponentsFromSource_IsValid;

	private static FFieldAddress RenameComponentsFromSource_PropertyAddress;

	private static int RenameComponentsFromSource_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.JoinStaticMeshActorsOptions:bRenameComponentsFromSource")]
	public bool RenameComponentsFromSource;

	private static bool SpawnMergedActor_IsValid;

	private static FFieldAddress SpawnMergedActor_PropertyAddress;

	private static int SpawnMergedActor_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/StaticMeshEditor.CreateProxyMeshActorOptions:bSpawnMergedActor")]
	public bool SpawnMergedActor;

	private static bool BasePackageName_IsValid;

	private static int BasePackageName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056261uL)]
	[UMetaPath("/Script/StaticMeshEditor.CreateProxyMeshActorOptions:BasePackageName")]
	public string BasePackageName;

	private static bool MeshProxySettings_IsValid;

	private static int MeshProxySettings_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/StaticMeshEditor.CreateProxyMeshActorOptions:MeshProxySettings")]
	public FMeshProxySettings MeshProxySettings;

	private static bool FCreateProxyMeshActorOptions_IsValid;

	private static int FCreateProxyMeshActorOptions_StructSize;

	public FCreateProxyMeshActorOptions Copy()
	{
		return this;
	}

	public static FCreateProxyMeshActorOptions FromNative(IntPtr nativeBuffer)
	{
		return new FCreateProxyMeshActorOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FCreateProxyMeshActorOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FCreateProxyMeshActorOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FCreateProxyMeshActorOptions(nativeBuffer + arrayIndex * FCreateProxyMeshActorOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FCreateProxyMeshActorOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FCreateProxyMeshActorOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FCreateProxyMeshActorOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.CreateProxyMeshActorOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SpawnMergedActor_Offset), 0, SpawnMergedActor_PropertyAddress.Address, SpawnMergedActor);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, BasePackageName_Offset), BasePackageName);
		FMeshProxySettings.ToNative(IntPtr.Add(nativeStruct, MeshProxySettings_Offset), MeshProxySettings);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address, DestroySourceActors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset), NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address, RenameComponentsFromSource);
	}

	public FCreateProxyMeshActorOptions(IntPtr nativeStruct)
	{
		if (!FCreateProxyMeshActorOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/StaticMeshEditor.CreateProxyMeshActorOptions");
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

	static FCreateProxyMeshActorOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FCreateProxyMeshActorOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FCreateProxyMeshActorOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/StaticMeshEditor.CreateProxyMeshActorOptions");
		FCreateProxyMeshActorOptions_StructSize = NativeReflection.GetStructSize(intPtr);
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
		FCreateProxyMeshActorOptions_IsValid = intPtr != IntPtr.Zero && SpawnMergedActor_IsValid && BasePackageName_IsValid && MeshProxySettings_IsValid && DestroySourceActors_IsValid && NewActorLabel_IsValid && RenameComponentsFromSource_IsValid;
		NativeReflection.LogStructIsValid("/Script/StaticMeshEditor.CreateProxyMeshActorOptions", FCreateProxyMeshActorOptions_IsValid);
	}
}
