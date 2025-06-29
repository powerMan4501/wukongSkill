using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class MatParamInfoForData
{
	public FName ParameterName;

	private TStrongObjectPtr<UCurveFloat> mFloatCurve = new TStrongObjectPtr<UCurveFloat>();

	public UCurveFloat FloatCurve
	{
		get
		{
			return mFloatCurve.Get();
		}
		set
		{
			mFloatCurve.Set(value);
		}
	}

	public MatParamInfoForData(in FMatParamInfo MPI)
	{
		ParameterName = MPI.ParameterName;
		FloatCurve = MPI.FloatCurve;
	}
}
