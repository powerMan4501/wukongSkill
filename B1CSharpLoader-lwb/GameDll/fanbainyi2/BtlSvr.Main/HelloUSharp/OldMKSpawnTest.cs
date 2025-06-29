using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace HelloUSharp;

[UClass]
[USharpPath("/Script/b1-Managed.OldMKSpawnTest")]
public class OldMKSpawnTest : AActor
{
	private static bool SpawnActorCS_IsValid;

	private static IntPtr SpawnActorCS_FunctionAddress;

	private static int SpawnActorCS_ParamsSize;

	private static bool SpawnActorCS_ActorClass_IsValid;

	private static int SpawnActorCS_ActorClass_Offset;

	private static bool SpawnActorCS_ReturnValue_IsValid;

	private static int SpawnActorCS_ReturnValue_Offset;

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.OldMKSpawnTest:SpawnActorCS")]
	public AActor SpawnActorCS(TSubclassOf<AActor> ActorClass)
	{
		FVector Location = GetActorLocation();
		FRotator Rotation = GetActorRotation();
		return BGU_UnrealWorldUtil.SpawnActorAndECSBeginPlay(base.World, ActorClass.Value, in Location, in Rotation);
	}

	[UFunctionInvoker("/Script/b1-Managed.OldMKSpawnTest:SpawnActorCS")]
	private static void SpawnActorCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		OldMKSpawnTest oldMKSpawnTest = GCHelper.Find<OldMKSpawnTest>(obj);
		TSubclassOf<AActor> actorClass = TSubclassOfMarshaler<AActor>.FromNative(IntPtr.Add(buffer, SpawnActorCS_ActorClass_Offset));
		AActor value = oldMKSpawnTest.SpawnActorCS(actorClass);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(buffer, SpawnActorCS_ReturnValue_Offset), value);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.OldMKSpawnTest");
		SpawnActorCS_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "SpawnActorCS");
		SpawnActorCS_ParamsSize = NativeReflection.GetFunctionParamsSize(SpawnActorCS_FunctionAddress);
		SpawnActorCS_ActorClass_Offset = NativeReflection.GetPropertyOffset(SpawnActorCS_FunctionAddress, "ActorClass");
		SpawnActorCS_ActorClass_IsValid = NativeReflection.ValidatePropertyClass(SpawnActorCS_FunctionAddress, "ActorClass", Classes.FClassProperty);
		SpawnActorCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(SpawnActorCS_FunctionAddress, "ReturnValue");
		SpawnActorCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(SpawnActorCS_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		SpawnActorCS_IsValid = SpawnActorCS_FunctionAddress != IntPtr.Zero && SpawnActorCS_ActorClass_IsValid && SpawnActorCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.OldMKSpawnTest:SpawnActorCS", SpawnActorCS_IsValid);
	}

	static OldMKSpawnTest()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(OldMKSpawnTest)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(OldMKSpawnTest));
	}
}
