using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.GooglePAD;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary", "GooglePAD", UnrealModuleType.EnginePlugin)]
public class UGooglePADFunctionLibrary : UBlueprintFunctionLibrary
{
	private static IntPtr classAddress;

	private static bool ShowCellularDataConfirmation_IsValid;

	private static IntPtr ShowCellularDataConfirmation_FunctionAddress;

	private static int ShowCellularDataConfirmation_ParamsSize;

	private static bool ShowCellularDataConfirmation_ReturnValue_IsValid;

	private static FFieldAddress ShowCellularDataConfirmation_ReturnValue_PropertyAddress;

	private static int ShowCellularDataConfirmation_ReturnValue_Offset;

	private static bool RequestRemoval_IsValid;

	private static IntPtr RequestRemoval_FunctionAddress;

	private static int RequestRemoval_ParamsSize;

	private static bool RequestRemoval_Name_IsValid;

	private static FFieldAddress RequestRemoval_Name_PropertyAddress;

	private static int RequestRemoval_Name_Offset;

	private static bool RequestRemoval_ReturnValue_IsValid;

	private static FFieldAddress RequestRemoval_ReturnValue_PropertyAddress;

	private static int RequestRemoval_ReturnValue_Offset;

	private static bool RequestInfo_IsValid;

	private static IntPtr RequestInfo_FunctionAddress;

	private static int RequestInfo_ParamsSize;

	private static bool RequestInfo_AssetPacks_IsValid;

	private static FFieldAddress RequestInfo_AssetPacks_PropertyAddress;

	private static int RequestInfo_AssetPacks_Offset;

	private static bool RequestInfo_ReturnValue_IsValid;

	private static FFieldAddress RequestInfo_ReturnValue_PropertyAddress;

	private static int RequestInfo_ReturnValue_Offset;

	private static bool RequestDownload_IsValid;

	private static IntPtr RequestDownload_FunctionAddress;

	private static int RequestDownload_ParamsSize;

	private static bool RequestDownload_AssetPacks_IsValid;

	private static FFieldAddress RequestDownload_AssetPacks_PropertyAddress;

	private static int RequestDownload_AssetPacks_Offset;

	private static bool RequestDownload_ReturnValue_IsValid;

	private static FFieldAddress RequestDownload_ReturnValue_PropertyAddress;

	private static int RequestDownload_ReturnValue_Offset;

	private static bool ReleaseDownloadState_IsValid;

	private static IntPtr ReleaseDownloadState_FunctionAddress;

	private static int ReleaseDownloadState_ParamsSize;

	private static bool ReleaseDownloadState_State_IsValid;

	private static FFieldAddress ReleaseDownloadState_State_PropertyAddress;

	private static int ReleaseDownloadState_State_Offset;

	private static bool ReleaseAssetPackLocation_IsValid;

	private static IntPtr ReleaseAssetPackLocation_FunctionAddress;

	private static int ReleaseAssetPackLocation_ParamsSize;

	private static bool ReleaseAssetPackLocation_Location_IsValid;

	private static FFieldAddress ReleaseAssetPackLocation_Location_PropertyAddress;

	private static int ReleaseAssetPackLocation_Location_Offset;

	private static bool GetTotalBytesToDownload_IsValid;

	private static IntPtr GetTotalBytesToDownload_FunctionAddress;

	private static int GetTotalBytesToDownload_ParamsSize;

	private static bool GetTotalBytesToDownload_State_IsValid;

	private static FFieldAddress GetTotalBytesToDownload_State_PropertyAddress;

	private static int GetTotalBytesToDownload_State_Offset;

	private static bool GetTotalBytesToDownload_ReturnValue_IsValid;

	private static FFieldAddress GetTotalBytesToDownload_ReturnValue_PropertyAddress;

	private static int GetTotalBytesToDownload_ReturnValue_Offset;

	private static bool GetStorageMethod_IsValid;

	private static IntPtr GetStorageMethod_FunctionAddress;

	private static int GetStorageMethod_ParamsSize;

	private static bool GetStorageMethod_Location_IsValid;

	private static FFieldAddress GetStorageMethod_Location_PropertyAddress;

	private static int GetStorageMethod_Location_Offset;

	private static bool GetStorageMethod_ReturnValue_IsValid;

	private static FFieldAddress GetStorageMethod_ReturnValue_PropertyAddress;

	private static int GetStorageMethod_ReturnValue_Offset;

	private static bool GetShowCellularDataConfirmationStatus_IsValid;

	private static IntPtr GetShowCellularDataConfirmationStatus_FunctionAddress;

	private static int GetShowCellularDataConfirmationStatus_ParamsSize;

	private static bool GetShowCellularDataConfirmationStatus_Status_IsValid;

	private static FFieldAddress GetShowCellularDataConfirmationStatus_Status_PropertyAddress;

	private static int GetShowCellularDataConfirmationStatus_Status_Offset;

	private static bool GetShowCellularDataConfirmationStatus_ReturnValue_IsValid;

	private static FFieldAddress GetShowCellularDataConfirmationStatus_ReturnValue_PropertyAddress;

	private static int GetShowCellularDataConfirmationStatus_ReturnValue_Offset;

	private static bool GetDownloadStatus_IsValid;

	private static IntPtr GetDownloadStatus_FunctionAddress;

	private static int GetDownloadStatus_ParamsSize;

	private static bool GetDownloadStatus_State_IsValid;

	private static FFieldAddress GetDownloadStatus_State_PropertyAddress;

	private static int GetDownloadStatus_State_Offset;

	private static bool GetDownloadStatus_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadStatus_ReturnValue_PropertyAddress;

	private static int GetDownloadStatus_ReturnValue_Offset;

	private static bool GetDownloadState_IsValid;

	private static IntPtr GetDownloadState_FunctionAddress;

	private static int GetDownloadState_ParamsSize;

	private static bool GetDownloadState_Name_IsValid;

	private static FFieldAddress GetDownloadState_Name_PropertyAddress;

	private static int GetDownloadState_Name_Offset;

	private static bool GetDownloadState_State_IsValid;

	private static FFieldAddress GetDownloadState_State_PropertyAddress;

	private static int GetDownloadState_State_Offset;

	private static bool GetDownloadState_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadState_ReturnValue_PropertyAddress;

	private static int GetDownloadState_ReturnValue_Offset;

	private static bool GetBytesDownloaded_IsValid;

	private static IntPtr GetBytesDownloaded_FunctionAddress;

	private static int GetBytesDownloaded_ParamsSize;

	private static bool GetBytesDownloaded_State_IsValid;

	private static FFieldAddress GetBytesDownloaded_State_PropertyAddress;

	private static int GetBytesDownloaded_State_Offset;

	private static bool GetBytesDownloaded_ReturnValue_IsValid;

	private static FFieldAddress GetBytesDownloaded_ReturnValue_PropertyAddress;

	private static int GetBytesDownloaded_ReturnValue_Offset;

	private static bool GetAssetsPath_IsValid;

	private static IntPtr GetAssetsPath_FunctionAddress;

	private static int GetAssetsPath_ParamsSize;

	private static bool GetAssetsPath_Location_IsValid;

	private static FFieldAddress GetAssetsPath_Location_PropertyAddress;

	private static int GetAssetsPath_Location_Offset;

	private static bool GetAssetsPath_ReturnValue_IsValid;

	private static FFieldAddress GetAssetsPath_ReturnValue_PropertyAddress;

	private static int GetAssetsPath_ReturnValue_Offset;

	private static bool GetAssetPackLocation_IsValid;

	private static IntPtr GetAssetPackLocation_FunctionAddress;

	private static int GetAssetPackLocation_ParamsSize;

	private static bool GetAssetPackLocation_Name_IsValid;

	private static FFieldAddress GetAssetPackLocation_Name_PropertyAddress;

	private static int GetAssetPackLocation_Name_Offset;

	private static bool GetAssetPackLocation_Location_IsValid;

	private static FFieldAddress GetAssetPackLocation_Location_PropertyAddress;

	private static int GetAssetPackLocation_Location_Offset;

	private static bool GetAssetPackLocation_ReturnValue_IsValid;

	private static FFieldAddress GetAssetPackLocation_ReturnValue_PropertyAddress;

	private static int GetAssetPackLocation_ReturnValue_Offset;

	private static bool CancelDownload_IsValid;

	private static IntPtr CancelDownload_FunctionAddress;

	private static int CancelDownload_ParamsSize;

	private static bool CancelDownload_AssetPacks_IsValid;

	private static FFieldAddress CancelDownload_AssetPacks_PropertyAddress;

	private static int CancelDownload_AssetPacks_Offset;

	private static bool CancelDownload_ReturnValue_IsValid;

	private static FFieldAddress CancelDownload_ReturnValue_PropertyAddress;

	private static int CancelDownload_ReturnValue_Offset;

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:ShowCellularDataConfirmation")]
	public unsafe static EGooglePADErrorCode ShowCellularDataConfirmation()
	{
		if (!ShowCellularDataConfirmation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:ShowCellularDataConfirmation");
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ShowCellularDataConfirmation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ShowCellularDataConfirmation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ShowCellularDataConfirmation_FunctionAddress, intPtr, ShowCellularDataConfirmation_ParamsSize);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, ShowCellularDataConfirmation_ReturnValue_Offset), 0, ShowCellularDataConfirmation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:RequestRemoval")]
	public unsafe static EGooglePADErrorCode RequestRemoval(string Name)
	{
		if (!RequestRemoval_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:RequestRemoval");
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestRemoval_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestRemoval_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestRemoval_Name_Offset), 0, RequestRemoval_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestRemoval_FunctionAddress, intPtr, RequestRemoval_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestRemoval_Name_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, RequestRemoval_ReturnValue_Offset), 0, RequestRemoval_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:RequestInfo")]
	public unsafe static EGooglePADErrorCode RequestInfo(List<string> AssetPacks)
	{
		if (!RequestInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:RequestInfo");
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, RequestInfo_AssetPacks_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, RequestInfo_AssetPacks_Offset), AssetPacks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestInfo_FunctionAddress, intPtr, RequestInfo_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestInfo_AssetPacks_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, RequestInfo_ReturnValue_Offset), 0, RequestInfo_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:RequestDownload")]
	public unsafe static EGooglePADErrorCode RequestDownload(List<string> AssetPacks)
	{
		if (!RequestDownload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:RequestDownload");
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestDownload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestDownload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, RequestDownload_AssetPacks_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, RequestDownload_AssetPacks_Offset), AssetPacks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, RequestDownload_FunctionAddress, intPtr, RequestDownload_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestDownload_AssetPacks_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, RequestDownload_ReturnValue_Offset), 0, RequestDownload_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseDownloadState")]
	public unsafe static void ReleaseDownloadState(int State)
	{
		if (!ReleaseDownloadState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseDownloadState");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseDownloadState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseDownloadState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReleaseDownloadState_State_Offset), 0, ReleaseDownloadState_State_PropertyAddress.Address, State);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseDownloadState_FunctionAddress, intPtr, ReleaseDownloadState_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseAssetPackLocation")]
	public unsafe static void ReleaseAssetPackLocation(int Location)
	{
		if (!ReleaseAssetPackLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseAssetPackLocation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReleaseAssetPackLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReleaseAssetPackLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, ReleaseAssetPackLocation_Location_Offset), 0, ReleaseAssetPackLocation_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, ReleaseAssetPackLocation_FunctionAddress, intPtr, ReleaseAssetPackLocation_ParamsSize);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetTotalBytesToDownload")]
	public unsafe static int GetTotalBytesToDownload(int State)
	{
		if (!GetTotalBytesToDownload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetTotalBytesToDownload");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalBytesToDownload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalBytesToDownload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetTotalBytesToDownload_State_Offset), 0, GetTotalBytesToDownload_State_PropertyAddress.Address, State);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetTotalBytesToDownload_FunctionAddress, intPtr, GetTotalBytesToDownload_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTotalBytesToDownload_ReturnValue_Offset), 0, GetTotalBytesToDownload_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetStorageMethod")]
	public unsafe static EGooglePADStorageMethod GetStorageMethod(int Location)
	{
		if (!GetStorageMethod_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetStorageMethod");
			return EGooglePADStorageMethod.AssetPack_STORAGE_FILES;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetStorageMethod_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetStorageMethod_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetStorageMethod_Location_Offset), 0, GetStorageMethod_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetStorageMethod_FunctionAddress, intPtr, GetStorageMethod_ParamsSize);
		return EnumMarshaler<EGooglePADStorageMethod>.FromNative(IntPtr.Add(intPtr, GetStorageMethod_ReturnValue_Offset), 0, GetStorageMethod_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetShowCellularDataConfirmationStatus")]
	public unsafe static EGooglePADErrorCode GetShowCellularDataConfirmationStatus(out EGooglePADCellularDataConfirmStatus Status)
	{
		if (!GetShowCellularDataConfirmationStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetShowCellularDataConfirmationStatus");
			Status = EGooglePADCellularDataConfirmStatus.AssetPack_CONFIRM_UNKNOWN;
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetShowCellularDataConfirmationStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetShowCellularDataConfirmationStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetShowCellularDataConfirmationStatus_FunctionAddress, intPtr, GetShowCellularDataConfirmationStatus_ParamsSize);
		Status = EnumMarshaler<EGooglePADCellularDataConfirmStatus>.FromNative(IntPtr.Add(intPtr, GetShowCellularDataConfirmationStatus_Status_Offset), 0, GetShowCellularDataConfirmationStatus_Status_PropertyAddress.Address);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, GetShowCellularDataConfirmationStatus_ReturnValue_Offset), 0, GetShowCellularDataConfirmationStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadStatus")]
	public unsafe static EGooglePADDownloadStatus GetDownloadStatus(int State)
	{
		if (!GetDownloadStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadStatus");
			return EGooglePADDownloadStatus.AssetPack_UNKNOWN;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetDownloadStatus_State_Offset), 0, GetDownloadStatus_State_PropertyAddress.Address, State);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDownloadStatus_FunctionAddress, intPtr, GetDownloadStatus_ParamsSize);
		return EnumMarshaler<EGooglePADDownloadStatus>.FromNative(IntPtr.Add(intPtr, GetDownloadStatus_ReturnValue_Offset), 0, GetDownloadStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadState")]
	public unsafe static EGooglePADErrorCode GetDownloadState(string Name, out int State)
	{
		if (!GetDownloadState_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadState");
			State = 0;
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadState_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadState_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetDownloadState_Name_Offset), 0, GetDownloadState_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetDownloadState_FunctionAddress, intPtr, GetDownloadState_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetDownloadState_Name_PropertyAddress.Address, intPtr);
		State = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDownloadState_State_Offset), 0, GetDownloadState_State_PropertyAddress.Address);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, GetDownloadState_ReturnValue_Offset), 0, GetDownloadState_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetBytesDownloaded")]
	public unsafe static int GetBytesDownloaded(int State)
	{
		if (!GetBytesDownloaded_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetBytesDownloaded");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetBytesDownloaded_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetBytesDownloaded_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetBytesDownloaded_State_Offset), 0, GetBytesDownloaded_State_PropertyAddress.Address, State);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetBytesDownloaded_FunctionAddress, intPtr, GetBytesDownloaded_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetBytesDownloaded_ReturnValue_Offset), 0, GetBytesDownloaded_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetsPath")]
	public unsafe static string GetAssetsPath(int Location)
	{
		if (!GetAssetsPath_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetsPath");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetsPath_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetsPath_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetAssetsPath_Location_Offset), 0, GetAssetsPath_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetsPath_FunctionAddress, intPtr, GetAssetsPath_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetAssetsPath_ReturnValue_Offset), 0, GetAssetsPath_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetAssetsPath_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 71443457u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetPackLocation")]
	public unsafe static EGooglePADErrorCode GetAssetPackLocation(string Name, out int Location)
	{
		if (!GetAssetPackLocation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetPackLocation");
			Location = 0;
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetAssetPackLocation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetAssetPackLocation_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, GetAssetPackLocation_Name_Offset), 0, GetAssetPackLocation_Name_PropertyAddress.Address, Name);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, GetAssetPackLocation_FunctionAddress, intPtr, GetAssetPackLocation_ParamsSize);
		NativeReflection.DestroyValue_InContainer(GetAssetPackLocation_Name_PropertyAddress.Address, intPtr);
		Location = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetAssetPackLocation_Location_Offset), 0, GetAssetPackLocation_Location_PropertyAddress.Address);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, GetAssetPackLocation_ReturnValue_Offset), 0, GetAssetPackLocation_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67249153u)]
	[UMetaPath("/Script/GooglePAD.GooglePADFunctionLibrary:CancelDownload")]
	public unsafe static EGooglePADErrorCode CancelDownload(List<string> AssetPacks)
	{
		if (!CancelDownload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/GooglePAD.GooglePADFunctionLibrary:CancelDownload");
			return EGooglePADErrorCode.AssetPack_NO_ERROR;
		}
		byte* ptr = stackalloc byte[(int)(uint)(CancelDownload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)CancelDownload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		new TArrayCopyMarshaler<string>(1, CancelDownload_AssetPacks_PropertyAddress, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative).ToNative(IntPtr.Add(intPtr, CancelDownload_AssetPacks_Offset), AssetPacks);
		NativeReflection.InvokeStaticFunctionOptimized(classAddress, CancelDownload_FunctionAddress, intPtr, CancelDownload_ParamsSize);
		NativeReflection.DestroyValue_InContainer(CancelDownload_AssetPacks_PropertyAddress.Address, intPtr);
		return EnumMarshaler<EGooglePADErrorCode>.FromNative(IntPtr.Add(intPtr, CancelDownload_ReturnValue_Offset), 0, CancelDownload_ReturnValue_PropertyAddress.Address);
	}

	static UGooglePADFunctionLibrary()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGooglePADFunctionLibrary)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGooglePADFunctionLibrary));
	}

	private static void LoadNativeType()
	{
		classAddress = NativeReflection.GetClass("/Script/GooglePAD.GooglePADFunctionLibrary");
		ShowCellularDataConfirmation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ShowCellularDataConfirmation");
		ShowCellularDataConfirmation_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowCellularDataConfirmation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ShowCellularDataConfirmation_ReturnValue_PropertyAddress, ShowCellularDataConfirmation_FunctionAddress, "ReturnValue");
		ShowCellularDataConfirmation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ShowCellularDataConfirmation_FunctionAddress, "ReturnValue");
		ShowCellularDataConfirmation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ShowCellularDataConfirmation_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		ShowCellularDataConfirmation_IsValid = ShowCellularDataConfirmation_FunctionAddress != IntPtr.Zero && ShowCellularDataConfirmation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:ShowCellularDataConfirmation", ShowCellularDataConfirmation_IsValid);
		RequestRemoval_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestRemoval");
		RequestRemoval_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestRemoval_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestRemoval_Name_PropertyAddress, RequestRemoval_FunctionAddress, "Name");
		RequestRemoval_Name_Offset = NativeReflectionCached.GetPropertyOffset(RequestRemoval_FunctionAddress, "Name");
		RequestRemoval_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRemoval_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestRemoval_ReturnValue_PropertyAddress, RequestRemoval_FunctionAddress, "ReturnValue");
		RequestRemoval_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequestRemoval_FunctionAddress, "ReturnValue");
		RequestRemoval_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestRemoval_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RequestRemoval_IsValid = RequestRemoval_FunctionAddress != IntPtr.Zero && RequestRemoval_Name_IsValid && RequestRemoval_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:RequestRemoval", RequestRemoval_IsValid);
		RequestInfo_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestInfo");
		RequestInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestInfo_AssetPacks_PropertyAddress, RequestInfo_FunctionAddress, "AssetPacks");
		RequestInfo_AssetPacks_Offset = NativeReflectionCached.GetPropertyOffset(RequestInfo_FunctionAddress, "AssetPacks");
		RequestInfo_AssetPacks_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestInfo_FunctionAddress, "AssetPacks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestInfo_ReturnValue_PropertyAddress, RequestInfo_FunctionAddress, "ReturnValue");
		RequestInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequestInfo_FunctionAddress, "ReturnValue");
		RequestInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestInfo_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RequestInfo_IsValid = RequestInfo_FunctionAddress != IntPtr.Zero && RequestInfo_AssetPacks_IsValid && RequestInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:RequestInfo", RequestInfo_IsValid);
		RequestDownload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "RequestDownload");
		RequestDownload_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestDownload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_AssetPacks_PropertyAddress, RequestDownload_FunctionAddress, "AssetPacks");
		RequestDownload_AssetPacks_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "AssetPacks");
		RequestDownload_AssetPacks_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "AssetPacks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_ReturnValue_PropertyAddress, RequestDownload_FunctionAddress, "ReturnValue");
		RequestDownload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "ReturnValue");
		RequestDownload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		RequestDownload_IsValid = RequestDownload_FunctionAddress != IntPtr.Zero && RequestDownload_AssetPacks_IsValid && RequestDownload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:RequestDownload", RequestDownload_IsValid);
		ReleaseDownloadState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseDownloadState");
		ReleaseDownloadState_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseDownloadState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseDownloadState_State_PropertyAddress, ReleaseDownloadState_FunctionAddress, "State");
		ReleaseDownloadState_State_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseDownloadState_FunctionAddress, "State");
		ReleaseDownloadState_State_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseDownloadState_FunctionAddress, "State", Classes.FIntProperty);
		ReleaseDownloadState_IsValid = ReleaseDownloadState_FunctionAddress != IntPtr.Zero && ReleaseDownloadState_State_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseDownloadState", ReleaseDownloadState_IsValid);
		ReleaseAssetPackLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "ReleaseAssetPackLocation");
		ReleaseAssetPackLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(ReleaseAssetPackLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReleaseAssetPackLocation_Location_PropertyAddress, ReleaseAssetPackLocation_FunctionAddress, "Location");
		ReleaseAssetPackLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(ReleaseAssetPackLocation_FunctionAddress, "Location");
		ReleaseAssetPackLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(ReleaseAssetPackLocation_FunctionAddress, "Location", Classes.FIntProperty);
		ReleaseAssetPackLocation_IsValid = ReleaseAssetPackLocation_FunctionAddress != IntPtr.Zero && ReleaseAssetPackLocation_Location_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:ReleaseAssetPackLocation", ReleaseAssetPackLocation_IsValid);
		GetTotalBytesToDownload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetTotalBytesToDownload");
		GetTotalBytesToDownload_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalBytesToDownload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalBytesToDownload_State_PropertyAddress, GetTotalBytesToDownload_FunctionAddress, "State");
		GetTotalBytesToDownload_State_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalBytesToDownload_FunctionAddress, "State");
		GetTotalBytesToDownload_State_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalBytesToDownload_FunctionAddress, "State", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetTotalBytesToDownload_ReturnValue_PropertyAddress, GetTotalBytesToDownload_FunctionAddress, "ReturnValue");
		GetTotalBytesToDownload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalBytesToDownload_FunctionAddress, "ReturnValue");
		GetTotalBytesToDownload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalBytesToDownload_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTotalBytesToDownload_IsValid = GetTotalBytesToDownload_FunctionAddress != IntPtr.Zero && GetTotalBytesToDownload_State_IsValid && GetTotalBytesToDownload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetTotalBytesToDownload", GetTotalBytesToDownload_IsValid);
		GetStorageMethod_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetStorageMethod");
		GetStorageMethod_ParamsSize = NativeReflection.GetFunctionParamsSize(GetStorageMethod_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetStorageMethod_Location_PropertyAddress, GetStorageMethod_FunctionAddress, "Location");
		GetStorageMethod_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetStorageMethod_FunctionAddress, "Location");
		GetStorageMethod_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStorageMethod_FunctionAddress, "Location", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetStorageMethod_ReturnValue_PropertyAddress, GetStorageMethod_FunctionAddress, "ReturnValue");
		GetStorageMethod_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetStorageMethod_FunctionAddress, "ReturnValue");
		GetStorageMethod_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetStorageMethod_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetStorageMethod_IsValid = GetStorageMethod_FunctionAddress != IntPtr.Zero && GetStorageMethod_Location_IsValid && GetStorageMethod_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetStorageMethod", GetStorageMethod_IsValid);
		GetShowCellularDataConfirmationStatus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetShowCellularDataConfirmationStatus");
		GetShowCellularDataConfirmationStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetShowCellularDataConfirmationStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetShowCellularDataConfirmationStatus_Status_PropertyAddress, GetShowCellularDataConfirmationStatus_FunctionAddress, "Status");
		GetShowCellularDataConfirmationStatus_Status_Offset = NativeReflectionCached.GetPropertyOffset(GetShowCellularDataConfirmationStatus_FunctionAddress, "Status");
		GetShowCellularDataConfirmationStatus_Status_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShowCellularDataConfirmationStatus_FunctionAddress, "Status", Classes.FEnumProperty);
		NativeReflectionCached.GetPropertyRef(ref GetShowCellularDataConfirmationStatus_ReturnValue_PropertyAddress, GetShowCellularDataConfirmationStatus_FunctionAddress, "ReturnValue");
		GetShowCellularDataConfirmationStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetShowCellularDataConfirmationStatus_FunctionAddress, "ReturnValue");
		GetShowCellularDataConfirmationStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetShowCellularDataConfirmationStatus_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetShowCellularDataConfirmationStatus_IsValid = GetShowCellularDataConfirmationStatus_FunctionAddress != IntPtr.Zero && GetShowCellularDataConfirmationStatus_Status_IsValid && GetShowCellularDataConfirmationStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetShowCellularDataConfirmationStatus", GetShowCellularDataConfirmationStatus_IsValid);
		GetDownloadStatus_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDownloadStatus");
		GetDownloadStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadStatus_State_PropertyAddress, GetDownloadStatus_FunctionAddress, "State");
		GetDownloadStatus_State_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadStatus_FunctionAddress, "State");
		GetDownloadStatus_State_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadStatus_FunctionAddress, "State", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadStatus_ReturnValue_PropertyAddress, GetDownloadStatus_FunctionAddress, "ReturnValue");
		GetDownloadStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadStatus_FunctionAddress, "ReturnValue");
		GetDownloadStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadStatus_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDownloadStatus_IsValid = GetDownloadStatus_FunctionAddress != IntPtr.Zero && GetDownloadStatus_State_IsValid && GetDownloadStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadStatus", GetDownloadStatus_IsValid);
		GetDownloadState_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetDownloadState");
		GetDownloadState_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadState_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadState_Name_PropertyAddress, GetDownloadState_FunctionAddress, "Name");
		GetDownloadState_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadState_FunctionAddress, "Name");
		GetDownloadState_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadState_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadState_State_PropertyAddress, GetDownloadState_FunctionAddress, "State");
		GetDownloadState_State_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadState_FunctionAddress, "State");
		GetDownloadState_State_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadState_FunctionAddress, "State", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadState_ReturnValue_PropertyAddress, GetDownloadState_FunctionAddress, "ReturnValue");
		GetDownloadState_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadState_FunctionAddress, "ReturnValue");
		GetDownloadState_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadState_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDownloadState_IsValid = GetDownloadState_FunctionAddress != IntPtr.Zero && GetDownloadState_Name_IsValid && GetDownloadState_State_IsValid && GetDownloadState_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetDownloadState", GetDownloadState_IsValid);
		GetBytesDownloaded_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetBytesDownloaded");
		GetBytesDownloaded_ParamsSize = NativeReflection.GetFunctionParamsSize(GetBytesDownloaded_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetBytesDownloaded_State_PropertyAddress, GetBytesDownloaded_FunctionAddress, "State");
		GetBytesDownloaded_State_Offset = NativeReflectionCached.GetPropertyOffset(GetBytesDownloaded_FunctionAddress, "State");
		GetBytesDownloaded_State_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBytesDownloaded_FunctionAddress, "State", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetBytesDownloaded_ReturnValue_PropertyAddress, GetBytesDownloaded_FunctionAddress, "ReturnValue");
		GetBytesDownloaded_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetBytesDownloaded_FunctionAddress, "ReturnValue");
		GetBytesDownloaded_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetBytesDownloaded_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetBytesDownloaded_IsValid = GetBytesDownloaded_FunctionAddress != IntPtr.Zero && GetBytesDownloaded_State_IsValid && GetBytesDownloaded_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetBytesDownloaded", GetBytesDownloaded_IsValid);
		GetAssetsPath_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetsPath");
		GetAssetsPath_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetsPath_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsPath_Location_PropertyAddress, GetAssetsPath_FunctionAddress, "Location");
		GetAssetsPath_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsPath_FunctionAddress, "Location");
		GetAssetsPath_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsPath_FunctionAddress, "Location", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetsPath_ReturnValue_PropertyAddress, GetAssetsPath_FunctionAddress, "ReturnValue");
		GetAssetsPath_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetsPath_FunctionAddress, "ReturnValue");
		GetAssetsPath_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetsPath_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetAssetsPath_IsValid = GetAssetsPath_FunctionAddress != IntPtr.Zero && GetAssetsPath_Location_IsValid && GetAssetsPath_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetsPath", GetAssetsPath_IsValid);
		GetAssetPackLocation_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "GetAssetPackLocation");
		GetAssetPackLocation_ParamsSize = NativeReflection.GetFunctionParamsSize(GetAssetPackLocation_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetAssetPackLocation_Name_PropertyAddress, GetAssetPackLocation_FunctionAddress, "Name");
		GetAssetPackLocation_Name_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetPackLocation_FunctionAddress, "Name");
		GetAssetPackLocation_Name_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetPackLocation_FunctionAddress, "Name", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetPackLocation_Location_PropertyAddress, GetAssetPackLocation_FunctionAddress, "Location");
		GetAssetPackLocation_Location_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetPackLocation_FunctionAddress, "Location");
		GetAssetPackLocation_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetPackLocation_FunctionAddress, "Location", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetAssetPackLocation_ReturnValue_PropertyAddress, GetAssetPackLocation_FunctionAddress, "ReturnValue");
		GetAssetPackLocation_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetAssetPackLocation_FunctionAddress, "ReturnValue");
		GetAssetPackLocation_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetAssetPackLocation_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetAssetPackLocation_IsValid = GetAssetPackLocation_FunctionAddress != IntPtr.Zero && GetAssetPackLocation_Name_IsValid && GetAssetPackLocation_Location_IsValid && GetAssetPackLocation_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:GetAssetPackLocation", GetAssetPackLocation_IsValid);
		CancelDownload_FunctionAddress = NativeReflectionCached.GetFunction(classAddress, "CancelDownload");
		CancelDownload_ParamsSize = NativeReflection.GetFunctionParamsSize(CancelDownload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref CancelDownload_AssetPacks_PropertyAddress, CancelDownload_FunctionAddress, "AssetPacks");
		CancelDownload_AssetPacks_Offset = NativeReflectionCached.GetPropertyOffset(CancelDownload_FunctionAddress, "AssetPacks");
		CancelDownload_AssetPacks_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelDownload_FunctionAddress, "AssetPacks", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref CancelDownload_ReturnValue_PropertyAddress, CancelDownload_FunctionAddress, "ReturnValue");
		CancelDownload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(CancelDownload_FunctionAddress, "ReturnValue");
		CancelDownload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(CancelDownload_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		CancelDownload_IsValid = CancelDownload_FunctionAddress != IntPtr.Zero && CancelDownload_AssetPacks_IsValid && CancelDownload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/GooglePAD.GooglePADFunctionLibrary:CancelDownload", CancelDownload_IsValid);
	}
}
