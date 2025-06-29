using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.Specialized;
using UnrealEngine.Engine;
using UnrealEngine.Landscape;
using UnrealEngine.Plugins.Niagara;
using UnrealEngine.Runtime;

namespace b1;

public class BUC_InteractDrawData
{
	public TStrongObjectPtr<UNiagaraComponent> NS_Simulator = new TStrongObjectPtr<UNiagaraComponent>();

	public TStrongObjectPtr<UNiagaraComponent> NS_Particles = new TStrongObjectPtr<UNiagaraComponent>();

	public TStrongObjectPtr<UMaterialParameterCollection> GlobalMPC = new TStrongObjectPtr<UMaterialParameterCollection>();

	public TStrongObjectPtr<UNiagaraParameterCollectionInstance> GlobalNPC = new TStrongObjectPtr<UNiagaraParameterCollectionInstance>();

	public TStrongObjectPtr<UMaterial> M_CombineTexture = new TStrongObjectPtr<UMaterial>();

	public TStrongObjectPtr<UTextureRenderTarget2D> RT_LandscapeMap = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public float InteractiveDataStorageSize;

	public float SimulationSize;

	public float DataStorageRTSize;

	public FDispInteractLandscapeInfo InteractLandscapeInfo;

	public FVector centerSnappedPos;

	public FVector centerOffset;

	public FVector centerSnappedOffset;

	public FVector centerPos_Previous;

	public FVector centerSnappedPos_Previous;

	public List<FVector> World_to_LandscapeUV_Transform;

	private Dictionary<int, int> actorID_previous_dict = new Dictionary<int, int>();

	private Dictionary<int, FVector4> data_previous_dict = new Dictionary<int, FVector4>();

	private Dictionary<int, FVector4> data_twoBefore_dict = new Dictionary<int, FVector4>();

	private OrderedDictionary data_toNiagara_pos_dict = new OrderedDictionary();

	private OrderedDictionary data_toNiagara_velocity_dict = new OrderedDictionary();

	private bool havePreviousData;

	public Dictionary<int, FDispInteractInfo> previousData_dict = new Dictionary<int, FDispInteractInfo>();

	public Dictionary<int, FDispInteractInfo> twoBeforeData_dict = new Dictionary<int, FDispInteractInfo>();

	private FVector SnapToPixelWorldSize(FVector origPos)
	{
		float num = DataStorageRTSize / InteractiveDataStorageSize;
		float num2 = FMath.FloorToFloat(num * origPos.X + 0.5f) / num;
		float num3 = FMath.FloorToFloat(num * origPos.Y + 0.5f) / num;
		return new FVector(num2, num3, origPos.Z);
	}

	private FVector2D CustomTransformVector2D(FVector VectorToTransform, List<FVector> CustomTransform)
	{
		float num = FVector.DotProduct(VectorToTransform, CustomTransform[0]);
		float num2 = FVector.DotProduct(VectorToTransform, CustomTransform[1]);
		return new FVector2D(num, num2);
	}

	public void ComputeSnappedPosOffset(AActor ACenter)
	{
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(ACenter);
		centerSnappedPos = SnapToPixelWorldSize(fVector);
		if (centerPos_Previous == FVector.ZeroVector)
		{
			centerPos_Previous = fVector;
		}
		if (centerSnappedPos_Previous == FVector.ZeroVector)
		{
			centerSnappedPos_Previous = centerSnappedPos;
		}
		centerOffset = fVector - centerPos_Previous;
		centerSnappedOffset = centerSnappedPos - centerSnappedPos_Previous;
	}

	public List<FVector> GetTransform_WorldtoUVSpace(FDispInteractLandscapeInfo LandscapeInfo)
	{
		ALandscape landscape = LandscapeInfo.Landscape;
		FVector landscapeOriginOffset = LandscapeInfo._LandscapeOriginOffset;
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(landscape);
		FVector actorScale3D = landscape.GetActorScale3D();
		int vertexCount_Width = LandscapeInfo.VertexCount_Width;
		int vertexCount_Height = LandscapeInfo.VertexCount_Height;
		float value = BGUFuncLibActorTransformCS.BGUGetActorRotation(landscape).Yaw / -180f * (float)Math.PI;
		float num = FMath.Cos(value);
		float num2 = FMath.Sin(value);
		float num3 = actorScale3D.X * 0.5f - (fVector.X * num - fVector.Y * num2 + actorScale3D.X * landscapeOriginOffset.X);
		FVector item = new FVector(num, 0f - num2, num3);
		item /= (double)((float)vertexCount_Width * actorScale3D.X);
		float num4 = actorScale3D.Y * 0.5f - (num2 * fVector.X + num * fVector.Y + actorScale3D.Y * landscapeOriginOffset.Y);
		FVector item2 = new FVector(num2, num, num4);
		item2 /= (double)((float)vertexCount_Height * actorScale3D.Y);
		return new List<FVector> { item, item2 };
	}

	public void PrepareMotionDataForNiagara(List<FDispInteractInfo> DataArray, AActor Owner)
	{
		for (int i = 0; i < DataArray.Count; i++)
		{
			int num = 1;
			if (actorID_previous_dict.TryGetValue(i, out var value))
			{
				havePreviousData = value == num;
			}
			else
			{
				actorID_previous_dict.Add(i, 0);
				havePreviousData = false;
			}
			actorID_previous_dict[i] = num;
			FVector firstPos = DataArray[i].FirstPos;
			FVector nextPos = DataArray[i].NextPos;
			FVector fVector = firstPos - centerSnappedPos;
			fVector.Z = firstPos.Z;
			FVector fVector2 = nextPos - centerSnappedPos;
			fVector2.Z = nextPos.Z;
			FVector4 fVector3 = new FVector4(fVector, DataArray[i].FirstRadius);
			FVector4 fVector4 = new FVector4(fVector2, DataArray[i].NextRadius);
			FVector4 fVector5;
			FVector fVector6;
			if (data_previous_dict.TryGetValue(i * 2, out var value2) && havePreviousData)
			{
				fVector5 = value2 - new FVector4(centerSnappedOffset, 0.0);
				fVector6 = new FVector(value2.X, value2.Y, value2.Z);
			}
			else
			{
				fVector5 = new FVector4(fVector3.X - 5f, fVector3.Y - 5f, fVector3.Z, fVector3.W);
				fVector6 = fVector;
			}
			FVector4 fVector7;
			FVector fVector8;
			if (data_previous_dict.TryGetValue(i * 2 + 1, out var value3) && havePreviousData)
			{
				fVector7 = value3 - new FVector4(centerSnappedOffset, 0.0);
				fVector8 = new FVector(value3.X, value3.Y, value3.Z);
			}
			else
			{
				fVector7 = new FVector4(fVector4.X + 5f, fVector4.Y + 5f, fVector4.Z, fVector4.W);
				fVector8 = fVector2;
			}
			FVector4 value4;
			FVector fVector9 = ((!data_twoBefore_dict.TryGetValue(i * 2, out value4) || !havePreviousData) ? fVector6 : new FVector(value4.X, value4.Y, value4.Z));
			FVector4 value5;
			FVector fVector10 = ((!data_twoBefore_dict.TryGetValue(i * 2 + 1, out value5) || !havePreviousData) ? fVector8 : new FVector(value5.X, value5.Y, value5.Z));
			FVector item = fVector - fVector6 + centerSnappedOffset;
			FVector item2 = fVector2 - fVector8 + centerSnappedOffset;
			FVector item3 = fVector6 - fVector9 + centerSnappedOffset;
			FVector item4 = fVector8 - fVector10 + centerSnappedOffset;
			List<FVector4> list = new List<FVector4> { fVector3, fVector4, fVector5, fVector7 };
			List<FVector> list2 = new List<FVector> { item, item2, item3, item4 };
			for (int j = 0; j < 4; j++)
			{
				int num2 = i * 4 + j;
				if (!data_toNiagara_pos_dict.Contains(num2))
				{
					data_toNiagara_pos_dict.Add(num2, list[j]);
				}
				else
				{
					data_toNiagara_pos_dict[num2] = list[j];
				}
				if (!data_toNiagara_velocity_dict.Contains(num2))
				{
					data_toNiagara_velocity_dict.Add(num2, list2[j]);
				}
				else
				{
					data_toNiagara_velocity_dict[num2] = list2[j];
				}
			}
			if (!data_twoBefore_dict.TryGetValue(i * 2, out var _))
			{
				data_twoBefore_dict.Add(i * 2, FVector4.ZeroVector);
			}
			if (!data_twoBefore_dict.TryGetValue(i * 2 + 1, out var _))
			{
				data_twoBefore_dict.Add(i * 2 + 1, FVector4.ZeroVector);
			}
			data_twoBefore_dict[i * 2] = fVector5;
			data_twoBefore_dict[i * 2 + 1] = fVector7;
			if (!data_previous_dict.TryGetValue(i * 2, out var _))
			{
				data_previous_dict.Add(i * 2, FVector4.ZeroVector);
			}
			if (!data_twoBefore_dict.TryGetValue(i * 2 + 1, out var _))
			{
				data_previous_dict.Add(i * 2 + 1, FVector4.ZeroVector);
			}
			data_previous_dict[i * 2] = fVector3;
			data_previous_dict[i * 2 + 1] = fVector4;
		}
		List<FVector4> list3 = new List<FVector4>();
		foreach (DictionaryEntry item7 in data_toNiagara_pos_dict)
		{
			FVector4 item5 = (FVector4)item7.Value;
			list3.Add(item5);
		}
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector4(NS_Simulator.Get(), new FName("User.Data"), list3);
		foreach (FVector4 item8 in list3)
		{
			FVector fVector11 = new FVector(centerSnappedPos.X, centerSnappedPos.Y, 0.0);
			_ = new FVector(item8.X, item8.Y, item8.Z) + fVector11;
		}
		List<FVector> list4 = new List<FVector>();
		foreach (DictionaryEntry item9 in data_toNiagara_velocity_dict)
		{
			FVector item6 = (FVector)item9.Value;
			list4.Add(item6);
		}
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(NS_Simulator.Get(), new FName("User.VelocityData"), list4);
		foreach (FDispInteractInfo item10 in DataArray)
		{
			_ = item10;
			int num3 = 1;
			for (int num4 = actorID_previous_dict.Count - 1; num4 >= 0; num4--)
			{
				if (actorID_previous_dict.TryGetValue(num4, out var value10) && num3 != value10)
				{
					actorID_previous_dict.Remove(value10);
				}
			}
		}
	}

	public void TickSendData(FDispInteractLandscapeInfo landscapeInfo, AActor Owner)
	{
		UNiagaraDataInterfaceArrayFunctionLibrary.SetNiagaraArrayVector(NS_Simulator.Get(), new FName("User.World_to_LandscapeUV_Transform"), World_to_LandscapeUV_Transform);
		NS_Simulator.Get()?.SetNiagaraVariableVec3("User.PlayerSnappedPos_WorldSpace", centerSnappedPos);
		NS_Simulator.Get()?.SetNiagaraVariableVec3("User.PlayerOffset_VirtualSpace", centerSnappedOffset / InteractiveDataStorageSize);
		GlobalNPC.Get()?.SetVectorParameter("PlayerSnappedPos_WorldSpace", centerSnappedPos);
		UMaterialLibrary.SetVectorParameterValue(Owner.World, GlobalMPC.Get(), new FName("PlayerSnappedPos_WorldSpace"), new FLinearColor(centerSnappedPos));
	}

	public void StoreCurPosition()
	{
		centerSnappedPos_Previous = centerSnappedPos;
	}
}
