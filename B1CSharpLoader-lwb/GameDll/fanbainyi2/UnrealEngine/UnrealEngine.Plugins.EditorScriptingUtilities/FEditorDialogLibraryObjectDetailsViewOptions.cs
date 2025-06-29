using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public struct FEditorDialogLibraryObjectDetailsViewOptions
{
	private static bool ShowObjectName_IsValid;

	private static FFieldAddress ShowObjectName_PropertyAddress;

	private static int ShowObjectName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:bShowObjectName")]
	public bool ShowObjectName;

	private static bool AllowSearch_IsValid;

	private static FFieldAddress AllowSearch_PropertyAddress;

	private static int AllowSearch_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions:bAllowSearch")]
	public bool AllowSearch;

	private static bool FEditorDialogLibraryObjectDetailsViewOptions_IsValid;

	private static int FEditorDialogLibraryObjectDetailsViewOptions_StructSize;

	public FEditorDialogLibraryObjectDetailsViewOptions Copy()
	{
		return this;
	}

	public static FEditorDialogLibraryObjectDetailsViewOptions FromNative(IntPtr nativeBuffer)
	{
		return new FEditorDialogLibraryObjectDetailsViewOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FEditorDialogLibraryObjectDetailsViewOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FEditorDialogLibraryObjectDetailsViewOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FEditorDialogLibraryObjectDetailsViewOptions(nativeBuffer + arrayIndex * FEditorDialogLibraryObjectDetailsViewOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FEditorDialogLibraryObjectDetailsViewOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FEditorDialogLibraryObjectDetailsViewOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FEditorDialogLibraryObjectDetailsViewOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShowObjectName_Offset), 0, ShowObjectName_PropertyAddress.Address, ShowObjectName);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, AllowSearch_Offset), 0, AllowSearch_PropertyAddress.Address, AllowSearch);
	}

	public FEditorDialogLibraryObjectDetailsViewOptions(IntPtr nativeStruct)
	{
		if (!FEditorDialogLibraryObjectDetailsViewOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions");
			ShowObjectName = false;
			AllowSearch = false;
		}
		else
		{
			ShowObjectName = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShowObjectName_Offset), 0, ShowObjectName_PropertyAddress.Address);
			AllowSearch = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, AllowSearch_Offset), 0, AllowSearch_PropertyAddress.Address);
		}
	}

	static FEditorDialogLibraryObjectDetailsViewOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FEditorDialogLibraryObjectDetailsViewOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FEditorDialogLibraryObjectDetailsViewOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions");
		FEditorDialogLibraryObjectDetailsViewOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectName_PropertyAddress, intPtr, "bShowObjectName");
		ShowObjectName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShowObjectName");
		ShowObjectName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShowObjectName", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AllowSearch_PropertyAddress, intPtr, "bAllowSearch");
		AllowSearch_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAllowSearch");
		AllowSearch_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAllowSearch", Classes.FBoolProperty);
		FEditorDialogLibraryObjectDetailsViewOptions_IsValid = intPtr != IntPtr.Zero && ShowObjectName_IsValid && AllowSearch_IsValid;
		NativeReflection.LogStructIsValid("/Script/EditorScriptingUtilities.EditorDialogLibraryObjectDetailsViewOptions", FEditorDialogLibraryObjectDetailsViewOptions_IsValid);
	}
}
