using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.OSC;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/OSC.OSCManager", "OSC", UnrealModuleType.EnginePlugin)]
public class UOSCManager : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool SetOSCMessageAddress_IsValid;

	private static IntPtr SetOSCMessageAddress_FunctionAddress;

	private static int SetOSCMessageAddress_ParamsSize;

	private static bool SetOSCMessageAddress_Message_IsValid;

	private static FFieldAddress SetOSCMessageAddress_Message_PropertyAddress;

	private static int SetOSCMessageAddress_Message_Offset;

	private static bool SetOSCMessageAddress_Address_IsValid;

	private static FFieldAddress SetOSCMessageAddress_Address_PropertyAddress;

	private static int SetOSCMessageAddress_Address_Offset;

	private static bool SetOSCMessageAddress_ReturnValue_IsValid;

	private static FFieldAddress SetOSCMessageAddress_ReturnValue_PropertyAddress;

	private static int SetOSCMessageAddress_ReturnValue_Offset;

	private static bool SetOSCAddressMethod_IsValid;

	private static IntPtr SetOSCAddressMethod_FunctionAddress;

	private static int SetOSCAddressMethod_ParamsSize;

	private static bool SetOSCAddressMethod_Address_IsValid;

	private static FFieldAddress SetOSCAddressMethod_Address_PropertyAddress;

	private static int SetOSCAddressMethod_Address_Offset;

	private static bool SetOSCAddressMethod_Method_IsValid;

	private static FFieldAddress SetOSCAddressMethod_Method_PropertyAddress;

	private static int SetOSCAddressMethod_Method_Offset;

	private static bool SetOSCAddressMethod_ReturnValue_IsValid;

	private static FFieldAddress SetOSCAddressMethod_ReturnValue_PropertyAddress;

	private static int SetOSCAddressMethod_ReturnValue_Offset;

	private static bool OSCAddressRemoveContainers_IsValid;

	private static IntPtr OSCAddressRemoveContainers_FunctionAddress;

	private static int OSCAddressRemoveContainers_ParamsSize;

	private static bool OSCAddressRemoveContainers_Address_IsValid;

	private static FFieldAddress OSCAddressRemoveContainers_Address_PropertyAddress;

	private static int OSCAddressRemoveContainers_Address_Offset;

	private static bool OSCAddressRemoveContainers_Index_IsValid;

	private static FFieldAddress OSCAddressRemoveContainers_Index_PropertyAddress;

	private static int OSCAddressRemoveContainers_Index_Offset;

	private static bool OSCAddressRemoveContainers_Count_IsValid;

	private static FFieldAddress OSCAddressRemoveContainers_Count_PropertyAddress;

	private static int OSCAddressRemoveContainers_Count_Offset;

	private static bool OSCAddressRemoveContainers_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressRemoveContainers_ReturnValue_PropertyAddress;

	private static int OSCAddressRemoveContainers_ReturnValue_Offset;

	private static bool OSCAddressPushContainers_IsValid;

	private static IntPtr OSCAddressPushContainers_FunctionAddress;

	private static int OSCAddressPushContainers_ParamsSize;

	private static bool OSCAddressPushContainers_Address_IsValid;

	private static FFieldAddress OSCAddressPushContainers_Address_PropertyAddress;

	private static int OSCAddressPushContainers_Address_Offset;

	private static bool OSCAddressPushContainers_Containers_IsValid;

	private static FFieldAddress OSCAddressPushContainers_Containers_PropertyAddress;

	private static int OSCAddressPushContainers_Containers_Offset;

	private static bool OSCAddressPushContainers_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressPushContainers_ReturnValue_PropertyAddress;

	private static int OSCAddressPushContainers_ReturnValue_Offset;

	private static bool OSCAddressPushContainer_IsValid;

	private static IntPtr OSCAddressPushContainer_FunctionAddress;

	private static int OSCAddressPushContainer_ParamsSize;

	private static bool OSCAddressPushContainer_Address_IsValid;

	private static FFieldAddress OSCAddressPushContainer_Address_PropertyAddress;

	private static int OSCAddressPushContainer_Address_Offset;

	private static bool OSCAddressPushContainer_Container_IsValid;

	private static FFieldAddress OSCAddressPushContainer_Container_PropertyAddress;

	private static int OSCAddressPushContainer_Container_Offset;

	private static bool OSCAddressPushContainer_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressPushContainer_ReturnValue_PropertyAddress;

	private static int OSCAddressPushContainer_ReturnValue_Offset;

	private static bool OSCAddressPopContainers_IsValid;

	private static IntPtr OSCAddressPopContainers_FunctionAddress;

	private static int OSCAddressPopContainers_ParamsSize;

	private static bool OSCAddressPopContainers_Address_IsValid;

	private static FFieldAddress OSCAddressPopContainers_Address_PropertyAddress;

	private static int OSCAddressPopContainers_Address_Offset;

	private static bool OSCAddressPopContainers_NumContainers_IsValid;

	private static FFieldAddress OSCAddressPopContainers_NumContainers_PropertyAddress;

	private static int OSCAddressPopContainers_NumContainers_Offset;

	private static bool OSCAddressPopContainers_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressPopContainers_ReturnValue_PropertyAddress;

	private static int OSCAddressPopContainers_ReturnValue_Offset;

	private static bool OSCAddressPopContainer_IsValid;

	private static IntPtr OSCAddressPopContainer_FunctionAddress;

	private static int OSCAddressPopContainer_ParamsSize;

	private static bool OSCAddressPopContainer_Address_IsValid;

	private static FFieldAddress OSCAddressPopContainer_Address_PropertyAddress;

	private static int OSCAddressPopContainer_Address_Offset;

	private static bool OSCAddressPopContainer_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressPopContainer_ReturnValue_PropertyAddress;

	private static int OSCAddressPopContainer_ReturnValue_Offset;

	private static bool OSCAddressPathMatchesPattern_IsValid;

	private static IntPtr OSCAddressPathMatchesPattern_FunctionAddress;

	private static int OSCAddressPathMatchesPattern_ParamsSize;

	private static bool OSCAddressPathMatchesPattern_Pattern_IsValid;

	private static FFieldAddress OSCAddressPathMatchesPattern_Pattern_PropertyAddress;

	private static int OSCAddressPathMatchesPattern_Pattern_Offset;

	private static bool OSCAddressPathMatchesPattern_Path_IsValid;

	private static FFieldAddress OSCAddressPathMatchesPattern_Path_PropertyAddress;

	private static int OSCAddressPathMatchesPattern_Path_Offset;

	private static bool OSCAddressPathMatchesPattern_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressPathMatchesPattern_ReturnValue_PropertyAddress;

	private static int OSCAddressPathMatchesPattern_ReturnValue_Offset;

	private static bool OSCAddressIsValidPattern_IsValid;

	private static IntPtr OSCAddressIsValidPattern_FunctionAddress;

	private static int OSCAddressIsValidPattern_ParamsSize;

	private static bool OSCAddressIsValidPattern_Address_IsValid;

	private static FFieldAddress OSCAddressIsValidPattern_Address_PropertyAddress;

	private static int OSCAddressIsValidPattern_Address_Offset;

	private static bool OSCAddressIsValidPattern_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressIsValidPattern_ReturnValue_PropertyAddress;

	private static int OSCAddressIsValidPattern_ReturnValue_Offset;

	private static bool OSCAddressIsValidPath_IsValid;

	private static IntPtr OSCAddressIsValidPath_FunctionAddress;

	private static int OSCAddressIsValidPath_ParamsSize;

	private static bool OSCAddressIsValidPath_Address_IsValid;

	private static FFieldAddress OSCAddressIsValidPath_Address_PropertyAddress;

	private static int OSCAddressIsValidPath_Address_Offset;

	private static bool OSCAddressIsValidPath_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressIsValidPath_ReturnValue_PropertyAddress;

	private static int OSCAddressIsValidPath_ReturnValue_Offset;

	private static bool OSCAddressFromObjectPathString_IsValid;

	private static IntPtr OSCAddressFromObjectPathString_FunctionAddress;

	private static int OSCAddressFromObjectPathString_ParamsSize;

	private static bool OSCAddressFromObjectPathString_PathName_IsValid;

	private static FFieldAddress OSCAddressFromObjectPathString_PathName_PropertyAddress;

	private static int OSCAddressFromObjectPathString_PathName_Offset;

	private static bool OSCAddressFromObjectPathString_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressFromObjectPathString_ReturnValue_PropertyAddress;

	private static int OSCAddressFromObjectPathString_ReturnValue_Offset;

	private static bool OSCAddressFromObjectPath_IsValid;

	private static IntPtr OSCAddressFromObjectPath_FunctionAddress;

	private static int OSCAddressFromObjectPath_ParamsSize;

	private static bool OSCAddressFromObjectPath_Object_IsValid;

	private static FFieldAddress OSCAddressFromObjectPath_Object_PropertyAddress;

	private static int OSCAddressFromObjectPath_Object_Offset;

	private static bool OSCAddressFromObjectPath_ReturnValue_IsValid;

	private static FFieldAddress OSCAddressFromObjectPath_ReturnValue_PropertyAddress;

	private static int OSCAddressFromObjectPath_ReturnValue_Offset;

	private static bool ObjectPathFromOSCAddress_IsValid;

	private static IntPtr ObjectPathFromOSCAddress_FunctionAddress;

	private static int ObjectPathFromOSCAddress_ParamsSize;

	private static bool ObjectPathFromOSCAddress_Address_IsValid;

	private static FFieldAddress ObjectPathFromOSCAddress_Address_PropertyAddress;

	private static int ObjectPathFromOSCAddress_Address_Offset;

	private static bool ObjectPathFromOSCAddress_ReturnValue_IsValid;

	private static FFieldAddress ObjectPathFromOSCAddress_ReturnValue_PropertyAddress;

	private static int ObjectPathFromOSCAddress_ReturnValue_Offset;

	private static bool GetString_IsValid;

	private static IntPtr GetString_FunctionAddress;

	private static int GetString_ParamsSize;

	private static bool GetString_Message_IsValid;

	private static FFieldAddress GetString_Message_PropertyAddress;

	private static int GetString_Message_Offset;

	private static bool GetString_Index_IsValid;

	private static FFieldAddress GetString_Index_PropertyAddress;

	private static int GetString_Index_Offset;

	private static bool GetString_Value_IsValid;

	private static FFieldAddress GetString_Value_PropertyAddress;

	private static int GetString_Value_Offset;

	private static bool GetString_ReturnValue_IsValid;

	private static FFieldAddress GetString_ReturnValue_PropertyAddress;

	private static int GetString_ReturnValue_Offset;

	private static bool GetOSCMessageAddress_IsValid;

	private static IntPtr GetOSCMessageAddress_FunctionAddress;

	private static int GetOSCMessageAddress_ParamsSize;

	private static bool GetOSCMessageAddress_Message_IsValid;

	private static FFieldAddress GetOSCMessageAddress_Message_PropertyAddress;

	private static int GetOSCMessageAddress_Message_Offset;

	private static bool GetOSCMessageAddress_ReturnValue_IsValid;

	private static FFieldAddress GetOSCMessageAddress_ReturnValue_PropertyAddress;

	private static int GetOSCMessageAddress_ReturnValue_Offset;

	private static bool GetOSCAddressMethod_IsValid;

	private static IntPtr GetOSCAddressMethod_FunctionAddress;

	private static int GetOSCAddressMethod_ParamsSize;

	private static bool GetOSCAddressMethod_Address_IsValid;

	private static FFieldAddress GetOSCAddressMethod_Address_PropertyAddress;

	private static int GetOSCAddressMethod_Address_Offset;

	private static bool GetOSCAddressMethod_ReturnValue_IsValid;

	private static FFieldAddress GetOSCAddressMethod_ReturnValue_PropertyAddress;

	private static int GetOSCAddressMethod_ReturnValue_Offset;

	private static bool GetOSCAddressFullPath_IsValid;

	private static IntPtr GetOSCAddressFullPath_FunctionAddress;

	private static int GetOSCAddressFullPath_ParamsSize;

	private static bool GetOSCAddressFullPath_Address_IsValid;

	private static FFieldAddress GetOSCAddressFullPath_Address_PropertyAddress;

	private static int GetOSCAddressFullPath_Address_Offset;

	private static bool GetOSCAddressFullPath_ReturnValue_IsValid;

	private static FFieldAddress GetOSCAddressFullPath_ReturnValue_PropertyAddress;

	private static int GetOSCAddressFullPath_ReturnValue_Offset;

	private static bool GetOSCAddressContainers_IsValid;

	private static IntPtr GetOSCAddressContainers_FunctionAddress;

	private static int GetOSCAddressContainers_ParamsSize;

	private static bool GetOSCAddressContainers_Address_IsValid;

	private static FFieldAddress GetOSCAddressContainers_Address_PropertyAddress;

	private static int GetOSCAddressContainers_Address_Offset;

	private static bool GetOSCAddressContainers_ReturnValue_IsValid;

	private static FFieldAddress GetOSCAddressContainers_ReturnValue_PropertyAddress;

	private static int GetOSCAddressContainers_ReturnValue_Offset;

	private static bool GetOSCAddressContainerPath_IsValid;

	private static IntPtr GetOSCAddressContainerPath_FunctionAddress;

	private static int GetOSCAddressContainerPath_ParamsSize;

	private static bool GetOSCAddressContainerPath_Address_IsValid;

	private static FFieldAddress GetOSCAddressContainerPath_Address_PropertyAddress;

	private static int GetOSCAddressContainerPath_Address_Offset;

	private static bool GetOSCAddressContainerPath_ReturnValue_IsValid;

	private static FFieldAddress GetOSCAddressContainerPath_ReturnValue_PropertyAddress;

	private static int GetOSCAddressContainerPath_ReturnValue_Offset;

	private static bool GetOSCAddressContainer_IsValid;

	private static IntPtr GetOSCAddressContainer_FunctionAddress;

	private static int GetOSCAddressContainer_ParamsSize;

	private static bool GetOSCAddressContainer_Address_IsValid;

	private static FFieldAddress GetOSCAddressContainer_Address_PropertyAddress;

	private static int GetOSCAddressContainer_Address_Offset;

	private static bool GetOSCAddressContainer_Index_IsValid;

	private static FFieldAddress GetOSCAddressContainer_Index_PropertyAddress;

	private static int GetOSCAddressContainer_Index_Offset;

	private static bool GetOSCAddressContainer_ReturnValue_IsValid;

	private static FFieldAddress GetOSCAddressContainer_ReturnValue_PropertyAddress;

	private static int GetOSCAddressContainer_ReturnValue_Offset;

	private static bool GetMessagesFromBundle_IsValid;

	private static IntPtr GetMessagesFromBundle_FunctionAddress;

	private static int GetMessagesFromBundle_ParamsSize;

	private static bool GetMessagesFromBundle_Bundle_IsValid;

	private static FFieldAddress GetMessagesFromBundle_Bundle_PropertyAddress;

	private static int GetMessagesFromBundle_Bundle_Offset;

	private static bool GetMessagesFromBundle_ReturnValue_IsValid;

	private static FFieldAddress GetMessagesFromBundle_ReturnValue_PropertyAddress;

	private static int GetMessagesFromBundle_ReturnValue_Offset;

	private static bool GetMessageFromBundle_IsValid;

	private static IntPtr GetMessageFromBundle_FunctionAddress;

	private static int GetMessageFromBundle_ParamsSize;

	private static bool GetMessageFromBundle_Bundle_IsValid;

	private static FFieldAddress GetMessageFromBundle_Bundle_PropertyAddress;

	private static int GetMessageFromBundle_Bundle_Offset;

	private static bool GetMessageFromBundle_Index_IsValid;

	private static FFieldAddress GetMessageFromBundle_Index_PropertyAddress;

	private static int GetMessageFromBundle_Index_Offset;

	private static bool GetMessageFromBundle_bSucceeded_IsValid;

	private static FFieldAddress GetMessageFromBundle_bSucceeded_PropertyAddress;

	private static int GetMessageFromBundle_bSucceeded_Offset;

	private static bool GetMessageFromBundle_ReturnValue_IsValid;

	private static FFieldAddress GetMessageFromBundle_ReturnValue_PropertyAddress;

	private static int GetMessageFromBundle_ReturnValue_Offset;

	private static bool GetInt64_IsValid;

	private static IntPtr GetInt64_FunctionAddress;

	private static int GetInt64_ParamsSize;

	private static bool GetInt64_Message_IsValid;

	private static FFieldAddress GetInt64_Message_PropertyAddress;

	private static int GetInt64_Message_Offset;

	private static bool GetInt64_Index_IsValid;

	private static FFieldAddress GetInt64_Index_PropertyAddress;

	private static int GetInt64_Index_Offset;

	private static bool GetInt64_Value_IsValid;

	private static FFieldAddress GetInt64_Value_PropertyAddress;

	private static int GetInt64_Value_Offset;

	private static bool GetInt64_ReturnValue_IsValid;

	private static FFieldAddress GetInt64_ReturnValue_PropertyAddress;

	private static int GetInt64_ReturnValue_Offset;

	private static bool GetInt32_IsValid;

	private static IntPtr GetInt32_FunctionAddress;

	private static int GetInt32_ParamsSize;

	private static bool GetInt32_Message_IsValid;

	private static FFieldAddress GetInt32_Message_PropertyAddress;

	private static int GetInt32_Message_Offset;

	private static bool GetInt32_Index_IsValid;

	private static FFieldAddress GetInt32_Index_PropertyAddress;

	private static int GetInt32_Index_Offset;

	private static bool GetInt32_Value_IsValid;

	private static FFieldAddress GetInt32_Value_PropertyAddress;

	private static int GetInt32_Value_Offset;

	private static bool GetInt32_ReturnValue_IsValid;

	private static FFieldAddress GetInt32_ReturnValue_PropertyAddress;

	private static int GetInt32_ReturnValue_Offset;

	private static bool GetFloat_IsValid;

	private static IntPtr GetFloat_FunctionAddress;

	private static int GetFloat_ParamsSize;

	private static bool GetFloat_Message_IsValid;

	private static FFieldAddress GetFloat_Message_PropertyAddress;

	private static int GetFloat_Message_Offset;

	private static bool GetFloat_Index_IsValid;

	private static FFieldAddress GetFloat_Index_PropertyAddress;

	private static int GetFloat_Index_Offset;

	private static bool GetFloat_Value_IsValid;

	private static FFieldAddress GetFloat_Value_PropertyAddress;

	private static int GetFloat_Value_Offset;

	private static bool GetFloat_ReturnValue_IsValid;

	private static FFieldAddress GetFloat_ReturnValue_PropertyAddress;

	private static int GetFloat_ReturnValue_Offset;

	private static bool GetBundlesFromBundle_IsValid;

	private static IntPtr GetBundlesFromBundle_FunctionAddress;

	private static int GetBundlesFromBundle_ParamsSize;

	private static bool GetBundlesFromBundle_Bundle_IsValid;

	private static FFieldAddress GetBundlesFromBundle_Bundle_PropertyAddress;

	private static int GetBundlesFromBundle_Bundle_Offset;

	private static bool GetBundlesFromBundle_ReturnValue_IsValid;

	private static FFieldAddress GetBundlesFromBundle_ReturnValue_PropertyAddress;

	private static int GetBundlesFromBundle_ReturnValue_Offset;

	private static bool GetBool_IsValid;

	private static IntPtr GetBool_FunctionAddress;

	private static int GetBool_ParamsSize;

	private static bool GetBool_Message_IsValid;

	private static FFieldAddress GetBool_Message_PropertyAddress;

	private static int GetBool_Message_Offset;

	private static bool GetBool_Index_IsValid;

	private static FFieldAddress GetBool_Index_PropertyAddress;

	private static int GetBool_Index_Offset;

	private static bool GetBool_Value_IsValid;

	private static FFieldAddress GetBool_Value_PropertyAddress;

	private static int GetBool_Value_Offset;

	private static bool GetBool_ReturnValue_IsValid;

	private static FFieldAddress GetBool_ReturnValue_PropertyAddress;

	private static int GetBool_ReturnValue_Offset;

	private static bool GetBlob_IsValid;

	private static IntPtr GetBlob_FunctionAddress;

	private static int GetBlob_ParamsSize;

	private static bool GetBlob_Message_IsValid;

	private static FFieldAddress GetBlob_Message_PropertyAddress;

	private static int GetBlob_Message_Offset;

	private static bool GetBlob_Index_IsValid;

	private static FFieldAddress GetBlob_Index_PropertyAddress;

	private static int GetBlob_Index_Offset;

	private static bool GetBlob_Value_IsValid;

	private static FFieldAddress GetBlob_Value_PropertyAddress;

	private static int GetBlob_Value_Offset;

	private static bool GetBlob_ReturnValue_IsValid;

	private static FFieldAddress GetBlob_ReturnValue_PropertyAddress;

	private static int GetBlob_ReturnValue_Offset;

	private static bool GetAllStrings_IsValid;

	private static IntPtr GetAllStrings_FunctionAddress;

	private static int GetAllStrings_ParamsSize;

	private static bool GetAllStrings_Message_IsValid;

	private static FFieldAddress GetAllStrings_Message_PropertyAddress;

	private static int GetAllStrings_Message_Offset;

	private static bool GetAllStrings_Values_IsValid;

	private static FFieldAddress GetAllStrings_Values_PropertyAddress;

	private static int GetAllStrings_Values_Offset;

	private static bool GetAllInt64s_IsValid;

	private static IntPtr GetAllInt64s_FunctionAddress;

	private static int GetAllInt64s_ParamsSize;

	private static bool GetAllInt64s_Message_IsValid;

	private static FFieldAddress GetAllInt64s_Message_PropertyAddress;

	private static int GetAllInt64s_Message_Offset;

	private static bool GetAllInt64s_Values_IsValid;

	private static FFieldAddress GetAllInt64s_Values_PropertyAddress;

	private static int GetAllInt64s_Values_Offset;

	private static bool GetAllInt32s_IsValid;

	private static IntPtr GetAllInt32s_FunctionAddress;

	private static int GetAllInt32s_ParamsSize;

	private static bool GetAllInt32s_Message_IsValid;

	private static FFieldAddress GetAllInt32s_Message_PropertyAddress;

	private static int GetAllInt32s_Message_Offset;

	private static bool GetAllInt32s_Values_IsValid;

	private static FFieldAddress GetAllInt32s_Values_PropertyAddress;

	private static int GetAllInt32s_Values_Offset;

	private static bool GetAllFloats_IsValid;

	private static IntPtr GetAllFloats_FunctionAddress;

	private static int GetAllFloats_ParamsSize;

	private static bool GetAllFloats_Message_IsValid;

	private static FFieldAddress GetAllFloats_Message_PropertyAddress;

	private static int GetAllFloats_Message_Offset;

	private static bool GetAllFloats_Values_IsValid;

	private static FFieldAddress GetAllFloats_Values_PropertyAddress;

	private static int GetAllFloats_Values_Offset;

	private static bool GetAllBools_IsValid;

	private static IntPtr GetAllBools_FunctionAddress;

	private static int GetAllBools_ParamsSize;

	private static bool GetAllBools_Message_IsValid;

	private static FFieldAddress GetAllBools_Message_PropertyAddress;

	private static int GetAllBools_Message_Offset;

	private static bool GetAllBools_Values_IsValid;

	private static FFieldAddress GetAllBools_Values_PropertyAddress;

	private static int GetAllBools_Values_Offset;

	private static bool GetAllAddresses_IsValid;

	private static IntPtr GetAllAddresses_FunctionAddress;

	private static int GetAllAddresses_ParamsSize;

	private static bool GetAllAddresses_Message_IsValid;

	private static FFieldAddress GetAllAddresses_Message_PropertyAddress;

	private static int GetAllAddresses_Message_Offset;

	private static bool GetAllAddresses_Values_IsValid;

	private static FFieldAddress GetAllAddresses_Values_PropertyAddress;

	private static int GetAllAddresses_Values_Offset;

	private static bool GetAddress_IsValid;

	private static IntPtr GetAddress_FunctionAddress;

	private static int GetAddress_ParamsSize;

	private static bool GetAddress_Message_IsValid;

	private static FFieldAddress GetAddress_Message_PropertyAddress;

	private static int GetAddress_Message_Offset;

	private static bool GetAddress_Index_IsValid;

	private static FFieldAddress GetAddress_Index_PropertyAddress;

	private static int GetAddress_Index_Offset;

	private static bool GetAddress_Value_IsValid;

	private static FFieldAddress GetAddress_Value_PropertyAddress;

	private static int GetAddress_Value_Offset;

	private static bool GetAddress_ReturnValue_IsValid;

	private static FFieldAddress GetAddress_ReturnValue_PropertyAddress;

	private static int GetAddress_ReturnValue_Offset;

	private static bool FindObjectAtOSCAddress_IsValid;

	private static IntPtr FindObjectAtOSCAddress_FunctionAddress;

	private static int FindObjectAtOSCAddress_ParamsSize;

	private static bool FindObjectAtOSCAddress_Address_IsValid;

	private static FFieldAddress FindObjectAtOSCAddress_Address_PropertyAddress;

	private static int FindObjectAtOSCAddress_Address_Offset;

	private static bool FindObjectAtOSCAddress_ReturnValue_IsValid;

	private static FFieldAddress FindObjectAtOSCAddress_ReturnValue_PropertyAddress;

	private static int FindObjectAtOSCAddress_ReturnValue_Offset;

	private static bool CreateOSCServer_IsValid;

	private static IntPtr CreateOSCServer_FunctionAddress;

	private static int CreateOSCServer_ParamsSize;

	private static bool CreateOSCServer_ReceiveIPAddress_IsValid;

	private static FFieldAddress CreateOSCServer_ReceiveIPAddress_PropertyAddress;

	private static int CreateOSCServer_ReceiveIPAddress_Offset;

	private static bool CreateOSCServer_Port_IsValid;

	private static FFieldAddress CreateOSCServer_Port_PropertyAddress;

	private static int CreateOSCServer_Port_Offset;

	private static bool CreateOSCServer_bMulticastLoopback_IsValid;

	private static FFieldAddress CreateOSCServer_bMulticastLoopback_PropertyAddress;

	private static int CreateOSCServer_bMulticastLoopback_Offset;

	private static bool CreateOSCServer_bStartListening_IsValid;

	private static FFieldAddress CreateOSCServer_bStartListening_PropertyAddress;

	private static int CreateOSCServer_bStartListening_Offset;

	private static bool CreateOSCServer_ServerName_IsValid;

	private static FFieldAddress CreateOSCServer_ServerName_PropertyAddress;

	private static int CreateOSCServer_ServerName_Offset;

	private static bool CreateOSCServer_Outer_IsValid;

	private static FFieldAddress CreateOSCServer_Outer_PropertyAddress;

	private static int CreateOSCServer_Outer_Offset;

	private static bool CreateOSCServer_ReturnValue_IsValid;

	private static FFieldAddress CreateOSCServer_ReturnValue_PropertyAddress;

	private static int CreateOSCServer_ReturnValue_Offset;

	private static bool CreateOSCClient_IsValid;

	private static IntPtr CreateOSCClient_FunctionAddress;

	private static int CreateOSCClient_ParamsSize;

	private static bool CreateOSCClient_SendIPAddress_IsValid;

	private static FFieldAddress CreateOSCClient_SendIPAddress_PropertyAddress;

	private static int CreateOSCClient_SendIPAddress_Offset;

	private static bool CreateOSCClient_Port_IsValid;

	private static FFieldAddress CreateOSCClient_Port_PropertyAddress;

	private static int CreateOSCClient_Port_Offset;

	private static bool CreateOSCClient_ClientName_IsValid;

	private static FFieldAddress CreateOSCClient_ClientName_PropertyAddress;

	private static int CreateOSCClient_ClientName_Offset;

	private static bool CreateOSCClient_Outer_IsValid;

	private static FFieldAddress CreateOSCClient_Outer_PropertyAddress;

	private static int CreateOSCClient_Outer_Offset;

	private static bool CreateOSCClient_ReturnValue_IsValid;

	private static FFieldAddress CreateOSCClient_ReturnValue_PropertyAddress;

	private static int CreateOSCClient_ReturnValue_Offset;

	private static bool ConvertStringToOSCAddress_IsValid;

	private static IntPtr ConvertStringToOSCAddress_FunctionAddress;

	private static int ConvertStringToOSCAddress_ParamsSize;

	private static bool ConvertStringToOSCAddress_String_IsValid;

	private static FFieldAddress ConvertStringToOSCAddress_String_PropertyAddress;

	private static int ConvertStringToOSCAddress_String_Offset;

	private static bool ConvertStringToOSCAddress_ReturnValue_IsValid;

	private static FFieldAddress ConvertStringToOSCAddress_ReturnValue_PropertyAddress;

	private static int ConvertStringToOSCAddress_ReturnValue_Offset;

	private static bool ClearOSCAddressContainers_IsValid;

	private static IntPtr ClearOSCAddressContainers_FunctionAddress;

	private static int ClearOSCAddressContainers_ParamsSize;

	private static bool ClearOSCAddressContainers_Address_IsValid;

	private static FFieldAddress ClearOSCAddressContainers_Address_PropertyAddress;

	private static int ClearOSCAddressContainers_Address_Offset;

	private static bool ClearOSCAddressContainers_ReturnValue_IsValid;

	private static FFieldAddress ClearOSCAddressContainers_ReturnValue_PropertyAddress;

	private static int ClearOSCAddressContainers_ReturnValue_Offset;

	private static bool ClearMessage_IsValid;

	private static IntPtr ClearMessage_FunctionAddress;

	private static int ClearMessage_ParamsSize;

	private static bool ClearMessage_Message_IsValid;

	private static FFieldAddress ClearMessage_Message_PropertyAddress;

	private static int ClearMessage_Message_Offset;

	private static bool ClearMessage_ReturnValue_IsValid;

	private static FFieldAddress ClearMessage_ReturnValue_PropertyAddress;

	private static int ClearMessage_ReturnValue_Offset;

	private static bool ClearBundle_IsValid;

	private static IntPtr ClearBundle_FunctionAddress;

	private static int ClearBundle_ParamsSize;

	private static bool ClearBundle_Bundle_IsValid;

	private static FFieldAddress ClearBundle_Bundle_PropertyAddress;

	private static int ClearBundle_Bundle_Offset;

	private static bool ClearBundle_ReturnValue_IsValid;

	private static FFieldAddress ClearBundle_ReturnValue_PropertyAddress;

	private static int ClearBundle_ReturnValue_Offset;

	private static bool AddString_IsValid;

	private static IntPtr AddString_FunctionAddress;

	private static int AddString_ParamsSize;

	private static bool AddString_Message_IsValid;

	private static FFieldAddress AddString_Message_PropertyAddress;

	private static int AddString_Message_Offset;

	private static bool AddString_Value_IsValid;

	private static FFieldAddress AddString_Value_PropertyAddress;

	private static int AddString_Value_Offset;

	private static bool AddString_ReturnValue_IsValid;

	private static FFieldAddress AddString_ReturnValue_PropertyAddress;

	private static int AddString_ReturnValue_Offset;

	private static bool AddMessageToBundle_IsValid;

	private static IntPtr AddMessageToBundle_FunctionAddress;

	private static int AddMessageToBundle_ParamsSize;

	private static bool AddMessageToBundle_Message_IsValid;

	private static FFieldAddress AddMessageToBundle_Message_PropertyAddress;

	private static int AddMessageToBundle_Message_Offset;

	private static bool AddMessageToBundle_Bundle_IsValid;

	private static FFieldAddress AddMessageToBundle_Bundle_PropertyAddress;

	private static int AddMessageToBundle_Bundle_Offset;

	private static bool AddMessageToBundle_ReturnValue_IsValid;

	private static FFieldAddress AddMessageToBundle_ReturnValue_PropertyAddress;

	private static int AddMessageToBundle_ReturnValue_Offset;

	private static bool AddInt64_IsValid;

	private static IntPtr AddInt64_FunctionAddress;

	private static int AddInt64_ParamsSize;

	private static bool AddInt64_Message_IsValid;

	private static FFieldAddress AddInt64_Message_PropertyAddress;

	private static int AddInt64_Message_Offset;

	private static bool AddInt64_Value_IsValid;

	private static FFieldAddress AddInt64_Value_PropertyAddress;

	private static int AddInt64_Value_Offset;

	private static bool AddInt64_ReturnValue_IsValid;

	private static FFieldAddress AddInt64_ReturnValue_PropertyAddress;

	private static int AddInt64_ReturnValue_Offset;

	private static bool AddInt32_IsValid;

	private static IntPtr AddInt32_FunctionAddress;

	private static int AddInt32_ParamsSize;

	private static bool AddInt32_Message_IsValid;

	private static FFieldAddress AddInt32_Message_PropertyAddress;

	private static int AddInt32_Message_Offset;

	private static bool AddInt32_Value_IsValid;

	private static FFieldAddress AddInt32_Value_PropertyAddress;

	private static int AddInt32_Value_Offset;

	private static bool AddInt32_ReturnValue_IsValid;

	private static FFieldAddress AddInt32_ReturnValue_PropertyAddress;

	private static int AddInt32_ReturnValue_Offset;

	private static bool AddFloat_IsValid;

	private static IntPtr AddFloat_FunctionAddress;

	private static int AddFloat_ParamsSize;

	private static bool AddFloat_Message_IsValid;

	private static FFieldAddress AddFloat_Message_PropertyAddress;

	private static int AddFloat_Message_Offset;

	private static bool AddFloat_Value_IsValid;

	private static FFieldAddress AddFloat_Value_PropertyAddress;

	private static int AddFloat_Value_Offset;

	private static bool AddFloat_ReturnValue_IsValid;

	private static FFieldAddress AddFloat_ReturnValue_PropertyAddress;

	private static int AddFloat_ReturnValue_Offset;

	private static bool AddBundleToBundle_IsValid;

	private static IntPtr AddBundleToBundle_FunctionAddress;

	private static int AddBundleToBundle_ParamsSize;

	private static bool AddBundleToBundle_InBundle_IsValid;

	private static FFieldAddress AddBundleToBundle_InBundle_PropertyAddress;

	private static int AddBundleToBundle_InBundle_Offset;

	private static bool AddBundleToBundle_OutBundle_IsValid;

	private static FFieldAddress AddBundleToBundle_OutBundle_PropertyAddress;

	private static int AddBundleToBundle_OutBundle_Offset;

	private static bool AddBundleToBundle_ReturnValue_IsValid;

	private static FFieldAddress AddBundleToBundle_ReturnValue_PropertyAddress;

	private static int AddBundleToBundle_ReturnValue_Offset;

	private static bool AddBool_IsValid;

	private static IntPtr AddBool_FunctionAddress;

	private static int AddBool_ParamsSize;

	private static bool AddBool_Message_IsValid;

	private static FFieldAddress AddBool_Message_PropertyAddress;

	private static int AddBool_Message_Offset;

	private static bool AddBool_Value_IsValid;

	private static FFieldAddress AddBool_Value_PropertyAddress;

	private static int AddBool_Value_Offset;

	private static bool AddBool_ReturnValue_IsValid;

	private static FFieldAddress AddBool_ReturnValue_PropertyAddress;

	private static int AddBool_ReturnValue_Offset;

	private static bool AddBlob_IsValid;

	private static IntPtr AddBlob_FunctionAddress;

	private static int AddBlob_ParamsSize;

	private static bool AddBlob_Message_IsValid;

	private static FFieldAddress AddBlob_Message_PropertyAddress;

	private static int AddBlob_Message_Offset;

	private static bool AddBlob_Value_IsValid;

	private static FFieldAddress AddBlob_Value_PropertyAddress;

	private static int AddBlob_Value_Offset;

	private static bool AddBlob_ReturnValue_IsValid;

	private static FFieldAddress AddBlob_ReturnValue_PropertyAddress;

	private static int AddBlob_ReturnValue_Offset;

	private static bool AddAddress_IsValid;

	private static IntPtr AddAddress_FunctionAddress;

	private static int AddAddress_ParamsSize;

	private static bool AddAddress_Message_IsValid;

	private static FFieldAddress AddAddress_Message_PropertyAddress;

	private static int AddAddress_Message_Offset;

	private static bool AddAddress_Value_IsValid;

	private static FFieldAddress AddAddress_Value_PropertyAddress;

	private static int AddAddress_Value_Offset;

	private static bool AddAddress_ReturnValue_IsValid;

	private static FFieldAddress AddAddress_ReturnValue_PropertyAddress;

	private static int AddAddress_ReturnValue_Offset;

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:SetOSCMessageAddress")]
	public unsafe static FOSCMessage SetOSCMessageAddress(ref FOSCMessage Message, FOSCAddress Address)
	{
		if (!SetOSCMessageAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:SetOSCMessageAddress");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOSCMessageAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOSCMessageAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOSCMessageAddress_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, SetOSCMessageAddress_Message_Offset), 0, SetOSCMessageAddress_Message_PropertyAddress.Address, Message);
		NativeReflection.InitializeValue_InContainer(SetOSCMessageAddress_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, SetOSCMessageAddress_Address_Offset), 0, SetOSCMessageAddress_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOSCMessageAddress_FunctionAddress, intPtr, SetOSCMessageAddress_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, SetOSCMessageAddress_Message_Offset), 0, SetOSCMessageAddress_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOSCMessageAddress_Message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetOSCMessageAddress_Address_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, SetOSCMessageAddress_ReturnValue_Offset), 0, SetOSCMessageAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOSCMessageAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:SetOSCAddressMethod")]
	public unsafe static FOSCAddress SetOSCAddressMethod(ref FOSCAddress Address, string Method)
	{
		if (!SetOSCAddressMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:SetOSCAddressMethod");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetOSCAddressMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetOSCAddressMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(SetOSCAddressMethod_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, SetOSCAddressMethod_Address_Offset), 0, SetOSCAddressMethod_Address_PropertyAddress.Address, Address);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, SetOSCAddressMethod_Method_Offset), 0, SetOSCAddressMethod_Method_PropertyAddress.Address, Method);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, SetOSCAddressMethod_FunctionAddress, intPtr, SetOSCAddressMethod_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, SetOSCAddressMethod_Address_Offset), 0, SetOSCAddressMethod_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOSCAddressMethod_Address_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(SetOSCAddressMethod_Method_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, SetOSCAddressMethod_ReturnValue_Offset), 0, SetOSCAddressMethod_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(SetOSCAddressMethod_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressRemoveContainers")]
	public unsafe static FOSCAddress OSCAddressRemoveContainers(ref FOSCAddress Address, int Index, int Count)
	{
		if (!OSCAddressRemoveContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressRemoveContainers");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressRemoveContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressRemoveContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressRemoveContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressRemoveContainers_Address_Offset), 0, OSCAddressRemoveContainers_Address_PropertyAddress.Address, Address);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCAddressRemoveContainers_Index_Offset), 0, OSCAddressRemoveContainers_Index_PropertyAddress.Address, Index);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCAddressRemoveContainers_Count_Offset), 0, OSCAddressRemoveContainers_Count_PropertyAddress.Address, Count);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressRemoveContainers_FunctionAddress, intPtr, OSCAddressRemoveContainers_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressRemoveContainers_Address_Offset), 0, OSCAddressRemoveContainers_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressRemoveContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressRemoveContainers_ReturnValue_Offset), 0, OSCAddressRemoveContainers_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressRemoveContainers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressPushContainers")]
	public unsafe static FOSCAddress OSCAddressPushContainers(ref FOSCAddress Address, List<string> Containers)
	{
		if (!OSCAddressPushContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressPushContainers");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressPushContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressPushContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressPushContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPushContainers_Address_Offset), 0, OSCAddressPushContainers_Address_PropertyAddress.Address, Address);
		new TArrayCopyMarshaler<string>(1, OSCAddressPushContainers_Containers_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, OSCAddressPushContainers_Containers_Offset), Containers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressPushContainers_FunctionAddress, intPtr, OSCAddressPushContainers_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPushContainers_Address_Offset), 0, OSCAddressPushContainers_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainers_Address_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainers_Containers_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPushContainers_ReturnValue_Offset), 0, OSCAddressPushContainers_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressPushContainer")]
	public unsafe static FOSCAddress OSCAddressPushContainer(ref FOSCAddress Address, string Container)
	{
		if (!OSCAddressPushContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressPushContainer");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressPushContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressPushContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressPushContainer_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPushContainer_Address_Offset), 0, OSCAddressPushContainer_Address_PropertyAddress.Address, Address);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCAddressPushContainer_Container_Offset), 0, OSCAddressPushContainer_Container_PropertyAddress.Address, Container);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressPushContainer_FunctionAddress, intPtr, OSCAddressPushContainer_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPushContainer_Address_Offset), 0, OSCAddressPushContainer_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainer_Address_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainer_Container_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPushContainer_ReturnValue_Offset), 0, OSCAddressPushContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPushContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressPopContainers")]
	public unsafe static List<string> OSCAddressPopContainers(ref FOSCAddress Address, int NumContainers)
	{
		if (!OSCAddressPopContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressPopContainers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressPopContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressPopContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressPopContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPopContainers_Address_Offset), 0, OSCAddressPopContainers_Address_PropertyAddress.Address, Address);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, OSCAddressPopContainers_NumContainers_Offset), 0, OSCAddressPopContainers_NumContainers_PropertyAddress.Address, NumContainers);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressPopContainers_FunctionAddress, intPtr, OSCAddressPopContainers_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPopContainers_Address_Offset), 0, OSCAddressPopContainers_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPopContainers_Address_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, OSCAddressPopContainers_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, OSCAddressPopContainers_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(OSCAddressPopContainers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressPopContainer")]
	public unsafe static string OSCAddressPopContainer(ref FOSCAddress Address)
	{
		if (!OSCAddressPopContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressPopContainer");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressPopContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressPopContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressPopContainer_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPopContainer_Address_Offset), 0, OSCAddressPopContainer_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressPopContainer_FunctionAddress, intPtr, OSCAddressPopContainer_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressPopContainer_Address_Offset), 0, OSCAddressPopContainer_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPopContainer_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, OSCAddressPopContainer_ReturnValue_Offset), 0, OSCAddressPopContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressPopContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressPathMatchesPattern")]
	public unsafe static bool OSCAddressPathMatchesPattern(FOSCAddress Pattern, FOSCAddress Path)
	{
		if (!OSCAddressPathMatchesPattern_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressPathMatchesPattern");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressPathMatchesPattern_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressPathMatchesPattern_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressPathMatchesPattern_Pattern_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPathMatchesPattern_Pattern_Offset), 0, OSCAddressPathMatchesPattern_Pattern_PropertyAddress.Address, Pattern);
		NativeReflection.InitializeValue_InContainer(OSCAddressPathMatchesPattern_Path_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressPathMatchesPattern_Path_Offset), 0, OSCAddressPathMatchesPattern_Path_PropertyAddress.Address, Path);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressPathMatchesPattern_FunctionAddress, intPtr, OSCAddressPathMatchesPattern_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OSCAddressPathMatchesPattern_Pattern_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(OSCAddressPathMatchesPattern_Path_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OSCAddressPathMatchesPattern_ReturnValue_Offset), 0, OSCAddressPathMatchesPattern_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressIsValidPattern")]
	public unsafe static bool OSCAddressIsValidPattern(FOSCAddress Address)
	{
		if (!OSCAddressIsValidPattern_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressIsValidPattern");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressIsValidPattern_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressIsValidPattern_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressIsValidPattern_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressIsValidPattern_Address_Offset), 0, OSCAddressIsValidPattern_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressIsValidPattern_FunctionAddress, intPtr, OSCAddressIsValidPattern_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OSCAddressIsValidPattern_Address_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OSCAddressIsValidPattern_ReturnValue_Offset), 0, OSCAddressIsValidPattern_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressIsValidPath")]
	public unsafe static bool OSCAddressIsValidPath(FOSCAddress Address)
	{
		if (!OSCAddressIsValidPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressIsValidPath");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressIsValidPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressIsValidPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(OSCAddressIsValidPath_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, OSCAddressIsValidPath_Address_Offset), 0, OSCAddressIsValidPath_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressIsValidPath_FunctionAddress, intPtr, OSCAddressIsValidPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OSCAddressIsValidPath_Address_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, OSCAddressIsValidPath_ReturnValue_Offset), 0, OSCAddressIsValidPath_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressFromObjectPathString")]
	public unsafe static FOSCAddress OSCAddressFromObjectPathString(string PathName)
	{
		if (!OSCAddressFromObjectPathString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressFromObjectPathString");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressFromObjectPathString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressFromObjectPathString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, OSCAddressFromObjectPathString_PathName_Offset), 0, OSCAddressFromObjectPathString_PathName_PropertyAddress.Address, PathName);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressFromObjectPathString_FunctionAddress, intPtr, OSCAddressFromObjectPathString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(OSCAddressFromObjectPathString_PathName_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressFromObjectPathString_ReturnValue_Offset), 0, OSCAddressFromObjectPathString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressFromObjectPathString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OSC.OSCManager:OSCAddressFromObjectPath")]
	public unsafe static FOSCAddress OSCAddressFromObjectPath(UObject Object)
	{
		if (!OSCAddressFromObjectPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:OSCAddressFromObjectPath");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(OSCAddressFromObjectPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OSCAddressFromObjectPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, OSCAddressFromObjectPath_Object_Offset), 0, OSCAddressFromObjectPath_Object_PropertyAddress.Address, Object);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, OSCAddressFromObjectPath_FunctionAddress, intPtr, OSCAddressFromObjectPath_ParamsSize);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, OSCAddressFromObjectPath_ReturnValue_Offset), 0, OSCAddressFromObjectPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(OSCAddressFromObjectPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:ObjectPathFromOSCAddress")]
	public unsafe static string ObjectPathFromOSCAddress(FOSCAddress Address)
	{
		if (!ObjectPathFromOSCAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:ObjectPathFromOSCAddress");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ObjectPathFromOSCAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ObjectPathFromOSCAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ObjectPathFromOSCAddress_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, ObjectPathFromOSCAddress_Address_Offset), 0, ObjectPathFromOSCAddress_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ObjectPathFromOSCAddress_FunctionAddress, intPtr, ObjectPathFromOSCAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ObjectPathFromOSCAddress_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, ObjectPathFromOSCAddress_ReturnValue_Offset), 0, ObjectPathFromOSCAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ObjectPathFromOSCAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetString")]
	public unsafe static bool GetString(FOSCMessage Message, int Index, out string Value)
	{
		if (!GetString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetString");
			Value = FStringMarshaler.DefaultString;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetString_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetString_Message_Offset), 0, GetString_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetString_Index_Offset), 0, GetString_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetString_FunctionAddress, intPtr, GetString_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetString_Message_PropertyAddress.Address, intPtr);
		Value = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetString_Value_Offset), 0, GetString_Value_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetString_Value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetString_ReturnValue_Offset), 0, GetString_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCMessageAddress")]
	public unsafe static FOSCAddress GetOSCMessageAddress(FOSCMessage Message)
	{
		if (!GetOSCMessageAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCMessageAddress");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCMessageAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCMessageAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCMessageAddress_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetOSCMessageAddress_Message_Offset), 0, GetOSCMessageAddress_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCMessageAddress_FunctionAddress, intPtr, GetOSCMessageAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCMessageAddress_Message_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, GetOSCMessageAddress_ReturnValue_Offset), 0, GetOSCMessageAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOSCMessageAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCAddressMethod")]
	public unsafe static string GetOSCAddressMethod(FOSCAddress Address)
	{
		if (!GetOSCAddressMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCAddressMethod");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCAddressMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCAddressMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCAddressMethod_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, GetOSCAddressMethod_Address_Offset), 0, GetOSCAddressMethod_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCAddressMethod_FunctionAddress, intPtr, GetOSCAddressMethod_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressMethod_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetOSCAddressMethod_ReturnValue_Offset), 0, GetOSCAddressMethod_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressMethod_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCAddressFullPath")]
	public unsafe static string GetOSCAddressFullPath(FOSCAddress Address)
	{
		if (!GetOSCAddressFullPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCAddressFullPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCAddressFullPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCAddressFullPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCAddressFullPath_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, GetOSCAddressFullPath_Address_Offset), 0, GetOSCAddressFullPath_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCAddressFullPath_FunctionAddress, intPtr, GetOSCAddressFullPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressFullPath_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetOSCAddressFullPath_ReturnValue_Offset), 0, GetOSCAddressFullPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressFullPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCAddressContainers")]
	public unsafe static List<string> GetOSCAddressContainers(FOSCAddress Address)
	{
		if (!GetOSCAddressContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCAddressContainers");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCAddressContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCAddressContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCAddressContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, GetOSCAddressContainers_Address_Offset), 0, GetOSCAddressContainers_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCAddressContainers_FunctionAddress, intPtr, GetOSCAddressContainers_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainers_Address_PropertyAddress.Address, intPtr);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetOSCAddressContainers_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetOSCAddressContainers_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCAddressContainerPath")]
	public unsafe static string GetOSCAddressContainerPath(FOSCAddress Address)
	{
		if (!GetOSCAddressContainerPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCAddressContainerPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCAddressContainerPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCAddressContainerPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCAddressContainerPath_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, GetOSCAddressContainerPath_Address_Offset), 0, GetOSCAddressContainerPath_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCAddressContainerPath_FunctionAddress, intPtr, GetOSCAddressContainerPath_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainerPath_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetOSCAddressContainerPath_ReturnValue_Offset), 0, GetOSCAddressContainerPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainerPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetOSCAddressContainer")]
	public unsafe static string GetOSCAddressContainer(FOSCAddress Address, int Index)
	{
		if (!GetOSCAddressContainer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetOSCAddressContainer");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetOSCAddressContainer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetOSCAddressContainer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetOSCAddressContainer_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, GetOSCAddressContainer_Address_Offset), 0, GetOSCAddressContainer_Address_PropertyAddress.Address, Address);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetOSCAddressContainer_Index_Offset), 0, GetOSCAddressContainer_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetOSCAddressContainer_FunctionAddress, intPtr, GetOSCAddressContainer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainer_Address_PropertyAddress.Address, intPtr);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetOSCAddressContainer_ReturnValue_Offset), 0, GetOSCAddressContainer_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetOSCAddressContainer_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetMessagesFromBundle")]
	public unsafe static List<FOSCMessage> GetMessagesFromBundle(FOSCBundle Bundle)
	{
		if (!GetMessagesFromBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetMessagesFromBundle");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMessagesFromBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMessagesFromBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMessagesFromBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, GetMessagesFromBundle_Bundle_Offset), 0, GetMessagesFromBundle_Bundle_PropertyAddress.Address, Bundle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMessagesFromBundle_FunctionAddress, intPtr, GetMessagesFromBundle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMessagesFromBundle_Bundle_PropertyAddress.Address, intPtr);
		List<FOSCMessage> result = new TArrayCopyMarshaler<FOSCMessage>(1, GetMessagesFromBundle_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FOSCMessage, FOSCMessage>.FromNative, CachedMarshalingDelegates<FOSCMessage, FOSCMessage>.ToNative).FromNative(IntPtr.Add(intPtr, GetMessagesFromBundle_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetMessagesFromBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetMessageFromBundle")]
	public unsafe static FOSCMessage GetMessageFromBundle(FOSCBundle Bundle, int Index, out bool bSucceeded)
	{
		if (!GetMessageFromBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetMessageFromBundle");
			bSucceeded = false;
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMessageFromBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMessageFromBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetMessageFromBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, GetMessageFromBundle_Bundle_Offset), 0, GetMessageFromBundle_Bundle_PropertyAddress.Address, Bundle);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetMessageFromBundle_Index_Offset), 0, GetMessageFromBundle_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetMessageFromBundle_FunctionAddress, intPtr, GetMessageFromBundle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetMessageFromBundle_Bundle_PropertyAddress.Address, intPtr);
		bSucceeded = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetMessageFromBundle_bSucceeded_Offset), 0, GetMessageFromBundle_bSucceeded_PropertyAddress.Address);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, GetMessageFromBundle_ReturnValue_Offset), 0, GetMessageFromBundle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetMessageFromBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetInt64")]
	public unsafe static bool GetInt64(FOSCMessage Message, int Index, out long Value)
	{
		if (!GetInt64_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetInt64");
			Value = 0L;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt64_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt64_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInt64_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetInt64_Message_Offset), 0, GetInt64_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetInt64_Index_Offset), 0, GetInt64_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInt64_FunctionAddress, intPtr, GetInt64_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInt64_Message_PropertyAddress.Address, intPtr);
		Value = BlittableTypeMarshaler<long>.FromNative(IntPtr.Add(intPtr, GetInt64_Value_Offset), 0, GetInt64_Value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInt64_ReturnValue_Offset), 0, GetInt64_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetInt32")]
	public unsafe static bool GetInt32(FOSCMessage Message, int Index, out int Value)
	{
		if (!GetInt32_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetInt32");
			Value = 0;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInt32_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInt32_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetInt32_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetInt32_Message_Offset), 0, GetInt32_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetInt32_Index_Offset), 0, GetInt32_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInt32_FunctionAddress, intPtr, GetInt32_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInt32_Message_PropertyAddress.Address, intPtr);
		Value = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetInt32_Value_Offset), 0, GetInt32_Value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetInt32_ReturnValue_Offset), 0, GetInt32_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetFloat")]
	public unsafe static bool GetFloat(FOSCMessage Message, int Index, out float Value)
	{
		if (!GetFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetFloat");
			Value = 0f;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetFloat_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetFloat_Message_Offset), 0, GetFloat_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetFloat_Index_Offset), 0, GetFloat_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetFloat_FunctionAddress, intPtr, GetFloat_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetFloat_Message_PropertyAddress.Address, intPtr);
		Value = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetFloat_Value_Offset), 0, GetFloat_Value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetFloat_ReturnValue_Offset), 0, GetFloat_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetBundlesFromBundle")]
	public unsafe static List<FOSCBundle> GetBundlesFromBundle(FOSCBundle Bundle)
	{
		if (!GetBundlesFromBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetBundlesFromBundle");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBundlesFromBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBundlesFromBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBundlesFromBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, GetBundlesFromBundle_Bundle_Offset), 0, GetBundlesFromBundle_Bundle_PropertyAddress.Address, Bundle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBundlesFromBundle_FunctionAddress, intPtr, GetBundlesFromBundle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBundlesFromBundle_Bundle_PropertyAddress.Address, intPtr);
		List<FOSCBundle> result = new TArrayCopyMarshaler<FOSCBundle>(1, GetBundlesFromBundle_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FOSCBundle, FOSCBundle>.FromNative, CachedMarshalingDelegates<FOSCBundle, FOSCBundle>.ToNative).FromNative(IntPtr.Add(intPtr, GetBundlesFromBundle_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetBundlesFromBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetBool")]
	public unsafe static bool GetBool(FOSCMessage Message, int Index, out bool Value)
	{
		if (!GetBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetBool");
			Value = false;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBool_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetBool_Message_Offset), 0, GetBool_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBool_Index_Offset), 0, GetBool_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBool_FunctionAddress, intPtr, GetBool_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBool_Message_PropertyAddress.Address, intPtr);
		Value = BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBool_Value_Offset), 0, GetBool_Value_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBool_ReturnValue_Offset), 0, GetBool_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetBlob")]
	public unsafe static bool GetBlob(FOSCMessage Message, int Index, out List<byte> Value)
	{
		if (!GetBlob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetBlob");
			Value = null;
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBlob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBlob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetBlob_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetBlob_Message_Offset), 0, GetBlob_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBlob_Index_Offset), 0, GetBlob_Index_PropertyAddress.Address, Index);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBlob_FunctionAddress, intPtr, GetBlob_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetBlob_Message_PropertyAddress.Address, intPtr);
		Value = new TArrayCopyMarshaler<byte>(1, GetBlob_Value_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).FromNative(IntPtr.Add(intPtr, GetBlob_Value_Offset));
		NativeReflection.DestroyValue_InContainer(GetBlob_Value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetBlob_ReturnValue_Offset), 0, GetBlob_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllStrings")]
	public unsafe static void GetAllStrings(FOSCMessage Message, out List<string> Values)
	{
		if (!GetAllStrings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllStrings");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllStrings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllStrings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllStrings_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllStrings_Message_Offset), 0, GetAllStrings_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllStrings_FunctionAddress, intPtr, GetAllStrings_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllStrings_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<string>(1, GetAllStrings_Values_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllStrings_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllStrings_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllInt64s")]
	public unsafe static void GetAllInt64s(FOSCMessage Message, out List<long> Values)
	{
		if (!GetAllInt64s_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllInt64s");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllInt64s_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllInt64s_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllInt64s_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllInt64s_Message_Offset), 0, GetAllInt64s_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllInt64s_FunctionAddress, intPtr, GetAllInt64s_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllInt64s_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<long>(1, GetAllInt64s_Values_PropertyAddress, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.FromNative, CachedMarshalingDelegates<long, BlittableTypeMarshaler<long>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllInt64s_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllInt64s_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllInt32s")]
	public unsafe static void GetAllInt32s(FOSCMessage Message, out List<int> Values)
	{
		if (!GetAllInt32s_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllInt32s");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllInt32s_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllInt32s_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllInt32s_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllInt32s_Message_Offset), 0, GetAllInt32s_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllInt32s_FunctionAddress, intPtr, GetAllInt32s_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllInt32s_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<int>(1, GetAllInt32s_Values_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllInt32s_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllInt32s_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllFloats")]
	public unsafe static void GetAllFloats(FOSCMessage Message, out List<float> Values)
	{
		if (!GetAllFloats_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllFloats");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllFloats_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllFloats_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllFloats_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllFloats_Message_Offset), 0, GetAllFloats_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllFloats_FunctionAddress, intPtr, GetAllFloats_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllFloats_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<float>(1, GetAllFloats_Values_PropertyAddress, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.FromNative, CachedMarshalingDelegates<float, BlittableTypeMarshaler<float>>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllFloats_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllFloats_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllBools")]
	public unsafe static void GetAllBools(FOSCMessage Message, out List<bool> Values)
	{
		if (!GetAllBools_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllBools");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllBools_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllBools_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllBools_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllBools_Message_Offset), 0, GetAllBools_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllBools_FunctionAddress, intPtr, GetAllBools_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllBools_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<bool>(1, GetAllBools_Values_PropertyAddress, CachedMarshalingDelegates<bool, BoolMarshaler>.FromNative, CachedMarshalingDelegates<bool, BoolMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllBools_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllBools_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAllAddresses")]
	public unsafe static void GetAllAddresses(FOSCMessage Message, out List<FOSCAddress> Values)
	{
		if (!GetAllAddresses_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAllAddresses");
			Values = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAllAddresses_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAllAddresses_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAllAddresses_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAllAddresses_Message_Offset), 0, GetAllAddresses_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAllAddresses_FunctionAddress, intPtr, GetAllAddresses_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAllAddresses_Message_PropertyAddress.Address, intPtr);
		Values = new TArrayCopyMarshaler<FOSCAddress>(1, GetAllAddresses_Values_PropertyAddress, CachedMarshalingDelegates<FOSCAddress, FOSCAddress>.FromNative, CachedMarshalingDelegates<FOSCAddress, FOSCAddress>.ToNative).FromNative(IntPtr.Add(intPtr, GetAllAddresses_Values_Offset));
		NativeReflection.DestroyValue_InContainer(GetAllAddresses_Values_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:GetAddress")]
	public unsafe static bool GetAddress(FOSCMessage Message, int Index, out FOSCAddress Value)
	{
		if (!GetAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:GetAddress");
			Value = default(FOSCAddress);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(GetAddress_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, GetAddress_Message_Offset), 0, GetAddress_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAddress_Index_Offset), 0, GetAddress_Index_PropertyAddress.Address, Index);
		NativeReflection.InitializeValue_InContainer(GetAddress_Value_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAddress_FunctionAddress, intPtr, GetAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAddress_Message_PropertyAddress.Address, intPtr);
		Value = FOSCAddress.FromNative(IntPtr.Add(intPtr, GetAddress_Value_Offset), 0, GetAddress_Value_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAddress_Value_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetAddress_ReturnValue_Offset), 0, GetAddress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:FindObjectAtOSCAddress")]
	public unsafe static UObject FindObjectAtOSCAddress(FOSCAddress Address)
	{
		if (!FindObjectAtOSCAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:FindObjectAtOSCAddress");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(FindObjectAtOSCAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)FindObjectAtOSCAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(FindObjectAtOSCAddress_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, FindObjectAtOSCAddress_Address_Offset), 0, FindObjectAtOSCAddress_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, FindObjectAtOSCAddress_FunctionAddress, intPtr, FindObjectAtOSCAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(FindObjectAtOSCAddress_Address_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UObject>.FromNative(IntPtr.Add(intPtr, FindObjectAtOSCAddress_ReturnValue_Offset), 0, FindObjectAtOSCAddress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OSC.OSCManager:CreateOSCServer")]
	public unsafe static UOSCServer CreateOSCServer(string ReceiveIPAddress, int Port, bool bMulticastLoopback, bool bStartListening, string ServerName, UObject Outer)
	{
		if (!CreateOSCServer_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:CreateOSCServer");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateOSCServer_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateOSCServer_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCServer_ReceiveIPAddress_Offset), 0, CreateOSCServer_ReceiveIPAddress_PropertyAddress.Address, ReceiveIPAddress);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateOSCServer_Port_Offset), 0, CreateOSCServer_Port_PropertyAddress.Address, Port);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCServer_bMulticastLoopback_Offset), 0, CreateOSCServer_bMulticastLoopback_PropertyAddress.Address, bMulticastLoopback);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCServer_bStartListening_Offset), 0, CreateOSCServer_bStartListening_PropertyAddress.Address, bStartListening);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCServer_ServerName_Offset), 0, CreateOSCServer_ServerName_PropertyAddress.Address, ServerName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateOSCServer_Outer_Offset), 0, CreateOSCServer_Outer_PropertyAddress.Address, Outer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateOSCServer_FunctionAddress, intPtr, CreateOSCServer_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateOSCServer_ReceiveIPAddress_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateOSCServer_ServerName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UOSCServer>.FromNative(IntPtr.Add(intPtr, CreateOSCServer_ReturnValue_Offset), 0, CreateOSCServer_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OSC.OSCManager:CreateOSCClient")]
	public unsafe static UOSCClient CreateOSCClient(string SendIPAddress, int Port, string ClientName, UObject Outer)
	{
		if (!CreateOSCClient_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:CreateOSCClient");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CreateOSCClient_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CreateOSCClient_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCClient_SendIPAddress_Offset), 0, CreateOSCClient_SendIPAddress_PropertyAddress.Address, SendIPAddress);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, CreateOSCClient_Port_Offset), 0, CreateOSCClient_Port_PropertyAddress.Address, Port);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, CreateOSCClient_ClientName_Offset), 0, CreateOSCClient_ClientName_PropertyAddress.Address, ClientName);
		UObjectMarshaler<UObject>.ToNative(IntPtr.Add(intPtr, CreateOSCClient_Outer_Offset), 0, CreateOSCClient_Outer_PropertyAddress.Address, Outer);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CreateOSCClient_FunctionAddress, intPtr, CreateOSCClient_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CreateOSCClient_SendIPAddress_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(CreateOSCClient_ClientName_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UOSCClient>.FromNative(IntPtr.Add(intPtr, CreateOSCClient_ReturnValue_Offset), 0, CreateOSCClient_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/OSC.OSCManager:ConvertStringToOSCAddress")]
	public unsafe static FOSCAddress ConvertStringToOSCAddress(string String)
	{
		if (!ConvertStringToOSCAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:ConvertStringToOSCAddress");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConvertStringToOSCAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConvertStringToOSCAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, ConvertStringToOSCAddress_String_Offset), 0, ConvertStringToOSCAddress_String_PropertyAddress.Address, String);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ConvertStringToOSCAddress_FunctionAddress, intPtr, ConvertStringToOSCAddress_ParamsSize);
		NativeReflection.DestroyValue_InContainer(ConvertStringToOSCAddress_String_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, ConvertStringToOSCAddress_ReturnValue_Offset), 0, ConvertStringToOSCAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ConvertStringToOSCAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:ClearOSCAddressContainers")]
	public unsafe static FOSCAddress ClearOSCAddressContainers(ref FOSCAddress Address)
	{
		if (!ClearOSCAddressContainers_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:ClearOSCAddressContainers");
			return default(FOSCAddress);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearOSCAddressContainers_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearOSCAddressContainers_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearOSCAddressContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, ClearOSCAddressContainers_Address_Offset), 0, ClearOSCAddressContainers_Address_PropertyAddress.Address, Address);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearOSCAddressContainers_FunctionAddress, intPtr, ClearOSCAddressContainers_ParamsSize);
		Address = FOSCAddress.FromNative(IntPtr.Add(intPtr, ClearOSCAddressContainers_Address_Offset), 0, ClearOSCAddressContainers_Address_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearOSCAddressContainers_Address_PropertyAddress.Address, intPtr);
		FOSCAddress result = FOSCAddress.FromNative(IntPtr.Add(intPtr, ClearOSCAddressContainers_ReturnValue_Offset), 0, ClearOSCAddressContainers_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearOSCAddressContainers_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:ClearMessage")]
	public unsafe static FOSCMessage ClearMessage(ref FOSCMessage Message)
	{
		if (!ClearMessage_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:ClearMessage");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearMessage_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearMessage_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearMessage_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, ClearMessage_Message_Offset), 0, ClearMessage_Message_PropertyAddress.Address, Message);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearMessage_FunctionAddress, intPtr, ClearMessage_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, ClearMessage_Message_Offset), 0, ClearMessage_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearMessage_Message_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, ClearMessage_ReturnValue_Offset), 0, ClearMessage_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearMessage_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:ClearBundle")]
	public unsafe static FOSCBundle ClearBundle(ref FOSCBundle Bundle)
	{
		if (!ClearBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:ClearBundle");
			return default(FOSCBundle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ClearBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ClearBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(ClearBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, ClearBundle_Bundle_Offset), 0, ClearBundle_Bundle_PropertyAddress.Address, Bundle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ClearBundle_FunctionAddress, intPtr, ClearBundle_ParamsSize);
		Bundle = FOSCBundle.FromNative(IntPtr.Add(intPtr, ClearBundle_Bundle_Offset), 0, ClearBundle_Bundle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle result = FOSCBundle.FromNative(IntPtr.Add(intPtr, ClearBundle_ReturnValue_Offset), 0, ClearBundle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(ClearBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddString")]
	public unsafe static FOSCMessage AddString(ref FOSCMessage Message, ref string Value)
	{
		if (!AddString_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddString");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddString_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddString_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddString_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddString_Message_Offset), 0, AddString_Message_PropertyAddress.Address, Message);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, AddString_Value_Offset), 0, AddString_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddString_FunctionAddress, intPtr, AddString_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddString_Message_Offset), 0, AddString_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddString_Message_PropertyAddress.Address, intPtr);
		Value = FStringMarshaler.FromNative(IntPtr.Add(intPtr, AddString_Value_Offset), 0, AddString_Value_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddString_Value_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddString_ReturnValue_Offset), 0, AddString_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddString_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddMessageToBundle")]
	public unsafe static FOSCBundle AddMessageToBundle(FOSCMessage Message, ref FOSCBundle Bundle)
	{
		if (!AddMessageToBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddMessageToBundle");
			return default(FOSCBundle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddMessageToBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddMessageToBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddMessageToBundle_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddMessageToBundle_Message_Offset), 0, AddMessageToBundle_Message_PropertyAddress.Address, Message);
		NativeReflection.InitializeValue_InContainer(AddMessageToBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, AddMessageToBundle_Bundle_Offset), 0, AddMessageToBundle_Bundle_PropertyAddress.Address, Bundle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddMessageToBundle_FunctionAddress, intPtr, AddMessageToBundle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddMessageToBundle_Message_PropertyAddress.Address, intPtr);
		Bundle = FOSCBundle.FromNative(IntPtr.Add(intPtr, AddMessageToBundle_Bundle_Offset), 0, AddMessageToBundle_Bundle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddMessageToBundle_Bundle_PropertyAddress.Address, intPtr);
		FOSCBundle result = FOSCBundle.FromNative(IntPtr.Add(intPtr, AddMessageToBundle_ReturnValue_Offset), 0, AddMessageToBundle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddMessageToBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddInt64")]
	public unsafe static FOSCMessage AddInt64(ref FOSCMessage Message, long Value)
	{
		if (!AddInt64_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddInt64");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInt64_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInt64_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddInt64_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddInt64_Message_Offset), 0, AddInt64_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<long>.ToNative(IntPtr.Add(intPtr, AddInt64_Value_Offset), 0, AddInt64_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddInt64_FunctionAddress, intPtr, AddInt64_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddInt64_Message_Offset), 0, AddInt64_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddInt64_Message_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddInt64_ReturnValue_Offset), 0, AddInt64_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddInt64_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddInt32")]
	public unsafe static FOSCMessage AddInt32(ref FOSCMessage Message, int Value)
	{
		if (!AddInt32_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddInt32");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddInt32_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddInt32_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddInt32_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddInt32_Message_Offset), 0, AddInt32_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, AddInt32_Value_Offset), 0, AddInt32_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddInt32_FunctionAddress, intPtr, AddInt32_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddInt32_Message_Offset), 0, AddInt32_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddInt32_Message_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddInt32_ReturnValue_Offset), 0, AddInt32_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddInt32_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddFloat")]
	public unsafe static FOSCMessage AddFloat(ref FOSCMessage Message, float Value)
	{
		if (!AddFloat_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddFloat");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddFloat_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddFloat_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddFloat_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddFloat_Message_Offset), 0, AddFloat_Message_PropertyAddress.Address, Message);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, AddFloat_Value_Offset), 0, AddFloat_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddFloat_FunctionAddress, intPtr, AddFloat_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddFloat_Message_Offset), 0, AddFloat_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddFloat_Message_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddFloat_ReturnValue_Offset), 0, AddFloat_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddFloat_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddBundleToBundle")]
	public unsafe static FOSCBundle AddBundleToBundle(FOSCBundle InBundle, ref FOSCBundle OutBundle)
	{
		if (!AddBundleToBundle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddBundleToBundle");
			return default(FOSCBundle);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBundleToBundle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBundleToBundle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBundleToBundle_InBundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, AddBundleToBundle_InBundle_Offset), 0, AddBundleToBundle_InBundle_PropertyAddress.Address, InBundle);
		NativeReflection.InitializeValue_InContainer(AddBundleToBundle_OutBundle_PropertyAddress.Address, intPtr);
		FOSCBundle.ToNative(IntPtr.Add(intPtr, AddBundleToBundle_OutBundle_Offset), 0, AddBundleToBundle_OutBundle_PropertyAddress.Address, OutBundle);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBundleToBundle_FunctionAddress, intPtr, AddBundleToBundle_ParamsSize);
		NativeReflection.DestroyValue_InContainer(AddBundleToBundle_InBundle_PropertyAddress.Address, intPtr);
		OutBundle = FOSCBundle.FromNative(IntPtr.Add(intPtr, AddBundleToBundle_OutBundle_Offset), 0, AddBundleToBundle_OutBundle_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBundleToBundle_OutBundle_PropertyAddress.Address, intPtr);
		FOSCBundle result = FOSCBundle.FromNative(IntPtr.Add(intPtr, AddBundleToBundle_ReturnValue_Offset), 0, AddBundleToBundle_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBundleToBundle_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddBool")]
	public unsafe static FOSCMessage AddBool(ref FOSCMessage Message, bool Value)
	{
		if (!AddBool_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddBool");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBool_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBool_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBool_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddBool_Message_Offset), 0, AddBool_Message_PropertyAddress.Address, Message);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, AddBool_Value_Offset), 0, AddBool_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBool_FunctionAddress, intPtr, AddBool_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddBool_Message_Offset), 0, AddBool_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBool_Message_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddBool_ReturnValue_Offset), 0, AddBool_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBool_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddBlob")]
	public unsafe static FOSCMessage AddBlob(ref FOSCMessage Message, List<byte> Value)
	{
		if (!AddBlob_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddBlob");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddBlob_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddBlob_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddBlob_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddBlob_Message_Offset), 0, AddBlob_Message_PropertyAddress.Address, Message);
		new TArrayCopyMarshaler<byte>(1, AddBlob_Value_PropertyAddress, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.FromNative, CachedMarshalingDelegates<byte, BlittableTypeMarshaler<byte>>.ToNative).ToNative(IntPtr.Add(intPtr, AddBlob_Value_Offset), Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddBlob_FunctionAddress, intPtr, AddBlob_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddBlob_Message_Offset), 0, AddBlob_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBlob_Message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddBlob_Value_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddBlob_ReturnValue_Offset), 0, AddBlob_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddBlob_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/OSC.OSCManager:AddAddress")]
	public unsafe static FOSCMessage AddAddress(ref FOSCMessage Message, FOSCAddress Value)
	{
		if (!AddAddress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/OSC.OSCManager:AddAddress");
			return default(FOSCMessage);
		}
		byte* ptr = stackalloc byte[(int)(uint)(AddAddress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)AddAddress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(AddAddress_Message_PropertyAddress.Address, intPtr);
		FOSCMessage.ToNative(IntPtr.Add(intPtr, AddAddress_Message_Offset), 0, AddAddress_Message_PropertyAddress.Address, Message);
		NativeReflection.InitializeValue_InContainer(AddAddress_Value_PropertyAddress.Address, intPtr);
		FOSCAddress.ToNative(IntPtr.Add(intPtr, AddAddress_Value_Offset), 0, AddAddress_Value_PropertyAddress.Address, Value);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, AddAddress_FunctionAddress, intPtr, AddAddress_ParamsSize);
		Message = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddAddress_Message_Offset), 0, AddAddress_Message_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddAddress_Message_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(AddAddress_Value_PropertyAddress.Address, intPtr);
		FOSCMessage result = FOSCMessage.FromNative(IntPtr.Add(intPtr, AddAddress_ReturnValue_Offset), 0, AddAddress_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(AddAddress_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UOSCManager()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UOSCManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UOSCManager));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/OSC.OSCManager");
		SetOSCMessageAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOSCMessageAddress");
		SetOSCMessageAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOSCMessageAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOSCMessageAddress_Message_PropertyAddress, SetOSCMessageAddress_FunctionAddress, "Message");
		SetOSCMessageAddress_Message_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCMessageAddress_FunctionAddress, "Message");
		SetOSCMessageAddress_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCMessageAddress_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOSCMessageAddress_Address_PropertyAddress, SetOSCMessageAddress_FunctionAddress, "Address");
		SetOSCMessageAddress_Address_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCMessageAddress_FunctionAddress, "Address");
		SetOSCMessageAddress_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCMessageAddress_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOSCMessageAddress_ReturnValue_PropertyAddress, SetOSCMessageAddress_FunctionAddress, "ReturnValue");
		SetOSCMessageAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCMessageAddress_FunctionAddress, "ReturnValue");
		SetOSCMessageAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCMessageAddress_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetOSCMessageAddress_IsValid = SetOSCMessageAddress_FunctionAddress != IntPtr.Zero && SetOSCMessageAddress_Message_IsValid && SetOSCMessageAddress_Address_IsValid && SetOSCMessageAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:SetOSCMessageAddress", SetOSCMessageAddress_IsValid);
		SetOSCAddressMethod_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "SetOSCAddressMethod");
		SetOSCAddressMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(SetOSCAddressMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetOSCAddressMethod_Address_PropertyAddress, SetOSCAddressMethod_FunctionAddress, "Address");
		SetOSCAddressMethod_Address_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCAddressMethod_FunctionAddress, "Address");
		SetOSCAddressMethod_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCAddressMethod_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOSCAddressMethod_Method_PropertyAddress, SetOSCAddressMethod_FunctionAddress, "Method");
		SetOSCAddressMethod_Method_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCAddressMethod_FunctionAddress, "Method");
		SetOSCAddressMethod_Method_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCAddressMethod_FunctionAddress, "Method", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref SetOSCAddressMethod_ReturnValue_PropertyAddress, SetOSCAddressMethod_FunctionAddress, "ReturnValue");
		SetOSCAddressMethod_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(SetOSCAddressMethod_FunctionAddress, "ReturnValue");
		SetOSCAddressMethod_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(SetOSCAddressMethod_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		SetOSCAddressMethod_IsValid = SetOSCAddressMethod_FunctionAddress != IntPtr.Zero && SetOSCAddressMethod_Address_IsValid && SetOSCAddressMethod_Method_IsValid && SetOSCAddressMethod_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:SetOSCAddressMethod", SetOSCAddressMethod_IsValid);
		OSCAddressRemoveContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressRemoveContainers");
		OSCAddressRemoveContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressRemoveContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressRemoveContainers_Address_PropertyAddress, OSCAddressRemoveContainers_FunctionAddress, "Address");
		OSCAddressRemoveContainers_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressRemoveContainers_FunctionAddress, "Address");
		OSCAddressRemoveContainers_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressRemoveContainers_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressRemoveContainers_Index_PropertyAddress, OSCAddressRemoveContainers_FunctionAddress, "Index");
		OSCAddressRemoveContainers_Index_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressRemoveContainers_FunctionAddress, "Index");
		OSCAddressRemoveContainers_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressRemoveContainers_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressRemoveContainers_Count_PropertyAddress, OSCAddressRemoveContainers_FunctionAddress, "Count");
		OSCAddressRemoveContainers_Count_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressRemoveContainers_FunctionAddress, "Count");
		OSCAddressRemoveContainers_Count_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressRemoveContainers_FunctionAddress, "Count", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressRemoveContainers_ReturnValue_PropertyAddress, OSCAddressRemoveContainers_FunctionAddress, "ReturnValue");
		OSCAddressRemoveContainers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressRemoveContainers_FunctionAddress, "ReturnValue");
		OSCAddressRemoveContainers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressRemoveContainers_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OSCAddressRemoveContainers_IsValid = OSCAddressRemoveContainers_FunctionAddress != IntPtr.Zero && OSCAddressRemoveContainers_Address_IsValid && OSCAddressRemoveContainers_Index_IsValid && OSCAddressRemoveContainers_Count_IsValid && OSCAddressRemoveContainers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressRemoveContainers", OSCAddressRemoveContainers_IsValid);
		OSCAddressPushContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressPushContainers");
		OSCAddressPushContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressPushContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainers_Address_PropertyAddress, OSCAddressPushContainers_FunctionAddress, "Address");
		OSCAddressPushContainers_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainers_FunctionAddress, "Address");
		OSCAddressPushContainers_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainers_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainers_Containers_PropertyAddress, OSCAddressPushContainers_FunctionAddress, "Containers");
		OSCAddressPushContainers_Containers_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainers_FunctionAddress, "Containers");
		OSCAddressPushContainers_Containers_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainers_FunctionAddress, "Containers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainers_ReturnValue_PropertyAddress, OSCAddressPushContainers_FunctionAddress, "ReturnValue");
		OSCAddressPushContainers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainers_FunctionAddress, "ReturnValue");
		OSCAddressPushContainers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainers_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OSCAddressPushContainers_IsValid = OSCAddressPushContainers_FunctionAddress != IntPtr.Zero && OSCAddressPushContainers_Address_IsValid && OSCAddressPushContainers_Containers_IsValid && OSCAddressPushContainers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressPushContainers", OSCAddressPushContainers_IsValid);
		OSCAddressPushContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressPushContainer");
		OSCAddressPushContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressPushContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainer_Address_PropertyAddress, OSCAddressPushContainer_FunctionAddress, "Address");
		OSCAddressPushContainer_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainer_FunctionAddress, "Address");
		OSCAddressPushContainer_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainer_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainer_Container_PropertyAddress, OSCAddressPushContainer_FunctionAddress, "Container");
		OSCAddressPushContainer_Container_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainer_FunctionAddress, "Container");
		OSCAddressPushContainer_Container_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainer_FunctionAddress, "Container", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPushContainer_ReturnValue_PropertyAddress, OSCAddressPushContainer_FunctionAddress, "ReturnValue");
		OSCAddressPushContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPushContainer_FunctionAddress, "ReturnValue");
		OSCAddressPushContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPushContainer_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OSCAddressPushContainer_IsValid = OSCAddressPushContainer_FunctionAddress != IntPtr.Zero && OSCAddressPushContainer_Address_IsValid && OSCAddressPushContainer_Container_IsValid && OSCAddressPushContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressPushContainer", OSCAddressPushContainer_IsValid);
		OSCAddressPopContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressPopContainers");
		OSCAddressPopContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressPopContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPopContainers_Address_PropertyAddress, OSCAddressPopContainers_FunctionAddress, "Address");
		OSCAddressPopContainers_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPopContainers_FunctionAddress, "Address");
		OSCAddressPopContainers_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPopContainers_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPopContainers_NumContainers_PropertyAddress, OSCAddressPopContainers_FunctionAddress, "NumContainers");
		OSCAddressPopContainers_NumContainers_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPopContainers_FunctionAddress, "NumContainers");
		OSCAddressPopContainers_NumContainers_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPopContainers_FunctionAddress, "NumContainers", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPopContainers_ReturnValue_PropertyAddress, OSCAddressPopContainers_FunctionAddress, "ReturnValue");
		OSCAddressPopContainers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPopContainers_FunctionAddress, "ReturnValue");
		OSCAddressPopContainers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPopContainers_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		OSCAddressPopContainers_IsValid = OSCAddressPopContainers_FunctionAddress != IntPtr.Zero && OSCAddressPopContainers_Address_IsValid && OSCAddressPopContainers_NumContainers_IsValid && OSCAddressPopContainers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressPopContainers", OSCAddressPopContainers_IsValid);
		OSCAddressPopContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressPopContainer");
		OSCAddressPopContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressPopContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPopContainer_Address_PropertyAddress, OSCAddressPopContainer_FunctionAddress, "Address");
		OSCAddressPopContainer_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPopContainer_FunctionAddress, "Address");
		OSCAddressPopContainer_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPopContainer_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPopContainer_ReturnValue_PropertyAddress, OSCAddressPopContainer_FunctionAddress, "ReturnValue");
		OSCAddressPopContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPopContainer_FunctionAddress, "ReturnValue");
		OSCAddressPopContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPopContainer_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		OSCAddressPopContainer_IsValid = OSCAddressPopContainer_FunctionAddress != IntPtr.Zero && OSCAddressPopContainer_Address_IsValid && OSCAddressPopContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressPopContainer", OSCAddressPopContainer_IsValid);
		OSCAddressPathMatchesPattern_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressPathMatchesPattern");
		OSCAddressPathMatchesPattern_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressPathMatchesPattern_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPathMatchesPattern_Pattern_PropertyAddress, OSCAddressPathMatchesPattern_FunctionAddress, "Pattern");
		OSCAddressPathMatchesPattern_Pattern_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPathMatchesPattern_FunctionAddress, "Pattern");
		OSCAddressPathMatchesPattern_Pattern_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPathMatchesPattern_FunctionAddress, "Pattern", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPathMatchesPattern_Path_PropertyAddress, OSCAddressPathMatchesPattern_FunctionAddress, "Path");
		OSCAddressPathMatchesPattern_Path_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPathMatchesPattern_FunctionAddress, "Path");
		OSCAddressPathMatchesPattern_Path_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPathMatchesPattern_FunctionAddress, "Path", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressPathMatchesPattern_ReturnValue_PropertyAddress, OSCAddressPathMatchesPattern_FunctionAddress, "ReturnValue");
		OSCAddressPathMatchesPattern_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressPathMatchesPattern_FunctionAddress, "ReturnValue");
		OSCAddressPathMatchesPattern_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressPathMatchesPattern_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OSCAddressPathMatchesPattern_IsValid = OSCAddressPathMatchesPattern_FunctionAddress != IntPtr.Zero && OSCAddressPathMatchesPattern_Pattern_IsValid && OSCAddressPathMatchesPattern_Path_IsValid && OSCAddressPathMatchesPattern_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressPathMatchesPattern", OSCAddressPathMatchesPattern_IsValid);
		OSCAddressIsValidPattern_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressIsValidPattern");
		OSCAddressIsValidPattern_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressIsValidPattern_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressIsValidPattern_Address_PropertyAddress, OSCAddressIsValidPattern_FunctionAddress, "Address");
		OSCAddressIsValidPattern_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressIsValidPattern_FunctionAddress, "Address");
		OSCAddressIsValidPattern_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressIsValidPattern_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressIsValidPattern_ReturnValue_PropertyAddress, OSCAddressIsValidPattern_FunctionAddress, "ReturnValue");
		OSCAddressIsValidPattern_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressIsValidPattern_FunctionAddress, "ReturnValue");
		OSCAddressIsValidPattern_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressIsValidPattern_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OSCAddressIsValidPattern_IsValid = OSCAddressIsValidPattern_FunctionAddress != IntPtr.Zero && OSCAddressIsValidPattern_Address_IsValid && OSCAddressIsValidPattern_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressIsValidPattern", OSCAddressIsValidPattern_IsValid);
		OSCAddressIsValidPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressIsValidPath");
		OSCAddressIsValidPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressIsValidPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressIsValidPath_Address_PropertyAddress, OSCAddressIsValidPath_FunctionAddress, "Address");
		OSCAddressIsValidPath_Address_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressIsValidPath_FunctionAddress, "Address");
		OSCAddressIsValidPath_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressIsValidPath_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressIsValidPath_ReturnValue_PropertyAddress, OSCAddressIsValidPath_FunctionAddress, "ReturnValue");
		OSCAddressIsValidPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressIsValidPath_FunctionAddress, "ReturnValue");
		OSCAddressIsValidPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressIsValidPath_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		OSCAddressIsValidPath_IsValid = OSCAddressIsValidPath_FunctionAddress != IntPtr.Zero && OSCAddressIsValidPath_Address_IsValid && OSCAddressIsValidPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressIsValidPath", OSCAddressIsValidPath_IsValid);
		OSCAddressFromObjectPathString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressFromObjectPathString");
		OSCAddressFromObjectPathString_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressFromObjectPathString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressFromObjectPathString_PathName_PropertyAddress, OSCAddressFromObjectPathString_FunctionAddress, "PathName");
		OSCAddressFromObjectPathString_PathName_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressFromObjectPathString_FunctionAddress, "PathName");
		OSCAddressFromObjectPathString_PathName_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressFromObjectPathString_FunctionAddress, "PathName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressFromObjectPathString_ReturnValue_PropertyAddress, OSCAddressFromObjectPathString_FunctionAddress, "ReturnValue");
		OSCAddressFromObjectPathString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressFromObjectPathString_FunctionAddress, "ReturnValue");
		OSCAddressFromObjectPathString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressFromObjectPathString_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OSCAddressFromObjectPathString_IsValid = OSCAddressFromObjectPathString_FunctionAddress != IntPtr.Zero && OSCAddressFromObjectPathString_PathName_IsValid && OSCAddressFromObjectPathString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressFromObjectPathString", OSCAddressFromObjectPathString_IsValid);
		OSCAddressFromObjectPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "OSCAddressFromObjectPath");
		OSCAddressFromObjectPath_ParamsSize = NativeReflection.GetFunctionParamsSize(OSCAddressFromObjectPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressFromObjectPath_Object_PropertyAddress, OSCAddressFromObjectPath_FunctionAddress, "Object");
		OSCAddressFromObjectPath_Object_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressFromObjectPath_FunctionAddress, "Object");
		OSCAddressFromObjectPath_Object_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressFromObjectPath_FunctionAddress, "Object", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref OSCAddressFromObjectPath_ReturnValue_PropertyAddress, OSCAddressFromObjectPath_FunctionAddress, "ReturnValue");
		OSCAddressFromObjectPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(OSCAddressFromObjectPath_FunctionAddress, "ReturnValue");
		OSCAddressFromObjectPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(OSCAddressFromObjectPath_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		OSCAddressFromObjectPath_IsValid = OSCAddressFromObjectPath_FunctionAddress != IntPtr.Zero && OSCAddressFromObjectPath_Object_IsValid && OSCAddressFromObjectPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:OSCAddressFromObjectPath", OSCAddressFromObjectPath_IsValid);
		ObjectPathFromOSCAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ObjectPathFromOSCAddress");
		ObjectPathFromOSCAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(ObjectPathFromOSCAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ObjectPathFromOSCAddress_Address_PropertyAddress, ObjectPathFromOSCAddress_FunctionAddress, "Address");
		ObjectPathFromOSCAddress_Address_Offset = NativeReflectionCached.GetPropertyOffset(ObjectPathFromOSCAddress_FunctionAddress, "Address");
		ObjectPathFromOSCAddress_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectPathFromOSCAddress_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ObjectPathFromOSCAddress_ReturnValue_PropertyAddress, ObjectPathFromOSCAddress_FunctionAddress, "ReturnValue");
		ObjectPathFromOSCAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ObjectPathFromOSCAddress_FunctionAddress, "ReturnValue");
		ObjectPathFromOSCAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ObjectPathFromOSCAddress_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		ObjectPathFromOSCAddress_IsValid = ObjectPathFromOSCAddress_FunctionAddress != IntPtr.Zero && ObjectPathFromOSCAddress_Address_IsValid && ObjectPathFromOSCAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:ObjectPathFromOSCAddress", ObjectPathFromOSCAddress_IsValid);
		GetString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetString");
		GetString_ParamsSize = NativeReflection.GetFunctionParamsSize(GetString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetString_Message_PropertyAddress, GetString_FunctionAddress, "Message");
		GetString_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "Message");
		GetString_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_Index_PropertyAddress, GetString_FunctionAddress, "Index");
		GetString_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "Index");
		GetString_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_Value_PropertyAddress, GetString_FunctionAddress, "Value");
		GetString_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "Value");
		GetString_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "Value", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetString_ReturnValue_PropertyAddress, GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetString_FunctionAddress, "ReturnValue");
		GetString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetString_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetString_IsValid = GetString_FunctionAddress != IntPtr.Zero && GetString_Message_IsValid && GetString_Index_IsValid && GetString_Value_IsValid && GetString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetString", GetString_IsValid);
		GetOSCMessageAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCMessageAddress");
		GetOSCMessageAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCMessageAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCMessageAddress_Message_PropertyAddress, GetOSCMessageAddress_FunctionAddress, "Message");
		GetOSCMessageAddress_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCMessageAddress_FunctionAddress, "Message");
		GetOSCMessageAddress_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCMessageAddress_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCMessageAddress_ReturnValue_PropertyAddress, GetOSCMessageAddress_FunctionAddress, "ReturnValue");
		GetOSCMessageAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCMessageAddress_FunctionAddress, "ReturnValue");
		GetOSCMessageAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCMessageAddress_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetOSCMessageAddress_IsValid = GetOSCMessageAddress_FunctionAddress != IntPtr.Zero && GetOSCMessageAddress_Message_IsValid && GetOSCMessageAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCMessageAddress", GetOSCMessageAddress_IsValid);
		GetOSCAddressMethod_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCAddressMethod");
		GetOSCAddressMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCAddressMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressMethod_Address_PropertyAddress, GetOSCAddressMethod_FunctionAddress, "Address");
		GetOSCAddressMethod_Address_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressMethod_FunctionAddress, "Address");
		GetOSCAddressMethod_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressMethod_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressMethod_ReturnValue_PropertyAddress, GetOSCAddressMethod_FunctionAddress, "ReturnValue");
		GetOSCAddressMethod_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressMethod_FunctionAddress, "ReturnValue");
		GetOSCAddressMethod_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressMethod_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOSCAddressMethod_IsValid = GetOSCAddressMethod_FunctionAddress != IntPtr.Zero && GetOSCAddressMethod_Address_IsValid && GetOSCAddressMethod_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCAddressMethod", GetOSCAddressMethod_IsValid);
		GetOSCAddressFullPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCAddressFullPath");
		GetOSCAddressFullPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCAddressFullPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressFullPath_Address_PropertyAddress, GetOSCAddressFullPath_FunctionAddress, "Address");
		GetOSCAddressFullPath_Address_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressFullPath_FunctionAddress, "Address");
		GetOSCAddressFullPath_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressFullPath_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressFullPath_ReturnValue_PropertyAddress, GetOSCAddressFullPath_FunctionAddress, "ReturnValue");
		GetOSCAddressFullPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressFullPath_FunctionAddress, "ReturnValue");
		GetOSCAddressFullPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressFullPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOSCAddressFullPath_IsValid = GetOSCAddressFullPath_FunctionAddress != IntPtr.Zero && GetOSCAddressFullPath_Address_IsValid && GetOSCAddressFullPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCAddressFullPath", GetOSCAddressFullPath_IsValid);
		GetOSCAddressContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCAddressContainers");
		GetOSCAddressContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCAddressContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainers_Address_PropertyAddress, GetOSCAddressContainers_FunctionAddress, "Address");
		GetOSCAddressContainers_Address_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainers_FunctionAddress, "Address");
		GetOSCAddressContainers_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainers_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainers_ReturnValue_PropertyAddress, GetOSCAddressContainers_FunctionAddress, "ReturnValue");
		GetOSCAddressContainers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainers_FunctionAddress, "ReturnValue");
		GetOSCAddressContainers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainers_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetOSCAddressContainers_IsValid = GetOSCAddressContainers_FunctionAddress != IntPtr.Zero && GetOSCAddressContainers_Address_IsValid && GetOSCAddressContainers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCAddressContainers", GetOSCAddressContainers_IsValid);
		GetOSCAddressContainerPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCAddressContainerPath");
		GetOSCAddressContainerPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCAddressContainerPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainerPath_Address_PropertyAddress, GetOSCAddressContainerPath_FunctionAddress, "Address");
		GetOSCAddressContainerPath_Address_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainerPath_FunctionAddress, "Address");
		GetOSCAddressContainerPath_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainerPath_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainerPath_ReturnValue_PropertyAddress, GetOSCAddressContainerPath_FunctionAddress, "ReturnValue");
		GetOSCAddressContainerPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainerPath_FunctionAddress, "ReturnValue");
		GetOSCAddressContainerPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainerPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOSCAddressContainerPath_IsValid = GetOSCAddressContainerPath_FunctionAddress != IntPtr.Zero && GetOSCAddressContainerPath_Address_IsValid && GetOSCAddressContainerPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCAddressContainerPath", GetOSCAddressContainerPath_IsValid);
		GetOSCAddressContainer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetOSCAddressContainer");
		GetOSCAddressContainer_ParamsSize = NativeReflection.GetFunctionParamsSize(GetOSCAddressContainer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainer_Address_PropertyAddress, GetOSCAddressContainer_FunctionAddress, "Address");
		GetOSCAddressContainer_Address_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainer_FunctionAddress, "Address");
		GetOSCAddressContainer_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainer_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainer_Index_PropertyAddress, GetOSCAddressContainer_FunctionAddress, "Index");
		GetOSCAddressContainer_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainer_FunctionAddress, "Index");
		GetOSCAddressContainer_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainer_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetOSCAddressContainer_ReturnValue_PropertyAddress, GetOSCAddressContainer_FunctionAddress, "ReturnValue");
		GetOSCAddressContainer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetOSCAddressContainer_FunctionAddress, "ReturnValue");
		GetOSCAddressContainer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetOSCAddressContainer_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetOSCAddressContainer_IsValid = GetOSCAddressContainer_FunctionAddress != IntPtr.Zero && GetOSCAddressContainer_Address_IsValid && GetOSCAddressContainer_Index_IsValid && GetOSCAddressContainer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetOSCAddressContainer", GetOSCAddressContainer_IsValid);
		GetMessagesFromBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMessagesFromBundle");
		GetMessagesFromBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMessagesFromBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMessagesFromBundle_Bundle_PropertyAddress, GetMessagesFromBundle_FunctionAddress, "Bundle");
		GetMessagesFromBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(GetMessagesFromBundle_FunctionAddress, "Bundle");
		GetMessagesFromBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessagesFromBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMessagesFromBundle_ReturnValue_PropertyAddress, GetMessagesFromBundle_FunctionAddress, "ReturnValue");
		GetMessagesFromBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMessagesFromBundle_FunctionAddress, "ReturnValue");
		GetMessagesFromBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessagesFromBundle_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetMessagesFromBundle_IsValid = GetMessagesFromBundle_FunctionAddress != IntPtr.Zero && GetMessagesFromBundle_Bundle_IsValid && GetMessagesFromBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetMessagesFromBundle", GetMessagesFromBundle_IsValid);
		GetMessageFromBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetMessageFromBundle");
		GetMessageFromBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMessageFromBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMessageFromBundle_Bundle_PropertyAddress, GetMessageFromBundle_FunctionAddress, "Bundle");
		GetMessageFromBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(GetMessageFromBundle_FunctionAddress, "Bundle");
		GetMessageFromBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessageFromBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMessageFromBundle_Index_PropertyAddress, GetMessageFromBundle_FunctionAddress, "Index");
		GetMessageFromBundle_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetMessageFromBundle_FunctionAddress, "Index");
		GetMessageFromBundle_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessageFromBundle_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMessageFromBundle_bSucceeded_PropertyAddress, GetMessageFromBundle_FunctionAddress, "bSucceeded");
		GetMessageFromBundle_bSucceeded_Offset = NativeReflectionCached.GetPropertyOffset(GetMessageFromBundle_FunctionAddress, "bSucceeded");
		GetMessageFromBundle_bSucceeded_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessageFromBundle_FunctionAddress, "bSucceeded", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetMessageFromBundle_ReturnValue_PropertyAddress, GetMessageFromBundle_FunctionAddress, "ReturnValue");
		GetMessageFromBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMessageFromBundle_FunctionAddress, "ReturnValue");
		GetMessageFromBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMessageFromBundle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetMessageFromBundle_IsValid = GetMessageFromBundle_FunctionAddress != IntPtr.Zero && GetMessageFromBundle_Bundle_IsValid && GetMessageFromBundle_Index_IsValid && GetMessageFromBundle_bSucceeded_IsValid && GetMessageFromBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetMessageFromBundle", GetMessageFromBundle_IsValid);
		GetInt64_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInt64");
		GetInt64_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt64_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt64_Message_PropertyAddress, GetInt64_FunctionAddress, "Message");
		GetInt64_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64_FunctionAddress, "Message");
		GetInt64_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt64_Index_PropertyAddress, GetInt64_FunctionAddress, "Index");
		GetInt64_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64_FunctionAddress, "Index");
		GetInt64_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt64_Value_PropertyAddress, GetInt64_FunctionAddress, "Value");
		GetInt64_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64_FunctionAddress, "Value");
		GetInt64_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64_FunctionAddress, "Value", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref GetInt64_ReturnValue_PropertyAddress, GetInt64_FunctionAddress, "ReturnValue");
		GetInt64_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt64_FunctionAddress, "ReturnValue");
		GetInt64_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt64_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetInt64_IsValid = GetInt64_FunctionAddress != IntPtr.Zero && GetInt64_Message_IsValid && GetInt64_Index_IsValid && GetInt64_Value_IsValid && GetInt64_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetInt64", GetInt64_IsValid);
		GetInt32_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInt32");
		GetInt32_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInt32_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInt32_Message_PropertyAddress, GetInt32_FunctionAddress, "Message");
		GetInt32_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32_FunctionAddress, "Message");
		GetInt32_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32_Index_PropertyAddress, GetInt32_FunctionAddress, "Index");
		GetInt32_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32_FunctionAddress, "Index");
		GetInt32_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32_Value_PropertyAddress, GetInt32_FunctionAddress, "Value");
		GetInt32_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32_FunctionAddress, "Value");
		GetInt32_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInt32_ReturnValue_PropertyAddress, GetInt32_FunctionAddress, "ReturnValue");
		GetInt32_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInt32_FunctionAddress, "ReturnValue");
		GetInt32_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInt32_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetInt32_IsValid = GetInt32_FunctionAddress != IntPtr.Zero && GetInt32_Message_IsValid && GetInt32_Index_IsValid && GetInt32_Value_IsValid && GetInt32_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetInt32", GetInt32_IsValid);
		GetFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetFloat");
		GetFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(GetFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_Message_PropertyAddress, GetFloat_FunctionAddress, "Message");
		GetFloat_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "Message");
		GetFloat_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_Index_PropertyAddress, GetFloat_FunctionAddress, "Index");
		GetFloat_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "Index");
		GetFloat_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_Value_PropertyAddress, GetFloat_FunctionAddress, "Value");
		GetFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "Value");
		GetFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref GetFloat_ReturnValue_PropertyAddress, GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetFloat_FunctionAddress, "ReturnValue");
		GetFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetFloat_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetFloat_IsValid = GetFloat_FunctionAddress != IntPtr.Zero && GetFloat_Message_IsValid && GetFloat_Index_IsValid && GetFloat_Value_IsValid && GetFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetFloat", GetFloat_IsValid);
		GetBundlesFromBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBundlesFromBundle");
		GetBundlesFromBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBundlesFromBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBundlesFromBundle_Bundle_PropertyAddress, GetBundlesFromBundle_FunctionAddress, "Bundle");
		GetBundlesFromBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(GetBundlesFromBundle_FunctionAddress, "Bundle");
		GetBundlesFromBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBundlesFromBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBundlesFromBundle_ReturnValue_PropertyAddress, GetBundlesFromBundle_FunctionAddress, "ReturnValue");
		GetBundlesFromBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBundlesFromBundle_FunctionAddress, "ReturnValue");
		GetBundlesFromBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBundlesFromBundle_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetBundlesFromBundle_IsValid = GetBundlesFromBundle_FunctionAddress != IntPtr.Zero && GetBundlesFromBundle_Bundle_IsValid && GetBundlesFromBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetBundlesFromBundle", GetBundlesFromBundle_IsValid);
		GetBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBool");
		GetBool_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBool_Message_PropertyAddress, GetBool_FunctionAddress, "Message");
		GetBool_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "Message");
		GetBool_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_Index_PropertyAddress, GetBool_FunctionAddress, "Index");
		GetBool_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "Index");
		GetBool_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_Value_PropertyAddress, GetBool_FunctionAddress, "Value");
		GetBool_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "Value");
		GetBool_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "Value", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBool_ReturnValue_PropertyAddress, GetBool_FunctionAddress, "ReturnValue");
		GetBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBool_FunctionAddress, "ReturnValue");
		GetBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBool_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBool_IsValid = GetBool_FunctionAddress != IntPtr.Zero && GetBool_Message_IsValid && GetBool_Index_IsValid && GetBool_Value_IsValid && GetBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetBool", GetBool_IsValid);
		GetBlob_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBlob");
		GetBlob_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBlob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBlob_Message_PropertyAddress, GetBlob_FunctionAddress, "Message");
		GetBlob_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetBlob_FunctionAddress, "Message");
		GetBlob_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlob_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlob_Index_PropertyAddress, GetBlob_FunctionAddress, "Index");
		GetBlob_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetBlob_FunctionAddress, "Index");
		GetBlob_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlob_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlob_Value_PropertyAddress, GetBlob_FunctionAddress, "Value");
		GetBlob_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetBlob_FunctionAddress, "Value");
		GetBlob_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlob_FunctionAddress, "Value", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBlob_ReturnValue_PropertyAddress, GetBlob_FunctionAddress, "ReturnValue");
		GetBlob_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBlob_FunctionAddress, "ReturnValue");
		GetBlob_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBlob_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetBlob_IsValid = GetBlob_FunctionAddress != IntPtr.Zero && GetBlob_Message_IsValid && GetBlob_Index_IsValid && GetBlob_Value_IsValid && GetBlob_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetBlob", GetBlob_IsValid);
		GetAllStrings_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllStrings");
		GetAllStrings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllStrings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllStrings_Message_PropertyAddress, GetAllStrings_FunctionAddress, "Message");
		GetAllStrings_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllStrings_FunctionAddress, "Message");
		GetAllStrings_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllStrings_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllStrings_Values_PropertyAddress, GetAllStrings_FunctionAddress, "Values");
		GetAllStrings_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllStrings_FunctionAddress, "Values");
		GetAllStrings_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllStrings_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllStrings_IsValid = GetAllStrings_FunctionAddress != IntPtr.Zero && GetAllStrings_Message_IsValid && GetAllStrings_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllStrings", GetAllStrings_IsValid);
		GetAllInt64s_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllInt64s");
		GetAllInt64s_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllInt64s_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllInt64s_Message_PropertyAddress, GetAllInt64s_FunctionAddress, "Message");
		GetAllInt64s_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllInt64s_FunctionAddress, "Message");
		GetAllInt64s_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllInt64s_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllInt64s_Values_PropertyAddress, GetAllInt64s_FunctionAddress, "Values");
		GetAllInt64s_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllInt64s_FunctionAddress, "Values");
		GetAllInt64s_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllInt64s_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllInt64s_IsValid = GetAllInt64s_FunctionAddress != IntPtr.Zero && GetAllInt64s_Message_IsValid && GetAllInt64s_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllInt64s", GetAllInt64s_IsValid);
		GetAllInt32s_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllInt32s");
		GetAllInt32s_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllInt32s_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllInt32s_Message_PropertyAddress, GetAllInt32s_FunctionAddress, "Message");
		GetAllInt32s_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllInt32s_FunctionAddress, "Message");
		GetAllInt32s_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllInt32s_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllInt32s_Values_PropertyAddress, GetAllInt32s_FunctionAddress, "Values");
		GetAllInt32s_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllInt32s_FunctionAddress, "Values");
		GetAllInt32s_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllInt32s_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllInt32s_IsValid = GetAllInt32s_FunctionAddress != IntPtr.Zero && GetAllInt32s_Message_IsValid && GetAllInt32s_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllInt32s", GetAllInt32s_IsValid);
		GetAllFloats_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllFloats");
		GetAllFloats_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllFloats_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllFloats_Message_PropertyAddress, GetAllFloats_FunctionAddress, "Message");
		GetAllFloats_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllFloats_FunctionAddress, "Message");
		GetAllFloats_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllFloats_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllFloats_Values_PropertyAddress, GetAllFloats_FunctionAddress, "Values");
		GetAllFloats_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllFloats_FunctionAddress, "Values");
		GetAllFloats_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllFloats_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllFloats_IsValid = GetAllFloats_FunctionAddress != IntPtr.Zero && GetAllFloats_Message_IsValid && GetAllFloats_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllFloats", GetAllFloats_IsValid);
		GetAllBools_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllBools");
		GetAllBools_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllBools_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllBools_Message_PropertyAddress, GetAllBools_FunctionAddress, "Message");
		GetAllBools_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllBools_FunctionAddress, "Message");
		GetAllBools_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllBools_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllBools_Values_PropertyAddress, GetAllBools_FunctionAddress, "Values");
		GetAllBools_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllBools_FunctionAddress, "Values");
		GetAllBools_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllBools_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllBools_IsValid = GetAllBools_FunctionAddress != IntPtr.Zero && GetAllBools_Message_IsValid && GetAllBools_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllBools", GetAllBools_IsValid);
		GetAllAddresses_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAllAddresses");
		GetAllAddresses_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAllAddresses_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAllAddresses_Message_PropertyAddress, GetAllAddresses_FunctionAddress, "Message");
		GetAllAddresses_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAddresses_FunctionAddress, "Message");
		GetAllAddresses_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAddresses_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAllAddresses_Values_PropertyAddress, GetAllAddresses_FunctionAddress, "Values");
		GetAllAddresses_Values_Offset = NativeReflectionCached.GetPropertyOffset(GetAllAddresses_FunctionAddress, "Values");
		GetAllAddresses_Values_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAllAddresses_FunctionAddress, "Values", Classes.FArrayProperty);
		GetAllAddresses_IsValid = GetAllAddresses_FunctionAddress != IntPtr.Zero && GetAllAddresses_Message_IsValid && GetAllAddresses_Values_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAllAddresses", GetAllAddresses_IsValid);
		GetAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAddress");
		GetAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAddress_Message_PropertyAddress, GetAddress_FunctionAddress, "Message");
		GetAddress_Message_Offset = NativeReflectionCached.GetPropertyOffset(GetAddress_FunctionAddress, "Message");
		GetAddress_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAddress_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAddress_Index_PropertyAddress, GetAddress_FunctionAddress, "Index");
		GetAddress_Index_Offset = NativeReflectionCached.GetPropertyOffset(GetAddress_FunctionAddress, "Index");
		GetAddress_Index_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAddress_FunctionAddress, "Index", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAddress_Value_PropertyAddress, GetAddress_FunctionAddress, "Value");
		GetAddress_Value_Offset = NativeReflectionCached.GetPropertyOffset(GetAddress_FunctionAddress, "Value");
		GetAddress_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAddress_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAddress_ReturnValue_PropertyAddress, GetAddress_FunctionAddress, "ReturnValue");
		GetAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAddress_FunctionAddress, "ReturnValue");
		GetAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAddress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetAddress_IsValid = GetAddress_FunctionAddress != IntPtr.Zero && GetAddress_Message_IsValid && GetAddress_Index_IsValid && GetAddress_Value_IsValid && GetAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:GetAddress", GetAddress_IsValid);
		FindObjectAtOSCAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "FindObjectAtOSCAddress");
		FindObjectAtOSCAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(FindObjectAtOSCAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref FindObjectAtOSCAddress_Address_PropertyAddress, FindObjectAtOSCAddress_FunctionAddress, "Address");
		FindObjectAtOSCAddress_Address_Offset = NativeReflectionCached.GetPropertyOffset(FindObjectAtOSCAddress_FunctionAddress, "Address");
		FindObjectAtOSCAddress_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(FindObjectAtOSCAddress_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref FindObjectAtOSCAddress_ReturnValue_PropertyAddress, FindObjectAtOSCAddress_FunctionAddress, "ReturnValue");
		FindObjectAtOSCAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(FindObjectAtOSCAddress_FunctionAddress, "ReturnValue");
		FindObjectAtOSCAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(FindObjectAtOSCAddress_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		FindObjectAtOSCAddress_IsValid = FindObjectAtOSCAddress_FunctionAddress != IntPtr.Zero && FindObjectAtOSCAddress_Address_IsValid && FindObjectAtOSCAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:FindObjectAtOSCAddress", FindObjectAtOSCAddress_IsValid);
		CreateOSCServer_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateOSCServer");
		CreateOSCServer_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateOSCServer_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_ReceiveIPAddress_PropertyAddress, CreateOSCServer_FunctionAddress, "ReceiveIPAddress");
		CreateOSCServer_ReceiveIPAddress_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "ReceiveIPAddress");
		CreateOSCServer_ReceiveIPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "ReceiveIPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_Port_PropertyAddress, CreateOSCServer_FunctionAddress, "Port");
		CreateOSCServer_Port_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "Port");
		CreateOSCServer_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "Port", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_bMulticastLoopback_PropertyAddress, CreateOSCServer_FunctionAddress, "bMulticastLoopback");
		CreateOSCServer_bMulticastLoopback_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "bMulticastLoopback");
		CreateOSCServer_bMulticastLoopback_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "bMulticastLoopback", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_bStartListening_PropertyAddress, CreateOSCServer_FunctionAddress, "bStartListening");
		CreateOSCServer_bStartListening_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "bStartListening");
		CreateOSCServer_bStartListening_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "bStartListening", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_ServerName_PropertyAddress, CreateOSCServer_FunctionAddress, "ServerName");
		CreateOSCServer_ServerName_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "ServerName");
		CreateOSCServer_ServerName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "ServerName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_Outer_PropertyAddress, CreateOSCServer_FunctionAddress, "Outer");
		CreateOSCServer_Outer_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "Outer");
		CreateOSCServer_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCServer_ReturnValue_PropertyAddress, CreateOSCServer_FunctionAddress, "ReturnValue");
		CreateOSCServer_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCServer_FunctionAddress, "ReturnValue");
		CreateOSCServer_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCServer_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateOSCServer_IsValid = CreateOSCServer_FunctionAddress != IntPtr.Zero && CreateOSCServer_ReceiveIPAddress_IsValid && CreateOSCServer_Port_IsValid && CreateOSCServer_bMulticastLoopback_IsValid && CreateOSCServer_bStartListening_IsValid && CreateOSCServer_ServerName_IsValid && CreateOSCServer_Outer_IsValid && CreateOSCServer_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:CreateOSCServer", CreateOSCServer_IsValid);
		CreateOSCClient_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CreateOSCClient");
		CreateOSCClient_ParamsSize = NativeReflection.GetFunctionParamsSize(CreateOSCClient_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCClient_SendIPAddress_PropertyAddress, CreateOSCClient_FunctionAddress, "SendIPAddress");
		CreateOSCClient_SendIPAddress_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCClient_FunctionAddress, "SendIPAddress");
		CreateOSCClient_SendIPAddress_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCClient_FunctionAddress, "SendIPAddress", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCClient_Port_PropertyAddress, CreateOSCClient_FunctionAddress, "Port");
		CreateOSCClient_Port_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCClient_FunctionAddress, "Port");
		CreateOSCClient_Port_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCClient_FunctionAddress, "Port", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCClient_ClientName_PropertyAddress, CreateOSCClient_FunctionAddress, "ClientName");
		CreateOSCClient_ClientName_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCClient_FunctionAddress, "ClientName");
		CreateOSCClient_ClientName_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCClient_FunctionAddress, "ClientName", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCClient_Outer_PropertyAddress, CreateOSCClient_FunctionAddress, "Outer");
		CreateOSCClient_Outer_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCClient_FunctionAddress, "Outer");
		CreateOSCClient_Outer_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCClient_FunctionAddress, "Outer", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref CreateOSCClient_ReturnValue_PropertyAddress, CreateOSCClient_FunctionAddress, "ReturnValue");
		CreateOSCClient_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CreateOSCClient_FunctionAddress, "ReturnValue");
		CreateOSCClient_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CreateOSCClient_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		CreateOSCClient_IsValid = CreateOSCClient_FunctionAddress != IntPtr.Zero && CreateOSCClient_SendIPAddress_IsValid && CreateOSCClient_Port_IsValid && CreateOSCClient_ClientName_IsValid && CreateOSCClient_Outer_IsValid && CreateOSCClient_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:CreateOSCClient", CreateOSCClient_IsValid);
		ConvertStringToOSCAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ConvertStringToOSCAddress");
		ConvertStringToOSCAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(ConvertStringToOSCAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConvertStringToOSCAddress_String_PropertyAddress, ConvertStringToOSCAddress_FunctionAddress, "String");
		ConvertStringToOSCAddress_String_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStringToOSCAddress_FunctionAddress, "String");
		ConvertStringToOSCAddress_String_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStringToOSCAddress_FunctionAddress, "String", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref ConvertStringToOSCAddress_ReturnValue_PropertyAddress, ConvertStringToOSCAddress_FunctionAddress, "ReturnValue");
		ConvertStringToOSCAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConvertStringToOSCAddress_FunctionAddress, "ReturnValue");
		ConvertStringToOSCAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConvertStringToOSCAddress_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConvertStringToOSCAddress_IsValid = ConvertStringToOSCAddress_FunctionAddress != IntPtr.Zero && ConvertStringToOSCAddress_String_IsValid && ConvertStringToOSCAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:ConvertStringToOSCAddress", ConvertStringToOSCAddress_IsValid);
		ClearOSCAddressContainers_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearOSCAddressContainers");
		ClearOSCAddressContainers_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearOSCAddressContainers_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearOSCAddressContainers_Address_PropertyAddress, ClearOSCAddressContainers_FunctionAddress, "Address");
		ClearOSCAddressContainers_Address_Offset = NativeReflectionCached.GetPropertyOffset(ClearOSCAddressContainers_FunctionAddress, "Address");
		ClearOSCAddressContainers_Address_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearOSCAddressContainers_FunctionAddress, "Address", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearOSCAddressContainers_ReturnValue_PropertyAddress, ClearOSCAddressContainers_FunctionAddress, "ReturnValue");
		ClearOSCAddressContainers_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearOSCAddressContainers_FunctionAddress, "ReturnValue");
		ClearOSCAddressContainers_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearOSCAddressContainers_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClearOSCAddressContainers_IsValid = ClearOSCAddressContainers_FunctionAddress != IntPtr.Zero && ClearOSCAddressContainers_Address_IsValid && ClearOSCAddressContainers_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:ClearOSCAddressContainers", ClearOSCAddressContainers_IsValid);
		ClearMessage_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearMessage");
		ClearMessage_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearMessage_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearMessage_Message_PropertyAddress, ClearMessage_FunctionAddress, "Message");
		ClearMessage_Message_Offset = NativeReflectionCached.GetPropertyOffset(ClearMessage_FunctionAddress, "Message");
		ClearMessage_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMessage_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearMessage_ReturnValue_PropertyAddress, ClearMessage_FunctionAddress, "ReturnValue");
		ClearMessage_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearMessage_FunctionAddress, "ReturnValue");
		ClearMessage_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearMessage_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClearMessage_IsValid = ClearMessage_FunctionAddress != IntPtr.Zero && ClearMessage_Message_IsValid && ClearMessage_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:ClearMessage", ClearMessage_IsValid);
		ClearBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ClearBundle");
		ClearBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(ClearBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ClearBundle_Bundle_PropertyAddress, ClearBundle_FunctionAddress, "Bundle");
		ClearBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(ClearBundle_FunctionAddress, "Bundle");
		ClearBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ClearBundle_ReturnValue_PropertyAddress, ClearBundle_FunctionAddress, "ReturnValue");
		ClearBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ClearBundle_FunctionAddress, "ReturnValue");
		ClearBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ClearBundle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ClearBundle_IsValid = ClearBundle_FunctionAddress != IntPtr.Zero && ClearBundle_Bundle_IsValid && ClearBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:ClearBundle", ClearBundle_IsValid);
		AddString_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddString");
		AddString_ParamsSize = NativeReflection.GetFunctionParamsSize(AddString_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddString_Message_PropertyAddress, AddString_FunctionAddress, "Message");
		AddString_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddString_FunctionAddress, "Message");
		AddString_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddString_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddString_Value_PropertyAddress, AddString_FunctionAddress, "Value");
		AddString_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddString_FunctionAddress, "Value");
		AddString_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddString_FunctionAddress, "Value", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref AddString_ReturnValue_PropertyAddress, AddString_FunctionAddress, "ReturnValue");
		AddString_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddString_FunctionAddress, "ReturnValue");
		AddString_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddString_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddString_IsValid = AddString_FunctionAddress != IntPtr.Zero && AddString_Message_IsValid && AddString_Value_IsValid && AddString_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddString", AddString_IsValid);
		AddMessageToBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddMessageToBundle");
		AddMessageToBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(AddMessageToBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddMessageToBundle_Message_PropertyAddress, AddMessageToBundle_FunctionAddress, "Message");
		AddMessageToBundle_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddMessageToBundle_FunctionAddress, "Message");
		AddMessageToBundle_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMessageToBundle_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMessageToBundle_Bundle_PropertyAddress, AddMessageToBundle_FunctionAddress, "Bundle");
		AddMessageToBundle_Bundle_Offset = NativeReflectionCached.GetPropertyOffset(AddMessageToBundle_FunctionAddress, "Bundle");
		AddMessageToBundle_Bundle_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMessageToBundle_FunctionAddress, "Bundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddMessageToBundle_ReturnValue_PropertyAddress, AddMessageToBundle_FunctionAddress, "ReturnValue");
		AddMessageToBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddMessageToBundle_FunctionAddress, "ReturnValue");
		AddMessageToBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddMessageToBundle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddMessageToBundle_IsValid = AddMessageToBundle_FunctionAddress != IntPtr.Zero && AddMessageToBundle_Message_IsValid && AddMessageToBundle_Bundle_IsValid && AddMessageToBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddMessageToBundle", AddMessageToBundle_IsValid);
		AddInt64_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddInt64");
		AddInt64_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInt64_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInt64_Message_PropertyAddress, AddInt64_FunctionAddress, "Message");
		AddInt64_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddInt64_FunctionAddress, "Message");
		AddInt64_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt64_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInt64_Value_PropertyAddress, AddInt64_FunctionAddress, "Value");
		AddInt64_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddInt64_FunctionAddress, "Value");
		AddInt64_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt64_FunctionAddress, "Value", Classes.FInt64Property);
		NativeReflectionCached.GetPropertyRef(ref AddInt64_ReturnValue_PropertyAddress, AddInt64_FunctionAddress, "ReturnValue");
		AddInt64_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInt64_FunctionAddress, "ReturnValue");
		AddInt64_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt64_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddInt64_IsValid = AddInt64_FunctionAddress != IntPtr.Zero && AddInt64_Message_IsValid && AddInt64_Value_IsValid && AddInt64_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddInt64", AddInt64_IsValid);
		AddInt32_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddInt32");
		AddInt32_ParamsSize = NativeReflection.GetFunctionParamsSize(AddInt32_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddInt32_Message_PropertyAddress, AddInt32_FunctionAddress, "Message");
		AddInt32_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32_FunctionAddress, "Message");
		AddInt32_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInt32_Value_PropertyAddress, AddInt32_FunctionAddress, "Value");
		AddInt32_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32_FunctionAddress, "Value");
		AddInt32_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32_FunctionAddress, "Value", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref AddInt32_ReturnValue_PropertyAddress, AddInt32_FunctionAddress, "ReturnValue");
		AddInt32_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddInt32_FunctionAddress, "ReturnValue");
		AddInt32_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddInt32_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddInt32_IsValid = AddInt32_FunctionAddress != IntPtr.Zero && AddInt32_Message_IsValid && AddInt32_Value_IsValid && AddInt32_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddInt32", AddInt32_IsValid);
		AddFloat_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddFloat");
		AddFloat_ParamsSize = NativeReflection.GetFunctionParamsSize(AddFloat_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddFloat_Message_PropertyAddress, AddFloat_FunctionAddress, "Message");
		AddFloat_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddFloat_FunctionAddress, "Message");
		AddFloat_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloat_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloat_Value_PropertyAddress, AddFloat_FunctionAddress, "Value");
		AddFloat_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddFloat_FunctionAddress, "Value");
		AddFloat_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloat_FunctionAddress, "Value", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref AddFloat_ReturnValue_PropertyAddress, AddFloat_FunctionAddress, "ReturnValue");
		AddFloat_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddFloat_FunctionAddress, "ReturnValue");
		AddFloat_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddFloat_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddFloat_IsValid = AddFloat_FunctionAddress != IntPtr.Zero && AddFloat_Message_IsValid && AddFloat_Value_IsValid && AddFloat_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddFloat", AddFloat_IsValid);
		AddBundleToBundle_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBundleToBundle");
		AddBundleToBundle_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBundleToBundle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBundleToBundle_InBundle_PropertyAddress, AddBundleToBundle_FunctionAddress, "InBundle");
		AddBundleToBundle_InBundle_Offset = NativeReflectionCached.GetPropertyOffset(AddBundleToBundle_FunctionAddress, "InBundle");
		AddBundleToBundle_InBundle_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBundleToBundle_FunctionAddress, "InBundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBundleToBundle_OutBundle_PropertyAddress, AddBundleToBundle_FunctionAddress, "OutBundle");
		AddBundleToBundle_OutBundle_Offset = NativeReflectionCached.GetPropertyOffset(AddBundleToBundle_FunctionAddress, "OutBundle");
		AddBundleToBundle_OutBundle_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBundleToBundle_FunctionAddress, "OutBundle", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBundleToBundle_ReturnValue_PropertyAddress, AddBundleToBundle_FunctionAddress, "ReturnValue");
		AddBundleToBundle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBundleToBundle_FunctionAddress, "ReturnValue");
		AddBundleToBundle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBundleToBundle_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddBundleToBundle_IsValid = AddBundleToBundle_FunctionAddress != IntPtr.Zero && AddBundleToBundle_InBundle_IsValid && AddBundleToBundle_OutBundle_IsValid && AddBundleToBundle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddBundleToBundle", AddBundleToBundle_IsValid);
		AddBool_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBool");
		AddBool_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBool_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBool_Message_PropertyAddress, AddBool_FunctionAddress, "Message");
		AddBool_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddBool_FunctionAddress, "Message");
		AddBool_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBool_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBool_Value_PropertyAddress, AddBool_FunctionAddress, "Value");
		AddBool_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddBool_FunctionAddress, "Value");
		AddBool_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBool_FunctionAddress, "Value", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBool_ReturnValue_PropertyAddress, AddBool_FunctionAddress, "ReturnValue");
		AddBool_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBool_FunctionAddress, "ReturnValue");
		AddBool_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBool_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddBool_IsValid = AddBool_FunctionAddress != IntPtr.Zero && AddBool_Message_IsValid && AddBool_Value_IsValid && AddBool_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddBool", AddBool_IsValid);
		AddBlob_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddBlob");
		AddBlob_ParamsSize = NativeReflection.GetFunctionParamsSize(AddBlob_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddBlob_Message_PropertyAddress, AddBlob_FunctionAddress, "Message");
		AddBlob_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddBlob_FunctionAddress, "Message");
		AddBlob_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBlob_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBlob_Value_PropertyAddress, AddBlob_FunctionAddress, "Value");
		AddBlob_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddBlob_FunctionAddress, "Value");
		AddBlob_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBlob_FunctionAddress, "Value", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref AddBlob_ReturnValue_PropertyAddress, AddBlob_FunctionAddress, "ReturnValue");
		AddBlob_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddBlob_FunctionAddress, "ReturnValue");
		AddBlob_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddBlob_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddBlob_IsValid = AddBlob_FunctionAddress != IntPtr.Zero && AddBlob_Message_IsValid && AddBlob_Value_IsValid && AddBlob_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddBlob", AddBlob_IsValid);
		AddAddress_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "AddAddress");
		AddAddress_ParamsSize = NativeReflection.GetFunctionParamsSize(AddAddress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref AddAddress_Message_PropertyAddress, AddAddress_FunctionAddress, "Message");
		AddAddress_Message_Offset = NativeReflectionCached.GetPropertyOffset(AddAddress_FunctionAddress, "Message");
		AddAddress_Message_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAddress_FunctionAddress, "Message", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAddress_Value_PropertyAddress, AddAddress_FunctionAddress, "Value");
		AddAddress_Value_Offset = NativeReflectionCached.GetPropertyOffset(AddAddress_FunctionAddress, "Value");
		AddAddress_Value_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAddress_FunctionAddress, "Value", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref AddAddress_ReturnValue_PropertyAddress, AddAddress_FunctionAddress, "ReturnValue");
		AddAddress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(AddAddress_FunctionAddress, "ReturnValue");
		AddAddress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(AddAddress_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		AddAddress_IsValid = AddAddress_FunctionAddress != IntPtr.Zero && AddAddress_Message_IsValid && AddAddress_Value_IsValid && AddAddress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/OSC.OSCManager:AddAddress", AddAddress_IsValid);
	}
}
