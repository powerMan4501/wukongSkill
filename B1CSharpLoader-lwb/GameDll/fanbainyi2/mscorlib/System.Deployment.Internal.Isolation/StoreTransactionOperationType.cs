namespace System.Deployment.Internal.Isolation;

internal enum StoreTransactionOperationType
{
	Invalid = 0,
	SetCanonicalizationContext = 14,
	StageComponent = 20,
	PinDeployment = 21,
	UnpinDeployment = 22,
	StageComponentFile = 23,
	InstallDeployment = 24,
	UninstallDeployment = 25,
	SetDeploymentMetadata = 26,
	Scavenge = 27
}
