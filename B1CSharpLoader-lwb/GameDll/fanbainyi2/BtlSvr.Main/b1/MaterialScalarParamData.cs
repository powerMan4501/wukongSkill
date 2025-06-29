using UnrealEngine.Runtime;

namespace b1;

public struct MaterialScalarParamData
{
	public FName ParamName;

	public float Value;

	public MaterialScalarParamData(FName Name, float InValue)
	{
		ParamName = Name;
		Value = InValue;
	}
}
