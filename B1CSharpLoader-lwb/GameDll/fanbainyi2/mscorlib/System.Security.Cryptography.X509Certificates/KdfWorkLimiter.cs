namespace System.Security.Cryptography.X509Certificates;

internal static class KdfWorkLimiter
{
	private sealed class State
	{
		internal ulong RemainingAllowedWork;

		internal bool WorkLimitWasExceeded;
	}

	[ThreadStatic]
	private static State t_State;

	internal static void SetIterationLimit(ulong workLimit)
	{
		State state = new State();
		state.RemainingAllowedWork = workLimit;
		t_State = state;
	}

	internal static bool WasWorkLimitExceeded()
	{
		return t_State.WorkLimitWasExceeded;
	}

	internal static void ResetIterationLimit()
	{
		t_State = null;
	}

	internal static void RecordIterations(int workCount)
	{
		RecordIterations((long)workCount);
	}

	internal static void RecordIterations(long workCount)
	{
		State state = t_State;
		bool flag = false;
		checked
		{
			try
			{
				if (!state.WorkLimitWasExceeded)
				{
					state.RemainingAllowedWork -= (ulong)workCount;
					flag = true;
				}
			}
			finally
			{
				if (!flag)
				{
					state.RemainingAllowedWork = 0uL;
					state.WorkLimitWasExceeded = true;
					throw new CryptographicException();
				}
			}
		}
	}
}
