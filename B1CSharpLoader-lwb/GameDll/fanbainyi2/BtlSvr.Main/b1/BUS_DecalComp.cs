using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

internal class BUS_DecalComp : UActorCompBaseCS
{
	public override void PreBeginPlay()
	{
		UClass uClass = UClass.GetClass<UPrimitiveComponent>();
		foreach (UActorComponent item in GetOwner().GetComponentsByClass(uClass))
		{
			UPrimitiveComponent uPrimitiveComponent = item as UPrimitiveComponent;
			if (uPrimitiveComponent != null)
			{
				uPrimitiveComponent.SetReceivesDecals(bNewReceivesDecals: false);
			}
		}
	}
}
