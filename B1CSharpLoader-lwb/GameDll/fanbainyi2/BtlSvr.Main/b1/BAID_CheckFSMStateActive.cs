using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckFSMStateActive")]
internal class BAID_CheckFSMStateActive : BAID_Base
{
	private static bool FSMState_IsValid;

	private static int FSMState_Offset;

	private static FFieldAddress FSMState_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckFSMStateActive:FSMState")]
	public EBGUFSMStateName FSMState
	{
		get
		{
			CheckDestroyed();
			if (!FSMState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFSMStateActive:FSMState");
				return EBGUFSMStateName.FSM_STATE_LIFE;
			}
			return EnumMarshaler<EBGUFSMStateName>.FromNative(IntPtr.Add(base.Address, FSMState_Offset), 0, FSMState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FSMState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckFSMStateActive:FSMState");
			}
			else
			{
				EnumMarshaler<EBGUFSMStateName>.ToNative(IntPtr.Add(base.Address, FSMState_Offset), 0, FSMState_PropertyAddress.Address, value);
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
		return BGU_CommonUtil.IsInFsmState(bGUCharacterCS, FSMState);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckFSMStateActive");
		NativeReflection.GetPropertyRef(ref FSMState_PropertyAddress, unrealStruct, "FSMState");
		FSMState_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FSMState");
		FSMState_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FSMState", Classes.FEnumProperty);
	}

	static BAID_CheckFSMStateActive()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckFSMStateActive)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckFSMStateActive));
	}
}
