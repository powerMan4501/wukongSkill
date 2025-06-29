using b1;

namespace GSDispLib;

public class BWS_DispLibCompBase : UActorCompBaseCS
{
	protected BWS_DispLibEventCollection BWSDispLibEventCollection => BWS_DispLibEventCollection.Get(this);

	public override void OnAttach()
	{
		base.OnAttach();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}
}
