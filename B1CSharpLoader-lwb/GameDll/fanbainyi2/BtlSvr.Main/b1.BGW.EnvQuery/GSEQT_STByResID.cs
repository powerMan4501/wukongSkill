using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1.BGW.EnvQuery;

[UClass]
[BlueprintType]
[Blueprintable]
[DisplayName("GS EQT ST By ResID")]
[USharpPath("/Script/b1-Managed.GSEQT_STByResID")]
public class GSEQT_STByResID : UGSEQTBase
{
	private static bool ResID_IsValid;

	private static int ResID_Offset;

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

	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.GSEQT_STByResID:ResID")]
	public int ResID
	{
		get
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_STByResID:ResID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ResID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ResID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.GSEQT_STByResID:ResID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ResID_Offset), value);
			}
		}
	}

	[USharpPath("/Script/b1-Managed.GSEQT_STByResID:ShouldPrepareContext")]
	protected override bool ShouldPrepareContext_Implementation()
	{
		return true;
	}

	[USharpPath("/Script/b1-Managed.GSEQT_STByResID:ProcessItemCS")]
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
		if (BGU_DataUtil.GetActorResID(aBGUCharacter) == ResID)
		{
			return true;
		}
		return false;
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_STByResID:ProcessItemCS")]
	private static void ProcessItemCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_STByResID gSEQT_STByResID = GCHelper.Find<GSEQT_STByResID>(obj);
		UWorld world = UObjectMarshaler<UWorld>.FromNative(IntPtr.Add(buffer, ProcessItemCS_World_Offset));
		FVector itemLocation = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemLocation_Offset));
		AActor itemActor = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_ItemActor_Offset));
		AActor querier = UObjectMarshaler<AActor>.FromNative(IntPtr.Add(buffer, ProcessItemCS_Querier_Offset));
		bool value = gSEQT_STByResID.ProcessItemCS_Implementation(world, itemLocation, itemActor, querier);
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ProcessItemCS_ReturnValue_Offset), 0, ProcessItemCS_ReturnValue_PropertyAddress.Address, value);
	}

	[UFunctionInvoker("/Script/b1-Managed.GSEQT_STByResID:ShouldPrepareContext")]
	private static void ShouldPrepareContext__Invoker(IntPtr buffer, IntPtr obj)
	{
		GSEQT_STByResID gSEQT_STByResID = GCHelper.Find<GSEQT_STByResID>(obj);
		bool value = gSEQT_STByResID.ShouldPrepareContext_Implementation();
		BoolMarshaler.ToNative(IntPtr.Add(buffer, ShouldPrepareContext_ReturnValue_Offset), 0, ShouldPrepareContext_ReturnValue_PropertyAddress.Address, value);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.GSEQT_STByResID");
		ResID_Offset = NativeReflection.GetPropertyOffset(intPtr, "ResID");
		ResID_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "ResID", Classes.FIntProperty);
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
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_STByResID:ProcessItemCS", ProcessItemCS_IsValid);
		ShouldPrepareContext_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShouldPrepareContext");
		ShouldPrepareContext_ParamsSize = NativeReflection.GetFunctionParamsSize(ShouldPrepareContext_FunctionAddress);
		NativeReflection.GetPropertyRef(ref ShouldPrepareContext_ReturnValue_PropertyAddress, ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_Offset = NativeReflection.GetPropertyOffset(ShouldPrepareContext_FunctionAddress, "ReturnValue");
		ShouldPrepareContext_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(ShouldPrepareContext_FunctionAddress, "ReturnValue", Classes.FBoolProperty);
		ShouldPrepareContext_IsValid = ShouldPrepareContext_FunctionAddress != IntPtr.Zero && ShouldPrepareContext_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.GSEQT_STByResID:ShouldPrepareContext", ShouldPrepareContext_IsValid);
	}

	static GSEQT_STByResID()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(GSEQT_STByResID)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(GSEQT_STByResID));
	}
}
