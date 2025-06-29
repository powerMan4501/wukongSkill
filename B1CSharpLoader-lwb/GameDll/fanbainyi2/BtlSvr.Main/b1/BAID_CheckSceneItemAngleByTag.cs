using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag")]
internal class BAID_CheckSceneItemAngleByTag : BAID_Base
{
	private static bool BoneName_IsValid;

	private static int BoneName_Offset;

	private static bool SceneItemTag_IsValid;

	private static int SceneItemTag_Offset;

	private static bool MinDistance_IsValid;

	private static int MinDistance_Offset;

	private static bool MaxDistance_IsValid;

	private static int MaxDistance_Offset;

	private static bool AngleValue_IsValid;

	private static int AngleValue_Offset;

	[Tooltip("如果不填，则直接使用角色正朝向")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[DisplayName("角色对准骨骼名")]
	[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:BoneName")]
	public FName BoneName
	{
		get
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:BoneName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, BoneName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BoneName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:BoneName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, BoneName_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:SceneItemTag")]
	public FName SceneItemTag
	{
		get
		{
			CheckDestroyed();
			if (!SceneItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:SceneItemTag");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, SceneItemTag_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SceneItemTag_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:SceneItemTag");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, SceneItemTag_Offset), value);
			}
		}
	}

	[UProperty]
	[DisplayName("筛选范围最小值")]
	[UMeta(MDProp.ClampMin, "0")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MinDistance")]
	public int MinDistance
	{
		get
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MinDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MinDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MinDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MinDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MinDistance_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("筛选范围最大值")]
	[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MaxDistance")]
	public int MaxDistance
	{
		get
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MaxDistance");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, MaxDistance_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!MaxDistance_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:MaxDistance");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, MaxDistance_Offset), value);
			}
		}
	}

	[Tooltip("是指角色朝向与角色朝SceneItem方向夹角")]
	[DisplayName("判断角度")]
	[UMeta(MDProp.ClampMax, "180")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[USharpPath("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:AngleValue")]
	public int AngleValue
	{
		get
		{
			CheckDestroyed();
			if (!AngleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:AngleValue");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AngleValue_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AngleValue_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag:AngleValue");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AngleValue_Offset), value);
			}
		}
	}

	public override bool PerformConditionCheck(AActor OwnerActor)
	{
		if (OwnerActor.IsNullOrDestroyed())
		{
			return false;
		}
		BGUCharacterCS bGUCharacterCS = OwnerActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return false;
		}
		BGU_DataUtil.GetGameStateReadonlyData<IBGC_LevelActorData, BGC_LevelActorData>(OwnerActor).GetSceneItemsByTag(SceneItemTag, out var OutSceneItems);
		if (OutSceneItems != null && OutSceneItems.Count > 0)
		{
			_ = FVector.ZeroVector;
			FVector safeNormal2D = BGUFuncLibActorTransformCS.BGUGetActorForwardVector(bGUCharacterCS).GetSafeNormal2D();
			FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(bGUCharacterCS);
			if (!BoneName.Equals(FName.None))
			{
				int boneIndex = bGUCharacterCS.Mesh.GetBoneIndex(BoneName);
				if (boneIndex > 0)
				{
					safeNormal2D = (UGSE_AnimFuncLib.GetBoneTransform(bGUCharacterCS.Mesh, boneIndex).GetLocation() - fVector).GetSafeNormal2D();
				}
			}
			FVector2D unitRotateAimDir = new FVector2D(safeNormal2D);
			foreach (AActor item in OutSceneItems)
			{
				if (item != null)
				{
					FVector v = BGUFuncLibActorTransformCS.BGUGetActorLocation(item);
					float num = FVector.Distance(v, fVector);
					if (num >= (float)MinDistance && num <= (float)MaxDistance && BGU_MoveUtil.GetRotateAngle2D(unitRotateAimDir, new FVector2D(v.X - fVector.X, v.Y - fVector.Y)) <= (float)AngleValue)
					{
						return true;
					}
				}
			}
		}
		return false;
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BAID_CheckSceneItemAngleByTag");
		BoneName_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "BoneName");
		BoneName_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "BoneName", Classes.FNameProperty);
		SceneItemTag_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "SceneItemTag");
		SceneItemTag_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "SceneItemTag", Classes.FNameProperty);
		MinDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MinDistance");
		MinDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MinDistance", Classes.FIntProperty);
		MaxDistance_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "MaxDistance");
		MaxDistance_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "MaxDistance", Classes.FIntProperty);
		AngleValue_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AngleValue");
		AngleValue_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AngleValue", Classes.FIntProperty);
	}

	static BAID_CheckSceneItemAngleByTag()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BAID_CheckSceneItemAngleByTag)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BAID_CheckSceneItemAngleByTag));
	}
}
