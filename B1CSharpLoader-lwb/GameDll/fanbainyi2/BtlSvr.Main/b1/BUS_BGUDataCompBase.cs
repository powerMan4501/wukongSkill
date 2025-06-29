using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_BGUDataCompBase")]
public class BUS_BGUDataCompBase : UBGUDataComp
{
	protected Entity Entity;

	protected BGW_ECSWorld ECSWorld;

	protected bool LateBeginPlayFinish;

	public List<ECSDataInitTemplate> DataInitTemplate;

	private static bool InitOnNewInCS_IsValid;

	private static IntPtr InitOnNewInCS_FunctionAddress;

	private static int InitOnNewInCS_ParamsSize;

	private static bool OnDestoryInCS_IsValid;

	private static IntPtr OnDestoryInCS_FunctionAddress;

	private static int OnDestoryInCS_ParamsSize;

	private static bool PreECSBeginPlay_IsValid;

	private static IntPtr PreECSBeginPlay_FunctionAddress;

	private static int PreECSBeginPlay_ParamsSize;

	private static bool LateECSBeginPlay_IsValid;

	private static IntPtr LateECSBeginPlay_FunctionAddress;

	private static int LateECSBeginPlay_ParamsSize;

	public void FreshNetRole(int NewNetRole)
	{
		if (ECSWorld != null)
		{
			bool flag = (NewNetRole & 0x80) != 0;
			bool flag2 = (NewNetRole & 2) != 0;
			bool flag3 = (NewNetRole & 0x1000) != 0;
			bool flag4 = (NewNetRole & 0x800) != 0;
			bool isActive = (!flag3 && (flag || flag2)) || (flag3 && flag4);
			ECSWorld.GetObject<BUC_ABPHelperData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_AttrContainer>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_BuffData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_ChargeSkillData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_FallDyingData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_MontageSyncData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_PredictionTestData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_ReplicateTestData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_SimpleStateData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_TargetInfoData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_UnitHatredData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_UnitStateData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_ObjActorMovementData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_InteractData>(Entity)?._SetRepActive(isActive);
			ECSWorld.GetObject<BUC_ProjectileBasicData>(Entity)?._SetRepActive(isActive);
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_BGUDataCompBase:PreECSBeginPlay")]
	protected override void PreECSBeginPlay_Implementation()
	{
		AActor owner = GetOwner();
		FreshNetRole(BGUFuncLibReplication.GetActorNetRole(owner));
		if (DataInitTemplate == null)
		{
			return;
		}
		foreach (ECSDataInitTemplate item in DataInitTemplate)
		{
			item.InitDataPreBeginPlay();
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_BGUDataCompBase:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
		GetOwner();
		if (DataInitTemplate != null)
		{
			foreach (ECSDataInitTemplate item in DataInitTemplate)
			{
				item.InitDataLateBeginPlay();
			}
		}
		LateBeginPlayFinish = true;
	}

	protected T CreateDataClass<T>() where T : class, new()
	{
		T val = new T();
		int typeIndex = TypeManager.GetTypeIndex<T>();
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, typeIndex, val);
		}
		return val;
	}

	protected T CreateDataObj<T>() where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		int typeIndex = TypeManager.GetTypeIndex<T>();
		AddDataObjInCS(val);
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, typeIndex, val);
		}
		return val;
	}

	protected T CreateDataWithCppAccess<T>() where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		int typeIndex = TypeManager.GetTypeIndex<T>();
		AddDataObjInCS(val);
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, typeIndex, val);
		}
		return val;
	}

	[USharpPath("/Script/b1-Managed.BUS_BGUDataCompBase:InitOnNewInCS")]
	protected sealed override void InitOnNewInCS_Implementation()
	{
		LateBeginPlayFinish = false;
		AActor owner = GetOwner();
		if (owner is IECSWorldObj iECSWorldObj)
		{
			ECSWorld = BGW_ECSWorld.Get(this);
			if (iECSWorldObj.ECSEntity != Entity.Null)
			{
				BGW_LogUtil.LogError($"Before CreateEntity EntityCon.ECSEntity != null EntitySharedRef MayDestroy {iECSWorldObj.ECSEntity}");
				ECSWorld.OnActorReUse(iECSWorldObj.ECSEntity);
			}
			Entity = ECSWorld.CreateEntity(iECSWorldObj.ECSArcheType);
			iECSWorldObj.ECSEntity = Entity;
			iECSWorldObj.ECSChunk = ECSWorld.GetEntityChunk(Entity);
			iECSWorldObj.ECSIndexInChunk = Entity.IndexInChunk;
			BUC_ActorBasicData bUC_ActorBasicData = new BUC_ActorBasicData();
			Entity = iECSWorldObj.ECSEntity;
			bUC_ActorBasicData.Entity = iECSWorldObj.ECSEntity;
			bUC_ActorBasicData.Actor = GetOwner();
			if (Entity.ArchIndex == 6)
			{
				bUC_ActorBasicData.ActorType = BGU_ActorType.CharacterAI;
			}
			else if (Entity.ArchIndex == 5)
			{
				bUC_ActorBasicData.ActorType = BGU_ActorType.CharacterPlayer;
			}
			else if (Entity.ArchIndex == 10)
			{
				bUC_ActorBasicData.ActorType = BGU_ActorType.CharacterEmptyPlayer;
			}
			ECSWorld.SetObject(bUC_ActorBasicData.Entity, bUC_ActorBasicData);
		}
		InitOnNewInCSImpl();
		DataInitTemplate = BGW_EffectTemplateList.Get(owner).AllocatECSDataInitTemplate(owner);
		if (DataInitTemplate == null)
		{
			return;
		}
		foreach (ECSDataInitTemplate item in DataInitTemplate)
		{
			item.InitDataOnNew();
		}
	}

	protected virtual void InitOnNewInCSImpl()
	{
	}

	[USharpPath("/Script/b1-Managed.BUS_BGUDataCompBase:OnDestoryInCS")]
	protected override void OnDestoryInCS_Implementation()
	{
		LateBeginPlayFinish = false;
		IECSWorldObj worldObj = GetOwner() as IECSWorldObj;
		if (ECSWorld != null)
		{
			ECSWorld.DestroyEntity(worldObj);
		}
		Entity = Entity.Null;
	}

	public bool IsActorHasBeginPlay()
	{
		return LateBeginPlayFinish;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_BGUDataCompBase:InitOnNewInCS")]
	private static void InitOnNewInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_BGUDataCompBase bUS_BGUDataCompBase = GCHelper.Find<BUS_BGUDataCompBase>(obj);
		bUS_BGUDataCompBase.InitOnNewInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_BGUDataCompBase:OnDestoryInCS")]
	private static void OnDestoryInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_BGUDataCompBase bUS_BGUDataCompBase = GCHelper.Find<BUS_BGUDataCompBase>(obj);
		bUS_BGUDataCompBase.OnDestoryInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_BGUDataCompBase:PreECSBeginPlay")]
	private static void PreECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_BGUDataCompBase bUS_BGUDataCompBase = GCHelper.Find<BUS_BGUDataCompBase>(obj);
		bUS_BGUDataCompBase.PreECSBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_BGUDataCompBase:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_BGUDataCompBase bUS_BGUDataCompBase = GCHelper.Find<BUS_BGUDataCompBase>(obj);
		bUS_BGUDataCompBase.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_BGUDataCompBase");
		InitOnNewInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitOnNewInCS");
		InitOnNewInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitOnNewInCS_FunctionAddress);
		InitOnNewInCS_IsValid = InitOnNewInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_BGUDataCompBase:InitOnNewInCS", InitOnNewInCS_IsValid);
		OnDestoryInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDestoryInCS");
		OnDestoryInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestoryInCS_FunctionAddress);
		OnDestoryInCS_IsValid = OnDestoryInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_BGUDataCompBase:OnDestoryInCS", OnDestoryInCS_IsValid);
		PreECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreECSBeginPlay");
		PreECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(PreECSBeginPlay_FunctionAddress);
		PreECSBeginPlay_IsValid = PreECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_BGUDataCompBase:PreECSBeginPlay", PreECSBeginPlay_IsValid);
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_BGUDataCompBase:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BUS_BGUDataCompBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_BGUDataCompBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_BGUDataCompBase));
	}
}
