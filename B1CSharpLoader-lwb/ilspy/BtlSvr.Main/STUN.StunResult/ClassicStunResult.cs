using STUN.Enums;

namespace STUN.StunResult;

public class ClassicStunResult : StunResult
{
	public NatType NatType { get; set; }

	public void Clone(ClassicStunResult result)
	{
		base.PublicEndPoint = result.PublicEndPoint;
		base.LocalEndPoint = result.LocalEndPoint;
		NatType = result.NatType;
	}

	public override void Reset()
	{
		base.Reset();
		NatType = NatType.Unknown;
	}
}
