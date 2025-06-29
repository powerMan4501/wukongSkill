using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class MagicallyChangeTFXConfig
{
	public TStrongObjectPtr<UTressFXAsset> TFXAsset = new TStrongObjectPtr<UTressFXAsset>();

	public TStrongObjectPtr<UMaterialInterface> HairMaterial = new TStrongObjectPtr<UMaterialInterface>();

	public FTressFXShadeSettings ShadeSettings;

	public float LodScreenSize;

	public bool bEnableSimulation;
}
