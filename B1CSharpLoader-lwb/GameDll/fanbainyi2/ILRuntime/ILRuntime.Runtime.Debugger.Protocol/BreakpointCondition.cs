namespace ILRuntime.Runtime.Debugger.Protocol;

public class BreakpointCondition
{
	public BreakpointConditionStyle Style { get; set; }

	public string Expression { get; set; }
}
