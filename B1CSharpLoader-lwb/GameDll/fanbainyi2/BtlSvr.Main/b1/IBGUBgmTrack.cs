using b1.ECS;

namespace b1;

public interface IBGUBgmTrack
{
	void TryPlayBGM(BGMWrap NewBGMWrap);

	void TryStopBGM(Entity RequestorEntity, EBGMStopCondition StopCondition = EBGMStopCondition.Default);

	void PauseBGM(EBGMStopCondition StopCondition = EBGMStopCondition.Default);

	void ResumeBGM();

	void Tick(float DeltaTime);

	void OnShutdown();

	void SetIsCanTick(bool NewIsCanTick);

	void OnReset(EResetActorReason ResetReason);
}
