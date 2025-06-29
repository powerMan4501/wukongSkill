using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_GiveBackControlRight")]
public class MovieNodeInstance_GiveBackControlRight : MovieNodeInstance
{
	private MovieCustom_GiveBackControlRight CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_GiveBackControlRight();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		BGS_EventCollectionCS.Get(this)?.Evt_ConvertToNoCameraMovie.Invoke(base.ParentInstance);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_GiveBackControlRight");
	}

	static MovieNodeInstance_GiveBackControlRight()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_GiveBackControlRight)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_GiveBackControlRight));
	}
}
