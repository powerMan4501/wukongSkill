using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/AIModule.AIStimulus", "AIModule", UnrealModuleType.Engine)]
public struct FAIStimulus
{
	private static bool Age_IsValid;

	private static int Age_Offset;

	[UProperty(Flags = (PropFlags)11267864954667524uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:Age")]
	public float Age;

	private static bool ExpirationAge_IsValid;

	private static int ExpirationAge_Offset;

	[UProperty(Flags = (PropFlags)11267864954667524uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:ExpirationAge")]
	public float ExpirationAge;

	private static bool Strength_IsValid;

	private static int Strength_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:Strength")]
	public float Strength;

	private static bool StimulusLocation_IsValid;

	private static int StimulusLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:StimulusLocation")]
	public FVector StimulusLocation;

	private static bool ReceiverLocation_IsValid;

	private static int ReceiverLocation_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:ReceiverLocation")]
	public FVector ReceiverLocation;

	private static bool Tag_IsValid;

	private static int Tag_Offset;

	[UProperty(Flags = (PropFlags)6755469234274820uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:Tag")]
	public FName Tag;

	private static bool SuccessfullySensed_IsValid;

	private static FFieldAddress SuccessfullySensed_PropertyAddress;

	private static int SuccessfullySensed_Offset;

	[UProperty(Flags = (PropFlags)11267863880925188uL)]
	[UMetaPath("/Script/AIModule.AIStimulus:bSuccessfullySensed")]
	public bool SuccessfullySensed;

	private static bool FAIStimulus_IsValid;

	private static int FAIStimulus_StructSize;

	public FAIStimulus Copy()
	{
		return this;
	}

	public static FAIStimulus FromNative(IntPtr nativeBuffer)
	{
		return new FAIStimulus(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAIStimulus value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAIStimulus FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAIStimulus(nativeBuffer + arrayIndex * FAIStimulus_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAIStimulus value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAIStimulus_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAIStimulus_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIStimulus");
			return;
		}
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Age_Offset), Age);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ExpirationAge_Offset), ExpirationAge);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Strength_Offset), Strength);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, StimulusLocation_Offset), StimulusLocation);
		BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(nativeStruct, ReceiverLocation_Offset), ReceiverLocation);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, Tag_Offset), Tag);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, SuccessfullySensed_Offset), 0, SuccessfullySensed_PropertyAddress.Address, SuccessfullySensed);
	}

	public FAIStimulus(IntPtr nativeStruct)
	{
		if (!FAIStimulus_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.AIStimulus");
			Age = 0f;
			ExpirationAge = 0f;
			Strength = 0f;
			StimulusLocation = default(FVector);
			ReceiverLocation = default(FVector);
			Tag = default(FName);
			SuccessfullySensed = false;
		}
		else
		{
			Age = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Age_Offset));
			ExpirationAge = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ExpirationAge_Offset));
			Strength = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Strength_Offset));
			StimulusLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, StimulusLocation_Offset));
			ReceiverLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(nativeStruct, ReceiverLocation_Offset));
			Tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, Tag_Offset));
			SuccessfullySensed = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, SuccessfullySensed_Offset), 0, SuccessfullySensed_PropertyAddress.Address);
		}
	}

	static FAIStimulus()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAIStimulus)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAIStimulus));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.AIStimulus");
		FAIStimulus_StructSize = NativeReflection.GetStructSize(intPtr);
		Age_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Age");
		Age_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Age", Classes.FFloatProperty);
		ExpirationAge_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ExpirationAge");
		ExpirationAge_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ExpirationAge", Classes.FFloatProperty);
		Strength_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Strength");
		Strength_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Strength", Classes.FFloatProperty);
		StimulusLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "StimulusLocation");
		StimulusLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "StimulusLocation", Classes.FStructProperty);
		ReceiverLocation_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ReceiverLocation");
		ReceiverLocation_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ReceiverLocation", Classes.FStructProperty);
		Tag_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tag");
		Tag_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tag", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref SuccessfullySensed_PropertyAddress, intPtr, "bSuccessfullySensed");
		SuccessfullySensed_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bSuccessfullySensed");
		SuccessfullySensed_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bSuccessfullySensed", Classes.FBoolProperty);
		FAIStimulus_IsValid = intPtr != IntPtr.Zero && Age_IsValid && ExpirationAge_IsValid && Strength_IsValid && StimulusLocation_IsValid && ReceiverLocation_IsValid && Tag_IsValid && SuccessfullySensed_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.AIStimulus", FAIStimulus_IsValid);
	}
}
