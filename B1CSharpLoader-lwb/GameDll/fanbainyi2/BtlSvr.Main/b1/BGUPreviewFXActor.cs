using System;
using GSDispLib;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUPreviewFXActor")]
public class BGUPreviewFXActor : BGUActorBaseCS
{
	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_ActorBaseDataComp>(this, B1GlobalFNames.DataComp);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		BGW_ECSWorld bGW_ECSWorld = BGW_ECSWorld.Get(this);
		bGW_ECSWorld?.SetObject(base.ECSEntity, new BUS_DispLibEventCollection());
		UPrimitiveComponent componentByClass = GetComponentByClass<USkeletalMeshComponent>();
		if (componentByClass == null)
		{
			componentByClass = GetComponentByClass<UStaticMeshComponent>();
		}
		BUC_DispLibUnitRendererBaseData bUC_DispLibUnitRendererBaseData = CreateDataClass<BUC_DispLibUnitRendererBaseData>(bGW_ECSWorld);
		bUC_DispLibUnitRendererBaseData.Init(300f, 0, componentByClass);
		CreateDataClass<BUC_DispLibSetUnitMaterialsParamsRequestsQueueData>(bGW_ECSWorld).Init(bUC_DispLibUnitRendererBaseData);
		base.ActorCompContainerCS.AddComp(new BUS_DispLibUnitMaterialsManageComp());
		CreateDataClass<BUC_DispLibDBCBaseData>(bGW_ECSWorld).Init(componentByClass, DispLibDBCActorGroup.EquipPreview);
		CreateDataClass<BUC_DispLibDBCQueueData>(bGW_ECSWorld).Init();
		base.ActorCompContainerCS.AddComp(new BUS_DispLibDBCManageComp());
	}

	protected T CreateDataClass<T>(BGW_ECSWorld ECSWorld) where T : class, new()
	{
		T val = new T();
		ECSWorld?.SetObject(base.ECSEntity, val);
		return val;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUPreviewFXActor");
	}

	static BGUPreviewFXActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUPreviewFXActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUPreviewFXActor));
	}
}
