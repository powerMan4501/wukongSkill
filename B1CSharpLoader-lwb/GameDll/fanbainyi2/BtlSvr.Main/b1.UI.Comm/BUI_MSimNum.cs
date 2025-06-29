using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MSimNum")]
public class BUI_MSimNum : BUI_ProjWidget
{
	private Dictionary<DamageTypeEnum, DamageNumUIInfo> DamageNumUIInfoMap;

	private GSMovePanel RootCon;

	private FWidgetAnimationDynamicEvent WidgetAnimEnd;

	private DamageTypeEnum CurDamageType;

	private static bool PlayerDamageNumConfig_IsValid;

	private static int PlayerDamageNumConfig_Offset;

	private static FFieldAddress PlayerDamageNumConfig_PropertyAddress;

	private TMapReadWriteMarshaler<DamageTypeEnum, string> PlayerDamageNumConfig_Marshaler;

	private static bool EnemyDamageNumConfig_IsValid;

	private static int EnemyDamageNumConfig_Offset;

	private static FFieldAddress EnemyDamageNumConfig_PropertyAddress;

	private TMapReadWriteMarshaler<DamageTypeEnum, string> EnemyDamageNumConfig_Marshaler;

	private static bool OnShowAnimFinished_IsValid;

	private static IntPtr OnShowAnimFinished_FunctionAddress;

	private static int OnShowAnimFinished_ParamsSize;

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[DisplayName("PlayerDamageNumConfig")]
	[Category("DamageNum")]
	[USharpPath("/Script/b1-Managed.BUI_MSimNum:PlayerDamageNumConfig")]
	public TMapReadWrite<DamageTypeEnum, string> PlayerDamageNumConfig
	{
		get
		{
			CheckDestroyed();
			if (!PlayerDamageNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MSimNum:PlayerDamageNumConfig");
				return null;
			}
			if (PlayerDamageNumConfig_Marshaler == null)
			{
				PlayerDamageNumConfig_Marshaler = new TMapReadWriteMarshaler<DamageTypeEnum, string>(1, PlayerDamageNumConfig_PropertyAddress, CachedMarshalingDelegates<DamageTypeEnum, EnumMarshaler<DamageTypeEnum>>.FromNative, CachedMarshalingDelegates<DamageTypeEnum, EnumMarshaler<DamageTypeEnum>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return PlayerDamageNumConfig_Marshaler.FromNative(IntPtr.Add(base.Address, PlayerDamageNumConfig_Offset));
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[Category("DamageNum")]
	[DisplayName("EnemyDamageNumConfig")]
	[USharpPath("/Script/b1-Managed.BUI_MSimNum:EnemyDamageNumConfig")]
	public TMapReadWrite<DamageTypeEnum, string> EnemyDamageNumConfig
	{
		get
		{
			CheckDestroyed();
			if (!EnemyDamageNumConfig_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MSimNum:EnemyDamageNumConfig");
				return null;
			}
			if (EnemyDamageNumConfig_Marshaler == null)
			{
				EnemyDamageNumConfig_Marshaler = new TMapReadWriteMarshaler<DamageTypeEnum, string>(1, EnemyDamageNumConfig_PropertyAddress, CachedMarshalingDelegates<DamageTypeEnum, EnumMarshaler<DamageTypeEnum>>.FromNative, CachedMarshalingDelegates<DamageTypeEnum, EnumMarshaler<DamageTypeEnum>>.ToNative, CachedMarshalingDelegates<string, FStringMarshaler>.FromNative, CachedMarshalingDelegates<string, FStringMarshaler>.ToNative);
			}
			return EnemyDamageNumConfig_Marshaler.FromNative(IntPtr.Add(base.Address, EnemyDamageNumConfig_Offset));
		}
	}

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		RootCon = FindChildWidget("RootCon") as GSMovePanel;
		InitUI();
	}

	private void InitUI()
	{
		CurDamageType = DamageTypeEnum.NONE;
		WidgetAnimEnd = new FWidgetAnimationDynamicEvent();
		WidgetAnimEnd.Bind(OnShowAnimFinished);
		DamageNumUIInfoMap = new Dictionary<DamageTypeEnum, DamageNumUIInfo>();
		InitDamageNumUI(PlayerDamageNumConfig);
		InitDamageNumUI(EnemyDamageNumConfig);
	}

	private void InitDamageNumUI(TMapReadWrite<DamageTypeEnum, string> DamageNumConfig)
	{
		if (DamageNumConfig == null)
		{
			return;
		}
		DamageNumUIInfo value = default(DamageNumUIInfo);
		foreach (KeyValuePair<DamageTypeEnum, string> item in DamageNumConfig)
		{
			UWidgetAnimation widgetAnimationByName = UGSE_UMGFuncLib.GetWidgetAnimationByName(this, "AnShowIn_" + item.Value);
			BindToAnimationFinished(widgetAnimationByName, WidgetAnimEnd);
			value.AnShowIn = widgetAnimationByName;
			value.Widgets = new List<UWidget>();
			UWidget uWidget = FindChildWidget("TxtNum_" + item.Value);
			if (uWidget == null)
			{
				for (int i = 0; i < 2; i++)
				{
					UWidget uWidget2 = FindChildWidget($"TxtNum_{item.Value}_{i}");
					if (uWidget2 != null)
					{
						value.Widgets.Add(uWidget2);
					}
				}
			}
			else
			{
				value.Widgets.Add(uWidget);
			}
			UWidget uWidget3 = FindChildWidget("Canvas_" + item.Value);
			if (uWidget3 != null)
			{
				value.Widgets.Add(uWidget3);
			}
			DamageNumUIInfoMap.Add(item.Key, value);
		}
	}

	public void SetDamageNumParam(DamageNumShowParam ShowParam, DamageNumParam Param, BGWDataAsset_DamageNumConfig DamageNumConfig)
	{
		Reset();
		CurDamageType = ShowParam.DamageType;
		if (RootCon != null)
		{
			FVector2D defaultDir = DamageNumConfig.DefaultDir;
			float angle = MathLib.RandomFloatInRange(0f - DamageNumConfig.DirRandomParam, DamageNumConfig.DirRandomParam);
			defaultDir = Rotate(defaultDir, angle);
			RootCon.Direction = defaultDir;
			float num = MathLib.RandomFloatInRange(0f - DamageNumConfig.AmplitudeRandomParam, DamageNumConfig.AmplitudeRandomParam);
			float amplitude = FMath.Clamp(Param.Amplitude + num, DamageNumConfig.AmplitudeMin, DamageNumConfig.AmplitudeMax);
			RootCon.Amplitude = amplitude;
		}
		NumProjInfo inProjData = new NumProjInfo(Param.RealHitLocation);
		InitSet(inProjData);
		string displayTxt = ((Param.DamageNum <= 0) ? $"{FMath.Abs(ShowParam.DamageNum)}" : $"+{ShowParam.DamageNum}");
		UpdateDamageNum(displayTxt);
	}

	private void UpdateDamageNum(string displayTxt)
	{
		if (!DamageNumUIInfoMap.ContainsKey(CurDamageType))
		{
			return;
		}
		List<UWidget> widgets = DamageNumUIInfoMap[CurDamageType].Widgets;
		if (widgets == null)
		{
			return;
		}
		FText text = FText.FromString(displayTxt);
		for (int i = 0; i < widgets.Count; i++)
		{
			UTextBlock uTextBlock = widgets[i] as UTextBlock;
			if (uTextBlock != null)
			{
				uTextBlock.SetText(text);
			}
			UGSBitmapFontBox uGSBitmapFontBox = widgets[i] as UGSBitmapFontBox;
			if (uGSBitmapFontBox != null)
			{
				UGSE_UMGFuncLib.SetTextToBitmapFontBox(uGSBitmapFontBox, text);
			}
			widgets[i]?.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
	}

	private void SetTextVisable(bool Visable)
	{
		foreach (KeyValuePair<DamageTypeEnum, DamageNumUIInfo> item in DamageNumUIInfoMap)
		{
			if (item.Value.Widgets == null)
			{
				continue;
			}
			foreach (UWidget widget in item.Value.Widgets)
			{
				if (widget != null)
				{
					if (Visable)
					{
						widget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
					}
					else
					{
						widget.SetVisibility(ESlateVisibility.Collapsed);
					}
				}
			}
		}
	}

	public override void Reset()
	{
		base.Reset();
		if (RootCon != null)
		{
			RootCon.Reset();
		}
		SetTextVisable(Visable: false);
	}

	protected override void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
		base.UpdateScrPosAngle(ScrPos, RectAngle);
		SetRenderTranslation(ScrPos);
	}

	[UFunction]
	[USharpPath("/Script/b1-Managed.BUI_MSimNum:OnShowAnimFinished")]
	private void OnShowAnimFinished()
	{
		Reset();
	}

	public static FVector2D Rotate(FVector2D Orig, float Angle)
	{
		float num = MathLib.DegreesToRadians(Angle);
		FVector2D fVector2D = new FVector2D(0.0, 0.0);
		fVector2D.X = (float)((double)Orig.X * Math.Cos(num) - (double)Orig.Y * Math.Sin(num));
		fVector2D.Y = (float)((double)Orig.X * Math.Sin(num) + (double)Orig.Y * Math.Cos(num));
		FVector2D fVector2D2 = fVector2D;
		return fVector2D2.GetSafeNormal();
	}

	protected override void PlayFadeIn()
	{
		SetVisibility(ESlateVisibility.HitTestInvisible);
		if (DamageNumUIInfoMap.ContainsKey(CurDamageType))
		{
			UWidgetAnimation anShowIn = DamageNumUIInfoMap[CurDamageType].AnShowIn;
			PlayAnimation(anShowIn);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BUI_MSimNum:OnShowAnimFinished")]
	private static void OnShowAnimFinished__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUI_MSimNum bUI_MSimNum = GCHelper.Find<BUI_MSimNum>(obj);
		bUI_MSimNum.OnShowAnimFinished();
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUI_MSimNum");
		NativeReflection.GetPropertyRef(ref PlayerDamageNumConfig_PropertyAddress, intPtr, "PlayerDamageNumConfig");
		PlayerDamageNumConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "PlayerDamageNumConfig");
		PlayerDamageNumConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PlayerDamageNumConfig", Classes.FMapProperty);
		NativeReflection.GetPropertyRef(ref EnemyDamageNumConfig_PropertyAddress, intPtr, "EnemyDamageNumConfig");
		EnemyDamageNumConfig_Offset = NativeReflection.GetPropertyOffset(intPtr, "EnemyDamageNumConfig");
		EnemyDamageNumConfig_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "EnemyDamageNumConfig", Classes.FMapProperty);
		OnShowAnimFinished_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OnShowAnimFinished");
		OnShowAnimFinished_ParamsSize = NativeReflection.GetFunctionParamsSize(OnShowAnimFinished_FunctionAddress);
		OnShowAnimFinished_IsValid = OnShowAnimFinished_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUI_MSimNum:OnShowAnimFinished", OnShowAnimFinished_IsValid);
	}

	static BUI_MSimNum()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MSimNum)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MSimNum));
	}
}
