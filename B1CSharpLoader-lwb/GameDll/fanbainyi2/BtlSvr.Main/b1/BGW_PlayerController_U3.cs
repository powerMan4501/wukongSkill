using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3")]
internal class BGW_PlayerController_U3 : ABGWPlayerController
{
	public Action<FVector2D, float> Evt_OnTapPressed;

	public Action<FVector2D, float> Evt_OnHoldPressed;

	public Action<FVector2D, float> Evt_OnHoldReleased;

	public Action<FVector2D, float> Evt_OnSwipeStarted;

	public Action<FVector2D, float> Evt_OnSwipeUpdate;

	public Action<FVector2D, float> Evt_OnSwipeReleased;

	public Action<FVector2D, FVector2D, float> Evt_OnSwipeTwoPointsStarted;

	public Action<FVector2D, FVector2D, float> Evt_OnSwipeTwoPointsUpdate;

	public Action<FVector2D, FVector2D, float> Evt_OnPinchStarted;

	public Action<FVector2D, FVector2D, float> Evt_OnPinchUpdate;

	public Action<float> Evt_AxisMoveForward;

	public Action<float> Evt_AxisMoveSideways;

	public Action<float> Evt_AxisMoveForwardGamepad;

	public Action<float> Evt_AxisMoveSidewaysGamepad;

	private bool bIgnoreInput = true;

	private static bool InputHandler_IsValid;

	private static int InputHandler_Offset;

	private static bool OnAxisMoveForward_IsValid;

	private static IntPtr OnAxisMoveForward_FunctionAddress;

	private static int OnAxisMoveForward_ParamsSize;

	private static bool OnAxisMoveForward_AxisValue_IsValid;

	private static int OnAxisMoveForward_AxisValue_Offset;

	private static bool OnAxisMoveSideways_IsValid;

	private static IntPtr OnAxisMoveSideways_FunctionAddress;

	private static int OnAxisMoveSideways_ParamsSize;

	private static bool OnAxisMoveSideways_AxisValue_IsValid;

	private static int OnAxisMoveSideways_AxisValue_Offset;

	private static bool OnAxisMoveForwardGamepad_IsValid;

	private static IntPtr OnAxisMoveForwardGamepad_FunctionAddress;

	private static int OnAxisMoveForwardGamepad_ParamsSize;

	private static bool OnAxisMoveForwardGamepad_AxisValue_IsValid;

	private static int OnAxisMoveForwardGamepad_AxisValue_Offset;

	private static bool OnAxisMoveSidewaysGamepad_IsValid;

	private static IntPtr OnAxisMoveSidewaysGamepad_FunctionAddress;

	private static int OnAxisMoveSidewaysGamepad_ParamsSize;

	private static bool OnAxisMoveSidewaysGamepad_AxisValue_IsValid;

	private static int OnAxisMoveSidewaysGamepad_AxisValue_Offset;

	private static bool ProcessPlayerInputCS_IsValid;

	private static IntPtr ProcessPlayerInputCS_FunctionAddress;

	private static int ProcessPlayerInputCS_ParamsSize;

	private static bool ProcessPlayerInputCS_DeltaTime_IsValid;

	private static int ProcessPlayerInputCS_DeltaTime_Offset;

	private static bool ProcessPlayerInputCS_bGamePaused_IsValid;

	private static int ProcessPlayerInputCS_bGamePaused_Offset;

	private static FFieldAddress ProcessPlayerInputCS_bGamePaused_PropertyAddress;

	private static bool SetupInputComponentCS_IsValid;

	private static IntPtr SetupInputComponentCS_FunctionAddress;

	private static int SetupInputComponentCS_ParamsSize;

	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:InputHandler")]
	public b1.BGW_PlayerInput_U3 InputHandler
	{
		get
		{
			CheckDestroyed();
			if (!InputHandler_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PlayerController_U3:InputHandler");
				return null;
			}
			return UObjectMarshaler<b1.BGW_PlayerInput_U3>.FromNative(IntPtr.Add(base.Address, InputHandler_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InputHandler_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_PlayerController_U3:InputHandler");
			}
			else
			{
				UObjectMarshaler<b1.BGW_PlayerInput_U3>.ToNative(IntPtr.Add(base.Address, InputHandler_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:SetupInputComponentCS")]
	protected override void SetupInputComponentCS_Implementation()
	{
		InputHandler = UObject.NewObject<b1.BGW_PlayerInput_U3>(this);
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Tap, EInputEventType.IE_Pressed, OnTapPressed));
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Hold, EInputEventType.IE_Pressed, OnHoldPressed));
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Hold, EInputEventType.IE_Released, OnHoldReleased));
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Swipe, EInputEventType.IE_Pressed, OnSwipeStarted));
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Swipe, EInputEventType.IE_Repeat, OnSwipeUpdate));
		InputHandler.ActionBindings1P.Add(new ActionBinding1P(EGameKeyType.Swipe, EInputEventType.IE_Released, OnSwipeReleased));
		InputHandler.ActionBindings2P.Add(new ActionBinding2P(EGameKeyType.SwipeTwoPoints, EInputEventType.IE_Released, OnSwipeTwoPointsStarted));
		InputHandler.ActionBindings2P.Add(new ActionBinding2P(EGameKeyType.SwipeTwoPoints, EInputEventType.IE_Repeat, OnSwipeTwoPointsUpdate));
		InputHandler.ActionBindings2P.Add(new ActionBinding2P(EGameKeyType.Pinch, EInputEventType.IE_Pressed, OnPinchStarted));
		InputHandler.ActionBindings2P.Add(new ActionBinding2P(EGameKeyType.Pinch, EInputEventType.IE_Repeat, OnPinchUpdate));
		base.InputComponent.BindAxis("MoveForward", OnAxisMoveForward);
		base.InputComponent.BindAxis("MoveSideways", OnAxisMoveSideways);
		base.InputComponent.BindAxis("MoveForwardGamepad", OnAxisMoveForwardGamepad);
		base.InputComponent.BindAxis("MoveSidewaysGamepad", OnAxisMoveSidewaysGamepad);
	}

	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:ProcessPlayerInputCS")]
	protected override void ProcessPlayerInputCS_Implementation(float DeltaTime, bool bGamePaused)
	{
		if (InputHandler != null && !bIgnoreInput)
		{
			InputHandler.UpdateDetection(DeltaTime);
		}
	}

	private void OnTapPressed(FVector2D ScreenPosition, float DownTime)
	{
		Evt_OnTapPressed?.Invoke(ScreenPosition, DownTime);
	}

	private void OnHoldPressed(FVector2D ScreenPosition, float DownTime)
	{
		Evt_OnHoldPressed?.Invoke(ScreenPosition, DownTime);
	}

	private void OnHoldReleased(FVector2D ScreenPosition, float DownTime)
	{
		Evt_OnHoldReleased?.Invoke(ScreenPosition, DownTime);
	}

	private void OnSwipeStarted(FVector2D AnchorPosition, float DownTime)
	{
		Evt_OnSwipeStarted?.Invoke(AnchorPosition, DownTime);
	}

	private void OnSwipeUpdate(FVector2D ScreenPosition, float DownTime)
	{
		Evt_OnSwipeUpdate?.Invoke(ScreenPosition, DownTime);
	}

	private void OnSwipeReleased(FVector2D ScreenPosition, float DownTime)
	{
		Evt_OnSwipeReleased?.Invoke(ScreenPosition, DownTime);
	}

	private void OnSwipeTwoPointsStarted(FVector2D ScreenPosition1, FVector2D ScreenPosition2, float DownTime)
	{
		Evt_OnSwipeTwoPointsStarted?.Invoke(ScreenPosition1, ScreenPosition2, DownTime);
	}

	private void OnSwipeTwoPointsUpdate(FVector2D ScreenPosition1, FVector2D ScreenPosition2, float DownTime)
	{
		Evt_OnSwipeTwoPointsUpdate?.Invoke(ScreenPosition1, ScreenPosition2, DownTime);
	}

	private void OnPinchStarted(FVector2D AnchorPosition1, FVector2D AnchorPosition2, float DownTime)
	{
		Evt_OnPinchStarted?.Invoke(AnchorPosition1, AnchorPosition2, DownTime);
	}

	private void OnPinchUpdate(FVector2D ScreenPosition1, FVector2D ScreenPosition2, float DownTime)
	{
		Evt_OnPinchUpdate?.Invoke(ScreenPosition1, ScreenPosition2, DownTime);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForward")]
	private void OnAxisMoveForward(float AxisValue)
	{
		if (bIgnoreInput)
		{
			Evt_AxisMoveForward?.Invoke(AxisValue);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSideways")]
	private void OnAxisMoveSideways(float AxisValue)
	{
		if (bIgnoreInput)
		{
			Evt_AxisMoveSideways?.Invoke(AxisValue);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForwardGamepad")]
	private void OnAxisMoveForwardGamepad(float AxisValue)
	{
		if (bIgnoreInput)
		{
			Evt_AxisMoveForwardGamepad?.Invoke(AxisValue);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSidewaysGamepad")]
	private void OnAxisMoveSidewaysGamepad(float AxisValue)
	{
		if (bIgnoreInput)
		{
			Evt_AxisMoveSidewaysGamepad?.Invoke(AxisValue);
		}
	}

	public void SetIgnoreInput(bool bIgnore)
	{
		bIgnoreInput = bIgnore;
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForward")]
	private static void OnAxisMoveForward__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		float axisValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnAxisMoveForward_AxisValue_Offset));
		bGW_PlayerController_U.OnAxisMoveForward(axisValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSideways")]
	private static void OnAxisMoveSideways__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		float axisValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnAxisMoveSideways_AxisValue_Offset));
		bGW_PlayerController_U.OnAxisMoveSideways(axisValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForwardGamepad")]
	private static void OnAxisMoveForwardGamepad__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		float axisValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnAxisMoveForwardGamepad_AxisValue_Offset));
		bGW_PlayerController_U.OnAxisMoveForwardGamepad(axisValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSidewaysGamepad")]
	private static void OnAxisMoveSidewaysGamepad__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		float axisValue = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnAxisMoveSidewaysGamepad_AxisValue_Offset));
		bGW_PlayerController_U.OnAxisMoveSidewaysGamepad(axisValue);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:ProcessPlayerInputCS")]
	private static void ProcessPlayerInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ProcessPlayerInputCS_DeltaTime_Offset));
		bool bGamePaused = BoolMarshaler.FromNative(IntPtr.Add(buffer, ProcessPlayerInputCS_bGamePaused_Offset), 0, ProcessPlayerInputCS_bGamePaused_PropertyAddress.Address);
		bGW_PlayerController_U.ProcessPlayerInputCS_Implementation(deltaTime, bGamePaused);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGW_PlayerController_U3:SetupInputComponentCS")]
	private static void SetupInputComponentCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW_PlayerController_U3 bGW_PlayerController_U = GCHelper.Find<b1.BGW_PlayerController_U3>(obj);
		bGW_PlayerController_U.SetupInputComponentCS_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_PlayerController_U3");
		InputHandler_Offset = NativeReflection.GetPropertyOffset(intPtr, "InputHandler");
		InputHandler_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InputHandler", Classes.FObjectProperty);
		OnAxisMoveForward_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAxisMoveForward");
		OnAxisMoveForward_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAxisMoveForward_FunctionAddress);
		OnAxisMoveForward_AxisValue_Offset = NativeReflection.GetPropertyOffset(OnAxisMoveForward_FunctionAddress, "AxisValue");
		OnAxisMoveForward_AxisValue_IsValid = NativeReflection.ValidatePropertyClass(OnAxisMoveForward_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		OnAxisMoveForward_IsValid = OnAxisMoveForward_FunctionAddress != IntPtr.Zero && OnAxisMoveForward_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForward", OnAxisMoveForward_IsValid);
		OnAxisMoveSideways_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAxisMoveSideways");
		OnAxisMoveSideways_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAxisMoveSideways_FunctionAddress);
		OnAxisMoveSideways_AxisValue_Offset = NativeReflection.GetPropertyOffset(OnAxisMoveSideways_FunctionAddress, "AxisValue");
		OnAxisMoveSideways_AxisValue_IsValid = NativeReflection.ValidatePropertyClass(OnAxisMoveSideways_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		OnAxisMoveSideways_IsValid = OnAxisMoveSideways_FunctionAddress != IntPtr.Zero && OnAxisMoveSideways_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSideways", OnAxisMoveSideways_IsValid);
		OnAxisMoveForwardGamepad_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAxisMoveForwardGamepad");
		OnAxisMoveForwardGamepad_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAxisMoveForwardGamepad_FunctionAddress);
		OnAxisMoveForwardGamepad_AxisValue_Offset = NativeReflection.GetPropertyOffset(OnAxisMoveForwardGamepad_FunctionAddress, "AxisValue");
		OnAxisMoveForwardGamepad_AxisValue_IsValid = NativeReflection.ValidatePropertyClass(OnAxisMoveForwardGamepad_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		OnAxisMoveForwardGamepad_IsValid = OnAxisMoveForwardGamepad_FunctionAddress != IntPtr.Zero && OnAxisMoveForwardGamepad_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveForwardGamepad", OnAxisMoveForwardGamepad_IsValid);
		OnAxisMoveSidewaysGamepad_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnAxisMoveSidewaysGamepad");
		OnAxisMoveSidewaysGamepad_ParamsSize = NativeReflection.GetFunctionParamsSize(OnAxisMoveSidewaysGamepad_FunctionAddress);
		OnAxisMoveSidewaysGamepad_AxisValue_Offset = NativeReflection.GetPropertyOffset(OnAxisMoveSidewaysGamepad_FunctionAddress, "AxisValue");
		OnAxisMoveSidewaysGamepad_AxisValue_IsValid = NativeReflection.ValidatePropertyClass(OnAxisMoveSidewaysGamepad_FunctionAddress, "AxisValue", Classes.FFloatProperty);
		OnAxisMoveSidewaysGamepad_IsValid = OnAxisMoveSidewaysGamepad_FunctionAddress != IntPtr.Zero && OnAxisMoveSidewaysGamepad_AxisValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:OnAxisMoveSidewaysGamepad", OnAxisMoveSidewaysGamepad_IsValid);
		ProcessPlayerInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessPlayerInputCS");
		ProcessPlayerInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessPlayerInputCS_FunctionAddress);
		ProcessPlayerInputCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(ProcessPlayerInputCS_FunctionAddress, "DeltaTime");
		ProcessPlayerInputCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(ProcessPlayerInputCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref ProcessPlayerInputCS_bGamePaused_PropertyAddress, ProcessPlayerInputCS_FunctionAddress, "bGamePaused");
		ProcessPlayerInputCS_bGamePaused_Offset = NativeReflection.GetPropertyOffset(ProcessPlayerInputCS_FunctionAddress, "bGamePaused");
		ProcessPlayerInputCS_bGamePaused_IsValid = NativeReflection.ValidatePropertyClass(ProcessPlayerInputCS_FunctionAddress, "bGamePaused", Classes.FBoolProperty);
		ProcessPlayerInputCS_IsValid = ProcessPlayerInputCS_FunctionAddress != IntPtr.Zero && ProcessPlayerInputCS_DeltaTime_IsValid && ProcessPlayerInputCS_bGamePaused_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:ProcessPlayerInputCS", ProcessPlayerInputCS_IsValid);
		SetupInputComponentCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetupInputComponentCS");
		SetupInputComponentCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SetupInputComponentCS_FunctionAddress);
		SetupInputComponentCS_IsValid = SetupInputComponentCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGW_PlayerController_U3:SetupInputComponentCS", SetupInputComponentCS_IsValid);
	}

	static BGW_PlayerController_U3()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW_PlayerController_U3)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW_PlayerController_U3));
	}
}
