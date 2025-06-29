using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("BAN Trigger Effect")]
[UClass]
[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect")]
public class BAN_GSTriggerEffect : BAN_GSBase
{
	private static bool EffectID_IsValid;

	private static int EffectID_Offset;

	private static bool TargetType_IsValid;

	private static int TargetType_Offset;

	private static FFieldAddress TargetType_PropertyAddress;

	private static bool Command_IsValid;

	private static int Command_Offset;

	private static bool GSNotifyCS_IsValid;

	private static IntPtr GSNotifyCS_FunctionAddress;

	private static int GSNotifyCS_ParamsSize;

	private static bool GSNotifyCS_NotifyParam_IsValid;

	private static int GSNotifyCS_NotifyParam_Offset;

	private static FFieldAddress GSNotifyCS_NotifyParam_PropertyAddress;

	private static bool GSValidateInputCS_IsValid;

	private static IntPtr GSValidateInputCS_FunctionAddress;

	private static int GSValidateInputCS_ParamsSize;

	private static bool GSValidateInputCS_actor_IsValid;

	private static int GSValidateInputCS_actor_Offset;

	private static bool bIsNativeBranchingPointCS_IsValid;

	private static IntPtr bIsNativeBranchingPointCS_FunctionAddress;

	private static int bIsNativeBranchingPointCS_ParamsSize;

	private static bool bIsNativeBranchingPointCS_ReturnValue_IsValid;

	private static int bIsNativeBranchingPointCS_ReturnValue_Offset;

	private static FFieldAddress bIsNativeBranchingPointCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:EffectID")]
	public int EffectID
	{
		get
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:EffectID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, EffectID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!EffectID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:EffectID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, EffectID_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:TargetType")]
	public EANTriggerEffectTargetType TargetType
	{
		get
		{
			CheckDestroyed();
			if (!TargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:TargetType");
				return EANTriggerEffectTargetType.Owner;
			}
			return EnumMarshaler<EANTriggerEffectTargetType>.FromNative(IntPtr.Add(base.Address, TargetType_Offset), 0, TargetType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TargetType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:TargetType");
			}
			else
			{
				EnumMarshaler<EANTriggerEffectTargetType>.ToNative(IntPtr.Add(base.Address, TargetType_Offset), 0, TargetType_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:Command")]
	public string Command
	{
		get
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:Command");
				return null;
			}
			return FStringMarshaler.FromNative(IntPtr.Add(base.Address, Command_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Command_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAN_GSTriggerEffect:Command");
			}
			else
			{
				FStringMarshaler.ToNative(IntPtr.Add(base.Address, Command_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		TargetType = EANTriggerEffectTargetType.Owner;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:bIsNativeBranchingPointCS")]
	protected override bool bIsNativeBranchingPointCS_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:GSNotifyCS")]
	protected override void GSNotifyCS_Implementation(FUStGSNotifyParam NotifyParam)
	{
		AActor aActor = NotifyParam.MeshComp?.GetOwner();
		if (!(aActor != null))
		{
			return;
		}
		ABGUCharacter aBGUCharacter = aActor as ABGUCharacter;
		if (!(aBGUCharacter != null) || !(aActor.World != null))
		{
			return;
		}
		AActor aActor2 = GetEffectTarget(aActor, TargetType);
		if (aActor2.IsNullOrDestroyed())
		{
			return;
		}
		BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(aActor);
		if (bUS_GSEventCollection != null)
		{
			FEffectInstReq fEffectInstReq = new FEffectInstReq(aBGUCharacter);
			fEffectInstReq.HitLocation = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
			fEffectInstReq.HitPointNormalDir = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor);
			fEffectInstReq.HitActionDir = EHitActionDir.Default;
			FEffectInstReq effectInstReq = fEffectInstReq;
			if (TargetType == EANTriggerEffectTargetType.Owner)
			{
				aActor2 = null;
			}
			bUS_GSEventCollection.Evt_TriggerSkillEffect.Invoke(EffectID, effectInstReq, aActor2);
		}
	}

	public static AActor GetEffectTarget(AActor Owner, EANTriggerEffectTargetType _TargetType)
	{
		switch (_TargetType)
		{
		case EANTriggerEffectTargetType.Owner:
			return Owner;
		case EANTriggerEffectTargetType.Master:
		{
			IBUC_MasterData readOnlyData3 = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Owner);
			if (readOnlyData3 != null)
			{
				return readOnlyData3.GetMasterActor();
			}
			break;
		}
		case EANTriggerEffectTargetType.LastAttacker:
		{
			IBUC_BeAttackData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_BeAttackData, BUC_BeAttackData>(Owner);
			if (readOnlyData == null)
			{
				break;
			}
			BGUCharacterCS bGUCharacterCS = readOnlyData.GetAttacker() as BGUCharacterCS;
			if (bGUCharacterCS == null)
			{
				BUC_MasterData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUCharacterCS);
				if (readOnlyData2 != null)
				{
					bGUCharacterCS = readOnlyData2.GetMasterActor() as BGUCharacterCS;
				}
			}
			return bGUCharacterCS;
		}
		}
		return null;
	}

	[USharpPath("/Script/b1-Managed.BAN_GSTriggerEffect:GSValidateInputCS")]
	protected override void GSValidateInputCS_Implementation(AActor actor)
	{
		BGW_ValiDateMgr bGW_ValiDateMgr = BGW_ValiDateMgr.Get(actor.World);
		string pathName = GetOuter().GetPathName();
		string name = GetName();
		if (BGW_GameDB.GetSkillEffectDesc(EffectID, actor) == null)
		{
			string logStr = $"Montage（{pathName}）中的Notify（{name}）的EffectID（{EffectID}）未在SkillEffect表中找到索引";
			bGW_ValiDateMgr.ShowValidateWindow(logStr);
		}
		else
		{
			if (EffectID < 10100)
			{
				return;
			}
			BGUCharacterCS bGUCharacterCS = actor as BGUCharacterCS;
			if (bGUCharacterCS != null)
			{
				int resID = bGUCharacterCS.GetResID();
				int num = ((resID >= 100) ? (EffectID / 10000) : (EffectID / 100000));
				if (num != resID)
				{
					string logStr2 = $"Montage（{pathName}）中的Notify（{name}）的EffectID（{EffectID}）未对应单位的ResID（{resID}）";
					bGW_ValiDateMgr.ShowValidateWindow(logStr2);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerEffect:GSNotifyCS")]
	private static void GSNotifyCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSTriggerEffect bAN_GSTriggerEffect = GCHelper.Find<BAN_GSTriggerEffect>(obj);
		FUStGSNotifyParam notifyParam = FUStGSNotifyParam.FromNative(IntPtr.Add(buffer, GSNotifyCS_NotifyParam_Offset));
		bAN_GSTriggerEffect.GSNotifyCS_Implementation(notifyParam);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerEffect:GSValidateInputCS")]
	private static void GSValidateInputCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSTriggerEffect bAN_GSTriggerEffect = GCHelper.Find<BAN_GSTriggerEffect>(obj);
		AActor actor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, GSValidateInputCS_actor_Offset));
		bAN_GSTriggerEffect.GSValidateInputCS_Implementation(actor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BAN_GSTriggerEffect:bIsNativeBranchingPointCS")]
	private static void bIsNativeBranchingPointCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BAN_GSTriggerEffect bAN_GSTriggerEffect = GCHelper.Find<BAN_GSTriggerEffect>(obj);
		bool value = bAN_GSTriggerEffect.bIsNativeBranchingPointCS_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, bIsNativeBranchingPointCS_ReturnValue_Offset), 0, bIsNativeBranchingPointCS_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAN_GSTriggerEffect");
		EffectID_Offset = NativeReflection.GetPropertyOffset(intPtr, "EffectID");
		EffectID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EffectID", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref TargetType_PropertyAddress, intPtr, "TargetType");
		TargetType_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetType");
		TargetType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetType", Classes.FEnumProperty);
		Command_Offset = NativeReflection.GetPropertyOffset(intPtr, "Command");
		Command_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Command", Classes.FStrProperty);
		GSNotifyCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSNotifyCS");
		GSNotifyCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSNotifyCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GSNotifyCS_NotifyParam_PropertyAddress, GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_Offset = NativeReflection.GetPropertyOffset(GSNotifyCS_FunctionAddress, "NotifyParam");
		GSNotifyCS_NotifyParam_IsValid = NativeReflection.ValidatePropertyClass(GSNotifyCS_FunctionAddress, "NotifyParam", Classes.FStructProperty);
		GSNotifyCS_IsValid = GSNotifyCS_FunctionAddress != IntPtr.Zero && GSNotifyCS_NotifyParam_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerEffect:GSNotifyCS", GSNotifyCS_IsValid);
		GSValidateInputCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSValidateInputCS");
		GSValidateInputCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GSValidateInputCS_FunctionAddress);
		GSValidateInputCS_actor_Offset = NativeReflection.GetPropertyOffset(GSValidateInputCS_FunctionAddress, "actor");
		GSValidateInputCS_actor_IsValid = NativeReflection.ValidatePropertyClass(GSValidateInputCS_FunctionAddress, "actor", Classes.FObjectProperty);
		GSValidateInputCS_IsValid = GSValidateInputCS_FunctionAddress != IntPtr.Zero && GSValidateInputCS_actor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerEffect:GSValidateInputCS", GSValidateInputCS_IsValid);
		bIsNativeBranchingPointCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "bIsNativeBranchingPointCS");
		bIsNativeBranchingPointCS_ParamsSize = NativeReflection.GetFunctionParamsSize(bIsNativeBranchingPointCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref bIsNativeBranchingPointCS_ReturnValue_PropertyAddress, bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue");
		bIsNativeBranchingPointCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(bIsNativeBranchingPointCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		bIsNativeBranchingPointCS_IsValid = bIsNativeBranchingPointCS_FunctionAddress != IntPtr.Zero && bIsNativeBranchingPointCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BAN_GSTriggerEffect:bIsNativeBranchingPointCS", bIsNativeBranchingPointCS_IsValid);
	}

	static BAN_GSTriggerEffect()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAN_GSTriggerEffect)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAN_GSTriggerEffect));
	}
}
