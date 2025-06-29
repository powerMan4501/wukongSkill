using System;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUChapterCameraActor")]
public class BGUChapterCameraActor : AActor
{
	private static bool SceneRoot_IsValid;

	private static int SceneRoot_Offset;

	private static bool CameraBoom1_IsValid;

	private static int CameraBoom1_Offset;

	private static bool BoomPerformance_IsValid;

	private static int BoomPerformance_Offset;

	private static bool FollowCamera_IsValid;

	private static int FollowCamera_Offset;

	private static bool FollowPoint_IsValid;

	private static int FollowPoint_Offset;

	private static bool CameraLineTraceDistance_IsValid;

	private static int CameraLineTraceDistance_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:SceneRoot")]
	public USphereComponent SceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:SceneRoot");
				return null;
			}
			return UObjectMarshaler<USphereComponent>.FromNative(IntPtr.Add(base.Address, SceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:SceneRoot");
			}
			else
			{
				UObjectMarshaler<USphereComponent>.ToNative(IntPtr.Add(base.Address, SceneRoot_Offset), value);
			}
		}
	}

	[UProperty]
	[AllowPrivateAccess]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:CameraBoom1")]
	public BUS_SpringArmComponent CameraBoom1
	{
		get
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:CameraBoom1");
				return null;
			}
			return UObjectMarshaler<BUS_SpringArmComponent>.FromNative(IntPtr.Add(base.Address, CameraBoom1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:CameraBoom1");
			}
			else
			{
				UObjectMarshaler<BUS_SpringArmComponent>.ToNative(IntPtr.Add(base.Address, CameraBoom1_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:BoomPerformance")]
	public USceneComponent BoomPerformance
	{
		get
		{
			CheckDestroyed();
			if (!BoomPerformance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:BoomPerformance");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, BoomPerformance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoomPerformance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:BoomPerformance");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, BoomPerformance_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[AllowPrivateAccess]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:FollowCamera")]
	public UCineCameraComponent FollowCamera
	{
		get
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:FollowCamera");
				return null;
			}
			return UObjectMarshaler<UCineCameraComponent>.FromNative(IntPtr.Add(base.Address, FollowCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:FollowCamera");
			}
			else
			{
				UObjectMarshaler<UCineCameraComponent>.ToNative(IntPtr.Add(base.Address, FollowCamera_Offset), value);
			}
		}
	}

	[AllowPrivateAccess]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:FollowPoint")]
	public UPointLightComponent FollowPoint
	{
		get
		{
			CheckDestroyed();
			if (!FollowPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:FollowPoint");
				return null;
			}
			return UObjectMarshaler<UPointLightComponent>.FromNative(IntPtr.Add(base.Address, FollowPoint_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:FollowPoint");
			}
			else
			{
				UObjectMarshaler<UPointLightComponent>.ToNative(IntPtr.Add(base.Address, FollowPoint_Offset), value);
			}
		}
	}

	[AllowPrivateAccess]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUChapterCameraActor:CameraLineTraceDistance")]
	public float CameraLineTraceDistance
	{
		get
		{
			CheckDestroyed();
			if (!CameraLineTraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:CameraLineTraceDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraLineTraceDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraLineTraceDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUChapterCameraActor:CameraLineTraceDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraLineTraceDistance_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneRoot = initializer.CreateDefaultSubobject<USphereComponent>(this, B1GlobalFNames.SceneRoot);
		SceneRoot.SetSphereRadius(10f);
		base.RootComponent = SceneRoot;
		CameraBoom1 = initializer.CreateDefaultSubobject<BUS_SpringArmComponent>(this, B1GlobalFNames.CameraBoom1);
		CameraBoom1.AttachToComponent(base.RootComponent, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		CameraBoom1.TargetArmLength = 0f;
		CameraBoom1.UsePawnControlRotation = false;
		CameraBoom1.EnableCameraLag = true;
		BoomPerformance = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.BoomPerformance);
		BoomPerformance.AttachToComponent(CameraBoom1, B1GlobalFNames.SpringEndpoint, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		FollowCamera = initializer.CreateDefaultSubobject<UCineCameraComponent>(this, B1GlobalFNames.FollowCamera);
		FollowCamera.AttachToComponent(BoomPerformance, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
		FollowCamera.UsePawnControlRotation = false;
		FollowPoint = initializer.CreateDefaultSubobject<UPointLightComponent>(this, B1GlobalFNames.FollowPoint);
		FollowPoint.AttachToComponent(BoomPerformance, FName.None, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, EAttachmentRule.KeepRelative, bWeldSimulatedBodies: false);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUChapterCameraActor");
		SceneRoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneRoot");
		SceneRoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneRoot", Classes.FObjectProperty);
		CameraBoom1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBoom1");
		CameraBoom1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBoom1", Classes.FObjectProperty);
		BoomPerformance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoomPerformance");
		BoomPerformance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoomPerformance", Classes.FObjectProperty);
		FollowCamera_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FollowCamera");
		FollowCamera_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FollowCamera", Classes.FObjectProperty);
		FollowPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FollowPoint");
		FollowPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FollowPoint", Classes.FObjectProperty);
		CameraLineTraceDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraLineTraceDistance");
		CameraLineTraceDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraLineTraceDistance", Classes.FFloatProperty);
	}

	static BGUChapterCameraActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUChapterCameraActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUChapterCameraActor));
	}
}
