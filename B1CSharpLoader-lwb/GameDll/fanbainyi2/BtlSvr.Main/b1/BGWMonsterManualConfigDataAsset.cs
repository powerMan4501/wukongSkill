using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWMonsterManualConfigDataAsset")]
public class BGWMonsterManualConfigDataAsset : UBGWDataAsset
{
	private static bool MPCBook_IsValid;

	private static int MPCBook_Offset;

	private static bool MonsterManualInfoMap_IsValid;

	private static int MonsterManualInfoMap_Offset;

	private static FFieldAddress MonsterManualInfoMap_PropertyAddress;

	private TMapReadWriteMarshaler<int, FMonsterManualInfo> MonsterManualInfoMap_Marshaler;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWMonsterManualConfigDataAsset:MPCBook")]
	public UMaterialParameterCollection MPCBook
	{
		get
		{
			CheckDestroyed();
			if (!MPCBook_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonsterManualConfigDataAsset:MPCBook");
				return null;
			}
			return UObjectMarshaler<UMaterialParameterCollection>.FromNative(IntPtr.Add(base.Address, MPCBook_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MPCBook_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonsterManualConfigDataAsset:MPCBook");
			}
			else
			{
				UObjectMarshaler<UMaterialParameterCollection>.ToNative(IntPtr.Add(base.Address, MPCBook_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("图鉴Info")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWMonsterManualConfigDataAsset:MonsterManualInfoMap")]
	public TMapReadWrite<int, FMonsterManualInfo> MonsterManualInfoMap
	{
		get
		{
			CheckDestroyed();
			if (!MonsterManualInfoMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWMonsterManualConfigDataAsset:MonsterManualInfoMap");
				return null;
			}
			if (MonsterManualInfoMap_Marshaler == null)
			{
				MonsterManualInfoMap_Marshaler = new TMapReadWriteMarshaler<int, FMonsterManualInfo>(1, MonsterManualInfoMap_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative, CachedMarshalingDelegates<FMonsterManualInfo, FMonsterManualInfo>.FromNative, CachedMarshalingDelegates<FMonsterManualInfo, FMonsterManualInfo>.ToNative);
			}
			return MonsterManualInfoMap_Marshaler.FromNative(IntPtr.Add(base.Address, MonsterManualInfoMap_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWMonsterManualConfigDataAsset");
		MPCBook_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MPCBook");
		MPCBook_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MPCBook", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref MonsterManualInfoMap_PropertyAddress, unrealStruct, "MonsterManualInfoMap");
		MonsterManualInfoMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MonsterManualInfoMap");
		MonsterManualInfoMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MonsterManualInfoMap", Classes.FMapProperty);
	}

	static BGWMonsterManualConfigDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWMonsterManualConfigDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWMonsterManualConfigDataAsset));
	}
}
