using UnrealEngine.Runtime;

namespace b1;

public class BGU_RotatorPropRequest : BGU_PropMgrRequestBase
{
	public FRotator Value { get; private set; }

	public BGU_RotatorPropRequest(in FRotator RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_RotatorPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_RotatorPropRequest bGU_RotatorPropRequest)
		{
			return Value == bGU_RotatorPropRequest.Value;
		}
		return false;
	}

	public override void Sum(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_RotatorPropRequest bGU_RotatorPropRequest)
		{
			Value += bGU_RotatorPropRequest.Value;
		}
	}
}
