using System;
using BtlB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckMasterEquipMagic")]
public class BAID_CheckMasterEquipMagic : BAID_Base
{
	private static bool ItemID_IsValid;

	private static int ItemID_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAID_CheckMasterEquipMagic:ItemID")]
	public int ItemID
	{
		get
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterEquipMagic:ItemID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ItemID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ItemID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterEquipMagic:ItemID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ItemID_Offset), value);
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
		return BGU_DataUtil.GetReadOnlyData<BUC_PlayerSpellConfData>(bGUCharacterCS2).MagicConfInfo.Find((FUStMagicConfInfo Info) => Info.SpellID == ItemID) != null;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckMasterEquipMagic");
		ItemID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ItemID");
		ItemID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ItemID", Classes.FIntProperty);
	}

	static BAID_CheckMasterEquipMagic()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAID_CheckMasterEquipMagic)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAID_CheckMasterEquipMagic));
	}
}
