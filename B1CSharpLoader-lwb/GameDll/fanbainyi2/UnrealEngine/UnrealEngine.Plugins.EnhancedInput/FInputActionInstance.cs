using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UStruct(Flags = 4613)]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputActionInstance", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public struct FInputActionInstance
{
	private static bool Triggers_IsValid;

	private static FFieldAddress Triggers_PropertyAddress;

	private static int Triggers_Offset;

	[UProperty(Flags = (PropFlags)9016545103577628uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:Triggers")]
	public List<UInputTrigger> Triggers;

	private static bool Modifiers_IsValid;

	private static FFieldAddress Modifiers_PropertyAddress;

	private static int Modifiers_Offset;

	[UProperty(Flags = (PropFlags)9016545103577628uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:Modifiers")]
	public List<UInputModifier> Modifiers;

	private static bool ElapsedProcessedTime_IsValid;

	private static int ElapsedProcessedTime_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:ElapsedProcessedTime")]
	public float ElapsedProcessedTime;

	private static bool ElapsedTriggeredTime_IsValid;

	private static int ElapsedTriggeredTime_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:ElapsedTriggeredTime")]
	public float ElapsedTriggeredTime;

	private static bool LastTriggeredWorldTime_IsValid;

	private static int LastTriggeredWorldTime_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:LastTriggeredWorldTime")]
	public float LastTriggeredWorldTime;

	private static bool TriggerEvent_IsValid;

	private static FFieldAddress TriggerEvent_PropertyAddress;

	private static int TriggerEvent_Offset;

	[UProperty(Flags = (PropFlags)11267864954667540uL)]
	[UMetaPath("/Script/EnhancedInput.InputActionInstance:TriggerEvent")]
	public ETriggerEvent TriggerEvent;

	private static bool FInputActionInstance_IsValid;

	private static int FInputActionInstance_StructSize;

	public FInputActionInstance Copy()
	{
		FInputActionInstance result = this;
		if (Triggers != null)
		{
			result.Triggers = new List<UInputTrigger>(Triggers);
		}
		if (Modifiers != null)
		{
			result.Modifiers = new List<UInputModifier>(Modifiers);
		}
		return result;
	}

	public static FInputActionInstance FromNative(IntPtr nativeBuffer)
	{
		return new FInputActionInstance(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FInputActionInstance value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FInputActionInstance FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FInputActionInstance(nativeBuffer + arrayIndex * FInputActionInstance_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FInputActionInstance value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FInputActionInstance_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FInputActionInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.InputActionInstance");
			return;
		}
		new TArrayCopyMarshaler<UInputTrigger>(1, Triggers_PropertyAddress, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.FromNative, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Triggers_Offset), Triggers);
		new TArrayCopyMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative).ToNative(IntPtr.Add(nativeStruct, Modifiers_Offset), Modifiers);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ElapsedProcessedTime_Offset), ElapsedProcessedTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, ElapsedTriggeredTime_Offset), ElapsedTriggeredTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, LastTriggeredWorldTime_Offset), LastTriggeredWorldTime);
		EnumMarshaler<ETriggerEvent>.ToNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address, TriggerEvent);
	}

	public FInputActionInstance(IntPtr nativeStruct)
	{
		if (!FInputActionInstance_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/EnhancedInput.InputActionInstance");
			Triggers = null;
			Modifiers = null;
			ElapsedProcessedTime = 0f;
			ElapsedTriggeredTime = 0f;
			LastTriggeredWorldTime = 0f;
			TriggerEvent = ETriggerEvent.None;
		}
		else
		{
			Triggers = new TArrayCopyMarshaler<UInputTrigger>(1, Triggers_PropertyAddress, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.FromNative, CachedMarshalingDelegates<UInputTrigger, UObjectMarshaler<UInputTrigger>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Triggers_Offset));
			Modifiers = new TArrayCopyMarshaler<UInputModifier>(1, Modifiers_PropertyAddress, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.FromNative, CachedMarshalingDelegates<UInputModifier, UObjectMarshaler<UInputModifier>>.ToNative).FromNative(IntPtr.Add(nativeStruct, Modifiers_Offset));
			ElapsedProcessedTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ElapsedProcessedTime_Offset));
			ElapsedTriggeredTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, ElapsedTriggeredTime_Offset));
			LastTriggeredWorldTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, LastTriggeredWorldTime_Offset));
			TriggerEvent = EnumMarshaler<ETriggerEvent>.FromNative(IntPtr.Add(nativeStruct, TriggerEvent_Offset), 0, TriggerEvent_PropertyAddress.Address);
		}
	}

	static FInputActionInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FInputActionInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FInputActionInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/EnhancedInput.InputActionInstance");
		FInputActionInstance_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflectionCached.GetPropertyRef(ref Triggers_PropertyAddress, intPtr, "Triggers");
		Triggers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Triggers");
		Triggers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Triggers", Classes.FArrayProperty);
		NativeReflectionCached.GetPropertyRef(ref Modifiers_PropertyAddress, intPtr, "Modifiers");
		Modifiers_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Modifiers");
		Modifiers_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Modifiers", Classes.FArrayProperty);
		ElapsedProcessedTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElapsedProcessedTime");
		ElapsedProcessedTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElapsedProcessedTime", Classes.FFloatProperty);
		ElapsedTriggeredTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ElapsedTriggeredTime");
		ElapsedTriggeredTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ElapsedTriggeredTime", Classes.FFloatProperty);
		LastTriggeredWorldTime_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "LastTriggeredWorldTime");
		LastTriggeredWorldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "LastTriggeredWorldTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref TriggerEvent_PropertyAddress, intPtr, "TriggerEvent");
		TriggerEvent_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "TriggerEvent");
		TriggerEvent_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "TriggerEvent", Classes.FEnumProperty);
		FInputActionInstance_IsValid = intPtr != IntPtr.Zero && Triggers_IsValid && Modifiers_IsValid && ElapsedProcessedTime_IsValid && ElapsedTriggeredTime_IsValid && LastTriggeredWorldTime_IsValid && TriggerEvent_IsValid;
		NativeReflection.LogStructIsValid("/Script/EnhancedInput.InputActionInstance", FInputActionInstance_IsValid);
	}
}
