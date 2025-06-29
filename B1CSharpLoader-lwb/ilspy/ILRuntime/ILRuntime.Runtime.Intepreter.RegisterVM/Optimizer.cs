using System;
using System.Collections.Generic;
using ILRuntime.CLR.Method;
using ILRuntime.Runtime.Intepreter.OpCodes;

namespace ILRuntime.Runtime.Intepreter.RegisterVM;

internal class Optimizer
{
	public const int MaximalInlineInstructionCount = 20;

	public static void BackwardsCopyPropagation(List<CodeBasicBlock> blocks, bool hasReturn, short stackRegisterBegin)
	{
		foreach (CodeBasicBlock block in blocks)
		{
			List<OpCodeR> finalInstructions = block.FinalInstructions;
			HashSet<int> canRemove = block.CanRemove;
			bool flag = false;
			for (int num = finalInstructions.Count - 1; num >= 0; num--)
			{
				if (!canRemove.Contains(num))
				{
					OpCodeR op = finalInstructions[num];
					if (op.Code == OpCodeREnum.InlineStart)
					{
						flag = false;
					}
					else if (op.Code == OpCodeREnum.InlineEnd)
					{
						flag = true;
					}
					else if (op.Code == OpCodeREnum.Nop)
					{
						canRemove.Add(num);
					}
					else if (op.Code == OpCodeREnum.Move)
					{
						GetOpcodeSourceRegister(ref op, hasReturn, out var r, out var _, out var _);
						GetOpcodeDestRegister(ref op, out var r4);
						if (r4 == r)
						{
							canRemove.Add(num);
						}
						else if (!(r < stackRegisterBegin || r4 >= stackRegisterBegin || flag))
						{
							bool flag2 = false;
							for (int num2 = num - 1; num2 >= 0; num2--)
							{
								OpCodeR op2 = finalInstructions[num2];
								if (op2.Code == OpCodeREnum.InlineStart)
								{
									flag2 = false;
								}
								else if (op2.Code == OpCodeREnum.InlineEnd)
								{
									flag2 = true;
								}
								if (GetOpcodeSourceRegister(ref op2, hasReturn, out var r5, out var r6, out var r7) && ((r5 >= 0 && r5 == r4) || (r6 >= 0 && r6 == r4) || (r7 >= 0 && r7 == r4)))
								{
									break;
								}
								if (GetOpcodeDestRegister(ref op2, out var r8))
								{
									if (r4 == r8 && !flag2)
									{
										break;
									}
									if (r == r8)
									{
										if (flag2)
										{
											break;
										}
										ReplaceOpcodeDest(ref op2, r4);
										for (int i = num2 + 1; i < finalInstructions.Count; i++)
										{
											OpCodeR op3 = finalInstructions[i];
											bool flag3 = false;
											GetOpcodeDestRegister(ref op3, out var r9);
											if (GetOpcodeSourceRegister(ref op3, hasReturn, out var r10, out var r11, out var r12))
											{
												if (r10 == r8)
												{
													flag3 = true;
													ReplaceOpcodeSource(ref op3, 0, r4);
												}
												if (r11 == r8)
												{
													flag3 = true;
													ReplaceOpcodeSource(ref op3, 1, r4);
												}
												if (r12 == r8)
												{
													flag3 = true;
													ReplaceOpcodeSource(ref op3, 2, r4);
												}
											}
											if (flag3)
											{
												finalInstructions[i] = op3;
											}
											if (r9 >= 0 && r9 == r8)
											{
												break;
											}
										}
										canRemove.Add(num);
										finalInstructions[num2] = op2;
										break;
									}
								}
							}
						}
					}
				}
			}
		}
	}

	public static void EliminateConstantLoad(List<CodeBasicBlock> blocks, bool hasReturn)
	{
		foreach (CodeBasicBlock block in blocks)
		{
			if (!block.NeedLoadConstantElimination)
			{
				continue;
			}
			List<OpCodeR> finalInstructions = block.FinalInstructions;
			HashSet<int> canRemove = block.CanRemove;
			bool flag = false;
			for (int i = 0; i < finalInstructions.Count; i++)
			{
				OpCodeR constant = finalInstructions[i];
				if (constant.Code == OpCodeREnum.InlineStart)
				{
					flag = true;
				}
				else if (constant.Code == OpCodeREnum.InlineEnd)
				{
					flag = false;
				}
				else
				{
					if (flag || !IsLoadConstant(constant.Code))
					{
						continue;
					}
					GetOpcodeDestRegister(ref constant, out var r);
					bool flag2 = false;
					for (int j = i + 1; j < finalInstructions.Count; j++)
					{
						OpCodeR op = finalInstructions[j];
						if (op.Code == OpCodeREnum.InlineStart)
						{
							flag2 = true;
						}
						else if (op.Code == OpCodeREnum.InlineEnd)
						{
							flag2 = false;
						}
						GetOpcodeSourceRegister(ref op, hasReturn, out var r2, out var r3, out var r4);
						if (r2 == r || r3 == r || r4 == r)
						{
							if (!SupportIntemediateValue(op.Code))
							{
								break;
							}
							if (r3 == r)
							{
								if (!flag2)
								{
									op.Code = GetIntemediateValueOpcode(op.Code);
									ReplaceRegisterWithConstant(ref op, ref constant);
									finalInstructions[j] = op;
									canRemove.Add(i);
								}
							}
							else if (r2 == r && !flag2)
							{
								if (SupportOperandSwap(op.Code))
								{
									ReplaceOpcodeSource(ref op, 0, r3);
									op.Code = GetIntemediateValueOpcode(op.Code);
									ReplaceRegisterWithConstant(ref op, ref constant);
									finalInstructions[j] = op;
									canRemove.Add(i);
								}
								else if (HasInverseOpcode(op.Code))
								{
									ReplaceOpcodeSource(ref op, 0, r3);
									op.Code = GetIntemediateValueOpcode(GetInverseOpcode(op.Code));
									ReplaceRegisterWithConstant(ref op, ref constant);
									finalInstructions[j] = op;
									canRemove.Add(i);
								}
							}
							break;
						}
						GetOpcodeDestRegister(ref op, out var r5);
						if (r5 == r)
						{
							break;
						}
					}
				}
			}
		}
	}

	public static void ForwardCopyPropagation(List<CodeBasicBlock> blocks, bool hasReturn, short stackRegisterBegin)
	{
		foreach (CodeBasicBlock block in blocks)
		{
			List<OpCodeR> finalInstructions = block.FinalInstructions;
			HashSet<int> canRemove = block.CanRemove;
			HashSet<int> pendingCP = block.PendingCP;
			bool flag = false;
			for (int i = 0; i < finalInstructions.Count; i++)
			{
				if (canRemove.Contains(i))
				{
					continue;
				}
				OpCodeR op = finalInstructions[i];
				if (op.Code == OpCodeREnum.InlineStart)
				{
					flag = true;
				}
				else if (op.Code == OpCodeREnum.InlineEnd)
				{
					flag = false;
				}
				else if (op.Code == OpCodeREnum.Nop || op.Code == OpCodeREnum.Readonly || op.Code == OpCodeREnum.Volatile)
				{
					canRemove.Add(i);
				}
				else
				{
					if (op.Code != OpCodeREnum.Move)
					{
						continue;
					}
					GetOpcodeSourceRegister(ref op, hasReturn, out var r, out var _, out var _);
					GetOpcodeDestRegister(ref op, out var r4);
					if (r4 == r)
					{
						canRemove.Add(i);
					}
					else
					{
						if ((r >= stackRegisterBegin && r4 < stackRegisterBegin) || flag)
						{
							continue;
						}
						bool flag2 = false;
						bool flag3 = false;
						bool flag4 = false;
						for (int j = i + 1; j < finalInstructions.Count; j++)
						{
							OpCodeR op2 = finalInstructions[j];
							if (op2.Code == OpCodeREnum.InlineStart)
							{
								flag4 = true;
							}
							else if (op2.Code == OpCodeREnum.InlineEnd)
							{
								flag4 = false;
							}
							if (GetOpcodeSourceRegister(ref op2, hasReturn, out var r5, out var r6, out var r7))
							{
								bool flag5 = false;
								if (r5 >= 0 && r5 == r4)
								{
									if (flag2)
									{
										flag2 = false;
										flag3 = true;
										break;
									}
									if (flag4)
									{
										flag3 = true;
										break;
									}
									if (!CanReplaceOpcodeSource(ref op2, 0))
									{
										flag3 = true;
										break;
									}
									ReplaceOpcodeSource(ref op2, 0, r);
									flag5 = true;
								}
								if (r6 >= 0 && r6 == r4)
								{
									if (flag2)
									{
										flag2 = false;
										flag3 = true;
										break;
									}
									if (flag4)
									{
										flag3 = true;
										break;
									}
									if (!CanReplaceOpcodeSource(ref op2, 1))
									{
										flag3 = true;
										break;
									}
									ReplaceOpcodeSource(ref op2, 1, r);
									flag5 = true;
								}
								if (r7 >= 0 && r7 == r4)
								{
									if (flag2)
									{
										flag2 = false;
										flag3 = true;
										break;
									}
									if (flag4)
									{
										flag3 = true;
										break;
									}
									if (!CanReplaceOpcodeSource(ref op2, 2))
									{
										flag3 = true;
										break;
									}
									ReplaceOpcodeSource(ref op2, 2, r);
									flag5 = true;
								}
								if (flag5)
								{
									finalInstructions[j] = op2;
								}
							}
							if (GetOpcodeDestRegister(ref op2, out var r8))
							{
								if (r == r8)
								{
									flag2 = true;
								}
								if (r4 == r8)
								{
									flag2 = false;
									flag3 = true;
									if (!flag4)
									{
										canRemove.Add(i);
									}
									break;
								}
							}
							if (op2.Code == OpCodeREnum.Ret && !flag4)
							{
								flag2 = false;
								canRemove.Add(i);
								flag3 = true;
								break;
							}
						}
						if ((flag2 || !flag3) && r4 >= stackRegisterBegin)
						{
							pendingCP.Add(i);
						}
					}
				}
			}
		}
		foreach (CodeBasicBlock block2 in blocks)
		{
			HashSet<int> pendingCP2 = block2.PendingCP;
			if (pendingCP2.Count <= 0)
			{
				continue;
			}
			CodeBasicBlock codeBasicBlock = block2;
			HashSet<CodeBasicBlock> hashSet = new HashSet<CodeBasicBlock>();
			Queue<CodeBasicBlock> queue = new Queue<CodeBasicBlock>();
			foreach (int item in pendingCP2)
			{
				OpCodeR op3 = codeBasicBlock.FinalInstructions[item];
				GetOpcodeDestRegister(ref op3, out var r9);
				GetOpcodeSourceRegister(ref op3, hasReturn, out var r10, out var _, out var _);
				queue.Clear();
				bool flag6 = false;
				bool flag7 = false;
				hashSet.Clear();
				foreach (CodeBasicBlock nextBlock in codeBasicBlock.NextBlocks)
				{
					queue.Enqueue(nextBlock);
				}
				hashSet.Add(codeBasicBlock);
				while (queue.Count > 0)
				{
					CodeBasicBlock codeBasicBlock2 = queue.Dequeue();
					List<OpCodeR> finalInstructions2 = codeBasicBlock2.FinalInstructions;
					bool flag8 = false;
					for (int k = 0; k < finalInstructions2.Count; k++)
					{
						if (codeBasicBlock2 == codeBasicBlock && k == item)
						{
							flag7 = true;
							break;
						}
						OpCodeR op4 = finalInstructions2[k];
						if (op4.Code == OpCodeREnum.InlineStart)
						{
							flag8 = true;
						}
						else if (op4.Code == OpCodeREnum.InlineEnd)
						{
							flag8 = false;
						}
						if (GetOpcodeSourceRegister(ref op4, hasReturn, out var r13, out var r14, out var r15))
						{
							bool flag9 = false;
							if (r13 == r9)
							{
								if (flag8 || codeBasicBlock2.PreviousBlocks.Count > 1)
								{
									flag6 = true;
									break;
								}
								if (!CanReplaceOpcodeSource(ref op4, 0))
								{
									flag6 = true;
									break;
								}
								flag9 = true;
								ReplaceOpcodeSource(ref op4, 0, r10);
							}
							if (r14 == r9)
							{
								if (flag8 || codeBasicBlock2.PreviousBlocks.Count > 1)
								{
									flag6 = true;
									break;
								}
								if (!CanReplaceOpcodeSource(ref op4, 1))
								{
									flag6 = true;
									break;
								}
								flag9 = true;
								ReplaceOpcodeSource(ref op4, 1, r10);
							}
							if (r15 == r9)
							{
								if (flag8 || codeBasicBlock2.PreviousBlocks.Count > 1)
								{
									flag6 = true;
									break;
								}
								if (!CanReplaceOpcodeSource(ref op4, 2))
								{
									flag6 = true;
									break;
								}
								flag9 = true;
								ReplaceOpcodeSource(ref op4, 2, r10);
							}
							if (flag9)
							{
								finalInstructions2[k] = op4;
							}
						}
						if (GetOpcodeDestRegister(ref op4, out var r16) && r16 == r9)
						{
							flag7 = true;
							break;
						}
						if (op4.Code == OpCodeREnum.Ret && !flag8)
						{
							flag7 = true;
							break;
						}
					}
					if (flag6)
					{
						break;
					}
					hashSet.Add(codeBasicBlock2);
					if (flag7)
					{
						continue;
					}
					foreach (CodeBasicBlock nextBlock2 in codeBasicBlock2.NextBlocks)
					{
						if (!hashSet.Contains(nextBlock2))
						{
							queue.Enqueue(nextBlock2);
						}
					}
				}
				if (!flag6)
				{
					codeBasicBlock.CanRemove.Add(item);
				}
			}
			pendingCP2.Clear();
		}
	}

	public static void InlineMethod(CodeBasicBlock block, ILMethod method, RegisterVMSymbolLink symbolLink, ref Dictionary<int, int[]> jumpTables, short baseRegIdx, bool hasReturn)
	{
		List<OpCodeR> finalInstructions = block.FinalInstructions;
		OpCodeR[] bodyRegister = method.BodyRegister;
		OpCodeR item = new OpCodeR
		{
			Code = OpCodeREnum.InlineStart
		};
		finalInstructions.Add(item);
		int count = finalInstructions.Count;
		int num = 0;
		List<int> list = new List<int>();
		if (bodyRegister != null)
		{
			for (int i = 0; i < bodyRegister.Length; i++)
			{
				OpCodeR op = bodyRegister[i];
				short r = 0;
				short r2 = 0;
				short r3 = 0;
				if (GetOpcodeSourceRegister(ref op, hasReturn, out r, out r2, out r3))
				{
					if (r >= 0)
					{
						ReplaceOpcodeSource(ref op, 0, (short)(r + baseRegIdx));
					}
					if (r2 >= 0)
					{
						ReplaceOpcodeSource(ref op, 1, (short)(r2 + baseRegIdx));
					}
					if (r3 >= 0)
					{
						ReplaceOpcodeSource(ref op, 2, (short)(r3 + baseRegIdx));
					}
				}
				if (GetOpcodeDestRegister(ref op, out r) && r >= 0)
				{
					ReplaceOpcodeDest(ref op, (short)(r + baseRegIdx));
				}
				if (op.Code == OpCodeREnum.Ret)
				{
					bool flag = hasReturn && op.Register1 != baseRegIdx;
					if (flag)
					{
						op.Code = OpCodeREnum.Move;
						op.Register2 = op.Register1;
						op.Register1 = baseRegIdx;
						finalInstructions.Add(op);
						num++;
					}
					if (i >= bodyRegister.Length - 1)
					{
						continue;
					}
					if (flag)
					{
						for (int j = count; j < finalInstructions.Count; j++)
						{
							OpCodeR value = finalInstructions[j];
							if (IsBranching(value.Code))
							{
								if (value.Operand > i)
								{
									value.Operand++;
									finalInstructions[j] = value;
								}
							}
							else if (IsIntermediateBranching(value.Code))
							{
								if (value.Operand4 > i)
								{
									value.Operand4++;
									finalInstructions[j] = value;
								}
							}
							else
							{
								if (value.Code != OpCodeREnum.Switch)
								{
									continue;
								}
								int[] array = jumpTables[value.Operand];
								for (int k = 0; k < array.Length; k++)
								{
									if (array[k] > i)
									{
										array[k]++;
									}
								}
							}
						}
					}
					list.Add(finalInstructions.Count);
					op.Code = OpCodeREnum.Br;
					finalInstructions.Add(op);
					continue;
				}
				if (IsBranching(op.Code))
				{
					op.Operand += num;
				}
				if (op.Code == OpCodeREnum.Switch)
				{
					int[] array2 = method.JumpTablesRegister[op.Operand];
					int[] array3 = new int[array2.Length];
					for (int l = 0; l < array2.Length; l++)
					{
						array3[l] = array2[l] + num;
					}
					if (jumpTables == null)
					{
						jumpTables = new Dictionary<int, int[]>();
					}
					op.Operand = array3.GetHashCode();
					jumpTables.Add(op.Operand, array3);
				}
				finalInstructions.Add(op);
			}
		}
		foreach (int item2 in list)
		{
			OpCodeR value2 = finalInstructions[item2];
			value2.Operand = finalInstructions.Count - count;
			finalInstructions[item2] = value2;
		}
		item.Code = OpCodeREnum.InlineEnd;
		finalInstructions.Add(item);
	}

	public static int CleanupRegister(List<OpCodeR> ins, int locRegStart, bool hasReturn)
	{
		short num = (short)locRegStart;
		HashSet<short> hashSet = new HashSet<short>();
		for (short num2 = 0; num2 < locRegStart; num2++)
		{
			hashSet.Add(num2);
		}
		for (int i = 0; i < ins.Count; i++)
		{
			OpCodeR op = ins[i];
			if (GetOpcodeSourceRegister(ref op, hasReturn, out var r, out var r2, out var r3))
			{
				if (r >= 0)
				{
					if (r > num)
					{
						num = r;
					}
					hashSet.Add(r);
				}
				if (r2 >= 0)
				{
					if (r2 > num)
					{
						num = r2;
					}
					hashSet.Add(r2);
				}
				if (r3 >= 0)
				{
					if (r3 > num)
					{
						num = r3;
					}
					hashSet.Add(r3);
				}
			}
			if (GetOpcodeDestRegister(ref op, out var r4) && r4 >= 0)
			{
				if (r4 > num)
				{
					num = r4;
				}
				hashSet.Add(r4);
			}
		}
		List<short> list = new List<short>();
		for (short num3 = 0; num3 <= num; num3++)
		{
			if (!hashSet.Contains(num3))
			{
				list.Add(num3);
			}
		}
		for (short num4 = 0; num4 < list.Count; num4++)
		{
			short num5 = (short)(list[num4] - num4);
			for (int j = 0; j < ins.Count; j++)
			{
				OpCodeR op2 = ins[j];
				bool flag = false;
				if (GetOpcodeSourceRegister(ref op2, hasReturn, out var r5, out var r6, out var r7))
				{
					if (r5 > num5)
					{
						ReplaceOpcodeSource(ref op2, 0, (short)(r5 - 1));
						flag = true;
					}
					if (r6 > num5)
					{
						ReplaceOpcodeSource(ref op2, 1, (short)(r6 - 1));
						flag = true;
					}
					if (r7 > num5)
					{
						ReplaceOpcodeSource(ref op2, 2, (short)(r7 - 1));
						flag = true;
					}
				}
				if (GetOpcodeDestRegister(ref op2, out var r8) && r8 > num5)
				{
					ReplaceOpcodeDest(ref op2, (short)(r8 - 1));
					flag = true;
				}
				if (flag)
				{
					ins[j] = op2;
				}
			}
		}
		return num - list.Count + 1;
	}

	public static bool SupportIntemediateValue(OpCodeREnum op)
	{
		switch (op)
		{
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
		case OpCodeREnum.Add:
		case OpCodeREnum.Sub:
		case OpCodeREnum.Mul:
		case OpCodeREnum.Div:
		case OpCodeREnum.Rem:
		case OpCodeREnum.Rem_Un:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Shl:
		case OpCodeREnum.Shr:
		case OpCodeREnum.Shr_Un:
		case OpCodeREnum.Ceq:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
			return true;
		default:
			return false;
		}
	}

	public static void ReplaceRegisterWithConstant(ref OpCodeR op, ref OpCodeR constant)
	{
		switch (op.Code)
		{
		case OpCodeREnum.Ceqi:
		case OpCodeREnum.Cgti:
		case OpCodeREnum.Cgti_Un:
		case OpCodeREnum.Clti:
		case OpCodeREnum.Clti_Un:
		case OpCodeREnum.Addi:
		case OpCodeREnum.Subi:
		case OpCodeREnum.Muli:
		case OpCodeREnum.Divi:
		case OpCodeREnum.Remi:
		case OpCodeREnum.Remi_Un:
		case OpCodeREnum.Andi:
		case OpCodeREnum.Ori:
		case OpCodeREnum.Xori:
		case OpCodeREnum.Shli:
		case OpCodeREnum.Shri:
		case OpCodeREnum.Shri_Un:
			op.Register3 = 0;
			break;
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Beqi:
		case OpCodeREnum.Bgei:
		case OpCodeREnum.Bgti:
		case OpCodeREnum.Blei:
		case OpCodeREnum.Blti:
		case OpCodeREnum.Bnei_Un:
		case OpCodeREnum.Bgei_Un:
		case OpCodeREnum.Bgti_Un:
		case OpCodeREnum.Blei_Un:
		case OpCodeREnum.Blti_Un:
			op.Register2 = 0;
			op.Operand4 = op.Operand;
			break;
		}
		switch (constant.Code)
		{
		case OpCodeREnum.Ldc_I4_S:
		case OpCodeREnum.Ldc_I4:
			op.Operand = constant.Operand;
			break;
		case OpCodeREnum.Ldc_I4_0:
			op.Operand = 0;
			break;
		case OpCodeREnum.Ldc_I4_1:
			op.Operand = 1;
			break;
		case OpCodeREnum.Ldc_I4_2:
			op.Operand = 2;
			break;
		case OpCodeREnum.Ldc_I4_3:
			op.Operand = 3;
			break;
		case OpCodeREnum.Ldc_I4_4:
			op.Operand = 4;
			break;
		case OpCodeREnum.Ldc_I4_5:
			op.Operand = 5;
			break;
		case OpCodeREnum.Ldc_I4_6:
			op.Operand = 6;
			break;
		case OpCodeREnum.Ldc_I4_7:
			op.Operand = 7;
			break;
		case OpCodeREnum.Ldc_I4_8:
			op.Operand = 8;
			break;
		case OpCodeREnum.Ldc_I4_M1:
			op.Operand = -1;
			break;
		case OpCodeREnum.Ldc_I8:
			op.OperandLong = constant.OperandLong;
			break;
		case OpCodeREnum.Ldc_R4:
			op.OperandFloat = constant.OperandFloat;
			break;
		case OpCodeREnum.Ldc_R8:
			op.OperandDouble = constant.OperandDouble;
			break;
		}
	}

	public static OpCodeREnum GetIntemediateValueOpcode(OpCodeREnum op)
	{
		switch (op)
		{
		case OpCodeREnum.Add:
			return OpCodeREnum.Addi;
		case OpCodeREnum.Sub:
			return OpCodeREnum.Subi;
		case OpCodeREnum.Mul:
			return OpCodeREnum.Muli;
		case OpCodeREnum.Div:
			return OpCodeREnum.Divi;
		case OpCodeREnum.Rem:
			return OpCodeREnum.Remi;
		case OpCodeREnum.Rem_Un:
			return OpCodeREnum.Remi_Un;
		case OpCodeREnum.And:
			return OpCodeREnum.Andi;
		case OpCodeREnum.Or:
			return OpCodeREnum.Ori;
		case OpCodeREnum.Xor:
			return OpCodeREnum.Xori;
		case OpCodeREnum.Shl:
			return OpCodeREnum.Shli;
		case OpCodeREnum.Shr:
			return OpCodeREnum.Shri;
		case OpCodeREnum.Shr_Un:
			return OpCodeREnum.Shri_Un;
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Beq:
			return OpCodeREnum.Beqi;
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bge:
			return OpCodeREnum.Bgei;
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bge_Un:
			return OpCodeREnum.Bgei_Un;
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Bgt:
			return OpCodeREnum.Bgti;
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Bgt_Un:
			return OpCodeREnum.Bgti_Un;
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bne_Un:
			return OpCodeREnum.Bnei_Un;
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Ble:
			return OpCodeREnum.Blei;
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Ble_Un:
			return OpCodeREnum.Blei_Un;
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Blt:
			return OpCodeREnum.Blti;
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Blt_Un:
			return OpCodeREnum.Blti_Un;
		case OpCodeREnum.Ceq:
			return OpCodeREnum.Ceqi;
		case OpCodeREnum.Cgt:
			return OpCodeREnum.Cgti;
		case OpCodeREnum.Cgt_Un:
			return OpCodeREnum.Cgti_Un;
		case OpCodeREnum.Clt:
			return OpCodeREnum.Clti;
		case OpCodeREnum.Clt_Un:
			return OpCodeREnum.Clti_Un;
		default:
			throw new NotSupportedException();
		}
	}

	public static bool SupportOperandSwap(OpCodeREnum op)
	{
		switch (op)
		{
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Add:
		case OpCodeREnum.Mul:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Ceq:
			return true;
		default:
			return false;
		}
	}

	public static bool HasInverseOpcode(OpCodeREnum op)
	{
		switch (op)
		{
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
			return true;
		default:
			return false;
		}
	}

	public static OpCodeREnum GetInverseOpcode(OpCodeREnum op)
	{
		switch (op)
		{
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bge:
			return OpCodeREnum.Ble;
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bge_Un:
			return OpCodeREnum.Ble_Un;
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Bgt:
			return OpCodeREnum.Blt;
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Bgt_Un:
			return OpCodeREnum.Blt_Un;
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Ble:
			return OpCodeREnum.Bge;
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Ble_Un:
			return OpCodeREnum.Bge_Un;
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Blt:
			return OpCodeREnum.Bgt;
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Blt_Un:
			return OpCodeREnum.Bgt_Un;
		case OpCodeREnum.Cgt:
			return OpCodeREnum.Clt;
		case OpCodeREnum.Clt:
			return OpCodeREnum.Cgt;
		case OpCodeREnum.Clt_Un:
			return OpCodeREnum.Cgt_Un;
		default:
			throw new NotSupportedException();
		}
	}

	public static bool IsLoadConstant(OpCodeREnum op)
	{
		if ((uint)(op - 21) <= 14u)
		{
			return true;
		}
		return false;
	}

	public static bool IsBranching(OpCodeREnum op)
	{
		if ((uint)(op - 42) <= 25u)
		{
			return true;
		}
		return false;
	}

	public static bool IsIntermediateBranching(OpCodeREnum op)
	{
		if (op == OpCodeREnum.Beq_S || (uint)(op - 223) <= 9u)
		{
			return true;
		}
		return false;
	}

	public static bool GetOpcodeSourceRegister(ref OpCodeR op, bool hasReturn, out short r1, out short r2, out short r3)
	{
		r1 = -1;
		r2 = -1;
		r3 = -1;
		switch (op.Code)
		{
		case OpCodeREnum.Ldarg_S:
		case OpCodeREnum.Ldarga_S:
		case OpCodeREnum.Ldloca_S:
		case OpCodeREnum.Ldind_I1:
		case OpCodeREnum.Ldind_U1:
		case OpCodeREnum.Ldind_I2:
		case OpCodeREnum.Ldind_U2:
		case OpCodeREnum.Ldind_I4:
		case OpCodeREnum.Ldind_U4:
		case OpCodeREnum.Ldind_I8:
		case OpCodeREnum.Ldind_I:
		case OpCodeREnum.Ldind_R4:
		case OpCodeREnum.Ldind_R8:
		case OpCodeREnum.Ldind_Ref:
		case OpCodeREnum.Neg:
		case OpCodeREnum.Not:
		case OpCodeREnum.Conv_I1:
		case OpCodeREnum.Conv_I2:
		case OpCodeREnum.Conv_I4:
		case OpCodeREnum.Conv_I8:
		case OpCodeREnum.Conv_R4:
		case OpCodeREnum.Conv_R8:
		case OpCodeREnum.Conv_U4:
		case OpCodeREnum.Conv_U8:
		case OpCodeREnum.Ldobj:
		case OpCodeREnum.Castclass:
		case OpCodeREnum.Isinst:
		case OpCodeREnum.Conv_R_Un:
		case OpCodeREnum.Unbox:
		case OpCodeREnum.Ldfld:
		case OpCodeREnum.Ldflda:
		case OpCodeREnum.Conv_Ovf_I1_Un:
		case OpCodeREnum.Conv_Ovf_I2_Un:
		case OpCodeREnum.Conv_Ovf_I4_Un:
		case OpCodeREnum.Conv_Ovf_I8_Un:
		case OpCodeREnum.Conv_Ovf_U1_Un:
		case OpCodeREnum.Conv_Ovf_U2_Un:
		case OpCodeREnum.Conv_Ovf_U4_Un:
		case OpCodeREnum.Conv_Ovf_U8_Un:
		case OpCodeREnum.Conv_Ovf_I_Un:
		case OpCodeREnum.Conv_Ovf_U_Un:
		case OpCodeREnum.Box:
		case OpCodeREnum.Newarr:
		case OpCodeREnum.Ldlen:
		case OpCodeREnum.Unbox_Any:
		case OpCodeREnum.Conv_Ovf_I1:
		case OpCodeREnum.Conv_Ovf_U1:
		case OpCodeREnum.Conv_Ovf_I2:
		case OpCodeREnum.Conv_Ovf_U2:
		case OpCodeREnum.Conv_Ovf_I4:
		case OpCodeREnum.Conv_Ovf_U4:
		case OpCodeREnum.Conv_Ovf_I8:
		case OpCodeREnum.Conv_Ovf_U8:
		case OpCodeREnum.Conv_U2:
		case OpCodeREnum.Conv_U1:
		case OpCodeREnum.Conv_I:
		case OpCodeREnum.Conv_Ovf_I:
		case OpCodeREnum.Conv_Ovf_U:
		case OpCodeREnum.Conv_U:
		case OpCodeREnum.Ldvirtftn:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
		case OpCodeREnum.Move:
			r1 = op.Register2;
			return true;
		case OpCodeREnum.Stind_Ref:
		case OpCodeREnum.Stind_I1:
		case OpCodeREnum.Stind_I2:
		case OpCodeREnum.Stind_I4:
		case OpCodeREnum.Stind_I8:
		case OpCodeREnum.Stind_R4:
		case OpCodeREnum.Stind_R8:
		case OpCodeREnum.Stfld:
		case OpCodeREnum.Stobj:
		case OpCodeREnum.Stind_I:
			r1 = op.Register1;
			r2 = op.Register2;
			return true;
		case OpCodeREnum.Ldnull:
		case OpCodeREnum.Ldc_I4_M1:
		case OpCodeREnum.Ldc_I4_0:
		case OpCodeREnum.Ldc_I4_1:
		case OpCodeREnum.Ldc_I4_2:
		case OpCodeREnum.Ldc_I4_3:
		case OpCodeREnum.Ldc_I4_4:
		case OpCodeREnum.Ldc_I4_5:
		case OpCodeREnum.Ldc_I4_6:
		case OpCodeREnum.Ldc_I4_7:
		case OpCodeREnum.Ldc_I4_8:
		case OpCodeREnum.Ldc_I4_S:
		case OpCodeREnum.Ldc_I4:
		case OpCodeREnum.Ldc_I8:
		case OpCodeREnum.Ldc_R4:
		case OpCodeREnum.Ldc_R8:
		case OpCodeREnum.Ldstr:
		case OpCodeREnum.Ldsfld:
		case OpCodeREnum.Ldsflda:
		case OpCodeREnum.Ldtoken:
		case OpCodeREnum.Ldftn:
		case OpCodeREnum.Constrained:
			return false;
		case OpCodeREnum.Call:
		case OpCodeREnum.Callvirt:
		case OpCodeREnum.Newobj:
			r1 = op.Register2;
			r2 = op.Register3;
			r3 = op.Register4;
			return true;
		case OpCodeREnum.Nop:
		case OpCodeREnum.Br_S:
		case OpCodeREnum.Br:
		case OpCodeREnum.Endfinally:
		case OpCodeREnum.Leave:
		case OpCodeREnum.Leave_S:
		case OpCodeREnum.Volatile:
		case OpCodeREnum.Rethrow:
		case OpCodeREnum.Readonly:
		case OpCodeREnum.InlineStart:
		case OpCodeREnum.InlineEnd:
			return false;
		case OpCodeREnum.Brfalse_S:
		case OpCodeREnum.Brtrue_S:
		case OpCodeREnum.Brfalse:
		case OpCodeREnum.Brtrue:
		case OpCodeREnum.Switch:
		case OpCodeREnum.Throw:
		case OpCodeREnum.Stsfld:
		case OpCodeREnum.Initobj:
		case OpCodeREnum.Push:
		case OpCodeREnum.Beqi:
		case OpCodeREnum.Bgei:
		case OpCodeREnum.Bgti:
		case OpCodeREnum.Blei:
		case OpCodeREnum.Blti:
		case OpCodeREnum.Bnei_Un:
		case OpCodeREnum.Bgei_Un:
		case OpCodeREnum.Bgti_Un:
		case OpCodeREnum.Blei_Un:
		case OpCodeREnum.Blti_Un:
			r1 = op.Register1;
			return true;
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
			r1 = op.Register1;
			r2 = op.Register2;
			return true;
		case OpCodeREnum.Add:
		case OpCodeREnum.Sub:
		case OpCodeREnum.Mul:
		case OpCodeREnum.Div:
		case OpCodeREnum.Div_Un:
		case OpCodeREnum.Rem:
		case OpCodeREnum.Rem_Un:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Shl:
		case OpCodeREnum.Shr:
		case OpCodeREnum.Shr_Un:
		case OpCodeREnum.Ldelema:
		case OpCodeREnum.Ldelem_I1:
		case OpCodeREnum.Ldelem_U1:
		case OpCodeREnum.Ldelem_I2:
		case OpCodeREnum.Ldelem_U2:
		case OpCodeREnum.Ldelem_I4:
		case OpCodeREnum.Ldelem_U4:
		case OpCodeREnum.Ldelem_I8:
		case OpCodeREnum.Ldelem_R4:
		case OpCodeREnum.Ldelem_R8:
		case OpCodeREnum.Ldelem_Ref:
		case OpCodeREnum.Ldelem_Any:
		case OpCodeREnum.Add_Ovf:
		case OpCodeREnum.Add_Ovf_Un:
		case OpCodeREnum.Mul_Ovf:
		case OpCodeREnum.Mul_Ovf_Un:
		case OpCodeREnum.Sub_Ovf:
		case OpCodeREnum.Sub_Ovf_Un:
		case OpCodeREnum.Ceq:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
			r1 = op.Register2;
			r2 = op.Register3;
			return true;
		case OpCodeREnum.Ceqi:
		case OpCodeREnum.Cgti:
		case OpCodeREnum.Cgti_Un:
		case OpCodeREnum.Clti:
		case OpCodeREnum.Clti_Un:
		case OpCodeREnum.Addi:
		case OpCodeREnum.Subi:
		case OpCodeREnum.Muli:
		case OpCodeREnum.Divi:
		case OpCodeREnum.Remi:
		case OpCodeREnum.Remi_Un:
		case OpCodeREnum.Andi:
		case OpCodeREnum.Ori:
		case OpCodeREnum.Xori:
		case OpCodeREnum.Shli:
		case OpCodeREnum.Shri:
		case OpCodeREnum.Shri_Un:
			r1 = op.Register2;
			return true;
		case OpCodeREnum.Stelem_I:
		case OpCodeREnum.Stelem_I1:
		case OpCodeREnum.Stelem_I2:
		case OpCodeREnum.Stelem_I4:
		case OpCodeREnum.Stelem_I8:
		case OpCodeREnum.Stelem_R4:
		case OpCodeREnum.Stelem_R8:
		case OpCodeREnum.Stelem_Ref:
		case OpCodeREnum.Stelem_Any:
			r1 = op.Register1;
			r2 = op.Register2;
			r3 = op.Register3;
			return true;
		case OpCodeREnum.Ret:
			if (hasReturn)
			{
				r1 = op.Register1;
				return true;
			}
			return false;
		default:
			throw new NotImplementedException();
		}
	}

	public static bool GetOpcodeDestRegister(ref OpCodeR op, out short r1)
	{
		r1 = -1;
		switch (op.Code)
		{
		case OpCodeREnum.Ldarg_S:
		case OpCodeREnum.Ldarga_S:
		case OpCodeREnum.Ldloca_S:
		case OpCodeREnum.Ldnull:
		case OpCodeREnum.Ldc_I4_M1:
		case OpCodeREnum.Ldc_I4_0:
		case OpCodeREnum.Ldc_I4_1:
		case OpCodeREnum.Ldc_I4_2:
		case OpCodeREnum.Ldc_I4_3:
		case OpCodeREnum.Ldc_I4_4:
		case OpCodeREnum.Ldc_I4_5:
		case OpCodeREnum.Ldc_I4_6:
		case OpCodeREnum.Ldc_I4_7:
		case OpCodeREnum.Ldc_I4_8:
		case OpCodeREnum.Ldc_I4_S:
		case OpCodeREnum.Ldc_I4:
		case OpCodeREnum.Ldc_I8:
		case OpCodeREnum.Ldc_R4:
		case OpCodeREnum.Ldc_R8:
		case OpCodeREnum.Call:
		case OpCodeREnum.Ldind_I1:
		case OpCodeREnum.Ldind_U1:
		case OpCodeREnum.Ldind_I2:
		case OpCodeREnum.Ldind_U2:
		case OpCodeREnum.Ldind_I4:
		case OpCodeREnum.Ldind_U4:
		case OpCodeREnum.Ldind_I8:
		case OpCodeREnum.Ldind_I:
		case OpCodeREnum.Ldind_R4:
		case OpCodeREnum.Ldind_R8:
		case OpCodeREnum.Ldind_Ref:
		case OpCodeREnum.Neg:
		case OpCodeREnum.Not:
		case OpCodeREnum.Conv_I1:
		case OpCodeREnum.Conv_I2:
		case OpCodeREnum.Conv_I4:
		case OpCodeREnum.Conv_I8:
		case OpCodeREnum.Conv_R4:
		case OpCodeREnum.Conv_R8:
		case OpCodeREnum.Conv_U4:
		case OpCodeREnum.Conv_U8:
		case OpCodeREnum.Callvirt:
		case OpCodeREnum.Ldobj:
		case OpCodeREnum.Ldstr:
		case OpCodeREnum.Newobj:
		case OpCodeREnum.Castclass:
		case OpCodeREnum.Isinst:
		case OpCodeREnum.Conv_R_Un:
		case OpCodeREnum.Unbox:
		case OpCodeREnum.Ldfld:
		case OpCodeREnum.Ldflda:
		case OpCodeREnum.Ldsfld:
		case OpCodeREnum.Ldsflda:
		case OpCodeREnum.Conv_Ovf_I1_Un:
		case OpCodeREnum.Conv_Ovf_I2_Un:
		case OpCodeREnum.Conv_Ovf_I4_Un:
		case OpCodeREnum.Conv_Ovf_I8_Un:
		case OpCodeREnum.Conv_Ovf_U1_Un:
		case OpCodeREnum.Conv_Ovf_U2_Un:
		case OpCodeREnum.Conv_Ovf_U4_Un:
		case OpCodeREnum.Conv_Ovf_U8_Un:
		case OpCodeREnum.Conv_Ovf_I_Un:
		case OpCodeREnum.Conv_Ovf_U_Un:
		case OpCodeREnum.Box:
		case OpCodeREnum.Newarr:
		case OpCodeREnum.Ldlen:
		case OpCodeREnum.Ldelema:
		case OpCodeREnum.Ldelem_I1:
		case OpCodeREnum.Ldelem_U1:
		case OpCodeREnum.Ldelem_I2:
		case OpCodeREnum.Ldelem_U2:
		case OpCodeREnum.Ldelem_I4:
		case OpCodeREnum.Ldelem_U4:
		case OpCodeREnum.Ldelem_I8:
		case OpCodeREnum.Ldelem_R4:
		case OpCodeREnum.Ldelem_R8:
		case OpCodeREnum.Ldelem_Ref:
		case OpCodeREnum.Ldelem_Any:
		case OpCodeREnum.Unbox_Any:
		case OpCodeREnum.Conv_Ovf_I1:
		case OpCodeREnum.Conv_Ovf_U1:
		case OpCodeREnum.Conv_Ovf_I2:
		case OpCodeREnum.Conv_Ovf_U2:
		case OpCodeREnum.Conv_Ovf_I4:
		case OpCodeREnum.Conv_Ovf_U4:
		case OpCodeREnum.Conv_Ovf_I8:
		case OpCodeREnum.Conv_Ovf_U8:
		case OpCodeREnum.Ldtoken:
		case OpCodeREnum.Conv_U2:
		case OpCodeREnum.Conv_U1:
		case OpCodeREnum.Conv_I:
		case OpCodeREnum.Conv_Ovf_I:
		case OpCodeREnum.Conv_Ovf_U:
		case OpCodeREnum.Conv_U:
		case OpCodeREnum.Ldftn:
		case OpCodeREnum.Ldvirtftn:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
		case OpCodeREnum.Move:
			r1 = op.Register1;
			return true;
		case OpCodeREnum.Nop:
		case OpCodeREnum.Ret:
		case OpCodeREnum.Br_S:
		case OpCodeREnum.Brfalse_S:
		case OpCodeREnum.Brtrue_S:
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Br:
		case OpCodeREnum.Brfalse:
		case OpCodeREnum.Brtrue:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
		case OpCodeREnum.Switch:
		case OpCodeREnum.Stind_Ref:
		case OpCodeREnum.Stind_I1:
		case OpCodeREnum.Stind_I2:
		case OpCodeREnum.Stind_I4:
		case OpCodeREnum.Stind_I8:
		case OpCodeREnum.Stind_R4:
		case OpCodeREnum.Stind_R8:
		case OpCodeREnum.Throw:
		case OpCodeREnum.Stfld:
		case OpCodeREnum.Stsfld:
		case OpCodeREnum.Stobj:
		case OpCodeREnum.Stelem_I:
		case OpCodeREnum.Stelem_I1:
		case OpCodeREnum.Stelem_I2:
		case OpCodeREnum.Stelem_I4:
		case OpCodeREnum.Stelem_I8:
		case OpCodeREnum.Stelem_R4:
		case OpCodeREnum.Stelem_R8:
		case OpCodeREnum.Stelem_Ref:
		case OpCodeREnum.Stelem_Any:
		case OpCodeREnum.Endfinally:
		case OpCodeREnum.Leave:
		case OpCodeREnum.Leave_S:
		case OpCodeREnum.Stind_I:
		case OpCodeREnum.Volatile:
		case OpCodeREnum.Initobj:
		case OpCodeREnum.Constrained:
		case OpCodeREnum.Rethrow:
		case OpCodeREnum.Readonly:
		case OpCodeREnum.Push:
		case OpCodeREnum.InlineStart:
		case OpCodeREnum.InlineEnd:
		case OpCodeREnum.Beqi:
		case OpCodeREnum.Bgei:
		case OpCodeREnum.Bgti:
		case OpCodeREnum.Blei:
		case OpCodeREnum.Blti:
		case OpCodeREnum.Bnei_Un:
		case OpCodeREnum.Bgei_Un:
		case OpCodeREnum.Bgti_Un:
		case OpCodeREnum.Blei_Un:
		case OpCodeREnum.Blti_Un:
			return false;
		case OpCodeREnum.Add:
		case OpCodeREnum.Sub:
		case OpCodeREnum.Mul:
		case OpCodeREnum.Div:
		case OpCodeREnum.Div_Un:
		case OpCodeREnum.Rem:
		case OpCodeREnum.Rem_Un:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Shl:
		case OpCodeREnum.Shr:
		case OpCodeREnum.Shr_Un:
		case OpCodeREnum.Add_Ovf:
		case OpCodeREnum.Add_Ovf_Un:
		case OpCodeREnum.Mul_Ovf:
		case OpCodeREnum.Mul_Ovf_Un:
		case OpCodeREnum.Sub_Ovf:
		case OpCodeREnum.Sub_Ovf_Un:
		case OpCodeREnum.Ceq:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
		case OpCodeREnum.Ceqi:
		case OpCodeREnum.Cgti:
		case OpCodeREnum.Cgti_Un:
		case OpCodeREnum.Clti:
		case OpCodeREnum.Clti_Un:
		case OpCodeREnum.Addi:
		case OpCodeREnum.Subi:
		case OpCodeREnum.Muli:
		case OpCodeREnum.Divi:
		case OpCodeREnum.Remi:
		case OpCodeREnum.Remi_Un:
		case OpCodeREnum.Andi:
		case OpCodeREnum.Ori:
		case OpCodeREnum.Xori:
		case OpCodeREnum.Shli:
		case OpCodeREnum.Shri:
		case OpCodeREnum.Shri_Un:
			r1 = op.Register1;
			return true;
		default:
			throw new NotImplementedException();
		}
	}

	private static bool CanReplaceOpcodeSource(ref OpCodeR op, int idx)
	{
		switch (op.Code)
		{
		case OpCodeREnum.Ldarga_S:
		case OpCodeREnum.Ldloca_S:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
			return false;
		default:
			return true;
		}
	}

	private static void ReplaceOpcodeSource(ref OpCodeR op, int idx, short src)
	{
		switch (op.Code)
		{
		case OpCodeREnum.Ldarg_S:
		case OpCodeREnum.Ldarga_S:
		case OpCodeREnum.Ldloca_S:
		case OpCodeREnum.Ldind_I1:
		case OpCodeREnum.Ldind_U1:
		case OpCodeREnum.Ldind_I2:
		case OpCodeREnum.Ldind_U2:
		case OpCodeREnum.Ldind_I4:
		case OpCodeREnum.Ldind_U4:
		case OpCodeREnum.Ldind_I8:
		case OpCodeREnum.Ldind_I:
		case OpCodeREnum.Ldind_R4:
		case OpCodeREnum.Ldind_R8:
		case OpCodeREnum.Ldind_Ref:
		case OpCodeREnum.Neg:
		case OpCodeREnum.Not:
		case OpCodeREnum.Conv_I1:
		case OpCodeREnum.Conv_I2:
		case OpCodeREnum.Conv_I4:
		case OpCodeREnum.Conv_I8:
		case OpCodeREnum.Conv_R4:
		case OpCodeREnum.Conv_R8:
		case OpCodeREnum.Conv_U4:
		case OpCodeREnum.Conv_U8:
		case OpCodeREnum.Ldobj:
		case OpCodeREnum.Castclass:
		case OpCodeREnum.Isinst:
		case OpCodeREnum.Conv_R_Un:
		case OpCodeREnum.Unbox:
		case OpCodeREnum.Ldfld:
		case OpCodeREnum.Ldflda:
		case OpCodeREnum.Conv_Ovf_I1_Un:
		case OpCodeREnum.Conv_Ovf_I2_Un:
		case OpCodeREnum.Conv_Ovf_I4_Un:
		case OpCodeREnum.Conv_Ovf_I8_Un:
		case OpCodeREnum.Conv_Ovf_U1_Un:
		case OpCodeREnum.Conv_Ovf_U2_Un:
		case OpCodeREnum.Conv_Ovf_U4_Un:
		case OpCodeREnum.Conv_Ovf_U8_Un:
		case OpCodeREnum.Conv_Ovf_I_Un:
		case OpCodeREnum.Conv_Ovf_U_Un:
		case OpCodeREnum.Box:
		case OpCodeREnum.Newarr:
		case OpCodeREnum.Ldlen:
		case OpCodeREnum.Unbox_Any:
		case OpCodeREnum.Conv_Ovf_I1:
		case OpCodeREnum.Conv_Ovf_U1:
		case OpCodeREnum.Conv_Ovf_I2:
		case OpCodeREnum.Conv_Ovf_U2:
		case OpCodeREnum.Conv_Ovf_I4:
		case OpCodeREnum.Conv_Ovf_U4:
		case OpCodeREnum.Conv_Ovf_I8:
		case OpCodeREnum.Conv_Ovf_U8:
		case OpCodeREnum.Conv_U2:
		case OpCodeREnum.Conv_U1:
		case OpCodeREnum.Conv_I:
		case OpCodeREnum.Conv_Ovf_I:
		case OpCodeREnum.Conv_Ovf_U:
		case OpCodeREnum.Conv_U:
		case OpCodeREnum.Ldvirtftn:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
		case OpCodeREnum.Move:
		case OpCodeREnum.Ceqi:
		case OpCodeREnum.Cgti:
		case OpCodeREnum.Cgti_Un:
		case OpCodeREnum.Clti:
		case OpCodeREnum.Clti_Un:
		case OpCodeREnum.Addi:
		case OpCodeREnum.Subi:
		case OpCodeREnum.Muli:
		case OpCodeREnum.Divi:
		case OpCodeREnum.Remi:
		case OpCodeREnum.Remi_Un:
		case OpCodeREnum.Andi:
		case OpCodeREnum.Ori:
		case OpCodeREnum.Xori:
		case OpCodeREnum.Shli:
		case OpCodeREnum.Shri:
		case OpCodeREnum.Shri_Un:
			op.Register2 = src;
			break;
		case OpCodeREnum.Stind_Ref:
		case OpCodeREnum.Stind_I1:
		case OpCodeREnum.Stind_I2:
		case OpCodeREnum.Stind_I4:
		case OpCodeREnum.Stind_I8:
		case OpCodeREnum.Stind_R4:
		case OpCodeREnum.Stind_R8:
		case OpCodeREnum.Stfld:
		case OpCodeREnum.Stobj:
		case OpCodeREnum.Stind_I:
			switch (idx)
			{
			case 0:
				op.Register1 = src;
				break;
			case 1:
				op.Register2 = src;
				break;
			default:
				throw new NotSupportedException();
			}
			break;
		case OpCodeREnum.Add:
		case OpCodeREnum.Sub:
		case OpCodeREnum.Mul:
		case OpCodeREnum.Div:
		case OpCodeREnum.Div_Un:
		case OpCodeREnum.Rem:
		case OpCodeREnum.Rem_Un:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Shl:
		case OpCodeREnum.Shr:
		case OpCodeREnum.Shr_Un:
		case OpCodeREnum.Ldelema:
		case OpCodeREnum.Ldelem_I1:
		case OpCodeREnum.Ldelem_U1:
		case OpCodeREnum.Ldelem_I2:
		case OpCodeREnum.Ldelem_U2:
		case OpCodeREnum.Ldelem_I4:
		case OpCodeREnum.Ldelem_U4:
		case OpCodeREnum.Ldelem_I8:
		case OpCodeREnum.Ldelem_R4:
		case OpCodeREnum.Ldelem_R8:
		case OpCodeREnum.Ldelem_Ref:
		case OpCodeREnum.Ldelem_Any:
		case OpCodeREnum.Add_Ovf:
		case OpCodeREnum.Add_Ovf_Un:
		case OpCodeREnum.Mul_Ovf:
		case OpCodeREnum.Mul_Ovf_Un:
		case OpCodeREnum.Sub_Ovf:
		case OpCodeREnum.Sub_Ovf_Un:
		case OpCodeREnum.Ceq:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
			switch (idx)
			{
			case 0:
				op.Register2 = src;
				break;
			case 1:
				op.Register3 = src;
				break;
			default:
				throw new NotSupportedException();
			}
			break;
		case OpCodeREnum.Stelem_I:
		case OpCodeREnum.Stelem_I1:
		case OpCodeREnum.Stelem_I2:
		case OpCodeREnum.Stelem_I4:
		case OpCodeREnum.Stelem_I8:
		case OpCodeREnum.Stelem_R4:
		case OpCodeREnum.Stelem_R8:
		case OpCodeREnum.Stelem_Ref:
		case OpCodeREnum.Stelem_Any:
			switch (idx)
			{
			case 0:
				op.Register1 = src;
				break;
			case 1:
				op.Register2 = src;
				break;
			case 2:
				op.Register3 = src;
				break;
			default:
				throw new NotSupportedException();
			}
			break;
		case OpCodeREnum.Call:
		case OpCodeREnum.Callvirt:
		case OpCodeREnum.Newobj:
			switch (idx)
			{
			case 0:
				op.Register2 = src;
				break;
			case 1:
				op.Register3 = src;
				break;
			case 2:
				op.Register4 = src;
				break;
			default:
				throw new NotSupportedException();
			}
			break;
		case OpCodeREnum.Brfalse_S:
		case OpCodeREnum.Brtrue_S:
		case OpCodeREnum.Brfalse:
		case OpCodeREnum.Brtrue:
		case OpCodeREnum.Switch:
		case OpCodeREnum.Throw:
		case OpCodeREnum.Stsfld:
		case OpCodeREnum.Initobj:
		case OpCodeREnum.Push:
		case OpCodeREnum.Beqi:
		case OpCodeREnum.Bgei:
		case OpCodeREnum.Bgti:
		case OpCodeREnum.Blei:
		case OpCodeREnum.Blti:
		case OpCodeREnum.Bnei_Un:
		case OpCodeREnum.Bgei_Un:
		case OpCodeREnum.Bgti_Un:
		case OpCodeREnum.Blei_Un:
		case OpCodeREnum.Blti_Un:
			op.Register1 = src;
			break;
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
			switch (idx)
			{
			case 0:
				op.Register1 = src;
				break;
			case 1:
				op.Register2 = src;
				break;
			default:
				throw new NotSupportedException();
			}
			break;
		case OpCodeREnum.Ret:
			op.Register1 = src;
			break;
		default:
			throw new NotImplementedException();
		}
	}

	private static void ReplaceOpcodeDest(ref OpCodeR op, short dst)
	{
		switch (op.Code)
		{
		case OpCodeREnum.Ldarg_S:
		case OpCodeREnum.Ldarga_S:
		case OpCodeREnum.Ldloca_S:
		case OpCodeREnum.Ldnull:
		case OpCodeREnum.Ldc_I4_M1:
		case OpCodeREnum.Ldc_I4_0:
		case OpCodeREnum.Ldc_I4_1:
		case OpCodeREnum.Ldc_I4_2:
		case OpCodeREnum.Ldc_I4_3:
		case OpCodeREnum.Ldc_I4_4:
		case OpCodeREnum.Ldc_I4_5:
		case OpCodeREnum.Ldc_I4_6:
		case OpCodeREnum.Ldc_I4_7:
		case OpCodeREnum.Ldc_I4_8:
		case OpCodeREnum.Ldc_I4_S:
		case OpCodeREnum.Ldc_I4:
		case OpCodeREnum.Ldc_I8:
		case OpCodeREnum.Ldc_R4:
		case OpCodeREnum.Ldc_R8:
		case OpCodeREnum.Call:
		case OpCodeREnum.Ldind_I1:
		case OpCodeREnum.Ldind_U1:
		case OpCodeREnum.Ldind_I2:
		case OpCodeREnum.Ldind_U2:
		case OpCodeREnum.Ldind_I4:
		case OpCodeREnum.Ldind_U4:
		case OpCodeREnum.Ldind_I8:
		case OpCodeREnum.Ldind_I:
		case OpCodeREnum.Ldind_R4:
		case OpCodeREnum.Ldind_R8:
		case OpCodeREnum.Ldind_Ref:
		case OpCodeREnum.Add:
		case OpCodeREnum.Sub:
		case OpCodeREnum.Mul:
		case OpCodeREnum.Div:
		case OpCodeREnum.Div_Un:
		case OpCodeREnum.Rem:
		case OpCodeREnum.Rem_Un:
		case OpCodeREnum.And:
		case OpCodeREnum.Or:
		case OpCodeREnum.Xor:
		case OpCodeREnum.Shl:
		case OpCodeREnum.Shr:
		case OpCodeREnum.Shr_Un:
		case OpCodeREnum.Neg:
		case OpCodeREnum.Not:
		case OpCodeREnum.Conv_I1:
		case OpCodeREnum.Conv_I2:
		case OpCodeREnum.Conv_I4:
		case OpCodeREnum.Conv_I8:
		case OpCodeREnum.Conv_R4:
		case OpCodeREnum.Conv_R8:
		case OpCodeREnum.Conv_U4:
		case OpCodeREnum.Conv_U8:
		case OpCodeREnum.Callvirt:
		case OpCodeREnum.Ldobj:
		case OpCodeREnum.Ldstr:
		case OpCodeREnum.Newobj:
		case OpCodeREnum.Castclass:
		case OpCodeREnum.Isinst:
		case OpCodeREnum.Conv_R_Un:
		case OpCodeREnum.Unbox:
		case OpCodeREnum.Ldfld:
		case OpCodeREnum.Ldflda:
		case OpCodeREnum.Ldsfld:
		case OpCodeREnum.Ldsflda:
		case OpCodeREnum.Conv_Ovf_I1_Un:
		case OpCodeREnum.Conv_Ovf_I2_Un:
		case OpCodeREnum.Conv_Ovf_I4_Un:
		case OpCodeREnum.Conv_Ovf_I8_Un:
		case OpCodeREnum.Conv_Ovf_U1_Un:
		case OpCodeREnum.Conv_Ovf_U2_Un:
		case OpCodeREnum.Conv_Ovf_U4_Un:
		case OpCodeREnum.Conv_Ovf_U8_Un:
		case OpCodeREnum.Conv_Ovf_I_Un:
		case OpCodeREnum.Conv_Ovf_U_Un:
		case OpCodeREnum.Box:
		case OpCodeREnum.Newarr:
		case OpCodeREnum.Ldlen:
		case OpCodeREnum.Ldelema:
		case OpCodeREnum.Ldelem_I1:
		case OpCodeREnum.Ldelem_U1:
		case OpCodeREnum.Ldelem_I2:
		case OpCodeREnum.Ldelem_U2:
		case OpCodeREnum.Ldelem_I4:
		case OpCodeREnum.Ldelem_U4:
		case OpCodeREnum.Ldelem_I8:
		case OpCodeREnum.Ldelem_R4:
		case OpCodeREnum.Ldelem_R8:
		case OpCodeREnum.Ldelem_Ref:
		case OpCodeREnum.Ldelem_Any:
		case OpCodeREnum.Unbox_Any:
		case OpCodeREnum.Conv_Ovf_I1:
		case OpCodeREnum.Conv_Ovf_U1:
		case OpCodeREnum.Conv_Ovf_I2:
		case OpCodeREnum.Conv_Ovf_U2:
		case OpCodeREnum.Conv_Ovf_I4:
		case OpCodeREnum.Conv_Ovf_U4:
		case OpCodeREnum.Conv_Ovf_I8:
		case OpCodeREnum.Conv_Ovf_U8:
		case OpCodeREnum.Ldtoken:
		case OpCodeREnum.Conv_U2:
		case OpCodeREnum.Conv_U1:
		case OpCodeREnum.Conv_I:
		case OpCodeREnum.Conv_Ovf_I:
		case OpCodeREnum.Conv_Ovf_U:
		case OpCodeREnum.Add_Ovf:
		case OpCodeREnum.Add_Ovf_Un:
		case OpCodeREnum.Mul_Ovf:
		case OpCodeREnum.Mul_Ovf_Un:
		case OpCodeREnum.Sub_Ovf:
		case OpCodeREnum.Sub_Ovf_Un:
		case OpCodeREnum.Conv_U:
		case OpCodeREnum.Ceq:
		case OpCodeREnum.Cgt:
		case OpCodeREnum.Cgt_Un:
		case OpCodeREnum.Clt:
		case OpCodeREnum.Clt_Un:
		case OpCodeREnum.Ldftn:
		case OpCodeREnum.Ldvirtftn:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
		case OpCodeREnum.Move:
		case OpCodeREnum.Ceqi:
		case OpCodeREnum.Cgti:
		case OpCodeREnum.Cgti_Un:
		case OpCodeREnum.Clti:
		case OpCodeREnum.Clti_Un:
		case OpCodeREnum.Addi:
		case OpCodeREnum.Subi:
		case OpCodeREnum.Muli:
		case OpCodeREnum.Divi:
		case OpCodeREnum.Remi:
		case OpCodeREnum.Remi_Un:
		case OpCodeREnum.Andi:
		case OpCodeREnum.Ori:
		case OpCodeREnum.Xori:
		case OpCodeREnum.Shli:
		case OpCodeREnum.Shri:
		case OpCodeREnum.Shri_Un:
			op.Register1 = dst;
			break;
		default:
			throw new NotImplementedException();
		case OpCodeREnum.Nop:
		case OpCodeREnum.Ret:
		case OpCodeREnum.Br_S:
		case OpCodeREnum.Brfalse_S:
		case OpCodeREnum.Brtrue_S:
		case OpCodeREnum.Beq_S:
		case OpCodeREnum.Bge_S:
		case OpCodeREnum.Bgt_S:
		case OpCodeREnum.Ble_S:
		case OpCodeREnum.Blt_S:
		case OpCodeREnum.Bne_Un_S:
		case OpCodeREnum.Bge_Un_S:
		case OpCodeREnum.Bgt_Un_S:
		case OpCodeREnum.Ble_Un_S:
		case OpCodeREnum.Blt_Un_S:
		case OpCodeREnum.Br:
		case OpCodeREnum.Brfalse:
		case OpCodeREnum.Brtrue:
		case OpCodeREnum.Beq:
		case OpCodeREnum.Bge:
		case OpCodeREnum.Bgt:
		case OpCodeREnum.Ble:
		case OpCodeREnum.Blt:
		case OpCodeREnum.Bne_Un:
		case OpCodeREnum.Bge_Un:
		case OpCodeREnum.Bgt_Un:
		case OpCodeREnum.Ble_Un:
		case OpCodeREnum.Blt_Un:
		case OpCodeREnum.Switch:
		case OpCodeREnum.Constrained:
		case OpCodeREnum.Push:
			break;
		}
	}
}
