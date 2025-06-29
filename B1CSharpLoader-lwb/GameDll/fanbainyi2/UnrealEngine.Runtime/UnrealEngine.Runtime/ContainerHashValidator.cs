using System;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Runtime;

public static class ContainerHashValidator
{
	public static void Validate(IntPtr property)
	{
		if (!FBuild.BuildShipping && !IsValid(property))
		{
			throw new ArgumentException("This type is not valid for a TSet/TMap as it doesn't have a GetTypeHash function.");
		}
	}

	public static bool IsValid(IntPtr property)
	{
		return IsValidInternal(property);
	}

	private static bool IsValidInternal(IntPtr property)
	{
		if ((bool)Native_FField.IsA(property, Classes.FBoolProperty))
		{
			return false;
		}
		if ((bool)Native_FField.IsA(property, Classes.FTextProperty))
		{
			return false;
		}
		if (!Native_FField.IsA(property, Classes.FStructProperty))
		{
			return true;
		}
		IntPtr intPtr = Native_FStructProperty.Get_Struct(property);
		if (intPtr != IntPtr.Zero && (bool)Native_UObjectBaseUtility.IsA(intPtr, Classes.UScriptStruct))
		{
			return StructHasGetTypeHash(intPtr);
		}
		return false;
	}

	private static bool PropertyHasGetTypeHash(IntPtr property)
	{
		return Native_FProperty.HasAllPropertyFlags(property, EPropertyFlags.HasGetValueTypeHash);
	}

	private static bool StructHasGetTypeHash(IntPtr unrealStruct)
	{
		if ((bool)Native_UObjectBaseUtility.IsNative(unrealStruct))
		{
			IntPtr intPtr = Native_UScriptStruct.GetCppStructOps(unrealStruct);
			if (intPtr != IntPtr.Zero)
			{
				return Native_ICppStructOps.HasGetTypeHash(intPtr);
			}
			return false;
		}
		foreach (IntPtr item in new NativeReflection.NativeFFieldIterator(Classes.FProperty, unrealStruct))
		{
			if (!Native_FField.IsA(item, Classes.FBoolProperty) && !PropertyHasGetTypeHash(item))
			{
				return false;
			}
		}
		return true;
	}
}
