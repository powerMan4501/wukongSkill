using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class DynamicGameObjectWrap
{
	private TStrongObjectPtr<AActor> mGameObject = new TStrongObjectPtr<AActor>();

	public int GameObjectIndex;

	public bool IsActive;

	public AActor GameObject
	{
		get
		{
			return mGameObject.Get();
		}
		set
		{
			mGameObject.Set(value);
		}
	}

	public DynamicGameObjectWrap(UObject WorldContext)
	{
		FVector location = FVector.ZeroVector;
		FRotator rotation = FRotator.ZeroRotator;
		GameObject = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext).SpawnActor<AActor>(ref location, ref rotation);
	}

	public DynamicGameObjectWrap(UObject WorldContext, int GameObjectIndex, bool IsActive)
	{
		FVector location = FVector.ZeroVector;
		FRotator rotation = FRotator.ZeroRotator;
		GameObject = UGSE_EngineFuncLib.GetWorldFromObj(WorldContext).SpawnActor<AActor>(ref location, ref rotation);
		this.GameObjectIndex = GameObjectIndex;
		this.IsActive = IsActive;
	}
}
