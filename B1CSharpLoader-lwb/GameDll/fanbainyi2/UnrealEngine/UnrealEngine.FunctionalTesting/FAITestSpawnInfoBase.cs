using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfoBase", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAITestSpawnInfoBase
{
	private static bool SpawnLocation_IsValid;

	private static int SpawnLocation_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfoBase:SpawnLocation")]
	public AActor SpawnLocation;

	private static bool NumberToSpawn_IsValid;

	private static int NumberToSpawn_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfoBase:NumberToSpawn")]
	public int NumberToSpawn;

	private static bool SpawnDelay_IsValid;

	private static int SpawnDelay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfoBase:SpawnDelay")]
	public float SpawnDelay;

	private static bool PreSpawnDelay_IsValid;

	private static int PreSpawnDelay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfoBase:PreSpawnDelay")]
	public float PreSpawnDelay;

	private static bool FAITestSpawnInfoBase_IsValid;

	private static int FAITestSpawnInfoBase_StructSize;

	public FAITestSpawnInfoBase Copy()
	{
		return this;
	}

	public static FAITestSpawnInfoBase FromNative(IntPtr nativeBuffer)
	{
		return new FAITestSpawnInfoBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAITestSpawnInfoBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAITestSpawnInfoBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAITestSpawnInfoBase(nativeBuffer + arrayIndex * FAITestSpawnInfoBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAITestSpawnInfoBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAITestSpawnInfoBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAITestSpawnInfoBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnInfoBase");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, SpawnLocation_Offset), SpawnLocation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumberToSpawn_Offset), NumberToSpawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnDelay_Offset), SpawnDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreSpawnDelay_Offset), PreSpawnDelay);
	}

	public FAITestSpawnInfoBase(IntPtr nativeStruct)
	{
		if (!FAITestSpawnInfoBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnInfoBase");
			SpawnLocation = null;
			NumberToSpawn = 0;
			SpawnDelay = 0f;
			PreSpawnDelay = 0f;
		}
		else
		{
			SpawnLocation = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, SpawnLocation_Offset));
			NumberToSpawn = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumberToSpawn_Offset));
			SpawnDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnDelay_Offset));
			PreSpawnDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreSpawnDelay_Offset));
		}
	}

	static FAITestSpawnInfoBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAITestSpawnInfoBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAITestSpawnInfoBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AITestSpawnInfoBase");
		FAITestSpawnInfoBase_StructSize = NativeReflection.GetStructSize(intPtr);
		SpawnLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnLocation");
		SpawnLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnLocation", Classes.FObjectProperty);
		NumberToSpawn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberToSpawn");
		NumberToSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberToSpawn", Classes.FIntProperty);
		SpawnDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnDelay");
		SpawnDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnDelay", Classes.FFloatProperty);
		PreSpawnDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreSpawnDelay");
		PreSpawnDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreSpawnDelay", Classes.FFloatProperty);
		FAITestSpawnInfoBase_IsValid = intPtr != IntPtr.Zero && SpawnLocation_IsValid && NumberToSpawn_IsValid && SpawnDelay_IsValid && PreSpawnDelay_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AITestSpawnInfoBase", FAITestSpawnInfoBase_IsValid);
	}
}
