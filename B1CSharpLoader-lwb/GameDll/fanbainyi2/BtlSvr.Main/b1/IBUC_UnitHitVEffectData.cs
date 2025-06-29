namespace b1;

public interface IBUC_UnitHitVEffectData
{
	bool CheckIsInFreezeFrameGap(float CurTimeInSeconds);

	bool CanTriggerSlowIK();
}
