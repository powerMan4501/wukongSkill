using GUR.Runtime;
using UnrealEngine.Engine;

namespace b1;

[TypeFactory]
public abstract class FBehaviorNodeInstanceBase
{
	public BUS_BehaviorGraphComp.FBehaviorInstance ParentInstance { get; set; }

	public FCalliopeNode Node { get; set; }

	public abstract bool bLeftNode { get; }

	[FactoryKey]
	public abstract string NodeName { get; }

	public AActor Owner { get; set; }

	public BUS_GSEventCollection BUSEventCollection { get; set; }

	public BGS_GSEventCollection BGSEventCollection { get; set; }

	public BGW_EventCollection BGWEventCollection { get; set; }

	public void NotifyPostCreate()
	{
		PostCreate();
	}

	protected virtual void PostCreate()
	{
	}
}
