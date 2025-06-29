using b1.Prediction;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.EnhancedInput;

namespace b1;

public abstract class BUInputActionTemplate
{
	protected EInputActionType InputActionType;

	private UGameInstance WorldContext;

	protected static float INV1000 = 0.001f;

	public bool TriggerInputAction(UGameInstance InWorldContext, int InputActionID, ETriggerEvent TriggerEvent, FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		WorldContext = InWorldContext;
		return OnTriggerInputAction(InputActionID, TriggerEvent, ref Value, PredictionKey);
	}

	protected AActor GetOwner()
	{
		return UGameplayStatics.GetPlayerCharacter(WorldContext, 0);
	}

	protected virtual bool OnTriggerInputAction(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		return false;
	}

	public bool TriggerInputActionPredict(UGameInstance InWorldContext, int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		WorldContext = InWorldContext;
		return OnTriggerInputActionPredict(InputActionID, TriggerEvent, ref Value, PredictionKey);
	}

	public bool TriggerValuePredict(UGameInstance InWorldContext, int InputActionID, ETriggerEvent TriggerEvent, float Value)
	{
		WorldContext = InWorldContext;
		return OnTriggerValuePredict(InputActionID, TriggerEvent, Value);
	}

	protected virtual bool OnTriggerInputActionPredict(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value, GSPredictionKey PredictionKey)
	{
		return false;
	}

	protected virtual bool OnTriggerValuePredict(int InputActionID, ETriggerEvent TriggerEvent, float Value)
	{
		return false;
	}

	public bool TriggerInputActionRollBack(UGameInstance InWorldContext, int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value)
	{
		WorldContext = InWorldContext;
		return OnTriggerInputActionRollBack(InputActionID, TriggerEvent, ref Value);
	}

	public bool TriggerValueRollBack(UGameInstance InWorldContext, int InputActionID, ETriggerEvent TriggerEvent, float Value)
	{
		WorldContext = InWorldContext;
		return OnTriggerValueRollBack(InputActionID, TriggerEvent, Value);
	}

	protected virtual bool OnTriggerInputActionRollBack(int InputActionID, ETriggerEvent TriggerEvent, ref FInputActionValue Value)
	{
		return false;
	}

	protected virtual bool OnTriggerValueRollBack(int InputActionID, ETriggerEvent TriggerEvent, float Value)
	{
		return false;
	}
}
