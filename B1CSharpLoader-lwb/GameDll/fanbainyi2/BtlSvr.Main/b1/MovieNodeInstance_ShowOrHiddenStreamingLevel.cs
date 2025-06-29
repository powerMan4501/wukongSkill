using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_ShowOrHiddenStreamingLevel")]
public class MovieNodeInstance_ShowOrHiddenStreamingLevel : MovieNodeInstance
{
	private MovieCustom_ShowOrHiddenStreamingLevel CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_ShowOrHiddenStreamingLevel();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.SetStreamingLevelsVisibility(CustomData.StreamingLevelName, CustomData.IsVisible);
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_ShowOrHiddenStreamingLevel");
	}

	static MovieNodeInstance_ShowOrHiddenStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_ShowOrHiddenStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_ShowOrHiddenStreamingLevel));
	}
}
