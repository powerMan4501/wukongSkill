using System;
using System.Collections.Generic;
using b1.BGW;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_PreRoll")]
public class MovieNodeInstance_PreRoll : MovieNodeInstance
{
	private TStrongObjectPtr<ULevelSequence> PreRollSequencePtr { get; } = new TStrongObjectPtr<ULevelSequence>();

	private List<string> CameraTag { get; } = new List<string>();

	private List<string> RailTag { get; } = new List<string>();

	private List<string> CraneTag { get; } = new List<string>();

	private bool bUseCinematicCamera { get; set; }

	private float InCameraBlendTime { get; set; }

	private EViewTargetBlendFunction InCameraBlendFunction { get; set; }

	private float InCameraBlendFactor { get; set; }

	private MovieCustom_PreRoll CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_PreRoll();
		CustomData.MergeFrom(base.Node.NodeData);
		ULevelSequence uLevelSequence = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(CustomData.PreRollSequencePath, ELoadResourceType.AsyncLoadAndCache);
		if (uLevelSequence != null)
		{
			PreRollSequencePtr.Set(uLevelSequence);
		}
		CameraTag.Add(CustomData.CameraTag);
		RailTag.Add(FName.None.ToString());
		CraneTag.Add(FName.None.ToString());
		bUseCinematicCamera = CustomData.IsUseCinematicCamera;
		InCameraBlendTime = CustomData.CameraBlendTime;
		InCameraBlendFunction = (EViewTargetBlendFunction)CustomData.CameraBlendFunc;
		InCameraBlendFactor = CustomData.CameraBlendExp;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		base.ParentInstance.bStopPreRollWhenBlendFinish = CustomData.IsStopPreRollWhenFinish;
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Combine(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		FMovieSequencePlaySettings inMoviePlaySettings = new FMovieSequencePlaySettings
		{
			CameraTags = CameraTag,
			RailTags = RailTag,
			CraneTags = CraneTag,
			bUseCinematicCamera = bUseCinematicCamera,
			bUseRail = false,
			bUseCrane = false,
			InCameraBlendTime = InCameraBlendTime,
			InCameraBlendFunction = InCameraBlendFunction,
			InCameraBlendFactor = InCameraBlendFactor,
			bLoopPlay = false
		};
		inMoviePlaySettings.Sequences = new List<ULevelSequence>();
		if (!PreRollSequencePtr.IsValid())
		{
			PreRollSequencePtr.Set(BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(CustomData.PreRollSequencePath, ELoadResourceType.SyncLoadAndCache));
		}
		if (PreRollSequencePtr.IsValid())
		{
			inMoviePlaySettings.Sequences.Add(PreRollSequencePtr.Get());
		}
		base.ParentInstance.PlayPreRollSequence(inMoviePlaySettings);
	}

	public override void Shutdown()
	{
		base.Shutdown();
		if (CustomData != null)
		{
			BGW_PreloadAssetMgr.Get(this)?.TryRecyclingCachedResourceObj(CustomData.PreRollSequencePath);
		}
		PreRollSequencePtr.Set(null);
	}

	private void OnSequenceFinished()
	{
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Remove(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_PreRoll");
	}

	static MovieNodeInstance_PreRoll()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_PreRoll)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_PreRoll));
	}
}
