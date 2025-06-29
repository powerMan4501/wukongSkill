using System;
using System.Runtime.CompilerServices;
using UnrealEngine.NetCore;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938024uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.GameInstance", "Engine", UnrealModuleType.Engine)]
public class UGameInstance : UObject
{
	private static bool OnPawnControllerChangedDelegates_IsValid;

	private static int OnPawnControllerChangedDelegates_Offset;

	private FOnPawnControllerChanged OnPawnControllerChangedDelegates_DelegateCached;

	private static bool ReceiveShutdown_IsValid;

	private IntPtr ReceiveShutdown_InstanceFunctionAddress;

	private static IntPtr ReceiveShutdown_FunctionAddress;

	private static int ReceiveShutdown_ParamsSize;

	private static bool ReceiveInit_IsValid;

	private IntPtr ReceiveInit_InstanceFunctionAddress;

	private static IntPtr ReceiveInit_FunctionAddress;

	private static int ReceiveInit_ParamsSize;

	private static bool HandleTravelError_IsValid;

	private IntPtr HandleTravelError_InstanceFunctionAddress;

	private static IntPtr HandleTravelError_FunctionAddress;

	private static int HandleTravelError_ParamsSize;

	private static bool HandleTravelError_FailureType_IsValid;

	private static FFieldAddress HandleTravelError_FailureType_PropertyAddress;

	private static int HandleTravelError_FailureType_Offset;

	private static bool HandleNetworkError_IsValid;

	private IntPtr HandleNetworkError_InstanceFunctionAddress;

	private static IntPtr HandleNetworkError_FunctionAddress;

	private static int HandleNetworkError_ParamsSize;

	private static bool HandleNetworkError_FailureType_IsValid;

	private static FFieldAddress HandleNetworkError_FailureType_PropertyAddress;

	private static int HandleNetworkError_FailureType_Offset;

	private static bool HandleNetworkError_bIsServer_IsValid;

	private static FFieldAddress HandleNetworkError_bIsServer_PropertyAddress;

	private static int HandleNetworkError_bIsServer_Offset;

	[UProperty(Flags = (PropFlags)9015995616723456uL)]
	[UMetaPath("/Script/Engine.GameInstance:OnPawnControllerChangedDelegates")]
	protected FOnPawnControllerChanged OnPawnControllerChangedDelegates
	{
		get
		{
			CheckDestroyed();
			if (!OnPawnControllerChangedDelegates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.GameInstance:OnPawnControllerChangedDelegates");
				return new FOnPawnControllerChanged();
			}
			if (OnPawnControllerChangedDelegates_DelegateCached == null)
			{
				OnPawnControllerChangedDelegates_DelegateCached = new FOnPawnControllerChanged();
				OnPawnControllerChangedDelegates_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnPawnControllerChangedDelegates_Offset));
			}
			return OnPawnControllerChangedDelegates_DelegateCached;
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.GameInstance:ReceiveShutdown")]
	public unsafe void ReceiveShutdown()
	{
		CheckDestroyed();
		if (!ReceiveShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:ReceiveShutdown");
			return;
		}
		if (ReceiveShutdown_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveShutdown_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveShutdown");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveShutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveShutdown_InstanceFunctionAddress, argsSize: ReceiveShutdown_ParamsSize);
	}

	protected unsafe virtual void ReceiveShutdown_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveShutdown_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:ReceiveShutdown");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveShutdown_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveShutdown_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveShutdown_FunctionAddress, argsSize: ReceiveShutdown_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.GameInstance:ReceiveInit")]
	public unsafe void ReceiveInit()
	{
		CheckDestroyed();
		if (!ReceiveInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:ReceiveInit");
			return;
		}
		if (ReceiveInit_InstanceFunctionAddress == IntPtr.Zero)
		{
			ReceiveInit_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ReceiveInit");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveInit_InstanceFunctionAddress, argsSize: ReceiveInit_ParamsSize);
	}

	protected unsafe virtual void ReceiveInit_Implementation()
	{
		CheckDestroyed();
		if (!ReceiveInit_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:ReceiveInit");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ReceiveInit_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ReceiveInit_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ReceiveInit_FunctionAddress, argsSize: ReceiveInit_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.GameInstance:HandleTravelError")]
	public unsafe void HandleTravelError(ETravelFailure FailureType)
	{
		CheckDestroyed();
		if (!HandleTravelError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:HandleTravelError");
			return;
		}
		if (HandleTravelError_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleTravelError_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleTravelError");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleTravelError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleTravelError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETravelFailure>.ToNative(IntPtr.Add(intPtr, HandleTravelError_FailureType_Offset), 0, HandleTravelError_FailureType_PropertyAddress.Address, FailureType);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleTravelError_InstanceFunctionAddress, intPtr, HandleTravelError_ParamsSize);
	}

	protected unsafe virtual void HandleTravelError_Implementation(ETravelFailure FailureType)
	{
		CheckDestroyed();
		if (!HandleTravelError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:HandleTravelError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleTravelError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleTravelError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ETravelFailure>.ToNative(IntPtr.Add(intPtr, HandleTravelError_FailureType_Offset), 0, HandleTravelError_FailureType_PropertyAddress.Address, FailureType);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleTravelError_FunctionAddress, intPtr, HandleTravelError_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/Engine.GameInstance:HandleNetworkError")]
	public unsafe void HandleNetworkError(ENetworkFailure FailureType, bool bIsServer)
	{
		CheckDestroyed();
		if (!HandleNetworkError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:HandleNetworkError");
			return;
		}
		if (HandleNetworkError_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleNetworkError_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleNetworkError");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleNetworkError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleNetworkError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENetworkFailure>.ToNative(IntPtr.Add(intPtr, HandleNetworkError_FailureType_Offset), 0, HandleNetworkError_FailureType_PropertyAddress.Address, FailureType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HandleNetworkError_bIsServer_Offset), 0, HandleNetworkError_bIsServer_PropertyAddress.Address, bIsServer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleNetworkError_InstanceFunctionAddress, intPtr, HandleNetworkError_ParamsSize);
	}

	protected unsafe virtual void HandleNetworkError_Implementation(ENetworkFailure FailureType, bool bIsServer)
	{
		CheckDestroyed();
		if (!HandleNetworkError_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.GameInstance:HandleNetworkError");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleNetworkError_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleNetworkError_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<ENetworkFailure>.ToNative(IntPtr.Add(intPtr, HandleNetworkError_FailureType_Offset), 0, HandleNetworkError_FailureType_PropertyAddress.Address, FailureType);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, HandleNetworkError_bIsServer_Offset), 0, HandleNetworkError_bIsServer_PropertyAddress.Address, bIsServer);
		NativeReflection.InvokeFunctionOptimized(base.Address, HandleNetworkError_FunctionAddress, intPtr, HandleNetworkError_ParamsSize);
	}

	static UGameInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.GameInstance");
		OnPawnControllerChangedDelegates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnPawnControllerChangedDelegates");
		OnPawnControllerChangedDelegates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnPawnControllerChangedDelegates", Classes.FMulticastDelegateProperty);
		ReceiveShutdown_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveShutdown");
		ReceiveShutdown_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveShutdown_FunctionAddress);
		ReceiveShutdown_IsValid = ReceiveShutdown_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameInstance:ReceiveShutdown", ReceiveShutdown_IsValid);
		ReceiveInit_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveInit");
		ReceiveInit_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveInit_FunctionAddress);
		ReceiveInit_IsValid = ReceiveInit_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameInstance:ReceiveInit", ReceiveInit_IsValid);
		HandleTravelError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleTravelError");
		HandleTravelError_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleTravelError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleTravelError_FailureType_PropertyAddress, HandleTravelError_FunctionAddress, "FailureType");
		HandleTravelError_FailureType_Offset = NativeReflectionCached.GetPropertyOffset(HandleTravelError_FunctionAddress, "FailureType");
		HandleTravelError_FailureType_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleTravelError_FunctionAddress, "FailureType", Classes.FByteProperty);
		HandleTravelError_IsValid = HandleTravelError_FunctionAddress != IntPtr.Zero && HandleTravelError_FailureType_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameInstance:HandleTravelError", HandleTravelError_IsValid);
		HandleNetworkError_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleNetworkError");
		HandleNetworkError_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleNetworkError_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref HandleNetworkError_FailureType_PropertyAddress, HandleNetworkError_FunctionAddress, "FailureType");
		HandleNetworkError_FailureType_Offset = NativeReflectionCached.GetPropertyOffset(HandleNetworkError_FunctionAddress, "FailureType");
		HandleNetworkError_FailureType_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleNetworkError_FunctionAddress, "FailureType", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref HandleNetworkError_bIsServer_PropertyAddress, HandleNetworkError_FunctionAddress, "bIsServer");
		HandleNetworkError_bIsServer_Offset = NativeReflectionCached.GetPropertyOffset(HandleNetworkError_FunctionAddress, "bIsServer");
		HandleNetworkError_bIsServer_IsValid = NativeReflectionCached.ValidatePropertyClass(HandleNetworkError_FunctionAddress, "bIsServer", Classes.FBoolProperty);
		HandleNetworkError_IsValid = HandleNetworkError_FunctionAddress != IntPtr.Zero && HandleNetworkError_FailureType_IsValid && HandleNetworkError_bIsServer_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.GameInstance:HandleNetworkError", HandleNetworkError_IsValid);
	}
}
