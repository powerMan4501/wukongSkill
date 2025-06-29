using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_SetStreamingLevelStateInfo")]
public class MovieNodeInstance_SetStreamingLevelStateInfo : MovieNodeInstance
{
	private MovieCustom_SetStreamingLevelStateInfo CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_SetStreamingLevelStateInfo();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		if (!B1Global.GIsBossRushMode)
		{
			foreach (CalliopeCustom_RequestLevelStateInfo item in CustomData.LevelStateRequestInfo)
			{
				base.ParentInstance.RequestSetLevelStateInfo(item.LevelId, item.ConfigId);
			}
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_SetStreamingLevelStateInfo");
	}

	static MovieNodeInstance_SetStreamingLevelStateInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_SetStreamingLevelStateInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_SetStreamingLevelStateInfo));
	}
}
