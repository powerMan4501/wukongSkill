using System;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuEntryScriptDataAdvanced
{
	private static bool TutorialHighlight_IsValid;

	private static int TutorialHighlight_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:TutorialHighlight")]
	public FName TutorialHighlight;

	private static bool EntryType_IsValid;

	private static FFieldAddress EntryType_PropertyAddress;

	private static int EntryType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:EntryType")]
	public EMultiBlockType EntryType;

	private static bool UserInterfaceActionType_IsValid;

	private static FFieldAddress UserInterfaceActionType_PropertyAddress;

	private static int UserInterfaceActionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:UserInterfaceActionType")]
	public EUserInterfaceActionType UserInterfaceActionType;

	private static bool StyleNameOverride_IsValid;

	private static int StyleNameOverride_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:StyleNameOverride")]
	public FName StyleNameOverride;

	private static bool IsSubMenu_IsValid;

	private static FFieldAddress IsSubMenu_PropertyAddress;

	private static int IsSubMenu_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bIsSubMenu")]
	public bool IsSubMenu;

	private static bool OpenSubMenuOnClick_IsValid;

	private static FFieldAddress OpenSubMenuOnClick_PropertyAddress;

	private static int OpenSubMenuOnClick_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bOpenSubMenuOnClick")]
	public bool OpenSubMenuOnClick;

	private static bool ShouldCloseWindowAfterMenuSelection_IsValid;

	private static FFieldAddress ShouldCloseWindowAfterMenuSelection_PropertyAddress;

	private static int ShouldCloseWindowAfterMenuSelection_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bShouldCloseWindowAfterMenuSelection")]
	public bool ShouldCloseWindowAfterMenuSelection;

	private static bool SimpleComboBox_IsValid;

	private static FFieldAddress SimpleComboBox_PropertyAddress;

	private static int SimpleComboBox_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced:bSimpleComboBox")]
	public bool SimpleComboBox;

	private static bool FToolMenuEntryScriptDataAdvanced_IsValid;

	private static int FToolMenuEntryScriptDataAdvanced_StructSize;

	public FToolMenuEntryScriptDataAdvanced Copy()
	{
		return this;
	}

	public static FToolMenuEntryScriptDataAdvanced FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuEntryScriptDataAdvanced(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuEntryScriptDataAdvanced value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuEntryScriptDataAdvanced FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuEntryScriptDataAdvanced(nativeBuffer + arrayIndex * FToolMenuEntryScriptDataAdvanced_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuEntryScriptDataAdvanced value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuEntryScriptDataAdvanced_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuEntryScriptDataAdvanced_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, TutorialHighlight_Offset), TutorialHighlight);
		EnumMarshaler<EMultiBlockType>.ToNative(IntPtr.Add(nativeStruct, EntryType_Offset), 0, EntryType_PropertyAddress.Address, EntryType);
		EnumMarshaler<EUserInterfaceActionType>.ToNative(IntPtr.Add(nativeStruct, UserInterfaceActionType_Offset), 0, UserInterfaceActionType_PropertyAddress.Address, UserInterfaceActionType);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, StyleNameOverride_Offset), StyleNameOverride);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsSubMenu_Offset), 0, IsSubMenu_PropertyAddress.Address, IsSubMenu);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, OpenSubMenuOnClick_Offset), 0, OpenSubMenuOnClick_PropertyAddress.Address, OpenSubMenuOnClick);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address, ShouldCloseWindowAfterMenuSelection);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SimpleComboBox_Offset), 0, SimpleComboBox_PropertyAddress.Address, SimpleComboBox);
	}

	public FToolMenuEntryScriptDataAdvanced(IntPtr nativeStruct)
	{
		if (!FToolMenuEntryScriptDataAdvanced_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced");
			TutorialHighlight = default(FName);
			EntryType = EMultiBlockType.None;
			UserInterfaceActionType = EUserInterfaceActionType.None;
			StyleNameOverride = default(FName);
			IsSubMenu = false;
			OpenSubMenuOnClick = false;
			ShouldCloseWindowAfterMenuSelection = false;
			SimpleComboBox = false;
		}
		else
		{
			TutorialHighlight = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, TutorialHighlight_Offset));
			EntryType = EnumMarshaler<EMultiBlockType>.FromNative(IntPtr.Add(nativeStruct, EntryType_Offset), 0, EntryType_PropertyAddress.Address);
			UserInterfaceActionType = EnumMarshaler<EUserInterfaceActionType>.FromNative(IntPtr.Add(nativeStruct, UserInterfaceActionType_Offset), 0, UserInterfaceActionType_PropertyAddress.Address);
			StyleNameOverride = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, StyleNameOverride_Offset));
			IsSubMenu = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsSubMenu_Offset), 0, IsSubMenu_PropertyAddress.Address);
			OpenSubMenuOnClick = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, OpenSubMenuOnClick_Offset), 0, OpenSubMenuOnClick_PropertyAddress.Address);
			ShouldCloseWindowAfterMenuSelection = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, ShouldCloseWindowAfterMenuSelection_Offset), 0, ShouldCloseWindowAfterMenuSelection_PropertyAddress.Address);
			SimpleComboBox = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SimpleComboBox_Offset), 0, SimpleComboBox_PropertyAddress.Address);
		}
	}

	static FToolMenuEntryScriptDataAdvanced()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuEntryScriptDataAdvanced)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuEntryScriptDataAdvanced));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced");
		FToolMenuEntryScriptDataAdvanced_StructSize = NativeReflection.GetStructSize(intPtr);
		TutorialHighlight_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TutorialHighlight");
		TutorialHighlight_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TutorialHighlight", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref EntryType_PropertyAddress, intPtr, "EntryType");
		EntryType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "EntryType");
		EntryType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "EntryType", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref UserInterfaceActionType_PropertyAddress, intPtr, "UserInterfaceActionType");
		UserInterfaceActionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UserInterfaceActionType");
		UserInterfaceActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UserInterfaceActionType", Classes.FEnumProperty);
		StyleNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StyleNameOverride");
		StyleNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StyleNameOverride", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSubMenu_PropertyAddress, intPtr, "bIsSubMenu");
		IsSubMenu_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSubMenu");
		IsSubMenu_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSubMenu", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref OpenSubMenuOnClick_PropertyAddress, intPtr, "bOpenSubMenuOnClick");
		OpenSubMenuOnClick_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOpenSubMenuOnClick");
		OpenSubMenuOnClick_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOpenSubMenuOnClick", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldCloseWindowAfterMenuSelection_PropertyAddress, intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldCloseWindowAfterMenuSelection");
		ShouldCloseWindowAfterMenuSelection_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldCloseWindowAfterMenuSelection", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimpleComboBox_PropertyAddress, intPtr, "bSimpleComboBox");
		SimpleComboBox_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimpleComboBox");
		SimpleComboBox_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimpleComboBox", Classes.FBoolProperty);
		FToolMenuEntryScriptDataAdvanced_IsValid = intPtr != IntPtr.Zero && TutorialHighlight_IsValid && EntryType_IsValid && UserInterfaceActionType_IsValid && StyleNameOverride_IsValid && IsSubMenu_IsValid && OpenSubMenuOnClick_IsValid && ShouldCloseWindowAfterMenuSelection_IsValid && SimpleComboBox_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuEntryScriptDataAdvanced", FToolMenuEntryScriptDataAdvanced_IsValid);
	}
}
