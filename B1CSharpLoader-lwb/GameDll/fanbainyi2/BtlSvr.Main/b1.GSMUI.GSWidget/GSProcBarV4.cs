using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSProcBarV4")]
public class GSProcBarV4 : UOverlay, IProcBar, IGSMUITickable
{
	private float MainBarFromValue = 1f;

	private bool IsProcBarWorking;

	private float ProcBarFromValue;

	private float ProcBarShowingValue;

	private bool IsFlashBarWorking;

	private float IncBarBeginValueForInc;

	private float IncBarBeginValueForBack;

	private float IncBarShowingLowValue;

	private float IncBarShowingHighValue;

	private bool IsIncBarWorking;

	private float IncBarTickTime;

	private float IncBarKeepTime;

	private bool IsNeedTickUpdate;

	private GSMUITickMgr GSTickMgr;

	private float RealValue;

	private float MaxValue;

	private float PassedTime;

	private bool IsInit;

	private readonly FName ParamNamePercent = new FName("Percent");

	private readonly FName ParamNameBasePercent = new FName("BasePercent");

	private readonly FName ParamNameAnimOnceTime = new FName("AnimOnceTime");

	private readonly FName ParamNameAnimKeepTime = new FName("AnimKeepTime");

	private static bool MainBar_IsValid;

	private static int MainBar_Offset;

	private static bool MainBarTweenTime_IsValid;

	private static int MainBarTweenTime_Offset;

	private static bool MainBarTweenDelay_IsValid;

	private static int MainBarTweenDelay_Offset;

	private static bool ProcBar_IsValid;

	private static int ProcBar_Offset;

	private static bool ProcBarTweenTime_IsValid;

	private static int ProcBarTweenTime_Offset;

	private static bool ProcBarTweenDelay_IsValid;

	private static int ProcBarTweenDelay_Offset;

	private static bool MinProcShowPer_IsValid;

	private static int MinProcShowPer_Offset;

	private static bool IncBar_IsValid;

	private static int IncBar_Offset;

	private static bool IncBarIncTime_IsValid;

	private static int IncBarIncTime_Offset;

	private static bool IncBarStopTime_IsValid;

	private static int IncBarStopTime_Offset;

	private static bool IncBarBackTime_IsValid;

	private static int IncBarBackTime_Offset;

	private static bool MinIncShowPer_IsValid;

	private static int MinIncShowPer_Offset;

	private static bool FlashBar_IsValid;

	private static int FlashBar_Offset;

	private static bool FlashBarFadeDelay_IsValid;

	private static int FlashBarFadeDelay_Offset;

	private static bool FlashBarFadeTime_IsValid;

	private static int FlashBarFadeTime_Offset;

	private static bool MinFlashShowPer_IsValid;

	private static int MinFlashShowPer_Offset;

	private static bool ShineBar_IsValid;

	private static int ShineBar_Offset;

	private static bool SweepBar_IsValid;

	private static int SweepBar_Offset;

	private static bool GSOnConstruct_IsValid;

	private static IntPtr GSOnConstruct_FunctionAddress;

	private static int GSOnConstruct_ParamsSize;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSMainBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MainBar")]
	public UImage MainBar
	{
		get
		{
			CheckDestroyed();
			if (!MainBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, MainBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, MainBar_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|GSMainBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MainBarTweenTime")]
	public float MainBarTweenTime
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBarTweenTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBarTweenTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenTime_Offset), value);
			}
		}
	}

	[Category("GSProperty|GSMainBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MainBarTweenDelay")]
	public float MainBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MainBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProcBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:ProcBar")]
	public UImage ProcBar
	{
		get
		{
			CheckDestroyed();
			if (!ProcBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, ProcBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, ProcBar_Offset), value);
			}
		}
	}

	[Category("GSProperty|GSProcBarCfg")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:ProcBarTweenTime")]
	public float ProcBarTweenTime
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBarTweenTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBarTweenTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenTime_Offset), value);
			}
		}
	}

	[Category("GSProperty|GSProcBarCfg")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:ProcBarTweenDelay")]
	public float ProcBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ProcBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset), value);
			}
		}
	}

	[Category("GSProperty|GSProcBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MinProcShowPer")]
	public float MinProcShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinProcShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinProcShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinProcShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinProcShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinProcShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinProcShowPer_Offset), value);
			}
		}
	}

	[Category("GSIncBarCfg")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:IncBar")]
	public UImage IncBar
	{
		get
		{
			CheckDestroyed();
			if (!IncBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, IncBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, IncBar_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseInc")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty|GSIncBarCfg")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:IncBarIncTime")]
	public float IncBarIncTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarIncTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarIncTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarIncTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarIncTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarIncTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarIncTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|GSIncBarCfg")]
	[UMeta(MDProp.EditCondition, "UseInc")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:IncBarStopTime")]
	public float IncBarStopTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarStopTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarStopTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarStopTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarStopTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarStopTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarStopTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|GSIncBarCfg")]
	[UMeta(MDProp.EditCondition, "UseInc")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:IncBarBackTime")]
	public float IncBarBackTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarBackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarBackTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarBackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarBackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:IncBarBackTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarBackTime_Offset), value);
			}
		}
	}

	[Category("GSProperty|GSIncBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MinIncShowPer")]
	public float MinIncShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinIncShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinIncShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinIncShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinIncShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinIncShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinIncShowPer_Offset), value);
			}
		}
	}

	[Category("GSFlashBarCfg")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:FlashBar")]
	public UImage FlashBar
	{
		get
		{
			CheckDestroyed();
			if (!FlashBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, FlashBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlashBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, FlashBar_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSProperty|GSFlashBarCfg")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:FlashBarFadeDelay")]
	public float FlashBarFadeDelay
	{
		get
		{
			CheckDestroyed();
			if (!FlashBarFadeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBarFadeDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlashBarFadeDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlashBarFadeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBarFadeDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlashBarFadeDelay_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseFlash")]
	[Category("GSProperty|GSFlashBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:FlashBarFadeTime")]
	public float FlashBarFadeTime
	{
		get
		{
			CheckDestroyed();
			if (!FlashBarFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBarFadeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlashBarFadeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlashBarFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:FlashBarFadeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlashBarFadeTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|GSFlashBarCfg")]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:MinFlashShowPer")]
	public float MinFlashShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinFlashShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinFlashShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinFlashShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinFlashShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:MinFlashShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinFlashShowPer_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[Category("GSProperty|GSFullShineBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:ShineBar")]
	public UImage ShineBar
	{
		get
		{
			CheckDestroyed();
			if (!ShineBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ShineBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, ShineBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ShineBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:ShineBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, ShineBar_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|GSFullSweepBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:SweepBar")]
	public UImage SweepBar
	{
		get
		{
			CheckDestroyed();
			if (!SweepBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:SweepBar");
				return null;
			}
			return UObjectMarshaler<UImage>.FromNative(IntPtr.Add(base.Address, SweepBar_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SweepBar_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBarV4:SweepBar");
			}
			else
			{
				UObjectMarshaler<UImage>.ToNative(IntPtr.Add(base.Address, SweepBar_Offset), value);
			}
		}
	}

	private UMaterialInstanceDynamic MainImgMat => MainBar?.GetDynamicMaterial();

	private UMaterialInstanceDynamic ProcImgMat => ProcBar?.GetDynamicMaterial();

	private UMaterialInstanceDynamic IncImgMat => IncBar?.GetDynamicMaterial();

	private UMaterialInstanceDynamic FlashImgMat => FlashBar?.GetDynamicMaterial();

	public override void Initialize(FObjectInitializer initializer)
	{
		MainBarTweenTime = 0.1f;
		MainBarTweenDelay = 0f;
		ProcBarTweenTime = 0.2f;
		ProcBarTweenDelay = 0.3f;
		MinProcShowPer = 0.01f;
		IncBarIncTime = 0.2f;
		IncBarStopTime = 0.1f;
		IncBarBackTime = 0.3f;
		MinIncShowPer = 0.01f;
		IsIncBarWorking = false;
		FlashBarFadeTime = 0.4f;
		FlashBarFadeDelay = 0f;
		MinFlashShowPer = 0.01f;
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.GSProcBarV4:GSOnConstruct")]
	public virtual void GSOnConstruct()
	{
		if (!IsInit)
		{
			RealValue = 0f;
			MaxValue = 1f;
			MainBarFromValue = 0f;
			IncBarBeginValueForInc = 0f;
			IncBarBeginValueForBack = 0f;
			ProcBarFromValue = 0f;
			SetProcBarOpacity(0f);
			SetFlashBarOpacity(0f);
			SetIncBarOpacity(0f);
			IsInit = true;
		}
	}

	public void SetFlashBarMatValueOffset(float FromValue, float ToValue)
	{
		if (!(FlashBar == null))
		{
			if (ToValue < FromValue)
			{
				SetParamValue(FlashImgMat, ParamNameBasePercent, ToValue);
				SetParamValue(FlashImgMat, ParamNamePercent, FromValue);
				SetFlashBarOpacity(1f);
				IsFlashBarWorking = true;
			}
			else
			{
				SetFlashBarOpacity(0f);
				IsFlashBarWorking = false;
			}
		}
	}

	private void SetIncBarMatValue(float LowValue, float HighValue)
	{
		SetParamValue(IncImgMat, ParamNameBasePercent, LowValue);
		SetParamValue(IncImgMat, ParamNamePercent, HighValue);
		SetParamValue(IncImgMat, ParamNameAnimOnceTime, IncBarTickTime);
		SetParamValue(IncImgMat, ParamNameAnimKeepTime, IncBarKeepTime);
	}

	private void SetParamValue(UMaterialInstanceDynamic Mat, FName ParamName, float Value)
	{
		if (MaxValue != 0f)
		{
			Mat?.SetScalarParameterValue(ParamName, Value / MaxValue);
		}
	}

	private void StartTick()
	{
		IsNeedTickUpdate = true;
		GSTickMgr?.SetTickingQueue(this);
	}

	private void SetProcBarOpacity(float Opacity)
	{
		ProcBar?.SetRenderOpacity(Opacity);
	}

	private void SetFlashBarOpacity(float Opacity)
	{
		FlashBar?.SetRenderOpacity(Opacity);
	}

	private void SetIncBarOpacity(float Opacity)
	{
		IncBar?.SetRenderOpacity(Opacity);
	}

	public bool IsGSNeedTick()
	{
		return IsNeedTickUpdate;
	}

	public bool IsUObjectDestroyed()
	{
		return this.IsNullOrDestroyed();
	}

	private bool UpdateMainBarIsIdle()
	{
		if (IncBar != null && MainBarFromValue < RealValue)
		{
			return true;
		}
		float num = PassedTime - MainBarTweenDelay;
		if (num >= MainBarTweenTime)
		{
			SetParamValue(MainImgMat, ParamNamePercent, RealValue);
			return true;
		}
		float x = num / MainBarTweenTime;
		x = MathLib.Clamp(x, 0f, 1f);
		float value = GSEaseFuncInUE.GSMathEase(MainBarFromValue, RealValue, x, EEasingFunc.EaseOut);
		SetParamValue(MainImgMat, ParamNamePercent, value);
		return false;
	}

	private bool UpdateProcBarIsIdle()
	{
		if (ProcBar == null || !IsProcBarWorking)
		{
			return true;
		}
		float num = PassedTime - ProcBarTweenDelay;
		if (num >= ProcBarTweenTime)
		{
			SetParamValue(ProcImgMat, ParamNamePercent, RealValue);
			SetProcBarOpacity(0f);
			IsProcBarWorking = false;
			return true;
		}
		float x = num / ProcBarTweenTime;
		x = MathLib.Clamp(x, 0f, 1f);
		ProcBarShowingValue = GSEaseFuncInUE.GSMathEase(ProcBarFromValue, RealValue, x, EEasingFunc.EaseOut);
		SetParamValue(ProcImgMat, ParamNamePercent, ProcBarShowingValue);
		return false;
	}

	private bool UpdateFlashBarIsIdle()
	{
		if (FlashBar == null || !IsFlashBarWorking)
		{
			return true;
		}
		float num = PassedTime - FlashBarFadeDelay;
		if (num >= FlashBarFadeTime)
		{
			SetFlashBarOpacity(0f);
			IsFlashBarWorking = false;
			return true;
		}
		float x = num / FlashBarFadeTime;
		x = MathLib.Clamp(x, 0f, 1f);
		float flashBarOpacity = GSEaseFuncInUE.GSMathEase(1f, 0f, x, EEasingFunc.EaseOut);
		SetFlashBarOpacity(flashBarOpacity);
		return false;
	}

	private bool UpdateIncBarIsIdle(float DeltaTime)
	{
		if (!IsIncBarWorking)
		{
			return true;
		}
		IncBarTickTime += DeltaTime;
		IncBarKeepTime += DeltaTime;
		if (IncBarTickTime >= IncBarStopTime + IncBarIncTime + IncBarBackTime)
		{
			SetIncBarMatValue(RealValue, RealValue);
			SetIncBarOpacity(0f);
			IncBarTickTime = 0f;
			IncBarKeepTime = 0f;
			IsIncBarWorking = false;
			return true;
		}
		if (IncBarTickTime <= IncBarIncTime)
		{
			float x = IncBarTickTime / IncBarIncTime;
			x = MathLib.Clamp(x, 0f, 1f);
			IncBarShowingHighValue = GSEaseFuncInUE.GSMathEase(IncBarBeginValueForInc, RealValue, x, EEasingFunc.EaseOut);
		}
		else if (IncBarTickTime <= IncBarIncTime + IncBarStopTime)
		{
			IncBarShowingHighValue = RealValue;
		}
		else
		{
			IncBarShowingHighValue = RealValue;
			float x2 = (IncBarTickTime - IncBarIncTime - IncBarStopTime) / IncBarBackTime;
			x2 = MathLib.Clamp(x2, 0f, 1f);
			IncBarShowingLowValue = GSEaseFuncInUE.GSMathEase(IncBarBeginValueForBack, RealValue, x2, EEasingFunc.EaseOut);
		}
		SetIncBarMatValue(IncBarShowingLowValue, IncBarShowingHighValue);
		SetParamValue(MainImgMat, ParamNamePercent, IncBarShowingHighValue);
		return false;
	}

	public void DoGSTick(float DeltaTime)
	{
		if (IsNeedTickUpdate)
		{
			PassedTime += DeltaTime;
			bool num = UpdateMainBarIsIdle();
			bool flag = UpdateProcBarIsIdle();
			bool flag2 = UpdateFlashBarIsIdle();
			bool flag3 = UpdateIncBarIsIdle(DeltaTime);
			if (num && flag && flag2 && flag3)
			{
				IsNeedTickUpdate = false;
			}
		}
	}

	private void DoIncBarLogic(float NewValue)
	{
		if (IncBar == null)
		{
			return;
		}
		if (NewValue <= RealValue)
		{
			IsIncBarWorking = false;
			IncBarBeginValueForInc = RealValue;
			IncBarBeginValueForBack = RealValue;
			IncBarShowingLowValue = RealValue;
			IncBarShowingHighValue = RealValue;
			SetIncBarMatValue(IncBarShowingLowValue, IncBarShowingHighValue);
			SetIncBarOpacity(0f);
			return;
		}
		if (!IsIncBarWorking)
		{
			IsIncBarWorking = true;
			IncBarBeginValueForInc = RealValue;
			IncBarBeginValueForBack = RealValue;
			IncBarShowingLowValue = RealValue;
			IncBarShowingHighValue = RealValue;
		}
		else
		{
			IncBarBeginValueForBack = IncBarShowingLowValue;
			IncBarBeginValueForInc = IncBarShowingHighValue;
		}
		IncBarTickTime = 0f;
		SetIncBarMatValue(IncBarShowingLowValue, IncBarShowingHighValue);
		SetIncBarOpacity(1f);
	}

	public void SetValue(float NewValue, bool IsImmediately = false)
	{
		if (IsImmediately)
		{
			RealValue = NewValue;
			ProcBarShowingValue = RealValue;
			SetParamValue(MainImgMat, ParamNamePercent, RealValue);
			SetParamValue(ProcImgMat, ParamNamePercent, RealValue);
			IsProcBarWorking = false;
			SetProcBarOpacity(0f);
			IsFlashBarWorking = false;
			SetFlashBarOpacity(0f);
			IsIncBarWorking = false;
			SetIncBarOpacity(0f);
		}
		else if (NewValue != RealValue)
		{
			PassedTime = 0f;
			MainBarFromValue = RealValue;
			float num = 0f;
			if (MaxValue != 0f)
			{
				num = FMath.Abs((RealValue - NewValue) / MaxValue);
			}
			if (num > MinProcShowPer)
			{
				DoIncBarLogic(NewValue);
			}
			SetFlashBarMatValueOffset(RealValue, NewValue);
			if (ProcBar != null && NewValue < RealValue && num > MinIncShowPer)
			{
				SetProcBarOpacity(1f);
				ProcBarFromValue = ProcBarShowingValue;
				IsProcBarWorking = true;
			}
			else
			{
				SetProcBarOpacity(0f);
				IsProcBarWorking = false;
			}
			RealValue = NewValue;
			StartTick();
		}
	}

	public void SetMaxValue(float InMaxValue, bool IsImmediately = false)
	{
		MaxValue = InMaxValue;
	}

	public void BindTickMgr(GSMUITickMgr _TickMgr)
	{
		GSTickMgr = _TickMgr;
	}

	public float GetRealValue()
	{
		return RealValue;
	}

	public UMaterialInstanceDynamic GetMainMat()
	{
		return MainImgMat;
	}

	public float GetMaxValue()
	{
		return 0f;
	}

	public void PlayScaleAnim()
	{
	}

	public void StopScaleAnim()
	{
	}

	public bool GetInScaleAnim()
	{
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSProcBarV4:GSOnConstruct")]
	private static void GSOnConstruct__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSProcBarV4 gSProcBarV = GCHelper.Find<GSProcBarV4>(obj);
		gSProcBarV.GSOnConstruct();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSProcBarV4");
		MainBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainBar");
		MainBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainBar", Classes.FObjectProperty);
		MainBarTweenTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainBarTweenTime");
		MainBarTweenTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainBarTweenTime", Classes.FFloatProperty);
		MainBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainBarTweenDelay");
		MainBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainBarTweenDelay", Classes.FFloatProperty);
		ProcBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcBar");
		ProcBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcBar", Classes.FObjectProperty);
		ProcBarTweenTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcBarTweenTime");
		ProcBarTweenTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcBarTweenTime", Classes.FFloatProperty);
		ProcBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcBarTweenDelay");
		ProcBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcBarTweenDelay", Classes.FFloatProperty);
		MinProcShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinProcShowPer");
		MinProcShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinProcShowPer", Classes.FFloatProperty);
		IncBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBar");
		IncBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBar", Classes.FObjectProperty);
		IncBarIncTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarIncTime");
		IncBarIncTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarIncTime", Classes.FFloatProperty);
		IncBarStopTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarStopTime");
		IncBarStopTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarStopTime", Classes.FFloatProperty);
		IncBarBackTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarBackTime");
		IncBarBackTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarBackTime", Classes.FFloatProperty);
		MinIncShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinIncShowPer");
		MinIncShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinIncShowPer", Classes.FFloatProperty);
		FlashBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlashBar");
		FlashBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlashBar", Classes.FObjectProperty);
		FlashBarFadeDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlashBarFadeDelay");
		FlashBarFadeDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlashBarFadeDelay", Classes.FFloatProperty);
		FlashBarFadeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlashBarFadeTime");
		FlashBarFadeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlashBarFadeTime", Classes.FFloatProperty);
		MinFlashShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinFlashShowPer");
		MinFlashShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinFlashShowPer", Classes.FFloatProperty);
		ShineBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "ShineBar");
		ShineBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ShineBar", Classes.FObjectProperty);
		SweepBar_Offset = NativeReflection.GetPropertyOffset(intPtr, "SweepBar");
		SweepBar_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SweepBar", Classes.FObjectProperty);
		GSOnConstruct_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSOnConstruct");
		GSOnConstruct_ParamsSize = NativeReflection.GetFunctionParamsSize(GSOnConstruct_FunctionAddress);
		GSOnConstruct_IsValid = GSOnConstruct_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSProcBarV4:GSOnConstruct", GSOnConstruct_IsValid);
	}

	static GSProcBarV4()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSProcBarV4)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSProcBarV4));
	}
}
