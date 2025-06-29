using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor")]
public class BGUSpiderNavigationActor : BGUActorBaseCS
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool NavPoints_IsValid;

	private static int NavPoints_Offset;

	private static FFieldAddress NavPoints_PropertyAddress;

	private TArrayReadWriteMarshaler<FGsSpiderNavPointInfo> NavPoints_Marshaler;

	private static bool ShowSpiderNavPoint_IsValid;

	private static IntPtr ShowSpiderNavPoint_FunctionAddress;

	private static int ShowSpiderNavPoint_ParamsSize;

	private static bool HideSpiderNavPoint_IsValid;

	private static IntPtr HideSpiderNavPoint_FunctionAddress;

	private static int HideSpiderNavPoint_ParamsSize;

	private static bool RecordSpiderNavPoint_IsValid;

	private static IntPtr RecordSpiderNavPoint_FunctionAddress;

	private static int RecordSpiderNavPoint_ParamsSize;

	private static bool ReceiveTick_IsValid;

	private static IntPtr ReceiveTick_FunctionAddress;

	private static int ReceiveTick_ParamsSize;

	private static bool ReceiveTick_DeltaSeconds_IsValid;

	private static int ReceiveTick_DeltaSeconds_Offset;

	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:Root")]
	public USceneComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavigationActor:Root");
				return null;
			}
			return UObjectMarshaler<USceneComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavigationActor:Root");
			}
			else
			{
				UObjectMarshaler<USceneComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("NavPointInfo")]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:NavPoints")]
	public TArrayReadWrite<FGsSpiderNavPointInfo> NavPoints
	{
		get
		{
			CheckDestroyed();
			if (!NavPoints_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavigationActor:NavPoints");
				return null;
			}
			if (NavPoints_Marshaler == null)
			{
				NavPoints_Marshaler = new TArrayReadWriteMarshaler<FGsSpiderNavPointInfo>(1, NavPoints_PropertyAddress, CachedMarshalingDelegates<FGsSpiderNavPointInfo, FGsSpiderNavPointInfo>.FromNative, CachedMarshalingDelegates<FGsSpiderNavPointInfo, FGsSpiderNavPointInfo>.ToNative);
			}
			return NavPoints_Marshaler.FromNative(IntPtr.Add(base.Address, NavPoints_Offset));
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Root = initializer.CreateDefaultSubobject<USceneComponent>(this, B1GlobalFNames.Root);
		SetRootComponentCS(Root);
	}

	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:ReceiveTick")]
	protected override void ReceiveTick_Implementation(float DeltaSeconds)
	{
		base.ReceiveTick_Implementation(DeltaSeconds);
		BGS_GSEventCollection bGS_GSEventCollection = BGS_EventCollectionCS.Get(this);
		if (bGS_GSEventCollection != null)
		{
			bGS_GSEventCollection.Evt_BGS_RegisterSpiderNavMesh.Invoke(this, NavPoints.ToList());
		}
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<b1.BUS_SpiderNavigationDataComp>(this, B1GlobalFNames.SplineDataComp);
	}

	[UFunction]
	[BlueprintCallable]
	[Category("NavPointInfo")]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:ShowSpiderNavPoint")]
	public void ShowSpiderNavPoint()
	{
		HideSpiderNavPoint();
		GetActorTransform();
		for (int num = NavPoints.Count - 1; num >= 0; num--)
		{
			FGsSpiderNavPointInfo fGsSpiderNavPointInfo = NavPoints[num];
			FTransform fTransform = default(FTransform);
			fTransform.SetLocation(fGsSpiderNavPointInfo.Location);
			fTransform.SetRotation(MathLib.MakeRotFromX(fGsSpiderNavPointInfo.Normal).Conv_RotatorToQuaternion());
			fTransform.SetScale3D(FVector.OneVector);
			BGUSpiderNavPointActor obj = UGSFuncLibForEditor.GEditor_SpawnActorAbsolute(UGSFuncLibForEditor.GetEditorWorld(), UClass.GetClass<BGUSpiderNavPointActor>(), fTransform) as BGUSpiderNavPointActor;
			obj.SetActorTransform(fTransform, bSweep: false, out var _, bTeleport: true);
			obj.AttachToActor(this, FName.None, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, EAttachmentRule.KeepWorld, bWeldSimulatedBodies: false);
			obj.LinkRadius = fGsSpiderNavPointInfo.LinkRadius;
			obj.LinkAngle = fGsSpiderNavPointInfo.LinkAngle;
			obj.IsGroundPoint = fGsSpiderNavPointInfo.IsGroundPoint;
		}
		MarkPackageDirty();
	}

	[UFunction]
	[Category("NavPointInfo")]
	[BlueprintCallable]
	[UMeta(MDFunc.CallInEditor)]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:HideSpiderNavPoint")]
	public void HideSpiderNavPoint()
	{
		GetAttachedActors(out var OutActors);
		foreach (AActor item in OutActors)
		{
			if (item is BGUSpiderNavPointActor)
			{
				item.DetachFromActor();
				BGU_UnrealWorldUtil.DestroyActor(item);
			}
		}
	}

	[BlueprintCallable]
	[Category("NavPointInfo")]
	[UMeta(MDFunc.CallInEditor)]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavigationActor:RecordSpiderNavPoint")]
	public void RecordSpiderNavPoint()
	{
		GetAttachedActors(out var OutActors);
		for (int num = OutActors.Count - 1; num >= 0; num--)
		{
			if (!(OutActors[num] is BGUSpiderNavPointActor))
			{
				OutActors.RemoveAt(num);
			}
		}
		if (OutActors.Count == 0)
		{
			return;
		}
		NavPoints.Clear();
		foreach (AActor item2 in OutActors)
		{
			BGUSpiderNavPointActor bGUSpiderNavPointActor = item2 as BGUSpiderNavPointActor;
			FTransform actorTransform = bGUSpiderNavPointActor.GetActorTransform();
			NavPoints.Add(new FGsSpiderNavPointInfo
			{
				Location = actorTransform.GetLocation(),
				Normal = actorTransform.Rotation.GetForwardVector(),
				LinkRadius = bGUSpiderNavPointActor.LinkRadius,
				LinkAngle = bGUSpiderNavPointActor.LinkAngle,
				IsGroundPoint = bGUSpiderNavPointActor.IsGroundPoint
			});
		}
		for (int num2 = NavPoints.Count - 1; num2 >= 0; num2--)
		{
			FGsSpiderNavPointInfo item = NavPoints[num2];
			for (int num3 = NavPoints.Count - 1; num3 >= 0; num3--)
			{
				if (num2 != num3)
				{
					FGsSpiderNavPointInfo fGsSpiderNavPointInfo = NavPoints[num3];
					float num4 = MathLib.DegAcos((float)item.Normal.Dot_VectorVector(fGsSpiderNavPointInfo.Normal) / item.Normal.Size() / fGsSpiderNavPointInfo.Normal.Size());
					if (!(num4 > item.LinkAngle) && !(num4 > fGsSpiderNavPointInfo.LinkAngle))
					{
						float num5 = (fGsSpiderNavPointInfo.Location - item.Location).Size();
						if (num5 < item.LinkRadius && num5 < fGsSpiderNavPointInfo.LinkRadius)
						{
							item.NavLinkPoints.Add(new FGsSpiderNavPointLinkInfo
							{
								LinkPointIndex = num3,
								Cost = num5
							});
							USystemLibrary.DrawDebugLine(this, fGsSpiderNavPointInfo.Location, item.Location, FLinearColor.Green, 15f);
						}
					}
				}
			}
			NavPoints.RemoveAt(num2);
			NavPoints.Insert(num2, item);
		}
		MarkPackageDirty();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSpiderNavigationActor:ShowSpiderNavPoint")]
	private static void ShowSpiderNavPoint__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSpiderNavigationActor bGUSpiderNavigationActor = GCHelper.Find<BGUSpiderNavigationActor>(obj);
		bGUSpiderNavigationActor.ShowSpiderNavPoint();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSpiderNavigationActor:HideSpiderNavPoint")]
	private static void HideSpiderNavPoint__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSpiderNavigationActor bGUSpiderNavigationActor = GCHelper.Find<BGUSpiderNavigationActor>(obj);
		bGUSpiderNavigationActor.HideSpiderNavPoint();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSpiderNavigationActor:RecordSpiderNavPoint")]
	private static void RecordSpiderNavPoint__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSpiderNavigationActor bGUSpiderNavigationActor = GCHelper.Find<BGUSpiderNavigationActor>(obj);
		bGUSpiderNavigationActor.RecordSpiderNavPoint();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUSpiderNavigationActor:ReceiveTick")]
	private static void ReceiveTick__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUSpiderNavigationActor bGUSpiderNavigationActor = GCHelper.Find<BGUSpiderNavigationActor>(obj);
		float deltaSeconds = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, ReceiveTick_DeltaSeconds_Offset));
		bGUSpiderNavigationActor.ReceiveTick_Implementation(deltaSeconds);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUSpiderNavigationActor");
		Root_Offset = NativeReflection.GetPropertyOffset(intPtr, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Root", Classes.FObjectProperty);
		NativeReflection.GetPropertyRef(ref NavPoints_PropertyAddress, intPtr, "NavPoints");
		NavPoints_Offset = NativeReflection.GetPropertyOffset(intPtr, "NavPoints");
		NavPoints_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "NavPoints", Classes.FArrayProperty);
		ShowSpiderNavPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ShowSpiderNavPoint");
		ShowSpiderNavPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(ShowSpiderNavPoint_FunctionAddress);
		ShowSpiderNavPoint_IsValid = ShowSpiderNavPoint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderNavigationActor:ShowSpiderNavPoint", ShowSpiderNavPoint_IsValid);
		HideSpiderNavPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "HideSpiderNavPoint");
		HideSpiderNavPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(HideSpiderNavPoint_FunctionAddress);
		HideSpiderNavPoint_IsValid = HideSpiderNavPoint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderNavigationActor:HideSpiderNavPoint", HideSpiderNavPoint_IsValid);
		RecordSpiderNavPoint_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "RecordSpiderNavPoint");
		RecordSpiderNavPoint_ParamsSize = NativeReflection.GetFunctionParamsSize(RecordSpiderNavPoint_FunctionAddress);
		RecordSpiderNavPoint_IsValid = RecordSpiderNavPoint_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderNavigationActor:RecordSpiderNavPoint", RecordSpiderNavPoint_IsValid);
		ReceiveTick_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveTick");
		ReceiveTick_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveTick_FunctionAddress);
		ReceiveTick_DeltaSeconds_Offset = NativeReflection.GetPropertyOffset(ReceiveTick_FunctionAddress, "DeltaSeconds");
		ReceiveTick_DeltaSeconds_IsValid = NativeReflection.ValidatePropertyClass(ReceiveTick_FunctionAddress, "DeltaSeconds", Classes.FFloatProperty);
		ReceiveTick_IsValid = ReceiveTick_FunctionAddress != IntPtr.Zero && ReceiveTick_DeltaSeconds_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUSpiderNavigationActor:ReceiveTick", ReceiveTick_IsValid);
	}

	static BGUSpiderNavigationActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSpiderNavigationActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSpiderNavigationActor));
	}
}
