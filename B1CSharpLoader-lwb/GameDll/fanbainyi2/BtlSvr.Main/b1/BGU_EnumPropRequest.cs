namespace b1;

public class BGU_EnumPropRequest : BGU_PropMgrRequestBase
{
	public int Value { get; private set; }

	public BGU_EnumPropRequest(int RequestValue, string _ResourceInfo = "")
	{
		Value = RequestValue;
		ResourceInfo = _ResourceInfo;
	}

	public override BGU_PropMgrRequestBase Clone()
	{
		return new BGU_EnumPropRequest(Value);
	}

	public override bool Equals(BGU_PropMgrRequestBase Other)
	{
		if (Other is BGU_EnumPropRequest bGU_EnumPropRequest)
		{
			return Value == bGU_EnumPropRequest.Value;
		}
		return false;
	}
}
