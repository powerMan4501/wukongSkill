using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.InputCore;

[UStruct(Flags = 987649)]
[BlueprintType]
[UMetaPath("/Script/InputCore.Key", "InputCore", UnrealModuleType.Engine)]
public struct FKey : IEquatable<FKey>, IComparable<FKey>
{
	private static Dictionary<EKeys, FName> keyNames = new Dictionary<EKeys, FName>();

	private FName keyName;

	private FSharedPtr keyDetails;

	public bool IsValid => Native_FKey.IsValid(ref this);

	public bool IsModifierKey => Native_FKey.IsModifierKey(ref this);

	public bool IsGamepadKey => Native_FKey.IsGamepadKey(ref this);

	public bool IsMouseButton => Native_FKey.IsMouseButton(ref this);

	public bool IsFloatAxis => Native_FKey.IsFloatAxis(ref this);

	public bool IsVectorAxis => Native_FKey.IsVectorAxis(ref this);

	public bool IsBindableInBlueprints => Native_FKey.IsBindableInBlueprints(ref this);

	public bool ShouldUpdateAxisWithoutSamples => Native_FKey.ShouldUpdateAxisWithoutSamples(ref this);

	public FKey(EKeys key)
	{
		FName value;
		if (key == EKeys.Invalid)
		{
			value = FName.None;
		}
		else if (!keyNames.TryGetValue(key, out value))
		{
			value = new FName(key.ToString());
		}
		keyName = value;
		keyDetails = default(FSharedPtr);
	}

	public static FSharedPtr GetKeyDetailsRef(FKey key)
	{
		Native_FKey.GetKeyDetailsRef(ref key, out var result);
		return result;
	}

	public static int GetKeyDetailsRefCount(FKey key)
	{
		return Native_FKey.GetKeyDetailsRefCount(ref key);
	}

	public string GetDisplayName()
	{
		using FStringUnsafe fStringUnsafe = new FStringUnsafe();
		Native_FKey.GetDisplayNameString(ref this, ref fStringUnsafe.Array);
		return fStringUnsafe.Value;
	}

	public FText GetDisplayNameText()
	{
		FText empty = FText.GetEmpty();
		Native_FKey.GetDisplayName(ref this, empty.Address);
		return empty;
	}

	public FName GetFName()
	{
		return keyName;
	}

	public FName GetMenuCategory()
	{
		Native_FKey.GetMenuCategory(ref this, out var result);
		return result;
	}

	public override string ToString()
	{
		return keyName.ToString();
	}

	public static bool operator ==(FKey a, FKey b)
	{
		return a.keyName == b.keyName;
	}

	public static bool operator !=(FKey a, FKey b)
	{
		return a != b;
	}

	public override bool Equals(object obj)
	{
		if (obj is FKey)
		{
			return Equals((FKey)obj);
		}
		return false;
	}

	public bool Equals(FKey other)
	{
		return keyName.Equals(other.keyName);
	}

	public int CompareTo(FKey other)
	{
		return keyName.CompareTo(other.keyName);
	}

	public override int GetHashCode()
	{
		return keyName.GetHashCode();
	}

	public static implicit operator FKey(EKeys key)
	{
		return new FKey(key);
	}

	[Conditional("DEBUG")]
	private void EnsureValid()
	{
	}

	internal static void OnNativeFunctionsRegistered()
	{
		FieldInfo[] fields = typeof(EKeys).GetFields();
		foreach (FieldInfo fieldInfo in fields)
		{
			DisplayNameAttribute customAttribute = fieldInfo.GetCustomAttribute<DisplayNameAttribute>();
			if (customAttribute != null)
			{
				keyNames[(EKeys)fieldInfo.GetValue(null)] = (FName)customAttribute.Value;
			}
		}
	}

	public FKey Copy()
	{
		return this;
	}

	public static FKey FromNative(IntPtr nativeBuffer)
	{
		return BlittableTypeMarshaler<FKey>.FromNative(nativeBuffer);
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, FKey value)
	{
		Native_FKey.CopyFrom(nativeBuffer, (IntPtr)(&value));
	}

	public static FKey FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return BlittableTypeMarshaler<FKey>.FromNative(nativeBuffer, arrayIndex, prop);
	}

	public unsafe static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FKey value)
	{
		Native_FKey.CopyFrom(nativeBuffer + arrayIndex * sizeof(FKey), (IntPtr)(&value));
	}
}
