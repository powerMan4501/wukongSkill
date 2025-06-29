using System.Collections.Generic;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;

namespace b1;

public class SetCurveValueToHairUnitInfo
{
	public EGSHairType HairType;

	public List<FGSFloatCurveToParam> FloatCurveParamList;

	public List<UTressFXComponent> TressFXCompList;

	public List<UMeshComponent> HairStrandsCompList;

	public float CurTime;

	public float TotalTime;

	public SetCurveValueToHairUnitInfo()
	{
		FloatCurveParamList = new List<FGSFloatCurveToParam>();
		TressFXCompList = new List<UTressFXComponent>();
		HairStrandsCompList = new List<UMeshComponent>();
	}
}
