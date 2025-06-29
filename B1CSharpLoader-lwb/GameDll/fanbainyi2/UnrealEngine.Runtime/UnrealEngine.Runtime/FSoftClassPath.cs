using System;

namespace UnrealEngine.Runtime;

[UStruct(Flags = 759818)]
[BlueprintType]
[UMetaPath("/Script/CoreUObject.SoftClassPath", "CoreUObject", UnrealModuleType.Engine)]
public struct FSoftClassPath : IEquatable<FSoftClassPath>
{
	public FSoftObjectPath ObjectPath;

	public FSoftClassPath(FSoftObjectPath objectPath)
	{
		ObjectPath = objectPath;
	}

	public FSoftClassPath(FName assetPathName, string subPathString)
	{
		ObjectPath = new FSoftObjectPath(assetPathName, subPathString);
	}

	public FSoftClassPath(FSoftObjectPathUnsafe softObjectPath)
	{
		ObjectPath = new FSoftObjectPath(softObjectPath);
	}

	public FSoftClassPath(IntPtr softObjectPathPtr)
	{
		ObjectPath = new FSoftObjectPath(softObjectPathPtr);
	}

	public FSoftClassPath(UObject obj)
	{
		ObjectPath = new FSoftObjectPath(obj);
	}

	public UClass TryLoadClass<T>() where T : UObject
	{
		if (ObjectPath.IsValid)
		{
			return UObject.LoadClass<T>(null, ObjectPath.Path);
		}
		return null;
	}

	public UClass ResolveClass()
	{
		return ObjectPath.ResolveObject() as UClass;
	}

	public static bool operator ==(FSoftClassPath a, FSoftClassPath b)
	{
		return a.Equals(b);
	}

	public static bool operator !=(FSoftClassPath a, FSoftClassPath b)
	{
		return !a.Equals(b);
	}

	public override bool Equals(object obj)
	{
		if (obj is FSoftClassPath)
		{
			return Equals((FSoftClassPath)obj);
		}
		return false;
	}

	public bool Equals(FSoftClassPath other)
	{
		return ObjectPath == other.ObjectPath;
	}

	public override int GetHashCode()
	{
		return ObjectPath.GetHashCode();
	}

	public FSoftClassPath Copy()
	{
		return this;
	}

	public static FSoftClassPath FromNative(IntPtr nativeBuffer)
	{
		return new FSoftClassPath(FSoftObjectPathMarshaler.FromNative(nativeBuffer));
	}

	public static void ToNative(IntPtr nativeBuffer, FSoftClassPath value)
	{
		FSoftObjectPathMarshaler.ToNative(nativeBuffer, value.ObjectPath);
	}

	public static FSoftClassPath FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FSoftClassPath(FSoftObjectPathMarshaler.FromNative(nativeBuffer, arrayIndex, prop));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FSoftClassPath value)
	{
		FSoftObjectPathMarshaler.ToNative(nativeBuffer, arrayIndex, prop, value.ObjectPath);
	}
}
