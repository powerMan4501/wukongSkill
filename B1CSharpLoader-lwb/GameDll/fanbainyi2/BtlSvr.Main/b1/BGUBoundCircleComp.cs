using System;
using UnrealEngine.Runtime;

namespace b1;

[BlueprintSpawnableComponent]
[UClass]
[ClassGroup("GSCircleBound")]
[USharpPath("/Script/b1-Managed.BGUBoundCircleComp")]
public class BGUBoundCircleComp : USceneComponentTickable
{
	private static bool Radius_IsValid;

	private static int Radius_Offset;

	private static bool DragSpeed_IsValid;

	private static int DragSpeed_Offset;

	private static bool BackSpeed_IsValid;

	private static int BackSpeed_Offset;

	private static bool TimeStep_IsValid;

	private static int TimeStep_Offset;

	private static bool DrawDebug_IsValid;

	private static int DrawDebug_Offset;

	private static FFieldAddress DrawDebug_PropertyAddress;

	private static bool AddDragVec_IsValid;

	private static IntPtr AddDragVec_FunctionAddress;

	private static int AddDragVec_ParamsSize;

	private static bool AddDragVec_DragVectorInWorld_IsValid;

	private static int AddDragVec_DragVectorInWorld_Offset;

	private static FFieldAddress AddDragVec_DragVectorInWorld_PropertyAddress;

	private static bool AddDragVec_DragFactor_IsValid;

	private static int AddDragVec_DragFactor_Offset;

	private static bool SetGSEnabled_IsValid;

	private static IntPtr SetGSEnabled_FunctionAddress;

	private static int SetGSEnabled_ParamsSize;

	private static bool SetGSEnabled_IsEnabled_IsValid;

	private static int SetGSEnabled_IsEnabled_Offset;

	private static FFieldAddress SetGSEnabled_IsEnabled_PropertyAddress;

	private static bool GSTmpBeginPlay_IsValid;

	private static IntPtr GSTmpBeginPlay_FunctionAddress;

	private static int GSTmpBeginPlay_ParamsSize;

	private static bool BeginPlayGS_IsValid;

	private static IntPtr BeginPlayGS_FunctionAddress;

	private static int BeginPlayGS_ParamsSize;

	private static bool TickComponentGS_IsValid;

	private static IntPtr TickComponentGS_FunctionAddress;

	private static int TickComponentGS_ParamsSize;

	private static bool TickComponentGS_DeltaTime_IsValid;

	private static int TickComponentGS_DeltaTime_Offset;

	private FVector CurRetLocation { get; set; }

	private FVector LastDragVector { get; set; }

	private int DragingKeepFrames { get; set; }

	private bool IsGSEnabled { get; set; }

	[UMeta(MD.ToolTip, "圆形限制区域的最大半径")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:Radius")]
	public float Radius
	{
		get
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:Radius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, Radius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Radius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:Radius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, Radius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "拖动速度")]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:DragSpeed")]
	public float DragSpeed
	{
		get
		{
			CheckDestroyed();
			if (!DragSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:DragSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DragSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DragSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:DragSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DragSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[UMeta(MD.ToolTip, "回归速度")]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:BackSpeed")]
	public float BackSpeed
	{
		get
		{
			CheckDestroyed();
			if (!BackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:BackSpeed");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, BackSpeed_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!BackSpeed_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:BackSpeed");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, BackSpeed_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "拟合的时间计算步长")]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:TimeStep")]
	public float TimeStep
	{
		get
		{
			CheckDestroyed();
			if (!TimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:TimeStep");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TimeStep_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TimeStep_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:TimeStep");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TimeStep_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UMeta(MD.ToolTip, "是否显示debug图形")]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:DrawDebug")]
	public bool DrawDebug
	{
		get
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:DrawDebug");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!DrawDebug_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUBoundCircleComp:DrawDebug");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, DrawDebug_Offset), 0, DrawDebug_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		Radius = 600f;
		DragSpeed = 0.2f;
		BackSpeed = 1f;
		TimeStep = 0.016f;
		DrawDebug = false;
	}

	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:BeginPlayGS")]
	protected override void BeginPlayGS_Implementation()
	{
		DragingKeepFrames = 0;
		IsGSEnabled = false;
		CurRetLocation = FVector.ZeroVector;
		LastDragVector = FVector.ZeroVector;
	}

	[BlueprintCallable]
	[UFunction]
	[UMeta(MD.ToolTip, "是否正常工作")]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:SetGSEnabled")]
	public void SetGSEnabled(bool IsEnabled)
	{
		IsGSEnabled = IsEnabled;
	}

	[UMeta(MD.ToolTip, "添加主动拖扯速度,世界坐标方向,Factor为标量大小")]
	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:AddDragVec")]
	public void AddDragVec(FVector DragVectorInWorld, float DragFactor)
	{
		if (DrawDebug)
		{
			FVector centerPos = DragVectorInWorld;
			centerPos.Z = 1f;
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, centerPos, 10f, -1f, FColor.Red);
		}
		FVector fVector = GetWorldLocation() - CurRetLocation;
		DragVectorInWorld.Z = fVector.Z;
		LastDragVector = (DragVectorInWorld - fVector).GetSafeNormal() * DragFactor;
		DragingKeepFrames = 2;
	}

	private void UpdateDesiredLocation(float DeltaTime)
	{
		if (DragingKeepFrames > 0)
		{
			DragingKeepFrames--;
			FVector targetLocation = LastDragVector.GetSafeNormal() * Radius;
			InterpToWithTimeStep(targetLocation, DragSpeed, DeltaTime);
		}
		else if (!CurRetLocation.Equals(FVector.ZeroVector, 0.004999999888241291))
		{
			InterpToWithTimeStep(FVector.ZeroVector, BackSpeed, DeltaTime);
		}
	}

	private void InterpToWithTimeStep(FVector TargetLocation, float Speed, float DeltaTime)
	{
		if (DrawDebug)
		{
			FVector centerPos = GetWorldLocation() + CurRetLocation;
			FVector centerPos2 = GetWorldLocation() + TargetLocation;
			FVector worldLocation = GetWorldLocation();
			centerPos.Z = 1f;
			centerPos2.Z = 1f;
			worldLocation.Z = 1f;
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, worldLocation, Radius, -1f, FColor.Pink);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, worldLocation, 20f, -1f, FColor.YellowGreen);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, centerPos2, 20f, -1f, FColor.Green);
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, centerPos, 20f, -1f, FColor.Yellow);
		}
		float num = DeltaTime;
		while (num > 1E-05f)
		{
			float num2 = Math.Min(TimeStep, num);
			num -= num2;
			CurRetLocation = FMath.VInterpTo(CurRetLocation, TargetLocation, num2, Speed);
		}
		FVector worldLocation2 = GetWorldLocation();
		SetRelativeLocation(CurRetLocation, bSweep: false, out var _, bTeleport: true);
		(GetWorldLocation() - worldLocation2).Size();
	}

	[UFunction]
	[BlueprintCallable]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:GSTmpBeginPlay")]
	public void GSTmpBeginPlay()
	{
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGUBoundCircleComp:TickComponentGS")]
	protected override void TickComponentGS_Implementation(float DeltaTime)
	{
		if (DrawDebug)
		{
			FVector worldLocation = GetWorldLocation();
			worldLocation.Z = 1f;
			UBGUFunctionLibraryForCS.BGUDrawDebugSphereEx(GetOwner().World, worldLocation, 10f, -1f, FColor.AliceBlue);
		}
		if (IsGSEnabled)
		{
			UpdateDesiredLocation(DeltaTime);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBoundCircleComp:AddDragVec")]
	private static void AddDragVec__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBoundCircleComp bGUBoundCircleComp = GCHelper.Find<BGUBoundCircleComp>(obj);
		FVector dragVectorInWorld = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, AddDragVec_DragVectorInWorld_Offset));
		float dragFactor = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, AddDragVec_DragFactor_Offset));
		bGUBoundCircleComp.AddDragVec(dragVectorInWorld, dragFactor);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBoundCircleComp:SetGSEnabled")]
	private static void SetGSEnabled__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBoundCircleComp bGUBoundCircleComp = GCHelper.Find<BGUBoundCircleComp>(obj);
		bool gSEnabled = BoolMarshaler.FromNative(IntPtr.Add(buffer, SetGSEnabled_IsEnabled_Offset), 0, SetGSEnabled_IsEnabled_PropertyAddress.Address);
		bGUBoundCircleComp.SetGSEnabled(gSEnabled);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBoundCircleComp:GSTmpBeginPlay")]
	private static void GSTmpBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBoundCircleComp bGUBoundCircleComp = GCHelper.Find<BGUBoundCircleComp>(obj);
		bGUBoundCircleComp.GSTmpBeginPlay();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBoundCircleComp:BeginPlayGS")]
	private static void BeginPlayGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBoundCircleComp bGUBoundCircleComp = GCHelper.Find<BGUBoundCircleComp>(obj);
		bGUBoundCircleComp.BeginPlayGS_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGUBoundCircleComp:TickComponentGS")]
	private static void TickComponentGS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGUBoundCircleComp bGUBoundCircleComp = GCHelper.Find<BGUBoundCircleComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentGS_DeltaTime_Offset));
		bGUBoundCircleComp.TickComponentGS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGUBoundCircleComp");
		Radius_Offset = NativeReflection.GetPropertyOffset(intPtr, "Radius");
		Radius_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "Radius", Classes.FFloatProperty);
		DragSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "DragSpeed");
		DragSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DragSpeed", Classes.FFloatProperty);
		BackSpeed_Offset = NativeReflection.GetPropertyOffset(intPtr, "BackSpeed");
		BackSpeed_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "BackSpeed", Classes.FFloatProperty);
		TimeStep_Offset = NativeReflection.GetPropertyOffset(intPtr, "TimeStep");
		TimeStep_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TimeStep", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref DrawDebug_PropertyAddress, intPtr, "DrawDebug");
		DrawDebug_Offset = NativeReflection.GetPropertyOffset(intPtr, "DrawDebug");
		DrawDebug_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DrawDebug", Classes.FBoolProperty);
		AddDragVec_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "AddDragVec");
		AddDragVec_ParamsSize = NativeReflection.GetFunctionParamsSize(AddDragVec_FunctionAddress);
		NativeReflection.GetPropertyRef(ref AddDragVec_DragVectorInWorld_PropertyAddress, AddDragVec_FunctionAddress, "DragVectorInWorld");
		AddDragVec_DragVectorInWorld_Offset = NativeReflection.GetPropertyOffset(AddDragVec_FunctionAddress, "DragVectorInWorld");
		AddDragVec_DragVectorInWorld_IsValid = NativeReflection.ValidatePropertyClass(AddDragVec_FunctionAddress, "DragVectorInWorld", Classes.FStructProperty);
		AddDragVec_DragFactor_Offset = NativeReflection.GetPropertyOffset(AddDragVec_FunctionAddress, "DragFactor");
		AddDragVec_DragFactor_IsValid = NativeReflection.ValidatePropertyClass(AddDragVec_FunctionAddress, "DragFactor", Classes.FFloatProperty);
		AddDragVec_IsValid = AddDragVec_FunctionAddress != IntPtr.Zero && AddDragVec_DragVectorInWorld_IsValid && AddDragVec_DragFactor_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBoundCircleComp:AddDragVec", AddDragVec_IsValid);
		SetGSEnabled_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "SetGSEnabled");
		SetGSEnabled_ParamsSize = NativeReflection.GetFunctionParamsSize(SetGSEnabled_FunctionAddress);
		NativeReflection.GetPropertyRef(ref SetGSEnabled_IsEnabled_PropertyAddress, SetGSEnabled_FunctionAddress, "IsEnabled");
		SetGSEnabled_IsEnabled_Offset = NativeReflection.GetPropertyOffset(SetGSEnabled_FunctionAddress, "IsEnabled");
		SetGSEnabled_IsEnabled_IsValid = NativeReflection.ValidatePropertyClass(SetGSEnabled_FunctionAddress, "IsEnabled", Classes.FBoolProperty);
		SetGSEnabled_IsValid = SetGSEnabled_FunctionAddress != IntPtr.Zero && SetGSEnabled_IsEnabled_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBoundCircleComp:SetGSEnabled", SetGSEnabled_IsValid);
		GSTmpBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GSTmpBeginPlay");
		GSTmpBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(GSTmpBeginPlay_FunctionAddress);
		GSTmpBeginPlay_IsValid = GSTmpBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBoundCircleComp:GSTmpBeginPlay", GSTmpBeginPlay_IsValid);
		BeginPlayGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "BeginPlayGS");
		BeginPlayGS_ParamsSize = NativeReflection.GetFunctionParamsSize(BeginPlayGS_FunctionAddress);
		BeginPlayGS_IsValid = BeginPlayGS_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBoundCircleComp:BeginPlayGS", BeginPlayGS_IsValid);
		TickComponentGS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentGS");
		TickComponentGS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentGS_FunctionAddress);
		TickComponentGS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentGS_FunctionAddress, "DeltaTime");
		TickComponentGS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentGS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentGS_IsValid = TickComponentGS_FunctionAddress != IntPtr.Zero && TickComponentGS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGUBoundCircleComp:TickComponentGS", TickComponentGS_IsValid);
	}

	static BGUBoundCircleComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUBoundCircleComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUBoundCircleComp));
	}
}
