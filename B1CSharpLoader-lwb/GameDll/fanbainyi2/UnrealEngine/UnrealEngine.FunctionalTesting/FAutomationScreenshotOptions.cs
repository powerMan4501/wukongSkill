using System;
using UnrealEngine.Runtime;

namespace UnrealEngine.FunctionalTesting;

[UStruct(Flags = 4097)]
[BlueprintType]
[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions", "FunctionalTesting", UnrealModuleType.Engine)]
public struct FAutomationScreenshotOptions
{
	private static bool Resolution_IsValid;

	private static int Resolution_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:Resolution")]
	public FVector2D Resolution;

	private static bool Delay_IsValid;

	private static int Delay_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:Delay")]
	public float Delay;

	private static bool Override_OverrideTimeTo_IsValid;

	private static FFieldAddress Override_OverrideTimeTo_PropertyAddress;

	private static int Override_OverrideTimeTo_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:bOverride_OverrideTimeTo")]
	public bool Override_OverrideTimeTo;

	private static bool OverrideTimeTo_IsValid;

	private static int OverrideTimeTo_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:OverrideTimeTo")]
	public float OverrideTimeTo;

	private static bool DisableNoisyRenderingFeatures_IsValid;

	private static FFieldAddress DisableNoisyRenderingFeatures_PropertyAddress;

	private static int DisableNoisyRenderingFeatures_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:bDisableNoisyRenderingFeatures")]
	public bool DisableNoisyRenderingFeatures;

	private static bool DisableTonemapping_IsValid;

	private static FFieldAddress DisableTonemapping_PropertyAddress;

	private static int DisableTonemapping_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:bDisableTonemapping")]
	public bool DisableTonemapping;

	private static bool ViewSettings_IsValid;

	private static int ViewSettings_Offset;

	[UProperty(Flags = (PropFlags)7881369141117445uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:ViewSettings")]
	public UAutomationViewSettings ViewSettings;

	private static bool VisualizeBuffer_IsValid;

	private static int VisualizeBuffer_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:VisualizeBuffer")]
	public FName VisualizeBuffer;

	private static bool Tolerance_IsValid;

	private static FFieldAddress Tolerance_PropertyAddress;

	private static int Tolerance_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:Tolerance")]
	public EComparisonTolerance Tolerance;

	private static bool ToleranceAmount_IsValid;

	private static int ToleranceAmount_Offset;

	[UProperty(Flags = (PropFlags)4503668346847237uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:ToleranceAmount")]
	public FComparisonToleranceAmount ToleranceAmount;

	private static bool MaximumLocalError_IsValid;

	private static int MaximumLocalError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:MaximumLocalError")]
	public float MaximumLocalError;

	private static bool MaximumGlobalError_IsValid;

	private static int MaximumGlobalError_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:MaximumGlobalError")]
	public float MaximumGlobalError;

	private static bool IgnoreAntiAliasing_IsValid;

	private static FFieldAddress IgnoreAntiAliasing_PropertyAddress;

	private static int IgnoreAntiAliasing_Offset;

	[UProperty(Flags = (PropFlags)6755469234274821uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:bIgnoreAntiAliasing")]
	public bool IgnoreAntiAliasing;

	private static bool IgnoreColors_IsValid;

	private static FFieldAddress IgnoreColors_PropertyAddress;

	private static int IgnoreColors_Offset;

	[UProperty(Flags = (PropFlags)6759867280785925uL)]
	[UMetaPath("/Script/FunctionalTesting.AutomationScreenshotOptions:bIgnoreColors")]
	public bool IgnoreColors;

	private static bool FAutomationScreenshotOptions_IsValid;

	private static int FAutomationScreenshotOptions_StructSize;

	public FAutomationScreenshotOptions Copy()
	{
		return this;
	}

	public static FAutomationScreenshotOptions FromNative(IntPtr nativeBuffer)
	{
		return new FAutomationScreenshotOptions(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, FAutomationScreenshotOptions value)
	{
		value.ToNative(nativeBuffer);
	}

	public static FAutomationScreenshotOptions FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new FAutomationScreenshotOptions(nativeBuffer + arrayIndex * FAutomationScreenshotOptions_StructSize);
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, FAutomationScreenshotOptions value)
	{
		value.ToNative(nativeBuffer + arrayIndex * FAutomationScreenshotOptions_StructSize);
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (!FAutomationScreenshotOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AutomationScreenshotOptions");
			return;
		}
		BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(nativeStruct, Resolution_Offset), Resolution);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, Delay_Offset), Delay);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, Override_OverrideTimeTo_Offset), 0, Override_OverrideTimeTo_PropertyAddress.Address, Override_OverrideTimeTo);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, OverrideTimeTo_Offset), OverrideTimeTo);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableNoisyRenderingFeatures_Offset), 0, DisableNoisyRenderingFeatures_PropertyAddress.Address, DisableNoisyRenderingFeatures);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, DisableTonemapping_Offset), 0, DisableTonemapping_PropertyAddress.Address, DisableTonemapping);
		UObjectMarshaler<UAutomationViewSettings>.ToNative(IntPtr.Add(nativeStruct, ViewSettings_Offset), ViewSettings);
		BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(nativeStruct, VisualizeBuffer_Offset), VisualizeBuffer);
		EnumMarshaler<EComparisonTolerance>.ToNative(IntPtr.Add(nativeStruct, Tolerance_Offset), 0, Tolerance_PropertyAddress.Address, Tolerance);
		FComparisonToleranceAmount.ToNative(IntPtr.Add(nativeStruct, ToleranceAmount_Offset), ToleranceAmount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaximumLocalError_Offset), MaximumLocalError);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, MaximumGlobalError_Offset), MaximumGlobalError);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreAntiAliasing_Offset), 0, IgnoreAntiAliasing_PropertyAddress.Address, IgnoreAntiAliasing);
		BoolMarshaler.ToNative(IntPtr.Add(nativeStruct, IgnoreColors_Offset), 0, IgnoreColors_PropertyAddress.Address, IgnoreColors);
	}

	public FAutomationScreenshotOptions(IntPtr nativeStruct)
	{
		if (!FAutomationScreenshotOptions_IsValid)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/FunctionalTesting.AutomationScreenshotOptions");
			Resolution = default(FVector2D);
			Delay = 0f;
			Override_OverrideTimeTo = false;
			OverrideTimeTo = 0f;
			DisableNoisyRenderingFeatures = false;
			DisableTonemapping = false;
			ViewSettings = null;
			VisualizeBuffer = default(FName);
			Tolerance = EComparisonTolerance.Zero;
			ToleranceAmount = default(FComparisonToleranceAmount);
			MaximumLocalError = 0f;
			MaximumGlobalError = 0f;
			IgnoreAntiAliasing = false;
			IgnoreColors = false;
		}
		else
		{
			Resolution = BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(nativeStruct, Resolution_Offset));
			Delay = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, Delay_Offset));
			Override_OverrideTimeTo = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, Override_OverrideTimeTo_Offset), 0, Override_OverrideTimeTo_PropertyAddress.Address);
			OverrideTimeTo = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, OverrideTimeTo_Offset));
			DisableNoisyRenderingFeatures = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableNoisyRenderingFeatures_Offset), 0, DisableNoisyRenderingFeatures_PropertyAddress.Address);
			DisableTonemapping = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, DisableTonemapping_Offset), 0, DisableTonemapping_PropertyAddress.Address);
			ViewSettings = UObjectMarshaler<UAutomationViewSettings>.FromNative(IntPtr.Add(nativeStruct, ViewSettings_Offset));
			VisualizeBuffer = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(nativeStruct, VisualizeBuffer_Offset));
			Tolerance = EnumMarshaler<EComparisonTolerance>.FromNative(IntPtr.Add(nativeStruct, Tolerance_Offset), 0, Tolerance_PropertyAddress.Address);
			ToleranceAmount = FComparisonToleranceAmount.FromNative(IntPtr.Add(nativeStruct, ToleranceAmount_Offset));
			MaximumLocalError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaximumLocalError_Offset));
			MaximumGlobalError = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, MaximumGlobalError_Offset));
			IgnoreAntiAliasing = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreAntiAliasing_Offset), 0, IgnoreAntiAliasing_PropertyAddress.Address);
			IgnoreColors = BoolMarshaler.FromNative(IntPtr.Add(nativeStruct, IgnoreColors_Offset), 0, IgnoreColors_PropertyAddress.Address);
		}
	}

	static FAutomationScreenshotOptions()
	{
		if (UnrealTypes.CanLazyLoadNativeType(typeof(FAutomationScreenshotOptions)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(FAutomationScreenshotOptions));
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/FunctionalTesting.AutomationScreenshotOptions");
		FAutomationScreenshotOptions_StructSize = NativeReflection.GetStructSize(intPtr);
		Resolution_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Resolution");
		Resolution_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Resolution", Classes.FStructProperty);
		Delay_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Delay");
		Delay_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Delay", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref Override_OverrideTimeTo_PropertyAddress, intPtr, "bOverride_OverrideTimeTo");
		Override_OverrideTimeTo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bOverride_OverrideTimeTo");
		Override_OverrideTimeTo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bOverride_OverrideTimeTo", Classes.FBoolProperty);
		OverrideTimeTo_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "OverrideTimeTo");
		OverrideTimeTo_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "OverrideTimeTo", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableNoisyRenderingFeatures_PropertyAddress, intPtr, "bDisableNoisyRenderingFeatures");
		DisableNoisyRenderingFeatures_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableNoisyRenderingFeatures");
		DisableNoisyRenderingFeatures_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableNoisyRenderingFeatures", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref DisableTonemapping_PropertyAddress, intPtr, "bDisableTonemapping");
		DisableTonemapping_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bDisableTonemapping");
		DisableTonemapping_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bDisableTonemapping", Classes.FBoolProperty);
		ViewSettings_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ViewSettings");
		ViewSettings_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ViewSettings", Classes.FObjectProperty);
		VisualizeBuffer_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "VisualizeBuffer");
		VisualizeBuffer_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "VisualizeBuffer", Classes.FNameProperty);
		NativeReflectionCached.GetPropertyRef(ref Tolerance_PropertyAddress, intPtr, "Tolerance");
		Tolerance_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "Tolerance");
		Tolerance_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "Tolerance", Classes.FEnumProperty);
		ToleranceAmount_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "ToleranceAmount");
		ToleranceAmount_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "ToleranceAmount", Classes.FStructProperty);
		MaximumLocalError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumLocalError");
		MaximumLocalError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumLocalError", Classes.FFloatProperty);
		MaximumGlobalError_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "MaximumGlobalError");
		MaximumGlobalError_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "MaximumGlobalError", Classes.FFloatProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreAntiAliasing_PropertyAddress, intPtr, "bIgnoreAntiAliasing");
		IgnoreAntiAliasing_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreAntiAliasing");
		IgnoreAntiAliasing_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreAntiAliasing", Classes.FBoolProperty);
		NativeReflectionCached.GetPropertyRef(ref IgnoreColors_PropertyAddress, intPtr, "bIgnoreColors");
		IgnoreColors_Offset = NativeReflectionCached.GetPropertyOffset(intPtr, "bIgnoreColors");
		IgnoreColors_IsValid = NativeReflectionCached.ValidatePropertyClass(intPtr, "bIgnoreColors", Classes.FBoolProperty);
		FAutomationScreenshotOptions_IsValid = intPtr != IntPtr.Zero && Resolution_IsValid && Delay_IsValid && Override_OverrideTimeTo_IsValid && OverrideTimeTo_IsValid && DisableNoisyRenderingFeatures_IsValid && DisableTonemapping_IsValid && ViewSettings_IsValid && VisualizeBuffer_IsValid && Tolerance_IsValid && ToleranceAmount_IsValid && MaximumLocalError_IsValid && MaximumGlobalError_IsValid && IgnoreAntiAliasing_IsValid && IgnoreColors_IsValid;
		NativeReflection.LogStructIsValid("/Script/FunctionalTesting.AutomationScreenshotOptions", FAutomationScreenshotOptions_IsValid);
	}
}
