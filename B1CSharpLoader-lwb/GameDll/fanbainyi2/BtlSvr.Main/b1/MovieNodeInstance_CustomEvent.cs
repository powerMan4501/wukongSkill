using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_CustomEvent")]
public class MovieNodeInstance_CustomEvent : MovieNodeInstance
{
	private MovieCustom_CustomEvent CustomData { get; set; }

	public string EventName { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_CustomEvent();
		CustomData.MergeFrom(base.Node.NodeData);
		EventName = CustomData.EventName;
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_CustomEvent");
	}

	static MovieNodeInstance_CustomEvent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_CustomEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_CustomEvent));
	}
}
