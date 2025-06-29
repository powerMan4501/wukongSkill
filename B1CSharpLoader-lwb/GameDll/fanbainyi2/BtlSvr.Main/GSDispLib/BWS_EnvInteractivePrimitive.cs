using UnrealEngine.Engine;

namespace GSDispLib;

public class BWS_EnvInteractivePrimitive : BWS_EnvInteractiveItem
{
	public UPrimitiveComponent PrimtiveComp;

	public override bool OnTick()
	{
		Position = PrimtiveComp.GetWorldLocation();
		if (!PrimtiveComp.IsVisible())
		{
			return PrimtiveComp.IsCollisionEnabled();
		}
		return true;
	}
}
