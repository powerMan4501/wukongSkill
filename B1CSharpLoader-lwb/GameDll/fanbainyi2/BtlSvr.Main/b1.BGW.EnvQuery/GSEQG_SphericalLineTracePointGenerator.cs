using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[BlueprintType]
[DisplayName("GS EQG SphericalLineTracePointGenerator")]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator")]
public class GSEQG_SphericalLineTracePointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool RangeDir_X_IsValid;

	private static int RangeDir_X_Offset;

	private static bool RangeDir_Y_IsValid;

	private static int RangeDir_Y_Offset;

	private static bool RangeDir_Z_IsValid;

	private static int RangeDir_Z_Offset;

	private static bool LineTraceNum_IsValid;

	private static int LineTraceNum_Offset;

	private static bool LineTraceMaxLength_IsValid;

	private static int LineTraceMaxLength_Offset;

	private static bool TraceTypeQuery_IsValid;

	private static int TraceTypeQuery_Offset;

	private static FFieldAddress TraceTypeQuery_PropertyAddress;

	private static bool PointMinBetween_IsValid;

	private static int PointMinBetween_Offset;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_X")]
	public FFloatRange RangeDir_X
	{
		get
		{
			CheckDestroyed();
			if (!RangeDir_X_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_X");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, RangeDir_X_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeDir_X_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_X");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, RangeDir_X_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Y")]
	public FFloatRange RangeDir_Y
	{
		get
		{
			CheckDestroyed();
			if (!RangeDir_Y_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Y");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, RangeDir_Y_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeDir_Y_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Y");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, RangeDir_Y_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Z")]
	public FFloatRange RangeDir_Z
	{
		get
		{
			CheckDestroyed();
			if (!RangeDir_Z_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Z");
				return default(FFloatRange);
			}
			return BlittableTypeMarshaler<FFloatRange>.FromNative(IntPtr.Add(base.Address, RangeDir_Z_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RangeDir_Z_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:RangeDir_Z");
			}
			else
			{
				BlittableTypeMarshaler<FFloatRange>.ToNative(IntPtr.Add(base.Address, RangeDir_Z_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceNum")]
	public int LineTraceNum
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, LineTraceNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, LineTraceNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceMaxLength")]
	public float LineTraceMaxLength
	{
		get
		{
			CheckDestroyed();
			if (!LineTraceMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceMaxLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LineTraceMaxLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LineTraceMaxLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:LineTraceMaxLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LineTraceMaxLength_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:TraceTypeQuery")]
	public ETraceTypeQuery TraceTypeQuery
	{
		get
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:TraceTypeQuery");
				return ETraceTypeQuery.TraceTypeQuery1;
			}
			return EnumMarshaler<ETraceTypeQuery>.FromNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!TraceTypeQuery_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:TraceTypeQuery");
			}
			else
			{
				EnumMarshaler<ETraceTypeQuery>.ToNative(IntPtr.Add(base.Address, TraceTypeQuery_Offset), 0, TraceTypeQuery_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:PointMinBetween")]
	public float PointMinBetween
	{
		get
		{
			CheckDestroyed();
			if (!PointMinBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:PointMinBetween");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, PointMinBetween_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PointMinBetween_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:PointMinBetween");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, PointMinBetween_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		AActor aActor = GetQuerier() as AActor;
		if (aActor.IsNullOrDestroyed())
		{
			return;
		}
		for (int i = 0; i < 5; i++)
		{
			for (int j = 0; j < LineTraceNum; j++)
			{
				float num = MathLib.RandomFloatInRange(RangeDir_X.LowerBound.Value, RangeDir_X.UpperBound.Value);
				float num2 = MathLib.RandomFloatInRange(RangeDir_Y.LowerBound.Value, RangeDir_Y.UpperBound.Value);
				float num3 = MathLib.RandomFloatInRange(RangeDir_Z.LowerBound.Value, RangeDir_Z.UpperBound.Value);
				FVector fVector = UMathLibrary_CsExtensions.TransformDirection(Direction: new FVector(num, num2, num3), T: BGUFuncLibActorTransformCS.BGUGetActorTransform(aActor));
				fVector.Normalize();
				FVector fVector2 = BGUFuncLibActorTransformCS.BGUGetActorLocation(aActor);
				FVector endTrace = fVector2 + fVector * LineTraceMaxLength;
				if (UBGUSelectUtil.LineTraceSimple(aActor.World, fVector2, endTrace, TraceTypeQuery, bDebug: false, out var HitResult, null) != 1)
				{
					continue;
				}
				bool flag = false;
				if (PointMinBetween > 0f)
				{
					foreach (FVector generateItem in base.GenerateItemList)
					{
						flag |= FVector.Distance(generateItem, HitResult.HitLocation) < PointMinBetween;
					}
				}
				if (!flag)
				{
					base.GenerateItemList.Add(HitResult.HitLocation);
					if (base.GenerateItemList.Count >= LineTraceNum)
					{
						break;
					}
				}
			}
			if (base.GenerateItemList.Count >= LineTraceNum)
			{
				break;
			}
		}
	}

	private FVector GetSpherePos(float RandomX, float RandomY)
	{
		float value = (float)Math.PI * 2f * RandomX;
		float num = 1f - 2f * RandomY;
		float num2 = MathLib.Sqrt(1f - num * num);
		return new FVector(num2 * FMath.Cos(value), num2 * FMath.Sin(value), num);
	}

	private void V1Gen()
	{
	}

	private void V2Gen()
	{
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_SphericalLineTracePointGenerator gSEQG_SphericalLineTracePointGenerator = GCHelper.Find<GSEQG_SphericalLineTracePointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_SphericalLineTracePointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator");
		RangeDir_X_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_X");
		RangeDir_X_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_X", Classes.FStructProperty);
		RangeDir_Y_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_Y");
		RangeDir_Y_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_Y", Classes.FStructProperty);
		RangeDir_Z_Offset = NativeReflection.GetPropertyOffset(intPtr, "RangeDir_Z");
		RangeDir_Z_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RangeDir_Z", Classes.FStructProperty);
		LineTraceNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceNum");
		LineTraceNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceNum", Classes.FIntProperty);
		LineTraceMaxLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTraceMaxLength");
		LineTraceMaxLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTraceMaxLength", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref TraceTypeQuery_PropertyAddress, intPtr, "TraceTypeQuery");
		TraceTypeQuery_Offset = NativeReflection.GetPropertyOffset(intPtr, "TraceTypeQuery");
		TraceTypeQuery_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TraceTypeQuery", Classes.FEnumProperty);
		PointMinBetween_Offset = NativeReflection.GetPropertyOffset(intPtr, "PointMinBetween");
		PointMinBetween_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PointMinBetween", Classes.FFloatProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_SphericalLineTracePointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_SphericalLineTracePointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_SphericalLineTracePointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_SphericalLineTracePointGenerator));
	}
}
