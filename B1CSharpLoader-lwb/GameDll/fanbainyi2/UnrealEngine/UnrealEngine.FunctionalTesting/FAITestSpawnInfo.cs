using System;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfo", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAITestSpawnInfo
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

	private static bool PawnClass_IsValid;

	private static int PawnClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfo:PawnClass")]
	public TSubclassOf<APawn> PawnClass;

	private static bool ControllerClass_IsValid;

	private static int ControllerClass_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfo:ControllerClass")]
	public TSubclassOf<AIController> ControllerClass;

	private static bool TeamID_IsValid;

	private static int TeamID_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfo:TeamID")]
	public FGenericTeamId TeamID;

	private static bool BehaviorTree_IsValid;

	private static int BehaviorTree_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnInfo:BehaviorTree")]
	public UBehaviorTree BehaviorTree;

	private static bool FAITestSpawnInfo_IsValid;

	private static int FAITestSpawnInfo_StructSize;

	public FAITestSpawnInfo Copy()
	{
		return this;
	}

	public static FAITestSpawnInfo FromNative(IntPtr nativeBuffer)
	{
		return new FAITestSpawnInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAITestSpawnInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAITestSpawnInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAITestSpawnInfo(nativeBuffer + arrayIndex * FAITestSpawnInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAITestSpawnInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAITestSpawnInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAITestSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnInfo");
			return;
		}
		TSubclassOfMarshaler<APawn>.ToNative(IntPtr.Add(nativeStruct, PawnClass_Offset), PawnClass);
		TSubclassOfMarshaler<AIController>.ToNative(IntPtr.Add(nativeStruct, ControllerClass_Offset), ControllerClass);
		FGenericTeamId.ToNative(IntPtr.Add(nativeStruct, TeamID_Offset), TeamID);
		UObjectMarshaler<UBehaviorTree>.ToNative(IntPtr.Add(nativeStruct, BehaviorTree_Offset), BehaviorTree);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, SpawnLocation_Offset), SpawnLocation);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, NumberToSpawn_Offset), NumberToSpawn);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, SpawnDelay_Offset), SpawnDelay);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, PreSpawnDelay_Offset), PreSpawnDelay);
	}

	public FAITestSpawnInfo(IntPtr nativeStruct)
	{
		if (!FAITestSpawnInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnInfo");
			PawnClass = default(TSubclassOf<APawn>);
			ControllerClass = default(TSubclassOf<AIController>);
			TeamID = default(FGenericTeamId);
			BehaviorTree = null;
			SpawnLocation = null;
			NumberToSpawn = 0;
			SpawnDelay = 0f;
			PreSpawnDelay = 0f;
		}
		else
		{
			PawnClass = TSubclassOfMarshaler<APawn>.FromNative(IntPtr.Add(nativeStruct, PawnClass_Offset));
			ControllerClass = TSubclassOfMarshaler<AIController>.FromNative(IntPtr.Add(nativeStruct, ControllerClass_Offset));
			TeamID = FGenericTeamId.FromNative(IntPtr.Add(nativeStruct, TeamID_Offset));
			BehaviorTree = UObjectMarshaler<UBehaviorTree>.FromNative(IntPtr.Add(nativeStruct, BehaviorTree_Offset));
			SpawnLocation = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, SpawnLocation_Offset));
			NumberToSpawn = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, NumberToSpawn_Offset));
			SpawnDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, SpawnDelay_Offset));
			PreSpawnDelay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, PreSpawnDelay_Offset));
		}
	}

	static FAITestSpawnInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAITestSpawnInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAITestSpawnInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AITestSpawnInfo");
		FAITestSpawnInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		SpawnLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnLocation");
		SpawnLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnLocation", Classes.FObjectProperty);
		NumberToSpawn_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NumberToSpawn");
		NumberToSpawn_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NumberToSpawn", Classes.FIntProperty);
		SpawnDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnDelay");
		SpawnDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnDelay", Classes.FFloatProperty);
		PreSpawnDelay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PreSpawnDelay");
		PreSpawnDelay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PreSpawnDelay", Classes.FFloatProperty);
		PawnClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "PawnClass");
		PawnClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "PawnClass", Classes.FClassProperty);
		ControllerClass_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ControllerClass");
		ControllerClass_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ControllerClass", Classes.FClassProperty);
		TeamID_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TeamID");
		TeamID_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TeamID", Classes.FStructProperty);
		BehaviorTree_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "BehaviorTree");
		BehaviorTree_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "BehaviorTree", Classes.FObjectProperty);
		FAITestSpawnInfo_IsValid = intPtr != IntPtr.Zero && PawnClass_IsValid && ControllerClass_IsValid && TeamID_IsValid && BehaviorTree_IsValid && SpawnLocation_IsValid && NumberToSpawn_IsValid && SpawnDelay_IsValid && PreSpawnDelay_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AITestSpawnInfo", FAITestSpawnInfo_IsValid);
	}
}
