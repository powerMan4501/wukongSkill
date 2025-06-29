using System.Collections.Generic;
using System.Linq;

namespace UnrealEngine.Runtime;

public class WaitAny : YieldInstruction
{
	private List<YieldInstruction> instructions = new List<YieldInstruction>();

	public override bool KeepWaiting
	{
		get
		{
			if (instructions.Count == 0)
			{
				return false;
			}
			foreach (YieldInstruction instruction in instructions)
			{
				if (!instruction.KeepWaiting)
				{
					return false;
				}
			}
			return true;
		}
	}

	public WaitAny(params YieldInstruction[] instructions)
	{
		if (instructions == null)
		{
			return;
		}
		foreach (YieldInstruction yieldInstruction in instructions)
		{
			if (yieldInstruction != null && !this.instructions.Contains(yieldInstruction))
			{
				this.instructions.Add(yieldInstruction);
			}
		}
	}

	public override void OnBegin()
	{
		foreach (YieldInstruction instruction in instructions)
		{
			instruction.OnBegin();
		}
	}

	public override void OnEnd()
	{
		foreach (YieldInstruction instruction in instructions)
		{
			instruction.OnEnd();
		}
	}

	public override void OnOwnerSet()
	{
		foreach (YieldInstruction instruction in instructions)
		{
			instruction.Owner = base.Owner;
		}
	}

	internal WaitAny PoolNew(params YieldInstruction[] instructions)
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
