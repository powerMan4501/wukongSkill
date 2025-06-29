using System;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using AOT;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_PropMgrComp : UActorCompBaseCS
{
	private static class BUS_PropMgrComp_NativeCallback
	{
		private delegate uint Del_NativeSetEnumProperty(IntPtr Owner, int PropType, int EnumValue, uint InHandleID);

		private delegate uint Del_NativeSetCollisionResponseProperty(IntPtr Owner, int PropType, ECollisionChannel Channel, ECollisionResponseType Response, uint InHandleID);

		private delegate uint Del_NativeSetFloatProperty(IntPtr Owner, int PropType, float FloatValue, uint InHandleID);

		private delegate void Del_NativeResetProperty(IntPtr Owner, uint InHandleID);

		private delegate uint Del_OnNativeSetEnumProperty(IntPtr Owner, int PropType, int EnumValue, uint InHandleID);

		private delegate uint Del_OnNativeSetCollisionResponseProperty(IntPtr Owner, int PropType, ECollisionChannel Channel, ECollisionResponseType Response, uint InHandleID);

		private delegate uint Del_OnNativeSetFloatProperty(IntPtr Owner, int PropType, float FloatValue, uint InHandleID);

		private delegate void Del_OnNativeResetProperty(IntPtr Owner, uint InHandleID);

		public static int Ref;

		private static Del_NativeSetEnumProperty NativeSetEnumProperty;

		private static Del_NativeSetCollisionResponseProperty NativeSetCollisionResponseProperty;

		private static Del_NativeSetFloatProperty NativeSetFloatProperty;

		private static Del_NativeResetProperty NativeResetProperty;

		static BUS_PropMgrComp_NativeCallback()
		{
			Ref = 0;
			NativeSetEnumProperty = OnNativeSetEnumProperty;
			NativeSetCollisionResponseProperty = OnNativeSetCollisionResponseProperty;
			NativeSetFloatProperty = OnNativeSetFloatProperty;
			NativeResetProperty = OnNativeResetProperty;
			UBGUFuncLibCSDelegateRegister.Register_SetEnumProperty(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeSetEnumProperty)));
			UBGUFuncLibCSDelegateRegister.Register_SetCollisionResponseProperty(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeSetCollisionResponseProperty)));
			UBGUFuncLibCSDelegateRegister.Register_SetFloatProperty(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeSetFloatProperty)));
			UBGUFuncLibCSDelegateRegister.Register_ResetProperty(FIntPtrHelper.IntPtr2FIntPtr(Marshal.GetFunctionPointerForDelegate(NativeResetProperty)));
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeSetEnumProperty))]
		private static uint OnNativeSetEnumProperty(IntPtr Owner, int PropType, int EnumValue, uint InHandleID)
		{
			try
			{
				AActor aActor = GCHelper.Find<AActor>(Owner);
				if (aActor == null)
				{
					return 0u;
				}
				IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(aActor);
				if (readOnlyData == null)
				{
					return 0u;
				}
				BUS_EventCollectionCS.Get(aActor)?.Evt_SetEnumProperty.Invoke((EPropType)PropType, EnumValue, InHandleID);
				return (InHandleID != 0) ? InHandleID : readOnlyData.GetLastHandleID();
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
				return 0u;
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeSetCollisionResponseProperty))]
		private static uint OnNativeSetCollisionResponseProperty(IntPtr Owner, int PropType, ECollisionChannel Channel, ECollisionResponseType Response, uint InHandleID)
		{
			try
			{
				AActor aActor = GCHelper.Find<AActor>(Owner);
				if (aActor == null)
				{
					return 0u;
				}
				IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(aActor);
				if (readOnlyData == null)
				{
					return 0u;
				}
				BUS_EventCollectionCS.Get(aActor)?.Evt_SetCollisionResponseProperty.Invoke((EPropType)PropType, new Dictionary<ECollisionChannel, ECollisionResponseType> { { Channel, Response } }, InHandleID);
				return (InHandleID != 0) ? InHandleID : readOnlyData.GetLastHandleID();
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
				return 0u;
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeSetFloatProperty))]
		private static uint OnNativeSetFloatProperty(IntPtr Owner, int PropType, float FloatValue, uint InHandleID)
		{
			try
			{
				AActor aActor = GCHelper.Find<AActor>(Owner);
				if (aActor == null)
				{
					return 0u;
				}
				IBUC_PropMgrData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_PropMgrData, BUC_PropMgrData>(aActor);
				if (readOnlyData == null)
				{
					return 0u;
				}
				BUS_EventCollectionCS.Get(aActor)?.Evt_SetFloatProperty.Invoke((EPropType)PropType, FloatValue, InHandleID);
				return (InHandleID != 0) ? InHandleID : readOnlyData.GetLastHandleID();
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
				return 0u;
			}
		}

		[MonoPInvokeCallback(typeof(Del_OnNativeResetProperty))]
		private static void OnNativeResetProperty(IntPtr Owner, uint InHandleID)
		{
			try
			{
				AActor aActor = GCHelper.Find<AActor>(Owner);
				if (!(aActor == null))
				{
					BUS_EventCollectionCS.Get(aActor)?.Evt_ResetProperty.Invoke(InHandleID);
				}
			}
			catch (Exception e)
			{
				USharpExceptionHandler.HandleException(e, EUSharpExceptionType.NativeReflectionInvokeFunction);
			}
		}
	}

	private BUC_PropMgrData PropMgrData;

	private TStrongObjectPtr<UCharacterMovementComponent> mMovementComp = new TStrongObjectPtr<UCharacterMovementComponent>();

	private TStrongObjectPtr<USkeletalMeshComponent> mMeshComp = new TStrongObjectPtr<USkeletalMeshComponent>();

	private TStrongObjectPtr<UCapsuleComponent> mCapsuleComp = new TStrongObjectPtr<UCapsuleComponent>();

	private UCharacterMovementComponent MovementComp
	{
		get
		{
			return mMovementComp.Get();
		}
		set
		{
			mMovementComp.Set(value);
		}
	}

	private USkeletalMeshComponent MeshComp
	{
		get
		{
			return mMeshComp.Get();
		}
		set
		{
			mMeshComp.Set(value);
		}
	}

	private UCapsuleComponent CapsuleComp
	{
		get
		{
			return mCapsuleComp.Get();
		}
		set
		{
			mCapsuleComp.Set(value);
		}
	}

	public override void OnAttach()
	{
		BUS_PropMgrComp_NativeCallback.Ref++;
		PropMgrData = RequireWritableData<BUC_PropMgrData>();
		base.BUSEventCollection.Evt_ResetProperty += new Del_ResetProperty(OnResetProperty);
		base.BUSEventCollection.Evt_SetBoolProperty += new Del_SetBoolProperty(OnSetBoolProperty);
		base.BUSEventCollection.Evt_SetBoolBoolProperty += new Del_SetBoolBoolProperty(OnSetBoolBoolProperty);
		base.BUSEventCollection.Evt_SetVectorProperty += new Del_SetVectorProperty(OnSetVectorProperty);
		base.BUSEventCollection.Evt_SetRotatorProperty += new Del_SetRotatorProperty(OnSetRotatorProperty);
		base.BUSEventCollection.Evt_SetFloatProperty += new Del_SetFloatProperty(OnSetFloatProperty);
		base.BUSEventCollection.Evt_SetIntProperty += new Del_SetIntProperty(OnSetIntProperty);
		base.BUSEventCollection.Evt_SetEnumProperty += new Del_SetEnumProperty(OnSetEnumProperty);
		base.BUSEventCollection.Evt_SetStringProperty += new Del_SetStringProperty(OnSetStringProperty);
		base.BUSEventCollection.Evt_SetCollisionResponseProperty += new Del_SetCollisionResponseProperty(OnSetCollisionResponseProperty);
		if (GetOwner() is ACharacter aCharacter)
		{
			MovementComp = aCharacter.CharacterMovement;
			MeshComp = aCharacter.Mesh;
			CapsuleComp = aCharacter.CapsuleComponent;
		}
		if (GetOwner() is BGUWeaponBase bGUWeaponBase)
		{
			MeshComp = bGUWeaponBase.SkeletalMeshComp;
		}
		Init();
		InitProp();
	}

	public override void OnEndPlay(EEndPlayReason EndPlayReason)
	{
		foreach (KeyValuePair<EPropType, List<uint>> item in PropMgrData.MapPropType2HandleID)
		{
			if (PropMgrData.MapPropType.TryGetValue(item.Key, out var value))
			{
				int num = ((!value.bCompositeProp) ? 1 : 0);
				int num2 = 0;
				List<uint> value2 = item.Value;
				while (value2.Count > num && num2++ < 10000)
				{
					OnResetProperty(value2[value2.Count - 1]);
				}
			}
		}
		PropMgrData.MapNotifyHandleID.Clear();
	}

	private void InitProp()
	{
		if (MovementComp != null)
		{
			InitPropType(EPropType.Movement_OrientRotationToMovement, new BGU_PropMgrType_Movement_OrientRotationToMovement(MovementComp));
			InitPropType(EPropType.Movement_RotationRate, new BGU_PropMgrType_Movement_RotationRate(MovementComp));
			InitPropType(EPropType.Movement_BrakingDecelerationWalking, new BGU_PropMgrType_Movement_BrakingDecelerationWalking(MovementComp));
			InitPropType(EPropType.Movement_MaxAcceleration, new BGU_PropMgrType_Movement_MaxAcceleration(MovementComp));
			InitPropType(EPropType.Movement_GroundFriction, new BGU_PropMgrType_Movement_GroundFriction(MovementComp));
			InitPropType(EPropType.Movement_CanWalkOffLedges, new BGU_PropMgrType_Movement_CanWalkOffLedges(MovementComp));
			InitPropType(EPropType.Movement_AllowPhysicsRotationDuringAnimRootMotion, new BGU_PropMgrType_Movement_AllowPhysicsRotationDuringAnimRootMotion(MovementComp));
			InitPropType(EPropType.Movement_MaxCustomMovementSpeed, new BGU_PropMgrType_Movement_MaxCustomMovementSpeed(MovementComp));
			InitPropType(EPropType.Movement_MaxFlySpeed, new BGU_PropMgrType_Movement_MaxFlySpeed(MovementComp));
			InitPropType(EPropType.Movement_MaxSwimSpeed, new BGU_PropMgrType_Movement_MaxSwimSpeed(MovementComp));
			InitPropType(EPropType.Movement_MaxWalkSpeedCrouched, new BGU_PropMgrType_Movement_MaxWalkSpeedCrouched(MovementComp));
			InitPropType(EPropType.Movement_MaxWalkSpeed, new BGU_PropMgrType_Movement_MaxWalkSpeed(MovementComp));
			InitPropType(EPropType.Movement_MovementMode, new BGU_PropMgrType_Movement_MovementMode(MovementComp));
			InitPropType(EPropType.Movement_GravityScale, new BGU_PropMgrType_Movement_GravityScale(MovementComp));
			InitPropType(EPropType.Movement_BrakingFrictionFactor, new BGU_PropMgrType_Movement_BrakingFrictionFactor(MovementComp));
			InitPropType(EPropType.Movement_BrakingFriction, new BGU_PropMgrType_Movement_BrakingFriction(MovementComp));
			InitPropType(EPropType.Movement_SpeedCtrlInfo, new BGU_PropMgrType_Movement_SpeedCtrlInfo(MovementComp));
		}
		if (Owner != null)
		{
			InitPropType(EPropType.Actor_CustomTimeDilation, new BGU_PropMgrType_Actor_CustomTimeDilation(Owner));
			InitPropType(EPropType.Actor_ActorHiddenInGame, new BGU_PropMgrType_Actor_ActorHiddenInGame(Owner));
			InitPropType(EPropType.Actor_AttackerAbnormalDispID_Override, new BGU_PropMgrType_Actor_AttackerAbnormalDispID_Override(Owner));
		}
		if (MeshComp != null)
		{
			InitPropType(EPropType.Mesh_EnableGravity, new BGU_PropMgrType_Mesh_EnableGravity(MeshComp));
			InitPropType(EPropType.Mesh_PauseAnims, new BGU_PropMgrType_Mesh_PauseAnims(MeshComp));
			InitPropType(EPropType.Mesh_HiddenInGame, new BGU_PropMgrType_Mesh_HiddenInGame(MeshComp));
			InitPropType(EPropType.Mesh_Visibility, new BGU_PropMgrType_Mesh_Visibility(MeshComp));
			InitPropType(EPropType.Mesh_CollisionEnabled, new BGU_PropMgrType_Mesh_CollisionEnabled(MeshComp));
			InitPropType(EPropType.Mesh_CollisionObjectType, new BGU_PropMgrType_Mesh_CollisionObjectType(MeshComp));
			InitPropType(EPropType.Mesh_CollisionProfileName, new BGU_PropMgrType_Mesh_CollisionProfileName(MeshComp));
			InitPropType(EPropType.Mesh_CollisionResponseToChannels, new BGU_PropMgrType_Mesh_CollisionResponseToChannels(MeshComp));
			InitPropType(EPropType.Mesh_EnableFootIK, new BGU_PropMgrType_Mesh_EnableFootIK(MeshComp));
		}
		if (CapsuleComp != null)
		{
			InitPropType(EPropType.Capsule_EnableGravity, new BGU_PropMgrType_Capsule_EnableGravity(CapsuleComp));
			InitPropType(EPropType.Capsule_CollisionEnabled, new BGU_PropMgrType_Capsule_CollisionEnabled(CapsuleComp));
			InitPropType(EPropType.Capsule_CollisionObjectType, new BGU_PropMgrType_Capsule_CollisionObjectType(CapsuleComp));
			InitPropType(EPropType.Capsule_CollisionProfileName, new BGU_PropMgrType_Capsule_CollisionProfileName(CapsuleComp));
			InitPropType(EPropType.Capsule_CollisionResponseToChannels, new BGU_PropMgrType_Capsule_CollisionResponseToChannels(CapsuleComp));
		}
	}

	private void Init()
	{
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Stack, new b1.BUPCStack());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Queue, new b1.BUPCQueue());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Sum, new b1.BUPCSum());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Mul, new b1.BUPCMul());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.And, new b1.BUPCAnd());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Or, new b1.BUPCOr());
		PropMgrData.MapPropCalcTemplate.Add(EPropCalcRule.Merge, new b1.BUPCMerge());
	}

	private void OnSetBoolProperty(EPropType PropType, bool Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_BoolPropRequest request = new BGU_BoolPropRequest(Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetBoolBoolProperty(EPropType PropType, bool Value1, bool Value2, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_BoolBoolPropRequest request = new BGU_BoolBoolPropRequest(Value1, Value2);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetVectorProperty(EPropType PropType, in FVector Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_VectorPropRequest request = new BGU_VectorPropRequest(in Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetRotatorProperty(EPropType PropType, in FRotator Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_RotatorPropRequest request = new BGU_RotatorPropRequest(in Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetFloatProperty(EPropType PropType, float Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_FloatPropRequest request = new BGU_FloatPropRequest(Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetIntProperty(EPropType PropType, int Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_IntPropRequest request = new BGU_IntPropRequest(Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetEnumProperty(EPropType PropType, int Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false, string ResourceInfo = "")
	{
		BGU_EnumPropRequest request = new BGU_EnumPropRequest(Value, ResourceInfo);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetStringProperty(EPropType PropType, string Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_StringPropRequest request = new BGU_StringPropRequest(Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void OnSetCollisionResponseProperty(EPropType PropType, Dictionary<ECollisionChannel, ECollisionResponseType> Value, uint HandleID = 0u, uint NotifyUniqueID = 0u, bool bSetDefaultProperty = false)
	{
		BGU_CollisionResponsePropRequest request = new BGU_CollisionResponsePropRequest(Value);
		CalcProperty(PropType, request, HandleID, NotifyUniqueID, bSetDefaultProperty);
	}

	private void InitPropType(EPropType PropType, BGU_PropMgrTypeBase PropTypeObj)
	{
		PropMgrData.MapPropType2HandleID.Add(PropType, new List<uint>());
		PropMgrData.MapPropType.Add(PropType, PropTypeObj);
		PropTypeObj.SetDefaultProperty(base.BUSEventCollection);
	}

	private void DoCaculateProperty(EPropType PropType)
	{
		if (PropMgrData.MapPropType.TryGetValue(PropType, out var value) && PropMgrData.MapPropCalcTemplate.TryGetValue(value.CalcRule, out var value2))
		{
			BGU_PropMgrRequestBase request = value2.Calculate(PropMgrData.MapPropRequest, PropMgrData.MapPropType2HandleID[PropType]);
			value.HandlePropertyRequest(request, base.BUSEventCollection);
		}
	}

	private void CalcProperty(EPropType PropType, BGU_PropMgrRequestBase Request, uint HandleID, uint NotifyUniqueID, bool bSetDefaultProperty)
	{
		if (!PropMgrData.MapPropType.TryGetValue(PropType, out var value))
		{
			return;
		}
		if (NotifyUniqueID != 0 && PropMgrData.MapNotifyHandleID.TryGetValue(NotifyUniqueID, out var value2) && value2.TryGetValue(PropType, out var value3))
		{
			HandleID = value3;
		}
		if (HandleID == 0)
		{
			HandleID = PropMgrData.GenHandleID();
			PropMgrData.MapPropRequest.Add(HandleID, Request);
			PropMgrData.MapHandleID2PropType.Add(HandleID, PropType);
			PropMgrData.MapPropType2HandleID[PropType].Add(HandleID);
			if (NotifyUniqueID != 0)
			{
				if (PropMgrData.MapNotifyHandleID.TryGetValue(NotifyUniqueID, out var value4))
				{
					value4.Add(PropType, HandleID);
				}
				else
				{
					value4 = new Dictionary<EPropType, uint> { { PropType, HandleID } };
					PropMgrData.MapNotifyHandleID.Add(NotifyUniqueID, value4);
				}
			}
		}
		else
		{
			if (!PropMgrData.MapPropRequest.TryGetValue(HandleID, out var value5) || value5.Equals(Request))
			{
				return;
			}
			Request.ChildHandleID = value5.ChildHandleID;
			PropMgrData.MapPropRequest[HandleID] = Request;
		}
		if (bSetDefaultProperty)
		{
			return;
		}
		if (value.bCompositeProp)
		{
			value.HandlePropertyRequest(Request, base.BUSEventCollection);
			if (Request.ChildHandleID == null)
			{
				return;
			}
			{
				foreach (uint item in Request.ChildHandleID)
				{
					PropMgrData.MapHandleIDChild2Main.Add(item, HandleID);
				}
				return;
			}
		}
		DoCaculateProperty(PropType);
	}

	private void OnResetProperty(uint HandleID, uint NotifyUniqueID = 0u)
	{
		if (NotifyUniqueID != 0)
		{
			if (!PropMgrData.MapNotifyHandleID.TryGetValue(NotifyUniqueID, out var value))
			{
				return;
			}
			foreach (KeyValuePair<EPropType, uint> item in value)
			{
				OnResetProperty(item.Value);
			}
			PropMgrData.MapNotifyHandleID.Remove(NotifyUniqueID);
		}
		else
		{
			if (!PropMgrData.MapPropRequest.TryGetValue(HandleID, out var value2) || !PropMgrData.MapHandleID2PropType.TryGetValue(HandleID, out var value3) || !PropMgrData.MapPropType.TryGetValue(value3, out var value4))
			{
				return;
			}
			PropMgrData.MapPropRequest.Remove(HandleID);
			PropMgrData.MapHandleID2PropType.Remove(HandleID);
			PropMgrData.MapPropType2HandleID[value3].Remove(HandleID);
			if (value4.bCompositeProp)
			{
				if (value2.ChildHandleID == null)
				{
					return;
				}
				foreach (uint item2 in value2.ChildHandleID)
				{
					OnResetProperty(item2);
				}
				foreach (uint item3 in value2.ChildHandleID)
				{
					PropMgrData.MapHandleIDChild2Main.Remove(item3);
				}
				value2.ChildHandleID.Clear();
			}
			else
			{
				DoCaculateProperty(value3);
			}
		}
	}
}
