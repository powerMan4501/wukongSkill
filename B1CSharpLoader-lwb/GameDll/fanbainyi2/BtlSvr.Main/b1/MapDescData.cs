using b1.UI;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

public class MapDescData : UIBindData
{
	private DSMapSymbol DataStore;

	private BUI_Widget MapDescWidget;

	private UTextBlock TxtDesc;

	public MapDescData(BUI_Widget InMapDescWidget)
		: base(InMapDescWidget)
	{
		MapDescWidget = InMapDescWidget;
		MapDescWidget = UGSE_UMGFuncLib.CloneUserWidget(InMapDescWidget, FName.None) as BUI_Widget;
		InMapDescWidget.GetParent().AddChild(MapDescWidget);
		GSUIPanelSlotHelper.WidgetSlotCopy(MapDescWidget, InMapDescWidget);
		MapDescWidget.SetVisibility(ESlateVisibility.SelfHitTestInvisible);
		TxtDesc = UGSE_UMGFuncLib.GetWidgetFromName(MapDescWidget, new FName("TxtDesc")) as UTextBlock;
	}

	public void InitDataStore(DSMapSymbol InDataStore)
	{
		ReleaseBindAction();
		DataStore = InDataStore;
		BindValueToCustom(DataStore.Name, OnChangeName);
	}

	private void OnChangeName(EChangeReason Reason, FText OldValue, FText NewValue)
	{
		TxtDesc?.SetText(NewValue);
	}

	public UWidget GetWidget()
	{
		return MapDescWidget;
	}

	protected override void OnDestructImpl()
	{
	}
}
