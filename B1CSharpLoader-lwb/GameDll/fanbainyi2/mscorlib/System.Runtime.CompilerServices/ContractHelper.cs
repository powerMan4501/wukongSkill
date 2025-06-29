#define DEBUG
using System.Diagnostics;
using System.Diagnostics.Contracts;
using System.Runtime.ConstrainedExecution;
using System.Security;

namespace System.Runtime.CompilerServices;

[__DynamicallyInvokable]
public static class ContractHelper
{
	private static volatile EventHandler<ContractFailedEventArgs> contractFailedEvent;

	private static readonly object lockObject = new object();

	internal const int COR_E_CODECONTRACTFAILED = -2146233022;

	internal static event EventHandler<ContractFailedEventArgs> InternalContractFailed
	{
		[SecurityCritical]
		add
		{
			RuntimeHelpers.PrepareContractedDelegate(value);
			lock (lockObject)
			{
				contractFailedEvent = (EventHandler<ContractFailedEventArgs>)Delegate.Combine(contractFailedEvent, value);
			}
		}
		[SecurityCritical]
		remove
		{
			lock (lockObject)
			{
				contractFailedEvent = (EventHandler<ContractFailedEventArgs>)Delegate.Remove(contractFailedEvent, value);
			}
		}
	}

	[DebuggerNonUserCode]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	[__DynamicallyInvokable]
	public static string RaiseContractFailedEvent(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException)
	{
		string resultFailureMessage = "Contract failed";
		RaiseContractFailedEventImplementation(failureKind, userMessage, conditionText, innerException, ref resultFailureMessage);
		return resultFailureMessage;
	}

	[DebuggerNonUserCode]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	[__DynamicallyInvokable]
	public static void TriggerFailure(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException)
	{
		TriggerFailureImplementation(kind, displayMessage, userMessage, conditionText, innerException);
	}

	[DebuggerNonUserCode]
	[SecuritySafeCritical]
	private static void RaiseContractFailedEventImplementation(ContractFailureKind failureKind, string userMessage, string conditionText, Exception innerException, ref string resultFailureMessage)
	{
		if (failureKind < ContractFailureKind.Precondition || failureKind > ContractFailureKind.Assume)
		{
			throw new ArgumentException(Environment.GetResourceString("Arg_EnumIllegalVal", failureKind), "failureKind");
		}
		string text = "contract failed.";
		ContractFailedEventArgs e = null;
		RuntimeHelpers.PrepareConstrainedRegions();
		string text2;
		try
		{
			text = GetDisplayMessage(failureKind, userMessage, conditionText);
			EventHandler<ContractFailedEventArgs> eventHandler = contractFailedEvent;
			if (eventHandler != null)
			{
				e = new ContractFailedEventArgs(failureKind, text, conditionText, innerException);
				Delegate[] invocationList = eventHandler.GetInvocationList();
				for (int i = 0; i < invocationList.Length; i++)
				{
					EventHandler<ContractFailedEventArgs> eventHandler2 = (EventHandler<ContractFailedEventArgs>)invocationList[i];
					try
					{
						eventHandler2(null, e);
					}
					catch (Exception thrownDuringHandler)
					{
						e.thrownDuringHandler = thrownDuringHandler;
						e.SetUnwind();
					}
				}
				if (e.Unwind)
				{
					if (Environment.IsCLRHosted)
					{
						TriggerCodeContractEscalationPolicy(failureKind, text, conditionText, innerException);
					}
					if (innerException == null)
					{
						innerException = e.thrownDuringHandler;
					}
					throw new ContractException(failureKind, text, userMessage, conditionText, innerException);
				}
			}
		}
		finally
		{
			text2 = ((e == null || !e.Handled) ? text : null);
		}
		resultFailureMessage = text2;
	}

	[DebuggerNonUserCode]
	[SecuritySafeCritical]
	private static void TriggerFailureImplementation(ContractFailureKind kind, string displayMessage, string userMessage, string conditionText, Exception innerException)
	{
		if (Environment.IsCLRHosted)
		{
			TriggerCodeContractEscalationPolicy(kind, displayMessage, conditionText, innerException);
			throw new ContractException(kind, displayMessage, userMessage, conditionText, innerException);
		}
		if (!Environment.UserInteractive)
		{
			throw new ContractException(kind, displayMessage, userMessage, conditionText, innerException);
		}
		string resourceString = Environment.GetResourceString(GetResourceNameForFailure(kind));
		Assert.Fail(conditionText, displayMessage, resourceString, -2146233022, StackTrace.TraceFormat.Normal, 2);
	}

	private static string GetResourceNameForFailure(ContractFailureKind failureKind)
	{
		string text = null;
		switch (failureKind)
		{
		case ContractFailureKind.Assert:
			return "AssertionFailed";
		case ContractFailureKind.Assume:
			return "AssumptionFailed";
		case ContractFailureKind.Precondition:
			return "PreconditionFailed";
		case ContractFailureKind.Postcondition:
			return "PostconditionFailed";
		case ContractFailureKind.Invariant:
			return "InvariantFailed";
		case ContractFailureKind.PostconditionOnException:
			return "PostconditionOnExceptionFailed";
		default:
			Contract.Assume(condition: false, "Unreachable code");
			return "AssumptionFailed";
		}
	}

	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.MayFail)]
	private static string GetDisplayMessage(ContractFailureKind failureKind, string userMessage, string conditionText)
	{
		string resourceNameForFailure = GetResourceNameForFailure(failureKind);
		string resourceString;
		if (!string.IsNullOrEmpty(conditionText))
		{
			resourceNameForFailure += "_Cnd";
			resourceString = Environment.GetResourceString(resourceNameForFailure, conditionText);
		}
		else
		{
			resourceString = Environment.GetResourceString(resourceNameForFailure);
		}
		if (!string.IsNullOrEmpty(userMessage))
		{
			return resourceString + "  " + userMessage;
		}
		return resourceString;
	}

	[SecuritySafeCritical]
	[DebuggerNonUserCode]
	[ReliabilityContract(Consistency.WillNotCorruptState, Cer.Success)]
	private static void TriggerCodeContractEscalationPolicy(ContractFailureKind failureKind, string message, string conditionText, Exception innerException)
	{
		string exceptionAsString = null;
		if (innerException != null)
		{
			exceptionAsString = innerException.ToString();
		}
		Environment.TriggerCodeContractFailure(failureKind, message, conditionText, exceptionAsString);
	}
}
