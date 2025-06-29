using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerCatchTarget")]
public class MovieNodeInstance_PerformerCatchTarget : MovieNodeInstance
{
	private MovieCustom_PerformerCatchTarget CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerCatchTarget();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		BGUCharacterCS bGUCharacterCS = BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			LogError("未找到Guid为" + CustomData.PerformerGuid + "的演员");
		}
		else
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(bGUCharacterCS);
			if (bUS_GSEventCollection != null)
			{
				AActor nearestPlayerActor = BGU_UnrealWorldUtil.GetNearestPlayerActor(bGUCharacterCS);
				bUS_GSEventCollection.Evt_AICatchTarget.Invoke(nearestPlayerActor, ETargetSourceType.Target_CMGAssignTarget);
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerCatchTarget");
	}

	static MovieNodeInstance_PerformerCatchTarget()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerCatchTarget)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerCatchTarget));
	}
}
