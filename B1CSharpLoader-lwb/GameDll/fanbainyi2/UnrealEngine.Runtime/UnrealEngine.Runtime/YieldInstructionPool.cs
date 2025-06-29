using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public abstract class YieldInstructionPool<T> : IYieldInstructionPool where T : YieldInstruction
{
	private Stack<T> available = new Stack<T>();

	private uint nextObjectId = 1u;

	public void ReturnObject(YieldInstruction obj)
	{
		obj.keepAlive = false;
		if (obj.pool != this)
		{
			throw new InvalidOperationException("Pooled YieldInstruction was returned to the wrong pool");
		}
		available.Push((T)obj);
	}

	public T GetObject()
	{
		if (available.Count != 0)
		{
			return available.Pop();
		}
		T val = New();
		val.poolId = nextObjectId++;
		val.pool = this;
		return val;
	}

	protected abstract T New();
}
