using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationSharing;

[UClass(Flags = (ClassFlags)817889448uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationSharing.AnimSharingTransitionInstance", "AnimationSharing", UnrealModuleType.EnginePlugin)]
public class UAnimSharingTransitionInstance : UAnimInstance
{
	private static bool FromComponent_IsValid;

	private static int FromComponent_Offset;

	private static bool ToComponent_IsValid;

	private static int ToComponent_Offset;

	private static bool BlendTime_IsValid;

	private static int BlendTime_Offset;

	private static bool BlendBool_IsValid;

	private static FFieldAddress BlendBool_PropertyAddress;

	private static int BlendBool_Offset;

	[UProperty(Flags = (PropFlags)12393764862108189uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingTransitionInstance:FromComponent")]
	protected TWeakObject<USkeletalMeshComponent> FromComponent
	{
		get
		{
			CheckDestroyed();
			if (!FromComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:FromComponent");
				return default(TWeakObject<USkeletalMeshComponent>);
			}
			return TWeakObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, FromComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FromComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:FromComponent");
			}
			else
			{
				TWeakObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, FromComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764862108189uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingTransitionInstance:ToComponent")]
	protected TWeakObject<USkeletalMeshComponent> ToComponent
	{
		get
		{
			CheckDestroyed();
			if (!ToComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:ToComponent");
				return default(TWeakObject<USkeletalMeshComponent>);
			}
			return TWeakObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, ToComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ToComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:ToComponent");
			}
			else
			{
				TWeakObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, ToComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingTransitionInstance:BlendTime")]
	protected float BlendTime
	{
		get
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:BlendTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BlendTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BlendTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:BlendTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BlendTime_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingTransitionInstance:bBlendBool")]
	protected bool BlendBool
	{
		get
		{
			CheckDestroyed();
			if (!BlendBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:bBlendBool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, BlendBool_Offset), 0, BlendBool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!BlendBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingTransitionInstance:bBlendBool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, BlendBool_Offset), 0, BlendBool_PropertyAddress.Address, value);
			}
		}
	}

	static UAnimSharingTransitionInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSharingTransitionInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSharingTransitionInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimationSharing.AnimSharingTransitionInstance");
		FromComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "FromComponent");
		FromComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "FromComponent", Classes.FWeakObjectProperty);
		ToComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "ToComponent");
		ToComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "ToComponent", Classes.FWeakObjectProperty);
		BlendTime_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BlendTime");
		BlendTime_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BlendTime", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref BlendBool_PropertyAddress, unrealStruct, "bBlendBool");
		BlendBool_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bBlendBool");
		BlendBool_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bBlendBool", Classes.FBoolProperty);
	}
}
