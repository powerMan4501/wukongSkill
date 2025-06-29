using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1;

public class FSpiderNavPointInfo
{
	public List<FSpiderNavPointLinkInfo> NavLinks = new List<FSpiderNavPointLinkInfo>();

	public FVector PointLocation { get; }

	public FVector PointNormal { get; }

	public float LinkRadius { get; }

	public bool IsGroundPoint { get; }

	public FSpiderNavPointInfo(FVector _PointLocation, FVector _PointNormal, float _LinkRadius, bool _IsGroundPoint)
	{
		PointLocation = _PointLocation;
		PointNormal = _PointNormal;
		LinkRadius = _LinkRadius;
		IsGroundPoint = _IsGroundPoint;
	}

	public FSpiderNavPointInfo(FSpiderNavPointInfo NavPointInfo)
	{
		PointLocation = NavPointInfo.PointLocation;
		PointNormal = NavPointInfo.PointNormal;
		LinkRadius = NavPointInfo.LinkRadius;
		IsGroundPoint = NavPointInfo.IsGroundPoint;
		foreach (FSpiderNavPointLinkInfo navLink in NavPointInfo.NavLinks)
		{
			NavLinks.Add(new FSpiderNavPointLinkInfo(navLink));
		}
	}

	public FSpiderNavPointInfo(FGsSpiderNavPointInfo NavPoint)
	{
		PointLocation = NavPoint.Location;
		PointNormal = NavPoint.Normal;
		LinkRadius = NavPoint.LinkRadius;
		IsGroundPoint = NavPoint.IsGroundPoint;
		foreach (FGsSpiderNavPointLinkInfo navLinkPoint in NavPoint.NavLinkPoints)
		{
			NavLinks.Add(new FSpiderNavPointLinkInfo(navLinkPoint));
		}
	}
}
