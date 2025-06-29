namespace ILRuntime.Runtime.Debugger.Protocol;

public class CSResolveVariable
{
	public int ThreadHashCode { get; set; }

	public int FrameIndex { get; set; }

	public VariableReference Variable { get; set; }
}
