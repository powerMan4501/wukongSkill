using System.Collections.Generic;
using System.Linq;

namespace UnrealEngine.Runtime;

public class WaitAll : YieldInstruction
{
	private List<YieldInstruction> instructions = new List<YieldInstruction>();

	private int index;

	public override bool KeepWaiting
	{
		get
		{
			while (index < instructions.Count && !instructions[index].KeepWaiting)
			{
				instructions[index].End();
				index++;
			}
			return index >= instructions.Count;
		}
	}

	public WaitAll(params YieldInstruction[] instructions)
	{
		if (instructions == null)
		{
			return;
		}
		foreach (YieldInstruction yieldInstruction in instructions)
		{
			if (yieldInstruction != null && !instructions.Contains(yieldInstruction))
			{
				this.instructions.Add(yieldInstruction);
			}
		}
	}

	public override void OnBegin()
	{
		if (instructions.Count > 0)
		{
			instructions[0].OnBegin();
		}
	}

	public override void OnEnd()
	{
		if (index < instructions.Count)
		{
			for (int i = index; i < instructions.Count; i++)
			{
				instructions[i].OnEnd();
			}
		}
	}

	public override void OnOwnerSet()
	{
		foreach (YieldInstruction instruction in instructions)
		{
			instruction.Owner = base.Owner;
		}
	}

	internal WaitAll PoolNew(params YieldInstruction[] instructions)
	{
		this.instructions.Clear();
		if (instructions != null)
		{
			foreach (YieldInstruction yieldInstruction in instructions)
			{
				if (yieldInstruction != null && !instructions.Contains(yieldInstruction))
				{
					this.instructions.Add(yieldInstruction);
				}
			}
		}
		return this;
	}
}
