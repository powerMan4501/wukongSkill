using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.NavigationSystem;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator")]
public class GSEQG_AreaPointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool ContextOffset_IsValid;

	private static int ContextOffset_Offset;

	private static bool XLength_IsValid;

	private static int XLength_Offset;

	private static bool YLength_IsValid;

	private static int YLength_Offset;

	private static bool XSplitNum_IsValid;

	private static int XSplitNum_Offset;

	private static bool YSplitNum_IsValid;

	private static int YSplitNum_Offset;

	private static bool bFilterPathFinding_IsValid;

	private static int bFilterPathFinding_Offset;

	private static FFieldAddress bFilterPathFinding_PropertyAddress;

	private static bool bFilterLineTracing_IsValid;

	private static int bFilterLineTracing_Offset;

	private static FFieldAddress bFilterLineTracing_PropertyAddress;

	private static bool RandomFilterPointNum_IsValid;

	private static int RandomFilterPointNum_Offset;

	private static bool bEnableDebug_IsValid;

	private static int bEnableDebug_Offset;

	private static FFieldAddress bEnableDebug_PropertyAddress;

	private static bool LineTracingIgnoreActors_IsValid;

	private static int LineTracingIgnoreActors_Offset;

	private static FFieldAddress LineTracingIgnoreActors_PropertyAddress;

	private TArrayReadWriteMarshaler<AActor> LineTracingIgnoreActors_Marshaler;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[UProperty]
	[EditAnywhere]
	[Category("AreaCommon")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:ContextOffset")]
	protected FVector ContextOffset
	{
		get
		{
			CheckDestroyed();
			if (!ContextOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:ContextOffset");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, ContextOffset_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ContextOffset_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:ContextOffset");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, ContextOffset_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AreaCommon")]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:XLength")]
	protected float XLength
	{
		get
		{
			CheckDestroyed();
			if (!XLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:XLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, XLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:XLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, XLength_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AreaCommon")]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:YLength")]
	protected float YLength
	{
		get
		{
			CheckDestroyed();
			if (!YLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:YLength");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, YLength_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YLength_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:YLength");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, YLength_Offset), value);
			}
		}
	}

	[BlueprintReadWrite]
	[EditAnywhere]
	[Category("AreaCommon")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:XSplitNum")]
	protected int XSplitNum
	{
		get
		{
			CheckDestroyed();
			if (!XSplitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:XSplitNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, XSplitNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!XSplitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:XSplitNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, XSplitNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[Category("AreaCommon")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:YSplitNum")]
	protected int YSplitNum
	{
		get
		{
			CheckDestroyed();
			if (!YSplitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:YSplitNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, YSplitNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!YSplitNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:YSplitNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, YSplitNum_Offset), value);
			}
		}
	}

	[UProperty]
	[Category("Filter")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterPathFinding")]
	protected bool bFilterPathFinding
	{
		get
		{
			CheckDestroyed();
			if (!bFilterPathFinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterPathFinding");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFilterPathFinding_Offset), 0, bFilterPathFinding_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFilterPathFinding_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterPathFinding");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFilterPathFinding_Offset), 0, bFilterPathFinding_PropertyAddress.Address, value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[Category("Filter")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterLineTracing")]
	protected bool bFilterLineTracing
	{
		get
		{
			CheckDestroyed();
			if (!bFilterLineTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterLineTracing");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bFilterLineTracing_Offset), 0, bFilterLineTracing_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bFilterLineTracing_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bFilterLineTracing");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bFilterLineTracing_Offset), 0, bFilterLineTracing_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[Category("Filter")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:RandomFilterPointNum")]
	protected int RandomFilterPointNum
	{
		get
		{
			CheckDestroyed();
			if (!RandomFilterPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:RandomFilterPointNum");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, RandomFilterPointNum_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomFilterPointNum_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:RandomFilterPointNum");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, RandomFilterPointNum_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("AreaCommon")]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:bEnableDebug")]
	protected bool bEnableDebug
	{
		get
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bEnableDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnableDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:bEnableDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnableDebug_Offset), 0, bEnableDebug_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Filter")]
	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:LineTracingIgnoreActors")]
	protected TArrayReadWrite<AActor> LineTracingIgnoreActors
	{
		get
		{
			CheckDestroyed();
			if (!LineTracingIgnoreActors_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_AreaPointGenerator:LineTracingIgnoreActors");
				return null;
			}
			if (LineTracingIgnoreActors_Marshaler == null)
			{
				LineTracingIgnoreActors_Marshaler = new TArrayReadWriteMarshaler<AActor>(1, LineTracingIgnoreActors_PropertyAddress, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.FromNative, CachedMarshalingDelegates<AActor, UObjectMarshaler<AActor>>.ToNative);
			}
			return LineTracingIgnoreActors_Marshaler.FromNative(IntPtr.Add(base.Address, LineTracingIgnoreActors_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQG_AreaPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		foreach (FVector ContextLocation in ContextLocations)
		{
			GeneratePoints(ContextLocation);
		}
	}

	protected void GeneratePoints(FVector ContextLocation)
	{
		float num = XLength / (float)XSplitNum;
		float num2 = YLength / (float)YSplitNum;
		int num3 = XSplitNum * YSplitNum;
		FVector fVector = new FVector(ContextLocation.X - XLength / 2f, ContextLocation.Y - YLength / 2f, ContextLocation.Z);
		List<FVector> list = new List<FVector>();
		for (int i = 0; i < num3; i++)
		{
			float randomNumberFloat = UB1Util.GetRandomNumberFloat(0f, num);
			float randomNumberFloat2 = UB1Util.GetRandomNumberFloat(0f, num2);
			int num4 = i % XSplitNum;
			int num5 = i / XSplitNum;
			FVector fVector2 = ContextOffset + fVector + new FVector((float)num4 * num, (float)num5 * num2, 0.0) + new FVector(randomNumberFloat, randomNumberFloat2, 0.0);
			if (CheckPathFinding(ContextLocation, fVector2) && CheckLineTrace(ContextLocation, fVector2))
			{
				list.Add(fVector2);
			}
		}
		if (list.Count <= RandomFilterPointNum)
		{
			AddGeneratedVectors(list);
			return;
		}
		int num6 = list.Count - 1;
		for (int j = 0; j < RandomFilterPointNum; j++)
		{
			int randomNumberInt = UB1Util.GetRandomNumberInt(0, num6);
			AddGeneratedVector(list[randomNumberInt]);
			list.RemoveAt(randomNumberInt);
			num6--;
		}
	}

	protected void AddGeneratedVectors(List<FVector> GeneratedVectors)
	{
		if (GeneratedVectors == null)
		{
			return;
		}
		foreach (FVector GeneratedVector in GeneratedVectors)
		{
			AddGeneratedVector(GeneratedVector);
		}
	}

	protected bool CheckPathFinding(FVector ContextLocation, FVector PointLocation)
	{
		if (!bFilterPathFinding)
		{
			return true;
		}
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return false;
		}
		if (UNavigationSystemV1.GetPathLength(aActor, ContextLocation, PointLocation, out var _, null, null) != ENavigationQueryResult.Success)
		{
			return false;
		}
		return true;
	}

	protected bool CheckLineTrace(FVector ContextLocation, FVector PointLocation)
	{
		if (!bFilterLineTracing)
		{
			return true;
		}
		AActor aActor = GetQuerier() as AActor;
		if (aActor == null)
		{
			return false;
		}
		if (UBGUSelectUtil.LineTraceSimple(aActor, ContextLocation, PointLocation, ETraceTypeQuery.TraceTypeQuery1, bEnableDebug, out var _, LineTracingIgnoreActors.ToList()) != 1)
		{
			return false;
		}
		return true;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_AreaPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_AreaPointGenerator gSEQG_AreaPointGenerator = GCHelper.Find<GSEQG_AreaPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_AreaPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_AreaPointGenerator");
		ContextOffset_Offset = NativeReflection.GetPropertyOffset(intPtr, "ContextOffset");
		ContextOffset_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ContextOffset", Classes.FStructProperty);
		XLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "XLength");
		XLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "XLength", Classes.FFloatProperty);
		YLength_Offset = NativeReflection.GetPropertyOffset(intPtr, "YLength");
		YLength_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YLength", Classes.FFloatProperty);
		XSplitNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "XSplitNum");
		XSplitNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "XSplitNum", Classes.FIntProperty);
		YSplitNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "YSplitNum");
		YSplitNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "YSplitNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bFilterPathFinding_PropertyAddress, intPtr, "bFilterPathFinding");
		bFilterPathFinding_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFilterPathFinding");
		bFilterPathFinding_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFilterPathFinding", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref bFilterLineTracing_PropertyAddress, intPtr, "bFilterLineTracing");
		bFilterLineTracing_Offset = NativeReflection.GetPropertyOffset(intPtr, "bFilterLineTracing");
		bFilterLineTracing_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bFilterLineTracing", Classes.FBoolProperty);
		RandomFilterPointNum_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomFilterPointNum");
		RandomFilterPointNum_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomFilterPointNum", Classes.FIntProperty);
		NativeReflection.GetPropertyRef(ref bEnableDebug_PropertyAddress, intPtr, "bEnableDebug");
		bEnableDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnableDebug");
		bEnableDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnableDebug", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref LineTracingIgnoreActors_PropertyAddress, intPtr, "LineTracingIgnoreActors");
		LineTracingIgnoreActors_Offset = NativeReflection.GetPropertyOffset(intPtr, "LineTracingIgnoreActors");
		LineTracingIgnoreActors_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LineTracingIgnoreActors", Classes.FArrayProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_AreaPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_AreaPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_AreaPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_AreaPointGenerator));
	}
}
