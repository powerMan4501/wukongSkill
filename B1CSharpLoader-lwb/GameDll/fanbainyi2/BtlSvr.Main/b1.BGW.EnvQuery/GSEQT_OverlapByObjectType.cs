using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[Blueprintable]
[BlueprintType]
[UClass]
[DisplayName("GS EQT Overlap By ObjectType")]
[USharpPath("/Script/b1-Managed.GSEQT_OverlapByObjectType")]
public class GSEQT_OverlapByObjectType : UGSEQTBase
{
	private static bool OverlapData_IsValid;

	private static int OverlapData_Offset;

	private static bool ProcessItemCS_IsValid;

	private static IntPtr ProcessItemCS_FunctionAddress;

	private static int ProcessItemCS_ParamsSize;

	private static bool ProcessItemCS_World_IsValid;

	private static int ProcessItemCS_World_Offset;

	private static bool ProcessItemCS_ItemLocation_IsValid;

	private static int ProcessItemCS_ItemLocation_Offset;

	private static FFieldAddress ProcessItemCS_ItemLocation_PropertyAddress;

	private static bool ProcessItemCS_ItemActor_IsValid;

	private static int ProcessItemCS_ItemActor_Offset;

	private static bool ProcessItemCS_Querier_IsValid;

	private static int ProcessItemCS_Querier_Offset;

	private static bool ProcessItemCS_ReturnValue_IsValid;

	private static int ProcessItemCS_ReturnValue_Offset;

	private static FFieldAddress ProcessItemCS_ReturnValue_PropertyAddress;

	private static bool ShouldPrepareContext_IsValid;

	private static IntPtr ShouldPrepareContext_FunctionAddress;

	private static int ShouldPrepareContext_ParamsSize;

	private static bool ShouldPrepareContext_ReturnValue_IsValid;

	private static int ShouldPrepareContext_ReturnValue_Offset;

	private static FFieldAddress ShouldPrepareContext_ReturnValue_PropertyAddress;

	private static bool GetDescriptionTitleCS_IsValid;

	private static IntPtr GetDescriptionTitleCS_FunctionAddress;

	private static int GetDescriptionTitleCS_ParamsSize;

	private static bool GetDescriptionTitleCS_ReturnValue_IsValid;

	private static int GetDescriptionTitleCS_ReturnValue_Offset;

	private static FFieldAddress GetDescriptionTitleCS_ReturnValue_PropertyAddress;

	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_OverlapByObjectType:OverlapData")]
	public FEnvOverlapByObjectTypeData OverlapData
	{
		get
		{
			CheckDestroyed();
			if (!OverlapData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_OverlapByObjectType:OverlapData");
				return default(FEnvOverlapByObjectTypeData);
			}
			return FEnvOverlapByObjectTypeData.FromNative(IntPtr.Add(base.Address, OverlapData_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!OverlapData_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_OverlapByObjectType:OverlapData");
			}
			else
			{
				FEnvOverlapByObjectTypeData.ToNative(IntPtr.Add(base.Address, OverlapData_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_OverlapByObjectType:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return OverlapData.bSkipOverlapQuerier;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_OverlapByObjectType:GetDescriptionTitleCS")]
	protected override string GetDescriptionTitleCS_Implementation()
	{
		return $"{OverlapData.OverlapShape} Overlap By ObjectTypes";
	}

	[USharpPath("/Script/b1-Managed.GSEQT_OverlapByObjectType:ProcessItemCS")]
	protected override bool ProcessItemCS_Implementation(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		return UBGUFuncLibSelectTargets.BGUOverlapAnyTestByObjectType(ShapeExtent: new FVector(OverlapData.ExtentX, OverlapData.ExtentY, OverlapData.ExtentZ), WorldContextObject: World, Pos: ItemLocation + OverlapData.ShapeOffset, ObjectTypes: OverlapData.OverlapObjectTypes, CollisionShape: OverlapData.OverlapShape);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_OverlapByObjectType:ProcessItemCS")]
	private static void ProcessItemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_OverlapByObjectType gSEQT_OverlapByObjectType = GCHelper.Find<GSEQT_OverlapByObjectType>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, ProcessItemCS_World_Offset));
		FVector itemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemLocation_Offset));
		AActor itemActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemActor_Offset));
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_Querier_Offset));
		bool value = gSEQT_OverlapByObjectType.ProcessItemCS_Implementation(world, itemLocation, itemActor, querier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_OverlapByObjectType:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_OverlapByObjectType gSEQT_OverlapByObjectType = GCHelper.Find<GSEQT_OverlapByObjectType>(obj);
		bool value = gSEQT_OverlapByObjectType.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_OverlapByObjectType:GetDescriptionTitleCS")]
	private static void GetDescriptionTitleCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_OverlapByObjectType gSEQT_OverlapByObjectType = GCHelper.Find<GSEQT_OverlapByObjectType>(obj);
		string descriptionTitleCS_Implementation = gSEQT_OverlapByObjectType.GetDescriptionTitleCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetDescriptionTitleCS_ReturnValue_Offset), descriptionTitleCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_OverlapByObjectType");
		OverlapData_Offset = NativeReflection.GetPropertyOffset(intPtr, "OverlapData");
		OverlapData_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "OverlapData", Classes.FStructProperty);
		ProcessItemCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ProcessItemCS");
		ProcessItemCS_ParamsSize = NativeReflection.GetFunctionParamsSize(ProcessItemCS_FunctionAddress);
		ProcessItemCS_World_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "World");
		ProcessItemCS_World_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "World", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ItemLocation_PropertyAddress, ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemLocation");
		ProcessItemCS_ItemLocation_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemLocation", Classes.FStructProperty);
		ProcessItemCS_ItemActor_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ItemActor");
		ProcessItemCS_ItemActor_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ItemActor", Classes.FObjectProperty);
		ProcessItemCS_Querier_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "Querier");
		ProcessItemCS_Querier_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "Querier", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref ProcessItemCS_ReturnValue_PropertyAddress, ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ProcessItemCS_FunctionAddress, "ReturnValue");
		ProcessItemCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ProcessItemCS_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ProcessItemCS_IsValid = ProcessItemCS_FunctionAddress != IntPtr.Zero && ProcessItemCS_World_IsValid && ProcessItemCS_ItemLocation_IsValid && ProcessItemCS_ItemActor_IsValid && ProcessItemCS_Querier_IsValid && ProcessItemCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_OverlapByObjectType:ProcessItemCS", ProcessItemCS_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_OverlapByObjectType:ShouldPrepareContext", ShouldPrepareContext_IsValid);
		GetDescriptionTitleCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetDescriptionTitleCS");
		GetDescriptionTitleCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetDescriptionTitleCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetDescriptionTitleCS_ReturnValue_PropertyAddress, GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetDescriptionTitleCS_FunctionAddress, "ReturnValue");
		GetDescriptionTitleCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetDescriptionTitleCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetDescriptionTitleCS_IsValid = GetDescriptionTitleCS_FunctionAddress != IntPtr.Zero && GetDescriptionTitleCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_OverlapByObjectType:GetDescriptionTitleCS", GetDescriptionTitleCS_IsValid);
	}

	static GSEQT_OverlapByObjectType()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_OverlapByObjectType)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_OverlapByObjectType));
	}
}
