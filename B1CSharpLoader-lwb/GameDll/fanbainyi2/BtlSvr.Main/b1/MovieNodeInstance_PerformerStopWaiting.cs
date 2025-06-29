using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PerformerStopWaiting")]
public class MovieNodeInstance_PerformerStopWaiting : MovieNodeInstance
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
		BGW_EventCollection.Get(this)?.Evt_SendSceneObjEvent(CustomData.PerformerGuid, BGW_FlowUtils.PerformerTag.Event_AfterShowing);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PerformerStopWaiting");
	}

	static MovieNodeInstance_PerformerStopWaiting()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PerformerStopWaiting)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PerformerStopWaiting));
	}
}
