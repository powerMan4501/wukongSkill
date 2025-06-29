using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security;

namespace System.Threading;

internal struct CompressedStackSwitcher : IDisposable
{
	internal CompressedStack curr_CS;

	internal CompressedStack prev_CS;

	internal IntPtr prev_ADStack;

	public override bool Equals(object obj)
	{
		if (obj == null || !(obj is CompressedStackSwitcher compressedStackSwitcher))
		{
			return false;
		}
		if (curr_CS == compressedStackSwitcher.curr_CS && prev_CS == compressedStackSwitcher.prev_CS)
		{
			return prev_ADStack == compressedStackSwitcher.prev_ADStack;
		}
		return false;
	}

	public override int GetHashCode()
	{
		return ToString().GetHashCode();
	}

	public static bool operator ==(CompressedStackSwitcher c1, CompressedStackSwitcher c2)
	{
		return c1.Equals(c2);
	}

	public static bool operator !=(CompressedStackSwitcher c1, CompressedStackSwitcher c2)
	{
		return !c1.Equals(c2);
	}

	[SecuritySafeCritical]
	public void Dispose()
	{
		Undo();
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[HandleProcessCorruptedStateExceptions]
	internal bool UndoNoThrow()
	{
		try
		{
			Undo();
		}
		catch (Exception exception)
		{
			if (!AppContextSwitches.UseLegacyExecutionContextBehaviorUponUndoFailure)
			{
				Environment.FailFast(Environment.GetResourceString("ExecutionContext_UndoFailed"), exception);
			}
			return false;
		}
		return true;
	}

	[SecurityCritical]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	public void Undo()
	{
		if (curr_CS != null || prev_CS != null)
		{
			if (prev_ADStack != (IntPtr)0)
			{
				CompressedStack.RestoreAppDomainStack(prev_ADStack);
			}
			CompressedStack.SetCompressedStackThread(prev_CS);
			prev_CS = null;
			curr_CS = null;
			prev_ADStack = (IntPtr)0;
		}
	}
}
