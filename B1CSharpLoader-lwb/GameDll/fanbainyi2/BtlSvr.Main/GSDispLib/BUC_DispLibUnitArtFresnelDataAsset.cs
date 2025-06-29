using System;
using b1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset")]
public class BUC_DispLibUnitArtFresnelDataAsset : UBGWDataAsset
{
	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool OnePeriodTime_IsValid;

	private static int OnePeriodTime_Offset;

	private static bool SimpleProgrammedCurve_IsValid;

	private static int SimpleProgrammedCurve_Offset;

	private static FFieldAddress SimpleProgrammedCurve_PropertyAddress;

	private static bool FadeInTime_IsValid;

	private static int FadeInTime_Offset;

	private static bool CommonTime_IsValid;

	private static int CommonTime_Offset;

	private static bool FadeOutTime_IsValid;

	private static int FadeOutTime_Offset;

	private static bool ProgrammedPowerMax_IsValid;

	private static int ProgrammedPowerMax_Offset;

	private static bool Loop_IsValid;

	private static int Loop_Offset;

	private static FFieldAddress Loop_PropertyAddress;

	private static bool InvertGSArtFresnel_IsValid;

	private static int InvertGSArtFresnel_Offset;

	private static FFieldAddress InvertGSArtFresnel_PropertyAddress;

	private static bool UseVertexNormalNotTex_IsValid;

	private static int UseVertexNormalNotTex_Offset;

	private static FFieldAddress UseVertexNormalNotTex_PropertyAddress;

	private static bool UseContrastInsteadPower_IsValid;

	private static int UseContrastInsteadPower_Offset;

	private static FFieldAddress UseContrastInsteadPower_PropertyAddress;

	private static bool BrightValue_IsValid;

	private static int BrightValue_Offset;

	private static bool DarkValue_IsValid;

	private static int DarkValue_Offset;

	private static bool GSArtFresnelPower_IsValid;

	private static int GSArtFresnelPower_Offset;

	private static bool ClampGSArtFresnelDotProduct_IsValid;

	private static int ClampGSArtFresnelDotProduct_Offset;

	private static FFieldAddress ClampGSArtFresnelDotProduct_PropertyAddress;

	private static bool UseHeightGradientRamp_IsValid;

	private static int UseHeightGradientRamp_Offset;

	private static FFieldAddress UseHeightGradientRamp_PropertyAddress;

	private static bool BottomAlpha_IsValid;

	private static int BottomAlpha_Offset;

	private static bool TopAlpha_IsValid;

	private static int TopAlpha_Offset;

	private static bool FColor_Out_IsValid;

	private static int FColor_Out_Offset;

	private static bool FColor_In_IsValid;

	private static int FColor_In_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("总持续时间")]
	[UMeta(MDProp.ClampMin, 0.001f)]
	[Category("时间")]
	[UMeta(MDProp.EditCondition, "!Loop")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[Category("时间")]
	[UMeta(MDProp.ClampMin, 0.001f)]
	[UMeta(MDProp.EditCondition, "!SimpleProgrammedCurve")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("单次循环时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:OnePeriodTime")]
	public float OnePeriodTime
	{
		get
		{
			CheckDestroyed();
			if (!OnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:OnePeriodTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OnePeriodTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:OnePeriodTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OnePeriodTime_Offset), value);
			}
		}
	}

	[Category("时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("使用程序化Power曲线")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:SimpleProgrammedCurve")]
	public bool SimpleProgrammedCurve
	{
		get
		{
			CheckDestroyed();
			if (!SimpleProgrammedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:SimpleProgrammedCurve");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, SimpleProgrammedCurve_Offset), 0, SimpleProgrammedCurve_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!SimpleProgrammedCurve_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:SimpleProgrammedCurve");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, SimpleProgrammedCurve_Offset), 0, SimpleProgrammedCurve_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0)]
	[UMeta(MDProp.EditCondition, "SimpleProgrammedCurve")]
	[BlueprintReadWrite]
	[Category("时间")]
	[DisplayName("程序化Power爆发时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeInTime")]
	public float FadeInTime
	{
		get
		{
			CheckDestroyed();
			if (!FadeInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeInTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeInTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeInTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeInTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeInTime_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("程序化Power平稳时间")]
	[EditAnywhere]
	[Category("时间")]
	[UMeta(MDProp.EditCondition, "SimpleProgrammedCurve")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:CommonTime")]
	public float CommonTime
	{
		get
		{
			CheckDestroyed();
			if (!CommonTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:CommonTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CommonTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CommonTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:CommonTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CommonTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("程序化Power消退时间")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "SimpleProgrammedCurve")]
	[UMeta(MDProp.ClampMin, 0)]
	[Category("时间")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeOutTime")]
	public float FadeOutTime
	{
		get
		{
			CheckDestroyed();
			if (!FadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FadeOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FadeOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FadeOutTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "SimpleProgrammedCurve")]
	[Category("时间")]
	[DisplayName("程序化Power最大值")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0.001f)]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ProgrammedPowerMax")]
	public float ProgrammedPowerMax
	{
		get
		{
			CheckDestroyed();
			if (!ProgrammedPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ProgrammedPowerMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProgrammedPowerMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProgrammedPowerMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ProgrammedPowerMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProgrammedPowerMax_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("无限循环")]
	[Category("时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Loop")]
	public bool Loop
	{
		get
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Loop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:Loop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("反转菲涅尔")]
	[Category("菲涅尔范围")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:InvertGSArtFresnel")]
	public bool InvertGSArtFresnel
	{
		get
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:InvertGSArtFresnel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InvertGSArtFresnel_Offset), 0, InvertGSArtFresnel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:InvertGSArtFresnel");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InvertGSArtFresnel_Offset), 0, InvertGSArtFresnel_PropertyAddress.Address, value);
			}
		}
	}

	[Category("菲涅尔范围")]
	[DisplayName("使用顶点法线而不是法线纹理")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseVertexNormalNotTex")]
	public bool UseVertexNormalNotTex
	{
		get
		{
			CheckDestroyed();
			if (!UseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseVertexNormalNotTex");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseVertexNormalNotTex_Offset), 0, UseVertexNormalNotTex_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseVertexNormalNotTex");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseVertexNormalNotTex_Offset), 0, UseVertexNormalNotTex_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("使用明暗范围控制菲涅尔范围")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("菲涅尔范围")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseContrastInsteadPower")]
	public bool UseContrastInsteadPower
	{
		get
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseContrastInsteadPower");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseContrastInsteadPower_Offset), 0, UseContrastInsteadPower_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseContrastInsteadPower");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseContrastInsteadPower_Offset), 0, UseContrastInsteadPower_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseContrastInsteadPower")]
	[UMeta(MDProp.ClampMin, 0f)]
	[Category("菲涅尔范围")]
	[DisplayName("最亮处亮度")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BrightValue")]
	public float BrightValue
	{
		get
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BrightValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrightValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BrightValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrightValue_Offset), value);
			}
		}
	}

	[DisplayName("最暗处亮度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("菲涅尔范围")]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.EditCondition, "UseContrastInsteadPower")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:DarkValue")]
	public float DarkValue
	{
		get
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:DarkValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DarkValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:DarkValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DarkValue_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("菲涅尔范围(X_0,1)")]
	[UMeta(MDProp.EditCondition, "!UseContrastInsteadPower")]
	[EditAnywhere]
	[Category("菲涅尔范围")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:GSArtFresnelPower")]
	public UCurveFloat GSArtFresnelPower
	{
		get
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:GSArtFresnelPower");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:GSArtFresnelPower");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset), value);
			}
		}
	}

	[DisplayName("限制菲涅尔范围在[0,1]")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("菲涅尔范围")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ClampGSArtFresnelDotProduct")]
	public bool ClampGSArtFresnelDotProduct
	{
		get
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ClampGSArtFresnelDotProduct");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset), 0, ClampGSArtFresnelDotProduct_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:ClampGSArtFresnelDotProduct");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset), 0, ClampGSArtFresnelDotProduct_PropertyAddress.Address, value);
			}
		}
	}

	[Category("菲涅尔范围")]
	[DisplayName("高度渐变")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseHeightGradientRamp")]
	public bool UseHeightGradientRamp
	{
		get
		{
			CheckDestroyed();
			if (!UseHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseHeightGradientRamp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHeightGradientRamp_Offset), 0, UseHeightGradientRamp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:UseHeightGradientRamp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHeightGradientRamp_Offset), 0, UseHeightGradientRamp_PropertyAddress.Address, value);
			}
		}
	}

	[Category("菲涅尔范围")]
	[DisplayName("角色底部菲涅尔强度")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseHeightGradientRamp")]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BottomAlpha")]
	public float BottomAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BottomAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BottomAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:BottomAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BottomAlpha_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseHeightGradientRamp")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("高度顶部菲涅尔强度")]
	[Category("菲涅尔范围")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:TopAlpha")]
	public float TopAlpha
	{
		get
		{
			CheckDestroyed();
			if (!TopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:TopAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TopAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:TopAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TopAlpha_Offset), value);
			}
		}
	}

	[Category("颜色")]
	[DisplayName("外部颜色")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_Out")]
	public UCurveLinearColor FColor_Out
	{
		get
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_Out");
				return null;
			}
			return UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(base.Address, FColor_Out_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_Out");
			}
			else
			{
				UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(base.Address, FColor_Out_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("内部颜色")]
	[Category("颜色")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_In")]
	public UCurveLinearColor FColor_In
	{
		get
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_In");
				return null;
			}
			return UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(base.Address, FColor_In_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset:FColor_In");
			}
			else
			{
				UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(base.Address, FColor_In_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Time = 0f;
		Loop = false;
		UseVertexNormalNotTex = true;
		InvertGSArtFresnel = false;
		BrightValue = 1f;
		DarkValue = 0f;
		ClampGSArtFresnelDotProduct = true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUC_DispLibUnitArtFresnelDataAsset");
		Time_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time", Classes.FFloatProperty);
		OnePeriodTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnePeriodTime");
		OnePeriodTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnePeriodTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SimpleProgrammedCurve_PropertyAddress, unrealStruct, "SimpleProgrammedCurve");
		SimpleProgrammedCurve_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SimpleProgrammedCurve");
		SimpleProgrammedCurve_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SimpleProgrammedCurve", Classes.FBoolProperty);
		FadeInTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FadeInTime");
		FadeInTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FadeInTime", Classes.FFloatProperty);
		CommonTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CommonTime");
		CommonTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CommonTime", Classes.FFloatProperty);
		FadeOutTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FadeOutTime");
		FadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FadeOutTime", Classes.FFloatProperty);
		ProgrammedPowerMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ProgrammedPowerMax");
		ProgrammedPowerMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ProgrammedPowerMax", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Loop_PropertyAddress, unrealStruct, "Loop");
		Loop_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Loop");
		Loop_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Loop", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref InvertGSArtFresnel_PropertyAddress, unrealStruct, "InvertGSArtFresnel");
		InvertGSArtFresnel_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InvertGSArtFresnel");
		InvertGSArtFresnel_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InvertGSArtFresnel", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseVertexNormalNotTex_PropertyAddress, unrealStruct, "UseVertexNormalNotTex");
		UseVertexNormalNotTex_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseVertexNormalNotTex");
		UseVertexNormalNotTex_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseVertexNormalNotTex", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseContrastInsteadPower_PropertyAddress, unrealStruct, "UseContrastInsteadPower");
		UseContrastInsteadPower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseContrastInsteadPower");
		UseContrastInsteadPower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseContrastInsteadPower", Classes.FBoolProperty);
		BrightValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BrightValue");
		BrightValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BrightValue", Classes.FFloatProperty);
		DarkValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "DarkValue");
		DarkValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "DarkValue", Classes.FFloatProperty);
		GSArtFresnelPower_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "GSArtFresnelPower");
		GSArtFresnelPower_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "GSArtFresnelPower", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ClampGSArtFresnelDotProduct_PropertyAddress, unrealStruct, "ClampGSArtFresnelDotProduct");
		ClampGSArtFresnelDotProduct_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ClampGSArtFresnelDotProduct");
		ClampGSArtFresnelDotProduct_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ClampGSArtFresnelDotProduct", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref UseHeightGradientRamp_PropertyAddress, unrealStruct, "UseHeightGradientRamp");
		UseHeightGradientRamp_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseHeightGradientRamp");
		UseHeightGradientRamp_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseHeightGradientRamp", Classes.FBoolProperty);
		BottomAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BottomAlpha");
		BottomAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BottomAlpha", Classes.FFloatProperty);
		TopAlpha_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "TopAlpha");
		TopAlpha_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "TopAlpha", Classes.FFloatProperty);
		FColor_Out_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FColor_Out");
		FColor_Out_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FColor_Out", Classes.FObjectProperty);
		FColor_In_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FColor_In");
		FColor_In_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FColor_In", Classes.FObjectProperty);
	}

	static BUC_DispLibUnitArtFresnelDataAsset()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUC_DispLibUnitArtFresnelDataAsset)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUC_DispLibUnitArtFresnelDataAsset));
	}
}
