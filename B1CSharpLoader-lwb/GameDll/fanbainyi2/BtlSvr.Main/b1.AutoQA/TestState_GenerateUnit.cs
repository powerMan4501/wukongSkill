using System.Collections.Generic;
using b1.BGW;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1.AutoQA;

public class TestState_GenerateUnit : AutoTestNodeLib.TestState_Node
{
	private TStrongObjectPtr<UClass> TempBP = new TStrongObjectPtr<UClass>();

	public TestState_GenerateUnit(UObject WorldContext, string ClassPath)
	{
		base.WorldContext = WorldContext;
		TempBP.Set(BGW_PreloadAssetMgr.Get(WorldContext).TryGetCachedResourceObj<UClass>(ClassPath, ELoadResourceType.SyncLoadAndCache));
	}

	public TestState_GenerateUnit(UObject WorldContext, UClass Class)
	{
		base.WorldContext = WorldContext;
		TempBP.Set(Class);
	}

	public override AutoTestNodeLib.NodeState OnTick(out string Description, ref Stack<AutoTestNodeLib.TestState_Node> StateStack, float DeltaTime)
	{
		FVector actorLocation = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorLocation();
		FVector fVector = UGSE_EngineFuncLib.GetFirstLocalPlayerController(WorldContext).GetControlledPawn().GetActorRotation()
			.GetForwardVector() * 1000.0;
		FVector location = actorLocation + fVector;
		FRotator rotation = UMathLibrary.FindLookAtRotation(location, actorLocation);
		FActorSpawnParametersInterop parameters = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		UGSE_EngineFuncLib.GetWorldFromObj(WorldContext).SpawnActor(TempBP.Get(), ref location, ref rotation, ref parameters);
		Description = "生成成功";
		return AutoTestNodeLib.NodeState.Succeeded;
	}
}
