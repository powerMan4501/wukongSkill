using System.Collections.Generic;
using b1.ECS;

namespace b1;

public class BUC_StaminaData : IBUC_StaminaData, IPersistentECSData
{
	private float StaminaRecoverMul;

	public float StaminaRecoverFinal;

	public Dictionary<int, float> MapStaminaFreezeTimer;

	public bool bLastFrameStaminaDepleted { get; set; }

	public BUC_StaminaData()
	{
		StaminaRecoverMul = 1f;
		MapStaminaFreezeTimer = new Dictionary<int, float>();
	}

	public void SetStaminaRecoverMul(float RecoverMul)
	{
		StaminaRecoverMul = RecoverMul;
	}

	public void ResetStaminaRecoverMul()
	{
		StaminaRecoverMul = 1f;
	}

	public float GetStaminaRecoverMul()
	{
		return StaminaRecoverMul;
	}

	public float GetStaminaRecoverFinal()
	{
		return StaminaRecoverFinal;
	}
}
