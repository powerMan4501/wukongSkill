namespace b1;

public class BGU_BoolPropRequest : BGU_PropMgrRequestBase
{
	public bool Value { get; private set; }

	public BGU_BoolPropRequest(bool RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_BoolPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			return Value == bGU_BoolPropRequest.Value;
		}
		return false;
	}

	public override void And(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			Value = Value && bGU_BoolPropRequest.Value;
		}
	}

	public override void Or(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_BoolPropRequest bGU_BoolPropRequest)
		{
			Value = Value || bGU_BoolPropRequest.Value;
		}
	}
}
