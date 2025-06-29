using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EditorScriptingUtilities;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibrary", "EditorScriptingUtilities", UnrealModuleType.EnginePlugin)]
public class UEditorDialog : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ShowSuppressableWarningDialog_IsValid;

	private static IntPtr ShowSuppressableWarningDialog_FunctionAddress;

	private static int ShowSuppressableWarningDialog_ParamsSize;

	private static bool ShowSuppressableWarningDialog_Title_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_Title_PropertyAddress;

	private static int ShowSuppressableWarningDialog_Title_Offset;

	private static bool ShowSuppressableWarningDialog_Message_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_Message_PropertyAddress;

	private static int ShowSuppressableWarningDialog_Message_Offset;

	private static bool ShowSuppressableWarningDialog_InIniSettingName_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_InIniSettingName_PropertyAddress;

	private static int ShowSuppressableWarningDialog_InIniSettingName_Offset;

	private static bool ShowSuppressableWarningDialog_InIniSettingFileNameOverride_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_InIniSettingFileNameOverride_PropertyAddress;

	private static int ShowSuppressableWarningDialog_InIniSettingFileNameOverride_Offset;

	private static bool ShowSuppressableWarningDialog_bDefaultValue_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_bDefaultValue_PropertyAddress;

	private static int ShowSuppressableWarningDialog_bDefaultValue_Offset;

	private static bool ShowSuppressableWarningDialog_ReturnValue_IsValid;

	private static FFieldAddress ShowSuppressableWarningDialog_ReturnValue_PropertyAddress;

	private static int ShowSuppressableWarningDialog_ReturnValue_Offset;

	private static bool ShowObjectsDetailsView_IsValid;

	private static IntPtr ShowObjectsDetailsView_FunctionAddress;

	private static int ShowObjectsDetailsView_ParamsSize;

	private static bool ShowObjectsDetailsView_Title_IsValid;

	private static FFieldAddress ShowObjectsDetailsView_Title_PropertyAddress;

	private static int ShowObjectsDetailsView_Title_Offset;

	private static bool ShowObjectsDetailsView_InOutObjects_IsValid;

	private static FFieldAddress ShowObjectsDetailsView_InOutObjects_PropertyAddress;

	private static int ShowObjectsDetailsView_InOutObjects_Offset;

	private static bool ShowObjectsDetailsView_Options_IsValid;

	private static FFieldAddress ShowObjectsDetailsView_Options_PropertyAddress;

	private static int ShowObjectsDetailsView_Options_Offset;

	private static bool ShowObjectsDetailsView_ReturnValue_IsValid;

	private static FFieldAddress ShowObjectsDetailsView_ReturnValue_PropertyAddress;

	private static int ShowObjectsDetailsView_ReturnValue_Offset;

	private static bool ShowObjectDetailsView_IsValid;

	private static IntPtr ShowObjectDetailsView_FunctionAddress;

	private static int ShowObjectDetailsView_ParamsSize;

	private static bool ShowObjectDetailsView_Title_IsValid;

	private static FFieldAddress ShowObjectDetailsView_Title_PropertyAddress;

	private static int ShowObjectDetailsView_Title_Offset;

	private static bool ShowObjectDetailsView_InOutObject_IsValid;

	private static FFieldAddress ShowObjectDetailsView_InOutObject_PropertyAddress;

	private static int ShowObjectDetailsView_InOutObject_Offset;

	private static bool ShowObjectDetailsView_Options_IsValid;

	private static FFieldAddress ShowObjectDetailsView_Options_PropertyAddress;

	private static int ShowObjectDetailsView_Options_Offset;

	private static bool ShowObjectDetailsView_ReturnValue_IsValid;

	private static FFieldAddress ShowObjectDetailsView_ReturnValue_PropertyAddress;

	private static int ShowObjectDetailsView_ReturnValue_Offset;

	private static bool ShowMessage_IsValid;

	private static IntPtr ShowMessage_FunctionAddress;

	private static int ShowMessage_ParamsSize;

	private static bool ShowMessage_Title_IsValid;

	private static FFieldAddress ShowMessage_Title_PropertyAddress;

	private static int ShowMessage_Title_Offset;

	private static bool ShowMessage_Message_IsValid;

	private static FFieldAddress ShowMessage_Message_PropertyAddress;

	private static int ShowMessage_Message_Offset;

	private static bool ShowMessage_MessageType_IsValid;

	private static FFieldAddress ShowMessage_MessageType_PropertyAddress;

	private static int ShowMessage_MessageType_Offset;

	private static bool ShowMessage_DefaultValue_IsValid;

	private static FFieldAddress ShowMessage_DefaultValue_PropertyAddress;

	private static int ShowMessage_DefaultValue_Offset;

	private static bool ShowMessage_ReturnValue_IsValid;

	private static FFieldAddress ShowMessage_ReturnValue_PropertyAddress;

	private static int ShowMessage_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowSuppressableWarningDialog")]
	public unsafe static bool ShowSuppressableWarningDialog(FText Title, FText Message, string InIniSettingName, string InIniSettingFileNameOverride, bool bDefaultValue = true)
	{
		if (!ShowSuppressableWarningDialog_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowSuppressableWarningDialog");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowSuppressableWarningDialog_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowSuppressableWarningDialog_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ShowSuppressableWarningDialog_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_Title_Offset), 0, ShowSuppressableWarningDialog_Title_PropertyAddress.Address, Title);
		NativeReflection.InitializeValue_InContainer(ShowSuppressableWarningDialog_Message_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_Message_Offset), 0, ShowSuppressableWarningDialog_Message_PropertyAddress.Address, Message);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_InIniSettingName_Offset), 0, ShowSuppressableWarningDialog_InIniSettingName_PropertyAddress.Address, InIniSettingName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_InIniSettingFileNameOverride_Offset), 0, ShowSuppressableWarningDialog_InIniSettingFileNameOverride_PropertyAddress.Address, InIniSettingFileNameOverride);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_bDefaultValue_Offset), 0, ShowSuppressableWarningDialog_bDefaultValue_PropertyAddress.Address, bDefaultValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowSuppressableWarningDialog_FunctionAddress, intPtr, ShowSuppressableWarningDialog_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowSuppressableWarningDialog_Title_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ShowSuppressableWarningDialog_Message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ShowSuppressableWarningDialog_InIniSettingName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ShowSuppressableWarningDialog_InIniSettingFileNameOverride_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShowSuppressableWarningDialog_ReturnValue_Offset), 0, ShowSuppressableWarningDialog_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectsDetailsView")]
	public unsafe static bool ShowObjectsDetailsView(FText Title, List<UObject> InOutObjects, FEditorDialogLibraryObjectDetailsViewOptions Options)
	{
		if (!ShowObjectsDetailsView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectsDetailsView");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowObjectsDetailsView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowObjectsDetailsView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ShowObjectsDetailsView_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowObjectsDetailsView_Title_Offset), 0, ShowObjectsDetailsView_Title_PropertyAddress.Address, Title);
		new TArrayCopyMarshaler<UObject>(1, ShowObjectsDetailsView_InOutObjects_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).ToNative(IntPtr.Add(intPtr, ShowObjectsDetailsView_InOutObjects_Offset), InOutObjects);
		NativeReflection.InitializeValue_InContainer(ShowObjectsDetailsView_Options_PropertyAddress.Address, intPtr);
		FEditorDialogLibraryObjectDetailsViewOptions.ToNative(IntPtr.Add(intPtr, ShowObjectsDetailsView_Options_Offset), 0, ShowObjectsDetailsView_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowObjectsDetailsView_FunctionAddress, intPtr, ShowObjectsDetailsView_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowObjectsDetailsView_Title_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ShowObjectsDetailsView_InOutObjects_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShowObjectsDetailsView_ReturnValue_Offset), 0, ShowObjectsDetailsView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectDetailsView")]
	public unsafe static bool ShowObjectDetailsView(FText Title, UObject InOutObject, FEditorDialogLibraryObjectDetailsViewOptions Options)
	{
		if (!ShowObjectDetailsView_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectDetailsView");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowObjectDetailsView_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowObjectDetailsView_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ShowObjectDetailsView_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowObjectDetailsView_Title_Offset), 0, ShowObjectDetailsView_Title_PropertyAddress.Address, Title);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, ShowObjectDetailsView_InOutObject_Offset), 0, ShowObjectDetailsView_InOutObject_PropertyAddress.Address, InOutObject);
		NativeReflection.InitializeValue_InContainer(ShowObjectDetailsView_Options_PropertyAddress.Address, intPtr);
		FEditorDialogLibraryObjectDetailsViewOptions.ToNative(IntPtr.Add(intPtr, ShowObjectDetailsView_Options_Offset), 0, ShowObjectDetailsView_Options_PropertyAddress.Address, Options);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowObjectDetailsView_FunctionAddress, intPtr, ShowObjectDetailsView_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowObjectDetailsView_Title_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ShowObjectDetailsView_ReturnValue_Offset), 0, ShowObjectDetailsView_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowMessage")]
	public unsafe static EAppReturnType ShowMessage(FText Title, FText Message, EAppMsgType MessageType, EAppReturnType DefaultValue = EAppReturnType.No)
	{
		if (!ShowMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowMessage");
			return EAppReturnType.No;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ShowMessage_Title_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowMessage_Title_Offset), 0, ShowMessage_Title_PropertyAddress.Address, Title);
		NativeReflection.InitializeValue_InContainer(ShowMessage_Message_PropertyAddress.Address, intPtr);
		FTextMarshaler.ToNative(IntPtr.Add(intPtr, ShowMessage_Message_Offset), 0, ShowMessage_Message_PropertyAddress.Address, Message);
		EnumMarshaler<EAppMsgType>.ToNative(IntPtr.Add(intPtr, ShowMessage_MessageType_Offset), 0, ShowMessage_MessageType_PropertyAddress.Address, MessageType);
		EnumMarshaler<EAppReturnType>.ToNative(IntPtr.Add(intPtr, ShowMessage_DefaultValue_Offset), 0, ShowMessage_DefaultValue_PropertyAddress.Address, DefaultValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowMessage_FunctionAddress, intPtr, ShowMessage_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ShowMessage_Title_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(ShowMessage_Message_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EAppReturnType>.FromNative(IntPtr.Add(intPtr, ShowMessage_ReturnValue_Offset), 0, ShowMessage_ReturnValue_PropertyAddress.Address);
	}

	static UEditorDialog()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UEditorDialog)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UEditorDialog));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/EditorScriptingUtilities.EditorDialogLibrary");
		ShowSuppressableWarningDialog_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowSuppressableWarningDialog");
		ShowSuppressableWarningDialog_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowSuppressableWarningDialog_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_Title_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "Title");
		ShowSuppressableWarningDialog_Title_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "Title");
		ShowSuppressableWarningDialog_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_Message_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "Message");
		ShowSuppressableWarningDialog_Message_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "Message");
		ShowSuppressableWarningDialog_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "Message", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_InIniSettingName_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingName");
		ShowSuppressableWarningDialog_InIniSettingName_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingName");
		ShowSuppressableWarningDialog_InIniSettingName_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_InIniSettingFileNameOverride_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingFileNameOverride");
		ShowSuppressableWarningDialog_InIniSettingFileNameOverride_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingFileNameOverride");
		ShowSuppressableWarningDialog_InIniSettingFileNameOverride_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "InIniSettingFileNameOverride", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_bDefaultValue_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "bDefaultValue");
		ShowSuppressableWarningDialog_bDefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "bDefaultValue");
		ShowSuppressableWarningDialog_bDefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "bDefaultValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowSuppressableWarningDialog_ReturnValue_PropertyAddress, ShowSuppressableWarningDialog_FunctionAddress, "ReturnValue");
		ShowSuppressableWarningDialog_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowSuppressableWarningDialog_FunctionAddress, "ReturnValue");
		ShowSuppressableWarningDialog_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowSuppressableWarningDialog_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShowSuppressableWarningDialog_IsValid = ShowSuppressableWarningDialog_FunctionAddress != IntPtr.Zero && ShowSuppressableWarningDialog_Title_IsValid && ShowSuppressableWarningDialog_Message_IsValid && ShowSuppressableWarningDialog_InIniSettingName_IsValid && ShowSuppressableWarningDialog_InIniSettingFileNameOverride_IsValid && ShowSuppressableWarningDialog_bDefaultValue_IsValid && ShowSuppressableWarningDialog_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowSuppressableWarningDialog", ShowSuppressableWarningDialog_IsValid);
		ShowObjectsDetailsView_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowObjectsDetailsView");
		ShowObjectsDetailsView_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowObjectsDetailsView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectsDetailsView_Title_PropertyAddress, ShowObjectsDetailsView_FunctionAddress, "Title");
		ShowObjectsDetailsView_Title_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectsDetailsView_FunctionAddress, "Title");
		ShowObjectsDetailsView_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectsDetailsView_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectsDetailsView_InOutObjects_PropertyAddress, ShowObjectsDetailsView_FunctionAddress, "InOutObjects");
		ShowObjectsDetailsView_InOutObjects_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectsDetailsView_FunctionAddress, "InOutObjects");
		ShowObjectsDetailsView_InOutObjects_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectsDetailsView_FunctionAddress, "InOutObjects", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectsDetailsView_Options_PropertyAddress, ShowObjectsDetailsView_FunctionAddress, "Options");
		ShowObjectsDetailsView_Options_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectsDetailsView_FunctionAddress, "Options");
		ShowObjectsDetailsView_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectsDetailsView_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectsDetailsView_ReturnValue_PropertyAddress, ShowObjectsDetailsView_FunctionAddress, "ReturnValue");
		ShowObjectsDetailsView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectsDetailsView_FunctionAddress, "ReturnValue");
		ShowObjectsDetailsView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectsDetailsView_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShowObjectsDetailsView_IsValid = ShowObjectsDetailsView_FunctionAddress != IntPtr.Zero && ShowObjectsDetailsView_Title_IsValid && ShowObjectsDetailsView_InOutObjects_IsValid && ShowObjectsDetailsView_Options_IsValid && ShowObjectsDetailsView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectsDetailsView", ShowObjectsDetailsView_IsValid);
		ShowObjectDetailsView_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowObjectDetailsView");
		ShowObjectDetailsView_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowObjectDetailsView_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectDetailsView_Title_PropertyAddress, ShowObjectDetailsView_FunctionAddress, "Title");
		ShowObjectDetailsView_Title_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectDetailsView_FunctionAddress, "Title");
		ShowObjectDetailsView_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectDetailsView_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectDetailsView_InOutObject_PropertyAddress, ShowObjectDetailsView_FunctionAddress, "InOutObject");
		ShowObjectDetailsView_InOutObject_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectDetailsView_FunctionAddress, "InOutObject");
		ShowObjectDetailsView_InOutObject_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectDetailsView_FunctionAddress, "InOutObject", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectDetailsView_Options_PropertyAddress, ShowObjectDetailsView_FunctionAddress, "Options");
		ShowObjectDetailsView_Options_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectDetailsView_FunctionAddress, "Options");
		ShowObjectDetailsView_Options_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectDetailsView_FunctionAddress, "Options", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowObjectDetailsView_ReturnValue_PropertyAddress, ShowObjectDetailsView_FunctionAddress, "ReturnValue");
		ShowObjectDetailsView_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowObjectDetailsView_FunctionAddress, "ReturnValue");
		ShowObjectDetailsView_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowObjectDetailsView_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShowObjectDetailsView_IsValid = ShowObjectDetailsView_FunctionAddress != IntPtr.Zero && ShowObjectDetailsView_Title_IsValid && ShowObjectDetailsView_InOutObject_IsValid && ShowObjectDetailsView_Options_IsValid && ShowObjectDetailsView_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowObjectDetailsView", ShowObjectDetailsView_IsValid);
		ShowMessage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowMessage");
		ShowMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowMessage_Title_PropertyAddress, ShowMessage_FunctionAddress, "Title");
		ShowMessage_Title_Offset = NativeReflectionCached.GetPropertyOffset(ShowMessage_FunctionAddress, "Title");
		ShowMessage_Title_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMessage_FunctionAddress, "Title", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMessage_Message_PropertyAddress, ShowMessage_FunctionAddress, "Message");
		ShowMessage_Message_Offset = NativeReflectionCached.GetPropertyOffset(ShowMessage_FunctionAddress, "Message");
		ShowMessage_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMessage_FunctionAddress, "Message", Classes.FTextProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMessage_MessageType_PropertyAddress, ShowMessage_FunctionAddress, "MessageType");
		ShowMessage_MessageType_Offset = NativeReflectionCached.GetPropertyOffset(ShowMessage_FunctionAddress, "MessageType");
		ShowMessage_MessageType_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMessage_FunctionAddress, "MessageType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMessage_DefaultValue_PropertyAddress, ShowMessage_FunctionAddress, "DefaultValue");
		ShowMessage_DefaultValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowMessage_FunctionAddress, "DefaultValue");
		ShowMessage_DefaultValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMessage_FunctionAddress, "DefaultValue", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref ShowMessage_ReturnValue_PropertyAddress, ShowMessage_FunctionAddress, "ReturnValue");
		ShowMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowMessage_FunctionAddress, "ReturnValue");
		ShowMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowMessage_FunctionAddress, "ReturnValue", Classes.FByteProperty);
		ShowMessage_IsValid = ShowMessage_FunctionAddress != IntPtr.Zero && ShowMessage_Title_IsValid && ShowMessage_Message_IsValid && ShowMessage_MessageType_IsValid && ShowMessage_DefaultValue_IsValid && ShowMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/EditorScriptingUtilities.EditorDialogLibrary:ShowMessage", ShowMessage_IsValid);
	}
}
