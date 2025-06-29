using System;
using b1.Plugins.AkAudio;
using b1.UI.Comm;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2")]
public class BUI_ButtonLongPressV2 : BUI_Button
{
	private float CurPressStartTime;

	private UIDataHelper SpecialNormalUIDataMap;

	protected UIDataHelper NormalUIDataMap;

	private UImage ImgBgA;

	private UImage ImgBgB;

	private UImage ImgBgC;

	private bool StartPress;

	private bool StartLongPress;

	private float Percent;

	private PreFrameDeltaCal PreFrameData = PreFrameDeltaCal.Create(0f);

	private static bool PressStartTime_IsValid;

	private static int PressStartTime_Offset;

	private static bool PressTimeMax_IsValid;

	private static int PressTimeMax_Offset;

	private static bool CurPressTime_IsValid;

	private static int CurPressTime_Offset;

	private static bool OverFadeOutTime_IsValid;

	private static int OverFadeOutTime_Offset;

	private static bool StartPressAudioEvent_IsValid;

	private static int StartPressAudioEvent_Offset;

	private static bool StopPressAudioEvent_IsValid;

	private static int StopPressAudioEvent_Offset;

	private static bool FinishPressAudioEvent_IsValid;

	private static int FinishPressAudioEvent_Offset;

	private static bool UseSliderFreq_IsValid;

	private static int UseSliderFreq_Offset;

	private static FFieldAddress UseSliderFreq_PropertyAddress;

	private static bool SliderFreqInterval_IsValid;

	private static int SliderFreqInterval_Offset;

	private static bool SpecialNormalUIDataConfigMap_IsValid;

	private static int SpecialNormalUIDataConfigMap_Offset;

	private static FFieldAddress SpecialNormalUIDataConfigMap_PropertyAddress;

	private TMapReadWriteMarshaler<ButtonUIStat, FUIData> SpecialNormalUIDataConfigMap_Marshaler;

	private static bool IsSpecial_IsValid;

	private static int IsSpecial_Offset;

	private static FFieldAddress IsSpecial_PropertyAddress;

	[DisplayName("长按开始时间")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:PressStartTime")]
	public float PressStartTime
	{
		get
		{
			CheckDestroyed();
			if (!PressStartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:PressStartTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PressStartTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressStartTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:PressStartTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PressStartTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("长按完成时间")]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:PressTimeMax")]
	public float PressTimeMax
	{
		get
		{
			CheckDestroyed();
			if (!PressTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:PressTimeMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PressTimeMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PressTimeMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:PressTimeMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PressTimeMax_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty")]
	[DisplayName("当前按下时间")]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:CurPressTime")]
	public float CurPressTime
	{
		get
		{
			CheckDestroyed();
			if (!CurPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:CurPressTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurPressTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurPressTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:CurPressTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurPressTime_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[DisplayName("超过1以后消退时间")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:OverFadeOutTime")]
	public float OverFadeOutTime
	{
		get
		{
			CheckDestroyed();
			if (!OverFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:OverFadeOutTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OverFadeOutTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverFadeOutTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:OverFadeOutTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OverFadeOutTime_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[EditAnywhere]
	[UProperty]
	[DisplayName("开始长按音效")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:StartPressAudioEvent")]
	public UAkAudioEvent StartPressAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!StartPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:StartPressAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, StartPressAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:StartPressAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, StartPressAudioEvent_Offset), value);
			}
		}
	}

	[Category("GSProperty")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("停止长按音效")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:StopPressAudioEvent")]
	public UAkAudioEvent StopPressAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!StopPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:StopPressAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, StopPressAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StopPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:StopPressAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, StopPressAudioEvent_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("完成长按音效")]
	[Category("GSProperty")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:FinishPressAudioEvent")]
	public UAkAudioEvent FinishPressAudioEvent
	{
		get
		{
			CheckDestroyed();
			if (!FinishPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:FinishPressAudioEvent");
				return null;
			}
			return UObjectMarshaler<UAkAudioEvent>.FromNative(IntPtr.Add(base.Address, FinishPressAudioEvent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FinishPressAudioEvent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:FinishPressAudioEvent");
			}
			else
			{
				UObjectMarshaler<UAkAudioEvent>.ToNative(IntPtr.Add(base.Address, FinishPressAudioEvent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("是否计算SliderFreq")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:UseSliderFreq")]
	public bool UseSliderFreq
	{
		get
		{
			CheckDestroyed();
			if (!UseSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:UseSliderFreq");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSliderFreq_Offset), 0, UseSliderFreq_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSliderFreq_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:UseSliderFreq");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSliderFreq_Offset), 0, UseSliderFreq_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("SliderFreq区间")]
	[UMeta(MDProp.EditCondition, "UseSliderFreq")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:SliderFreqInterval")]
	public FVector2D SliderFreqInterval
	{
		get
		{
			CheckDestroyed();
			if (!SliderFreqInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:SliderFreqInterval");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, SliderFreqInterval_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SliderFreqInterval_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:SliderFreqInterval");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, SliderFreqInterval_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty")]
	[DisplayName("特殊状态UI配置")]
	[UMeta(MDProp.EditCondition, "!IsInstance")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:SpecialNormalUIDataConfigMap")]
	public TMapReadWrite<ButtonUIStat, FUIData> SpecialNormalUIDataConfigMap
	{
		get
		{
			CheckDestroyed();
			if (!SpecialNormalUIDataConfigMap_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:SpecialNormalUIDataConfigMap");
				return null;
			}
			if (SpecialNormalUIDataConfigMap_Marshaler == null)
			{
				SpecialNormalUIDataConfigMap_Marshaler = new TMapReadWriteMarshaler<ButtonUIStat, FUIData>(1, SpecialNormalUIDataConfigMap_PropertyAddress, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.FromNative, CachedMarshalingDelegates<ButtonUIStat, EnumMarshaler<ButtonUIStat>>.ToNative, CachedMarshalingDelegates<FUIData, FUIData>.FromNative, CachedMarshalingDelegates<FUIData, FUIData>.ToNative);
			}
			return SpecialNormalUIDataConfigMap_Marshaler.FromNative(IntPtr.Add(base.Address, SpecialNormalUIDataConfigMap_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Category("GSProperty")]
	[USharpPath("/Script/b1-Managed.BUI_ButtonLongPressV2:IsSpecial")]
	public bool IsSpecial
	{
		get
		{
			CheckDestroyed();
			if (!IsSpecial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:IsSpecial");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsSpecial_Offset), 0, IsSpecial_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsSpecial_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_ButtonLongPressV2:IsSpecial");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsSpecial_Offset), 0, IsSpecial_PropertyAddress.Address, value);
			}
		}
	}

	public event Action OnLongPressFinishEvent;

	protected override void OnZeroInitialize(FObjectInitializer initializer)
	{
		base.OnZeroInitialize(initializer);
		PressTimeMax = 2f;
		OverFadeOutTime = 0.5f;
		PressStartTime = 0.2f;
		IsSpecial = false;
	}

	protected override void OnUIPreConstruct()
	{
		ImgBgA = FindChildWidget("ImgBgA") as UImage;
		ImgBgB = FindChildWidget("ImgBgB") as UImage;
		ImgBgC = FindChildWidget("ImgBgC") as UImage;
		base.OnUIPreConstruct();
		CurPressTime = 0f;
		Percent = 0f;
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (StartPress && CurPressStartTime <= PressStartTime)
		{
			CurPressStartTime += InDeltaTime;
			if (CurPressStartTime <= PressStartTime)
			{
				return;
			}
			StartLongPress = true;
			if (StartPressAudioEvent != null)
			{
				UAkGameplayStatics.PostEventOnDummyObj(StartPressAudioEvent, string.Empty);
			}
		}
		if (StartPress || CurPressTime > 0f || CurPressTime >= PressTimeMax)
		{
			if (StartPress || CurPressTime >= PressTimeMax)
			{
				if (CurPressTime < PressTimeMax && CurPressTime + InDeltaTime > PressTimeMax)
				{
					this.OnLongPressFinishEvent?.Invoke();
					if (FinishPressAudioEvent != null)
					{
						UAkGameplayStatics.PostEventOnDummyObj(FinishPressAudioEvent, string.Empty);
					}
				}
				CurPressTime += InDeltaTime;
			}
			else
			{
				CurPressTime -= InDeltaTime;
			}
		}
		float num = CurPressTime / PressTimeMax;
		if (num >= 1f)
		{
			float x = (CurPressTime - PressTimeMax) / OverFadeOutTime;
			x = FMath.Clamp(x, 0f, 0.5f);
			num = 1f + x;
			if (num >= 1.5f)
			{
				OnStopPress();
				ResetPressTime();
			}
		}
		SetSweepLongPress(num);
		SetMatBeat(ImgBgA, InDeltaTime);
		SetMatBeat(ImgBgB, InDeltaTime);
		SetMatBeat(ImgBgC, InDeltaTime);
	}

	public void SetSweepLongPress(float SweepLongPress)
	{
		Percent = FMath.Clamp(SweepLongPress, 0f, 1f);
		SetMatPercent(ImgBgA, Percent);
		SetMatPercent(ImgBgB, Percent);
		SetMatPercent(ImgBgC, Percent);
	}

	public float GetPercent()
	{
		return Percent;
	}

	private void SetMatPercent(UImage Img, float Percent)
	{
		if (!(Img == null))
		{
			UMaterialInstanceDynamic uMaterialInstanceDynamic = Img?.Brush.ResourceObject as UMaterialInstanceDynamic;
			if (uMaterialInstanceDynamic != null)
			{
				uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.Percent, Percent);
			}
		}
	}

	private void SetMatBeat(UImage Img, float InDeltaTime)
	{
		if (Img == null)
		{
			return;
		}
		UMaterialInstanceDynamic uMaterialInstanceDynamic = Img?.Brush.ResourceObject as UMaterialInstanceDynamic;
		if (uMaterialInstanceDynamic != null && UseSliderFreq)
		{
			float num = FMath.Clamp(Percent, 0f, 1f);
			if (FMath.IsNearlyZero(num))
			{
				uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Beat, 0f);
				return;
			}
			float sliderFreq = FMath.Lerp(SliderFreqInterval.X, SliderFreqInterval.Y, num);
			PreFrameData.SetSliderFreq(sliderFreq);
			uMaterialInstanceDynamic.SetScalarParameterValue(B1GlobalFNames.GSMIParameter_Beat, PreFrameData.GetDeltaTime(InDeltaTime));
		}
	}

	public void OnStartPress()
	{
		StartPress = true;
	}

	public void OnStopPress()
	{
		if (StartLongPress && StopPressAudioEvent != null)
		{
			UAkGameplayStatics.PostEventOnDummyObj(StopPressAudioEvent, string.Empty);
		}
		StartPress = false;
		StartLongPress = false;
		CurPressStartTime = 0f;
	}

	public void ResetPressTime()
	{
		StartPress = false;
		StartLongPress = false;
		CurPressTime = 0f;
		CurPressStartTime = 0f;
	}

	public override void InitUIData()
	{
		base.InitUIData();
		BUI_ButtonLongPressV2 bUI_ButtonLongPressV = GetDefaultObj() as BUI_ButtonLongPressV2;
		if (bUI_ButtonLongPressV != null)
		{
			NormalUIDataMap = InitUIData(bUI_ButtonLongPressV.UIDataConfigMap);
			SpecialNormalUIDataMap = InitUIData(bUI_ButtonLongPressV.SpecialNormalUIDataConfigMap);
		}
		else
		{
			BGW_LogUtil.LogError("[InitUIData] Name = " + GetFullName() + " Init Fail");
		}
	}

	protected override UIDataHelper GetDataHelperImpl()
	{
		UIDataHelper uIDataHelper = null;
		if (IsSpecial)
		{
			return SpecialNormalUIDataMap;
		}
		return NormalUIDataMap;
	}

	public void SetIsSpecial(bool InIsSpecial)
	{
		IsSpecial = InIsSpecial;
		SetBtnStateEvent(ESetStateReason.Update);
	}

	protected override void ParentSetBtnState(ButtonUIStat BtnStat)
	{
		BUI_ButtonLongPressV2 bUI_ButtonLongPressV = base.Parent as BUI_ButtonLongPressV2;
		if (bUI_ButtonLongPressV != null)
		{
			IsSpecial = bUI_ButtonLongPressV.IsSpecial;
		}
		base.GSParentButtonUIStat = BtnStat;
		base.GSButtonUIStat = BtnStat;
		SetBtnStateEvent(ESetStateReason.ParentSet);
	}

	protected override void StopUIStatAnim()
	{
		StopAnimation("GSAnimNormal");
		StopAnimation("GSAnimHovered");
		StopAnimation("GSAnimFocused");
		StopAnimation("GSAnimLockNormal");
		StopAnimation("GSAnimLockHovered");
		StopAnimation("GSAnimLockFocused");
		StopAnimation("GSAnimActived");
		StopAnimation("GSAnimLockActived");
		StopAnimation("GSAnimNormalSpecial");
		StopAnimation("GSAnimHoveredSpecial");
		StopAnimation("GSAnimFocusedSpecial");
		StopAnimation("GSAnimLockNormalSpecial");
		StopAnimation("GSAnimLockHoveredSpecial");
		StopAnimation("GSAnimLockFocusedSpecial");
		StopAnimation("GSAnimActivedSpecial");
		StopAnimation("GSAnimLockActivedSpecial");
	}

	protected override void CalUIStatAnim(ButtonUIStat InGSButtonUIStat)
	{
		string btnStatAnim = string.Empty;
		string btnStatAKBState = string.Empty;
		if (IsSpecial)
		{
			switch (InGSButtonUIStat)
			{
			case ButtonUIStat.Normal:
				btnStatAKBState = "NormalSp";
				btnStatAnim = "GSAnimNormalSpecial";
				break;
			case ButtonUIStat.Hovered:
				btnStatAKBState = "HoveredSp";
				btnStatAnim = "GSAnimHoveredSpecial";
				break;
			case ButtonUIStat.Focused:
				btnStatAKBState = "FocusedSp";
				btnStatAnim = "GSAnimFocusedSpecial";
				break;
			case ButtonUIStat.LockNormal:
				btnStatAKBState = "LockNormalSp";
				btnStatAnim = "GSAnimLockNormalSpecial";
				break;
			case ButtonUIStat.LockHovered:
				btnStatAKBState = "LockHoveredSp";
				btnStatAnim = "GSAnimLockHoveredSpecial";
				break;
			case ButtonUIStat.LockFocused:
				btnStatAKBState = "LockFocusedSp";
				btnStatAnim = "GSAnimLockFocusedSpecial";
				break;
			case ButtonUIStat.Actived:
				btnStatAKBState = "ActivedSp";
				btnStatAnim = "GSAnimActivedSpecial";
				break;
			case ButtonUIStat.LockActived:
				btnStatAKBState = "LockActivedSp";
				btnStatAnim = "GSAnimLockActivedSpecial";
				break;
			case ButtonUIStat.Disable:
				btnStatAKBState = "DisableSp";
				btnStatAnim = "GSAnimDisableSpecial";
				break;
			}
		}
		else
		{
			switch (InGSButtonUIStat)
			{
			case ButtonUIStat.Normal:
				btnStatAKBState = "Normal";
				btnStatAnim = "GSAnimNormal";
				break;
			case ButtonUIStat.Hovered:
				btnStatAKBState = "Hovered";
				btnStatAnim = "GSAnimHovered";
				break;
			case ButtonUIStat.Focused:
				btnStatAKBState = "Focused";
				btnStatAnim = "GSAnimFocused";
				break;
			case ButtonUIStat.LockNormal:
				btnStatAKBState = "LockNormal";
				btnStatAnim = "GSAnimLockNormal";
				break;
			case ButtonUIStat.LockHovered:
				btnStatAKBState = "LockHovered";
				btnStatAnim = "GSAnimLockHovered";
				break;
			case ButtonUIStat.LockFocused:
				btnStatAKBState = "LockFocused";
				btnStatAnim = "GSAnimLockFocused";
				break;
			case ButtonUIStat.Actived:
				btnStatAKBState = "Actived";
				btnStatAnim = "GSAnimActived";
				break;
			case ButtonUIStat.LockActived:
				btnStatAKBState = "LockActived";
				btnStatAnim = "GSAnimLockActived";
				break;
			case ButtonUIStat.Disable:
				btnStatAKBState = "Disable";
				btnStatAnim = "GSAnimDisable";
				break;
			}
		}
		BtnStatAnim = btnStatAnim;
		BtnStatAKBState = btnStatAKBState;
	}

	protected override void OnUIDestruct()
	{
		base.OnUIDestruct();
		this.OnLongPressFinishEvent = null;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_ButtonLongPressV2");
		PressStartTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressStartTime");
		PressStartTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressStartTime", Classes.FFloatProperty);
		PressTimeMax_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "PressTimeMax");
		PressTimeMax_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "PressTimeMax", Classes.FFloatProperty);
		CurPressTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CurPressTime");
		CurPressTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CurPressTime", Classes.FFloatProperty);
		OverFadeOutTime_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OverFadeOutTime");
		OverFadeOutTime_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OverFadeOutTime", Classes.FFloatProperty);
		StartPressAudioEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StartPressAudioEvent");
		StartPressAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StartPressAudioEvent", Classes.FObjectProperty);
		StopPressAudioEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "StopPressAudioEvent");
		StopPressAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "StopPressAudioEvent", Classes.FObjectProperty);
		FinishPressAudioEvent_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "FinishPressAudioEvent");
		FinishPressAudioEvent_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "FinishPressAudioEvent", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref UseSliderFreq_PropertyAddress, unrealStruct, "UseSliderFreq");
		UseSliderFreq_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UseSliderFreq");
		UseSliderFreq_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UseSliderFreq", Classes.FBoolProperty);
		SliderFreqInterval_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SliderFreqInterval");
		SliderFreqInterval_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SliderFreqInterval", Classes.FStructProperty);
		NativeReflection.GetPropertyRef(ref SpecialNormalUIDataConfigMap_PropertyAddress, unrealStruct, "SpecialNormalUIDataConfigMap");
		SpecialNormalUIDataConfigMap_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SpecialNormalUIDataConfigMap");
		SpecialNormalUIDataConfigMap_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SpecialNormalUIDataConfigMap", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref IsSpecial_PropertyAddress, unrealStruct, "IsSpecial");
		IsSpecial_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsSpecial");
		IsSpecial_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsSpecial", Classes.FBoolProperty);
	}

	static BUI_ButtonLongPressV2()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_ButtonLongPressV2)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_ButtonLongPressV2));
	}
}
