using ILRuntime.Other;
using ILRuntime.Runtime.Stack;

namespace ILRuntime.Runtime.Intepreter;

internal struct RegisterFrameInfo
{
	public ILIntepreter Intepreter;

	public int FrameManagedBase;

	public int LocalManagedBase;

	public unsafe StackObject* StackBase;

	public unsafe StackObject* RegisterStart;

	public unsafe StackObject* StackRegisterStart;

	public unsafe StackObject* RegisterEnd;

	public UncheckedList<object> ManagedStack;
}
