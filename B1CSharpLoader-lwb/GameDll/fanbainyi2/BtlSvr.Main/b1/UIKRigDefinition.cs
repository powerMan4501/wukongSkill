using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.UIKRigDefinition")]
public class UIKRigDefinition : UObject
{
	private static bool TargetTransforms_IsValid;

	private static int TargetTransforms_Offset;

	private static FFieldAddress TargetTransforms_PropertyAddress;

	private TArrayReadWriteMarshaler<FTransform> TargetTransforms_Marshaler;

	private static bool RefTransforms_IsValid;

	private static int RefTransforms_Offset;

	private static FFieldAddress RefTransforms_PropertyAddress;

	private TArrayReadWriteMarshaler<FTransform> RefTransforms_Marshaler;

	private static bool BoneNames_IsValid;

	private static int BoneNames_Offset;

	private static FFieldAddress BoneNames_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneNames_Marshaler;

	private static bool ChainLength_IsValid;

	private static int ChainLength_Offset;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UIKRigDefinition:TargetTransforms")]
	public TArrayReadWrite<FTransform> TargetTransforms
	{
		get
		{
			CheckDestroyed();
			if (!TargetTransforms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UIKRigDefinition:TargetTransforms");
				return null;
			}
			if (TargetTransforms_Marshaler == null)
			{
				TargetTransforms_Marshaler = new TArrayReadWriteMarshaler<FTransform>(1, TargetTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative);
			}
			return TargetTransforms_Marshaler.FromNative(IntPtr.Add(base.Address, TargetTransforms_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UIKRigDefinition:RefTransforms")]
	public TArrayReadWrite<FTransform> RefTransforms
	{
		get
		{
			CheckDestroyed();
			if (!RefTransforms_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UIKRigDefinition:RefTransforms");
				return null;
			}
			if (RefTransforms_Marshaler == null)
			{
				RefTransforms_Marshaler = new TArrayReadWriteMarshaler<FTransform>(1, RefTransforms_PropertyAddress, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.FromNative, CachedMarshalingDelegates<FTransform, BlittableTypeMarshaler<FTransform>>.ToNative);
			}
			return RefTransforms_Marshaler.FromNative(IntPtr.Add(base.Address, RefTransforms_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UIKRigDefinition:BoneNames")]
	public TArrayReadWrite<FName> BoneNames
	{
		get
		{
			CheckDestroyed();
			if (!BoneNames_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UIKRigDefinition:BoneNames");
				return null;
			}
			if (BoneNames_Marshaler == null)
			{
				BoneNames_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneNames_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneNames_Marshaler.FromNative(IntPtr.Add(base.Address, BoneNames_Offset));
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UIKRigDefinition:ChainLength")]
	public float ChainLength
	{
		get
		{
			CheckDestroyed();
			if (!ChainLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UIKRigDefinition:ChainLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ChainLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChainLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.UIKRigDefinition:ChainLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ChainLength_Offset), value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.UIKRigDefinition");
		NativeReflection.GetPropertyRef(ref TargetTransforms_PropertyAddress, unrealStruct, "TargetTransforms");
		TargetTransforms_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TargetTransforms");
		TargetTransforms_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TargetTransforms", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref RefTransforms_PropertyAddress, unrealStruct, "RefTransforms");
		RefTransforms_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RefTransforms");
		RefTransforms_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RefTransforms", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneNames_PropertyAddress, unrealStruct, "BoneNames");
		BoneNames_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneNames");
		BoneNames_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneNames", Classes.FArrayProperty);
		ChainLength_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChainLength");
		ChainLength_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChainLength", Classes.FFloatProperty);
	}

	static UIKRigDefinition()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UIKRigDefinition)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UIKRigDefinition));
	}
}
