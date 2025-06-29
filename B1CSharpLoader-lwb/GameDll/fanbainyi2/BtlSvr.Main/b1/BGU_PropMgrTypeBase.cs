namespace b1;

public abstract class BGU_PropMgrTypeBase
{
	protected EPropType PropType { get; set; }

	public EPropCalcRule CalcRule { get; protected set; }

	public bool bCompositeProp { get; protected set; }

	public abstract void SetDefaultProperty(BUS_GSEventCollection EvtCollection);

	public abstract void HandlePropertyRequest(BGU_PropMgrRequestBase Request, BUS_GSEventCollection EvtCollection);
}
