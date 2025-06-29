using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method | AttributeTargets.Property)]
public class BlueprintGetterAttribute : ManagedUnrealAttributeBase
{
	public string FunctionName { get; set; }

	public override bool HasMetaData => true;

	public BlueprintGetterAttribute()
	{
	}

	public BlueprintGetterAttribute(string functionName)
	{
		FunctionName = functionName;
	}

	public override void SetMetaData(Dictionary<FName, string> metadata)
	{
		metadata[UMeta.GetKeyName(MDFunc.BlueprintGetter)] = FunctionName;
	}

	public override void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
		if (string.IsNullOrEmpty(FunctionName))
		{
			SetInvalidTarget("BlueprintGetter specified on a property but the function name was not provided");
		}
		propertyInfo.Flags |= EPropertyFlags.BlueprintVisible;
		propertyInfo.AdditionalFlags |= ManagedUnrealPropertyFlags.BlueprintGetter;
	}

	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		if (!string.IsNullOrEmpty(FunctionName))
		{
			SetInvalidTarget("BlueprintGetter specified on a function with an unexpected function name (shouldn't be used)");
		}
		functionInfo.Flags |= EFunctionFlags.BlueprintCallable;
		functionInfo.Flags |= EFunctionFlags.BlueprintPure;
		functionInfo.AdditionalFlags |= ManagedUnrealFunctionFlags.BlueprintGetter;
	}
}
