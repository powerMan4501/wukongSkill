using GUR.Runtime;

namespace b1;

[InstanceFactory]
public abstract class FSummonProcessorBase
{
	[FactoryKey]
	public abstract ESummonProcessorTag Tag { get; }

	protected virtual bool RunProcessor(FSummonInstance InSummonInstance)
	{
		return true;
	}

	protected virtual ESummonProcessorTag GetNext(FSummonInstance InSummonInstance)
	{
		return ESummonProcessorTag.Exception;
	}

	protected void RunNext(FSummonInstance InSummonInstance)
	{
		NotifyRun(GetNext(InSummonInstance), InSummonInstance);
	}

	private static void NotifyRun(ESummonProcessorTag Tag, FSummonInstance InSummonInstance)
	{
		if (InSummonInstance != null)
		{
			FSummonProcessorBase instance = FSummonProcessorFactory.GetInstance(Tag);
			if (instance.RunProcessor(InSummonInstance))
			{
				instance.RunNext(InSummonInstance);
			}
		}
	}

	public static void DoSummon(FSummonInstance InSummonInstance)
	{
		NotifyRun(ESummonProcessorTag.Start, InSummonInstance);
	}
}
