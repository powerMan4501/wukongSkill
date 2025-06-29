using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_EnableFightBack")]
internal class BAIT_EnableFightBack : BAIT_Base
{
	private static bool IsEnableFightBack_IsValid;

	private static int IsEnableFightBack_Offset;

	private static FFieldAddress IsEnableFightBack_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_EnableFightBack:IsEnableFightBack")]
	public bool IsEnableFightBack
	{
		get
		{
			CheckDestroyed();
			if (!IsEnableFightBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EnableFightBack:IsEnableFightBack");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsEnableFightBack_Offset), 0, IsEnableFightBack_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsEnableFightBack_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_EnableFightBack:IsEnableFightBack");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsEnableFightBack_Offset), 0, IsEnableFightBack_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (BGUFunctionLibraryCS.BGUHasBuff(bGUCharacterCS, EBPBuffID.FightBackBuff))
			{
				if (!IsEnableFightBack)
				{
					BGUFunctionLibraryCS.BGURemoveBuffImmediately(bGUCharacterCS, 209, EBuffEffectTriggerType.None);
				}
			}
			else if (IsEnableFightBack)
			{
				BGUFunctionLibraryCS.BGUAddBuff(bGUCharacterCS, bGUCharacterCS, 209, EBuffSourceType.BAIT);
			}
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_EnableFightBack");
		NativeReflection.GetPropertyRef(ref IsEnableFightBack_PropertyAddress, unrealStruct, "IsEnableFightBack");
		IsEnableFightBack_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsEnableFightBack");
		IsEnableFightBack_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsEnableFightBack", Classes.FBoolProperty);
	}

	static BAIT_EnableFightBack()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_EnableFightBack)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_EnableFightBack));
	}
}
