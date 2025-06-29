using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.EnhancedInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/EnhancedInput.InputTriggerChordAction", "EnhancedInput", UnrealModuleType.EnginePlugin)]
public class UInputTriggerChordAction : UInputTrigger
{
	private static bool ChordAction_IsValid;

	private static int ChordAction_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/EnhancedInput.InputTriggerChordAction:ChordAction")]
	public UInputAction ChordAction
	{
		get
		{
			CheckDestroyed();
			if (!ChordAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerChordAction:ChordAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, ChordAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChordAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/EnhancedInput.InputTriggerChordAction:ChordAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, ChordAction_Offset), value);
			}
		}
	}

	static UInputTriggerChordAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UInputTriggerChordAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UInputTriggerChordAction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/EnhancedInput.InputTriggerChordAction");
		ChordAction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChordAction");
		ChordAction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChordAction", Classes.FObjectProperty);
	}
}
