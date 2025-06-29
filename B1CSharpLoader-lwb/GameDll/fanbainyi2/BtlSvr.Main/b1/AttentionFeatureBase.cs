using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.AttentionFeatureBase")]
public class AttentionFeatureBase : UObject
{
	private static bool FeatureType_IsValid;

	private static int FeatureType_Offset;

	private static FFieldAddress FeatureType_PropertyAddress;

	[UProperty]
	[USharpPath("/Script/b1-Managed.AttentionFeatureBase:FeatureType")]
	public EAIAttentionFeatureType FeatureType
	{
		get
		{
			CheckDestroyed();
			if (!FeatureType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AttentionFeatureBase:FeatureType");
				return EAIAttentionFeatureType.None;
			}
			return EnumMarshaler<EAIAttentionFeatureType>.FromNative(IntPtr.Add(base.Address, FeatureType_Offset), 0, FeatureType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!FeatureType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.AttentionFeatureBase:FeatureType");
			}
			else
			{
				EnumMarshaler<EAIAttentionFeatureType>.ToNative(IntPtr.Add(base.Address, FeatureType_Offset), 0, FeatureType_PropertyAddress.Address, value);
			}
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.AttentionFeatureBase");
		NativeReflection.GetPropertyRef(ref FeatureType_PropertyAddress, unrealStruct, "FeatureType");
		FeatureType_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FeatureType");
		FeatureType_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FeatureType", Classes.FEnumProperty);
	}

	static AttentionFeatureBase()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(AttentionFeatureBase)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(AttentionFeatureBase));
	}
}
