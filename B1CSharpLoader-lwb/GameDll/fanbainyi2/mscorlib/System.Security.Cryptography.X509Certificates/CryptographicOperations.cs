using System.Runtime.CompilerServices;

namespace System.Security.Cryptography.X509Certificates;

internal static class CryptographicOperations
{
	[MethodImpl(MethodImplOptions.NoInlining)]
	public static void ZeroMemory(Span<byte> buffer)
	{
		buffer.Clear();
	}
}
