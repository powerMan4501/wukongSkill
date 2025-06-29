using System;

namespace UnrealEngine.Runtime;

[AttributeUsage(AttributeTargets.All, AllowMultiple = true)]
public abstract class UUnrealTypePathAttribute : Attribute
{
	public string Path;

	public Type InterfaceImpl;

	public virtual bool IsManagedType => false;
}
