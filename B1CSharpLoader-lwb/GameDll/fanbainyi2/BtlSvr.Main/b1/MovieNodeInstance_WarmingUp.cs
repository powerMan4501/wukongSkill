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
[USharpPath("/Script/b1-Managed.MovieNodeInstance_WarmingUp")]
public class MovieNodeInstance_WarmingUp : MovieNodeInstance
{
	private int SequenceCount { get; set; }

	private TStrongObjectPtr<ULevelSequence>[] StartSequences { get; set; }

	public FTransform[] StartCameraTransform { get; set; }

	private string[] CameraTags { get; set; }

	private string[] RailTags { get; set; }

	private string[] CraneTags { get; set; }

	private bool bUseMarkFrameLoop { get; set; }

	private bool bUseBlockLoad { get; set; }

	private List<string> StreamingLevelNames { get; } = new List<string>();

	private List<string> NeedPerformers { get; } = new List<string>();

	private int AssociationConfigId { get; set; }

	private EAssociationUnitSpawnType AssociationSpawnType { get; set; }

	private MovieCustom_WarmingUpV1 CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_WarmingUpV1();
		switch (base.Node.CustomDataVersion)
		{
		case 0u:
		{
			MovieCustom_WarmingUp movieCustom_WarmingUp = new MovieCustom_WarmingUp();
			movieCustom_WarmingUp.MergeFrom(base.Node.NodeData);
			CustomData.StartSequences.AddRange(movieCustom_WarmingUp.StartSequences);
			CustomData.IsUseCinematicCamera = movieCustom_WarmingUp.IsUseCinematicCamera;
			CustomData.IsUseMarkFrameLoop = movieCustom_WarmingUp.IsUseMarkFrameLoop;
			CustomData.CameraBlendInTime = movieCustom_WarmingUp.CameraBlendInTime;
			CustomData.CameraBlendInFunc = (byte)movieCustom_WarmingUp.CameraBlendInFunc;
			CustomData.CameraBlendInExp = movieCustom_WarmingUp.CameraBlendInExp;
			CustomData.IsUseBlockLoad = movieCustom_WarmingUp.IsUseBlockLoad;
			CustomData.StreamingLevelNameList.AddRange(movieCustom_WarmingUp.StreamingLevelNameList);
			CustomData.Performers.AddRange(movieCustom_WarmingUp.Performers);
			CustomData.AssociationConfigId = 0;
			CustomData.AssociationSpawnType = 0;
			break;
		}
		case 1u:
			CustomData.MergeFrom(base.Node.NodeData);
			break;
		}
		SequenceCount = CustomData.StartSequences.Count;
		if (SequenceCount > 0)
		{
			StartSequences = new TStrongObjectPtr<ULevelSequence>[SequenceCount];
			StartCameraTransform = new FTransform[SequenceCount];
			CameraTags = new string[SequenceCount];
			RailTags = new string[SequenceCount];
			CraneTags = new string[SequenceCount];
		}
		for (int i = 0; i < CustomData.StartSequences.Count; i++)
		{
			CalliopeCustom_LevelSequenceConfig calliopeCustom_LevelSequenceConfig = CustomData.StartSequences[i];
			ULevelSequence uLevelSequence = BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(calliopeCustom_LevelSequenceConfig.SequencePath, ELoadResourceType.AsyncLoadAndCache);
			if (uLevelSequence != null)
			{
				StartSequences[i] = new TStrongObjectPtr<ULevelSequence>(uLevelSequence);
			}
			StartCameraTransform[i] = CalliopeExtension.ToFTransform(calliopeCustom_LevelSequenceConfig.CameraStartTransform);
			CameraTags[i] = calliopeCustom_LevelSequenceConfig.CameraTag;
			RailTags[i] = calliopeCustom_LevelSequenceConfig.RailTag;
			CraneTags[i] = calliopeCustom_LevelSequenceConfig.CraneTag;
		}
		bUseMarkFrameLoop = CustomData.IsUseMarkFrameLoop;
		foreach (string streamingLevelName in CustomData.StreamingLevelNameList)
		{
			StreamingLevelNames.Add(streamingLevelName);
		}
		foreach (string performer in CustomData.Performers)
		{
			NeedPerformers.Add(performer);
		}
		bUseBlockLoad = CustomData.IsUseBlockLoad;
		AssociationConfigId = CustomData.AssociationConfigId;
		AssociationSpawnType = (EAssociationUnitSpawnType)CustomData.AssociationSpawnType;
	}

	public override void TriggerInput(string InputPin)
	{
		base.TriggerInput(InputPin);
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Combine(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		MovieInstance.FWarmingUpPlaySettings fWarmingUpPlaySettings = new MovieInstance.FWarmingUpPlaySettings();
		FMovieSequencePlaySettings playSettings = new FMovieSequencePlaySettings
		{
			bUseCinematicCamera = CustomData.IsUseCinematicCamera,
			bUseRail = false,
			bUseCrane = false,
			StartTimeSeconds = 0f,
			InCameraBlendTime = CustomData.CameraBlendInTime,
			InCameraBlendFunction = (EViewTargetBlendFunction)CustomData.CameraBlendInFunc,
			InCameraBlendFactor = CustomData.CameraBlendInExp,
			bLoopPlay = false,
			Sequences = new List<ULevelSequence>()
		};
		if (StartSequences != null)
		{
			for (int i = 0; i < StartSequences.Length; i++)
			{
				if (StartSequences[i] == null)
				{
					StartSequences[i] = new TStrongObjectPtr<ULevelSequence>(BGW_PreloadAssetMgr.Get(this).TryGetCachedResourceObj<ULevelSequence>(CustomData.StartSequences[i].SequencePath, ELoadResourceType.SyncLoadAndCache));
				}
				playSettings.Sequences.Add(StartSequences[i].Get());
			}
			playSettings.CameraTransforms = StartCameraTransform.ToList();
			playSettings.CameraTags = CameraTags.ToList();
			playSettings.RailTags = RailTags.ToList();
			playSettings.CraneTags = CraneTags.ToList();
		}
		fWarmingUpPlaySettings.PlaySettings = playSettings;
		fWarmingUpPlaySettings.NeedPerformers.AddRange(NeedPerformers);
		fWarmingUpPlaySettings.StreamingLevelNames.AddRange(StreamingLevelNames);
		fWarmingUpPlaySettings.bBlockLoad = bUseBlockLoad;
		fWarmingUpPlaySettings.bUseMarkFrameLoop = bUseMarkFrameLoop;
		fWarmingUpPlaySettings.AssociationSpawnType = AssociationSpawnType;
		fWarmingUpPlaySettings.AssociationConfigId = AssociationConfigId;
		base.ParentInstance.PlayWarmingUpSequence(fWarmingUpPlaySettings);
	}

	private void OnSequenceFinished()
	{
		TriggerFirstOutput();
	}

	protected override void Finish()
	{
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Remove(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
		base.Finish();
	}

	public override void Shutdown()
	{
		base.Shutdown();
		MovieInstance parentInstance = base.ParentInstance;
		parentInstance.InternalSequenceFinishedCallBack = (Action)Delegate.Remove(parentInstance.InternalSequenceFinishedCallBack, new Action(OnSequenceFinished));
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

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_WarmingUp");
	}

	static MovieNodeInstance_WarmingUp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_WarmingUp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_WarmingUp));
	}
}
