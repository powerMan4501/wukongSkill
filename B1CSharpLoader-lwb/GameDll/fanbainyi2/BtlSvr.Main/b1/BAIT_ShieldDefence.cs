using System;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_ShieldDefence")]
internal class BAIT_ShieldDefence : BAIT_Base
{
	private static bool IsShieldUp_IsValid;

	private static int IsShieldUp_Offset;

	private static FFieldAddress IsShieldUp_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_ShieldDefence:IsShieldUp")]
	public bool IsShieldUp
	{
		get
		{
			CheckDestroyed();
			if (!IsShieldUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ShieldDefence:IsShieldUp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsShieldUp_Offset), 0, IsShieldUp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsShieldUp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_ShieldDefence:IsShieldUp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsShieldUp_Offset), 0, IsShieldUp_PropertyAddress.Address, value);
			}
		}
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS != null)
		{
			if (BGUFunctionLibraryCS.BGUHasBuff(bGUCharacterCS, EBPBuffID.ShieldDefenceBuff))
			{
				if (!IsShieldUp)
				{
					BGUFunctionLibraryCS.BGURemoveBuffImmediately(bGUCharacterCS, 203, EBuffEffectTriggerType.None);
				}
			}
			else if (IsShieldUp)
			{
				BGUFunctionLibraryCS.BGUAddBuff(bGUCharacterCS, bGUCharacterCS, 203, EBuffSourceType.BAIT);
			}
		}
		FinishExecute(bSuccess: true);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_ShieldDefence");
		NativeReflection.GetPropertyRef(ref IsShieldUp_PropertyAddress, unrealStruct, "IsShieldUp");
		IsShieldUp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsShieldUp");
		IsShieldUp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsShieldUp", Classes.FBoolProperty);
	}

	static BAIT_ShieldDefence()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAIT_ShieldDefence)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAIT_ShieldDefence));
	}
}
