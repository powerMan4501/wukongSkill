using System;
using System.Security;

namespace Google.Protobuf;

[SecuritySafeCritical]
public static class UnsafeByteOperations
{
	public static ByteString UnsafeWrap(ReadOnlyMemory<byte> bytes)
	{
		return ByteString.AttachBytes(bytes);
	}
}
