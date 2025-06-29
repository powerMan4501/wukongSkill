using UnrealEngine.Runtime;

namespace b1;

[UEnum]
[USharpPath("/Script/b1-Managed.EOSS_CharacterType")]
public enum EOSS_CharacterType : byte
{
	None,
	Player,
	Monster,
	AiPartner
}
