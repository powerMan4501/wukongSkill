using b1;

namespace GSDispLib;

public class BUS_DispLibCompBase : UActorCompBaseCS
{
	protected BUS_DispLibEventCollection DispLibEventCollection => BUS_DispLibEventCollection.Get(this);

	protected BUS_GSEventCollection GamePlayEventCollection => base.BUSEventCollection;

	public override void OnAttach()
	{
		base.OnAttach();
	}

	public override void OnBeginPlay()
	{
		base.OnBeginPlay();
	}
}
