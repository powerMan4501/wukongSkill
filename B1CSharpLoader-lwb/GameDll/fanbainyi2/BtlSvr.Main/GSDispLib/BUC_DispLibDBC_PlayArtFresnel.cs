using System;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UStruct]
[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel")]
public struct BUC_DispLibDBC_PlayArtFresnel
{
	[DisplayName("影响范围")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:FilterMode")]
	public BUC_DispLibDBC_MaterialEffectTargetInfo FilterMode;

	[DisplayName("延迟时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:Delay")]
	public float Delay;

	[DisplayName("效果数据")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:CustomUAFDataAsset")]
	public BUC_DispLibUnitArtFresnelDataAsset CustomUAFDataAsset;

	[Category("通用")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("优先级")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:Priority")]
	public int Priority;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("结束模式")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:EndMode")]
	public DispLibDBCEndMode EndMode;

	[Category("时间")]
	[UMeta(MDProp.EditCondition, "OverrideLoop == 0 && EndMode != DispLibDBCEndMode::ProcedureNotity")]
	[DisplayName("Override 总持续时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "EndMode是【ProcedureEnd】时该字段无效")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideTime")]
	public float OverrideTime;

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Override 使用程序化Power曲线")]
	[UProperty]
	[Category("时间")]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MD.ToolTip, "0 = UseSource, 1 = False, 2 = True")]
	[UMeta(MDProp.ClampMax, "2")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideSimpleProgrammedCurve")]
	public int OverrideSimpleProgrammedCurve;

	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[Category("时间")]
	[DisplayName("Override 程序化Power爆发时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideFadeInTime")]
	public float OverrideFadeInTime;

	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[Category("时间")]
	[DisplayName("Override 程序化Power平稳时间")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideCommonTime")]
	public float OverrideCommonTime;

	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[Category("时间")]
	[DisplayName("Override 程序化Power消退时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideFadeOutTime")]
	public float OverrideFadeOutTime;

	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve == 2")]
	[DisplayName("Override 程序化Power最大值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideProgrammedPowerMax")]
	public float OverrideProgrammedPowerMax;

	[UProperty]
	[Category("时间")]
	[UMeta(MD.ToolTip, "程序化Power曲线模式下，单次循环时间会自动计算 = 三段程序化时间之和")]
	[UMeta(MDProp.EditCondition, "OverrideSimpleProgrammedCurve != 2")]
	[DisplayName("Override 单次循环时间")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideOnePeriodTime")]
	public float OverrideOnePeriodTime;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, "0")]
	[UMeta(MDProp.ClampMax, "2")]
	[DisplayName("Override 无限循环")]
	[UMeta(MD.ToolTip, "0 = UseSource, 1 = False, 2 = True")]
	[Category("时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:OverrideLoop")]
	public int OverrideLoop;

	[DisplayName("暂停优先级")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MD.ToolTip, "当触发暂停时会给定一个优先级，如果此参数大于优先级则不会被暂停")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel:PausePriority")]
	public int PausePriority;

	private static int BUC_DispLibDBC_PlayArtFresnel_StructSize;

	private static int BUC_DispLibDBC_PlayArtFresnel_IsValid;

	private static bool FilterMode_IsValid;

	private static int FilterMode_Offset;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	private static bool CustomUAFDataAsset_IsValid;

	private static int CustomUAFDataAsset_Offset;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool EndMode_IsValid;

	private static int EndMode_Offset;

	private static FFieldAddress EndMode_PropertyAddress;

	private static bool OverrideTime_IsValid;

	private static int OverrideTime_Offset;

	private static bool OverrideSimpleProgrammedCurve_IsValid;

	private static int OverrideSimpleProgrammedCurve_Offset;

	private static bool OverrideFadeInTime_IsValid;

	private static int OverrideFadeInTime_Offset;

	private static bool OverrideCommonTime_IsValid;

	private static int OverrideCommonTime_Offset;

	private static bool OverrideFadeOutTime_IsValid;

	private static int OverrideFadeOutTime_Offset;

	private static bool OverrideProgrammedPowerMax_IsValid;

	private static int OverrideProgrammedPowerMax_Offset;

	private static bool OverrideOnePeriodTime_IsValid;

	private static int OverrideOnePeriodTime_Offset;

	private static bool OverrideLoop_IsValid;

	private static int OverrideLoop_Offset;

	private static bool PausePriority_IsValid;

	private static int PausePriority_Offset;

	public BUC_DispLibDBC_PlayArtFresnel Copy()
	{
		return this;
	}

	public static BUC_DispLibDBC_PlayArtFresnel FromNative(IntPtr nativeBuffer)
	{
		return new BUC_DispLibDBC_PlayArtFresnel(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, BUC_DispLibDBC_PlayArtFresnel value)
	{
		value.ToNative(nativeBuffer);
	}

	public static BUC_DispLibDBC_PlayArtFresnel FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new BUC_DispLibDBC_PlayArtFresnel(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayArtFresnel_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, BUC_DispLibDBC_PlayArtFresnel value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * BUC_DispLibDBC_PlayArtFresnel_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayArtFresnel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel");
			return;
		}
		BUC_DispLibDBC_MaterialEffectTargetInfo.ToNative(IntPtr.Add(nativeStruct, FilterMode_Offset), FilterMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>.ToNative(IntPtr.Add(nativeStruct, CustomUAFDataAsset_Offset), CustomUAFDataAsset);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, Priority_Offset), Priority);
		EnumMarshaler<DispLibDBCEndMode>.ToNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address, EndMode);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideTime_Offset), OverrideTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OverrideSimpleProgrammedCurve_Offset), OverrideSimpleProgrammedCurve);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideFadeInTime_Offset), OverrideFadeInTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideCommonTime_Offset), OverrideCommonTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideFadeOutTime_Offset), OverrideFadeOutTime);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideProgrammedPowerMax_Offset), OverrideProgrammedPowerMax);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideOnePeriodTime_Offset), OverrideOnePeriodTime);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, OverrideLoop_Offset), OverrideLoop);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, PausePriority_Offset), PausePriority);
	}

	public BUC_DispLibDBC_PlayArtFresnel(IntPtr nativeStruct)
	{
		if (BUC_DispLibDBC_PlayArtFresnel_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel");
			FilterMode = default(BUC_DispLibDBC_MaterialEffectTargetInfo);
			Delay = 0f;
			CustomUAFDataAsset = null;
			Priority = 0;
			EndMode = DispLibDBCEndMode.AutoRelease;
			OverrideTime = 0f;
			OverrideSimpleProgrammedCurve = 0;
			OverrideFadeInTime = 0f;
			OverrideCommonTime = 0f;
			OverrideFadeOutTime = 0f;
			OverrideProgrammedPowerMax = 0f;
			OverrideOnePeriodTime = 0f;
			OverrideLoop = 0;
			PausePriority = 0;
		}
		else
		{
			FilterMode = BUC_DispLibDBC_MaterialEffectTargetInfo.FromNative(IntPtr.Add(nativeStruct, FilterMode_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			CustomUAFDataAsset = UObjectMarshaler<BUC_DispLibUnitArtFresnelDataAsset>.FromNative(IntPtr.Add(nativeStruct, CustomUAFDataAsset_Offset));
			Priority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, Priority_Offset));
			EndMode = EnumMarshaler<DispLibDBCEndMode>.FromNative(IntPtr.Add(nativeStruct, EndMode_Offset), 0, EndMode_PropertyAddress.Address);
			OverrideTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideTime_Offset));
			OverrideSimpleProgrammedCurve = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OverrideSimpleProgrammedCurve_Offset));
			OverrideFadeInTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideFadeInTime_Offset));
			OverrideCommonTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideCommonTime_Offset));
			OverrideFadeOutTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideFadeOutTime_Offset));
			OverrideProgrammedPowerMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideProgrammedPowerMax_Offset));
			OverrideOnePeriodTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideOnePeriodTime_Offset));
			OverrideLoop = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, OverrideLoop_Offset));
			PausePriority = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, PausePriority_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel");
		BUC_DispLibDBC_PlayArtFresnel_StructSize = NativeReflection.GetStructSize(intPtr);
		FilterMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "FilterMode");
		FilterMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FilterMode", Classes.FStructProperty);
		Delay_Offset = NativeReflection.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		CustomUAFDataAsset_Offset = NativeReflection.GetPropertyOffset(intPtr, "CustomUAFDataAsset");
		CustomUAFDataAsset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CustomUAFDataAsset", Classes.FObjectProperty);
		Priority_Offset = NativeReflection.GetPropertyOffset(intPtr, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Priority", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref EndMode_PropertyAddress, intPtr, "EndMode");
		EndMode_Offset = NativeReflection.GetPropertyOffset(intPtr, "EndMode");
		EndMode_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EndMode", Classes.FEnumProperty);
		OverrideTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideTime");
		OverrideTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideTime", Classes.FFloatProperty);
		OverrideSimpleProgrammedCurve_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideSimpleProgrammedCurve");
		OverrideSimpleProgrammedCurve_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideSimpleProgrammedCurve", Classes.FIntProperty);
		OverrideFadeInTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideFadeInTime");
		OverrideFadeInTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideFadeInTime", Classes.FFloatProperty);
		OverrideCommonTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideCommonTime");
		OverrideCommonTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideCommonTime", Classes.FFloatProperty);
		OverrideFadeOutTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideFadeOutTime");
		OverrideFadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideFadeOutTime", Classes.FFloatProperty);
		OverrideProgrammedPowerMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideProgrammedPowerMax");
		OverrideProgrammedPowerMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideProgrammedPowerMax", Classes.FFloatProperty);
		OverrideOnePeriodTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideOnePeriodTime");
		OverrideOnePeriodTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideOnePeriodTime", Classes.FFloatProperty);
		OverrideLoop_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverrideLoop");
		OverrideLoop_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverrideLoop", Classes.FIntProperty);
		PausePriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "PausePriority");
		PausePriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PausePriority", Classes.FIntProperty);
		BUC_DispLibDBC_PlayArtFresnel_IsValid = ((intPtr != IntPtr.Zero && FilterMode_IsValid && Delay_IsValid && CustomUAFDataAsset_IsValid && Priority_IsValid && EndMode_IsValid && OverrideTime_IsValid && OverrideSimpleProgrammedCurve_IsValid && OverrideFadeInTime_IsValid && OverrideCommonTime_IsValid && OverrideFadeOutTime_IsValid && OverrideProgrammedPowerMax_IsValid && OverrideOnePeriodTime_IsValid && OverrideLoop_IsValid && PausePriority_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.BUC_DispLibDBC_PlayArtFresnel", (byte)BUC_DispLibDBC_PlayArtFresnel_IsValid != 0);
	}

	static BUC_DispLibDBC_PlayArtFresnel()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibDBC_PlayArtFresnel)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibDBC_PlayArtFresnel));
	}
}
