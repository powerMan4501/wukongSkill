using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.AIModule;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/AIModule.ActorPerceptionBlueprintInfo", "AIModule", UnrealModuleType.Engine)]
public struct FActorPerceptionBlueprintInfo
{
	private static bool Target_IsValid;

	private static int Target_Offset;

	[UProperty(Flags = (PropFlags)7881369141117444uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionBlueprintInfo:Target")]
	public AActor Target;

	private static bool LastSensedStimuli_IsValid;

	private static FFieldAddress LastSensedStimuli_PropertyAddress;

	private static int LastSensedStimuli_Offset;

	[UProperty(Flags = (PropFlags)4503599627371012uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionBlueprintInfo:LastSensedStimuli")]
	public List<FAIStimulus> LastSensedStimuli;

	private static bool IsHostile_IsValid;

	private static FFieldAddress IsHostile_PropertyAddress;

	private static int IsHostile_Offset;

	[UProperty(Flags = (PropFlags)6755468160532484uL)]
	[UMetaPath("/Script/AIModule.ActorPerceptionBlueprintInfo:bIsHostile")]
	public bool IsHostile;

	private static bool FActorPerceptionBlueprintInfo_IsValid;

	private static int FActorPerceptionBlueprintInfo_StructSize;

	public FActorPerceptionBlueprintInfo Copy()
	{
		FActorPerceptionBlueprintInfo result = this;
		if (LastSensedStimuli != null)
		{
			result.LastSensedStimuli = new List<FAIStimulus>(LastSensedStimuli);
		}
		return result;
	}

	public static FActorPerceptionBlueprintInfo FromNative(IntPtr nativeBuffer)
	{
		return new FActorPerceptionBlueprintInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FActorPerceptionBlueprintInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FActorPerceptionBlueprintInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FActorPerceptionBlueprintInfo(nativeBuffer + arrayIndex * FActorPerceptionBlueprintInfo_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FActorPerceptionBlueprintInfo value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FActorPerceptionBlueprintInfo_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FActorPerceptionBlueprintInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.ActorPerceptionBlueprintInfo");
			return;
		}
		UObjectMarshaler<AActor>.ToNative(IntPtr.Add(nativeStruct, Target_Offset), Target);
		new TArrayCopyMarshaler<FAIStimulus>(1, LastSensedStimuli_PropertyAddress, CachedMarshalingDelegates<FAIStimulus, FAIStimulus>.FromNative, CachedMarshalingDelegates<FAIStimulus, FAIStimulus>.ToNative).ToNative(IntPtr.Add(nativeStruct, LastSensedStimuli_Offset), LastSensedStimuli);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IsHostile_Offset), 0, IsHostile_PropertyAddress.Address, IsHostile);
	}

	public FActorPerceptionBlueprintInfo(IntPtr nativeStruct)
	{
		if (!FActorPerceptionBlueprintInfo_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/AIModule.ActorPerceptionBlueprintInfo");
			Target = null;
			LastSensedStimuli = null;
			IsHostile = false;
		}
		else
		{
			Target = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(nativeStruct, Target_Offset));
			LastSensedStimuli = new TArrayCopyMarshaler<FAIStimulus>(1, LastSensedStimuli_PropertyAddress, CachedMarshalingDelegates<FAIStimulus, FAIStimulus>.FromNative, CachedMarshalingDelegates<FAIStimulus, FAIStimulus>.ToNative).FromNative(IntPtr.Add(nativeStruct, LastSensedStimuli_Offset));
			IsHostile = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IsHostile_Offset), 0, IsHostile_PropertyAddress.Address);
		}
	}

	static FActorPerceptionBlueprintInfo()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FActorPerceptionBlueprintInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FActorPerceptionBlueprintInfo));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/AIModule.ActorPerceptionBlueprintInfo");
		FActorPerceptionBlueprintInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		Target_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Target");
		Target_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Target", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref LastSensedStimuli_PropertyAddress, intPtr, "LastSensedStimuli");
		LastSensedStimuli_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastSensedStimuli");
		LastSensedStimuli_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastSensedStimuli", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref IsHostile_PropertyAddress, intPtr, "bIsHostile");
		IsHostile_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIsHostile");
		IsHostile_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIsHostile", Classes.FBoolProperty);
		FActorPerceptionBlueprintInfo_IsValid = intPtr != IntPtr.Zero && Target_IsValid && LastSensedStimuli_IsValid && IsHostile_IsValid;
		NativeReflection.LogStructIsValid("/Script/AIModule.ActorPerceptionBlueprintInfo", FActorPerceptionBlueprintInfo_IsValid);
	}
}
