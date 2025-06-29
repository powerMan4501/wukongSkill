using System;
using System.Collections.Generic;
using b1.BGW;
using b1.GSMUI.GSWidget;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.SlateCore;
using UnrealEngine.UMG;

namespace b1.UI.Comm;

[UClass]
[USharpPath("/Script/b1-Managed.BUI_MPlayerInfo")]
public class BUI_MPlayerInfo : BUI_MBarBase
{
	private struct ArrowData
	{
		public UImage ArrowImg;

		public UPanelWidget ArrowCon;

		public ArrowData(UImage InArrowImg)
		{
			ArrowImg = InArrowImg;
			ArrowCon = ArrowImg.GetParent();
		}
	}

	private UTextBlock TxtName;

	private UVerticalBoxSlot TxtNameSlot;

	private UImage ProcBG;

	private UMaterialInstanceDynamic ProcBGMat;

	private UWidget HpSizeBox;

	private UWidget NameSpacer;

	private UWidget TeamTipsIconSizeBox;

	private BUI_TeamTipsIcon TeamTipsIcon;

	private Dictionary<EIndicatorType, ArrowData> Arrows;

	private EIndicatorType CurIndicatorType;

	private DS_IBUC_FallDyingData FallDyingData;

	private DS_IBPC_RoleBaseData PlayerOnLineRoleData;

	private readonly FName ParamNamePercent = new FName("Percent");

	private static bool InterpSpeed_IsValid;

	private static int InterpSpeed_Offset;

	[Tooltip("基准定位点的拟合速度")]
	[Category("GSProperty")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BUI_MPlayerInfo:InterpSpeed")]
	public float InterpSpeed
	{
		get
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MPlayerInfo:InterpSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, InterpSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!InterpSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUI_MPlayerInfo:InterpSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, InterpSpeed_Offset), value);
			}
		}
	}

	public FVector2D RealScreenPos { get; set; }

	public bool IsFallDying { get; set; }

	public float SaveSelfWaitTimePercent { get; set; }

	protected override void OnUIConstruct()
	{
		base.OnUIConstruct();
		TxtName = FindChildWidget("TxtName") as UTextBlock;
		TxtNameSlot = TxtName.Slot as UVerticalBoxSlot;
		ProcBG = FindChildWidget("ProcBG") as UImage;
		ProcBGMat = ProcBG?.GetDynamicMaterial();
		HpSizeBox = FindChildWidget("HpSizeBox");
		NameSpacer = FindChildWidget("NameSpacer");
		TeamTipsIconSizeBox = FindChildWidget("TeamTipsIconSizeBox");
		TeamTipsIcon = FindChildWidget("BI_TeamTipsIcon") as BUI_TeamTipsIcon;
		Arrows = new Dictionary<EIndicatorType, ArrowData>
		{
			{
				EIndicatorType.Top,
				new ArrowData(FindChildWidget("Arrow_Top") as UImage)
			},
			{
				EIndicatorType.Bottom,
				new ArrowData(FindChildWidget("Arrow_Bottom") as UImage)
			},
			{
				EIndicatorType.Left,
				new ArrowData(FindChildWidget("Arrow_Left") as UImage)
			},
			{
				EIndicatorType.Right,
				new ArrowData(FindChildWidget("Arrow_Right") as UImage)
			}
		};
	}

	public override void InitSet(IProjInfo InProjData)
	{
		base.InitSet(InProjData);
		if (ProjData is HPProjInfo hPProjInfo)
		{
			FallDyingData = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBUC_FallDyingData>(hPProjInfo.BindedUnit);
			PlayerOnLineRoleData = B1GSUIActorMgr.Get(this).GetBattleDataByActor<DS_IBPC_RoleBaseData>(hPProjInfo.BindedUnit.PlayerState);
		}
	}

	public void SetPlayerInfo(string Username)
	{
		if (!string.IsNullOrEmpty(Username))
		{
			TxtName.SetText(FText.FromString(Username));
		}
	}

	public override void SetHPBarPercent(float Percent, bool IsNow = false, bool IsChangeShow = false)
	{
		ProcBGMat?.SetScalarParameterValue(ParamNamePercent, Percent);
		base.SetHPBarPercent(Percent, IsNow, IsChangeShow);
	}

	protected override void UpdateScrPosAngle(FVector2D ScrPos, float RectAngle)
	{
		base.UpdateScrPosAngle(ScrPos, RectAngle);
		foreach (ArrowData value in Arrows.Values)
		{
			value.ArrowImg.SetRenderTransformAngle(FMath.RadiansToDegrees(RectAngle) + 90f);
		}
	}

	public void HandleChangeBeSaveWaitTime(float BeSaveWaitTime)
	{
		TeamTipsIcon.HandleChangeBeSaveWaitTime(BeSaveWaitTime);
	}

	public void HandleChangeSaveSelfWaitTimePercent(float SaveSelfWaitTimePercent)
	{
		this.SaveSelfWaitTimePercent = SaveSelfWaitTimePercent;
		TeamTipsIcon.HandleChangeSaveSelfWaitTimePercent(SaveSelfWaitTimePercent);
	}

	public void HandleChangeFallDying(bool IsFallDying)
	{
		this.IsFallDying = IsFallDying;
		if (IsFallDying)
		{
			if (CurIndicatorType == EIndicatorType.Top || CurIndicatorType == EIndicatorType.Bottom || CurIndicatorType == EIndicatorType.Middle)
			{
				NameSpacer.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				NameSpacer.SetVisibility(ESlateVisibility.Collapsed);
			}
			FMargin padding = new FMargin
			{
				Top = 0f,
				Bottom = 0f,
				Left = -500f,
				Right = -500f
			};
			TxtNameSlot.SetPadding(padding);
			TeamTipsIconSizeBox.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			NameSpacer.SetVisibility(ESlateVisibility.Collapsed);
			FMargin padding2 = new FMargin
			{
				Top = 0f,
				Bottom = 0f,
				Left = 0f,
				Right = 0f
			};
			TxtNameSlot.SetPadding(padding2);
			TeamTipsIconSizeBox.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public override void SwitchUIStat(EIndicatorType Type)
	{
		base.SwitchUIStat(Type);
		CurIndicatorType = Type;
		HandleChangeFallDying(IsFallDying);
		foreach (KeyValuePair<EIndicatorType, ArrowData> arrow in Arrows)
		{
			if (Type == arrow.Key)
			{
				arrow.Value.ArrowCon.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
			}
			else
			{
				arrow.Value.ArrowCon.SetVisibility(ESlateVisibility.Collapsed);
			}
		}
		if (Type == EIndicatorType.Middle)
		{
			HpSizeBox.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		}
		else
		{
			HpSizeBox.SetVisibility(ESlateVisibility.Collapsed);
		}
	}

	public override void SwitchUIInRound(bool IsInRound)
	{
		base.SwitchUIInRound(IsInRound);
	}

	protected override void OnUIGSInnerTickImpl(float InDeltaTime)
	{
		base.OnUIGSInnerTickImpl(InDeltaTime);
		if (PlayerOnLineRoleData != null)
		{
			SetPlayerInfo(PlayerOnLineRoleData.RoleName);
		}
		if (FallDyingData == null)
		{
			return;
		}
		if (FallDyingData.GetFallDyingState() != EFallDyingState.Alive)
		{
			if (!FallDyingData.GetCanBeSaveByTarget())
			{
				HandleChangeBeSaveWaitTime(FallDyingData.GetFallDyingTime());
			}
			else
			{
				float saveSelfWaitTime = FallDyingData.GetSaveSelfWaitTime();
				int num = BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveSelfWaitTime - BGW_PreloadAssetMgr.Get(this).FallDyingConfigDataAsset.SaveTeammateWaitTime;
				float saveSelfWaitTimePercent = saveSelfWaitTime / (float)num;
				HandleChangeSaveSelfWaitTimePercent(saveSelfWaitTimePercent);
			}
			HandleChangeFallDying(IsFallDying: true);
		}
		else
		{
			HandleChangeFallDying(IsFallDying: false);
		}
	}

	protected void ChangeImageMatInst(UImage Img, string ResPath)
	{
		if (Img.IsNullOrDestroyed())
		{
			BGW_LogUtil.LogError("AsyncLoadForImageInner Img IsNullOrDestroyed, " + ResPath);
			return;
		}
		BGW_PreloadAssetMgr.Get(this).RequestAsyncLoadForUIResource<UMaterialInstanceConstant>(ResPath, EAssetPriority.High, delegate(int ReqID, UObject Obj)
		{
			if (Obj == null)
			{
				BGW_LogUtil.LogError("AsyncLoadForImageInner objects.Count == 0 ResPath:" + ResPath);
			}
			else if (!Img.IsNullOrDestroyed())
			{
				UMaterialInstanceConstant uMaterialInstanceConstant = Obj as UMaterialInstanceConstant;
				if (uMaterialInstanceConstant == null)
				{
					BGW_LogUtil.LogError("AsyncLoadForImageInner To UMaterialInstanceConstant Failed ResPath:" + ResPath);
				}
				else
				{
					Img.SetBrushFromMaterial(uMaterialInstanceConstant);
				}
			}
		});
	}

	public override bool GetIsUseRound()
	{
		return true;
	}

	public override bool GetIsUseHideRound()
	{
		return false;
	}

	public FVector2D GetCalInfoSize()
	{
		return new FVector2D(200.0, 200.0);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BUI_MPlayerInfo");
		InterpSpeed_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "InterpSpeed");
		InterpSpeed_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "InterpSpeed", Classes.FFloatProperty);
	}

	static BUI_MPlayerInfo()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUI_MPlayerInfo)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUI_MPlayerInfo));
	}
}
