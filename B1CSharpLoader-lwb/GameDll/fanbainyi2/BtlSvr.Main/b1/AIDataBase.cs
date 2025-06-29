using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class AIDataBase
{
	public virtual FVector GetLocation()
	{
		return new FVector(-1.0, -1.0, -1.0);
	}

	public virtual ACharacter GetCharacter()
	{
		return null;
	}
}
