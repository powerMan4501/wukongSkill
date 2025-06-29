using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGU.ActorComp;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic")]
public class BGUNvFlowCameraBlockLogic : UActorComponentCS
{
	private static bool CameraComp_IsValid;

	private static int CameraComp_Offset;

	private static bool ActorComp_IsValid;

	private static int ActorComp_Offset;

	private static bool CapsuleBlocker_IsValid;

	private static int CapsuleBlocker_Offset;

	private static bool CapsuleBlockerRaidusRate_IsValid;

	private static int CapsuleBlockerRaidusRate_Offset;

	private static bool Init_IsValid;

	private static IntPtr Init_FunctionAddress;

	private static int Init_ParamsSize;

	private static bool Init_Cam_IsValid;

	private static int Init_Cam_Offset;

	private static bool Init_Actor_IsValid;

	private static int Init_Actor_Offset;

	private static bool Init_Blocker_IsValid;

	private static int Init_Blocker_Offset;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CameraComp")]
	public USceneComponent CameraComp
	{
		get
		{
			CheckDestroyed();
			if (!CameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CameraComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, CameraComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CameraComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, CameraComp_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ActorComp")]
	public USceneComponent ActorComp
	{
		get
		{
			CheckDestroyed();
			if (!ActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ActorComp");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, ActorComp_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ActorComp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ActorComp");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, ActorComp_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlocker")]
	public UCapsuleComponent CapsuleBlocker
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleBlocker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlocker");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, CapsuleBlocker_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleBlocker_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlocker");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, CapsuleBlocker_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlockerRaidusRate")]
	public float CapsuleBlockerRaidusRate
	{
		get
		{
			CheckDestroyed();
			if (!CapsuleBlockerRaidusRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlockerRaidusRate");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CapsuleBlockerRaidusRate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CapsuleBlockerRaidusRate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:CapsuleBlockerRaidusRate");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CapsuleBlockerRaidusRate_Offset), value);
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:Init")]
	public void Init(USceneComponent Cam, USceneComponent Actor, UCapsuleComponent Blocker)
	{
		CameraComp = Cam;
		ActorComp = Actor;
		CapsuleBlocker = Blocker;
		if (CapsuleBlockerRaidusRate == 0f)
		{
			CapsuleBlockerRaidusRate = 0.1f;
		}
	}

	[USharpPath("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		if (CameraComp != null)
		{
			FVector worldLocation = CameraComp.GetWorldLocation();
			FVector worldLocation2 = ActorComp.GetWorldLocation();
			float num = (worldLocation - worldLocation2).Size();
			CapsuleBlocker.SetCapsuleHalfHeight(num);
			CapsuleBlocker.SetCapsuleRadius(num * CapsuleBlockerRaidusRate);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:Init")]
	private static void Init__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNvFlowCameraBlockLogic bGUNvFlowCameraBlockLogic = GCHelper.Find<BGUNvFlowCameraBlockLogic>(obj);
		USceneComponent cam = UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(buffer, Init_Cam_Offset));
		USceneComponent actor = UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(buffer, Init_Actor_Offset));
		UCapsuleComponent blocker = UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(buffer, Init_Blocker_Offset));
		bGUNvFlowCameraBlockLogic.Init(cam, actor, blocker);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUNvFlowCameraBlockLogic bGUNvFlowCameraBlockLogic = GCHelper.Find<BGUNvFlowCameraBlockLogic>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUNvFlowCameraBlockLogic.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUNvFlowCameraBlockLogic");
		CameraComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraComp");
		CameraComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraComp", Classes.FObjectProperty);
		ActorComp_Offset = NativeReflection.GetPropertyOffset(intPtr, "ActorComp");
		ActorComp_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ActorComp", Classes.FObjectProperty);
		CapsuleBlocker_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleBlocker");
		CapsuleBlocker_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleBlocker", Classes.FObjectProperty);
		CapsuleBlockerRaidusRate_Offset = NativeReflection.GetPropertyOffset(intPtr, "CapsuleBlockerRaidusRate");
		CapsuleBlockerRaidusRate_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CapsuleBlockerRaidusRate", Classes.FFloatProperty);
		Init_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "Init");
		Init_ParamsSize = NativeReflection.GetFunctionParamsSize(Init_FunctionAddress);
		Init_Cam_Offset = NativeReflection.GetPropertyOffset(Init_FunctionAddress, "Cam");
		Init_Cam_IsValid = NativeReflection.ValidatePropertyClass(Init_FunctionAddress, "Cam", Classes.FObjectProperty);
		Init_Actor_Offset = NativeReflection.GetPropertyOffset(Init_FunctionAddress, "Actor");
		Init_Actor_IsValid = NativeReflection.ValidatePropertyClass(Init_FunctionAddress, "Actor", Classes.FObjectProperty);
		Init_Blocker_Offset = NativeReflection.GetPropertyOffset(Init_FunctionAddress, "Blocker");
		Init_Blocker_IsValid = NativeReflection.ValidatePropertyClass(Init_FunctionAddress, "Blocker", Classes.FObjectProperty);
		Init_IsValid = Init_FunctionAddress != IntPtr.Zero && Init_Cam_IsValid && Init_Actor_IsValid && Init_Blocker_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:Init", Init_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUNvFlowCameraBlockLogic:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUNvFlowCameraBlockLogic()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUNvFlowCameraBlockLogic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUNvFlowCameraBlockLogic));
	}
}
