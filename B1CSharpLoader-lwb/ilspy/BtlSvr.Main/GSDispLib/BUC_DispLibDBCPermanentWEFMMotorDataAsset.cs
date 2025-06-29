using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset")]
public class BUC_DispLibDBCPermanentWEFMMotorDataAsset : UBGWDataAsset
{
	private static bool BaseWindMotor_IsValid;

	private static int BaseWindMotor_Offset;

	private static FFieldAddress BaseWindMotor_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_WEFMPermanentWind> BaseWindMotor_Marshaler;

	private static bool BaseHeatMotor_IsValid;

	private static int BaseHeatMotor_Offset;

	private static FFieldAddress BaseHeatMotor_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_Heat> BaseHeatMotor_Marshaler;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("常驻风源")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset:BaseWindMotor")]
	public TArrayReadWrite<BUC_DispLibDBC_WEFMPermanentWind> BaseWindMotor
	{
		get
		{
			CheckDestroyed();
			if (!BaseWindMotor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset:BaseWindMotor");
				return null;
			}
			if (BaseWindMotor_Marshaler == null)
			{
				BaseWindMotor_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_WEFMPermanentWind>(1, BaseWindMotor_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_WEFMPermanentWind, BUC_DispLibDBC_WEFMPermanentWind>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_WEFMPermanentWind, BUC_DispLibDBC_WEFMPermanentWind>.ToNative);
			}
			return BaseWindMotor_Marshaler.FromNative(IntPtr.Add(base.Address, BaseWindMotor_Offset));
		}
	}

	[EditAnywhere]
	[DisplayName("常驻热源")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset:BaseHeatMotor")]
	public TArrayReadWrite<BUC_DispLibDBC_Heat> BaseHeatMotor
	{
		get
		{
			CheckDestroyed();
			if (!BaseHeatMotor_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset:BaseHeatMotor");
				return null;
			}
			if (BaseHeatMotor_Marshaler == null)
			{
				BaseHeatMotor_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_Heat>(1, BaseHeatMotor_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_Heat, BUC_DispLibDBC_Heat>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_Heat, BUC_DispLibDBC_Heat>.ToNative);
			}
			return BaseHeatMotor_Marshaler.FromNative(IntPtr.Add(base.Address, BaseHeatMotor_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DispLibDBCPermanentWEFMMotorDataAsset");
		NativeReflection.GetPropertyRef(ref BaseWindMotor_PropertyAddress, unrealStruct, "BaseWindMotor");
		BaseWindMotor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaseWindMotor");
		BaseWindMotor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaseWindMotor", Classes.FArrayProperty);
		NativeReflection.GetPropertyRef(ref BaseHeatMotor_PropertyAddress, unrealStruct, "BaseHeatMotor");
		BaseHeatMotor_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BaseHeatMotor");
		BaseHeatMotor_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BaseHeatMotor", Classes.FArrayProperty);
	}

	static BUC_DispLibDBCPermanentWEFMMotorDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBCPermanentWEFMMotorDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBCPermanentWEFMMotorDataAsset));
	}
}
