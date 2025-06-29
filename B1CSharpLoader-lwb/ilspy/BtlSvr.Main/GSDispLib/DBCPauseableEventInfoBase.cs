using System;

namespace GSDispLib;

public abstract class DBCPauseableEventInfoBase : DBCInfoBase
{
	public int PausePriority;

	public bool IsPause { get; protected set; }

	public float PauseAtTime { get; protected set; }

	public int PauseRequestOperationCounter { get; protected set; }

	public bool ResolveChangePauseState(bool NewPauseState, string PauseReason, bool ForceResumeByPauseMode)
	{
		bool isPause = IsPause;
		if (ForceResumeByPauseMode)
		{
			PauseRequestOperationCounter = 0;
			PauseAtTime = 0f;
			IsPause = false;
			return isPause != IsPause;
		}
		if (!IsPause || !NewPauseState)
		{
			PauseAtTime = (NewPauseState ? GetCurTime() : 0f);
		}
		if (NewPauseState)
		{
			PauseRequestOperationCounter++;
			PauseRequestOperationCounter = Math.Max(0, PauseRequestOperationCounter);
			IsPause = true;
		}
		else
		{
			PauseRequestOperationCounter--;
			PauseRequestOperationCounter = Math.Max(0, PauseRequestOperationCounter);
			if (PauseRequestOperationCounter == 0)
			{
				IsPause = false;
			}
		}
		return isPause != IsPause;
	}
}
