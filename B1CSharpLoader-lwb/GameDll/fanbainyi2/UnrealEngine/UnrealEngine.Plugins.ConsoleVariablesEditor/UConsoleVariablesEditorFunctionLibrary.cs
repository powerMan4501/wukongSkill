using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.ConsoleVariablesEditor;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary", "ConsoleVariablesEditor", UnrealModuleType.EnginePlugin)]
public class UConsoleVariablesEditorFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetEnableMultiUserCVarSync_IsValid;

	private static IntPtr SetEnableMultiUserCVarSync_FunctionAddress;

	private static int SetEnableMultiUserCVarSync_ParamsSize;

	private static bool SetEnableMultiUserCVarSync_bNewSetting_IsValid;

	private static FFieldAddress SetEnableMultiUserCVarSync_bNewSetting_PropertyAddress;

	private static int SetEnableMultiUserCVarSync_bNewSetting_Offset;

	private static bool SetConsoleVariableByName_String_IsValid;

	private static IntPtr SetConsoleVariableByName_String_FunctionAddress;

	private static int SetConsoleVariableByName_String_ParamsSize;

	private static bool SetConsoleVariableByName_String_InCommandName_IsValid;

	private static FFieldAddress SetConsoleVariableByName_String_InCommandName_PropertyAddress;

	private static int SetConsoleVariableByName_String_InCommandName_Offset;

	private static bool SetConsoleVariableByName_String_InValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_String_InValue_PropertyAddress;

	private static int SetConsoleVariableByName_String_InValue_Offset;

	private static bool SetConsoleVariableByName_String_ReturnValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_String_ReturnValue_PropertyAddress;

	private static int SetConsoleVariableByName_String_ReturnValue_Offset;

	private static bool SetConsoleVariableByName_Int_IsValid;

	private static IntPtr SetConsoleVariableByName_Int_FunctionAddress;

	private static int SetConsoleVariableByName_Int_ParamsSize;

	private static bool SetConsoleVariableByName_Int_InCommandName_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Int_InCommandName_PropertyAddress;

	private static int SetConsoleVariableByName_Int_InCommandName_Offset;

	private static bool SetConsoleVariableByName_Int_InValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Int_InValue_PropertyAddress;

	private static int SetConsoleVariableByName_Int_InValue_Offset;

	private static bool SetConsoleVariableByName_Int_ReturnValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Int_ReturnValue_PropertyAddress;

	private static int SetConsoleVariableByName_Int_ReturnValue_Offset;

	private static bool SetConsoleVariableByName_Float_IsValid;

	private static IntPtr SetConsoleVariableByName_Float_FunctionAddress;

	private static int SetConsoleVariableByName_Float_ParamsSize;

	private static bool SetConsoleVariableByName_Float_InCommandName_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Float_InCommandName_PropertyAddress;

	private static int SetConsoleVariableByName_Float_InCommandName_Offset;

	private static bool SetConsoleVariableByName_Float_InValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Float_InValue_PropertyAddress;

	private static int SetConsoleVariableByName_Float_InValue_Offset;

	private static bool SetConsoleVariableByName_Float_ReturnValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Float_ReturnValue_PropertyAddress;

	private static int SetConsoleVariableByName_Float_ReturnValue_Offset;

	private static bool SetConsoleVariableByName_Bool_IsValid;

	private static IntPtr SetConsoleVariableByName_Bool_FunctionAddress;

	private static int SetConsoleVariableByName_Bool_ParamsSize;

	private static bool SetConsoleVariableByName_Bool_InCommandName_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Bool_InCommandName_PropertyAddress;

	private static int SetConsoleVariableByName_Bool_InCommandName_Offset;

	private static bool SetConsoleVariableByName_Bool_InValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Bool_InValue_PropertyAddress;

	private static int SetConsoleVariableByName_Bool_InValue_Offset;

	private static bool SetConsoleVariableByName_Bool_ReturnValue_IsValid;

	private static FFieldAddress SetConsoleVariableByName_Bool_ReturnValue_PropertyAddress;

	private static int SetConsoleVariableByName_Bool_ReturnValue_Offset;

	private static bool RemoveCommandFromCurrentPreset_IsValid;

	private static IntPtr RemoveCommandFromCurrentPreset_FunctionAddress;

	private static int RemoveCommandFromCurrentPreset_ParamsSize;

	private static bool RemoveCommandFromCurrentPreset_NewCommand_IsValid;

	private static FFieldAddress RemoveCommandFromCurrentPreset_NewCommand_PropertyAddress;

	private static int RemoveCommandFromCurrentPreset_NewCommand_Offset;

	private static bool RemoveCommandFromCurrentPreset_ReturnValue_IsValid;

	private static FFieldAddress RemoveCommandFromCurrentPreset_ReturnValue_PropertyAddress;

	private static int RemoveCommandFromCurrentPreset_ReturnValue_Offset;

	private static bool LoadPresetIntoConsoleVariablesEditor_IsValid;

	private static IntPtr LoadPresetIntoConsoleVariablesEditor_FunctionAddress;

	private static int LoadPresetIntoConsoleVariablesEditor_ParamsSize;

	private static bool LoadPresetIntoConsoleVariablesEditor_InAsset_IsValid;

	private static FFieldAddress LoadPresetIntoConsoleVariablesEditor_InAsset_PropertyAddress;

	private static int LoadPresetIntoConsoleVariablesEditor_InAsset_Offset;

	private static bool GetListOfCommandsFromPreset_IsValid;

	private static IntPtr GetListOfCommandsFromPreset_FunctionAddress;

	private static int GetListOfCommandsFromPreset_ParamsSize;

	private static bool GetListOfCommandsFromPreset_InAsset_IsValid;

	private static FFieldAddress GetListOfCommandsFromPreset_InAsset_PropertyAddress;

	private static int GetListOfCommandsFromPreset_InAsset_Offset;

	private static bool GetListOfCommandsFromPreset_OutCommandList_IsValid;

	private static FFieldAddress GetListOfCommandsFromPreset_OutCommandList_PropertyAddress;

	private static int GetListOfCommandsFromPreset_OutCommandList_Offset;

	private static bool GetListOfCommandsFromPreset_ReturnValue_IsValid;

	private static FFieldAddress GetListOfCommandsFromPreset_ReturnValue_PropertyAddress;

	private static int GetListOfCommandsFromPreset_ReturnValue_Offset;

	private static bool GetEnableMultiUserCVarSync_IsValid;

	private static IntPtr GetEnableMultiUserCVarSync_FunctionAddress;

	private static int GetEnableMultiUserCVarSync_ParamsSize;

	private static bool GetEnableMultiUserCVarSync_ReturnValue_IsValid;

	private static FFieldAddress GetEnableMultiUserCVarSync_ReturnValue_PropertyAddress;

	private static int GetEnableMultiUserCVarSync_ReturnValue_Offset;

	private static bool GetCurrentlyLoadedPreset_IsValid;

	private static IntPtr GetCurrentlyLoadedPreset_FunctionAddress;

	private static int GetCurrentlyLoadedPreset_ParamsSize;

	private static bool GetCurrentlyLoadedPreset_ReturnValue_IsValid;

	private static FFieldAddress GetCurrentlyLoadedPreset_ReturnValue_PropertyAddress;

	private static int GetCurrentlyLoadedPreset_ReturnValue_Offset;

	private static bool GetConsoleVariableStringValue_IsValid;

	private static IntPtr GetConsoleVariableStringValue_FunctionAddress;

	private static int GetConsoleVariableStringValue_ParamsSize;

	private static bool GetConsoleVariableStringValue_InCommandName_IsValid;

	private static FFieldAddress GetConsoleVariableStringValue_InCommandName_PropertyAddress;

	private static int GetConsoleVariableStringValue_InCommandName_Offset;

	private static bool GetConsoleVariableStringValue_OutValue_IsValid;

	private static FFieldAddress GetConsoleVariableStringValue_OutValue_PropertyAddress;

	private static int GetConsoleVariableStringValue_OutValue_Offset;

	private static bool GetConsoleVariableStringValue_ReturnValue_IsValid;

	private static FFieldAddress GetConsoleVariableStringValue_ReturnValue_PropertyAddress;

	private static int GetConsoleVariableStringValue_ReturnValue_Offset;

	private static bool GetConsoleVariableSourceByName_IsValid;

	private static IntPtr GetConsoleVariableSourceByName_FunctionAddress;

	private static int GetConsoleVariableSourceByName_ParamsSize;

	private static bool GetConsoleVariableSourceByName_InCommandName_IsValid;

	private static FFieldAddress GetConsoleVariableSourceByName_InCommandName_PropertyAddress;

	private static int GetConsoleVariableSourceByName_InCommandName_Offset;

	private static bool GetConsoleVariableSourceByName_OutValue_IsValid;

	private static FFieldAddress GetConsoleVariableSourceByName_OutValue_PropertyAddress;

	private static int GetConsoleVariableSourceByName_OutValue_Offset;

	private static bool GetConsoleVariableSourceByName_ReturnValue_IsValid;

	private static FFieldAddress GetConsoleVariableSourceByName_ReturnValue_PropertyAddress;

	private static int GetConsoleVariableSourceByName_ReturnValue_Offset;

	private static bool CopyCurrentListToAsset_IsValid;

	private static IntPtr CopyCurrentListToAsset_FunctionAddress;

	private static int CopyCurrentListToAsset_ParamsSize;

	private static bool CopyCurrentListToAsset_InAsset_IsValid;

	private static FFieldAddress CopyCurrentListToAsset_InAsset_PropertyAddress;

	private static int CopyCurrentListToAsset_InAsset_Offset;

	private static bool CopyCurrentListToAsset_ReturnValue_IsValid;

	private static FFieldAddress CopyCurrentListToAsset_ReturnValue_PropertyAddress;

	private static int CopyCurrentListToAsset_ReturnValue_Offset;

	private static bool AddValidatedCommandToCurrentPreset_IsValid;

	private static IntPtr AddValidatedCommandToCurrentPreset_FunctionAddress;

	private static int AddValidatedCommandToCurrentPreset_ParamsSize;

	private static bool AddValidatedCommandToCurrentPreset_NewCommand_IsValid;

	private static FFieldAddress AddValidatedCommandToCurrentPreset_NewCommand_PropertyAddress;

	private static int AddValidatedCommandToCurrentPreset_NewCommand_Offset;

	private static bool AddValidatedCommandToCurrentPreset_ReturnValue_IsValid;

	private static FFieldAddress AddValidatedCommandToCurrentPreset_ReturnValue_PropertyAddress;

	private static int AddValidatedCommandToCurrentPreset_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetEnableMultiUserCVarSync")]
	public unsafe static void SetEnableMultiUserCVarSync(bool bNewSetting)
	{
		if (!SetEnableMultiUserCVarSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetEnableMultiUserCVarSync");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetEnableMultiUserCVarSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetEnableMultiUserCVarSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetEnableMultiUserCVarSync_bNewSetting_Offset), 0, SetEnableMultiUserCVarSync_bNewSetting_PropertyAddress.Address, bNewSetting);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetEnableMultiUserCVarSync_FunctionAddress, intPtr, SetEnableMultiUserCVarSync_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_String")]
	public unsafe static bool SetConsoleVariableByName_String(string InCommandName, string InValue)
	{
		if (!SetConsoleVariableByName_String_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_String");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsoleVariableByName_String_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsoleVariableByName_String_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_String_InCommandName_Offset), 0, SetConsoleVariableByName_String_InCommandName_PropertyAddress.Address, InCommandName);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_String_InValue_Offset), 0, SetConsoleVariableByName_String_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConsoleVariableByName_String_FunctionAddress, intPtr, SetConsoleVariableByName_String_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetConsoleVariableByName_String_InCommandName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetConsoleVariableByName_String_InValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConsoleVariableByName_String_ReturnValue_Offset), 0, SetConsoleVariableByName_String_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Int")]
	public unsafe static bool SetConsoleVariableByName_Int(string InCommandName, int InValue)
	{
		if (!SetConsoleVariableByName_Int_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Int");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsoleVariableByName_Int_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsoleVariableByName_Int_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Int_InCommandName_Offset), 0, SetConsoleVariableByName_Int_InCommandName_PropertyAddress.Address, InCommandName);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Int_InValue_Offset), 0, SetConsoleVariableByName_Int_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConsoleVariableByName_Int_FunctionAddress, intPtr, SetConsoleVariableByName_Int_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetConsoleVariableByName_Int_InCommandName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Int_ReturnValue_Offset), 0, SetConsoleVariableByName_Int_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Float")]
	public unsafe static bool SetConsoleVariableByName_Float(string InCommandName, float InValue)
	{
		if (!SetConsoleVariableByName_Float_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Float");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsoleVariableByName_Float_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsoleVariableByName_Float_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Float_InCommandName_Offset), 0, SetConsoleVariableByName_Float_InCommandName_PropertyAddress.Address, InCommandName);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Float_InValue_Offset), 0, SetConsoleVariableByName_Float_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConsoleVariableByName_Float_FunctionAddress, intPtr, SetConsoleVariableByName_Float_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetConsoleVariableByName_Float_InCommandName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Float_ReturnValue_Offset), 0, SetConsoleVariableByName_Float_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Bool")]
	public unsafe static bool SetConsoleVariableByName_Bool(string InCommandName, bool InValue)
	{
		if (!SetConsoleVariableByName_Bool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Bool");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetConsoleVariableByName_Bool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetConsoleVariableByName_Bool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Bool_InCommandName_Offset), 0, SetConsoleVariableByName_Bool_InCommandName_PropertyAddress.Address, InCommandName);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Bool_InValue_Offset), 0, SetConsoleVariableByName_Bool_InValue_PropertyAddress.Address, InValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetConsoleVariableByName_Bool_FunctionAddress, intPtr, SetConsoleVariableByName_Bool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetConsoleVariableByName_Bool_InCommandName_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetConsoleVariableByName_Bool_ReturnValue_Offset), 0, SetConsoleVariableByName_Bool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:RemoveCommandFromCurrentPreset")]
	public unsafe static bool RemoveCommandFromCurrentPreset(string NewCommand)
	{
		if (!RemoveCommandFromCurrentPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:RemoveCommandFromCurrentPreset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RemoveCommandFromCurrentPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RemoveCommandFromCurrentPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RemoveCommandFromCurrentPreset_NewCommand_Offset), 0, RemoveCommandFromCurrentPreset_NewCommand_PropertyAddress.Address, NewCommand);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RemoveCommandFromCurrentPreset_FunctionAddress, intPtr, RemoveCommandFromCurrentPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RemoveCommandFromCurrentPreset_NewCommand_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, RemoveCommandFromCurrentPreset_ReturnValue_Offset), 0, RemoveCommandFromCurrentPreset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:LoadPresetIntoConsoleVariablesEditor")]
	public unsafe static void LoadPresetIntoConsoleVariablesEditor(UConsoleVariablesAsset InAsset)
	{
		if (!LoadPresetIntoConsoleVariablesEditor_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:LoadPresetIntoConsoleVariablesEditor");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(LoadPresetIntoConsoleVariablesEditor_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LoadPresetIntoConsoleVariablesEditor_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UConsoleVariablesAsset>.ToNative(IntPtr.Add(intPtr, LoadPresetIntoConsoleVariablesEditor_InAsset_Offset), 0, LoadPresetIntoConsoleVariablesEditor_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, LoadPresetIntoConsoleVariablesEditor_FunctionAddress, intPtr, LoadPresetIntoConsoleVariablesEditor_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetListOfCommandsFromPreset")]
	public unsafe static bool GetListOfCommandsFromPreset(UConsoleVariablesAsset InAsset, out List<string> OutCommandList)
	{
		if (!GetListOfCommandsFromPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetListOfCommandsFromPreset");
			OutCommandList = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetListOfCommandsFromPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetListOfCommandsFromPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UConsoleVariablesAsset>.ToNative(IntPtr.Add(intPtr, GetListOfCommandsFromPreset_InAsset_Offset), 0, GetListOfCommandsFromPreset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetListOfCommandsFromPreset_FunctionAddress, intPtr, GetListOfCommandsFromPreset_ParamsSize);
		OutCommandList = new TArrayCopyMarshaler<string>(1, GetListOfCommandsFromPreset_OutCommandList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetListOfCommandsFromPreset_OutCommandList_Offset));
		NativeReflection.DestroyValue_InContainer(GetListOfCommandsFromPreset_OutCommandList_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetListOfCommandsFromPreset_ReturnValue_Offset), 0, GetListOfCommandsFromPreset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetEnableMultiUserCVarSync")]
	public unsafe static bool GetEnableMultiUserCVarSync()
	{
		if (!GetEnableMultiUserCVarSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetEnableMultiUserCVarSync");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetEnableMultiUserCVarSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetEnableMultiUserCVarSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetEnableMultiUserCVarSync_FunctionAddress, intPtr, GetEnableMultiUserCVarSync_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetEnableMultiUserCVarSync_ReturnValue_Offset), 0, GetEnableMultiUserCVarSync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetCurrentlyLoadedPreset")]
	public unsafe static UConsoleVariablesAsset GetCurrentlyLoadedPreset()
	{
		if (!GetCurrentlyLoadedPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetCurrentlyLoadedPreset");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetCurrentlyLoadedPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetCurrentlyLoadedPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetCurrentlyLoadedPreset_FunctionAddress, intPtr, GetCurrentlyLoadedPreset_ParamsSize);
		return UObjectMarshaler<UConsoleVariablesAsset>.FromNative(IntPtr.Add(intPtr, GetCurrentlyLoadedPreset_ReturnValue_Offset), 0, GetCurrentlyLoadedPreset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableStringValue")]
	public unsafe static bool GetConsoleVariableStringValue(string InCommandName, out string OutValue)
	{
		if (!GetConsoleVariableStringValue_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableStringValue");
			OutValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConsoleVariableStringValue_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConsoleVariableStringValue_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetConsoleVariableStringValue_InCommandName_Offset), 0, GetConsoleVariableStringValue_InCommandName_PropertyAddress.Address, InCommandName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConsoleVariableStringValue_FunctionAddress, intPtr, GetConsoleVariableStringValue_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetConsoleVariableStringValue_InCommandName_PropertyAddress.Address, intPtr);
		OutValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetConsoleVariableStringValue_OutValue_Offset), 0, GetConsoleVariableStringValue_OutValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConsoleVariableStringValue_OutValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetConsoleVariableStringValue_ReturnValue_Offset), 0, GetConsoleVariableStringValue_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableSourceByName")]
	public unsafe static bool GetConsoleVariableSourceByName(string InCommandName, out string OutValue)
	{
		if (!GetConsoleVariableSourceByName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableSourceByName");
			OutValue = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetConsoleVariableSourceByName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetConsoleVariableSourceByName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetConsoleVariableSourceByName_InCommandName_Offset), 0, GetConsoleVariableSourceByName_InCommandName_PropertyAddress.Address, InCommandName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetConsoleVariableSourceByName_FunctionAddress, intPtr, GetConsoleVariableSourceByName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetConsoleVariableSourceByName_InCommandName_PropertyAddress.Address, intPtr);
		OutValue = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetConsoleVariableSourceByName_OutValue_Offset), 0, GetConsoleVariableSourceByName_OutValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetConsoleVariableSourceByName_OutValue_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetConsoleVariableSourceByName_ReturnValue_Offset), 0, GetConsoleVariableSourceByName_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:CopyCurrentListToAsset")]
	public unsafe static bool CopyCurrentListToAsset(UConsoleVariablesAsset InAsset)
	{
		if (!CopyCurrentListToAsset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:CopyCurrentListToAsset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyCurrentListToAsset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyCurrentListToAsset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UConsoleVariablesAsset>.ToNative(IntPtr.Add(intPtr, CopyCurrentListToAsset_InAsset_Offset), 0, CopyCurrentListToAsset_InAsset_PropertyAddress.Address, InAsset);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyCurrentListToAsset_FunctionAddress, intPtr, CopyCurrentListToAsset_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CopyCurrentListToAsset_ReturnValue_Offset), 0, CopyCurrentListToAsset_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:AddValidatedCommandToCurrentPreset")]
	public unsafe static bool AddValidatedCommandToCurrentPreset(string NewCommand)
	{
		if (!AddValidatedCommandToCurrentPreset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:AddValidatedCommandToCurrentPreset");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddValidatedCommandToCurrentPreset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddValidatedCommandToCurrentPreset_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddValidatedCommandToCurrentPreset_NewCommand_Offset), 0, AddValidatedCommandToCurrentPreset_NewCommand_PropertyAddress.Address, NewCommand);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddValidatedCommandToCurrentPreset_FunctionAddress, intPtr, AddValidatedCommandToCurrentPreset_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddValidatedCommandToCurrentPreset_NewCommand_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddValidatedCommandToCurrentPreset_ReturnValue_Offset), 0, AddValidatedCommandToCurrentPreset_ReturnValue_PropertyAddress.Address);
	}

	static UConsoleVariablesEditorFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UConsoleVariablesEditorFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UConsoleVariablesEditorFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary");
		SetEnableMultiUserCVarSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetEnableMultiUserCVarSync");
		SetEnableMultiUserCVarSync_ParamsSize = NativeReflection.GetFunctionParamsSize(SetEnableMultiUserCVarSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetEnableMultiUserCVarSync_bNewSetting_PropertyAddress, SetEnableMultiUserCVarSync_FunctionAddress, "bNewSetting");
		SetEnableMultiUserCVarSync_bNewSetting_Offset = NativeReflectionCached.GetPropertyOffset(SetEnableMultiUserCVarSync_FunctionAddress, "bNewSetting");
		SetEnableMultiUserCVarSync_bNewSetting_IsValid = NativeReflectionCached.ValidatePropertyClass(SetEnableMultiUserCVarSync_FunctionAddress, "bNewSetting", Classes.FBoolProperty);
		SetEnableMultiUserCVarSync_IsValid = SetEnableMultiUserCVarSync_FunctionAddress != IntPtr.Zero && SetEnableMultiUserCVarSync_bNewSetting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetEnableMultiUserCVarSync", SetEnableMultiUserCVarSync_IsValid);
		SetConsoleVariableByName_String_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConsoleVariableByName_String");
		SetConsoleVariableByName_String_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsoleVariableByName_String_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_String_InCommandName_PropertyAddress, SetConsoleVariableByName_String_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_String_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_String_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_String_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_String_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_String_InValue_PropertyAddress, SetConsoleVariableByName_String_FunctionAddress, "InValue");
		SetConsoleVariableByName_String_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_String_FunctionAddress, "InValue");
		SetConsoleVariableByName_String_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_String_FunctionAddress, "InValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_String_ReturnValue_PropertyAddress, SetConsoleVariableByName_String_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_String_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_String_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_String_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_String_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConsoleVariableByName_String_IsValid = SetConsoleVariableByName_String_FunctionAddress != IntPtr.Zero && SetConsoleVariableByName_String_InCommandName_IsValid && SetConsoleVariableByName_String_InValue_IsValid && SetConsoleVariableByName_String_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_String", SetConsoleVariableByName_String_IsValid);
		SetConsoleVariableByName_Int_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConsoleVariableByName_Int");
		SetConsoleVariableByName_Int_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsoleVariableByName_Int_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Int_InCommandName_PropertyAddress, SetConsoleVariableByName_Int_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Int_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Int_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Int_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Int_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Int_InValue_PropertyAddress, SetConsoleVariableByName_Int_FunctionAddress, "InValue");
		SetConsoleVariableByName_Int_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Int_FunctionAddress, "InValue");
		SetConsoleVariableByName_Int_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Int_FunctionAddress, "InValue", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Int_ReturnValue_PropertyAddress, SetConsoleVariableByName_Int_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Int_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Int_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Int_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Int_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConsoleVariableByName_Int_IsValid = SetConsoleVariableByName_Int_FunctionAddress != IntPtr.Zero && SetConsoleVariableByName_Int_InCommandName_IsValid && SetConsoleVariableByName_Int_InValue_IsValid && SetConsoleVariableByName_Int_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Int", SetConsoleVariableByName_Int_IsValid);
		SetConsoleVariableByName_Float_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConsoleVariableByName_Float");
		SetConsoleVariableByName_Float_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsoleVariableByName_Float_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Float_InCommandName_PropertyAddress, SetConsoleVariableByName_Float_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Float_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Float_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Float_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Float_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Float_InValue_PropertyAddress, SetConsoleVariableByName_Float_FunctionAddress, "InValue");
		SetConsoleVariableByName_Float_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Float_FunctionAddress, "InValue");
		SetConsoleVariableByName_Float_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Float_FunctionAddress, "InValue", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Float_ReturnValue_PropertyAddress, SetConsoleVariableByName_Float_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Float_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Float_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Float_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Float_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConsoleVariableByName_Float_IsValid = SetConsoleVariableByName_Float_FunctionAddress != IntPtr.Zero && SetConsoleVariableByName_Float_InCommandName_IsValid && SetConsoleVariableByName_Float_InValue_IsValid && SetConsoleVariableByName_Float_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Float", SetConsoleVariableByName_Float_IsValid);
		SetConsoleVariableByName_Bool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetConsoleVariableByName_Bool");
		SetConsoleVariableByName_Bool_ParamsSize = NativeReflection.GetFunctionParamsSize(SetConsoleVariableByName_Bool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Bool_InCommandName_PropertyAddress, SetConsoleVariableByName_Bool_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Bool_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Bool_FunctionAddress, "InCommandName");
		SetConsoleVariableByName_Bool_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Bool_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Bool_InValue_PropertyAddress, SetConsoleVariableByName_Bool_FunctionAddress, "InValue");
		SetConsoleVariableByName_Bool_InValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Bool_FunctionAddress, "InValue");
		SetConsoleVariableByName_Bool_InValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Bool_FunctionAddress, "InValue", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SetConsoleVariableByName_Bool_ReturnValue_PropertyAddress, SetConsoleVariableByName_Bool_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Bool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetConsoleVariableByName_Bool_FunctionAddress, "ReturnValue");
		SetConsoleVariableByName_Bool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetConsoleVariableByName_Bool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetConsoleVariableByName_Bool_IsValid = SetConsoleVariableByName_Bool_FunctionAddress != IntPtr.Zero && SetConsoleVariableByName_Bool_InCommandName_IsValid && SetConsoleVariableByName_Bool_InValue_IsValid && SetConsoleVariableByName_Bool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:SetConsoleVariableByName_Bool", SetConsoleVariableByName_Bool_IsValid);
		RemoveCommandFromCurrentPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RemoveCommandFromCurrentPreset");
		RemoveCommandFromCurrentPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(RemoveCommandFromCurrentPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RemoveCommandFromCurrentPreset_NewCommand_PropertyAddress, RemoveCommandFromCurrentPreset_FunctionAddress, "NewCommand");
		RemoveCommandFromCurrentPreset_NewCommand_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCommandFromCurrentPreset_FunctionAddress, "NewCommand");
		RemoveCommandFromCurrentPreset_NewCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCommandFromCurrentPreset_FunctionAddress, "NewCommand", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RemoveCommandFromCurrentPreset_ReturnValue_PropertyAddress, RemoveCommandFromCurrentPreset_FunctionAddress, "ReturnValue");
		RemoveCommandFromCurrentPreset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RemoveCommandFromCurrentPreset_FunctionAddress, "ReturnValue");
		RemoveCommandFromCurrentPreset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RemoveCommandFromCurrentPreset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		RemoveCommandFromCurrentPreset_IsValid = RemoveCommandFromCurrentPreset_FunctionAddress != IntPtr.Zero && RemoveCommandFromCurrentPreset_NewCommand_IsValid && RemoveCommandFromCurrentPreset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:RemoveCommandFromCurrentPreset", RemoveCommandFromCurrentPreset_IsValid);
		LoadPresetIntoConsoleVariablesEditor_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "LoadPresetIntoConsoleVariablesEditor");
		LoadPresetIntoConsoleVariablesEditor_ParamsSize = NativeReflection.GetFunctionParamsSize(LoadPresetIntoConsoleVariablesEditor_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LoadPresetIntoConsoleVariablesEditor_InAsset_PropertyAddress, LoadPresetIntoConsoleVariablesEditor_FunctionAddress, "InAsset");
		LoadPresetIntoConsoleVariablesEditor_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(LoadPresetIntoConsoleVariablesEditor_FunctionAddress, "InAsset");
		LoadPresetIntoConsoleVariablesEditor_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(LoadPresetIntoConsoleVariablesEditor_FunctionAddress, "InAsset", Classes.FObjectProperty);
		LoadPresetIntoConsoleVariablesEditor_IsValid = LoadPresetIntoConsoleVariablesEditor_FunctionAddress != IntPtr.Zero && LoadPresetIntoConsoleVariablesEditor_InAsset_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:LoadPresetIntoConsoleVariablesEditor", LoadPresetIntoConsoleVariablesEditor_IsValid);
		GetListOfCommandsFromPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetListOfCommandsFromPreset");
		GetListOfCommandsFromPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetListOfCommandsFromPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetListOfCommandsFromPreset_InAsset_PropertyAddress, GetListOfCommandsFromPreset_FunctionAddress, "InAsset");
		GetListOfCommandsFromPreset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(GetListOfCommandsFromPreset_FunctionAddress, "InAsset");
		GetListOfCommandsFromPreset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(GetListOfCommandsFromPreset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref GetListOfCommandsFromPreset_OutCommandList_PropertyAddress, GetListOfCommandsFromPreset_FunctionAddress, "OutCommandList");
		GetListOfCommandsFromPreset_OutCommandList_Offset = NativeReflectionCached.GetPropertyOffset(GetListOfCommandsFromPreset_FunctionAddress, "OutCommandList");
		GetListOfCommandsFromPreset_OutCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetListOfCommandsFromPreset_FunctionAddress, "OutCommandList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetListOfCommandsFromPreset_ReturnValue_PropertyAddress, GetListOfCommandsFromPreset_FunctionAddress, "ReturnValue");
		GetListOfCommandsFromPreset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetListOfCommandsFromPreset_FunctionAddress, "ReturnValue");
		GetListOfCommandsFromPreset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetListOfCommandsFromPreset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetListOfCommandsFromPreset_IsValid = GetListOfCommandsFromPreset_FunctionAddress != IntPtr.Zero && GetListOfCommandsFromPreset_InAsset_IsValid && GetListOfCommandsFromPreset_OutCommandList_IsValid && GetListOfCommandsFromPreset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetListOfCommandsFromPreset", GetListOfCommandsFromPreset_IsValid);
		GetEnableMultiUserCVarSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetEnableMultiUserCVarSync");
		GetEnableMultiUserCVarSync_ParamsSize = NativeReflection.GetFunctionParamsSize(GetEnableMultiUserCVarSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetEnableMultiUserCVarSync_ReturnValue_PropertyAddress, GetEnableMultiUserCVarSync_FunctionAddress, "ReturnValue");
		GetEnableMultiUserCVarSync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetEnableMultiUserCVarSync_FunctionAddress, "ReturnValue");
		GetEnableMultiUserCVarSync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetEnableMultiUserCVarSync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetEnableMultiUserCVarSync_IsValid = GetEnableMultiUserCVarSync_FunctionAddress != IntPtr.Zero && GetEnableMultiUserCVarSync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetEnableMultiUserCVarSync", GetEnableMultiUserCVarSync_IsValid);
		GetCurrentlyLoadedPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetCurrentlyLoadedPreset");
		GetCurrentlyLoadedPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(GetCurrentlyLoadedPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetCurrentlyLoadedPreset_ReturnValue_PropertyAddress, GetCurrentlyLoadedPreset_FunctionAddress, "ReturnValue");
		GetCurrentlyLoadedPreset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetCurrentlyLoadedPreset_FunctionAddress, "ReturnValue");
		GetCurrentlyLoadedPreset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetCurrentlyLoadedPreset_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetCurrentlyLoadedPreset_IsValid = GetCurrentlyLoadedPreset_FunctionAddress != IntPtr.Zero && GetCurrentlyLoadedPreset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetCurrentlyLoadedPreset", GetCurrentlyLoadedPreset_IsValid);
		GetConsoleVariableStringValue_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConsoleVariableStringValue");
		GetConsoleVariableStringValue_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConsoleVariableStringValue_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableStringValue_InCommandName_PropertyAddress, GetConsoleVariableStringValue_FunctionAddress, "InCommandName");
		GetConsoleVariableStringValue_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableStringValue_FunctionAddress, "InCommandName");
		GetConsoleVariableStringValue_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableStringValue_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableStringValue_OutValue_PropertyAddress, GetConsoleVariableStringValue_FunctionAddress, "OutValue");
		GetConsoleVariableStringValue_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableStringValue_FunctionAddress, "OutValue");
		GetConsoleVariableStringValue_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableStringValue_FunctionAddress, "OutValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableStringValue_ReturnValue_PropertyAddress, GetConsoleVariableStringValue_FunctionAddress, "ReturnValue");
		GetConsoleVariableStringValue_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableStringValue_FunctionAddress, "ReturnValue");
		GetConsoleVariableStringValue_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableStringValue_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetConsoleVariableStringValue_IsValid = GetConsoleVariableStringValue_FunctionAddress != IntPtr.Zero && GetConsoleVariableStringValue_InCommandName_IsValid && GetConsoleVariableStringValue_OutValue_IsValid && GetConsoleVariableStringValue_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableStringValue", GetConsoleVariableStringValue_IsValid);
		GetConsoleVariableSourceByName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetConsoleVariableSourceByName");
		GetConsoleVariableSourceByName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetConsoleVariableSourceByName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableSourceByName_InCommandName_PropertyAddress, GetConsoleVariableSourceByName_FunctionAddress, "InCommandName");
		GetConsoleVariableSourceByName_InCommandName_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableSourceByName_FunctionAddress, "InCommandName");
		GetConsoleVariableSourceByName_InCommandName_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableSourceByName_FunctionAddress, "InCommandName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableSourceByName_OutValue_PropertyAddress, GetConsoleVariableSourceByName_FunctionAddress, "OutValue");
		GetConsoleVariableSourceByName_OutValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableSourceByName_FunctionAddress, "OutValue");
		GetConsoleVariableSourceByName_OutValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableSourceByName_FunctionAddress, "OutValue", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetConsoleVariableSourceByName_ReturnValue_PropertyAddress, GetConsoleVariableSourceByName_FunctionAddress, "ReturnValue");
		GetConsoleVariableSourceByName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetConsoleVariableSourceByName_FunctionAddress, "ReturnValue");
		GetConsoleVariableSourceByName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetConsoleVariableSourceByName_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetConsoleVariableSourceByName_IsValid = GetConsoleVariableSourceByName_FunctionAddress != IntPtr.Zero && GetConsoleVariableSourceByName_InCommandName_IsValid && GetConsoleVariableSourceByName_OutValue_IsValid && GetConsoleVariableSourceByName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:GetConsoleVariableSourceByName", GetConsoleVariableSourceByName_IsValid);
		CopyCurrentListToAsset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyCurrentListToAsset");
		CopyCurrentListToAsset_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyCurrentListToAsset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyCurrentListToAsset_InAsset_PropertyAddress, CopyCurrentListToAsset_FunctionAddress, "InAsset");
		CopyCurrentListToAsset_InAsset_Offset = NativeReflectionCached.GetPropertyOffset(CopyCurrentListToAsset_FunctionAddress, "InAsset");
		CopyCurrentListToAsset_InAsset_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyCurrentListToAsset_FunctionAddress, "InAsset", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CopyCurrentListToAsset_ReturnValue_PropertyAddress, CopyCurrentListToAsset_FunctionAddress, "ReturnValue");
		CopyCurrentListToAsset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CopyCurrentListToAsset_FunctionAddress, "ReturnValue");
		CopyCurrentListToAsset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyCurrentListToAsset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CopyCurrentListToAsset_IsValid = CopyCurrentListToAsset_FunctionAddress != IntPtr.Zero && CopyCurrentListToAsset_InAsset_IsValid && CopyCurrentListToAsset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:CopyCurrentListToAsset", CopyCurrentListToAsset_IsValid);
		AddValidatedCommandToCurrentPreset_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddValidatedCommandToCurrentPreset");
		AddValidatedCommandToCurrentPreset_ParamsSize = NativeReflection.GetFunctionParamsSize(AddValidatedCommandToCurrentPreset_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddValidatedCommandToCurrentPreset_NewCommand_PropertyAddress, AddValidatedCommandToCurrentPreset_FunctionAddress, "NewCommand");
		AddValidatedCommandToCurrentPreset_NewCommand_Offset = NativeReflectionCached.GetPropertyOffset(AddValidatedCommandToCurrentPreset_FunctionAddress, "NewCommand");
		AddValidatedCommandToCurrentPreset_NewCommand_IsValid = NativeReflectionCached.ValidatePropertyClass(AddValidatedCommandToCurrentPreset_FunctionAddress, "NewCommand", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddValidatedCommandToCurrentPreset_ReturnValue_PropertyAddress, AddValidatedCommandToCurrentPreset_FunctionAddress, "ReturnValue");
		AddValidatedCommandToCurrentPreset_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddValidatedCommandToCurrentPreset_FunctionAddress, "ReturnValue");
		AddValidatedCommandToCurrentPreset_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddValidatedCommandToCurrentPreset_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddValidatedCommandToCurrentPreset_IsValid = AddValidatedCommandToCurrentPreset_FunctionAddress != IntPtr.Zero && AddValidatedCommandToCurrentPreset_NewCommand_IsValid && AddValidatedCommandToCurrentPreset_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/ConsoleVariablesEditor.ConsoleVariablesEditorFunctionLibrary:AddValidatedCommandToCurrentPreset", AddValidatedCommandToCurrentPreset_IsValid);
	}
}
