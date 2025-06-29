using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckCurrentMoveMode")]
internal class BAID_CheckCurrentMoveMode : BAID_Base
{
	private static bool ToCheckMoveMode_IsValid;

	private static int ToCheckMoveMode_Offset;

	private static FFieldAddress ToCheckMoveMode_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckCurrentMoveMode:ToCheckMoveMode")]
	public EMovementMode ToCheckMoveMode
	{
		get
		{
			CheckDestroyed();
			if (!ToCheckMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurrentMoveMode:ToCheckMoveMode");
				return EMovementMode.MOVE_None;
			}
			return EnumMarshaler<EMovementMode>.FromNative(IntPtr.Add(base.Address, ToCheckMoveMode_Offset), 0, ToCheckMoveMode_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ToCheckMoveMode_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckCurrentMoveMode:ToCheckMoveMode");
			}
			else
			{
				EnumMarshaler<EMovementMode>.ToNative(IntPtr.Add(base.Address, ToCheckMoveMode_Offset), 0, ToCheckMoveMode_PropertyAddress.Address, value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor is BGUCharacterCS actor)
		{
			UBUC_ACharacterComponent unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<UBUC_ACharacterComponent>(actor);
			if (unPersistentReadOnlyData != null && unPersistentReadOnlyData.OwnerMovement != null)
			{
				if (unPersistentReadOnlyData.OwnerMovement.MovementMode == ToCheckMoveMode)
				{
					return true;
				}
				return false;
			}
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckCurrentMoveMode");
		NativeReflection.GetPropertyRef(ref ToCheckMoveMode_PropertyAddress, unrealStruct, "ToCheckMoveMode");
		ToCheckMoveMode_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ToCheckMoveMode");
		ToCheckMoveMode_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ToCheckMoveMode", Classes.FEnumProperty);
	}

	static BAID_CheckCurrentMoveMode()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckCurrentMoveMode)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckCurrentMoveMode));
	}
}
