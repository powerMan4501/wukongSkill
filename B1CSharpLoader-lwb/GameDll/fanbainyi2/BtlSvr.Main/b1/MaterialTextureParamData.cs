using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public struct MaterialTextureParamData
{
	public FName ParamName;

	public UTexture Value;

	public MaterialTextureParamData(FName Name, UTexture InValue)
	{
		ParamName = Name;
		Value = InValue;
	}
}
