using b1.UI.Comm;
using B1UI.GSUI;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class MapSymbolData : UIBindData
{
	protected DSMapSymbol DataStore;

	protected UCanvasPanelSlot MapSymbolWidgetSlot;

	protected UWidget MapSymbolWidget;

	protected static readonly FName MatParamNameTexIndex = new FName("TexIndex");

	protected static readonly FName MatParamNameIsHovered = new FName("IsHovered");

	protected static readonly FName MatParamNameIsFocused = new FName("IsFocused");

	protected static readonly FName MatParamNameIsDisabled = new FName("IsDisabled");

	protected static readonly FName MatParamNameIsCurLayer = new FName("isCurLayer");

	protected static readonly FName MatParamNameShrineType = new FName("ShrineType");

	protected FVector2D OriSize;

	protected UImage SymbolImg => MapSymbolWidget as UImage;

	protected BUI_Button SymbolBtn => MapSymbolWidget as BUI_Button;

	public MapSymbolData(UIBindData ParentData, UWidget InMapSymbolWidget)
		: base(ParentData)
	{
		Init(InMapSymbolWidget);
	}

	protected virtual void Init(UWidget InMapSymbolWidget)
	{
		MapSymbolWidget = InMapSymbolWidget;
		MapSymbolWidgetSlot = MapSymbolWidget.Slot as UCanvasPanelSlot;
		if (MapSymbolWidgetSlot != null)
		{
			OriSize = MapSymbolWidgetSlot.GetSize();
		}
	}

	public virtual void InitDataStore(DSMapSymbol InDataStore)
	{
		ReleaseBindAction();
		DataStore = InDataStore;
		BindValueToCustom(DataStore.Id, OnChangeId);
		BindValueToCustom(DataStore.MapPos, OnChangeMapPos);
		BindValueToCustom(DataStore.MapWidgetDStore.MapBasePos, OnChangeMapPos);
		BindValueToCustom(DataStore.StateParams, OnChangStateParams);
		BindValueToCustom(DataStore.IsHovered, OnChangeIsHovered);
		BindValueToCustom(DataStore.IsFocused, OnChangeIsFocused);
		BindValueToCustom(DataStore.IsVisable, OnChangeIsVisable);
		BindValueToCustom(DataStore.Scale, OnChangeScale);
		BindValueToCustom(DataStore.FocusScale, OnChangeFocusScale);
		BindValueToCustom(DataStore.Size, OnChangeSize);
		BindValueToCustom(DataStore.Angle, OnChangeAngle);
	}

	public virtual void Release()
	{
		DataStore.SetIsVisable(InIsVisable: false);
		ReleaseBindAction();
		DataStore = null;
	}

	private void OnChangeId(EChangeReason Reason, int OldValue, int NewValue)
	{
		switch (DataStore.MapSymbolType.Value)
		{
		case EMapSymbolType.RebirthPoint:
		{
			FUStRebirthPointDesc fUStRebirthPointDesc = GameDBRuntime.GetFUStRebirthPointDesc(NewValue);
			if (fUStRebirthPointDesc != null && SymbolImg != null)
			{
				SymbolImg.GetDynamicMaterial()?.SetScalarParameterValue(MatParamNameShrineType, (fUStRebirthPointDesc.IsZhaoHunFan == EGSYesNo.Yes) ? 1 : 0);
			}
			break;
		}
		case EMapSymbolType.Npc:
			UIAssetLoadHelper.AsyncLoadTexToSetImgMatParam(RootWidget, SymbolImg, GSUIResPathUtil.GetMapNPCMarkerPath(NewValue));
			break;
		}
	}

	protected virtual void OnChangeMapPos(EChangeReason Reason, FVector2D OldValue, FVector2D NewValue)
	{
		MapSymbolWidgetSlot?.SetPosition(DataStore.MapWidgetDStore.GetOriginMapPos(DataStore.MapPos.Value) + DataStore.MapWidgetDStore.MapBasePos.Value);
	}

	private void OnChangStateParams(EChangeReason Reason, int OldValue, int NewValue)
	{
		if (SymbolImg != null)
		{
			UMaterialInstanceDynamic dynamicMaterial = SymbolImg.GetDynamicMaterial();
			switch (DataStore.MapSymbolType.Value)
			{
			case EMapSymbolType.Pin:
				dynamicMaterial?.SetScalarParameterValue(MatParamNameTexIndex, NewValue + 1);
				break;
			case EMapSymbolType.Player:
				dynamicMaterial?.SetScalarParameterValue(MatParamNameIsCurLayer, NewValue);
				break;
			}
		}
	}

	private void OnChangeIsHovered(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UImage symbolImg = SymbolImg;
		if (symbolImg != null)
		{
			symbolImg.GetDynamicMaterial()?.SetScalarParameterValue(MatParamNameIsHovered, NewValue ? 1 : 0);
		}
	}

	private void OnChangeIsFocused(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		UImage symbolImg = SymbolImg;
		if (symbolImg != null)
		{
			symbolImg.GetDynamicMaterial()?.SetScalarParameterValue(MatParamNameIsFocused, NewValue ? 1 : 0);
		}
		UpdateScale();
	}

	private void OnChangeIsVisable(EChangeReason Reason, bool OldValue, bool NewValue)
	{
		MapSymbolWidget?.SetVisibility((!NewValue) ? ESlateVisibility.Collapsed : ESlateVisibility.SelfHitTestInvisible);
	}

	private void OnChangeScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		UpdateScale();
	}

	private void OnChangeFocusScale(EChangeReason Reason, float OldValue, float NewValue)
	{
		UpdateScale();
	}

	private void UpdateScale()
	{
		float num = DataStore.MapWidgetDStore.CalMapScale();
		if (num > 0f)
		{
			if (DataStore.IsFocused.Value)
			{
				DataStore.SetSize(OriSize * DataStore.Scale.Value * DataStore.FocusScale.Value / num);
			}
			else
			{
				DataStore.SetSize(OriSize * DataStore.Scale.Value / num);
			}
		}
	}

	private void OnChangeSize(EChangeReason Reason, FVector2D OldValue, FVector2D NewValue)
	{
		MapSymbolWidgetSlot?.SetSize(NewValue);
	}

	private void OnChangeAngle(EChangeReason Reason, float OldValue, float NewValue)
	{
		MapSymbolWidget?.SetRenderTransformAngle(NewValue);
	}

	public UWidget GetWidget()
	{
		return MapSymbolWidget;
	}

	protected override void OnDestructImpl()
	{
	}
}
