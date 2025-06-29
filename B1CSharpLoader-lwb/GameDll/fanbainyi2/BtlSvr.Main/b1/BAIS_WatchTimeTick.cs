using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIS_WatchTimeTick")]
internal class BAIS_WatchTimeTick : BAIS_Base
{
	public override void ReceiveTick(AActor OwnerActor, float DeltaSeconds)
	{
		if (!(OwnerActor is BGUCharacterCS ownerActor))
		{
			return;
		}
		BUC_AIData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<BUC_AIData>(OwnerActor);
		if (unPersistentReadOnlyData != null)
		{
			float watchTime = unPersistentReadOnlyData.GetWatchTime();
			if (watchTime >= 0f)
			{
				AIFuncLibForCS.PrintDebugMessage(ownerActor, "[BAIS_WatchTimeTick]", "观察时间还剩下 : " + watchTime);
				BUS_EventCollectionCS.Get(OwnerActor)?.Evt_SetWatchTime.Invoke(watchTime - DeltaSeconds);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BAIS_WatchTimeTick");
	}

	static BAIS_WatchTimeTick()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIS_WatchTimeTick)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIS_WatchTimeTick));
	}
}
