using ILRuntime.CLR.Method;

namespace ILRuntime.Runtime.Stack;

internal struct StackFrame
{
	public ILMethod Method;

	public unsafe StackObject* LocalVarPointer;

	public unsafe StackObject* BasePointer;

	public unsafe StackObject* ValueTypeBasePointer;

	public IntegerReference Address;

	public int ManagedStackBase;

	public bool IsRegister;
}
