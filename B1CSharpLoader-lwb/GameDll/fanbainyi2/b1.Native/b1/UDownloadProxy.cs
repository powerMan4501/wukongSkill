using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/DownloadTookit.DownloadProxy", "DownloadTookit", UnrealModuleType.Game)]
public class UDownloadProxy : UObject
{
	private static bool OnDownloadCompleteDyMultiDlg_IsValid;

	private static int OnDownloadCompleteDyMultiDlg_Offset;

	private FOnDownloadComplete OnDownloadCompleteDyMultiDlg_DelegateCached;

	private static bool OnDownloadPausedDyMultiDlg_IsValid;

	private static int OnDownloadPausedDyMultiDlg_Offset;

	private FOnDownloadPaused OnDownloadPausedDyMultiDlg_DelegateCached;

	private static bool OnDownloadCanceledDyMultiDlg_IsValid;

	private static int OnDownloadCanceledDyMultiDlg_Offset;

	private FOnDownloadCanceled OnDownloadCanceledDyMultiDlg_DelegateCached;

	private static bool OnDownloadResumedDyMultiDlg_IsValid;

	private static int OnDownloadResumedDyMultiDlg_Offset;

	private FOnDownloadResumed OnDownloadResumedDyMultiDlg_DelegateCached;

	private static bool Tick_IsValid;

	private static IntPtr Tick_FunctionAddress;

	private static int Tick_ParamsSize;

	private static bool Tick_delta_IsValid;

	private static FFieldAddress Tick_delta_PropertyAddress;

	private static int Tick_delta_Offset;

	private static bool Tick_ReturnValue_IsValid;

	private static FFieldAddress Tick_ReturnValue_PropertyAddress;

	private static int Tick_ReturnValue_Offset;

	private static bool Resume_IsValid;

	private static IntPtr Resume_FunctionAddress;

	private static int Resume_ParamsSize;

	private static bool Resume_ReturnValue_IsValid;

	private static FFieldAddress Resume_ReturnValue_PropertyAddress;

	private static int Resume_ReturnValue_Offset;

	private static bool Reset_IsValid;

	private static IntPtr Reset_FunctionAddress;

	private static int Reset_ParamsSize;

	private static bool RequestDownload_IsValid;

	private static IntPtr RequestDownload_FunctionAddress;

	private static int RequestDownload_ParamsSize;

	private static bool RequestDownload_InURL_IsValid;

	private static FFieldAddress RequestDownload_InURL_PropertyAddress;

	private static int RequestDownload_InURL_Offset;

	private static bool RequestDownload_InSavePathOpt_IsValid;

	private static FFieldAddress RequestDownload_InSavePathOpt_PropertyAddress;

	private static int RequestDownload_InSavePathOpt_Offset;

	private static bool RequestDownload_bInSliceOpt_IsValid;

	private static FFieldAddress RequestDownload_bInSliceOpt_PropertyAddress;

	private static int RequestDownload_bInSliceOpt_Offset;

	private static bool RequestDownload_InSliceByteSizeOpt_IsValid;

	private static FFieldAddress RequestDownload_InSliceByteSizeOpt_PropertyAddress;

	private static int RequestDownload_InSliceByteSizeOpt_Offset;

	private static bool RequestDownload_bInForceOpt_IsValid;

	private static FFieldAddress RequestDownload_bInForceOpt_PropertyAddress;

	private static int RequestDownload_bInForceOpt_Offset;

	private static bool ReDownload_IsValid;

	private static IntPtr ReDownload_FunctionAddress;

	private static int ReDownload_ParamsSize;

	private static bool ReDownload_ReturnValue_IsValid;

	private static FFieldAddress ReDownload_ReturnValue_PropertyAddress;

	private static int ReDownload_ReturnValue_Offset;

	private static bool Pause_IsValid;

	private static IntPtr Pause_FunctionAddress;

	private static int Pause_ParamsSize;

	private static bool HashCheck_IsValid;

	private static IntPtr HashCheck_FunctionAddress;

	private static int HashCheck_ParamsSize;

	private static bool HashCheck_InMD5Hash_IsValid;

	private static FFieldAddress HashCheck_InMD5Hash_PropertyAddress;

	private static int HashCheck_InMD5Hash_Offset;

	private static bool HashCheck_ReturnValue_IsValid;

	private static FFieldAddress HashCheck_ReturnValue_PropertyAddress;

	private static int HashCheck_ReturnValue_Offset;

	private static bool GetTotalSize_IsValid;

	private static IntPtr GetTotalSize_FunctionAddress;

	private static int GetTotalSize_ParamsSize;

	private static bool GetTotalSize_ReturnValue_IsValid;

	private static FFieldAddress GetTotalSize_ReturnValue_PropertyAddress;

	private static int GetTotalSize_ReturnValue_Offset;

	private static bool GetDownloadStatus_IsValid;

	private static IntPtr GetDownloadStatus_FunctionAddress;

	private static int GetDownloadStatus_ParamsSize;

	private static bool GetDownloadStatus_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadStatus_ReturnValue_PropertyAddress;

	private static int GetDownloadStatus_ReturnValue_Offset;

	private static bool GetDownloadSpeedKbs_IsValid;

	private static IntPtr GetDownloadSpeedKbs_FunctionAddress;

	private static int GetDownloadSpeedKbs_ParamsSize;

	private static bool GetDownloadSpeedKbs_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadSpeedKbs_ReturnValue_PropertyAddress;

	private static int GetDownloadSpeedKbs_ReturnValue_Offset;

	private static bool GetDownloadSpeed_IsValid;

	private static IntPtr GetDownloadSpeed_FunctionAddress;

	private static int GetDownloadSpeed_ParamsSize;

	private static bool GetDownloadSpeed_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadSpeed_ReturnValue_PropertyAddress;

	private static int GetDownloadSpeed_ReturnValue_Offset;

	private static bool GetDownloadProgress_IsValid;

	private static IntPtr GetDownloadProgress_FunctionAddress;

	private static int GetDownloadProgress_ParamsSize;

	private static bool GetDownloadProgress_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadProgress_ReturnValue_PropertyAddress;

	private static int GetDownloadProgress_ReturnValue_Offset;

	private static bool GetDownloadedSize_IsValid;

	private static IntPtr GetDownloadedSize_FunctionAddress;

	private static int GetDownloadedSize_ParamsSize;

	private static bool GetDownloadedSize_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadedSize_ReturnValue_PropertyAddress;

	private static int GetDownloadedSize_ReturnValue_Offset;

	private static bool GetDownloadedFileInfo_IsValid;

	private static IntPtr GetDownloadedFileInfo_FunctionAddress;

	private static int GetDownloadedFileInfo_ParamsSize;

	private static bool GetDownloadedFileInfo_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadedFileInfo_ReturnValue_PropertyAddress;

	private static int GetDownloadedFileInfo_ReturnValue_Offset;

	private static bool Cancel_IsValid;

	private static IntPtr Cancel_FunctionAddress;

	private static int Cancel_ParamsSize;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:OnDownloadCompleteDyMultiDlg")]
	public FOnDownloadComplete OnDownloadCompleteDyMultiDlg
	{
		get
		{
			CheckDestroyed();
			if (!OnDownloadCompleteDyMultiDlg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DownloadTookit.DownloadProxy:OnDownloadCompleteDyMultiDlg");
				return new FOnDownloadComplete();
			}
			if (OnDownloadCompleteDyMultiDlg_DelegateCached == null)
			{
				OnDownloadCompleteDyMultiDlg_DelegateCached = new FOnDownloadComplete();
				OnDownloadCompleteDyMultiDlg_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDownloadCompleteDyMultiDlg_Offset));
			}
			return OnDownloadCompleteDyMultiDlg_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:OnDownloadPausedDyMultiDlg")]
	public FOnDownloadPaused OnDownloadPausedDyMultiDlg
	{
		get
		{
			CheckDestroyed();
			if (!OnDownloadPausedDyMultiDlg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DownloadTookit.DownloadProxy:OnDownloadPausedDyMultiDlg");
				return new FOnDownloadPaused();
			}
			if (OnDownloadPausedDyMultiDlg_DelegateCached == null)
			{
				OnDownloadPausedDyMultiDlg_DelegateCached = new FOnDownloadPaused();
				OnDownloadPausedDyMultiDlg_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDownloadPausedDyMultiDlg_Offset));
			}
			return OnDownloadPausedDyMultiDlg_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:OnDownloadCanceledDyMultiDlg")]
	public FOnDownloadCanceled OnDownloadCanceledDyMultiDlg
	{
		get
		{
			CheckDestroyed();
			if (!OnDownloadCanceledDyMultiDlg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DownloadTookit.DownloadProxy:OnDownloadCanceledDyMultiDlg");
				return new FOnDownloadCanceled();
			}
			if (OnDownloadCanceledDyMultiDlg_DelegateCached == null)
			{
				OnDownloadCanceledDyMultiDlg_DelegateCached = new FOnDownloadCanceled();
				OnDownloadCanceledDyMultiDlg_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDownloadCanceledDyMultiDlg_Offset));
			}
			return OnDownloadCanceledDyMultiDlg_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:OnDownloadResumedDyMultiDlg")]
	public FOnDownloadResumed OnDownloadResumedDyMultiDlg
	{
		get
		{
			CheckDestroyed();
			if (!OnDownloadResumedDyMultiDlg_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/DownloadTookit.DownloadProxy:OnDownloadResumedDyMultiDlg");
				return new FOnDownloadResumed();
			}
			if (OnDownloadResumedDyMultiDlg_DelegateCached == null)
			{
				OnDownloadResumedDyMultiDlg_DelegateCached = new FOnDownloadResumed();
				OnDownloadResumedDyMultiDlg_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnDownloadResumedDyMultiDlg_Offset));
			}
			return OnDownloadResumedDyMultiDlg_DelegateCached;
		}
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:Tick")]
	public unsafe bool Tick(float delta)
	{
		CheckDestroyed();
		if (!Tick_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:Tick");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Tick_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Tick_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, Tick_delta_Offset), 0, Tick_delta_PropertyAddress.Address, delta);
		NativeReflection.InvokeFunctionOptimized(base.Address, Tick_FunctionAddress, intPtr, Tick_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Tick_ReturnValue_Offset), 0, Tick_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:Resume")]
	public unsafe bool Resume()
	{
		CheckDestroyed();
		if (!Resume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:Resume");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Resume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Resume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Resume_FunctionAddress, intPtr, Resume_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Resume_ReturnValue_Offset), 0, Resume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:Reset")]
	public unsafe void Reset()
	{
		CheckDestroyed();
		if (!Reset_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:Reset");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Reset_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Reset_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Reset_FunctionAddress, argsSize: Reset_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:RequestDownload")]
	public unsafe void RequestDownload(string InURL, string InSavePathOpt, bool bInSliceOpt = false, int InSliceByteSizeOpt = 0, bool bInForceOpt = false)
	{
		CheckDestroyed();
		if (!RequestDownload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:RequestDownload");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(RequestDownload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)RequestDownload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestDownload_InURL_Offset), 0, RequestDownload_InURL_PropertyAddress.Address, InURL);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, RequestDownload_InSavePathOpt_Offset), 0, RequestDownload_InSavePathOpt_PropertyAddress.Address, InSavePathOpt);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestDownload_bInSliceOpt_Offset), 0, RequestDownload_bInSliceOpt_PropertyAddress.Address, bInSliceOpt);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, RequestDownload_InSliceByteSizeOpt_Offset), 0, RequestDownload_InSliceByteSizeOpt_PropertyAddress.Address, InSliceByteSizeOpt);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, RequestDownload_bInForceOpt_Offset), 0, RequestDownload_bInForceOpt_PropertyAddress.Address, bInForceOpt);
		NativeReflection.InvokeFunctionOptimized(base.Address, RequestDownload_FunctionAddress, intPtr, RequestDownload_ParamsSize);
		NativeReflection.DestroyValue_InContainer(RequestDownload_InURL_PropertyAddress.Address, intPtr);
		NativeReflection.DestroyValue_InContainer(RequestDownload_InSavePathOpt_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:ReDownload")]
	public unsafe bool ReDownload()
	{
		CheckDestroyed();
		if (!ReDownload_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:ReDownload");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReDownload_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReDownload_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, ReDownload_FunctionAddress, intPtr, ReDownload_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, ReDownload_ReturnValue_Offset), 0, ReDownload_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:Pause")]
	public unsafe void Pause()
	{
		CheckDestroyed();
		if (!Pause_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:Pause");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Pause_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Pause_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Pause_FunctionAddress, argsSize: Pause_ParamsSize);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:HashCheck")]
	public unsafe bool HashCheck(string InMD5Hash)
	{
		CheckDestroyed();
		if (!HashCheck_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:HashCheck");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HashCheck_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HashCheck_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FStringMarshaler.ToNative(IntPtr.Add(intPtr, HashCheck_InMD5Hash_Offset), 0, HashCheck_InMD5Hash_PropertyAddress.Address, InMD5Hash);
		NativeReflection.InvokeFunctionOptimized(base.Address, HashCheck_FunctionAddress, intPtr, HashCheck_ParamsSize);
		NativeReflection.DestroyValue_InContainer(HashCheck_InMD5Hash_PropertyAddress.Address, intPtr);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HashCheck_ReturnValue_Offset), 0, HashCheck_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetTotalSize")]
	public unsafe int GetTotalSize()
	{
		CheckDestroyed();
		if (!GetTotalSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetTotalSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTotalSize_FunctionAddress, intPtr, GetTotalSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetTotalSize_ReturnValue_Offset), 0, GetTotalSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadStatus")]
	public unsafe EDownloadStatus GetDownloadStatus()
	{
		CheckDestroyed();
		if (!GetDownloadStatus_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadStatus");
			return EDownloadStatus.NotStarted;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadStatus_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadStatus_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadStatus_FunctionAddress, intPtr, GetDownloadStatus_ParamsSize);
		return EnumMarshaler<EDownloadStatus>.FromNative(IntPtr.Add(intPtr, GetDownloadStatus_ReturnValue_Offset), 0, GetDownloadStatus_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeedKbs")]
	public unsafe float GetDownloadSpeedKbs()
	{
		CheckDestroyed();
		if (!GetDownloadSpeedKbs_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeedKbs");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadSpeedKbs_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadSpeedKbs_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadSpeedKbs_FunctionAddress, intPtr, GetDownloadSpeedKbs_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDownloadSpeedKbs_ReturnValue_Offset), 0, GetDownloadSpeedKbs_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeed")]
	public unsafe int GetDownloadSpeed()
	{
		CheckDestroyed();
		if (!GetDownloadSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeed");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadSpeed_FunctionAddress, intPtr, GetDownloadSpeed_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDownloadSpeed_ReturnValue_Offset), 0, GetDownloadSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadProgress")]
	public unsafe float GetDownloadProgress()
	{
		CheckDestroyed();
		if (!GetDownloadProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadProgress_FunctionAddress, intPtr, GetDownloadProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDownloadProgress_ReturnValue_Offset), 0, GetDownloadProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadedSize")]
	public unsafe int GetDownloadedSize()
	{
		CheckDestroyed();
		if (!GetDownloadedSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadedSize");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadedSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadedSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadedSize_FunctionAddress, intPtr, GetDownloadedSize_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDownloadedSize_ReturnValue_Offset), 0, GetDownloadedSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:GetDownloadedFileInfo")]
	public unsafe FDownloadFile GetDownloadedFileInfo()
	{
		CheckDestroyed();
		if (!GetDownloadedFileInfo_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:GetDownloadedFileInfo");
			return default(FDownloadFile);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadedFileInfo_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadedFileInfo_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadedFileInfo_FunctionAddress, intPtr, GetDownloadedFileInfo_ParamsSize);
		FDownloadFile result = FDownloadFile.FromNative(IntPtr.Add(intPtr, GetDownloadedFileInfo_ReturnValue_Offset), 0, GetDownloadedFileInfo_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDownloadedFileInfo_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/DownloadTookit.DownloadProxy:Cancel")]
	public unsafe void Cancel()
	{
		CheckDestroyed();
		if (!Cancel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/DownloadTookit.DownloadProxy:Cancel");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cancel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cancel_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: Cancel_FunctionAddress, argsSize: Cancel_ParamsSize);
	}

	static UDownloadProxy()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UDownloadProxy)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDownloadProxy));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/DownloadTookit.DownloadProxy");
		OnDownloadCompleteDyMultiDlg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDownloadCompleteDyMultiDlg");
		OnDownloadCompleteDyMultiDlg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDownloadCompleteDyMultiDlg", Classes.FMulticastDelegateProperty);
		OnDownloadPausedDyMultiDlg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDownloadPausedDyMultiDlg");
		OnDownloadPausedDyMultiDlg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDownloadPausedDyMultiDlg", Classes.FMulticastDelegateProperty);
		OnDownloadCanceledDyMultiDlg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDownloadCanceledDyMultiDlg");
		OnDownloadCanceledDyMultiDlg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDownloadCanceledDyMultiDlg", Classes.FMulticastDelegateProperty);
		OnDownloadResumedDyMultiDlg_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnDownloadResumedDyMultiDlg");
		OnDownloadResumedDyMultiDlg_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnDownloadResumedDyMultiDlg", Classes.FMulticastDelegateProperty);
		Tick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Tick");
		Tick_ParamsSize = NativeReflection.GetFunctionParamsSize(Tick_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Tick_delta_PropertyAddress, Tick_FunctionAddress, "delta");
		Tick_delta_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "delta");
		Tick_delta_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "delta", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Tick_ReturnValue_PropertyAddress, Tick_FunctionAddress, "ReturnValue");
		Tick_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Tick_FunctionAddress, "ReturnValue");
		Tick_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Tick_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Tick_IsValid = Tick_FunctionAddress != IntPtr.Zero && Tick_delta_IsValid && Tick_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:Tick", Tick_IsValid);
		Resume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Resume");
		Resume_ParamsSize = NativeReflection.GetFunctionParamsSize(Resume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Resume_ReturnValue_PropertyAddress, Resume_FunctionAddress, "ReturnValue");
		Resume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Resume_FunctionAddress, "ReturnValue");
		Resume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Resume_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Resume_IsValid = Resume_FunctionAddress != IntPtr.Zero && Resume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:Resume", Resume_IsValid);
		Reset_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Reset");
		Reset_ParamsSize = NativeReflection.GetFunctionParamsSize(Reset_FunctionAddress);
		Reset_IsValid = Reset_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:Reset", Reset_IsValid);
		RequestDownload_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RequestDownload");
		RequestDownload_ParamsSize = NativeReflection.GetFunctionParamsSize(RequestDownload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_InURL_PropertyAddress, RequestDownload_FunctionAddress, "InURL");
		RequestDownload_InURL_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "InURL");
		RequestDownload_InURL_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "InURL", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_InSavePathOpt_PropertyAddress, RequestDownload_FunctionAddress, "InSavePathOpt");
		RequestDownload_InSavePathOpt_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "InSavePathOpt");
		RequestDownload_InSavePathOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "InSavePathOpt", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_bInSliceOpt_PropertyAddress, RequestDownload_FunctionAddress, "bInSliceOpt");
		RequestDownload_bInSliceOpt_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "bInSliceOpt");
		RequestDownload_bInSliceOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "bInSliceOpt", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_InSliceByteSizeOpt_PropertyAddress, RequestDownload_FunctionAddress, "InSliceByteSizeOpt");
		RequestDownload_InSliceByteSizeOpt_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "InSliceByteSizeOpt");
		RequestDownload_InSliceByteSizeOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "InSliceByteSizeOpt", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref RequestDownload_bInForceOpt_PropertyAddress, RequestDownload_FunctionAddress, "bInForceOpt");
		RequestDownload_bInForceOpt_Offset = NativeReflectionCached.GetPropertyOffset(RequestDownload_FunctionAddress, "bInForceOpt");
		RequestDownload_bInForceOpt_IsValid = NativeReflectionCached.ValidatePropertyClass(RequestDownload_FunctionAddress, "bInForceOpt", Classes.FBoolProperty);
		RequestDownload_IsValid = RequestDownload_FunctionAddress != IntPtr.Zero && RequestDownload_InURL_IsValid && RequestDownload_InSavePathOpt_IsValid && RequestDownload_bInSliceOpt_IsValid && RequestDownload_InSliceByteSizeOpt_IsValid && RequestDownload_bInForceOpt_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:RequestDownload", RequestDownload_IsValid);
		ReDownload_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReDownload");
		ReDownload_ParamsSize = NativeReflection.GetFunctionParamsSize(ReDownload_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ReDownload_ReturnValue_PropertyAddress, ReDownload_FunctionAddress, "ReturnValue");
		ReDownload_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ReDownload_FunctionAddress, "ReturnValue");
		ReDownload_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ReDownload_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ReDownload_IsValid = ReDownload_FunctionAddress != IntPtr.Zero && ReDownload_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:ReDownload", ReDownload_IsValid);
		Pause_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Pause");
		Pause_ParamsSize = NativeReflection.GetFunctionParamsSize(Pause_FunctionAddress);
		Pause_IsValid = Pause_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:Pause", Pause_IsValid);
		HashCheck_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HashCheck");
		HashCheck_ParamsSize = NativeReflection.GetFunctionParamsSize(HashCheck_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HashCheck_InMD5Hash_PropertyAddress, HashCheck_FunctionAddress, "InMD5Hash");
		HashCheck_InMD5Hash_Offset = NativeReflectionCached.GetPropertyOffset(HashCheck_FunctionAddress, "InMD5Hash");
		HashCheck_InMD5Hash_IsValid = NativeReflectionCached.ValidatePropertyClass(HashCheck_FunctionAddress, "InMD5Hash", Classes.FStrProperty);
		NativeReflectionCached.GetPropertyRef(ref HashCheck_ReturnValue_PropertyAddress, HashCheck_FunctionAddress, "ReturnValue");
		HashCheck_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HashCheck_FunctionAddress, "ReturnValue");
		HashCheck_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HashCheck_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HashCheck_IsValid = HashCheck_FunctionAddress != IntPtr.Zero && HashCheck_InMD5Hash_IsValid && HashCheck_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:HashCheck", HashCheck_IsValid);
		GetTotalSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetTotalSize");
		GetTotalSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalSize_ReturnValue_PropertyAddress, GetTotalSize_FunctionAddress, "ReturnValue");
		GetTotalSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalSize_FunctionAddress, "ReturnValue");
		GetTotalSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetTotalSize_IsValid = GetTotalSize_FunctionAddress != IntPtr.Zero && GetTotalSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetTotalSize", GetTotalSize_IsValid);
		GetDownloadStatus_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadStatus");
		GetDownloadStatus_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadStatus_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadStatus_ReturnValue_PropertyAddress, GetDownloadStatus_FunctionAddress, "ReturnValue");
		GetDownloadStatus_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadStatus_FunctionAddress, "ReturnValue");
		GetDownloadStatus_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadStatus_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetDownloadStatus_IsValid = GetDownloadStatus_FunctionAddress != IntPtr.Zero && GetDownloadStatus_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadStatus", GetDownloadStatus_IsValid);
		GetDownloadSpeedKbs_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadSpeedKbs");
		GetDownloadSpeedKbs_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadSpeedKbs_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadSpeedKbs_ReturnValue_PropertyAddress, GetDownloadSpeedKbs_FunctionAddress, "ReturnValue");
		GetDownloadSpeedKbs_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadSpeedKbs_FunctionAddress, "ReturnValue");
		GetDownloadSpeedKbs_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadSpeedKbs_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDownloadSpeedKbs_IsValid = GetDownloadSpeedKbs_FunctionAddress != IntPtr.Zero && GetDownloadSpeedKbs_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeedKbs", GetDownloadSpeedKbs_IsValid);
		GetDownloadSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadSpeed");
		GetDownloadSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadSpeed_ReturnValue_PropertyAddress, GetDownloadSpeed_FunctionAddress, "ReturnValue");
		GetDownloadSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadSpeed_FunctionAddress, "ReturnValue");
		GetDownloadSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadSpeed_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDownloadSpeed_IsValid = GetDownloadSpeed_FunctionAddress != IntPtr.Zero && GetDownloadSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadSpeed", GetDownloadSpeed_IsValid);
		GetDownloadProgress_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadProgress");
		GetDownloadProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadProgress_ReturnValue_PropertyAddress, GetDownloadProgress_FunctionAddress, "ReturnValue");
		GetDownloadProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadProgress_FunctionAddress, "ReturnValue");
		GetDownloadProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDownloadProgress_IsValid = GetDownloadProgress_FunctionAddress != IntPtr.Zero && GetDownloadProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadProgress", GetDownloadProgress_IsValid);
		GetDownloadedSize_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadedSize");
		GetDownloadedSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadedSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadedSize_ReturnValue_PropertyAddress, GetDownloadedSize_FunctionAddress, "ReturnValue");
		GetDownloadedSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadedSize_FunctionAddress, "ReturnValue");
		GetDownloadedSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadedSize_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDownloadedSize_IsValid = GetDownloadedSize_FunctionAddress != IntPtr.Zero && GetDownloadedSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadedSize", GetDownloadedSize_IsValid);
		GetDownloadedFileInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDownloadedFileInfo");
		GetDownloadedFileInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadedFileInfo_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadedFileInfo_ReturnValue_PropertyAddress, GetDownloadedFileInfo_FunctionAddress, "ReturnValue");
		GetDownloadedFileInfo_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadedFileInfo_FunctionAddress, "ReturnValue");
		GetDownloadedFileInfo_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadedFileInfo_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetDownloadedFileInfo_IsValid = GetDownloadedFileInfo_FunctionAddress != IntPtr.Zero && GetDownloadedFileInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:GetDownloadedFileInfo", GetDownloadedFileInfo_IsValid);
		Cancel_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Cancel");
		Cancel_ParamsSize = NativeReflection.GetFunctionParamsSize(Cancel_FunctionAddress);
		Cancel_IsValid = Cancel_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/DownloadTookit.DownloadProxy:Cancel", Cancel_IsValid);
	}
}
