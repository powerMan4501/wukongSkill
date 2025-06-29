using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig")]
public class BGWDataAsset_TryFindSceneItemConfig : UBGWDataAsset
{
	private static bool SceneActorTags_IsValid;

	private static int SceneActorTags_Offset;

	private static FFieldAddress SceneActorTags_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> SceneActorTags_Marshaler;

	private static bool MinDistance_IsValid;

	private static int MinDistance_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool FindSceneItemWay_IsValid;

	private static int FindSceneItemWay_Offset;

	private static FFieldAddress FindSceneItemWay_PropertyAddress;

	private static bool NeedRemoveCurrentCatch_IsValid;

	private static int NeedRemoveCurrentCatch_Offset;

	private static FFieldAddress NeedRemoveCurrentCatch_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:SceneActorTags")]
	public TArrayReadWrite<FName> SceneActorTags
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorTags_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:SceneActorTags");
				return null;
			}
			if (SceneActorTags_Marshaler == null)
			{
				SceneActorTags_Marshaler = new TArrayReadWriteMarshaler<FName>(1, SceneActorTags_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return SceneActorTags_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorTags_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MinDistance")]
	public float MinDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MinDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MinDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinDistance_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MaxDistance")]
	public float MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MaxDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:FindSceneItemWay")]
	public EFindSceneItemWay FindSceneItemWay
	{
		get
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:FindSceneItemWay");
				return EFindSceneItemWay.FindNearest;
			}
			return EnumMarshaler<EFindSceneItemWay>.FromNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FindSceneItemWay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:FindSceneItemWay");
			}
			else
			{
				EnumMarshaler<EFindSceneItemWay>.ToNative(IntPtr.Add(base.Address, FindSceneItemWay_Offset), 0, FindSceneItemWay_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:NeedRemoveCurrentCatch")]
	public bool NeedRemoveCurrentCatch
	{
		get
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:NeedRemoveCurrentCatch");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!NeedRemoveCurrentCatch_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig:NeedRemoveCurrentCatch");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, NeedRemoveCurrentCatch_Offset), 0, NeedRemoveCurrentCatch_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_TryFindSceneItemConfig");
		NativeReflection.GetPropertyRef(ref SceneActorTags_PropertyAddress, unrealStruct, "SceneActorTags");
		SceneActorTags_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneActorTags");
		SceneActorTags_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneActorTags", Classes.FArrayProperty);
		MinDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinDistance");
		MinDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinDistance", Classes.FFloatProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxDistance", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref FindSceneItemWay_PropertyAddress, unrealStruct, "FindSceneItemWay");
		FindSceneItemWay_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FindSceneItemWay");
		FindSceneItemWay_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FindSceneItemWay", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref NeedRemoveCurrentCatch_PropertyAddress, unrealStruct, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "NeedRemoveCurrentCatch");
		NeedRemoveCurrentCatch_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "NeedRemoveCurrentCatch", Classes.FBoolProperty);
	}

	static BGWDataAsset_TryFindSceneItemConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_TryFindSceneItemConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_TryFindSceneItemConfig));
	}
}
