using System;
using System.Runtime.InteropServices;
using System.Text;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[StructLayout(LayoutKind.Explicit, Size = 152)]
public struct FFrame
{
	internal static class StructBuilder
	{
		private static void FormatStructField(StringBuilder stringBuilder, string name, string typeName, int typeSize, ref int offset, int pad, bool align = false)
		{
			stringBuilder.AppendLine("[FieldOffset(" + offset + ")]");
			if (typeName == "Boolean" || typeName == "bool")
			{
				typeSize = 1;
				stringBuilder.AppendLine("[MarshalAs(UnmanagedType.I1)]");
			}
			stringBuilder.AppendLine("public " + typeName + " " + name + ";");
			offset += typeSize;
			if (align && offset % pad != 0)
			{
				offset += pad - offset % pad;
			}
		}

		private static void FormatStructField(StringBuilder stringBuilder, string name, Type type, int typeSize, ref int offset, int pad, bool align = false)
		{
			FormatStructField(stringBuilder, name, type.Name, typeSize, ref offset, pad, align);
		}

		private static void FormatStructField(StringBuilder stringBuilder, string name, Type type, ref int offset, int pad, bool align = false)
		{
			FormatStructField(stringBuilder, name, type.Name, Marshal.SizeOf(type), ref offset, pad, align);
		}

		private static string GetString()
		{
			int offset = 0;
			int pad = 8;
			int size = IntPtr.Size;
			StringBuilder stringBuilder = new StringBuilder();
			FormatStructField(stringBuilder, "vfptr", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "bSuppressEventTag", typeof(bool), ref offset, pad);
			FormatStructField(stringBuilder, "bAutoEmitLineTerminator", typeof(bool), ref offset, pad, align: true);
			FormatStructField(stringBuilder, "Node", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "Object", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "Code", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "Locals", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "MostRecentProperty", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "MostRecentPropertyAddress", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "FlowStack", "FScriptArray", 48, ref offset, pad);
			FormatStructField(stringBuilder, "PreviousFrame", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "OutParms", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "PropertyChainForCompiledIn", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "CurrentNativeFunction", typeof(IntPtr), size, ref offset, pad);
			FormatStructField(stringBuilder, "bArrayContextFailed", typeof(bool), ref offset, pad, align: true);
			stringBuilder.Insert(0, "{" + Environment.NewLine);
			stringBuilder.Insert(0, "public struct FFrame" + Environment.NewLine);
			stringBuilder.Insert(0, "[StructLayout(LayoutKind.Explicit, Size = " + offset + ")]" + Environment.NewLine);
			stringBuilder.AppendLine("}");
			return stringBuilder.ToString();
		}
	}

	[FieldOffset(0)]
	public IntPtr vfptr;

	[FieldOffset(8)]
	[MarshalAs(UnmanagedType.I1)]
	public bool bSuppressEventTag;

	[FieldOffset(9)]
	[MarshalAs(UnmanagedType.I1)]
	public bool bAutoEmitLineTerminator;

	[FieldOffset(16)]
	public IntPtr Node;

	[FieldOffset(24)]
	public IntPtr Object;

	[FieldOffset(32)]
	public IntPtr Code;

	[FieldOffset(40)]
	public IntPtr Locals;

	[FieldOffset(48)]
	public IntPtr MostRecentProperty;

	[FieldOffset(56)]
	public IntPtr MostRecentPropertyAddress;

	[FieldOffset(64)]
	public FScriptArray FlowStack;

	[FieldOffset(112)]
	public IntPtr PreviousFrame;

	[FieldOffset(120)]
	public IntPtr OutParms;

	[FieldOffset(128)]
	public IntPtr PropertyChainForCompiledIn;

	[FieldOffset(136)]
	public IntPtr CurrentNativeFunction;

	[FieldOffset(144)]
	[MarshalAs(UnmanagedType.I1)]
	public bool bArrayContextFailed;

	public unsafe FOutParmRec* OutParmsPtr => (FOutParmRec*)(void*)OutParms;

	public void PFinish()
	{
		if (Code != IntPtr.Zero)
		{
			Code += 1;
		}
	}

	public unsafe byte PeekCode()
	{
		return *(byte*)(void*)Code;
	}

	public void SkipCode(int numOps)
	{
		Code += numOps;
	}

	public void Step(IntPtr context, IntPtr result)
	{
		Native_FFrameRef.Step(ref this, context, result);
	}

	public void StepExplicitProperty(IntPtr result, IntPtr property)
	{
		Native_FFrameRef.StepExplicitProperty(ref this, result, property);
	}

	public void StepCompiledIn(IntPtr result)
	{
		if (Code != IntPtr.Zero)
		{
			Step(Object, result);
			return;
		}
		IntPtr propertyChainForCompiledIn = PropertyChainForCompiledIn;
		PropertyChainForCompiledIn = Native_UField.Get_Next(PropertyChainForCompiledIn);
		StepExplicitProperty(result, propertyChainForCompiledIn);
	}

	public byte ReadByte()
	{
		return Native_FFrameRef.ReadUInt8(ref this);
	}

	public sbyte ReadSByte()
	{
		return Native_FFrameRef.ReadInt8(ref this);
	}

	public short ReadInt16()
	{
		return Native_FFrameRef.ReadInt16(ref this);
	}

	public ushort ReadUInt16()
	{
		return Native_FFrameRef.ReadUInt16(ref this);
	}

	public int ReadInt32()
	{
		return Native_FFrameRef.ReadInt32(ref this);
	}

	public uint ReadUInt32()
	{
		return Native_FFrameRef.ReadUInt32(ref this);
	}

	public long ReadInt64()
	{
		return Native_FFrameRef.ReadInt64(ref this);
	}

	public ulong ReadUInt64()
	{
		return Native_FFrameRef.ReadUInt64(ref this);
	}

	public float ReadFloat()
	{
		return Native_FFrameRef.ReadFloat(ref this);
	}

	public FName ReadName()
	{
		Native_FFrameRef.ReadName(ref this, out var result);
		return result;
	}

	public IntPtr ReadObject()
	{
		return Native_FFrameRef.ReadObject(ref this);
	}

	public int ReadCodeSkipCount()
	{
		return Native_FFrameRef.ReadCodeSkipCount(ref this);
	}

	public int ReadVariableSize(IntPtr expressionField)
	{
		return Native_FFrameRef.ReadVariableSize(ref this, expressionField);
	}

	public string GetStackTrace()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FFrameRef.GetStackTrace(ref this, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static string GetScriptCallstack()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FFrameRef.GetScriptCallstack(ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}
}
