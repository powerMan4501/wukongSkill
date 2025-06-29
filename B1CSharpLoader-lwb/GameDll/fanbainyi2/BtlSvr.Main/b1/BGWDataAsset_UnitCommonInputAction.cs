using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitCommonInputAction")]
public class BGWDataAsset_UnitCommonInputAction : UBGWDataAsset
{
	private static bool CommonInputAction_IsValid;

	private static int CommonInputAction_Offset;

	private static FFieldAddress CommonInputAction_PropertyAddress;

	private TArrayReadWriteMarshaler<int> CommonInputAction_Marshaler;

	[EditAnywhere]
	[UProperty]
	[BlueprintReadOnly]
	[Category("Common Input Action")]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_UnitCommonInputAction:CommonInputAction")]
	public TArrayReadWrite<int> CommonInputAction
	{
		get
		{
			CheckDestroyed();
			if (!CommonInputAction_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_UnitCommonInputAction:CommonInputAction");
				return null;
			}
			if (CommonInputAction_Marshaler == null)
			{
				CommonInputAction_Marshaler = new TArrayReadWriteMarshaler<int>(1, CommonInputAction_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return CommonInputAction_Marshaler.FromNative(IntPtr.Add(base.Address, CommonInputAction_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_UnitCommonInputAction");
		NativeReflection.GetPropertyRef(ref CommonInputAction_PropertyAddress, unrealStruct, "CommonInputAction");
		CommonInputAction_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommonInputAction");
		CommonInputAction_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommonInputAction", Classes.FArrayProperty);
	}

	static BGWDataAsset_UnitCommonInputAction()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_UnitCommonInputAction)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_UnitCommonInputAction));
	}
}
