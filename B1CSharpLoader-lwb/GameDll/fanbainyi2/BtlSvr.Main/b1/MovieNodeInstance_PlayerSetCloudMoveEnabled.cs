using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayerSetCloudMoveEnabled")]
public class MovieNodeInstance_PlayerSetCloudMoveEnabled : MovieNodeInstance
{
	private MovieCustom_PlayerSetCloudMoveEnabled CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PlayerSetCloudMoveEnabled();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		foreach (BGUCharacterCS allPlayerActor in BGU_UnrealWorldUtil.GetAllPlayerActors(this))
		{
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(allPlayerActor);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_SetCloudMoveEnabledSafety.Invoke(CustomData.IsEnabled);
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PlayerSetCloudMoveEnabled");
	}

	static MovieNodeInstance_PlayerSetCloudMoveEnabled()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PlayerSetCloudMoveEnabled)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PlayerSetCloudMoveEnabled));
	}
}
