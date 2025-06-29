namespace GSDispLib;

public enum DispLibDBCNiagaraInstanceState
{
	EmptyInfo,
	WaitForSpawn,
	HasSpawn,
	ForceDestroy,
	ReleaseToPool,
	ExternalDestroy,
	Deactivate,
	BeReuseByScalability
}
