using UnrealEngine.Runtime;

namespace b1;

public struct MaterialVectorParamData
{
	public FName ParamName;

	public FLinearColor Value;

	public MaterialVectorParamData(FName Name, FLinearColor InValue)
	{
		ParamName = Name;
		Value = InValue;
	}
}
