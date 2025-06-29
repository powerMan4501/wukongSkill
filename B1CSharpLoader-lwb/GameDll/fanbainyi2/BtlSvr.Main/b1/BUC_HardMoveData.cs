using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUC_HardMoveData : IBUC_HardMoveData, IPersistentECSData
{
	private TStrongObjectPtr<UAnimSequenceBase> mWindyMoveForwardBlendAnim = new TStrongObjectPtr<UAnimSequenceBase>();

	public bool bEnableHardMove { get; set; }

	public float WindyMoveAffectedAngleForward { get; set; }

	public int WindyMoveForwardBuffID { get; set; }

	public int WindyMoveBackwardBuffID { get; set; }

	public int WindyMoveEnterSkill { get; set; }

	public int MuddyMoveEnterSkill { get; set; }

	public int FrozenMoveEnterSkill { get; set; }

	public int SpiderSilkyMoveEnterSkill { get; set; }

	public UAnimSequenceBase WindyMoveForwardBlendAnim
	{
		get
		{
			return mWindyMoveForwardBlendAnim.Get();
		}
		set
		{
			mWindyMoveForwardBlendAnim.Set(value);
		}
	}

	public bool bWindyMoveBlendAnim { get; set; }

	public bool bFrozenHardMoving { get; set; }

	public bool bMuddyHardMoving { get; set; }

	public bool bWindyHardMoving { get; set; }

	public bool bSpiderSilkyHardMoving { get; set; }

	public bool bImmuneHardMovingAll { get; set; }

	public bool bImmuneHardMovingFrozen { get; set; }

	public bool bImmuneHardMovingMuddy { get; set; }

	public bool bImmuneHardMovingWindy { get; set; }

	public bool bImmuneHardMovingSpiderSilky { get; set; }

	public EMoveDirection WindyMoveWindDirection { get; set; }

	public float WindyMoveAffectedHalfAngleForwardCos { get; set; }

	public bool IsHardMoving()
	{
		if (!bFrozenHardMoving && !bMuddyHardMoving && !bWindyHardMoving)
		{
			return bSpiderSilkyHardMoving;
		}
		return true;
	}
}
