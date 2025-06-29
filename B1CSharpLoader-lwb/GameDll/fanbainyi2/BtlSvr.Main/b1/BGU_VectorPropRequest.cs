using UnrealEngine.Runtime;

namespace b1;

public class BGU_VectorPropRequest : BGU_PropMgrRequestBase
{
	public FVector Value { get; private set; }

	public BGU_VectorPropRequest(in FVector RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_VectorPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_VectorPropRequest bGU_VectorPropRequest)
		{
			return Value == bGU_VectorPropRequest.Value;
		}
		return false;
	}

	public override void Sum(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_VectorPropRequest bGU_VectorPropRequest)
		{
			Value += bGU_VectorPropRequest.Value;
		}
	}
}
