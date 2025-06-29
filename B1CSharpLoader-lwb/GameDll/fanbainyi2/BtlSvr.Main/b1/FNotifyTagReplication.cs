using UnrealEngine.Runtime;

namespace b1;

public class FNotifyTagReplication
{
	public string IdentityGuid { get; set; }

	public FGameplayTag NotifyTag { get; set; }

	public FNotifyTagReplication(string InIdentityGuid, FGameplayTag InNotifyTag)
	{
		IdentityGuid = InIdentityGuid;
		NotifyTag = InNotifyTag;
	}
}
