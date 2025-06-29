using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerExitPhasePerformance")]
internal class MovieNodeInstance_PerformerExitPhasePerformance : MovieNodeInstance
{
	private MovieCustom_PerformerExitPhasePerformance CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PerformerExitPhasePerformance();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		if (BGU_DataUtil.GetActorByGuid(this, CustomData.PerformerGuid) is BGUCharacterCS actor)
		{
			BUS_EventCollectionCS.Get(actor).Evt_EnterOrExitPhasePerformance.Invoke(P1: false, "CMG 退出表演状态");
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerExitPhasePerformance");
	}

	static MovieNodeInstance_PerformerExitPhasePerformance()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.MovieNodeInstance_PerformerExitPhasePerformance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.MovieNodeInstance_PerformerExitPhasePerformance));
	}
}
