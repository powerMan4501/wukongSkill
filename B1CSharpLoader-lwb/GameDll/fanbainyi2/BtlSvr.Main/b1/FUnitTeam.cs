using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

[UStruct]
[USharpPath("/Script/b1-Managed.UnitTeam")]
public struct FUnitTeam
{
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UnitTeam:CharacterList")]
	public List<BGUCharacterCS> CharacterList;

	private static int UnitTeam_StructSize;

	private static int UnitTeam_IsValid;

	private static bool CharacterList_IsValid;

	private static int CharacterList_Offset;

	private static FFieldAddress CharacterList_PropertyAddress;

	public FUnitTeam Copy()
	{
		FUnitTeam result = this;
		if (CharacterList != null)
		{
			result.CharacterList = new List<BGUCharacterCS>(CharacterList);
		}
		return result;
	}

	public static FUnitTeam FromNative(IntPtr nativeBuffer)
	{
		return new FUnitTeam(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FUnitTeam value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FUnitTeam FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FUnitTeam(IntPtr.Add(nativeBuffer, arrayIndex * UnitTeam_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FUnitTeam value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UnitTeam_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UnitTeam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitTeam");
		}
		else
		{
			new TArrayCopyMarshaler<BGUCharacterCS>(1, CharacterList_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).ToNative(IntPtr.Add(nativeStruct, CharacterList_Offset), CharacterList);
		}
	}

	public FUnitTeam(IntPtr nativeStruct)
	{
		if (UnitTeam_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UnitTeam");
			CharacterList = null;
		}
		else
		{
			CharacterList = new TArrayCopyMarshaler<BGUCharacterCS>(1, CharacterList_PropertyAddress, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.FromNative, CachedMarshalingDelegates<BGUCharacterCS, UObjectMarshaler<BGUCharacterCS>>.ToNative).FromNative(IntPtr.Add(nativeStruct, CharacterList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UnitTeam");
		UnitTeam_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref CharacterList_PropertyAddress, intPtr, "CharacterList");
		CharacterList_Offset = NativeReflection.GetPropertyOffset(intPtr, "CharacterList");
		CharacterList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CharacterList", Classes.FArrayProperty);
		UnitTeam_IsValid = ((intPtr != IntPtr.Zero && CharacterList_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UnitTeam", (byte)UnitTeam_IsValid != 0);
	}

	static FUnitTeam()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(FUnitTeam)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FUnitTeam));
	}
}
