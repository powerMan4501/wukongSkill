namespace b1;

public class BUC_NPCShowData
{
	public readonly int PauseAIBuffID = 801;

	public readonly int InvisibleBuffID = 802;

	public readonly int InvincibleBuffID = 803;

	public readonly int CannotSelectedBuffID = 804;

	public readonly int DisableCapsuleCollisionBuffID = 805;

	public readonly int DisableMeshCollisionBuffID = 806;

	public readonly int DisableGravityBuffID = 807;

	public NPCShowStateConfigTemplate AppearingStateConfigTemplate { get; } = new NPCShowStateConfigTemplate
	{
		bPauseAI = false,
		bDisableCapsuleCollision = false,
		bDisableMeshCollision = false,
		bDisableGravity = false,
		bCannotSelected = false,
		bInvisible = false,
		bInvincible = false
	};

	public NPCShowStateConfigTemplate HidingStateConfigTemplate { get; } = new NPCShowStateConfigTemplate
	{
		bPauseAI = true,
		bDisableCapsuleCollision = true,
		bDisableMeshCollision = true,
		bDisableGravity = true,
		bCannotSelected = true,
		bInvisible = true,
		bInvincible = true
	};

	public NPCShowStateConfigTemplate ActualStateConfigTemplate { get; } = new NPCShowStateConfigTemplate();

	public EntitySharedRef OwnerEntityRef { get; set; }

	public bool bNeedOneTick { get; set; }
}
