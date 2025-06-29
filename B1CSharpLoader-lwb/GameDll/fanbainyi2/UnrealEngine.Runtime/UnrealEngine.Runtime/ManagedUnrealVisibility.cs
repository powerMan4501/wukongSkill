using System;

namespace UnrealEngine.Runtime;

public static class ManagedUnrealVisibility
{
	public enum Requirement
	{
		None,
		MainAttribute,
		AnyAttribute
	}

	[Flags]
	public enum Type
	{
		None = 0,
		BlueprintType = 1,
		Blueprintable = 2
	}

	[Flags]
	public enum Member
	{
		None = 0,
		BlueprintCallable = 1,
		EditorVisible = 2,
		BlueprintVisible = 4,
		EditorVisibleReadOnly = 8,
		BlueprintVisibleReadOnly = 0x10
	}

	public static readonly Type Class = Type.BlueprintType | Type.Blueprintable;

	public static readonly Type Interface = Type.BlueprintType | Type.Blueprintable;

	public static readonly Type Struct = Type.BlueprintType;

	public static readonly Type Enum = Type.BlueprintType;

	public static readonly Member Members = Member.None;

	public static readonly Requirement ClassRequirement = Requirement.MainAttribute;

	public static readonly Requirement StructRequirement = Requirement.MainAttribute;

	public static readonly Requirement EnumRequirement = Requirement.MainAttribute;

	public static readonly Requirement InterfaceRequirement = Requirement.MainAttribute;

	public static readonly Requirement DelegateRequirement = Requirement.None;

	public static readonly Requirement FunctionRequirement = Requirement.MainAttribute;

	public static readonly Requirement PropertyRequirement = Requirement.MainAttribute;
}
