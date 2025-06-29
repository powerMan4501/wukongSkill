using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.Method)]
public class UFunctionAttribute : ManagedUnrealAttributeBase
{
	public uint Flags { get; set; }

	public string OriginalName { get; set; }

	public override void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
		if (!string.IsNullOrEmpty(OriginalName))
		{
			functionInfo.OriginalName = OriginalName;
		}
		functionInfo.AdditionalFlags |= ManagedUnrealFunctionFlags.UFunction;
		functionInfo.Flags |= (EFunctionFlags)Flags;
	}
}
