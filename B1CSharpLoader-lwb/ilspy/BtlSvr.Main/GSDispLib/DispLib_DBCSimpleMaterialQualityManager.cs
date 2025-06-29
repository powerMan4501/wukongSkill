using System;
using System.Collections.Generic;
using b1;
using b1.EventDelDefine;
using b1.Plugins.TressFX;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace GSDispLib;

[BlueprintSpawnableComponent]
[UClass]
[USharpPath("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager")]
public class DispLib_DBCSimpleMaterialQualityManager : UBaseActorCompTickable
{
	private static bool InitOver_IsValid;

	private static int InitOver_Offset;

	private static FFieldAddress InitOver_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UProperty]
	[EditorVisible(EditorVisible.AnywhereReadOnly)]
	[BlueprintReadOnly]
	[USharpPath("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:InitOver")]
	public bool InitOver
	{
		get
		{
			CheckDestroyed();
			if (!InitOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:InitOver");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, InitOver_Offset), 0, InitOver_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!InitOver_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:InitOver");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, InitOver_Offset), 0, InitOver_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		InitOver = false;
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		GetAllValidPrimComp(out var AllValidMeshComp, out var AllTressFXComp);
		SwitchDynamicMaterialQuality(3, AllValidMeshComp, AllTressFXComp);
		TryRegisterDelegate();
	}

	private void TryRegisterDelegate()
	{
		if (!InitOver)
		{
			BGS_GSEventCollection bGS_GSEventCollection = BGS_GSEventCollection.Get(this);
			if (!(bGS_GSEventCollection == null))
			{
				bGS_GSEventCollection.Evt_NotifyMovieBegin += new Del_Void_IntInt(OnMovieBegin);
				bGS_GSEventCollection.Evt_NotifyMovieEnd += new Del_Void_IntInt(OnMovieEnd);
				InitOver = true;
			}
		}
	}

	private void GetAllValidPrimComp(out List<UMeshComponent> AllValidMeshComp, out List<UTressFXComponent> AllTressFXComp)
	{
		AActor owner = GetOwner();
		List<UActorComponent> componentsByClass = owner.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
		List<UActorComponent> componentsByClass2 = owner.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
		owner.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
		List<UActorComponent> componentsByClass3 = owner.GetComponentsByClass(UClass.GetClass<UChildActorComponent>());
		for (int i = 0; i < componentsByClass3.Count; i++)
		{
			UChildActorComponent uChildActorComponent = componentsByClass3[i] as UChildActorComponent;
			if (!uChildActorComponent.ChildActor.IsNullOrDestroyed())
			{
				List<UActorComponent> componentsByClass4 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UMeshComponent>());
				componentsByClass.AddRange(componentsByClass4);
				List<UActorComponent> componentsByClass5 = uChildActorComponent.ChildActor.GetComponentsByClass(UClass.GetClass<UTressFXComponent>());
				componentsByClass2.AddRange(componentsByClass5);
			}
		}
		AllValidMeshComp = new List<UMeshComponent>();
		AllTressFXComp = new List<UTressFXComponent>();
		for (int j = 0; j < componentsByClass.Count; j++)
		{
			AllValidMeshComp.Add(componentsByClass[j] as UMeshComponent);
		}
		for (int k = 0; k < componentsByClass2.Count; k++)
		{
			AllTressFXComp.Add(componentsByClass2[k] as UTressFXComponent);
		}
	}

	private void SwitchDynamicMaterialQuality(int Quality, List<UMeshComponent> AllValidMeshComp, List<UTressFXComponent> AllTressFXComp)
	{
		AActor owner = GetOwner();
		for (int i = 0; i < AllValidMeshComp.Count; i++)
		{
			UMeshComponent uMeshComponent = AllValidMeshComp[i];
			for (int j = 0; j < uMeshComponent.GetNumMaterials(); j++)
			{
				UMaterialInstanceDynamic uMaterialInstanceDynamic = uMeshComponent.CreateDynamicMaterialInstance(j, null, default(FName));
				if (!uMaterialInstanceDynamic.IsNullOrDestroyed())
				{
					UGSE_ActorFuncLib.SetMaterialInterfaceQualityLevel(owner, uMaterialInstanceDynamic, Quality);
				}
			}
		}
	}

	private void OnMovieBegin(int SeqID, int UniqueID)
	{
		GetAllValidPrimComp(out var AllValidMeshComp, out var AllTressFXComp);
		SwitchDynamicMaterialQuality(-1, AllValidMeshComp, AllTressFXComp);
	}

	private void OnMovieEnd(int SeqID, int UniqueID)
	{
		GetAllValidPrimComp(out var AllValidMeshComp, out var AllTressFXComp);
		SwitchDynamicMaterialQuality(3, AllValidMeshComp, AllTressFXComp);
	}

	[USharpPath("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (!InitOver)
		{
			TryRegisterDelegate();
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCSimpleMaterialQualityManager dispLib_DBCSimpleMaterialQualityManager = GCHelper.Find<DispLib_DBCSimpleMaterialQualityManager>(obj);
		dispLib_DBCSimpleMaterialQualityManager.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		DispLib_DBCSimpleMaterialQualityManager dispLib_DBCSimpleMaterialQualityManager = GCHelper.Find<DispLib_DBCSimpleMaterialQualityManager>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		dispLib_DBCSimpleMaterialQualityManager.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager");
		NativeReflection.GetPropertyRef(ref InitOver_PropertyAddress, intPtr, "InitOver");
		InitOver_Offset = NativeReflection.GetPropertyOffset(intPtr, "InitOver");
		InitOver_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "InitOver", Classes.FBoolProperty);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.DispLib_DBCSimpleMaterialQualityManager:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static DispLib_DBCSimpleMaterialQualityManager()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(DispLib_DBCSimpleMaterialQualityManager)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(DispLib_DBCSimpleMaterialQualityManager));
	}
}
