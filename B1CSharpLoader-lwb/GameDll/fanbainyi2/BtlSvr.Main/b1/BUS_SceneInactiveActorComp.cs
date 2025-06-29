using System;
using System.Collections.Generic;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintType]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp")]
public class BUS_SceneInactiveActorComp : UBaseActorCompTickable
{
	public List<FSceneActorActivationInfo> ActivationInfos;

	private BUS_GSEventCollection BUSEventCollision;

	private BGS_GSEventCollection BGSEventCollision;

	private const int DelayRegisterTick = 1;

	private int DelayedTickCount;

	private bool NeedEnableTickWhenDelayingRegister;

	private static bool SceneActorActivationInfo_IsValid;

	private static int SceneActorActivationInfo_Offset;

	private static FFieldAddress SceneActorActivationInfo_PropertyAddress;

	private TArrayReadWriteMarshaler<FGSSceneActorActivationInfo> SceneActorActivationInfo_Marshaler;

	private static bool TryAddActivationInfo_IsValid;

	private static IntPtr TryAddActivationInfo_FunctionAddress;

	private static int TryAddActivationInfo_ParamsSize;

	private static bool TryAddActivationInfo_ActivationInfo_IsValid;

	private static int TryAddActivationInfo_ActivationInfo_Offset;

	private static bool TryRemoveActivationInfo_IsValid;

	private static IntPtr TryRemoveActivationInfo_FunctionAddress;

	private static int TryRemoveActivationInfo_ParamsSize;

	private static bool TryRemoveActivationInfo_SceneActorActivationType_IsValid;

	private static int TryRemoveActivationInfo_SceneActorActivationType_Offset;

	private static FFieldAddress TryRemoveActivationInfo_SceneActorActivationType_PropertyAddress;

	private static bool TryRemoveActivationInfo_Tag_IsValid;

	private static int TryRemoveActivationInfo_Tag_Offset;

	private static bool EndPlayInCS_IsValid;

	private static IntPtr EndPlayInCS_FunctionAddress;

	private static int EndPlayInCS_ParamsSize;

	private static bool EndPlayInCS_EndPlayReason_IsValid;

	private static int EndPlayInCS_EndPlayReason_Offset;

	private static FFieldAddress EndPlayInCS_EndPlayReason_PropertyAddress;

	private static bool GetSceneActorActivationInfo_IsValid;

	private static IntPtr GetSceneActorActivationInfo_FunctionAddress;

	private static int GetSceneActorActivationInfo_ParamsSize;

	private static bool GetSceneActorActivationInfo_ReturnValue_IsValid;

	private static int GetSceneActorActivationInfo_ReturnValue_Offset;

	private static FFieldAddress GetSceneActorActivationInfo_ReturnValue_PropertyAddress;

	private static bool BeginPlayInCS_IsValid;

	private static IntPtr BeginPlayInCS_FunctionAddress;

	private static int BeginPlayInCS_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("物体功能开关配置信息")]
	[Category("物体功能开关配置信息")]
	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:SceneActorActivationInfo")]
	public TArrayReadWrite<FGSSceneActorActivationInfo> SceneActorActivationInfo
	{
		get
		{
			CheckDestroyed();
			if (!SceneActorActivationInfo_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BUS_SceneInactiveActorComp:SceneActorActivationInfo");
				return null;
			}
			if (SceneActorActivationInfo_Marshaler == null)
			{
				SceneActorActivationInfo_Marshaler = new TArrayReadWriteMarshaler<FGSSceneActorActivationInfo>(1, SceneActorActivationInfo_PropertyAddress, CachedMarshalingDelegates<FGSSceneActorActivationInfo, FGSSceneActorActivationInfo>.FromNative, CachedMarshalingDelegates<FGSSceneActorActivationInfo, FGSSceneActorActivationInfo>.ToNative);
			}
			return SceneActorActivationInfo_Marshaler.FromNative(IntPtr.Add(base.Address, SceneActorActivationInfo_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.IsEditorOnly = false;
	}

	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:BeginPlayInCS")]
	protected override void BeginPlayInCS_Implementation()
	{
		base.BeginPlayInCS_Implementation();
		AActor owner = GetOwner();
		ActivationInfos = new List<FSceneActorActivationInfo>();
		foreach (FGSSceneActorActivationInfo item2 in SceneActorActivationInfo)
		{
			FSceneActorActivationInfo item = new FSceneActorActivationInfo(owner, item2);
			ActivationInfos.Add(item);
		}
		BGSEventCollision = BGS_EventCollectionCS.Get(owner);
		BUSEventCollision = BUS_EventCollectionCS.Get(owner);
	}

	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		TryRegisterInactiveActor();
	}

	private void TryRegisterInactiveActor()
	{
		if (BGSEventCollision == null)
		{
			SetComponentTickEnabled(bEnabled: false);
		}
		if (BGSEventCollision != null && BGSEventCollision.HasBeginPlay && (BUSEventCollision == null || BUSEventCollision.HasBeginPlay))
		{
			if (DelayedTickCount < 1)
			{
				if (NeedEnableTickWhenDelayingRegister)
				{
					AActor owner = GetOwner();
					foreach (FSceneActorActivationInfo activationInfo in ActivationInfos)
					{
						activationInfo.ActivateComponents(owner);
					}
					NeedEnableTickWhenDelayingRegister = false;
				}
				DelayedTickCount++;
			}
			else
			{
				BGSEventCollision.Evt_BGS_RegisterSceneInactiveActor.Invoke(GetOwner(), ActivationInfos, this);
			}
		}
		else
		{
			if (NeedEnableTickWhenDelayingRegister)
			{
				return;
			}
			AActor owner2 = GetOwner();
			foreach (FSceneActorActivationInfo activationInfo2 in ActivationInfos)
			{
				activationInfo2.DeactivateComponents(owner2, ForceUpdate: true);
				NeedEnableTickWhenDelayingRegister = true;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryAddActivationInfo")]
	public void TryAddActivationInfo(FGSSceneActorActivationInfo ActivationInfo)
	{
		for (int i = 0; i < SceneActorActivationInfo.Count; i++)
		{
			if (SceneActorActivationInfo[i].SceneActorActivationType == ActivationInfo.SceneActorActivationType && SceneActorActivationInfo[i].Tag == ActivationInfo.Tag)
			{
				SceneActorActivationInfo.RemoveAt(i);
				SceneActorActivationInfo.Insert(i, ActivationInfo);
				return;
			}
		}
		SceneActorActivationInfo.Add(ActivationInfo);
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryRemoveActivationInfo")]
	public void TryRemoveActivationInfo(EGSSceneActorActivationType SceneActorActivationType, FName Tag)
	{
		for (int i = 0; i < SceneActorActivationInfo.Count; i++)
		{
			if (SceneActorActivationInfo[i].SceneActorActivationType == SceneActorActivationType && SceneActorActivationInfo[i].Tag == Tag)
			{
				SceneActorActivationInfo.RemoveAt(i);
				break;
			}
		}
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:GetSceneActorActivationInfo")]
	public List<FGSSceneActorActivationInfo> GetSceneActorActivationInfo()
	{
		return SceneActorActivationInfo.ToList();
	}

	[USharpPath("/Script/b1-Managed.BUS_SceneInactiveActorComp:EndPlayInCS")]
	protected override void EndPlayInCS_Implementation(EEndPlayReason EndPlayReason)
	{
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null && bGS_GSEventCollection.HasBeginPlay)
		{
			bGS_GSEventCollection.Evt_BGS_ReleaseSceneInactiveActor.Invoke(GetOwner());
		}
		base.EndPlayInCS_Implementation(EndPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryAddActivationInfo")]
	private static void TryAddActivationInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		FGSSceneActorActivationInfo activationInfo = FGSSceneActorActivationInfo.FromNative(IntPtr.Add(buffer, TryAddActivationInfo_ActivationInfo_Offset));
		bUS_SceneInactiveActorComp.TryAddActivationInfo(activationInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryRemoveActivationInfo")]
	private static void TryRemoveActivationInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		EGSSceneActorActivationType sceneActorActivationType = EnumMarshaler<EGSSceneActorActivationType>.FromNative(IntPtr.Add(buffer, TryRemoveActivationInfo_SceneActorActivationType_Offset), 0, TryRemoveActivationInfo_SceneActorActivationType_PropertyAddress.Address);
		FName tag = BlittableTypeMarshaler<FName>.FromNative(IntPtr.Add(buffer, TryRemoveActivationInfo_Tag_Offset));
		bUS_SceneInactiveActorComp.TryRemoveActivationInfo(sceneActorActivationType, tag);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:EndPlayInCS")]
	private static void EndPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		EEndPlayReason endPlayReason = EnumMarshaler<EEndPlayReason>.FromNative(IntPtr.Add(buffer, EndPlayInCS_EndPlayReason_Offset), 0, EndPlayInCS_EndPlayReason_PropertyAddress.Address);
		bUS_SceneInactiveActorComp.EndPlayInCS_Implementation(endPlayReason);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:GetSceneActorActivationInfo")]
	private static void GetSceneActorActivationInfo__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		TArrayCopyMarshaler<FGSSceneActorActivationInfo> tArrayCopyMarshaler = new TArrayCopyMarshaler<FGSSceneActorActivationInfo>(1, GetSceneActorActivationInfo_ReturnValue_PropertyAddress, CachedMarshalingDelegates<FGSSceneActorActivationInfo, FGSSceneActorActivationInfo>.FromNative, CachedMarshalingDelegates<FGSSceneActorActivationInfo, FGSSceneActorActivationInfo>.ToNative);
		List<FGSSceneActorActivationInfo> sceneActorActivationInfo = bUS_SceneInactiveActorComp.GetSceneActorActivationInfo();
		tArrayCopyMarshaler.ToNative(IntPtr.Add(buffer, GetSceneActorActivationInfo_ReturnValue_Offset), sceneActorActivationInfo);
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:BeginPlayInCS")]
	private static void BeginPlayInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		bUS_SceneInactiveActorComp.BeginPlayInCS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BUS_SceneInactiveActorComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BUS_SceneInactiveActorComp bUS_SceneInactiveActorComp = GCHelper.Find<BUS_SceneInactiveActorComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bUS_SceneInactiveActorComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BUS_SceneInactiveActorComp");
		NativeReflection.GetPropertyRef(ref SceneActorActivationInfo_PropertyAddress, intPtr, "SceneActorActivationInfo");
		SceneActorActivationInfo_Offset = NativeReflection.GetPropertyOffset(intPtr, "SceneActorActivationInfo");
		SceneActorActivationInfo_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "SceneActorActivationInfo", Classes.FArrayProperty);
		TryAddActivationInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryAddActivationInfo");
		TryAddActivationInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(TryAddActivationInfo_FunctionAddress);
		TryAddActivationInfo_ActivationInfo_Offset = NativeReflection.GetPropertyOffset(TryAddActivationInfo_FunctionAddress, "ActivationInfo");
		TryAddActivationInfo_ActivationInfo_IsValid = NativeReflection.ValidatePropertyClass(TryAddActivationInfo_FunctionAddress, "ActivationInfo", Classes.FStructProperty);
		TryAddActivationInfo_IsValid = TryAddActivationInfo_FunctionAddress != IntPtr.Zero && TryAddActivationInfo_ActivationInfo_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryAddActivationInfo", TryAddActivationInfo_IsValid);
		TryRemoveActivationInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TryRemoveActivationInfo");
		TryRemoveActivationInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(TryRemoveActivationInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref TryRemoveActivationInfo_SceneActorActivationType_PropertyAddress, TryRemoveActivationInfo_FunctionAddress, "SceneActorActivationType");
		TryRemoveActivationInfo_SceneActorActivationType_Offset = NativeReflection.GetPropertyOffset(TryRemoveActivationInfo_FunctionAddress, "SceneActorActivationType");
		TryRemoveActivationInfo_SceneActorActivationType_IsValid = NativeReflection.ValidatePropertyClass(TryRemoveActivationInfo_FunctionAddress, "SceneActorActivationType", Classes.FEnumProperty);
		TryRemoveActivationInfo_Tag_Offset = NativeReflection.GetPropertyOffset(TryRemoveActivationInfo_FunctionAddress, "Tag");
		TryRemoveActivationInfo_Tag_IsValid = NativeReflection.ValidatePropertyClass(TryRemoveActivationInfo_FunctionAddress, "Tag", Classes.FNameProperty);
		TryRemoveActivationInfo_IsValid = TryRemoveActivationInfo_FunctionAddress != IntPtr.Zero && TryRemoveActivationInfo_SceneActorActivationType_IsValid && TryRemoveActivationInfo_Tag_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:TryRemoveActivationInfo", TryRemoveActivationInfo_IsValid);
		EndPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "EndPlayInCS");
		EndPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(EndPlayInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref EndPlayInCS_EndPlayReason_PropertyAddress, EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_Offset = NativeReflection.GetPropertyOffset(EndPlayInCS_FunctionAddress, "EndPlayReason");
		EndPlayInCS_EndPlayReason_IsValid = NativeReflection.ValidatePropertyClass(EndPlayInCS_FunctionAddress, "EndPlayReason", Classes.FEnumProperty);
		EndPlayInCS_IsValid = EndPlayInCS_FunctionAddress != IntPtr.Zero && EndPlayInCS_EndPlayReason_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:EndPlayInCS", EndPlayInCS_IsValid);
		GetSceneActorActivationInfo_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetSceneActorActivationInfo");
		GetSceneActorActivationInfo_ParamsSize = NativeReflection.GetFunctionParamsSize(GetSceneActorActivationInfo_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetSceneActorActivationInfo_ReturnValue_PropertyAddress, GetSceneActorActivationInfo_FunctionAddress, "ReturnValue");
		GetSceneActorActivationInfo_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetSceneActorActivationInfo_FunctionAddress, "ReturnValue");
		GetSceneActorActivationInfo_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetSceneActorActivationInfo_FunctionAddress, "ReturnValue", Classes.FArrayProperty);
		GetSceneActorActivationInfo_IsValid = GetSceneActorActivationInfo_FunctionAddress != IntPtr.Zero && GetSceneActorActivationInfo_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:GetSceneActorActivationInfo", GetSceneActorActivationInfo_IsValid);
		BeginPlayInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayInCS");
		BeginPlayInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayInCS_FunctionAddress);
		BeginPlayInCS_IsValid = BeginPlayInCS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:BeginPlayInCS", BeginPlayInCS_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BUS_SceneInactiveActorComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BUS_SceneInactiveActorComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BUS_SceneInactiveActorComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BUS_SceneInactiveActorComp));
	}
}
