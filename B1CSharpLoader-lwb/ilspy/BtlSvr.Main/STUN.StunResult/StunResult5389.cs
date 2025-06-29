using System.Net;
using STUN.Enums;

namespace STUN.StunResult;

public class StunResult5389 : StunResult
{
	public IPEndPoint OtherEndPoint { get; set; }

	public BindingTestResult BindingTestResult { get; set; }

	public MappingBehavior MappingBehavior { get; set; }

	public FilteringBehavior FilteringBehavior { get; set; }

	public void Clone(StunResult5389 result)
	{
		base.PublicEndPoint = result.PublicEndPoint;
		base.LocalEndPoint = result.LocalEndPoint;
		OtherEndPoint = result.OtherEndPoint;
		BindingTestResult = result.BindingTestResult;
		MappingBehavior = result.MappingBehavior;
		FilteringBehavior = result.FilteringBehavior;
	}

	public override void Reset()
	{
		base.Reset();
		OtherEndPoint = null;
		BindingTestResult = BindingTestResult.Unknown;
		MappingBehavior = MappingBehavior.Unknown;
		FilteringBehavior = FilteringBehavior.Unknown;
	}
}
