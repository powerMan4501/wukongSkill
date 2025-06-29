using UnrealEngine.Runtime;

namespace UnrealEngine.Engine;

public static class UMaterialLibrary_CsExtensions
{
	public static void SetVectorParameterValue(this UWorld WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, FLinearColor ParameterValue)
	{
		UMaterialLibrary.SetVectorParameterValue(WorldContextObject, Collection, ParameterName, ParameterValue);
	}

	public static void SetScalarParameterValue(this UWorld WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName, float ParameterValue)
	{
		UMaterialLibrary.SetScalarParameterValue(WorldContextObject, Collection, ParameterName, ParameterValue);
	}

	public static FLinearColor GetVectorParameterValue(this UWorld WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
	{
		return UMaterialLibrary.GetVectorParameterValue(WorldContextObject, Collection, ParameterName);
	}

	public static float GetScalarParameterValue(this UWorld WorldContextObject, UMaterialParameterCollection Collection, FName ParameterName)
	{
		return UMaterialLibrary.GetScalarParameterValue(WorldContextObject, Collection, ParameterName);
	}

	public static UMaterialInstanceDynamic CreateDynamicMaterialInstance(this UWorld WorldContextObject, UMaterialInterface Parent, FName OptionalName, EMIDCreationFlags CreationFlags)
	{
		return UMaterialLibrary.CreateDynamicMaterialInstance(WorldContextObject, Parent, OptionalName, CreationFlags);
	}
}
