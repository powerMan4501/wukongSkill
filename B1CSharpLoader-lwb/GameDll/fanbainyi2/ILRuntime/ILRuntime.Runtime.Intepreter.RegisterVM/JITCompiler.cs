using System;
using System.Collections.Generic;
using System.Linq;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Mono.Cecil;
using ILRuntime.Mono.Cecil.Cil;
using ILRuntime.Runtime.Enviorment;
using ILRuntime.Runtime.Intepreter.OpCodes;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal struct JITCompiler
{
	public const int CallRegisterParamCount = 3;

	private ILRuntime.Runtime.Enviorment.AppDomain appdomain;

	private ILType declaringType;

	private ILMethod method;

	private MethodDefinition def;

	private bool hasReturn;

	private Dictionary<Instruction, int> entryMapping;

	private Dictionary<int, int[]> jumptables;

	public JITCompiler(ILRuntime.Runtime.Enviorment.AppDomain appDomain, ILType declaringType, ILMethod method)
	{
		appdomain = appDomain;
		this.declaringType = declaringType;
		this.method = method;
		def = method.Definition;
		hasReturn = method.ReturnType != appdomain.VoidType;
		entryMapping = null;
		jumptables = null;
	}

	private bool CheckNeedInitObj(CodeBasicBlock block, short reg, bool hasReturn, HashSet<CodeBasicBlock> visited)
	{
		if (visited.Contains(block))
		{
			return false;
		}
		visited.Add(block);
		for (int i = 0; i < block.FinalInstructions.Count; i++)
		{
			OpCodeR op = block.FinalInstructions[i];
			Optimizer.GetOpcodeDestRegister(ref op, out var r);
			if (Optimizer.GetOpcodeSourceRegister(ref op, hasReturn, out var r2, out var r3, out var r4) && (r2 == reg || r3 == reg || r4 == reg))
			{
				if (op.Code == OpCodeREnum.Ldloca || op.Code == OpCodeREnum.Ldloca_S)
				{
					if (i < block.FinalInstructions.Count - 1)
					{
						OpCodeR opCodeR = block.FinalInstructions[i + 1];
						if (opCodeR.Code == OpCodeREnum.Initobj && opCodeR.Register1 == r)
						{
							return false;
						}
					}
					return true;
				}
				return r != reg;
			}
			if (r == reg)
			{
				return false;
			}
		}
		if (block.NextBlocks != null && block.NextBlocks.Count > 0)
		{
			foreach (CodeBasicBlock nextBlock in block.NextBlocks)
			{
				if (CheckNeedInitObj(nextBlock, reg, hasReturn, visited))
				{
					return true;
				}
			}
		}
		return false;
	}

	private bool IsCatchHandler(CodeBasicBlock block, MethodBody body)
	{
		if (body.HasExceptionHandlers)
		{
			Instruction instruction = block.Instructions[0];
			foreach (ILRuntime.Mono.Cecil.Cil.ExceptionHandler exceptionHandler in body.ExceptionHandlers)
			{
				if (exceptionHandler.HandlerType == ILRuntime.Mono.Cecil.Cil.ExceptionHandlerType.Catch && exceptionHandler.HandlerStart == instruction)
				{
					return true;
				}
			}
			return false;
		}
		return false;
	}

	public OpCodeR[] Compile(out int stackRegisterCnt, out Dictionary<int, int[]> switchTargets, Dictionary<Instruction, int> addr, out Dictionary<int, RegisterVMSymbol> symbols)
	{
		method.Compiling = true;
		symbols = new Dictionary<int, RegisterVMSymbol>();
		MethodBody body = def.Body;
		short num = (short)def.Parameters.Count;
		if (!def.IsStatic)
		{
			num++;
		}
		short num2 = (short)(num + body.Variables.Count);
		short num3 = num2;
		List<CodeBasicBlock> list = CodeBasicBlock.BuildBasicBlocks(body, out entryMapping);
		foreach (CodeBasicBlock item3 in list)
		{
			num2 = num3;
			if (IsCatchHandler(item3, body))
			{
				num2++;
			}
			else if (item3.PreviousBlocks.Count > 0)
			{
				foreach (CodeBasicBlock previousBlock in item3.PreviousBlocks)
				{
					if (previousBlock.EndRegister >= 0)
					{
						num2 = previousBlock.EndRegister;
						break;
					}
				}
			}
			foreach (Instruction instruction in item3.Instructions)
			{
				Translate(item3, instruction, num, ref num2);
			}
			item3.EndRegister = num2;
		}
		CodeBasicBlock codeBasicBlock = list[0];
		int num4 = 0;
		int num5 = 0;
		HashSet<CodeBasicBlock> hashSet = ((body.Variables.Count > 0) ? new HashSet<CodeBasicBlock>() : null);
		for (short num6 = num; num6 < num + body.Variables.Count; num6++)
		{
			hashSet.Clear();
			foreach (CodeBasicBlock item4 in list)
			{
				if (item4.PreviousBlocks.Count == 0)
				{
					VariableDefinition variableDefinition = def.Body.Variables[num6 - num];
					bool flag = false;
					if (variableDefinition.VariableType.IsGenericParameter)
					{
						IType type = method.FindGenericArgument(variableDefinition.VariableType.Name);
						flag = type.IsValueType && !type.IsPrimitive;
					}
					else
					{
						flag = variableDefinition.VariableType.IsValueType && !variableDefinition.VariableType.IsPrimitive;
					}
					if (flag || CheckNeedInitObj(item4, num6, method.ReturnType != method.AppDomain.VoidType, hashSet))
					{
						OpCodeR item = new OpCodeR
						{
							Code = OpCodeREnum.Initobj,
							Register1 = num6,
							Operand = method.GetTypeTokenHashCode(body.Variables[num4].VariableType),
							Operand2 = 1
						};
						codeBasicBlock.FinalInstructions.Insert(num5++, item);
						break;
					}
				}
			}
			num4++;
		}
		for (num4 = codeBasicBlock.FinalInstructions.Count - 1; num4 >= 0; num4--)
		{
			if (num4 >= num5)
			{
				if (codeBasicBlock.InstructionMapping.TryGetValue(num4 - num5, out var _))
				{
					codeBasicBlock.InstructionMapping[num4] = codeBasicBlock.InstructionMapping[num4 - num5];
				}
			}
			else
			{
				codeBasicBlock.InstructionMapping.Remove(num4);
			}
		}
		Optimizer.ForwardCopyPropagation(list, hasReturn, num3);
		Optimizer.BackwardsCopyPropagation(list, hasReturn, num3);
		Optimizer.ForwardCopyPropagation(list, hasReturn, num3);
		Optimizer.EliminateConstantLoad(list, hasReturn);
		List<OpCodeR> list2 = new List<OpCodeR>();
		Dictionary<int, int> dictionary = new Dictionary<int, int>();
		int num7 = 0;
		HashSet<int> hashSet2 = new HashSet<int>();
		int num8 = 0;
		foreach (CodeBasicBlock item5 in list)
		{
			dictionary[num7++] = list2.Count;
			bool flag2 = false;
			int num9 = 0;
			bool flag3 = false;
			for (num4 = 0; num4 < item5.FinalInstructions.Count; num4++)
			{
				RegisterVMSymbol value2;
				bool flag4 = item5.InstructionMapping.TryGetValue(num4, out value2);
				if (flag4)
				{
					if (flag2)
					{
						if (!flag3)
						{
							while (value2.ParentSymbol != null)
							{
								value2 = value2.ParentSymbol.Value;
							}
							addr[value2.Instruction] = num8;
							flag3 = true;
						}
					}
					else
					{
						addr[value2.Instruction] = num8;
					}
				}
				if (item5.CanRemove.Contains(num4))
				{
					if (flag2)
					{
						num9--;
					}
					continue;
				}
				OpCodeR item2 = item5.FinalInstructions[num4];
				if (item2.Code == OpCodeREnum.InlineStart)
				{
					flag3 = false;
					flag2 = true;
					num9 = list2.Count;
					continue;
				}
				if (item2.Code == OpCodeREnum.InlineEnd)
				{
					flag2 = false;
					continue;
				}
				if (flag2)
				{
					if (Optimizer.IsBranching(item2.Code))
					{
						item2.Operand += num9;
						hashSet2.Add(list2.Count);
					}
					else if (Optimizer.IsIntermediateBranching(item2.Code))
					{
						item2.Operand4 += num9;
						hashSet2.Add(list2.Count);
					}
					else if (item2.Code == OpCodeREnum.Switch)
					{
						int[] array = jumptables[item2.Operand];
						for (int i = 0; i < array.Length; i++)
						{
							array[i] += num9;
						}
						hashSet2.Add(list2.Count);
					}
				}
				if (flag4)
				{
					symbols.Add(list2.Count, value2);
				}
				num8++;
				list2.Add(item2);
			}
		}
		for (int j = 0; j < list2.Count; j++)
		{
			OpCodeR value3 = list2[j];
			if (Optimizer.IsBranching(value3.Code) && !hashSet2.Contains(j))
			{
				value3.Operand = dictionary[value3.Operand];
				list2[j] = value3;
			}
			else if (Optimizer.IsIntermediateBranching(value3.Code) && !hashSet2.Contains(j))
			{
				value3.Operand4 = dictionary[value3.Operand4];
				list2[j] = value3;
			}
			else if (value3.Code == OpCodeREnum.Switch && !hashSet2.Contains(j))
			{
				int[] array2 = jumptables[value3.Operand];
				for (int k = 0; k < array2.Length; k++)
				{
					array2[k] = dictionary[array2[k]];
				}
			}
			else if (value3.Code == OpCodeREnum.Leave || value3.Code == OpCodeREnum.Leave_S)
			{
				value3.Operand = addr[(Instruction)symbols[j].Instruction.Operand];
				list2[j] = value3;
			}
		}
		symbols = null;
		switchTargets = jumptables;
		int num10 = Optimizer.CleanupRegister(list2, num, hasReturn);
		stackRegisterCnt = Math.Max(num10 - num3, 0);
		method.Compiling = false;
		return list2.ToArray();
	}

	private void PrepareJumpTable(object token)
	{
		int hashCode = token.GetHashCode();
		if (jumptables == null)
		{
			jumptables = new Dictionary<int, int[]>();
		}
		if (!jumptables.ContainsKey(hashCode))
		{
			Instruction[] array = token as Instruction[];
			int[] array2 = new int[array.Length];
			for (int i = 0; i < array.Length; i++)
			{
				array2[i] = entryMapping[array[i]];
			}
			jumptables[hashCode] = array2;
		}
	}

	public static void FixSymbol(Dictionary<int, RegisterVMSymbol> symbol)
	{
		HashSet<Instruction> hashSet = new HashSet<Instruction>();
		KeyValuePair<int, RegisterVMSymbol>[] array = symbol.ToArray();
		for (int i = 0; i < array.Length; i++)
		{
			KeyValuePair<int, RegisterVMSymbol> keyValuePair = array[i];
			RegisterVMSymbol value = keyValuePair.Value;
			RegisterVMSymbolLink registerVMSymbolLink = null;
			while (value.ParentSymbol != null)
			{
				registerVMSymbolLink = value.ParentSymbol;
				value = value.ParentSymbol.Value;
			}
			IDictionary<Instruction, SequencePoint> sequencePointMapping = value.Method.Definition.DebugInformation.GetSequencePointMapping();
			Instruction instruction = FindSequencePoint(value.Instruction, sequencePointMapping);
			if (instruction != null && !hashSet.Contains(instruction))
			{
				hashSet.Add(instruction);
				value.Instruction = instruction;
				if (registerVMSymbolLink != null)
				{
					registerVMSymbolLink.Value = value;
				}
				else
				{
					symbol[keyValuePair.Key] = value;
				}
			}
		}
	}

	private static Instruction FindSequencePoint(Instruction ins, IDictionary<Instruction, SequencePoint> seqMapping)
	{
		Instruction instruction = ins;
		SequencePoint value;
		while (!seqMapping.TryGetValue(instruction, out value) && instruction.Previous != null)
		{
			instruction = instruction.Previous;
		}
		return instruction;
	}

	private void Translate(CodeBasicBlock block, Instruction ins, short locVarRegStart, ref short baseRegIdx)
	{
		List<OpCodeR> finalInstructions = block.FinalInstructions;
		OpCodeR op = default(OpCodeR);
		ILRuntime.Mono.Cecil.Cil.OpCode opCode = ins.OpCode;
		object operand = ins.Operand;
		op.Code = (OpCodeREnum)opCode.Code;
		bool flag3;
		switch (opCode.Code)
		{
		case Code.Br_S:
		case Code.Br:
			op.Operand = entryMapping[(Instruction)operand];
			break;
		case Code.Brfalse_S:
		case Code.Brtrue_S:
		case Code.Brfalse:
		case Code.Brtrue:
			op.Register1 = --baseRegIdx;
			op.Operand = entryMapping[(Instruction)operand];
			break;
		case Code.Switch:
			op.Register1 = --baseRegIdx;
			PrepareJumpTable(operand);
			op.Operand = operand.GetHashCode();
			break;
		case Code.Beq_S:
		case Code.Bge_S:
		case Code.Bgt_S:
		case Code.Ble_S:
		case Code.Blt_S:
		case Code.Bne_Un_S:
		case Code.Bge_Un_S:
		case Code.Bgt_Un_S:
		case Code.Ble_Un_S:
		case Code.Blt_Un_S:
		case Code.Beq:
		case Code.Bge:
		case Code.Bgt:
		case Code.Ble:
		case Code.Blt:
		case Code.Bne_Un:
		case Code.Bge_Un:
		case Code.Bgt_Un:
		case Code.Ble_Un:
		case Code.Blt_Un:
			op.Register1 = (short)(baseRegIdx - 2);
			op.Register2 = (short)(baseRegIdx - 1);
			baseRegIdx -= 2;
			op.Operand = entryMapping[(Instruction)operand];
			break;
		case Code.Ldnull:
		case Code.Ldc_I4_M1:
		case Code.Ldc_I4_0:
		case Code.Ldc_I4_1:
		case Code.Ldc_I4_2:
		case Code.Ldc_I4_3:
		case Code.Ldc_I4_4:
		case Code.Ldc_I4_5:
		case Code.Ldc_I4_6:
		case Code.Ldc_I4_7:
		case Code.Ldc_I4_8:
			op.Register1 = baseRegIdx++;
			break;
		case Code.Ldc_I4:
			op.Register1 = baseRegIdx++;
			op.Operand = (int)operand;
			break;
		case Code.Ldc_I4_S:
			op.Register1 = baseRegIdx++;
			op.Operand = (sbyte)operand;
			break;
		case Code.Ldc_I8:
			op.Register1 = baseRegIdx++;
			op.OperandLong = (long)operand;
			break;
		case Code.Ldc_R4:
			op.Register1 = baseRegIdx++;
			op.OperandFloat = (float)operand;
			break;
		case Code.Ldc_R8:
			op.Register1 = baseRegIdx++;
			op.OperandDouble = (double)operand;
			break;
		case Code.Ldstr:
			op.Register1 = baseRegIdx++;
			op.OperandLong = appdomain.CacheString(operand);
			break;
		case Code.Newobj:
		{
			bool canInline3;
			IMethod m3;
			ILMethod toInline3;
			bool isILMethod3;
			int num = InitializeFunctionParam(ref op, operand, out flag3, out canInline3, out m3, out toInline3, out isILMethod3);
			int num2 = Math.Max(num - 3, 0);
			for (int num3 = num; num3 > num - num2; num3--)
			{
				finalInstructions.Add(new OpCodeR
				{
					Code = OpCodeREnum.Push,
					Register1 = (short)(baseRegIdx - num3)
				});
			}
			if (num2 < num)
			{
				switch (num - num2)
				{
				case 1:
					op.Register2 = (short)(baseRegIdx - 1);
					break;
				case 2:
					op.Register3 = (short)(baseRegIdx - 1);
					op.Register2 = (short)(baseRegIdx - 2);
					break;
				case 3:
					op.Register4 = (short)(baseRegIdx - 1);
					op.Register3 = (short)(baseRegIdx - 2);
					op.Register2 = (short)(baseRegIdx - 3);
					break;
				}
			}
			baseRegIdx -= (short)num;
			op.Register1 = baseRegIdx++;
			break;
		}
		case Code.Call:
		case Code.Callvirt:
		{
			bool canInline4;
			IMethod m4;
			ILMethod toInline4;
			bool isILMethod4;
			int num4 = InitializeFunctionParam(ref op, operand, out flag3, out canInline4, out m4, out toInline4, out isILMethod4);
			bool flag4 = false;
			int num5 = -1;
			if (finalInstructions.Count > 0)
			{
				num5 = finalInstructions.Count - 1;
				flag4 = finalInstructions[num5].Code == OpCodeREnum.Constrained;
			}
			bool flag5 = canInline4 && !flag4;
			if (flag5 && toInline4.BodyRegister.Length > 10)
			{
				flag5 = false;
			}
			if (!flag5)
			{
				if (opCode.Code == Code.Callvirt && m4 is ILMethod)
				{
					ILMethod iLMethod = (ILMethod)m4;
					if (!iLMethod.Definition.IsAbstract && !iLMethod.Definition.IsVirtual && !iLMethod.DeclearingType.IsInterface)
					{
						op.Code = OpCodeREnum.Call;
					}
				}
				int num6 = (flag4 ? num4 : Math.Max(num4 - 3, 0));
				for (int num7 = num4; num7 > num4 - num6; num7--)
				{
					finalInstructions.Add(new OpCodeR
					{
						Code = OpCodeREnum.Push,
						Operand = (isILMethod4 ? 1 : 0),
						Register1 = (short)(baseRegIdx - num7)
					});
				}
				if (num6 < num4)
				{
					switch (num4 - num6)
					{
					case 1:
						op.Register2 = (short)(baseRegIdx - 1);
						break;
					case 2:
						op.Register3 = (short)(baseRegIdx - 1);
						op.Register2 = (short)(baseRegIdx - 2);
						break;
					case 3:
						op.Register4 = (short)(baseRegIdx - 1);
						op.Register3 = (short)(baseRegIdx - 2);
						op.Register2 = (short)(baseRegIdx - 3);
						break;
					}
				}
				if (flag4)
				{
					op.Operand4 = 1;
					OpCodeR item = finalInstructions[num5];
					finalInstructions.RemoveAt(num5);
					item.Operand2 = op.Operand2;
					RegisterVMSymbol value = block.InstructionMapping[num5];
					block.InstructionMapping.Remove(num5);
					block.InstructionMapping.Add(finalInstructions.Count, value);
					finalInstructions.Add(item);
				}
				baseRegIdx -= (short)num4;
				if (flag3)
				{
					op.Register1 = baseRegIdx++;
				}
				else
				{
					op.Register1 = -1;
				}
				break;
			}
			baseRegIdx -= (short)num4;
			RegisterVMSymbolLink symbolLink = null;
			RegisterVMSymbol value2 = new RegisterVMSymbol
			{
				Instruction = ins,
				Method = method
			};
			block.InstructionMapping.Add(finalInstructions.Count, value2);
			Optimizer.InlineMethod(block, toInline4, symbolLink, ref jumptables, baseRegIdx, flag3);
			if (flag3)
			{
				baseRegIdx++;
			}
			return;
		}
		case Code.Ldsfld:
		case Code.Ldsflda:
			op.Register1 = baseRegIdx++;
			op.OperandLong = appdomain.GetStaticFieldIndex(operand, declaringType, method);
			break;
		case Code.Stsfld:
			op.Register1 = --baseRegIdx;
			op.OperandLong = appdomain.GetStaticFieldIndex(operand, declaringType, method);
			break;
		case Code.Initobj:
			op.Register1 = --baseRegIdx;
			op.Operand = method.GetTypeTokenHashCode(operand);
			break;
		case Code.Ret:
			if (hasReturn)
			{
				op.Register1 = --baseRegIdx;
			}
			break;
		case Code.Throw:
			op.Register1 = --baseRegIdx;
			break;
		case Code.Add:
		case Code.Sub:
		case Code.Mul:
		case Code.Div:
		case Code.Div_Un:
		case Code.Rem:
		case Code.Rem_Un:
		case Code.And:
		case Code.Or:
		case Code.Xor:
		case Code.Shl:
		case Code.Shr:
		case Code.Shr_Un:
		case Code.Ldelema:
		case Code.Ldelem_I1:
		case Code.Ldelem_U1:
		case Code.Ldelem_I2:
		case Code.Ldelem_U2:
		case Code.Ldelem_I4:
		case Code.Ldelem_U4:
		case Code.Ldelem_I8:
		case Code.Ldelem_R4:
		case Code.Ldelem_R8:
		case Code.Ldelem_Ref:
		case Code.Ldelem_Any:
		case Code.Add_Ovf:
		case Code.Add_Ovf_Un:
		case Code.Mul_Ovf:
		case Code.Mul_Ovf_Un:
		case Code.Sub_Ovf:
		case Code.Sub_Ovf_Un:
		case Code.Ceq:
		case Code.Cgt:
		case Code.Cgt_Un:
		case Code.Clt:
		case Code.Clt_Un:
			op.Register1 = (short)(baseRegIdx - 2);
			op.Register2 = (short)(baseRegIdx - 2);
			op.Register3 = (short)(baseRegIdx - 1);
			baseRegIdx--;
			break;
		case Code.Stloc_0:
			op.Code = OpCodeREnum.Move;
			op.Register1 = locVarRegStart;
			op.Register2 = --baseRegIdx;
			break;
		case Code.Stloc_1:
			op.Code = OpCodeREnum.Move;
			op.Register1 = (short)(locVarRegStart + 1);
			op.Register2 = --baseRegIdx;
			break;
		case Code.Stloc_2:
			op.Code = OpCodeREnum.Move;
			op.Register1 = (short)(locVarRegStart + 2);
			op.Register2 = --baseRegIdx;
			break;
		case Code.Stloc_3:
			op.Code = OpCodeREnum.Move;
			op.Register1 = (short)(locVarRegStart + 3);
			op.Register2 = --baseRegIdx;
			break;
		case Code.Stloc_S:
			op.Code = OpCodeREnum.Move;
			op.Register1 = (short)(locVarRegStart + ((VariableDefinition)ins.Operand).Index);
			op.Register2 = --baseRegIdx;
			break;
		case Code.Ldloc_0:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = locVarRegStart;
			break;
		case Code.Ldloc_1:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(locVarRegStart + 1);
			break;
		case Code.Ldloc_2:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(locVarRegStart + 2);
			break;
		case Code.Ldloc_3:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(locVarRegStart + 3);
			break;
		case Code.Ldloc_S:
		case Code.Ldloc:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(locVarRegStart + ((VariableDefinition)ins.Operand).Index);
			break;
		case Code.Ldloca_S:
		case Code.Ldloca:
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(locVarRegStart + ((VariableDefinition)ins.Operand).Index);
			break;
		case Code.Ldarg_0:
		case Code.Ldarg_1:
		case Code.Ldarg_2:
		case Code.Ldarg_3:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)(opCode.Code - 2);
			break;
		case Code.Ldarg_S:
			op.Code = OpCodeREnum.Move;
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)((ParameterDefinition)ins.Operand).Index;
			if (def.HasThis)
			{
				op.Register2++;
			}
			break;
		case Code.Ldarga_S:
		case Code.Ldarga:
			op.Register1 = baseRegIdx++;
			op.Register2 = (short)((ParameterDefinition)ins.Operand).Index;
			if (def.HasThis)
			{
				op.Register2++;
			}
			break;
		case Code.Starg_S:
		case Code.Starg:
			op.Code = OpCodeREnum.Move;
			op.Register2 = --baseRegIdx;
			op.Register1 = (short)((ParameterDefinition)ins.Operand).Index;
			if (def.HasThis)
			{
				op.Register1++;
			}
			break;
		case Code.Newarr:
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			op.Operand = method.GetTypeTokenHashCode(operand);
			break;
		case Code.Dup:
			op.Code = OpCodeREnum.Move;
			op.Register2 = (short)(baseRegIdx - 1);
			op.Register1 = baseRegIdx++;
			break;
		case Code.Stelem_I:
		case Code.Stelem_I1:
		case Code.Stelem_I2:
		case Code.Stelem_I4:
		case Code.Stelem_I8:
		case Code.Stelem_R4:
		case Code.Stelem_R8:
		case Code.Stelem_Ref:
		case Code.Stelem_Any:
			op.Register1 = (short)(baseRegIdx - 3);
			op.Register2 = (short)(baseRegIdx - 2);
			op.Register3 = (short)(baseRegIdx - 1);
			baseRegIdx -= 3;
			break;
		case Code.Stind_Ref:
		case Code.Stind_I1:
		case Code.Stind_I2:
		case Code.Stind_I4:
		case Code.Stind_I8:
		case Code.Stind_R4:
		case Code.Stind_R8:
		case Code.Stind_I:
			op.Register1 = (short)(baseRegIdx - 2);
			op.Register2 = (short)(baseRegIdx - 1);
			baseRegIdx -= 2;
			break;
		case Code.Stobj:
			op.Register1 = (short)(baseRegIdx - 2);
			op.Register2 = (short)(baseRegIdx - 1);
			op.Operand = method.GetTypeTokenHashCode(operand);
			baseRegIdx -= 2;
			break;
		case Code.Ldind_U1:
		case Code.Ldind_I2:
		case Code.Ldind_U2:
		case Code.Ldind_I4:
		case Code.Ldind_U4:
		case Code.Ldind_I8:
		case Code.Ldind_I:
		case Code.Ldind_R4:
		case Code.Ldind_R8:
		case Code.Ldind_Ref:
		case Code.Neg:
		case Code.Not:
		case Code.Conv_I1:
		case Code.Conv_I2:
		case Code.Conv_I4:
		case Code.Conv_I8:
		case Code.Conv_R4:
		case Code.Conv_R8:
		case Code.Conv_U4:
		case Code.Conv_U8:
		case Code.Conv_R_Un:
		case Code.Conv_Ovf_I1_Un:
		case Code.Conv_Ovf_I2_Un:
		case Code.Conv_Ovf_I4_Un:
		case Code.Conv_Ovf_I8_Un:
		case Code.Conv_Ovf_U1_Un:
		case Code.Conv_Ovf_U2_Un:
		case Code.Conv_Ovf_U4_Un:
		case Code.Conv_Ovf_U8_Un:
		case Code.Conv_Ovf_I_Un:
		case Code.Conv_Ovf_U_Un:
		case Code.Ldlen:
		case Code.Conv_Ovf_I1:
		case Code.Conv_Ovf_U1:
		case Code.Conv_Ovf_I2:
		case Code.Conv_Ovf_U2:
		case Code.Conv_Ovf_I4:
		case Code.Conv_Ovf_U4:
		case Code.Conv_Ovf_I8:
		case Code.Conv_Ovf_U8:
		case Code.Conv_U2:
		case Code.Conv_U1:
		case Code.Conv_I:
		case Code.Conv_Ovf_I:
		case Code.Conv_Ovf_U:
		case Code.Conv_U:
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			break;
		case Code.Ldobj:
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			op.Operand = method.GetTypeTokenHashCode(operand);
			break;
		case Code.Ldfld:
		case Code.Ldflda:
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			op.OperandLong = appdomain.GetStaticFieldIndex(operand, declaringType, method);
			break;
		case Code.Stfld:
			op.Register1 = (short)(baseRegIdx - 2);
			op.Register2 = (short)(baseRegIdx - 1);
			op.OperandLong = appdomain.GetStaticFieldIndex(operand, declaringType, method);
			baseRegIdx -= 2;
			break;
		case Code.Castclass:
		case Code.Isinst:
		case Code.Unbox:
		case Code.Box:
		case Code.Unbox_Any:
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			op.Operand = method.GetTypeTokenHashCode(operand);
			break;
		case Code.Constrained:
			op.Operand = method.GetTypeTokenHashCode(operand);
			break;
		case Code.Ldtoken:
			op.Register1 = baseRegIdx++;
			if (operand is FieldReference)
			{
				op.Operand = 0;
				op.OperandLong = appdomain.GetStaticFieldIndex(operand, declaringType, method);
				break;
			}
			if (operand is TypeReference)
			{
				op.Operand = 1;
				op.OperandLong = method.GetTypeTokenHashCode(operand);
				break;
			}
			throw new NotImplementedException();
		case Code.Ldftn:
		{
			op.Register1 = baseRegIdx++;
			InitializeFunctionParam(ref op, operand, out var _, out var _, out var _, out var _, out var _);
			break;
		}
		case Code.Ldvirtftn:
		{
			InitializeFunctionParam(ref op, operand, out var _, out var _, out var _, out var _, out var _);
			op.Register1 = (short)(baseRegIdx - 1);
			op.Register2 = (short)(baseRegIdx - 1);
			break;
		}
		case Code.Pop:
			baseRegIdx--;
			op.Code = OpCodeREnum.Nop;
			break;
		default:
			throw new NotImplementedException($"Unknown Opcode:{opCode.Code}");
		case Code.Nop:
		case Code.Endfinally:
		case Code.Leave:
		case Code.Leave_S:
		case Code.Volatile:
		case Code.Rethrow:
		case Code.Readonly:
			break;
		}
		RegisterVMSymbol value3 = new RegisterVMSymbol
		{
			Instruction = ins,
			Method = method
		};
		block.InstructionMapping.Add(finalInstructions.Count, value3);
		finalInstructions.Add(op);
		if (!block.NeedLoadConstantElimination)
		{
			block.NeedLoadConstantElimination = Optimizer.IsLoadConstant(op.Code);
		}
	}

	private int InitializeFunctionParam(ref OpCodeR op, object token, out bool hasReturn, out bool canInline, out IMethod m, out ILMethod toInline, out bool isILMethod)
	{
		int num = 0;
		m = appdomain.GetMethod(token, declaringType, method, out var invalidToken);
		toInline = null;
		canInline = false;
		op.Register2 = -1;
		op.Register3 = -1;
		op.Register4 = -1;
		if (m != null)
		{
			if (invalidToken)
			{
				op.Operand2 = m.GetHashCode();
			}
			else
			{
				op.Operand2 = token.GetHashCode();
			}
			num = m.ParameterCount;
			if (!m.IsStatic && op.Code != OpCodeREnum.Newobj)
			{
				num++;
			}
			hasReturn = m.ReturnType != appdomain.VoidType && (!m.IsConstructor || op.Code != OpCodeREnum.Call);
			if (m is ILMethod)
			{
				isILMethod = !m.IsDelegateInvoke;
				ILMethod iLMethod = (ILMethod)m;
				bool flag = (iLMethod.JITFlags & 4) != 0;
				bool flag2 = (iLMethod.JITFlags & 8) != 0;
				bool flag3 = iLMethod.Definition.HasBody && iLMethod.Definition.Body.HasExceptionHandlers;
				if (!iLMethod.IsDelegateInvoke && !iLMethod.IsVirtual && !flag && !flag3 && !iLMethod.Compiling && !iLMethod.IsEventAdd && !iLMethod.IsEventRemove)
				{
					MethodDefinition definition = iLMethod.Definition;
					if (!definition.HasBody || flag2)
					{
						canInline = true;
						toInline = iLMethod;
					}
					else if (iLMethod.IsRegisterBodyReady ? (iLMethod.BodyRegister.Length <= 10) : (definition.Body.Instructions.Count <= 20))
					{
						canInline = true;
						toInline = iLMethod;
					}
				}
			}
			else
			{
				isILMethod = false;
			}
		}
		else
		{
			isILMethod = false;
			MethodReference methodReference = (MethodReference)token;
			num = (methodReference.HasParameters ? methodReference.Parameters.Count : 0);
			if (methodReference.HasThis && op.Code != OpCodeREnum.Newobj)
			{
				num++;
			}
			op.Operand3 = num;
			hasReturn = false;
		}
		return num;
	}
}
