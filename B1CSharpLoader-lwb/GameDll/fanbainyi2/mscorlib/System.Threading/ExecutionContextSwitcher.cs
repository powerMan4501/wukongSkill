using System.Runtime.ConstrainedExecution;
using System.Runtime.ExceptionServices;
using System.Security;
using System.Security.Principal;

namespace System.Threading;

internal struct ExecutionContextSwitcher
{
	internal ExecutionContext.Reader outerEC;

	internal bool outerECBelongsToScope;

	internal SecurityContextSwitcher scsw;

	internal object hecsw;

	internal WindowsIdentity wi;

	internal bool cachedAlwaysFlowImpersonationPolicy;

	internal bool wiIsValid;

	internal Thread thread;

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
	internal void Undo()
	{
		if (this.thread != null)
		{
			Thread thread = this.thread;
			if (hecsw != null)
			{
				HostExecutionContextSwitcher.Undo(hecsw);
			}
			ExecutionContext.Reader executionContextReader = thread.GetExecutionContextReader();
			thread.SetExecutionContext(outerEC, outerECBelongsToScope);
			if (scsw.currSC != null)
			{
				scsw.Undo();
			}
			if (wiIsValid)
			{
				SecurityContext.RestoreCurrentWI(outerEC, executionContextReader, wi, cachedAlwaysFlowImpersonationPolicy);
			}
			this.thread = null;
			ExecutionContext.OnAsyncLocalContextChanged(executionContextReader.DangerousGetRawExecutionContext(), outerEC.DangerousGetRawExecutionContext());
		}
	}
}
