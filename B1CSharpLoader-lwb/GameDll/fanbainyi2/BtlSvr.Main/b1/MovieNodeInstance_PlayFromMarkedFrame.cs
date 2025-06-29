using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PlayFromMarkedFrame")]
public class MovieNodeInstance_PlayFromMarkedFrame : MovieNodeInstance
{
	private MovieCustom_PlayFromMarkedFrame CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PlayFromMarkedFrame();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.SkipToMarkedFrame(CustomData.MarkedFrameLabel);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PlayFromMarkedFrame");
	}

	static MovieNodeInstance_PlayFromMarkedFrame()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PlayFromMarkedFrame)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PlayFromMarkedFrame));
	}
}
