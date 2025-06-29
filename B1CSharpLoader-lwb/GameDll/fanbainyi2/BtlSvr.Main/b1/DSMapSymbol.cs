using UnrealEngine.Runtime;

namespace b1;

public class DSMapSymbol : UIBindData
{
	public readonly GSBindProp<int> Id = new GSBindProp<int>();

	public readonly GSBindProp<FText> Name = new GSBindProp<FText>();

	public readonly GSBindProp<EMapSymbolType> MapSymbolType = new GSBindProp<EMapSymbolType>();

	public readonly GSBindProp<int> StateParams = new GSBindProp<int>();

	public readonly GSBindProp<bool> IsVisable = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsFocused = new GSBindProp<bool>();

	public readonly GSBindProp<bool> IsHovered = new GSBindProp<bool>();

	public readonly GSBindProp<float> Angle = new GSBindProp<float>();

	public readonly GSBindProp<float> Scale = new GSBindProp<float>();

	public readonly GSBindProp<float> FocusScale = new GSBindProp<float>();

	public readonly GSBindProp<FVector2D> Size = new GSBindProp<FVector2D>();

	public readonly GSBindProp<FVector2D> MapPos = new GSBindProp<FVector2D>();

	public string Guid => CalGuid(MapSymbolType.Value, Id.Value);

	public DSMapWidget MapWidgetDStore => ParentData as DSMapWidget;

	public static string CalGuid(EMapSymbolType InMapSymbolType, int InId)
	{
		return $"{InMapSymbolType}_{InId}";
	}

	public DSMapSymbol(DSMapWidget ParentData, EMapSymbolType InMapSymbolType, int InId)
		: base(ParentData)
	{
		MapSymbolType.InitForEnumBugFix(InMapSymbolType);
		Id.InitForEnumBugFix(InId);
		Name.InitForEnumBugFix(FText.FromString(Guid));
		Angle.InitForEnumBugFix(0f);
		Scale.InitForEnumBugFix(1f);
		FocusScale.InitForEnumBugFix(1f);
	}

	public void SetName(FText InName)
	{
		Name.SetValue(EChangeReason.ManualSet, InName);
	}

	public void SetMapSymbolType(EMapSymbolType InMapSymbolType)
	{
		MapSymbolType.SetValue(EChangeReason.ManualSet, InMapSymbolType);
	}

	public void SetStateParams(int InStateParams)
	{
		StateParams.SetValue(EChangeReason.ManualSet, InStateParams);
	}

	public void SetScale(float InScale)
	{
		Scale.SetValue(EChangeReason.ManualSet, InScale);
	}

	public void SetFocusScale(float InFocusScale)
	{
		FocusScale.SetValue(EChangeReason.ManualSet, InFocusScale);
	}

	public void SetSize(FVector2D InSize)
	{
		Size.SetValue(EChangeReason.ManualSet, InSize);
	}

	public void SetAngle(float InAngle)
	{
		Angle.SetValue(EChangeReason.ManualSet, InAngle);
	}

	public void SetIsHovered(bool InIsHovered)
	{
		IsHovered.SetValue(EChangeReason.ManualSet, InIsHovered);
	}

	public void SetIsFocused(bool InIsFocused)
	{
		IsFocused.SetValue(EChangeReason.ManualSet, InIsFocused);
	}

	public void SetIsVisable(bool InIsVisable)
	{
		IsVisable.SetValue(EChangeReason.ManualSet, InIsVisable);
	}

	public void SetMapPos(FVector2D InMapPos)
	{
		MapPos.SetValue(EChangeReason.ManualSet, InMapPos);
	}

	public bool GetCanShowDesc()
	{
		if (MapSymbolType.Value == EMapSymbolType.Player || MapSymbolType.Value == EMapSymbolType.Npc || MapSymbolType.Value == EMapSymbolType.Pin)
		{
			return false;
		}
		if (Name.Value == null || Name.Value.IsEmpty())
		{
			return false;
		}
		return true;
	}
}
