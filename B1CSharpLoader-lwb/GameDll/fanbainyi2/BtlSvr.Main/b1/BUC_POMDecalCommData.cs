using UnrealEngine.Runtime;

namespace b1;

public class BUC_POMDecalCommData
{
	public FRotator LastRot;

	public BUC_POMDecalCommData()
	{
		LastRot = default(FRotator);
	}

	public bool POMRotHasChange(FRotator CurRot)
	{
		if (!LastRot.Equals(CurRot))
		{
			LastRot = CurRot;
			return true;
		}
		return false;
	}
}
