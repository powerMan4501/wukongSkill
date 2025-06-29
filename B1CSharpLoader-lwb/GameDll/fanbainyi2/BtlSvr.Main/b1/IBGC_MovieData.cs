using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public interface IBGC_MovieData
{
	bool IsLastMovieBlendOutCamera();

	bool IsPlaying();

	int GetSequenceId();

	bool IsCanSkip();

	bool IsMovieFastForwardSkiping(int MovieID);

	int GetPlayingMovieID(out List<int> OutPlayingMovieID);

	bool IsPlayingDefeatSlowTime();

	AActor GetCameraActor(UObject WorldContext);

	AActor GetCinematicCameraActor(UObject WorldContext);

	AActor GetCameraCraneActor(UObject WorldContext);

	AActor GetCameraRailActor(UObject WorldContext);

	BGUCameraActor GetCameraByTag(FName Tag);

	BGUCineCameraActor GetCineCameraByTag(FName Tag);

	BGUCameraRig_Rail GetRailByTag(FName Tag);

	BGUCameraRig_Crane GetCraneByTag(FName Tag);

	ICameraObj GetCameraObjByTag(FName Tag);

	bool TryGetTaggedPerformerGuid(FName BindingTag, out string PerformerGuid);
}
