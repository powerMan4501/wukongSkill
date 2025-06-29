using System;
using System.Collections.Generic;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUCollectionActorCS")]
public class BGUCollectionActorCS : BGUCollectionBase
{
	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
	}

	protected T CreateData<T>(BGW_ECSWorld ECSWorld) where T : UObject
	{
		T val = UObject.NewObject<T>(this);
		ECSWorld.SetObject(base.ECSEntity, val);
		return val;
	}

	protected override UMeshComponent GetMeshByCollectionType()
	{
		List<UActorComponent> componentsByClass = GetComponentsByClass(UClass.GetClass<UStaticMeshComponent>());
		string text = "StaticMeshNormal";
		IBIC_CollectionGroupData gameInstanceReadonlyData = BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_CollectionGroupData, BIC_CollectionGroupData>(this);
		string actorGuid = BGU_DataUtil.GetActorGuid(this, bFindFromComponent: true);
		switch (gameInstanceReadonlyData.CheckCollectionQuality(actorGuid))
		{
		case ECollectionQualityType.Normal:
			text = "StaticMeshNormal";
			break;
		case ECollectionQualityType.Plus:
			text = "StaticMeshPlus";
			break;
		case ECollectionQualityType.Chief:
			text = "StaticMeshChief";
			break;
		}
		foreach (UStaticMeshComponent item in componentsByClass)
		{
			if (item.GetFName().ToString() == text)
			{
				return item;
			}
		}
		return GetComponentByClass<UMeshComponent>();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUCollectionActorCS");
	}

	static BGUCollectionActorCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUCollectionActorCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUCollectionActorCS));
	}
}
