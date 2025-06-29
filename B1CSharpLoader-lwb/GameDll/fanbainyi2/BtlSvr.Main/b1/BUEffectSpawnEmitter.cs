using b1.BGW;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;
using UnrealEngine.Runtime.Native;

namespace b1;

[StopMaintenance]
[AffectTarget]
[EffectTemplateTips(new string[] { "停止维护，请勿再使用" })]
public class BUEffectSpawnEmitter : BUEffectTemplate
{
	public BUEffectSpawnEmitter()
	{
		EffectType = EBuffAndSkillEffectType.SpawnEmitter;
	}

	protected override void ApplyBySkill_Implement(int EffectID, AActor Caster, AActor Target, in FEffectInstReq EffectInstReq)
	{
		if (b1.EffectTemplateUtil.ReturnIfUnitDead(Caster) || b1.EffectTemplateUtil.ReturnIfUnitDead(Target))
		{
			return;
		}
		FUStSkillEffectDesc skillEffectDesc = BGW_GameDB.GetSkillEffectDesc(EffectID, Caster);
		if (skillEffectDesc != null && skillEffectDesc.EffectParamsStr.Count >= 1)
		{
			string fXPath = skillEffectDesc.EffectParamsStr[0];
			bool useSocket = skillEffectDesc.EffectParamsInt[0] != 0;
			string socketName = "";
			if (skillEffectDesc.EffectParamsStr.Count > 1)
			{
				socketName = skillEffectDesc.EffectParamsStr[1];
			}
			int spawnPosCategory = 0;
			if (skillEffectDesc.EffectParamsInt.Count >= 2)
			{
				spawnPosCategory = skillEffectDesc.EffectParamsInt[1];
			}
			bool useDBC = false;
			if (skillEffectDesc.EffectParamsInt.Count == 3)
			{
				useDBC = skillEffectDesc.EffectParamsInt[2] == 1;
			}
			PlayFX(Target, fXPath, useSocket, socketName, useDBC, spawnPosCategory);
		}
	}

	protected override void ApplyByBuff_Implement(BuffInstData BuffInst, AActor Target, int EffectIdx, in FEffectInstReq EffectInstReq, bool bIsPeriodical)
	{
		BuffDescRuntime buffDescRuntime = b1.EffectTemplateUtil.GetBuffDescRuntime(BuffInst);
		if (buffDescRuntime != null)
		{
			string stringEffectParam = buffDescRuntime.GetStringEffectParam(EffectIdx, 0);
			if (!string.IsNullOrEmpty(stringEffectParam))
			{
				bool useSocket = buffDescRuntime.GetIntEffectParam(EffectIdx, 0) != 0;
				string stringEffectParam2 = buffDescRuntime.GetStringEffectParam(EffectIdx, 1);
				int intEffectParam = buffDescRuntime.GetIntEffectParam(EffectIdx, 1);
				bool useDBC = buffDescRuntime.GetIntEffectParam(EffectIdx, 2) == 1;
				PlayFX(Target, stringEffectParam, useSocket, stringEffectParam2, useDBC, intEffectParam);
			}
		}
	}

	private void PlayFX(AActor Target, string FXPath, bool UseSocket, string SocketName, bool UseDBC, int SpawnPosCategory)
	{
		FActorSpawnParametersInterop fActorSpawnParametersInterop = new FActorSpawnParametersInterop
		{
			SpawnCollisionHandlingOverride = ESpawnActorCollisionHandlingMethod.AdjustIfPossibleButAlwaysSpawn
		};
		FVector location = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
		FRotator rotation = BGUFuncLibActorTransformCS.BGUGetActorRotation(Target);
		BGUCharacterCS bGUCharacterCS = Target as BGUCharacterCS;
		USceneComponent attachToComponent = Target.GetRootComponent();
		if (bGUCharacterCS != null)
		{
			location = BGU_ObjActorUtil.GetSocketOrCompTransform(UseSocket, bGUCharacterCS, new FName(SocketName), out var SocketOwnerComp).GetLocation();
			attachToComponent = SocketOwnerComp;
		}
		if (UseDBC)
		{
			BUS_EventCollectionCS.Get(Target).Evt_RequestSpawnFXByDispConfig.Invoke(FXPath, out var _);
			return;
		}
		UObject uObject = BGW_PreloadAssetMgr.Get(Target.World).TryGetCachedResourceObj<UObject>(FXPath, ELoadResourceType.AsyncLoadAndCache, EAssetPriority.Low);
		UParticleSystem uParticleSystem = uObject as UParticleSystem;
		if (uParticleSystem != null)
		{
			switch (SpawnPosCategory)
			{
			case 0:
				UGameplayStatics.SpawnEmitterAtLocation(Target.World, uParticleSystem, location, rotation, FVector.OneVector, bAutoDestroy: true, EPSCPoolMethod.AutoRelease, bAutoActivateSystem: true);
				break;
			case 1:
				UGameplayStatics.SpawnEmitterAttached(uParticleSystem, attachToComponent, new FName(SocketName), FVector.ZeroVector, FRotator.ZeroRotator, FVector.OneVector, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true, EPSCPoolMethod.AutoRelease, bAutoActivate: true);
				break;
			}
			return;
		}
		UNiagaraSystem uNiagaraSystem = uObject as UNiagaraSystem;
		if (uNiagaraSystem != null)
		{
			switch (SpawnPosCategory)
			{
			case 0:
				UNiagaraFunctionLibrary.SpawnSystemAtLocation(Target.World, uNiagaraSystem, location, rotation, FVector.OneVector, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false);
				break;
			case 1:
				UNiagaraFunctionLibrary.SpawnSystemAttached(uNiagaraSystem, attachToComponent, new FName(SocketName), FVector.ZeroVector, FRotator.ZeroRotator, EAttachLocation.KeepRelativeOffset, bAutoDestroy: true);
				break;
			}
		}
	}
}
