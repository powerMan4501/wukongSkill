using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("球面点集")]
[Blueprintable]
[UClass]
[BlueprintType]
[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere")]
internal class GSEQG_PointsOnSphere : UGSEQGBase_ProjectedPoint
{
	private static bool PointNumber_IsValid;

	private static int PointNumber_Offset;

	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool QuerierSocketName_IsValid;

	private static int QuerierSocketName_Offset;

	private static bool DisOrder_IsValid;

	private static int DisOrder_Offset;

	private static FFieldAddress DisOrder_PropertyAddress;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[UProperty]
	[DisplayName("数量")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere:PointNumber")]
	public int PointNumber
	{
		get
		{
			CheckDestroyed();
			if (!PointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:PointNumber");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, PointNumber_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointNumber_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:PointNumber");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, PointNumber_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("半径")]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere:QuerierSocketName")]
	public FName QuerierSocketName
	{
		get
		{
			CheckDestroyed();
			if (!QuerierSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:QuerierSocketName");
				return default(FName);
			}
			return BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(base.Address, QuerierSocketName_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!QuerierSocketName_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:QuerierSocketName");
			}
			else
			{
				BlittableTypeMarshaler<FName>.ToNative(IntPtr.Add(base.Address, QuerierSocketName_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[DisplayName("乱序")]
	[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere:DisOrder")]
	public bool DisOrder
	{
		get
		{
			CheckDestroyed();
			if (!DisOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:DisOrder");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DisOrder_Offset), 0, DisOrder_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DisOrder_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_PointsOnSphere:DisOrder");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DisOrder_Offset), 0, DisOrder_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_PointsOnSphere:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		FVector fVector = aActor.GetActorLocation();
		BGUCharacterCS bGUCharacterCS = aActor as BGUCharacterCS;
		if (bGUCharacterCS != null && bGUCharacterCS.Mesh != null && QuerierSocketName != FName.None)
		{
			fVector = bGUCharacterCS.Mesh.GetSocketLocation(QuerierSocketName);
		}
		new List<FVector>();
		float num = (float)Math.PI * (3f - FMath.Sqrt(5f));
		for (int i = 0; i < PointNumber; i++)
		{
			float num2 = 1f - (float)i / (float)(PointNumber - 1) * 2f;
			float num3 = FMath.Sqrt(1f - num2 * num2);
			float value = num * (float)i;
			float num4 = FMath.Cos(value) * num3;
			float num5 = FMath.Sin(value) * num3;
			base.GenerateItemList.Add(new FVector(num4, num2, num5) * Radius + fVector);
		}
		if (DisOrder)
		{
			Random random = new Random();
			int num6 = base.GenerateItemList.Count;
			while (num6 > 1)
			{
				num6--;
				int index = random.Next(num6 + 1);
				FVector value2 = base.GenerateItemList[index];
				base.GenerateItemList[index] = base.GenerateItemList[num6];
				base.GenerateItemList[num6] = value2;
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_PointsOnSphere:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BGW.EnvQuery.GSEQG_PointsOnSphere gSEQG_PointsOnSphere = GCHelper.Find<b1.BGW.EnvQuery.GSEQG_PointsOnSphere>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_PointsOnSphere.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_PointsOnSphere");
		PointNumber_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointNumber");
		PointNumber_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointNumber", Classes.FIntProperty);
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		QuerierSocketName_Offset = NativeReflection.GetPropertyOffset(intPtr, "QuerierSocketName");
		QuerierSocketName_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "QuerierSocketName", Classes.FNameProperty);
		NativeReflection.GetPropertyRef(ref DisOrder_PropertyAddress, intPtr, "DisOrder");
		DisOrder_Offset = NativeReflection.GetPropertyOffset(intPtr, "DisOrder");
		DisOrder_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DisOrder", Classes.FBoolProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_PointsOnSphere:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_PointsOnSphere()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGW.EnvQuery.GSEQG_PointsOnSphere)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGW.EnvQuery.GSEQG_PointsOnSphere));
	}
}
