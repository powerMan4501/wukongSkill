namespace UnrealEngine.Runtime;

public static class CachedMarshalingDelegates<T, TMarshaler>
{
	public static readonly MarshalingDelegates<T>.FromNative FromNative = MarshalingDelegateResolver<T>.FromNative;

	public static readonly MarshalingDelegates<T>.ToNative ToNative = MarshalingDelegateResolver<T>.ToNative;

	public static readonly MarshalingDelegates<T>.Destroy Destroy = MarshalingDelegateResolver<T>.Destroy;
}
