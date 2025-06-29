using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace GSDispLib;

public class PPEffectParametersValue
{
	public float Duration;

	public float BeginningDuration;

	public float FinishingDuration;

	public List<FVector4> VectorParams;

	public List<float> ScalarParams;

	public void CopyValue(UDispLib_PPEffectParameters UParameter)
	{
		if (!(UParameter == null))
		{
			Duration = UParameter.Duration;
			BeginningDuration = UParameter.BeginningDuration;
			FinishingDuration = UParameter.FinishingDuration;
			if (UParameter.VectorParams != null)
			{
				VectorParams = UParameter.VectorParams.ToList();
			}
			if (UParameter.ScalarParams != null)
			{
				ScalarParams = UParameter.ScalarParams.ToList();
			}
		}
	}
}
