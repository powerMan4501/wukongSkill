using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BTD_CheckSkillCoolDown")]
internal class BTD_CheckSkillCoolDown : BAID_Base
{
	private static bool SkillID_IsValid;

	private static int SkillID_Offset;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BTD_CheckSkillCoolDown:SkillID")]
	public int SkillID
	{
		get
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BTD_CheckSkillCoolDown:SkillID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SkillID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SkillID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BTD_CheckSkillCoolDown:SkillID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SkillID_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor as BGUCharacterCS == null)
		{
			return false;
		}
		return BGU_CommonUtil.IsSkillInCoolDown(SkillID, OwnerActor);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BTD_CheckSkillCoolDown");
		SkillID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SkillID");
		SkillID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SkillID", Classes.FIntProperty);
	}

	static BTD_CheckSkillCoolDown()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BTD_CheckSkillCoolDown)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BTD_CheckSkillCoolDown));
	}
}
