using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.DispLib_PostProcessConf")]
public class UDispLib_PostProcessConf : UBGWDataAsset
{
	private static bool RadialBlurConf_IsValid;

	private static int RadialBlurConf_Offset;

	private static bool InverseFieldConf_IsValid;

	private static int InverseFieldConf_Offset;

	private static bool CommonConfs_IsValid;

	private static int CommonConfs_Offset;

	private static FFieldAddress CommonConfs_PropertyAddress;

	private TArrayReadWriteMarshaler<UDispLib_PostPorcessCommonConf> CommonConfs_Marshaler;

	[EditAnywhere]
	[UProperty]
	[DisplayName("径向模糊配置")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.DispLib_PostProcessConf:RadialBlurConf")]
	public UDispLib_PostProcessRadialBlurConf RadialBlurConf
	{
		get
		{
			CheckDestroyed();
			if (!RadialBlurConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PostProcessConf:RadialBlurConf");
				return default(UDispLib_PostProcessRadialBlurConf);
			}
			return UDispLib_PostProcessRadialBlurConf.FromNative(IntPtr.Add(base.Address, RadialBlurConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RadialBlurConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PostProcessConf:RadialBlurConf");
			}
			else
			{
				UDispLib_PostProcessRadialBlurConf.ToNative(IntPtr.Add(base.Address, RadialBlurConf_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("逆场配置")]
	[USharpPath("/Script/b1-Managed.DispLib_PostProcessConf:InverseFieldConf")]
	public UDispLib_PostProcessBlueprintConf InverseFieldConf
	{
		get
		{
			CheckDestroyed();
			if (!InverseFieldConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PostProcessConf:InverseFieldConf");
				return default(UDispLib_PostProcessBlueprintConf);
			}
			return UDispLib_PostProcessBlueprintConf.FromNative(IntPtr.Add(base.Address, InverseFieldConf_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InverseFieldConf_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PostProcessConf:InverseFieldConf");
			}
			else
			{
				UDispLib_PostProcessBlueprintConf.ToNative(IntPtr.Add(base.Address, InverseFieldConf_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.DispLib_PostProcessConf:CommonConfs")]
	public TArrayReadWrite<UDispLib_PostPorcessCommonConf> CommonConfs
	{
		get
		{
			CheckDestroyed();
			if (!CommonConfs_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_PostProcessConf:CommonConfs");
				return null;
			}
			if (CommonConfs_Marshaler == null)
			{
				CommonConfs_Marshaler = new TArrayReadWriteMarshaler<UDispLib_PostPorcessCommonConf>(1, CommonConfs_PropertyAddress, CachedMarshalingDelegates<UDispLib_PostPorcessCommonConf, UDispLib_PostPorcessCommonConf>.FromNative, CachedMarshalingDelegates<UDispLib_PostPorcessCommonConf, UDispLib_PostPorcessCommonConf>.ToNative);
			}
			return CommonConfs_Marshaler.FromNative(IntPtr.Add(base.Address, CommonConfs_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.DispLib_PostProcessConf");
		RadialBlurConf_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "RadialBlurConf");
		RadialBlurConf_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "RadialBlurConf", Classes.FStructProperty);
		InverseFieldConf_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InverseFieldConf");
		InverseFieldConf_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InverseFieldConf", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CommonConfs_PropertyAddress, unrealStruct, "CommonConfs");
		CommonConfs_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommonConfs");
		CommonConfs_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommonConfs", Classes.FArrayProperty);
	}

	static UDispLib_PostProcessConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDispLib_PostProcessConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDispLib_PostProcessConf));
	}
}
