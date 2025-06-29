using UnrealEngine.Engine;

namespace b1;

public abstract class BUChangeMaterialUnitAttrTemplate
{
	public EChangeMatUnitAttrType AttrType { get; protected set; }

	public virtual float GetAttrValue(AActor Owner)
	{
		return 0f;
	}
}
