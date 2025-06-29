namespace b1;

public class NPCShowStateConfigTemplate
{
	public bool bPauseAI { get; set; }

	public bool bDisableCapsuleCollision { get; set; }

	public bool bDisableMeshCollision { get; set; }

	public bool bDisableGravity { get; set; }

	public bool bCannotSelected { get; set; }

	public bool bInvisible { get; set; }

	public bool bInvincible { get; set; }

	public NPCShowStateConfigTemplate()
	{
		bPauseAI = false;
		bDisableCapsuleCollision = false;
		bDisableMeshCollision = false;
		bDisableGravity = false;
		bCannotSelected = false;
		bInvisible = false;
		bInvincible = false;
	}
}
