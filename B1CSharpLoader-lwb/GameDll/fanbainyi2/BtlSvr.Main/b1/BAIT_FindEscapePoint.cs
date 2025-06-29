using System;
using System.Collections.Generic;
using UnrealEngine.AIModule;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint")]
public class BAIT_FindEscapePoint : BAIT_Base
{
	private static bool QueryEscapeDirectionTemplate_IsValid;

	private static int QueryEscapeDirectionTemplate_Offset;

	private static bool MinCircleDistance_IsValid;

	private static int MinCircleDistance_Offset;

	private static bool MaxCircleDistance_IsValid;

	private static int MaxCircleDistance_Offset;

	private static bool OwnerCharacter_IsValid;

	private static int OwnerCharacter_Offset;

	private static bool AutoGenPointTag_IsValid;

	private static int AutoGenPointTag_Offset;

	[UProperty]
	[DisplayName("脱困方向查询EQS")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint:QueryEscapeDirectionTemplate")]
	public UEnvQuery QueryEscapeDirectionTemplate
	{
		get
		{
			CheckDestroyed();
			if (!QueryEscapeDirectionTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:QueryEscapeDirectionTemplate");
				return null;
			}
			return UObjectMarshaler<UEnvQuery>.FromNative(IntPtr.Add(base.Address, QueryEscapeDirectionTemplate_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QueryEscapeDirectionTemplate_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:QueryEscapeDirectionTemplate");
			}
			else
			{
				UObjectMarshaler<UEnvQuery>.ToNative(IntPtr.Add(base.Address, QueryEscapeDirectionTemplate_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint:MinCircleDistance")]
	public float MinCircleDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinCircleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:MinCircleDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MinCircleDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinCircleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:MinCircleDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MinCircleDistance_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint:MaxCircleDistance")]
	public float MaxCircleDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxCircleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:MaxCircleDistance");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, MaxCircleDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxCircleDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:MaxCircleDistance");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, MaxCircleDistance_Offset), value);
			}
		}
	}

	[UProperty]
	[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint:OwnerCharacter")]
	private ABGUCharacter OwnerCharacter
	{
		get
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:OwnerCharacter");
				return null;
			}
			return UObjectMarshaler<ABGUCharacter>.FromNative(IntPtr.Add(base.Address, OwnerCharacter_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OwnerCharacter_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:OwnerCharacter");
			}
			else
			{
				UObjectMarshaler<ABGUCharacter>.ToNative(IntPtr.Add(base.Address, OwnerCharacter_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAIT_FindEscapePoint:AutoGenPointTag")]
	public FName AutoGenPointTag
	{
		get
		{
			CheckDestroyed();
			if (!AutoGenPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:AutoGenPointTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, AutoGenPointTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AutoGenPointTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAIT_FindEscapePoint:AutoGenPointTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, AutoGenPointTag_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		MinCircleDistance = 800f;
		MaxCircleDistance = 4000f;
		AutoGenPointTag = B1GlobalFNames.DefaultEscapePoint;
	}

	public override void ReceiveExecute(AActor OwnerActor)
	{
		OwnerCharacter = OwnerActor as ABGUCharacter;
		if (OwnerCharacter == null)
		{
			USystemLibrary.PrintString(this, "BAIT_FindEscapePoint Failed, OwnerCharacter is null!", bPrintToScreen: true, bPrintToLog: true, FLinearColor.Red, 2f, FName.None);
			FinishExecute(bSuccess: false);
			return;
		}
		FVector BestPoint;
		bool flag = FilterBestMaximumScorePoint(out BestPoint);
		if (flag)
		{
			UGameplayStatics.GetAllActorsOfClassWithTag(OwnerActor, UClass.GetClass<BGUSceneItemBase>(), AutoGenPointTag, out var OutActors);
			AActor aActor = null;
			if (OutActors.Count == 0)
			{
				FRotator rotation = FRotator.ZeroRotator;
				FVector location = FVector.ZeroVector;
				aActor = OwnerActor.World.SpawnActor<BGUSceneItemBase>(ref location, ref rotation);
				aActor.Tags.Add(AutoGenPointTag);
			}
			else if (OutActors.Count == 1)
			{
				aActor = OutActors[0];
			}
			else if (OutActors.Count > 1)
			{
				aActor = OutActors[0];
				for (int i = 1; i < OutActors.Count; i++)
				{
					BGW_ECSWorld.Get(this).DestroyActor(OutActors[i]);
				}
			}
			if (aActor == null)
			{
				FinishExecute(bSuccess: false);
				return;
			}
			BGUFuncLibActorTransformCS.BGUSetActorLocation(aActor, BestPoint, bSweep: false, bTeleport: false);
			QueryBestLocationCondition queryBestLocationConditionObject = BGU_DataUtil.GetReadOnlyData<BUC_SceneItemData>(OwnerCharacter).QueryBestLocationConditionObject;
			queryBestLocationConditionObject.Initialize();
			List<FName> sceneActorTags = new List<FName> { AutoGenPointTag };
			BUS_EventCollectionCS.Get(OwnerCharacter).Evt_TryCatchSceneItemByCondition.Invoke(sceneActorTags, queryBestLocationConditionObject, NeedRemoveCurrentCatch: true);
			EndThisNode();
		}
		FinishExecute(flag);
	}

	private bool FilterBestMaximumScorePoint(out FVector BestPoint)
	{
		FGSEnvNamedValue item = new FGSEnvNamedValue
		{
			ParamName = B1GlobalFNames.InnerRadius,
			ParamType = EAIParamType.Float,
			Value = MinCircleDistance
		};
		FGSEnvNamedValue item2 = new FGSEnvNamedValue
		{
			ParamName = B1GlobalFNames.OuterRadius,
			ParamType = EAIParamType.Float,
			Value = MaxCircleDistance
		};
		List<FGSEnvNamedValue> namedParams = new List<FGSEnvNamedValue> { item, item2 };
		BGS_EventCollectionCS.Get(this).Evt_BGS_EQSObjRunInstantWithCustomParams.Invoke(QueryEscapeDirectionTemplate, OwnerCharacter, namedParams, out var Locations, out var Scores);
		List<FVector> list = new List<FVector>();
		for (int i = 0; i < Scores.Count && Math.Abs(Scores[i] - 1f) < 1E-08f; i++)
		{
			list.Add(Locations[i]);
		}
		if (list.Count == 0)
		{
			BestPoint = FVector.ZeroVector;
			return false;
		}
		Random random = new Random((int)DateTime.Now.Ticks);
		int num = random.Next(1, list.Count);
		BestPoint = list[num - 1];
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OwnerCharacter);
		float num2 = (BestPoint - fVector).Size2D();
		FVector safeNormal2D = (BestPoint - fVector).GetSafeNormal2D();
		float num3 = (float)random.Next(30, 70) / 100f;
		BestPoint = fVector + safeNormal2D * MathLib.Clamp(num2 * num3, MinCircleDistance, MaxCircleDistance);
		return true;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAIT_FindEscapePoint");
		QueryEscapeDirectionTemplate_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "QueryEscapeDirectionTemplate");
		QueryEscapeDirectionTemplate_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "QueryEscapeDirectionTemplate", Classes.FObjectProperty);
		MinCircleDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinCircleDistance");
		MinCircleDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinCircleDistance", Classes.FFloatProperty);
		MaxCircleDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxCircleDistance");
		MaxCircleDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxCircleDistance", Classes.FFloatProperty);
		OwnerCharacter_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "OwnerCharacter");
		OwnerCharacter_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "OwnerCharacter", Classes.FObjectProperty);
		AutoGenPointTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AutoGenPointTag");
		AutoGenPointTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AutoGenPointTag", Classes.FNameProperty);
	}

	static BAIT_FindEscapePoint()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BAIT_FindEscapePoint)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BAIT_FindEscapePoint));
	}
}
