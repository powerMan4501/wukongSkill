using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public struct FUpdateInputWidgetInfoParam
{
	public string ActionName;

	public ETriggerEvent TriggerEvent;

	public UGSInputWidgetCS Widget;

	public FInputDelegate.UIInputActionTrigger Callback;

	public int PageId;
}
