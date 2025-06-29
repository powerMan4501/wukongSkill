using System;
using System.Buffers;
using System.IO;
using System.Security;

namespace Google.Protobuf;

public static class MessageExtensions
{
	public static void MergeFrom(this IMessage message, byte[] data)
	{
		message.MergeFrom(data, discardUnknownFields: false, null);
	}

	public static void MergeFrom(this IMessage message, byte[] data, int offset, int length)
	{
		message.MergeFrom(data, offset, length, discardUnknownFields: false, null);
	}

	public static void MergeFrom(this IMessage message, ByteString data)
	{
		message.MergeFrom(data, discardUnknownFields: false, null);
	}

	public static void MergeFrom(this IMessage message, Stream input)
	{
		message.MergeFrom(input, discardUnknownFields: false, null);
	}

	public static void MergeDelimitedFrom(this IMessage message, Stream input)
	{
		message.MergeDelimitedFrom(input, discardUnknownFields: false, null);
	}

	public static byte[] ToByteArray(this IMessage message)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		byte[] array = new byte[message.CalculateSize()];
		CodedOutputStream codedOutputStream = new CodedOutputStream(array);
		message.WriteTo(codedOutputStream);
		codedOutputStream.CheckNoSpaceLeft();
		return array;
	}

	public static void WriteTo(this IMessage message, Stream output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(output, "output");
		CodedOutputStream codedOutputStream = new CodedOutputStream(output);
		message.WriteTo(codedOutputStream);
		codedOutputStream.Flush();
	}

	public static void WriteDelimitedTo(this IMessage message, Stream output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(output, "output");
		CodedOutputStream codedOutputStream = new CodedOutputStream(output);
		codedOutputStream.WriteLength(message.CalculateSize());
		message.WriteTo(codedOutputStream);
		codedOutputStream.Flush();
	}

	public static ByteString ToByteString(this IMessage message)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		return ByteString.AttachBytes(message.ToByteArray());
	}

	[SecuritySafeCritical]
	public static void WriteTo(this IMessage message, IBufferWriter<byte> output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(output, "output");
		WriteContext.Initialize(output, out var ctx);
		WritingPrimitivesMessages.WriteRawMessage(ref ctx, message);
		ctx.Flush();
	}

	[SecuritySafeCritical]
	public static void WriteTo(this IMessage message, Span<byte> output)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		WriteContext.Initialize(ref output, out var ctx);
		WritingPrimitivesMessages.WriteRawMessage(ref ctx, message);
		ctx.CheckNoSpaceLeft();
	}

	public static bool IsInitialized(this IMessage message)
	{
		return false;
	}

	internal static void MergeFrom(this IMessage message, byte[] data, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = new CodedInputStream(data);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		codedInputStream.ExtensionRegistry = registry;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, byte[] data, int offset, int length, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = new CodedInputStream(data, offset, length);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		codedInputStream.ExtensionRegistry = registry;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, ByteString data, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(data, "data");
		CodedInputStream codedInputStream = data.CreateCodedInput();
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		codedInputStream.ExtensionRegistry = registry;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	internal static void MergeFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(input, "input");
		CodedInputStream codedInputStream = new CodedInputStream(input);
		codedInputStream.DiscardUnknownFields = discardUnknownFields;
		codedInputStream.ExtensionRegistry = registry;
		message.MergeFrom(codedInputStream);
		codedInputStream.CheckReadEndOfStreamTag();
	}

	[SecuritySafeCritical]
	internal static void MergeFrom(this IMessage message, ReadOnlySequence<byte> data, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ParseContext.Initialize(data, out var ctx);
		ctx.DiscardUnknownFields = discardUnknownFields;
		ctx.ExtensionRegistry = registry;
		ParsingPrimitivesMessages.ReadRawMessage(ref ctx, message);
		ParsingPrimitivesMessages.CheckReadEndOfStreamTag(ref ctx.state);
	}

	internal static void MergeDelimitedFrom(this IMessage message, Stream input, bool discardUnknownFields, ExtensionRegistry registry)
	{
		ProtoPreconditions.CheckNotNull(message, "message");
		ProtoPreconditions.CheckNotNull(input, "input");
		int size = (int)CodedInputStream.ReadRawVarint32(input);
		Stream input2 = new LimitedInputStream(input, size);
		message.MergeFrom(input2, discardUnknownFields, registry);
	}
}
