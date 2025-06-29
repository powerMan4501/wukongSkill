using System;
using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActorBaseDataComp")]
public class BUS_ActorBaseDataComp : UActorDataContainer
{
	protected AActor Owner;

	protected Entity Entity;

	protected BGW_ECSWorld ECSWorld;

	protected BUC_ActorBasicData BasicData;

	protected bool LateBeginPlayFinish;

	private List<ECSDataInitTemplate> DataInitTemplate;

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

	[USharpPath("/Script/b1-Managed.BUS_ActorBaseDataComp:PreECSBeginPlay")]
	protected override void PreECSBeginPlay_Implementation()
	{
		BUS_RepStateInitHelper.InitNetRole(Entity, BGUFuncLibReplication.GetActorNetRole(GetOwner()));
		Owner = BGUGetOwner();
		_ = Owner;
		if (DataInitTemplate == null)
		{
			return;
		}
		foreach (ECSDataInitTemplate item in DataInitTemplate)
		{
			item.InitDataPreBeginPlay();
		}
	}

	[USharpPath("/Script/b1-Managed.BUS_ActorBaseDataComp:LateECSBeginPlay")]
	protected override void LateECSBeginPlay_Implementation()
	{
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
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, val);
		}
		return val;
	}

	protected T CreateData<T>() where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		AddDataObjInCS(val);
		if (ECSWorld != null)
		{
			ECSWorld.SetObject(Entity, val);
		}
		return val;
	}

	[USharpPath("/Script/b1-Managed.BUS_ActorBaseDataComp:InitOnNewInCS")]
	protected sealed override void InitOnNewInCS_Implementation()
	{
		LateBeginPlayFinish = false;
		AActor aActor = BGUGetOwner();
		if (aActor is IECSWorldObj iECSWorldObj)
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
			bUC_ActorBasicData.Entity = iECSWorldObj.ECSEntity;
			bUC_ActorBasicData.Actor = BGUGetOwner();
			bUC_ActorBasicData.ActorType = BGU_ActorType.GameMode;
			Entity = iECSWorldObj.ECSEntity;
			ECSWorld.SetObject(bUC_ActorBasicData.Entity, bUC_ActorBasicData);
		}
		Entity ent = ECSUtil.ToEntity(this);
		if (ECSWorld != null)
		{
			BasicData = ECSWorld.GetObject<BUC_ActorBasicData>(ent);
		}
		CreateDataClass<BUC_GuidData>();
		CreateDataClass<BUC_ActorInitData>();
		CreateDataClass<BUC_ActorTransformInfoData>();
		if (DebugConfig.DebugWidget)
		{
			CreateDataClass<BUC_DebugInfoData>();
		}
		InitOnNewInCSImpl();
		DataInitTemplate = BGW_EffectTemplateList.Get(aActor).AllocatECSDataInitTemplate(aActor);
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

	[USharpPath("/Script/b1-Managed.BUS_ActorBaseDataComp:OnDestoryInCS")]
	protected override void OnDestoryInCS_Implementation()
	{
		LateBeginPlayFinish = false;
		IECSWorldObj worldObj = BGUGetOwner() as IECSWorldObj;
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

	protected AActor BGUGetOwner()
	{
		if (Owner != null)
		{
			return Owner;
		}
		Owner = GetOwner();
		return Owner;
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ActorBaseDataComp:InitOnNewInCS")]
	private static void InitOnNewInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ActorBaseDataComp bUS_ActorBaseDataComp = GCHelper.Find<BUS_ActorBaseDataComp>(obj);
		bUS_ActorBaseDataComp.InitOnNewInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ActorBaseDataComp:OnDestoryInCS")]
	private static void OnDestoryInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ActorBaseDataComp bUS_ActorBaseDataComp = GCHelper.Find<BUS_ActorBaseDataComp>(obj);
		bUS_ActorBaseDataComp.OnDestoryInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ActorBaseDataComp:PreECSBeginPlay")]
	private static void PreECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ActorBaseDataComp bUS_ActorBaseDataComp = GCHelper.Find<BUS_ActorBaseDataComp>(obj);
		bUS_ActorBaseDataComp.PreECSBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_ActorBaseDataComp:LateECSBeginPlay")]
	private static void LateECSBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_ActorBaseDataComp bUS_ActorBaseDataComp = GCHelper.Find<BUS_ActorBaseDataComp>(obj);
		bUS_ActorBaseDataComp.LateECSBeginPlay_Implementation();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActorBaseDataComp");
		InitOnNewInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "InitOnNewInCS");
		InitOnNewInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(InitOnNewInCS_FunctionAddress);
		InitOnNewInCS_IsValid = InitOnNewInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ActorBaseDataComp:InitOnNewInCS", InitOnNewInCS_IsValid);
		OnDestoryInCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "OnDestoryInCS");
		OnDestoryInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(OnDestoryInCS_FunctionAddress);
		OnDestoryInCS_IsValid = OnDestoryInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ActorBaseDataComp:OnDestoryInCS", OnDestoryInCS_IsValid);
		PreECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "PreECSBeginPlay");
		PreECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(PreECSBeginPlay_FunctionAddress);
		PreECSBeginPlay_IsValid = PreECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ActorBaseDataComp:PreECSBeginPlay", PreECSBeginPlay_IsValid);
		LateECSBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "LateECSBeginPlay");
		LateECSBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(LateECSBeginPlay_FunctionAddress);
		LateECSBeginPlay_IsValid = LateECSBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_ActorBaseDataComp:LateECSBeginPlay", LateECSBeginPlay_IsValid);
	}

	static BUS_ActorBaseDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ActorBaseDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ActorBaseDataComp));
	}
}
