namespace ILRuntime.Runtime;

public static class ILRuntimeJITFlags
{
	public const int None = 0;

	public const int JITOnDemand = 1;

	public const int JITImmediately = 2;

	public const int NoJIT = 4;

	public const int ForceInline = 8;
}
