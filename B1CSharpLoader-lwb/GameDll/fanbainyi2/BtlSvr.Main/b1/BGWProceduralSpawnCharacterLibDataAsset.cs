using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWProceduralSpawnCharacterLibDataAsset")]
public class BGWProceduralSpawnCharacterLibDataAsset : UBGWDataAsset
{
	private static bool CharacterInfoList_IsValid;

	private static int CharacterInfoList_Offset;

	private static FFieldAddress CharacterInfoList_PropertyAddress;

	private TArrayReadWriteMarshaler<CharacterSpawnerLibInfo> CharacterInfoList_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Character Spawn Lib")]
	[DisplayName("怪物组合库")]
	[USharpPath("/Script/b1-Managed.BGWProceduralSpawnCharacterLibDataAsset:CharacterInfoList")]
	public TArrayReadWrite<CharacterSpawnerLibInfo> CharacterInfoList
	{
		get
		{
			CheckDestroyed();
			if (!CharacterInfoList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWProceduralSpawnCharacterLibDataAsset:CharacterInfoList");
				return null;
			}
			if (CharacterInfoList_Marshaler == null)
			{
				CharacterInfoList_Marshaler = new TArrayReadWriteMarshaler<CharacterSpawnerLibInfo>(1, CharacterInfoList_PropertyAddress, CachedMarshalingDelegates<CharacterSpawnerLibInfo, CharacterSpawnerLibInfo>.FromNative, CachedMarshalingDelegates<CharacterSpawnerLibInfo, CharacterSpawnerLibInfo>.ToNative);
			}
			return CharacterInfoList_Marshaler.FromNative(IntPtr.Add(base.Address, CharacterInfoList_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWProceduralSpawnCharacterLibDataAsset");
		NativeReflection.GetPropertyRef(ref CharacterInfoList_PropertyAddress, unrealStruct, "CharacterInfoList");
		CharacterInfoList_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CharacterInfoList");
		CharacterInfoList_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CharacterInfoList", Classes.FArrayProperty);
	}

	static BGWProceduralSpawnCharacterLibDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWProceduralSpawnCharacterLibDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWProceduralSpawnCharacterLibDataAsset));
	}
}
