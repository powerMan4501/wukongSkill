using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIDamageEvent", "AIModule", UnrealModuleType.Engine)]
public struct FAIDamageEvent
{
	private static bool Amount_IsValid;

	private static int Amount_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:Amount")]
	public float Amount;

	private static bool Location_IsValid;

	private static int Location_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:Location")]
	public FVector Location;

	private static bool HitLocation_IsValid;

	private static int HitLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:HitLocation")]
	public FVector HitLocation;

	private static bool DamagedActor_IsValid;

	private static int DamagedActor_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:DamagedActor")]
	public AActor DamagedActor;

	private static bool Instigator_IsValid;

	private static int Instigator_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:Instigator")]
	public AActor Instigator;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/AIModule.AIDamageEvent:Tag")]
	public FName Tag;

	private static bool FAIDamageEvent_IsValid;

	private static int FAIDamageEvent_StructSize;

	public FAIDamageEvent Copy()
	{
		return this;
	}

	public static FAIDamageEvent FromNative(IntPtr nativeBuffer)
	{
		return new FAIDamageEvent(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAIDamageEvent value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAIDamageEvent FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAIDamageEvent(nativeBuffer + arrayIndex * FAIDamageEvent_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAIDamageEvent value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAIDamageEvent_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAIDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIDamageEvent");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Amount_Offset), Amount);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, Location_Offset), Location);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, HitLocation_Offset), HitLocation);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, DamagedActor_Offset), DamagedActor);
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Instigator_Offset), Instigator);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
	}

	public FAIDamageEvent(IntPtr nativeStruct)
	{
		if (!FAIDamageEvent_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIDamageEvent");
			Amount = 0f;
			Location = default(FVector);
			HitLocation = default(FVector);
			DamagedActor = null;
			Instigator = null;
			Tag = default(FName);
		}
		else
		{
			Amount = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Amount_Offset));
			Location = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, Location_Offset));
			HitLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, HitLocation_Offset));
			DamagedActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, DamagedActor_Offset));
			Instigator = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Instigator_Offset));
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
		}
	}

	static FAIDamageEvent()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAIDamageEvent)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAIDamageEvent));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AIDamageEvent");
		FAIDamageEvent_StructSize = NativeReflection.GetStructSize(intPtr);
		Amount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Amount");
		Amount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Amount", Classes.FFloatProperty);
		Location_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Location");
		Location_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Location", Classes.FStructProperty);
		HitLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "HitLocation");
		HitLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "HitLocation", Classes.FStructProperty);
		DamagedActor_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "DamagedActor");
		DamagedActor_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "DamagedActor", Classes.FObjectProperty);
		Instigator_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Instigator");
		Instigator_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Instigator", Classes.FObjectProperty);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		FAIDamageEvent_IsValid = intPtr != IntPtr.Zero && Amount_IsValid && Location_IsValid && HitLocation_IsValid && DamagedActor_IsValid && Instigator_IsValid && Tag_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.AIDamageEvent", FAIDamageEvent_IsValid);
	}
}
