namespace b1;

public class BGU_BoolBoolPropRequest : BGU_PropMgrRequestBase
{
	public bool Value1 { get; private set; }

	public bool Value2 { get; private set; }

	public BGU_BoolBoolPropRequest(bool RequestValue1, bool RequestValue2)
	{
		Value1 = RequestValue1;
		Value2 = RequestValue2;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_BoolBoolPropRequest(Value1, Value2);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolBoolPropRequest bGU_BoolBoolPropRequest && Value1 == bGU_BoolBoolPropRequest.Value1)
		{
			return Value2 == bGU_BoolBoolPropRequest.Value2;
		}
		return false;
	}

	public override void And(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolBoolPropRequest bGU_BoolBoolPropRequest)
		{
			Value1 = Value1 && bGU_BoolBoolPropRequest.Value1;
			Value2 = Value2 && bGU_BoolBoolPropRequest.Value2;
		}
	}

	public override void Or(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolBoolPropRequest bGU_BoolBoolPropRequest)
		{
			Value1 = Value1 || bGU_BoolBoolPropRequest.Value1;
			Value2 = Value2 || bGU_BoolBoolPropRequest.Value2;
		}
	}
}
