using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ABPAimOffsetData : IBUC_ABPAimOffsetData
{
	private TStrongObjectPtr<UAimOffsetBlendSpace> mDefaultAimOffset = new TStrongObjectPtr<UAimOffsetBlendSpace>();

	private TStrongObjectPtr<UAimOffsetBlendSpace> mAttackAimOffset = new TStrongObjectPtr<UAimOffsetBlendSpace>();

	public bool IsUseThisAlpha { get; set; }

	public float BlendInTime { get; set; }

	public float BlendOutTime { get; set; }

	public float BlendTime { get; set; }

	public float AOAlpha { get; set; }

	public float BlendSpd { get; set; }

	public bool IsBlendToOne { get; set; }

	public UAimOffsetBlendSpace DefaultAimOffset
	{
		get
		{
			return mDefaultAimOffset.Get();
		}
		set
		{
			mDefaultAimOffset.Set(value);
		}
	}

	public UAimOffsetBlendSpace AttackAimOffset
	{
		get
		{
			return mAttackAimOffset.Get();
		}
		set
		{
			mAttackAimOffset.Set(value);
		}
	}

	public void Update(IBUC_ABPCharacterData ChrData, float DeltaTime)
	{
		if (!ChrData.IsMontage)
		{
			AOAlpha = 1f;
		}
		if (!IsUseThisAlpha)
		{
			return;
		}
		if (IsBlendToOne)
		{
			BlendTime -= DeltaTime;
			if (BlendTime <= 0f)
			{
				BlendInTime -= DeltaTime;
				if (BlendInTime <= 0f || AOAlpha >= 1f)
				{
					AOAlpha = 1f;
					BlendSpd = ((BlendOutTime > 0f) ? (1f / BlendOutTime) : 1f);
				}
				if (AOAlpha < 1f)
				{
					AOAlpha += BlendSpd * DeltaTime;
				}
				if (AOAlpha > 1f)
				{
					AOAlpha = 1f;
				}
			}
		}
		else
		{
			BlendOutTime -= DeltaTime;
			if (BlendOutTime <= 0f || AOAlpha <= 0f)
			{
				IsBlendToOne = true;
				AOAlpha = 0f;
				BlendSpd = ((BlendInTime > 0f) ? (1f / BlendInTime) : 1f);
			}
			if (AOAlpha > 0f)
			{
				AOAlpha -= BlendSpd * DeltaTime;
			}
			if (AOAlpha < 0f)
			{
				AOAlpha = 0f;
			}
		}
	}

	public void Init(BUABPSettingData Setting)
	{
		IsUseThisAlpha = false;
		AOAlpha = 1f;
		BlendSpd = 0f;
		IsBlendToOne = true;
		DefaultAimOffset = Setting.AimOffsetSetting.DefaultAimOffset;
		AttackAimOffset = Setting.AimOffsetSetting.AttackAimOffset;
	}
}
