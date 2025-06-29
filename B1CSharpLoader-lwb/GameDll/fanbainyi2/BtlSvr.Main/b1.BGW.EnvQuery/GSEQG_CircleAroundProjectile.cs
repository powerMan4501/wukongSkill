using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQG CircleAroundProjectile")]
[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile")]
public class GSEQG_CircleAroundProjectile : UGSEQGBase_ProjectedPoint
{
	private static bool ProjectileID_IsValid;

	private static int ProjectileID_Offset;

	private static bool PointNumber_IsValid;

	private static int PointNumber_Offset;

	private static bool CircleRadius_IsValid;

	private static int CircleRadius_Offset;

	private static bool ZOffset_IsValid;

	private static int ZOffset_Offset;

	private static bool LeftFvector_IsValid;

	private static int LeftFvector_Offset;

	private static bool RightFvector_IsValid;

	private static int RightFvector_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[Tooltip("填 ‘0’ 代表所有子弹")]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ProjectileID")]
	public int ProjectileID
	{
		get
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ProjectileID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ProjectileID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ProjectileID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ProjectileID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ProjectileID_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("点数量")]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:PointNumber")]
	public int PointNumber
	{
		get
		{
			CheckDestroyed();
			if (!PointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:PointNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:PointNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointNumber_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("半径")]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:CircleRadius")]
	public float CircleRadius
	{
		get
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:CircleRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CircleRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CircleRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:CircleRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CircleRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Z轴偏移")]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ZOffset")]
	public float ZOffset
	{
		get
		{
			CheckDestroyed();
			if (!ZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ZOffset");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ZOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ZOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:ZOffset");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ZOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Left偏移Fvector")]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:LeftFvector")]
	public FVector LeftFvector
	{
		get
		{
			CheckDestroyed();
			if (!LeftFvector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:LeftFvector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, LeftFvector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LeftFvector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:LeftFvector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, LeftFvector_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("Right偏移Fvector")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:RightFvector")]
	public FVector RightFvector
	{
		get
		{
			CheckDestroyed();
			if (!RightFvector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:RightFvector");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, RightFvector_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RightFvector_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CircleAroundProjectile:RightFvector");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, RightFvector_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_CircleAroundProjectile:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (bGUCharacterCS == null)
		{
			return;
		}
		b1.BUC_ProjectileCtrData readOnlyData = BGU_DataUtil.GetReadOnlyData<b1.BUC_ProjectileCtrData>(bGUCharacterCS);
		if (readOnlyData == null)
		{
			return;
		}
		List<AActor> list = new List<AActor>();
		if (readOnlyData.ProjectileList != null)
		{
			foreach (BGUProjectileBaseActor projectile in readOnlyData.ProjectileList)
			{
				if (ProjectileID != 0 && projectile.GetProjectileID() == ProjectileID)
				{
					list.Add(projectile);
				}
				else if (ProjectileID == 0)
				{
					list.Add(projectile);
				}
			}
		}
		if (list.Count < 1)
		{
			return;
		}
		float num = 2f / (float)PointNumber;
		for (int i = 0; i < PointNumber; i++)
		{
			FVector fVector = new FVector(UB1Util.GetRandomNumberFloat(LeftFvector.X, RightFvector.X), UB1Util.GetRandomNumberFloat(LeftFvector.Y, RightFvector.Y), UB1Util.GetRandomNumberFloat(LeftFvector.Z, RightFvector.Z));
			FVector fVector2 = new FVector(MathLib.Cos(num * (float)Math.PI * (float)i) * CircleRadius, MathLib.Sin(num * (float)Math.PI * (float)i) * CircleRadius, ZOffset) + fVector;
			foreach (AActor item in list)
			{
				base.GenerateItemList.Add(BGUFuncLibActorTransformCS.BGUGetActorLocation(item) + fVector2);
				if (GSGameplayCVar.CVar_ShowDebugBulletEQG.GetValueInGameThread() == 1)
				{
					USystemLibrary.DrawDebugSphere(bGUCharacterCS, BGUFuncLibActorTransformCS.BGUGetActorLocation(item) + fVector2, 20f, 12, FLinearColor.Red, 0.5f, 4f);
				}
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_CircleAroundProjectile:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_CircleAroundProjectile gSEQG_CircleAroundProjectile = GCHelper.Find<GSEQG_CircleAroundProjectile>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_CircleAroundProjectile.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_CircleAroundProjectile");
		ProjectileID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ProjectileID");
		ProjectileID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ProjectileID", Classes.FIntProperty);
		PointNumber_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointNumber");
		PointNumber_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointNumber", Classes.FIntProperty);
		CircleRadius_Offset = NativeReflection.GetPropertyOffset(intPtr, "CircleRadius");
		CircleRadius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CircleRadius", Classes.FFloatProperty);
		ZOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ZOffset");
		ZOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ZOffset", Classes.FFloatProperty);
		LeftFvector_Offset = NativeReflection.GetPropertyOffset(intPtr, "LeftFvector");
		LeftFvector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LeftFvector", Classes.FStructProperty);
		RightFvector_Offset = NativeReflection.GetPropertyOffset(intPtr, "RightFvector");
		RightFvector_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RightFvector", Classes.FStructProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_CircleAroundProjectile:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_CircleAroundProjectile()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_CircleAroundProjectile)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_CircleAroundProjectile));
	}
}
