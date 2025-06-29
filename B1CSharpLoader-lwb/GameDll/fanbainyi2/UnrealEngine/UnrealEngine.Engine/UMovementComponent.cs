using System;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[Abstract]
[UClass(Flags = (ClassFlags)821035173uL, Config = "Engine")]
[BlueprintType]
[UMetaPath("/Script/Engine.MovementComponent", "Engine", UnrealModuleType.Engine)]
public class UMovementComponent : UActorComponent
{
	private static bool UpdatedComponent_IsValid;

	private static int UpdatedComponent_Offset;

	private static bool UpdatedPrimitive_IsValid;

	private static int UpdatedPrimitive_Offset;

	private static bool Velocity_IsValid;

	private static int Velocity_Offset;

	private static bool PlaneConstraintNormal_IsValid;

	private static int PlaneConstraintNormal_Offset;

	private static bool PlaneConstraintOrigin_IsValid;

	private static int PlaneConstraintOrigin_Offset;

	private static bool UpdateOnlyIfRendered_IsValid;

	private static FFieldAddress UpdateOnlyIfRendered_PropertyAddress;

	private static int UpdateOnlyIfRendered_Offset;

	private static bool AutoUpdateTickRegistration_IsValid;

	private static FFieldAddress AutoUpdateTickRegistration_PropertyAddress;

	private static int AutoUpdateTickRegistration_Offset;

	private static bool TickBeforeOwner_IsValid;

	private static FFieldAddress TickBeforeOwner_PropertyAddress;

	private static int TickBeforeOwner_Offset;

	private static bool AutoRegisterUpdatedComponent_IsValid;

	private static FFieldAddress AutoRegisterUpdatedComponent_PropertyAddress;

	private static int AutoRegisterUpdatedComponent_Offset;

	private static bool ConstrainToPlane_IsValid;

	private static FFieldAddress ConstrainToPlane_PropertyAddress;

	private static int ConstrainToPlane_Offset;

	private static bool SnapToPlaneAtStart_IsValid;

	private static FFieldAddress SnapToPlaneAtStart_PropertyAddress;

	private static int SnapToPlaneAtStart_Offset;

	private static bool AutoRegisterPhysicsVolumeUpdates_IsValid;

	private static FFieldAddress AutoRegisterPhysicsVolumeUpdates_PropertyAddress;

	private static int AutoRegisterPhysicsVolumeUpdates_Offset;

	private static bool ComponentShouldUpdatePhysicsVolume_IsValid;

	private static FFieldAddress ComponentShouldUpdatePhysicsVolume_PropertyAddress;

	private static int ComponentShouldUpdatePhysicsVolume_Offset;

	private static bool StopMovementImmediately_IsValid;

	private static IntPtr StopMovementImmediately_FunctionAddress;

	private static int StopMovementImmediately_ParamsSize;

	private static bool SnapUpdatedComponentToPlane_IsValid;

	private static IntPtr SnapUpdatedComponentToPlane_FunctionAddress;

	private static int SnapUpdatedComponentToPlane_ParamsSize;

	private static bool SetUpdatedComponent_IsValid;

	private static IntPtr SetUpdatedComponent_FunctionAddress;

	private static int SetUpdatedComponent_ParamsSize;

	private static bool SetUpdatedComponent_NewUpdatedComponent_IsValid;

	private static FFieldAddress SetUpdatedComponent_NewUpdatedComponent_PropertyAddress;

	private static int SetUpdatedComponent_NewUpdatedComponent_Offset;

	private static bool SetPlaneConstraintOrigin_IsValid;

	private static IntPtr SetPlaneConstraintOrigin_FunctionAddress;

	private static int SetPlaneConstraintOrigin_ParamsSize;

	private static bool SetPlaneConstraintOrigin_PlaneOrigin_IsValid;

	private static FFieldAddress SetPlaneConstraintOrigin_PlaneOrigin_PropertyAddress;

	private static int SetPlaneConstraintOrigin_PlaneOrigin_Offset;

	private static bool SetPlaneConstraintNormal_IsValid;

	private static IntPtr SetPlaneConstraintNormal_FunctionAddress;

	private static int SetPlaneConstraintNormal_ParamsSize;

	private static bool SetPlaneConstraintNormal_PlaneNormal_IsValid;

	private static FFieldAddress SetPlaneConstraintNormal_PlaneNormal_PropertyAddress;

	private static int SetPlaneConstraintNormal_PlaneNormal_Offset;

	private static bool SetPlaneConstraintFromVectors_IsValid;

	private static IntPtr SetPlaneConstraintFromVectors_FunctionAddress;

	private static int SetPlaneConstraintFromVectors_ParamsSize;

	private static bool SetPlaneConstraintFromVectors_Forward_IsValid;

	private static FFieldAddress SetPlaneConstraintFromVectors_Forward_PropertyAddress;

	private static int SetPlaneConstraintFromVectors_Forward_Offset;

	private static bool SetPlaneConstraintFromVectors_Up_IsValid;

	private static FFieldAddress SetPlaneConstraintFromVectors_Up_PropertyAddress;

	private static int SetPlaneConstraintFromVectors_Up_Offset;

	private static bool SetPlaneConstraintEnabled_IsValid;

	private static IntPtr SetPlaneConstraintEnabled_FunctionAddress;

	private static int SetPlaneConstraintEnabled_ParamsSize;

	private static bool SetPlaneConstraintEnabled_bEnabled_IsValid;

	private static FFieldAddress SetPlaneConstraintEnabled_bEnabled_PropertyAddress;

	private static int SetPlaneConstraintEnabled_bEnabled_Offset;

	private static bool SetPlaneConstraintAxisSetting_IsValid;

	private static IntPtr SetPlaneConstraintAxisSetting_FunctionAddress;

	private static int SetPlaneConstraintAxisSetting_ParamsSize;

	private static bool SetPlaneConstraintAxisSetting_NewAxisSetting_IsValid;

	private static FFieldAddress SetPlaneConstraintAxisSetting_NewAxisSetting_PropertyAddress;

	private static int SetPlaneConstraintAxisSetting_NewAxisSetting_Offset;

	private static bool MoveUpdatedComponent_IsValid;

	private static IntPtr MoveUpdatedComponent_FunctionAddress;

	private static int MoveUpdatedComponent_ParamsSize;

	private static bool MoveUpdatedComponent_Delta_IsValid;

	private static FFieldAddress MoveUpdatedComponent_Delta_PropertyAddress;

	private static int MoveUpdatedComponent_Delta_Offset;

	private static bool MoveUpdatedComponent_NewRotation_IsValid;

	private static FFieldAddress MoveUpdatedComponent_NewRotation_PropertyAddress;

	private static int MoveUpdatedComponent_NewRotation_Offset;

	private static bool MoveUpdatedComponent_OutHit_IsValid;

	private static FFieldAddress MoveUpdatedComponent_OutHit_PropertyAddress;

	private static int MoveUpdatedComponent_OutHit_Offset;

	private static bool MoveUpdatedComponent_bSweep_IsValid;

	private static FFieldAddress MoveUpdatedComponent_bSweep_PropertyAddress;

	private static int MoveUpdatedComponent_bSweep_Offset;

	private static bool MoveUpdatedComponent_bTeleport_IsValid;

	private static FFieldAddress MoveUpdatedComponent_bTeleport_PropertyAddress;

	private static int MoveUpdatedComponent_bTeleport_Offset;

	private static bool MoveUpdatedComponent_ReturnValue_IsValid;

	private static FFieldAddress MoveUpdatedComponent_ReturnValue_PropertyAddress;

	private static int MoveUpdatedComponent_ReturnValue_Offset;

	private static bool IsExceedingMaxSpeed_IsValid;

	private static IntPtr IsExceedingMaxSpeed_FunctionAddress;

	private static int IsExceedingMaxSpeed_ParamsSize;

	private static bool IsExceedingMaxSpeed_MaxSpeed_IsValid;

	private static FFieldAddress IsExceedingMaxSpeed_MaxSpeed_PropertyAddress;

	private static int IsExceedingMaxSpeed_MaxSpeed_Offset;

	private static bool IsExceedingMaxSpeed_ReturnValue_IsValid;

	private static FFieldAddress IsExceedingMaxSpeed_ReturnValue_PropertyAddress;

	private static int IsExceedingMaxSpeed_ReturnValue_Offset;

	private static bool GetPlaneConstraintOrigin_IsValid;

	private static IntPtr GetPlaneConstraintOrigin_FunctionAddress;

	private static int GetPlaneConstraintOrigin_ParamsSize;

	private static bool GetPlaneConstraintOrigin_ReturnValue_IsValid;

	private static FFieldAddress GetPlaneConstraintOrigin_ReturnValue_PropertyAddress;

	private static int GetPlaneConstraintOrigin_ReturnValue_Offset;

	private static bool GetPlaneConstraintNormal_IsValid;

	private static IntPtr GetPlaneConstraintNormal_FunctionAddress;

	private static int GetPlaneConstraintNormal_ParamsSize;

	private static bool GetPlaneConstraintNormal_ReturnValue_IsValid;

	private static FFieldAddress GetPlaneConstraintNormal_ReturnValue_PropertyAddress;

	private static int GetPlaneConstraintNormal_ReturnValue_Offset;

	private static bool GetPlaneConstraintAxisSetting_IsValid;

	private static IntPtr GetPlaneConstraintAxisSetting_FunctionAddress;

	private static int GetPlaneConstraintAxisSetting_ParamsSize;

	private static bool GetPlaneConstraintAxisSetting_ReturnValue_IsValid;

	private static FFieldAddress GetPlaneConstraintAxisSetting_ReturnValue_PropertyAddress;

	private static int GetPlaneConstraintAxisSetting_ReturnValue_Offset;

	private static bool GetPhysicsVolume_IsValid;

	private static IntPtr GetPhysicsVolume_FunctionAddress;

	private static int GetPhysicsVolume_ParamsSize;

	private static bool GetPhysicsVolume_ReturnValue_IsValid;

	private static FFieldAddress GetPhysicsVolume_ReturnValue_PropertyAddress;

	private static int GetPhysicsVolume_ReturnValue_Offset;

	private static bool GetMaxSpeed_IsValid;

	private static IntPtr GetMaxSpeed_FunctionAddress;

	private static int GetMaxSpeed_ParamsSize;

	private static bool GetMaxSpeed_ReturnValue_IsValid;

	private static FFieldAddress GetMaxSpeed_ReturnValue_PropertyAddress;

	private static int GetMaxSpeed_ReturnValue_Offset;

	private static bool GetGravityZ_IsValid;

	private static IntPtr GetGravityZ_FunctionAddress;

	private static int GetGravityZ_ParamsSize;

	private static bool GetGravityZ_ReturnValue_IsValid;

	private static FFieldAddress GetGravityZ_ReturnValue_PropertyAddress;

	private static int GetGravityZ_ReturnValue_Offset;

	private static bool ConstrainNormalToPlane_IsValid;

	private static IntPtr ConstrainNormalToPlane_FunctionAddress;

	private static int ConstrainNormalToPlane_ParamsSize;

	private static bool ConstrainNormalToPlane_Normal_IsValid;

	private static FFieldAddress ConstrainNormalToPlane_Normal_PropertyAddress;

	private static int ConstrainNormalToPlane_Normal_Offset;

	private static bool ConstrainNormalToPlane_ReturnValue_IsValid;

	private static FFieldAddress ConstrainNormalToPlane_ReturnValue_PropertyAddress;

	private static int ConstrainNormalToPlane_ReturnValue_Offset;

	private static bool ConstrainLocationToPlane_IsValid;

	private static IntPtr ConstrainLocationToPlane_FunctionAddress;

	private static int ConstrainLocationToPlane_ParamsSize;

	private static bool ConstrainLocationToPlane_Location_IsValid;

	private static FFieldAddress ConstrainLocationToPlane_Location_PropertyAddress;

	private static int ConstrainLocationToPlane_Location_Offset;

	private static bool ConstrainLocationToPlane_ReturnValue_IsValid;

	private static FFieldAddress ConstrainLocationToPlane_ReturnValue_PropertyAddress;

	private static int ConstrainLocationToPlane_ReturnValue_Offset;

	private static bool ConstrainDirectionToPlane_IsValid;

	private static IntPtr ConstrainDirectionToPlane_FunctionAddress;

	private static int ConstrainDirectionToPlane_ParamsSize;

	private static bool ConstrainDirectionToPlane_Direction_IsValid;

	private static FFieldAddress ConstrainDirectionToPlane_Direction_PropertyAddress;

	private static int ConstrainDirectionToPlane_Direction_Offset;

	private static bool ConstrainDirectionToPlane_ReturnValue_IsValid;

	private static FFieldAddress ConstrainDirectionToPlane_ReturnValue_PropertyAddress;

	private static int ConstrainDirectionToPlane_ReturnValue_Offset;

	[UProperty(Flags = (PropFlags)7881369143747100uL)]
	[UMetaPath("/Script/Engine.MovementComponent:UpdatedComponent")]
	public USceneComponent UpdatedComponent
	{
		get
		{
			CheckDestroyed();
			if (!UpdatedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:UpdatedComponent");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, UpdatedComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdatedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:UpdatedComponent");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, UpdatedComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)7881369143747100uL)]
	[UMetaPath("/Script/Engine.MovementComponent:UpdatedPrimitive")]
	public UPrimitiveComponent UpdatedPrimitive
	{
		get
		{
			CheckDestroyed();
			if (!UpdatedPrimitive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:UpdatedPrimitive");
				return null;
			}
			return UObjectMarshaler<UPrimitiveComponent>.FromNative(IntPtr.Add(base.Address, UpdatedPrimitive_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdatedPrimitive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:UpdatedPrimitive");
			}
			else
			{
				UObjectMarshaler<UPrimitiveComponent>.ToNative(IntPtr.Add(base.Address, UpdatedPrimitive_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/Engine.MovementComponent:Velocity")]
	public FVector Velocity
	{
		get
		{
			CheckDestroyed();
			if (!Velocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:Velocity");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, Velocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Velocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:Velocity");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, Velocity_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.MovementComponent:PlaneConstraintNormal")]
	protected FVector PlaneConstraintNormal
	{
		get
		{
			CheckDestroyed();
			if (!PlaneConstraintNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:PlaneConstraintNormal");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PlaneConstraintNormal_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaneConstraintNormal_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:PlaneConstraintNormal");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PlaneConstraintNormal_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954667541uL)]
	[UMetaPath("/Script/Engine.MovementComponent:PlaneConstraintOrigin")]
	protected FVector PlaneConstraintOrigin
	{
		get
		{
			CheckDestroyed();
			if (!PlaneConstraintOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:PlaneConstraintOrigin");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PlaneConstraintOrigin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PlaneConstraintOrigin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:PlaneConstraintOrigin");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PlaneConstraintOrigin_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bUpdateOnlyIfRendered")]
	public bool UpdateOnlyIfRendered
	{
		get
		{
			CheckDestroyed();
			if (!UpdateOnlyIfRendered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bUpdateOnlyIfRendered");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UpdateOnlyIfRendered_Offset), 0, UpdateOnlyIfRendered_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UpdateOnlyIfRendered_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bUpdateOnlyIfRendered");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UpdateOnlyIfRendered_Offset), 0, UpdateOnlyIfRendered_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bAutoUpdateTickRegistration")]
	public bool AutoUpdateTickRegistration
	{
		get
		{
			CheckDestroyed();
			if (!AutoUpdateTickRegistration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoUpdateTickRegistration");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoUpdateTickRegistration_Offset), 0, AutoUpdateTickRegistration_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoUpdateTickRegistration_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoUpdateTickRegistration");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoUpdateTickRegistration_Offset), 0, AutoUpdateTickRegistration_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bTickBeforeOwner")]
	public bool TickBeforeOwner
	{
		get
		{
			CheckDestroyed();
			if (!TickBeforeOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bTickBeforeOwner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, TickBeforeOwner_Offset), 0, TickBeforeOwner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TickBeforeOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bTickBeforeOwner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, TickBeforeOwner_Offset), 0, TickBeforeOwner_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bAutoRegisterUpdatedComponent")]
	public bool AutoRegisterUpdatedComponent
	{
		get
		{
			CheckDestroyed();
			if (!AutoRegisterUpdatedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoRegisterUpdatedComponent");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRegisterUpdatedComponent_Offset), 0, AutoRegisterUpdatedComponent_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRegisterUpdatedComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoRegisterUpdatedComponent");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRegisterUpdatedComponent_Offset), 0, AutoRegisterUpdatedComponent_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bConstrainToPlane")]
	public bool ConstrainToPlane
	{
		get
		{
			CheckDestroyed();
			if (!ConstrainToPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bConstrainToPlane");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ConstrainToPlane_Offset), 0, ConstrainToPlane_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ConstrainToPlane_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bConstrainToPlane");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ConstrainToPlane_Offset), 0, ConstrainToPlane_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bSnapToPlaneAtStart")]
	public bool SnapToPlaneAtStart
	{
		get
		{
			CheckDestroyed();
			if (!SnapToPlaneAtStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bSnapToPlaneAtStart");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SnapToPlaneAtStart_Offset), 0, SnapToPlaneAtStart_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SnapToPlaneAtStart_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bSnapToPlaneAtStart");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SnapToPlaneAtStart_Offset), 0, SnapToPlaneAtStart_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bAutoRegisterPhysicsVolumeUpdates")]
	public bool AutoRegisterPhysicsVolumeUpdates
	{
		get
		{
			CheckDestroyed();
			if (!AutoRegisterPhysicsVolumeUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoRegisterPhysicsVolumeUpdates");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, AutoRegisterPhysicsVolumeUpdates_Offset), 0, AutoRegisterPhysicsVolumeUpdates_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!AutoRegisterPhysicsVolumeUpdates_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bAutoRegisterPhysicsVolumeUpdates");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, AutoRegisterPhysicsVolumeUpdates_Offset), 0, AutoRegisterPhysicsVolumeUpdates_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/Engine.MovementComponent:bComponentShouldUpdatePhysicsVolume")]
	public bool ComponentShouldUpdatePhysicsVolume
	{
		get
		{
			CheckDestroyed();
			if (!ComponentShouldUpdatePhysicsVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bComponentShouldUpdatePhysicsVolume");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ComponentShouldUpdatePhysicsVolume_Offset), 0, ComponentShouldUpdatePhysicsVolume_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ComponentShouldUpdatePhysicsVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/Engine.MovementComponent:bComponentShouldUpdatePhysicsVolume");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ComponentShouldUpdatePhysicsVolume_Offset), 0, ComponentShouldUpdatePhysicsVolume_PropertyAddress.Address, value);
			}
		}
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MovementComponent:StopMovementImmediately")]
	public unsafe void StopMovementImmediately()
	{
		CheckDestroyed();
		if (!StopMovementImmediately_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:StopMovementImmediately");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(StopMovementImmediately_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)StopMovementImmediately_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: StopMovementImmediately_FunctionAddress, argsSize: StopMovementImmediately_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MovementComponent:SnapUpdatedComponentToPlane")]
	public unsafe void SnapUpdatedComponentToPlane()
	{
		CheckDestroyed();
		if (!SnapUpdatedComponentToPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SnapUpdatedComponentToPlane");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SnapUpdatedComponentToPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SnapUpdatedComponentToPlane_ParamsSize);
		NativeReflection.InvokeFunctionOptimized(args: new IntPtr(ptr2), unrealClass: base.Address, function: SnapUpdatedComponentToPlane_FunctionAddress, argsSize: SnapUpdatedComponentToPlane_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetUpdatedComponent")]
	public unsafe void SetUpdatedComponent(USceneComponent NewUpdatedComponent)
	{
		CheckDestroyed();
		if (!SetUpdatedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetUpdatedComponent");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetUpdatedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetUpdatedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(intPtr, SetUpdatedComponent_NewUpdatedComponent_Offset), 0, SetUpdatedComponent_NewUpdatedComponent_PropertyAddress.Address, NewUpdatedComponent);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetUpdatedComponent_FunctionAddress, intPtr, SetUpdatedComponent_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetPlaneConstraintOrigin")]
	public unsafe void SetPlaneConstraintOrigin(FVector PlaneOrigin)
	{
		CheckDestroyed();
		if (!SetPlaneConstraintOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetPlaneConstraintOrigin");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneConstraintOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneConstraintOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintOrigin_PlaneOrigin_Offset), 0, SetPlaneConstraintOrigin_PlaneOrigin_PropertyAddress.Address, PlaneOrigin);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneConstraintOrigin_FunctionAddress, intPtr, SetPlaneConstraintOrigin_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetPlaneConstraintNormal")]
	public unsafe void SetPlaneConstraintNormal(FVector PlaneNormal)
	{
		CheckDestroyed();
		if (!SetPlaneConstraintNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetPlaneConstraintNormal");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneConstraintNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneConstraintNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintNormal_PlaneNormal_Offset), 0, SetPlaneConstraintNormal_PlaneNormal_PropertyAddress.Address, PlaneNormal);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneConstraintNormal_FunctionAddress, intPtr, SetPlaneConstraintNormal_ParamsSize);
	}

	[UFunction(Flags = 75629568u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetPlaneConstraintFromVectors")]
	public unsafe void SetPlaneConstraintFromVectors(FVector Forward, FVector Up)
	{
		CheckDestroyed();
		if (!SetPlaneConstraintFromVectors_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetPlaneConstraintFromVectors");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneConstraintFromVectors_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneConstraintFromVectors_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintFromVectors_Forward_Offset), 0, SetPlaneConstraintFromVectors_Forward_PropertyAddress.Address, Forward);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintFromVectors_Up_Offset), 0, SetPlaneConstraintFromVectors_Up_PropertyAddress.Address, Up);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneConstraintFromVectors_FunctionAddress, intPtr, SetPlaneConstraintFromVectors_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetPlaneConstraintEnabled")]
	public unsafe void SetPlaneConstraintEnabled(bool bEnabled)
	{
		CheckDestroyed();
		if (!SetPlaneConstraintEnabled_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetPlaneConstraintEnabled");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneConstraintEnabled_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneConstraintEnabled_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintEnabled_bEnabled_Offset), 0, SetPlaneConstraintEnabled_bEnabled_PropertyAddress.Address, bEnabled);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneConstraintEnabled_FunctionAddress, intPtr, SetPlaneConstraintEnabled_ParamsSize);
	}

	[UFunction(Flags = 67240960u)]
	[UMetaPath("/Script/Engine.MovementComponent:SetPlaneConstraintAxisSetting")]
	public unsafe void SetPlaneConstraintAxisSetting(EPlaneConstraintAxisSetting NewAxisSetting)
	{
		CheckDestroyed();
		if (!SetPlaneConstraintAxisSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:SetPlaneConstraintAxisSetting");
			return;
		}
		byte* ptr = stackalloc byte[(int)(uint)(SetPlaneConstraintAxisSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)SetPlaneConstraintAxisSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		EnumMarshaler<EPlaneConstraintAxisSetting>.ToNative(IntPtr.Add(intPtr, SetPlaneConstraintAxisSetting_NewAxisSetting_Offset), 0, SetPlaneConstraintAxisSetting_NewAxisSetting_PropertyAddress.Address, NewAxisSetting);
		NativeReflection.InvokeFunctionOptimized(base.Address, SetPlaneConstraintAxisSetting_FunctionAddress, intPtr, SetPlaneConstraintAxisSetting_ParamsSize);
	}

	[UFunction(Flags = 79823873u, OriginalName = "K2_MoveUpdatedComponent")]
	[UMetaPath("/Script/Engine.MovementComponent:K2_MoveUpdatedComponent")]
	public unsafe bool MoveUpdatedComponent(FVector Delta, FRotator NewRotation, out FHitResult OutHit, bool bSweep = true, bool bTeleport = false)
	{
		CheckDestroyed();
		if (!MoveUpdatedComponent_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:K2_MoveUpdatedComponent");
			OutHit = default(FHitResult);
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(MoveUpdatedComponent_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)MoveUpdatedComponent_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, MoveUpdatedComponent_Delta_Offset), 0, MoveUpdatedComponent_Delta_PropertyAddress.Address, Delta);
		BlittableTypeMarshaler<FRotator>.ToNative(IntPtr.Add(intPtr, MoveUpdatedComponent_NewRotation_Offset), 0, MoveUpdatedComponent_NewRotation_PropertyAddress.Address, NewRotation);
		NativeReflection.InitializeValue_InContainer(MoveUpdatedComponent_OutHit_PropertyAddress.Address, intPtr);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveUpdatedComponent_bSweep_Offset), 0, MoveUpdatedComponent_bSweep_PropertyAddress.Address, bSweep);
		BoolMarshaler.ToNative(IntPtr.Add(intPtr, MoveUpdatedComponent_bTeleport_Offset), 0, MoveUpdatedComponent_bTeleport_PropertyAddress.Address, bTeleport);
		NativeReflection.InvokeFunctionOptimized(base.Address, MoveUpdatedComponent_FunctionAddress, intPtr, MoveUpdatedComponent_ParamsSize);
		OutHit = FHitResult.FromNative(IntPtr.Add(intPtr, MoveUpdatedComponent_OutHit_Offset), 0, MoveUpdatedComponent_OutHit_PropertyAddress.Address);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, MoveUpdatedComponent_ReturnValue_Offset), 0, MoveUpdatedComponent_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MovementComponent:IsExceedingMaxSpeed")]
	public unsafe bool IsExceedingMaxSpeed(float MaxSpeed)
	{
		CheckDestroyed();
		if (!IsExceedingMaxSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:IsExceedingMaxSpeed");
			return false;
		}
		byte* ptr = stackalloc byte[(int)(uint)(IsExceedingMaxSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)IsExceedingMaxSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(intPtr, IsExceedingMaxSpeed_MaxSpeed_Offset), 0, IsExceedingMaxSpeed_MaxSpeed_PropertyAddress.Address, MaxSpeed);
		NativeReflection.InvokeFunctionOptimized(base.Address, IsExceedingMaxSpeed_FunctionAddress, intPtr, IsExceedingMaxSpeed_ParamsSize);
		return BoolMarshaler.FromNative(IntPtr.Add(intPtr, IsExceedingMaxSpeed_ReturnValue_Offset), 0, IsExceedingMaxSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetPlaneConstraintOrigin")]
	public unsafe FVector GetPlaneConstraintOrigin()
	{
		CheckDestroyed();
		if (!GetPlaneConstraintOrigin_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetPlaneConstraintOrigin");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaneConstraintOrigin_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaneConstraintOrigin_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaneConstraintOrigin_FunctionAddress, intPtr, GetPlaneConstraintOrigin_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlaneConstraintOrigin_ReturnValue_Offset), 0, GetPlaneConstraintOrigin_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806849u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetPlaneConstraintNormal")]
	public unsafe FVector GetPlaneConstraintNormal()
	{
		CheckDestroyed();
		if (!GetPlaneConstraintNormal_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetPlaneConstraintNormal");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaneConstraintNormal_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaneConstraintNormal_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaneConstraintNormal_FunctionAddress, intPtr, GetPlaneConstraintNormal_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, GetPlaneConstraintNormal_ReturnValue_Offset), 0, GetPlaneConstraintNormal_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418241u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetPlaneConstraintAxisSetting")]
	public unsafe EPlaneConstraintAxisSetting GetPlaneConstraintAxisSetting()
	{
		CheckDestroyed();
		if (!GetPlaneConstraintAxisSetting_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetPlaneConstraintAxisSetting");
			return EPlaneConstraintAxisSetting.Custom;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPlaneConstraintAxisSetting_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPlaneConstraintAxisSetting_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPlaneConstraintAxisSetting_FunctionAddress, intPtr, GetPlaneConstraintAxisSetting_ParamsSize);
		return EnumMarshaler<EPlaneConstraintAxisSetting>.FromNative(IntPtr.Add(intPtr, GetPlaneConstraintAxisSetting_ReturnValue_Offset), 0, GetPlaneConstraintAxisSetting_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetPhysicsVolume")]
	public unsafe APhysicsVolume GetPhysicsVolume()
	{
		CheckDestroyed();
		if (!GetPhysicsVolume_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetPhysicsVolume");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetPhysicsVolume_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetPhysicsVolume_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetPhysicsVolume_FunctionAddress, intPtr, GetPhysicsVolume_ParamsSize);
		return UObjectMarshaler<APhysicsVolume>.FromNative(IntPtr.Add(intPtr, GetPhysicsVolume_ReturnValue_Offset), 0, GetPhysicsVolume_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetMaxSpeed")]
	public unsafe float GetMaxSpeed()
	{
		CheckDestroyed();
		if (!GetMaxSpeed_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetMaxSpeed");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetMaxSpeed_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetMaxSpeed_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetMaxSpeed_FunctionAddress, intPtr, GetMaxSpeed_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetMaxSpeed_ReturnValue_Offset), 0, GetMaxSpeed_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1409418240u)]
	[UMetaPath("/Script/Engine.MovementComponent:GetGravityZ")]
	public unsafe float GetGravityZ()
	{
		CheckDestroyed();
		if (!GetGravityZ_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:GetGravityZ");
			return 0f;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetGravityZ_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetGravityZ_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetGravityZ_FunctionAddress, intPtr, GetGravityZ_ParamsSize);
		return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(intPtr, GetGravityZ_ReturnValue_Offset), 0, GetGravityZ_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.MovementComponent:ConstrainNormalToPlane")]
	public unsafe FVector ConstrainNormalToPlane(FVector Normal)
	{
		CheckDestroyed();
		if (!ConstrainNormalToPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:ConstrainNormalToPlane");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstrainNormalToPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstrainNormalToPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConstrainNormalToPlane_Normal_Offset), 0, ConstrainNormalToPlane_Normal_PropertyAddress.Address, Normal);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstrainNormalToPlane_FunctionAddress, intPtr, ConstrainNormalToPlane_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ConstrainNormalToPlane_ReturnValue_Offset), 0, ConstrainNormalToPlane_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.MovementComponent:ConstrainLocationToPlane")]
	public unsafe FVector ConstrainLocationToPlane(FVector Location)
	{
		CheckDestroyed();
		if (!ConstrainLocationToPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:ConstrainLocationToPlane");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstrainLocationToPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstrainLocationToPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConstrainLocationToPlane_Location_Offset), 0, ConstrainLocationToPlane_Location_PropertyAddress.Address, Location);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstrainLocationToPlane_FunctionAddress, intPtr, ConstrainLocationToPlane_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ConstrainLocationToPlane_ReturnValue_Offset), 0, ConstrainLocationToPlane_ReturnValue_PropertyAddress.Address);
	}

	[UFunction(Flags = 1417806848u)]
	[UMetaPath("/Script/Engine.MovementComponent:ConstrainDirectionToPlane")]
	public unsafe FVector ConstrainDirectionToPlane(FVector Direction)
	{
		CheckDestroyed();
		if (!ConstrainDirectionToPlane_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.MovementComponent:ConstrainDirectionToPlane");
			return default(FVector);
		}
		byte* ptr = stackalloc byte[(int)(uint)(ConstrainDirectionToPlane_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)ConstrainDirectionToPlane_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(intPtr, ConstrainDirectionToPlane_Direction_Offset), 0, ConstrainDirectionToPlane_Direction_PropertyAddress.Address, Direction);
		NativeReflection.InvokeFunctionOptimized(base.Address, ConstrainDirectionToPlane_FunctionAddress, intPtr, ConstrainDirectionToPlane_ParamsSize);
		return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(intPtr, ConstrainDirectionToPlane_ReturnValue_Offset), 0, ConstrainDirectionToPlane_ReturnValue_PropertyAddress.Address);
	}

	static UMovementComponent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UMovementComponent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UMovementComponent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/Engine.MovementComponent");
		UpdatedComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpdatedComponent");
		UpdatedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpdatedComponent", Classes.FObjectProperty);
		UpdatedPrimitive_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "UpdatedPrimitive");
		UpdatedPrimitive_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "UpdatedPrimitive", Classes.FObjectProperty);
		Velocity_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Velocity");
		Velocity_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Velocity", Classes.FStructProperty);
		PlaneConstraintNormal_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaneConstraintNormal");
		PlaneConstraintNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaneConstraintNormal", Classes.FStructProperty);
		PlaneConstraintOrigin_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PlaneConstraintOrigin");
		PlaneConstraintOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PlaneConstraintOrigin", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref UpdateOnlyIfRendered_PropertyAddress, intPtr, "bUpdateOnlyIfRendered");
		UpdateOnlyIfRendered_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bUpdateOnlyIfRendered");
		UpdateOnlyIfRendered_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bUpdateOnlyIfRendered", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoUpdateTickRegistration_PropertyAddress, intPtr, "bAutoUpdateTickRegistration");
		AutoUpdateTickRegistration_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoUpdateTickRegistration");
		AutoUpdateTickRegistration_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoUpdateTickRegistration", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref TickBeforeOwner_PropertyAddress, intPtr, "bTickBeforeOwner");
		TickBeforeOwner_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bTickBeforeOwner");
		TickBeforeOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bTickBeforeOwner", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRegisterUpdatedComponent_PropertyAddress, intPtr, "bAutoRegisterUpdatedComponent");
		AutoRegisterUpdatedComponent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoRegisterUpdatedComponent");
		AutoRegisterUpdatedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoRegisterUpdatedComponent", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainToPlane_PropertyAddress, intPtr, "bConstrainToPlane");
		ConstrainToPlane_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bConstrainToPlane");
		ConstrainToPlane_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bConstrainToPlane", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref SnapToPlaneAtStart_PropertyAddress, intPtr, "bSnapToPlaneAtStart");
		SnapToPlaneAtStart_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSnapToPlaneAtStart");
		SnapToPlaneAtStart_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSnapToPlaneAtStart", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref AutoRegisterPhysicsVolumeUpdates_PropertyAddress, intPtr, "bAutoRegisterPhysicsVolumeUpdates");
		AutoRegisterPhysicsVolumeUpdates_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bAutoRegisterPhysicsVolumeUpdates");
		AutoRegisterPhysicsVolumeUpdates_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bAutoRegisterPhysicsVolumeUpdates", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref ComponentShouldUpdatePhysicsVolume_PropertyAddress, intPtr, "bComponentShouldUpdatePhysicsVolume");
		ComponentShouldUpdatePhysicsVolume_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bComponentShouldUpdatePhysicsVolume");
		ComponentShouldUpdatePhysicsVolume_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bComponentShouldUpdatePhysicsVolume", Classes.FBoolProperty);
		StopMovementImmediately_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "StopMovementImmediately");
		StopMovementImmediately_ParamsSize = NativeReflection.GetFunctionParamsSize(StopMovementImmediately_FunctionAddress);
		StopMovementImmediately_IsValid = StopMovementImmediately_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:StopMovementImmediately", StopMovementImmediately_IsValid);
		SnapUpdatedComponentToPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SnapUpdatedComponentToPlane");
		SnapUpdatedComponentToPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(SnapUpdatedComponentToPlane_FunctionAddress);
		SnapUpdatedComponentToPlane_IsValid = SnapUpdatedComponentToPlane_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SnapUpdatedComponentToPlane", SnapUpdatedComponentToPlane_IsValid);
		SetUpdatedComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetUpdatedComponent");
		SetUpdatedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetUpdatedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetUpdatedComponent_NewUpdatedComponent_PropertyAddress, SetUpdatedComponent_FunctionAddress, "NewUpdatedComponent");
		SetUpdatedComponent_NewUpdatedComponent_Offset = NativeReflectionCached.GetPropertyOffset(SetUpdatedComponent_FunctionAddress, "NewUpdatedComponent");
		SetUpdatedComponent_NewUpdatedComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(SetUpdatedComponent_FunctionAddress, "NewUpdatedComponent", Classes.FObjectProperty);
		SetUpdatedComponent_IsValid = SetUpdatedComponent_FunctionAddress != IntPtr.Zero && SetUpdatedComponent_NewUpdatedComponent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetUpdatedComponent", SetUpdatedComponent_IsValid);
		SetPlaneConstraintOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneConstraintOrigin");
		SetPlaneConstraintOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneConstraintOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintOrigin_PlaneOrigin_PropertyAddress, SetPlaneConstraintOrigin_FunctionAddress, "PlaneOrigin");
		SetPlaneConstraintOrigin_PlaneOrigin_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintOrigin_FunctionAddress, "PlaneOrigin");
		SetPlaneConstraintOrigin_PlaneOrigin_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintOrigin_FunctionAddress, "PlaneOrigin", Classes.FStructProperty);
		SetPlaneConstraintOrigin_IsValid = SetPlaneConstraintOrigin_FunctionAddress != IntPtr.Zero && SetPlaneConstraintOrigin_PlaneOrigin_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetPlaneConstraintOrigin", SetPlaneConstraintOrigin_IsValid);
		SetPlaneConstraintNormal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneConstraintNormal");
		SetPlaneConstraintNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneConstraintNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintNormal_PlaneNormal_PropertyAddress, SetPlaneConstraintNormal_FunctionAddress, "PlaneNormal");
		SetPlaneConstraintNormal_PlaneNormal_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintNormal_FunctionAddress, "PlaneNormal");
		SetPlaneConstraintNormal_PlaneNormal_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintNormal_FunctionAddress, "PlaneNormal", Classes.FStructProperty);
		SetPlaneConstraintNormal_IsValid = SetPlaneConstraintNormal_FunctionAddress != IntPtr.Zero && SetPlaneConstraintNormal_PlaneNormal_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetPlaneConstraintNormal", SetPlaneConstraintNormal_IsValid);
		SetPlaneConstraintFromVectors_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneConstraintFromVectors");
		SetPlaneConstraintFromVectors_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneConstraintFromVectors_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintFromVectors_Forward_PropertyAddress, SetPlaneConstraintFromVectors_FunctionAddress, "Forward");
		SetPlaneConstraintFromVectors_Forward_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintFromVectors_FunctionAddress, "Forward");
		SetPlaneConstraintFromVectors_Forward_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintFromVectors_FunctionAddress, "Forward", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintFromVectors_Up_PropertyAddress, SetPlaneConstraintFromVectors_FunctionAddress, "Up");
		SetPlaneConstraintFromVectors_Up_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintFromVectors_FunctionAddress, "Up");
		SetPlaneConstraintFromVectors_Up_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintFromVectors_FunctionAddress, "Up", Classes.FStructProperty);
		SetPlaneConstraintFromVectors_IsValid = SetPlaneConstraintFromVectors_FunctionAddress != IntPtr.Zero && SetPlaneConstraintFromVectors_Forward_IsValid && SetPlaneConstraintFromVectors_Up_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetPlaneConstraintFromVectors", SetPlaneConstraintFromVectors_IsValid);
		SetPlaneConstraintEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneConstraintEnabled");
		SetPlaneConstraintEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneConstraintEnabled_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintEnabled_bEnabled_PropertyAddress, SetPlaneConstraintEnabled_FunctionAddress, "bEnabled");
		SetPlaneConstraintEnabled_bEnabled_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintEnabled_FunctionAddress, "bEnabled");
		SetPlaneConstraintEnabled_bEnabled_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintEnabled_FunctionAddress, "bEnabled", Classes.FBoolProperty);
		SetPlaneConstraintEnabled_IsValid = SetPlaneConstraintEnabled_FunctionAddress != IntPtr.Zero && SetPlaneConstraintEnabled_bEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetPlaneConstraintEnabled", SetPlaneConstraintEnabled_IsValid);
		SetPlaneConstraintAxisSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetPlaneConstraintAxisSetting");
		SetPlaneConstraintAxisSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(SetPlaneConstraintAxisSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref SetPlaneConstraintAxisSetting_NewAxisSetting_PropertyAddress, SetPlaneConstraintAxisSetting_FunctionAddress, "NewAxisSetting");
		SetPlaneConstraintAxisSetting_NewAxisSetting_Offset = NativeReflectionCached.GetPropertyOffset(SetPlaneConstraintAxisSetting_FunctionAddress, "NewAxisSetting");
		SetPlaneConstraintAxisSetting_NewAxisSetting_IsValid = NativeReflectionCached.ValidatePropertyClass(SetPlaneConstraintAxisSetting_FunctionAddress, "NewAxisSetting", Classes.FEnumProperty);
		SetPlaneConstraintAxisSetting_IsValid = SetPlaneConstraintAxisSetting_FunctionAddress != IntPtr.Zero && SetPlaneConstraintAxisSetting_NewAxisSetting_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:SetPlaneConstraintAxisSetting", SetPlaneConstraintAxisSetting_IsValid);
		MoveUpdatedComponent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "K2_MoveUpdatedComponent");
		MoveUpdatedComponent_ParamsSize = NativeReflection.GetFunctionParamsSize(MoveUpdatedComponent_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_Delta_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "Delta");
		MoveUpdatedComponent_Delta_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "Delta");
		MoveUpdatedComponent_Delta_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "Delta", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_NewRotation_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "NewRotation");
		MoveUpdatedComponent_NewRotation_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "NewRotation");
		MoveUpdatedComponent_NewRotation_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "NewRotation", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_OutHit_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "OutHit");
		MoveUpdatedComponent_OutHit_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "OutHit");
		MoveUpdatedComponent_OutHit_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "OutHit", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_bSweep_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "bSweep");
		MoveUpdatedComponent_bSweep_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "bSweep");
		MoveUpdatedComponent_bSweep_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "bSweep", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_bTeleport_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "bTeleport");
		MoveUpdatedComponent_bTeleport_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "bTeleport");
		MoveUpdatedComponent_bTeleport_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "bTeleport", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref MoveUpdatedComponent_ReturnValue_PropertyAddress, MoveUpdatedComponent_FunctionAddress, "ReturnValue");
		MoveUpdatedComponent_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(MoveUpdatedComponent_FunctionAddress, "ReturnValue");
		MoveUpdatedComponent_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(MoveUpdatedComponent_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		MoveUpdatedComponent_IsValid = MoveUpdatedComponent_FunctionAddress != IntPtr.Zero && MoveUpdatedComponent_Delta_IsValid && MoveUpdatedComponent_NewRotation_IsValid && MoveUpdatedComponent_OutHit_IsValid && MoveUpdatedComponent_bSweep_IsValid && MoveUpdatedComponent_bTeleport_IsValid && MoveUpdatedComponent_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:K2_MoveUpdatedComponent", MoveUpdatedComponent_IsValid);
		IsExceedingMaxSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "IsExceedingMaxSpeed");
		IsExceedingMaxSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(IsExceedingMaxSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref IsExceedingMaxSpeed_MaxSpeed_PropertyAddress, IsExceedingMaxSpeed_FunctionAddress, "MaxSpeed");
		IsExceedingMaxSpeed_MaxSpeed_Offset = NativeReflectionCached.GetPropertyOffset(IsExceedingMaxSpeed_FunctionAddress, "MaxSpeed");
		IsExceedingMaxSpeed_MaxSpeed_IsValid = NativeReflectionCached.ValidatePropertyClass(IsExceedingMaxSpeed_FunctionAddress, "MaxSpeed", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IsExceedingMaxSpeed_ReturnValue_PropertyAddress, IsExceedingMaxSpeed_FunctionAddress, "ReturnValue");
		IsExceedingMaxSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(IsExceedingMaxSpeed_FunctionAddress, "ReturnValue");
		IsExceedingMaxSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(IsExceedingMaxSpeed_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		IsExceedingMaxSpeed_IsValid = IsExceedingMaxSpeed_FunctionAddress != IntPtr.Zero && IsExceedingMaxSpeed_MaxSpeed_IsValid && IsExceedingMaxSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:IsExceedingMaxSpeed", IsExceedingMaxSpeed_IsValid);
		GetPlaneConstraintOrigin_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaneConstraintOrigin");
		GetPlaneConstraintOrigin_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaneConstraintOrigin_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaneConstraintOrigin_ReturnValue_PropertyAddress, GetPlaneConstraintOrigin_FunctionAddress, "ReturnValue");
		GetPlaneConstraintOrigin_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaneConstraintOrigin_FunctionAddress, "ReturnValue");
		GetPlaneConstraintOrigin_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaneConstraintOrigin_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlaneConstraintOrigin_IsValid = GetPlaneConstraintOrigin_FunctionAddress != IntPtr.Zero && GetPlaneConstraintOrigin_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetPlaneConstraintOrigin", GetPlaneConstraintOrigin_IsValid);
		GetPlaneConstraintNormal_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaneConstraintNormal");
		GetPlaneConstraintNormal_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaneConstraintNormal_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaneConstraintNormal_ReturnValue_PropertyAddress, GetPlaneConstraintNormal_FunctionAddress, "ReturnValue");
		GetPlaneConstraintNormal_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaneConstraintNormal_FunctionAddress, "ReturnValue");
		GetPlaneConstraintNormal_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaneConstraintNormal_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		GetPlaneConstraintNormal_IsValid = GetPlaneConstraintNormal_FunctionAddress != IntPtr.Zero && GetPlaneConstraintNormal_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetPlaneConstraintNormal", GetPlaneConstraintNormal_IsValid);
		GetPlaneConstraintAxisSetting_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPlaneConstraintAxisSetting");
		GetPlaneConstraintAxisSetting_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPlaneConstraintAxisSetting_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPlaneConstraintAxisSetting_ReturnValue_PropertyAddress, GetPlaneConstraintAxisSetting_FunctionAddress, "ReturnValue");
		GetPlaneConstraintAxisSetting_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPlaneConstraintAxisSetting_FunctionAddress, "ReturnValue");
		GetPlaneConstraintAxisSetting_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPlaneConstraintAxisSetting_FunctionAddress, "ReturnValue", Classes.FEnumProperty);
		GetPlaneConstraintAxisSetting_IsValid = GetPlaneConstraintAxisSetting_FunctionAddress != IntPtr.Zero && GetPlaneConstraintAxisSetting_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetPlaneConstraintAxisSetting", GetPlaneConstraintAxisSetting_IsValid);
		GetPhysicsVolume_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetPhysicsVolume");
		GetPhysicsVolume_ParamsSize = NativeReflection.GetFunctionParamsSize(GetPhysicsVolume_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetPhysicsVolume_ReturnValue_PropertyAddress, GetPhysicsVolume_FunctionAddress, "ReturnValue");
		GetPhysicsVolume_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetPhysicsVolume_FunctionAddress, "ReturnValue");
		GetPhysicsVolume_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetPhysicsVolume_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetPhysicsVolume_IsValid = GetPhysicsVolume_FunctionAddress != IntPtr.Zero && GetPhysicsVolume_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetPhysicsVolume", GetPhysicsVolume_IsValid);
		GetMaxSpeed_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetMaxSpeed");
		GetMaxSpeed_ParamsSize = NativeReflection.GetFunctionParamsSize(GetMaxSpeed_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetMaxSpeed_ReturnValue_PropertyAddress, GetMaxSpeed_FunctionAddress, "ReturnValue");
		GetMaxSpeed_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetMaxSpeed_FunctionAddress, "ReturnValue");
		GetMaxSpeed_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetMaxSpeed_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetMaxSpeed_IsValid = GetMaxSpeed_FunctionAddress != IntPtr.Zero && GetMaxSpeed_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetMaxSpeed", GetMaxSpeed_IsValid);
		GetGravityZ_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetGravityZ");
		GetGravityZ_ParamsSize = NativeReflection.GetFunctionParamsSize(GetGravityZ_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetGravityZ_ReturnValue_PropertyAddress, GetGravityZ_FunctionAddress, "ReturnValue");
		GetGravityZ_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetGravityZ_FunctionAddress, "ReturnValue");
		GetGravityZ_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetGravityZ_FunctionAddress, "ReturnValue", Classes.FFloatProperty);
		GetGravityZ_IsValid = GetGravityZ_FunctionAddress != IntPtr.Zero && GetGravityZ_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:GetGravityZ", GetGravityZ_IsValid);
		ConstrainNormalToPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstrainNormalToPlane");
		ConstrainNormalToPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstrainNormalToPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstrainNormalToPlane_Normal_PropertyAddress, ConstrainNormalToPlane_FunctionAddress, "Normal");
		ConstrainNormalToPlane_Normal_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainNormalToPlane_FunctionAddress, "Normal");
		ConstrainNormalToPlane_Normal_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainNormalToPlane_FunctionAddress, "Normal", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainNormalToPlane_ReturnValue_PropertyAddress, ConstrainNormalToPlane_FunctionAddress, "ReturnValue");
		ConstrainNormalToPlane_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainNormalToPlane_FunctionAddress, "ReturnValue");
		ConstrainNormalToPlane_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainNormalToPlane_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConstrainNormalToPlane_IsValid = ConstrainNormalToPlane_FunctionAddress != IntPtr.Zero && ConstrainNormalToPlane_Normal_IsValid && ConstrainNormalToPlane_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:ConstrainNormalToPlane", ConstrainNormalToPlane_IsValid);
		ConstrainLocationToPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstrainLocationToPlane");
		ConstrainLocationToPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstrainLocationToPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstrainLocationToPlane_Location_PropertyAddress, ConstrainLocationToPlane_FunctionAddress, "Location");
		ConstrainLocationToPlane_Location_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainLocationToPlane_FunctionAddress, "Location");
		ConstrainLocationToPlane_Location_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainLocationToPlane_FunctionAddress, "Location", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainLocationToPlane_ReturnValue_PropertyAddress, ConstrainLocationToPlane_FunctionAddress, "ReturnValue");
		ConstrainLocationToPlane_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainLocationToPlane_FunctionAddress, "ReturnValue");
		ConstrainLocationToPlane_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainLocationToPlane_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConstrainLocationToPlane_IsValid = ConstrainLocationToPlane_FunctionAddress != IntPtr.Zero && ConstrainLocationToPlane_Location_IsValid && ConstrainLocationToPlane_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:ConstrainLocationToPlane", ConstrainLocationToPlane_IsValid);
		ConstrainDirectionToPlane_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ConstrainDirectionToPlane");
		ConstrainDirectionToPlane_ParamsSize = NativeReflection.GetFunctionParamsSize(ConstrainDirectionToPlane_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref ConstrainDirectionToPlane_Direction_PropertyAddress, ConstrainDirectionToPlane_FunctionAddress, "Direction");
		ConstrainDirectionToPlane_Direction_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainDirectionToPlane_FunctionAddress, "Direction");
		ConstrainDirectionToPlane_Direction_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainDirectionToPlane_FunctionAddress, "Direction", Classes.FStructProperty);
		NativeReflectionCached.GetPropertyRef(ref ConstrainDirectionToPlane_ReturnValue_PropertyAddress, ConstrainDirectionToPlane_FunctionAddress, "ReturnValue");
		ConstrainDirectionToPlane_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(ConstrainDirectionToPlane_FunctionAddress, "ReturnValue");
		ConstrainDirectionToPlane_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(ConstrainDirectionToPlane_FunctionAddress, "ReturnValue", Classes.FStructProperty);
		ConstrainDirectionToPlane_IsValid = ConstrainDirectionToPlane_FunctionAddress != IntPtr.Zero && ConstrainDirectionToPlane_Direction_IsValid && ConstrainDirectionToPlane_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.MovementComponent:ConstrainDirectionToPlane", ConstrainDirectionToPlane_IsValid);
	}
}
