namespace ILRuntime.Runtime.Stack;

internal struct MemoryBlockInfo
{
	public unsafe StackObject* RequestAddress;

	public unsafe StackObject* StartAddress;

	public int Size;

	public int ManagedIndex;

	public int ManagedCount;
}
