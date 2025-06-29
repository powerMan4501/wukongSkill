using System.Collections.Generic;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Runtime.Intepreter.OpCodes;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal class CodeBasicBlock
{
	private List<Instruction> instructions = new List<Instruction>();

	private List<OpCodeR> finalInstructions = new List<OpCodeR>();

	private HashSet<int> canRemove = new HashSet<int>();

	private HashSet<int> pendingCP = new HashSet<int>();

	private HashSet<CodeBasicBlock> prevBlocks = new HashSet<CodeBasicBlock>();

	private HashSet<CodeBasicBlock> nextBlocks = new HashSet<CodeBasicBlock>();

	private Dictionary<int, RegisterVMSymbol> instructionMapping = new Dictionary<int, RegisterVMSymbol>();

	private short endRegister = -1;

	private Instruction entry;

	public List<Instruction> Instructions => instructions;

	public List<OpCodeR> FinalInstructions => finalInstructions;

	public HashSet<int> CanRemove => canRemove;

	public HashSet<int> PendingCP => pendingCP;

	public HashSet<CodeBasicBlock> PreviousBlocks => prevBlocks;

	public HashSet<CodeBasicBlock> NextBlocks => nextBlocks;

	public Dictionary<int, RegisterVMSymbol> InstructionMapping => instructionMapping;

	public bool NeedLoadConstantElimination { get; set; }

	public short EndRegister
	{
		get
		{
			return endRegister;
		}
		set
		{
			endRegister = value;
		}
	}

	public void AddInstruction(Instruction op)
	{
		if (instructions.Count == 0)
		{
			entry = op;
		}
		instructions.Add(op);
	}

	public static List<CodeBasicBlock> BuildBasicBlocks(MethodBody body, out Dictionary<Instruction, int> entryMapping)
	{
		entryMapping = new Dictionary<Instruction, int>();
		HashSet<Instruction> hashSet = new HashSet<Instruction>();
		foreach (Instruction instruction2 in body.Instructions)
		{
			switch (instruction2.OpCode.OperandType)
			{
			case OperandType.InlineBrTarget:
			case OperandType.ShortInlineBrTarget:
				hashSet.Add((Instruction)instruction2.Operand);
				break;
			case OperandType.InlineSwitch:
			{
				Instruction[] array = instruction2.Operand as Instruction[];
				foreach (Instruction item in array)
				{
					hashSet.Add(item);
				}
				break;
			}
			}
		}
		List<CodeBasicBlock> list = new List<CodeBasicBlock>();
		CodeBasicBlock codeBasicBlock = new CodeBasicBlock();
		list.Add(codeBasicBlock);
		foreach (Instruction instruction3 in body.Instructions)
		{
			if (hashSet.Contains(instruction3) && codeBasicBlock.entry != null && codeBasicBlock.entry != instruction3)
			{
				entryMapping[codeBasicBlock.entry] = list.Count - 1;
				codeBasicBlock = new CodeBasicBlock();
				list.Add(codeBasicBlock);
			}
			codeBasicBlock.AddInstruction(instruction3);
			if ((instruction3.OpCode.Code != Code.Switch && instruction3.OpCode.Code != Code.Throw && instruction3.OpCode.OperandType != OperandType.InlineBrTarget && instruction3.OpCode.OperandType != OperandType.ShortInlineBrTarget && instruction3.OpCode.Code != Code.Endfinally) || codeBasicBlock.entry == null)
			{
				continue;
			}
			if (instruction3.OpCode.OperandType == OperandType.InlineBrTarget || instruction3.OpCode.OperandType == OperandType.ShortInlineBrTarget)
			{
				if (codeBasicBlock.entry != (Instruction)instruction3.Operand)
				{
					entryMapping[codeBasicBlock.entry] = list.Count - 1;
					codeBasicBlock = new CodeBasicBlock();
					list.Add(codeBasicBlock);
				}
			}
			else if (instruction3.Operand is Instruction)
			{
				if (codeBasicBlock.entry != (Instruction)instruction3.Operand)
				{
					entryMapping[codeBasicBlock.entry] = list.Count - 1;
					codeBasicBlock = new CodeBasicBlock();
					list.Add(codeBasicBlock);
				}
			}
			else
			{
				entryMapping[codeBasicBlock.entry] = list.Count - 1;
				codeBasicBlock = new CodeBasicBlock();
				list.Add(codeBasicBlock);
			}
		}
		if (codeBasicBlock.entry != null)
		{
			entryMapping[codeBasicBlock.entry] = list.Count - 1;
		}
		else
		{
			list.RemoveAt(list.Count - 1);
		}
		for (int j = 0; j < list.Count; j++)
		{
			CodeBasicBlock codeBasicBlock2 = list[j];
			Instruction instruction = codeBasicBlock2.instructions[codeBasicBlock2.instructions.Count - 1];
			switch (instruction.OpCode.OperandType)
			{
			case OperandType.InlineBrTarget:
			case OperandType.ShortInlineBrTarget:
			{
				CodeBasicBlock codeBasicBlock4 = list[entryMapping[(Instruction)instruction.Operand]];
				codeBasicBlock4.prevBlocks.Add(codeBasicBlock2);
				codeBasicBlock2.nextBlocks.Add(codeBasicBlock4);
				Code code = instruction.OpCode.Code;
				if ((uint)(code - 43) > 11u && (uint)(code - 56) > 11u)
				{
					continue;
				}
				if (j < list.Count - 1)
				{
					CodeBasicBlock codeBasicBlock5 = list[j + 1];
					codeBasicBlock2.nextBlocks.Add(codeBasicBlock5);
					codeBasicBlock5.prevBlocks.Add(codeBasicBlock2);
				}
				break;
			}
			case OperandType.InlineSwitch:
			{
				Instruction[] array = (Instruction[])instruction.Operand;
				foreach (Instruction key in array)
				{
					CodeBasicBlock codeBasicBlock3 = list[entryMapping[key]];
					codeBasicBlock3.prevBlocks.Add(codeBasicBlock2);
					codeBasicBlock2.nextBlocks.Add(codeBasicBlock3);
				}
				break;
			}
			}
			if (j < list.Count - 1)
			{
				CodeBasicBlock codeBasicBlock6 = list[j + 1];
				codeBasicBlock2.nextBlocks.Add(codeBasicBlock6);
				codeBasicBlock6.prevBlocks.Add(codeBasicBlock2);
			}
		}
		return list;
	}
}
