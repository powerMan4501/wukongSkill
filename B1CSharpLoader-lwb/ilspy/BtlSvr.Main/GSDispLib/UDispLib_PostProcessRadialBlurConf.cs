using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[UStruct]
[BlueprintType]
[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf")]
public struct UDispLib_PostProcessRadialBlurConf
{
	[Tooltip("模糊材质")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("材质")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:Material")]
	public UMaterialInstance Material;

	[DisplayName("模糊中心点")]
	[Tooltip("模糊中心点(XY) ViewportUV空间, 右上角为(0,0)")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:RadialCenter")]
	public FLinearColor RadialCenter;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Tooltip("最大模糊程度, 正负为不同模糊方向")]
	[DisplayName("模糊强度")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:BlurIntensity")]
	public float BlurIntensity;

	[BlueprintReadWrite]
	[Tooltip("次数越多效果越好，但是开销也会越大，默认4次")]
	[DisplayName("步进次数")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:IterationCount")]
	public int IterationCount;

	[EditAnywhere]
	[UProperty]
	[DisplayName("渐变深度范围")]
	[Tooltip("模糊根据离摄像机距离做渐变，近处模糊，远处清晰。这个值调整渐变的范围")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:DepthRange")]
	public float DepthRange;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("深度遮罩偏移")]
	[Tooltip("0遮罩区域完全模糊，1为遮罩区域不模糊。遮罩物体勾选RenderCustomDepthPass生效")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:DepthMaskBias")]
	public float DepthMaskBias;

	[Tooltip("叠加这个颜色")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("参考颜色")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:TintColor")]
	public FLinearColor TintColor;

	[Tooltip("范围[0,1]配合RadialBlurTintColor可以改变色调")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("去饱和度系数")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:DesaturationFaction")]
	public float DesaturationFaction;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("初始阶段时长")]
	[Tooltip("从0到最大模糊程度的时长")]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:BeginningDuration")]
	public float BeginningDuration;

	[Tooltip("从最大模糊程度到0的时长")]
	[DisplayName("结束阶段时长")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf:FinishingDuration")]
	public float FinishingDuration;

	private static int UDispLib_PostProcessRadialBlurConf_StructSize;

	private static int UDispLib_PostProcessRadialBlurConf_IsValid;

	private static bool Material_IsValid;

	private static int Material_Offset;

	private static bool RadialCenter_IsValid;

	private static int RadialCenter_Offset;

	private static bool BlurIntensity_IsValid;

	private static int BlurIntensity_Offset;

	private static bool IterationCount_IsValid;

	private static int IterationCount_Offset;

	private static bool DepthRange_IsValid;

	private static int DepthRange_Offset;

	private static bool DepthMaskBias_IsValid;

	private static int DepthMaskBias_Offset;

	private static bool TintColor_IsValid;

	private static int TintColor_Offset;

	private static bool DesaturationFaction_IsValid;

	private static int DesaturationFaction_Offset;

	private static bool BeginningDuration_IsValid;

	private static int BeginningDuration_Offset;

	private static bool FinishingDuration_IsValid;

	private static int FinishingDuration_Offset;

	public UDispLib_PostProcessRadialBlurConf Copy()
	{
		return this;
	}

	public static UDispLib_PostProcessRadialBlurConf FromNative(IntPtr nativeBuffer)
	{
		return new UDispLib_PostProcessRadialBlurConf(nativeBuffer);
	}

	public static void ToNative(IntPtr nativeBuffer, UDispLib_PostProcessRadialBlurConf value)
	{
		value.ToNative(nativeBuffer);
	}

	public static UDispLib_PostProcessRadialBlurConf FromNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop)
	{
		return new UDispLib_PostProcessRadialBlurConf(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostProcessRadialBlurConf_StructSize));
	}

	public static void ToNative(IntPtr nativeBuffer, int arrayIndex, IntPtr prop, UDispLib_PostProcessRadialBlurConf value)
	{
		value.ToNative(IntPtr.Add(nativeBuffer, arrayIndex * UDispLib_PostProcessRadialBlurConf_StructSize));
	}

	public void ToNative(IntPtr nativeStruct)
	{
		if (UDispLib_PostProcessRadialBlurConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf");
			return;
		}
		UObjectMarshaler<UMaterialInstance>.ToNative(IntPtr.Add(nativeStruct, Material_Offset), Material);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, RadialCenter_Offset), RadialCenter);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BlurIntensity_Offset), BlurIntensity);
		BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(nativeStruct, IterationCount_Offset), IterationCount);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DepthRange_Offset), DepthRange);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DepthMaskBias_Offset), DepthMaskBias);
		BlittableTypeMarshaler<FLinearColor>.ToNative(IntPtr.Add(nativeStruct, TintColor_Offset), TintColor);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, DesaturationFaction_Offset), DesaturationFaction);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, BeginningDuration_Offset), BeginningDuration);
		BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(nativeStruct, FinishingDuration_Offset), FinishingDuration);
	}

	public UDispLib_PostProcessRadialBlurConf(IntPtr nativeStruct)
	{
		if (UDispLib_PostProcessRadialBlurConf_IsValid == 0)
		{
			NativeReflection.LogInvalidStructAccessed("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf");
			Material = null;
			RadialCenter = default(FLinearColor);
			BlurIntensity = 0f;
			IterationCount = 0;
			DepthRange = 0f;
			DepthMaskBias = 0f;
			TintColor = default(FLinearColor);
			DesaturationFaction = 0f;
			BeginningDuration = 0f;
			FinishingDuration = 0f;
		}
		else
		{
			Material = UObjectMarshaler<UMaterialInstance>.FromNative(IntPtr.Add(nativeStruct, Material_Offset));
			RadialCenter = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, RadialCenter_Offset));
			BlurIntensity = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BlurIntensity_Offset));
			IterationCount = BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(nativeStruct, IterationCount_Offset));
			DepthRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DepthRange_Offset));
			DepthMaskBias = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DepthMaskBias_Offset));
			TintColor = BlittableTypeMarshaler<FLinearColor>.FromNative(IntPtr.Add(nativeStruct, TintColor_Offset));
			DesaturationFaction = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, DesaturationFaction_Offset));
			BeginningDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, BeginningDuration_Offset));
			FinishingDuration = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(nativeStruct, FinishingDuration_Offset));
		}
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetStruct("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf");
		UDispLib_PostProcessRadialBlurConf_StructSize = NativeReflection.GetStructSize(intPtr);
		Material_Offset = NativeReflection.GetPropertyOffset(intPtr, "Material");
		Material_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Material", Classes.FObjectProperty);
		RadialCenter_Offset = NativeReflection.GetPropertyOffset(intPtr, "RadialCenter");
		RadialCenter_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RadialCenter", Classes.FStructProperty);
		BlurIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "BlurIntensity");
		BlurIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BlurIntensity", Classes.FFloatProperty);
		IterationCount_Offset = NativeReflection.GetPropertyOffset(intPtr, "IterationCount");
		IterationCount_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IterationCount", Classes.FIntProperty);
		DepthRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "DepthRange");
		DepthRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DepthRange", Classes.FFloatProperty);
		DepthMaskBias_Offset = NativeReflection.GetPropertyOffset(intPtr, "DepthMaskBias");
		DepthMaskBias_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DepthMaskBias", Classes.FFloatProperty);
		TintColor_Offset = NativeReflection.GetPropertyOffset(intPtr, "TintColor");
		TintColor_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TintColor", Classes.FStructProperty);
		DesaturationFaction_Offset = NativeReflection.GetPropertyOffset(intPtr, "DesaturationFaction");
		DesaturationFaction_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DesaturationFaction", Classes.FFloatProperty);
		BeginningDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "BeginningDuration");
		BeginningDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BeginningDuration", Classes.FFloatProperty);
		FinishingDuration_Offset = NativeReflection.GetPropertyOffset(intPtr, "FinishingDuration");
		FinishingDuration_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FinishingDuration", Classes.FFloatProperty);
		UDispLib_PostProcessRadialBlurConf_IsValid = ((intPtr != IntPtr.Zero && Material_IsValid && RadialCenter_IsValid && BlurIntensity_IsValid && IterationCount_IsValid && DepthRange_IsValid && DepthMaskBias_IsValid && TintColor_IsValid && DesaturationFaction_IsValid && BeginningDuration_IsValid && FinishingDuration_IsValid) ? 1 : 0);
		NativeReflection.LogStructIsValid("/Script/b1-Managed.UDispLib_PostProcessRadialBlurConf", (byte)UDispLib_PostProcessRadialBlurConf_IsValid != 0);
	}

	static UDispLib_PostProcessRadialBlurConf()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(UDispLib_PostProcessRadialBlurConf)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(UDispLib_PostProcessRadialBlurConf));
	}
}
