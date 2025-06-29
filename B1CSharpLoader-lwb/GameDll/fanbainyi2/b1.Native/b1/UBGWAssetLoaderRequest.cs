using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810549408uL, Config = "Engine")]
[UMetaPath("/Script/b1.BGWAssetLoaderRequest", "b1", UnrealModuleType.Game)]
public class UBGWAssetLoaderRequest : UObject
{
	private static bool WasCanceled_IsValid;

	private static IntPtr WasCanceled_FunctionAddress;

	private static int WasCanceled_ParamsSize;

	private static bool WasCanceled_ReturnValue_IsValid;

	private static FFieldAddress WasCanceled_ReturnValue_PropertyAddress;

	private static int WasCanceled_ReturnValue_Offset;

	private static bool WaitUntilComplete_IsValid;

	private static IntPtr WaitUntilComplete_FunctionAddress;

	private static int WaitUntilComplete_ParamsSize;

	private static bool WaitUntilComplete_Timeout_IsValid;

	private static FFieldAddress WaitUntilComplete_Timeout_PropertyAddress;

	private static int WaitUntilComplete_Timeout_Offset;

	private static bool WaitUntilComplete_bStartStalledHandles_IsValid;

	private static FFieldAddress WaitUntilComplete_bStartStalledHandles_PropertyAddress;

	private static int WaitUntilComplete_bStartStalledHandles_Offset;

	private static bool WaitUntilComplete_ReturnValue_IsValid;

	private static FFieldAddress WaitUntilComplete_ReturnValue_PropertyAddress;

	private static int WaitUntilComplete_ReturnValue_Offset;

	private static bool IsStalled_IsValid;

	private static IntPtr IsStalled_FunctionAddress;

	private static int IsStalled_ParamsSize;

	private static bool IsStalled_ReturnValue_IsValid;

	private static FFieldAddress IsStalled_ReturnValue_PropertyAddress;

	private static int IsStalled_ReturnValue_Offset;

	private static bool IsLoadingInProgress_IsValid;

	private static IntPtr IsLoadingInProgress_FunctionAddress;

	private static int IsLoadingInProgress_ParamsSize;

	private static bool IsLoadingInProgress_ReturnValue_IsValid;

	private static FFieldAddress IsLoadingInProgress_ReturnValue_PropertyAddress;

	private static int IsLoadingInProgress_ReturnValue_Offset;

	private static bool IsCombinedHandle_IsValid;

	private static IntPtr IsCombinedHandle_FunctionAddress;

	private static int IsCombinedHandle_ParamsSize;

	private static bool IsCombinedHandle_ReturnValue_IsValid;

	private static FFieldAddress IsCombinedHandle_ReturnValue_PropertyAddress;

	private static int IsCombinedHandle_ReturnValue_Offset;

	private static bool IsActive_IsValid;

	private static IntPtr IsActive_FunctionAddress;

	private static int IsActive_ParamsSize;

	private static bool IsActive_ReturnValue_IsValid;

	private static FFieldAddress IsActive_ReturnValue_PropertyAddress;

	private static int IsActive_ReturnValue_Offset;

	private static bool HasLoadCompletedOrStalled_IsValid;

	private static IntPtr HasLoadCompletedOrStalled_FunctionAddress;

	private static int HasLoadCompletedOrStalled_ParamsSize;

	private static bool HasLoadCompletedOrStalled_ReturnValue_IsValid;

	private static FFieldAddress HasLoadCompletedOrStalled_ReturnValue_PropertyAddress;

	private static int HasLoadCompletedOrStalled_ReturnValue_Offset;

	private static bool HasLoadCompleted_IsValid;

	private static IntPtr HasLoadCompleted_FunctionAddress;

	private static int HasLoadCompleted_ParamsSize;

	private static bool HasLoadCompleted_ReturnValue_IsValid;

	private static FFieldAddress HasLoadCompleted_ReturnValue_PropertyAddress;

	private static int HasLoadCompleted_ReturnValue_Offset;

	private static bool GetRequestedAssets_IsValid;

	private static IntPtr GetRequestedAssets_FunctionAddress;

	private static int GetRequestedAssets_ParamsSize;

	private static bool GetRequestedAssets_AssetList_IsValid;

	private static FFieldAddress GetRequestedAssets_AssetList_PropertyAddress;

	private static int GetRequestedAssets_AssetList_Offset;

	private static bool GetProgress_IsValid;

	private static IntPtr GetProgress_FunctionAddress;

	private static int GetProgress_ParamsSize;

	private static bool GetProgress_ReturnValue_IsValid;

	private static FFieldAddress GetProgress_ReturnValue_PropertyAddress;

	private static int GetProgress_ReturnValue_Offset;

	private static bool GetPriority_IsValid;

	private static IntPtr GetPriority_FunctionAddress;

	private static int GetPriority_ParamsSize;

	private static bool GetPriority_ReturnValue_IsValid;

	private static FFieldAddress GetPriority_ReturnValue_PropertyAddress;

	private static int GetPriority_ReturnValue_Offset;

	private static bool GetLoadedCount_IsValid;

	private static IntPtr GetLoadedCount_FunctionAddress;

	private static int GetLoadedCount_ParamsSize;

	private static bool GetLoadedCount_LoadedCount_IsValid;

	private static FFieldAddress GetLoadedCount_LoadedCount_PropertyAddress;

	private static int GetLoadedCount_LoadedCount_Offset;

	private static bool GetLoadedCount_RequestedCount_IsValid;

	private static FFieldAddress GetLoadedCount_RequestedCount_PropertyAddress;

	private static int GetLoadedCount_RequestedCount_Offset;

	private static bool GetLoadedAssets_IsValid;

	private static IntPtr GetLoadedAssets_FunctionAddress;

	private static int GetLoadedAssets_ParamsSize;

	private static bool GetLoadedAssets_LoadedAssets_IsValid;

	private static FFieldAddress GetLoadedAssets_LoadedAssets_PropertyAddress;

	private static int GetLoadedAssets_LoadedAssets_Offset;

	private static bool GetDebugName_IsValid;

	private static IntPtr GetDebugName_FunctionAddress;

	private static int GetDebugName_ParamsSize;

	private static bool GetDebugName_ReturnValue_IsValid;

	private static FFieldAddress GetDebugName_ReturnValue_PropertyAddress;

	private static int GetDebugName_ReturnValue_Offset;

	private static bool ExecuteCS_IsValid;

	private IntPtr ExecuteCS_InstanceFunctionAddress;

	private static IntPtr ExecuteCS_FunctionAddress;

	private static int ExecuteCS_ParamsSize;

	private static bool Cancel_IsValid;

	private static IntPtr Cancel_FunctionAddress;

	private static int Cancel_ParamsSize;

	private static bool Cancel_ReturnValue_IsValid;

	private static FFieldAddress Cancel_ReturnValue_PropertyAddress;

	private static int Cancel_ReturnValue_Offset;

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:WasCanceled")]
	public unsafe bool WasCanceled()
	{
		CheckDestroyed();
		if (!WasCanceled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:WasCanceled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WasCanceled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WasCanceled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, WasCanceled_FunctionAddress, intPtr, WasCanceled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WasCanceled_ReturnValue_Offset), 0, WasCanceled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:WaitUntilComplete")]
	public unsafe bool WaitUntilComplete(float Timeout, bool bStartStalledHandles = true)
	{
		CheckDestroyed();
		if (!WaitUntilComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:WaitUntilComplete");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(WaitUntilComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)WaitUntilComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, WaitUntilComplete_Timeout_Offset), 0, WaitUntilComplete_Timeout_PropertyAddress.Address, Timeout);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, WaitUntilComplete_bStartStalledHandles_Offset), 0, WaitUntilComplete_bStartStalledHandles_PropertyAddress.Address, bStartStalledHandles);
		NativeReflection.InvokeFunctionOptimized(base.Address, WaitUntilComplete_FunctionAddress, intPtr, WaitUntilComplete_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, WaitUntilComplete_ReturnValue_Offset), 0, WaitUntilComplete_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:IsStalled")]
	public unsafe bool IsStalled()
	{
		CheckDestroyed();
		if (!IsStalled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:IsStalled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsStalled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsStalled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsStalled_FunctionAddress, intPtr, IsStalled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsStalled_ReturnValue_Offset), 0, IsStalled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:IsLoadingInProgress")]
	public unsafe bool IsLoadingInProgress()
	{
		CheckDestroyed();
		if (!IsLoadingInProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:IsLoadingInProgress");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsLoadingInProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsLoadingInProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsLoadingInProgress_FunctionAddress, intPtr, IsLoadingInProgress_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsLoadingInProgress_ReturnValue_Offset), 0, IsLoadingInProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:IsCombinedHandle")]
	public unsafe bool IsCombinedHandle()
	{
		CheckDestroyed();
		if (!IsCombinedHandle_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:IsCombinedHandle");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsCombinedHandle_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsCombinedHandle_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsCombinedHandle_FunctionAddress, intPtr, IsCombinedHandle_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsCombinedHandle_ReturnValue_Offset), 0, IsCombinedHandle_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:IsActive")]
	public unsafe bool IsActive()
	{
		CheckDestroyed();
		if (!IsActive_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:IsActive");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsActive_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsActive_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsActive_FunctionAddress, intPtr, IsActive_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsActive_ReturnValue_Offset), 0, IsActive_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:HasLoadCompletedOrStalled")]
	public unsafe bool HasLoadCompletedOrStalled()
	{
		CheckDestroyed();
		if (!HasLoadCompletedOrStalled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:HasLoadCompletedOrStalled");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasLoadCompletedOrStalled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasLoadCompletedOrStalled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasLoadCompletedOrStalled_FunctionAddress, intPtr, HasLoadCompletedOrStalled_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasLoadCompletedOrStalled_ReturnValue_Offset), 0, HasLoadCompletedOrStalled_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:HasLoadCompleted")]
	public unsafe bool HasLoadCompleted()
	{
		CheckDestroyed();
		if (!HasLoadCompleted_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:HasLoadCompleted");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HasLoadCompleted_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HasLoadCompleted_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, HasLoadCompleted_FunctionAddress, intPtr, HasLoadCompleted_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, HasLoadCompleted_ReturnValue_Offset), 0, HasLoadCompleted_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetRequestedAssets")]
	public unsafe void GetRequestedAssets(out List<FSoftObjectPath> AssetList)
	{
		CheckDestroyed();
		if (!GetRequestedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetRequestedAssets");
			AssetList = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetRequestedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetRequestedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetRequestedAssets_FunctionAddress, intPtr, GetRequestedAssets_ParamsSize);
		AssetList = new TArrayCopyMarshaler<FSoftObjectPath>(1, GetRequestedAssets_AssetList_PropertyAddress, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.FromNative, CachedMarshalingDelegates<FSoftObjectPath, FSoftObjectPath>.ToNative).FromNative(IntPtr.Add(intPtr, GetRequestedAssets_AssetList_Offset));
		NativeReflection.DestroyValue_InContainer(GetRequestedAssets_AssetList_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetProgress")]
	public unsafe float GetProgress()
	{
		CheckDestroyed();
		if (!GetProgress_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetProgress");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetProgress_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetProgress_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetProgress_FunctionAddress, intPtr, GetProgress_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetProgress_ReturnValue_Offset), 0, GetProgress_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetPriority")]
	public unsafe int GetPriority()
	{
		CheckDestroyed();
		if (!GetPriority_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetPriority");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPriority_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPriority_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPriority_FunctionAddress, intPtr, GetPriority_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPriority_ReturnValue_Offset), 0, GetPriority_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetLoadedCount")]
	public unsafe void GetLoadedCount(out int LoadedCount, out int RequestedCount)
	{
		CheckDestroyed();
		if (!GetLoadedCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetLoadedCount");
			LoadedCount = 0;
			RequestedCount = 0;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoadedCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoadedCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLoadedCount_FunctionAddress, intPtr, GetLoadedCount_ParamsSize);
		LoadedCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLoadedCount_LoadedCount_Offset), 0, GetLoadedCount_LoadedCount_PropertyAddress.Address);
		RequestedCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLoadedCount_RequestedCount_Offset), 0, GetLoadedCount_RequestedCount_PropertyAddress.Address);
	}

	[UFunction(Flags = 1413612545u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetLoadedAssets")]
	public unsafe void GetLoadedAssets(out List<UObject> LoadedAssets)
	{
		CheckDestroyed();
		if (!GetLoadedAssets_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetLoadedAssets");
			LoadedAssets = null;
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLoadedAssets_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLoadedAssets_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLoadedAssets_FunctionAddress, intPtr, GetLoadedAssets_ParamsSize);
		LoadedAssets = new TArrayCopyMarshaler<UObject>(1, GetLoadedAssets_LoadedAssets_PropertyAddress, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.FromNative, CachedMarshalingDelegates<UObject, UObjectMarshaler<UObject>>.ToNative).FromNative(IntPtr.Add(intPtr, GetLoadedAssets_LoadedAssets_Offset));
		NativeReflection.DestroyValue_InContainer(GetLoadedAssets_LoadedAssets_PropertyAddress.Address, intPtr);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:GetDebugName")]
	public unsafe string GetDebugName()
	{
		CheckDestroyed();
		if (!GetDebugName_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:GetDebugName");
			return FStringMarshaler.DefaultString;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugName_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugName_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDebugName_FunctionAddress, intPtr, GetDebugName_ParamsSize);
		string result = FStringMarshaler.FromNative(IntPtr.Add(intPtr, GetDebugName_ReturnValue_Offset), 0, GetDebugName_ReturnValue_PropertyAddress.Address);
		NativeReflection.DestroyValue_InContainer(GetDebugName_ReturnValue_PropertyAddress.Address, intPtr);
		return result;
	}

	[UFunction(Flags = 1208485888u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:ExecuteCS")]
	protected unsafe void ExecuteCS()
	{
		CheckDestroyed();
		if (!ExecuteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:ExecuteCS");
			return;
		}
		if (ExecuteCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ExecuteCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ExecuteCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExecuteCS_InstanceFunctionAddress, argsSize: ExecuteCS_ParamsSize);
	}

	protected unsafe virtual void ExecuteCS_Implementation()
	{
		CheckDestroyed();
		if (!ExecuteCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:ExecuteCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ExecuteCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ExecuteCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ExecuteCS_FunctionAddress, argsSize: ExecuteCS_ParamsSize);
	}

	[UFunction(Flags = 67240961u)]
	[UMetaPath("/Script/b1.BGWAssetLoaderRequest:Cancel")]
	public unsafe bool Cancel()
	{
		CheckDestroyed();
		if (!Cancel_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWAssetLoaderRequest:Cancel");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(Cancel_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)Cancel_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, Cancel_FunctionAddress, intPtr, Cancel_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, Cancel_ReturnValue_Offset), 0, Cancel_ReturnValue_PropertyAddress.Address);
	}

	static UBGWAssetLoaderRequest()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBGWAssetLoaderRequest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBGWAssetLoaderRequest));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWAssetLoaderRequest");
		WasCanceled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WasCanceled");
		WasCanceled_ParamsSize = NativeReflection.GetFunctionParamsSize(WasCanceled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WasCanceled_ReturnValue_PropertyAddress, WasCanceled_FunctionAddress, "ReturnValue");
		WasCanceled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WasCanceled_FunctionAddress, "ReturnValue");
		WasCanceled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WasCanceled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WasCanceled_IsValid = WasCanceled_FunctionAddress != IntPtr.Zero && WasCanceled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:WasCanceled", WasCanceled_IsValid);
		WaitUntilComplete_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "WaitUntilComplete");
		WaitUntilComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(WaitUntilComplete_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref WaitUntilComplete_Timeout_PropertyAddress, WaitUntilComplete_FunctionAddress, "Timeout");
		WaitUntilComplete_Timeout_Offset = NativeReflectionCached.GetPropertyOffset(WaitUntilComplete_FunctionAddress, "Timeout");
		WaitUntilComplete_Timeout_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitUntilComplete_FunctionAddress, "Timeout", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref WaitUntilComplete_bStartStalledHandles_PropertyAddress, WaitUntilComplete_FunctionAddress, "bStartStalledHandles");
		WaitUntilComplete_bStartStalledHandles_Offset = NativeReflectionCached.GetPropertyOffset(WaitUntilComplete_FunctionAddress, "bStartStalledHandles");
		WaitUntilComplete_bStartStalledHandles_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitUntilComplete_FunctionAddress, "bStartStalledHandles", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref WaitUntilComplete_ReturnValue_PropertyAddress, WaitUntilComplete_FunctionAddress, "ReturnValue");
		WaitUntilComplete_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(WaitUntilComplete_FunctionAddress, "ReturnValue");
		WaitUntilComplete_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(WaitUntilComplete_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		WaitUntilComplete_IsValid = WaitUntilComplete_FunctionAddress != IntPtr.Zero && WaitUntilComplete_Timeout_IsValid && WaitUntilComplete_bStartStalledHandles_IsValid && WaitUntilComplete_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:WaitUntilComplete", WaitUntilComplete_IsValid);
		IsStalled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsStalled");
		IsStalled_ParamsSize = NativeReflection.GetFunctionParamsSize(IsStalled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsStalled_ReturnValue_PropertyAddress, IsStalled_FunctionAddress, "ReturnValue");
		IsStalled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsStalled_FunctionAddress, "ReturnValue");
		IsStalled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsStalled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsStalled_IsValid = IsStalled_FunctionAddress != IntPtr.Zero && IsStalled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:IsStalled", IsStalled_IsValid);
		IsLoadingInProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsLoadingInProgress");
		IsLoadingInProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(IsLoadingInProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsLoadingInProgress_ReturnValue_PropertyAddress, IsLoadingInProgress_FunctionAddress, "ReturnValue");
		IsLoadingInProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsLoadingInProgress_FunctionAddress, "ReturnValue");
		IsLoadingInProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsLoadingInProgress_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsLoadingInProgress_IsValid = IsLoadingInProgress_FunctionAddress != IntPtr.Zero && IsLoadingInProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:IsLoadingInProgress", IsLoadingInProgress_IsValid);
		IsCombinedHandle_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsCombinedHandle");
		IsCombinedHandle_ParamsSize = NativeReflection.GetFunctionParamsSize(IsCombinedHandle_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsCombinedHandle_ReturnValue_PropertyAddress, IsCombinedHandle_FunctionAddress, "ReturnValue");
		IsCombinedHandle_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsCombinedHandle_FunctionAddress, "ReturnValue");
		IsCombinedHandle_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsCombinedHandle_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsCombinedHandle_IsValid = IsCombinedHandle_FunctionAddress != IntPtr.Zero && IsCombinedHandle_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:IsCombinedHandle", IsCombinedHandle_IsValid);
		IsActive_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "IsActive");
		IsActive_ParamsSize = NativeReflection.GetFunctionParamsSize(IsActive_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsActive_ReturnValue_PropertyAddress, IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsActive_FunctionAddress, "ReturnValue");
		IsActive_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsActive_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsActive_IsValid = IsActive_FunctionAddress != IntPtr.Zero && IsActive_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:IsActive", IsActive_IsValid);
		HasLoadCompletedOrStalled_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasLoadCompletedOrStalled");
		HasLoadCompletedOrStalled_ParamsSize = NativeReflection.GetFunctionParamsSize(HasLoadCompletedOrStalled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasLoadCompletedOrStalled_ReturnValue_PropertyAddress, HasLoadCompletedOrStalled_FunctionAddress, "ReturnValue");
		HasLoadCompletedOrStalled_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasLoadCompletedOrStalled_FunctionAddress, "ReturnValue");
		HasLoadCompletedOrStalled_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLoadCompletedOrStalled_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasLoadCompletedOrStalled_IsValid = HasLoadCompletedOrStalled_FunctionAddress != IntPtr.Zero && HasLoadCompletedOrStalled_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:HasLoadCompletedOrStalled", HasLoadCompletedOrStalled_IsValid);
		HasLoadCompleted_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "HasLoadCompleted");
		HasLoadCompleted_ParamsSize = NativeReflection.GetFunctionParamsSize(HasLoadCompleted_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HasLoadCompleted_ReturnValue_PropertyAddress, HasLoadCompleted_FunctionAddress, "ReturnValue");
		HasLoadCompleted_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(HasLoadCompleted_FunctionAddress, "ReturnValue");
		HasLoadCompleted_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(HasLoadCompleted_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		HasLoadCompleted_IsValid = HasLoadCompleted_FunctionAddress != IntPtr.Zero && HasLoadCompleted_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:HasLoadCompleted", HasLoadCompleted_IsValid);
		GetRequestedAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetRequestedAssets");
		GetRequestedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetRequestedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetRequestedAssets_AssetList_PropertyAddress, GetRequestedAssets_FunctionAddress, "AssetList");
		GetRequestedAssets_AssetList_Offset = NativeReflectionCached.GetPropertyOffset(GetRequestedAssets_FunctionAddress, "AssetList");
		GetRequestedAssets_AssetList_IsValid = NativeReflectionCached.ValidatePropertyClass(GetRequestedAssets_FunctionAddress, "AssetList", Classes.FArrayProperty);
		GetRequestedAssets_IsValid = GetRequestedAssets_FunctionAddress != IntPtr.Zero && GetRequestedAssets_AssetList_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetRequestedAssets", GetRequestedAssets_IsValid);
		GetProgress_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetProgress");
		GetProgress_ParamsSize = NativeReflection.GetFunctionParamsSize(GetProgress_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetProgress_ReturnValue_PropertyAddress, GetProgress_FunctionAddress, "ReturnValue");
		GetProgress_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetProgress_FunctionAddress, "ReturnValue");
		GetProgress_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetProgress_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetProgress_IsValid = GetProgress_FunctionAddress != IntPtr.Zero && GetProgress_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetProgress", GetProgress_IsValid);
		GetPriority_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPriority");
		GetPriority_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPriority_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPriority_ReturnValue_PropertyAddress, GetPriority_FunctionAddress, "ReturnValue");
		GetPriority_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPriority_FunctionAddress, "ReturnValue");
		GetPriority_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPriority_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPriority_IsValid = GetPriority_FunctionAddress != IntPtr.Zero && GetPriority_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetPriority", GetPriority_IsValid);
		GetLoadedCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLoadedCount");
		GetLoadedCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoadedCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoadedCount_LoadedCount_PropertyAddress, GetLoadedCount_FunctionAddress, "LoadedCount");
		GetLoadedCount_LoadedCount_Offset = NativeReflectionCached.GetPropertyOffset(GetLoadedCount_FunctionAddress, "LoadedCount");
		GetLoadedCount_LoadedCount_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoadedCount_FunctionAddress, "LoadedCount", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetLoadedCount_RequestedCount_PropertyAddress, GetLoadedCount_FunctionAddress, "RequestedCount");
		GetLoadedCount_RequestedCount_Offset = NativeReflectionCached.GetPropertyOffset(GetLoadedCount_FunctionAddress, "RequestedCount");
		GetLoadedCount_RequestedCount_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoadedCount_FunctionAddress, "RequestedCount", Classes.FIntProperty);
		GetLoadedCount_IsValid = GetLoadedCount_FunctionAddress != IntPtr.Zero && GetLoadedCount_LoadedCount_IsValid && GetLoadedCount_RequestedCount_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetLoadedCount", GetLoadedCount_IsValid);
		GetLoadedAssets_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLoadedAssets");
		GetLoadedAssets_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLoadedAssets_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLoadedAssets_LoadedAssets_PropertyAddress, GetLoadedAssets_FunctionAddress, "LoadedAssets");
		GetLoadedAssets_LoadedAssets_Offset = NativeReflectionCached.GetPropertyOffset(GetLoadedAssets_FunctionAddress, "LoadedAssets");
		GetLoadedAssets_LoadedAssets_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLoadedAssets_FunctionAddress, "LoadedAssets", Classes.FArrayProperty);
		GetLoadedAssets_IsValid = GetLoadedAssets_FunctionAddress != IntPtr.Zero && GetLoadedAssets_LoadedAssets_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetLoadedAssets", GetLoadedAssets_IsValid);
		GetDebugName_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDebugName");
		GetDebugName_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugName_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugName_ReturnValue_PropertyAddress, GetDebugName_FunctionAddress, "ReturnValue");
		GetDebugName_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugName_FunctionAddress, "ReturnValue");
		GetDebugName_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugName_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDebugName_IsValid = GetDebugName_FunctionAddress != IntPtr.Zero && GetDebugName_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:GetDebugName", GetDebugName_IsValid);
		ExecuteCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ExecuteCS");
		ExecuteCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ExecuteCS_FunctionAddress);
		ExecuteCS_IsValid = ExecuteCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:ExecuteCS", ExecuteCS_IsValid);
		Cancel_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "Cancel");
		Cancel_ParamsSize = NativeReflection.GetFunctionParamsSize(Cancel_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref Cancel_ReturnValue_PropertyAddress, Cancel_FunctionAddress, "ReturnValue");
		Cancel_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(Cancel_FunctionAddress, "ReturnValue");
		Cancel_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(Cancel_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		Cancel_IsValid = Cancel_FunctionAddress != IntPtr.Zero && Cancel_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWAssetLoaderRequest:Cancel", Cancel_IsValid);
	}
}
