using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)809578656uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSTrail", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSTrail : UAnimNotifyState_Trail
{
	private static bool IsNeedPauseWithOwner_IsValid;

	private static FFieldAddress IsNeedPauseWithOwner_PropertyAddress;

	private static int IsNeedPauseWithOwner_Offset;

	[UProperty(Flags = (PropFlags)6755468160532501uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSTrail:bIsNeedPauseWithOwner")]
	public bool IsNeedPauseWithOwner
	{
		get
		{
			CheckDestroyed();
			if (!IsNeedPauseWithOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSTrail:bIsNeedPauseWithOwner");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsNeedPauseWithOwner_Offset), 0, IsNeedPauseWithOwner_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsNeedPauseWithOwner_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSTrail:bIsNeedPauseWithOwner");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsNeedPauseWithOwner_Offset), 0, IsNeedPauseWithOwner_PropertyAddress.Address, value);
			}
		}
	}

	static UAnimNotifyState_GSTrail()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSTrail)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSTrail));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSTrail");
		NativeReflectionCached.GetPropertyRef(ref IsNeedPauseWithOwner_PropertyAddress, unrealStruct, "bIsNeedPauseWithOwner");
		IsNeedPauseWithOwner_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bIsNeedPauseWithOwner");
		IsNeedPauseWithOwner_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bIsNeedPauseWithOwner", Classes.FBoolProperty);
	}
}
