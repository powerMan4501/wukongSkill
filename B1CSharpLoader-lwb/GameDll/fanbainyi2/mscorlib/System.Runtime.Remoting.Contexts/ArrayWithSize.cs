namespace System.Runtime.Remoting.Contexts;

internal class ArrayWithSize
{
	internal IDynamicMessageSink[] Sinks;

	internal int Count;

	internal ArrayWithSize(IDynamicMessageSink[] sinks, int count)
	{
		Sinks = sinks;
		Count = count;
	}
}
