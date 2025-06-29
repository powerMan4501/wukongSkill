using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorScriptingJoinStaticMeshActorsOptions_Deprecated
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

	private static bool FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_IsValid;

	private static int FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_StructSize;

	public FEditorScriptingJoinStaticMeshActorsOptions_Deprecated Copy()
	{
		return this;
	}

	public static FEditorScriptingJoinStaticMeshActorsOptions_Deprecated FromNative(IntPtr nativeBuffer)
	{
		return new FEditorScriptingJoinStaticMeshActorsOptions_Deprecated(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorScriptingJoinStaticMeshActorsOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorScriptingJoinStaticMeshActorsOptions_Deprecated FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorScriptingJoinStaticMeshActorsOptions_Deprecated(nativeBuffer + arrayIndex * FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorScriptingJoinStaticMeshActorsOptions_Deprecated value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address, DestroySourceActors);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset), NewActorLabel);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address, RenameComponentsFromSource);
	}

	public FEditorScriptingJoinStaticMeshActorsOptions_Deprecated(IntPtr nativeStruct)
	{
		if (!FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated");
			DestroySourceActors = false;
			NewActorLabel = FStringMarshaler.DefaultString;
			RenameComponentsFromSource = false;
		}
		else
		{
			DestroySourceActors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DestroySourceActors_Offset), 0, DestroySourceActors_PropertyAddress.Address);
			NewActorLabel = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, NewActorLabel_Offset));
			RenameComponentsFromSource = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, RenameComponentsFromSource_Offset), 0, RenameComponentsFromSource_PropertyAddress.Address);
		}
	}

	static FEditorScriptingJoinStaticMeshActorsOptions_Deprecated()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorScriptingJoinStaticMeshActorsOptions_Deprecated)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorScriptingJoinStaticMeshActorsOptions_Deprecated));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated");
		FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref DestroySourceActors_PropertyAddress, intPtr, "bDestroySourceActors");
		DestroySourceActors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDestroySourceActors");
		DestroySourceActors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDestroySourceActors", Classes.FBoolProperty);
		NewActorLabel_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NewActorLabel");
		NewActorLabel_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NewActorLabel", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RenameComponentsFromSource_PropertyAddress, intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRenameComponentsFromSource");
		RenameComponentsFromSource_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRenameComponentsFromSource", Classes.FBoolProperty);
		FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_IsValid = intPtr != IntPtr.Zero && DestroySourceActors_IsValid && NewActorLabel_IsValid && RenameComponentsFromSource_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorScriptingJoinStaticMeshActorsOptions_Deprecated", FEditorScriptingJoinStaticMeshActorsOptions_Deprecated_IsValid);
	}
}
