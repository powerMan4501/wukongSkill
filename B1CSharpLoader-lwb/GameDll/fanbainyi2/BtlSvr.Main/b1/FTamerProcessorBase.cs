using GUR.Runtime;

namespace b1;

[InstanceFactory]
public abstract class FTamerProcessorBase
{
	[FactoryKey]
	public abstract EProcessorSequence ProcessorSequence { get; }

	private FTamerProcessorBase NextProcessor { get; set; }

	protected bool bStopCurrentProcessChain { get; set; }

	public void Initial()
	{
		FTamerProcessorBase instance = FTamerProcessorFactory.GetInstance(ProcessorSequence + 1);
		if (instance != null)
		{
			SetNext(instance);
			instance.Initial();
		}
		PostInitial();
	}

	public void NotifyProcess(ref FTamerProcessorContext InContext)
	{
		Process(ref InContext);
		if (bStopCurrentProcessChain)
		{
			bStopCurrentProcessChain = false;
		}
		else if (!InContext.CanBreakProcessChain() && NextProcessor != null)
		{
			NextProcessor.NotifyProcess(ref InContext);
		}
	}

	protected virtual void PostInitial()
	{
	}

	protected virtual void Process(ref FTamerProcessorContext InContext)
	{
	}

	private void SetNext(FTamerProcessorBase InNextProcessor)
	{
		NextProcessor = InNextProcessor;
	}
}
