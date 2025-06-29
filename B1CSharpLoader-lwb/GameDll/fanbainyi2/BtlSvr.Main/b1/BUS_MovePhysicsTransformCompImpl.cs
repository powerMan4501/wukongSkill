using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_MovePhysicsTransformCompImpl")]
public class BUS_MovePhysicsTransformCompImpl : UActorCompBaseUObj
{
	private b1.BUC_MovePhysicsTransformData MovePhysicsTransformData;

	private static bool OnRootCompHit_IsValid;

	private static IntPtr OnRootCompHit_FunctionAddress;

	private static int OnRootCompHit_ParamsSize;

	private static bool OnRootCompHit_HitComp_IsValid;

	private static int OnRootCompHit_HitComp_Offset;

	private static bool OnRootCompHit_OtherActor_IsValid;

	private static int OnRootCompHit_OtherActor_Offset;

	private static bool OnRootCompHit_OtherComp_IsValid;

	private static int OnRootCompHit_OtherComp_Offset;

	private static bool OnRootCompHit_HitImpule_IsValid;

	private static int OnRootCompHit_HitImpule_Offset;

	private static FFieldAddress OnRootCompHit_HitImpule_PropertyAddress;

	private static bool OnRootCompHit_Hit_IsValid;

	private static int OnRootCompHit_Hit_Offset;

	private static FFieldAddress OnRootCompHit_Hit_PropertyAddress;

	public override void OnAttach()
	{
		MovePhysicsTransformData = RequireWritableData<b1.BUC_MovePhysicsTransformData>();
	}

	public override void OnBeginPlay()
	{
		if (MovePhysicsTransformData.bEnableMovePhysicsTransform)
		{
			ACharacter aCharacter = GetOwner() as ACharacter;
			if (!(aCharacter == null))
			{
				UBGUFunctionLibraryForCS.BGUBindOnComponentHitEvent(aCharacter.CapsuleComponent, this, B1GlobalFNames.OnRootCompHit);
			}
		}
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (MovePhysicsTransformData.bEnableMovePhysicsTransform)
		{
			if (MovePhysicsTransformData.ComponentHitTimer > 0f)
			{
				MovePhysicsTransformData.ComponentHitTimer -= DeltaTime;
			}
			TickPhysicsState(DeltaTime);
		}
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_MovePhysicsTransformCompImpl:OnRootCompHit")]
	private void OnRootCompHit(UPrimitiveComponent HitComp, AActor OtherActor, UPrimitiveComponent OtherComp, FVector HitImpule, FHitResult Hit)
	{
		if (MovePhysicsTransformData.bSimulatingPhysics || MovePhysicsTransformData.ComponentHitTimer > 0f)
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.Mesh == null))
		{
			UAnimInstance animInstance = aCharacter.Mesh.GetAnimInstance();
			if (!(animInstance == null) && !animInstance.IsAnyMontagePlaying())
			{
				SetSimulatePhysics(bSimulate: true);
				MovePhysicsTransformData.ComponentHitTimer = 1f;
			}
		}
	}

	private void SetSimulatePhysics(bool bSimulate)
	{
		ACharacter aCharacter = Owner as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		if (bSimulate)
		{
			if (MovePhysicsTransformData.bSimulatingPhysics)
			{
				return;
			}
			aCharacter.CapsuleComponent.SetSimulatePhysics(bSimulate: true);
		}
		else
		{
			aCharacter.CapsuleComponent.SetSimulatePhysics(bSimulate: false);
		}
		MovePhysicsTransformData.bSimulatingPhysics = bSimulate;
	}

	private void AddLocalGravity()
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null))
		{
			aCharacter.CapsuleComponent.AddForce(FVector.UpVector * MovePhysicsTransformData.GravityAddValue, FName.None, bAccelChange: true);
		}
	}

	private void TickPhysicsState(float DeltaTime)
	{
		if (!MovePhysicsTransformData.bSimulatingPhysics)
		{
			return;
		}
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null)
		{
			return;
		}
		MovePhysicsTransformData.PhysicsVelocity = aCharacter.CapsuleComponent.GetComponentVelocity();
		FRotator fRotator = BGUFuncLibActorTransformCS.BGUGetActorRotation(GetOwner());
		FRotator fRotator2 = fRotator;
		switch (MovePhysicsTransformData.RotationTypeDurningPhysicsState)
		{
		case EMovePhysicsRotationType.FollowVelocityXYPlane:
			if (MovePhysicsTransformData.PhysicsVelocity.Size() > 0.1f)
			{
				fRotator2.Yaw = MovePhysicsTransformData.PhysicsVelocity.Rotation().Yaw;
				fRotator2 = FMath.RInterpTo(fRotator, fRotator2, DeltaTime, 20f);
				fRotator2.Pitch = 0f;
				fRotator2.Roll = 0f;
			}
			break;
		case EMovePhysicsRotationType.FollowVelocity:
			if (MovePhysicsTransformData.PhysicsVelocity.Size() > 0.1f)
			{
				fRotator2 = MovePhysicsTransformData.PhysicsVelocity.Rotation();
				fRotator2 = FMath.RInterpTo(fRotator, fRotator2, DeltaTime, 20f);
			}
			break;
		}
		if (fRotator2 != fRotator)
		{
			BGUFuncLibActorTransformCS.BGUSetActorRotation(GetOwner(), fRotator2, bTeleportPhysics: true);
		}
		AddLocalGravity();
		CheckPhysicsStateFinish(DeltaTime);
	}

	private void CheckPhysicsStateFinish(float DeltaTime)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter != null && aCharacter.Mesh != null)
		{
			UAnimInstance animInstance = aCharacter.Mesh.GetAnimInstance();
			if (animInstance != null && animInstance.IsAnyMontagePlaying())
			{
				OnPhysicsStateFinish();
				MovePhysicsTransformData.CheckPhysicsStateFinishTimer = 0f;
				return;
			}
		}
		FHitResultSimple Result2;
		if (MovePhysicsTransformData.CheckPhysicsStateFinishTimer > 0f)
		{
			MovePhysicsTransformData.CheckPhysicsStateFinishTimer -= DeltaTime;
			if (MovePhysicsTransformData.CheckPhysicsStateFinishTimer <= 0f && TraceDown(out var _))
			{
				OnPhysicsStateFinish();
			}
		}
		else if (TraceDown(out Result2))
		{
			MovePhysicsTransformData.CheckPhysicsStateFinishTimer = 0.5f;
		}
	}

	private bool TraceDown(out FHitResultSimple Result)
	{
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (aCharacter == null || aCharacter.Mesh == null)
		{
			Result = null;
			return false;
		}
		FVector socketLocation = aCharacter.Mesh.GetSocketLocation(B1GlobalFNames.root);
		FVector lineTraceEnd = socketLocation + FVector.UpVector * -20.0;
		return BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(aCharacter, socketLocation, lineTraceEnd, out Result);
	}

	private void OnPhysicsStateFinish()
	{
		SetSimulatePhysics(bSimulate: false);
		ACharacter aCharacter = GetOwner() as ACharacter;
		if (!(aCharacter == null) && !(aCharacter.CharacterMovement == null))
		{
			FVector physicsVelocity = MovePhysicsTransformData.PhysicsVelocity;
			physicsVelocity.Z = 0f;
			aCharacter.CharacterMovement.Velocity = physicsVelocity;
			MovePhysicsTransformData.ComponentHitTimer = 0.5f;
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_MovePhysicsTransformCompImpl:OnRootCompHit")]
	private static void OnRootCompHit__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_MovePhysicsTransformCompImpl bUS_MovePhysicsTransformCompImpl = GCHelper.Find<BUS_MovePhysicsTransformCompImpl>(obj);
		UPrimitiveComponent hitComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnRootCompHit_HitComp_Offset));
		AActor otherActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, OnRootCompHit_OtherActor_Offset));
		UPrimitiveComponent otherComp = UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(buffer, OnRootCompHit_OtherComp_Offset));
		FVector hitImpule = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, OnRootCompHit_HitImpule_Offset));
		FHitResult hit = FHitResult.FromNative(IntPtr.Add(buffer, OnRootCompHit_Hit_Offset));
		bUS_MovePhysicsTransformCompImpl.OnRootCompHit(hitComp, otherActor, otherComp, hitImpule, hit);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_MovePhysicsTransformCompImpl");
		OnRootCompHit_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnRootCompHit");
		OnRootCompHit_ParamsSize = NativeReflection.GetFunctionParamsSize(OnRootCompHit_FunctionAddress);
		OnRootCompHit_HitComp_Offset = NativeReflection.GetPropertyOffset(OnRootCompHit_FunctionAddress, "HitComp");
		OnRootCompHit_HitComp_IsValid = NativeReflection.ValidatePropertyClass(OnRootCompHit_FunctionAddress, "HitComp", Classes.FObjectProperty);
		OnRootCompHit_OtherActor_Offset = NativeReflection.GetPropertyOffset(OnRootCompHit_FunctionAddress, "OtherActor");
		OnRootCompHit_OtherActor_IsValid = NativeReflection.ValidatePropertyClass(OnRootCompHit_FunctionAddress, "OtherActor", Classes.FObjectProperty);
		OnRootCompHit_OtherComp_Offset = NativeReflection.GetPropertyOffset(OnRootCompHit_FunctionAddress, "OtherComp");
		OnRootCompHit_OtherComp_IsValid = NativeReflection.ValidatePropertyClass(OnRootCompHit_FunctionAddress, "OtherComp", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref OnRootCompHit_HitImpule_PropertyAddress, OnRootCompHit_FunctionAddress, "HitImpule");
		OnRootCompHit_HitImpule_Offset = NativeReflection.GetPropertyOffset(OnRootCompHit_FunctionAddress, "HitImpule");
		OnRootCompHit_HitImpule_IsValid = NativeReflection.ValidatePropertyClass(OnRootCompHit_FunctionAddress, "HitImpule", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref OnRootCompHit_Hit_PropertyAddress, OnRootCompHit_FunctionAddress, "Hit");
		OnRootCompHit_Hit_Offset = NativeReflection.GetPropertyOffset(OnRootCompHit_FunctionAddress, "Hit");
		OnRootCompHit_Hit_IsValid = NativeReflection.ValidatePropertyClass(OnRootCompHit_FunctionAddress, "Hit", Classes.FStructProperty);
		OnRootCompHit_IsValid = OnRootCompHit_FunctionAddress != IntPtr.Zero && OnRootCompHit_HitComp_IsValid && OnRootCompHit_OtherActor_IsValid && OnRootCompHit_OtherComp_IsValid && OnRootCompHit_HitImpule_IsValid && OnRootCompHit_Hit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_MovePhysicsTransformCompImpl:OnRootCompHit", OnRootCompHit_IsValid);
	}

	static BUS_MovePhysicsTransformCompImpl()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_MovePhysicsTransformCompImpl)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_MovePhysicsTransformCompImpl));
	}
}
