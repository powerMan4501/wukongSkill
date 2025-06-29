using b1.ECS;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class BGC_UnrealGameplayData : IBGC_UnrealGameplayData, IPersistentECSData
{
	private bool IsInitialized;

	private UWorld CachedWorld;

	private WorldTimeHelper WorldTime;

	public UWorld World { get; set; }

	public BGWGameInstanceCS GameInstance { get; set; }

	public AGameState GameState { get; set; }

	public bool IsListenServer { get; set; }

	public bool IsDedicatedServer { get; set; }

	public bool IsEditor { get; set; }

	public APlayerController GetFirstLocalPlayerController()
	{
		return UGSE_EngineFuncLib.GetFirstLocalPlayerController(World);
	}

	public ACharacter GetPlayerCharacter(int Index)
	{
		return UGameplayStatics.GetPlayerCharacter(World, Index);
	}

	public float GetTimeSeconds()
	{
		return WorldTime.TimeSeconds;
	}

	public void Init(AGameState GState)
	{
		GameState = GState;
		World = GState.World;
		WorldTime.WorldAddress = World.Address;
		GameInstance = World.GetGameInstance() as BGWGameInstanceCS;
		IsListenServer = UGSE_EngineFuncLib.IsListenServer(World);
		IsDedicatedServer = UGSE_EngineFuncLib.IsDedicateServer(World);
		IsEditor = UGSE_EngineFuncLib.IsEditor();
		IsInitialized = true;
	}
}
