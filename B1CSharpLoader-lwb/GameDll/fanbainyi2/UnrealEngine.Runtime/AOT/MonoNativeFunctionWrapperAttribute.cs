using System;

namespace AOT;

[AttributeUsage(AttributeTargets.Delegate)]
public sealed class MonoNativeFunctionWrapperAttribute : Attribute
{
}
