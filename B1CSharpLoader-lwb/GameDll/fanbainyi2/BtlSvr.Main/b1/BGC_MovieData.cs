using System.Collections.Generic;
using b1.BGW;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_MovieData : IBGC_MovieData, IPersistentECSData
{
	private readonly TStrongObjectPtr<MovieInstance> _currentMovieInstance = new TStrongObjectPtr<MovieInstance>();

	private TStrongObjectPtr<UCurveFloat> _timeDilationCurve = new TStrongObjectPtr<UCurveFloat>();

	public bool bCanTick { get; set; }

	public int LockArchiveID { get; set; } = -1;

	public MovieInstance CameraMovieInstance
	{
		get
		{
			return _currentMovieInstance.Get();
		}
		set
		{
			_currentMovieInstance.Set(value);
		}
	}

	public Dictionary<FName, FGameplayTag> PerformerIds { get; } = new Dictionary<FName, FGameplayTag>();

	public MultiMap<FName, TWeakObject<AActor>> TagCameraMap { get; } = new MultiMap<FName, TWeakObject<AActor>>();

	public MultiMap<AActor, FName> RegisteredCameras { get; } = new MultiMap<AActor, FName>();

	public Dictionary<int, TStrongObjectPtr<MovieInstance>> MovieInstances { get; } = new Dictionary<int, TStrongObjectPtr<MovieInstance>>();

	public float TransBackTimeForPreviewMovie { get; set; } = -1f;

	public UCurveFloat TimeDilationCurve
	{
		get
		{
			return _timeDilationCurve.Get();
		}
		set
		{
			_timeDilationCurve.Set(value);
		}
	}

	public int CurrentDefeatExtendID { get; set; }

	public float CurrentDefeatSlowTime { get; set; }

	public float DefeatSlowTotalTime { get; set; }

	public bool bAllSeqCantSkip { get; set; }

	public bool bLastCameraMovieBlendOutCamera { get; set; }

	public bool IsMovieFastForwardSkiping(int MovieID)
	{
		if (MovieInstances.TryGetValue(MovieID, out var value))
		{
			return value.Get().FastForwardSkipStage != 0;
		}
		return false;
	}

	public bool IsLastMovieBlendOutCamera()
	{
		return bLastCameraMovieBlendOutCamera;
	}

	public bool IsPlaying()
	{
		return CameraMovieInstance != null;
	}

	public int GetSequenceId()
	{
		if (CameraMovieInstance != null)
		{
			return CameraMovieInstance.SequenceId;
		}
		return 0;
	}

	public bool IsCanSkip()
	{
		if (bAllSeqCantSkip)
		{
			return false;
		}
		if (CameraMovieInstance != null)
		{
			return CameraMovieInstance.CanSkipMovie();
		}
		return false;
	}

	public int GetPlayingMovieID(out List<int> OutPlayingMovieID)
	{
		OutPlayingMovieID = new List<int>();
		foreach (KeyValuePair<int, TStrongObjectPtr<MovieInstance>> movieInstance in MovieInstances)
		{
			int sequenceId = movieInstance.Value.Get().SequenceId;
			if (!OutPlayingMovieID.Contains(sequenceId))
			{
				OutPlayingMovieID.Add(sequenceId);
			}
		}
		return OutPlayingMovieID.Count;
	}

	public bool IsPlayingDefeatSlowTime()
	{
		return CurrentDefeatExtendID > 0;
	}

	public bool TryGetTaggedPerformerGuid(FName BindingTag, out string PerformerGuid)
	{
		PerformerGuid = "";
		if (PerformerIds.TryGetValue(BindingTag, out var value))
		{
			PerformerGuid = value.TagName.PlainName;
			return true;
		}
		return false;
	}

	public AActor GetCameraActor(UObject WorldContext)
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CameraActorForSeq);
		if (aActor == null)
		{
			aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/CameraSeq/BP_CameraActor_ForSeq.BP_CameraActor_ForSeq_C", ELoadResourceType.SyncLoadAndCache));
		}
		aActor.DetachFromActor();
		return aActor;
	}

	public AActor GetCinematicCameraActor(UObject WorldContext)
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CameraCinematicForSeq);
		if (aActor == null)
		{
			aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/CameraSeq/BP_CameraCinematic_ForSeq.BP_CameraCinematic_ForSeq_C", ELoadResourceType.SyncLoadAndCache));
		}
		aActor.DetachFromActor();
		return aActor;
	}

	public AActor GetCameraCraneActor(UObject WorldContext)
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CameraCraneForSeq);
		if (aActor == null)
		{
			aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>("/Game/00Main/Design/CameraSeq/BP_CameraCrane_ForSeq.BP_CameraCrane_ForSeq_C", ELoadResourceType.SyncLoadAndCache));
		}
		aActor.DetachFromActor();
		return aActor;
	}

	public AActor GetCameraRailActor(UObject WorldContext)
	{
		AActor aActor = UBGUFunctionLibrary.BGUFindFirstActorWithTag(WorldContext, B1GlobalFNames.CameraRailForSeq);
		if (aActor == null)
		{
			aActor = BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(UGSE_EngineFuncLib.GetWorldFromObj(WorldContext), (UClass)BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UObject>("/Game/00Main/Design/CameraSeq/BP_CameraRail_ForSeq.BP_CameraRail_ForSeq_C", ELoadResourceType.SyncLoadAndCache));
		}
		aActor.DetachFromActor();
		return aActor;
	}

	public BGUCameraActor GetCameraByTag(FName Tag)
	{
		ICameraObj cameraObjByTag = GetCameraObjByTag(Tag);
		if (cameraObjByTag != null && cameraObjByTag.CameraType == ECameraType.Normal)
		{
			return cameraObjByTag as BGUCameraActor;
		}
		return null;
	}

	public BGUCineCameraActor GetCineCameraByTag(FName Tag)
	{
		ICameraObj cameraObjByTag = GetCameraObjByTag(Tag);
		if (cameraObjByTag != null && cameraObjByTag.CameraType == ECameraType.Cine)
		{
			return cameraObjByTag as BGUCineCameraActor;
		}
		return null;
	}

	public BGUCameraRig_Rail GetRailByTag(FName Tag)
	{
		ICameraObj cameraObjByTag = GetCameraObjByTag(Tag);
		if (cameraObjByTag != null && cameraObjByTag.CameraType == ECameraType.Rail)
		{
			return cameraObjByTag as BGUCameraRig_Rail;
		}
		return null;
	}

	public BGUCameraRig_Crane GetCraneByTag(FName Tag)
	{
		ICameraObj cameraObjByTag = GetCameraObjByTag(Tag);
		if (cameraObjByTag != null && cameraObjByTag.CameraType == ECameraType.Crane)
		{
			return cameraObjByTag as BGUCameraRig_Crane;
		}
		return null;
	}

	public ICameraObj GetCameraObjByTag(FName Tag)
	{
		if (TagCameraMap.TryGetValue(Tag, out var value) && value.Count > 0)
		{
			TWeakObject<AActor> tWeakObject = value[0];
			if (tWeakObject.IsValid())
			{
				return tWeakObject.Get() as ICameraObj;
			}
		}
		return null;
	}
}
