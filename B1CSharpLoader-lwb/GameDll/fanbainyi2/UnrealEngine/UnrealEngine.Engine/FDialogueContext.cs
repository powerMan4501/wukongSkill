using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UStruct(Flags = 4609)]
[BlueprintType]
[UMetaPath("/Script/Engine.DialogueContext", "Engine", UnrealModuleType.Engine)]
public struct FDialogueContext
{
	private static bool Speaker_IsValid;

	private static int Speaker_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/Engine.DialogueContext:Speaker")]
	public UDialogueVoice Speaker;

	private static bool Targets_IsValid;

	private static FFieldAddress Targets_PropertyAddress;

	private static int Targets_Offset;

	[UProperty(Flags = (PropFlags)5629499534213637uL)]
	[UMetaPath("/Script/Engine.DialogueContext:Targets")]
	public List<UDialogueVoice> Targets;

	private static bool FDialogueContext_IsValid;

	private static int FDialogueContext_StructSize;

	public FDialogueContext Copy()
	{
		FDialogueContext result = this;
		if (Targets != null)
		{
			result.Targets = new List<UDialogueVoice>(Targets);
		}
		return result;
	}

	public static FDialogueContext FromNative(IntPtr nativeBuffer)
	{
		return new FDialogueContext(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FDialogueContext value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FDialogueContext FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FDialogueContext(nativeBuffer + arrayIndex * FDialogueContext_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FDialogueContext value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FDialogueContext_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FDialogueContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DialogueContext");
			return;
		}
		UObjectMarshaler<UDialogueVoice>.ToNative(IntPtr.Add(nativeStruct, Speaker_Offset), Speaker);
		new TArrayCopyMarshaler<UDialogueVoice>(1, Targets_PropertyAddress, CachedMarshalingDelegates<UDialogueVoice, UObjectMarshaler<UDialogueVoice>>.FromNative, CachedMarshalingDelegates<UDialogueVoice, UObjectMarshaler<UDialogueVoice>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Targets_Offset), Targets);
	}

	public FDialogueContext(IntPtr nativeStruct)
	{
		if (!FDialogueContext_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/Engine.DialogueContext");
			Speaker = null;
			Targets = null;
		}
		else
		{
			Speaker = UObjectMarshaler<UDialogueVoice>.FromNative(IntPtr.Add(nativeStruct, Speaker_Offset));
			Targets = new TArrayCopyMarshaler<UDialogueVoice>(1, Targets_PropertyAddress, CachedMarshalingDelegates<UDialogueVoice, UObjectMarshaler<UDialogueVoice>>.FromNative, CachedMarshalingDelegates<UDialogueVoice, UObjectMarshaler<UDialogueVoice>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Targets_Offset));
		}
	}

	static FDialogueContext()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FDialogueContext)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FDialogueContext));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/Engine.DialogueContext");
		FDialogueContext_StructSize = NativeReflection.GetStructSize(intPtr);
		Speaker_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Speaker");
		Speaker_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Speaker", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref Targets_PropertyAddress, intPtr, "Targets");
		Targets_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Targets");
		Targets_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Targets", Classes.FArrayProperty);
		FDialogueContext_IsValid = intPtr != IntPtr.Zero && Speaker_IsValid && Targets_IsValid;
		NativeReflection.LogStructIsValid("/Script/Engine.DialogueContext", FDialogueContext_IsValid);
	}
}
