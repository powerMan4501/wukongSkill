using UnrealEngine.Runtime;

namespace UnrealEngine.RigVMDeveloper;

[UEnum]
[BlueprintType]
[UMetaPath("/Script/RigVMDeveloper.ERigVMGraphNotifType", "RigVMDeveloper", UnrealModuleType.Engine)]
public enum ERigVMGraphNotifType : byte
{
	GraphChanged,
	NodeAdded,
	NodeRemoved,
	NodeSelected,
	NodeDeselected,
	NodeSelectionChanged,
	NodePositionChanged,
	NodeSizeChanged,
	NodeColorChanged,
	PinAdded,
	PinRemoved,
	PinRenamed,
	PinExpansionChanged,
	PinWatchedChanged,
	PinArraySizeChanged,
	PinDefaultValueChanged,
	PinDirectionChanged,
	PinTypeChanged,
	PinIndexChanged,
	LinkAdded,
	LinkRemoved,
	CommentTextChanged,
	RerouteCompactnessChanged,
	VariableAdded,
	VariableRemoved,
	VariableRenamed,
	ParameterAdded,
	ParameterRemoved,
	ParameterRenamed,
	InteractionBracketOpened,
	InteractionBracketClosed,
	InteractionBracketCanceled,
	PinBoundVariableChanged,
	NodeRenamed,
	NodeReferenceChanged,
	NodeCategoryChanged,
	NodeKeywordsChanged,
	NodeDescriptionChanged,
	VariableRemappingChanged,
	Invalid
}
