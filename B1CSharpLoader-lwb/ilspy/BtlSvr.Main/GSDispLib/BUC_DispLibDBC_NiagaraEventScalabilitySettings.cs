using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings")]
public struct BUC_DispLibDBC_NiagaraEventScalabilitySettings
{
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:Enable")]
	public bool Enable;

	[UMeta(MDProp.EditCondition, "Enable")]
	[DisplayName("共享池模式")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:PoolMode")]
	public DispLibDBCNiagaraScalabilityPoolMode PoolMode;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Low")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:Low")]
	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings Low;

	[UMeta(MDProp.EditCondition, "Enable")]
	[DisplayName("Medium")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:Medium")]
	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings Medium;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("High")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:High")]
	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings High;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Epic")]
	[UMeta(MDProp.EditCondition, "Enable")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:Epic")]
	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings Epic;

	[UMeta(MDProp.EditCondition, "Enable")]
	[DisplayName("Cinematic")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings:Cinematic")]
	public BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings Cinematic;

	private static int BUC_DispLibDBC_NiagaraEventScalabilitySettings_StructSize;

	private static int BUC_DispLibDBC_NiagaraEventScalabilitySettings_IsValid;

	private static bool Enable_IsValid;

	private static int Enable_Offset;

	private static FFieldAddress Enable_PropertyAddress;

	private static bool PoolMode_IsValid;

	private static int PoolMode_Offset;

	private static FFieldAddress PoolMode_PropertyAddress;

	private static bool Low_IsValid;

	private static int Low_Offset;

	private static bool Medium_IsValid;

	private static int Medium_Offset;

	private static bool High_IsValid;

	private static int High_Offset;

	private static bool Epic_IsValid;

	private static int Epic_Offset;

	private static bool Cinematic_IsValid;

	private static int Cinematic_Offset;

	public BUC_DispLibDBC_NiagaraEventScalabilitySettings Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_NiagaraEventScalabilitySettings FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_NiagaraEventScalabilitySettings(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_NiagaraEventScalabilitySettings value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_NiagaraEventScalabilitySettings FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_NiagaraEventScalabilitySettings(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_NiagaraEventScalabilitySettings_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_NiagaraEventScalabilitySettings value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_NiagaraEventScalabilitySettings_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_NiagaraEventScalabilitySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings");
			return;
		}
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address, Enable);
		EnumMarshaler<DispLibDBCNiagaraScalabilityPoolMode>.ToNative(IntPtr.Add(nativeStruct, PoolMode_Offset), 0, PoolMode_PropertyAddress.Address, PoolMode);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, Low_Offset), Low);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, Medium_Offset), Medium);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, High_Offset), High);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, Epic_Offset), Epic);
		BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.ToNative(IntPtr.Add(nativeStruct, Cinematic_Offset), Cinematic);
	}

	public BUC_DispLibDBC_NiagaraEventScalabilitySettings(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_NiagaraEventScalabilitySettings_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings");
			Enable = false;
			PoolMode = DispLibDBCNiagaraScalabilityPoolMode.GlobalSameDataAssets;
			Low = default(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings);
			Medium = default(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings);
			High = default(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings);
			Epic = default(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings);
			Cinematic = default(BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings);
		}
		else
		{
			Enable = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Enable_Offset), 0, Enable_PropertyAddress.Address);
			PoolMode = EnumMarshaler<DispLibDBCNiagaraScalabilityPoolMode>.FromNative(IntPtr.Add(nativeStruct, PoolMode_Offset), 0, PoolMode_PropertyAddress.Address);
			Low = BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, Low_Offset));
			Medium = BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, Medium_Offset));
			High = BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, High_Offset));
			Epic = BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, Epic_Offset));
			Cinematic = BUC_DispLibDBC_OneEffectQualityNiagaraScalabilitySettings.FromNative(IntPtr.Add(nativeStruct, Cinematic_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings");
		BUC_DispLibDBC_NiagaraEventScalabilitySettings_StructSize = NativeReflection.GetStructSize(intPtr);
		NativeReflection.GetPropertyRef(ref Enable_PropertyAddress, intPtr, "Enable");
		Enable_Offset = NativeReflection.GetPropertyOffset(intPtr, "Enable");
		Enable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Enable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref PoolMode_PropertyAddress, intPtr, "PoolMode");
		PoolMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "PoolMode");
		PoolMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PoolMode", Classes.FEnumProperty);
		Low_Offset = NativeReflection.GetPropertyOffset(intPtr, "Low");
		Low_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Low", Classes.FStructProperty);
		Medium_Offset = NativeReflection.GetPropertyOffset(intPtr, "Medium");
		Medium_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Medium", Classes.FStructProperty);
		High_Offset = NativeReflection.GetPropertyOffset(intPtr, "High");
		High_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "High", Classes.FStructProperty);
		Epic_Offset = NativeReflection.GetPropertyOffset(intPtr, "Epic");
		Epic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Epic", Classes.FStructProperty);
		Cinematic_Offset = NativeReflection.GetPropertyOffset(intPtr, "Cinematic");
		Cinematic_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Cinematic", Classes.FStructProperty);
		BUC_DispLibDBC_NiagaraEventScalabilitySettings_IsValid = ((intPtr != IntPtr.Zero && Enable_IsValid && PoolMode_IsValid && Low_IsValid && Medium_IsValid && High_IsValid && Epic_IsValid && Cinematic_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_NiagaraEventScalabilitySettings", (byte)BUC_DispLibDBC_NiagaraEventScalabilitySettings_IsValid != 0);
	}

	static BUC_DispLibDBC_NiagaraEventScalabilitySettings()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_NiagaraEventScalabilitySettings)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_NiagaraEventScalabilitySettings));
	}
}
