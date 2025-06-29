using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary", "MobilePatchingUtils", UnrealModuleType.EnginePlugin)]
public class UMobilePatchingLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool RequestContent_IsValid;

	private static IntPtr RequestContent_FunctionAddress;

	private static int RequestContent_ParamsSize;

	private static bool RequestContent_RemoteManifestURL_IsValid;

	private static FFieldAddress RequestContent_RemoteManifestURL_PropertyAddress;

	private static int RequestContent_RemoteManifestURL_Offset;

	private static bool RequestContent_CloudURL_IsValid;

	private static FFieldAddress RequestContent_CloudURL_PropertyAddress;

	private static int RequestContent_CloudURL_Offset;

	private static bool RequestContent_InstallDirectory_IsValid;

	private static FFieldAddress RequestContent_InstallDirectory_PropertyAddress;

	private static int RequestContent_InstallDirectory_Offset;

	private static bool RequestContent_OnSucceeded_IsValid;

	private static FFieldAddress RequestContent_OnSucceeded_PropertyAddress;

	private static int RequestContent_OnSucceeded_Offset;

	private static bool RequestContent_OnFailed_IsValid;

	private static FFieldAddress RequestContent_OnFailed_PropertyAddress;

	private static int RequestContent_OnFailed_Offset;

	private static bool HasActiveWiFiConnection_IsValid;

	private static IntPtr HasActiveWiFiConnection_FunctionAddress;

	private static int HasActiveWiFiConnection_ParamsSize;

	private static bool HasActiveWiFiConnection_ReturnValue_IsValid;

	private static FFieldAddress HasActiveWiFiConnection_ReturnValue_PropertyAddress;

	private static int HasActiveWiFiConnection_ReturnValue_Offset;

	private static bool GetSupportedPlatformNames_IsValid;

	private static IntPtr GetSupportedPlatformNames_FunctionAddress;

	private static int GetSupportedPlatformNames_ParamsSize;

	private static bool GetSupportedPlatformNames_ReturnValue_IsValid;

	private static FFieldAddress GetSupportedPlatformNames_ReturnValue_PropertyAddress;

	private static int GetSupportedPlatformNames_ReturnValue_Offset;

	private static bool GetInstalledContent_IsValid;

	private static IntPtr GetInstalledContent_FunctionAddress;

	private static int GetInstalledContent_ParamsSize;

	private static bool GetInstalledContent_InstallDirectory_IsValid;

	private static FFieldAddress GetInstalledContent_InstallDirectory_PropertyAddress;

	private static int GetInstalledContent_InstallDirectory_Offset;

	private static bool GetInstalledContent_ReturnValue_IsValid;

	private static FFieldAddress GetInstalledContent_ReturnValue_PropertyAddress;

	private static int GetInstalledContent_ReturnValue_Offset;

	private static bool GetActiveDeviceProfileName_IsValid;

	private static IntPtr GetActiveDeviceProfileName_FunctionAddress;

	private static int GetActiveDeviceProfileName_ParamsSize;

	private static bool GetActiveDeviceProfileName_ReturnValue_IsValid;

	private static FFieldAddress GetActiveDeviceProfileName_ReturnValue_PropertyAddress;

	private static int GetActiveDeviceProfileName_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary:RequestContent")]
	public unsafe static void RequestContent(string RemoteManifestURL, string CloudURL, string InstallDirectory, FOnRequestContentSucceeded OnSucceeded, FOnRequestContentFailed OnFailed)
	{
		if (!RequestContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePatchingLibrary:RequestContent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestContent_RemoteManifestURL_Offset), 0, RequestContent_RemoteManifestURL_PropertyAddress.Address, RemoteManifestURL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestContent_CloudURL_Offset), 0, RequestContent_CloudURL_PropertyAddress.Address, CloudURL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestContent_InstallDirectory_Offset), 0, RequestContent_InstallDirectory_PropertyAddress.Address, InstallDirectory);
		FDelegateMarshaler<FOnRequestContentSucceeded>.ToNative(IntPtr.Add(intPtr, RequestContent_OnSucceeded_Offset), 0, RequestContent_OnSucceeded_PropertyAddress.Address, OnSucceeded);
		FDelegateMarshaler<FOnRequestContentFailed>.ToNative(IntPtr.Add(intPtr, RequestContent_OnFailed_Offset), 0, RequestContent_OnFailed_PropertyAddress.Address, OnFailed);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestContent_FunctionAddress, intPtr, RequestContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestContent_RemoteManifestURL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RequestContent_CloudURL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RequestContent_InstallDirectory_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary:HasActiveWiFiConnection")]
	public unsafe static bool HasActiveWiFiConnection()
	{
		if (!HasActiveWiFiConnection_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePatchingLibrary:HasActiveWiFiConnection");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasActiveWiFiConnection_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasActiveWiFiConnection_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, HasActiveWiFiConnection_FunctionAddress, intPtr, HasActiveWiFiConnection_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasActiveWiFiConnection_ReturnValue_Offset), 0, HasActiveWiFiConnection_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetSupportedPlatformNames")]
	public unsafe static List<string> GetSupportedPlatformNames()
	{
		if (!GetSupportedPlatformNames_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetSupportedPlatformNames");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetSupportedPlatformNames_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetSupportedPlatformNames_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetSupportedPlatformNames_FunctionAddress, intPtr, GetSupportedPlatformNames_ParamsSize);
		List<string> result = new TArrayCopyMarshaler<string>(1, GetSupportedPlatformNames_ReturnValue_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).FromNative(IntPtr.Add(intPtr, GetSupportedPlatformNames_ReturnValue_Offset));
		NativeReflection.DestroyValue_InContainer(GetSupportedPlatformNames_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetInstalledContent")]
	public unsafe static UMobileInstalledContent GetInstalledContent(string InstallDirectory)
	{
		if (!GetInstalledContent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetInstalledContent");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstalledContent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstalledContent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetInstalledContent_InstallDirectory_Offset), 0, GetInstalledContent_InstallDirectory_PropertyAddress.Address, InstallDirectory);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetInstalledContent_FunctionAddress, intPtr, GetInstalledContent_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetInstalledContent_InstallDirectory_PropertyAddress.Address, intPtr);
		return UObjectMarshaler<UMobileInstalledContent>.FromNative(IntPtr.Add(intPtr, GetInstalledContent_ReturnValue_Offset), 0, GetInstalledContent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335684609u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetActiveDeviceProfileName")]
	public unsafe static string GetActiveDeviceProfileName()
	{
		if (!GetActiveDeviceProfileName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetActiveDeviceProfileName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetActiveDeviceProfileName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetActiveDeviceProfileName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetActiveDeviceProfileName_FunctionAddress, intPtr, GetActiveDeviceProfileName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetActiveDeviceProfileName_ReturnValue_Offset), 0, GetActiveDeviceProfileName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetActiveDeviceProfileName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	static UMobilePatchingLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMobilePatchingLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMobilePatchingLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/MobilePatchingUtils.MobilePatchingLibrary");
		RequestContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestContent");
		RequestContent_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestContent_RemoteManifestURL_PropertyAddress, RequestContent_FunctionAddress, "RemoteManifestURL");
		RequestContent_RemoteManifestURL_Offset = NativeReflectionCached.GetPropertyOffset(RequestContent_FunctionAddress, "RemoteManifestURL");
		RequestContent_RemoteManifestURL_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestContent_FunctionAddress, "RemoteManifestURL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestContent_CloudURL_PropertyAddress, RequestContent_FunctionAddress, "CloudURL");
		RequestContent_CloudURL_Offset = NativeReflectionCached.GetPropertyOffset(RequestContent_FunctionAddress, "CloudURL");
		RequestContent_CloudURL_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestContent_FunctionAddress, "CloudURL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestContent_InstallDirectory_PropertyAddress, RequestContent_FunctionAddress, "InstallDirectory");
		RequestContent_InstallDirectory_Offset = NativeReflectionCached.GetPropertyOffset(RequestContent_FunctionAddress, "InstallDirectory");
		RequestContent_InstallDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestContent_FunctionAddress, "InstallDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestContent_OnSucceeded_PropertyAddress, RequestContent_FunctionAddress, "OnSucceeded");
		RequestContent_OnSucceeded_Offset = NativeReflectionCached.GetPropertyOffset(RequestContent_FunctionAddress, "OnSucceeded");
		RequestContent_OnSucceeded_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestContent_FunctionAddress, "OnSucceeded", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestContent_OnFailed_PropertyAddress, RequestContent_FunctionAddress, "OnFailed");
		RequestContent_OnFailed_Offset = NativeReflectionCached.GetPropertyOffset(RequestContent_FunctionAddress, "OnFailed");
		RequestContent_OnFailed_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestContent_FunctionAddress, "OnFailed", Classes.FDelegateProperty);
		RequestContent_IsValid = RequestContent_FunctionAddress != IntPtr.Zero && RequestContent_RemoteManifestURL_IsValid && RequestContent_CloudURL_IsValid && RequestContent_InstallDirectory_IsValid && RequestContent_OnSucceeded_IsValid && RequestContent_OnFailed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePatchingLibrary:RequestContent", RequestContent_IsValid);
		HasActiveWiFiConnection_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "HasActiveWiFiConnection");
		HasActiveWiFiConnection_ParamsSize = NativeReflection.GetFunctionParamsSize(HasActiveWiFiConnection_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasActiveWiFiConnection_ReturnValue_PropertyAddress, HasActiveWiFiConnection_FunctionAddress, "ReturnValue");
		HasActiveWiFiConnection_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasActiveWiFiConnection_FunctionAddress, "ReturnValue");
		HasActiveWiFiConnection_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasActiveWiFiConnection_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasActiveWiFiConnection_IsValid = HasActiveWiFiConnection_FunctionAddress != IntPtr.Zero && HasActiveWiFiConnection_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePatchingLibrary:HasActiveWiFiConnection", HasActiveWiFiConnection_IsValid);
		GetSupportedPlatformNames_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetSupportedPlatformNames");
		GetSupportedPlatformNames_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSupportedPlatformNames_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetSupportedPlatformNames_ReturnValue_PropertyAddress, GetSupportedPlatformNames_FunctionAddress, "ReturnValue");
		GetSupportedPlatformNames_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetSupportedPlatformNames_FunctionAddress, "ReturnValue");
		GetSupportedPlatformNames_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetSupportedPlatformNames_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSupportedPlatformNames_IsValid = GetSupportedPlatformNames_FunctionAddress != IntPtr.Zero && GetSupportedPlatformNames_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetSupportedPlatformNames", GetSupportedPlatformNames_IsValid);
		GetInstalledContent_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetInstalledContent");
		GetInstalledContent_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstalledContent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstalledContent_InstallDirectory_PropertyAddress, GetInstalledContent_FunctionAddress, "InstallDirectory");
		GetInstalledContent_InstallDirectory_Offset = NativeReflectionCached.GetPropertyOffset(GetInstalledContent_FunctionAddress, "InstallDirectory");
		GetInstalledContent_InstallDirectory_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstalledContent_FunctionAddress, "InstallDirectory", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetInstalledContent_ReturnValue_PropertyAddress, GetInstalledContent_FunctionAddress, "ReturnValue");
		GetInstalledContent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstalledContent_FunctionAddress, "ReturnValue");
		GetInstalledContent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstalledContent_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetInstalledContent_IsValid = GetInstalledContent_FunctionAddress != IntPtr.Zero && GetInstalledContent_InstallDirectory_IsValid && GetInstalledContent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetInstalledContent", GetInstalledContent_IsValid);
		GetActiveDeviceProfileName_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetActiveDeviceProfileName");
		GetActiveDeviceProfileName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetActiveDeviceProfileName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetActiveDeviceProfileName_ReturnValue_PropertyAddress, GetActiveDeviceProfileName_FunctionAddress, "ReturnValue");
		GetActiveDeviceProfileName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetActiveDeviceProfileName_FunctionAddress, "ReturnValue");
		GetActiveDeviceProfileName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetActiveDeviceProfileName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetActiveDeviceProfileName_IsValid = GetActiveDeviceProfileName_FunctionAddress != IntPtr.Zero && GetActiveDeviceProfileName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePatchingLibrary:GetActiveDeviceProfileName", GetActiveDeviceProfileName_IsValid);
	}
}
