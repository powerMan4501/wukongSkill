using AOT;

namespace UnrealEngine.Runtime.Native;

internal static class Native_FGameplayTag
{
	[MonoNativeFunctionWrapper]
	public delegate void Del_RequestGameplayTag(out FGameplayTag OutTag, ref FName InTagName, bool ErrorIfNotFound);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsEqual(ref FGameplayTag Tag, ref FGameplayTag Other);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_NotEqual(ref FGameplayTag Tag, ref FGameplayTag Other);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_SmallThan(ref FGameplayTag Tag, ref FGameplayTag Other);

	[MonoNativeFunctionWrapper]
	public delegate int Del_GetTypeHash(ref FGameplayTag Tag);

	[MonoNativeFunctionWrapper]
	public delegate csbool Del_IsValid(ref FGameplayTag Tag);

	[MonoNativeFunctionWrapper]
	public delegate void Del_ToString(ref FGameplayTag Tag, out FScriptArray Result);

	public static Del_RequestGameplayTag RequestGameplayTag;

	public static Del_IsEqual IsEqual;

	public static Del_NotEqual NotEqual;

	public static Del_SmallThan SmallThan;

	public static Del_GetTypeHash GetTypeHash;

	public static Del_IsValid IsValid;

	public new static Del_ToString ToString;
}
