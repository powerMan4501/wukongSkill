using BtlShare;

namespace b1.UI;

public class DSAttrProgBar : DSProgBarInfo
{
	public readonly EBGUAttrFloat AttrFloat;

	public readonly EBGUAttrFloat AttrFloatMax;

	protected B1ActorTag BindTag;

	public readonly GSBindProp<DS_IBUC_AttrContainer> CurAttrContainer = new GSBindProp<DS_IBUC_AttrContainer>();

	protected int AttrBindIdx;

	public DSAttrProgBar(BUI_Widget BindWidget, EBGUAttrFloat InAttrFloat, EBGUAttrFloat InAttrFloatMax)
		: base(BindWidget)
	{
		AttrFloat = InAttrFloat;
		AttrFloatMax = InAttrFloatMax;
		BindValueToCustom(CurAttrContainer, OnChangeCurAttrContainer);
		B1GSUIActorMgr.Get(GetWorldContext()).BindResetActor(OnResetActor);
	}

	public virtual void Init(B1ActorTag InBindTag)
	{
		BindTag = InBindTag;
		DS_IBUC_AttrContainer curAttrContainer = null;
		if (BindTag != B1ActorTag.None)
		{
			curAttrContainer = B1GSUIActorMgr.Get(GetWorldContext()).GetBattleData<DS_IBUC_AttrContainer>(BindTag);
		}
		SetCurAttrContainer(curAttrContainer);
	}

	public override void Clear()
	{
		BindTag = B1ActorTag.None;
		SetCurAttrContainer(null);
	}

	private void OnResetActor(int TagIdx)
	{
		SetBindResId(B1GSUIActorMgr.Get(GetWorldContext()).GetActorResId(BindTag));
		if (TagIdx == (int)BindTag && CurAttrContainer.Value != null)
		{
			SetMaxValue(EChangeReason.Init, CurAttrContainer.Value.GetFloatValue(AttrFloatMax));
			SetValue(EChangeReason.Init, CurAttrContainer.Value.GetFloatValue(AttrFloat));
		}
	}

	private void OnChangeCurAttrContainer(EChangeReason Reason, DS_IBUC_AttrContainer OldValue, DS_IBUC_AttrContainer NewValue)
	{
		OldValue?.UnBindFloatAttrsOnSetIdxValue(AttrBindIdx, OnBindOnSetIdxValueChange);
		if (NewValue != null)
		{
			SetMaxValue(EChangeReason.Init, NewValue.GetFloatValue(AttrFloatMax));
			SetValue(EChangeReason.Init, NewValue.GetFloatValue(AttrFloat));
			AttrBindIdx = NewValue.BindFloatAttrsOnSetIdxValue(OnBindOnSetIdxValueChange);
		}
	}

	protected virtual void OnBindOnSetIdxValueChange(int AttrId, float OldValue, float NewValue)
	{
		if ((int)AttrFloat == AttrId)
		{
			OnAttrChange(AttrFloat, OldValue, NewValue);
		}
		else if ((int)AttrFloatMax == AttrId)
		{
			OnAttrMaxChange(AttrFloatMax, OldValue, NewValue);
		}
	}

	protected virtual void OnAttrMaxChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		SetMaxValue(EChangeReason.ManualSet, NewValue);
	}

	protected virtual void OnAttrChange(EBGUAttrFloat EBGUAttrFloat, float OldValue, float NewValue)
	{
		SetValue(EChangeReason.ManualSet, NewValue);
	}

	public void SetCurAttrContainer(DS_IBUC_AttrContainer NewAttrContainer)
	{
		CurAttrContainer.SetValue(EChangeReason.ManualSet, NewAttrContainer);
	}

	public void SetBindResId(int InBindResId)
	{
		BindResId.SetValue(EChangeReason.ManualSet, InBindResId);
	}

	protected override void OnDestructImpl()
	{
		base.OnDestructImpl();
		CurAttrContainer.SetValue(EChangeReason.Init, null);
		B1GSUIActorMgr.Get(GetWorldContext()).UnBindResetActor(OnResetActor);
	}
}
