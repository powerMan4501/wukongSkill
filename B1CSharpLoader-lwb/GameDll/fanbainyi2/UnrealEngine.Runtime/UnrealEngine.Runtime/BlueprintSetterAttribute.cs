using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class BlueprintSetterAttribute : ManagedUnrealAttributeBase
{
	public string FunctionName { get; set; }

	public override bool HasMetaData => true;

	public BlueprintSetterAttribute(string functionName)
	{
		FunctionName = functionName;
	}

	public override void SetMetaData(Dictionary<FName, string> metadata)
	{
		metadata[UMeta.GetKeyName(MDFunc.BlueprintSetter)] = FunctionName;
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		if (string.IsNullOrEmpty(FunctionName))
		{
			SetInvalidTarget("BlueprintSetter specified on a property but the function name was not provided");
		}
		propertyInfo.AdditionalFlags |= ManagedUnrealPropertyFlags.BlueprintSetter;
	}

	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		if (!string.IsNullOrEmpty(FunctionName))
		{
			SetInvalidTarget("BlueprintSetter specified on a function with an unexpected function name (shouldn't be used)");
		}
		functionInfo.Flags |= EFunctionFlags.BlueprintCallable;
		functionInfo.AdditionalFlags |= ManagedUnrealFunctionFlags.BlueprintSetter;
	}
}
