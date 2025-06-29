using System;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuEntry", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuEntry
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:Name")]
	public FName Name;

	private static bool Owner_IsValid;

	private static int Owner_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:Owner")]
	public FToolMenuOwner Owner;

	private static bool Type_IsValid;

	private static FFieldAddress Type_PropertyAddress;

	private static int Type_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:Type")]
	public EMultiBlockType Type;

	private static bool UserInterfaceActionType_IsValid;

	private static FFieldAddress UserInterfaceActionType_PropertyAddress;

	private static int UserInterfaceActionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:UserInterfaceActionType")]
	public EUserInterfaceActionType UserInterfaceActionType;

	private static bool TutorialHighlightName_IsValid;

	private static int TutorialHighlightName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:TutorialHighlightName")]
	public FName TutorialHighlightName;

	private static bool InsertPosition_IsValid;

	private static int InsertPosition_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:InsertPosition")]
	public FToolMenuInsert InsertPosition;

	private static bool ShouldCloseWindowAfterMenuSelection_IsValid;

	private static FFieldAddress ShouldCloseWindowAfterMenuSelection_PropertyAddress;

	private static int ShouldCloseWindowAfterMenuSelection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:bShouldCloseWindowAfterMenuSelection")]
	public bool ShouldCloseWindowAfterMenuSelection;

	private static bool ScriptObject_IsValid;

	private static int ScriptObject_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:ScriptObject")]
	public UToolMenuEntryScript ScriptObject;

	private static bool StyleNameOverride_IsValid;

	private static int StyleNameOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntry:StyleNameOverride")]
	public FName StyleNameOverride;

	private static bool FToolMenuEntry_IsValid;

	private static int FToolMenuEntry_StructSize;

	public FToolMenuEntry Copy()
	{
		return this;
	}

	public static FToolMenuEntry FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuEntry(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuEntry value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuEntry FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuEntry(nativeBuffer + arrayIndex * FToolMenuEntry_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuEntry value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuEntry_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntry");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FToolMenuOwner.ToNative(IntPtr.Add(nativeStruct, Owner_Offset), Owner);
		EnumMarshaler<EMultiBlockType>.ToNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address, Type);
		EnumMarshaler<EUserInterfaceActionType>.ToNative(IntPtr.Add(nativeStruct, UserInterfaceActionType_Offset), 0, UserInterfaceActionType_PropertyAddress.Address, UserInterfaceActionType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TutorialHighlightName_Offset), TutorialHighlightName);
		FToolMenuInsert.ToNative(IntPtr.Add(nativeStruct, InsertPosition_Offset), InsertPosition);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address, ShouldCloseWindowAfterMenuSelection);
		UObjectMarshaler<UToolMenuEntryScript>.ToNative(IntPtr.Add(nativeStruct, ScriptObject_Offset), ScriptObject);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StyleNameOverride_Offset), StyleNameOverride);
	}

	public FToolMenuEntry(IntPtr nativeStruct)
	{
		if (!FToolMenuEntry_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntry");
			Name = default(FName);
			Owner = default(FToolMenuOwner);
			Type = EMultiBlockType.None;
			UserInterfaceActionType = EUserInterfaceActionType.None;
			TutorialHighlightName = default(FName);
			InsertPosition = default(FToolMenuInsert);
			ShouldCloseWindowAfterMenuSelection = false;
			ScriptObject = null;
			StyleNameOverride = default(FName);
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Owner = FToolMenuOwner.FromNative(IntPtr.Add(nativeStruct, Owner_Offset));
			Type = EnumMarshaler<EMultiBlockType>.FromNative(IntPtr.Add(nativeStruct, Type_Offset), 0, Type_PropertyAddress.Address);
			UserInterfaceActionType = EnumMarshaler<EUserInterfaceActionType>.FromNative(IntPtr.Add(nativeStruct, UserInterfaceActionType_Offset), 0, UserInterfaceActionType_PropertyAddress.Address);
			TutorialHighlightName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TutorialHighlightName_Offset));
			InsertPosition = FToolMenuInsert.FromNative(IntPtr.Add(nativeStruct, InsertPosition_Offset));
			ShouldCloseWindowAfterMenuSelection = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address);
			ScriptObject = UObjectMarshaler<UToolMenuEntryScript>.FromNative(IntPtr.Add(nativeStruct, ScriptObject_Offset));
			StyleNameOverride = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StyleNameOverride_Offset));
		}
	}

	static FToolMenuEntry()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuEntry)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuEntry));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuEntry");
		FToolMenuEntry_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Owner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Owner");
		Owner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Owner", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref Type_PropertyAddress, intPtr, "Type");
		Type_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Type");
		Type_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Type", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UserInterfaceActionType_PropertyAddress, intPtr, "UserInterfaceActionType");
		UserInterfaceActionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserInterfaceActionType");
		UserInterfaceActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserInterfaceActionType", Classes.FEnumProperty);
		TutorialHighlightName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TutorialHighlightName");
		TutorialHighlightName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TutorialHighlightName", Classes.FNameProperty);
		InsertPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InsertPosition");
		InsertPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InsertPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldCloseWindowAfterMenuSelection_PropertyAddress, intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldCloseWindowAfterMenuSelection", Classes.FBoolProperty);
		ScriptObject_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ScriptObject");
		ScriptObject_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ScriptObject", Classes.FObjectProperty);
		StyleNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StyleNameOverride");
		StyleNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StyleNameOverride", Classes.FNameProperty);
		FToolMenuEntry_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Owner_IsValid && Type_IsValid && UserInterfaceActionType_IsValid && TutorialHighlightName_IsValid && InsertPosition_IsValid && ShouldCloseWindowAfterMenuSelection_IsValid && ScriptObject_IsValid && StyleNameOverride_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuEntry", FToolMenuEntry_IsValid);
	}
}
