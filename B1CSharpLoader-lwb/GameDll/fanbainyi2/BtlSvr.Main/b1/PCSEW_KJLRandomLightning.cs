using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.PCSEW_KJLRandomLightning")]
public class PCSEW_KJLRandomLightning : PCSEW_Base
{
	private int BulletID;

	private string LightningStartSocketName;

	private FVector EndPosition_World;

	private FVector EndPosNoise;

	private string LightningEndParamName;

	private bool IsDummyType;

	private static bool Target_IsValid;

	private static int Target_Offset;

	private static bool LightningBeam_IsValid;

	private static int LightningBeam_Offset;

	[UProperty]
	[USharpPath("/Script/b1-Managed.PCSEW_KJLRandomLightning:Target")]
	private AActor Target
	{
		get
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_KJLRandomLightning:Target");
				return null;
			}
			return UObjectMarshaler<AActor>.FromNative(IntPtr.Add(base.Address, Target_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Target_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_KJLRandomLightning:Target");
			}
			else
			{
				UObjectMarshaler<AActor>.ToNative(IntPtr.Add(base.Address, Target_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.PCSEW_KJLRandomLightning:LightningBeam")]
	private UNiagaraSystem LightningBeam
	{
		get
		{
			CheckDestroyed();
			if (!LightningBeam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_KJLRandomLightning:LightningBeam");
				return null;
			}
			return UObjectMarshaler<UNiagaraSystem>.FromNative(IntPtr.Add(base.Address, LightningBeam_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LightningBeam_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.PCSEW_KJLRandomLightning:LightningBeam");
			}
			else
			{
				UObjectMarshaler<UNiagaraSystem>.ToNative(IntPtr.Add(base.Address, LightningBeam_Offset), value);
			}
		}
	}

	public override void Wrapper()
	{
		ACharacter aCharacter = base.Owner as ACharacter;
		if (aCharacter.IsNullOrDestroyed() || Target.IsNullOrDestroyed())
		{
			return;
		}
		FName inSocketName = new FName(LightningStartSocketName);
		if (aCharacter.Mesh.DoesSocketExist(inSocketName))
		{
			FVector socketLocation = aCharacter.Mesh.GetSocketLocation(inSocketName);
			FVector fVector = socketLocation;
			FVector offsetNoise = BGUFunctionLibraryCS.GetOffsetNoise(EndPosNoise.X, EndPosNoise.Y, EndPosNoise.Z);
			fVector = ((!IsDummyType) ? (Target.GetActorLocation() + offsetNoise) : (EndPosition_World + offsetNoise));
			FRotator hitPointNormalDir = FRotator.ZeroRotator;
			if (BGUFuncLibSelectTargetsCS.LineTraceForHitWorldItem(base.Owner, socketLocation, fVector + (fVector - socketLocation).GetSafeNormal() * 2000.0, out var hitResultSimple))
			{
				fVector = hitResultSimple.HitLocation;
				hitPointNormalDir = hitResultSimple.HitImpactNormal.Rotation();
			}
			if (LightningBeam != null && !string.IsNullOrEmpty(LightningEndParamName))
			{
				UNiagaraFunctionLibrary.SpawnSystemAtLocation(base.Owner, LightningBeam, socketLocation, FRotator.ZeroRotator, FVector.OneVector, bAutoDestroy: true, bAutoActivate: true, ENCPoolMethod.AutoRelease, bPreCullCheck: false).SetNiagaraVariableVec3(LightningEndParamName, fVector);
			}
			FEffectInstReq effectInstReq = new FEffectInstReq(base.Owner);
			effectInstReq.HitLocation = fVector;
			effectInstReq.HitPointNormalDir = hitPointNormalDir;
			FGSProjecttileObjSpawnNSInfo ProjectileSpawnNSInfo = new FGSProjecttileObjSpawnNSInfo();
			ProjectileSpawnNSInfo.ProjectileType = EProjectileType.Bullet;
			ProjectileSpawnNSInfo.BuffIDList = new List<int>();
			ProjectileSpawnNSInfo.ProjectileID = BulletID;
			ProjectileSpawnNSInfo.SpawnWave = 1;
			ProjectileSpawnNSInfo.SpawnNumPerWave = 1;
			ProjectileSpawnNSInfo.SpawnBase.BaseType = ProjectileBaseType.UseEffectPosition;
			ProjectileSpawnNSInfo.SpawnBase.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
			ProjectileSpawnNSInfo.SpawnBase.BaseActor.Set(base.Owner);
			ProjectileSpawnNSInfo.SpawnBase.EffectInstReq = effectInstReq;
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo = default(ProjectilePosOffsetStruct);
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo.BaseActor = new TStrongObjectPtr<AActor>();
			ProjectileSpawnNSInfo.SpawnPosOffsetInfo.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(base.Owner, base.Owner, ProjectileBaseType.EffectCaster));
			ProjectileSpawnNSInfo.TargetBase.BaseType = ProjectileBaseType.None;
			ProjectileSpawnNSInfo.TargetBase.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
			ProjectileSpawnNSInfo.TargetBase.BaseActor.Set(Target);
			ProjectileSpawnNSInfo.TargetPosOffsetInfo = default(ProjectilePosOffsetStruct);
			ProjectileSpawnNSInfo.TargetPosOffsetInfo.BaseActor = new TStrongObjectPtr_NoCollect<AActor>();
			ProjectileSpawnNSInfo.TargetPosOffsetInfo.BaseActor.Set(BGU_ObjActorUtil.GetBaseActor(base.Owner, base.Owner, ProjectileBaseType.EffectCaster));
			ProjectileSpawnNSInfo.BornDirBaseInfo.BornDirType = ProjectileBornDirType.UseEffectNormal;
			ProjectileSpawnNSInfo.BornDirBaseInfo.HitPointNormalDir = effectInstReq.HitPointNormalDir;
			ProjectileSpawnNSInfo.BornDirOffset = default(ProjectileBornDirOffsetStruct);
			ProjectileSpawnNSInfo.ProjectileFlySpd = default(FSpawnBulletSpeed);
			ProjectileSpawnNSInfo.ProjectileRotSpd = default(FSpawnBulletSpeed);
			ProjectileSpawnNSInfo.MontageID = -1;
			ProjectileSpawnNSInfo.SpawnWaveDuration = 0f;
			ProjectileSpawnNSInfo.SpawnCounter = 0;
			ProjectileSpawnNSInfo.SpawnWaveCounter = 0;
			ProjectileSpawnNSInfo.ANSTotalTime = 0f;
			ProjectileSpawnNSInfo.bEnableMultiTargetMode = false;
			ProjectileSpawnNSInfo.MutilTargetRule = default(FProjectileMulTargetRule);
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(base.Owner);
			if (bUS_GSEventCollection != null)
			{
				bUS_GSEventCollection.Evt_OnNotifyStateSpawnProjectileObj.Invoke(ref ProjectileSpawnNSInfo);
			}
		}
	}

	public void InitData(int BulletID, FVector EndPosition_World, FVector EndPosNoise, string LightningStartSocketName, UNiagaraSystem LightningBeam, string LightningEndParamName, bool IsDummyType, AActor Target)
	{
		this.BulletID = BulletID;
		this.EndPosition_World = EndPosition_World;
		this.EndPosNoise = EndPosNoise;
		this.Target = Target;
		this.LightningStartSocketName = LightningStartSocketName;
		this.LightningBeam = LightningBeam;
		this.LightningEndParamName = LightningEndParamName;
		this.IsDummyType = IsDummyType;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.PCSEW_KJLRandomLightning");
		Target_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Target");
		Target_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Target", Classes.FObjectProperty);
		LightningBeam_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LightningBeam");
		LightningBeam_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LightningBeam", Classes.FObjectProperty);
	}

	static PCSEW_KJLRandomLightning()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(PCSEW_KJLRandomLightning)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(PCSEW_KJLRandomLightning));
	}
}
