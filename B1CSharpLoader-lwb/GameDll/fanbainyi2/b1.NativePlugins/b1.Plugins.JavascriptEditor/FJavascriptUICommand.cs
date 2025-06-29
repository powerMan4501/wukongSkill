using System;
using b1.Plugins.JavascriptUMG;
using UnrealEngine.Runtime;
using UnrealEngine.Slate;

namespace b1.Plugins.JavascriptEditor;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand", "JavascriptEditor", UnrealModuleType.GamePlugin)]
public struct FJavascriptUICommand
{
	private static bool Id_IsValid;

	private static int Id_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:Id")]
	public string Id;

	private static bool FriendlyName_IsValid;

	private static int FriendlyName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:FriendlyName")]
	public string FriendlyName;

	private static bool Description_IsValid;

	private static int Description_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:Description")]
	public string Description;

	private static bool DefaultChord_IsValid;

	private static int DefaultChord_Offset;

	[UProperty(Flags = (PropFlags)6755399441055748uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:DefaultChord")]
	public FInputChord DefaultChord;

	private static bool ActionType_IsValid;

	private static FFieldAddress ActionType_PropertyAddress;

	private static int ActionType_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:ActionType")]
	public EJavasrciptUserInterfaceActionType ActionType;

	private static bool CommandInfo_IsValid;

	private static int CommandInfo_Offset;

	[UProperty(Flags = (PropFlags)4503599627370500uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:CommandInfo")]
	public FJavascriptUICommandInfo CommandInfo;

	private static bool IconStyleName_IsValid;

	private static int IconStyleName_Offset;

	[UProperty(Flags = (PropFlags)6755399441056260uL)]
	[UMetaPath("/Script/JavascriptEditor.JavascriptUICommand:IconStyleName")]
	public string IconStyleName;

	private static bool FJavascriptUICommand_IsValid;

	private static int FJavascriptUICommand_StructSize;

	public FJavascriptUICommand Copy()
	{
		return this;
	}

	public static FJavascriptUICommand FromNative(IntPtr nativeBuffer)
	{
		return new FJavascriptUICommand(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FJavascriptUICommand value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FJavascriptUICommand FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FJavascriptUICommand(nativeBuffer + arrayIndex * FJavascriptUICommand_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FJavascriptUICommand value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FJavascriptUICommand_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommand");
			return;
		}
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Id_Offset), Id);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, FriendlyName_Offset), FriendlyName);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, Description_Offset), Description);
		FInputChord.ToNative(IntPtr.Add(nativeStruct, DefaultChord_Offset), DefaultChord);
		EnumMarshaler<EJavasrciptUserInterfaceActionType>.ToNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address, ActionType);
		FJavascriptUICommandInfo.ToNative(IntPtr.Add(nativeStruct, CommandInfo_Offset), CommandInfo);
		FStringMarshaler.ToNative(IntPtr.Add(nativeStruct, IconStyleName_Offset), IconStyleName);
	}

	public FJavascriptUICommand(IntPtr nativeStruct)
	{
		if (!FJavascriptUICommand_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/JavascriptEditor.JavascriptUICommand");
			Id = FStringMarshaler.DefaultString;
			FriendlyName = FStringMarshaler.DefaultString;
			Description = FStringMarshaler.DefaultString;
			DefaultChord = default(FInputChord);
			ActionType = EJavasrciptUserInterfaceActionType.None;
			CommandInfo = default(FJavascriptUICommandInfo);
			IconStyleName = FStringMarshaler.DefaultString;
		}
		else
		{
			Id = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Id_Offset));
			FriendlyName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, FriendlyName_Offset));
			Description = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, Description_Offset));
			DefaultChord = FInputChord.FromNative(IntPtr.Add(nativeStruct, DefaultChord_Offset));
			ActionType = EnumMarshaler<EJavasrciptUserInterfaceActionType>.FromNative(IntPtr.Add(nativeStruct, ActionType_Offset), 0, ActionType_PropertyAddress.Address);
			CommandInfo = FJavascriptUICommandInfo.FromNative(IntPtr.Add(nativeStruct, CommandInfo_Offset));
			IconStyleName = FStringMarshaler.FromNative(IntPtr.Add(nativeStruct, IconStyleName_Offset));
		}
	}

	static FJavascriptUICommand()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FJavascriptUICommand)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FJavascriptUICommand));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/JavascriptEditor.JavascriptUICommand");
		FJavascriptUICommand_StructSize = NativeReflection.GetStructSize(intPtr);
		Id_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Id");
		Id_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Id", Classes.FStrProperty);
		FriendlyName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FriendlyName");
		FriendlyName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FriendlyName", Classes.FStrProperty);
		Description_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Description");
		Description_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Description", Classes.FStrProperty);
		DefaultChord_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DefaultChord");
		DefaultChord_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DefaultChord", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ActionType_PropertyAddress, intPtr, "ActionType");
		ActionType_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ActionType");
		ActionType_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ActionType", Classes.FByteProperty);
		CommandInfo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "CommandInfo");
		CommandInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "CommandInfo", Classes.FStructProperty);
		IconStyleName_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "IconStyleName");
		IconStyleName_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "IconStyleName", Classes.FStrProperty);
		FJavascriptUICommand_IsValid = intPtr != IntPtr.Zero && Id_IsValid && FriendlyName_IsValid && Description_IsValid && DefaultChord_IsValid && ActionType_IsValid && CommandInfo_IsValid && IconStyleName_IsValid;
		NativeReflection.LogStructIsValid("/Script/JavascriptEditor.JavascriptUICommand", FJavascriptUICommand_IsValid);
	}
}
