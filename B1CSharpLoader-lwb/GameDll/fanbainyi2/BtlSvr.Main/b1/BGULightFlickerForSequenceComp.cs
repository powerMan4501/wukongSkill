using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp")]
public class BGULightFlickerForSequenceComp : BGULightFlickerComp
{
	private static bool StartIntensity_IsValid;

	private static int StartIntensity_Offset;

	private static bool TargetIntensity_IsValid;

	private static int TargetIntensity_Offset;

	private static bool LerpTime_IsValid;

	private static int LerpTime_Offset;

	private static bool bBeginTick_IsValid;

	private static int bBeginTick_Offset;

	private static FFieldAddress bBeginTick_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[DisplayName("")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.ClampMax, 100f)]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:StartIntensity")]
	public float StartIntensity
	{
		get
		{
			CheckDestroyed();
			if (!StartIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:StartIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, StartIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!StartIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:StartIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, StartIntensity_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("")]
	[UMeta(MDProp.ClampMin, 0f)]
	[UMeta(MDProp.ClampMax, 100f)]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:TargetIntensity")]
	public float TargetIntensity
	{
		get
		{
			CheckDestroyed();
			if (!TargetIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:TargetIntensity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, TargetIntensity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!TargetIntensity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:TargetIntensity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, TargetIntensity_Offset), value);
			}
		}
	}

	[UMeta(MDProp.ClampMax, 100f)]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("")]
	[UMeta(MDProp.ClampMin, 0f)]
	[Tooltip("")]
	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:LerpTime")]
	public float LerpTime
	{
		get
		{
			CheckDestroyed();
			if (!LerpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:LerpTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LerpTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LerpTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:LerpTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LerpTime_Offset), value);
			}
		}
	}

	[Tooltip("")]
	[DisplayName("")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:bBeginTick")]
	public bool bBeginTick
	{
		get
		{
			CheckDestroyed();
			if (!bBeginTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:bBeginTick");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bBeginTick_Offset), 0, bBeginTick_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bBeginTick_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerForSequenceComp:bBeginTick");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bBeginTick_Offset), 0, bBeginTick_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		StartIntensity = 0f;
		TargetIntensity = 50f;
		LerpTime = 3.866f;
		bBeginTick = false;
	}

	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		base.ReceiveBeginPlay_Implementation();
		CurIntensity = StartIntensity;
	}

	[USharpPath("/Script/b1-Managed.BGULightFlickerForSequenceComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		if (bBeginTick)
		{
			TickLerpIntensity(DeltaTime);
			base.TickComponentInCS_Implementation(DeltaTime);
		}
	}

	private void TickLerpIntensity(float DeltaTime)
	{
		if (!(LightComp == null) && !(Owner == null) && !Owner.IsPendingKill)
		{
			CurIntensity += (TargetIntensity - StartIntensity) / LerpTime * DeltaTime;
			CurIntensity = ((CurIntensity <= TargetIntensity) ? CurIntensity : TargetIntensity);
			LightComp.SetIntensity(CurIntensity);
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULightFlickerForSequenceComp:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULightFlickerForSequenceComp bGULightFlickerForSequenceComp = GCHelper.Find<BGULightFlickerForSequenceComp>(obj);
		bGULightFlickerForSequenceComp.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULightFlickerForSequenceComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULightFlickerForSequenceComp bGULightFlickerForSequenceComp = GCHelper.Find<BGULightFlickerForSequenceComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bGULightFlickerForSequenceComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGULightFlickerForSequenceComp");
		StartIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "StartIntensity");
		StartIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StartIntensity", Classes.FFloatProperty);
		TargetIntensity_Offset = NativeReflection.GetPropertyOffset(intPtr, "TargetIntensity");
		TargetIntensity_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "TargetIntensity", Classes.FFloatProperty);
		LerpTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "LerpTime");
		LerpTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "LerpTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref bBeginTick_PropertyAddress, intPtr, "bBeginTick");
		bBeginTick_Offset = NativeReflection.GetPropertyOffset(intPtr, "bBeginTick");
		bBeginTick_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bBeginTick", Classes.FBoolProperty);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULightFlickerForSequenceComp:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULightFlickerForSequenceComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BGULightFlickerForSequenceComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULightFlickerForSequenceComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGULightFlickerForSequenceComp));
	}
}
