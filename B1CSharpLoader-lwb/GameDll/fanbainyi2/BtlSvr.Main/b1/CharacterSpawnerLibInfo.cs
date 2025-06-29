using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.CharacterSpawnerLibInfo")]
public struct CharacterSpawnerLibInfo
{
	[Category("Character Spawner Lib Info")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("角色蓝图")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CharacterSpawnerLibInfo:SpawnClass")]
	public TSubclassOf<BGUCharacterCS> SpawnClass;

	[Category("Character Spawner Lib Info")]
	[DisplayName("角色是否可以成为精英怪")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.CharacterSpawnerLibInfo:CanBeElite")]
	public bool CanBeElite;

	private static int CharacterSpawnerLibInfo_StructSize;

	private static int CharacterSpawnerLibInfo_IsValid;

	private static bool SpawnClass_IsValid;

	private static int SpawnClass_Offset;

	private static bool CanBeElite_IsValid;

	private static int CanBeElite_Offset;

	private static FFieldAddress CanBeElite_PropertyAddress;

	public CharacterSpawnerLibInfo Copy()
	{
		return this;
	}

	public static CharacterSpawnerLibInfo FromNative(IntPtr nativeBuffer)
	{
		return new CharacterSpawnerLibInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, CharacterSpawnerLibInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static CharacterSpawnerLibInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new CharacterSpawnerLibInfo(IntPtr.Add(nativeBuffer, arrayIndex * CharacterSpawnerLibInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, CharacterSpawnerLibInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * CharacterSpawnerLibInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (CharacterSpawnerLibInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CharacterSpawnerLibInfo");
			return;
		}
		TSubclassOfMarshaler<BGUCharacterCS>.ToNative(IntPtr.Add(nativeStruct, SpawnClass_Offset), SpawnClass);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, CanBeElite_Offset), 0, CanBeElite_PropertyAddress.Address, CanBeElite);
	}

	public CharacterSpawnerLibInfo(IntPtr nativeStruct)
	{
		if (CharacterSpawnerLibInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.CharacterSpawnerLibInfo");
			SpawnClass = default(TSubclassOf<BGUCharacterCS>);
			CanBeElite = false;
		}
		else
		{
			SpawnClass = TSubclassOfMarshaler<BGUCharacterCS>.FromNative(IntPtr.Add(nativeStruct, SpawnClass_Offset));
			CanBeElite = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, CanBeElite_Offset), 0, CanBeElite_PropertyAddress.Address);
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.CharacterSpawnerLibInfo");
		CharacterSpawnerLibInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SpawnClass_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnClass");
		SpawnClass_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnClass", Classes.FClassProperty);
		NativeReflection.GetPropertyRef(ref CanBeElite_PropertyAddress, intPtr, "CanBeElite");
		CanBeElite_Offset = NativeReflection.GetPropertyOffset(intPtr, "CanBeElite");
		CanBeElite_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CanBeElite", Classes.FBoolProperty);
		CharacterSpawnerLibInfo_IsValid = ((intPtr != IntPtr.Zero && SpawnClass_IsValid && CanBeElite_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.CharacterSpawnerLibInfo", (byte)CharacterSpawnerLibInfo_IsValid != 0);
	}

	static CharacterSpawnerLibInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(CharacterSpawnerLibInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(CharacterSpawnerLibInfo));
	}
}
