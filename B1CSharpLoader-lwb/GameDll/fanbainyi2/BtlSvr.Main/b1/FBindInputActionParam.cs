using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public struct FBindInputActionParam
{
	public string ActionName;

	public ETriggerEvent TriggerEvent;

	public FInputDelegate.InputActionTrigger Callback;

	public EnhancedInputActionType InputActionType;

	public EnhancedInputActionType InputActionRefType;

	public FInputMappingContextProcessor InputMappingContextProcessor;
}
