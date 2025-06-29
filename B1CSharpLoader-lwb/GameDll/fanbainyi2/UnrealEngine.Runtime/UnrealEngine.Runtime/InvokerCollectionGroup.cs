namespace UnrealEngine.Runtime;

internal class InvokerCollectionGroup
{
	private UnrealBinaryHeapEx<Invoker> delayInvokers = new UnrealBinaryHeapEx<Invoker>();

	private UnrealBinaryHeapEx<Invoker> ticksInvokers = new UnrealBinaryHeapEx<Invoker>();

	private UnrealBinaryHeapEx<Invoker> framesInvokers = new UnrealBinaryHeapEx<Invoker>();

	public CoroutineGroup Group { get; private set; }

	public InvokerCollectionGroup(CoroutineGroup group)
	{
		Group = group;
	}

	public UnrealBinaryHeapEx<Invoker> GetCollection(InvokerType type)
	{
		return type switch
		{
			InvokerType.Delay => delayInvokers, 
			InvokerType.Ticks => ticksInvokers, 
			InvokerType.Frames => framesInvokers, 
			_ => null, 
		};
	}

	public void Process()
	{
		if (delayInvokers.Count > 0)
		{
			ProcessTime(delayInvokers);
		}
		if (ticksInvokers.Count > 0)
		{
			Process(ticksInvokers, EngineLoop.WorldTickCounter);
		}
		if (framesInvokers.Count > 0)
		{
			Process(framesInvokers, EngineLoop.WorldFrameNumber);
		}
	}

	private void Process(UnrealBinaryHeapEx<Invoker> invokers, ulong value)
	{
		while (invokers.Count > 0)
		{
			Invoker invoker = invokers.HeapTop();
			if (invoker.EndValue <= value)
			{
				invokers.HeapPopDiscard();
				invoker.Process(value);
				continue;
			}
			break;
		}
	}

	private void ProcessTime(UnrealBinaryHeapEx<Invoker> invokers)
	{
		while (invokers.Count > 0)
		{
			Invoker invoker = invokers.HeapTop();
			ulong ticks = (ulong)WorldTimeHelper.GetTimeChecked(invoker.OwnerWorld).Ticks;
			if (invoker.EndValue <= ticks)
			{
				invokers.HeapPopDiscard();
				invoker.Process(ticks);
				continue;
			}
			break;
		}
	}
}
