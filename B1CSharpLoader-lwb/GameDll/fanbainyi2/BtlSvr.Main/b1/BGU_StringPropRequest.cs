namespace b1;

public class BGU_StringPropRequest : BGU_PropMgrRequestBase
{
	public string Value { get; private set; }

	public BGU_StringPropRequest(string RequestValue)
	{
		Value = RequestValue;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_StringPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_StringPropRequest bGU_StringPropRequest)
		{
			return Value.Equals(bGU_StringPropRequest.Value);
		}
		return false;
	}
}
