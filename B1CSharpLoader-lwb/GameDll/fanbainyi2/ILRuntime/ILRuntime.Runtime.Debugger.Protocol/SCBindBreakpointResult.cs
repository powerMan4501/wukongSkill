namespace ILRuntime.Runtime.Debugger.Protocol;

public class SCBindBreakpointResult
{
	public int BreakpointHashCode { get; set; }

	public BindBreakpointResults Result { get; set; }
}
