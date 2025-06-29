using System;
using ILRuntime.Runtime.Debugger.Protocol;

namespace ILRuntime.Runtime.Debugger;

public class BreakpointConditionDetails : BreakpointCondition
{
	public bool ExpressionError { get; set; }

	public Exception Exception { get; set; }
}
