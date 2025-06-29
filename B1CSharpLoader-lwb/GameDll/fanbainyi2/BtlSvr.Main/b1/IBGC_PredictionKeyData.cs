using b1.Prediction;

namespace b1;

public interface IBGC_PredictionKeyData
{
	GSPredictionKey ConfirmmingPredictionKey { get; }

	GSPredictionKey PredictingingPredictionKey { get; }

	bool ServerRecvingOrClientCueing();

	bool ServerRecving();

	bool ClientPredicting();
}
