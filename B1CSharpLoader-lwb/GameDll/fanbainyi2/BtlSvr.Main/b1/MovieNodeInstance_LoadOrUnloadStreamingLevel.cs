using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_LoadOrUnloadStreamingLevel")]
public class MovieNodeInstance_LoadOrUnloadStreamingLevel : MovieNodeInstance
{
	private MovieCustom_LoadOrUnloadStreamingLevel CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_LoadOrUnloadStreamingLevel();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		if (CustomData.IsLoadOrUnload)
		{
			base.ParentInstance.RequestLoadLevel(CustomData.StreamingLevelName, bMakeVisibleAfterLoaded: false, bShouldBlockOnLoad: false, CustomData.FinishLoadEvent);
		}
		else
		{
			base.ParentInstance.UnloadStreamingLevel(CustomData.StreamingLevelName);
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_LoadOrUnloadStreamingLevel");
	}

	static MovieNodeInstance_LoadOrUnloadStreamingLevel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_LoadOrUnloadStreamingLevel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_LoadOrUnloadStreamingLevel));
	}
}
