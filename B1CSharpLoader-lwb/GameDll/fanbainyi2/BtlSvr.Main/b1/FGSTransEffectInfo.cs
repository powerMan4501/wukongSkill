using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class FGSTransEffectInfo
{
	public bool WaitingDestinationUnit;

	public ACharacter Unit;

	public UNiagaraComponent TransEffect;

	public float Duration;

	public FVector UnitLocation;

	public FGSTransEffectInfo(UNiagaraComponent TransEffect)
	{
		WaitingDestinationUnit = true;
		Unit = null;
		this.TransEffect = TransEffect;
		Duration = -1f;
		UnitLocation = FVector.ZeroVector;
	}
}
