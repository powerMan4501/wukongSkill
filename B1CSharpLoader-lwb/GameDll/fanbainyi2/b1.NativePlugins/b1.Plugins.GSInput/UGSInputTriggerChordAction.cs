using System;
using UnrealEngine.Plugins.EnhancedInput;
using UnrealEngine.Runtime;

namespace b1.Plugins.GSInput;

[UClass(Flags = (ClassFlags)1883779238uL, Config = "Input")]
[BlueprintType]
[UMetaPath("/Script/GSInput.GSInputTriggerChordAction", "GSInput", UnrealModuleType.GamePlugin)]
public class UGSInputTriggerChordAction : UInputTrigger
{
	private static bool ChordAction_IsValid;

	private static int ChordAction_Offset;

	private static bool IsConsiderHoldTime_IsValid;

	private static FFieldAddress IsConsiderHoldTime_PropertyAddress;

	private static int IsConsiderHoldTime_Offset;

	private static bool HoldTimeThreshold_IsValid;

	private static int HoldTimeThreshold_Offset;

	[UProperty(Flags = (PropFlags)6755469234276869uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerChordAction:ChordAction")]
	public UInputAction ChordAction
	{
		get
		{
			CheckDestroyed();
			if (!ChordAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:ChordAction");
				return null;
			}
			return UObjectMarshaler<UInputAction>.FromNative(IntPtr.Add(base.Address, ChordAction_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChordAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:ChordAction");
			}
			else
			{
				UObjectMarshaler<UInputAction>.ToNative(IntPtr.Add(base.Address, ChordAction_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerChordAction:IsConsiderHoldTime")]
	public bool IsConsiderHoldTime
	{
		get
		{
			CheckDestroyed();
			if (!IsConsiderHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:IsConsiderHoldTime");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsConsiderHoldTime_Offset), 0, IsConsiderHoldTime_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsConsiderHoldTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:IsConsiderHoldTime");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsConsiderHoldTime_Offset), 0, IsConsiderHoldTime_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234291205uL)]
	[UMetaPath("/Script/GSInput.GSInputTriggerChordAction:HoldTimeThreshold")]
	public float HoldTimeThreshold
	{
		get
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:HoldTimeThreshold");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!HoldTimeThreshold_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/GSInput.GSInputTriggerChordAction:HoldTimeThreshold");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, HoldTimeThreshold_Offset), value);
			}
		}
	}

	static UGSInputTriggerChordAction()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UGSInputTriggerChordAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UGSInputTriggerChordAction));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/GSInput.GSInputTriggerChordAction");
		ChordAction_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ChordAction");
		ChordAction_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ChordAction", Classes.FObjectProperty);
		NativeReflectionCached.GetPropertyRef(ref IsConsiderHoldTime_PropertyAddress, unrealStruct, "IsConsiderHoldTime");
		IsConsiderHoldTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "IsConsiderHoldTime");
		IsConsiderHoldTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "IsConsiderHoldTime", Classes.FBoolProperty);
		HoldTimeThreshold_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "HoldTimeThreshold");
		HoldTimeThreshold_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "HoldTimeThreshold", Classes.FFloatProperty);
	}
}
