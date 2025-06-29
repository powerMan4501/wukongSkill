using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.MobilePatchingUtils;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent", "MobilePatchingUtils", UnrealModuleType.EnginePlugin)]
public class UMobilePendingContent : UMobileInstalledContent
{
	private static bool StartInstall_IsValid;

	private static IntPtr StartInstall_FunctionAddress;

	private static int StartInstall_ParamsSize;

	private static bool StartInstall_OnSucceeded_IsValid;

	private static FFieldAddress StartInstall_OnSucceeded_PropertyAddress;

	private static int StartInstall_OnSucceeded_Offset;

	private static bool StartInstall_OnFailed_IsValid;

	private static FFieldAddress StartInstall_OnFailed_PropertyAddress;

	private static int StartInstall_OnFailed_Offset;

	private static bool GetTotalDownloadedSize_IsValid;

	private static IntPtr GetTotalDownloadedSize_FunctionAddress;

	private static int GetTotalDownloadedSize_ParamsSize;

	private static bool GetTotalDownloadedSize_ReturnValue_IsValid;

	private static FFieldAddress GetTotalDownloadedSize_ReturnValue_PropertyAddress;

	private static int GetTotalDownloadedSize_ReturnValue_Offset;

	private static bool GetRequiredDiskSpace_IsValid;

	private static IntPtr GetRequiredDiskSpace_FunctionAddress;

	private static int GetRequiredDiskSpace_ParamsSize;

	private static bool GetRequiredDiskSpace_ReturnValue_IsValid;

	private static FFieldAddress GetRequiredDiskSpace_ReturnValue_PropertyAddress;

	private static int GetRequiredDiskSpace_ReturnValue_Offset;

	private static bool GetInstallProgress_IsValid;

	private static IntPtr GetInstallProgress_FunctionAddress;

	private static int GetInstallProgress_ParamsSize;

	private static bool GetInstallProgress_ReturnValue_IsValid;

	private static FFieldAddress GetInstallProgress_ReturnValue_PropertyAddress;

	private static int GetInstallProgress_ReturnValue_Offset;

	private static bool GetDownloadStatusText_IsValid;

	private static IntPtr GetDownloadStatusText_FunctionAddress;

	private static int GetDownloadStatusText_ParamsSize;

	private static bool GetDownloadStatusText_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadStatusText_ReturnValue_PropertyAddress;

	private static int GetDownloadStatusText_ReturnValue_Offset;

	private static bool GetDownloadSpeed_IsValid;

	private static IntPtr GetDownloadSpeed_FunctionAddress;

	private static int GetDownloadSpeed_ParamsSize;

	private static bool GetDownloadSpeed_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadSpeed_ReturnValue_PropertyAddress;

	private static int GetDownloadSpeed_ReturnValue_Offset;

	private static bool GetDownloadSize_IsValid;

	private static IntPtr GetDownloadSize_FunctionAddress;

	private static int GetDownloadSize_ParamsSize;

	private static bool GetDownloadSize_ReturnValue_IsValid;

	private static FFieldAddress GetDownloadSize_ReturnValue_PropertyAddress;

	private static int GetDownloadSize_ReturnValue_Offset;

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:StartInstall")]
	public unsafe void StartInstall(FOnContentInstallSucceeded OnSucceeded, FOnContentInstallFailed OnFailed)
	{
		CheckDestroyed();
		if (!StartInstall_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:StartInstall");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StartInstall_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StartInstall_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		FDelegateMarshaler<FOnContentInstallSucceeded>.ToNative(IntPtr.Add(intPtr, StartInstall_OnSucceeded_Offset), 0, StartInstall_OnSucceeded_PropertyAddress.Address, OnSucceeded);
		FDelegateMarshaler<FOnContentInstallFailed>.ToNative(IntPtr.Add(intPtr, StartInstall_OnFailed_Offset), 0, StartInstall_OnFailed_PropertyAddress.Address, OnFailed);
		NativeReflection.InvokeFunctionOptimized(base.Address, StartInstall_FunctionAddress, intPtr, StartInstall_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetTotalDownloadedSize")]
	public unsafe float GetTotalDownloadedSize()
	{
		CheckDestroyed();
		if (!GetTotalDownloadedSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetTotalDownloadedSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetTotalDownloadedSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetTotalDownloadedSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetTotalDownloadedSize_FunctionAddress, intPtr, GetTotalDownloadedSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetTotalDownloadedSize_ReturnValue_Offset), 0, GetTotalDownloadedSize_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetRequiredDiskSpace")]
	public unsafe float GetRequiredDiskSpace()
	{
		CheckDestroyed();
		if (!GetRequiredDiskSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetRequiredDiskSpace");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRequiredDiskSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRequiredDiskSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRequiredDiskSpace_FunctionAddress, intPtr, GetRequiredDiskSpace_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetRequiredDiskSpace_ReturnValue_Offset), 0, GetRequiredDiskSpace_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetInstallProgress")]
	public unsafe float GetInstallProgress()
	{
		CheckDestroyed();
		if (!GetInstallProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetInstallProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetInstallProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetInstallProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetInstallProgress_FunctionAddress, intPtr, GetInstallProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetInstallProgress_ReturnValue_Offset), 0, GetInstallProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadStatusText")]
	public unsafe string GetDownloadStatusText()
	{
		CheckDestroyed();
		if (!GetDownloadStatusText_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadStatusText");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadStatusText_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadStatusText_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadStatusText_FunctionAddress, intPtr, GetDownloadStatusText_ParamsSize);
		FText fText = FTextMarshaler.FromNative(IntPtr.Add(intPtr, GetDownloadStatusText_ReturnValue_Offset), 0, GetDownloadStatusText_ReturnValue_PropertyAddress.Address);
		string result = fText.ToString();
		NativeReflection.DestroyValue_InContainer(GetDownloadStatusText_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSpeed")]
	public unsafe float GetDownloadSpeed()
	{
		CheckDestroyed();
		if (!GetDownloadSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSpeed");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadSpeed_FunctionAddress, intPtr, GetDownloadSpeed_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDownloadSpeed_ReturnValue_Offset), 0, GetDownloadSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSize")]
	public unsafe float GetDownloadSize()
	{
		CheckDestroyed();
		if (!GetDownloadSize_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSize");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDownloadSize_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDownloadSize_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDownloadSize_FunctionAddress, intPtr, GetDownloadSize_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetDownloadSize_ReturnValue_Offset), 0, GetDownloadSize_ReturnValue_PropertyAddress.Address);
	}

	static UMobilePendingContent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMobilePendingContent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMobilePendingContent));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/MobilePatchingUtils.MobilePendingContent");
		StartInstall_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "StartInstall");
		StartInstall_ParamsSize = NativeReflection.GetFunctionParamsSize(StartInstall_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StartInstall_OnSucceeded_PropertyAddress, StartInstall_FunctionAddress, "OnSucceeded");
		StartInstall_OnSucceeded_Offset = NativeReflectionCached.GetPropertyOffset(StartInstall_FunctionAddress, "OnSucceeded");
		StartInstall_OnSucceeded_IsValid = NativeReflectionCached.ValidatePropertyClass(StartInstall_FunctionAddress, "OnSucceeded", Classes.FDelegateProperty);
		NativeReflectionCached.GetPropertyRef(ref StartInstall_OnFailed_PropertyAddress, StartInstall_FunctionAddress, "OnFailed");
		StartInstall_OnFailed_Offset = NativeReflectionCached.GetPropertyOffset(StartInstall_FunctionAddress, "OnFailed");
		StartInstall_OnFailed_IsValid = NativeReflectionCached.ValidatePropertyClass(StartInstall_FunctionAddress, "OnFailed", Classes.FDelegateProperty);
		StartInstall_IsValid = StartInstall_FunctionAddress != IntPtr.Zero && StartInstall_OnSucceeded_IsValid && StartInstall_OnFailed_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:StartInstall", StartInstall_IsValid);
		GetTotalDownloadedSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetTotalDownloadedSize");
		GetTotalDownloadedSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetTotalDownloadedSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetTotalDownloadedSize_ReturnValue_PropertyAddress, GetTotalDownloadedSize_FunctionAddress, "ReturnValue");
		GetTotalDownloadedSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetTotalDownloadedSize_FunctionAddress, "ReturnValue");
		GetTotalDownloadedSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetTotalDownloadedSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetTotalDownloadedSize_IsValid = GetTotalDownloadedSize_FunctionAddress != IntPtr.Zero && GetTotalDownloadedSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetTotalDownloadedSize", GetTotalDownloadedSize_IsValid);
		GetRequiredDiskSpace_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRequiredDiskSpace");
		GetRequiredDiskSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRequiredDiskSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRequiredDiskSpace_ReturnValue_PropertyAddress, GetRequiredDiskSpace_FunctionAddress, "ReturnValue");
		GetRequiredDiskSpace_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetRequiredDiskSpace_FunctionAddress, "ReturnValue");
		GetRequiredDiskSpace_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRequiredDiskSpace_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetRequiredDiskSpace_IsValid = GetRequiredDiskSpace_FunctionAddress != IntPtr.Zero && GetRequiredDiskSpace_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetRequiredDiskSpace", GetRequiredDiskSpace_IsValid);
		GetInstallProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetInstallProgress");
		GetInstallProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetInstallProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetInstallProgress_ReturnValue_PropertyAddress, GetInstallProgress_FunctionAddress, "ReturnValue");
		GetInstallProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetInstallProgress_FunctionAddress, "ReturnValue");
		GetInstallProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetInstallProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetInstallProgress_IsValid = GetInstallProgress_FunctionAddress != IntPtr.Zero && GetInstallProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetInstallProgress", GetInstallProgress_IsValid);
		GetDownloadStatusText_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDownloadStatusText");
		GetDownloadStatusText_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadStatusText_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadStatusText_ReturnValue_PropertyAddress, GetDownloadStatusText_FunctionAddress, "ReturnValue");
		GetDownloadStatusText_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadStatusText_FunctionAddress, "ReturnValue");
		GetDownloadStatusText_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadStatusText_FunctionAddress, "ReturnValue", Classes.FTextProperty);
		GetDownloadStatusText_IsValid = GetDownloadStatusText_FunctionAddress != IntPtr.Zero && GetDownloadStatusText_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadStatusText", GetDownloadStatusText_IsValid);
		GetDownloadSpeed_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDownloadSpeed");
		GetDownloadSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadSpeed_ReturnValue_PropertyAddress, GetDownloadSpeed_FunctionAddress, "ReturnValue");
		GetDownloadSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadSpeed_FunctionAddress, "ReturnValue");
		GetDownloadSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadSpeed_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDownloadSpeed_IsValid = GetDownloadSpeed_FunctionAddress != IntPtr.Zero && GetDownloadSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSpeed", GetDownloadSpeed_IsValid);
		GetDownloadSize_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDownloadSize");
		GetDownloadSize_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDownloadSize_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDownloadSize_ReturnValue_PropertyAddress, GetDownloadSize_FunctionAddress, "ReturnValue");
		GetDownloadSize_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDownloadSize_FunctionAddress, "ReturnValue");
		GetDownloadSize_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDownloadSize_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetDownloadSize_IsValid = GetDownloadSize_FunctionAddress != IntPtr.Zero && GetDownloadSize_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/MobilePatchingUtils.MobilePendingContent:GetDownloadSize", GetDownloadSize_IsValid);
	}
}
