using System;
using ArchiveB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckMasterCurrentHeavyAttackType")]
public class BAID_CheckMasterCurrentHeavyAttackType : BAID_Base
{
	[UEnum]
	[USharpPath("/Script/b1-Managed.AttackStyle")]
	public enum AttackStyle : byte
	{
		Heavy,
		Prop,
		Poke
	}

	private static bool CheckCurType_IsValid;

	private static int CheckCurType_Offset;

	private static FFieldAddress CheckCurType_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckMasterCurrentHeavyAttackType:CheckCurType")]
	public AttackStyle CheckCurType
	{
		get
		{
			CheckDestroyed();
			if (!CheckCurType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterCurrentHeavyAttackType:CheckCurType");
				return AttackStyle.Heavy;
			}
			return EnumMarshaler<AttackStyle>.FromNative(IntPtr.Add(base.Address, CheckCurType_Offset), 0, CheckCurType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!CheckCurType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterCurrentHeavyAttackType:CheckCurType");
			}
			else
			{
				EnumMarshaler<AttackStyle>.ToNative(IntPtr.Add(base.Address, CheckCurType_Offset), 0, CheckCurType_PropertyAddress.Address, value);
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
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(bGUCharacterCS);
		if (readOnlyData == null || readOnlyData.GetMaster() == null)
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS2 = readOnlyData.GetMaster() as BGUCharacterCS;
		if (bGUCharacterCS2 == null)
		{
			return false;
		}
		Stance stance = RoleDataHelper.GetStance(BGU_DataUtil.GetReadOnlyData<BPC_PlayerRoleData>(bGUCharacterCS2.GetController()).RoleData.RoleCs);
		return CheckCurType switch
		{
			AttackStyle.Heavy => stance == Stance.Heavy, 
			AttackStyle.Poke => stance == Stance.Poke, 
			AttackStyle.Prop => stance == Stance.Prop, 
			_ => false, 
		};
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckMasterCurrentHeavyAttackType");
		NativeReflection.GetPropertyRef(ref CheckCurType_PropertyAddress, unrealStruct, "CheckCurType");
		CheckCurType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CheckCurType");
		CheckCurType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CheckCurType", Classes.FEnumProperty);
	}

	static BAID_CheckMasterCurrentHeavyAttackType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckMasterCurrentHeavyAttackType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckMasterCurrentHeavyAttackType));
	}
}
