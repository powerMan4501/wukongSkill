using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.DispLibDispWorldDataComp")]
public class DispLibDispWorldDataComp : BUS_ActorBaseDataComp
{
	private BUC_DispLibDBCBaseData DispLibDBCBaseData;

	private BWC_DispLibCameraData DispLibCameraData;

	private BWC_DispLibDispWorldGlobalData DispLibDispWorldGlobalData;

	private BUC_DispLibDBCQueueData DispLibDBCQueueData;

	private BWC_DispLibDispWorldDBCQueueData DLDWorld_DispLibQueue;

	protected override void InitOnNewInCSImpl()
	{
		base.InitOnNewInCSImpl();
		DispLibCameraData = CreateDataClass<BWC_DispLibCameraData>();
		DispLibDispWorldGlobalData = CreateDataClass<BWC_DispLibDispWorldGlobalData>();
		DispLibDBCBaseData = CreateDataClass<BUC_DispLibDBCBaseData>();
		DLDWorld_DispLibQueue = CreateDataClass<BWC_DispLibDispWorldDBCQueueData>();
		DispLibDBCQueueData = CreateDataClass<BUC_DispLibDBCQueueData>();
	}

	internal void Reset()
	{
		DispLibCameraData.Reset();
		DispLibDispWorldGlobalData.Reset();
		DispLibDBCBaseData.Reset();
		DLDWorld_DispLibQueue.Reset();
		DispLibDBCQueueData.Reset();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLibDispWorldDataComp");
	}

	static DispLibDispWorldDataComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLibDispWorldDataComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLibDispWorldDataComp));
	}
}
