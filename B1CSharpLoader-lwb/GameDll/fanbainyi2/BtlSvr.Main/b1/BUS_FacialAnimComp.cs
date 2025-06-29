using b1.EventDelDefine;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUS_FacialAnimComp : UActorCompBaseCS
{
	private BUC_FacialAnimData FacialAnimData;

	public override void OnAttach()
	{
		FacialAnimData = RequireWritableData<BUC_FacialAnimData>();
		base.BUSEventCollection.Evt_PlayFacialAnim += new Del_Void_PlayFacialAnim(PlayFacialAnim);
		base.BUSEventCollection.Evt_StopFacialAnim += new Del_Void(StopFacialAnim);
	}

	public override void OnBeginPlay()
	{
		ClearMontagePlayingInfo();
	}

	public override int GetTickGroupMask()
	{
		return 1024;
	}

	public override void OnTickWithGroup(float DeltaTime, int TickGroup)
	{
		if (FacialAnimData.AnimDelayTimer > 0f)
		{
			FacialAnimData.AnimDelayTimer -= DeltaTime;
			if (FacialAnimData.AnimDelayTimer <= 0f)
			{
				PlayFacialAnim(FacialAnimData.Anim_Cache, 0f, FacialAnimData.AutoBlendOutTime_Cache);
			}
		}
		if (FacialAnimData.AnimRemainTimer > 0f)
		{
			FacialAnimData.AnimRemainTimer -= DeltaTime;
			if (FacialAnimData.AnimRemainTimer <= 0f)
			{
				ClearMontagePlayingInfo();
			}
		}
	}

	public UAnimInstance GetCurAnimInst()
	{
		if (Owner is BGUCharacterCS)
		{
			return OwnerAsCharacterCS.Mesh.GetAnimInstance();
		}
		if (Owner is BGUPerformerActorCS)
		{
			BGUPerformerActorCS bGUPerformerActorCS = Owner as BGUPerformerActorCS;
			if (!bGUPerformerActorCS.IsNullOrDestroyed())
			{
				return bGUPerformerActorCS.Mesh.GetAnimInstance();
			}
		}
		return null;
	}

	public void PlayFacialAnim(UAnimSequence Anim, float TimeOffset, float AutoBlendOutTime)
	{
		if (!(Anim == null) && !(GetCurAnimInst() == null))
		{
			if (TimeOffset < 0f)
			{
				FacialAnimData.AnimDelayTimer = 0f - TimeOffset;
				FacialAnimData.Anim_Cache = Anim;
				FacialAnimData.AutoBlendOutTime_Cache = AutoBlendOutTime;
			}
			else
			{
				PlayMontage(Anim, TimeOffset, AutoBlendOutTime);
			}
		}
	}

	public void StopFacialAnim()
	{
		if (FacialAnimData.CurAnimMontage != null)
		{
			UAnimInstance curAnimInst = GetCurAnimInst();
			if (curAnimInst != null)
			{
				curAnimInst.StopSlotAnimation(0.1f, B1GlobalFNames.AdditiveAM);
			}
			ClearMontagePlayingInfo();
		}
	}

	private void ClearMontagePlayingInfo()
	{
		FacialAnimData.Anim_Cache = null;
		FacialAnimData.CurAnimMontage = null;
		FacialAnimData.AnimRemainTimer = -1f;
		FacialAnimData.AnimDelayTimer = -1f;
		FacialAnimData.AutoBlendOutTime_Cache = 0f;
	}

	private void PlayMontage(UAnimSequence Anim, float StartPos, float _AutoBlendOutTime)
	{
		ClearMontagePlayingInfo();
		if (!(Anim != null))
		{
			return;
		}
		float blendOutTime = ((_AutoBlendOutTime <= 0f) ? 0.2f : _AutoBlendOutTime);
		UAnimInstance curAnimInst = GetCurAnimInst();
		if (curAnimInst != null)
		{
			UAnimMontage uAnimMontage = curAnimInst.PlaySlotAnimationAsDynamicMontage(Anim, B1GlobalFNames.AdditiveAM, 0.2f, blendOutTime, 1f, 1, -1f, StartPos);
			if (uAnimMontage != null)
			{
				FacialAnimData.CurAnimMontage = uAnimMontage;
				float sequenceLength = uAnimMontage.SequenceLength;
				FacialAnimData.AnimRemainTimer = MathLib.Clamp(sequenceLength - StartPos, 0f, sequenceLength);
			}
		}
	}
}
