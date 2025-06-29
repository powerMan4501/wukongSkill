namespace UnrealEngine.Runtime;

public abstract class YieldInstruction : BinaryHeapItem
{
	internal uint poolId;

	internal bool keepAlive;

	internal IYieldInstructionPool pool;

	internal IComparableYieldInstructionCollection comparableCollection;

	private Coroutine owner;

	internal bool running;

	public bool IsPooled => poolId != 0;

	internal bool IsInsideComparableCollection => comparableCollection != null;

	internal virtual bool IsComparable => false;

	public Coroutine Owner
	{
		get
		{
			return owner;
		}
		set
		{
			bool num = owner != value;
			owner = value;
			if (num && value != null)
			{
				OnOwnerSet();
			}
		}
	}

	public abstract bool KeepWaiting { get; }

	internal virtual bool AddToComparableCollection()
	{
		return false;
	}

	internal virtual void RemoveFromComparableCollection()
	{
	}

	internal void Begin()
	{
		running = true;
		OnBegin();
		if (IsComparable && Owner.CurrentInstruction == this && KeepWaiting && AddToComparableCollection())
		{
			Coroutine.ComparableBegin(Owner);
		}
	}

	internal void End()
	{
		OnEnd();
		if (IsInsideComparableCollection)
		{
			RemoveFromComparableCollection();
			Coroutine.ComparableEnd(Owner);
		}
		running = false;
	}

	public virtual void OnBegin()
	{
	}

	public virtual void OnEnd()
	{
	}

	public virtual void OnOwnerSet()
	{
	}
}
