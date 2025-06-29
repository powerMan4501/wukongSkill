using System.Runtime.InteropServices;

namespace System.Threading;

[ComVisible(true)]
[__DynamicallyInvokable]
public static class Timeout
{
	[ComVisible(false)]
	[__DynamicallyInvokable]
	public static readonly TimeSpan InfiniteTimeSpan = new TimeSpan(0, 0, 0, 0, -1);

	[__DynamicallyInvokable]
	public const int Infinite = -1;

	internal const uint UnsignedInfinite = uint.MaxValue;
}
