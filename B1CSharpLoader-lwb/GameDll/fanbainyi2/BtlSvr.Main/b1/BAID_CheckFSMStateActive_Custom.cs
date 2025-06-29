using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckFSMStateActive_Custom")]
internal class BAID_CheckFSMStateActive_Custom : BAID_Base
{
	private static bool FSMStateTag_IsValid;

	private static int FSMStateTag_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckFSMStateActive_Custom:FSMStateTag")]
	public FGameplayTag FSMStateTag
	{
		get
		{
			CheckDestroyed();
			if (!FSMStateTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFSMStateActive_Custom:FSMStateTag");
				return default(FGameplayTag);
			}
			return BlittableTypeMarshaler<FGameplayTag>.FromNative(IntPtr.Add(base.Address, FSMStateTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FSMStateTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFSMStateActive_Custom:FSMStateTag");
			}
			else
			{
				BlittableTypeMarshaler<FGameplayTag>.ToNative(IntPtr.Add(base.Address, FSMStateTag_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		return BGU_CommonUtil.IsInFsmState(bGUCharacterCS, FSMStateTag);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckFSMStateActive_Custom");
		FSMStateTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FSMStateTag");
		FSMStateTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FSMStateTag", Classes.FStructProperty);
	}

	static BAID_CheckFSMStateActive_Custom()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckFSMStateActive_Custom)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckFSMStateActive_Custom));
	}
}
