using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[DisplayName("GS EQG Landing Point")]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator")]
public class GSEQG_LandingPointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool ExtentX_IsValid;

	private static int ExtentX_Offset;

	private static bool ExtentY_IsValid;

	private static int ExtentY_Offset;

	private static bool SpawnPointNumPerXDir_IsValid;

	private static int SpawnPointNumPerXDir_Offset;

	private static bool SpawnPointNumPerYDir_IsValid;

	private static int SpawnPointNumPerYDir_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[DisplayName("生成范围X延展")]
	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentX")]
	public float ExtentX
	{
		get
		{
			CheckDestroyed();
			if (!ExtentX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentX");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ExtentX_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtentX_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentX");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ExtentX_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[DisplayName("生成范围Y延展")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentY")]
	public float ExtentY
	{
		get
		{
			CheckDestroyed();
			if (!ExtentY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentY");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, ExtentY_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ExtentY_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:ExtentY");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, ExtentY_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("X方向生成点数量")]
	[UMeta(MDProp.ClampMin, "0")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerXDir")]
	public int SpawnPointNumPerXDir
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPointNumPerXDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerXDir");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpawnPointNumPerXDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPointNumPerXDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerXDir");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpawnPointNumPerXDir_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MDProp.ClampMin, "0")]
	[DisplayName("Y方向生成点数量")]
	[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerYDir")]
	public int SpawnPointNumPerYDir
	{
		get
		{
			CheckDestroyed();
			if (!SpawnPointNumPerYDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerYDir");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, SpawnPointNumPerYDir_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!SpawnPointNumPerYDir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_LandingPointGenerator:SpawnPointNumPerYDir");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, SpawnPointNumPerYDir_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_LandingPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null || SpawnPointNumPerXDir == 0 || SpawnPointNumPerYDir == 0)
		{
			return;
		}
		FVector fVector = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
		FVector actorForwardVector = aActor.GetActorForwardVector();
		FVector actorRightVector = aActor.GetActorRightVector();
		float num = ExtentX / (float)(SpawnPointNumPerXDir / 2);
		float num2 = ExtentY / (float)(SpawnPointNumPerYDir / 2);
		List<FVector> list = new List<FVector>();
		for (int i = 0; i < SpawnPointNumPerXDir; i++)
		{
			for (int j = 0; j < SpawnPointNumPerYDir; j++)
			{
				FVector item = fVector - actorForwardVector * num * i;
				item += actorRightVector * num2 * j;
				item += actorForwardVector * num * SpawnPointNumPerXDir / 2.0;
				item -= actorRightVector * num2 * SpawnPointNumPerYDir / 2.0;
				list.Add(item);
			}
		}
		CalcResultPoint(list);
	}

	private void CalcResultPoint(List<FVector> GenPoints)
	{
		foreach (FVector GenPoint in GenPoints)
		{
			base.GenerateItemList.Add(GenPoint);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_LandingPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_LandingPointGenerator gSEQG_LandingPointGenerator = GCHelper.Find<GSEQG_LandingPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_LandingPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_LandingPointGenerator");
		ExtentX_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtentX");
		ExtentX_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtentX", Classes.FFloatProperty);
		ExtentY_Offset = NativeReflection.GetPropertyOffset(intPtr, "ExtentY");
		ExtentY_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ExtentY", Classes.FFloatProperty);
		SpawnPointNumPerXDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointNumPerXDir");
		SpawnPointNumPerXDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointNumPerXDir", Classes.FIntProperty);
		SpawnPointNumPerYDir_Offset = NativeReflection.GetPropertyOffset(intPtr, "SpawnPointNumPerYDir");
		SpawnPointNumPerYDir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SpawnPointNumPerYDir", Classes.FIntProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_LandingPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_LandingPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_LandingPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_LandingPointGenerator));
	}
}
