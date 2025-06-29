using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_FlyCtrlData
{
	private TStrongObjectPtr<UBGUCharacterMovementComponent> mMovementComp = new TStrongObjectPtr<UBGUCharacterMovementComponent>();

	public bool bEnable;

	public float CheckInterval;

	public float CheckTimer;

	public List<FName> TraceIgnoreActorTags = new List<FName>();

	public float FlyHeightMin;

	public float FlyHeightMax;

	public float FlyHeightMaxAbs;

	public float LineTraceLength;

	public float PushUpImpulse;

	public float PushDownImpulse;

	public bool bLockZ;

	public bool bPrintHitActor;

	public UBGUCharacterMovementComponent MovementComp
	{
		get
		{
			return mMovementComp.Get();
		}
		set
		{
			mMovementComp.Set(value);
		}
	}
}
