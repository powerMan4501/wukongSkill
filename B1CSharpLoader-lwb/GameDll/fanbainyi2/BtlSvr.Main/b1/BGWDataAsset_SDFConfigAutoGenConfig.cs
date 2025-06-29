using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig")]
public class BGWDataAsset_SDFConfigAutoGenConfig : UBGWDataAsset
{
	private static bool BoneArray_1_First_IsValid;

	private static int BoneArray_1_First_Offset;

	private static FFieldAddress BoneArray_1_First_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_1_First_Marshaler;

	private static bool BoneArray_1_Next_IsValid;

	private static int BoneArray_1_Next_Offset;

	private static FFieldAddress BoneArray_1_Next_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_1_Next_Marshaler;

	private static bool BoneArray_2_First_IsValid;

	private static int BoneArray_2_First_Offset;

	private static FFieldAddress BoneArray_2_First_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_2_First_Marshaler;

	private static bool BoneArray_2_Next_IsValid;

	private static int BoneArray_2_Next_Offset;

	private static FFieldAddress BoneArray_2_Next_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_2_Next_Marshaler;

	private static bool BoneArray_3_First_IsValid;

	private static int BoneArray_3_First_Offset;

	private static FFieldAddress BoneArray_3_First_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_3_First_Marshaler;

	private static bool BoneArray_3_Next_IsValid;

	private static int BoneArray_3_Next_Offset;

	private static FFieldAddress BoneArray_3_Next_PropertyAddress;

	private TArrayReadWriteMarshaler<FName> BoneArray_3_Next_Marshaler;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_1_First")]
	public TArrayReadWrite<FName> BoneArray_1_First
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_1_First_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_1_First");
				return null;
			}
			if (BoneArray_1_First_Marshaler == null)
			{
				BoneArray_1_First_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_1_First_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_1_First_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_1_First_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_1_Next")]
	public TArrayReadWrite<FName> BoneArray_1_Next
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_1_Next_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_1_Next");
				return null;
			}
			if (BoneArray_1_Next_Marshaler == null)
			{
				BoneArray_1_Next_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_1_Next_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_1_Next_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_1_Next_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_2_First")]
	public TArrayReadWrite<FName> BoneArray_2_First
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_2_First_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_2_First");
				return null;
			}
			if (BoneArray_2_First_Marshaler == null)
			{
				BoneArray_2_First_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_2_First_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_2_First_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_2_First_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_2_Next")]
	public TArrayReadWrite<FName> BoneArray_2_Next
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_2_Next_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_2_Next");
				return null;
			}
			if (BoneArray_2_Next_Marshaler == null)
			{
				BoneArray_2_Next_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_2_Next_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_2_Next_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_2_Next_Offset));
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_3_First")]
	public TArrayReadWrite<FName> BoneArray_3_First
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_3_First_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_3_First");
				return null;
			}
			if (BoneArray_3_First_Marshaler == null)
			{
				BoneArray_3_First_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_3_First_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_3_First_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_3_First_Offset));
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_3_Next")]
	public TArrayReadWrite<FName> BoneArray_3_Next
	{
		get
		{
			CheckDestroyed();
			if (!BoneArray_3_Next_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig:BoneArray_3_Next");
				return null;
			}
			if (BoneArray_3_Next_Marshaler == null)
			{
				BoneArray_3_Next_Marshaler = new TArrayReadWriteMarshaler<FName>(1, BoneArray_3_Next_PropertyAddress, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.FromNative, CachedMarshalingDelegates<FName, BlittableTypeMarshaler<FName>>.ToNative);
			}
			return BoneArray_3_Next_Marshaler.FromNative(IntPtr.Add(base.Address, BoneArray_3_Next_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGWDataAsset_SDFConfigAutoGenConfig");
		NativeReflection.GetPropertyRef(ref BoneArray_1_First_PropertyAddress, unrealStruct, "BoneArray_1_First");
		BoneArray_1_First_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_1_First");
		BoneArray_1_First_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_1_First", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneArray_1_Next_PropertyAddress, unrealStruct, "BoneArray_1_Next");
		BoneArray_1_Next_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_1_Next");
		BoneArray_1_Next_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_1_Next", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneArray_2_First_PropertyAddress, unrealStruct, "BoneArray_2_First");
		BoneArray_2_First_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_2_First");
		BoneArray_2_First_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_2_First", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneArray_2_Next_PropertyAddress, unrealStruct, "BoneArray_2_Next");
		BoneArray_2_Next_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_2_Next");
		BoneArray_2_Next_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_2_Next", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneArray_3_First_PropertyAddress, unrealStruct, "BoneArray_3_First");
		BoneArray_3_First_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_3_First");
		BoneArray_3_First_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_3_First", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BoneArray_3_Next_PropertyAddress, unrealStruct, "BoneArray_3_Next");
		BoneArray_3_Next_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneArray_3_Next");
		BoneArray_3_Next_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneArray_3_Next", Classes.FArrayProperty);
	}

	static BGWDataAsset_SDFConfigAutoGenConfig()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGWDataAsset_SDFConfigAutoGenConfig)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGWDataAsset_SDFConfigAutoGenConfig));
	}
}
