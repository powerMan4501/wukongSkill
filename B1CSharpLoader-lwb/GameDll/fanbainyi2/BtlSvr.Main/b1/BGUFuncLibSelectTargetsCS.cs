using System;
using System.Collections.Generic;
using b1.FUnctionLibUtil;
using BtlB1;
using BtlShare;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;
using UnrealEngine.UMG;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUFuncLibSelectTargetsCS")]
public class BGUFuncLibSelectTargetsCS : UBlueprintFunctionLibrary
{
	public enum EAffiliationType
	{
		None = 0,
		Master = 1,
		Summon = 2,
		Other = 4
	}

	private static bool DeadPhyTest_IsValid;

	private static IntPtr DeadPhyTest_FunctionAddress;

	private static int DeadPhyTest_ParamsSize;

	private static bool DeadPhyTest_Unit_IsValid;

	private static int DeadPhyTest_Unit_Offset;

	private static bool DeadPhyReset_IsValid;

	private static IntPtr DeadPhyReset_FunctionAddress;

	private static int DeadPhyReset_ParamsSize;

	private static bool DeadPhyReset_Unit_IsValid;

	private static int DeadPhyReset_Unit_Offset;

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyReset")]
	public static void DeadPhyReset(AActor Unit)
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyTest")]
	public static void DeadPhyTest(AActor Unit)
	{
		BUS_EventCollectionCS.Get(Unit)?.Evt_SetPhysAnimSetting.Invoke(EPhysAnimType.Death);
	}

	public static List<ABGUCharacter> SelectTargetsWithFilter(AActor Owner, IBUC_WakeUpData WakeUpData)
	{
		List<ABGUCharacter> list = new List<ABGUCharacter>();
		if (Owner.IsNullOrDestroyed())
		{
			return list;
		}
		if (WakeUpData == null)
		{
			return list;
		}
		if (WakeUpData.UseManualSelect)
		{
			foreach (string manualTargetGuid in WakeUpData.ManualTargetGuidList)
			{
				ABGUCharacter aBGUCharacter = BGU_DataUtil.GetActorByGuid(Owner, manualTargetGuid) as ABGUCharacter;
				if (!list.Contains(aBGUCharacter) && BGUFunctionLibraryCS.BGUSeletUnitsFilter(aBGUCharacter as BGUCharacterCS, WakeUpData.ResIDList, WakeUpData.bSelectUnitHasTarget, WakeUpData.bSelectPassiveUnit))
				{
					list.Add(aBGUCharacter);
				}
			}
		}
		if (WakeUpData.UseRangeSelect)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
			fVector.Z -= WakeUpData.RangeParam_2 - WakeUpData.RangeParam_3;
			UBGUSelectUtil.BoxOverlapBGUCharacters(BoxExtent: new FVector(WakeUpData.RangeParam_1, WakeUpData.RangeParam_1, (WakeUpData.RangeParam_2 + WakeUpData.RangeParam_3) / 2f), WorldContextObject: Owner.World, BoxPos: fVector, OutArray: out var OutArray);
			foreach (ABGUCharacter item in OutArray)
			{
				if (item != Owner && !list.Contains(item) && BGUTargetActorIsInCylinder(item, fVector, WakeUpData.RangeParam_1, WakeUpData.RangeParam_2, WakeUpData.RangeParam_3) && BGUFunctionLibraryCS.BGUSeletUnitsFilter(item as BGUCharacterCS, WakeUpData.ResIDList, WakeUpData.bSelectUnitHasTarget, WakeUpData.bSelectPassiveUnit) && BGUIsSelectTargetByTeamFilter(Owner, item, 2))
				{
					list.Add(item);
				}
			}
		}
		return list;
	}

	public static int BGUSelectTargetsInShape(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector BaseLoc, ERangeType RangeType, int TargetCount, int TargetFilter, int TargetTypeFilter, int AffiliationTypeFilter, in IList<int> Prams)
	{
		OutActors = null;
		if (WorldContextObject == null || TargetBase == null)
		{
			return 0;
		}
		switch (RangeType)
		{
		case ERangeType.Circle:
			SelectUnitsInCircle(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Rect:
			SelectUnitsInRect(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Cylinder:
			SelectUnitsInCylinder(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.ForwardRect:
			SelectUnitsInForwardRect(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Ring:
			SelectUnitsInRing(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Sphere:
			SelectUnitsInSphere(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.AnnularSector:
			SelectUnitsInAnnularSector(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.VelocityDirSphere:
			SelectUnitsInVelocityDirSphere(WorldContextObject, out OutActors, TargetBase, TargetTypeFilter, Prams);
			break;
		}
		for (int i = 0; i < OutActors.Count; i++)
		{
			if (!BGUIsSelectTargetByTeamFilter(TargetBase, OutActors[i], TargetFilter))
			{
				OutActors.RemoveAt(i);
				i--;
			}
		}
		for (int j = 0; j < OutActors.Count; j++)
		{
			if (!BGUIsSelectTargetByAffiliationFilter(TargetBase, OutActors[j], AffiliationTypeFilter))
			{
				OutActors.RemoveAt(j);
				j--;
			}
		}
		if (TargetCount > 0 && OutActors.Count > TargetCount)
		{
			OutActors.RemoveRange(TargetCount, OutActors.Count - TargetCount);
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInCircle(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 1 && Params[0] > 0)
		{
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				USystemLibrary.DrawDebugCircle(WorldContextObject, TargetBaseLoc, Params[0], 12, FLinearColor.Aquamarine, 2f, 0f, FVector.ForwardVector, FVector.RightVector, bDrawAxis: false);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, Params[0], 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num = OutActors.Count - 1; num >= 0; num--)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num]);
				if (FVector.Dist2D(TargetBaseLoc, v) > (float)Params[0])
				{
					OutActors.RemoveAt(num);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInSphere(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 1 && Params[0] > 0)
		{
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				USystemLibrary.DrawDebugSphere(WorldContextObject, TargetBaseLoc, Params[0], 12, FLinearColor.Aquamarine, 2f, 0f);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, Params[0], 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num = OutActors.Count - 1; num >= 0; num--)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num]);
				if (FVector.Dist(TargetBaseLoc, v) > (float)Params[0])
				{
					OutActors.RemoveAt(num);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInVelocityDirSphere(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		FVector actorVelocityDirection = GetActorVelocityDirection(TargetBase);
		if (Params.Count >= 1 && Params[0] > 0)
		{
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetBase);
			if (actorVelocityDirection.Size() > 0f && Params.Count >= 2)
			{
				fVector += actorVelocityDirection * Params[1];
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, fVector, TargetTypeFilter, Params[0], 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num = OutActors.Count - 1; num >= 0; num--)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num]);
				if (FVector.Dist(fVector, v) > (float)Params[0])
				{
					OutActors.RemoveAt(num);
				}
			}
		}
		return OutActors.Count;
	}

	public static int BGUSelectTargetsInShapeForIntimidation(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector BaseLoc, ERangeType RangeType, int TargetFilter, int TargetTypeFilter, int AffiliationTypeFilter, in IList<int> Prams)
	{
		OutActors = null;
		if (WorldContextObject == null || TargetBase == null)
		{
			return 0;
		}
		switch (RangeType)
		{
		case ERangeType.Circle:
			SelectUnitsInCircle(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Rect:
			SelectUnitsInRect(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Cylinder:
			SelectUnitsInCylinder(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.ForwardRect:
			SelectUnitsInForwardRect(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Ring:
			SelectUnitsInRing(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.Sphere:
			SelectUnitsInSphere(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.AnnularSector:
			SelectUnitsInAnnularSector(WorldContextObject, out OutActors, TargetBase, BaseLoc, TargetTypeFilter, Prams);
			break;
		case ERangeType.VelocityDirSphere:
			SelectUnitsInVelocityDirSphere(WorldContextObject, out OutActors, TargetBase, TargetTypeFilter, Prams);
			break;
		}
		for (int i = 0; i < OutActors.Count; i++)
		{
			if (!BGUIsSelectTargetByTeamFilter(TargetBase, OutActors[i], TargetFilter))
			{
				OutActors.RemoveAt(i);
				i--;
			}
		}
		for (int j = 0; j < OutActors.Count; j++)
		{
			if (!BGUIsSelectTargetByAffiliationFilter(TargetBase, OutActors[j], AffiliationTypeFilter))
			{
				OutActors.RemoveAt(j);
				j--;
			}
		}
		return OutActors.Count;
	}

	private static FVector GetActorVelocityDirection(AActor Actor)
	{
		if (Actor.IsNullOrDestroyed())
		{
			return FVector.ZeroVector;
		}
		FVector safeNormal = Actor.GetVelocity().GetSafeNormal();
		b1.IBUC_PhysAnimData unPersistentReadOnlyData = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysAnimData, b1.BUC_PhysAnimData>(Actor);
		b1.IBUC_PhysicalMoveData unPersistentReadOnlyData2 = BGU_DataUtil.GetUnPersistentReadOnlyData<b1.IBUC_PhysicalMoveData, b1.BUC_PhysicalMoveData>(Actor);
		if (unPersistentReadOnlyData2 != null && unPersistentReadOnlyData != null && unPersistentReadOnlyData.CurrentType == EPhysAnimType.PhysicsSimulationMove)
		{
			safeNormal = unPersistentReadOnlyData2.PhysicalMoveVelocity.GetSafeNormal();
		}
		return safeNormal;
	}

	public static int SelectUnitsInAnnularSector(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 3 && Params[0] >= 0 && Params[1] >= 0 && Params[0] + Params[1] > 0)
		{
			float num = FMath.Max(Params[0], Params[1]);
			float num2 = FMath.Min(Params[0], Params[1]);
			float num3 = Params[2];
			FVector direction = TargetBase.GetActorForwardVector();
			if (Params.Count > 3)
			{
				direction = direction.RotateAngleAxis(Params[3], TargetBase.GetActorUpVector());
			}
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				UBGUFunctionLibraryForCS.BGUDrawDebugAnnularSector(TargetBase.World, TargetBaseLoc, direction, num2, num, num3, FColor.Azure, 2f, 5f, 100);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, num, 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num4 = OutActors.Count - 1; num4 >= 0; num4--)
			{
				FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num4]);
				float num5 = FVector.Dist2D(TargetBaseLoc, fVector);
				bool flag = false;
				if (num5 > num || num5 < num2)
				{
					flag = true;
				}
				else
				{
					FVector fVector2 = fVector - BGUFuncLibActorTransformCS.BGUGetActorLocation(TargetBase);
					if (MathLib.Abs(UBUS_UtilComm.CalcDegreeFromVectorsProjectInXYPlane(direction.GetSafeNormal2D(), fVector2.GetSafeNormal2D())) > num3)
					{
						flag = true;
					}
				}
				if (flag)
				{
					OutActors.RemoveAt(num4);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInRing(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 4 && Params[0] >= 0 && Params[1] >= 0 && Params[0] <= Params[1] && Params[2] <= 0 && Params[3] >= 0)
		{
			int num = Params[0];
			int num2 = Params[1];
			int num3 = Params[2];
			int num4 = Params[3];
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, num2, 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num5 = OutActors.Count - 1; num5 >= 0; num5--)
			{
				FVector fVector = MathLib.InverseTransformDirection(BGUFuncLibActorTransformCS.BGUGetActorTransform(TargetBase), BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num5]) - TargetBaseLoc);
				FVector2D safeNormal = new FVector2D(fVector.X, fVector.Y).GetSafeNormal();
				float num6 = FMath.Acos(safeNormal.X) * (180f / (float)Math.PI);
				float num7 = FVector.Dist(TargetBaseLoc, BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num5]));
				if (safeNormal.Y < 0f)
				{
					num6 = 0f - num6;
				}
				if (num7 >= (float)num2 || num7 <= (float)num || num6 <= (float)num3 || num6 >= (float)num4)
				{
					OutActors.RemoveAt(num5);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SimpleSelectUnitsInRect(UObject WorldContextObject, out List<AActor> OutActors, FVector BaseLoc, FVector ForwardVector, FVector RightVector, float Width, float Length, int TargetTypeFilter)
	{
		OutActors = new List<AActor>();
		List<AActor> list = new List<AActor>();
		list = GetAllActorsNeeded(WorldContextObject, TargetTypeFilter);
		float num = Width / 2f;
		float num2 = Length / 2f;
		FVector fVector = ForwardVector * num;
		FVector fVector2 = RightVector * num2;
		FVector fVector3 = fVector + -1.0 * fVector2;
		FVector fVector4 = fVector + fVector2;
		FVector fVector5 = -1.0 * fVector + fVector2;
		FVector fVector6 = -1.0 * fVector + -1.0 * fVector2;
		fVector3 += BaseLoc;
		fVector4 += BaseLoc;
		fVector5 += BaseLoc;
		fVector6 += BaseLoc;
		if (SelectRangeDebugInfo.EnableDebugForSelectRange)
		{
			USystemLibrary.DrawDebugPoint(WorldContextObject, fVector3, 30f, FLinearColor.Red, 10f);
			USystemLibrary.DrawDebugPoint(WorldContextObject, fVector4, 30f, FLinearColor.Blue, 10f);
			USystemLibrary.DrawDebugPoint(WorldContextObject, fVector5, 30f, FLinearColor.Green, 10f);
			USystemLibrary.DrawDebugPoint(WorldContextObject, fVector6, 30f, FLinearColor.Black, 10f);
		}
		for (int i = 0; i < list.Count; i++)
		{
			FVector fVector7 = BGUFuncLibActorTransformCS.BGUGetActorLocation(list[i]);
			fVector7.Z = BaseLoc.Z;
			FVector a = FVector.CrossProduct(fVector7 - fVector3, fVector4 - fVector3);
			FVector fVector8 = FVector.CrossProduct(fVector7 - fVector4, fVector5 - fVector4);
			FVector fVector9 = FVector.CrossProduct(fVector7 - fVector5, fVector6 - fVector5);
			FVector b = FVector.CrossProduct(fVector7 - fVector6, fVector3 - fVector6);
			float num3 = FVector.DotProduct(a, fVector8);
			float num4 = FVector.DotProduct(fVector8, fVector9);
			float num5 = FVector.DotProduct(fVector9, b);
			if (num3 * num4 > 0f && num4 * num5 > 0f)
			{
				OutActors.Add(list[i]);
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInRect(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 2 && Params[0] > 0 && Params[1] > 0)
		{
			float num = Params[1] / 2;
			float num2 = Params[0] / 2;
			FVector fVector = TargetBase.GetActorForwardVector() * num;
			FVector fVector2 = TargetBase.GetActorRightVector() * num2;
			FVector fVector3 = fVector + -1.0 * fVector2;
			FVector fVector4 = fVector + fVector2;
			FVector fVector5 = -1.0 * fVector + fVector2;
			FVector fVector6 = -1.0 * fVector + -1.0 * fVector2;
			fVector3 += TargetBaseLoc;
			fVector4 += TargetBaseLoc;
			fVector5 += TargetBaseLoc;
			fVector6 += TargetBaseLoc;
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector3, fVector4, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector4, fVector5, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector5, fVector6, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector6, fVector3, FLinearColor.Aquamarine, 2f);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, 0f, num, num2, TargetBase.GetActorForwardVector().Conv_VectorToVector2D(), bIsSphere: false, out OutActors);
			for (int num3 = OutActors.Count - 1; num3 >= 0; num3--)
			{
				FVector fVector7 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num3]);
				fVector7.Z = TargetBaseLoc.Z;
				FVector a = FVector.CrossProduct(fVector7 - fVector3, fVector4 - fVector3);
				FVector fVector8 = FVector.CrossProduct(fVector7 - fVector4, fVector5 - fVector4);
				FVector fVector9 = FVector.CrossProduct(fVector7 - fVector5, fVector6 - fVector5);
				FVector b = FVector.CrossProduct(fVector7 - fVector6, fVector3 - fVector6);
				float num4 = FVector.DotProduct(a, fVector8);
				float num5 = FVector.DotProduct(fVector8, fVector9);
				float num6 = FVector.DotProduct(fVector9, b);
				if (num4 * num5 <= 0f || num5 * num6 <= 0f)
				{
					OutActors.RemoveAt(num3);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInForwardRect(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 2 && Params[0] > 0 && Params[1] > 0)
		{
			float num = Params[1] / 2;
			float num2 = Params[0] / 2;
			FVector fVector = TargetBase.GetActorForwardVector() * num;
			FVector fVector2 = TargetBase.GetActorRightVector() * num2;
			FVector fVector3 = 2.0 * fVector + -1.0 * fVector2;
			FVector fVector4 = 2.0 * fVector + fVector2;
			FVector fVector5 = fVector2;
			FVector fVector6 = -1.0 * fVector2;
			FVector fVector7 = TargetBaseLoc + TargetBase.GetActorForwardVector() * num;
			fVector3 += TargetBaseLoc;
			fVector4 += TargetBaseLoc;
			fVector5 += TargetBaseLoc;
			fVector6 += TargetBaseLoc;
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				USystemLibrary.DrawDebugPoint(WorldContextObject, fVector7, 30f, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector3, fVector4, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector4, fVector5, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector5, fVector6, FLinearColor.Aquamarine, 2f);
				USystemLibrary.DrawDebugLine(WorldContextObject, fVector6, fVector3, FLinearColor.Aquamarine, 2f);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, fVector7, TargetTypeFilter, 0f, num, num2, TargetBase.GetActorForwardVector().Conv_VectorToVector2D(), bIsSphere: false, out OutActors);
			for (int num3 = OutActors.Count - 1; num3 >= 0; num3--)
			{
				FVector fVector8 = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num3]);
				fVector8.Z = TargetBaseLoc.Z;
				FVector a = FVector.CrossProduct(fVector8 - fVector3, fVector4 - fVector3);
				FVector fVector9 = FVector.CrossProduct(fVector8 - fVector4, fVector5 - fVector4);
				FVector fVector10 = FVector.CrossProduct(fVector8 - fVector5, fVector6 - fVector5);
				FVector b = FVector.CrossProduct(fVector8 - fVector6, fVector3 - fVector6);
				float num4 = FVector.DotProduct(a, fVector9);
				float num5 = FVector.DotProduct(fVector9, fVector10);
				float num6 = FVector.DotProduct(fVector10, b);
				if (num4 * num5 <= 0f || num5 * num6 <= 0f)
				{
					OutActors.RemoveAt(num3);
				}
			}
		}
		return OutActors.Count;
	}

	public static int SelectUnitsInCylinder(UObject WorldContextObject, out List<AActor> OutActors, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, IList<int> Params)
	{
		OutActors = new List<AActor>();
		if (Params.Count >= 3 && Params[0] > 0)
		{
			float z = TargetBaseLoc.Z;
			float num = FMath.Min(z + (float)Params[1], z + (float)Params[2]);
			float num2 = FMath.Max(z + (float)Params[1], z + (float)Params[2]);
			if (SelectRangeDebugInfo.EnableDebugForSelectRange)
			{
				USystemLibrary.DrawDebugCylinder(WorldContextObject, TargetBaseLoc + new FVector(0.0, 0.0, Params[1]), TargetBaseLoc + new FVector(0.0, 0.0, Params[2]), Params[0], 100, FLinearColor.Aqua, 2f, 5f);
			}
			GetAllActorsBySimpleOverlapWithTypeFilter(WorldContextObject, TargetBase, TargetBaseLoc, TargetTypeFilter, Params[0], 0f, 0f, FVector2D.UnitVector, bIsSphere: true, out OutActors);
			for (int num3 = OutActors.Count - 1; num3 >= 0; num3--)
			{
				FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActors[num3]);
				float z2 = v.Z;
				bool flag = false;
				if (FVector.Dist2D(TargetBaseLoc, v) > (float)Params[0])
				{
					flag = true;
				}
				else if (z2 < num || z2 > num2)
				{
					flag = true;
				}
				if (flag)
				{
					OutActors.RemoveAt(num3);
				}
			}
		}
		return OutActors.Count;
	}

	public static bool BGUTargetActorIsInCylinder(AActor Target, FVector CylinderCenter, float CylinderRadius, float UpAbsHeight, float DownAbsHeight)
	{
		if (Target.IsNullOrDestroyed())
		{
			return false;
		}
		FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target);
		if (FVector.Dist2D(CylinderCenter, v) <= CylinderRadius)
		{
			if (UpAbsHeight == 0f && UpAbsHeight == 0f)
			{
				return true;
			}
			float z = BGUFuncLibActorTransformCS.BGUGetActorLocation(Target).Z;
			float z2 = CylinderCenter.Z;
			if (z == z2)
			{
				return true;
			}
			if (UpAbsHeight != 0f && z > z2 && z - z2 < FMath.Abs(UpAbsHeight))
			{
				return true;
			}
			if (DownAbsHeight != 0f && z < z2 && z2 - z < FMath.Abs(DownAbsHeight))
			{
				return true;
			}
		}
		return false;
	}

	public static bool GetAllActorsBySimpleOverlapWithTypeFilter(UObject WorldContextObject, AActor TargetBase, FVector TargetBaseLoc, int TargetTypeFilter, float SphereRadius, float RectWidth, float RectLength, FVector2D RectRotation, bool bIsSphere, out List<AActor> OutActors)
	{
		BGC_SimpleOverlapMgrData gameStateReadonlyData = BGU_DataUtil.GetGameStateReadonlyData<BGC_SimpleOverlapMgrData>(TargetBase);
		bool flag = false;
		OutActors = new List<AActor>();
		if (gameStateReadonlyData != null)
		{
			ESimpleOverlapResult simpleOverlapActorsByMask = gameStateReadonlyData.GetSimpleOverlapActorsByMask(TargetBase, TargetBaseLoc, TargetTypeFilter, SphereRadius, RectWidth, RectLength, RectRotation, bIsSphere, out OutActors);
			flag = simpleOverlapActorsByMask == ESimpleOverlapResult.ValidInputAndHasOverlapping || simpleOverlapActorsByMask == ESimpleOverlapResult.ValidInputAndNoOverlapping;
		}
		if (!flag)
		{
			OutActors = GetAllActorsNeeded(WorldContextObject, TargetTypeFilter);
		}
		if (SelectRangeDebugInfo.EnableDebugForSelectUnit)
		{
			foreach (AActor OutActor in OutActors)
			{
				USystemLibrary.DrawDebugPoint(WorldContextObject, BGUFuncLibActorTransformCS.BGUGetActorLocation(OutActor), 30f, FLinearColor.Blue, 10f);
			}
		}
		return flag;
	}

	public static List<AActor> GetAllActorsNeeded(UObject WorldContextObject, int TargetType)
	{
		List<AActor> list = new List<AActor>();
		if ((TargetType & 1) != 0)
		{
			List<AActor> list2 = new List<AActor>();
			list2 = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<ABGUCharacter>());
			list.AddRange(list2);
		}
		if ((TargetType & 2) != 0)
		{
			List<AActor> list3 = new List<AActor>();
			list3 = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<BGUBulletBaseCS>());
			for (int i = 0; i < list3.Count; i++)
			{
				BGUBulletBaseCS bGUBulletBaseCS = list3[i] as BGUBulletBaseCS;
				if (bGUBulletBaseCS.IsNullOrDestroyed() || bGUBulletBaseCS.IsDead())
				{
					list3.RemoveAt(i);
					i--;
				}
			}
			list.AddRange(list3);
		}
		if ((TargetType & 4) != 0)
		{
			List<AActor> list4 = new List<AActor>();
			list4 = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<BGUMagicFieldBaseCS>());
			for (int j = 0; j < list4.Count; j++)
			{
				BGUMagicFieldBaseCS bGUMagicFieldBaseCS = list4[j] as BGUMagicFieldBaseCS;
				if (bGUMagicFieldBaseCS.IsNullOrDestroyed() || bGUMagicFieldBaseCS.IsDead())
				{
					list4.RemoveAt(j);
					j--;
				}
			}
			list.AddRange(list4);
		}
		if ((TargetType & 8) != 0)
		{
			List<AActor> allActorsOfClassList = UGameplayStatics.GetAllActorsOfClassList(WorldContextObject, UClass.GetClass<BGUFXActorBase>());
			for (int k = 0; k < allActorsOfClassList.Count; k++)
			{
				BGUFXActorBase obj = allActorsOfClassList[k] as BGUFXActorBase;
				if (obj.IsNullOrDestroyed())
				{
					allActorsOfClassList.RemoveAt(k);
				}
				b1.IBUC_FXActorBaseData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.IBUC_FXActorBaseData, b1.BUC_FXActorBaseData>(obj);
				if (readOnlyData == null || readOnlyData.FXActorType != EFXActorType.DestructibleObject)
				{
					allActorsOfClassList.RemoveAt(k);
				}
			}
			list.AddRange(allActorsOfClassList);
		}
		return list;
	}

	public static bool BGUIsSelectTargetByTeamFilter(AActor Caster, AActor Target, int Filter)
	{
		if (Caster == null || Target == null)
		{
			return false;
		}
		bool result = false;
		if ((Filter & 1) != 0 && Caster == Target)
		{
			result = true;
		}
		if ((Filter & 2) != 0 && !BGUFunctionLibraryCS.BGUIsEnemyTeam(Caster, Target) && Caster != Target)
		{
			result = true;
		}
		if ((Filter & 4) != 0 && BGUFunctionLibraryCS.BGUIsEnemyTeam(Caster, Target))
		{
			result = true;
		}
		return result;
	}

	public static bool BGUIsSelectTargetByTypeFilter(AActor Target, int FilterParam)
	{
		if (Target == null)
		{
			return false;
		}
		bool result = false;
		if ((FilterParam & 1) != 0 && Target as BGUCharacterCS != null)
		{
			result = true;
		}
		if ((FilterParam & 2) != 0 && Target as BGUBulletBaseCS != null)
		{
			result = true;
		}
		if ((FilterParam & 4) != 0 && Target as BGUMagicFieldBaseCS != null)
		{
			result = true;
		}
		return result;
	}

	public static bool BGUIsSelectTargetByAffiliationFilter(AActor Caster, AActor Target, int Filter)
	{
		if (Caster == null || Target == null)
		{
			return false;
		}
		if (Filter == 0 || Filter == 7)
		{
			return true;
		}
		bool result = false;
		IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Caster);
		IBUC_MasterData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(Target);
		if (readOnlyData != null && readOnlyData2 != null)
		{
			if ((Filter & 1) != 0 && readOnlyData.GetMasterActor() == Target)
			{
				result = true;
			}
			if ((Filter & 2) != 0 && readOnlyData2.GetMasterActor() == Caster)
			{
				result = true;
			}
			if ((Filter & 4) != 0 && readOnlyData.GetMasterActor() != Target && readOnlyData2.GetMasterActor() != Caster)
			{
				result = true;
			}
		}
		return result;
	}

	public static bool FilterSweepCheck(AActor SelfActor, AActor BeHitUnit, ESweepCheckHitFilterType FilterType)
	{
		if (SelfActor == null || BeHitUnit == null)
		{
			return false;
		}
		bool result = false;
		switch (FilterType)
		{
		case ESweepCheckHitFilterType.FilterMaster:
		{
			IBUC_MasterData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_MasterData, BUC_MasterData>(SelfActor);
			if (readOnlyData != null && readOnlyData.GetMasterActor() == BeHitUnit)
			{
				result = true;
			}
			break;
		}
		case ESweepCheckHitFilterType.NotInSameTeam:
			if (!BGUFunctionLibraryCS.BGUIsEnemyTeam(SelfActor, BeHitUnit))
			{
				result = true;
			}
			break;
		}
		return result;
	}

	public static bool LineTraceForHitWorldItem(UObject WorldContextObject, FVector LineTraceStart, FVector LineTraceEnd, out FHitResultSimple hitResultSimple, bool bDebug = false)
	{
		if (WorldContextObject == null)
		{
			hitResultSimple = null;
			return false;
		}
		hitResultSimple = new FHitResultSimple();
		return BGW_NativeFuncs.LineTraceForWorldStaticObjects(WorldContextObject.Address, ref LineTraceStart, ref LineTraceEnd, bDebug, hitResultSimple.Address);
	}

	public static UnitLockTargetInfo BGUSelectLockTargetInRange(ACharacter Owner, float FirstFilterMaxRange, EBSelectTargetRangeType RangeType, float AngleMax, FRotator MyDir, float DistScoreRating, AActor PreferActor, float PreferActorDistTolerance = 0f)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return null;
		}
		if (Owner == null)
		{
			return new UnitLockTargetInfo();
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(Owner);
		FRotator fRotator = MyDir;
		FVector b = fRotator.Vector();
		b.Z = 0f;
		UBGUSelectUtil.SphereOverlapBGUCharacters(Owner, fVector, FirstFilterMaxRange, out var OutArray);
		ABGUCharacter targetActor = null;
		string skeletonSocketName = "";
		float num = -1000f;
		float num2 = FirstFilterMaxRange;
		bool flag = false;
		bool flag2 = true;
		FVector2D fVector2D = FVector2D.ZeroVector;
		APlayerController firstLocalPlayerController = UGSE_EngineFuncLib.GetFirstLocalPlayerController(Owner);
		if (firstLocalPlayerController != null)
		{
			fVector2D = UWidgetLayoutLibrary.GetViewportSize(firstLocalPlayerController) / UWidgetLayoutLibrary.GetViewportScale(firstLocalPlayerController);
		}
		IBGC_CircusControlData readOnlyData = BGU_DataUtil.GetReadOnlyData<BGC_CircusControlData>(UGameplayStatics.GetGameState(Owner));
		for (int i = 0; i < OutArray.Count; i++)
		{
			BGUCharacterCS bGUCharacterCS = OutArray[i] as BGUCharacterCS;
			if (flag)
			{
				if (!flag2)
				{
					return new UnitLockTargetInfo(targetActor, ETargetSourceType.None, ELockTargetWayType.Manual, "", skeletonSocketName);
				}
				return new UnitLockTargetInfo(targetActor, ETargetSourceType.None);
			}
			if (!(bGUCharacterCS != Owner) || BGUFunctionLibraryCS.BGUIsUnitDead(bGUCharacterCS) || !BGUFunctionLibraryCS.BGUIsEnemyTeam(Owner, bGUCharacterCS))
			{
				continue;
			}
			if (RangeType == EBSelectTargetRangeType.CameraLock)
			{
				if (BGUFunctionLibraryCS.BGUHasUnitSimpleState(bGUCharacterCS, EBGUSimpleState.CantBeLock))
				{
					continue;
				}
				FUStUnitCommDesc unitCommDesc = BGW_GameDB.GetUnitCommDesc(bGUCharacterCS.GetResID());
				if (unitCommDesc != null)
				{
					num2 = unitCommDesc.CameraLockDist;
					PreferActorDistTolerance = unitCommDesc.CameraLockDistTolerance;
				}
			}
			IBUC_TargetInfoData readOnlyData2 = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(bGUCharacterCS);
			if (readOnlyData2 == null)
			{
				continue;
			}
			bool flag3 = readOnlyData2.CachedLockSkeletonSocket.Count == 1 && readOnlyData2.CachedLockSkeletonSocket[0].Equals("CAMERA_LOCK");
			foreach (string item in readOnlyData2.CachedLockSkeletonSocket)
			{
				if (readOnlyData2.DisabledLockSkeletonSocket.Contains(item))
				{
					continue;
				}
				FVector fVector2 = bGUCharacterCS.Mesh.GetSocketLocation(new FName(item));
				bool flag4 = Owner.GetController() != null && Owner.IsLocallyControlled();
				bool flag5 = true;
				if (flag4)
				{
					UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, fVector2, out var ScreenPosition, bPlayerViewportRelative: false);
					if (ScreenPosition.X <= 0f || ScreenPosition.Y <= 0f || ScreenPosition.X >= fVector2D.X || ScreenPosition.Y >= fVector2D.Y)
					{
						flag5 = false;
					}
				}
				if (flag3 && !flag5)
				{
					fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
				}
				if (flag4)
				{
					UWidgetLayoutLibrary.ProjectWorldLocationToWidgetPosition(firstLocalPlayerController, fVector2, out var ScreenPosition2, bPlayerViewportRelative: false);
					if (ScreenPosition2.X <= 0f || ScreenPosition2.Y <= 0f || ScreenPosition2.X >= fVector2D.X || ScreenPosition2.Y >= fVector2D.Y)
					{
						continue;
					}
				}
				FVector fVector3 = fVector2 - fVector;
				fVector3.Z = 0f;
				float num3 = fVector3.CosineAngle2D(b);
				float num4 = FVector.Dist(fVector, fVector2);
				if (PreferActor != bGUCharacterCS)
				{
					if (num4 > num2)
					{
						continue;
					}
				}
				else if (num4 > num2 + PreferActorDistTolerance)
				{
					continue;
				}
				if (flag4)
				{
					Owner.GetController().GetPlayerViewPoint(out var Location, out var _);
					UBGUSelectUtil.LineTraceSimple(Owner, Location, fVector2, ETraceTypeQuery.TraceTypeQuery1, bDebug: false, out var HitResult, new List<AActor> { bGUCharacterCS });
					if (HitResult.IsBlockingHit && (readOnlyData == null || !readOnlyData.IsInSameCircus(bGUCharacterCS, HitResult.HitActor)))
					{
						continue;
					}
				}
				if (!flag && PreferActor != null && PreferActor == bGUCharacterCS)
				{
					flag = true;
					targetActor = null;
					num = -1000f;
					skeletonSocketName = "";
					flag2 = true;
				}
				float num5 = (0f - num4) * DistScoreRating + num3;
				if (num5 > num)
				{
					num = num5;
					targetActor = bGUCharacterCS;
					skeletonSocketName = item;
					flag2 = flag3;
				}
			}
		}
		if (!flag2)
		{
			return new UnitLockTargetInfo(targetActor, ETargetSourceType.None, ELockTargetWayType.Manual, "", skeletonSocketName);
		}
		return new UnitLockTargetInfo(targetActor, ETargetSourceType.None);
	}

	public static void BGUSetShowAttackRange(AActor Owner, bool bShow, int SkillID)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(Owner))
		{
			return;
		}
		if (bShow)
		{
			FUStPlayerSkillCtrlDesc playerSkillCtrlDesc = BGW_GameDB.GetPlayerSkillCtrlDesc(SkillID, Owner);
			if (!BGW_LogUtil.LogIfNull(playerSkillCtrlDesc, "Find GetPlayerSkillCtrlDesc failed! SkillID: {0}", SkillID) && (playerSkillCtrlDesc.CanShowSelectShapeAndRangeInCD != EGSYesNo.No || !BGU_CommonUtil.IsSkillInCoolDown(SkillID, Owner)) && BGU_CommonUtil.CheckSkillCanCast(Owner, SkillID, SkillID) == ECanCastSkillResult.CCSR_OK && playerSkillCtrlDesc.IsShowAttackRange != EGSYesNo.No)
			{
				BUS_EventCollectionCS.Get(Owner).Evt_ShowAttackRange.Invoke(SkillID);
			}
		}
		else
		{
			BUS_EventCollectionCS.Get(Owner).Evt_HideAttackRange.Invoke();
		}
	}

	public static void TriggerMonsterGoHome(UObject WorldContext)
	{
		if (b1.FUnctionLibUtil.FunctionLibUtil.ReturnIfUnitNullOrDestroyed(WorldContext) || UGameplayStatics.GetPlayerCharacter(WorldContext, 0) == null)
		{
			return;
		}
		foreach (string actorDataKey in BGU_DataUtil.GetGameInstanceReadonlyData<IBIC_GlobalActorData, BIC_GlobalActorData>(WorldContext).GetActorDataKeys())
		{
			AActor actorByGuid = BGU_DataUtil.GetActorByGuid(WorldContext, actorDataKey);
			if (actorByGuid == null || ((IBUC_ActorBasicData)BGU_DataUtil.GetReadOnlyData<BUC_ActorBasicData>(actorByGuid)).ActorType != BGU_ActorType.CharacterAI || !BGU_CommonUtil.IsInFsmState(actorByGuid, EBGUFSMStateName.FSM_STATE_BATTLE))
			{
				continue;
			}
			BUS_GSEventCollection bUS_GSEventCollection = BUS_EventCollectionCS.Get(actorByGuid);
			if (bUS_GSEventCollection != null)
			{
				bool flag = false;
				IBUC_FollowPartnerData readOnlyData = BGU_DataUtil.GetReadOnlyData<IBUC_FollowPartnerData, b1.BUC_FollowPartnerData>(actorByGuid);
				if (readOnlyData != null && readOnlyData.IsFollowPartnerUnit)
				{
					flag = true;
					bUS_GSEventCollection.Evt_TriggerFsmEvent.Invoke(BGW_FlowUtils.FollowPartnerAIFsmEventTag.BackToPlayer);
				}
				if (!flag)
				{
					bUS_GSEventCollection.Evt_OnLeaveFight.Invoke();
					BUS_EventCollectionCS.Get(actorByGuid).Evt_NotifyUnitReturnHome.Invoke(P1: false);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyTest")]
	private static void DeadPhyTest__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DeadPhyTest_Unit_Offset));
		DeadPhyTest(unit);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyReset")]
	private static void DeadPhyReset__Invoker(IntPtr buffer, IntPtr obj)
	{
		AActor unit = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, DeadPhyReset_Unit_Offset));
		DeadPhyReset(unit);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealClass = NativeReflection.GetClass("/Script/b1-Managed.BGUFuncLibSelectTargetsCS");
		DeadPhyTest_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeadPhyTest");
		DeadPhyTest_ParamsSize = NativeReflection.GetFunctionParamsSize(DeadPhyTest_FunctionAddress);
		DeadPhyTest_Unit_Offset = NativeReflection.GetPropertyOffset(DeadPhyTest_FunctionAddress, "Unit");
		DeadPhyTest_Unit_IsValid = NativeReflection.ValidatePropertyClass(DeadPhyTest_FunctionAddress, "Unit", Classes.FObjectProperty);
		DeadPhyTest_IsValid = DeadPhyTest_FunctionAddress != IntPtr.Zero && DeadPhyTest_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyTest", DeadPhyTest_IsValid);
		DeadPhyReset_FunctionAddress = NativeReflectionCached.GetFunction(unrealClass, "DeadPhyReset");
		DeadPhyReset_ParamsSize = NativeReflection.GetFunctionParamsSize(DeadPhyReset_FunctionAddress);
		DeadPhyReset_Unit_Offset = NativeReflection.GetPropertyOffset(DeadPhyReset_FunctionAddress, "Unit");
		DeadPhyReset_Unit_IsValid = NativeReflection.ValidatePropertyClass(DeadPhyReset_FunctionAddress, "Unit", Classes.FObjectProperty);
		DeadPhyReset_IsValid = DeadPhyReset_FunctionAddress != IntPtr.Zero && DeadPhyReset_Unit_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUFuncLibSelectTargetsCS:DeadPhyReset", DeadPhyReset_IsValid);
	}

	static BGUFuncLibSelectTargetsCS()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUFuncLibSelectTargetsCS)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUFuncLibSelectTargetsCS));
	}
}
