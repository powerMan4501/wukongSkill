using System.Collections.Generic;

namespace b1;

public static class FMovieStateFactory
{
	public static Dictionary<EMoviePlayState, MovieInstance.MovieStateBase> InstanceMapping { get; }

	static FMovieStateFactory()
	{
		InstanceMapping = new Dictionary<EMoviePlayState, MovieInstance.MovieStateBase>();
		InstanceMapping[EMoviePlayState.Idle] = new MovieInstance.MovieState_Idle();
		InstanceMapping[EMoviePlayState.PoseTurnBack] = new MovieInstance.MovieState_PoseTurnBack();
		InstanceMapping[EMoviePlayState.Matching2PointA] = new MovieInstance.MovieState_MatchingA();
		InstanceMapping[EMoviePlayState.Orientating2PointA] = new MovieInstance.MovieState_Orientating2A();
		InstanceMapping[EMoviePlayState.OriPointAStop] = new MovieInstance.MovieState_PointAStop();
		InstanceMapping[EMoviePlayState.ExceptionProcess] = new MovieInstance.MovieState_ExceptionProcess();
		InstanceMapping[EMoviePlayState.PrePlayProcess] = new MovieInstance.MovieState_PrePlayProcess();
		InstanceMapping[EMoviePlayState.PreRoll] = new MovieInstance.MovieState_PreRoll();
		InstanceMapping[EMoviePlayState.WarmingUpPlaying] = new MovieInstance.MovieState_WarmingUpPlaying();
		InstanceMapping[EMoviePlayState.PlayingProcess] = new MovieInstance.MovieState_PlayingProcess();
		InstanceMapping[EMoviePlayState.StartSequencePlaying] = new MovieInstance.MovieState_StartSequencePlaying();
		InstanceMapping[EMoviePlayState.CutSequencePlaying] = new MovieInstance.MovieState_CutSequencePlaying();
		InstanceMapping[EMoviePlayState.PreRollSequencePlaying] = new MovieInstance.MovieState_PreRollSequencePlaying();
		InstanceMapping[EMoviePlayState.Paused] = new MovieInstance.MovieState_Paused();
		InstanceMapping[EMoviePlayState.Skipping] = new MovieInstance.MovieState_Skipping();
		InstanceMapping[EMoviePlayState.Stopping] = new MovieInstance.MovieState_Stopping();
		InstanceMapping[EMoviePlayState.PostPlayProcess] = new MovieInstance.MovieState_PostPlayProcess();
		InstanceMapping[EMoviePlayState.Finished] = new MovieInstance.MovieState_Finished();
	}

	public static MovieInstance.MovieStateBase GetInstance(EMoviePlayState InInstanceKey)
	{
		if (InstanceMapping.TryGetValue(InInstanceKey, out var value))
		{
			return value;
		}
		return null;
	}

	public static int GetAllInstances(out IReadOnlyDictionary<EMoviePlayState, MovieInstance.MovieStateBase> OutAllInstances)
	{
		OutAllInstances = InstanceMapping;
		return OutAllInstances.Count;
	}
}
