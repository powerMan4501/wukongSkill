namespace b1.Prediction;

public interface IPredictableObject
{
	void OnRollback(GSPredictionKey PredictionKey);

	void OnConfirm(GSPredictionKey PredictionKey);
}
