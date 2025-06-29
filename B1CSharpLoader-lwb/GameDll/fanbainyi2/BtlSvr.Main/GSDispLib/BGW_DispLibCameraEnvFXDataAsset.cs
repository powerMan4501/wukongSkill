using System;
using b1;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset")]
public class BGW_DispLibCameraEnvFXDataAsset : UBGWDataAsset
{
	private static bool UseCameraEnvFX_IsValid;

	private static int UseCameraEnvFX_Offset;

	private static FFieldAddress UseCameraEnvFX_PropertyAddress;

	private static bool CameraZOffset_IsValid;

	private static int CameraZOffset_Offset;

	private static bool CameraOffset_IsValid;

	private static int CameraOffset_Offset;

	private static bool CameraEnvFXConfig_IsValid;

	private static int CameraEnvFXConfig_Offset;

	private static FFieldAddress CameraEnvFXConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<BUC_DispLibDBC_CameraEnvFXInfo> CameraEnvFXConfig_Marshaler;

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Camera Env FX")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:UseCameraEnvFX")]
	public bool UseCameraEnvFX
	{
		get
		{
			CheckDestroyed();
			if (!UseCameraEnvFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:UseCameraEnvFX");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseCameraEnvFX_Offset), 0, UseCameraEnvFX_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseCameraEnvFX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:UseCameraEnvFX");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseCameraEnvFX_Offset), 0, UseCameraEnvFX_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[Tooltip("环境特效在本地玩家的相机Z轴方向上偏移此距离")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("Camera Env FX")]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraZOffset")]
	public float CameraZOffset
	{
		get
		{
			CheckDestroyed();
			if (!CameraZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraZOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CameraZOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraZOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CameraZOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Camera Env FX")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraOffset")]
	public FVector CameraOffset
	{
		get
		{
			CheckDestroyed();
			if (!CameraOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, CameraOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CameraOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, CameraOffset_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[Category("Camera Env FX")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraEnvFXConfig")]
	public TArrayReadWrite<BUC_DispLibDBC_CameraEnvFXInfo> CameraEnvFXConfig
	{
		get
		{
			CheckDestroyed();
			if (!CameraEnvFXConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset:CameraEnvFXConfig");
				return null;
			}
			if (CameraEnvFXConfig_Marshaler == null)
			{
				CameraEnvFXConfig_Marshaler = new TArrayReadWriteMarshaler<BUC_DispLibDBC_CameraEnvFXInfo>(1, CameraEnvFXConfig_PropertyAddress, CachedMarshalingDelegates<BUC_DispLibDBC_CameraEnvFXInfo, BUC_DispLibDBC_CameraEnvFXInfo>.FromNative, CachedMarshalingDelegates<BUC_DispLibDBC_CameraEnvFXInfo, BUC_DispLibDBC_CameraEnvFXInfo>.ToNative);
			}
			return CameraEnvFXConfig_Marshaler.FromNative(IntPtr.Add(base.Address, CameraEnvFXConfig_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGW_DispLibCameraEnvFXDataAsset");
		NativeReflection.GetPropertyRef(ref UseCameraEnvFX_PropertyAddress, unrealStruct, "UseCameraEnvFX");
		UseCameraEnvFX_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseCameraEnvFX");
		UseCameraEnvFX_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseCameraEnvFX", Classes.FBoolProperty);
		CameraZOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraZOffset");
		CameraZOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraZOffset", Classes.FFloatProperty);
		CameraOffset_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraOffset");
		CameraOffset_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraOffset", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref CameraEnvFXConfig_PropertyAddress, unrealStruct, "CameraEnvFXConfig");
		CameraEnvFXConfig_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CameraEnvFXConfig");
		CameraEnvFXConfig_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CameraEnvFXConfig", Classes.FArrayProperty);
	}

	static BGW_DispLibCameraEnvFXDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGW_DispLibCameraEnvFXDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGW_DispLibCameraEnvFXDataAsset));
	}
}
