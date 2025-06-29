using System.Collections.Generic;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MagicallyChangeData : IBUC_MagicallyChangeData
{
	public TStrongObjectPtr<UCapsuleComponent> HitMoveCollision = new TStrongObjectPtr<UCapsuleComponent>();

	public List<TStrongObjectPtr<UTressFXComponent>> TFXComponents = new List<TStrongObjectPtr<UTressFXComponent>>();

	public TStrongObjectPtr<UStaticMeshComponent> StaticMeshComp = new TStrongObjectPtr<UStaticMeshComponent>();

	public List<int> VigorSkillWhiteList = new List<int>();

	public UBGWDataAsset PendingConfig;

	public int MagicallyChangeSkillID;

	public int RecoverSkillID;

	public bool bIsPendingCast;

	public MagicallyChangeDefaultConfig DefaultConfig;

	public bool DurMagicallyChange;

	public int RemainHiddenFrame = -1;

	public int ModularMeshRemainHiddenFrame = -1;

	public uint MainMeshHiddenInGameHandleID;

	public uint MeshCollisionProfileHandleID;

	public uint AbnormalDispID_AsAttacker_Override_HanldeID;

	public UAnimMontage Montage_CurrentMontageEndEventBinded;

	public bool bIsPendingReset;

	public EResetReason_MagicallyChange ResetReason;

	public int CurVigorSkillID;

	public float VigorSkillDelayTimer;

	public float MimicrySkillTimer;

	public int FadeOutFXRequestID;

	public ECastReason_MagicallyChange CastReason;

	public uint MeshVisibilityHandleID;

	public string ChrMeshProfileName;

	public float VigorSkillReEnterWaitTime { get; set; }

	public BUC_MagicallyChangeData()
	{
		bIsPendingCast = false;
		DurMagicallyChange = false;
		bIsPendingReset = false;
		CurVigorSkillID = 0;
		VigorSkillDelayTimer = 0f;
		MimicrySkillTimer = 0f;
		MeshVisibilityHandleID = 0u;
		ChrMeshProfileName = "CharacterMesh";
	}

	public bool IsDurMagicallyChange()
	{
		return DurMagicallyChange;
	}
}
