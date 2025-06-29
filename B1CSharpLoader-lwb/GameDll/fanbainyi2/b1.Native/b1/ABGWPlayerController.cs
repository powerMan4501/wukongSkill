using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)818938532uL, Config = "Game")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.BGWPlayerController", "b1", UnrealModuleType.Game)]
public class ABGWPlayerController : APlayerController
{
	private static bool SetupInputComponentCS_IsValid;

	private IntPtr SetupInputComponentCS_InstanceFunctionAddress;

	private static IntPtr SetupInputComponentCS_FunctionAddress;

	private static int SetupInputComponentCS_ParamsSize;

	private static bool ProcessPlayerInputCS_IsValid;

	private IntPtr ProcessPlayerInputCS_InstanceFunctionAddress;

	private static IntPtr ProcessPlayerInputCS_FunctionAddress;

	private static int ProcessPlayerInputCS_ParamsSize;

	private static bool ProcessPlayerInputCS_DeltaTime_IsValid;

	private static FFieldAddress ProcessPlayerInputCS_DeltaTime_PropertyAddress;

	private static int ProcessPlayerInputCS_DeltaTime_Offset;

	private static bool ProcessPlayerInputCS_bGamePaused_IsValid;

	private static FFieldAddress ProcessPlayerInputCS_bGamePaused_PropertyAddress;

	private static int ProcessPlayerInputCS_bGamePaused_Offset;

	private static bool InitCS_IsValid;

	private IntPtr InitCS_InstanceFunctionAddress;

	private static IntPtr InitCS_FunctionAddress;

	private static int InitCS_ParamsSize;

	private static bool GetViewportClientMousePosition_IsValid;

	private static IntPtr GetViewportClientMousePosition_FunctionAddress;

	private static int GetViewportClientMousePosition_ParamsSize;

	private static bool GetViewportClientMousePosition_MousePosition_IsValid;

	private static FFieldAddress GetViewportClientMousePosition_MousePosition_PropertyAddress;

	private static int GetViewportClientMousePosition_MousePosition_Offset;

	private static bool GetViewportClientMousePosition_ReturnValue_IsValid;

	private static FFieldAddress GetViewportClientMousePosition_ReturnValue_PropertyAddress;

	private static int GetViewportClientMousePosition_ReturnValue_Offset;

	private static bool GetPlayerInputTouchesCount_IsValid;

	private static IntPtr GetPlayerInputTouchesCount_FunctionAddress;

	private static int GetPlayerInputTouchesCount_ParamsSize;

	private static bool GetPlayerInputTouchesCount_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerInputTouchesCount_ReturnValue_PropertyAddress;

	private static int GetPlayerInputTouchesCount_ReturnValue_Offset;

	private static bool GetPlayerInputTouch_IsValid;

	private static IntPtr GetPlayerInputTouch_FunctionAddress;

	private static int GetPlayerInputTouch_ParamsSize;

	private static bool GetPlayerInputTouch_Idx_IsValid;

	private static FFieldAddress GetPlayerInputTouch_Idx_PropertyAddress;

	private static int GetPlayerInputTouch_Idx_Offset;

	private static bool GetPlayerInputTouch_ReturnValue_IsValid;

	private static FFieldAddress GetPlayerInputTouch_ReturnValue_PropertyAddress;

	private static int GetPlayerInputTouch_ReturnValue_Offset;

	private static bool BGWGetHitResultAtScreenPosition_IsValid;

	private static IntPtr BGWGetHitResultAtScreenPosition_FunctionAddress;

	private static int BGWGetHitResultAtScreenPosition_ParamsSize;

	private static bool BGWGetHitResultAtScreenPosition_ScreenPosition_IsValid;

	private static FFieldAddress BGWGetHitResultAtScreenPosition_ScreenPosition_PropertyAddress;

	private static int BGWGetHitResultAtScreenPosition_ScreenPosition_Offset;

	private static bool BGWGetHitResultAtScreenPosition_TraceChannel_IsValid;

	private static FFieldAddress BGWGetHitResultAtScreenPosition_TraceChannel_PropertyAddress;

	private static int BGWGetHitResultAtScreenPosition_TraceChannel_Offset;

	private static bool BGWGetHitResultAtScreenPosition_bTraceComplex_IsValid;

	private static FFieldAddress BGWGetHitResultAtScreenPosition_bTraceComplex_PropertyAddress;

	private static int BGWGetHitResultAtScreenPosition_bTraceComplex_Offset;

	private static bool BGWGetHitResultAtScreenPosition_HitResult_IsValid;

	private static FFieldAddress BGWGetHitResultAtScreenPosition_HitResult_PropertyAddress;

	private static int BGWGetHitResultAtScreenPosition_HitResult_Offset;

	private static bool BGWGetHitResultAtScreenPosition_ReturnValue_IsValid;

	private static FFieldAddress BGWGetHitResultAtScreenPosition_ReturnValue_PropertyAddress;

	private static int BGWGetHitResultAtScreenPosition_ReturnValue_Offset;

	private static bool BGWDeprojectScreenToWorld_IsValid;

	private static IntPtr BGWDeprojectScreenToWorld_FunctionAddress;

	private static int BGWDeprojectScreenToWorld_ParamsSize;

	private static bool BGWDeprojectScreenToWorld_ScreenPosition_IsValid;

	private static FFieldAddress BGWDeprojectScreenToWorld_ScreenPosition_PropertyAddress;

	private static int BGWDeprojectScreenToWorld_ScreenPosition_Offset;

	private static bool BGWDeprojectScreenToWorld_RayOrigin_IsValid;

	private static FFieldAddress BGWDeprojectScreenToWorld_RayOrigin_PropertyAddress;

	private static int BGWDeprojectScreenToWorld_RayOrigin_Offset;

	private static bool BGWDeprojectScreenToWorld_RayDirection_IsValid;

	private static FFieldAddress BGWDeprojectScreenToWorld_RayDirection_PropertyAddress;

	private static int BGWDeprojectScreenToWorld_RayDirection_Offset;

	private static bool BGWDeprojectScreenToWorld_ReturnValue_IsValid;

	private static FFieldAddress BGWDeprojectScreenToWorld_ReturnValue_PropertyAddress;

	private static int BGWDeprojectScreenToWorld_ReturnValue_Offset;

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlayerController:SetupInputComponentCS")]
	protected unsafe void SetupInputComponentCS()
	{
		CheckDestroyed();
		if (!SetupInputComponentCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:SetupInputComponentCS");
			return;
		}
		if (SetupInputComponentCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			SetupInputComponentCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "SetupInputComponentCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupInputComponentCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupInputComponentCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetupInputComponentCS_InstanceFunctionAddress, argsSize: SetupInputComponentCS_ParamsSize);
	}

	protected unsafe virtual void SetupInputComponentCS_Implementation()
	{
		CheckDestroyed();
		if (!SetupInputComponentCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:SetupInputComponentCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetupInputComponentCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetupInputComponentCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SetupInputComponentCS_FunctionAddress, argsSize: SetupInputComponentCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlayerController:ProcessPlayerInputCS")]
	protected unsafe void ProcessPlayerInputCS(float DeltaTime, bool bGamePaused)
	{
		CheckDestroyed();
		if (!ProcessPlayerInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:ProcessPlayerInputCS");
			return;
		}
		if (ProcessPlayerInputCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			ProcessPlayerInputCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "ProcessPlayerInputCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessPlayerInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessPlayerInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ProcessPlayerInputCS_DeltaTime_Offset), 0, ProcessPlayerInputCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ProcessPlayerInputCS_bGamePaused_Offset), 0, ProcessPlayerInputCS_bGamePaused_PropertyAddress.Address, bGamePaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessPlayerInputCS_InstanceFunctionAddress, intPtr, ProcessPlayerInputCS_ParamsSize);
	}

	protected unsafe virtual void ProcessPlayerInputCS_Implementation(float DeltaTime, bool bGamePaused)
	{
		CheckDestroyed();
		if (!ProcessPlayerInputCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:ProcessPlayerInputCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ProcessPlayerInputCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ProcessPlayerInputCS_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, ProcessPlayerInputCS_DeltaTime_Offset), 0, ProcessPlayerInputCS_DeltaTime_PropertyAddress.Address, DeltaTime);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, ProcessPlayerInputCS_bGamePaused_Offset), 0, ProcessPlayerInputCS_bGamePaused_PropertyAddress.Address, bGamePaused);
		NativeReflection.InvokeFunctionOptimized(base.Address, ProcessPlayerInputCS_FunctionAddress, intPtr, ProcessPlayerInputCS_ParamsSize);
	}

	[UFunction(Flags = 134744064u)]
	[UMetaPath("/Script/b1.BGWPlayerController:InitCS")]
	protected unsafe void InitCS()
	{
		CheckDestroyed();
		if (!InitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:InitCS");
			return;
		}
		if (InitCS_InstanceFunctionAddress == IntPtr.Zero)
		{
			InitCS_InstanceFunctionAddress = NativeReflection.GetFunctionFromInstance(base.Address, "InitCS");
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitCS_InstanceFunctionAddress, argsSize: InitCS_ParamsSize);
	}

	protected unsafe virtual void InitCS_Implementation()
	{
		CheckDestroyed();
		if (!InitCS_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:InitCS");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(InitCS_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)InitCS_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: InitCS_FunctionAddress, argsSize: InitCS_ParamsSize);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGWPlayerController:GetViewportClientMousePosition")]
	public unsafe bool GetViewportClientMousePosition(out FVector2D MousePosition)
	{
		CheckDestroyed();
		if (!GetViewportClientMousePosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:GetViewportClientMousePosition");
			MousePosition = default(FVector2D);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetViewportClientMousePosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetViewportClientMousePosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetViewportClientMousePosition_FunctionAddress, intPtr, GetViewportClientMousePosition_ParamsSize);
		MousePosition = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(intPtr, GetViewportClientMousePosition_MousePosition_Offset), 0, GetViewportClientMousePosition_MousePosition_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, GetViewportClientMousePosition_ReturnValue_Offset), 0, GetViewportClientMousePosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/b1.BGWPlayerController:GetPlayerInputTouchesCount")]
	public unsafe int GetPlayerInputTouchesCount()
	{
		CheckDestroyed();
		if (!GetPlayerInputTouchesCount_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:GetPlayerInputTouchesCount");
			return 0;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerInputTouchesCount_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerInputTouchesCount_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerInputTouchesCount_FunctionAddress, intPtr, GetPlayerInputTouchesCount_ParamsSize);
		return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(intPtr, GetPlayerInputTouchesCount_ReturnValue_Offset), 0, GetPlayerInputTouchesCount_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/b1.BGWPlayerController:GetPlayerInputTouch")]
	public unsafe FVector GetPlayerInputTouch(int Idx)
	{
		CheckDestroyed();
		if (!GetPlayerInputTouch_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:GetPlayerInputTouch");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlayerInputTouch_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlayerInputTouch_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(intPtr, GetPlayerInputTouch_Idx_Offset), 0, GetPlayerInputTouch_Idx_PropertyAddress.Address, Idx);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlayerInputTouch_FunctionAddress, intPtr, GetPlayerInputTouch_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlayerInputTouch_ReturnValue_Offset), 0, GetPlayerInputTouch_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1422001153u)]
	[UMetaPath("/Script/b1.BGWPlayerController:BGWGetHitResultAtScreenPosition")]
	public unsafe bool BGWGetHitResultAtScreenPosition(FVector2D ScreenPosition, ECollisionChannel TraceChannel, bool bTraceComplex, out FHitResult HitResult)
	{
		CheckDestroyed();
		if (!BGWGetHitResultAtScreenPosition_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:BGWGetHitResultAtScreenPosition");
			HitResult = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWGetHitResultAtScreenPosition_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWGetHitResultAtScreenPosition_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, BGWGetHitResultAtScreenPosition_ScreenPosition_Offset), 0, BGWGetHitResultAtScreenPosition_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		EnumMarshaler<ECollisionChannel>.ToNative(IntPtr.Add(intPtr, BGWGetHitResultAtScreenPosition_TraceChannel_Offset), 0, BGWGetHitResultAtScreenPosition_TraceChannel_PropertyAddress.Address, TraceChannel);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, BGWGetHitResultAtScreenPosition_bTraceComplex_Offset), 0, BGWGetHitResultAtScreenPosition_bTraceComplex_PropertyAddress.Address, bTraceComplex);
		NativeReflection.InitializeValue_InContainer(BGWGetHitResultAtScreenPosition_HitResult_PropertyAddress.Address, intPtr);
		NativeReflection.InvokeFunctionOptimized(base.Address, BGWGetHitResultAtScreenPosition_FunctionAddress, intPtr, BGWGetHitResultAtScreenPosition_ParamsSize);
		HitResult = FHitResult.FromNative(IntPtr.Add(intPtr, BGWGetHitResultAtScreenPosition_HitResult_Offset), 0, BGWGetHitResultAtScreenPosition_HitResult_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGWGetHitResultAtScreenPosition_ReturnValue_Offset), 0, BGWGetHitResultAtScreenPosition_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 79823873u)]
	[UMetaPath("/Script/b1.BGWPlayerController:BGWDeprojectScreenToWorld")]
	public unsafe bool BGWDeprojectScreenToWorld(FVector2D ScreenPosition, out FVector RayOrigin, out FVector RayDirection)
	{
		CheckDestroyed();
		if (!BGWDeprojectScreenToWorld_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/b1.BGWPlayerController:BGWDeprojectScreenToWorld");
			RayOrigin = default(FVector);
			RayDirection = default(FVector);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(BGWDeprojectScreenToWorld_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)BGWDeprojectScreenToWorld_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(intPtr, BGWDeprojectScreenToWorld_ScreenPosition_Offset), 0, BGWDeprojectScreenToWorld_ScreenPosition_PropertyAddress.Address, ScreenPosition);
		NativeReflection.InvokeFunctionOptimized(base.Address, BGWDeprojectScreenToWorld_FunctionAddress, intPtr, BGWDeprojectScreenToWorld_ParamsSize);
		RayOrigin = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGWDeprojectScreenToWorld_RayOrigin_Offset), 0, BGWDeprojectScreenToWorld_RayOrigin_PropertyAddress.Address);
		RayDirection = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, BGWDeprojectScreenToWorld_RayDirection_Offset), 0, BGWDeprojectScreenToWorld_RayDirection_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, BGWDeprojectScreenToWorld_ReturnValue_Offset), 0, BGWDeprojectScreenToWorld_ReturnValue_PropertyAddress.Address);
	}

	static ABGWPlayerController()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(ABGWPlayerController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(ABGWPlayerController));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1.BGWPlayerController");
		SetupInputComponentCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SetupInputComponentCS");
		SetupInputComponentCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupInputComponentCS_FunctionAddress);
		SetupInputComponentCS_IsValid = SetupInputComponentCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:SetupInputComponentCS", SetupInputComponentCS_IsValid);
		ProcessPlayerInputCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "ProcessPlayerInputCS");
		ProcessPlayerInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessPlayerInputCS_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ProcessPlayerInputCS_DeltaTime_PropertyAddress, ProcessPlayerInputCS_FunctionAddress, "DeltaTime");
		ProcessPlayerInputCS_DeltaTime_Offset = NativeReflectionCached.GetPropertyOffset(ProcessPlayerInputCS_FunctionAddress, "DeltaTime");
		ProcessPlayerInputCS_DeltaTime_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessPlayerInputCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref ProcessPlayerInputCS_bGamePaused_PropertyAddress, ProcessPlayerInputCS_FunctionAddress, "bGamePaused");
		ProcessPlayerInputCS_bGamePaused_Offset = NativeReflectionCached.GetPropertyOffset(ProcessPlayerInputCS_FunctionAddress, "bGamePaused");
		ProcessPlayerInputCS_bGamePaused_IsValid = NativeReflectionCached.ValidatePropertyClass(ProcessPlayerInputCS_FunctionAddress, "bGamePaused", Classes.FBoolProperty);
		ProcessPlayerInputCS_IsValid = ProcessPlayerInputCS_FunctionAddress != IntPtr.Zero && ProcessPlayerInputCS_DeltaTime_IsValid && ProcessPlayerInputCS_bGamePaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:ProcessPlayerInputCS", ProcessPlayerInputCS_IsValid);
		InitCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitCS");
		InitCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitCS_FunctionAddress);
		InitCS_IsValid = InitCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:InitCS", InitCS_IsValid);
		GetViewportClientMousePosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetViewportClientMousePosition");
		GetViewportClientMousePosition_ParamsSize = NativeReflection.GetFunctionParamsSize(GetViewportClientMousePosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetViewportClientMousePosition_MousePosition_PropertyAddress, GetViewportClientMousePosition_FunctionAddress, "MousePosition");
		GetViewportClientMousePosition_MousePosition_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportClientMousePosition_FunctionAddress, "MousePosition");
		GetViewportClientMousePosition_MousePosition_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportClientMousePosition_FunctionAddress, "MousePosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref GetViewportClientMousePosition_ReturnValue_PropertyAddress, GetViewportClientMousePosition_FunctionAddress, "ReturnValue");
		GetViewportClientMousePosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetViewportClientMousePosition_FunctionAddress, "ReturnValue");
		GetViewportClientMousePosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetViewportClientMousePosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		GetViewportClientMousePosition_IsValid = GetViewportClientMousePosition_FunctionAddress != IntPtr.Zero && GetViewportClientMousePosition_MousePosition_IsValid && GetViewportClientMousePosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:GetViewportClientMousePosition", GetViewportClientMousePosition_IsValid);
		GetPlayerInputTouchesCount_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerInputTouchesCount");
		GetPlayerInputTouchesCount_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerInputTouchesCount_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerInputTouchesCount_ReturnValue_PropertyAddress, GetPlayerInputTouchesCount_FunctionAddress, "ReturnValue");
		GetPlayerInputTouchesCount_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerInputTouchesCount_FunctionAddress, "ReturnValue");
		GetPlayerInputTouchesCount_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerInputTouchesCount_FunctionAddress, "ReturnValue", Classes.FIntProperty);
		GetPlayerInputTouchesCount_IsValid = GetPlayerInputTouchesCount_FunctionAddress != IntPtr.Zero && GetPlayerInputTouchesCount_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:GetPlayerInputTouchesCount", GetPlayerInputTouchesCount_IsValid);
		GetPlayerInputTouch_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "GetPlayerInputTouch");
		GetPlayerInputTouch_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlayerInputTouch_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerInputTouch_Idx_PropertyAddress, GetPlayerInputTouch_FunctionAddress, "Idx");
		GetPlayerInputTouch_Idx_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerInputTouch_FunctionAddress, "Idx");
		GetPlayerInputTouch_Idx_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerInputTouch_FunctionAddress, "Idx", Classes.FIntProperty);
		NativeReflectionCached.GetPropertyRef(ref GetPlayerInputTouch_ReturnValue_PropertyAddress, GetPlayerInputTouch_FunctionAddress, "ReturnValue");
		GetPlayerInputTouch_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlayerInputTouch_FunctionAddress, "ReturnValue");
		GetPlayerInputTouch_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlayerInputTouch_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlayerInputTouch_IsValid = GetPlayerInputTouch_FunctionAddress != IntPtr.Zero && GetPlayerInputTouch_Idx_IsValid && GetPlayerInputTouch_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:GetPlayerInputTouch", GetPlayerInputTouch_IsValid);
		BGWGetHitResultAtScreenPosition_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGWGetHitResultAtScreenPosition");
		BGWGetHitResultAtScreenPosition_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWGetHitResultAtScreenPosition_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWGetHitResultAtScreenPosition_ScreenPosition_PropertyAddress, BGWGetHitResultAtScreenPosition_FunctionAddress, "ScreenPosition");
		BGWGetHitResultAtScreenPosition_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetHitResultAtScreenPosition_FunctionAddress, "ScreenPosition");
		BGWGetHitResultAtScreenPosition_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetHitResultAtScreenPosition_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetHitResultAtScreenPosition_TraceChannel_PropertyAddress, BGWGetHitResultAtScreenPosition_FunctionAddress, "TraceChannel");
		BGWGetHitResultAtScreenPosition_TraceChannel_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetHitResultAtScreenPosition_FunctionAddress, "TraceChannel");
		BGWGetHitResultAtScreenPosition_TraceChannel_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetHitResultAtScreenPosition_FunctionAddress, "TraceChannel", Classes.FByteProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetHitResultAtScreenPosition_bTraceComplex_PropertyAddress, BGWGetHitResultAtScreenPosition_FunctionAddress, "bTraceComplex");
		BGWGetHitResultAtScreenPosition_bTraceComplex_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetHitResultAtScreenPosition_FunctionAddress, "bTraceComplex");
		BGWGetHitResultAtScreenPosition_bTraceComplex_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetHitResultAtScreenPosition_FunctionAddress, "bTraceComplex", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetHitResultAtScreenPosition_HitResult_PropertyAddress, BGWGetHitResultAtScreenPosition_FunctionAddress, "HitResult");
		BGWGetHitResultAtScreenPosition_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetHitResultAtScreenPosition_FunctionAddress, "HitResult");
		BGWGetHitResultAtScreenPosition_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetHitResultAtScreenPosition_FunctionAddress, "HitResult", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWGetHitResultAtScreenPosition_ReturnValue_PropertyAddress, BGWGetHitResultAtScreenPosition_FunctionAddress, "ReturnValue");
		BGWGetHitResultAtScreenPosition_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWGetHitResultAtScreenPosition_FunctionAddress, "ReturnValue");
		BGWGetHitResultAtScreenPosition_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWGetHitResultAtScreenPosition_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGWGetHitResultAtScreenPosition_IsValid = BGWGetHitResultAtScreenPosition_FunctionAddress != IntPtr.Zero && BGWGetHitResultAtScreenPosition_ScreenPosition_IsValid && BGWGetHitResultAtScreenPosition_TraceChannel_IsValid && BGWGetHitResultAtScreenPosition_bTraceComplex_IsValid && BGWGetHitResultAtScreenPosition_HitResult_IsValid && BGWGetHitResultAtScreenPosition_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:BGWGetHitResultAtScreenPosition", BGWGetHitResultAtScreenPosition_IsValid);
		BGWDeprojectScreenToWorld_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "BGWDeprojectScreenToWorld");
		BGWDeprojectScreenToWorld_ParamsSize = NativeReflection.GetFunctionParamsSize(BGWDeprojectScreenToWorld_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref BGWDeprojectScreenToWorld_ScreenPosition_PropertyAddress, BGWDeprojectScreenToWorld_FunctionAddress, "ScreenPosition");
		BGWDeprojectScreenToWorld_ScreenPosition_Offset = NativeReflectionCached.GetPropertyOffset(BGWDeprojectScreenToWorld_FunctionAddress, "ScreenPosition");
		BGWDeprojectScreenToWorld_ScreenPosition_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWDeprojectScreenToWorld_FunctionAddress, "ScreenPosition", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWDeprojectScreenToWorld_RayOrigin_PropertyAddress, BGWDeprojectScreenToWorld_FunctionAddress, "RayOrigin");
		BGWDeprojectScreenToWorld_RayOrigin_Offset = NativeReflectionCached.GetPropertyOffset(BGWDeprojectScreenToWorld_FunctionAddress, "RayOrigin");
		BGWDeprojectScreenToWorld_RayOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWDeprojectScreenToWorld_FunctionAddress, "RayOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWDeprojectScreenToWorld_RayDirection_PropertyAddress, BGWDeprojectScreenToWorld_FunctionAddress, "RayDirection");
		BGWDeprojectScreenToWorld_RayDirection_Offset = NativeReflectionCached.GetPropertyOffset(BGWDeprojectScreenToWorld_FunctionAddress, "RayDirection");
		BGWDeprojectScreenToWorld_RayDirection_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWDeprojectScreenToWorld_FunctionAddress, "RayDirection", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref BGWDeprojectScreenToWorld_ReturnValue_PropertyAddress, BGWDeprojectScreenToWorld_FunctionAddress, "ReturnValue");
		BGWDeprojectScreenToWorld_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(BGWDeprojectScreenToWorld_FunctionAddress, "ReturnValue");
		BGWDeprojectScreenToWorld_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(BGWDeprojectScreenToWorld_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		BGWDeprojectScreenToWorld_IsValid = BGWDeprojectScreenToWorld_FunctionAddress != IntPtr.Zero && BGWDeprojectScreenToWorld_ScreenPosition_IsValid && BGWDeprojectScreenToWorld_RayOrigin_IsValid && BGWDeprojectScreenToWorld_RayDirection_IsValid && BGWDeprojectScreenToWorld_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1.BGWPlayerController:BGWDeprojectScreenToWorld", BGWDeprojectScreenToWorld_IsValid);
	}
}
