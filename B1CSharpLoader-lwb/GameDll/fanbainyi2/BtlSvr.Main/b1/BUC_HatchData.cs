using b1.ECS;

namespace b1;

internal class BUC_HatchData : b1.IBUC_HatchData, IPersistentECSData
{
	public FHatchConfigInfo ConfigInfo;

	public FHatchConfigInfo GetHatchConfig()
	{
		return ConfigInfo;
	}
}
