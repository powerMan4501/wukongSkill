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
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Cut")]
public class MovieNodeInstance_Cut : MovieNodeInstance
{
	private TStrongObjectPtr<ULevelSequence> CutSequencePtr { get; } = new TStrongObjectPtr<ULevelSequence>();

	private List<string> CameraTag { get; } = new List<string>();

	private List<string> RailTag { get; } = new List<string>();

	private List<string> CraneTag { get; } = new List<string>();

	private bool bUseCinematicCamera { get; set; }

	private bool bUseRail { get; set; }

	private bool bUseCrane { get; set; }

	private float InCameraBlendTime { get; set; }

	private EViewTargetBlendFunction InCameraBlendFunction { get; set; }

	private float InCameraBlendFactor { get; set; }

	private bool bLoopPlay { get; set; }

	private MovieCustom_Cut CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_Cut();
		CustomData.MergeFrom(base.Node.NodeData);
		ULevelSequence uLevelSequence = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(CustomData.CutSequencePath, ELoadResourceType.AsyncLoadAndCache);
		if (uLevelSequence != null)
		{
			CutSequencePtr.Set(uLevelSequence);
		}
		CameraTag.Add(CustomData.CameraTag);
		RailTag.Add(CustomData.RailTag);
		CraneTag.Add(CustomData.CraneTag);
		bUseCinematicCamera = CustomData.IsUseCinematicCamera;
		bUseRail = CustomData.IsUseRail;
		bUseCrane = CustomData.IsUseCrane;
		InCameraBlendTime = CustomData.CameraBlendTime;
		InCameraBlendFunction = (EViewTargetBlendFunction)CustomData.CameraBlendFunc;
		InCameraBlendFactor = CustomData.CameraBlendExp;
		bLoopPlay = CustomData.IsLoopPlay;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Combine(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		FMovieSequencePlaySettings inMoviePlaySettings = new FMovieSequencePlaySettings
		{
			CameraTags = CameraTag,
			RailTags = RailTag,
			CraneTags = CraneTag,
			bUseCinematicCamera = bUseCinematicCamera,
			bUseRail = bUseRail,
			bUseCrane = bUseCrane,
			InCameraBlendTime = InCameraBlendTime,
			InCameraBlendFunction = InCameraBlendFunction,
			InCameraBlendFactor = InCameraBlendFactor,
			bLoopPlay = bLoopPlay
		};
		inMoviePlaySettings.Sequences = new List<ULevelSequence>();
		if (!CutSequencePtr.IsValid())
		{
			CutSequencePtr.Set(BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(CustomData.CutSequencePath, ELoadResourceType.SyncLoadAndCache));
		}
		if (CutSequencePtr.IsValid())
		{
			inMoviePlaySettings.Sequences.Add(CutSequencePtr.Get());
		}
		base.ParentInstance.PlaySequenceCut(inMoviePlaySettings);
	}

	public override void Shutdown()
	{
		base.Shutdown();
		if (CustomData != null)
		{
			BGW_PreloadAssetMgr.Get(this)?.TryRecyclingCachedResourceObj(CustomData.CutSequencePath);
		}
		CutSequencePtr.Set(null);
	}

	private void OnSequenceFinished()
	{
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Remove(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Cut");
	}

	static MovieNodeInstance_Cut()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Cut)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Cut));
	}
}
