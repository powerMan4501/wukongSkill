namespace b1;

public class BGU_IntPropRequest : BGU_PropMgrRequestBase
{
	public int Value { get; private set; }

	public BGU_IntPropRequest(int RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_IntPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_IntPropRequest bGU_IntPropRequest)
		{
			return Value == bGU_IntPropRequest.Value;
		}
		return false;
	}

	public override void Sum(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_IntPropRequest bGU_IntPropRequest)
		{
			Value += bGU_IntPropRequest.Value;
		}
	}

	public override void Mul(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_IntPropRequest bGU_IntPropRequest)
		{
			Value *= bGU_IntPropRequest.Value;
		}
	}
}
