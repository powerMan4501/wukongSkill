namespace ILRuntime.Runtime.Stack;

public unsafe delegate void StackObjectAllocateCallback(int size, out StackObject* ptr, out int managedIdx);
