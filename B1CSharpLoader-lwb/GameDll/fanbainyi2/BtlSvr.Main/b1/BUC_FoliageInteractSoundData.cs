using b1.ECS;

namespace b1;

internal class BUC_FoliageInteractSoundData : IBUC_FoliageInteractSoundData, IPersistentECSData
{
	public EFoliageInteractSoundPriority FoliageInteractSoundPriority { get; set; }
}
