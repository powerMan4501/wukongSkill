using System;
using System.Collections.Generic;

namespace UnrealEngine.Runtime;

public abstract class ManagedUnrealAttributeBase : Attribute
{
	public virtual bool HasMetaData => false;

	public bool InvalidTarget { get; set; }

	public string InvalidTargetReason { get; protected set; }

	protected void SetInvalidTarget(string reason)
	{
		InvalidTarget = true;
		InvalidTargetReason = reason;
	}

	public virtual void ProcessType(ManagedUnrealTypeInfo typeInfo)
	{
	}

	public virtual void ProcessClass(ManagedUnrealTypeInfo typeInfo)
	{
		ProcessType(typeInfo);
	}

	public virtual void ProcessStruct(ManagedUnrealTypeInfo typeInfo)
	{
		ProcessType(typeInfo);
	}

	public virtual void ProcessInterface(ManagedUnrealTypeInfo typeInfo)
	{
		ProcessType(typeInfo);
	}

	public virtual void ProcessEnum(ManagedUnrealTypeInfo typeInfo)
	{
		ProcessType(typeInfo);
	}

	public virtual void ProcessDelegate(ManagedUnrealTypeInfo typeInfo)
	{
		ProcessType(typeInfo);
	}

	public virtual void ProcessFunction(ManagedUnrealFunctionInfo functionInfo)
	{
	}

	public virtual void ProcessFunctionParams(ManagedUnrealFunctionInfo functionInfo)
	{
		foreach (ManagedUnrealPropertyInfo item in functionInfo.Params)
		{
			ProcessProperty(item);
		}
		if (functionInfo.ReturnProp != null)
		{
			ProcessProperty(functionInfo.ReturnProp);
		}
	}

	public virtual void ProcessProperty(ManagedUnrealPropertyInfo propertyInfo)
	{
	}

	public virtual void SetMetaData(Dictionary<FName, string> metadata)
	{
	}
}
