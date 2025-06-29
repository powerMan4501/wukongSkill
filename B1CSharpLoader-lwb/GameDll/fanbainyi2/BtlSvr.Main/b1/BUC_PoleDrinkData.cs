using System.Collections.Generic;
using b1.ECS;
using UnrealEngine.Engine;

namespace b1;

public class BUC_PoleDrinkData : b1.IBUC_PoleDrinkData, IPersistentECSData
{
	public UAnimMontage DrinkHPBottomSuccessAM;

	public UAnimMontage DrinkHPBottomFailedAM;

	public Dictionary<int, UAnimMontage> UseItemAMMapping;

	public float BlendInTime;

	public float BlendOutTime;

	public UAnimMontage CurPlayAM;

	public float CurMontageLength;

	public float CurMontageRemainTime;

	public bool bPoleDrinkFlag { get; set; }

	public BUC_PoleDrinkData()
	{
		UseItemAMMapping = new Dictionary<int, UAnimMontage>();
	}
}
