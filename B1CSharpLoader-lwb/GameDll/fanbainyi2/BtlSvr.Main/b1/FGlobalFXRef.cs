using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class FGlobalFXRef
{
	public int GamePlayDispReqID { get; set; }

	public UNiagaraSystem FXTemplate { get; set; }

	public FName BulletPositionParamName { get; set; }

	public FName MFSpherePosParamName { get; set; }

	public FName MFSphereRadiusParamName { get; set; }

	public FName AvoidanceMFSpherePosParamName { get; set; }

	public FName AvoidanceMFSphereRadiusParamName { get; set; }

	public FName FXStartPointTag { get; set; }

	public FName FXStartPointParamName { get; set; }

	public bool bMFSphereRadiusParamUseArray { get; set; }

	public bool bAvoidanceMFSphereRadiusParamUseArray { get; set; }

	public Dictionary<AActor, int> ProjectileParamIndexMap { get; } = new Dictionary<AActor, int>();

	public List<FVector> ActualProjectilePosVectorArrayParam { get; } = new List<FVector>();

	public List<float> ActualMFRadiusFloatArrayParam { get; } = new List<float>();

	public Dictionary<AActor, int> AvoidanceMFSphereParamIndexMap { get; } = new Dictionary<AActor, int>();

	public List<FVector> ActualAvoidanceMFSpherePosVectorArrayParam { get; } = new List<FVector>();

	public List<float> ActualAvoidanceMFSphereRadiusFloatArrayParam { get; } = new List<float>();

	public bool IsValid()
	{
		return GamePlayDispReqID > 0;
	}
}
