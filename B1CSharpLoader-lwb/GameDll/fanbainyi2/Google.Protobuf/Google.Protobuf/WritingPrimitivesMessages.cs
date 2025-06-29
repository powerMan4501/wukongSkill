using System.Runtime.CompilerServices;
using System.Security;

namespace Google.Protobuf;

[SecuritySafeCritical]
internal static class WritingPrimitivesMessages
{
	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteMessage(ref WriteContext ctx, IMessage value)
	{
		WritingPrimitives.WriteLength(ref ctx.buffer, ref ctx.state, value.CalculateSize());
		WriteRawMessage(ref ctx, value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteGroup(ref WriteContext ctx, IMessage value)
	{
		WriteRawMessage(ref ctx, value);
	}

	[MethodImpl(MethodImplOptions.AggressiveInlining)]
	public static void WriteRawMessage(ref WriteContext ctx, IMessage message)
	{
		if (message is IBufferMessage bufferMessage)
		{
			bufferMessage.InternalWriteTo(ref ctx);
			return;
		}
		if (ctx.state.CodedOutputStream == null)
		{
			throw new InvalidProtocolBufferException("Message " + message.GetType().Name + " doesn't provide the generated method that enables WriteContext-based serialization. You might need to regenerate the generated protobuf code.");
		}
		ctx.CopyStateTo(ctx.state.CodedOutputStream);
		try
		{
			message.WriteTo(ctx.state.CodedOutputStream);
		}
		finally
		{
			ctx.LoadStateFrom(ctx.state.CodedOutputStream);
		}
	}
}
