using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 4254776)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.Name", "CoreUObject", UnrealModuleType.Engine)]
public struct FName : IEquatable<FName>, IComparable<FName>
{
	public enum EFindName
	{
		Find,
		Add,
		Replace_Not_Safe_For_Threading
	}

	public enum ENameCase : byte
	{
		CaseSensitive,
		IgnoreCase
	}

	public int ComparisonIndex;

	public int Number;

	public static readonly FName None = new FName(0, 0);

	public const int MaxNameSize = 1024;

	public string PlainName
	{
		get
		{
			using FStringUnsafe fStringUnsafe = new FStringUnsafe();
			Native_FName.GetPlainNameString(ref this, ref fStringUnsafe.Array);
			return fStringUnsafe.Value;
		}
	}

	public FName(string name, EFindName findType = EFindName.Add)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		Native_FName.FromString(out this, ref fStringUnsafe.Array, findType);
	}

	public FName(string name, int number, EFindName findType = EFindName.Add)
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe(name);
		Native_FName.FromStringNumber(out this, ref fStringUnsafe.Array, number, findType);
	}

	internal FName(int index, int number)
	{
		ComparisonIndex = index;
		Number = number;
	}

	internal FName(int comparisonIndex, int displayIndex, int number)
	{
		ComparisonIndex = comparisonIndex;
		Number = number;
	}

	public override string ToString()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FName.ToString(ref this, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public static bool operator ==(FName a, FName b)
	{
		return Native_FName.IsEqual(ref a, ref b, ENameCase.IgnoreCase, true);
	}

	public static bool operator !=(FName a, FName b)
	{
		return !Native_FName.IsEqual(ref a, ref b, ENameCase.IgnoreCase, true);
	}

	public override bool Equals(object obj)
	{
		if (obj is FName)
		{
			return Equals((FName)obj);
		}
		return false;
	}

	public bool Equals(FName other)
	{
		return Native_FName.IsEqual(ref this, ref other, ENameCase.IgnoreCase, true);
	}

	public int CompareTo(FName other)
	{
		return Native_FName.Compare(ref this, ref other);
	}

	public override int GetHashCode()
	{
		return ComparisonIndex;
	}

	public static explicit operator FName(string value)
	{
		return new FName(value);
	}
}
