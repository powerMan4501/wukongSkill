using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class CricketMovePointConfig
{
	private TStrongObjectPtr<UAnimMontage> mJumpAnim = new TStrongObjectPtr<UAnimMontage>();

	public FTransform PointTrans { get; set; }

	public List<TStrongObjectPtr<UAnimSequence>> AnimIdleList { get; set; }

	public float IdleTime { get; set; }

	public UAnimMontage JumpAnim
	{
		get
		{
			return mJumpAnim.Get();
		}
		set
		{
			mJumpAnim.Set(value);
		}
	}

	public CricketMovePointConfig(in FCricketMovePointConfig Config)
	{
		AnimIdleList = new List<TStrongObjectPtr<UAnimSequence>>();
		foreach (UAnimSequence animIdle in Config.AnimIdleList)
		{
			AnimIdleList.Add(new TStrongObjectPtr<UAnimSequence>(animIdle));
		}
		PointTrans = Config.PointTrans;
		IdleTime = Config.IdleTime;
		JumpAnim = Config.JumpAnim;
	}
}
