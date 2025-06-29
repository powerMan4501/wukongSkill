using System.Collections.Generic;
using b1.Plugins.AkAudio;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_ProjectileLaserData
{
	public bool bDead;

	public float LaserCurLength;

	public float LaserLengthSpeed;

	public bool LaserEnable;

	public float LaserAge = -1f;

	public float LaserMaxLength;

	public bool LaserBulletCanThroughChr;

	private TStrongObjectPtr<UCurveFloat> mLaserLengthSpeedCurve = new TStrongObjectPtr<UCurveFloat>();

	public FVector LastLaserEnd = FVector.ZeroVector;

	public readonly List<UNiagaraComponent> LaserNgComps = new List<UNiagaraComponent>();

	public bool HitSceneItemNgComps_Initted;

	public readonly List<UNiagaraComponent> NgComps_HitSceneItem = new List<UNiagaraComponent>();

	public bool bDrawDebug;

	public UAkComponent LaserAudioComp;

	public UAkAudioEvent AkEvent_Laser;

	public int FadeOut_AkEvent_LaserEnd;

	public int PlayingID_LaserAudio;

	public bool bHasHitSceneItem;

	public UAkComponent HitItemAudioComp;

	public UAkAudioEvent AkEvent_LaserHitItem;

	public int PlayingID_LaserHitItem;

	public UCurveFloat LaserLengthSpeedCurve
	{
		get
		{
			return mLaserLengthSpeedCurve.Get();
		}
		set
		{
			mLaserLengthSpeedCurve.Set(value);
		}
	}
}
