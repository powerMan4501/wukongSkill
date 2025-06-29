using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.ToolMenus;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData", "ToolMenus", UnrealModuleType.Engine)]
public struct FToolMenuEntryScriptData
{
	private static bool Menu_IsValid;

	private static int Menu_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Menu")]
	public FName Menu;

	private static bool Section_IsValid;

	private static int Section_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Section")]
	public FName Section;

	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Name")]
	public FName Name;

	private static bool Label_IsValid;

	private static int Label_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Label")]
	public FText Label;

	private static bool ToolTip_IsValid;

	private static int ToolTip_Offset;

	[UProperty(Flags = (PropFlags)4503599627370501uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:ToolTip")]
	public FText ToolTip;

	private static bool Icon_IsValid;

	private static int Icon_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Icon")]
	public FScriptSlateIcon Icon;

	private static bool OwnerName_IsValid;

	private static int OwnerName_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:OwnerName")]
	public FName OwnerName;

	private static bool InsertPosition_IsValid;

	private static int InsertPosition_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:InsertPosition")]
	public FToolMenuInsert InsertPosition;

	private static bool Advanced_IsValid;

	private static int Advanced_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/ToolMenus.ToolMenuEntryScriptData:Advanced")]
	public FToolMenuEntryScriptDataAdvanced Advanced;

	private static bool FToolMenuEntryScriptData_IsValid;

	private static int FToolMenuEntryScriptData_StructSize;

	public FToolMenuEntryScriptData Copy()
	{
		return this;
	}

	public static FToolMenuEntryScriptData FromNative(IntPtr nativeBuffer)
	{
		return new FToolMenuEntryScriptData(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FToolMenuEntryScriptData value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FToolMenuEntryScriptData FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FToolMenuEntryScriptData(nativeBuffer + arrayIndex * FToolMenuEntryScriptData_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FToolMenuEntryScriptData value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FToolMenuEntryScriptData_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FToolMenuEntryScriptData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntryScriptData");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Menu_Offset), Menu);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Section_Offset), Section);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, Label_Offset), Label);
		FTextMarshaler.ToNative(IntPtr.Add(nativeStruct, ToolTip_Offset), ToolTip);
		FScriptSlateIcon.ToNative(IntPtr.Add(nativeStruct, Icon_Offset), Icon);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, OwnerName_Offset), OwnerName);
		FToolMenuInsert.ToNative(IntPtr.Add(nativeStruct, InsertPosition_Offset), InsertPosition);
		FToolMenuEntryScriptDataAdvanced.ToNative(IntPtr.Add(nativeStruct, Advanced_Offset), Advanced);
	}

	public FToolMenuEntryScriptData(IntPtr nativeStruct)
	{
		if (!FToolMenuEntryScriptData_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/ToolMenus.ToolMenuEntryScriptData");
			Menu = default(FName);
			Section = default(FName);
			Name = default(FName);
			Label = null;
			ToolTip = null;
			Icon = default(FScriptSlateIcon);
			OwnerName = default(FName);
			InsertPosition = default(FToolMenuInsert);
			Advanced = default(FToolMenuEntryScriptDataAdvanced);
		}
		else
		{
			Menu = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Menu_Offset));
			Section = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Section_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Label = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, Label_Offset));
			ToolTip = FTextMarshaler.FromNative(IntPtr.Add(nativeStruct, ToolTip_Offset));
			Icon = FScriptSlateIcon.FromNative(IntPtr.Add(nativeStruct, Icon_Offset));
			OwnerName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, OwnerName_Offset));
			InsertPosition = FToolMenuInsert.FromNative(IntPtr.Add(nativeStruct, InsertPosition_Offset));
			Advanced = FToolMenuEntryScriptDataAdvanced.FromNative(IntPtr.Add(nativeStruct, Advanced_Offset));
		}
	}

	static FToolMenuEntryScriptData()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FToolMenuEntryScriptData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FToolMenuEntryScriptData));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/ToolMenus.ToolMenuEntryScriptData");
		FToolMenuEntryScriptData_StructSize = NativeReflection.GetStructSize(intPtr);
		Menu_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Menu");
		Menu_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Menu", Classes.FNameProperty);
		Section_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Section");
		Section_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Section", Classes.FNameProperty);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		Label_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Label");
		Label_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Label", Classes.FTextProperty);
		ToolTip_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToolTip");
		ToolTip_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToolTip", Classes.FTextProperty);
		Icon_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Icon");
		Icon_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Icon", Classes.FStructProperty);
		OwnerName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OwnerName");
		OwnerName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OwnerName", Classes.FNameProperty);
		InsertPosition_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InsertPosition");
		InsertPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InsertPosition", Classes.FStructProperty);
		Advanced_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Advanced");
		Advanced_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Advanced", Classes.FStructProperty);
		FToolMenuEntryScriptData_IsValid = intPtr != IntPtr.Zero && Menu_IsValid && Section_IsValid && Name_IsValid && Label_IsValid && ToolTip_IsValid && Icon_IsValid && OwnerName_IsValid && InsertPosition_IsValid && Advanced_IsValid;
		NativeReflection.LogStructIsValid("/Script/ToolMenus.ToolMenuEntryScriptData", FToolMenuEntryScriptData_IsValid);
	}
}
