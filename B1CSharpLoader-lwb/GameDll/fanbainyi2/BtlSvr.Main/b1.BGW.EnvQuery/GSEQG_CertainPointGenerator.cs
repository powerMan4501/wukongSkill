using System;
using System.Collections.Generic;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQG CertainPoint")]
[BlueprintType]
[UClass]
[Blueprintable]
[USharpPath("/Script/b1-Managed.GSEQG_CertainPointGenerator")]
public class GSEQG_CertainPointGenerator : UGSEQGBase_ProjectedPoint
{
	private static bool CertainPointList_IsValid;

	private static int CertainPointList_Offset;

	private static FFieldAddress CertainPointList_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> CertainPointList_Marshaler;

	private static bool DoItemGenerationCS_IsValid;

	private static IntPtr DoItemGenerationCS_FunctionAddress;

	private static int DoItemGenerationCS_ParamsSize;

	private static bool DoItemGenerationCS_ContextLocations_IsValid;

	private static int DoItemGenerationCS_ContextLocations_Offset;

	private static FFieldAddress DoItemGenerationCS_ContextLocations_PropertyAddress;

	[Category("CertainPointGen")]
	[UProperty]
	[DisplayName("定点数组")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.GSEQG_CertainPointGenerator:CertainPointList")]
	public TArrayReadWrite<FVector> CertainPointList
	{
		get
		{
			CheckDestroyed();
			if (!CertainPointList_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQG_CertainPointGenerator:CertainPointList");
				return null;
			}
			if (CertainPointList_Marshaler == null)
			{
				CertainPointList_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, CertainPointList_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return CertainPointList_Marshaler.FromNative(IntPtr.Add(base.Address, CertainPointList_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
	}

	[USharpPath("/Script/b1-Managed.GSEQG_CertainPointGenerator:DoItemGenerationCS")]
	protected override void DoItemGenerationCS_Implementation(List<FVector> ContextLocations)
	{
		for (int i = 0; i < CertainPointList.Count; i++)
		{
			base.GenerateItemList.Add(CertainPointList[i]);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQG_CertainPointGenerator:DoItemGenerationCS")]
	private static void DoItemGenerationCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQG_CertainPointGenerator gSEQG_CertainPointGenerator = GCHelper.Find<GSEQG_CertainPointGenerator>(obj);
		List<FVector> contextLocations = new TArrayCopyMarshaler<FVector>(1, DoItemGenerationCS_ContextLocations_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative).FromNative(IntPtr.Add(buffer, DoItemGenerationCS_ContextLocations_Offset));
		gSEQG_CertainPointGenerator.DoItemGenerationCS_Implementation(contextLocations);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQG_CertainPointGenerator");
		NativeReflection.GetPropertyRef(ref CertainPointList_PropertyAddress, intPtr, "CertainPointList");
		CertainPointList_Offset = NativeReflection.GetPropertyOffset(intPtr, "CertainPointList");
		CertainPointList_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "CertainPointList", Classes.FArrayProperty);
		DoItemGenerationCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "DoItemGenerationCS");
		DoItemGenerationCS_ParamsSize = NativeReflection.GetFunctionParamsSize(DoItemGenerationCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref DoItemGenerationCS_ContextLocations_PropertyAddress, DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_Offset = NativeReflection.GetPropertyOffset(DoItemGenerationCS_FunctionAddress, "ContextLocations");
		DoItemGenerationCS_ContextLocations_IsValid = NativeReflection.ValidatePropertyClass(DoItemGenerationCS_FunctionAddress, "ContextLocations", Classes.FArrayProperty);
		DoItemGenerationCS_IsValid = DoItemGenerationCS_FunctionAddress != IntPtr.Zero && DoItemGenerationCS_ContextLocations_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQG_CertainPointGenerator:DoItemGenerationCS", DoItemGenerationCS_IsValid);
	}

	static GSEQG_CertainPointGenerator()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQG_CertainPointGenerator)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQG_CertainPointGenerator));
	}
}
