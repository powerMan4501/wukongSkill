using System;
using System.Text;

namespace UnrealEngine.Runtime;

public class ScriptDisassembler
{
	private StringBuilder output;

	private string indents;

	private byte[] script;

	private int scriptIndex;

	public ScriptDisassembler(StringBuilder output)
	{
		this.output = output;
	}

	public void DisassembleStructure(UFunction source)
	{
		script = source.Script;
		indents = string.Empty;
		if (script != null)
		{
			scriptIndex = 0;
			while (scriptIndex < script.Length)
			{
				output.AppendLine("Label_0x" + scriptIndex.ToString("X8") + ":");
				AddIndent();
				SerializeExpr();
				DropIndent();
			}
		}
	}

	public static void DisassembleAllFunctionsInClasses(StringBuilder output, string classnameSubstring)
	{
		ScriptDisassembler scriptDisassembler = new ScriptDisassembler(output);
		foreach (UClass item in new TObjectIterator<UClass>())
		{
			string name = item.GetName();
			if (classnameSubstring.IndexOf(classnameSubstring, StringComparison.OrdinalIgnoreCase) >= 0)
			{
				output.AppendLine("Processing class " + name);
				foreach (UFunction uField in item.GetUFields<UFunction>(includeSuper: false))
				{
					string name2 = uField.GetName();
					byte[] array = uField.Script;
					int num = ((array != null) ? array.Length : 0);
					output.AppendLine("  Processing function " + name2 + " (" + num + " bytes)");
					scriptDisassembler.DisassembleStructure(uField);
					output.AppendLine();
				}
			}
			output.AppendLine();
			output.AppendLine("-----------");
			output.AppendLine();
		}
	}

	public static void DisassembleAllFunctionsInClass(StringBuilder output, UClass unrealClass)
	{
		if (!(unrealClass != null))
		{
			return;
		}
		ScriptDisassembler scriptDisassembler = new ScriptDisassembler(output);
		output.AppendLine("Processing class " + unrealClass.GetName());
		foreach (UFunction uField in unrealClass.GetUFields<UFunction>(includeSuper: false))
		{
			string name = uField.GetName();
			byte[] array = uField.Script;
			int num = ((array != null) ? array.Length : 0);
			output.AppendLine("  Processing function " + name + " (" + num + " bytes)");
			scriptDisassembler.DisassembleStructure(uField);
			output.AppendLine();
		}
	}

	private string FmtPtr(UObject obj)
	{
		return obj.Address.ToString("X" + IntPtr.Size * 2);
	}

	private string FmtObjOuterNameOrNull(UObject obj)
	{
		if (!(obj != null))
		{
			return "(null)";
		}
		return obj.GetOuter().GetName();
	}

	private string FmtObjNameOrNull(UObject obj)
	{
		if (!(obj != null))
		{
			return "(null)";
		}
		return obj.GetName();
	}

	private string FmtFPropertyNameOrNull(FProperty property)
	{
		if (!(property != null) || !(property.Address != IntPtr.Zero))
		{
			return "(null)";
		}
		return FProperty.GetNameSafe(property);
	}

	private string FmtSkipCount(uint skipCount)
	{
		return "0x" + skipCount.ToString("X8");
	}

	private string FmtScriptIndex(int index)
	{
		return "0x" + index.ToString("X" + ((index > 65535) ? 8 : 4));
	}

	private string FmtOpcodeIndent(EExprToken opcode)
	{
		return indents + " $" + ((byte)opcode).ToString("X2") + ": ";
	}

	private string FmtOpcode(EExprToken opcode)
	{
		return "$" + ((byte)opcode).ToString("X2");
	}

	private byte ReadByte()
	{
		byte result = script[scriptIndex];
		scriptIndex++;
		return result;
	}

	private ushort ReadUInt16()
	{
		byte num = script[scriptIndex];
		scriptIndex++;
		ushort result = (ushort)(num | (script[scriptIndex] << 8));
		scriptIndex++;
		return result;
	}

	private int ReadInt32()
	{
		byte num = script[scriptIndex];
		scriptIndex++;
		int num2 = num | (script[scriptIndex] << 8);
		scriptIndex++;
		int num3 = num2 | (script[scriptIndex] << 16);
		scriptIndex++;
		int result = num3 | (script[scriptIndex] << 24);
		scriptIndex++;
		return result;
	}

	private ulong ReadUInt64()
	{
		long num = script[scriptIndex];
		scriptIndex++;
		long num2 = num | (long)((ulong)script[scriptIndex] << 8);
		scriptIndex++;
		long num3 = num2 | (long)((ulong)script[scriptIndex] << 16);
		scriptIndex++;
		long num4 = num3 | (long)((ulong)script[scriptIndex] << 24);
		scriptIndex++;
		long num5 = num4 | (long)((ulong)script[scriptIndex] << 32);
		scriptIndex++;
		long num6 = num5 | (long)((ulong)script[scriptIndex] << 40);
		scriptIndex++;
		long num7 = num6 | (long)((ulong)script[scriptIndex] << 48);
		scriptIndex++;
		long result = num7 | (long)((ulong)script[scriptIndex] << 56);
		scriptIndex++;
		return (ulong)result;
	}

	private unsafe float ReadFloat()
	{
		int num = ReadInt32();
		return *(float*)(&num);
	}

	private T ReadUFieldPointer<T>() where T : UObject
	{
		return GCHelper.Find<T>((IntPtr)(long)ReadUInt64());
	}

	private T ReadFFieldPointer<T>() where T : FProperty
	{
		return new FProperty((IntPtr)(long)ReadUInt64()) as T;
	}

	private uint ReadSkipCount()
	{
		return (uint)ReadInt32();
	}

	private unsafe string ReadName()
	{
		fixed (byte* ptr = script)
		{
			FScriptName fScriptName = *(FScriptName*)(ptr + scriptIndex);
			scriptIndex += sizeof(FScriptName);
			return fScriptName.ToName().ToString();
		}
	}

	private string ReadString()
	{
		EExprToken eExprToken = (EExprToken)script[scriptIndex++];
		return eExprToken switch
		{
			EExprToken.EX_StringConst => ReadString8(), 
			EExprToken.EX_UnicodeStringConst => ReadString16(), 
			_ => throw new Exception("FKismetBytecodeDisassembler::ReadString - Unexpected opcode. Expected " + EExprToken.EX_StringConst.ToString() + " or " + EExprToken.EX_UnicodeStringConst.ToString() + ", got " + eExprToken), 
		};
	}

	private string ReadString8()
	{
		string text = string.Empty;
		char c;
		while ((c = (char)ReadByte()) != 0)
		{
			text += c;
		}
		return text;
	}

	private string ReadString16()
	{
		string text = string.Empty;
		char c;
		while ((c = (char)ReadUInt16()) != 0)
		{
			text += c;
		}
		return text;
	}

	private void AddIndent()
	{
		indents += "  ";
	}

	private void DropIndent()
	{
		indents = indents.Substring(0, indents.Length - 2);
	}

	private EExprToken SerializeExpr()
	{
		AddIndent();
		EExprToken eExprToken = (EExprToken)script[scriptIndex];
		scriptIndex++;
		ProcessCommon(eExprToken);
		DropIndent();
		return eExprToken;
	}

	private void ProcessCastByte(int castType)
	{
		SerializeExpr();
	}

	private void ProcessCommon(EExprToken opcode)
	{
		switch (opcode)
		{
		case EExprToken.EX_PrimitiveCast:
		{
			byte castType = ReadByte();
			output.AppendLine(FmtOpcodeIndent(opcode) + "PrimitiveCast of type " + castType);
			AddIndent();
			output.AppendLine(indents + " Argument:");
			ProcessCastByte(castType);
			break;
		}
		case EExprToken.EX_SetSet:
			output.AppendLine(FmtOpcodeIndent(opcode) + "set set");
			SerializeExpr();
			ReadInt32();
			while (SerializeExpr() != EExprToken.EX_EndSet)
			{
			}
			break;
		case EExprToken.EX_EndSet:
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_EndSet");
			break;
		case EExprToken.EX_SetConst:
		{
			FProperty property8 = ReadFFieldPointer<FProperty>();
			int num26 = ReadInt32();
			output.AppendLine(FmtOpcodeIndent(opcode) + "set set const - elements number: " + num26 + ", inner property: " + FProperty.GetNameSafe(property8));
			while (SerializeExpr() != EExprToken.EX_EndSetConst)
			{
			}
			break;
		}
		case EExprToken.EX_EndSetConst:
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_EndSetConst");
			break;
		case EExprToken.EX_SetMap:
			output.AppendLine(FmtOpcodeIndent(opcode) + "set map");
			SerializeExpr();
			ReadInt32();
			while (SerializeExpr() != EExprToken.EX_EndMap)
			{
			}
			break;
		case EExprToken.EX_EndMap:
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_EndMap");
			break;
		case EExprToken.EX_MapConst:
		{
			FProperty property2 = ReadFFieldPointer<FProperty>();
			FProperty property3 = ReadFFieldPointer<FProperty>();
			int num25 = ReadInt32();
			output.AppendLine(FmtOpcodeIndent(opcode) + "set map const - elements number: " + num25 + ", key property: " + FProperty.GetNameSafe(property2) + ", val property: " + FProperty.GetNameSafe(property3));
			while (SerializeExpr() != EExprToken.EX_EndMapConst)
			{
			}
			break;
		}
		case EExprToken.EX_ObjToInterfaceCast:
		{
			UClass uClass5 = ReadUFieldPointer<UClass>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "ObjToInterfaceCast to " + uClass5.GetName());
			SerializeExpr();
			break;
		}
		case EExprToken.EX_CrossInterfaceCast:
		{
			UClass uClass4 = ReadUFieldPointer<UClass>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "InterfaceToInterfaceCast to " + uClass4.GetName());
			SerializeExpr();
			break;
		}
		case EExprToken.EX_InterfaceToObjCast:
		{
			UClass uClass3 = ReadUFieldPointer<UClass>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "InterfaceToObjCast to " + uClass3.GetName());
			SerializeExpr();
			break;
		}
		case EExprToken.EX_Let:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Let (Variable = Expression)");
			AddIndent();
			ReadFFieldPointer<FProperty>();
			output.AppendLine(indents + " Variable:");
			SerializeExpr();
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		case EExprToken.EX_LetObj:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Let Obj (Variable = Expression)");
			goto IL_04ff;
		case EExprToken.EX_LetWeakObjPtr:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Let WeakObjPtr (Variable = Expression)");
			goto IL_04ff;
		case EExprToken.EX_LetBool:
			output.AppendLine(FmtOpcodeIndent(opcode) + "LetBool (Variable = Expression)");
			AddIndent();
			output.AppendLine(indents + " Variable:");
			SerializeExpr();
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		case EExprToken.EX_LetValueOnPersistentFrame:
		{
			output.AppendLine(FmtOpcodeIndent(opcode) + "LetValueOnPersistentFrame");
			AddIndent();
			FProperty fProperty2 = ReadFFieldPointer<FProperty>();
			output.AppendLine(indents + " Destination variable: " + FProperty.GetNameSafe(fProperty2) + ", offset: " + ((fProperty2 != null) ? fProperty2.GetOffset_ForDebug() : 0));
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		}
		case EExprToken.EX_StructMemberContext:
		{
			output.AppendLine(FmtOpcodeIndent(opcode) + "Struct member context");
			AddIndent();
			FProperty fProperty = ReadFFieldPointer<FProperty>();
			output.AppendLine(indents + " Expression within struct " + fProperty.GetName() + ", offset " + fProperty.GetOffset_ForDebug());
			output.AppendLine(indents + " Expression to struct:");
			SerializeExpr();
			DropIndent();
			break;
		}
		case EExprToken.EX_LetDelegate:
			output.AppendLine(FmtOpcodeIndent(opcode) + "LetDelegate (Variable = Expression)");
			AddIndent();
			output.AppendLine(indents + " Variable:");
			SerializeExpr();
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		case EExprToken.EX_LetMulticastDelegate:
			output.AppendLine(FmtOpcodeIndent(opcode) + "LetMulticastDelegate (Variable = Expression)");
			AddIndent();
			output.AppendLine(indents + " Variable:");
			SerializeExpr();
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		case EExprToken.EX_ComputedJump:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Computed Jump, offset specified by expression:");
			AddIndent();
			SerializeExpr();
			DropIndent();
			break;
		case EExprToken.EX_Jump:
		{
			uint skipCount8 = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Jump to offset " + FmtSkipCount(skipCount8));
			break;
		}
		case EExprToken.EX_LocalVariable:
		{
			FProperty property7 = ReadFFieldPointer<FProperty>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Local variable named " + FmtFPropertyNameOrNull(property7));
			break;
		}
		case EExprToken.EX_DefaultVariable:
		{
			FProperty property6 = ReadFFieldPointer<FProperty>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Default variable named " + FmtFPropertyNameOrNull(property6));
			break;
		}
		case EExprToken.EX_InstanceVariable:
		{
			FProperty property5 = ReadFFieldPointer<FProperty>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Instance variable named " + FmtFPropertyNameOrNull(property5));
			break;
		}
		case EExprToken.EX_LocalOutVariable:
		{
			FProperty property4 = ReadFFieldPointer<FProperty>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Local out variable named " + FmtFPropertyNameOrNull(property4));
			break;
		}
		case EExprToken.EX_InterfaceContext:
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_InterfaceContext:");
			SerializeExpr();
			break;
		case EExprToken.EX_DeprecatedOp4A:
			output.AppendLine(FmtOpcodeIndent(opcode) + "This opcode has been removed and does nothing.");
			break;
		case EExprToken.EX_Nothing:
		case EExprToken.EX_EndParmValue:
		case EExprToken.EX_EndFunctionParms:
		case EExprToken.EX_Self:
		case EExprToken.EX_IntZero:
		case EExprToken.EX_IntOne:
		case EExprToken.EX_True:
		case EExprToken.EX_False:
		case EExprToken.EX_NoObject:
		case EExprToken.EX_NoInterface:
		case EExprToken.EX_EndStructConst:
		case EExprToken.EX_EndArray:
		case EExprToken.EX_EndOfScript:
		case EExprToken.EX_EndArrayConst:
			output.AppendLine(FmtOpcodeIndent(opcode) + opcode);
			break;
		case EExprToken.EX_Return:
			output.AppendLine(FmtOpcodeIndent(opcode) + opcode);
			SerializeExpr();
			break;
		case EExprToken.EX_CallMath:
		{
			UStruct uStruct = ReadUFieldPointer<UStruct>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Call Math (stack node " + UObject.GetNameSafe((uStruct != null) ? uStruct.GetOuter() : null) + "::" + UObject.GetNameSafe(uStruct) + ")");
			while (SerializeExpr() != EExprToken.EX_EndFunctionParms)
			{
			}
			break;
		}
		case EExprToken.EX_FinalFunction:
		{
			UStruct obj3 = ReadUFieldPointer<UStruct>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Final Function (stack node " + FmtObjOuterNameOrNull(obj3) + "::" + FmtObjNameOrNull(obj3) + ")");
			while (SerializeExpr() != EExprToken.EX_EndFunctionParms)
			{
			}
			break;
		}
		case EExprToken.EX_CallMulticastDelegate:
		{
			UStruct obj2 = ReadUFieldPointer<UStruct>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "CallMulticastDelegate (signature " + FmtObjOuterNameOrNull(obj2) + "::" + FmtObjNameOrNull(obj2) + ") delegate:");
			SerializeExpr();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Params:");
			while (SerializeExpr() != EExprToken.EX_EndFunctionParms)
			{
			}
			break;
		}
		case EExprToken.EX_VirtualFunction:
		{
			string text14 = ReadName();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Virtual Function named " + text14);
			while (SerializeExpr() != EExprToken.EX_EndFunctionParms)
			{
			}
			break;
		}
		case EExprToken.EX_ClassContext:
		case EExprToken.EX_Context:
		case EExprToken.EX_Context_FailSilent:
		{
			output.AppendLine(FmtOpcodeIndent(opcode) + ((opcode == EExprToken.EX_ClassContext) ? "Class Context" : "Context"));
			AddIndent();
			output.AppendLine(indents + " ObjectExpression:");
			SerializeExpr();
			if (opcode == EExprToken.EX_Context_FailSilent)
			{
				output.AppendLine(indents + " Can fail silently on access none ");
			}
			uint skipCount7 = ReadSkipCount();
			output.AppendLine(indents + " Skip Bytes: " + FmtSkipCount(skipCount7));
			UField obj = ReadUFieldPointer<UField>();
			output.AppendLine(indents + " R-Value Property: " + FmtObjNameOrNull(obj));
			output.AppendLine(indents + " ContextExpression:");
			SerializeExpr();
			DropIndent();
			break;
		}
		case EExprToken.EX_IntConst:
		{
			int num24 = ReadInt32();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal int32 " + num24);
			break;
		}
		case EExprToken.EX_SkipOffsetConst:
		{
			uint skipCount6 = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal CodeSkipSizeType " + FmtSkipCount(skipCount6));
			break;
		}
		case EExprToken.EX_FloatConst:
		{
			float num23 = ReadFloat();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal float " + num23);
			break;
		}
		case EExprToken.EX_StringConst:
		{
			string text13 = ReadString8();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal ansi string \"" + text13 + "\"");
			break;
		}
		case EExprToken.EX_UnicodeStringConst:
		{
			string text12 = ReadString16();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal unicode string \"" + text12 + "\"");
			break;
		}
		case EExprToken.EX_TextConst:
			switch ((EBlueprintTextLiteralType)script[scriptIndex++])
			{
			case EBlueprintTextLiteralType.Empty:
				output.AppendLine(FmtOpcodeIndent(opcode) + "literal text - empty");
				break;
			case EBlueprintTextLiteralType.LocalizedText:
			{
				string text9 = ReadString();
				string text10 = ReadString();
				string text11 = ReadString();
				output.AppendLine(FmtOpcodeIndent(opcode) + "literal text - localized text { namespace: \"" + text11 + "\", key: \"" + text10 + "\", source: \"" + text9 + "\" }");
				break;
			}
			case EBlueprintTextLiteralType.InvariantText:
			{
				string text8 = ReadString();
				output.AppendLine(FmtOpcodeIndent(opcode) + "literal text - invariant text: \"" + text8 + "\"");
				break;
			}
			case EBlueprintTextLiteralType.LiteralString:
			{
				string text7 = ReadString();
				output.AppendLine(FmtOpcodeIndent(opcode) + "literal text - literal string: \"" + text7 + "\"");
				break;
			}
			case EBlueprintTextLiteralType.StringTableEntry:
			{
				ReadUFieldPointer<UObject>();
				string text5 = ReadString();
				string text6 = ReadString();
				output.AppendLine(FmtOpcodeIndent(opcode) + "literal text - string table entry { tableid: \"" + text5 + "\", key: \"" + text6 + "\" }");
				break;
			}
			default:
				throw new Exception("Unknown EBlueprintTextLiteralType! Please update ProcessCommon() to handle this type of text.");
			}
			break;
		case EExprToken.EX_ObjectConst:
		{
			UObject uObject = ReadUFieldPointer<UObject>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_ObjectConst (" + FmtPtr(uObject) + ":" + uObject.GetFullName());
			break;
		}
		case EExprToken.EX_SoftObjectConst:
			output.AppendLine(FmtOpcodeIndent(opcode) + "EX_SoftObjectConst");
			SerializeExpr();
			break;
		case EExprToken.EX_NameConst:
		{
			string text4 = ReadName();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal name " + text4);
			break;
		}
		case EExprToken.EX_RotationConst:
		{
			float num20 = ReadFloat();
			float num21 = ReadFloat();
			float num22 = ReadFloat();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal rotation (" + num20 + "," + num21 + "," + num22 + ")");
			break;
		}
		case EExprToken.EX_VectorConst:
		{
			float num17 = ReadFloat();
			float num18 = ReadFloat();
			float num19 = ReadFloat();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal vector (" + num17 + "," + num18 + "," + num19 + ")");
			break;
		}
		case EExprToken.EX_TransformConst:
		{
			float num7 = ReadFloat();
			float num8 = ReadFloat();
			float num9 = ReadFloat();
			float num10 = ReadFloat();
			float num11 = ReadFloat();
			float num12 = ReadFloat();
			float num13 = ReadFloat();
			float num14 = ReadFloat();
			float num15 = ReadFloat();
			float num16 = ReadFloat();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal transform R(" + num7 + "," + num8 + "," + num9 + "," + num10 + ",) T(" + num11 + "," + num12 + "," + num13 + ") T(" + num14 + "," + num15 + "," + num16 + ")");
			break;
		}
		case EExprToken.EX_StructConst:
		{
			UScriptStruct uScriptStruct = ReadUFieldPointer<UScriptStruct>();
			int num6 = ReadInt32();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal struct " + uScriptStruct.GetName() + "  (serialized size: " + num6 + ")");
			break;
		}
		case EExprToken.EX_SetArray:
			output.AppendLine(FmtOpcodeIndent(opcode) + "set array");
			SerializeExpr();
			while (SerializeExpr() != EExprToken.EX_EndArray)
			{
			}
			break;
		case EExprToken.EX_ArrayConst:
		{
			FProperty property = ReadFFieldPointer<FProperty>();
			int num5 = ReadInt32();
			output.AppendLine(FmtOpcodeIndent(opcode) + "set array const - elements number: " + num5 + ", inner property: " + FProperty.GetNameSafe(property));
			break;
		}
		case EExprToken.EX_ByteConst:
		{
			byte b2 = ReadByte();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal byte " + b2);
			break;
		}
		case EExprToken.EX_IntConstByte:
		{
			int num4 = ReadByte();
			output.AppendLine(FmtOpcodeIndent(opcode) + "literal int " + num4);
			break;
		}
		case EExprToken.EX_MetaCast:
		{
			UClass uClass2 = ReadUFieldPointer<UClass>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "MetaCast to " + uClass2.GetName() + " of expr:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_DynamicCast:
		{
			UClass uClass = ReadUFieldPointer<UClass>();
			output.AppendLine(FmtOpcodeIndent(opcode) + "DynamicCast to " + uClass.GetName() + " of expr:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_JumpIfNot:
		{
			uint skipCount5 = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Jump to offset " + FmtSkipCount(skipCount5) + " if not expr:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_Assert:
		{
			ushort num3 = ReadUInt16();
			byte b = ReadByte();
			output.AppendLine(FmtOpcodeIndent(opcode) + "assert at line " + num3 + ", in debug mode = " + b + " with expr:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_Skip:
		{
			uint skipCount4 = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "possibly skip " + FmtSkipCount(skipCount4) + " bytes of expr:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_InstanceDelegate:
		{
			string text3 = ReadName();
			output.AppendLine(FmtOpcodeIndent(opcode) + "instance delegate function named " + text3);
			break;
		}
		case EExprToken.EX_AddMulticastDelegate:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Add MC delegate");
			SerializeExpr();
			SerializeExpr();
			break;
		case EExprToken.EX_RemoveMulticastDelegate:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Remove MC delegate");
			SerializeExpr();
			SerializeExpr();
			break;
		case EExprToken.EX_ClearMulticastDelegate:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Clear MC delegate");
			SerializeExpr();
			break;
		case EExprToken.EX_BindDelegate:
		{
			string text2 = ReadName();
			output.AppendLine(FmtOpcodeIndent(opcode) + "BindDelegate '" + text2 + "'");
			output.AppendLine(indents + " Delegate:");
			SerializeExpr();
			output.AppendLine(indents + " Object:");
			SerializeExpr();
			break;
		}
		case EExprToken.EX_PushExecutionFlow:
		{
			uint skipCount3 = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "FlowStack.Push(" + FmtSkipCount(skipCount3) + ");");
			break;
		}
		case EExprToken.EX_PopExecutionFlow:
			output.AppendLine(FmtOpcodeIndent(opcode) + "if (FlowStack.Num()) { jump to statement at FlowStack.Pop(); } else { ERROR!!! }");
			break;
		case EExprToken.EX_PopExecutionFlowIfNot:
			output.AppendLine(FmtOpcodeIndent(opcode) + "if (!condition) { if (FlowStack.Num()) { jump to statement at FlowStack.Pop(); } else { ERROR!!! } }");
			SerializeExpr();
			break;
		case EExprToken.EX_Breakpoint:
			output.AppendLine(FmtOpcodeIndent(opcode) + "<<< BREAKPOINT >>>");
			break;
		case EExprToken.EX_WireTracepoint:
			output.AppendLine(FmtOpcodeIndent(opcode) + ".. wire debug site ..");
			break;
		case EExprToken.EX_InstrumentationEvent:
			switch ((EScriptInstrumentation)ReadByte())
			{
			case EScriptInstrumentation.InlineEvent:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented inline event ..");
				break;
			case EScriptInstrumentation.Stop:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented event stop ..");
				break;
			case EScriptInstrumentation.PureNodeEntry:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented pure node entry site ..");
				break;
			case EScriptInstrumentation.NodeDebugSite:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented debug site ..");
				break;
			case EScriptInstrumentation.NodeEntry:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented wire entry site ..");
				break;
			case EScriptInstrumentation.NodeExit:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. instrumented wire exit site ..");
				break;
			case EScriptInstrumentation.PushState:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. push execution state ..");
				break;
			case EScriptInstrumentation.RestoreState:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. restore execution state ..");
				break;
			case EScriptInstrumentation.ResetState:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. reset execution state ..");
				break;
			case EScriptInstrumentation.SuspendState:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. suspend execution state ..");
				break;
			case EScriptInstrumentation.PopState:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. pop execution state ..");
				break;
			case EScriptInstrumentation.TunnelEndOfThread:
				output.AppendLine(FmtOpcodeIndent(opcode) + ".. tunnel end of thread ..");
				break;
			case EScriptInstrumentation.ResumeEvent:
				break;
			}
			break;
		case EExprToken.EX_Tracepoint:
			output.AppendLine(FmtOpcodeIndent(opcode) + ".. debug site ..");
			break;
		case EExprToken.EX_SwitchValue:
		{
			ushort num = ReadUInt16();
			uint skipCount = ReadSkipCount();
			output.AppendLine(FmtOpcodeIndent(opcode) + "Switch Value " + num + " cases, end in " + FmtSkipCount(skipCount));
			AddIndent();
			output.AppendLine(indents + " Index:");
			SerializeExpr();
			for (ushort num2 = 0; num2 < num; num2++)
			{
				output.AppendLine(indents + " [" + num2 + "] Case Index (label: " + FmtScriptIndex(scriptIndex) + ")");
				SerializeExpr();
				uint skipCount2 = ReadSkipCount();
				output.AppendLine(indents + " [" + num2 + "] Offset to the next case: " + FmtSkipCount(skipCount2));
				output.AppendLine(indents + " [" + num2 + "] Case Result:");
				SerializeExpr();
			}
			output.AppendLine(indents + " Default result (label: " + FmtScriptIndex(scriptIndex) + ")");
			SerializeExpr();
			output.AppendLine(indents + " (label: " + FmtScriptIndex(scriptIndex) + ")");
			DropIndent();
			break;
		}
		case EExprToken.EX_ArrayGetByRef:
			output.AppendLine(FmtOpcodeIndent(opcode) + "Array Get-by-Ref Index");
			AddIndent();
			SerializeExpr();
			SerializeExpr();
			DropIndent();
			break;
		default:
			{
				string text = "Unknown bytecode 0x" + ((byte)opcode).ToString("X2") + "; ignoring it";
				output.AppendLine(FmtOpcodeIndent(opcode) + "!!!" + text);
				FMessage.Log(ELogVerbosity.Warning, text);
				break;
			}
			IL_04ff:
			AddIndent();
			output.AppendLine(indents + " Variable:");
			SerializeExpr();
			output.AppendLine(indents + " Expression:");
			SerializeExpr();
			DropIndent();
			break;
		}
	}

	private string GetNameSafe(FField InField)
	{
		if (InField.Address != IntPtr.Zero)
		{
			return InField.GetName();
		}
		return "none";
	}
}
