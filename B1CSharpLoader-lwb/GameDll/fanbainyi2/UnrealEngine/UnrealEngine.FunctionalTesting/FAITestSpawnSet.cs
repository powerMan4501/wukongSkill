using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AITestSpawnSet", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAITestSpawnSet
{
	private static bool Name_IsValid;

	private static int Name_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnSetBase:Name")]
	public FName Name;

	private static bool Enabled_IsValid;

	private static FFieldAddress Enabled_PropertyAddress;

	private static int Enabled_Offset;

	[UProperty(Flags = (PropFlags)6755468160532485uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnSetBase:bEnabled")]
	public bool Enabled;

	private static bool FallbackSpawnLocation_IsValid;

	private static int FallbackSpawnLocation_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnSetBase:FallbackSpawnLocation")]
	public AActor FallbackSpawnLocation;

	private static bool SpawnInfoContainer_IsValid;

	private static FFieldAddress SpawnInfoContainer_PropertyAddress;

	private static int SpawnInfoContainer_Offset;

	[UProperty(Flags = (PropFlags)9015995347763717uL)]
	[UMetaPath("/Script/FunctionalTesting.AITestSpawnSet:SpawnInfoContainer")]
	public List<FAITestSpawnInfo> SpawnInfoContainer;

	private static bool FAITestSpawnSet_IsValid;

	private static int FAITestSpawnSet_StructSize;

	public FAITestSpawnSet Copy()
	{
		FAITestSpawnSet result = this;
		if (SpawnInfoContainer != null)
		{
			result.SpawnInfoContainer = new List<FAITestSpawnInfo>(SpawnInfoContainer);
		}
		return result;
	}

	public static FAITestSpawnSet FromNative(IntPtr nativeBuffer)
	{
		return new FAITestSpawnSet(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAITestSpawnSet value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAITestSpawnSet FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAITestSpawnSet(nativeBuffer + arrayIndex * FAITestSpawnSet_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAITestSpawnSet value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAITestSpawnSet_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAITestSpawnSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnSet");
			return;
		}
		new TArrayCopyMarshaler<FAITestSpawnInfo>(1, SpawnInfoContainer_PropertyAddress, CachedMarshalingDelegates<FAITestSpawnInfo, FAITestSpawnInfo>.FromNative, CachedMarshalingDelegates<FAITestSpawnInfo, FAITestSpawnInfo>.ToNative).ToNative(IntPtr.Add(nativeStruct, SpawnInfoContainer_Offset), SpawnInfoContainer);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, FallbackSpawnLocation_Offset), FallbackSpawnLocation);
	}

	public FAITestSpawnSet(IntPtr nativeStruct)
	{
		if (!FAITestSpawnSet_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnSet");
			SpawnInfoContainer = null;
			Name = default(FName);
			Enabled = false;
			FallbackSpawnLocation = null;
		}
		else
		{
			SpawnInfoContainer = new TArrayCopyMarshaler<FAITestSpawnInfo>(1, SpawnInfoContainer_PropertyAddress, CachedMarshalingDelegates<FAITestSpawnInfo, FAITestSpawnInfo>.FromNative, CachedMarshalingDelegates<FAITestSpawnInfo, FAITestSpawnInfo>.ToNative).FromNative(IntPtr.Add(nativeStruct, SpawnInfoContainer_Offset));
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			FallbackSpawnLocation = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, FallbackSpawnLocation_Offset));
		}
	}

	static FAITestSpawnSet()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAITestSpawnSet)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAITestSpawnSet));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AITestSpawnSet");
		FAITestSpawnSet_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FallbackSpawnLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackSpawnLocation");
		FallbackSpawnLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackSpawnLocation", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref SpawnInfoContainer_PropertyAddress, intPtr, "SpawnInfoContainer");
		SpawnInfoContainer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "SpawnInfoContainer");
		SpawnInfoContainer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "SpawnInfoContainer", Classes.FArrayProperty);
		FAITestSpawnSet_IsValid = intPtr != IntPtr.Zero && SpawnInfoContainer_IsValid && Name_IsValid && Enabled_IsValid && FallbackSpawnLocation_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AITestSpawnSet", FAITestSpawnSet_IsValid);
	}
}
