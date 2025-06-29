using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[DisplayName("GS EQT ST Priority")]
[Blueprintable]
[BlueprintType]
[UClass]
[USharpPath("/Script/b1-Managed.GSEQT_STPriority")]
public class GSEQT_STPriority : UGSEQTBase
{
	private static bool ResIDPriority_IsValid;

	private static int ResIDPriority_Offset;

	private static FFieldAddress ResIDPriority_PropertyAddress;

	private TArrayReadWriteMarshaler<int> ResIDPriority_Marshaler;

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

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.GSEQT_STPriority:ResIDPriority")]
	public TArrayReadWrite<int> ResIDPriority
	{
		get
		{
			CheckDestroyed();
			if (!ResIDPriority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_STPriority:ResIDPriority");
				return null;
			}
			if (ResIDPriority_Marshaler == null)
			{
				ResIDPriority_Marshaler = new TArrayReadWriteMarshaler<int>(1, ResIDPriority_PropertyAddress, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.FromNative, CachedMarshalingDelegates<int, BlittableTypeMarshaler<int>>.ToNative);
			}
			return ResIDPriority_Marshaler.FromNative(IntPtr.Add(base.Address, ResIDPriority_Offset));
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_STPriority:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_STPriority:ProcessItemCS")]
	protected override bool ProcessItemCS_Implementation(UWorld World, FVector ItemLocation, AActor ItemActor, AActor Querier)
	{
		ABGUCharacter aBGUCharacter = null;
		if (ItemActor.IsNullOrDestroyed())
		{
			List<ABGUCharacter> OutArray = new List<ABGUCharacter>();
			Querier.World.BoxOverlapBGUCharacters(ItemLocation, new FVector(0.10000000149011612, 0.10000000149011612, 20.0), out OutArray);
			aBGUCharacter = OutArray[0];
		}
		else
		{
			aBGUCharacter = ItemActor as ABGUCharacter;
		}
		if (aBGUCharacter.IsNullOrDestroyed())
		{
			return false;
		}
		AActor lockTargetActor = BGU_DataUtil.GetReadOnlyData<IBUC_TargetInfoData, BUC_TargetInfoData>(Querier).GetTargetInfo().LockTargetActor;
		if (lockTargetActor == null)
		{
			return true;
		}
		int actorResID = BGU_DataUtil.GetActorResID(aBGUCharacter);
		int actorResID2 = BGU_DataUtil.GetActorResID(lockTargetActor);
		int num = 0;
		int num2 = 0;
		for (num = 0; num < ResIDPriority.Count && ResIDPriority[num] != actorResID; num++)
		{
		}
		for (num2 = 0; num2 < ResIDPriority.Count && ResIDPriority[num2] != actorResID2; num2++)
		{
		}
		if (num < num2)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_STPriority:ProcessItemCS")]
	private static void ProcessItemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_STPriority gSEQT_STPriority = GCHelper.Find<GSEQT_STPriority>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, ProcessItemCS_World_Offset));
		FVector itemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemLocation_Offset));
		AActor itemActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemActor_Offset));
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_Querier_Offset));
		bool value = gSEQT_STPriority.ProcessItemCS_Implementation(world, itemLocation, itemActor, querier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_STPriority:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_STPriority gSEQT_STPriority = GCHelper.Find<GSEQT_STPriority>(obj);
		bool value = gSEQT_STPriority.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_STPriority");
		NativeReflection.GetPropertyRef(ref ResIDPriority_PropertyAddress, intPtr, "ResIDPriority");
		ResIDPriority_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResIDPriority");
		ResIDPriority_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResIDPriority", Classes.FArrayProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_STPriority:ProcessItemCS", ProcessItemCS_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_STPriority:ShouldPrepareContext", ShouldPrepareContext_IsValid);
	}

	static GSEQT_STPriority()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_STPriority)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_STPriority));
	}
}
