namespace System.Security;

[Flags]
public enum ManifestKinds
{
	None = 0,
	Deployment = 1,
	Application = 2,
	ApplicationAndDeployment = 3
}
