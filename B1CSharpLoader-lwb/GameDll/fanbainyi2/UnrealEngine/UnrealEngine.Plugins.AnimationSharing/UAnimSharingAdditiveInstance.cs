using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace UnrealEngine.Plugins.AnimationSharing;

[UClass(Flags = (ClassFlags)817889448uL, Config = "Engine")]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/AnimationSharing.AnimSharingAdditiveInstance", "AnimationSharing", UnrealModuleType.EnginePlugin)]
public class UAnimSharingAdditiveInstance : UAnimInstance
{
	private static bool BaseComponent_IsValid;

	private static int BaseComponent_Offset;

	private static bool AdditiveAnimation_IsValid;

	private static int AdditiveAnimation_Offset;

	private static bool Alpha_IsValid;

	private static int Alpha_Offset;

	private static bool StateBool_IsValid;

	private static FFieldAddress StateBool_PropertyAddress;

	private static int StateBool_Offset;

	[UProperty(Flags = (PropFlags)12393764862108189uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingAdditiveInstance:BaseComponent")]
	protected TWeakObject<USkeletalMeshComponent> BaseComponent
	{
		get
		{
			CheckDestroyed();
			if (!BaseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:BaseComponent");
				return default(TWeakObject<USkeletalMeshComponent>);
			}
			return TWeakObjectMarshaler<USkeletalMeshComponent>.FromNative(IntPtr.Add(base.Address, BaseComponent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BaseComponent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:BaseComponent");
			}
			else
			{
				TWeakObjectMarshaler<USkeletalMeshComponent>.ToNative(IntPtr.Add(base.Address, BaseComponent_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)12393764861583893uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingAdditiveInstance:AdditiveAnimation")]
	protected TWeakObject<UAnimSequence> AdditiveAnimation
	{
		get
		{
			CheckDestroyed();
			if (!AdditiveAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:AdditiveAnimation");
				return default(TWeakObject<UAnimSequence>);
			}
			return TWeakObjectMarshaler<UAnimSequence>.FromNative(IntPtr.Add(base.Address, AdditiveAnimation_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AdditiveAnimation_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:AdditiveAnimation");
			}
			else
			{
				TWeakObjectMarshaler<UAnimSequence>.ToNative(IntPtr.Add(base.Address, AdditiveAnimation_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingAdditiveInstance:Alpha")]
	protected float Alpha
	{
		get
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:Alpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Alpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Alpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:Alpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Alpha_Offset), value);
			}
		}
	}

	[UProperty(Flags = (PropFlags)11267864954741269uL)]
	[UMetaPath("/Script/AnimationSharing.AnimSharingAdditiveInstance:bStateBool")]
	protected bool StateBool
	{
		get
		{
			CheckDestroyed();
			if (!StateBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:bStateBool");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, StateBool_Offset), 0, StateBool_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!StateBool_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/AnimationSharing.AnimSharingAdditiveInstance:bStateBool");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, StateBool_Offset), 0, StateBool_PropertyAddress.Address, value);
			}
		}
	}

	static UAnimSharingAdditiveInstance()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(UAnimSharingAdditiveInstance)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UAnimSharingAdditiveInstance));
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/AnimationSharing.AnimSharingAdditiveInstance");
		BaseComponent_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "BaseComponent");
		BaseComponent_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "BaseComponent", Classes.FWeakObjectProperty);
		AdditiveAnimation_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "AdditiveAnimation");
		AdditiveAnimation_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "AdditiveAnimation", Classes.FWeakObjectProperty);
		Alpha_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "Alpha");
		Alpha_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "Alpha", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref StateBool_PropertyAddress, unrealStruct, "bStateBool");
		StateBool_Offset = NativeReflectionCached.GetPropertyOffset(unrealStruct, "bStateBool");
		StateBool_IsValid = NativeReflectionCached.ValidatePropertyClass(unrealStruct, "bStateBool", Classes.FBoolProperty);
	}
}
