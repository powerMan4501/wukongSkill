using System;

namespace UnrealEngine.Runtime;

public abstract class ComparableYieldInstruction<T> : YieldInstruction, IComparable<ComparableYieldInstruction<T>> where T : ComparableYieldInstruction<T>
{
	internal override bool IsComparable => true;

	protected void ComparableValueChanged()
	{
		if (base.IsInsideComparableCollection)
		{
			ComparableYieldInstructions<ComparableYieldInstruction<T>>.ValueChanged(this);
		}
	}

	internal override bool AddToComparableCollection()
	{
		return ComparableYieldInstructions<ComparableYieldInstruction<T>>.Add(this);
	}

	internal override void RemoveFromComparableCollection()
	{
		ComparableYieldInstructions<ComparableYieldInstruction<T>>.Remove(this);
	}

	public int CompareTo(ComparableYieldInstruction<T> other)
	{
		return CompareTo((T)other);
	}

	public abstract int CompareTo(T other);
}
