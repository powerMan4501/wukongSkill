using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWGameState", "b1", UnrealModuleType.Game)]
public class ABGWGameState : AGameState
{
	private static bool BGSDataComp_IsValid;

	private static int BGSDataComp_Offset;

	private static bool PostInitializeComponentsCS_IsValid;

	private IntPtr PostInitializeComponentsCS_InstanceFunctionAddress;

	private static IntPtr PostInitializeComponentsCS_FunctionAddress;

	private static int PostInitializeComponentsCS_ParamsSize;

	private static bool OnTickDispatchEventCS_IsValid;

	private IntPtr OnTickDispatchEventCS_InstanceFunctionAddress;

	private static IntPtr OnTickDispatchEventCS_FunctionAddress;

	private static int OnTickDispatchEventCS_ParamsSize;

	private static bool OnTickDispatchEventCS_DeltaTime_IsValid;

	private static FFieldAddress OnTickDispatchEventCS_DeltaTime_PropertyAddress;

	private static int OnTickDispatchEventCS_DeltaTime_Offset;

	private static bool OnPostTickDispatchEventCS_IsValid;

	private IntPtr OnPostTickDispatchEventCS_InstanceFunctionAddress;

	private static IntPtr OnPostTickDispatchEventCS_FunctionAddress;

	private static int OnPostTickDispatchEventCS_ParamsSize;

	private static bool IsGSEventDebuggerOpenCS_IsValid;

	private IntPtr IsGSEventDebuggerOpenCS_InstanceFunctionAddress;

	private static IntPtr IsGSEventDebuggerOpenCS_FunctionAddress;

	private static int IsGSEventDebuggerOpenCS_ParamsSize;

	private static bool IsGSEventDebuggerOpenCS_ReturnValue_IsValid;

	private static FFieldAddress IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress;

	private static int IsGSEventDebuggerOpenCS_ReturnValue_Offset;

	private static bool HandleMatchIsWaitingToStartCS_IsValid;

	private IntPtr HandleMatchIsWaitingToStartCS_InstanceFunctionAddress;

	private static IntPtr HandleMatchIsWaitingToStartCS_FunctionAddress;

	private static int HandleMatchIsWaitingToStartCS_ParamsSize;

	private static bool HandleMatchHasStartedCS_IsValid;

	private IntPtr HandleMatchHasStartedCS_InstanceFunctionAddress;

	private static IntPtr HandleMatchHasStartedCS_FunctionAddress;

	private static int HandleMatchHasStartedCS_ParamsSize;

	private static bool HandleMatchHasEndedCS_IsValid;

	private IntPtr HandleMatchHasEndedCS_InstanceFunctionAddress;

	private static IntPtr HandleMatchHasEndedCS_FunctionAddress;

	private static int HandleMatchHasEndedCS_ParamsSize;

	private static bool HandleLeavingMapCS_IsValid;

	private IntPtr HandleLeavingMapCS_InstanceFunctionAddress;

	private static IntPtr HandleLeavingMapCS_FunctionAddress;

	private static int HandleLeavingMapCS_ParamsSize;

	private static bool HandleBeginPlayCS_IsValid;

	private IntPtr HandleBeginPlayCS_InstanceFunctionAddress;

	private static IntPtr HandleBeginPlayCS_FunctionAddress;

	private static int HandleBeginPlayCS_ParamsSize;

	private static bool BeginPlayCS_IsValid;

	private IntPtr BeginPlayCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayCS_FunctionAddress;

	private static int BeginPlayCS_ParamsSize;

	[UProperty(Flags = (PropFlags)11267864955200012uL)]
	[UMetaPath("/Script/b1.BGWGameState:BGSDataComp")]
	protected UActorDataContainer BGSDataComp
	{
		get
		{
			CheckDestroyed();
			if (!BGSDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWGameState:BGSDataComp");
				return null;
			}
			return UObjectMarshaler<UActorDataContainer>.FromNative(IntPtr.Add(base.Address, BGSDataComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BGSDataComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.BGWGameState:BGSDataComp");
			}
			else
			{
				UObjectMarshaler<UActorDataContainer>.ToNative(IntPtr.Add(base.Address, BGSDataComp_Offset), value);
			}
		}
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameState:PostInitializeComponentsCS")]
	public unsafe void PostInitializeComponentsCS()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:PostInitializeComponentsCS");
			return;
		}
		if (PostInitializeComponentsCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitializeComponentsCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitializeComponentsCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_InstanceFunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	protected unsafe virtual void PostInitializeComponentsCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitializeComponentsCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:PostInitializeComponentsCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitializeComponentsCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitializeComponentsCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitializeComponentsCS_FunctionAddress, argsSize: PostInitializeComponentsCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameState:OnTickDispatchEventCS")]
	public unsafe void OnTickDispatchEventCS(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnTickDispatchEventCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:OnTickDispatchEventCS");
			return;
		}
		if (OnTickDispatchEventCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnTickDispatchEventCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnTickDispatchEventCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTickDispatchEventCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTickDispatchEventCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTickDispatchEventCS_DeltaTime_Offset), 0, OnTickDispatchEventCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTickDispatchEventCS_InstanceFunctionAddress, intPtr, OnTickDispatchEventCS_ParamsSize);
	}

	protected unsafe virtual void OnTickDispatchEventCS_Implementation(float DeltaTime)
	{
		CheckDestroyed();
		if (!OnTickDispatchEventCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:OnTickDispatchEventCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnTickDispatchEventCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnTickDispatchEventCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, OnTickDispatchEventCS_DeltaTime_Offset), 0, OnTickDispatchEventCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		NativeReflection.InvokeFunctionOptimized(base.Address, OnTickDispatchEventCS_FunctionAddress, intPtr, OnTickDispatchEventCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameState:OnPostTickDispatchEventCS")]
	public unsafe void OnPostTickDispatchEventCS()
	{
		CheckDestroyed();
		if (!OnPostTickDispatchEventCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:OnPostTickDispatchEventCS");
			return;
		}
		if (OnPostTickDispatchEventCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnPostTickDispatchEventCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnPostTickDispatchEventCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostTickDispatchEventCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostTickDispatchEventCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostTickDispatchEventCS_InstanceFunctionAddress, argsSize: OnPostTickDispatchEventCS_ParamsSize);
	}

	protected unsafe virtual void OnPostTickDispatchEventCS_Implementation()
	{
		CheckDestroyed();
		if (!OnPostTickDispatchEventCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:OnPostTickDispatchEventCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnPostTickDispatchEventCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnPostTickDispatchEventCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnPostTickDispatchEventCS_FunctionAddress, argsSize: OnPostTickDispatchEventCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameState:IsGSEventDebuggerOpenCS")]
	public unsafe bool IsGSEventDebuggerOpenCS()
	{
		CheckDestroyed();
		if (!IsGSEventDebuggerOpenCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:IsGSEventDebuggerOpenCS");
			return false;
		}
		if (IsGSEventDebuggerOpenCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			IsGSEventDebuggerOpenCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "IsGSEventDebuggerOpenCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGSEventDebuggerOpenCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGSEventDebuggerOpenCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsGSEventDebuggerOpenCS_InstanceFunctionAddress, intPtr, IsGSEventDebuggerOpenCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGSEventDebuggerOpenCS_ReturnValue_Offset), 0, IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress.Address);
	}

	protected unsafe virtual bool IsGSEventDebuggerOpenCS_Implementation()
	{
		CheckDestroyed();
		if (!IsGSEventDebuggerOpenCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:IsGSEventDebuggerOpenCS");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsGSEventDebuggerOpenCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsGSEventDebuggerOpenCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsGSEventDebuggerOpenCS_FunctionAddress, intPtr, IsGSEventDebuggerOpenCS_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsGSEventDebuggerOpenCS_ReturnValue_Offset), 0, IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWGameState:HandleMatchIsWaitingToStartCS")]
	protected unsafe void HandleMatchIsWaitingToStartCS()
	{
		CheckDestroyed();
		if (!HandleMatchIsWaitingToStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchIsWaitingToStartCS");
			return;
		}
		if (HandleMatchIsWaitingToStartCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleMatchIsWaitingToStartCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleMatchIsWaitingToStartCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchIsWaitingToStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchIsWaitingToStartCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchIsWaitingToStartCS_InstanceFunctionAddress, argsSize: HandleMatchIsWaitingToStartCS_ParamsSize);
	}

	protected unsafe virtual void HandleMatchIsWaitingToStartCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleMatchIsWaitingToStartCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchIsWaitingToStartCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchIsWaitingToStartCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchIsWaitingToStartCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchIsWaitingToStartCS_FunctionAddress, argsSize: HandleMatchIsWaitingToStartCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWGameState:HandleMatchHasStartedCS")]
	protected unsafe void HandleMatchHasStartedCS()
	{
		CheckDestroyed();
		if (!HandleMatchHasStartedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchHasStartedCS");
			return;
		}
		if (HandleMatchHasStartedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleMatchHasStartedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleMatchHasStartedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasStartedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasStartedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasStartedCS_InstanceFunctionAddress, argsSize: HandleMatchHasStartedCS_ParamsSize);
	}

	protected unsafe virtual void HandleMatchHasStartedCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleMatchHasStartedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchHasStartedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasStartedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasStartedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasStartedCS_FunctionAddress, argsSize: HandleMatchHasStartedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWGameState:HandleMatchHasEndedCS")]
	protected unsafe void HandleMatchHasEndedCS()
	{
		CheckDestroyed();
		if (!HandleMatchHasEndedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchHasEndedCS");
			return;
		}
		if (HandleMatchHasEndedCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleMatchHasEndedCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleMatchHasEndedCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasEndedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasEndedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasEndedCS_InstanceFunctionAddress, argsSize: HandleMatchHasEndedCS_ParamsSize);
	}

	protected unsafe virtual void HandleMatchHasEndedCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleMatchHasEndedCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleMatchHasEndedCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleMatchHasEndedCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleMatchHasEndedCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleMatchHasEndedCS_FunctionAddress, argsSize: HandleMatchHasEndedCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWGameState:HandleLeavingMapCS")]
	protected unsafe void HandleLeavingMapCS()
	{
		CheckDestroyed();
		if (!HandleLeavingMapCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleLeavingMapCS");
			return;
		}
		if (HandleLeavingMapCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleLeavingMapCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleLeavingMapCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleLeavingMapCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleLeavingMapCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleLeavingMapCS_InstanceFunctionAddress, argsSize: HandleLeavingMapCS_ParamsSize);
	}

	protected unsafe virtual void HandleLeavingMapCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleLeavingMapCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleLeavingMapCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleLeavingMapCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleLeavingMapCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleLeavingMapCS_FunctionAddress, argsSize: HandleLeavingMapCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWGameState:HandleBeginPlayCS")]
	protected unsafe void HandleBeginPlayCS()
	{
		CheckDestroyed();
		if (!HandleBeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleBeginPlayCS");
			return;
		}
		if (HandleBeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			HandleBeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "HandleBeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleBeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleBeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleBeginPlayCS_InstanceFunctionAddress, argsSize: HandleBeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void HandleBeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!HandleBeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:HandleBeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(HandleBeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)HandleBeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: HandleBeginPlayCS_FunctionAddress, argsSize: HandleBeginPlayCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BGWGameState:BeginPlayCS")]
	public unsafe void BeginPlayCS()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:BeginPlayCS");
			return;
		}
		if (BeginPlayCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_InstanceFunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWGameState:BeginPlayCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayCS_FunctionAddress, argsSize: BeginPlayCS_ParamsSize);
	}

	static ABGWGameState()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWGameState)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWGameState));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1.BGWGameState");
		BGSDataComp_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BGSDataComp");
		BGSDataComp_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BGSDataComp", Classes.FObjectProperty);
		PostInitializeComponentsCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "PostInitializeComponentsCS");
		PostInitializeComponentsCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitializeComponentsCS_FunctionAddress);
		PostInitializeComponentsCS_IsValid = PostInitializeComponentsCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:PostInitializeComponentsCS", PostInitializeComponentsCS_IsValid);
		OnTickDispatchEventCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTickDispatchEventCS");
		OnTickDispatchEventCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTickDispatchEventCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref OnTickDispatchEventCS_DeltaTime_PropertyAddress, OnTickDispatchEventCS_FunctionAddress, "DeltaTime");
		OnTickDispatchEventCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(OnTickDispatchEventCS_FunctionAddress, "DeltaTime");
		OnTickDispatchEventCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(OnTickDispatchEventCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTickDispatchEventCS_IsValid = OnTickDispatchEventCS_FunctionAddress != IntPtr.Zero && OnTickDispatchEventCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:OnTickDispatchEventCS", OnTickDispatchEventCS_IsValid);
		OnPostTickDispatchEventCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnPostTickDispatchEventCS");
		OnPostTickDispatchEventCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnPostTickDispatchEventCS_FunctionAddress);
		OnPostTickDispatchEventCS_IsValid = OnPostTickDispatchEventCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:OnPostTickDispatchEventCS", OnPostTickDispatchEventCS_IsValid);
		IsGSEventDebuggerOpenCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsGSEventDebuggerOpenCS");
		IsGSEventDebuggerOpenCS_ParamsSize = NativeReflection.GetFunctionParamsSize(IsGSEventDebuggerOpenCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsGSEventDebuggerOpenCS_ReturnValue_PropertyAddress, IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue");
		IsGSEventDebuggerOpenCS_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue");
		IsGSEventDebuggerOpenCS_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsGSEventDebuggerOpenCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsGSEventDebuggerOpenCS_IsValid = IsGSEventDebuggerOpenCS_FunctionAddress != IntPtr.Zero && IsGSEventDebuggerOpenCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:IsGSEventDebuggerOpenCS", IsGSEventDebuggerOpenCS_IsValid);
		HandleMatchIsWaitingToStartCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchIsWaitingToStartCS");
		HandleMatchIsWaitingToStartCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchIsWaitingToStartCS_FunctionAddress);
		HandleMatchIsWaitingToStartCS_IsValid = HandleMatchIsWaitingToStartCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:HandleMatchIsWaitingToStartCS", HandleMatchIsWaitingToStartCS_IsValid);
		HandleMatchHasStartedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchHasStartedCS");
		HandleMatchHasStartedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchHasStartedCS_FunctionAddress);
		HandleMatchHasStartedCS_IsValid = HandleMatchHasStartedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:HandleMatchHasStartedCS", HandleMatchHasStartedCS_IsValid);
		HandleMatchHasEndedCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleMatchHasEndedCS");
		HandleMatchHasEndedCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleMatchHasEndedCS_FunctionAddress);
		HandleMatchHasEndedCS_IsValid = HandleMatchHasEndedCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:HandleMatchHasEndedCS", HandleMatchHasEndedCS_IsValid);
		HandleLeavingMapCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleLeavingMapCS");
		HandleLeavingMapCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleLeavingMapCS_FunctionAddress);
		HandleLeavingMapCS_IsValid = HandleLeavingMapCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:HandleLeavingMapCS", HandleLeavingMapCS_IsValid);
		HandleBeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HandleBeginPlayCS");
		HandleBeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(HandleBeginPlayCS_FunctionAddress);
		HandleBeginPlayCS_IsValid = HandleBeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:HandleBeginPlayCS", HandleBeginPlayCS_IsValid);
		BeginPlayCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayCS");
		BeginPlayCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayCS_FunctionAddress);
		BeginPlayCS_IsValid = BeginPlayCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWGameState:BeginPlayCS", BeginPlayCS_IsValid);
	}
}
