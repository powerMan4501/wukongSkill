using System;
using b1.BGW;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_ManipulateStreamingSource")]
public class MovieNodeInstance_ManipulateStreamingSource : MovieNodeInstance
{
	private MovieCustom_ActivateOrDeactivateStreamingSource CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_ActivateOrDeactivateStreamingSource();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		if (CustomData.IsEnable)
		{
			if (CustomData.TransformX.Count > 0)
			{
				UGSE_EngineFuncLib.GetFirstLocalPlayerController(this);
				BGW_LevelStreamingManger.Get(this)?.ResumeAllLevelDistanceStreaming();
				for (int i = 0; i < CustomData.TransformX.Count; i++)
				{
					FVector spawnLocation = new FVector(CustomData.TransformX[i], CustomData.TransformY[i], CustomData.TransformZ[i]);
					UBGUWCStreamingFuncLib.SpawnStreamingSource(this, spawnLocation);
				}
			}
		}
		else
		{
			UBGUWCStreamingFuncLib.DestroyGSWCWorldStreamingSources(this);
		}
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_ManipulateStreamingSource");
	}

	static MovieNodeInstance_ManipulateStreamingSource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_ManipulateStreamingSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_ManipulateStreamingSource));
	}
}
