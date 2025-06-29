using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.B1Util", "b1", UnrealModuleType.Game)]
public class UB1Util : UObject
{
	private static IntPtr classAddress;

	private static bool SetUISettingPbTag_IsValid;

	private static IntPtr SetUISettingPbTag_FunctionAddress;

	private static int SetUISettingPbTag_ParamsSize;

	private static bool SetUISettingPbTag_TagId_IsValid;

	private static FFieldAddress SetUISettingPbTag_TagId_PropertyAddress;

	private static int SetUISettingPbTag_TagId_Offset;

	private static bool SetUISettingData_IsValid;

	private static IntPtr SetUISettingData_FunctionAddress;

	private static int SetUISettingData_ParamsSize;

	private static bool SetUISettingData_SetUISettingData_IsValid;

	private static FFieldAddress SetUISettingData_SetUISettingData_PropertyAddress;

	private static int SetUISettingData_SetUISettingData_Offset;

	private static bool SetUISettingCustomData_IsValid;

	private static IntPtr SetUISettingCustomData_FunctionAddress;

	private static int SetUISettingCustomData_ParamsSize;

	private static bool SetUISettingCustomData_DetailSettingData_IsValid;

	private static FFieldAddress SetUISettingCustomData_DetailSettingData_PropertyAddress;

	private static int SetUISettingCustomData_DetailSettingData_Offset;

	private static bool SetStartupConfigEnable_IsValid;

	private static IntPtr SetStartupConfigEnable_FunctionAddress;

	private static int SetStartupConfigEnable_ParamsSize;

	private static bool SetStartupConfigEnable_bEnable_IsValid;

	private static FFieldAddress SetStartupConfigEnable_bEnable_PropertyAddress;

	private static int SetStartupConfigEnable_bEnable_Offset;

	private static bool SetStartLevelName_IsValid;

	private static IntPtr SetStartLevelName_FunctionAddress;

	private static int SetStartLevelName_ParamsSize;

	private static bool SetStartLevelName_InStartLevelName_IsValid;

	private static FFieldAddress SetStartLevelName_InStartLevelName_PropertyAddress;

	private static int SetStartLevelName_InStartLevelName_Offset;

	private static bool SetStartCommandList_IsValid;

	private static IntPtr SetStartCommandList_FunctionAddress;

	private static int SetStartCommandList_ParamsSize;

	private static bool SetStartCommandList_InStartCommandList_IsValid;

	private static FFieldAddress SetStartCommandList_InStartCommandList_PropertyAddress;

	private static int SetStartCommandList_InStartCommandList_Offset;

	private static bool SetPrivacyAgreement_IsValid;

	private static IntPtr SetPrivacyAgreement_FunctionAddress;

	private static int SetPrivacyAgreement_ParamsSize;

	private static bool SetPrivacyAgreement_NewValue_IsValid;

	private static FFieldAddress SetPrivacyAgreement_NewValue_PropertyAddress;

	private static int SetPrivacyAgreement_NewValue_Offset;

	private static bool SetNeverShowStartupUI_IsValid;

	private static IntPtr SetNeverShowStartupUI_FunctionAddress;

	private static int SetNeverShowStartupUI_ParamsSize;

	private static bool SetNeverShowStartupUI_bInNeverShowStartupUI_IsValid;

	private static FFieldAddress SetNeverShowStartupUI_bInNeverShowStartupUI_PropertyAddress;

	private static int SetNeverShowStartupUI_bInNeverShowStartupUI_Offset;

	private static bool SetMainMonitorID_IsValid;

	private static IntPtr SetMainMonitorID_FunctionAddress;

	private static int SetMainMonitorID_ParamsSize;

	private static bool SetMainMonitorID_MonitorID_IsValid;

	private static FFieldAddress SetMainMonitorID_MonitorID_PropertyAddress;

	private static int SetMainMonitorID_MonitorID_Offset;

	private static bool SetGMCommandList_IsValid;

	private static IntPtr SetGMCommandList_FunctionAddress;

	private static int SetGMCommandList_ParamsSize;

	private static bool SetGMCommandList_InGMCommandList_IsValid;

	private static FFieldAddress SetGMCommandList_InGMCommandList_PropertyAddress;

	private static int SetGMCommandList_InGMCommandList_Offset;

	private static bool SetFirstSettingFinish_IsValid;

	private static IntPtr SetFirstSettingFinish_FunctionAddress;

	private static int SetFirstSettingFinish_ParamsSize;

	private static bool SetFirstSettingFinish_NewValue_IsValid;

	private static FFieldAddress SetFirstSettingFinish_NewValue_PropertyAddress;

	private static int SetFirstSettingFinish_NewValue_Offset;

	private static bool SetArchiveMarkFinish_IsValid;

	private static IntPtr SetArchiveMarkFinish_FunctionAddress;

	private static int SetArchiveMarkFinish_ParamsSize;

	private static bool SetArchiveMarkFinish_NewValue_IsValid;

	private static FFieldAddress SetArchiveMarkFinish_NewValue_PropertyAddress;

	private static int SetArchiveMarkFinish_NewValue_Offset;

	private static bool SetAgreementReaded_IsValid;

	private static IntPtr SetAgreementReaded_FunctionAddress;

	private static int SetAgreementReaded_ParamsSize;

	private static bool SetAgreementReaded_NewValue_IsValid;

	private static FFieldAddress SetAgreementReaded_NewValue_PropertyAddress;

	private static int SetAgreementReaded_NewValue_Offset;

	private static bool SaveGameUserSettings_IsValid;

	private static IntPtr SaveGameUserSettings_FunctionAddress;

	private static int SaveGameUserSettings_ParamsSize;

	private static bool OpenFileBrowser_IsValid;

	private static IntPtr OpenFileBrowser_FunctionAddress;

	private static int OpenFileBrowser_ParamsSize;

	private static bool OpenFileBrowser_FolderPath_IsValid;

	private static FFieldAddress OpenFileBrowser_FolderPath_PropertyAddress;

	private static int OpenFileBrowser_FolderPath_Offset;

	private static bool IsStartupConfigEnable_IsValid;

	private static IntPtr IsStartupConfigEnable_FunctionAddress;

	private static int IsStartupConfigEnable_ParamsSize;

	private static bool IsStartupConfigEnable_ReturnValue_IsValid;

	private static FFieldAddress IsStartupConfigEnable_ReturnValue_PropertyAddress;

	private static int IsStartupConfigEnable_ReturnValue_Offset;

	private static bool IsNeverShowStartupUI_IsValid;

	private static IntPtr IsNeverShowStartupUI_FunctionAddress;

	private static int IsNeverShowStartupUI_ParamsSize;

	private static bool IsNeverShowStartupUI_ReturnValue_IsValid;

	private static FFieldAddress IsNeverShowStartupUI_ReturnValue_PropertyAddress;

	private static int IsNeverShowStartupUI_ReturnValue_Offset;

	private static bool GetUISettingPbTag_IsValid;

	private static IntPtr GetUISettingPbTag_FunctionAddress;

	private static int GetUISettingPbTag_ParamsSize;

	private static bool GetUISettingPbTag_ReturnValue_IsValid;

	private static FFieldAddress GetUISettingPbTag_ReturnValue_PropertyAddress;

	private static int GetUISettingPbTag_ReturnValue_Offset;

	private static bool GetUISettingData_IsValid;

	private static IntPtr GetUISettingData_FunctionAddress;

	private static int GetUISettingData_ParamsSize;

	private static bool GetUISettingData_OutUISettingData_IsValid;

	private static FFieldAddress GetUISettingData_OutUISettingData_PropertyAddress;

	private static int GetUISettingData_OutUISettingData_Offset;

	private static bool GetUISettingData_ReturnValue_IsValid;

	private static FFieldAddress GetUISettingData_ReturnValue_PropertyAddress;

	private static int GetUISettingData_ReturnValue_Offset;

	private static bool GetUISettingCustomData_IsValid;

	private static IntPtr GetUISettingCustomData_FunctionAddress;

	private static int GetUISettingCustomData_ParamsSize;

	private static bool GetUISettingCustomData_OutDetailSettingData_IsValid;

	private static FFieldAddress GetUISettingCustomData_OutDetailSettingData_PropertyAddress;

	private static int GetUISettingCustomData_OutDetailSettingData_Offset;

	private static bool GetUISettingCustomData_ReturnValue_IsValid;

	private static FFieldAddress GetUISettingCustomData_ReturnValue_PropertyAddress;

	private static int GetUISettingCustomData_ReturnValue_Offset;

	private static bool GetStartLevelName_IsValid;

	private static IntPtr GetStartLevelName_FunctionAddress;

	private static int GetStartLevelName_ParamsSize;

	private static bool GetStartLevelName_ReturnValue_IsValid;

	private static FFieldAddress GetStartLevelName_ReturnValue_PropertyAddress;

	private static int GetStartLevelName_ReturnValue_Offset;

	private static bool GetStartCommandList_IsValid;

	private static IntPtr GetStartCommandList_FunctionAddress;

	private static int GetStartCommandList_ParamsSize;

	private static bool GetStartCommandList_OutStartCommandList_IsValid;

	private static FFieldAddress GetStartCommandList_OutStartCommandList_PropertyAddress;

	private static int GetStartCommandList_OutStartCommandList_Offset;

	private static bool GetStartCommandList_ReturnValue_IsValid;

	private static FFieldAddress GetStartCommandList_ReturnValue_PropertyAddress;

	private static int GetStartCommandList_ReturnValue_Offset;

	private static bool GetRandomNumberInt_IsValid;

	private static IntPtr GetRandomNumberInt_FunctionAddress;

	private static int GetRandomNumberInt_ParamsSize;

	private static bool GetRandomNumberInt_LeftNum_IsValid;

	private static FFieldAddress GetRandomNumberInt_LeftNum_PropertyAddress;

	private static int GetRandomNumberInt_LeftNum_Offset;

	private static bool GetRandomNumberInt_RightNum_IsValid;

	private static FFieldAddress GetRandomNumberInt_RightNum_PropertyAddress;

	private static int GetRandomNumberInt_RightNum_Offset;

	private static bool GetRandomNumberInt_ReturnValue_IsValid;

	private static FFieldAddress GetRandomNumberInt_ReturnValue_PropertyAddress;

	private static int GetRandomNumberInt_ReturnValue_Offset;

	private static bool GetRandomNumberFloat_IsValid;

	private static IntPtr GetRandomNumberFloat_FunctionAddress;

	private static int GetRandomNumberFloat_ParamsSize;

	private static bool GetRandomNumberFloat_LeftNum_IsValid;

	private static FFieldAddress GetRandomNumberFloat_LeftNum_PropertyAddress;

	private static int GetRandomNumberFloat_LeftNum_Offset;

	private static bool GetRandomNumberFloat_RightNum_IsValid;

	private static FFieldAddress GetRandomNumberFloat_RightNum_PropertyAddress;

	private static int GetRandomNumberFloat_RightNum_Offset;

	private static bool GetRandomNumberFloat_ReturnValue_IsValid;

	private static FFieldAddress GetRandomNumberFloat_ReturnValue_PropertyAddress;

	private static int GetRandomNumberFloat_ReturnValue_Offset;

	private static bool GetPrivacyAgreement_IsValid;

	private static IntPtr GetPrivacyAgreement_FunctionAddress;

	private static int GetPrivacyAgreement_ParamsSize;

	private static bool GetPrivacyAgreement_ReturnValue_IsValid;

	private static FFieldAddress GetPrivacyAgreement_ReturnValue_PropertyAddress;

	private static int GetPrivacyAgreement_ReturnValue_Offset;

	private static bool GetGMCommandList_IsValid;

	private static IntPtr GetGMCommandList_FunctionAddress;

	private static int GetGMCommandList_ParamsSize;

	private static bool GetGMCommandList_OutGMCommandList_IsValid;

	private static FFieldAddress GetGMCommandList_OutGMCommandList_PropertyAddress;

	private static int GetGMCommandList_OutGMCommandList_Offset;

	private static bool GetGMCommandList_ReturnValue_IsValid;

	private static FFieldAddress GetGMCommandList_ReturnValue_PropertyAddress;

	private static int GetGMCommandList_ReturnValue_Offset;

	private static bool GetFirstSettingFinish_IsValid;

	private static IntPtr GetFirstSettingFinish_FunctionAddress;

	private static int GetFirstSettingFinish_ParamsSize;

	private static bool GetFirstSettingFinish_ReturnValue_IsValid;

	private static FFieldAddress GetFirstSettingFinish_ReturnValue_PropertyAddress;

	private static int GetFirstSettingFinish_ReturnValue_Offset;

	private static bool GetAvailableMaps_IsValid;

	private static IntPtr GetAvailableMaps_FunctionAddress;

	private static int GetAvailableMaps_ParamsSize;

	private static bool GetAvailableMaps_OutAvailableMaps_IsValid;

	private static FFieldAddress GetAvailableMaps_OutAvailableMaps_PropertyAddress;

	private static int GetAvailableMaps_OutAvailableMaps_Offset;

	private static bool GetAvailableMaps_ReturnValue_IsValid;

	private static FFieldAddress GetAvailableMaps_ReturnValue_PropertyAddress;

	private static int GetAvailableMaps_ReturnValue_Offset;

	private static bool GetArchiveMarkFinish_IsValid;

	private static IntPtr GetArchiveMarkFinish_FunctionAddress;

	private static int GetArchiveMarkFinish_ParamsSize;

	private static bool GetArchiveMarkFinish_ReturnValue_IsValid;

	private static FFieldAddress GetArchiveMarkFinish_ReturnValue_PropertyAddress;

	private static int GetArchiveMarkFinish_ReturnValue_Offset;

	private static bool GetAgreementReaded_IsValid;

	private static IntPtr GetAgreementReaded_FunctionAddress;

	private static int GetAgreementReaded_ParamsSize;

	private static bool GetAgreementReaded_ReturnValue_IsValid;

	private static FFieldAddress GetAgreementReaded_ReturnValue_PropertyAddress;

	private static int GetAgreementReaded_ReturnValue_Offset;

	private static bool CopyStringToClipboard_IsValid;

	private static IntPtr CopyStringToClipboard_FunctionAddress;

	private static int CopyStringToClipboard_ParamsSize;

	private static bool CopyStringToClipboard_Text_IsValid;

	private static FFieldAddress CopyStringToClipboard_Text_PropertyAddress;

	private static int CopyStringToClipboard_Text_Offset;

	private static bool CheckIsSimulationPlayMode_IsValid;

	private static IntPtr CheckIsSimulationPlayMode_FunctionAddress;

	private static int CheckIsSimulationPlayMode_ParamsSize;

	private static bool CheckIsSimulationPlayMode_ReturnValue_IsValid;

	private static FFieldAddress CheckIsSimulationPlayMode_ReturnValue_PropertyAddress;

	private static int CheckIsSimulationPlayMode_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetUISettingPbTag")]
	public unsafe static void SetUISettingPbTag(int TagId)
	{
		if (!SetUISettingPbTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetUISettingPbTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUISettingPbTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUISettingPbTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetUISettingPbTag_TagId_Offset), 0, SetUISettingPbTag_TagId_PropertyAddress.Address, TagId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUISettingPbTag_FunctionAddress, intPtr, SetUISettingPbTag_ParamsSize);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:SetUISettingData")]
	public unsafe static void SetUISettingData(Dictionary<string, string> SetUISettingData)
	{
		if (!SetUISettingData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetUISettingData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUISettingData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUISettingData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetUISettingData_SetUISettingData_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, SetUISettingData_SetUISettingData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetUISettingData_SetUISettingData_Offset), SetUISettingData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUISettingData_FunctionAddress, intPtr, SetUISettingData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetUISettingData_SetUISettingData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:SetUISettingCustomData")]
	public unsafe static void SetUISettingCustomData(Dictionary<string, string> DetailSettingData)
	{
		if (!SetUISettingCustomData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetUISettingCustomData");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUISettingCustomData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUISettingCustomData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetUISettingCustomData_DetailSettingData_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, SetUISettingCustomData_DetailSettingData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetUISettingCustomData_DetailSettingData_Offset), DetailSettingData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetUISettingCustomData_FunctionAddress, intPtr, SetUISettingCustomData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetUISettingCustomData_DetailSettingData_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetStartupConfigEnable")]
	public unsafe static void SetStartupConfigEnable(bool bEnable)
	{
		if (!SetStartupConfigEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetStartupConfigEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartupConfigEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartupConfigEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetStartupConfigEnable_bEnable_Offset), 0, SetStartupConfigEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartupConfigEnable_FunctionAddress, intPtr, SetStartupConfigEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetStartLevelName")]
	public unsafe static void SetStartLevelName(string InStartLevelName)
	{
		if (!SetStartLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetStartLevelName");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetStartLevelName_InStartLevelName_Offset), 0, SetStartLevelName_InStartLevelName_PropertyAddress.Address, InStartLevelName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartLevelName_FunctionAddress, intPtr, SetStartLevelName_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStartLevelName_InStartLevelName_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:SetStartCommandList")]
	public unsafe static void SetStartCommandList(List<string> InStartCommandList)
	{
		if (!SetStartCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetStartCommandList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetStartCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetStartCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, SetStartCommandList_InStartCommandList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetStartCommandList_InStartCommandList_Offset), InStartCommandList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetStartCommandList_FunctionAddress, intPtr, SetStartCommandList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetStartCommandList_InStartCommandList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetPrivacyAgreement")]
	public unsafe static void SetPrivacyAgreement(int NewValue)
	{
		if (!SetPrivacyAgreement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetPrivacyAgreement");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPrivacyAgreement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPrivacyAgreement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetPrivacyAgreement_NewValue_Offset), 0, SetPrivacyAgreement_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetPrivacyAgreement_FunctionAddress, intPtr, SetPrivacyAgreement_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetNeverShowStartupUI")]
	public unsafe static void SetNeverShowStartupUI(bool bInNeverShowStartupUI)
	{
		if (!SetNeverShowStartupUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetNeverShowStartupUI");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetNeverShowStartupUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetNeverShowStartupUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetNeverShowStartupUI_bInNeverShowStartupUI_Offset), 0, SetNeverShowStartupUI_bInNeverShowStartupUI_PropertyAddress.Address, bInNeverShowStartupUI);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetNeverShowStartupUI_FunctionAddress, intPtr, SetNeverShowStartupUI_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetMainMonitorID")]
	public unsafe static void SetMainMonitorID(string MonitorID)
	{
		if (!SetMainMonitorID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetMainMonitorID");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetMainMonitorID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetMainMonitorID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetMainMonitorID_MonitorID_Offset), 0, SetMainMonitorID_MonitorID_PropertyAddress.Address, MonitorID);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetMainMonitorID_FunctionAddress, intPtr, SetMainMonitorID_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetMainMonitorID_MonitorID_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:SetGMCommandList")]
	public unsafe static void SetGMCommandList(Dictionary<byte, string> InGMCommandList)
	{
		if (!SetGMCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetGMCommandList");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetGMCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetGMCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetGMCommandList_InGMCommandList_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<byte, string>(1, SetGMCommandList_InGMCommandList_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SetGMCommandList_InGMCommandList_Offset), InGMCommandList);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetGMCommandList_FunctionAddress, intPtr, SetGMCommandList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetGMCommandList_InGMCommandList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetFirstSettingFinish")]
	public unsafe static void SetFirstSettingFinish(bool NewValue)
	{
		if (!SetFirstSettingFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetFirstSettingFinish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetFirstSettingFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetFirstSettingFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetFirstSettingFinish_NewValue_Offset), 0, SetFirstSettingFinish_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetFirstSettingFinish_FunctionAddress, intPtr, SetFirstSettingFinish_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetArchiveMarkFinish")]
	public unsafe static void SetArchiveMarkFinish(bool NewValue)
	{
		if (!SetArchiveMarkFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetArchiveMarkFinish");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetArchiveMarkFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetArchiveMarkFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetArchiveMarkFinish_NewValue_Offset), 0, SetArchiveMarkFinish_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetArchiveMarkFinish_FunctionAddress, intPtr, SetArchiveMarkFinish_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SetAgreementReaded")]
	public unsafe static void SetAgreementReaded(int NewValue)
	{
		if (!SetAgreementReaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SetAgreementReaded");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAgreementReaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAgreementReaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAgreementReaded_NewValue_Offset), 0, SetAgreementReaded_NewValue_PropertyAddress.Address, NewValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAgreementReaded_FunctionAddress, intPtr, SetAgreementReaded_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:SaveGameUserSettings")]
	public unsafe static void SaveGameUserSettings()
	{
		if (!SaveGameUserSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:SaveGameUserSettings");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SaveGameUserSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SaveGameUserSettings_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: SaveGameUserSettings_FunctionAddress, argsSize: SaveGameUserSettings_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:OpenFileBrowser")]
	public unsafe static void OpenFileBrowser(string FolderPath)
	{
		if (!OpenFileBrowser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:OpenFileBrowser");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OpenFileBrowser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OpenFileBrowser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OpenFileBrowser_FolderPath_Offset), 0, OpenFileBrowser_FolderPath_PropertyAddress.Address, FolderPath);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OpenFileBrowser_FunctionAddress, intPtr, OpenFileBrowser_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OpenFileBrowser_FolderPath_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:IsStartupConfigEnable")]
	public unsafe static bool IsStartupConfigEnable()
	{
		if (!IsStartupConfigEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:IsStartupConfigEnable");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStartupConfigEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStartupConfigEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsStartupConfigEnable_FunctionAddress, intPtr, IsStartupConfigEnable_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStartupConfigEnable_ReturnValue_Offset), 0, IsStartupConfigEnable_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:IsNeverShowStartupUI")]
	public unsafe static bool IsNeverShowStartupUI()
	{
		if (!IsNeverShowStartupUI_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:IsNeverShowStartupUI");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsNeverShowStartupUI_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsNeverShowStartupUI_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsNeverShowStartupUI_FunctionAddress, intPtr, IsNeverShowStartupUI_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsNeverShowStartupUI_ReturnValue_Offset), 0, IsNeverShowStartupUI_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetUISettingPbTag")]
	public unsafe static int GetUISettingPbTag()
	{
		if (!GetUISettingPbTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetUISettingPbTag");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUISettingPbTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUISettingPbTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUISettingPbTag_FunctionAddress, intPtr, GetUISettingPbTag_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUISettingPbTag_ReturnValue_Offset), 0, GetUISettingPbTag_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:GetUISettingData")]
	public unsafe static int GetUISettingData(out Dictionary<string, string> OutUISettingData)
	{
		if (!GetUISettingData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetUISettingData");
			OutUISettingData = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUISettingData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUISettingData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUISettingData_OutUISettingData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUISettingData_FunctionAddress, intPtr, GetUISettingData_ParamsSize);
		OutUISettingData = new TMapCopyMarshaler<string, string>(1, GetUISettingData_OutUISettingData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetUISettingData_OutUISettingData_Offset));
		NativeReflection.DestroyValue_InContainer(GetUISettingData_OutUISettingData_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUISettingData_ReturnValue_Offset), 0, GetUISettingData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:GetUISettingCustomData")]
	public unsafe static int GetUISettingCustomData(out Dictionary<string, string> OutDetailSettingData)
	{
		if (!GetUISettingCustomData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetUISettingCustomData");
			OutDetailSettingData = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetUISettingCustomData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetUISettingCustomData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetUISettingCustomData_OutDetailSettingData_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetUISettingCustomData_FunctionAddress, intPtr, GetUISettingCustomData_ParamsSize);
		OutDetailSettingData = new TMapCopyMarshaler<string, string>(1, GetUISettingCustomData_OutDetailSettingData_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetUISettingCustomData_OutDetailSettingData_Offset));
		NativeReflection.DestroyValue_InContainer(GetUISettingCustomData_OutDetailSettingData_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetUISettingCustomData_ReturnValue_Offset), 0, GetUISettingCustomData_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetStartLevelName")]
	public unsafe static string GetStartLevelName()
	{
		if (!GetStartLevelName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetStartLevelName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartLevelName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartLevelName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartLevelName_FunctionAddress, intPtr, GetStartLevelName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetStartLevelName_ReturnValue_Offset), 0, GetStartLevelName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetStartLevelName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:GetStartCommandList")]
	public unsafe static int GetStartCommandList(out List<string> OutStartCommandList)
	{
		if (!GetStartCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetStartCommandList");
			OutStartCommandList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStartCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStartCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStartCommandList_FunctionAddress, intPtr, GetStartCommandList_ParamsSize);
		OutStartCommandList = new TArrayCopyMarshaler<string>(1, GetStartCommandList_OutStartCommandList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetStartCommandList_OutStartCommandList_Offset));
		NativeReflection.DestroyValue_InContainer(GetStartCommandList_OutStartCommandList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetStartCommandList_ReturnValue_Offset), 0, GetStartCommandList_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.B1Util:GetRandomNumberInt")]
	public unsafe static int GetRandomNumberInt(int LeftNum = 0, int RightNum = 0)
	{
		if (!GetRandomNumberInt_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetRandomNumberInt");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomNumberInt_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomNumberInt_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRandomNumberInt_LeftNum_Offset), 0, GetRandomNumberInt_LeftNum_PropertyAddress.Address, LeftNum);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetRandomNumberInt_RightNum_Offset), 0, GetRandomNumberInt_RightNum_PropertyAddress.Address, RightNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomNumberInt_FunctionAddress, intPtr, GetRandomNumberInt_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetRandomNumberInt_ReturnValue_Offset), 0, GetRandomNumberInt_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.B1Util:GetRandomNumberFloat")]
	public unsafe static float GetRandomNumberFloat(float LeftNum = 0f, float RightNum = 0f)
	{
		if (!GetRandomNumberFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetRandomNumberFloat");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRandomNumberFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRandomNumberFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRandomNumberFloat_LeftNum_Offset), 0, GetRandomNumberFloat_LeftNum_PropertyAddress.Address, LeftNum);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, GetRandomNumberFloat_RightNum_Offset), 0, GetRandomNumberFloat_RightNum_PropertyAddress.Address, RightNum);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetRandomNumberFloat_FunctionAddress, intPtr, GetRandomNumberFloat_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRandomNumberFloat_ReturnValue_Offset), 0, GetRandomNumberFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetPrivacyAgreement")]
	public unsafe static int GetPrivacyAgreement()
	{
		if (!GetPrivacyAgreement_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetPrivacyAgreement");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPrivacyAgreement_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPrivacyAgreement_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPrivacyAgreement_FunctionAddress, intPtr, GetPrivacyAgreement_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPrivacyAgreement_ReturnValue_Offset), 0, GetPrivacyAgreement_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:GetGMCommandList")]
	public unsafe static int GetGMCommandList(out Dictionary<byte, string> OutGMCommandList)
	{
		if (!GetGMCommandList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetGMCommandList");
			OutGMCommandList = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGMCommandList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGMCommandList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGMCommandList_OutGMCommandList_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGMCommandList_FunctionAddress, intPtr, GetGMCommandList_ParamsSize);
		OutGMCommandList = new TMapCopyMarshaler<byte, string>(1, GetGMCommandList_OutGMCommandList_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetGMCommandList_OutGMCommandList_Offset));
		NativeReflection.DestroyValue_InContainer(GetGMCommandList_OutGMCommandList_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetGMCommandList_ReturnValue_Offset), 0, GetGMCommandList_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetFirstSettingFinish")]
	public unsafe static bool GetFirstSettingFinish()
	{
		if (!GetFirstSettingFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetFirstSettingFinish");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFirstSettingFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFirstSettingFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFirstSettingFinish_FunctionAddress, intPtr, GetFirstSettingFinish_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFirstSettingFinish_ReturnValue_Offset), 0, GetFirstSettingFinish_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/b1.B1Util:GetAvailableMaps")]
	public unsafe static int GetAvailableMaps(out List<string> OutAvailableMaps)
	{
		if (!GetAvailableMaps_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetAvailableMaps");
			OutAvailableMaps = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAvailableMaps_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAvailableMaps_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAvailableMaps_FunctionAddress, intPtr, GetAvailableMaps_ParamsSize);
		OutAvailableMaps = new TArrayCopyMarshaler<string>(1, GetAvailableMaps_OutAvailableMaps_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAvailableMaps_OutAvailableMaps_Offset));
		NativeReflection.DestroyValue_InContainer(GetAvailableMaps_OutAvailableMaps_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAvailableMaps_ReturnValue_Offset), 0, GetAvailableMaps_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetArchiveMarkFinish")]
	public unsafe static bool GetArchiveMarkFinish()
	{
		if (!GetArchiveMarkFinish_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetArchiveMarkFinish");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetArchiveMarkFinish_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetArchiveMarkFinish_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetArchiveMarkFinish_FunctionAddress, intPtr, GetArchiveMarkFinish_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetArchiveMarkFinish_ReturnValue_Offset), 0, GetArchiveMarkFinish_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:GetAgreementReaded")]
	public unsafe static int GetAgreementReaded()
	{
		if (!GetAgreementReaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:GetAgreementReaded");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAgreementReaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAgreementReaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAgreementReaded_FunctionAddress, intPtr, GetAgreementReaded_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAgreementReaded_ReturnValue_Offset), 0, GetAgreementReaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/b1.B1Util:CopyStringToClipboard")]
	public unsafe static void CopyStringToClipboard(string Text)
	{
		if (!CopyStringToClipboard_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:CopyStringToClipboard");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CopyStringToClipboard_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CopyStringToClipboard_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CopyStringToClipboard_Text_Offset), 0, CopyStringToClipboard_Text_PropertyAddress.Address, Text);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CopyStringToClipboard_FunctionAddress, intPtr, CopyStringToClipboard_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CopyStringToClipboard_Text_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/b1.B1Util:CheckIsSimulationPlayMode")]
	public unsafe static bool CheckIsSimulationPlayMode()
	{
		if (!CheckIsSimulationPlayMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.B1Util:CheckIsSimulationPlayMode");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CheckIsSimulationPlayMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CheckIsSimulationPlayMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CheckIsSimulationPlayMode_FunctionAddress, intPtr, CheckIsSimulationPlayMode_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, CheckIsSimulationPlayMode_ReturnValue_Offset), 0, CheckIsSimulationPlayMode_ReturnValue_PropertyAddress.Address);
	}

	static UB1Util()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UB1Util)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UB1Util));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/b1.B1Util");
		SetUISettingPbTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUISettingPbTag");
		SetUISettingPbTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUISettingPbTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUISettingPbTag_TagId_PropertyAddress, SetUISettingPbTag_FunctionAddress, "TagId");
		SetUISettingPbTag_TagId_Offset = NativeReflectionCached.GetPropertyOffset(SetUISettingPbTag_FunctionAddress, "TagId");
		SetUISettingPbTag_TagId_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUISettingPbTag_FunctionAddress, "TagId", Classes.FIntProperty);
		SetUISettingPbTag_IsValid = SetUISettingPbTag_FunctionAddress != IntPtr.Zero && SetUISettingPbTag_TagId_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetUISettingPbTag", SetUISettingPbTag_IsValid);
		SetUISettingData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUISettingData");
		SetUISettingData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUISettingData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUISettingData_SetUISettingData_PropertyAddress, SetUISettingData_FunctionAddress, "SetUISettingData");
		SetUISettingData_SetUISettingData_Offset = NativeReflectionCached.GetPropertyOffset(SetUISettingData_FunctionAddress, "SetUISettingData");
		SetUISettingData_SetUISettingData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUISettingData_FunctionAddress, "SetUISettingData", Classes.FMapProperty);
		SetUISettingData_IsValid = SetUISettingData_FunctionAddress != IntPtr.Zero && SetUISettingData_SetUISettingData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetUISettingData", SetUISettingData_IsValid);
		SetUISettingCustomData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetUISettingCustomData");
		SetUISettingCustomData_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUISettingCustomData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUISettingCustomData_DetailSettingData_PropertyAddress, SetUISettingCustomData_FunctionAddress, "DetailSettingData");
		SetUISettingCustomData_DetailSettingData_Offset = NativeReflectionCached.GetPropertyOffset(SetUISettingCustomData_FunctionAddress, "DetailSettingData");
		SetUISettingCustomData_DetailSettingData_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUISettingCustomData_FunctionAddress, "DetailSettingData", Classes.FMapProperty);
		SetUISettingCustomData_IsValid = SetUISettingCustomData_FunctionAddress != IntPtr.Zero && SetUISettingCustomData_DetailSettingData_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetUISettingCustomData", SetUISettingCustomData_IsValid);
		SetStartupConfigEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartupConfigEnable");
		SetStartupConfigEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartupConfigEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartupConfigEnable_bEnable_PropertyAddress, SetStartupConfigEnable_FunctionAddress, "bEnable");
		SetStartupConfigEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetStartupConfigEnable_FunctionAddress, "bEnable");
		SetStartupConfigEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartupConfigEnable_FunctionAddress, "bEnable", Classes.FBoolProperty);
		SetStartupConfigEnable_IsValid = SetStartupConfigEnable_FunctionAddress != IntPtr.Zero && SetStartupConfigEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetStartupConfigEnable", SetStartupConfigEnable_IsValid);
		SetStartLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartLevelName");
		SetStartLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartLevelName_InStartLevelName_PropertyAddress, SetStartLevelName_FunctionAddress, "InStartLevelName");
		SetStartLevelName_InStartLevelName_Offset = NativeReflectionCached.GetPropertyOffset(SetStartLevelName_FunctionAddress, "InStartLevelName");
		SetStartLevelName_InStartLevelName_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartLevelName_FunctionAddress, "InStartLevelName", Classes.FStrProperty);
		SetStartLevelName_IsValid = SetStartLevelName_FunctionAddress != IntPtr.Zero && SetStartLevelName_InStartLevelName_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetStartLevelName", SetStartLevelName_IsValid);
		SetStartCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetStartCommandList");
		SetStartCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetStartCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetStartCommandList_InStartCommandList_PropertyAddress, SetStartCommandList_FunctionAddress, "InStartCommandList");
		SetStartCommandList_InStartCommandList_Offset = NativeReflectionCached.GetPropertyOffset(SetStartCommandList_FunctionAddress, "InStartCommandList");
		SetStartCommandList_InStartCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetStartCommandList_FunctionAddress, "InStartCommandList", Classes.FArrayProperty);
		SetStartCommandList_IsValid = SetStartCommandList_FunctionAddress != IntPtr.Zero && SetStartCommandList_InStartCommandList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetStartCommandList", SetStartCommandList_IsValid);
		SetPrivacyAgreement_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetPrivacyAgreement");
		SetPrivacyAgreement_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPrivacyAgreement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPrivacyAgreement_NewValue_PropertyAddress, SetPrivacyAgreement_FunctionAddress, "NewValue");
		SetPrivacyAgreement_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetPrivacyAgreement_FunctionAddress, "NewValue");
		SetPrivacyAgreement_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPrivacyAgreement_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetPrivacyAgreement_IsValid = SetPrivacyAgreement_FunctionAddress != IntPtr.Zero && SetPrivacyAgreement_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetPrivacyAgreement", SetPrivacyAgreement_IsValid);
		SetNeverShowStartupUI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetNeverShowStartupUI");
		SetNeverShowStartupUI_ParamsSize = NativeReflection.GetFunctionParamsSize(SetNeverShowStartupUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetNeverShowStartupUI_bInNeverShowStartupUI_PropertyAddress, SetNeverShowStartupUI_FunctionAddress, "bInNeverShowStartupUI");
		SetNeverShowStartupUI_bInNeverShowStartupUI_Offset = NativeReflectionCached.GetPropertyOffset(SetNeverShowStartupUI_FunctionAddress, "bInNeverShowStartupUI");
		SetNeverShowStartupUI_bInNeverShowStartupUI_IsValid = NativeReflectionCached.ValidatePropertyClass(SetNeverShowStartupUI_FunctionAddress, "bInNeverShowStartupUI", Classes.FBoolProperty);
		SetNeverShowStartupUI_IsValid = SetNeverShowStartupUI_FunctionAddress != IntPtr.Zero && SetNeverShowStartupUI_bInNeverShowStartupUI_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetNeverShowStartupUI", SetNeverShowStartupUI_IsValid);
		SetMainMonitorID_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetMainMonitorID");
		SetMainMonitorID_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMainMonitorID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetMainMonitorID_MonitorID_PropertyAddress, SetMainMonitorID_FunctionAddress, "MonitorID");
		SetMainMonitorID_MonitorID_Offset = NativeReflectionCached.GetPropertyOffset(SetMainMonitorID_FunctionAddress, "MonitorID");
		SetMainMonitorID_MonitorID_IsValid = NativeReflectionCached.ValidatePropertyClass(SetMainMonitorID_FunctionAddress, "MonitorID", Classes.FStrProperty);
		SetMainMonitorID_IsValid = SetMainMonitorID_FunctionAddress != IntPtr.Zero && SetMainMonitorID_MonitorID_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetMainMonitorID", SetMainMonitorID_IsValid);
		SetGMCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetGMCommandList");
		SetGMCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGMCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetGMCommandList_InGMCommandList_PropertyAddress, SetGMCommandList_FunctionAddress, "InGMCommandList");
		SetGMCommandList_InGMCommandList_Offset = NativeReflectionCached.GetPropertyOffset(SetGMCommandList_FunctionAddress, "InGMCommandList");
		SetGMCommandList_InGMCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(SetGMCommandList_FunctionAddress, "InGMCommandList", Classes.FMapProperty);
		SetGMCommandList_IsValid = SetGMCommandList_FunctionAddress != IntPtr.Zero && SetGMCommandList_InGMCommandList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetGMCommandList", SetGMCommandList_IsValid);
		SetFirstSettingFinish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetFirstSettingFinish");
		SetFirstSettingFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(SetFirstSettingFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetFirstSettingFinish_NewValue_PropertyAddress, SetFirstSettingFinish_FunctionAddress, "NewValue");
		SetFirstSettingFinish_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetFirstSettingFinish_FunctionAddress, "NewValue");
		SetFirstSettingFinish_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetFirstSettingFinish_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetFirstSettingFinish_IsValid = SetFirstSettingFinish_FunctionAddress != IntPtr.Zero && SetFirstSettingFinish_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetFirstSettingFinish", SetFirstSettingFinish_IsValid);
		SetArchiveMarkFinish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetArchiveMarkFinish");
		SetArchiveMarkFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(SetArchiveMarkFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetArchiveMarkFinish_NewValue_PropertyAddress, SetArchiveMarkFinish_FunctionAddress, "NewValue");
		SetArchiveMarkFinish_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetArchiveMarkFinish_FunctionAddress, "NewValue");
		SetArchiveMarkFinish_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetArchiveMarkFinish_FunctionAddress, "NewValue", Classes.FBoolProperty);
		SetArchiveMarkFinish_IsValid = SetArchiveMarkFinish_FunctionAddress != IntPtr.Zero && SetArchiveMarkFinish_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetArchiveMarkFinish", SetArchiveMarkFinish_IsValid);
		SetAgreementReaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAgreementReaded");
		SetAgreementReaded_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAgreementReaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAgreementReaded_NewValue_PropertyAddress, SetAgreementReaded_FunctionAddress, "NewValue");
		SetAgreementReaded_NewValue_Offset = NativeReflectionCached.GetPropertyOffset(SetAgreementReaded_FunctionAddress, "NewValue");
		SetAgreementReaded_NewValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAgreementReaded_FunctionAddress, "NewValue", Classes.FIntProperty);
		SetAgreementReaded_IsValid = SetAgreementReaded_FunctionAddress != IntPtr.Zero && SetAgreementReaded_NewValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SetAgreementReaded", SetAgreementReaded_IsValid);
		SaveGameUserSettings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SaveGameUserSettings");
		SaveGameUserSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(SaveGameUserSettings_FunctionAddress);
		SaveGameUserSettings_IsValid = SaveGameUserSettings_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:SaveGameUserSettings", SaveGameUserSettings_IsValid);
		OpenFileBrowser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OpenFileBrowser");
		OpenFileBrowser_ParamsSize = NativeReflection.GetFunctionParamsSize(OpenFileBrowser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OpenFileBrowser_FolderPath_PropertyAddress, OpenFileBrowser_FunctionAddress, "FolderPath");
		OpenFileBrowser_FolderPath_Offset = NativeReflectionCached.GetPropertyOffset(OpenFileBrowser_FunctionAddress, "FolderPath");
		OpenFileBrowser_FolderPath_IsValid = NativeReflectionCached.ValidatePropertyClass(OpenFileBrowser_FunctionAddress, "FolderPath", Classes.FStrProperty);
		OpenFileBrowser_IsValid = OpenFileBrowser_FunctionAddress != IntPtr.Zero && OpenFileBrowser_FolderPath_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:OpenFileBrowser", OpenFileBrowser_IsValid);
		IsStartupConfigEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsStartupConfigEnable");
		IsStartupConfigEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStartupConfigEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStartupConfigEnable_ReturnValue_PropertyAddress, IsStartupConfigEnable_FunctionAddress, "ReturnValue");
		IsStartupConfigEnable_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStartupConfigEnable_FunctionAddress, "ReturnValue");
		IsStartupConfigEnable_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStartupConfigEnable_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStartupConfigEnable_IsValid = IsStartupConfigEnable_FunctionAddress != IntPtr.Zero && IsStartupConfigEnable_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:IsStartupConfigEnable", IsStartupConfigEnable_IsValid);
		IsNeverShowStartupUI_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsNeverShowStartupUI");
		IsNeverShowStartupUI_ParamsSize = NativeReflection.GetFunctionParamsSize(IsNeverShowStartupUI_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsNeverShowStartupUI_ReturnValue_PropertyAddress, IsNeverShowStartupUI_FunctionAddress, "ReturnValue");
		IsNeverShowStartupUI_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsNeverShowStartupUI_FunctionAddress, "ReturnValue");
		IsNeverShowStartupUI_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsNeverShowStartupUI_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsNeverShowStartupUI_IsValid = IsNeverShowStartupUI_FunctionAddress != IntPtr.Zero && IsNeverShowStartupUI_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:IsNeverShowStartupUI", IsNeverShowStartupUI_IsValid);
		GetUISettingPbTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUISettingPbTag");
		GetUISettingPbTag_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUISettingPbTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUISettingPbTag_ReturnValue_PropertyAddress, GetUISettingPbTag_FunctionAddress, "ReturnValue");
		GetUISettingPbTag_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUISettingPbTag_FunctionAddress, "ReturnValue");
		GetUISettingPbTag_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUISettingPbTag_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUISettingPbTag_IsValid = GetUISettingPbTag_FunctionAddress != IntPtr.Zero && GetUISettingPbTag_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetUISettingPbTag", GetUISettingPbTag_IsValid);
		GetUISettingData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUISettingData");
		GetUISettingData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUISettingData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUISettingData_OutUISettingData_PropertyAddress, GetUISettingData_FunctionAddress, "OutUISettingData");
		GetUISettingData_OutUISettingData_Offset = NativeReflectionCached.GetPropertyOffset(GetUISettingData_FunctionAddress, "OutUISettingData");
		GetUISettingData_OutUISettingData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUISettingData_FunctionAddress, "OutUISettingData", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUISettingData_ReturnValue_PropertyAddress, GetUISettingData_FunctionAddress, "ReturnValue");
		GetUISettingData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUISettingData_FunctionAddress, "ReturnValue");
		GetUISettingData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUISettingData_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUISettingData_IsValid = GetUISettingData_FunctionAddress != IntPtr.Zero && GetUISettingData_OutUISettingData_IsValid && GetUISettingData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetUISettingData", GetUISettingData_IsValid);
		GetUISettingCustomData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetUISettingCustomData");
		GetUISettingCustomData_ParamsSize = NativeReflection.GetFunctionParamsSize(GetUISettingCustomData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetUISettingCustomData_OutDetailSettingData_PropertyAddress, GetUISettingCustomData_FunctionAddress, "OutDetailSettingData");
		GetUISettingCustomData_OutDetailSettingData_Offset = NativeReflectionCached.GetPropertyOffset(GetUISettingCustomData_FunctionAddress, "OutDetailSettingData");
		GetUISettingCustomData_OutDetailSettingData_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUISettingCustomData_FunctionAddress, "OutDetailSettingData", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetUISettingCustomData_ReturnValue_PropertyAddress, GetUISettingCustomData_FunctionAddress, "ReturnValue");
		GetUISettingCustomData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetUISettingCustomData_FunctionAddress, "ReturnValue");
		GetUISettingCustomData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetUISettingCustomData_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetUISettingCustomData_IsValid = GetUISettingCustomData_FunctionAddress != IntPtr.Zero && GetUISettingCustomData_OutDetailSettingData_IsValid && GetUISettingCustomData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetUISettingCustomData", GetUISettingCustomData_IsValid);
		GetStartLevelName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartLevelName");
		GetStartLevelName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartLevelName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartLevelName_ReturnValue_PropertyAddress, GetStartLevelName_FunctionAddress, "ReturnValue");
		GetStartLevelName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartLevelName_FunctionAddress, "ReturnValue");
		GetStartLevelName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartLevelName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetStartLevelName_IsValid = GetStartLevelName_FunctionAddress != IntPtr.Zero && GetStartLevelName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetStartLevelName", GetStartLevelName_IsValid);
		GetStartCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStartCommandList");
		GetStartCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStartCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStartCommandList_OutStartCommandList_PropertyAddress, GetStartCommandList_FunctionAddress, "OutStartCommandList");
		GetStartCommandList_OutStartCommandList_Offset = NativeReflectionCached.GetPropertyOffset(GetStartCommandList_FunctionAddress, "OutStartCommandList");
		GetStartCommandList_OutStartCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartCommandList_FunctionAddress, "OutStartCommandList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStartCommandList_ReturnValue_PropertyAddress, GetStartCommandList_FunctionAddress, "ReturnValue");
		GetStartCommandList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStartCommandList_FunctionAddress, "ReturnValue");
		GetStartCommandList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStartCommandList_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetStartCommandList_IsValid = GetStartCommandList_FunctionAddress != IntPtr.Zero && GetStartCommandList_OutStartCommandList_IsValid && GetStartCommandList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetStartCommandList", GetStartCommandList_IsValid);
		GetRandomNumberInt_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRandomNumberInt");
		GetRandomNumberInt_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomNumberInt_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberInt_LeftNum_PropertyAddress, GetRandomNumberInt_FunctionAddress, "LeftNum");
		GetRandomNumberInt_LeftNum_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberInt_FunctionAddress, "LeftNum");
		GetRandomNumberInt_LeftNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberInt_FunctionAddress, "LeftNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberInt_RightNum_PropertyAddress, GetRandomNumberInt_FunctionAddress, "RightNum");
		GetRandomNumberInt_RightNum_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberInt_FunctionAddress, "RightNum");
		GetRandomNumberInt_RightNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberInt_FunctionAddress, "RightNum", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberInt_ReturnValue_PropertyAddress, GetRandomNumberInt_FunctionAddress, "ReturnValue");
		GetRandomNumberInt_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberInt_FunctionAddress, "ReturnValue");
		GetRandomNumberInt_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberInt_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetRandomNumberInt_IsValid = GetRandomNumberInt_FunctionAddress != IntPtr.Zero && GetRandomNumberInt_LeftNum_IsValid && GetRandomNumberInt_RightNum_IsValid && GetRandomNumberInt_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetRandomNumberInt", GetRandomNumberInt_IsValid);
		GetRandomNumberFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetRandomNumberFloat");
		GetRandomNumberFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRandomNumberFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberFloat_LeftNum_PropertyAddress, GetRandomNumberFloat_FunctionAddress, "LeftNum");
		GetRandomNumberFloat_LeftNum_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberFloat_FunctionAddress, "LeftNum");
		GetRandomNumberFloat_LeftNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberFloat_FunctionAddress, "LeftNum", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberFloat_RightNum_PropertyAddress, GetRandomNumberFloat_FunctionAddress, "RightNum");
		GetRandomNumberFloat_RightNum_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberFloat_FunctionAddress, "RightNum");
		GetRandomNumberFloat_RightNum_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberFloat_FunctionAddress, "RightNum", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetRandomNumberFloat_ReturnValue_PropertyAddress, GetRandomNumberFloat_FunctionAddress, "ReturnValue");
		GetRandomNumberFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRandomNumberFloat_FunctionAddress, "ReturnValue");
		GetRandomNumberFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRandomNumberFloat_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRandomNumberFloat_IsValid = GetRandomNumberFloat_FunctionAddress != IntPtr.Zero && GetRandomNumberFloat_LeftNum_IsValid && GetRandomNumberFloat_RightNum_IsValid && GetRandomNumberFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetRandomNumberFloat", GetRandomNumberFloat_IsValid);
		GetPrivacyAgreement_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPrivacyAgreement");
		GetPrivacyAgreement_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPrivacyAgreement_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPrivacyAgreement_ReturnValue_PropertyAddress, GetPrivacyAgreement_FunctionAddress, "ReturnValue");
		GetPrivacyAgreement_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPrivacyAgreement_FunctionAddress, "ReturnValue");
		GetPrivacyAgreement_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPrivacyAgreement_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPrivacyAgreement_IsValid = GetPrivacyAgreement_FunctionAddress != IntPtr.Zero && GetPrivacyAgreement_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetPrivacyAgreement", GetPrivacyAgreement_IsValid);
		GetGMCommandList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGMCommandList");
		GetGMCommandList_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGMCommandList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGMCommandList_OutGMCommandList_PropertyAddress, GetGMCommandList_FunctionAddress, "OutGMCommandList");
		GetGMCommandList_OutGMCommandList_Offset = NativeReflectionCached.GetPropertyOffset(GetGMCommandList_FunctionAddress, "OutGMCommandList");
		GetGMCommandList_OutGMCommandList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGMCommandList_FunctionAddress, "OutGMCommandList", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref GetGMCommandList_ReturnValue_PropertyAddress, GetGMCommandList_FunctionAddress, "ReturnValue");
		GetGMCommandList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGMCommandList_FunctionAddress, "ReturnValue");
		GetGMCommandList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGMCommandList_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetGMCommandList_IsValid = GetGMCommandList_FunctionAddress != IntPtr.Zero && GetGMCommandList_OutGMCommandList_IsValid && GetGMCommandList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetGMCommandList", GetGMCommandList_IsValid);
		GetFirstSettingFinish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFirstSettingFinish");
		GetFirstSettingFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFirstSettingFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFirstSettingFinish_ReturnValue_PropertyAddress, GetFirstSettingFinish_FunctionAddress, "ReturnValue");
		GetFirstSettingFinish_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFirstSettingFinish_FunctionAddress, "ReturnValue");
		GetFirstSettingFinish_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFirstSettingFinish_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFirstSettingFinish_IsValid = GetFirstSettingFinish_FunctionAddress != IntPtr.Zero && GetFirstSettingFinish_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetFirstSettingFinish", GetFirstSettingFinish_IsValid);
		GetAvailableMaps_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAvailableMaps");
		GetAvailableMaps_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAvailableMaps_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableMaps_OutAvailableMaps_PropertyAddress, GetAvailableMaps_FunctionAddress, "OutAvailableMaps");
		GetAvailableMaps_OutAvailableMaps_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableMaps_FunctionAddress, "OutAvailableMaps");
		GetAvailableMaps_OutAvailableMaps_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableMaps_FunctionAddress, "OutAvailableMaps", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAvailableMaps_ReturnValue_PropertyAddress, GetAvailableMaps_FunctionAddress, "ReturnValue");
		GetAvailableMaps_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAvailableMaps_FunctionAddress, "ReturnValue");
		GetAvailableMaps_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAvailableMaps_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAvailableMaps_IsValid = GetAvailableMaps_FunctionAddress != IntPtr.Zero && GetAvailableMaps_OutAvailableMaps_IsValid && GetAvailableMaps_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetAvailableMaps", GetAvailableMaps_IsValid);
		GetArchiveMarkFinish_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetArchiveMarkFinish");
		GetArchiveMarkFinish_ParamsSize = NativeReflection.GetFunctionParamsSize(GetArchiveMarkFinish_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetArchiveMarkFinish_ReturnValue_PropertyAddress, GetArchiveMarkFinish_FunctionAddress, "ReturnValue");
		GetArchiveMarkFinish_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetArchiveMarkFinish_FunctionAddress, "ReturnValue");
		GetArchiveMarkFinish_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetArchiveMarkFinish_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetArchiveMarkFinish_IsValid = GetArchiveMarkFinish_FunctionAddress != IntPtr.Zero && GetArchiveMarkFinish_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetArchiveMarkFinish", GetArchiveMarkFinish_IsValid);
		GetAgreementReaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAgreementReaded");
		GetAgreementReaded_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAgreementReaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAgreementReaded_ReturnValue_PropertyAddress, GetAgreementReaded_FunctionAddress, "ReturnValue");
		GetAgreementReaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAgreementReaded_FunctionAddress, "ReturnValue");
		GetAgreementReaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAgreementReaded_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetAgreementReaded_IsValid = GetAgreementReaded_FunctionAddress != IntPtr.Zero && GetAgreementReaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:GetAgreementReaded", GetAgreementReaded_IsValid);
		CopyStringToClipboard_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CopyStringToClipboard");
		CopyStringToClipboard_ParamsSize = NativeReflection.GetFunctionParamsSize(CopyStringToClipboard_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CopyStringToClipboard_Text_PropertyAddress, CopyStringToClipboard_FunctionAddress, "Text");
		CopyStringToClipboard_Text_Offset = NativeReflectionCached.GetPropertyOffset(CopyStringToClipboard_FunctionAddress, "Text");
		CopyStringToClipboard_Text_IsValid = NativeReflectionCached.ValidatePropertyClass(CopyStringToClipboard_FunctionAddress, "Text", Classes.FStrProperty);
		CopyStringToClipboard_IsValid = CopyStringToClipboard_FunctionAddress != IntPtr.Zero && CopyStringToClipboard_Text_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:CopyStringToClipboard", CopyStringToClipboard_IsValid);
		CheckIsSimulationPlayMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CheckIsSimulationPlayMode");
		CheckIsSimulationPlayMode_ParamsSize = NativeReflection.GetFunctionParamsSize(CheckIsSimulationPlayMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CheckIsSimulationPlayMode_ReturnValue_PropertyAddress, CheckIsSimulationPlayMode_FunctionAddress, "ReturnValue");
		CheckIsSimulationPlayMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CheckIsSimulationPlayMode_FunctionAddress, "ReturnValue");
		CheckIsSimulationPlayMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CheckIsSimulationPlayMode_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		CheckIsSimulationPlayMode_IsValid = CheckIsSimulationPlayMode_FunctionAddress != IntPtr.Zero && CheckIsSimulationPlayMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.B1Util:CheckIsSimulationPlayMode", CheckIsSimulationPlayMode_IsValid);
	}
}
