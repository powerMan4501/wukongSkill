using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGU_DispLibDBCCarrierActorDataComp")]
public class BGU_DispLibDBCCarrierActorDataComp : BUS_ActorBaseDataComp
{
	private BUC_DispLibDBCBaseData DispLibDBCBaseData;

	private BUC_DispLibDBCQueueData DispLibDBCQueueData;

	private BUC_DispLibDBCCarrierActorBaseData CarrierActrorBaseData;

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		DispLibDBCBaseData = CreateDataClass<BUC_DispLibDBCBaseData>();
		DispLibDBCQueueData = CreateDataClass<BUC_DispLibDBCQueueData>();
		CarrierActrorBaseData = CreateDataClass<BUC_DispLibDBCCarrierActorBaseData>();
	}

	internal void Reset()
	{
		DispLibDBCBaseData.Reset();
		DispLibDBCQueueData.Reset();
		CarrierActrorBaseData.Reset();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGU_DispLibDBCCarrierActorDataComp");
	}

	static BGU_DispLibDBCCarrierActorDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_DispLibDBCCarrierActorDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_DispLibDBCCarrierActorDataComp));
	}
}
