using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class MaterialParameterConfig
{
	private TStrongObjectPtr<UCurveFloat> mAttrValueMapCurve = new TStrongObjectPtr<UCurveFloat>();

	private TStrongObjectPtr<UMaterialFunctionInterface> mParameterLayerFunction = new TStrongObjectPtr<UMaterialFunctionInterface>();

	public float InterpSpeed { get; set; }

	public UCurveFloat AttrValueMapCurve
	{
		get
		{
			return mAttrValueMapCurve.Get();
		}
		set
		{
			mAttrValueMapCurve.Set(value);
		}
	}

	public EMaterialParameterAssociation ParameterAssociation { get; set; }

	public FName ParameterName { get; set; }

	public UMaterialFunctionInterface ParameterLayerFunction
	{
		get
		{
			return mParameterLayerFunction.Get();
		}
		set
		{
			mParameterLayerFunction.Set(value);
		}
	}

	public float LastInputValue { get; set; }
}
