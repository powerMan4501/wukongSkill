using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 5117441)]
[BlueprintType]
[UMetaPath("/Script/GameplayTags.GameplayTag", "GameplayTags", UnrealModuleType.Engine)]
public struct FGameplayTag : IEquatable<FGameplayTag>, IComparable<FGameplayTag>, IComparable
{
	public FName TagName;

	public FGameplayTag(FName TagName)
	{
		this = RequestGameplayTag(TagName);
	}

	public static FGameplayTag RequestGameplayTag(FName TagName, bool ErrorIfNotFound = true)
	{
		Native_FGameplayTag.RequestGameplayTag(out var OutTag, ref TagName, ErrorIfNotFound);
		return OutTag;
	}

	public static bool operator ==(FGameplayTag a, FGameplayTag b)
	{
		return Native_FGameplayTag.IsEqual(ref a, ref b);
	}

	public static bool operator !=(FGameplayTag a, FGameplayTag b)
	{
		return Native_FGameplayTag.NotEqual(ref a, ref b);
	}

	public bool Equals(FGameplayTag Other)
	{
		return Native_FGameplayTag.IsEqual(ref this, ref Other);
	}

	public override bool Equals(object obj)
	{
		if (obj is FGameplayTag other)
		{
			return Equals(other);
		}
		return false;
	}

	public override int GetHashCode()
	{
		return Native_FGameplayTag.GetTypeHash(ref this);
	}

	public int CompareTo(FGameplayTag Other)
	{
		return TagName.CompareTo(Other.TagName);
	}

	public int CompareTo(object obj)
	{
		if (obj == null)
		{
			return 1;
		}
		if (!(obj is FGameplayTag other))
		{
			throw new ArgumentException("Object must be of type FGameplayTag");
		}
		return CompareTo(other);
	}

	public override string ToString()
	{
		return TagName.ToString();
	}
}
