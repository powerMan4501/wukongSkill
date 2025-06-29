using System;

namespace UnrealEngine.Runtime;

internal class ComparableYieldInstructions<T> : IComparableYieldInstructionCollection where T : YieldInstruction, IComparable<T>
{
	private static ComparableYieldInstructions<T> instance = new ComparableYieldInstructions<T>();

	private UnrealBinaryHeapEx<T> tick = new UnrealBinaryHeapEx<T>();

	private UnrealBinaryHeapEx<T> beginFrame = new UnrealBinaryHeapEx<T>();

	private UnrealBinaryHeapEx<T> endFrame = new UnrealBinaryHeapEx<T>();

	private ComparableYieldInstructions()
	{
		Coroutine.comparableCollections.Add(this);
	}

	public void Process(CoroutineGroup group)
	{
		UnrealBinaryHeapEx<T> collection = GetCollection(group);
		while (collection.Count > 0)
		{
			T val = collection.HeapTop();
			if (val.KeepWaiting)
			{
				break;
			}
			collection.HeapPopDiscard();
			val.comparableCollection = null;
			Coroutine.ComparableEnd(val.Owner);
		}
	}

	public void OnGroupChanged(YieldInstruction instruction, CoroutineGroup oldGroup, CoroutineGroup newGroup)
	{
		OnGroupChanged((T)instruction, oldGroup, newGroup);
	}

	private void OnGroupChanged(T instruction, CoroutineGroup oldGroup, CoroutineGroup newGroup)
	{
		UnrealBinaryHeapEx<T> collection = GetCollection(oldGroup);
		UnrealBinaryHeapEx<T> collection2 = GetCollection(newGroup);
		if (collection != null && collection2 != null && collection != collection2)
		{
			collection.HeapRemove(instruction);
			collection2.HeapPush(instruction);
		}
	}

	private bool AddInternal(T value)
	{
		GetCollection(value.Owner.Group).HeapPush(value);
		value.comparableCollection = this;
		return true;
	}

	private void RemoveInternal(T value)
	{
		GetCollection(value.Owner.Group).HeapRemove(value);
		value.comparableCollection = null;
	}

	private void ValueChangedInternal(T value)
	{
		UnrealBinaryHeapEx<T> collection = GetCollection(value.Owner.Group);
		collection.HeapRemove(value);
		collection.HeapPush(value);
	}

	public static bool Add(T value)
	{
		return instance.AddInternal(value);
	}

	public static void Remove(T value)
	{
		instance.RemoveInternal(value);
	}

	public static void ValueChanged(T value)
	{
		instance.ValueChangedInternal(value);
	}

	private UnrealBinaryHeapEx<T> GetCollection(CoroutineGroup group)
	{
		return group switch
		{
			CoroutineGroup.Tick => tick, 
			CoroutineGroup.BeginFrame => beginFrame, 
			CoroutineGroup.EndFrame => endFrame, 
			_ => null, 
		};
	}
}
