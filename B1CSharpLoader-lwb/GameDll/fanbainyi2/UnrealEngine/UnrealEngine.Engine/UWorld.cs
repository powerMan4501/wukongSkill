using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace UnrealEngine.Engine;

[UClass(Flags = (ClassFlags)818938016uL, Config = "Engine")]
[UMetaPath("/Script/Engine.World", "Engine", UnrealModuleType.Engine)]
public class UWorld : UObject
{
	private static bool GetWorldSettings_IsValid;

	private static IntPtr GetWorldSettings_FunctionAddress;

	private static int GetWorldSettings_ParamsSize;

	private static bool GetWorldSettings_ReturnValue_IsValid;

	private static FFieldAddress GetWorldSettings_ReturnValue_PropertyAddress;

	private static int GetWorldSettings_ReturnValue_Offset;

	public T[] GetAllActorsOfClass<T>() where T : AActor
	{
		return UGameplayStatics.GetAllActorsOfClass<T>(this);
	}

	public List<T> GetAllActorsOfClassList<T>() where T : AActor
	{
		return UGameplayStatics.GetAllActorsOfClassList<T>(this);
	}

	public AActor SpawnActor(UClass unrealClass, ref FVector location, ref FRotator rotation, ref FActorSpawnParameters parameters)
	{
		FActorSpawnParametersInterop parameters2 = new FActorSpawnParametersInterop
		{
			Name = parameters.Name,
			Template = ((parameters.Template == null) ? IntPtr.Zero : parameters.Template.Address),
			Owner = ((parameters.Owner == null) ? IntPtr.Zero : parameters.Owner.Address),
			Instigator = ((parameters.Instigator == null) ? IntPtr.Zero : parameters.Instigator.Address),
			OverrideLevel = ((parameters.OverrideLevel == null) ? IntPtr.Zero : parameters.OverrideLevel.Address),
			SpawnCollisionHandlingOverride = parameters.SpawnCollisionHandlingOverride,
			PackedBools = parameters.PackedBools,
			ObjectFlags = parameters.ObjectFlags
		};
		return GCHelper.Find<AActor>(Native_UWorld.SpawnActor(base.Address, unrealClass.Address, ref location, ref rotation, ref parameters2));
	}

	public AActor SpawnActor(UClass unrealClass, ref FVector location, ref FRotator rotation, ref FActorSpawnParametersInterop parameters)
	{
		return GCHelper.Find<AActor>(Native_UWorld.SpawnActor(base.Address, unrealClass.Address, ref location, ref rotation, ref parameters));
	}

	public AActor SpawnActor(UClass unrealClass, ref FVector location, ref FRotator rotation)
	{
		FActorSpawnParametersInterop parameters = default(FActorSpawnParametersInterop);
		return GCHelper.Find<AActor>(Native_UWorld.SpawnActor(base.Address, unrealClass.Address, ref location, ref rotation, ref parameters));
	}

	public AActor SpawnActor(UClass unrealClass, ref FTransform tranform, ref FActorSpawnParameters parameters)
	{
		FActorSpawnParametersInterop parameters2 = new FActorSpawnParametersInterop
		{
			Name = parameters.Name,
			Template = ((parameters.Template == null) ? IntPtr.Zero : parameters.Template.Address),
			Owner = ((parameters.Owner == null) ? IntPtr.Zero : parameters.Owner.Address),
			Instigator = ((parameters.Instigator == null) ? IntPtr.Zero : parameters.Instigator.Address),
			OverrideLevel = ((parameters.OverrideLevel == null) ? IntPtr.Zero : parameters.OverrideLevel.Address),
			SpawnCollisionHandlingOverride = parameters.SpawnCollisionHandlingOverride,
			PackedBools = parameters.PackedBools,
			ObjectFlags = parameters.ObjectFlags
		};
		return GCHelper.Find<AActor>(Native_UWorld.SpawnActorByTransform(base.Address, unrealClass.Address, ref tranform, ref parameters2));
	}

	public T SpawnActor<T>(ref FVector location, ref FRotator rotation, ref FActorSpawnParameters parameters) where T : AActor
	{
		return SpawnActor(UClass.GetClass<T>(), ref location, ref rotation, ref parameters) as T;
	}

	public T SpawnActor<T>(ref FVector location, ref FRotator rotation, ref FActorSpawnParametersInterop parameters) where T : AActor
	{
		return SpawnActor(UClass.GetClass<T>(), ref location, ref rotation, ref parameters) as T;
	}

	public T SpawnActor<T>(ref FVector location, ref FRotator rotation) where T : AActor
	{
		return SpawnActor(UClass.GetClass<T>(), ref location, ref rotation) as T;
	}

	public T SpawnActor<T>(ref FTransform tranform, ref FActorSpawnParameters parameters) where T : AActor
	{
		return SpawnActor(UClass.GetClass<T>(), ref tranform, ref parameters) as T;
	}

	[UFunction(Flags = 67240961u, OriginalName = "K2_GetWorldSettings")]
	[UMetaPath("/Script/Engine.World:K2_GetWorldSettings")]
	public unsafe AWorldSettings GetWorldSettings()
	{
		CheckDestroyed();
		if (!GetWorldSettings_IsValid)
		{
			NativeReflection.LogInvalidFunctionAccessed("/Script/Engine.World:K2_GetWorldSettings");
			return null;
		}
		byte* ptr = stackalloc byte[(int)(uint)(GetWorldSettings_ParamsSize + 16)];
		int num = (int)((16L - (long)ptr) & 0xF);
		byte* ptr2 = ptr + num;
		Unsafe.InitBlockUnaligned(ptr2, 0, (uint)GetWorldSettings_ParamsSize);
		IntPtr intPtr = new IntPtr(ptr2);
		NativeReflection.InvokeFunctionOptimized(base.Address, GetWorldSettings_FunctionAddress, intPtr, GetWorldSettings_ParamsSize);
		return UObjectMarshaler<AWorldSettings>.FromNative(IntPtr.Add(intPtr, GetWorldSettings_ReturnValue_Offset), 0, GetWorldSettings_ReturnValue_PropertyAddress.Address);
	}

	static UWorld()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UWorld)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UWorld));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/Engine.World");
		GetWorldSettings_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "K2_GetWorldSettings");
		GetWorldSettings_ParamsSize = NativeReflection.GetFunctionParamsSize(GetWorldSettings_FunctionAddress);
		NativeReflectionCached.GetPropertyRef(ref GetWorldSettings_ReturnValue_PropertyAddress, GetWorldSettings_FunctionAddress, "ReturnValue");
		GetWorldSettings_ReturnValue_Offset = NativeReflectionCached.GetPropertyOffset(GetWorldSettings_FunctionAddress, "ReturnValue");
		GetWorldSettings_ReturnValue_IsValid = NativeReflectionCached.ValidatePropertyClass(GetWorldSettings_FunctionAddress, "ReturnValue", Classes.FObjectProperty);
		GetWorldSettings_IsValid = GetWorldSettings_FunctionAddress != IntPtr.Zero && GetWorldSettings_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/Engine.World:K2_GetWorldSettings", GetWorldSettings_IsValid);
	}
}
