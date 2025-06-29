using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security.Principal;
using System.Threading;

namespace System.Security;

internal struct SecurityContextSwitcher : IDisposable
{
	internal SecurityContext.Reader prevSC;

	internal SecurityContext currSC;

	internal ExecutionContext currEC;

	internal CompressedStackSwitcher cssw;

	internal WindowsImpersonationContext wic;

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
	[HandleProcessCorruptedStateExceptions]
	public void Undo()
	{
		if (currSC == null)
		{
			return;
		}
		if (currEC != null)
		{
			currEC.SecurityContext = prevSC.DangerousGetRawSecurityContext();
		}
		currSC = null;
		bool flag = true;
		try
		{
			if (wic != null)
			{
				flag &= wic.UndoNoThrow();
			}
		}
		catch
		{
			flag &= cssw.UndoNoThrow();
			Environment.FailFast(Environment.GetResourceString("ExecutionContext_UndoFailed"));
		}
		if (!(flag & cssw.UndoNoThrow()))
		{
			Environment.FailFast(Environment.GetResourceString("ExecutionContext_UndoFailed"));
		}
	}
}
