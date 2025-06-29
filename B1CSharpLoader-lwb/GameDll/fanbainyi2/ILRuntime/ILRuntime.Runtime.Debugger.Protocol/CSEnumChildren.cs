namespace ILRuntime.Runtime.Debugger.Protocol;

public class CSEnumChildren
{
	public int ThreadHashCode { get; set; }

	public int FrameIndex { get; set; }

	public VariableReference Parent { get; set; }
}
