using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQG WanderPoint")]
[UClass]
[BlueprintType]
[Blueprintable]
[USharpPath("/Script/b1-Managed.GSEQG_WanderPointGenerator")]
public class GSEQG_WanderPointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool Dist_IsValid;

	private static int Dist_Offset;

	private static bool Is8Dir_IsValid;

	private static int Is8Dir_Offset;

	private static FFieldAddress Is8Dir_PropertyAddress;

	private static bool RandomRangeDist_IsValid;

	private static int RandomRangeDist_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_WanderPointGenerator:Dist")]
	public float Dist
	{
		get
		{
			CheckDestroyed();
			if (!Dist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:Dist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Dist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Dist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:Dist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Dist_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_WanderPointGenerator:Is8Dir")]
	public bool Is8Dir
	{
		get
		{
			CheckDestroyed();
			if (!Is8Dir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:Is8Dir");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, Is8Dir_Offset), 0, Is8Dir_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!Is8Dir_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:Is8Dir");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, Is8Dir_Offset), 0, Is8Dir_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_WanderPointGenerator:RandomRangeDist")]
	public float RandomRangeDist
	{
		get
		{
			CheckDestroyed();
			if (!RandomRangeDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:RandomRangeDist");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RandomRangeDist_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomRangeDist_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_WanderPointGenerator:RandomRangeDist");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RandomRangeDist_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		Dist = 0f;
		Is8Dir = false;
		RandomRangeDist = 0f;
	}

	[USharpPath("/Script/b1-Managed.GSEQG_WanderPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		float randomNumberFloat = UB1Util.GetRandomNumberFloat(Dist - RandomRangeDist, Dist);
		float randomNumberFloat2 = UB1Util.GetRandomNumberFloat(Dist, Dist + RandomRangeDist);
		float[] array = new float[3] { Dist, randomNumberFloat, randomNumberFloat2 };
		List<FVector> Output;
		float[] array2;
		if (!Is8Dir)
		{
			array2 = array;
			foreach (float distance in array2)
			{
				Calc4DirPoint(ContextLocations[0], distance, out Output);
				foreach (FVector item in Output)
				{
					base.GenerateItemList.Add(item);
				}
			}
			return;
		}
		array2 = array;
		foreach (float distance2 in array2)
		{
			Calc8DirPoint(ContextLocations[0], distance2, out Output);
			foreach (FVector item2 in Output)
			{
				base.GenerateItemList.Add(item2);
			}
		}
	}

	private void Calc4DirPoint(FVector CenterPos, float Distance, out List<FVector> Output)
	{
		AActor aActor = GetQuerier() as AActor;
		Output = new List<FVector>();
		if (aActor != null)
		{
			FVector forwardVector = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor).GetForwardVector();
			for (int i = 0; i < 4; i++)
			{
				FVector item = UMathLibrary.RotateAngleAxis(forwardVector, (float)i * 90f, FVector.UpVector) * Distance + CenterPos;
				item.Z = CenterPos.Z;
				Output.Add(item);
			}
		}
	}

	private void Calc8DirPoint(FVector CenterPos, float Distance, out List<FVector> Output)
	{
		AActor aActor = GetQuerier() as AActor;
		Output = new List<FVector>();
		if (aActor != null)
		{
			FVector forwardVector = BGUFuncLibActorTransformCS.BGUGetActorRotation(aActor).GetForwardVector();
			for (int i = 0; i < 8; i++)
			{
				FVector item = UMathLibrary.RotateAngleAxis(forwardVector, (float)i * 45f, FVector.UpVector) * Distance + CenterPos;
				item.Z = CenterPos.Z;
				Output.Add(item);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_WanderPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_WanderPointGenerator gSEQG_WanderPointGenerator = GCHelper.Find<GSEQG_WanderPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_WanderPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_WanderPointGenerator");
		Dist_Offset = NativeReflection.GetPropertyOffset(intPtr, "Dist");
		Dist_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Dist", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref Is8Dir_PropertyAddress, intPtr, "Is8Dir");
		Is8Dir_Offset = NativeReflection.GetPropertyOffset(intPtr, "Is8Dir");
		Is8Dir_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Is8Dir", Classes.FBoolProperty);
		RandomRangeDist_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomRangeDist");
		RandomRangeDist_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomRangeDist", Classes.FFloatProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_WanderPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_WanderPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_WanderPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_WanderPointGenerator));
	}
}
