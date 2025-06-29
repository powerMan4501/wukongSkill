using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AINoiseEvent", "AIModule", UnrealModuleType.Engine)]
public struct FAINoiseEvent
{
	private static bool NoiseLocation_IsValid;

	private static int NoiseLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AINoiseEvent:NoiseLocation")]
	public FVector NoiseLocation;

	private static bool Loudness_IsValid;

	private static int Loudness_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AINoiseEvent:Loudness")]
	public float Loudness;

	private static bool MaxRange_IsValid;

	private static int MaxRange_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AINoiseEvent:MaxRange")]
	public float MaxRange;

	private static bool Instigator_IsValid;

	private static int Instigator_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AIModule.AINoiseEvent:Instigator")]
	public AActor Instigator;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AINoiseEvent:Tag")]
	public FName Tag;

	private static bool FAINoiseEvent_IsValid;

	private static int FAINoiseEvent_StructSize;

	public FAINoiseEvent Copy()
	{
		return this;
	}

	public static FAINoiseEvent FromNative(IntPtr nativeBuffer)
	{
		return new FAINoiseEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAINoiseEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAINoiseEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAINoiseEvent(nativeBuffer + arrayIndex * FAINoiseEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAINoiseEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAINoiseEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAINoiseEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AINoiseEvent");
			return;
		}
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, NoiseLocation_Offset), NoiseLocation);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Loudness_Offset), Loudness);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaxRange_Offset), MaxRange);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Instigator_Offset), Instigator);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
	}

	public FAINoiseEvent(IntPtr nativeStruct)
	{
		if (!FAINoiseEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AINoiseEvent");
			NoiseLocation = default(FVector);
			Loudness = 0f;
			MaxRange = 0f;
			Instigator = null;
			Tag = default(FName);
		}
		else
		{
			NoiseLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, NoiseLocation_Offset));
			Loudness = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Loudness_Offset));
			MaxRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaxRange_Offset));
			Instigator = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Instigator_Offset));
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
		}
	}

	static FAINoiseEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAINoiseEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAINoiseEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AINoiseEvent");
		FAINoiseEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		NoiseLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "NoiseLocation");
		NoiseLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "NoiseLocation", Classes.FStructProperty);
		Loudness_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Loudness");
		Loudness_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Loudness", Classes.FFloatProperty);
		MaxRange_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaxRange");
		MaxRange_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaxRange", Classes.FFloatProperty);
		Instigator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Instigator");
		Instigator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Instigator", Classes.FObjectProperty);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		FAINoiseEvent_IsValid = intPtr != IntPtr.Zero && NoiseLocation_IsValid && Loudness_IsValid && MaxRange_IsValid && Instigator_IsValid && Tag_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.AINoiseEvent", FAINoiseEvent_IsValid);
	}
}
