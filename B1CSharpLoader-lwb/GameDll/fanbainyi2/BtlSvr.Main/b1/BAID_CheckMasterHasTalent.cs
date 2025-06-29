using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckMasterHasTalent")]
internal class BAID_CheckMasterHasTalent : BAID_Base
{
	private static bool TalentID_IsValid;

	private static int TalentID_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckMasterHasTalent:TalentID")]
	public int TalentID
	{
		get
		{
			CheckDestroyed();
			if (!TalentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterHasTalent:TalentID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, TalentID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TalentID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckMasterHasTalent:TalentID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, TalentID_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		ABGUCharacter aBGUCharacter = OwnerActor as ABGUCharacter;
		if (aBGUCharacter == null)
		{
			return false;
		}
		BUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<BUC_MasterData>(aBGUCharacter);
		if (readOnlyData != null && BGUFunctionLibraryCS.BGUHasTalentByID(readOnlyData.GetMaster() as BGUCharacterCS, TalentID))
		{
			return true;
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckMasterHasTalent");
		TalentID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TalentID");
		TalentID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TalentID", Classes.FIntProperty);
	}

	static BAID_CheckMasterHasTalent()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckMasterHasTalent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckMasterHasTalent));
	}
}
