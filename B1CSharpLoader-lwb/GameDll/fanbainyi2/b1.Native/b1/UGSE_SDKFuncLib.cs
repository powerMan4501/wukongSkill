using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib", "UnrealExtent", UnrealModuleType.Game)]
public class UGSE_SDKFuncLib : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool UsbStorageIsExist_IsValid;

	private static IntPtr UsbStorageIsExist_FunctionAddress;

	private static int UsbStorageIsExist_ParamsSize;

	private static bool UsbStorageIsExist_DeviceIdStr_IsValid;

	private static FFieldAddress UsbStorageIsExist_DeviceIdStr_PropertyAddress;

	private static int UsbStorageIsExist_DeviceIdStr_Offset;

	private static bool UsbStorageIsExist_Path_IsValid;

	private static FFieldAddress UsbStorageIsExist_Path_PropertyAddress;

	private static int UsbStorageIsExist_Path_Offset;

	private static bool UsbStorageIsExist_IsFile_IsValid;

	private static FFieldAddress UsbStorageIsExist_IsFile_PropertyAddress;

	private static int UsbStorageIsExist_IsFile_Offset;

	private static bool UsbStorageIsExist_ReturnValue_IsValid;

	private static FFieldAddress UsbStorageIsExist_ReturnValue_PropertyAddress;

	private static int UsbStorageIsExist_ReturnValue_Offset;

	private static bool TestCallAndroidFunc_IsValid;

	private static IntPtr TestCallAndroidFunc_FunctionAddress;

	private static int TestCallAndroidFunc_ParamsSize;

	private static bool TestCallAndroidFunc_content_IsValid;

	private static FFieldAddress TestCallAndroidFunc_content_PropertyAddress;

	private static int TestCallAndroidFunc_content_Offset;

	private static bool TestCallAndroidFunc_ReturnValue_IsValid;

	private static FFieldAddress TestCallAndroidFunc_ReturnValue_PropertyAddress;

	private static int TestCallAndroidFunc_ReturnValue_Offset;

	private static bool StartHttpRawDataRequest_IsValid;

	private static IntPtr StartHttpRawDataRequest_FunctionAddress;

	private static int StartHttpRawDataRequest_ParamsSize;

	private static bool StartHttpRawDataRequest_Url_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_Url_PropertyAddress;

	private static int StartHttpRawDataRequest_Url_Offset;

	private static bool StartHttpRawDataRequest_Method_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_Method_PropertyAddress;

	private static int StartHttpRawDataRequest_Method_Offset;

	private static bool StartHttpRawDataRequest_ExHeaders_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_ExHeaders_PropertyAddress;

	private static int StartHttpRawDataRequest_ExHeaders_Offset;

	private static bool StartHttpRawDataRequest_PostRawData_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_PostRawData_PropertyAddress;

	private static int StartHttpRawDataRequest_PostRawData_Offset;

	private static bool StartHttpRawDataRequest_Listener_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_Listener_PropertyAddress;

	private static int StartHttpRawDataRequest_Listener_Offset;

	private static bool StartHttpRawDataRequest_RequestTimeout_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_RequestTimeout_PropertyAddress;

	private static int StartHttpRawDataRequest_RequestTimeout_Offset;

	private static bool StartHttpRawDataRequest_ReturnValue_IsValid;

	private static FFieldAddress StartHttpRawDataRequest_ReturnValue_PropertyAddress;

	private static int StartHttpRawDataRequest_ReturnValue_Offset;

	private static bool StartHttpBase64DataRequest_IsValid;

	private static IntPtr StartHttpBase64DataRequest_FunctionAddress;

	private static int StartHttpBase64DataRequest_ParamsSize;

	private static bool StartHttpBase64DataRequest_Url_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_Url_PropertyAddress;

	private static int StartHttpBase64DataRequest_Url_Offset;

	private static bool StartHttpBase64DataRequest_Method_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_Method_PropertyAddress;

	private static int StartHttpBase64DataRequest_Method_Offset;

	private static bool StartHttpBase64DataRequest_ExHeaders_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_ExHeaders_PropertyAddress;

	private static int StartHttpBase64DataRequest_ExHeaders_Offset;

	private static bool StartHttpBase64DataRequest_Base64PostData_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_Base64PostData_PropertyAddress;

	private static int StartHttpBase64DataRequest_Base64PostData_Offset;

	private static bool StartHttpBase64DataRequest_Listener_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_Listener_PropertyAddress;

	private static int StartHttpBase64DataRequest_Listener_Offset;

	private static bool StartHttpBase64DataRequest_RequestTimeout_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_RequestTimeout_PropertyAddress;

	private static int StartHttpBase64DataRequest_RequestTimeout_Offset;

	private static bool StartHttpBase64DataRequest_ReturnValue_IsValid;

	private static FFieldAddress StartHttpBase64DataRequest_ReturnValue_PropertyAddress;

	private static int StartHttpBase64DataRequest_ReturnValue_Offset;

	private static bool SetCrashReportClientEnable_IsValid;

	private static IntPtr SetCrashReportClientEnable_FunctionAddress;

	private static int SetCrashReportClientEnable_ParamsSize;

	private static bool SetCrashReportClientEnable_bEnable_IsValid;

	private static FFieldAddress SetCrashReportClientEnable_bEnable_PropertyAddress;

	private static int SetCrashReportClientEnable_bEnable_Offset;

	private static bool SetBuglyUserMap_IsValid;

	private static IntPtr SetBuglyUserMap_FunctionAddress;

	private static int SetBuglyUserMap_ParamsSize;

	private static bool SetBuglyUserMap_key_IsValid;

	private static FFieldAddress SetBuglyUserMap_key_PropertyAddress;

	private static int SetBuglyUserMap_key_Offset;

	private static bool SetBuglyUserMap_value_IsValid;

	private static FFieldAddress SetBuglyUserMap_value_PropertyAddress;

	private static int SetBuglyUserMap_value_Offset;

	private static bool SetBuglyUserMap_ReturnValue_IsValid;

	private static FFieldAddress SetBuglyUserMap_ReturnValue_PropertyAddress;

	private static int SetBuglyUserMap_ReturnValue_Offset;

	private static bool SetAppIsAutoTestingMode_IsValid;

	private static IntPtr SetAppIsAutoTestingMode_FunctionAddress;

	private static int SetAppIsAutoTestingMode_ParamsSize;

	private static bool SetAppIsAutoTestingMode_bEnable_IsValid;

	private static FFieldAddress SetAppIsAutoTestingMode_bEnable_PropertyAddress;

	private static int SetAppIsAutoTestingMode_bEnable_Offset;

	private static bool SentryCrashReporterSetUser_IsValid;

	private static IntPtr SentryCrashReporterSetUser_FunctionAddress;

	private static int SentryCrashReporterSetUser_ParamsSize;

	private static bool SentryCrashReporterSetUser_UserKey_IsValid;

	private static FFieldAddress SentryCrashReporterSetUser_UserKey_PropertyAddress;

	private static int SentryCrashReporterSetUser_UserKey_Offset;

	private static bool SentryCrashReporterSetUser_UserValue_IsValid;

	private static FFieldAddress SentryCrashReporterSetUser_UserValue_PropertyAddress;

	private static int SentryCrashReporterSetUser_UserValue_Offset;

	private static bool SentryCrashReporterSetTag_IsValid;

	private static IntPtr SentryCrashReporterSetTag_FunctionAddress;

	private static int SentryCrashReporterSetTag_ParamsSize;

	private static bool SentryCrashReporterSetTag_Key_IsValid;

	private static FFieldAddress SentryCrashReporterSetTag_Key_PropertyAddress;

	private static int SentryCrashReporterSetTag_Key_Offset;

	private static bool SentryCrashReporterSetTag_Value_IsValid;

	private static FFieldAddress SentryCrashReporterSetTag_Value_PropertyAddress;

	private static int SentryCrashReporterSetTag_Value_Offset;

	private static bool SentryCrashReporterSetRoot_IsValid;

	private static IntPtr SentryCrashReporterSetRoot_FunctionAddress;

	private static int SentryCrashReporterSetRoot_ParamsSize;

	private static bool SentryCrashReporterSetRoot_RootKey_IsValid;

	private static FFieldAddress SentryCrashReporterSetRoot_RootKey_PropertyAddress;

	private static int SentryCrashReporterSetRoot_RootKey_Offset;

	private static bool SentryCrashReporterSetRoot_RootValue_IsValid;

	private static FFieldAddress SentryCrashReporterSetRoot_RootValue_PropertyAddress;

	private static int SentryCrashReporterSetRoot_RootValue_Offset;

	private static bool SentryCrashReporterSetContext_IsValid;

	private static IntPtr SentryCrashReporterSetContext_FunctionAddress;

	private static int SentryCrashReporterSetContext_ParamsSize;

	private static bool SentryCrashReporterSetContext_Key_IsValid;

	private static FFieldAddress SentryCrashReporterSetContext_Key_PropertyAddress;

	private static int SentryCrashReporterSetContext_Key_Offset;

	private static bool SentryCrashReporterSetContext_ContextValues_IsValid;

	private static FFieldAddress SentryCrashReporterSetContext_ContextValues_PropertyAddress;

	private static int SentryCrashReporterSetContext_ContextValues_Offset;

	private static bool ReenableMediaPlay_IsValid;

	private static IntPtr ReenableMediaPlay_FunctionAddress;

	private static int ReenableMediaPlay_ParamsSize;

	private static bool QueryIsOwnPS5EntitlementSync_IsValid;

	private static IntPtr QueryIsOwnPS5EntitlementSync_FunctionAddress;

	private static int QueryIsOwnPS5EntitlementSync_ParamsSize;

	private static bool QueryIsOwnPS5EntitlementSync_QueryEntitlementId_IsValid;

	private static FFieldAddress QueryIsOwnPS5EntitlementSync_QueryEntitlementId_PropertyAddress;

	private static int QueryIsOwnPS5EntitlementSync_QueryEntitlementId_Offset;

	private static bool QueryIsOwnPS5EntitlementSync_ReturnValue_IsValid;

	private static FFieldAddress QueryIsOwnPS5EntitlementSync_ReturnValue_PropertyAddress;

	private static int QueryIsOwnPS5EntitlementSync_ReturnValue_Offset;

	private static bool PS5UsbSelectDevice_IsValid;

	private static IntPtr PS5UsbSelectDevice_FunctionAddress;

	private static int PS5UsbSelectDevice_ParamsSize;

	private static bool PS5UsbSelectDevice_UsrDir_IsValid;

	private static FFieldAddress PS5UsbSelectDevice_UsrDir_PropertyAddress;

	private static int PS5UsbSelectDevice_UsrDir_Offset;

	private static bool PS5UsbSelectDevice_OutDeviceId_IsValid;

	private static FFieldAddress PS5UsbSelectDevice_OutDeviceId_PropertyAddress;

	private static int PS5UsbSelectDevice_OutDeviceId_Offset;

	private static bool PS5UsbSelectDevice_ReturnValue_IsValid;

	private static FFieldAddress PS5UsbSelectDevice_ReturnValue_PropertyAddress;

	private static int PS5UsbSelectDevice_ReturnValue_Offset;

	private static bool PS5UsbMkSubDir_IsValid;

	private static IntPtr PS5UsbMkSubDir_FunctionAddress;

	private static int PS5UsbMkSubDir_ParamsSize;

	private static bool PS5UsbMkSubDir_DeviceId_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_DeviceId_PropertyAddress;

	private static int PS5UsbMkSubDir_DeviceId_Offset;

	private static bool PS5UsbMkSubDir_MountPoint_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_MountPoint_PropertyAddress;

	private static int PS5UsbMkSubDir_MountPoint_Offset;

	private static bool PS5UsbMkSubDir_UsrDir_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_UsrDir_PropertyAddress;

	private static int PS5UsbMkSubDir_UsrDir_Offset;

	private static bool PS5UsbMkSubDir_SubDir_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_SubDir_PropertyAddress;

	private static int PS5UsbMkSubDir_SubDir_Offset;

	private static bool PS5UsbMkSubDir_OutDirPath_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_OutDirPath_PropertyAddress;

	private static int PS5UsbMkSubDir_OutDirPath_Offset;

	private static bool PS5UsbMkSubDir_ReturnValue_IsValid;

	private static FFieldAddress PS5UsbMkSubDir_ReturnValue_PropertyAddress;

	private static int PS5UsbMkSubDir_ReturnValue_Offset;

	private static bool PS5RequestUnMapUsb_IsValid;

	private static IntPtr PS5RequestUnMapUsb_FunctionAddress;

	private static int PS5RequestUnMapUsb_ParamsSize;

	private static bool PS5RequestUnMapUsb_DeviceId_IsValid;

	private static FFieldAddress PS5RequestUnMapUsb_DeviceId_PropertyAddress;

	private static int PS5RequestUnMapUsb_DeviceId_Offset;

	private static bool PS5RequestUnMapUsb_UsrDir_IsValid;

	private static FFieldAddress PS5RequestUnMapUsb_UsrDir_PropertyAddress;

	private static int PS5RequestUnMapUsb_UsrDir_Offset;

	private static bool PS5RequestUnMapUsb_ReturnValue_IsValid;

	private static FFieldAddress PS5RequestUnMapUsb_ReturnValue_PropertyAddress;

	private static int PS5RequestUnMapUsb_ReturnValue_Offset;

	private static bool PS5RequestMapUsb_IsValid;

	private static IntPtr PS5RequestMapUsb_FunctionAddress;

	private static int PS5RequestMapUsb_ParamsSize;

	private static bool PS5RequestMapUsb_DeviceId_IsValid;

	private static FFieldAddress PS5RequestMapUsb_DeviceId_PropertyAddress;

	private static int PS5RequestMapUsb_DeviceId_Offset;

	private static bool PS5RequestMapUsb_UsrDir_IsValid;

	private static FFieldAddress PS5RequestMapUsb_UsrDir_PropertyAddress;

	private static int PS5RequestMapUsb_UsrDir_Offset;

	private static bool PS5RequestMapUsb_OutMountPoint_IsValid;

	private static FFieldAddress PS5RequestMapUsb_OutMountPoint_PropertyAddress;

	private static int PS5RequestMapUsb_OutMountPoint_Offset;

	private static bool PS5RequestMapUsb_ReturnValue_IsValid;

	private static FFieldAddress PS5RequestMapUsb_ReturnValue_PropertyAddress;

	private static int PS5RequestMapUsb_ReturnValue_Offset;

	private static bool PS5ExportDataToUsb_IsValid;

	private static IntPtr PS5ExportDataToUsb_FunctionAddress;

	private static int PS5ExportDataToUsb_ParamsSize;

	private static bool PS5ExportDataToUsb_FileName_IsValid;

	private static FFieldAddress PS5ExportDataToUsb_FileName_PropertyAddress;

	private static int PS5ExportDataToUsb_FileName_Offset;

	private static bool PS5ExportDataToUsb_FileContentData_IsValid;

	private static FFieldAddress PS5ExportDataToUsb_FileContentData_PropertyAddress;

	private static int PS5ExportDataToUsb_FileContentData_Offset;

	private static bool PS5ExportDataToUsb_ReturnValue_IsValid;

	private static FFieldAddress PS5ExportDataToUsb_ReturnValue_PropertyAddress;

	private static int PS5ExportDataToUsb_ReturnValue_Offset;

	private static bool PrintCachedEntitlements_IsValid;

	private static IntPtr PrintCachedEntitlements_FunctionAddress;

	private static int PrintCachedEntitlements_ParamsSize;

	private static bool PostExceptionSample_IsValid;

	private static IntPtr PostExceptionSample_FunctionAddress;

	private static int PostExceptionSample_ParamsSize;

	private static bool PostExceptionSample_message_IsValid;

	private static FFieldAddress PostExceptionSample_message_PropertyAddress;

	private static int PostExceptionSample_message_Offset;

	private static bool PostExceptionSample_ReturnValue_IsValid;

	private static FFieldAddress PostExceptionSample_ReturnValue_PropertyAddress;

	private static int PostExceptionSample_ReturnValue_Offset;

	private static bool PostException_IsValid;

	private static IntPtr PostException_FunctionAddress;

	private static int PostException_ParamsSize;

	private static bool PostException_type_IsValid;

	private static FFieldAddress PostException_type_PropertyAddress;

	private static int PostException_type_Offset;

	private static bool PostException_name_IsValid;

	private static FFieldAddress PostException_name_PropertyAddress;

	private static int PostException_name_Offset;

	private static bool PostException_message_IsValid;

	private static FFieldAddress PostException_message_PropertyAddress;

	private static int PostException_message_Offset;

	private static bool PostException_stackTrace_IsValid;

	private static FFieldAddress PostException_stackTrace_PropertyAddress;

	private static int PostException_stackTrace_Offset;

	private static bool PostException_ReturnValue_IsValid;

	private static FFieldAddress PostException_ReturnValue_PropertyAddress;

	private static int PostException_ReturnValue_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_IsValid;

	private static IntPtr NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_ParamsSize;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_Offset;

	private static bool NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_IsValid;

	private static FFieldAddress NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_PropertyAddress;

	private static int NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_Offset;

	private static bool IsPureVersion_IsValid;

	private static IntPtr IsPureVersion_FunctionAddress;

	private static int IsPureVersion_ParamsSize;

	private static bool IsPureVersion_ReturnValue_IsValid;

	private static FFieldAddress IsPureVersion_ReturnValue_PropertyAddress;

	private static int IsPureVersion_ReturnValue_Offset;

	private static bool IsCleanVersion_IsValid;

	private static IntPtr IsCleanVersion_FunctionAddress;

	private static int IsCleanVersion_ParamsSize;

	private static bool IsCleanVersion_ReturnValue_IsValid;

	private static FFieldAddress IsCleanVersion_ReturnValue_PropertyAddress;

	private static int IsCleanVersion_ReturnValue_Offset;

	private static bool HttpPostFileList_IsValid;

	private static IntPtr HttpPostFileList_FunctionAddress;

	private static int HttpPostFileList_ParamsSize;

	private static bool HttpPostFileList_PostUrl_IsValid;

	private static FFieldAddress HttpPostFileList_PostUrl_PropertyAddress;

	private static int HttpPostFileList_PostUrl_Offset;

	private static bool HttpPostFileList_ExHeaders_IsValid;

	private static FFieldAddress HttpPostFileList_ExHeaders_PropertyAddress;

	private static int HttpPostFileList_ExHeaders_Offset;

	private static bool HttpPostFileList_FilePathList_IsValid;

	private static FFieldAddress HttpPostFileList_FilePathList_PropertyAddress;

	private static int HttpPostFileList_FilePathList_Offset;

	private static bool HttpPostFileList_Listener_IsValid;

	private static FFieldAddress HttpPostFileList_Listener_PropertyAddress;

	private static int HttpPostFileList_Listener_Offset;

	private static bool HttpPostFileList_ReturnValue_IsValid;

	private static FFieldAddress HttpPostFileList_ReturnValue_PropertyAddress;

	private static int HttpPostFileList_ReturnValue_Offset;

	private static bool HttpPostFileContent_IsValid;

	private static IntPtr HttpPostFileContent_FunctionAddress;

	private static int HttpPostFileContent_ParamsSize;

	private static bool HttpPostFileContent_PostUrl_IsValid;

	private static FFieldAddress HttpPostFileContent_PostUrl_PropertyAddress;

	private static int HttpPostFileContent_PostUrl_Offset;

	private static bool HttpPostFileContent_ExHeaders_IsValid;

	private static FFieldAddress HttpPostFileContent_ExHeaders_PropertyAddress;

	private static int HttpPostFileContent_ExHeaders_Offset;

	private static bool HttpPostFileContent_FileName_IsValid;

	private static FFieldAddress HttpPostFileContent_FileName_PropertyAddress;

	private static int HttpPostFileContent_FileName_Offset;

	private static bool HttpPostFileContent_FileContentData_IsValid;

	private static FFieldAddress HttpPostFileContent_FileContentData_PropertyAddress;

	private static int HttpPostFileContent_FileContentData_Offset;

	private static bool HttpPostFileContent_Listener_IsValid;

	private static FFieldAddress HttpPostFileContent_Listener_PropertyAddress;

	private static int HttpPostFileContent_Listener_Offset;

	private static bool HttpPostFileContent_ReturnValue_IsValid;

	private static FFieldAddress HttpPostFileContent_ReturnValue_PropertyAddress;

	private static int HttpPostFileContent_ReturnValue_Offset;

	private static bool HttpPostFile_IsValid;

	private static IntPtr HttpPostFile_FunctionAddress;

	private static int HttpPostFile_ParamsSize;

	private static bool HttpPostFile_PostUrl_IsValid;

	private static FFieldAddress HttpPostFile_PostUrl_PropertyAddress;

	private static int HttpPostFile_PostUrl_Offset;

	private static bool HttpPostFile_ExHeaders_IsValid;

	private static FFieldAddress HttpPostFile_ExHeaders_PropertyAddress;

	private static int HttpPostFile_ExHeaders_Offset;

	private static bool HttpPostFile_FilePath_IsValid;

	private static FFieldAddress HttpPostFile_FilePath_PropertyAddress;

	private static int HttpPostFile_FilePath_Offset;

	private static bool HttpPostFile_Listener_IsValid;

	private static FFieldAddress HttpPostFile_Listener_PropertyAddress;

	private static int HttpPostFile_Listener_Offset;

	private static bool HttpPostFile_ReturnValue_IsValid;

	private static FFieldAddress HttpPostFile_ReturnValue_PropertyAddress;

	private static int HttpPostFile_ReturnValue_Offset;

	private static bool GetPS5UserDefinedParam_IsValid;

	private static IntPtr GetPS5UserDefinedParam_FunctionAddress;

	private static int GetPS5UserDefinedParam_ParamsSize;

	private static bool GetPS5UserDefinedParam_index_IsValid;

	private static FFieldAddress GetPS5UserDefinedParam_index_PropertyAddress;

	private static int GetPS5UserDefinedParam_index_Offset;

	private static bool GetPS5UserDefinedParam_ReturnValue_IsValid;

	private static FFieldAddress GetPS5UserDefinedParam_ReturnValue_PropertyAddress;

	private static int GetPS5UserDefinedParam_ReturnValue_Offset;

	private static bool GetPS5UserAccountRegionCode_IsValid;

	private static IntPtr GetPS5UserAccountRegionCode_FunctionAddress;

	private static int GetPS5UserAccountRegionCode_ParamsSize;

	private static bool GetPS5UserAccountRegionCode_ReturnValue_IsValid;

	private static FFieldAddress GetPS5UserAccountRegionCode_ReturnValue_PropertyAddress;

	private static int GetPS5UserAccountRegionCode_ReturnValue_Offset;

	private static bool GetPS5UsbStorageDeviceInfo_IsValid;

	private static IntPtr GetPS5UsbStorageDeviceInfo_FunctionAddress;

	private static int GetPS5UsbStorageDeviceInfo_ParamsSize;

	private static bool GetPS5UsbStorageDeviceInfo_DeviceId_IsValid;

	private static FFieldAddress GetPS5UsbStorageDeviceInfo_DeviceId_PropertyAddress;

	private static int GetPS5UsbStorageDeviceInfo_DeviceId_Offset;

	private static bool GetPS5UsbStorageDeviceInfo_OutInfo_IsValid;

	private static FFieldAddress GetPS5UsbStorageDeviceInfo_OutInfo_PropertyAddress;

	private static int GetPS5UsbStorageDeviceInfo_OutInfo_Offset;

	private static bool GetPS5UsbStorageDeviceInfo_ReturnValue_IsValid;

	private static FFieldAddress GetPS5UsbStorageDeviceInfo_ReturnValue_PropertyAddress;

	private static int GetPS5UsbStorageDeviceInfo_ReturnValue_Offset;

	private static bool GetNatInfo_IsValid;

	private static IntPtr GetNatInfo_FunctionAddress;

	private static int GetNatInfo_ParamsSize;

	private static bool GetNatInfo_ReturnValue_IsValid;

	private static FFieldAddress GetNatInfo_ReturnValue_PropertyAddress;

	private static int GetNatInfo_ReturnValue_Offset;

	private static bool GetIOSDocumentPath_IsValid;

	private static IntPtr GetIOSDocumentPath_FunctionAddress;

	private static int GetIOSDocumentPath_ParamsSize;

	private static bool GetIOSDocumentPath_ReturnValue_IsValid;

	private static FFieldAddress GetIOSDocumentPath_ReturnValue_PropertyAddress;

	private static int GetIOSDocumentPath_ReturnValue_Offset;

	private static bool GetIOSBundlePath_IsValid;

	private static IntPtr GetIOSBundlePath_FunctionAddress;

	private static int GetIOSBundlePath_ParamsSize;

	private static bool GetIOSBundlePath_ReturnValue_IsValid;

	private static FFieldAddress GetIOSBundlePath_ReturnValue_PropertyAddress;

	private static int GetIOSBundlePath_ReturnValue_Offset;

	private static bool GetGameRunEnvContext_IsValid;

	private static IntPtr GetGameRunEnvContext_FunctionAddress;

	private static int GetGameRunEnvContext_ParamsSize;

	private static bool GetGameRunEnvContext_OutContext_IsValid;

	private static FFieldAddress GetGameRunEnvContext_OutContext_PropertyAddress;

	private static int GetGameRunEnvContext_OutContext_Offset;

	private static bool GetAllPS5UsbStorageDeviceId_IsValid;

	private static IntPtr GetAllPS5UsbStorageDeviceId_FunctionAddress;

	private static int GetAllPS5UsbStorageDeviceId_ParamsSize;

	private static bool GetAllPS5UsbStorageDeviceId_OutIds_IsValid;

	private static FFieldAddress GetAllPS5UsbStorageDeviceId_OutIds_PropertyAddress;

	private static int GetAllPS5UsbStorageDeviceId_OutIds_Offset;

	private static bool GetAllPS5UsbStorageDeviceId_ReturnValue_IsValid;

	private static FFieldAddress GetAllPS5UsbStorageDeviceId_ReturnValue_PropertyAddress;

	private static int GetAllPS5UsbStorageDeviceId_ReturnValue_Offset;

	private static bool FCommandLine_Get_IsValid;

	private static IntPtr FCommandLine_Get_FunctionAddress;

	private static int FCommandLine_Get_ParamsSize;

	private static bool FCommandLine_Get_ReturnValue_IsValid;

	private static FFieldAddress FCommandLine_Get_ReturnValue_PropertyAddress;

	private static int FCommandLine_Get_ReturnValue_Offset;

	private static bool FCommandLine_AddArg_IsValid;

	private static IntPtr FCommandLine_AddArg_FunctionAddress;

	private static int FCommandLine_AddArg_ParamsSize;

	private static bool FCommandLine_AddArg_Command_IsValid;

	private static FFieldAddress FCommandLine_AddArg_Command_PropertyAddress;

	private static int FCommandLine_AddArg_Command_Offset;

	private static bool DisableMediaPlay_IsValid;

	private static IntPtr DisableMediaPlay_FunctionAddress;

	private static int DisableMediaPlay_ParamsSize;

	private static bool AddCrashUserData_IsValid;

	private static IntPtr AddCrashUserData_FunctionAddress;

	private static int AddCrashUserData_ParamsSize;

	private static bool AddCrashUserData_Key_IsValid;

	private static FFieldAddress AddCrashUserData_Key_PropertyAddress;

	private static int AddCrashUserData_Key_Offset;

	private static bool AddCrashUserData_Value_IsValid;

	private static FFieldAddress AddCrashUserData_Value_PropertyAddress;

	private static int AddCrashUserData_Value_Offset;

	private static bool AddCrashUserData_ReturnValue_IsValid;

	private static FFieldAddress AddCrashUserData_ReturnValue_PropertyAddress;

	private static int AddCrashUserData_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:UsbStorageIsExist")]
	public unsafe static bool UsbStorageIsExist(string DeviceIdStr, string Path, out bool IsFile)
	{
		if (!UsbStorageIsExist_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:UsbStorageIsExist");
			IsFile = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(UsbStorageIsExist_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)UsbStorageIsExist_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UsbStorageIsExist_DeviceIdStr_Offset), 0, UsbStorageIsExist_DeviceIdStr_PropertyAddress.Address, DeviceIdStr);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, UsbStorageIsExist_Path_Offset), 0, UsbStorageIsExist_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, UsbStorageIsExist_FunctionAddress, intPtr, UsbStorageIsExist_ParamsSize);
		NativeReflection.DestroyValue_InContainer(UsbStorageIsExist_DeviceIdStr_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(UsbStorageIsExist_Path_PropertyAddress.Address, intPtr);
		IsFile = BoolMarshaler.FromNative(IntPtr.Add(intPtr, UsbStorageIsExist_IsFile_Offset), 0, UsbStorageIsExist_IsFile_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, UsbStorageIsExist_ReturnValue_Offset), 0, UsbStorageIsExist_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:TestCallAndroidFunc")]
	public unsafe static bool TestCallAndroidFunc(string content)
	{
		if (!TestCallAndroidFunc_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:TestCallAndroidFunc");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(TestCallAndroidFunc_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)TestCallAndroidFunc_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, TestCallAndroidFunc_content_Offset), 0, TestCallAndroidFunc_content_PropertyAddress.Address, content);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, TestCallAndroidFunc_FunctionAddress, intPtr, TestCallAndroidFunc_ParamsSize);
		NativeReflection.DestroyValue_InContainer(TestCallAndroidFunc_content_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, TestCallAndroidFunc_ReturnValue_Offset), 0, TestCallAndroidFunc_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpRawDataRequest")]
	public unsafe static bool StartHttpRawDataRequest(string Url, string Method, Dictionary<string, string> ExHeaders, List<byte> PostRawData, UHttpResposeListener Listener, int RequestTimeout)
	{
		if (!StartHttpRawDataRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpRawDataRequest");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartHttpRawDataRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartHttpRawDataRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_Url_Offset), 0, StartHttpRawDataRequest_Url_PropertyAddress.Address, Url);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_Method_Offset), 0, StartHttpRawDataRequest_Method_PropertyAddress.Address, Method);
		NativeReflection.InitializeValue_InContainer(StartHttpRawDataRequest_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, StartHttpRawDataRequest_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_ExHeaders_Offset), ExHeaders);
		new TArrayCopyMarshaler<byte>(1, StartHttpRawDataRequest_PostRawData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_PostRawData_Offset), PostRawData);
		UObjectMarshaler<UHttpResposeListener>.ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_Listener_Offset), 0, StartHttpRawDataRequest_Listener_PropertyAddress.Address, Listener);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_RequestTimeout_Offset), 0, StartHttpRawDataRequest_RequestTimeout_PropertyAddress.Address, RequestTimeout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartHttpRawDataRequest_FunctionAddress, intPtr, StartHttpRawDataRequest_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartHttpRawDataRequest_Url_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpRawDataRequest_Method_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpRawDataRequest_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpRawDataRequest_PostRawData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartHttpRawDataRequest_ReturnValue_Offset), 0, StartHttpRawDataRequest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpBase64DataRequest")]
	public unsafe static bool StartHttpBase64DataRequest(string Url, string Method, Dictionary<string, string> ExHeaders, string Base64PostData, UHttpResposeListener Listener, int RequestTimeout)
	{
		if (!StartHttpBase64DataRequest_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpBase64DataRequest");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartHttpBase64DataRequest_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartHttpBase64DataRequest_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_Url_Offset), 0, StartHttpBase64DataRequest_Url_PropertyAddress.Address, Url);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_Method_Offset), 0, StartHttpBase64DataRequest_Method_PropertyAddress.Address, Method);
		NativeReflection.InitializeValue_InContainer(StartHttpBase64DataRequest_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, StartHttpBase64DataRequest_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_ExHeaders_Offset), ExHeaders);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_Base64PostData_Offset), 0, StartHttpBase64DataRequest_Base64PostData_PropertyAddress.Address, Base64PostData);
		UObjectMarshaler<UHttpResposeListener>.ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_Listener_Offset), 0, StartHttpBase64DataRequest_Listener_PropertyAddress.Address, Listener);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_RequestTimeout_Offset), 0, StartHttpBase64DataRequest_RequestTimeout_PropertyAddress.Address, RequestTimeout);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, StartHttpBase64DataRequest_FunctionAddress, intPtr, StartHttpBase64DataRequest_ParamsSize);
		NativeReflection.DestroyValue_InContainer(StartHttpBase64DataRequest_Url_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpBase64DataRequest_Method_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpBase64DataRequest_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(StartHttpBase64DataRequest_Base64PostData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, StartHttpBase64DataRequest_ReturnValue_Offset), 0, StartHttpBase64DataRequest_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SetCrashReportClientEnable")]
	public unsafe static void SetCrashReportClientEnable(int bEnable)
	{
		if (!SetCrashReportClientEnable_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SetCrashReportClientEnable");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetCrashReportClientEnable_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetCrashReportClientEnable_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetCrashReportClientEnable_bEnable_Offset), 0, SetCrashReportClientEnable_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetCrashReportClientEnable_FunctionAddress, intPtr, SetCrashReportClientEnable_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SetBuglyUserMap")]
	public unsafe static bool SetBuglyUserMap(string key, string value)
	{
		if (!SetBuglyUserMap_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SetBuglyUserMap");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetBuglyUserMap_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetBuglyUserMap_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBuglyUserMap_key_Offset), 0, SetBuglyUserMap_key_PropertyAddress.Address, key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetBuglyUserMap_value_Offset), 0, SetBuglyUserMap_value_PropertyAddress.Address, value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetBuglyUserMap_FunctionAddress, intPtr, SetBuglyUserMap_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SetBuglyUserMap_key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetBuglyUserMap_value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, SetBuglyUserMap_ReturnValue_Offset), 0, SetBuglyUserMap_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SetAppIsAutoTestingMode")]
	public unsafe static void SetAppIsAutoTestingMode(int bEnable)
	{
		if (!SetAppIsAutoTestingMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SetAppIsAutoTestingMode");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetAppIsAutoTestingMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetAppIsAutoTestingMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, SetAppIsAutoTestingMode_bEnable_Offset), 0, SetAppIsAutoTestingMode_bEnable_PropertyAddress.Address, bEnable);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetAppIsAutoTestingMode_FunctionAddress, intPtr, SetAppIsAutoTestingMode_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetUser")]
	public unsafe static void SentryCrashReporterSetUser(string UserKey, string UserValue)
	{
		if (!SentryCrashReporterSetUser_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetUser");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SentryCrashReporterSetUser_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SentryCrashReporterSetUser_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetUser_UserKey_Offset), 0, SentryCrashReporterSetUser_UserKey_PropertyAddress.Address, UserKey);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetUser_UserValue_Offset), 0, SentryCrashReporterSetUser_UserValue_PropertyAddress.Address, UserValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SentryCrashReporterSetUser_FunctionAddress, intPtr, SentryCrashReporterSetUser_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetUser_UserKey_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetUser_UserValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetTag")]
	public unsafe static void SentryCrashReporterSetTag(string Key, string Value)
	{
		if (!SentryCrashReporterSetTag_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetTag");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SentryCrashReporterSetTag_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SentryCrashReporterSetTag_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetTag_Key_Offset), 0, SentryCrashReporterSetTag_Key_PropertyAddress.Address, Key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetTag_Value_Offset), 0, SentryCrashReporterSetTag_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SentryCrashReporterSetTag_FunctionAddress, intPtr, SentryCrashReporterSetTag_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetTag_Key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetTag_Value_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetRoot")]
	public unsafe static void SentryCrashReporterSetRoot(string RootKey, string RootValue)
	{
		if (!SentryCrashReporterSetRoot_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetRoot");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SentryCrashReporterSetRoot_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SentryCrashReporterSetRoot_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetRoot_RootKey_Offset), 0, SentryCrashReporterSetRoot_RootKey_PropertyAddress.Address, RootKey);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetRoot_RootValue_Offset), 0, SentryCrashReporterSetRoot_RootValue_PropertyAddress.Address, RootValue);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SentryCrashReporterSetRoot_FunctionAddress, intPtr, SentryCrashReporterSetRoot_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetRoot_RootKey_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetRoot_RootValue_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetContext")]
	public unsafe static void SentryCrashReporterSetContext(string Key, Dictionary<string, string> ContextValues)
	{
		if (!SentryCrashReporterSetContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetContext");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SentryCrashReporterSetContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SentryCrashReporterSetContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetContext_Key_Offset), 0, SentryCrashReporterSetContext_Key_PropertyAddress.Address, Key);
		NativeReflection.InitializeValue_InContainer(SentryCrashReporterSetContext_ContextValues_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, SentryCrashReporterSetContext_ContextValues_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, SentryCrashReporterSetContext_ContextValues_Offset), ContextValues);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SentryCrashReporterSetContext_FunctionAddress, intPtr, SentryCrashReporterSetContext_ParamsSize);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetContext_Key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SentryCrashReporterSetContext_ContextValues_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:ReenableMediaPlay")]
	public unsafe static void ReenableMediaPlay()
	{
		if (!ReenableMediaPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:ReenableMediaPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReenableMediaPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReenableMediaPlay_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: ReenableMediaPlay_FunctionAddress, argsSize: ReenableMediaPlay_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:QueryIsOwnPS5EntitlementSync")]
	public unsafe static bool QueryIsOwnPS5EntitlementSync(string QueryEntitlementId)
	{
		if (!QueryIsOwnPS5EntitlementSync_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:QueryIsOwnPS5EntitlementSync");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(QueryIsOwnPS5EntitlementSync_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)QueryIsOwnPS5EntitlementSync_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, QueryIsOwnPS5EntitlementSync_QueryEntitlementId_Offset), 0, QueryIsOwnPS5EntitlementSync_QueryEntitlementId_PropertyAddress.Address, QueryEntitlementId);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, QueryIsOwnPS5EntitlementSync_FunctionAddress, intPtr, QueryIsOwnPS5EntitlementSync_ParamsSize);
		NativeReflection.DestroyValue_InContainer(QueryIsOwnPS5EntitlementSync_QueryEntitlementId_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, QueryIsOwnPS5EntitlementSync_ReturnValue_Offset), 0, QueryIsOwnPS5EntitlementSync_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbSelectDevice")]
	public unsafe static EPS5UsbSelectErrorCode PS5UsbSelectDevice(string UsrDir, out string OutDeviceId)
	{
		if (!PS5UsbSelectDevice_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbSelectDevice");
			OutDeviceId = FStringMarshaler.DefaultString;
			return EPS5UsbSelectErrorCode.UsrNotInit;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PS5UsbSelectDevice_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PS5UsbSelectDevice_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5UsbSelectDevice_UsrDir_Offset), 0, PS5UsbSelectDevice_UsrDir_PropertyAddress.Address, UsrDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PS5UsbSelectDevice_FunctionAddress, intPtr, PS5UsbSelectDevice_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PS5UsbSelectDevice_UsrDir_PropertyAddress.Address, intPtr);
		OutDeviceId = FStringMarshaler.FromNative(IntPtr.Add(intPtr, PS5UsbSelectDevice_OutDeviceId_Offset), 0, PS5UsbSelectDevice_OutDeviceId_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PS5UsbSelectDevice_OutDeviceId_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPS5UsbSelectErrorCode>.FromNative(IntPtr.Add(intPtr, PS5UsbSelectDevice_ReturnValue_Offset), 0, PS5UsbSelectDevice_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbMkSubDir")]
	public unsafe static bool PS5UsbMkSubDir(string DeviceId, string MountPoint, string UsrDir, string SubDir, out string OutDirPath)
	{
		if (!PS5UsbMkSubDir_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbMkSubDir");
			OutDirPath = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PS5UsbMkSubDir_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PS5UsbMkSubDir_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_DeviceId_Offset), 0, PS5UsbMkSubDir_DeviceId_PropertyAddress.Address, DeviceId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_MountPoint_Offset), 0, PS5UsbMkSubDir_MountPoint_PropertyAddress.Address, MountPoint);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_UsrDir_Offset), 0, PS5UsbMkSubDir_UsrDir_PropertyAddress.Address, UsrDir);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_SubDir_Offset), 0, PS5UsbMkSubDir_SubDir_PropertyAddress.Address, SubDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PS5UsbMkSubDir_FunctionAddress, intPtr, PS5UsbMkSubDir_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PS5UsbMkSubDir_DeviceId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5UsbMkSubDir_MountPoint_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5UsbMkSubDir_UsrDir_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5UsbMkSubDir_SubDir_PropertyAddress.Address, intPtr);
		OutDirPath = FStringMarshaler.FromNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_OutDirPath_Offset), 0, PS5UsbMkSubDir_OutDirPath_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PS5UsbMkSubDir_OutDirPath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PS5UsbMkSubDir_ReturnValue_Offset), 0, PS5UsbMkSubDir_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestUnMapUsb")]
	public unsafe static EPS5RequestUnMapUsbErrorCode PS5RequestUnMapUsb(string DeviceId, string UsrDir)
	{
		if (!PS5RequestUnMapUsb_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestUnMapUsb");
			return EPS5RequestUnMapUsbErrorCode.DeviceDoesNotExist;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PS5RequestUnMapUsb_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PS5RequestUnMapUsb_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5RequestUnMapUsb_DeviceId_Offset), 0, PS5RequestUnMapUsb_DeviceId_PropertyAddress.Address, DeviceId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5RequestUnMapUsb_UsrDir_Offset), 0, PS5RequestUnMapUsb_UsrDir_PropertyAddress.Address, UsrDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PS5RequestUnMapUsb_FunctionAddress, intPtr, PS5RequestUnMapUsb_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PS5RequestUnMapUsb_DeviceId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5RequestUnMapUsb_UsrDir_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPS5RequestUnMapUsbErrorCode>.FromNative(IntPtr.Add(intPtr, PS5RequestUnMapUsb_ReturnValue_Offset), 0, PS5RequestUnMapUsb_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestMapUsb")]
	public unsafe static EPS5RequestMapUsbErrorCode PS5RequestMapUsb(string DeviceId, string UsrDir, out string OutMountPoint)
	{
		if (!PS5RequestMapUsb_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestMapUsb");
			OutMountPoint = FStringMarshaler.DefaultString;
			return EPS5RequestMapUsbErrorCode.DeviceDoesNotExist;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PS5RequestMapUsb_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PS5RequestMapUsb_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5RequestMapUsb_DeviceId_Offset), 0, PS5RequestMapUsb_DeviceId_PropertyAddress.Address, DeviceId);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5RequestMapUsb_UsrDir_Offset), 0, PS5RequestMapUsb_UsrDir_PropertyAddress.Address, UsrDir);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PS5RequestMapUsb_FunctionAddress, intPtr, PS5RequestMapUsb_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PS5RequestMapUsb_DeviceId_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5RequestMapUsb_UsrDir_PropertyAddress.Address, intPtr);
		OutMountPoint = FStringMarshaler.FromNative(IntPtr.Add(intPtr, PS5RequestMapUsb_OutMountPoint_Offset), 0, PS5RequestMapUsb_OutMountPoint_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(PS5RequestMapUsb_OutMountPoint_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPS5RequestMapUsbErrorCode>.FromNative(IntPtr.Add(intPtr, PS5RequestMapUsb_ReturnValue_Offset), 0, PS5RequestMapUsb_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PS5ExportDataToUsb")]
	public unsafe static EPS5UsbWriteErrorCode PS5ExportDataToUsb(string FileName, List<byte> FileContentData)
	{
		if (!PS5ExportDataToUsb_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PS5ExportDataToUsb");
			return EPS5UsbWriteErrorCode.NoAvailableSpace;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PS5ExportDataToUsb_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PS5ExportDataToUsb_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PS5ExportDataToUsb_FileName_Offset), 0, PS5ExportDataToUsb_FileName_PropertyAddress.Address, FileName);
		new TArrayCopyMarshaler<byte>(1, PS5ExportDataToUsb_FileContentData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, PS5ExportDataToUsb_FileContentData_Offset), FileContentData);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PS5ExportDataToUsb_FunctionAddress, intPtr, PS5ExportDataToUsb_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PS5ExportDataToUsb_FileName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PS5ExportDataToUsb_FileContentData_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EPS5UsbWriteErrorCode>.FromNative(IntPtr.Add(intPtr, PS5ExportDataToUsb_ReturnValue_Offset), 0, PS5ExportDataToUsb_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PrintCachedEntitlements")]
	public unsafe static void PrintCachedEntitlements()
	{
		if (!PrintCachedEntitlements_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PrintCachedEntitlements");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PrintCachedEntitlements_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PrintCachedEntitlements_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: PrintCachedEntitlements_FunctionAddress, argsSize: PrintCachedEntitlements_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PostExceptionSample")]
	public unsafe static bool PostExceptionSample(string message)
	{
		if (!PostExceptionSample_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PostExceptionSample");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostExceptionSample_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostExceptionSample_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostExceptionSample_message_Offset), 0, PostExceptionSample_message_PropertyAddress.Address, message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostExceptionSample_FunctionAddress, intPtr, PostExceptionSample_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostExceptionSample_message_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PostExceptionSample_ReturnValue_Offset), 0, PostExceptionSample_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:PostException")]
	public unsafe static bool PostException(int type, string name, string message, string stackTrace)
	{
		if (!PostException_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:PostException");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostException_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostException_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, PostException_type_Offset), 0, PostException_type_PropertyAddress.Address, type);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostException_name_Offset), 0, PostException_name_PropertyAddress.Address, name);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostException_message_Offset), 0, PostException_message_PropertyAddress.Address, message);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, PostException_stackTrace_Offset), 0, PostException_stackTrace_PropertyAddress.Address, stackTrace);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, PostException_FunctionAddress, intPtr, PostException_ParamsSize);
		NativeReflection.DestroyValue_InContainer(PostException_name_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PostException_message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(PostException_stackTrace_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, PostException_ReturnValue_Offset), 0, PostException_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:NonGameThreadStartHttpRawDataRequestWithBlockMode")]
	public unsafe static int NonGameThreadStartHttpRawDataRequestWithBlockMode(string Url, string Method, Dictionary<string, string> ExHeaders, List<byte> PostRawData, int RequestTimeout, out Dictionary<string, string> OutResponse)
	{
		if (!NonGameThreadStartHttpRawDataRequestWithBlockMode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:NonGameThreadStartHttpRawDataRequestWithBlockMode");
			OutResponse = null;
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(NonGameThreadStartHttpRawDataRequestWithBlockMode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)NonGameThreadStartHttpRawDataRequestWithBlockMode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_Offset), 0, NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_PropertyAddress.Address, Url);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_Offset), 0, NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_PropertyAddress.Address, Method);
		NativeReflection.InitializeValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_Offset), ExHeaders);
		new TArrayCopyMarshaler<byte>(1, NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_Offset), PostRawData);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_Offset), 0, NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_PropertyAddress.Address, RequestTimeout);
		NativeReflection.InitializeValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_ParamsSize);
		NativeReflection.DestroyValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_PropertyAddress.Address, intPtr);
		OutResponse = new TMapCopyMarshaler<string, string>(1, NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_Offset));
		NativeReflection.DestroyValue_InContainer(NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_PropertyAddress.Address, intPtr);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_Offset), 0, NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:IsPureVersion")]
	public unsafe static bool IsPureVersion()
	{
		if (!IsPureVersion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:IsPureVersion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsPureVersion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsPureVersion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsPureVersion_FunctionAddress, intPtr, IsPureVersion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsPureVersion_ReturnValue_Offset), 0, IsPureVersion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:IsCleanVersion")]
	public unsafe static bool IsCleanVersion()
	{
		if (!IsCleanVersion_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:IsCleanVersion");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCleanVersion_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCleanVersion_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, IsCleanVersion_FunctionAddress, intPtr, IsCleanVersion_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCleanVersion_ReturnValue_Offset), 0, IsCleanVersion_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileList")]
	public unsafe static bool HttpPostFileList(string PostUrl, Dictionary<string, string> ExHeaders, List<string> FilePathList, UHttpResposeListener Listener)
	{
		if (!HttpPostFileList_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileList");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HttpPostFileList_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HttpPostFileList_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HttpPostFileList_PostUrl_Offset), 0, HttpPostFileList_PostUrl_PropertyAddress.Address, PostUrl);
		NativeReflection.InitializeValue_InContainer(HttpPostFileList_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, HttpPostFileList_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HttpPostFileList_ExHeaders_Offset), ExHeaders);
		new TArrayCopyMarshaler<string>(1, HttpPostFileList_FilePathList_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HttpPostFileList_FilePathList_Offset), FilePathList);
		UObjectMarshaler<UHttpResposeListener>.ToNative(IntPtr.Add(intPtr, HttpPostFileList_Listener_Offset), 0, HttpPostFileList_Listener_PropertyAddress.Address, Listener);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HttpPostFileList_FunctionAddress, intPtr, HttpPostFileList_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HttpPostFileList_PostUrl_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFileList_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFileList_FilePathList_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HttpPostFileList_ReturnValue_Offset), 0, HttpPostFileList_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileContent")]
	public unsafe static bool HttpPostFileContent(string PostUrl, Dictionary<string, string> ExHeaders, string FileName, List<byte> FileContentData, UHttpResposeListener Listener)
	{
		if (!HttpPostFileContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileContent");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HttpPostFileContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HttpPostFileContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HttpPostFileContent_PostUrl_Offset), 0, HttpPostFileContent_PostUrl_PropertyAddress.Address, PostUrl);
		NativeReflection.InitializeValue_InContainer(HttpPostFileContent_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, HttpPostFileContent_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HttpPostFileContent_ExHeaders_Offset), ExHeaders);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HttpPostFileContent_FileName_Offset), 0, HttpPostFileContent_FileName_PropertyAddress.Address, FileName);
		new TArrayCopyMarshaler<byte>(1, HttpPostFileContent_FileContentData_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, HttpPostFileContent_FileContentData_Offset), FileContentData);
		UObjectMarshaler<UHttpResposeListener>.ToNative(IntPtr.Add(intPtr, HttpPostFileContent_Listener_Offset), 0, HttpPostFileContent_Listener_PropertyAddress.Address, Listener);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HttpPostFileContent_FunctionAddress, intPtr, HttpPostFileContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HttpPostFileContent_PostUrl_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFileContent_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFileContent_FileName_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFileContent_FileContentData_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HttpPostFileContent_ReturnValue_Offset), 0, HttpPostFileContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFile")]
	public unsafe static bool HttpPostFile(string PostUrl, Dictionary<string, string> ExHeaders, string FilePath, UHttpResposeListener Listener)
	{
		if (!HttpPostFile_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFile");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HttpPostFile_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HttpPostFile_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HttpPostFile_PostUrl_Offset), 0, HttpPostFile_PostUrl_PropertyAddress.Address, PostUrl);
		NativeReflection.InitializeValue_InContainer(HttpPostFile_ExHeaders_PropertyAddress.Address, intPtr);
		new TMapCopyMarshaler<string, string>(1, HttpPostFile_ExHeaders_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, HttpPostFile_ExHeaders_Offset), ExHeaders);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HttpPostFile_FilePath_Offset), 0, HttpPostFile_FilePath_PropertyAddress.Address, FilePath);
		UObjectMarshaler<UHttpResposeListener>.ToNative(IntPtr.Add(intPtr, HttpPostFile_Listener_Offset), 0, HttpPostFile_Listener_PropertyAddress.Address, Listener);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HttpPostFile_FunctionAddress, intPtr, HttpPostFile_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HttpPostFile_PostUrl_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFile_ExHeaders_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(HttpPostFile_FilePath_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HttpPostFile_ReturnValue_Offset), 0, HttpPostFile_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserDefinedParam")]
	public unsafe static int GetPS5UserDefinedParam(int index)
	{
		if (!GetPS5UserDefinedParam_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserDefinedParam");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPS5UserDefinedParam_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPS5UserDefinedParam_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPS5UserDefinedParam_index_Offset), 0, GetPS5UserDefinedParam_index_PropertyAddress.Address, index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPS5UserDefinedParam_FunctionAddress, intPtr, GetPS5UserDefinedParam_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPS5UserDefinedParam_ReturnValue_Offset), 0, GetPS5UserDefinedParam_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserAccountRegionCode")]
	public unsafe static string GetPS5UserAccountRegionCode()
	{
		if (!GetPS5UserAccountRegionCode_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserAccountRegionCode");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPS5UserAccountRegionCode_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPS5UserAccountRegionCode_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPS5UserAccountRegionCode_FunctionAddress, intPtr, GetPS5UserAccountRegionCode_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetPS5UserAccountRegionCode_ReturnValue_Offset), 0, GetPS5UserAccountRegionCode_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPS5UserAccountRegionCode_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UsbStorageDeviceInfo")]
	public unsafe static bool GetPS5UsbStorageDeviceInfo(string DeviceId, out FUsbStorageDeviceInfo OutInfo)
	{
		if (!GetPS5UsbStorageDeviceInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UsbStorageDeviceInfo");
			OutInfo = default(FUsbStorageDeviceInfo);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPS5UsbStorageDeviceInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPS5UsbStorageDeviceInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetPS5UsbStorageDeviceInfo_DeviceId_Offset), 0, GetPS5UsbStorageDeviceInfo_DeviceId_PropertyAddress.Address, DeviceId);
		NativeReflection.InitializeValue_InContainer(GetPS5UsbStorageDeviceInfo_OutInfo_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetPS5UsbStorageDeviceInfo_FunctionAddress, intPtr, GetPS5UsbStorageDeviceInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetPS5UsbStorageDeviceInfo_DeviceId_PropertyAddress.Address, intPtr);
		OutInfo = FUsbStorageDeviceInfo.FromNative(IntPtr.Add(intPtr, GetPS5UsbStorageDeviceInfo_OutInfo_Offset), 0, GetPS5UsbStorageDeviceInfo_OutInfo_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetPS5UsbStorageDeviceInfo_OutInfo_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetPS5UsbStorageDeviceInfo_ReturnValue_Offset), 0, GetPS5UsbStorageDeviceInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetNatInfo")]
	public unsafe static EBGWNATType GetNatInfo()
	{
		if (!GetNatInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetNatInfo");
			return EBGWNATType.SONY_NAT_TYPE_UNKNOWN;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetNatInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetNatInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetNatInfo_FunctionAddress, intPtr, GetNatInfo_ParamsSize);
		return EnumMarshaler<EBGWNATType>.FromNative(IntPtr.Add(intPtr, GetNatInfo_ReturnValue_Offset), 0, GetNatInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSDocumentPath")]
	public unsafe static string GetIOSDocumentPath()
	{
		if (!GetIOSDocumentPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSDocumentPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIOSDocumentPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIOSDocumentPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIOSDocumentPath_FunctionAddress, intPtr, GetIOSDocumentPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetIOSDocumentPath_ReturnValue_Offset), 0, GetIOSDocumentPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetIOSDocumentPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSBundlePath")]
	public unsafe static string GetIOSBundlePath()
	{
		if (!GetIOSBundlePath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSBundlePath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetIOSBundlePath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetIOSBundlePath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetIOSBundlePath_FunctionAddress, intPtr, GetIOSBundlePath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetIOSBundlePath_ReturnValue_Offset), 0, GetIOSBundlePath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetIOSBundlePath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetGameRunEnvContext")]
	public unsafe static void GetGameRunEnvContext(out Dictionary<string, string> OutContext)
	{
		if (!GetGameRunEnvContext_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetGameRunEnvContext");
			OutContext = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGameRunEnvContext_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGameRunEnvContext_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetGameRunEnvContext_OutContext_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetGameRunEnvContext_FunctionAddress, intPtr, GetGameRunEnvContext_ParamsSize);
		OutContext = new TMapCopyMarshaler<string, string>(1, GetGameRunEnvContext_OutContext_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetGameRunEnvContext_OutContext_Offset));
		NativeReflection.DestroyValue_InContainer(GetGameRunEnvContext_OutContext_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:GetAllPS5UsbStorageDeviceId")]
	public unsafe static bool GetAllPS5UsbStorageDeviceId(out List<string> OutIds)
	{
		if (!GetAllPS5UsbStorageDeviceId_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:GetAllPS5UsbStorageDeviceId");
			OutIds = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllPS5UsbStorageDeviceId_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllPS5UsbStorageDeviceId_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllPS5UsbStorageDeviceId_FunctionAddress, intPtr, GetAllPS5UsbStorageDeviceId_ParamsSize);
		OutIds = new TArrayCopyMarshaler<string>(1, GetAllPS5UsbStorageDeviceId_OutIds_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllPS5UsbStorageDeviceId_OutIds_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllPS5UsbStorageDeviceId_OutIds_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAllPS5UsbStorageDeviceId_ReturnValue_Offset), 0, GetAllPS5UsbStorageDeviceId_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_Get")]
	public unsafe static string FCommandLine_Get()
	{
		if (!FCommandLine_Get_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_Get");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FCommandLine_Get_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FCommandLine_Get_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FCommandLine_Get_FunctionAddress, intPtr, FCommandLine_Get_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, FCommandLine_Get_ReturnValue_Offset), 0, FCommandLine_Get_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(FCommandLine_Get_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_AddArg")]
	public unsafe static void FCommandLine_AddArg(string Command)
	{
		if (!FCommandLine_AddArg_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_AddArg");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FCommandLine_AddArg_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FCommandLine_AddArg_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, FCommandLine_AddArg_Command_Offset), 0, FCommandLine_AddArg_Command_PropertyAddress.Address, Command);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FCommandLine_AddArg_FunctionAddress, intPtr, FCommandLine_AddArg_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FCommandLine_AddArg_Command_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:DisableMediaPlay")]
	public unsafe static void DisableMediaPlay()
	{
		if (!DisableMediaPlay_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:DisableMediaPlay");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(DisableMediaPlay_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)DisableMediaPlay_ParamsSize);
		NativeReflection.InvokeStaticFunctionOptimized(args: new IntPtr(ptr2), unrealClass: classAddress, function: DisableMediaPlay_FunctionAddress, argsSize: DisableMediaPlay_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/UnrealExtent.GSE_SDKFuncLib:AddCrashUserData")]
	public unsafe static bool AddCrashUserData(string Key, string Value)
	{
		if (!AddCrashUserData_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/UnrealExtent.GSE_SDKFuncLib:AddCrashUserData");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddCrashUserData_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddCrashUserData_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddCrashUserData_Key_Offset), 0, AddCrashUserData_Key_PropertyAddress.Address, Key);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddCrashUserData_Value_Offset), 0, AddCrashUserData_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddCrashUserData_FunctionAddress, intPtr, AddCrashUserData_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddCrashUserData_Key_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddCrashUserData_Value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, AddCrashUserData_ReturnValue_Offset), 0, AddCrashUserData_ReturnValue_PropertyAddress.Address);
	}

	static UGSE_SDKFuncLib()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSE_SDKFuncLib)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSE_SDKFuncLib));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/UnrealExtent.GSE_SDKFuncLib");
		UsbStorageIsExist_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "UsbStorageIsExist");
		UsbStorageIsExist_ParamsSize = NativeReflection.GetFunctionParamsSize(UsbStorageIsExist_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref UsbStorageIsExist_DeviceIdStr_PropertyAddress, UsbStorageIsExist_FunctionAddress, "DeviceIdStr");
		UsbStorageIsExist_DeviceIdStr_Offset = NativeReflectionCached.GetPropertyOffset(UsbStorageIsExist_FunctionAddress, "DeviceIdStr");
		UsbStorageIsExist_DeviceIdStr_IsValid = NativeReflectionCached.ValidatePropertyClass(UsbStorageIsExist_FunctionAddress, "DeviceIdStr", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UsbStorageIsExist_Path_PropertyAddress, UsbStorageIsExist_FunctionAddress, "Path");
		UsbStorageIsExist_Path_Offset = NativeReflectionCached.GetPropertyOffset(UsbStorageIsExist_FunctionAddress, "Path");
		UsbStorageIsExist_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(UsbStorageIsExist_FunctionAddress, "Path", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref UsbStorageIsExist_IsFile_PropertyAddress, UsbStorageIsExist_FunctionAddress, "IsFile");
		UsbStorageIsExist_IsFile_Offset = NativeReflectionCached.GetPropertyOffset(UsbStorageIsExist_FunctionAddress, "IsFile");
		UsbStorageIsExist_IsFile_IsValid = NativeReflectionCached.ValidatePropertyClass(UsbStorageIsExist_FunctionAddress, "IsFile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref UsbStorageIsExist_ReturnValue_PropertyAddress, UsbStorageIsExist_FunctionAddress, "ReturnValue");
		UsbStorageIsExist_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(UsbStorageIsExist_FunctionAddress, "ReturnValue");
		UsbStorageIsExist_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(UsbStorageIsExist_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		UsbStorageIsExist_IsValid = UsbStorageIsExist_FunctionAddress != IntPtr.Zero && UsbStorageIsExist_DeviceIdStr_IsValid && UsbStorageIsExist_Path_IsValid && UsbStorageIsExist_IsFile_IsValid && UsbStorageIsExist_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:UsbStorageIsExist", UsbStorageIsExist_IsValid);
		TestCallAndroidFunc_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "TestCallAndroidFunc");
		TestCallAndroidFunc_ParamsSize = NativeReflection.GetFunctionParamsSize(TestCallAndroidFunc_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref TestCallAndroidFunc_content_PropertyAddress, TestCallAndroidFunc_FunctionAddress, "content");
		TestCallAndroidFunc_content_Offset = NativeReflectionCached.GetPropertyOffset(TestCallAndroidFunc_FunctionAddress, "content");
		TestCallAndroidFunc_content_IsValid = NativeReflectionCached.ValidatePropertyClass(TestCallAndroidFunc_FunctionAddress, "content", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref TestCallAndroidFunc_ReturnValue_PropertyAddress, TestCallAndroidFunc_FunctionAddress, "ReturnValue");
		TestCallAndroidFunc_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(TestCallAndroidFunc_FunctionAddress, "ReturnValue");
		TestCallAndroidFunc_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(TestCallAndroidFunc_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		TestCallAndroidFunc_IsValid = TestCallAndroidFunc_FunctionAddress != IntPtr.Zero && TestCallAndroidFunc_content_IsValid && TestCallAndroidFunc_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:TestCallAndroidFunc", TestCallAndroidFunc_IsValid);
		StartHttpRawDataRequest_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartHttpRawDataRequest");
		StartHttpRawDataRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(StartHttpRawDataRequest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_Url_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "Url");
		StartHttpRawDataRequest_Url_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "Url");
		StartHttpRawDataRequest_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_Method_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "Method");
		StartHttpRawDataRequest_Method_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "Method");
		StartHttpRawDataRequest_Method_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "Method", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_ExHeaders_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "ExHeaders");
		StartHttpRawDataRequest_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "ExHeaders");
		StartHttpRawDataRequest_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_PostRawData_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "PostRawData");
		StartHttpRawDataRequest_PostRawData_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "PostRawData");
		StartHttpRawDataRequest_PostRawData_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "PostRawData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_Listener_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "Listener");
		StartHttpRawDataRequest_Listener_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "Listener");
		StartHttpRawDataRequest_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_RequestTimeout_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "RequestTimeout");
		StartHttpRawDataRequest_RequestTimeout_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "RequestTimeout");
		StartHttpRawDataRequest_RequestTimeout_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "RequestTimeout", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpRawDataRequest_ReturnValue_PropertyAddress, StartHttpRawDataRequest_FunctionAddress, "ReturnValue");
		StartHttpRawDataRequest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpRawDataRequest_FunctionAddress, "ReturnValue");
		StartHttpRawDataRequest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpRawDataRequest_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartHttpRawDataRequest_IsValid = StartHttpRawDataRequest_FunctionAddress != IntPtr.Zero && StartHttpRawDataRequest_Url_IsValid && StartHttpRawDataRequest_Method_IsValid && StartHttpRawDataRequest_ExHeaders_IsValid && StartHttpRawDataRequest_PostRawData_IsValid && StartHttpRawDataRequest_Listener_IsValid && StartHttpRawDataRequest_RequestTimeout_IsValid && StartHttpRawDataRequest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpRawDataRequest", StartHttpRawDataRequest_IsValid);
		StartHttpBase64DataRequest_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "StartHttpBase64DataRequest");
		StartHttpBase64DataRequest_ParamsSize = NativeReflection.GetFunctionParamsSize(StartHttpBase64DataRequest_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_Url_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "Url");
		StartHttpBase64DataRequest_Url_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "Url");
		StartHttpBase64DataRequest_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_Method_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "Method");
		StartHttpBase64DataRequest_Method_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "Method");
		StartHttpBase64DataRequest_Method_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "Method", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_ExHeaders_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "ExHeaders");
		StartHttpBase64DataRequest_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "ExHeaders");
		StartHttpBase64DataRequest_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_Base64PostData_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "Base64PostData");
		StartHttpBase64DataRequest_Base64PostData_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "Base64PostData");
		StartHttpBase64DataRequest_Base64PostData_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "Base64PostData", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_Listener_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "Listener");
		StartHttpBase64DataRequest_Listener_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "Listener");
		StartHttpBase64DataRequest_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_RequestTimeout_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "RequestTimeout");
		StartHttpBase64DataRequest_RequestTimeout_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "RequestTimeout");
		StartHttpBase64DataRequest_RequestTimeout_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "RequestTimeout", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref StartHttpBase64DataRequest_ReturnValue_PropertyAddress, StartHttpBase64DataRequest_FunctionAddress, "ReturnValue");
		StartHttpBase64DataRequest_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(StartHttpBase64DataRequest_FunctionAddress, "ReturnValue");
		StartHttpBase64DataRequest_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(StartHttpBase64DataRequest_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		StartHttpBase64DataRequest_IsValid = StartHttpBase64DataRequest_FunctionAddress != IntPtr.Zero && StartHttpBase64DataRequest_Url_IsValid && StartHttpBase64DataRequest_Method_IsValid && StartHttpBase64DataRequest_ExHeaders_IsValid && StartHttpBase64DataRequest_Base64PostData_IsValid && StartHttpBase64DataRequest_Listener_IsValid && StartHttpBase64DataRequest_RequestTimeout_IsValid && StartHttpBase64DataRequest_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:StartHttpBase64DataRequest", StartHttpBase64DataRequest_IsValid);
		SetCrashReportClientEnable_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetCrashReportClientEnable");
		SetCrashReportClientEnable_ParamsSize = NativeReflection.GetFunctionParamsSize(SetCrashReportClientEnable_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetCrashReportClientEnable_bEnable_PropertyAddress, SetCrashReportClientEnable_FunctionAddress, "bEnable");
		SetCrashReportClientEnable_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetCrashReportClientEnable_FunctionAddress, "bEnable");
		SetCrashReportClientEnable_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetCrashReportClientEnable_FunctionAddress, "bEnable", Classes.FIntProperty);
		SetCrashReportClientEnable_IsValid = SetCrashReportClientEnable_FunctionAddress != IntPtr.Zero && SetCrashReportClientEnable_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SetCrashReportClientEnable", SetCrashReportClientEnable_IsValid);
		SetBuglyUserMap_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetBuglyUserMap");
		SetBuglyUserMap_ParamsSize = NativeReflection.GetFunctionParamsSize(SetBuglyUserMap_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetBuglyUserMap_key_PropertyAddress, SetBuglyUserMap_FunctionAddress, "key");
		SetBuglyUserMap_key_Offset = NativeReflectionCached.GetPropertyOffset(SetBuglyUserMap_FunctionAddress, "key");
		SetBuglyUserMap_key_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBuglyUserMap_FunctionAddress, "key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBuglyUserMap_value_PropertyAddress, SetBuglyUserMap_FunctionAddress, "value");
		SetBuglyUserMap_value_Offset = NativeReflectionCached.GetPropertyOffset(SetBuglyUserMap_FunctionAddress, "value");
		SetBuglyUserMap_value_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBuglyUserMap_FunctionAddress, "value", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetBuglyUserMap_ReturnValue_PropertyAddress, SetBuglyUserMap_FunctionAddress, "ReturnValue");
		SetBuglyUserMap_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetBuglyUserMap_FunctionAddress, "ReturnValue");
		SetBuglyUserMap_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetBuglyUserMap_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		SetBuglyUserMap_IsValid = SetBuglyUserMap_FunctionAddress != IntPtr.Zero && SetBuglyUserMap_key_IsValid && SetBuglyUserMap_value_IsValid && SetBuglyUserMap_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SetBuglyUserMap", SetBuglyUserMap_IsValid);
		SetAppIsAutoTestingMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetAppIsAutoTestingMode");
		SetAppIsAutoTestingMode_ParamsSize = NativeReflection.GetFunctionParamsSize(SetAppIsAutoTestingMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetAppIsAutoTestingMode_bEnable_PropertyAddress, SetAppIsAutoTestingMode_FunctionAddress, "bEnable");
		SetAppIsAutoTestingMode_bEnable_Offset = NativeReflectionCached.GetPropertyOffset(SetAppIsAutoTestingMode_FunctionAddress, "bEnable");
		SetAppIsAutoTestingMode_bEnable_IsValid = NativeReflectionCached.ValidatePropertyClass(SetAppIsAutoTestingMode_FunctionAddress, "bEnable", Classes.FIntProperty);
		SetAppIsAutoTestingMode_IsValid = SetAppIsAutoTestingMode_FunctionAddress != IntPtr.Zero && SetAppIsAutoTestingMode_bEnable_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SetAppIsAutoTestingMode", SetAppIsAutoTestingMode_IsValid);
		SentryCrashReporterSetUser_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SentryCrashReporterSetUser");
		SentryCrashReporterSetUser_ParamsSize = NativeReflection.GetFunctionParamsSize(SentryCrashReporterSetUser_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetUser_UserKey_PropertyAddress, SentryCrashReporterSetUser_FunctionAddress, "UserKey");
		SentryCrashReporterSetUser_UserKey_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetUser_FunctionAddress, "UserKey");
		SentryCrashReporterSetUser_UserKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetUser_FunctionAddress, "UserKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetUser_UserValue_PropertyAddress, SentryCrashReporterSetUser_FunctionAddress, "UserValue");
		SentryCrashReporterSetUser_UserValue_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetUser_FunctionAddress, "UserValue");
		SentryCrashReporterSetUser_UserValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetUser_FunctionAddress, "UserValue", Classes.FStrProperty);
		SentryCrashReporterSetUser_IsValid = SentryCrashReporterSetUser_FunctionAddress != IntPtr.Zero && SentryCrashReporterSetUser_UserKey_IsValid && SentryCrashReporterSetUser_UserValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetUser", SentryCrashReporterSetUser_IsValid);
		SentryCrashReporterSetTag_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SentryCrashReporterSetTag");
		SentryCrashReporterSetTag_ParamsSize = NativeReflection.GetFunctionParamsSize(SentryCrashReporterSetTag_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetTag_Key_PropertyAddress, SentryCrashReporterSetTag_FunctionAddress, "Key");
		SentryCrashReporterSetTag_Key_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetTag_FunctionAddress, "Key");
		SentryCrashReporterSetTag_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetTag_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetTag_Value_PropertyAddress, SentryCrashReporterSetTag_FunctionAddress, "Value");
		SentryCrashReporterSetTag_Value_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetTag_FunctionAddress, "Value");
		SentryCrashReporterSetTag_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetTag_FunctionAddress, "Value", Classes.FStrProperty);
		SentryCrashReporterSetTag_IsValid = SentryCrashReporterSetTag_FunctionAddress != IntPtr.Zero && SentryCrashReporterSetTag_Key_IsValid && SentryCrashReporterSetTag_Value_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetTag", SentryCrashReporterSetTag_IsValid);
		SentryCrashReporterSetRoot_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SentryCrashReporterSetRoot");
		SentryCrashReporterSetRoot_ParamsSize = NativeReflection.GetFunctionParamsSize(SentryCrashReporterSetRoot_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetRoot_RootKey_PropertyAddress, SentryCrashReporterSetRoot_FunctionAddress, "RootKey");
		SentryCrashReporterSetRoot_RootKey_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetRoot_FunctionAddress, "RootKey");
		SentryCrashReporterSetRoot_RootKey_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetRoot_FunctionAddress, "RootKey", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetRoot_RootValue_PropertyAddress, SentryCrashReporterSetRoot_FunctionAddress, "RootValue");
		SentryCrashReporterSetRoot_RootValue_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetRoot_FunctionAddress, "RootValue");
		SentryCrashReporterSetRoot_RootValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetRoot_FunctionAddress, "RootValue", Classes.FStrProperty);
		SentryCrashReporterSetRoot_IsValid = SentryCrashReporterSetRoot_FunctionAddress != IntPtr.Zero && SentryCrashReporterSetRoot_RootKey_IsValid && SentryCrashReporterSetRoot_RootValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetRoot", SentryCrashReporterSetRoot_IsValid);
		SentryCrashReporterSetContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SentryCrashReporterSetContext");
		SentryCrashReporterSetContext_ParamsSize = NativeReflection.GetFunctionParamsSize(SentryCrashReporterSetContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetContext_Key_PropertyAddress, SentryCrashReporterSetContext_FunctionAddress, "Key");
		SentryCrashReporterSetContext_Key_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetContext_FunctionAddress, "Key");
		SentryCrashReporterSetContext_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetContext_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SentryCrashReporterSetContext_ContextValues_PropertyAddress, SentryCrashReporterSetContext_FunctionAddress, "ContextValues");
		SentryCrashReporterSetContext_ContextValues_Offset = NativeReflectionCached.GetPropertyOffset(SentryCrashReporterSetContext_FunctionAddress, "ContextValues");
		SentryCrashReporterSetContext_ContextValues_IsValid = NativeReflectionCached.ValidatePropertyClass(SentryCrashReporterSetContext_FunctionAddress, "ContextValues", Classes.FMapProperty);
		SentryCrashReporterSetContext_IsValid = SentryCrashReporterSetContext_FunctionAddress != IntPtr.Zero && SentryCrashReporterSetContext_Key_IsValid && SentryCrashReporterSetContext_ContextValues_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:SentryCrashReporterSetContext", SentryCrashReporterSetContext_IsValid);
		ReenableMediaPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReenableMediaPlay");
		ReenableMediaPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReenableMediaPlay_FunctionAddress);
		ReenableMediaPlay_IsValid = ReenableMediaPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:ReenableMediaPlay", ReenableMediaPlay_IsValid);
		QueryIsOwnPS5EntitlementSync_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "QueryIsOwnPS5EntitlementSync");
		QueryIsOwnPS5EntitlementSync_ParamsSize = NativeReflection.GetFunctionParamsSize(QueryIsOwnPS5EntitlementSync_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref QueryIsOwnPS5EntitlementSync_QueryEntitlementId_PropertyAddress, QueryIsOwnPS5EntitlementSync_FunctionAddress, "QueryEntitlementId");
		QueryIsOwnPS5EntitlementSync_QueryEntitlementId_Offset = NativeReflectionCached.GetPropertyOffset(QueryIsOwnPS5EntitlementSync_FunctionAddress, "QueryEntitlementId");
		QueryIsOwnPS5EntitlementSync_QueryEntitlementId_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryIsOwnPS5EntitlementSync_FunctionAddress, "QueryEntitlementId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref QueryIsOwnPS5EntitlementSync_ReturnValue_PropertyAddress, QueryIsOwnPS5EntitlementSync_FunctionAddress, "ReturnValue");
		QueryIsOwnPS5EntitlementSync_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(QueryIsOwnPS5EntitlementSync_FunctionAddress, "ReturnValue");
		QueryIsOwnPS5EntitlementSync_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(QueryIsOwnPS5EntitlementSync_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		QueryIsOwnPS5EntitlementSync_IsValid = QueryIsOwnPS5EntitlementSync_FunctionAddress != IntPtr.Zero && QueryIsOwnPS5EntitlementSync_QueryEntitlementId_IsValid && QueryIsOwnPS5EntitlementSync_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:QueryIsOwnPS5EntitlementSync", QueryIsOwnPS5EntitlementSync_IsValid);
		PS5UsbSelectDevice_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PS5UsbSelectDevice");
		PS5UsbSelectDevice_ParamsSize = NativeReflection.GetFunctionParamsSize(PS5UsbSelectDevice_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbSelectDevice_UsrDir_PropertyAddress, PS5UsbSelectDevice_FunctionAddress, "UsrDir");
		PS5UsbSelectDevice_UsrDir_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbSelectDevice_FunctionAddress, "UsrDir");
		PS5UsbSelectDevice_UsrDir_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbSelectDevice_FunctionAddress, "UsrDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbSelectDevice_OutDeviceId_PropertyAddress, PS5UsbSelectDevice_FunctionAddress, "OutDeviceId");
		PS5UsbSelectDevice_OutDeviceId_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbSelectDevice_FunctionAddress, "OutDeviceId");
		PS5UsbSelectDevice_OutDeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbSelectDevice_FunctionAddress, "OutDeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbSelectDevice_ReturnValue_PropertyAddress, PS5UsbSelectDevice_FunctionAddress, "ReturnValue");
		PS5UsbSelectDevice_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbSelectDevice_FunctionAddress, "ReturnValue");
		PS5UsbSelectDevice_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbSelectDevice_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		PS5UsbSelectDevice_IsValid = PS5UsbSelectDevice_FunctionAddress != IntPtr.Zero && PS5UsbSelectDevice_UsrDir_IsValid && PS5UsbSelectDevice_OutDeviceId_IsValid && PS5UsbSelectDevice_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbSelectDevice", PS5UsbSelectDevice_IsValid);
		PS5UsbMkSubDir_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PS5UsbMkSubDir");
		PS5UsbMkSubDir_ParamsSize = NativeReflection.GetFunctionParamsSize(PS5UsbMkSubDir_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_DeviceId_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "DeviceId");
		PS5UsbMkSubDir_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "DeviceId");
		PS5UsbMkSubDir_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "DeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_MountPoint_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "MountPoint");
		PS5UsbMkSubDir_MountPoint_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "MountPoint");
		PS5UsbMkSubDir_MountPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "MountPoint", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_UsrDir_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "UsrDir");
		PS5UsbMkSubDir_UsrDir_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "UsrDir");
		PS5UsbMkSubDir_UsrDir_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "UsrDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_SubDir_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "SubDir");
		PS5UsbMkSubDir_SubDir_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "SubDir");
		PS5UsbMkSubDir_SubDir_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "SubDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_OutDirPath_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "OutDirPath");
		PS5UsbMkSubDir_OutDirPath_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "OutDirPath");
		PS5UsbMkSubDir_OutDirPath_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "OutDirPath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5UsbMkSubDir_ReturnValue_PropertyAddress, PS5UsbMkSubDir_FunctionAddress, "ReturnValue");
		PS5UsbMkSubDir_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PS5UsbMkSubDir_FunctionAddress, "ReturnValue");
		PS5UsbMkSubDir_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5UsbMkSubDir_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PS5UsbMkSubDir_IsValid = PS5UsbMkSubDir_FunctionAddress != IntPtr.Zero && PS5UsbMkSubDir_DeviceId_IsValid && PS5UsbMkSubDir_MountPoint_IsValid && PS5UsbMkSubDir_UsrDir_IsValid && PS5UsbMkSubDir_SubDir_IsValid && PS5UsbMkSubDir_OutDirPath_IsValid && PS5UsbMkSubDir_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PS5UsbMkSubDir", PS5UsbMkSubDir_IsValid);
		PS5RequestUnMapUsb_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PS5RequestUnMapUsb");
		PS5RequestUnMapUsb_ParamsSize = NativeReflection.GetFunctionParamsSize(PS5RequestUnMapUsb_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestUnMapUsb_DeviceId_PropertyAddress, PS5RequestUnMapUsb_FunctionAddress, "DeviceId");
		PS5RequestUnMapUsb_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestUnMapUsb_FunctionAddress, "DeviceId");
		PS5RequestUnMapUsb_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestUnMapUsb_FunctionAddress, "DeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestUnMapUsb_UsrDir_PropertyAddress, PS5RequestUnMapUsb_FunctionAddress, "UsrDir");
		PS5RequestUnMapUsb_UsrDir_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestUnMapUsb_FunctionAddress, "UsrDir");
		PS5RequestUnMapUsb_UsrDir_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestUnMapUsb_FunctionAddress, "UsrDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestUnMapUsb_ReturnValue_PropertyAddress, PS5RequestUnMapUsb_FunctionAddress, "ReturnValue");
		PS5RequestUnMapUsb_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestUnMapUsb_FunctionAddress, "ReturnValue");
		PS5RequestUnMapUsb_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestUnMapUsb_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		PS5RequestUnMapUsb_IsValid = PS5RequestUnMapUsb_FunctionAddress != IntPtr.Zero && PS5RequestUnMapUsb_DeviceId_IsValid && PS5RequestUnMapUsb_UsrDir_IsValid && PS5RequestUnMapUsb_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestUnMapUsb", PS5RequestUnMapUsb_IsValid);
		PS5RequestMapUsb_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PS5RequestMapUsb");
		PS5RequestMapUsb_ParamsSize = NativeReflection.GetFunctionParamsSize(PS5RequestMapUsb_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestMapUsb_DeviceId_PropertyAddress, PS5RequestMapUsb_FunctionAddress, "DeviceId");
		PS5RequestMapUsb_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestMapUsb_FunctionAddress, "DeviceId");
		PS5RequestMapUsb_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestMapUsb_FunctionAddress, "DeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestMapUsb_UsrDir_PropertyAddress, PS5RequestMapUsb_FunctionAddress, "UsrDir");
		PS5RequestMapUsb_UsrDir_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestMapUsb_FunctionAddress, "UsrDir");
		PS5RequestMapUsb_UsrDir_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestMapUsb_FunctionAddress, "UsrDir", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestMapUsb_OutMountPoint_PropertyAddress, PS5RequestMapUsb_FunctionAddress, "OutMountPoint");
		PS5RequestMapUsb_OutMountPoint_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestMapUsb_FunctionAddress, "OutMountPoint");
		PS5RequestMapUsb_OutMountPoint_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestMapUsb_FunctionAddress, "OutMountPoint", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5RequestMapUsb_ReturnValue_PropertyAddress, PS5RequestMapUsb_FunctionAddress, "ReturnValue");
		PS5RequestMapUsb_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PS5RequestMapUsb_FunctionAddress, "ReturnValue");
		PS5RequestMapUsb_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5RequestMapUsb_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		PS5RequestMapUsb_IsValid = PS5RequestMapUsb_FunctionAddress != IntPtr.Zero && PS5RequestMapUsb_DeviceId_IsValid && PS5RequestMapUsb_UsrDir_IsValid && PS5RequestMapUsb_OutMountPoint_IsValid && PS5RequestMapUsb_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PS5RequestMapUsb", PS5RequestMapUsb_IsValid);
		PS5ExportDataToUsb_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PS5ExportDataToUsb");
		PS5ExportDataToUsb_ParamsSize = NativeReflection.GetFunctionParamsSize(PS5ExportDataToUsb_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PS5ExportDataToUsb_FileName_PropertyAddress, PS5ExportDataToUsb_FunctionAddress, "FileName");
		PS5ExportDataToUsb_FileName_Offset = NativeReflectionCached.GetPropertyOffset(PS5ExportDataToUsb_FunctionAddress, "FileName");
		PS5ExportDataToUsb_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5ExportDataToUsb_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5ExportDataToUsb_FileContentData_PropertyAddress, PS5ExportDataToUsb_FunctionAddress, "FileContentData");
		PS5ExportDataToUsb_FileContentData_Offset = NativeReflectionCached.GetPropertyOffset(PS5ExportDataToUsb_FunctionAddress, "FileContentData");
		PS5ExportDataToUsb_FileContentData_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5ExportDataToUsb_FunctionAddress, "FileContentData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref PS5ExportDataToUsb_ReturnValue_PropertyAddress, PS5ExportDataToUsb_FunctionAddress, "ReturnValue");
		PS5ExportDataToUsb_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PS5ExportDataToUsb_FunctionAddress, "ReturnValue");
		PS5ExportDataToUsb_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PS5ExportDataToUsb_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		PS5ExportDataToUsb_IsValid = PS5ExportDataToUsb_FunctionAddress != IntPtr.Zero && PS5ExportDataToUsb_FileName_IsValid && PS5ExportDataToUsb_FileContentData_IsValid && PS5ExportDataToUsb_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PS5ExportDataToUsb", PS5ExportDataToUsb_IsValid);
		PrintCachedEntitlements_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PrintCachedEntitlements");
		PrintCachedEntitlements_ParamsSize = NativeReflection.GetFunctionParamsSize(PrintCachedEntitlements_FunctionAddress);
		PrintCachedEntitlements_IsValid = PrintCachedEntitlements_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PrintCachedEntitlements", PrintCachedEntitlements_IsValid);
		PostExceptionSample_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostExceptionSample");
		PostExceptionSample_ParamsSize = NativeReflection.GetFunctionParamsSize(PostExceptionSample_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostExceptionSample_message_PropertyAddress, PostExceptionSample_FunctionAddress, "message");
		PostExceptionSample_message_Offset = NativeReflectionCached.GetPropertyOffset(PostExceptionSample_FunctionAddress, "message");
		PostExceptionSample_message_IsValid = NativeReflectionCached.ValidatePropertyClass(PostExceptionSample_FunctionAddress, "message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostExceptionSample_ReturnValue_PropertyAddress, PostExceptionSample_FunctionAddress, "ReturnValue");
		PostExceptionSample_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostExceptionSample_FunctionAddress, "ReturnValue");
		PostExceptionSample_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostExceptionSample_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PostExceptionSample_IsValid = PostExceptionSample_FunctionAddress != IntPtr.Zero && PostExceptionSample_message_IsValid && PostExceptionSample_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PostExceptionSample", PostExceptionSample_IsValid);
		PostException_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "PostException");
		PostException_ParamsSize = NativeReflection.GetFunctionParamsSize(PostException_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref PostException_type_PropertyAddress, PostException_FunctionAddress, "type");
		PostException_type_Offset = NativeReflectionCached.GetPropertyOffset(PostException_FunctionAddress, "type");
		PostException_type_IsValid = NativeReflectionCached.ValidatePropertyClass(PostException_FunctionAddress, "type", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref PostException_name_PropertyAddress, PostException_FunctionAddress, "name");
		PostException_name_Offset = NativeReflectionCached.GetPropertyOffset(PostException_FunctionAddress, "name");
		PostException_name_IsValid = NativeReflectionCached.ValidatePropertyClass(PostException_FunctionAddress, "name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostException_message_PropertyAddress, PostException_FunctionAddress, "message");
		PostException_message_Offset = NativeReflectionCached.GetPropertyOffset(PostException_FunctionAddress, "message");
		PostException_message_IsValid = NativeReflectionCached.ValidatePropertyClass(PostException_FunctionAddress, "message", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostException_stackTrace_PropertyAddress, PostException_FunctionAddress, "stackTrace");
		PostException_stackTrace_Offset = NativeReflectionCached.GetPropertyOffset(PostException_FunctionAddress, "stackTrace");
		PostException_stackTrace_IsValid = NativeReflectionCached.ValidatePropertyClass(PostException_FunctionAddress, "stackTrace", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref PostException_ReturnValue_PropertyAddress, PostException_FunctionAddress, "ReturnValue");
		PostException_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(PostException_FunctionAddress, "ReturnValue");
		PostException_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(PostException_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		PostException_IsValid = PostException_FunctionAddress != IntPtr.Zero && PostException_type_IsValid && PostException_name_IsValid && PostException_message_IsValid && PostException_stackTrace_IsValid && PostException_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:PostException", PostException_IsValid);
		NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "NonGameThreadStartHttpRawDataRequestWithBlockMode");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_ParamsSize = NativeReflection.GetFunctionParamsSize(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Url");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Url");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Url", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Method");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Method");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "Method", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ExHeaders");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ExHeaders");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "PostRawData");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "PostRawData");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "PostRawData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "RequestTimeout");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "RequestTimeout");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "RequestTimeout", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "OutResponse");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "OutResponse");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "OutResponse", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_PropertyAddress, NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ReturnValue");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ReturnValue");
		NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		NonGameThreadStartHttpRawDataRequestWithBlockMode_IsValid = NonGameThreadStartHttpRawDataRequestWithBlockMode_FunctionAddress != IntPtr.Zero && NonGameThreadStartHttpRawDataRequestWithBlockMode_Url_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_Method_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_ExHeaders_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_PostRawData_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_RequestTimeout_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_OutResponse_IsValid && NonGameThreadStartHttpRawDataRequestWithBlockMode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:NonGameThreadStartHttpRawDataRequestWithBlockMode", NonGameThreadStartHttpRawDataRequestWithBlockMode_IsValid);
		IsPureVersion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsPureVersion");
		IsPureVersion_ParamsSize = NativeReflection.GetFunctionParamsSize(IsPureVersion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsPureVersion_ReturnValue_PropertyAddress, IsPureVersion_FunctionAddress, "ReturnValue");
		IsPureVersion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsPureVersion_FunctionAddress, "ReturnValue");
		IsPureVersion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsPureVersion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsPureVersion_IsValid = IsPureVersion_FunctionAddress != IntPtr.Zero && IsPureVersion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:IsPureVersion", IsPureVersion_IsValid);
		IsCleanVersion_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "IsCleanVersion");
		IsCleanVersion_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCleanVersion_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCleanVersion_ReturnValue_PropertyAddress, IsCleanVersion_FunctionAddress, "ReturnValue");
		IsCleanVersion_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCleanVersion_FunctionAddress, "ReturnValue");
		IsCleanVersion_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCleanVersion_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCleanVersion_IsValid = IsCleanVersion_FunctionAddress != IntPtr.Zero && IsCleanVersion_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:IsCleanVersion", IsCleanVersion_IsValid);
		HttpPostFileList_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HttpPostFileList");
		HttpPostFileList_ParamsSize = NativeReflection.GetFunctionParamsSize(HttpPostFileList_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileList_PostUrl_PropertyAddress, HttpPostFileList_FunctionAddress, "PostUrl");
		HttpPostFileList_PostUrl_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileList_FunctionAddress, "PostUrl");
		HttpPostFileList_PostUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileList_FunctionAddress, "PostUrl", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileList_ExHeaders_PropertyAddress, HttpPostFileList_FunctionAddress, "ExHeaders");
		HttpPostFileList_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileList_FunctionAddress, "ExHeaders");
		HttpPostFileList_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileList_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileList_FilePathList_PropertyAddress, HttpPostFileList_FunctionAddress, "FilePathList");
		HttpPostFileList_FilePathList_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileList_FunctionAddress, "FilePathList");
		HttpPostFileList_FilePathList_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileList_FunctionAddress, "FilePathList", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileList_Listener_PropertyAddress, HttpPostFileList_FunctionAddress, "Listener");
		HttpPostFileList_Listener_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileList_FunctionAddress, "Listener");
		HttpPostFileList_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileList_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileList_ReturnValue_PropertyAddress, HttpPostFileList_FunctionAddress, "ReturnValue");
		HttpPostFileList_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileList_FunctionAddress, "ReturnValue");
		HttpPostFileList_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileList_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HttpPostFileList_IsValid = HttpPostFileList_FunctionAddress != IntPtr.Zero && HttpPostFileList_PostUrl_IsValid && HttpPostFileList_ExHeaders_IsValid && HttpPostFileList_FilePathList_IsValid && HttpPostFileList_Listener_IsValid && HttpPostFileList_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileList", HttpPostFileList_IsValid);
		HttpPostFileContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HttpPostFileContent");
		HttpPostFileContent_ParamsSize = NativeReflection.GetFunctionParamsSize(HttpPostFileContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_PostUrl_PropertyAddress, HttpPostFileContent_FunctionAddress, "PostUrl");
		HttpPostFileContent_PostUrl_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "PostUrl");
		HttpPostFileContent_PostUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "PostUrl", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_ExHeaders_PropertyAddress, HttpPostFileContent_FunctionAddress, "ExHeaders");
		HttpPostFileContent_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "ExHeaders");
		HttpPostFileContent_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_FileName_PropertyAddress, HttpPostFileContent_FunctionAddress, "FileName");
		HttpPostFileContent_FileName_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "FileName");
		HttpPostFileContent_FileName_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "FileName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_FileContentData_PropertyAddress, HttpPostFileContent_FunctionAddress, "FileContentData");
		HttpPostFileContent_FileContentData_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "FileContentData");
		HttpPostFileContent_FileContentData_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "FileContentData", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_Listener_PropertyAddress, HttpPostFileContent_FunctionAddress, "Listener");
		HttpPostFileContent_Listener_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "Listener");
		HttpPostFileContent_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFileContent_ReturnValue_PropertyAddress, HttpPostFileContent_FunctionAddress, "ReturnValue");
		HttpPostFileContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFileContent_FunctionAddress, "ReturnValue");
		HttpPostFileContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFileContent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HttpPostFileContent_IsValid = HttpPostFileContent_FunctionAddress != IntPtr.Zero && HttpPostFileContent_PostUrl_IsValid && HttpPostFileContent_ExHeaders_IsValid && HttpPostFileContent_FileName_IsValid && HttpPostFileContent_FileContentData_IsValid && HttpPostFileContent_Listener_IsValid && HttpPostFileContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFileContent", HttpPostFileContent_IsValid);
		HttpPostFile_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HttpPostFile");
		HttpPostFile_ParamsSize = NativeReflection.GetFunctionParamsSize(HttpPostFile_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFile_PostUrl_PropertyAddress, HttpPostFile_FunctionAddress, "PostUrl");
		HttpPostFile_PostUrl_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFile_FunctionAddress, "PostUrl");
		HttpPostFile_PostUrl_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFile_FunctionAddress, "PostUrl", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFile_ExHeaders_PropertyAddress, HttpPostFile_FunctionAddress, "ExHeaders");
		HttpPostFile_ExHeaders_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFile_FunctionAddress, "ExHeaders");
		HttpPostFile_ExHeaders_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFile_FunctionAddress, "ExHeaders", Classes.FMapProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFile_FilePath_PropertyAddress, HttpPostFile_FunctionAddress, "FilePath");
		HttpPostFile_FilePath_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFile_FunctionAddress, "FilePath");
		HttpPostFile_FilePath_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFile_FunctionAddress, "FilePath", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFile_Listener_PropertyAddress, HttpPostFile_FunctionAddress, "Listener");
		HttpPostFile_Listener_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFile_FunctionAddress, "Listener");
		HttpPostFile_Listener_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFile_FunctionAddress, "Listener", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref HttpPostFile_ReturnValue_PropertyAddress, HttpPostFile_FunctionAddress, "ReturnValue");
		HttpPostFile_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HttpPostFile_FunctionAddress, "ReturnValue");
		HttpPostFile_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HttpPostFile_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HttpPostFile_IsValid = HttpPostFile_FunctionAddress != IntPtr.Zero && HttpPostFile_PostUrl_IsValid && HttpPostFile_ExHeaders_IsValid && HttpPostFile_FilePath_IsValid && HttpPostFile_Listener_IsValid && HttpPostFile_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:HttpPostFile", HttpPostFile_IsValid);
		GetPS5UserDefinedParam_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPS5UserDefinedParam");
		GetPS5UserDefinedParam_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPS5UserDefinedParam_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UserDefinedParam_index_PropertyAddress, GetPS5UserDefinedParam_FunctionAddress, "index");
		GetPS5UserDefinedParam_index_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UserDefinedParam_FunctionAddress, "index");
		GetPS5UserDefinedParam_index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UserDefinedParam_FunctionAddress, "index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UserDefinedParam_ReturnValue_PropertyAddress, GetPS5UserDefinedParam_FunctionAddress, "ReturnValue");
		GetPS5UserDefinedParam_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UserDefinedParam_FunctionAddress, "ReturnValue");
		GetPS5UserDefinedParam_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UserDefinedParam_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPS5UserDefinedParam_IsValid = GetPS5UserDefinedParam_FunctionAddress != IntPtr.Zero && GetPS5UserDefinedParam_index_IsValid && GetPS5UserDefinedParam_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserDefinedParam", GetPS5UserDefinedParam_IsValid);
		GetPS5UserAccountRegionCode_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPS5UserAccountRegionCode");
		GetPS5UserAccountRegionCode_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPS5UserAccountRegionCode_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UserAccountRegionCode_ReturnValue_PropertyAddress, GetPS5UserAccountRegionCode_FunctionAddress, "ReturnValue");
		GetPS5UserAccountRegionCode_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UserAccountRegionCode_FunctionAddress, "ReturnValue");
		GetPS5UserAccountRegionCode_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UserAccountRegionCode_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetPS5UserAccountRegionCode_IsValid = GetPS5UserAccountRegionCode_FunctionAddress != IntPtr.Zero && GetPS5UserAccountRegionCode_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UserAccountRegionCode", GetPS5UserAccountRegionCode_IsValid);
		GetPS5UsbStorageDeviceInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetPS5UsbStorageDeviceInfo");
		GetPS5UsbStorageDeviceInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPS5UsbStorageDeviceInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UsbStorageDeviceInfo_DeviceId_PropertyAddress, GetPS5UsbStorageDeviceInfo_FunctionAddress, "DeviceId");
		GetPS5UsbStorageDeviceInfo_DeviceId_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UsbStorageDeviceInfo_FunctionAddress, "DeviceId");
		GetPS5UsbStorageDeviceInfo_DeviceId_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UsbStorageDeviceInfo_FunctionAddress, "DeviceId", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UsbStorageDeviceInfo_OutInfo_PropertyAddress, GetPS5UsbStorageDeviceInfo_FunctionAddress, "OutInfo");
		GetPS5UsbStorageDeviceInfo_OutInfo_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UsbStorageDeviceInfo_FunctionAddress, "OutInfo");
		GetPS5UsbStorageDeviceInfo_OutInfo_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UsbStorageDeviceInfo_FunctionAddress, "OutInfo", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPS5UsbStorageDeviceInfo_ReturnValue_PropertyAddress, GetPS5UsbStorageDeviceInfo_FunctionAddress, "ReturnValue");
		GetPS5UsbStorageDeviceInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPS5UsbStorageDeviceInfo_FunctionAddress, "ReturnValue");
		GetPS5UsbStorageDeviceInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPS5UsbStorageDeviceInfo_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetPS5UsbStorageDeviceInfo_IsValid = GetPS5UsbStorageDeviceInfo_FunctionAddress != IntPtr.Zero && GetPS5UsbStorageDeviceInfo_DeviceId_IsValid && GetPS5UsbStorageDeviceInfo_OutInfo_IsValid && GetPS5UsbStorageDeviceInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetPS5UsbStorageDeviceInfo", GetPS5UsbStorageDeviceInfo_IsValid);
		GetNatInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetNatInfo");
		GetNatInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNatInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetNatInfo_ReturnValue_PropertyAddress, GetNatInfo_FunctionAddress, "ReturnValue");
		GetNatInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetNatInfo_FunctionAddress, "ReturnValue");
		GetNatInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetNatInfo_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetNatInfo_IsValid = GetNatInfo_FunctionAddress != IntPtr.Zero && GetNatInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetNatInfo", GetNatInfo_IsValid);
		GetIOSDocumentPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIOSDocumentPath");
		GetIOSDocumentPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIOSDocumentPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIOSDocumentPath_ReturnValue_PropertyAddress, GetIOSDocumentPath_FunctionAddress, "ReturnValue");
		GetIOSDocumentPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIOSDocumentPath_FunctionAddress, "ReturnValue");
		GetIOSDocumentPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIOSDocumentPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetIOSDocumentPath_IsValid = GetIOSDocumentPath_FunctionAddress != IntPtr.Zero && GetIOSDocumentPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSDocumentPath", GetIOSDocumentPath_IsValid);
		GetIOSBundlePath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetIOSBundlePath");
		GetIOSBundlePath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetIOSBundlePath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetIOSBundlePath_ReturnValue_PropertyAddress, GetIOSBundlePath_FunctionAddress, "ReturnValue");
		GetIOSBundlePath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetIOSBundlePath_FunctionAddress, "ReturnValue");
		GetIOSBundlePath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetIOSBundlePath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetIOSBundlePath_IsValid = GetIOSBundlePath_FunctionAddress != IntPtr.Zero && GetIOSBundlePath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetIOSBundlePath", GetIOSBundlePath_IsValid);
		GetGameRunEnvContext_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetGameRunEnvContext");
		GetGameRunEnvContext_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGameRunEnvContext_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGameRunEnvContext_OutContext_PropertyAddress, GetGameRunEnvContext_FunctionAddress, "OutContext");
		GetGameRunEnvContext_OutContext_Offset = NativeReflectionCached.GetPropertyOffset(GetGameRunEnvContext_FunctionAddress, "OutContext");
		GetGameRunEnvContext_OutContext_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGameRunEnvContext_FunctionAddress, "OutContext", Classes.FMapProperty);
		GetGameRunEnvContext_IsValid = GetGameRunEnvContext_FunctionAddress != IntPtr.Zero && GetGameRunEnvContext_OutContext_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetGameRunEnvContext", GetGameRunEnvContext_IsValid);
		GetAllPS5UsbStorageDeviceId_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllPS5UsbStorageDeviceId");
		GetAllPS5UsbStorageDeviceId_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllPS5UsbStorageDeviceId_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllPS5UsbStorageDeviceId_OutIds_PropertyAddress, GetAllPS5UsbStorageDeviceId_FunctionAddress, "OutIds");
		GetAllPS5UsbStorageDeviceId_OutIds_Offset = NativeReflectionCached.GetPropertyOffset(GetAllPS5UsbStorageDeviceId_FunctionAddress, "OutIds");
		GetAllPS5UsbStorageDeviceId_OutIds_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllPS5UsbStorageDeviceId_FunctionAddress, "OutIds", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllPS5UsbStorageDeviceId_ReturnValue_PropertyAddress, GetAllPS5UsbStorageDeviceId_FunctionAddress, "ReturnValue");
		GetAllPS5UsbStorageDeviceId_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAllPS5UsbStorageDeviceId_FunctionAddress, "ReturnValue");
		GetAllPS5UsbStorageDeviceId_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllPS5UsbStorageDeviceId_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAllPS5UsbStorageDeviceId_IsValid = GetAllPS5UsbStorageDeviceId_FunctionAddress != IntPtr.Zero && GetAllPS5UsbStorageDeviceId_OutIds_IsValid && GetAllPS5UsbStorageDeviceId_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:GetAllPS5UsbStorageDeviceId", GetAllPS5UsbStorageDeviceId_IsValid);
		FCommandLine_Get_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FCommandLine_Get");
		FCommandLine_Get_ParamsSize = NativeReflection.GetFunctionParamsSize(FCommandLine_Get_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FCommandLine_Get_ReturnValue_PropertyAddress, FCommandLine_Get_FunctionAddress, "ReturnValue");
		FCommandLine_Get_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FCommandLine_Get_FunctionAddress, "ReturnValue");
		FCommandLine_Get_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FCommandLine_Get_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		FCommandLine_Get_IsValid = FCommandLine_Get_FunctionAddress != IntPtr.Zero && FCommandLine_Get_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_Get", FCommandLine_Get_IsValid);
		FCommandLine_AddArg_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FCommandLine_AddArg");
		FCommandLine_AddArg_ParamsSize = NativeReflection.GetFunctionParamsSize(FCommandLine_AddArg_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FCommandLine_AddArg_Command_PropertyAddress, FCommandLine_AddArg_FunctionAddress, "Command");
		FCommandLine_AddArg_Command_Offset = NativeReflectionCached.GetPropertyOffset(FCommandLine_AddArg_FunctionAddress, "Command");
		FCommandLine_AddArg_Command_IsValid = NativeReflectionCached.ValidatePropertyClass(FCommandLine_AddArg_FunctionAddress, "Command", Classes.FStrProperty);
		FCommandLine_AddArg_IsValid = FCommandLine_AddArg_FunctionAddress != IntPtr.Zero && FCommandLine_AddArg_Command_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:FCommandLine_AddArg", FCommandLine_AddArg_IsValid);
		DisableMediaPlay_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "DisableMediaPlay");
		DisableMediaPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(DisableMediaPlay_FunctionAddress);
		DisableMediaPlay_IsValid = DisableMediaPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:DisableMediaPlay", DisableMediaPlay_IsValid);
		AddCrashUserData_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddCrashUserData");
		AddCrashUserData_ParamsSize = NativeReflection.GetFunctionParamsSize(AddCrashUserData_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddCrashUserData_Key_PropertyAddress, AddCrashUserData_FunctionAddress, "Key");
		AddCrashUserData_Key_Offset = NativeReflectionCached.GetPropertyOffset(AddCrashUserData_FunctionAddress, "Key");
		AddCrashUserData_Key_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCrashUserData_FunctionAddress, "Key", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCrashUserData_Value_PropertyAddress, AddCrashUserData_FunctionAddress, "Value");
		AddCrashUserData_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddCrashUserData_FunctionAddress, "Value");
		AddCrashUserData_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCrashUserData_FunctionAddress, "Value", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddCrashUserData_ReturnValue_PropertyAddress, AddCrashUserData_FunctionAddress, "ReturnValue");
		AddCrashUserData_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddCrashUserData_FunctionAddress, "ReturnValue");
		AddCrashUserData_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddCrashUserData_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		AddCrashUserData_IsValid = AddCrashUserData_FunctionAddress != IntPtr.Zero && AddCrashUserData_Key_IsValid && AddCrashUserData_Value_IsValid && AddCrashUserData_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/UnrealExtent.GSE_SDKFuncLib:AddCrashUserData", AddCrashUserData_IsValid);
	}
}
