using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/b1.BaseActorComp", "b1", UnrealModuleType.Game)]
public class UBaseActorComp : UActorComponent
{
	private static bool PostInitPropertiesCS_IsValid;

	private IntPtr PostInitPropertiesCS_InstanceFunctionAddress;

	private static IntPtr PostInitPropertiesCS_FunctionAddress;

	private static int PostInitPropertiesCS_ParamsSize;

	private static bool OnUnregisterCS_IsValid;

	private IntPtr OnUnregisterCS_InstanceFunctionAddress;

	private static IntPtr OnUnregisterCS_FunctionAddress;

	private static int OnUnregisterCS_ParamsSize;

	private static bool OnRegisterCS_IsValid;

	private IntPtr OnRegisterCS_InstanceFunctionAddress;

	private static IntPtr OnRegisterCS_FunctionAddress;

	private static int OnRegisterCS_ParamsSize;

	private static bool OnAttachInCS_IsValid;

	private IntPtr OnAttachInCS_InstanceFunctionAddress;

	private static IntPtr OnAttachInCS_FunctionAddress;

	private static int OnAttachInCS_ParamsSize;

	private static bool InitializeCS_IsValid;

	private IntPtr InitializeCS_InstanceFunctionAddress;

	private static IntPtr InitializeCS_FunctionAddress;

	private static int InitializeCS_ParamsSize;

	private static bool GetLogLvl_IsValid;

	private static IntPtr GetLogLvl_FunctionAddress;

	private static int GetLogLvl_ParamsSize;

	private static bool GetLogLvl_ReturnValue_IsValid;

	private static FFieldAddress GetLogLvl_ReturnValue_PropertyAddress;

	private static int GetLogLvl_ReturnValue_Offset;

	private static bool GetDebugID_IsValid;

	private static IntPtr GetDebugID_FunctionAddress;

	private static int GetDebugID_ParamsSize;

	private static bool GetDebugID_ReturnValue_IsValid;

	private static FFieldAddress GetDebugID_ReturnValue_PropertyAddress;

	private static int GetDebugID_ReturnValue_Offset;

	private static bool EndPlayInCS_IsValid;

	private IntPtr EndPlayInCS_InstanceFunctionAddress;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static bool BeginPlayInCS_IsValid;

	private IntPtr BeginPlayInCS_InstanceFunctionAddress;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool ApplyWorldOffsetCS_IsValid;

	private IntPtr ApplyWorldOffsetCS_InstanceFunctionAddress;

	private static IntPtr ApplyWorldOffsetCS_FunctionAddress;

	private static int ApplyWorldOffsetCS_ParamsSize;

	private static bool ApplyWorldOffsetCS_InOffset_IsValid;

	private static FFieldAddress ApplyWorldOffsetCS_InOffset_PropertyAddress;

	private static int ApplyWorldOffsetCS_InOffset_Offset;

	private static bool ApplyWorldOffsetCS_bWorldShift_IsValid;

	private static FFieldAddress ApplyWorldOffsetCS_bWorldShift_PropertyAddress;

	private static int ApplyWorldOffsetCS_bWorldShift_Offset;

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:PostInitPropertiesCS")]
	public unsafe void PostInitPropertiesCS()
	{
		CheckDestroyed();
		if (!PostInitPropertiesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:PostInitPropertiesCS");
			return;
		}
		if (PostInitPropertiesCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			PostInitPropertiesCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "PostInitPropertiesCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitPropertiesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitPropertiesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitPropertiesCS_InstanceFunctionAddress, argsSize: PostInitPropertiesCS_ParamsSize);
	}

	protected unsafe virtual void PostInitPropertiesCS_Implementation()
	{
		CheckDestroyed();
		if (!PostInitPropertiesCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:PostInitPropertiesCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(PostInitPropertiesCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)PostInitPropertiesCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: PostInitPropertiesCS_FunctionAddress, argsSize: PostInitPropertiesCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:OnUnregisterCS")]
	public unsafe void OnUnregisterCS()
	{
		CheckDestroyed();
		if (!OnUnregisterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnUnregisterCS");
			return;
		}
		if (OnUnregisterCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnUnregisterCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnUnregisterCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUnregisterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUnregisterCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnUnregisterCS_InstanceFunctionAddress, argsSize: OnUnregisterCS_ParamsSize);
	}

	protected unsafe virtual void OnUnregisterCS_Implementation()
	{
		CheckDestroyed();
		if (!OnUnregisterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnUnregisterCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnUnregisterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnUnregisterCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnUnregisterCS_FunctionAddress, argsSize: OnUnregisterCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:OnRegisterCS")]
	public unsafe void OnRegisterCS()
	{
		CheckDestroyed();
		if (!OnRegisterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnRegisterCS");
			return;
		}
		if (OnRegisterCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnRegisterCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnRegisterCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRegisterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRegisterCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRegisterCS_InstanceFunctionAddress, argsSize: OnRegisterCS_ParamsSize);
	}

	protected unsafe virtual void OnRegisterCS_Implementation()
	{
		CheckDestroyed();
		if (!OnRegisterCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnRegisterCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnRegisterCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnRegisterCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnRegisterCS_FunctionAddress, argsSize: OnRegisterCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:OnAttachInCS")]
	public unsafe void OnAttachInCS()
	{
		CheckDestroyed();
		if (!OnAttachInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnAttachInCS");
			return;
		}
		if (OnAttachInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			OnAttachInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "OnAttachInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAttachInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAttachInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnAttachInCS_InstanceFunctionAddress, argsSize: OnAttachInCS_ParamsSize);
	}

	protected unsafe virtual void OnAttachInCS_Implementation()
	{
		CheckDestroyed();
		if (!OnAttachInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:OnAttachInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(OnAttachInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnAttachInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: OnAttachInCS_FunctionAddress, argsSize: OnAttachInCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:InitializeCS")]
	public unsafe void InitializeCS()
	{
		CheckDestroyed();
		if (!InitializeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:InitializeCS");
			return;
		}
		if (InitializeCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitializeCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitializeCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitializeCS_InstanceFunctionAddress, argsSize: InitializeCS_ParamsSize);
	}

	protected unsafe virtual void InitializeCS_Implementation()
	{
		CheckDestroyed();
		if (!InitializeCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:InitializeCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitializeCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitializeCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitializeCS_FunctionAddress, argsSize: InitializeCS_ParamsSize);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BaseActorComp:GetLogLvl")]
	public unsafe int GetLogLvl()
	{
		CheckDestroyed();
		if (!GetLogLvl_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:GetLogLvl");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetLogLvl_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetLogLvl_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetLogLvl_FunctionAddress, intPtr, GetLogLvl_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetLogLvl_ReturnValue_Offset), 0, GetLogLvl_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 335676417u)]
	[UMetaPath("/Script/b1.BaseActorComp:GetDebugID")]
	public unsafe int GetDebugID()
	{
		CheckDestroyed();
		if (!GetDebugID_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:GetDebugID");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetDebugID_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetDebugID_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetDebugID_FunctionAddress, intPtr, GetDebugID_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetDebugID_ReturnValue_Offset), 0, GetDebugID_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:EndPlayInCS")]
	public unsafe void EndPlayInCS(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!EndPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:EndPlayInCS");
			return;
		}
		if (EndPlayInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			EndPlayInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "EndPlayInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndPlayInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndPlayInCS_InstanceFunctionAddress, intPtr, EndPlayInCS_ParamsSize);
	}

	protected unsafe virtual void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		CheckDestroyed();
		if (!EndPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:EndPlayInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(EndPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)EndPlayInCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EEndPlayReason>.ToNative(IntPtr.Add(intPtr, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address, EndPlayReason);
		NativeReflection.InvokeFunctionOptimized(base.Address, EndPlayInCS_FunctionAddress, intPtr, EndPlayInCS_ParamsSize);
	}

	[UFunction(Flags = 134350848u)]
	[UMetaPath("/Script/b1.BaseActorComp:BeginPlayInCS")]
	public unsafe void BeginPlayInCS()
	{
		CheckDestroyed();
		if (!BeginPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:BeginPlayInCS");
			return;
		}
		if (BeginPlayInCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			BeginPlayInCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "BeginPlayInCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayInCS_InstanceFunctionAddress, argsSize: BeginPlayInCS_ParamsSize);
	}

	protected unsafe virtual void BeginPlayInCS_Implementation()
	{
		CheckDestroyed();
		if (!BeginPlayInCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:BeginPlayInCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BeginPlayInCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BeginPlayInCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: BeginPlayInCS_FunctionAddress, argsSize: BeginPlayInCS_ParamsSize);
	}

	[UFunction(Flags = 146933760u)]
	[UMetaPath("/Script/b1.BaseActorComp:ApplyWorldOffsetCS")]
	public unsafe void ApplyWorldOffsetCS(FVector InOffset, bool bWorldShift)
	{
		CheckDestroyed();
		if (!ApplyWorldOffsetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:ApplyWorldOffsetCS");
			return;
		}
		if (ApplyWorldOffsetCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ApplyWorldOffsetCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ApplyWorldOffsetCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyWorldOffsetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyWorldOffsetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_InOffset_Offset), 0, ApplyWorldOffsetCS_InOffset_PropertyAddress.Address, InOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address, bWorldShift);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyWorldOffsetCS_InstanceFunctionAddress, intPtr, ApplyWorldOffsetCS_ParamsSize);
	}

	protected unsafe virtual void ApplyWorldOffsetCS_Implementation(FVector InOffset, bool bWorldShift)
	{
		CheckDestroyed();
		if (!ApplyWorldOffsetCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BaseActorComp:ApplyWorldOffsetCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ApplyWorldOffsetCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ApplyWorldOffsetCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_InOffset_Offset), 0, ApplyWorldOffsetCS_InOffset_PropertyAddress.Address, InOffset);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ApplyWorldOffsetCS_bWorldShift_Offset), 0, ApplyWorldOffsetCS_bWorldShift_PropertyAddress.Address, bWorldShift);
		NativeReflection.InvokeFunctionOptimized(base.Address, ApplyWorldOffsetCS_FunctionAddress, intPtr, ApplyWorldOffsetCS_ParamsSize);
	}

	static UBaseActorComp()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UBaseActorComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UBaseActorComp));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BaseActorComp");
		PostInitPropertiesCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PostInitPropertiesCS");
		PostInitPropertiesCS_ParamsSize = NativeReflection.GetFunctionParamsSize(PostInitPropertiesCS_FunctionAddress);
		PostInitPropertiesCS_IsValid = PostInitPropertiesCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:PostInitPropertiesCS", PostInitPropertiesCS_IsValid);
		OnUnregisterCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnUnregisterCS");
		OnUnregisterCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnUnregisterCS_FunctionAddress);
		OnUnregisterCS_IsValid = OnUnregisterCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:OnUnregisterCS", OnUnregisterCS_IsValid);
		OnRegisterCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRegisterCS");
		OnRegisterCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRegisterCS_FunctionAddress);
		OnRegisterCS_IsValid = OnRegisterCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:OnRegisterCS", OnRegisterCS_IsValid);
		OnAttachInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnAttachInCS");
		OnAttachInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAttachInCS_FunctionAddress);
		OnAttachInCS_IsValid = OnAttachInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:OnAttachInCS", OnAttachInCS_IsValid);
		InitializeCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitializeCS");
		InitializeCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitializeCS_FunctionAddress);
		InitializeCS_IsValid = InitializeCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:InitializeCS", InitializeCS_IsValid);
		GetLogLvl_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetLogLvl");
		GetLogLvl_ParamsSize = NativeReflection.GetFunctionParamsSize(GetLogLvl_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetLogLvl_ReturnValue_PropertyAddress, GetLogLvl_FunctionAddress, "ReturnValue");
		GetLogLvl_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetLogLvl_FunctionAddress, "ReturnValue");
		GetLogLvl_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetLogLvl_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetLogLvl_IsValid = GetLogLvl_FunctionAddress != IntPtr.Zero && GetLogLvl_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:GetLogLvl", GetLogLvl_IsValid);
		GetDebugID_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetDebugID");
		GetDebugID_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDebugID_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetDebugID_ReturnValue_PropertyAddress, GetDebugID_FunctionAddress, "ReturnValue");
		GetDebugID_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetDebugID_FunctionAddress, "ReturnValue");
		GetDebugID_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetDebugID_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetDebugID_IsValid = GetDebugID_FunctionAddress != IntPtr.Zero && GetDebugID_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:GetDebugID", GetDebugID_IsValid);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflectionCached.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflectionCached.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FByteProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:EndPlayInCS", EndPlayInCS_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		ApplyWorldOffsetCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ApplyWorldOffsetCS");
		ApplyWorldOffsetCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ApplyWorldOffsetCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_InOffset_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "InOffset");
		ApplyWorldOffsetCS_InOffset_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "InOffset", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ApplyWorldOffsetCS_bWorldShift_PropertyAddress, ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_Offset = NativeReflectionCached.GetPropertyOffset(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift");
		ApplyWorldOffsetCS_bWorldShift_IsValid = NativeReflectionCached.ValidatePropertyClass(ApplyWorldOffsetCS_FunctionAddress, "bWorldShift", Classes.FBoolProperty);
		ApplyWorldOffsetCS_IsValid = ApplyWorldOffsetCS_FunctionAddress != IntPtr.Zero && ApplyWorldOffsetCS_InOffset_IsValid && ApplyWorldOffsetCS_bWorldShift_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BaseActorComp:ApplyWorldOffsetCS", ApplyWorldOffsetCS_IsValid);
	}
}
