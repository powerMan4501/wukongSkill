using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_Array_TriggerEffectWithCondition")]
public class BGWDataAsset_Array_TriggerEffectWithCondition : UBGWDataAsset
{
	private static bool Effects_IsValid;

	private static int Effects_Offset;

	private static FFieldAddress Effects_PropertyAddress;

	private TArrayReadWriteMarshaler<FTriggerEffectWithCondition> Effects_Marshaler;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_Array_TriggerEffectWithCondition:Effects")]
	public TArrayReadWrite<FTriggerEffectWithCondition> Effects
	{
		get
		{
			CheckDestroyed();
			if (!Effects_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_Array_TriggerEffectWithCondition:Effects");
				return null;
			}
			if (Effects_Marshaler == null)
			{
				Effects_Marshaler = new TArrayReadWriteMarshaler<FTriggerEffectWithCondition>(1, Effects_PropertyAddress, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.FromNative, CachedMarshalingDelegates<FTriggerEffectWithCondition, FTriggerEffectWithCondition>.ToNative);
			}
			return Effects_Marshaler.FromNative(IntPtr.Add(base.Address, Effects_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_Array_TriggerEffectWithCondition");
		NativeReflection.GetPropertyRef(ref Effects_PropertyAddress, unrealStruct, "Effects");
		Effects_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Effects");
		Effects_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Effects", Classes.FArrayProperty);
	}

	static BGWDataAsset_Array_TriggerEffectWithCondition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_Array_TriggerEffectWithCondition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_Array_TriggerEffectWithCondition));
	}
}
