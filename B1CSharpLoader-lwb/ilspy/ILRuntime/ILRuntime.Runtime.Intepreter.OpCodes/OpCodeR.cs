using System;
using System.Runtime.InteropServices;
using ILRuntime.CLR.Method;
using ILRuntime.CLR.TypeSystem;
using ILRuntime.Runtime.Enviorment;

namespace ILRuntime.Runtime.Intepreter.OpCodes;

[StructLayout(LayoutKind.Explicit)]
internal struct OpCodeR
{
	[FieldOffset(0)]
	public OpCodeREnum Code;

	[FieldOffset(4)]
	public short Register1;

	[FieldOffset(6)]
	public short Register2;

	[FieldOffset(8)]
	public short Register3;

	[FieldOffset(10)]
	public short Register4;

	[FieldOffset(8)]
	public int Operand;

	[FieldOffset(8)]
	public float OperandFloat;

	[FieldOffset(12)]
	public int Operand2;

	[FieldOffset(16)]
	public int Operand3;

	[FieldOffset(12)]
	public long OperandLong;

	[FieldOffset(12)]
	public double OperandDouble;

	[FieldOffset(20)]
	public int Operand4;

	public override string ToString()
	{
		return ToString(null);
	}

	public string ToString(ILRuntime.Runtime.Enviorment.AppDomain domain)
	{
		string arg = null;
		switch (Code)
		{
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
		case OpCodeREnum.Stind_Ref:
		case OpCodeREnum.Stind_I1:
		case OpCodeREnum.Stind_I2:
		case OpCodeREnum.Stind_I4:
		case OpCodeREnum.Stind_I8:
		case OpCodeREnum.Stind_R4:
		case OpCodeREnum.Stind_R8:
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
		case OpCodeREnum.Conv_R_Un:
		case OpCodeREnum.Stobj:
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
		case OpCodeREnum.Stind_I:
		case OpCodeREnum.Conv_U:
		case OpCodeREnum.Ldarga:
		case OpCodeREnum.Ldloca:
		case OpCodeREnum.Move:
			arg = $"r{Register1}, r{Register2}";
			break;
		case OpCodeREnum.Castclass:
		case OpCodeREnum.Isinst:
		case OpCodeREnum.Unbox:
		case OpCodeREnum.Box:
		case OpCodeREnum.Unbox_Any:
		{
			if (domain == null)
			{
				arg = $"r{Register1}, r{Register2}, {Operand}";
				break;
			}
			IType type6 = domain.GetType(Operand);
			arg = $"r{Register1}, r{Register2}, {type6}";
			break;
		}
		case OpCodeREnum.Ldfld:
		case OpCodeREnum.Ldflda:
		case OpCodeREnum.Stfld:
			arg = $"r{Register1}, r{Register2}, 0x{OperandLong:X8}";
			break;
		case OpCodeREnum.Ldsfld:
		case OpCodeREnum.Ldsflda:
		case OpCodeREnum.Stsfld:
			arg = $"r{Register1}, 0x{OperandLong:X8}";
			break;
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
			arg = ((Operand == 0) ? ((OperandLong == 0L) ? ((OperandFloat == 0f) ? ((OperandDouble == 0.0) ? $"r{Register1},0,{Operand4}" : $"r{Register1},{OperandDouble},{Operand4}") : $"r{Register1},{OperandFloat},{Operand4}") : $"r{Register1},{OperandLong},{Operand4}") : $"r{Register1},{Operand},{Operand4}");
			break;
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
			arg = ((Operand == 0) ? ((OperandLong == 0L) ? ((OperandFloat == 0f) ? ((OperandDouble == 0.0) ? $"r{Register1},r{Register2},0" : $"r{Register1},r{Register2},{OperandDouble}") : $"r{Register1},r{Register2},{OperandFloat}") : $"r{Register1},r{Register2},{OperandLong}") : $"r{Register1},r{Register2},{Operand}");
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
		case OpCodeREnum.Ldelem_I2:
		case OpCodeREnum.Ldelem_I4:
		case OpCodeREnum.Ldelem_I:
		case OpCodeREnum.Ldelem_R4:
		case OpCodeREnum.Ldelem_R8:
		case OpCodeREnum.Ldelem_Ref:
		case OpCodeREnum.Stelem_I:
		case OpCodeREnum.Stelem_I1:
		case OpCodeREnum.Stelem_I2:
		case OpCodeREnum.Stelem_I4:
		case OpCodeREnum.Stelem_R4:
		case OpCodeREnum.Stelem_R8:
		case OpCodeREnum.Stelem_Ref:
		case OpCodeREnum.Ldelem_Any:
		case OpCodeREnum.Stelem_Any:
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
			arg = $"r{Register1},r{Register2},r{Register3}";
			break;
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
		case OpCodeREnum.Ret:
		case OpCodeREnum.Push:
			arg = $"r{Register1}";
			break;
		case OpCodeREnum.Brfalse_S:
		case OpCodeREnum.Brtrue_S:
		case OpCodeREnum.Brfalse:
		case OpCodeREnum.Brtrue:
		case OpCodeREnum.Switch:
			arg = $"r{Register1}, {Operand}";
			break;
		case OpCodeREnum.Ldftn:
		{
			if (domain == null)
			{
				arg = $"r{Register1}, {Operand2}";
				break;
			}
			IMethod method3 = domain.GetMethod(Operand2);
			arg = ((!(method3 is CLRMethod)) ? ((method3 != null) ? $"r{Register1}, {method3}" : $"r{Register1}, {Operand2}") : ((method3 != null) ? $"r{Register1}, {method3.DeclearingType.FullName}::{method3}" : $"r{Register1}, {Operand2}"));
			break;
		}
		case OpCodeREnum.Ldvirtftn:
		{
			if (domain == null)
			{
				arg = $"r{Register1}, r{Register2} {Operand2}";
				break;
			}
			IMethod method2 = domain.GetMethod(Operand2);
			arg = ((!(method2 is CLRMethod)) ? ((method2 != null) ? $"r{Register1}, r{Register2}, {method2}" : $"r{Register1}, r{Register2}, {Operand2}") : ((method2 != null) ? $"r{Register1}, r{Register2}, {method2.DeclearingType.FullName}::{method2}" : $"r{Register1}, r{Register2}, {Operand2}"));
			break;
		}
		case OpCodeREnum.Constrained:
		{
			if (domain == null)
			{
				arg = Operand.ToString();
				break;
			}
			IType type5 = domain.GetType(Operand);
			arg = ((type5 != null) ? type5.ToString() : Operand.ToString());
			break;
		}
		case OpCodeREnum.Call:
		case OpCodeREnum.Callvirt:
		case OpCodeREnum.Newobj:
		{
			string text = ((Register1 >= 0) ? ("r" + Register1) : "-");
			if (Register2 >= 0)
			{
				text = text + ", r" + Register2;
			}
			if (Register3 >= 0)
			{
				text = text + ", r" + Register3;
			}
			if (Register4 >= 0)
			{
				text = text + ", r" + Register4;
			}
			if (domain == null)
			{
				arg = $"{text}, {Operand2}";
				break;
			}
			IMethod method = domain.GetMethod(Operand2);
			arg = ((!(method is CLRMethod)) ? ((method != null) ? $"{text}, {method}" : $"{text}, {Operand2}") : ((method != null) ? $"{text}, {method.DeclearingType.FullName}::{method}" : $"{text}, {Operand2}"));
			break;
		}
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
			arg = $"r{Register1}, r{Register2}, {Operand}";
			break;
		case OpCodeREnum.Br_S:
		case OpCodeREnum.Br:
		case OpCodeREnum.Leave:
		case OpCodeREnum.Leave_S:
			arg = $"{Operand}";
			break;
		case OpCodeREnum.Ldc_I4_S:
		case OpCodeREnum.Ldc_I4:
			arg = $"r{Register1},{Operand}";
			break;
		case OpCodeREnum.Ldc_I8:
			arg = $"r{Register1},{OperandLong}";
			break;
		case OpCodeREnum.Ldc_R4:
			arg = $"r{Register1},{OperandFloat}";
			break;
		case OpCodeREnum.Ldc_R8:
			arg = $"r{Register1},{OperandDouble}";
			break;
		case OpCodeREnum.Ldstr:
			arg = ((domain != null) ? $"r{Register1},\"{domain.GetString(OperandLong)}\"" : $"r{Register1},0x{OperandLong:X}");
			break;
		case OpCodeREnum.Ldtoken:
			if (domain == null)
			{
				arg = $"r{Register1},0x{OperandLong:X}";
				break;
			}
			switch (Operand)
			{
			case 0:
			{
				IType type4 = domain.GetType((int)(OperandLong >> 32));
				int num = (int)OperandLong;
				arg = $"r{Register1},{type4.FullName}.{((type4 is ILType) ? ((ILType)type4).TypeDefinition.Fields[num].Name : ((CLRType)type4).Fields[num].Name)}";
				break;
			}
			case 1:
			{
				IType type3 = domain.GetType((int)OperandLong);
				arg = $"r{Register1},\"{type3}\"";
				break;
			}
			default:
				throw new NotImplementedException();
			}
			break;
		case OpCodeREnum.Initobj:
		{
			if (domain == null)
			{
				arg = $"r{Register1}, {Operand}";
				break;
			}
			IType type2 = domain.GetType(Operand);
			arg = $"r{Register1}, {type2}";
			break;
		}
		case OpCodeREnum.Newarr:
		{
			if (domain == null)
			{
				arg = $"r{Register1}, r{Register2}";
				break;
			}
			IType type = domain.GetType(Operand);
			arg = string.Format("r{0}, {2}, r{1}", Register1, Register2, type);
			break;
		}
		}
		return $"{Code.ToString().ToLower().Replace('_', '.')} {arg}";
	}
}
