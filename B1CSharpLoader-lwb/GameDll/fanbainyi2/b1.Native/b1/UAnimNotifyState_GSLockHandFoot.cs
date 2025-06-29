using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass(Flags = (ClassFlags)810627232uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/b1.AnimNotifyState_GSLockHandFoot", "b1", UnrealModuleType.Game)]
public class UAnimNotifyState_GSLockHandFoot : UAnimNotifyState_GSBase
{
	private static bool NeedLockType_IsValid;

	private static FFieldAddress NeedLockType_PropertyAddress;

	private static int NeedLockType_Offset;

	private static bool BeginReduceScale_IsValid;

	private static int BeginReduceScale_Offset;

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSLockHandFoot:NeedLockType")]
	public EBUHandFootType NeedLockType
	{
		get
		{
			CheckDestroyed();
			if (!NeedLockType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSLockHandFoot:NeedLockType");
				return EBUHandFootType.None;
			}
			return EnumMarshaler<EBUHandFootType>.FromNative(IntPtr.Add(base.Address, NeedLockType_Offset), 0, NeedLockType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedLockType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSLockHandFoot:NeedLockType");
			}
			else
			{
				EnumMarshaler<EBUHandFootType>.ToNative(IntPtr.Add(base.Address, NeedLockType_Offset), 0, NeedLockType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)6755469234274837uL)]
	[UMetaPath("/Script/b1.AnimNotifyState_GSLockHandFoot:BeginReduceScale")]
	public float BeginReduceScale
	{
		get
		{
			CheckDestroyed();
			if (!BeginReduceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSLockHandFoot:BeginReduceScale");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BeginReduceScale_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BeginReduceScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1.AnimNotifyState_GSLockHandFoot:BeginReduceScale");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BeginReduceScale_Offset), value);
			}
		}
	}

	static UAnimNotifyState_GSLockHandFoot()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimNotifyState_GSLockHandFoot)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimNotifyState_GSLockHandFoot));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1.AnimNotifyState_GSLockHandFoot");
		NativeReflectionCached.GetPropertyRef(ref NeedLockType_PropertyAddress, unrealStruct, "NeedLockType");
		NeedLockType_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "NeedLockType");
		NeedLockType_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "NeedLockType", Classes.FEnumProperty);
		BeginReduceScale_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BeginReduceScale");
		BeginReduceScale_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BeginReduceScale", Classes.FFloatProperty);
	}
}
