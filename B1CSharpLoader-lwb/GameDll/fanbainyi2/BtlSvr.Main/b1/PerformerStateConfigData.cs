namespace b1;

public class PerformerStateConfigData
{
	public bool bPauseAI { get; set; }

	public bool bDisableCapsuleCollision { get; set; }

	public bool bDisableMeshCollision { get; set; }

	public bool bDisableGravity { get; set; }

	public bool bCannotSelected { get; set; }

	public bool bInvisible { get; set; }

	public bool bInvincible { get; set; }

	public bool bPerforming { get; set; }

	public PerformerStateConfigData()
	{
		bPauseAI = false;
		bDisableCapsuleCollision = false;
		bDisableMeshCollision = false;
		bDisableGravity = false;
		bCannotSelected = false;
		bInvisible = false;
		bInvincible = false;
		bPerforming = false;
	}

	public void Update(FPerformerStateConfig InStateConfig)
	{
		bPauseAI = InStateConfig.bPauseAI;
		bDisableCapsuleCollision = InStateConfig.bDisableCollision;
		bDisableMeshCollision = InStateConfig.bDisableMeshCollision;
		bDisableGravity = InStateConfig.bDisableGravity;
		bCannotSelected = InStateConfig.bCannotSelected;
		bInvisible = InStateConfig.bInvisible;
		bInvincible = InStateConfig.bInvincible;
		bPerforming = InStateConfig.bPerforming;
	}
}
