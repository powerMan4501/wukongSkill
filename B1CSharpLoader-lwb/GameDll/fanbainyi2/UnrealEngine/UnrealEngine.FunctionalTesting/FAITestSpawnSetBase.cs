using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AITestSpawnSetBase", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAITestSpawnSetBase
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

	private static bool FAITestSpawnSetBase_IsValid;

	private static int FAITestSpawnSetBase_StructSize;

	public FAITestSpawnSetBase Copy()
	{
		return this;
	}

	public static FAITestSpawnSetBase FromNative(IntPtr nativeBuffer)
	{
		return new FAITestSpawnSetBase(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAITestSpawnSetBase value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAITestSpawnSetBase FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAITestSpawnSetBase(nativeBuffer + arrayIndex * FAITestSpawnSetBase_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAITestSpawnSetBase value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAITestSpawnSetBase_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAITestSpawnSetBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnSetBase");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Name_Offset), Name);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address, Enabled);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, FallbackSpawnLocation_Offset), FallbackSpawnLocation);
	}

	public FAITestSpawnSetBase(IntPtr nativeStruct)
	{
		if (!FAITestSpawnSetBase_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AITestSpawnSetBase");
			Name = default(FName);
			Enabled = false;
			FallbackSpawnLocation = null;
		}
		else
		{
			Name = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Name_Offset));
			Enabled = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enabled_Offset), 0, Enabled_PropertyAddress.Address);
			FallbackSpawnLocation = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, FallbackSpawnLocation_Offset));
		}
	}

	static FAITestSpawnSetBase()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAITestSpawnSetBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAITestSpawnSetBase));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AITestSpawnSetBase");
		FAITestSpawnSetBase_StructSize = NativeReflection.GetStructSize(intPtr);
		Name_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Name");
		Name_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Name", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Enabled_PropertyAddress, intPtr, "bEnabled");
		Enabled_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bEnabled");
		Enabled_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bEnabled", Classes.FBoolProperty);
		FallbackSpawnLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "FallbackSpawnLocation");
		FallbackSpawnLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "FallbackSpawnLocation", Classes.FObjectProperty);
		FAITestSpawnSetBase_IsValid = intPtr != IntPtr.Zero && Name_IsValid && Enabled_IsValid && FallbackSpawnLocation_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AITestSpawnSetBase", FAITestSpawnSetBase_IsValid);
	}
}
