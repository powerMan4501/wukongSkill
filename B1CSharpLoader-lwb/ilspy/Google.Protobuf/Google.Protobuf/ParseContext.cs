using System;
using System.Buffers;
using System.Runtime.CompilerServices;
using System.Security;

namespace Google.Protobuf;

[SecuritySafeCritical]
public ref struct ParseContext
{
	internal const int DefaultRecursionLimit = 100;

	internal const int DefaultSizeLimit = int.MaxValue;

	internal ReadOnlySpan<byte> buffer;

	internal ParserInternalState state;

	internal uint LastTag => state.lastTag;

	internal bool DiscardUnknownFields
	{
		get
		{
			return state.DiscardUnknownFields;
		}
		set
		{
			state.DiscardUnknownFields = value;
		}
	}

	internal ExtensionRegistry ExtensionRegistry
	{
		get
		{
			return state.ExtensionRegistry;
		}
		set
		{
			state.ExtensionRegistry = value;
		}
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Initialize(ref ReadOnlySpan<byte> buffer, ref ParserInternalState state, out ParseContext ctx)
	{
		ctx.buffer = buffer;
		ctx.state = state;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Initialize(CodedInputStream input, out ParseContext ctx)
	{
		ctx.buffer = new ReadOnlySpan<byte>(input.InternalBuffer);
		ctx.state = input.InternalState;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Initialize(ReadOnlySequence<byte> input, out ParseContext ctx)
	{
		Initialize(input, 100, out ctx);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	internal static void Initialize(ReadOnlySequence<byte> input, int recursionLimit, out ParseContext ctx)
	{
		ctx.buffer = default(ReadOnlySpan<byte>);
		ctx.state = default(ParserInternalState);
		ctx.state.lastTag = 0u;
		ctx.state.recursionDepth = 0;
		ctx.state.sizeLimit = int.MaxValue;
		ctx.state.recursionLimit = recursionLimit;
		ctx.state.currentLimit = int.MaxValue;
		SegmentedBufferHelper.Initialize(input, out ctx.state.segmentedBufferHelper, out ctx.buffer);
		ctx.state.bufferPos = 0;
		ctx.state.bufferSize = ctx.buffer.Length;
		ctx.state.DiscardUnknownFields = false;
		ctx.state.ExtensionRegistry = null;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint ReadTag()
	{
		return ParsingPrimitives.ParseTag(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public double ReadDouble()
	{
		return ParsingPrimitives.ParseDouble(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public float ReadFloat()
	{
		return ParsingPrimitives.ParseFloat(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ulong ReadUInt64()
	{
		return ParsingPrimitives.ParseRawVarint64(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public long ReadInt64()
	{
		return (long)ParsingPrimitives.ParseRawVarint64(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int ReadInt32()
	{
		return (int)ParsingPrimitives.ParseRawVarint32(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ulong ReadFixed64()
	{
		return ParsingPrimitives.ParseRawLittleEndian64(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint ReadFixed32()
	{
		return ParsingPrimitives.ParseRawLittleEndian32(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public bool ReadBool()
	{
		return ParsingPrimitives.ParseRawVarint64(ref buffer, ref state) != 0;
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public string ReadString()
	{
		return ParsingPrimitives.ReadString(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ReadMessage(IMessage message)
	{
		ParsingPrimitivesMessages.ReadMessage(ref this, message);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public void ReadGroup(IMessage message)
	{
		ParsingPrimitivesMessages.ReadGroup(ref this, message);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public ByteString ReadBytes()
	{
		return ParsingPrimitives.ReadBytes(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public uint ReadUInt32()
	{
		return ParsingPrimitives.ParseRawVarint32(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int ReadEnum()
	{
		return (int)ParsingPrimitives.ParseRawVarint32(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int ReadSFixed32()
	{
		return (int)ParsingPrimitives.ParseRawLittleEndian32(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public long ReadSFixed64()
	{
		return (long)ParsingPrimitives.ParseRawLittleEndian64(ref buffer, ref state);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int ReadSInt32()
	{
		return ParsingPrimitives.DecodeZigZag32(ParsingPrimitives.ParseRawVarint32(ref buffer, ref state));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public long ReadSInt64()
	{
		return ParsingPrimitives.DecodeZigZag64(ParsingPrimitives.ParseRawVarint64(ref buffer, ref state));
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public int ReadLength()
	{
		return (int)ParsingPrimitives.ParseRawVarint32(ref buffer, ref state);
	}

	internal void CopyStateTo(CodedInputStream input)
	{
		input.InternalState = state;
	}

	internal void LoadStateFrom(CodedInputStream input)
	{
		state = input.InternalState;
	}
}
