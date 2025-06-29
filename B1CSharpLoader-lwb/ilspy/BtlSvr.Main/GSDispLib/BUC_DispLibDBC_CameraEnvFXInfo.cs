using System;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo")]
public struct BUC_DispLibDBC_CameraEnvFXInfo
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("关卡名")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo:LevelName")]
	public FName LevelName;

	[DisplayName("环境特效")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo:NiagaraSystem")]
	public UNiagaraSystem NiagaraSystem;

	private static int BUC_DispLibDBC_CameraEnvFXInfo_StructSize;

	private static int BUC_DispLibDBC_CameraEnvFXInfo_IsValid;

	private static bool LevelName_IsValid;

	private static int LevelName_Offset;

	private static bool NiagaraSystem_IsValid;

	private static int NiagaraSystem_Offset;

	public BUC_DispLibDBC_CameraEnvFXInfo Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_CameraEnvFXInfo FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_CameraEnvFXInfo(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_CameraEnvFXInfo value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_CameraEnvFXInfo FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_CameraEnvFXInfo(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_CameraEnvFXInfo_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_CameraEnvFXInfo value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_CameraEnvFXInfo_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_CameraEnvFXInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo");
			return;
		}
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, LevelName_Offset), LevelName);
		UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(nativeStruct, NiagaraSystem_Offset), NiagaraSystem);
	}

	public BUC_DispLibDBC_CameraEnvFXInfo(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_CameraEnvFXInfo_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo");
			LevelName = default(FName);
			NiagaraSystem = null;
		}
		else
		{
			LevelName = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, LevelName_Offset));
			NiagaraSystem = UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(nativeStruct, NiagaraSystem_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo");
		BUC_DispLibDBC_CameraEnvFXInfo_StructSize = NativeReflection.GetStructSize(intPtr);
		LevelName_Offset = NativeReflection.GetPropertyOffset(intPtr, "LevelName");
		LevelName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LevelName", Classes.FNameProperty);
		NiagaraSystem_Offset = NativeReflection.GetPropertyOffset(intPtr, "NiagaraSystem");
		NiagaraSystem_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NiagaraSystem", Classes.FObjectProperty);
		BUC_DispLibDBC_CameraEnvFXInfo_IsValid = ((intPtr != IntPtr.Zero && LevelName_IsValid && NiagaraSystem_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_CameraEnvFXInfo", (byte)BUC_DispLibDBC_CameraEnvFXInfo_IsValid != 0);
	}

	static BUC_DispLibDBC_CameraEnvFXInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_CameraEnvFXInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_CameraEnvFXInfo));
	}
}
