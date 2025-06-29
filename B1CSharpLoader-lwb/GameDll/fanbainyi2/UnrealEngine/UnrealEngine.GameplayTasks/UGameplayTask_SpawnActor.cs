using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.GameplayTasks;

[UClass(Flags = (ClassFlags)818413732uL, Config = "Game")]
[BlueprintType]
[UMetaPath("/Script/GameplayTasks.GameplayTask_SpawnActor", "GameplayTasks", UnrealModuleType.Engine)]
public class UGameplayTask_SpawnActor : UGameplayTask
{
	private static bool Success_IsValid;

	private static int Success_Offset;

	private FGameplayTaskSpawnActorDelegate Success_DelegateCached;

	private static bool DidNotSpawn_IsValid;

	private static int DidNotSpawn_Offset;

	private FGameplayTaskSpawnActorDelegate DidNotSpawn_DelegateCached;

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_SpawnActor:Success")]
	public FGameplayTaskSpawnActorDelegate Success
	{
		get
		{
			CheckDestroyed();
			if (!Success_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTask_SpawnActor:Success");
				return new FGameplayTaskSpawnActorDelegate();
			}
			if (Success_DelegateCached == null)
			{
				Success_DelegateCached = new FGameplayTaskSpawnActorDelegate();
				Success_DelegateCached.SetAddress(IntPtr.Add(base.Address, Success_Offset));
			}
			return Success_DelegateCached;
		}
	}

	[UProperty(Flags = (PropFlags)4503599896330752uL)]
	[UMetaPath("/Script/GameplayTasks.GameplayTask_SpawnActor:DidNotSpawn")]
	public FGameplayTaskSpawnActorDelegate DidNotSpawn
	{
		get
		{
			CheckDestroyed();
			if (!DidNotSpawn_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GameplayTasks.GameplayTask_SpawnActor:DidNotSpawn");
				return new FGameplayTaskSpawnActorDelegate();
			}
			if (DidNotSpawn_DelegateCached == null)
			{
				DidNotSpawn_DelegateCached = new FGameplayTaskSpawnActorDelegate();
				DidNotSpawn_DelegateCached.SetAddress(IntPtr.Add(base.Address, DidNotSpawn_Offset));
			}
			return DidNotSpawn_DelegateCached;
		}
	}

	static UGameplayTask_SpawnActor()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGameplayTask_SpawnActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGameplayTask_SpawnActor));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GameplayTasks.GameplayTask_SpawnActor");
		Success_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Success");
		Success_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Success", Classes.FMulticastDelegateProperty);
		DidNotSpawn_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "DidNotSpawn");
		DidNotSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "DidNotSpawn", Classes.FMulticastDelegateProperty);
	}
}
