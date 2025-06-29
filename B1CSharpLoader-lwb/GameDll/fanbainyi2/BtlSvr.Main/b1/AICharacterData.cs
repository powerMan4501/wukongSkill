using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class AICharacterData : AIDataBase
{
	public ACharacter Character;

	public AICharacterData(ACharacter Character)
	{
		this.Character = Character;
	}

	public override FVector GetLocation()
	{
		return BGUFuncLibActorTransformCS.BGUGetActorLocation(Character);
	}

	public override ACharacter GetCharacter()
	{
		return Character;
	}
}
