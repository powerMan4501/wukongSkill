using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_AbnormalHandleData : IPersistentECSData
{
	public float RemoveBRKSkillSuperArmorStateTimer;

	private TStrongObjectPtr<UAnimMontage> mAssignedSSABreakAM = new TStrongObjectPtr<UAnimMontage>();

	public Dictionary<int, float> DmgDefInSkillSuperArmor;

	public float RemovePAStateTimer;

	public UAnimMontage AssignedSSABreakAM
	{
		get
		{
			return mAssignedSSABreakAM.Get();
		}
		set
		{
			mAssignedSSABreakAM.Set(value);
		}
	}

	public void InitData()
	{
		DmgDefInSkillSuperArmor = new Dictionary<int, float>();
	}

	public void ResetBreakSSAInfo()
	{
		RemoveBRKSkillSuperArmorStateTimer = 0f;
	}

	public void ResetBHAInfo()
	{
		RemovePAStateTimer = 0f;
	}
}
