using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1.GSMUI;

public interface IGSSetCommParams : IGSMUITickable
{
	UWidget GetWidget();

	UObject GetWorldContext();

	UMaterialInstanceDynamic GetMaterial();

	void UpdateRandomParams();
}
