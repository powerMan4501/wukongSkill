namespace ILRuntime.Runtime.Debugger.Protocol;

public class CSBindBreakpoint
{
	public int BreakpointHashCode { get; set; }

	public bool IsLambda { get; set; }

	public string NamespaceName { get; set; }

	public string TypeName { get; set; }

	public string MethodName { get; set; }

	public int StartLine { get; set; }

	public int EndLine { get; set; }

	public bool Enabled { get; set; }

	public BreakpointCondition Condition { get; set; }

	public UsingInfo[] UsingInfos { get; set; }
}
