using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings")]
public struct BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:Enable")]
	public bool Enable;

	[UMeta(MDProp.EditCondition, "Enable")]
	[BlueprintReadWrite]
	[DisplayName("最大同时存在实例数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:MaxSystemInstanceCount")]
	public int MaxSystemInstanceCount;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("模式")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:Mode")]
	public DispLibDBCNiagaraScalabilityKillMode Mode;

	[UMeta(MDProp.EditCondition, "Enable")]
	[BlueprintReadWrite]
	[DisplayName("SystemAge权重")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:AgeWeight")]
	public FVector2D AgeWeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("CameraDistance权重")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:CameraDistanceWeight")]
	public FVector2D CameraDistanceWeight;

	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "Enable")]
	[DisplayName("CameraForwardDirDot权重")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:CameraForwardDirDotWeight")]
	public FVector2D CameraForwardDirDotWeight;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("额外加分")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings:CustomWeightAdd")]
	public float CustomWeightAdd;

	private static int BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_StructSize;

	private static int BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_IsValid;

	private static bool Enable_IsValid;

	private static int Enable_Offset;

	private static FFieldAddress Enable_PropertyAddress;

	private static bool MaxSystemInstanceCount_IsValid;

	private static int MaxSystemInstanceCount_Offset;

	private static bool Mode_IsValid;

	private static int Mode_Offset;

	private static FFieldAddress Mode_PropertyAddress;

	private static bool AgeWeight_IsValid;

	private static int AgeWeight_Offset;

	private static bool CameraDistanceWeight_IsValid;

	private static int CameraDistanceWeight_Offset;

	private static bool CameraForwardDirDotWeight_IsValid;

	private static int CameraForwardDirDotWeight_Offset;

	private static bool CustomWeightAdd_IsValid;

	private static int CustomWeightAdd_Offset;

	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address, Enable);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, MaxSystemInstanceCount_Offset), MaxSystemInstanceCount);
		EnumMarshaler<DispLibDBCNiagaraScalabilityKillMode>.ToNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address, Mode);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, AgeWeight_Offset), AgeWeight);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, CameraDistanceWeight_Offset), CameraDistanceWeight);
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, CameraForwardDirDotWeight_Offset), CameraForwardDirDotWeight);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, CustomWeightAdd_Offset), CustomWeightAdd);
	}

	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings");
			Enable = false;
			MaxSystemInstanceCount = 0;
			Mode = DispLibDBCNiagaraScalabilityKillMode.IntoEndDispStage;
			AgeWeight = default(FVector2D);
			CameraDistanceWeight = default(FVector2D);
			CameraForwardDirDotWeight = default(FVector2D);
			CustomWeightAdd = 0f;
		}
		else
		{
			Enable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address);
			MaxSystemInstanceCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, MaxSystemInstanceCount_Offset));
			Mode = EnumMarshaler<DispLibDBCNiagaraScalabilityKillMode>.FromNative(IntPtr.Add(nativeStruct, Mode_Offset), 0, Mode_PropertyAddress.Address);
			AgeWeight = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, AgeWeight_Offset));
			CameraDistanceWeight = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, CameraDistanceWeight_Offset));
			CameraForwardDirDotWeight = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, CameraForwardDirDotWeight_Offset));
			CustomWeightAdd = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, CustomWeightAdd_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings");
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "Enable");
		Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Enable");
		Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Enable", Classes.FBoolProperty);
		MaxSystemInstanceCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxSystemInstanceCount");
		MaxSystemInstanceCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxSystemInstanceCount", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref Mode_PropertyAddress, intPtr, "Mode");
		Mode_Offset = NativeReflection.GetPropertyOffset(intPtr, "Mode");
		Mode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Mode", Classes.FEnumProperty);
		AgeWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "AgeWeight");
		AgeWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "AgeWeight", Classes.FStructProperty);
		CameraDistanceWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraDistanceWeight");
		CameraDistanceWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraDistanceWeight", Classes.FStructProperty);
		CameraForwardDirDotWeight_Offset = NativeReflection.GetPropertyOffset(intPtr, "CameraForwardDirDotWeight");
		CameraForwardDirDotWeight_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CameraForwardDirDotWeight", Classes.FStructProperty);
		CustomWeightAdd_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomWeightAdd");
		CustomWeightAdd_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomWeightAdd", Classes.FFloatProperty);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_IsValid = ((intPtr != IntPtr.Zero && Enable_IsValid && MaxSystemInstanceCount_IsValid && Mode_IsValid && AgeWeight_IsValid && CameraDistanceWeight_IsValid && CameraForwardDirDotWeight_IsValid && CustomWeightAdd_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings", (byte)BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings_IsValid != 0);
	}

	static BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings));
	}
}
