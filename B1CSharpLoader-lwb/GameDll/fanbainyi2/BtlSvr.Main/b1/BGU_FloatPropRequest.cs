namespace b1;

public class BGU_FloatPropRequest : BGU_PropMgrRequestBase
{
	public float Value { get; private set; }

	public BGU_FloatPropRequest(float RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_FloatPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			return Value == bGU_FloatPropRequest.Value;
		}
		return false;
	}

	public override void Sum(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			Value += bGU_FloatPropRequest.Value;
		}
	}

	public override void Mul(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_FloatPropRequest bGU_FloatPropRequest)
		{
			Value *= bGU_FloatPropRequest.Value;
		}
	}
}
