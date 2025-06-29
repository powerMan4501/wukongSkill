using System;
using UnrealEngine.LevelSequence;
using UnrealEngine.MovieScene;
using UnrealEngine.Runtime;

namespace b1;

public static class BGUFuncLibSequenceCS
{
	public static void PlayFromStart(this ALevelSequenceActor SeqActor)
	{
		if (SeqActor != null && !(SeqActor.GetSequence() == null) && SeqActor.GetSequencePlayer() != null)
		{
			FMovieSceneSequencePlaybackParams playbackPosition = new FMovieSceneSequencePlaybackParams
			{
				Time = 0f
			};
			SeqActor.GetSequencePlayer().SetPlaybackPosition(playbackPosition);
		}
	}

	public static void SetAllSequencePaused(UObject WorldContext, bool bPaused)
	{
		if (bPaused)
		{
			BGW_EventCollection.Get(WorldContext)?.Evt_PauseAllMovie();
		}
		else
		{
			BGW_EventCollection.Get(WorldContext)?.Evt_ResumeAllMovie();
		}
	}

	public static bool GetPreviewSeqInfo(UObject WorldCtx, int SeqId, out int LevelId, out FVector PreviewPosition, out FRotator PreviewRotation, out Action OnleportFinish, Action OnSeqFinish)
	{
		LevelId = 4;
		PreviewPosition = new FVector(9.760186, 1954.653442, 96.873878);
		PreviewRotation = FRotator.ZeroRotator;
		OnleportFinish = delegate
		{
		};
		if (MovieInstance.GetMoviePreviewLocation(WorldCtx, SeqId, out LevelId, out PreviewPosition, out PreviewRotation))
		{
			BGW_EventCollection.Get(WorldCtx).Evt_ClearAllGameData();
			OnleportFinish = delegate
			{
				BGW_EventCollection.Get(WorldCtx).Evt_TriggerResetAllActors(EResetActorReason.InteractRebirthPoint);
				BGS_EventCollectionCS.Get(WorldCtx).Evt_PreviewMovie.Invoke(SeqId, OnSeqFinish);
			};
			return true;
		}
		return false;
	}
}
