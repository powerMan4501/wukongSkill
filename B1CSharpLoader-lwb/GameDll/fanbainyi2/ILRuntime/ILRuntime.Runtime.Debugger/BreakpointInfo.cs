using ILRuntime.Runtime.Debugger.Protocol;
using ILRuntime.Runtime.Intepreter;

namespace ILRuntime.Runtime.Debugger;

internal class BreakpointInfo
{
	public int BreakpointHashCode { get; set; }

	public int MethodHashCode { get; set; }

	public int StartLine { get; set; }

	public bool Enabled { get; set; }

	public BreakpointConditionDetails Condition { get; set; }

	public UsingInfo[] UsingInfos { get; set; }

	public bool CheckCondition(DebugService debugService, ILIntepreter intp, ref StackFrameInfo[] stackFrameInfos, ref string error)
	{
		return true;
	}
}
