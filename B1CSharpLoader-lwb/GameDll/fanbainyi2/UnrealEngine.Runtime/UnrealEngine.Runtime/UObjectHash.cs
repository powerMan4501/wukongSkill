using System;
using System.Linq;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public class UObjectHash
{
	public static UObject[] GetObjectsWithOuter(UObject outer, bool includeNestedObjects = true, EObjectFlags exclusionFlags = EObjectFlags.NoFlags, EInternalObjectFlags exclusionInternalFlags = EInternalObjectFlags.None)
	{
		using TArrayUnsafe<UObject> tArrayUnsafe = new TArrayUnsafe<UObject>();
		Native_UObjectHash.GetObjectsWithOuter(outer.Address, tArrayUnsafe.Address, includeNestedObjects, exclusionFlags, exclusionInternalFlags);
		return tArrayUnsafe.ToArray();
	}

	public static UObject FindObjectWithOuter(UObject outer, UClass classToLookFor = null, FName nameToLookFor = default(FName))
	{
		return GCHelper.Find<UObject>(Native_UObjectHash.FindObjectWithOuter(outer.Address, (classToLookFor == null) ? IntPtr.Zero : classToLookFor.Address, ref nameToLookFor));
	}

	public static UObject[] GetObjectsOfClass<T>(bool includeDerivedClasses = true, EObjectFlags additionalExcludeFlags = EObjectFlags.ClassDefaultObject, EInternalObjectFlags exclusionInternalFlags = EInternalObjectFlags.None) where T : UObject
	{
		return GetObjectsOfClass(UClass.GetClass<T>(), includeDerivedClasses, additionalExcludeFlags, exclusionInternalFlags);
	}

	public static UObject[] GetObjectsOfClass(UClass classToLookFor, bool includeDerivedClasses = true, EObjectFlags additionalExcludeFlags = EObjectFlags.ClassDefaultObject, EInternalObjectFlags exclusionInternalFlags = EInternalObjectFlags.None)
	{
		using TArrayUnsafe<UObject> tArrayUnsafe = new TArrayUnsafe<UObject>();
		Native_UObjectHash.GetObjectsOfClass(classToLookFor.Address, tArrayUnsafe.Address, includeDerivedClasses, additionalExcludeFlags, exclusionInternalFlags);
		return tArrayUnsafe.ToArray();
	}

	public static UClass[] GetDerivedClasses<T>(bool recursive = true) where T : UObject
	{
		return GetDerivedClasses(UClass.GetClass<T>(), recursive);
	}

	public static UClass[] GetDerivedClasses(UClass classToLookFor, bool recursive = true)
	{
		using TArrayUnsafe<UClass> tArrayUnsafe = new TArrayUnsafe<UClass>();
		Native_UObjectHash.GetDerivedClasses(classToLookFor.Address, tArrayUnsafe.Address, recursive);
		return tArrayUnsafe.ToArray();
	}
}
