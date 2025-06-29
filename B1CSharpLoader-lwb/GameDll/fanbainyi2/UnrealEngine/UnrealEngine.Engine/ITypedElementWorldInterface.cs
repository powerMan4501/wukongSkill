using UnrealEngine.Runtime;
using UnrealEngine.TypedElementFramework;
using UnrealEngine.TypedElementRuntime;

namespace UnrealEngine.Engine;

[Abstract]
[UInterface(Flags = 810041505u)]
[BlueprintType]
[Blueprintable]
[UMetaPath("/Script/Engine.TypedElementWorldInterface", "Engine", UnrealModuleType.Engine, InterfaceImpl = typeof(ITypedElementWorldInterfaceImpl))]
public interface ITypedElementWorldInterface : IInterface
{
	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetWorldTransform")]
	bool SetWorldTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetRelativeTransform")]
	bool SetRelativeTransform(FScriptTypedElementHandle InElementHandle, FTransform InTransform);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:SetPivotOffset")]
	bool SetPivotOffset(FScriptTypedElementHandle InElementHandle, FVector InPivotOffset);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementStarted")]
	void NotifyMovementStarted(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementOngoing")]
	void NotifyMovementOngoing(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:NotifyMovementEnded")]
	void NotifyMovementEnded(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:IsTemplateElement")]
	bool IsTemplateElement(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetWorldTransform")]
	bool GetWorldTransform(FScriptTypedElementHandle InElementHandle, out FTransform OutTransform);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetRelativeTransform")]
	bool GetRelativeTransform(FScriptTypedElementHandle InElementHandle, out FTransform OutTransform);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetPivotOffset")]
	bool GetPivotOffset(FScriptTypedElementHandle InElementHandle, out FVector OutPivotOffset);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetOwnerWorld")]
	UWorld GetOwnerWorld(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetOwnerLevel")]
	ULevel GetOwnerLevel(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:GetBounds")]
	bool GetBounds(FScriptTypedElementHandle InElementHandle, out FBoxSphereBounds OutBounds);

	[UFunction(Flags = 79823872u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:DuplicateElement")]
	FScriptTypedElementHandle DuplicateElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, FVector InLocationOffset);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:DeleteElement")]
	bool DeleteElement(FScriptTypedElementHandle InElementHandle, UWorld InWorld, UTypedElementSelectionSet InSelectionSet, FTypedElementDeletionOptions InDeletionOptions);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanMoveElement")]
	bool CanMoveElement(FScriptTypedElementHandle InElementHandle, ETypedElementWorldType InWorldType);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanEditElement")]
	bool CanEditElement(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanDuplicateElement")]
	bool CanDuplicateElement(FScriptTypedElementHandle InElementHandle);

	[UFunction(Flags = 71435264u)]
	[UMetaPath("/Script/Engine.TypedElementWorldInterface:CanDeleteElement")]
	bool CanDeleteElement(FScriptTypedElementHandle InElementHandle);
}
