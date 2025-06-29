using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/Engine.EFunctionInputType", "Engine", UnrealModuleType.Engine)]
public enum EFunctionInputType : byte
{
	FunctionInput_Scalar,
	FunctionInput_Vector2,
	FunctionInput_Vector3,
	FunctionInput_Vector4,
	FunctionInput_Texture2D,
	FunctionInput_TextureCube,
	FunctionInput_Texture2DArray,
	FunctionInput_VolumeTexture,
	FunctionInput_StaticBool,
	FunctionInput_MaterialAttributes,
	FunctionInput_TextureExternal,
	FunctionInput_Bool
}
