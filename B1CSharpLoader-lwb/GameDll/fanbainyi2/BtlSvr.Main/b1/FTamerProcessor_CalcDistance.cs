using System;
using UnrealEngine.Runtime;

namespace b1;

public class FTamerProcessor_CalcDistance : FTamerProcessorBase
{
	public override EProcessorSequence ProcessorSequence => EProcessorSequence.CalcDistance;

	protected override void Process(ref FTamerProcessorContext InContext)
	{
		float num = -1f;
		float num2 = -1f;
		FTamerRef currentProcessedTamer = InContext.CurrentProcessedTamer;
		foreach (FVector2D allPlayerLocation2D in InContext.AllPlayerLocation2Ds)
		{
			float num3 = (currentProcessedTamer.Location2D - allPlayerLocation2D).Size() / 100f;
			num = ((!(num < 0f)) ? Math.Min(num3, num) : num3);
		}
		num = FMath.Clamp(num - currentProcessedTamer.CapsuleRadius / 100f, 0f, num);
		foreach (float allPlayerLocationZ in InContext.AllPlayerLocationZs)
		{
			float num4 = Math.Abs(currentProcessedTamer.LocationZ - allPlayerLocationZ) / 100f;
			num2 = ((!(num2 < 0f)) ? Math.Min(num4, num2) : num4);
		}
		num2 = FMath.Clamp(num2 - currentProcessedTamer.CapsuleHalfHeight / 100f, 0f, num2);
		currentProcessedTamer.LastCalcDistance = new FVector2D(num, num2);
		currentProcessedTamer.LastScore = 1f / FMath.Abs(num) * 100f;
	}
}
