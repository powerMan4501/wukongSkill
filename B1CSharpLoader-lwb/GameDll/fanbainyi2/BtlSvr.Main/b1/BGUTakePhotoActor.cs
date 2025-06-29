using System;
using UnrealEngine.CinematicCamera;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUTakePhotoActor")]
public class BGUTakePhotoActor : AActor
{
	private static bool SceneRoot_IsValid;

	private static int SceneRoot_Offset;

	private static bool CameraBoom1_IsValid;

	private static int CameraBoom1_Offset;

	private static bool BoomPerformance_IsValid;

	private static int BoomPerformance_Offset;

	private static bool FollowCamera_IsValid;

	private static int FollowCamera_Offset;

	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTakePhotoActor:SceneRoot")]
	public UCapsuleComponent SceneRoot
	{
		get
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:SceneRoot");
				return null;
			}
			return UObjectMarshaler<UCapsuleComponent>.FromNative(IntPtr.Add(base.Address, SceneRoot_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneRoot_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:SceneRoot");
			}
			else
			{
				UObjectMarshaler<UCapsuleComponent>.ToNative(IntPtr.Add(base.Address, SceneRoot_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[AllowPrivateAccess]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTakePhotoActor:CameraBoom1")]
	public BUS_SpringArmComponent CameraBoom1
	{
		get
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:CameraBoom1");
				return null;
			}
			return UObjectMarshaler<BUS_SpringArmComponent>.FromNative(IntPtr.Add(base.Address, CameraBoom1_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraBoom1_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:CameraBoom1");
			}
			else
			{
				UObjectMarshaler<BUS_SpringArmComponent>.ToNative(IntPtr.Add(base.Address, CameraBoom1_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUTakePhotoActor:BoomPerformance")]
	public USceneComponent BoomPerformance
	{
		get
		{
			CheckDestroyed();
			if (!BoomPerformance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:BoomPerformance");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, BoomPerformance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoomPerformance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:BoomPerformance");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, BoomPerformance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[AllowPrivateAccess]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUTakePhotoActor:FollowCamera")]
	public UCineCameraComponent FollowCamera
	{
		get
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:FollowCamera");
				return null;
			}
			return UObjectMarshaler<UCineCameraComponent>.FromNative(IntPtr.Add(base.Address, FollowCamera_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FollowCamera_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUTakePhotoActor:FollowCamera");
			}
			else
			{
				UObjectMarshaler<UCineCameraComponent>.ToNative(IntPtr.Add(base.Address, FollowCamera_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		SceneRoot = initializer.CreateDefaultSubobject<UCapsuleComponent>(this, B1GlobalFNames.SceneRoot);
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
	}

	public void SetCameraFOV(float TargetFOV)
	{
		FollowCamera.SetFieldOfView(TargetFOV);
	}

	public void SetEnableCameraLag(bool IsEnable)
	{
		CameraBoom1.EnableCameraLag = IsEnable;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUTakePhotoActor");
		SceneRoot_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneRoot");
		SceneRoot_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneRoot", Classes.FObjectProperty);
		CameraBoom1_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraBoom1");
		CameraBoom1_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraBoom1", Classes.FObjectProperty);
		BoomPerformance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoomPerformance");
		BoomPerformance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoomPerformance", Classes.FObjectProperty);
		FollowCamera_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FollowCamera");
		FollowCamera_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FollowCamera", Classes.FObjectProperty);
	}

	static BGUTakePhotoActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUTakePhotoActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUTakePhotoActor));
	}
}
