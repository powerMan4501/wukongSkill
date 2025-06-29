using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.UI;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController")]
public class BP_ActorTouchDraggingController : AActor
{
	private APlayerController playerController;

	private UInputComponent inputComponent;

	private APlayerCameraManager camManager;

	private bool bIsDragging;

	private bool bIsHitDistanceCheck;

	private AActor controllingActor;

	private float hitDistance;

	private static bool traceChnl_IsValid;

	private static int traceChnl_Offset;

	private static FFieldAddress traceChnl_PropertyAddress;

	private static bool OnTick_IsValid;

	private static IntPtr OnTick_FunctionAddress;

	private static int OnTick_ParamsSize;

	private static bool OnTick_DeltaTime_IsValid;

	private static int OnTick_DeltaTime_Offset;

	private static bool OnTouchPressed_IsValid;

	private static IntPtr OnTouchPressed_FunctionAddress;

	private static int OnTouchPressed_ParamsSize;

	private static bool OnTouchReleased_IsValid;

	private static IntPtr OnTouchReleased_FunctionAddress;

	private static int OnTouchReleased_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController:traceChnl")]
	public ETraceTypeQuery traceChnl
	{
		get
		{
			CheckDestroyed();
			if (!traceChnl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BP_ActorTouchDraggingController:traceChnl");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, traceChnl_Offset), 0, traceChnl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!traceChnl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BP_ActorTouchDraggingController:traceChnl");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, traceChnl_Offset), 0, traceChnl_PropertyAddress.Address, value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		camManager = UGSE_EngineFuncLib.GetLocalPlayerCameraManager(this);
		playerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
		if (playerController != null)
		{
			inputComponent = playerController.InputComponent;
			if (inputComponent != null)
			{
				inputComponent.BindAction("SingleTouch", EInputEventType.IE_Pressed, OnTouchPressed);
				inputComponent.BindAction("SingleTouch", EInputEventType.IE_Released, OnTouchReleased);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTick")]
	public void OnTick(float DeltaTime)
	{
		if (bIsDragging && controllingActor != null)
		{
			FVector touchWorldLocation = GetTouchWorldLocation();
			if (controllingActor.RootComponent.Mobility == EComponentMobility.Movable)
			{
				controllingActor.SetActorLocation(touchWorldLocation, bSweep: false, out var _, bTeleport: false);
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchPressed")]
	private void OnTouchPressed()
	{
		if (camManager == null || !playerController.DeprojectMousePositionToWorld(out var _, out var WorldDirection))
		{
			return;
		}
		FVector worldLocation = camManager.TransformComponent.GetWorldLocation();
		FVector end = worldLocation + WorldDirection * 1000.0;
		FLinearColor fLinearColor = new FLinearColor(1f, 0f, 0f);
		if (base.World.LineTraceSingle(worldLocation, end, traceChnl, bTraceComplex: true, null, EDrawDebugTrace.ForDuration, out var OutHit, bIgnoreSelf: true, fLinearColor, fLinearColor, 2f))
		{
			controllingActor = UBGUFunctionLibrary.BGUGetHitResultActor(OutHit.HitObjectHandle);
			if (!bIsHitDistanceCheck)
			{
				hitDistance = OutHit.Distance;
				bIsHitDistanceCheck = true;
			}
			bIsDragging = true;
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchReleased")]
	private void OnTouchReleased()
	{
		bIsDragging = false;
	}

	private FVector GetTouchWorldLocation()
	{
		if (!playerController.DeprojectMousePositionToWorld(out var WorldLocation, out var WorldDirection))
		{
			return new FVector(0f);
		}
		return WorldLocation + WorldDirection * hitDistance;
	}

	[UFunctionInvoker("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTick")]
	private static void OnTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BP_ActorTouchDraggingController bP_ActorTouchDraggingController = GCHelper.Find<BP_ActorTouchDraggingController>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OnTick_DeltaTime_Offset));
		bP_ActorTouchDraggingController.OnTick(deltaTime);
	}

	[UFunctionInvoker("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchPressed")]
	private static void OnTouchPressed__Invoker(IntPtr buffer, IntPtr obj)
	{
		BP_ActorTouchDraggingController bP_ActorTouchDraggingController = GCHelper.Find<BP_ActorTouchDraggingController>(obj);
		bP_ActorTouchDraggingController.OnTouchPressed();
	}

	[UFunctionInvoker("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchReleased")]
	private static void OnTouchReleased__Invoker(IntPtr buffer, IntPtr obj)
	{
		BP_ActorTouchDraggingController bP_ActorTouchDraggingController = GCHelper.Find<BP_ActorTouchDraggingController>(obj);
		bP_ActorTouchDraggingController.OnTouchReleased();
	}

	[UFunctionInvoker("/Script/b1-Managed.BP_ActorTouchDraggingController:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BP_ActorTouchDraggingController bP_ActorTouchDraggingController = GCHelper.Find<BP_ActorTouchDraggingController>(obj);
		bP_ActorTouchDraggingController.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BP_ActorTouchDraggingController");
		NativeReflection.GetPropertyRef(ref traceChnl_PropertyAddress, intPtr, "traceChnl");
		traceChnl_Offset = NativeReflection.GetPropertyOffset(intPtr, "traceChnl");
		traceChnl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "traceChnl", Classes.FEnumProperty);
		OnTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTick");
		OnTick_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTick_FunctionAddress);
		OnTick_DeltaTime_Offset = NativeReflection.GetPropertyOffset(OnTick_FunctionAddress, "DeltaTime");
		OnTick_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(OnTick_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		OnTick_IsValid = OnTick_FunctionAddress != IntPtr.Zero && OnTick_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTick", OnTick_IsValid);
		OnTouchPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchPressed");
		OnTouchPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchPressed_FunctionAddress);
		OnTouchPressed_IsValid = OnTouchPressed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchPressed", OnTouchPressed_IsValid);
		OnTouchReleased_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchReleased");
		OnTouchReleased_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchReleased_FunctionAddress);
		OnTouchReleased_IsValid = OnTouchReleased_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BP_ActorTouchDraggingController:OnTouchReleased", OnTouchReleased_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BP_ActorTouchDraggingController:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static BP_ActorTouchDraggingController()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BP_ActorTouchDraggingController)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BP_ActorTouchDraggingController));
	}
}
