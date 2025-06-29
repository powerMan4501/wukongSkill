using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_MontageSectionCtrlData : IBUC_MontageSectionCtrlData
{
	private TStrongObjectPtr<BGUCharacterCS> mTargetChar = new TStrongObjectPtr<BGUCharacterCS>();

	public MontageSectionJumpType SectionJumpType;

	public Dictionary<FName, float> PreDetectionConfig;

	public float PreDetectionDuration;

	public EBGUSimpleState IgnoreSimplateState;

	public bool bEnableDebugDraw;

	public FName NextSectionName;

	public float TimeBeforeNextSection;

	public bool bJumpSectionApproved;

	public BGUCharacterCS TargetChar
	{
		get
		{
			return mTargetChar.Get();
		}
		set
		{
			mTargetChar.Set(value);
		}
	}

	public BUC_MontageSectionCtrlData()
	{
		PreDetectionDuration = -1f;
		TimeBeforeNextSection = -1f;
		bJumpSectionApproved = false;
	}
}
