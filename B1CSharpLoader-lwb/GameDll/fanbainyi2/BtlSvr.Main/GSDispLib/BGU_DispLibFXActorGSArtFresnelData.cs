using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData")]
public class BGU_DispLibFXActorGSArtFresnelData : BGU_DispLibUComponentBase
{
	public float TimeACC;

	public bool HasTrigger;

	private static bool Priority_IsValid;

	private static int Priority_Offset;

	private static bool FirstDelayTime_IsValid;

	private static int FirstDelayTime_Offset;

	private static bool Time_IsValid;

	private static int Time_Offset;

	private static bool OnePeriodTime_IsValid;

	private static int OnePeriodTime_Offset;

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
	[DisplayName("优先级")]
	[Category("通用")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Priority")]
	public int Priority
	{
		get
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Priority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Priority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Priority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Priority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Priority_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("首次触发延迟")]
	[Category("时间")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FirstDelayTime")]
	public float FirstDelayTime
	{
		get
		{
			CheckDestroyed();
			if (!FirstDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FirstDelayTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FirstDelayTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FirstDelayTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FirstDelayTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FirstDelayTime_Offset), value);
			}
		}
	}

	[Category("时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("总持续时间")]
	[UMeta(MDProp.EditCondition, "!Loop")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Time")]
	public float Time
	{
		get
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Time");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Time_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Time_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Time");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Time_Offset), value);
			}
		}
	}

	[DisplayName("单次持续时间")]
	[EditAnywhere]
	[Category("时间")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:OnePeriodTime")]
	public float OnePeriodTime
	{
		get
		{
			CheckDestroyed();
			if (!OnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:OnePeriodTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OnePeriodTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnePeriodTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:OnePeriodTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OnePeriodTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("无限循环")]
	[Category("时间")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Loop")]
	public bool Loop
	{
		get
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Loop");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Loop_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:Loop");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Loop_Offset), 0, Loop_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("菲涅尔范围")]
	[DisplayName("反转菲涅尔")]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:InvertGSArtFresnel")]
	public bool InvertGSArtFresnel
	{
		get
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:InvertGSArtFresnel");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InvertGSArtFresnel_Offset), 0, InvertGSArtFresnel_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InvertGSArtFresnel_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:InvertGSArtFresnel");
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
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseVertexNormalNotTex")]
	public bool UseVertexNormalNotTex
	{
		get
		{
			CheckDestroyed();
			if (!UseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseVertexNormalNotTex");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseVertexNormalNotTex_Offset), 0, UseVertexNormalNotTex_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseVertexNormalNotTex_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseVertexNormalNotTex");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseVertexNormalNotTex_Offset), 0, UseVertexNormalNotTex_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("使用明暗范围控制菲涅尔范围")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("菲涅尔范围")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseContrastInsteadPower")]
	public bool UseContrastInsteadPower
	{
		get
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseContrastInsteadPower");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseContrastInsteadPower_Offset), 0, UseContrastInsteadPower_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseContrastInsteadPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseContrastInsteadPower");
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
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BrightValue")]
	public float BrightValue
	{
		get
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BrightValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BrightValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BrightValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BrightValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BrightValue_Offset), value);
			}
		}
	}

	[Category("菲涅尔范围")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("最暗处亮度")]
	[UMeta(MDProp.EditCondition, "UseContrastInsteadPower")]
	[UMeta(MDProp.ClampMin, 0f)]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:DarkValue")]
	public float DarkValue
	{
		get
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:DarkValue");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DarkValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DarkValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:DarkValue");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DarkValue_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[DisplayName("菲涅尔范围(X_0,1)")]
	[Category("菲涅尔范围")]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "!UseContrastInsteadPower")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:GSArtFresnelPower")]
	public UCurveFloat GSArtFresnelPower
	{
		get
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:GSArtFresnelPower");
				return null;
			}
			return UObjectMarshaler<UCurveFloat>.FromNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!GSArtFresnelPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:GSArtFresnelPower");
			}
			else
			{
				UObjectMarshaler<UCurveFloat>.ToNative(IntPtr.Add(base.Address, GSArtFresnelPower_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("菲涅尔范围")]
	[DisplayName("限制菲涅尔范围在[0,1]")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:ClampGSArtFresnelDotProduct")]
	public bool ClampGSArtFresnelDotProduct
	{
		get
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:ClampGSArtFresnelDotProduct");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset), 0, ClampGSArtFresnelDotProduct_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!ClampGSArtFresnelDotProduct_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:ClampGSArtFresnelDotProduct");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, ClampGSArtFresnelDotProduct_Offset), 0, ClampGSArtFresnelDotProduct_PropertyAddress.Address, value);
			}
		}
	}

	[DisplayName("高度渐变")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("菲涅尔范围")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseHeightGradientRamp")]
	public bool UseHeightGradientRamp
	{
		get
		{
			CheckDestroyed();
			if (!UseHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseHeightGradientRamp");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseHeightGradientRamp_Offset), 0, UseHeightGradientRamp_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseHeightGradientRamp_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:UseHeightGradientRamp");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseHeightGradientRamp_Offset), 0, UseHeightGradientRamp_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseHeightGradientRamp")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("角色底部菲涅尔强度")]
	[Category("菲涅尔范围")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BottomAlpha")]
	public float BottomAlpha
	{
		get
		{
			CheckDestroyed();
			if (!BottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BottomAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BottomAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BottomAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:BottomAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BottomAlpha_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("高度顶部菲涅尔强度")]
	[Category("菲涅尔范围")]
	[UMeta(MDProp.EditCondition, "UseHeightGradientRamp")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:TopAlpha")]
	public float TopAlpha
	{
		get
		{
			CheckDestroyed();
			if (!TopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:TopAlpha");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TopAlpha_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TopAlpha_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:TopAlpha");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TopAlpha_Offset), value);
			}
		}
	}

	[Category("颜色")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("外部颜色")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_Out")]
	public UCurveLinearColor FColor_Out
	{
		get
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_Out");
				return null;
			}
			return UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(base.Address, FColor_Out_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_Out_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_Out");
			}
			else
			{
				UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(base.Address, FColor_Out_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("内部颜色")]
	[Category("颜色")]
	[USharpPath("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_In")]
	public UCurveLinearColor FColor_In
	{
		get
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_In");
				return null;
			}
			return UObjectMarshaler<UCurveLinearColor>.FromNative(IntPtr.Add(base.Address, FColor_In_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FColor_In_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData:FColor_In");
			}
			else
			{
				UObjectMarshaler<UCurveLinearColor>.ToNative(IntPtr.Add(base.Address, FColor_In_Offset), value);
			}
		}
	}

	protected override void Reset()
	{
		TimeACC = 0f;
		HasTrigger = false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGU_DispLibFXActorGSArtFresnelData");
		Priority_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Priority");
		Priority_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Priority", Classes.FIntProperty);
		FirstDelayTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FirstDelayTime");
		FirstDelayTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FirstDelayTime", Classes.FFloatProperty);
		Time_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Time");
		Time_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Time", Classes.FFloatProperty);
		OnePeriodTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OnePeriodTime");
		OnePeriodTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OnePeriodTime", Classes.FFloatProperty);
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

	static BGU_DispLibFXActorGSArtFresnelData()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGU_DispLibFXActorGSArtFresnelData)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGU_DispLibFXActorGSArtFresnelData));
	}
}
