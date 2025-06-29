using System;
using System.Collections.Generic;
using System.Linq;
using b1.BGW;
using BtlB1;
using BtlShare;
using ResB1;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI.GSWidget;

[UClass]
[USharpPath("/Script/b1-Managed.GSProcBar")]
public class GSProcBar : GSImage, IProcBar, IGSMUITickable
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

	private Dictionary<FName, float> ParamDic = new Dictionary<FName, float>();

	private ProcBarSizeHelper SizeHelper;

	private int BindResId = -1;

	private float RealValue;

	private float CurMaxValue;

	private float PassedTime;

	private bool UseNormalMaxInc;

	private float CurNormalMaxIncTime;

	private bool[] WarnStates;

	private PreFrameDeltaCal PreFrameData;

	private float CurSliderFreq;

	private List<FFreqConfig> SliderFreqConfigList;

	private UMaterialInstanceDynamic Mat;

	private readonly FName ParamNameAnimOnceTime = new FName("AnimOnceTime");

	private readonly FName ParamNameAnimKeepTime = new FName("AnimKeepTime");

	private readonly FName ParamNameMaxLengthPix = new FName("MaxLength_pix");

	private readonly FName ParamNameMainOpacity = new FName("MainOpacity");

	private readonly FName ParamNameMainPStart = new FName("Main_P_Start");

	private readonly FName ParamNameMainPEnd = new FName("Main_P_End");

	private readonly FName ParamNameProcOpacity = new FName("ProcOpacity");

	private readonly FName ParamNameProcPStart = new FName("Proc_P_Start");

	private readonly FName ParamNameProcPEnd = new FName("Proc_P_End");

	private readonly FName ParamNameFlashOpacity = new FName("FlashOpacity");

	private readonly FName ParamNameFlashPStart = new FName("Flash_P_Start");

	private readonly FName ParamNameFlashPEnd = new FName("Flash_P_End");

	private readonly FName ParamNameIncOpacity = new FName("IncOpacity");

	private readonly FName ParamNameIncPStart = new FName("Inc_P_Start");

	private readonly FName ParamNameIncPEnd = new FName("Inc_P_End");

	private readonly FName ParamNamePercent = new FName("Percent");

	private readonly FName ParamNameActivedWarn = new FName("ActivedWarn");

	private readonly FName ParamNameWarnType = new FName("WarnType");

	private readonly FName ParamNameCullingLeftPix = new FName("CullingLeft_Pix");

	private readonly FName ParamNameCullingRightPix = new FName("CullingRight_Pix");

	private readonly FName ParamNameProgBaseLengthPix = new FName("ProgBaseLength_pix");

	private readonly FName ParamNameBeat = new FName("Beat");

	private static bool MainBarTweenTime_IsValid;

	private static int MainBarTweenTime_Offset;

	private static bool MainBarTweenDelay_IsValid;

	private static int MainBarTweenDelay_Offset;

	private static bool UseProc_IsValid;

	private static int UseProc_Offset;

	private static FFieldAddress UseProc_PropertyAddress;

	private static bool ProcBarTweenTime_IsValid;

	private static int ProcBarTweenTime_Offset;

	private static bool ProcBarTweenDelay_IsValid;

	private static int ProcBarTweenDelay_Offset;

	private static bool MinProcShowPer_IsValid;

	private static int MinProcShowPer_Offset;

	private static bool UseInc_IsValid;

	private static int UseInc_Offset;

	private static FFieldAddress UseInc_PropertyAddress;

	private static bool IncBarIncTime_IsValid;

	private static int IncBarIncTime_Offset;

	private static bool IncBarStopTime_IsValid;

	private static int IncBarStopTime_Offset;

	private static bool IncBarBackTime_IsValid;

	private static int IncBarBackTime_Offset;

	private static bool MinIncShowPer_IsValid;

	private static int MinIncShowPer_Offset;

	private static bool UseFlash_IsValid;

	private static int UseFlash_Offset;

	private static FFieldAddress UseFlash_PropertyAddress;

	private static bool FlashBarFadeDelay_IsValid;

	private static int FlashBarFadeDelay_Offset;

	private static bool FlashBarFadeTime_IsValid;

	private static int FlashBarFadeTime_Offset;

	private static bool MinFlashShowPer_IsValid;

	private static int MinFlashShowPer_Offset;

	private static bool UseSizeScale_IsValid;

	private static int UseSizeScale_Offset;

	private static FFieldAddress UseSizeScale_PropertyAddress;

	private static bool OrgMaxLength_IsValid;

	private static int OrgMaxLength_Offset;

	private static bool NewMaxLength_IsValid;

	private static int NewMaxLength_Offset;

	private static bool CurMaxLength_IsValid;

	private static int CurMaxLength_Offset;

	private static bool MaxIncPercent_IsValid;

	private static int MaxIncPercent_Offset;

	private static bool MaxIncNormalTime_IsValid;

	private static int MaxIncNormalTime_Offset;

	private static bool DefaulValueType_IsValid;

	private static int DefaulValueType_Offset;

	private static FFieldAddress DefaulValueType_PropertyAddress;

	private static bool UseWarnState_IsValid;

	private static int UseWarnState_Offset;

	private static FFieldAddress UseWarnState_PropertyAddress;

	private static bool WarnState_IsValid;

	private static int WarnState_Offset;

	private static FFieldAddress WarnState_PropertyAddress;

	private static bool WarnStateBlock_IsValid;

	private static int WarnStateBlock_Offset;

	private static FFieldAddress WarnStateBlock_PropertyAddress;

	private static bool DangerStatePercent_IsValid;

	private static int DangerStatePercent_Offset;

	private static bool OnceWarnPercent_IsValid;

	private static int OnceWarnPercent_Offset;

	private static bool SliderFreqConfig_IsValid;

	private static int SliderFreqConfig_Offset;

	private static FFieldAddress SliderFreqConfig_PropertyAddress;

	private TArrayReadWriteMarshaler<FFreqConfig> SliderFreqConfig_Marshaler;

	private static bool Size_IsValid;

	private static int Size_Offset;

	private static bool Culling_IsValid;

	private static int Culling_Offset;

	private static bool SetMaxIncPercent_IsValid;

	private static IntPtr SetMaxIncPercent_FunctionAddress;

	private static int SetMaxIncPercent_ParamsSize;

	private static bool SetMaxIncPercent_InMaxIncPercent_IsValid;

	private static int SetMaxIncPercent_InMaxIncPercent_Offset;

	[Category("GSProperty|GSMainBarCfg")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:MainBarTweenTime")]
	public float MainBarTweenTime
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MainBarTweenTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MainBarTweenTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("GSProperty|GSMainBarCfg")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:MainBarTweenDelay")]
	public float MainBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MainBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MainBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MainBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MainBarTweenDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("GSProperty|GSProcBarCfg")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:UseProc")]
	public bool UseProc
	{
		get
		{
			CheckDestroyed();
			if (!UseProc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseProc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseProc_Offset), 0, UseProc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseProc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseProc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseProc_Offset), 0, UseProc_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty|GSProcBarCfg")]
	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseProc")]
	[USharpPath("/Script/b1-Managed.GSProcBar:ProcBarTweenTime")]
	public float ProcBarTweenTime
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:ProcBarTweenTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:ProcBarTweenTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseProc")]
	[Category("GSProperty|GSProcBarCfg")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:ProcBarTweenDelay")]
	public float ProcBarTweenDelay
	{
		get
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:ProcBarTweenDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProcBarTweenDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:ProcBarTweenDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ProcBarTweenDelay_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseProc")]
	[Category("GSProperty|GSProcBarCfg")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:MinProcShowPer")]
	public float MinProcShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinProcShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinProcShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinProcShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinProcShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinProcShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinProcShowPer_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty|GSIncBarCfg")]
	[USharpPath("/Script/b1-Managed.GSProcBar:UseInc")]
	public bool UseInc
	{
		get
		{
			CheckDestroyed();
			if (!UseInc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseInc");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseInc_Offset), 0, UseInc_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseInc_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseInc");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseInc_Offset), 0, UseInc_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseInc")]
	[Category("GSProperty|GSIncBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:IncBarIncTime")]
	public float IncBarIncTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarIncTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarIncTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarIncTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarIncTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarIncTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarIncTime_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseInc")]
	[Category("GSProperty|GSIncBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:IncBarStopTime")]
	public float IncBarStopTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarStopTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarStopTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarStopTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarStopTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarStopTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarStopTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty|GSIncBarCfg")]
	[UMeta(MDProp.EditCondition, "UseInc")]
	[USharpPath("/Script/b1-Managed.GSProcBar:IncBarBackTime")]
	public float IncBarBackTime
	{
		get
		{
			CheckDestroyed();
			if (!IncBarBackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarBackTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, IncBarBackTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!IncBarBackTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:IncBarBackTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, IncBarBackTime_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("GSProperty|GSIncBarCfg")]
	[UMeta(MDProp.EditCondition, "UseInc")]
	[USharpPath("/Script/b1-Managed.GSProcBar:MinIncShowPer")]
	public float MinIncShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinIncShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinIncShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinIncShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinIncShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinIncShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinIncShowPer_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty|GSFlashBarCfg")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:UseFlash")]
	public bool UseFlash
	{
		get
		{
			CheckDestroyed();
			if (!UseFlash_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseFlash");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseFlash_Offset), 0, UseFlash_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseFlash_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseFlash");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseFlash_Offset), 0, UseFlash_PropertyAddress.Address, value);
			}
		}
	}

	[Category("GSProperty|GSFlashBarCfg")]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:FlashBarFadeDelay")]
	public float FlashBarFadeDelay
	{
		get
		{
			CheckDestroyed();
			if (!FlashBarFadeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:FlashBarFadeDelay");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlashBarFadeDelay_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlashBarFadeDelay_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:FlashBarFadeDelay");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlashBarFadeDelay_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[Category("GSProperty|GSFlashBarCfg")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:FlashBarFadeTime")]
	public float FlashBarFadeTime
	{
		get
		{
			CheckDestroyed();
			if (!FlashBarFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:FlashBarFadeTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlashBarFadeTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlashBarFadeTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:FlashBarFadeTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlashBarFadeTime_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseFlash")]
	[Category("GSProperty|GSFlashBarCfg")]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:MinFlashShowPer")]
	public float MinFlashShowPer
	{
		get
		{
			CheckDestroyed();
			if (!MinFlashShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinFlashShowPer");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinFlashShowPer_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinFlashShowPer_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MinFlashShowPer");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinFlashShowPer_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Tooltip("是否开启最大值增长功能")]
	[Category("GSProperty|SizeScale")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:UseSizeScale")]
	public bool UseSizeScale
	{
		get
		{
			CheckDestroyed();
			if (!UseSizeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseSizeScale");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseSizeScale_Offset), 0, UseSizeScale_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseSizeScale_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseSizeScale");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseSizeScale_Offset), 0, UseSizeScale_PropertyAddress.Address, value);
			}
		}
	}

	[BlueprintReadWrite]
	[Category("GSProperty|SizeScale")]
	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[UProperty]
	[EditAnywhere]
	[Tooltip("原大小")]
	[USharpPath("/Script/b1-Managed.GSProcBar:OrgMaxLength")]
	public float OrgMaxLength
	{
		get
		{
			CheckDestroyed();
			if (!OrgMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:OrgMaxLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OrgMaxLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OrgMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:OrgMaxLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OrgMaxLength_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[Tooltip("目标大小")]
	[UProperty]
	[BlueprintReadWrite]
	[Category("GSProperty|SizeScale")]
	[USharpPath("/Script/b1-Managed.GSProcBar:NewMaxLength")]
	public float NewMaxLength
	{
		get
		{
			CheckDestroyed();
			if (!NewMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:NewMaxLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, NewMaxLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!NewMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:NewMaxLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, NewMaxLength_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[Tooltip("当前大小")]
	[Category("GSProperty|SizeScale")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:CurMaxLength")]
	public float CurMaxLength
	{
		get
		{
			CheckDestroyed();
			if (!CurMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:CurMaxLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CurMaxLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CurMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:CurMaxLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CurMaxLength_Offset), value);
			}
		}
	}

	[Category("GSProperty|SizeScale")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[Tooltip("最大值增长进度")]
	[USharpPath("/Script/b1-Managed.GSProcBar:MaxIncPercent")]
	public float MaxIncPercent
	{
		get
		{
			CheckDestroyed();
			if (!MaxIncPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MaxIncPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxIncPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIncPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MaxIncPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxIncPercent_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("默认增长时间")]
	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[Category("GSProperty|SizeScale")]
	[USharpPath("/Script/b1-Managed.GSProcBar:MaxIncNormalTime")]
	public float MaxIncNormalTime
	{
		get
		{
			CheckDestroyed();
			if (!MaxIncNormalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MaxIncNormalTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxIncNormalTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxIncNormalTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:MaxIncNormalTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxIncNormalTime_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("默认值类型")]
	[UMeta(MDProp.EditCondition, "UseSizeScale")]
	[Category("GSProperty|SizeScale")]
	[USharpPath("/Script/b1-Managed.GSProcBar:DefaulValueType")]
	public EDefaulValueType DefaulValueType
	{
		get
		{
			CheckDestroyed();
			if (!DefaulValueType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:DefaulValueType");
				return EDefaulValueType.Percent;
			}
			return EnumMarshaler<EDefaulValueType>.FromNative(IntPtr.Add(base.Address, DefaulValueType_Offset), 0, DefaulValueType_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DefaulValueType_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:DefaulValueType");
			}
			else
			{
				EnumMarshaler<EDefaulValueType>.ToNative(IntPtr.Add(base.Address, DefaulValueType_Offset), 0, DefaulValueType_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("是否开启示警")]
	[Category("GSProperty|WarnState")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:UseWarnState")]
	public bool UseWarnState
	{
		get
		{
			CheckDestroyed();
			if (!UseWarnState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseWarnState");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, UseWarnState_Offset), 0, UseWarnState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!UseWarnState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:UseWarnState");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, UseWarnState_Offset), 0, UseWarnState_PropertyAddress.Address, value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseWarnState")]
	[Tooltip("示警状态")]
	[Category("GSProperty|WarnState")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:WarnState")]
	public EWarnState WarnState
	{
		get
		{
			CheckDestroyed();
			if (!WarnState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:WarnState");
				return EWarnState.None;
			}
			return EnumMarshaler<EWarnState>.FromNative(IntPtr.Add(base.Address, WarnState_Offset), 0, WarnState_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WarnState_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:WarnState");
			}
			else
			{
				EnumMarshaler<EWarnState>.ToNative(IntPtr.Add(base.Address, WarnState_Offset), 0, WarnState_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Tooltip("当进度值为0时阻断示警类型")]
	[UMeta(MDProp.EditCondition, "UseWarnState")]
	[EditAnywhere]
	[Category("GSProperty|WarnState")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:WarnStateBlock")]
	public EWarnStateBlock WarnStateBlock
	{
		get
		{
			CheckDestroyed();
			if (!WarnStateBlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:WarnStateBlock");
				return EWarnStateBlock.UnBlock;
			}
			return EnumMarshaler<EWarnStateBlock>.FromNative(IntPtr.Add(base.Address, WarnStateBlock_Offset), 0, WarnStateBlock_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!WarnStateBlock_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:WarnStateBlock");
			}
			else
			{
				EnumMarshaler<EWarnStateBlock>.ToNative(IntPtr.Add(base.Address, WarnStateBlock_Offset), 0, WarnStateBlock_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("GSProperty|WarnState")]
	[Tooltip("危险警示（进度值低于一定阈值时）")]
	[UMeta(MDProp.EditCondition, "UseWarnState")]
	[USharpPath("/Script/b1-Managed.GSProcBar:DangerStatePercent")]
	public float DangerStatePercent
	{
		get
		{
			CheckDestroyed();
			if (!DangerStatePercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:DangerStatePercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DangerStatePercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DangerStatePercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:DangerStatePercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DangerStatePercent_Offset), value);
			}
		}
	}

	[UProperty]
	[UMeta(MDProp.EditCondition, "UseWarnState")]
	[Category("GSProperty|WarnState")]
	[BlueprintReadWrite]
	[Tooltip("单次强调（单次增量或扣减大于一定值时）")]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSProcBar:OnceWarnPercent")]
	public float OnceWarnPercent
	{
		get
		{
			CheckDestroyed();
			if (!OnceWarnPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:OnceWarnPercent");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, OnceWarnPercent_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OnceWarnPercent_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:OnceWarnPercent");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, OnceWarnPercent_Offset), value);
			}
		}
	}

	[UMeta(MDProp.EditCondition, "UseWarnState")]
	[Tooltip("SliderFreq配置")]
	[Category("GSProperty|WarnState")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSProcBar:SliderFreqConfig")]
	public TArrayReadWrite<FFreqConfig> SliderFreqConfig
	{
		get
		{
			CheckDestroyed();
			if (!SliderFreqConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:SliderFreqConfig");
				return null;
			}
			if (SliderFreqConfig_Marshaler == null)
			{
				SliderFreqConfig_Marshaler = new TArrayReadWriteMarshaler<FFreqConfig>(1, SliderFreqConfig_PropertyAddress, CachedMarshalingDelegates<FFreqConfig, BlittableTypeMarshaler<FFreqConfig>>.FromNative, CachedMarshalingDelegates<FFreqConfig, BlittableTypeMarshaler<FFreqConfig>>.ToNative);
			}
			return SliderFreqConfig_Marshaler.FromNative(IntPtr.Add(base.Address, SliderFreqConfig_Offset));
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[Category("GSProperty")]
	[EditAnywhere]
	[Tooltip("默认Size/最大Size")]
	[USharpPath("/Script/b1-Managed.GSProcBar:Size")]
	public FVector2D Size
	{
		get
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:Size");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Size_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Size_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:Size");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Size_Offset), value);
			}
		}
	}

	[Tooltip("左右裁剪")]
	[Category("GSProperty")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSProcBar:Culling")]
	public FVector2D Culling
	{
		get
		{
			CheckDestroyed();
			if (!Culling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:Culling");
				return default(FVector2D);
			}
			return BlittableTypeMarshaler<FVector2D>.FromNative(IntPtr.Add(base.Address, Culling_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Culling_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSProcBar:Culling");
			}
			else
			{
				BlittableTypeMarshaler<FVector2D>.ToNative(IntPtr.Add(base.Address, Culling_Offset), value);
			}
		}
	}

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
		MaxIncNormalTime = 0.5f;
		Size = new FVector2D(512.0, 512.0);
		base.CommParams = new MatCommParams
		{
			UseTimerParam = false,
			UseRandomParam = false,
			UseMouseParam = false,
			IsShowFocusPosInGamepad = false,
			UseWidgetParam = false,
			IsDynamic = false
		};
	}

	[UFunction]
	[BlueprintCallable]
	public override void GSOnConstruct()
	{
		if (!base.IsInit)
		{
			RealValue = 0f;
			CurMaxValue = 1f;
			MainBarFromValue = 0f;
			IncBarBeginValueForInc = 0f;
			IncBarBeginValueForBack = 0f;
			ProcBarFromValue = 0f;
			MaxIncPercent = 0f;
			SetProcBarOpacity(0f);
			SetFlashBarOpacity(0f);
			SetIncBarOpacity(0f);
			Mat = GetDynamicMaterial();
			ParamDic.Clear();
			ParamDic.Add(ParamNameMainPStart, 0f);
			ParamDic.Add(ParamNameMainPEnd, 1f);
			ParamDic.Add(ParamNameProcPStart, 0f);
			ParamDic.Add(ParamNameProcPEnd, 1f);
			ParamDic.Add(ParamNameFlashPStart, 0f);
			ParamDic.Add(ParamNameFlashPEnd, 1f);
			ParamDic.Add(ParamNameIncPStart, 0f);
			ParamDic.Add(ParamNameIncPEnd, 1f);
			ParamDic.Add(ParamNamePercent, 1f);
			UCanvasPanelSlot uCanvasPanelSlot = base.Slot as UCanvasPanelSlot;
			if (uCanvasPanelSlot != null)
			{
				uCanvasPanelSlot.SetSize(new FVector2D(GetDefaultSizeNotCulling(), uCanvasPanelSlot.GetSize().Y));
			}
			InitSizeHelper();
			WarnStates = new bool[3];
			SliderFreqConfigList = SliderFreqConfig.OrderByDescending((FFreqConfig x) => x.Percent).ToList();
			if (SliderFreqConfigList.Count > 0)
			{
				float freq = SliderFreqConfigList[0].Freq;
				PreFrameData = PreFrameDeltaCal.Create(freq);
			}
			if (!UBGUFunctionLibraryForCS.BGUGetIsInEditorPreview(this))
			{
				float defaultSize = GetDefaultSize();
				SetMaxLength(defaultSize, defaultSize, IsImmediately: true);
				SetWarnState(EWarnState.None);
			}
			else
			{
				SetWarnState(WarnState);
			}
			Mat?.SetScalarParameterValue(ParamNameCullingLeftPix, Culling.X);
			Mat?.SetScalarParameterValue(ParamNameCullingRightPix, Culling.Y);
			Mat?.SetScalarParameterValue(ParamNameProgBaseLengthPix, GetDefaultSizeNotCulling());
			base.GSOnConstruct();
		}
	}

	private void SetWarnState(EWarnState NewWarnState)
	{
		EWarnState warnState = WarnState;
		WarnState = NewWarnState;
		Mat?.SetScalarParameterValue(ParamNameActivedWarn, (WarnState != EWarnState.None) ? 1 : 0);
		Mat?.SetScalarParameterValue(ParamNameWarnType, (int)(WarnState - 1));
		if (PreFrameData != null && warnState != NewWarnState && WarnState == EWarnState.Danger)
		{
			PreFrameData.SetSliderFreq(0f);
			Mat?.SetScalarParameterValue(ParamNameBeat, 0f);
			StartTick();
		}
	}

	public void SetFlashBarMatValueOffset(float FromValue, float ToValue)
	{
		if (UseFlash)
		{
			if (ToValue < FromValue)
			{
				SetParamValue(ParamNameFlashPEnd, FromValue);
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
		SetParamValue(ParamNameIncPStart, LowValue);
		SetParamValue(ParamNameIncPEnd, HighValue);
		Mat?.SetScalarParameterValue(ParamNameAnimOnceTime, IncBarTickTime);
		Mat?.SetScalarParameterValue(ParamNameAnimKeepTime, IncBarKeepTime);
	}

	private void SetParamValue(FName ParamName, float Value)
	{
		if (ParamDic.ContainsKey(ParamName))
		{
			ParamDic[ParamName] = Value;
		}
		StartTick();
	}

	private float GetParamValue(FName ParamName)
	{
		if (ParamDic.TryGetValue(ParamName, out var value))
		{
			return value;
		}
		return -1f;
	}

	private void SetParamPercent(float MaxValue)
	{
		foreach (KeyValuePair<FName, float> item in ParamDic)
		{
			float num = item.Value / MaxValue;
			if (item.Key == ParamNamePercent)
			{
				SetWarnState(EWarnState.Danger, DangerStatePercent > 0f && num < DangerStatePercent);
				CurSliderFreq = 0f;
				for (int i = 0; i < SliderFreqConfigList.Count; i++)
				{
					FFreqConfig fFreqConfig = SliderFreqConfigList[i];
					if (num > fFreqConfig.Percent)
					{
						break;
					}
					CurSliderFreq = fFreqConfig.Freq;
				}
			}
			Mat?.SetScalarParameterValue(item.Key, num);
		}
	}

	private void StartTick()
	{
		IsNeedTickUpdate = true;
		GSTickMgr?.SetTickingQueue(this);
	}

	private void SetProcBarOpacity(float Opacity)
	{
		Mat?.SetScalarParameterValue(ParamNameProcOpacity, Opacity);
	}

	private void SetFlashBarOpacity(float Opacity)
	{
		Mat?.SetScalarParameterValue(ParamNameFlashOpacity, Opacity);
	}

	private void SetIncBarOpacity(float Opacity)
	{
		Mat?.SetScalarParameterValue(ParamNameIncOpacity, Opacity);
	}

	public override bool IsGSNeedTick()
	{
		if (!IsNeedTickUpdate)
		{
			return base.IsGSNeedTick();
		}
		return true;
	}

	private bool UpdateMainBarIsIdle()
	{
		if (IsIncBarWorking)
		{
			return true;
		}
		float num = PassedTime - MainBarTweenDelay;
		if (num >= MainBarTweenTime)
		{
			SetParamValue(ParamNameMainPEnd, RealValue);
			SetParamValue(ParamNamePercent, RealValue);
			return true;
		}
		float x = num / MainBarTweenTime;
		x = MathLib.Clamp(x, 0f, 1f);
		float value = GSEaseFuncInUE.GSMathEase(MainBarFromValue, RealValue, x, EEasingFunc.EaseOut, 3.5f);
		SetParamValue(ParamNameMainPEnd, value);
		SetParamValue(ParamNamePercent, value);
		return false;
	}

	private bool UpdateProcBarIsIdle()
	{
		if (!UseProc || !IsProcBarWorking)
		{
			return true;
		}
		float num = PassedTime - ProcBarTweenDelay;
		if (num >= ProcBarTweenTime)
		{
			SetParamValue(ParamNameProcPEnd, RealValue);
			SetProcBarOpacity(0f);
			IsProcBarWorking = false;
			return true;
		}
		float x = num / ProcBarTweenTime;
		x = MathLib.Clamp(x, 0f, 1f);
		ProcBarShowingValue = GSEaseFuncInUE.GSMathEase(ProcBarFromValue, RealValue, x, EEasingFunc.EaseOut, 3.5f);
		SetParamValue(ParamNameProcPEnd, ProcBarShowingValue);
		SetProcBarOpacity(1f);
		return false;
	}

	private bool UpdateFlashBarIsIdle()
	{
		if (!UseFlash || !IsFlashBarWorking)
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
		float flashBarOpacity = GSEaseFuncInUE.GSMathEase(1f, 0f, x, EEasingFunc.EaseOut, 3.5f);
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
			IncBarShowingHighValue = GSEaseFuncInUE.GSMathEase(IncBarBeginValueForInc, RealValue, x, EEasingFunc.EaseOut, 3.5f);
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
			IncBarShowingLowValue = GSEaseFuncInUE.GSMathEase(IncBarBeginValueForBack, RealValue, x2, EEasingFunc.EaseOut, 3.5f);
		}
		SetIncBarMatValue(IncBarShowingLowValue, IncBarShowingHighValue);
		SetParamValue(ParamNameMainPEnd, IncBarShowingHighValue);
		SetParamValue(ParamNamePercent, IncBarShowingHighValue);
		return false;
	}

	private bool UpdataParamsIsIdle(float InDeltaTime)
	{
		if (UseSizeScale && NewMaxLength != 0f && OrgMaxLength != 0f)
		{
			if (UseNormalMaxInc)
			{
				CurNormalMaxIncTime += InDeltaTime;
				float alpha = 1f;
				if (MaxIncNormalTime != 0f)
				{
					alpha = FMath.Clamp(CurNormalMaxIncTime / MaxIncNormalTime, 0f, 1f);
				}
				MaxIncPercent = GSEaseFuncInUE.GSMathEase(0f, 1f, alpha, EEasingFunc.EaseOut, 3.5f);
			}
			CurMaxLength = GSEaseFuncInUE.GSMathEase(OrgMaxLength, NewMaxLength, MaxIncPercent, EEasingFunc.Linear);
			SetSize(CurMaxLength);
			if (CurMaxValue * CurMaxLength / NewMaxLength != 0f)
			{
				SetParamPercent(CurMaxValue);
			}
		}
		else if (CurMaxValue != 0f)
		{
			SetParamPercent(CurMaxValue);
		}
		if (GetInScaleAnim())
		{
			return false;
		}
		StopScaleAnim();
		return true;
	}

	[BlueprintCallable]
	[UFunction]
	public override void DoGSTick(float DeltaTime)
	{
		base.DoGSTick(DeltaTime);
		if (IsNeedTickUpdate)
		{
			PassedTime += DeltaTime;
			bool num = UpdateMainBarIsIdle();
			bool flag = UpdateProcBarIsIdle();
			bool flag2 = UpdateFlashBarIsIdle();
			bool flag3 = UpdateIncBarIsIdle(DeltaTime);
			bool flag4 = UpdataParamsIsIdle(DeltaTime);
			bool flag5 = UpdataSliderFreqIsIdle(DeltaTime);
			if (num && flag && flag2 && flag3 && flag5 && flag4)
			{
				IsNeedTickUpdate = false;
			}
		}
	}

	private bool UpdataSliderFreqIsIdle(float InDeltaTime)
	{
		if (SliderFreqConfigList.Count > 0 && PreFrameData != null && WarnState == EWarnState.Danger)
		{
			PreFrameData.SetSliderFreq(CurSliderFreq);
			Mat?.SetScalarParameterValue(ParamNameBeat, PreFrameData.GetDeltaTime(InDeltaTime));
			return false;
		}
		return true;
	}

	private void DoIncBarLogic(float NewValue)
	{
		if (!UseInc)
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
			MainBarFromValue = RealValue;
			ProcBarShowingValue = RealValue;
			SetParamValue(ParamNameMainPEnd, RealValue);
			SetParamValue(ParamNameProcPEnd, RealValue);
			SetParamValue(ParamNamePercent, RealValue);
			IsProcBarWorking = false;
			SetProcBarOpacity(0f);
			IsFlashBarWorking = false;
			SetFlashBarOpacity(0f);
			IsIncBarWorking = false;
			SetIncBarOpacity(0f);
		}
		else
		{
			if (NewValue == RealValue)
			{
				return;
			}
			PassedTime = 0f;
			MainBarFromValue = RealValue;
			float num = 0f;
			if (CurMaxValue != 0f)
			{
				num = FMath.Abs((RealValue - NewValue) / CurMaxValue);
			}
			if (num > MinIncShowPer)
			{
				DoIncBarLogic(NewValue);
			}
			if (NewValue <= 0f)
			{
				IsFlashBarWorking = false;
				SetFlashBarOpacity(0f);
			}
			else if (num > MinFlashShowPer)
			{
				SetFlashBarMatValueOffset(RealValue, NewValue);
			}
			if (UseProc && NewValue < RealValue && num > MinProcShowPer)
			{
				if (IsProcBarWorking)
				{
					ProcBarFromValue = ProcBarShowingValue;
					SetParamValue(ParamNameProcPEnd, ProcBarShowingValue);
				}
				else
				{
					ProcBarFromValue = RealValue;
					SetParamValue(ParamNameProcPEnd, RealValue);
					IsProcBarWorking = true;
				}
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
		if (CurMaxValue != InMaxValue)
		{
			float curMaxValue = CurMaxValue;
			CurMaxValue = InMaxValue;
			if (UseSizeScale)
			{
				float finalSize = SizeHelper.GetFinalSize(curMaxValue);
				float finalSize2 = SizeHelper.GetFinalSize(CurMaxValue);
				SetMaxLength(finalSize, finalSize2, IsImmediately);
				StartTick();
			}
		}
	}

	public float GetMaxValue()
	{
		return CurMaxValue;
	}

	public float GetRealValue()
	{
		return RealValue;
	}

	public UMaterialInstanceDynamic GetMainMat()
	{
		return Mat;
	}

	private void InitSizeHelper()
	{
		if (!UseSizeScale)
		{
			return;
		}
		float inDefValue = -1f;
		float inMaxValue = -1f;
		int commLogicCfgValue = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultResid);
		int commLogicCfgValue2 = GameDBRuntime.GetCommLogicCfgValue(CommCfgType.PlayerDefaultBattleinfoextendid);
		switch (DefaulValueType)
		{
		case EDefaulValueType.PlayerHp:
		{
			FUStUnitLevelUpDesc unitLevelUpDesc = BGW_GameDB.GetUnitLevelUpDesc(commLogicCfgValue, commLogicCfgValue2);
			if (unitLevelUpDesc != null)
			{
				int hpBase = unitLevelUpDesc.HpBase;
				if (hpBase != 0)
				{
					inDefValue = hpBase;
					inMaxValue = hpBase;
				}
			}
			break;
		}
		case EDefaulValueType.PlayerMp:
		{
			FUStUnitLevelUpDesc unitLevelUpDesc3 = BGW_GameDB.GetUnitLevelUpDesc(commLogicCfgValue, commLogicCfgValue2);
			if (unitLevelUpDesc3 != null)
			{
				int mpBase = unitLevelUpDesc3.MpBase;
				if (mpBase != 0)
				{
					inDefValue = mpBase;
					inMaxValue = mpBase;
				}
			}
			break;
		}
		case EDefaulValueType.PlayerSt:
		{
			FUStPlayerCommDesc playerCommDesc = BGW_GameDB.GetPlayerCommDesc(commLogicCfgValue);
			if (playerCommDesc != null)
			{
				float staminaMaxBase = playerCommDesc.StaminaMaxBase;
				if (staminaMaxBase != 0f)
				{
					inDefValue = staminaMaxBase;
					inMaxValue = staminaMaxBase;
				}
			}
			break;
		}
		case EDefaulValueType.UnitHp:
		{
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr2 = BGW_PreloadAssetMgr.Get(this);
			if (BindResId > 0 && bGW_PreloadAssetMgr2 != null && bGW_PreloadAssetMgr2.UIConfigDataAsset.HpDefaultMap.TryGetValue(BindResId, out var value3))
			{
				if (value3 != 0f)
				{
					inDefValue = value3;
					inMaxValue = value3;
				}
				break;
			}
			FUStUnitLevelUpDesc unitLevelUpDesc2 = BGW_GameDB.GetUnitLevelUpDesc(commLogicCfgValue, commLogicCfgValue2);
			if (unitLevelUpDesc2 != null)
			{
				value3 = unitLevelUpDesc2.HpBase;
				if (value3 != 0f)
				{
					inDefValue = value3;
					inMaxValue = value3;
				}
			}
			break;
		}
		case EDefaulValueType.MultiMapping:
		{
			BGW_PreloadAssetMgr bGW_PreloadAssetMgr = BGW_PreloadAssetMgr.Get(this);
			if (bGW_PreloadAssetMgr != null && bGW_PreloadAssetMgr.UIConfigDataAsset.ProcBarConfigMap != null)
			{
				FProcBarConfig value2;
				if (BindResId > 0 && bGW_PreloadAssetMgr.UIConfigDataAsset.ProcBarConfigMap.TryGetValue(BindResId, out var value))
				{
					inDefValue = value.DefValue;
					inMaxValue = value.MaxValue;
				}
				else if (bGW_PreloadAssetMgr.UIConfigDataAsset.ProcBarConfigMap.TryGetValue(commLogicCfgValue, out value2))
				{
					inDefValue = value2.DefValue;
					inMaxValue = value2.MaxValue;
				}
			}
			else
			{
				inDefValue = 300f;
				inMaxValue = 1000f;
			}
			break;
		}
		}
		float defaultSize = GetDefaultSize();
		float maxSize = GetMaxSize();
		SizeHelper = new ProcBarSizeHelper(defaultSize, maxSize, inDefValue, inMaxValue);
		UpdateMaxLength();
	}

	public void SetDefalutValueType(EDefaulValueType InDefalutValueType)
	{
		DefaulValueType = InDefalutValueType;
		InitSizeHelper();
	}

	public void SetBindResId(int ResId)
	{
		BindResId = ResId;
		InitSizeHelper();
	}

	private void UpdateMaxLength()
	{
		if (UseSizeScale)
		{
			float finalSize = SizeHelper.GetFinalSize(CurMaxValue);
			SetMaxLength(finalSize, finalSize, IsImmediately: true);
		}
	}

	private float GetDefaultSize()
	{
		return GetDefaultSizeNotCulling() - GetCullingSize();
	}

	private float GetMaxSize()
	{
		return GetMaxSizeNotCulling() - GetCullingSize();
	}

	private float GetDefaultSizeNotCulling()
	{
		return Size.X;
	}

	private float GetMaxSizeNotCulling()
	{
		return Size.Y;
	}

	private void SetSize(float Size)
	{
		UCanvasPanelSlot uCanvasPanelSlot = base.Slot as UCanvasPanelSlot;
		if (uCanvasPanelSlot != null)
		{
			uCanvasPanelSlot.SetSize(new FVector2D(Size + GetCullingSize(), uCanvasPanelSlot.GetSize().Y));
		}
		Mat?.SetScalarParameterValue(ParamNameMaxLengthPix, Size + GetCullingSize());
	}

	private float GetCullingSize()
	{
		return Culling.X + Culling.Y;
	}

	private void SetMaxLength(float OldValue, float NewValue, bool IsImmediately = false)
	{
		if (IsImmediately || !FMath.IsNearlyEqual(NewValue, NewMaxLength))
		{
			ResetScaleAnim();
			if (IsImmediately)
			{
				OrgMaxLength = NewValue;
				CurMaxLength = NewValue;
				NewMaxLength = NewValue;
				StopScaleAnim();
			}
			else
			{
				OrgMaxLength = OldValue;
				NewMaxLength = NewValue;
				IsNeedTickUpdate = true;
			}
		}
	}

	public void PlayScaleAnim()
	{
		OrgMaxLength = CurMaxLength;
		MaxIncPercent = 0f;
		UseNormalMaxInc = true;
		CurNormalMaxIncTime = 0f;
		IsNeedTickUpdate = true;
	}

	public void StopScaleAnim()
	{
		UseNormalMaxInc = false;
		CurNormalMaxIncTime = 0f;
		SetSize(NewMaxLength);
	}

	public void StopScaleAnimAndCurLength()
	{
		CurMaxLength = NewMaxLength;
		MaxIncPercent = 1f;
		StopScaleAnim();
	}

	public void ResetScaleAnim()
	{
		MaxIncPercent = 0f;
	}

	public bool GetInScaleAnim()
	{
		if (FMath.IsNearlyZero(NewMaxLength - CurMaxLength))
		{
			if (MaxIncPercent > 0f)
			{
				return MaxIncPercent < 1f;
			}
			return false;
		}
		return true;
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.GSProcBar:SetMaxIncPercent")]
	public void SetMaxIncPercent(float InMaxIncPercent)
	{
		MaxIncPercent = InMaxIncPercent;
	}

	public bool GetBlockState()
	{
		if (RealValue <= 0f)
		{
			if (WarnStateBlock != EWarnStateBlock.BlockAll)
			{
				return WarnStateBlock == EWarnStateBlock.BlockState;
			}
			return true;
		}
		return false;
	}

	public bool GetBlockOnce()
	{
		if (RealValue <= 0f)
		{
			if (WarnStateBlock != EWarnStateBlock.BlockAll)
			{
				return WarnStateBlock == EWarnStateBlock.BlockOnce;
			}
			return true;
		}
		return false;
	}

	public void SetWarnState(EWarnState InWarnState, bool InValue)
	{
		if (WarnStates[(uint)InWarnState] != InValue)
		{
			WarnStates[(uint)InWarnState] = InValue;
		}
		UpdateWarnStateIsIdle();
	}

	private bool UpdateWarnStateIsIdle()
	{
		bool result = true;
		EWarnState eWarnState = EWarnState.None;
		if (!GetBlockState() && eWarnState == EWarnState.None)
		{
			for (int i = 0; i < WarnStates.Length; i++)
			{
				if (WarnStates[i])
				{
					eWarnState = (EWarnState)i;
					break;
				}
			}
		}
		if (WarnState != eWarnState)
		{
			SetWarnState(eWarnState);
		}
		return result;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSProcBar:SetMaxIncPercent")]
	private static void SetMaxIncPercent__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSProcBar gSProcBar = GCHelper.Find<GSProcBar>(obj);
		float maxIncPercent = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, SetMaxIncPercent_InMaxIncPercent_Offset));
		gSProcBar.SetMaxIncPercent(maxIncPercent);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSProcBar");
		MainBarTweenTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainBarTweenTime");
		MainBarTweenTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainBarTweenTime", Classes.FFloatProperty);
		MainBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "MainBarTweenDelay");
		MainBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MainBarTweenDelay", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseProc_PropertyAddress, intPtr, "UseProc");
		UseProc_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseProc");
		UseProc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseProc", Classes.FBoolProperty);
		ProcBarTweenTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcBarTweenTime");
		ProcBarTweenTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcBarTweenTime", Classes.FFloatProperty);
		ProcBarTweenDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProcBarTweenDelay");
		ProcBarTweenDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProcBarTweenDelay", Classes.FFloatProperty);
		MinProcShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinProcShowPer");
		MinProcShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinProcShowPer", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseInc_PropertyAddress, intPtr, "UseInc");
		UseInc_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseInc");
		UseInc_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseInc", Classes.FBoolProperty);
		IncBarIncTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarIncTime");
		IncBarIncTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarIncTime", Classes.FFloatProperty);
		IncBarStopTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarStopTime");
		IncBarStopTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarStopTime", Classes.FFloatProperty);
		IncBarBackTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "IncBarBackTime");
		IncBarBackTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "IncBarBackTime", Classes.FFloatProperty);
		MinIncShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinIncShowPer");
		MinIncShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinIncShowPer", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseFlash_PropertyAddress, intPtr, "UseFlash");
		UseFlash_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseFlash");
		UseFlash_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseFlash", Classes.FBoolProperty);
		FlashBarFadeDelay_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlashBarFadeDelay");
		FlashBarFadeDelay_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlashBarFadeDelay", Classes.FFloatProperty);
		FlashBarFadeTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlashBarFadeTime");
		FlashBarFadeTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlashBarFadeTime", Classes.FFloatProperty);
		MinFlashShowPer_Offset = NativeReflection.GetPropertyOffset(intPtr, "MinFlashShowPer");
		MinFlashShowPer_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MinFlashShowPer", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref UseSizeScale_PropertyAddress, intPtr, "UseSizeScale");
		UseSizeScale_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseSizeScale");
		UseSizeScale_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseSizeScale", Classes.FBoolProperty);
		OrgMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "OrgMaxLength");
		OrgMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OrgMaxLength", Classes.FFloatProperty);
		NewMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "NewMaxLength");
		NewMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NewMaxLength", Classes.FFloatProperty);
		CurMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "CurMaxLength");
		CurMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CurMaxLength", Classes.FFloatProperty);
		MaxIncPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxIncPercent");
		MaxIncPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxIncPercent", Classes.FFloatProperty);
		MaxIncNormalTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "MaxIncNormalTime");
		MaxIncNormalTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "MaxIncNormalTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DefaulValueType_PropertyAddress, intPtr, "DefaulValueType");
		DefaulValueType_Offset = NativeReflection.GetPropertyOffset(intPtr, "DefaulValueType");
		DefaulValueType_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DefaulValueType", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref UseWarnState_PropertyAddress, intPtr, "UseWarnState");
		UseWarnState_Offset = NativeReflection.GetPropertyOffset(intPtr, "UseWarnState");
		UseWarnState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "UseWarnState", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref WarnState_PropertyAddress, intPtr, "WarnState");
		WarnState_Offset = NativeReflection.GetPropertyOffset(intPtr, "WarnState");
		WarnState_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WarnState", Classes.FEnumProperty);
		NativeReflection.GetPropertyRef(ref WarnStateBlock_PropertyAddress, intPtr, "WarnStateBlock");
		WarnStateBlock_Offset = NativeReflection.GetPropertyOffset(intPtr, "WarnStateBlock");
		WarnStateBlock_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "WarnStateBlock", Classes.FEnumProperty);
		DangerStatePercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "DangerStatePercent");
		DangerStatePercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DangerStatePercent", Classes.FFloatProperty);
		OnceWarnPercent_Offset = NativeReflection.GetPropertyOffset(intPtr, "OnceWarnPercent");
		OnceWarnPercent_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OnceWarnPercent", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref SliderFreqConfig_PropertyAddress, intPtr, "SliderFreqConfig");
		SliderFreqConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "SliderFreqConfig");
		SliderFreqConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SliderFreqConfig", Classes.FArrayProperty);
		Size_Offset = NativeReflection.GetPropertyOffset(intPtr, "Size");
		Size_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Size", Classes.FStructProperty);
		Culling_Offset = NativeReflection.GetPropertyOffset(intPtr, "Culling");
		Culling_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Culling", Classes.FStructProperty);
		SetMaxIncPercent_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetMaxIncPercent");
		SetMaxIncPercent_ParamsSize = NativeReflection.GetFunctionParamsSize(SetMaxIncPercent_FunctionAddress);
		SetMaxIncPercent_InMaxIncPercent_Offset = NativeReflection.GetPropertyOffset(SetMaxIncPercent_FunctionAddress, "InMaxIncPercent");
		SetMaxIncPercent_InMaxIncPercent_IsValid = NativeReflection.ValidatePropertyClass(SetMaxIncPercent_FunctionAddress, "InMaxIncPercent", Classes.FFloatProperty);
		SetMaxIncPercent_IsValid = SetMaxIncPercent_FunctionAddress != IntPtr.Zero && SetMaxIncPercent_InMaxIncPercent_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSProcBar:SetMaxIncPercent", SetMaxIncPercent_IsValid);
	}

	static GSProcBar()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSProcBar)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSProcBar));
	}
}
