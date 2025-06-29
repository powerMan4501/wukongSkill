using System;
using System.Collections.Generic;
using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGW_MovieManager")]
public class BGW_MovieManager : GameInstanceSystemBaseUObj
{
	private BIC_MovieData MovieData { get; set; }

	private BGW_GameArchiveMgr GameArchivedMgr { get; set; }

	public override void OnAttach()
	{
		MovieData = RequireWritableGameInstanceData<BIC_MovieData>();
		BGW_EventCollection bGW_EventCollection = BGW_EventCollection.Get(this);
		if (bGW_EventCollection != null)
		{
			bGW_EventCollection.Evt_ResetGameInstanceData = (BGW_EventCollection.Del_BGW_ResetGameInstanceData)Delegate.Combine(bGW_EventCollection.Evt_ResetGameInstanceData, new BGW_EventCollection.Del_BGW_ResetGameInstanceData(OnReSetGameData));
			bGW_EventCollection.Evt_RecoverMovieArchiveData = (Del_Void_IntList)Delegate.Combine(bGW_EventCollection.Evt_RecoverMovieArchiveData, new Del_Void_IntList(OnRecoverMovieArchiveData));
			bGW_EventCollection.Evt_PauseAllMovie = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_PauseAllMovie, new Del_Void(OnPauseAllMovie));
			bGW_EventCollection.Evt_ResumeAllMovie = (Del_Void)Delegate.Combine(bGW_EventCollection.Evt_ResumeAllMovie, new Del_Void(OnResumeAllMovie));
			bGW_EventCollection.Evt_MarkMoviePlayed = (Del_Void_Int)Delegate.Combine(bGW_EventCollection.Evt_MarkMoviePlayed, new Del_Void_Int(OnMarkSequencePlayed));
			bGW_EventCollection.Evt_StorePlayerPerformerEquipConfig = (BGW_EventCollection.Del_StorePlayerPerformerEquipConfig)Delegate.Combine(bGW_EventCollection.Evt_StorePlayerPerformerEquipConfig, new BGW_EventCollection.Del_StorePlayerPerformerEquipConfig(StorePlayerPerformerEquipConfig));
			bGW_EventCollection.Evt_RequestPlayMovie = (Del_PlayMovieRequest)Delegate.Combine(bGW_EventCollection.Evt_RequestPlayMovie, new Del_PlayMovieRequest(RequestPlayMovie));
		}
	}

	private void StorePlayerPerformerEquipConfig(FEquipMeshConfig MeshConfig, FEquipAbpConfig AbpConfig)
	{
		MovieData.EquipMeshConfig = MeshConfig;
		MovieData.EquipAbpConfig = AbpConfig;
		BGUPerformerActorCS[] allActorsOfClass = UGameplayStatics.GetAllActorsOfClass<BGUPerformerActorCS>(base.Owner);
		for (int i = 0; i < allActorsOfClass.Length; i++)
		{
			allActorsOfClass[i].ApplyEquipConfig();
		}
	}

	public override void OnAfterInit()
	{
		GameArchivedMgr = BGW_GameArchiveMgr.Get(this);
	}

	private void OnRecoverMovieArchiveData(List<int> PlayedSequenceList)
	{
		MovieData.PlayedSequenceList.Clear();
		foreach (int PlayedSequence in PlayedSequenceList)
		{
			MovieData.PlayedSequenceList.Add(PlayedSequence);
		}
	}

	private void OnMarkSequencePlayed(int SequenceId)
	{
		GameArchivedMgr?.MarkDelaySaveArchive(EArchiveDelaySaveSource.NeverPlaySequenceListAdd);
		MovieData.PlayedSequenceList.Add(SequenceId);
	}

	private void OnReSetGameData(EGameInstanceResetType ResetType)
	{
		MovieData.PlayedSequenceList.Clear();
	}

	private void OnResumeAllMovie()
	{
		MovieData.bPauseAllMovie = false;
		BGS_EventCollectionCS.Get(base.Owner)?.Evt_ResumeCurrentMovie.Invoke();
	}

	private void OnPauseAllMovie()
	{
		MovieData.bPauseAllMovie = true;
		BGS_EventCollectionCS.Get(base.Owner)?.Evt_PauseCurrentMovie.Invoke();
	}

	private void RequestPlayMovie(FPlayMovieRequest InRequest)
	{
		MovieData.PlayMovieRequestQueue.Enqueue(InRequest);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGW_MovieManager");
	}

	static BGW_MovieManager()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_MovieManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_MovieManager));
	}
}
