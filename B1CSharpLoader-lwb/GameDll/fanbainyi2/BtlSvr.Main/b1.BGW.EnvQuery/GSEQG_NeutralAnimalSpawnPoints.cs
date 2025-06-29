using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[DisplayName("中立生物领地刷新点集")]
[Blueprintable]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints")]
public class GSEQG_NeutralAnimalSpawnPoints : UGSEQGBase_ProjectedPoint
{
	private static bool PointBetween_IsValid;

	private static int PointBetween_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("点间距")]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:PointBetween")]
	public int PointBetween
	{
		get
		{
			CheckDestroyed();
			if (!PointBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:PointBetween");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:PointBetween");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointBetween_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		BGUNeutralAnimalSpawnArea bGUNeutralAnimalSpawnArea = GetQuerier() as BGUNeutralAnimalSpawnArea;
		if (bGUNeutralAnimalSpawnArea == null || (float)PointBetween <= 0f)
		{
			return;
		}
		List<FVector> list = new List<FVector>();
		FName territory = B1GlobalFNames.Territory;
		foreach (UActorComponent item in bGUNeutralAnimalSpawnArea.GetComponentsByTag(UClass.GetClass<UBoxComponent>(), territory))
		{
			List<FVector> collection = GenOneTerritoryLandPoints(item as UBoxComponent);
			list.AddRange(collection);
		}
		CalcResultPoint(list);
	}

	private List<FVector> GenOneTerritoryLandPoints(UBoxComponent BoxComp)
	{
		List<FVector> list = new List<FVector>();
		FVector worldLocation = BoxComp.GetWorldLocation();
		FVector forwardVector = BoxComp.GetForwardVector();
		FVector rightVector = BoxComp.GetRightVector();
		float num = BoxComp.GetScaledBoxExtent().X * 2f;
		float num2 = BoxComp.GetScaledBoxExtent().Y * 2f;
		int num3 = (int)(num / (float)PointBetween) + 1;
		int num4 = (int)(num2 / (float)PointBetween) + 1;
		FVector fVector = worldLocation - forwardVector * num / 2.0 - rightVector * num2 / 2.0;
		for (int i = 0; i < num3; i++)
		{
			for (int j = 0; j < num4; j++)
			{
				FVector item = fVector;
				item += rightVector * j * PointBetween;
				item += forwardVector * i * PointBetween;
				list.Add(item);
			}
		}
		return list;
	}

	private void CalcResultPoint(List<FVector> GenPoints)
	{
		foreach (FVector GenPoint in GenPoints)
		{
			base.GenerateItemList.Add(GenPoint);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_NeutralAnimalSpawnPoints gSEQG_NeutralAnimalSpawnPoints = GCHelper.Find<GSEQG_NeutralAnimalSpawnPoints>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_NeutralAnimalSpawnPoints.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints");
		PointBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointBetween");
		PointBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointBetween", Classes.FIntProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_NeutralAnimalSpawnPoints:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_NeutralAnimalSpawnPoints()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_NeutralAnimalSpawnPoints)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_NeutralAnimalSpawnPoints));
	}
}
