using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUS_ActorConfigInfoComp")]
public class BUS_ActorConfigInfoComp : UActorEditCompBase
{
	private static bool GameplayTagGuid_IsValid;

	private static int GameplayTagGuid_Offset;

	private static bool GameplayTagGuidForGroup_IsValid;

	private static int GameplayTagGuidForGroup_Offset;

	private static bool CircusConfig_IsValid;

	private static int CircusConfig_Offset;

	[Category("Actor Config Info")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuid")]
	public FGameplayTag GameplayTagGuid
	{
		get
		{
			CheckDestroyed();
			if (!GameplayTagGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuid");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, GameplayTagGuid_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameplayTagGuid_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuid");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, GameplayTagGuid_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("Actor Config Info")]
	[USharpPath("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuidForGroup")]
	public FGameplayTag GameplayTagGuidForGroup
	{
		get
		{
			CheckDestroyed();
			if (!GameplayTagGuidForGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuidForGroup");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, GameplayTagGuidForGroup_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GameplayTagGuidForGroup_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:GameplayTagGuidForGroup");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, GameplayTagGuidForGroup_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Circus")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUS_ActorConfigInfoComp:CircusConfig")]
	public FCircusConfigNonCharacter CircusConfig
	{
		get
		{
			CheckDestroyed();
			if (!CircusConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:CircusConfig");
				return default(FCircusConfigNonCharacter);
			}
			return FCircusConfigNonCharacter.FromNative(IntPtr.Add(base.Address, CircusConfig_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircusConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_ActorConfigInfoComp:CircusConfig");
			}
			else
			{
				FCircusConfigNonCharacter.ToNative(IntPtr.Add(base.Address, CircusConfig_Offset), value);
			}
		}
	}

	public override void OnDataConvert(AActor Owner)
	{
		BUC_GuidData bUC_GuidData = RequireWritableData<BUC_GuidData>();
		bUC_GuidData.UnitFixedGuid = GameplayTagGuid;
		bUC_GuidData.UnitFixedGuidForGroup = GameplayTagGuidForGroup;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUS_ActorConfigInfoComp");
		GameplayTagGuid_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GameplayTagGuid");
		GameplayTagGuid_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GameplayTagGuid", Classes.FStructProperty);
		GameplayTagGuidForGroup_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GameplayTagGuidForGroup");
		GameplayTagGuidForGroup_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GameplayTagGuidForGroup", Classes.FStructProperty);
		CircusConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CircusConfig");
		CircusConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CircusConfig", Classes.FStructProperty);
	}

	static BUS_ActorConfigInfoComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_ActorConfigInfoComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_ActorConfigInfoComp));
	}
}
