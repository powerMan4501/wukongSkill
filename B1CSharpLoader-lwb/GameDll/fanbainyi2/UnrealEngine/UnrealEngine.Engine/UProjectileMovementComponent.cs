using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)821035172uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.ProjectileMovementComponent", "Engine", UnrealModuleType.Engine)]
public class UProjectileMovementComponent : UMovementComponent
{
	[UDelegate]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature")]
	public class FOnProjectileStopDelegate : FMulticastDelegate<FOnProjectileStopDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult);

		private static bool OnProjectileStopDelegate__DelegateSignature_IsValid;

		private static IntPtr OnProjectileStopDelegate__DelegateSignature_FunctionAddress;

		private static int OnProjectileStopDelegate__DelegateSignature_ParamsSize;

		private static bool OnProjectileStopDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnProjectileStopDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnProjectileStopDelegate__DelegateSignature_ImpactResult_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnProjectileStopDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnProjectileStopDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature");
			OnProjectileStopDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnProjectileStopDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnProjectileStopDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnProjectileStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnProjectileStopDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnProjectileStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnProjectileStopDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnProjectileStopDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			OnProjectileStopDelegate__DelegateSignature_IsValid = OnProjectileStopDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnProjectileStopDelegate__DelegateSignature_ImpactResult_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature", OnProjectileStopDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult)
		{
			if (!OnProjectileStopDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:OnProjectileStopDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnProjectileStopDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnProjectileStopDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnProjectileStopDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnProjectileStopDelegate__DelegateSignature_ImpactResult_Offset), 0, OnProjectileStopDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				ProcessDelegate(intPtr);
			}
		}
	}

	[UDelegate]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature")]
	public class FOnProjectileBounceDelegate : FMulticastDelegate<FOnProjectileBounceDelegate.Signature>
	{
		public delegate void Signature(FHitResult ImpactResult, FVector ImpactVelocity);

		private static bool OnProjectileBounceDelegate__DelegateSignature_IsValid;

		private static IntPtr OnProjectileBounceDelegate__DelegateSignature_FunctionAddress;

		private static int OnProjectileBounceDelegate__DelegateSignature_ParamsSize;

		private static bool OnProjectileBounceDelegate__DelegateSignature_ImpactResult_IsValid;

		private static FFieldAddress OnProjectileBounceDelegate__DelegateSignature_ImpactResult_PropertyAddress;

		private static int OnProjectileBounceDelegate__DelegateSignature_ImpactResult_Offset;

		private static bool OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_IsValid;

		private static FFieldAddress OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_PropertyAddress;

		private static int OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_Offset;

		public override Signature GetInvoker()
		{
			return Invoker;
		}

		static FOnProjectileBounceDelegate()
		{
			LoadNativeType();
		}

		private static void LoadNativeType()
		{
			OnProjectileBounceDelegate__DelegateSignature_FunctionAddress = NativeReflection.GetFunction("/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature");
			OnProjectileBounceDelegate__DelegateSignature_ParamsSize = NativeReflection.GetFunctionParamsSize(OnProjectileBounceDelegate__DelegateSignature_FunctionAddress);
			NativeReflectionCached.GetPropertyRef(ref OnProjectileBounceDelegate__DelegateSignature_ImpactResult_PropertyAddress, OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnProjectileBounceDelegate__DelegateSignature_ImpactResult_Offset = NativeReflectionCached.GetPropertyOffset(OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactResult");
			OnProjectileBounceDelegate__DelegateSignature_ImpactResult_IsValid = NativeReflectionCached.ValidatePropertyClass(OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactResult", Classes.FStructProperty);
			NativeReflectionCached.GetPropertyRef(ref OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_PropertyAddress, OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactVelocity");
			OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_Offset = NativeReflectionCached.GetPropertyOffset(OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactVelocity");
			OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(OnProjectileBounceDelegate__DelegateSignature_FunctionAddress, "ImpactVelocity", Classes.FStructProperty);
			OnProjectileBounceDelegate__DelegateSignature_IsValid = OnProjectileBounceDelegate__DelegateSignature_FunctionAddress != IntPtr.Zero && OnProjectileBounceDelegate__DelegateSignature_ImpactResult_IsValid && OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_IsValid;
			NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature", OnProjectileBounceDelegate__DelegateSignature_IsValid);
		}

		private unsafe void Invoker(FHitResult ImpactResult, FVector ImpactVelocity)
		{
			if (!OnProjectileBounceDelegate__DelegateSignature_IsValid)
			{
				NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:OnProjectileBounceDelegate__DelegateSignature");
			}
			else if (IsBound)
			{
				byte* ptr = stackalloc byte[(int)(uint)(OnProjectileBounceDelegate__DelegateSignature_ParamsSize + 16)];
				int num = (int)((16L - (long)ptr) & 0xF);
				byte* ptr2 = ptr + num;
				Unsafe.InitBlockUnaligned(ptr2, 0, (uint)OnProjectileBounceDelegate__DelegateSignature_ParamsSize);
				IntPtr intPtr = new IntPtr(ptr2);
				NativeReflection.InitializeValue_InContainer(OnProjectileBounceDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, intPtr);
				FHitResult.ToNative(IntPtr.Add(intPtr, OnProjectileBounceDelegate__DelegateSignature_ImpactResult_Offset), 0, OnProjectileBounceDelegate__DelegateSignature_ImpactResult_PropertyAddress.Address, ImpactResult);
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_Offset), 0, OnProjectileBounceDelegate__DelegateSignature_ImpactVelocity_PropertyAddress.Address, ImpactVelocity);
				ProcessDelegate(intPtr);
			}
		}
	}

	private static bool InitialSpeed_IsValid;

	private static int InitialSpeed_Offset;

	private static bool MaxSpeed_IsValid;

	private static int MaxSpeed_Offset;

	private static bool RotationFollowsVelocity_IsValid;

	private static FFieldAddress RotationFollowsVelocity_PropertyAddress;

	private static int RotationFollowsVelocity_Offset;

	private static bool RotationRemainsVertical_IsValid;

	private static FFieldAddress RotationRemainsVertical_PropertyAddress;

	private static int RotationRemainsVertical_Offset;

	private static bool ShouldBounce_IsValid;

	private static FFieldAddress ShouldBounce_PropertyAddress;

	private static int ShouldBounce_Offset;

	private static bool InitialVelocityInLocalSpace_IsValid;

	private static FFieldAddress InitialVelocityInLocalSpace_PropertyAddress;

	private static int InitialVelocityInLocalSpace_Offset;

	private static bool ForceSubStepping_IsValid;

	private static FFieldAddress ForceSubStepping_PropertyAddress;

	private static int ForceSubStepping_Offset;

	private static bool SimulationEnabled_IsValid;

	private static FFieldAddress SimulationEnabled_PropertyAddress;

	private static int SimulationEnabled_Offset;

	private static bool SweepCollision_IsValid;

	private static FFieldAddress SweepCollision_PropertyAddress;

	private static int SweepCollision_Offset;

	private static bool IsHomingProjectile_IsValid;

	private static FFieldAddress IsHomingProjectile_PropertyAddress;

	private static int IsHomingProjectile_Offset;

	private static bool BounceAngleAffectsFriction_IsValid;

	private static FFieldAddress BounceAngleAffectsFriction_PropertyAddress;

	private static int BounceAngleAffectsFriction_Offset;

	private static bool IsSliding_IsValid;

	private static FFieldAddress IsSliding_PropertyAddress;

	private static int IsSliding_Offset;

	private static bool InterpMovement_IsValid;

	private static FFieldAddress InterpMovement_PropertyAddress;

	private static int InterpMovement_Offset;

	private static bool InterpRotation_IsValid;

	private static FFieldAddress InterpRotation_PropertyAddress;

	private static int InterpRotation_Offset;

	private static bool PreviousHitTime_IsValid;

	private static int PreviousHitTime_Offset;

	private static bool PreviousHitNormal_IsValid;

	private static int PreviousHitNormal_Offset;

	private static bool ProjectileGravityScale_IsValid;

	private static int ProjectileGravityScale_Offset;

	private static bool Bounciness_IsValid;

	private static int Bounciness_Offset;

	private static bool Friction_IsValid;

	private static int Friction_Offset;

	private static bool BounceVelocityStopSimulatingThreshold_IsValid;

	private static int BounceVelocityStopSimulatingThreshold_Offset;

	private static bool MinFrictionFraction_IsValid;

	private static int MinFrictionFraction_Offset;

	private static bool OnProjectileBounce_IsValid;

	private static int OnProjectileBounce_Offset;

	private FOnProjectileBounceDelegate OnProjectileBounce_DelegateCached;

	private static bool OnProjectileStop_IsValid;

	private static int OnProjectileStop_Offset;

	private FOnProjectileStopDelegate OnProjectileStop_DelegateCached;

	private static bool HomingAccelerationMagnitude_IsValid;

	private static int HomingAccelerationMagnitude_Offset;

	private static bool HomingTargetComponent_IsValid;

	private static int HomingTargetComponent_Offset;

	private static bool MaxSimulationTimeStep_IsValid;

	private static int MaxSimulationTimeStep_Offset;

	private static bool MaxSimulationIterations_IsValid;

	private static int MaxSimulationIterations_Offset;

	private static bool BounceAdditionalIterations_IsValid;

	private static int BounceAdditionalIterations_Offset;

	private static bool InterpLocationTime_IsValid;

	private static int InterpLocationTime_Offset;

	private static bool InterpRotationTime_IsValid;

	private static int InterpRotationTime_Offset;

	private static bool InterpLocationMaxLagDistance_IsValid;

	private static int InterpLocationMaxLagDistance_Offset;

	private static bool InterpLocationSnapToTargetDistance_IsValid;

	private static int InterpLocationSnapToTargetDistance_Offset;

	private static bool StopSimulating_IsValid;

	private static IntPtr StopSimulating_FunctionAddress;

	private static int StopSimulating_ParamsSize;

	private static bool StopSimulating_HitResult_IsValid;

	private static FFieldAddress StopSimulating_HitResult_PropertyAddress;

	private static int StopSimulating_HitResult_Offset;

	private static bool SetVelocityInLocalSpace_IsValid;

	private static IntPtr SetVelocityInLocalSpace_FunctionAddress;

	private static int SetVelocityInLocalSpace_ParamsSize;

	private static bool SetVelocityInLocalSpace_NewVelocity_IsValid;

	private static FFieldAddress SetVelocityInLocalSpace_NewVelocity_PropertyAddress;

	private static int SetVelocityInLocalSpace_NewVelocity_Offset;

	private static bool SetInterpolatedComponent_IsValid;

	private static IntPtr SetInterpolatedComponent_FunctionAddress;

	private static int SetInterpolatedComponent_ParamsSize;

	private static bool SetInterpolatedComponent_Component_IsValid;

	private static FFieldAddress SetInterpolatedComponent_Component_PropertyAddress;

	private static int SetInterpolatedComponent_Component_Offset;

	private static bool ResetInterpolation_IsValid;

	private static IntPtr ResetInterpolation_FunctionAddress;

	private static int ResetInterpolation_ParamsSize;

	private static bool MoveInterpolationTarget_IsValid;

	private static IntPtr MoveInterpolationTarget_FunctionAddress;

	private static int MoveInterpolationTarget_ParamsSize;

	private static bool MoveInterpolationTarget_NewLocation_IsValid;

	private static FFieldAddress MoveInterpolationTarget_NewLocation_PropertyAddress;

	private static int MoveInterpolationTarget_NewLocation_Offset;

	private static bool MoveInterpolationTarget_NewRotation_IsValid;

	private static FFieldAddress MoveInterpolationTarget_NewRotation_PropertyAddress;

	private static int MoveInterpolationTarget_NewRotation_Offset;

	private static bool LimitVelocity_IsValid;

	private static IntPtr LimitVelocity_FunctionAddress;

	private static int LimitVelocity_ParamsSize;

	private static bool LimitVelocity_NewVelocity_IsValid;

	private static FFieldAddress LimitVelocity_NewVelocity_PropertyAddress;

	private static int LimitVelocity_NewVelocity_Offset;

	private static bool LimitVelocity_ReturnValue_IsValid;

	private static FFieldAddress LimitVelocity_ReturnValue_PropertyAddress;

	private static int LimitVelocity_ReturnValue_Offset;

	private static bool IsVelocityUnderSimulationThreshold_IsValid;

	private static IntPtr IsVelocityUnderSimulationThreshold_FunctionAddress;

	private static int IsVelocityUnderSimulationThreshold_ParamsSize;

	private static bool IsVelocityUnderSimulationThreshold_ReturnValue_IsValid;

	private static FFieldAddress IsVelocityUnderSimulationThreshold_ReturnValue_PropertyAddress;

	private static int IsVelocityUnderSimulationThreshold_ReturnValue_Offset;

	private static bool IsInterpolationComplete_IsValid;

	private static IntPtr IsInterpolationComplete_FunctionAddress;

	private static int IsInterpolationComplete_ParamsSize;

	private static bool IsInterpolationComplete_ReturnValue_IsValid;

	private static FFieldAddress IsInterpolationComplete_ReturnValue_PropertyAddress;

	private static int IsInterpolationComplete_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:InitialSpeed")]
	public float InitialSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InitialSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InitialSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InitialSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InitialSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InitialSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InitialSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:MaxSpeed")]
	public float MaxSpeed
	{
		get
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSpeed_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bRotationFollowsVelocity")]
	public bool RotationFollowsVelocity
	{
		get
		{
			CheckDestroyed();
			if (!RotationFollowsVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bRotationFollowsVelocity");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RotationFollowsVelocity_Offset), 0, RotationFollowsVelocity_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationFollowsVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bRotationFollowsVelocity");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RotationFollowsVelocity_Offset), 0, RotationFollowsVelocity_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bRotationRemainsVertical")]
	public bool RotationRemainsVertical
	{
		get
		{
			CheckDestroyed();
			if (!RotationRemainsVertical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bRotationRemainsVertical");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, RotationRemainsVertical_Offset), 0, RotationRemainsVertical_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!RotationRemainsVertical_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bRotationRemainsVertical");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, RotationRemainsVertical_Offset), 0, RotationRemainsVertical_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bShouldBounce")]
	public bool ShouldBounce
	{
		get
		{
			CheckDestroyed();
			if (!ShouldBounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bShouldBounce");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ShouldBounce_Offset), 0, ShouldBounce_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ShouldBounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bShouldBounce");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ShouldBounce_Offset), 0, ShouldBounce_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bInitialVelocityInLocalSpace")]
	public bool InitialVelocityInLocalSpace
	{
		get
		{
			CheckDestroyed();
			if (!InitialVelocityInLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInitialVelocityInLocalSpace");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InitialVelocityInLocalSpace_Offset), 0, InitialVelocityInLocalSpace_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InitialVelocityInLocalSpace_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInitialVelocityInLocalSpace");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InitialVelocityInLocalSpace_Offset), 0, InitialVelocityInLocalSpace_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bForceSubStepping")]
	public bool ForceSubStepping
	{
		get
		{
			CheckDestroyed();
			if (!ForceSubStepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bForceSubStepping");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ForceSubStepping_Offset), 0, ForceSubStepping_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ForceSubStepping_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bForceSubStepping");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ForceSubStepping_Offset), 0, ForceSubStepping_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bSimulationEnabled")]
	public bool SimulationEnabled
	{
		get
		{
			CheckDestroyed();
			if (!SimulationEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bSimulationEnabled");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimulationEnabled_Offset), 0, SimulationEnabled_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimulationEnabled_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bSimulationEnabled");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimulationEnabled_Offset), 0, SimulationEnabled_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bSweepCollision")]
	public bool SweepCollision
	{
		get
		{
			CheckDestroyed();
			if (!SweepCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bSweepCollision");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SweepCollision_Offset), 0, SweepCollision_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SweepCollision_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bSweepCollision");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SweepCollision_Offset), 0, SweepCollision_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bIsHomingProjectile")]
	public bool IsHomingProjectile
	{
		get
		{
			CheckDestroyed();
			if (!IsHomingProjectile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bIsHomingProjectile");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsHomingProjectile_Offset), 0, IsHomingProjectile_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsHomingProjectile_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bIsHomingProjectile");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsHomingProjectile_Offset), 0, IsHomingProjectile_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bBounceAngleAffectsFriction")]
	public bool BounceAngleAffectsFriction
	{
		get
		{
			CheckDestroyed();
			if (!BounceAngleAffectsFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bBounceAngleAffectsFriction");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BounceAngleAffectsFriction_Offset), 0, BounceAngleAffectsFriction_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BounceAngleAffectsFriction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bBounceAngleAffectsFriction");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BounceAngleAffectsFriction_Offset), 0, BounceAngleAffectsFriction_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160665621uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bIsSliding")]
	public bool IsSliding
	{
		get
		{
			CheckDestroyed();
			if (!IsSliding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bIsSliding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSliding_Offset), 0, IsSliding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSliding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bIsSliding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSliding_Offset), 0, IsSliding_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bInterpMovement")]
	public bool InterpMovement
	{
		get
		{
			CheckDestroyed();
			if (!InterpMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInterpMovement");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InterpMovement_Offset), 0, InterpMovement_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InterpMovement_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInterpMovement");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InterpMovement_Offset), 0, InterpMovement_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:bInterpRotation")]
	public bool InterpRotation
	{
		get
		{
			CheckDestroyed();
			if (!InterpRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInterpRotation");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InterpRotation_Offset), 0, InterpRotation_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InterpRotation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:bInterpRotation");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InterpRotation_Offset), 0, InterpRotation_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:PreviousHitTime")]
	public float PreviousHitTime
	{
		get
		{
			CheckDestroyed();
			if (!PreviousHitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:PreviousHitTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PreviousHitTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousHitTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:PreviousHitTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PreviousHitTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234407957uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:PreviousHitNormal")]
	public FVector PreviousHitNormal
	{
		get
		{
			CheckDestroyed();
			if (!PreviousHitNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:PreviousHitNormal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PreviousHitNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PreviousHitNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:PreviousHitNormal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PreviousHitNormal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:ProjectileGravityScale")]
	public float ProjectileGravityScale
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileGravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:ProjectileGravityScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProjectileGravityScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileGravityScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:ProjectileGravityScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProjectileGravityScale_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:Bounciness")]
	public float Bounciness
	{
		get
		{
			CheckDestroyed();
			if (!Bounciness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:Bounciness");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Bounciness_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Bounciness_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:Bounciness");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Bounciness_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:Friction")]
	public float Friction
	{
		get
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:Friction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Friction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Friction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:Friction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Friction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:BounceVelocityStopSimulatingThreshold")]
	public float BounceVelocityStopSimulatingThreshold
	{
		get
		{
			CheckDestroyed();
			if (!BounceVelocityStopSimulatingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:BounceVelocityStopSimulatingThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BounceVelocityStopSimulatingThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BounceVelocityStopSimulatingThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:BounceVelocityStopSimulatingThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BounceVelocityStopSimulatingThreshold_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:MinFrictionFraction")]
	public float MinFrictionFraction
	{
		get
		{
			CheckDestroyed();
			if (!MinFrictionFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MinFrictionFraction");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinFrictionFraction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinFrictionFraction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MinFrictionFraction");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinFrictionFraction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:OnProjectileBounce")]
	public FOnProjectileBounceDelegate OnProjectileBounce
	{
		get
		{
			CheckDestroyed();
			if (!OnProjectileBounce_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:OnProjectileBounce");
				return new FOnProjectileBounceDelegate();
			}
			if (OnProjectileBounce_DelegateCached == null)
			{
				OnProjectileBounce_DelegateCached = new FOnProjectileBounceDelegate();
				OnProjectileBounce_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnProjectileBounce_Offset));
			}
			return OnProjectileBounce_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:OnProjectileStop")]
	public FOnProjectileStopDelegate OnProjectileStop
	{
		get
		{
			CheckDestroyed();
			if (!OnProjectileStop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:OnProjectileStop");
				return new FOnProjectileStopDelegate();
			}
			if (OnProjectileStop_DelegateCached == null)
			{
				OnProjectileStop_DelegateCached = new FOnProjectileStopDelegate();
				OnProjectileStop_DelegateCached.SetAddress(IntPtr.Add(base.Address, OnProjectileStop_Offset));
			}
			return OnProjectileStop_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:HomingAccelerationMagnitude")]
	public float HomingAccelerationMagnitude
	{
		get
		{
			CheckDestroyed();
			if (!HomingAccelerationMagnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:HomingAccelerationMagnitude");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HomingAccelerationMagnitude_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HomingAccelerationMagnitude_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:HomingAccelerationMagnitude");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HomingAccelerationMagnitude_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369141774861uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:HomingTargetComponent")]
	public TWeakObject<USceneComponent> HomingTargetComponent
	{
		get
		{
			CheckDestroyed();
			if (!HomingTargetComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:HomingTargetComponent");
				return default(TWeakObject<USceneComponent>);
			}
			return TWeakObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, HomingTargetComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HomingTargetComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:HomingTargetComponent");
			}
			else
			{
				TWeakObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, HomingTargetComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:MaxSimulationTimeStep")]
	public float MaxSimulationTimeStep
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSimulationTimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationTimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSimulationTimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxSimulationTimeStep_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:MaxSimulationIterations")]
	public int MaxSimulationIterations
	{
		get
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSimulationIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxSimulationIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:MaxSimulationIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxSimulationIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:BounceAdditionalIterations")]
	public int BounceAdditionalIterations
	{
		get
		{
			CheckDestroyed();
			if (!BounceAdditionalIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:BounceAdditionalIterations");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, BounceAdditionalIterations_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BounceAdditionalIterations_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:BounceAdditionalIterations");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, BounceAdditionalIterations_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:InterpLocationTime")]
	public float InterpLocationTime
	{
		get
		{
			CheckDestroyed();
			if (!InterpLocationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpLocationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpLocationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpLocationTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:InterpRotationTime")]
	public float InterpRotationTime
	{
		get
		{
			CheckDestroyed();
			if (!InterpRotationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpRotationTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpRotationTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpRotationTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpRotationTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpRotationTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:InterpLocationMaxLagDistance")]
	public float InterpLocationMaxLagDistance
	{
		get
		{
			CheckDestroyed();
			if (!InterpLocationMaxLagDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationMaxLagDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpLocationMaxLagDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpLocationMaxLagDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationMaxLagDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpLocationMaxLagDistance_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:InterpLocationSnapToTargetDistance")]
	public float InterpLocationSnapToTargetDistance
	{
		get
		{
			CheckDestroyed();
			if (!InterpLocationSnapToTargetDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationSnapToTargetDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpLocationSnapToTargetDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpLocationSnapToTargetDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.ProjectileMovementComponent:InterpLocationSnapToTargetDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpLocationSnapToTargetDistance_Offset), value);
			}
		}
	}

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:StopSimulating")]
	public unsafe void StopSimulating(FHitResult HitResult)
	{
		CheckDestroyed();
		if (!StopSimulating_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:StopSimulating");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopSimulating_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopSimulating_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InitializeValue_InContainer(StopSimulating_HitResult_PropertyAddress.Address, intPtr);
		FHitResult.ToNative(IntPtr.Add(intPtr, StopSimulating_HitResult_Offset), 0, StopSimulating_HitResult_PropertyAddress.Address, HitResult);
		NativeReflection.InvokeFunctionOptimized(base.Address, StopSimulating_FunctionAddress, intPtr, StopSimulating_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:SetVelocityInLocalSpace")]
	public unsafe void SetVelocityInLocalSpace(FVector NewVelocity)
	{
		CheckDestroyed();
		if (!SetVelocityInLocalSpace_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:SetVelocityInLocalSpace");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetVelocityInLocalSpace_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetVelocityInLocalSpace_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetVelocityInLocalSpace_NewVelocity_Offset), 0, SetVelocityInLocalSpace_NewVelocity_PropertyAddress.Address, NewVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetVelocityInLocalSpace_FunctionAddress, intPtr, SetVelocityInLocalSpace_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:SetInterpolatedComponent")]
	public unsafe void SetInterpolatedComponent(USceneComponent Component)
	{
		CheckDestroyed();
		if (!SetInterpolatedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:SetInterpolatedComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetInterpolatedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetInterpolatedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetInterpolatedComponent_Component_Offset), 0, SetInterpolatedComponent_Component_PropertyAddress.Address, Component);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetInterpolatedComponent_FunctionAddress, intPtr, SetInterpolatedComponent_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:ResetInterpolation")]
	public unsafe void ResetInterpolation()
	{
		CheckDestroyed();
		if (!ResetInterpolation_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:ResetInterpolation");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(ResetInterpolation_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ResetInterpolation_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: ResetInterpolation_FunctionAddress, argsSize: ResetInterpolation_ParamsSize);
	}

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:MoveInterpolationTarget")]
	public unsafe void MoveInterpolationTarget(FVector NewLocation, FRotator NewRotation)
	{
		CheckDestroyed();
		if (!MoveInterpolationTarget_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:MoveInterpolationTarget");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveInterpolationTarget_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveInterpolationTarget_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MoveInterpolationTarget_NewLocation_Offset), 0, MoveInterpolationTarget_NewLocation_PropertyAddress.Address, NewLocation);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, MoveInterpolationTarget_NewRotation_Offset), 0, MoveInterpolationTarget_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveInterpolationTarget_FunctionAddress, intPtr, MoveInterpolationTarget_ParamsSize);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:LimitVelocity")]
	public unsafe FVector LimitVelocity(FVector NewVelocity)
	{
		CheckDestroyed();
		if (!LimitVelocity_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:LimitVelocity");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(LimitVelocity_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)LimitVelocity_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, LimitVelocity_NewVelocity_Offset), 0, LimitVelocity_NewVelocity_PropertyAddress.Address, NewVelocity);
		NativeReflection.InvokeFunctionOptimized(base.Address, LimitVelocity_FunctionAddress, intPtr, LimitVelocity_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, LimitVelocity_ReturnValue_Offset), 0, LimitVelocity_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:IsVelocityUnderSimulationThreshold")]
	public unsafe bool IsVelocityUnderSimulationThreshold()
	{
		CheckDestroyed();
		if (!IsVelocityUnderSimulationThreshold_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:IsVelocityUnderSimulationThreshold");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsVelocityUnderSimulationThreshold_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsVelocityUnderSimulationThreshold_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsVelocityUnderSimulationThreshold_FunctionAddress, intPtr, IsVelocityUnderSimulationThreshold_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsVelocityUnderSimulationThreshold_ReturnValue_Offset), 0, IsVelocityUnderSimulationThreshold_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.ProjectileMovementComponent:IsInterpolationComplete")]
	public unsafe bool IsInterpolationComplete()
	{
		CheckDestroyed();
		if (!IsInterpolationComplete_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.ProjectileMovementComponent:IsInterpolationComplete");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsInterpolationComplete_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsInterpolationComplete_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsInterpolationComplete_FunctionAddress, intPtr, IsInterpolationComplete_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsInterpolationComplete_ReturnValue_Offset), 0, IsInterpolationComplete_ReturnValue_PropertyAddress.Address);
	}

	static UProjectileMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UProjectileMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UProjectileMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.ProjectileMovementComponent");
		InitialSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InitialSpeed");
		InitialSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InitialSpeed", Classes.FFloatProperty);
		MaxSpeed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSpeed");
		MaxSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref RotationFollowsVelocity_PropertyAddress, intPtr, "bRotationFollowsVelocity");
		RotationFollowsVelocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRotationFollowsVelocity");
		RotationFollowsVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRotationFollowsVelocity", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref RotationRemainsVertical_PropertyAddress, intPtr, "bRotationRemainsVertical");
		RotationRemainsVertical_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bRotationRemainsVertical");
		RotationRemainsVertical_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bRotationRemainsVertical", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ShouldBounce_PropertyAddress, intPtr, "bShouldBounce");
		ShouldBounce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bShouldBounce");
		ShouldBounce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bShouldBounce", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InitialVelocityInLocalSpace_PropertyAddress, intPtr, "bInitialVelocityInLocalSpace");
		InitialVelocityInLocalSpace_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInitialVelocityInLocalSpace");
		InitialVelocityInLocalSpace_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInitialVelocityInLocalSpace", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ForceSubStepping_PropertyAddress, intPtr, "bForceSubStepping");
		ForceSubStepping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bForceSubStepping");
		ForceSubStepping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bForceSubStepping", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SimulationEnabled_PropertyAddress, intPtr, "bSimulationEnabled");
		SimulationEnabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSimulationEnabled");
		SimulationEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSimulationEnabled", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SweepCollision_PropertyAddress, intPtr, "bSweepCollision");
		SweepCollision_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSweepCollision");
		SweepCollision_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSweepCollision", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHomingProjectile_PropertyAddress, intPtr, "bIsHomingProjectile");
		IsHomingProjectile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsHomingProjectile");
		IsHomingProjectile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsHomingProjectile", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref BounceAngleAffectsFriction_PropertyAddress, intPtr, "bBounceAngleAffectsFriction");
		BounceAngleAffectsFriction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bBounceAngleAffectsFriction");
		BounceAngleAffectsFriction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bBounceAngleAffectsFriction", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IsSliding_PropertyAddress, intPtr, "bIsSliding");
		IsSliding_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsSliding");
		IsSliding_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsSliding", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpMovement_PropertyAddress, intPtr, "bInterpMovement");
		InterpMovement_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInterpMovement");
		InterpMovement_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInterpMovement", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref InterpRotation_PropertyAddress, intPtr, "bInterpRotation");
		InterpRotation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bInterpRotation");
		InterpRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bInterpRotation", Classes.FBoolProperty);
		PreviousHitTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviousHitTime");
		PreviousHitTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviousHitTime", Classes.FFloatProperty);
		PreviousHitNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreviousHitNormal");
		PreviousHitNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreviousHitNormal", Classes.FStructProperty);
		ProjectileGravityScale_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ProjectileGravityScale");
		ProjectileGravityScale_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ProjectileGravityScale", Classes.FFloatProperty);
		Bounciness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Bounciness");
		Bounciness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Bounciness", Classes.FFloatProperty);
		Friction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Friction");
		Friction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Friction", Classes.FFloatProperty);
		BounceVelocityStopSimulatingThreshold_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BounceVelocityStopSimulatingThreshold");
		BounceVelocityStopSimulatingThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BounceVelocityStopSimulatingThreshold", Classes.FFloatProperty);
		MinFrictionFraction_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MinFrictionFraction");
		MinFrictionFraction_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MinFrictionFraction", Classes.FFloatProperty);
		OnProjectileBounce_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnProjectileBounce");
		OnProjectileBounce_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnProjectileBounce", Classes.FMulticastDelegateProperty);
		OnProjectileStop_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OnProjectileStop");
		OnProjectileStop_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OnProjectileStop", Classes.FMulticastDelegateProperty);
		HomingAccelerationMagnitude_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HomingAccelerationMagnitude");
		HomingAccelerationMagnitude_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HomingAccelerationMagnitude", Classes.FFloatProperty);
		HomingTargetComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HomingTargetComponent");
		HomingTargetComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HomingTargetComponent", Classes.FWeakObjectProperty);
		MaxSimulationTimeStep_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationTimeStep");
		MaxSimulationTimeStep_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationTimeStep", Classes.FFloatProperty);
		MaxSimulationIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxSimulationIterations");
		MaxSimulationIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxSimulationIterations", Classes.FIntProperty);
		BounceAdditionalIterations_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BounceAdditionalIterations");
		BounceAdditionalIterations_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BounceAdditionalIterations", Classes.FIntProperty);
		InterpLocationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpLocationTime");
		InterpLocationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpLocationTime", Classes.FFloatProperty);
		InterpRotationTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpRotationTime");
		InterpRotationTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpRotationTime", Classes.FFloatProperty);
		InterpLocationMaxLagDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpLocationMaxLagDistance");
		InterpLocationMaxLagDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpLocationMaxLagDistance", Classes.FFloatProperty);
		InterpLocationSnapToTargetDistance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "InterpLocationSnapToTargetDistance");
		InterpLocationSnapToTargetDistance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "InterpLocationSnapToTargetDistance", Classes.FFloatProperty);
		StopSimulating_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopSimulating");
		StopSimulating_ParamsSize = NativeReflection.GetFunctionParamsSize(StopSimulating_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref StopSimulating_HitResult_PropertyAddress, StopSimulating_FunctionAddress, "HitResult");
		StopSimulating_HitResult_Offset = NativeReflectionCached.GetPropertyOffset(StopSimulating_FunctionAddress, "HitResult");
		StopSimulating_HitResult_IsValid = NativeReflectionCached.ValidatePropertyClass(StopSimulating_FunctionAddress, "HitResult", Classes.FStructProperty);
		StopSimulating_IsValid = StopSimulating_FunctionAddress != IntPtr.Zero && StopSimulating_HitResult_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:StopSimulating", StopSimulating_IsValid);
		SetVelocityInLocalSpace_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetVelocityInLocalSpace");
		SetVelocityInLocalSpace_ParamsSize = NativeReflection.GetFunctionParamsSize(SetVelocityInLocalSpace_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetVelocityInLocalSpace_NewVelocity_PropertyAddress, SetVelocityInLocalSpace_FunctionAddress, "NewVelocity");
		SetVelocityInLocalSpace_NewVelocity_Offset = NativeReflectionCached.GetPropertyOffset(SetVelocityInLocalSpace_FunctionAddress, "NewVelocity");
		SetVelocityInLocalSpace_NewVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(SetVelocityInLocalSpace_FunctionAddress, "NewVelocity", Classes.FStructProperty);
		SetVelocityInLocalSpace_IsValid = SetVelocityInLocalSpace_FunctionAddress != IntPtr.Zero && SetVelocityInLocalSpace_NewVelocity_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:SetVelocityInLocalSpace", SetVelocityInLocalSpace_IsValid);
		SetInterpolatedComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetInterpolatedComponent");
		SetInterpolatedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetInterpolatedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetInterpolatedComponent_Component_PropertyAddress, SetInterpolatedComponent_FunctionAddress, "Component");
		SetInterpolatedComponent_Component_Offset = NativeReflectionCached.GetPropertyOffset(SetInterpolatedComponent_FunctionAddress, "Component");
		SetInterpolatedComponent_Component_IsValid = NativeReflectionCached.ValidatePropertyClass(SetInterpolatedComponent_FunctionAddress, "Component", Classes.FObjectProperty);
		SetInterpolatedComponent_IsValid = SetInterpolatedComponent_FunctionAddress != IntPtr.Zero && SetInterpolatedComponent_Component_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:SetInterpolatedComponent", SetInterpolatedComponent_IsValid);
		ResetInterpolation_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ResetInterpolation");
		ResetInterpolation_ParamsSize = NativeReflection.GetFunctionParamsSize(ResetInterpolation_FunctionAddress);
		ResetInterpolation_IsValid = ResetInterpolation_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:ResetInterpolation", ResetInterpolation_IsValid);
		MoveInterpolationTarget_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "MoveInterpolationTarget");
		MoveInterpolationTarget_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveInterpolationTarget_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveInterpolationTarget_NewLocation_PropertyAddress, MoveInterpolationTarget_FunctionAddress, "NewLocation");
		MoveInterpolationTarget_NewLocation_Offset = NativeReflectionCached.GetPropertyOffset(MoveInterpolationTarget_FunctionAddress, "NewLocation");
		MoveInterpolationTarget_NewLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveInterpolationTarget_FunctionAddress, "NewLocation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveInterpolationTarget_NewRotation_PropertyAddress, MoveInterpolationTarget_FunctionAddress, "NewRotation");
		MoveInterpolationTarget_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(MoveInterpolationTarget_FunctionAddress, "NewRotation");
		MoveInterpolationTarget_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveInterpolationTarget_FunctionAddress, "NewRotation", Classes.FStructProperty);
		MoveInterpolationTarget_IsValid = MoveInterpolationTarget_FunctionAddress != IntPtr.Zero && MoveInterpolationTarget_NewLocation_IsValid && MoveInterpolationTarget_NewRotation_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:MoveInterpolationTarget", MoveInterpolationTarget_IsValid);
		LimitVelocity_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "LimitVelocity");
		LimitVelocity_ParamsSize = NativeReflection.GetFunctionParamsSize(LimitVelocity_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref LimitVelocity_NewVelocity_PropertyAddress, LimitVelocity_FunctionAddress, "NewVelocity");
		LimitVelocity_NewVelocity_Offset = NativeReflectionCached.GetPropertyOffset(LimitVelocity_FunctionAddress, "NewVelocity");
		LimitVelocity_NewVelocity_IsValid = NativeReflectionCached.ValidatePropertyClass(LimitVelocity_FunctionAddress, "NewVelocity", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref LimitVelocity_ReturnValue_PropertyAddress, LimitVelocity_FunctionAddress, "ReturnValue");
		LimitVelocity_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(LimitVelocity_FunctionAddress, "ReturnValue");
		LimitVelocity_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(LimitVelocity_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		LimitVelocity_IsValid = LimitVelocity_FunctionAddress != IntPtr.Zero && LimitVelocity_NewVelocity_IsValid && LimitVelocity_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:LimitVelocity", LimitVelocity_IsValid);
		IsVelocityUnderSimulationThreshold_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsVelocityUnderSimulationThreshold");
		IsVelocityUnderSimulationThreshold_ParamsSize = NativeReflection.GetFunctionParamsSize(IsVelocityUnderSimulationThreshold_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsVelocityUnderSimulationThreshold_ReturnValue_PropertyAddress, IsVelocityUnderSimulationThreshold_FunctionAddress, "ReturnValue");
		IsVelocityUnderSimulationThreshold_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsVelocityUnderSimulationThreshold_FunctionAddress, "ReturnValue");
		IsVelocityUnderSimulationThreshold_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsVelocityUnderSimulationThreshold_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsVelocityUnderSimulationThreshold_IsValid = IsVelocityUnderSimulationThreshold_FunctionAddress != IntPtr.Zero && IsVelocityUnderSimulationThreshold_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:IsVelocityUnderSimulationThreshold", IsVelocityUnderSimulationThreshold_IsValid);
		IsInterpolationComplete_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsInterpolationComplete");
		IsInterpolationComplete_ParamsSize = NativeReflection.GetFunctionParamsSize(IsInterpolationComplete_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsInterpolationComplete_ReturnValue_PropertyAddress, IsInterpolationComplete_FunctionAddress, "ReturnValue");
		IsInterpolationComplete_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsInterpolationComplete_FunctionAddress, "ReturnValue");
		IsInterpolationComplete_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsInterpolationComplete_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsInterpolationComplete_IsValid = IsInterpolationComplete_FunctionAddress != IntPtr.Zero && IsInterpolationComplete_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.ProjectileMovementComponent:IsInterpolationComplete", IsInterpolationComplete_IsValid);
	}
}
