using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.GSUI;

[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.MouseInputControlActor")]
public class MouseInputControlActor : AActor
{
	private APlayerController playerController;

	private UInputComponent inputComponent;

	private APlayerCameraManager camManager;

	private static bool traceChnl_IsValid;

	private static int traceChnl_Offset;

	private static FFieldAddress traceChnl_PropertyAddress;

	private static bool sphereActor_IsValid;

	private static int sphereActor_Offset;

	private static bool verticalOffset_IsValid;

	private static int verticalOffset_Offset;

	private static bool OnTouchPressed_IsValid;

	private static IntPtr OnTouchPressed_FunctionAddress;

	private static int OnTouchPressed_ParamsSize;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.MouseInputControlActor:traceChnl")]
	public ETraceTypeQuery traceChnl
	{
		get
		{
			CheckDestroyed();
			if (!traceChnl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:traceChnl");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, traceChnl_Offset), 0, traceChnl_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!traceChnl_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:traceChnl");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, traceChnl_Offset), 0, traceChnl_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.MouseInputControlActor:sphereActor")]
	public AActor sphereActor
	{
		get
		{
			CheckDestroyed();
			if (!sphereActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:sphereActor");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, sphereActor_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!sphereActor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:sphereActor");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, sphereActor_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.MouseInputControlActor:verticalOffset")]
	public float verticalOffset
	{
		get
		{
			CheckDestroyed();
			if (!verticalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:verticalOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, verticalOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!verticalOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.MouseInputControlActor:verticalOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, verticalOffset_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.MouseInputControlActor:ReceiveBeginPlay")]
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
			}
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.MouseInputControlActor:OnTouchPressed")]
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
			FVector newLocation = new FVector(OutHit.Location.X, OutHit.Location.Y, OutHit.Location.Z + (double)verticalOffset);
			if (sphereActor.RootComponent.Mobility == EComponentMobility.Movable)
			{
				sphereActor.SetActorLocation(newLocation, bSweep: false, out var _, bTeleport: false);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.MouseInputControlActor:OnTouchPressed")]
	private static void OnTouchPressed__Invoker(IntPtr buffer, IntPtr obj)
	{
		MouseInputControlActor mouseInputControlActor = GCHelper.Find<MouseInputControlActor>(obj);
		mouseInputControlActor.OnTouchPressed();
	}

	[UFunctionInvoker("/Script/b1-Managed.MouseInputControlActor:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		MouseInputControlActor mouseInputControlActor = GCHelper.Find<MouseInputControlActor>(obj);
		mouseInputControlActor.ReceiveBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MouseInputControlActor");
		NativeReflection.GetPropertyRef(ref traceChnl_PropertyAddress, intPtr, "traceChnl");
		traceChnl_Offset = NativeReflection.GetPropertyOffset(intPtr, "traceChnl");
		traceChnl_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "traceChnl", Classes.FEnumProperty);
		sphereActor_Offset = NativeReflection.GetPropertyOffset(intPtr, "sphereActor");
		sphereActor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "sphereActor", Classes.FObjectProperty);
		verticalOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "verticalOffset");
		verticalOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "verticalOffset", Classes.FFloatProperty);
		OnTouchPressed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnTouchPressed");
		OnTouchPressed_ParamsSize = NativeReflection.GetFunctionParamsSize(OnTouchPressed_FunctionAddress);
		OnTouchPressed_IsValid = OnTouchPressed_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MouseInputControlActor:OnTouchPressed", OnTouchPressed_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.MouseInputControlActor:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
	}

	static MouseInputControlActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MouseInputControlActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MouseInputControlActor));
	}
}
