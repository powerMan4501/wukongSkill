using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Engine;
using UnrealEngine.LevelSequence;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_Start")]
public class MovieNodeInstance_Start : MovieNodeInstance
{
	private int SequenceCount { get; set; }

	private TStrongObjectPtr<ULevelSequence>[] StartSequences { get; set; }

	public FTransform[] StartCameraTransform { get; set; }

	private string[] CameraTags { get; set; }

	private string[] RailTags { get; set; }

	private string[] CraneTags { get; set; }

	private MovieCustom_Start CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_Start();
		CustomData.MergeFrom(base.Node.NodeData);
		SequenceCount = CustomData.StartSequences.Count;
		if (SequenceCount > 0)
		{
			StartSequences = new TStrongObjectPtr<ULevelSequence>[SequenceCount];
			StartCameraTransform = new FTransform[SequenceCount];
			CameraTags = new string[SequenceCount];
			RailTags = new string[SequenceCount];
			CraneTags = new string[SequenceCount];
		}
		BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
		for (int i = 0; i < CustomData.StartSequences.Count; i++)
		{
			CalliopeCustom_LevelSequenceConfig calliopeCustom_LevelSequenceConfig = CustomData.StartSequences[i];
			ULevelSequence uLevelSequence = bGW_PreloadAssetMgr.TryGetCachedResourceObj<ULevelSequence>(calliopeCustom_LevelSequenceConfig.SequencePath, ELoadResourceType.AsyncLoadAndCache);
			if (uLevelSequence != null)
			{
				StartSequences[i] = new TStrongObjectPtr<ULevelSequence>(uLevelSequence);
			}
			StartCameraTransform[i] = CalliopeExtension.ToFTransform(calliopeCustom_LevelSequenceConfig.CameraStartTransform);
			CameraTags[i] = calliopeCustom_LevelSequenceConfig.CameraTag;
			RailTags[i] = calliopeCustom_LevelSequenceConfig.RailTag;
			CraneTags[i] = calliopeCustom_LevelSequenceConfig.CraneTag;
		}
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		if (StartSequences.Length != 0)
		{
			MovieInstance parentInstance = base.ParentInstance;
			parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Combine(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
			FMovieSequencePlaySettings inSequencePlaySettings = new FMovieSequencePlaySettings
			{
				CameraTransforms = StartCameraTransform.ToList(),
				CameraTags = CameraTags.ToList(),
				RailTags = RailTags.ToList(),
				CraneTags = CraneTags.ToList(),
				bUseCinematicCamera = CustomData.IsUseCinematicCamera,
				bUseRail = CustomData.IsUseRail,
				bUseCrane = CustomData.IsUseCrane,
				StartTimeSeconds = CustomData.StartTimeSeconds,
				InCameraBlendTime = CustomData.CameraBlendInTime,
				InCameraBlendFunction = (EViewTargetBlendFunction)CustomData.CameraBlendInFunc,
				InCameraBlendFactor = CustomData.CameraBlendInExp,
				bLoopPlay = CustomData.IsLoopPlay,
				Sequences = new List<ULevelSequence>()
			};
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
			for (int i = 0; i < StartSequences.Length; i++)
			{
				if (StartSequences[i] == null)
				{
					StartSequences[i] = new TStrongObjectPtr<ULevelSequence>(bGW_PreloadAssetMgr.TryGetCachedResourceObj<ULevelSequence>(CustomData.StartSequences[i].SequencePath, ELoadResourceType.SyncLoadAndCache));
				}
				inSequencePlaySettings.Sequences.Add(StartSequences[i].Get());
			}
			base.ParentInstance.PlayStartSequence(inSequencePlaySettings);
		}
		else
		{
			TriggerFirstOutput();
		}
	}

	public override void Shutdown()
	{
		base.Shutdown();
		if (CustomData != null)
		{
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
			if (bGW_PreloadAssetMgr != null && CustomData.StartSequences != null)
			{
				foreach (CalliopeCustom_LevelSequenceConfig startSequence in CustomData.StartSequences)
				{
					bGW_PreloadAssetMgr.TryRecyclingCachedResourceObj(startSequence.SequencePath);
				}
			}
		}
		if (StartSequences != null)
		{
			TStrongObjectPtr<ULevelSequence>[] startSequences = StartSequences;
			for (int i = 0; i < startSequences.Length; i++)
			{
				startSequences[i]?.SetNull();
			}
		}
		StartSequences = null;
	}

	private void OnSequenceFinished()
	{
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Remove(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		TriggerFirstOutput();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_Start");
	}

	static MovieNodeInstance_Start()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_Start)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_Start));
	}
}
