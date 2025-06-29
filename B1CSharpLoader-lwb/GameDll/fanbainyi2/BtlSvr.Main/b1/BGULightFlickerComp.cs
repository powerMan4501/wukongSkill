using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGULightFlickerComp")]
public class BGULightFlickerComp : UBaseActorCompTickable
{
	protected float OrigIntensity;

	protected float NextIntensity;

	protected float CurIntensity;

	protected float ThisFlickTime;

	protected float FlickTimeRandomMinOrg;

	protected FVector DefaultPos;

	protected FVector TargetPos;

	protected FVector CurPos;

	protected float TickedTime;

	protected bool bInit;

	protected ULightComponent LightComp;

	protected AActor Owner;

	protected FBox RandomPosBox;

	protected FVector2D RandomRange;

	protected FVector2D Vector0To1 = new FVector2D(0.0, 1.0);

	private float totalTime;

	private float totalDelata;

	private float totalDelataLength;

	private static bool FlickRange_IsValid;

	private static int FlickRange_Offset;

	private static bool FlickTimeRandomMin_IsValid;

	private static int FlickTimeRandomMin_Offset;

	private static bool FlickTimeRandomMax_IsValid;

	private static int FlickTimeRandomMax_Offset;

	private static bool RandomRemapPower_IsValid;

	private static int RandomRemapPower_Offset;

	private static bool DestroyTime_IsValid;

	private static int DestroyTime_Offset;

	private static bool PosFlickRange_IsValid;

	private static int PosFlickRange_Offset;

	private static bool OverrideProperty_IsValid;

	private static IntPtr OverrideProperty_FunctionAddress;

	private static int OverrideProperty_ParamsSize;

	private static bool OverrideProperty_flickRange_IsValid;

	private static int OverrideProperty_flickRange_Offset;

	private static bool OverrideProperty_flickTimeRandomMin_IsValid;

	private static int OverrideProperty_flickTimeRandomMin_Offset;

	private static bool OverrideProperty_flickTimeRandomMax_IsValid;

	private static int OverrideProperty_flickTimeRandomMax_Offset;

	private static bool OverrideProperty_randomRemapPower_IsValid;

	private static int OverrideProperty_randomRemapPower_Offset;

	private static bool OverrideProperty_destroyTime_IsValid;

	private static int OverrideProperty_destroyTime_Offset;

	private static bool OverrideProperty_posFlickRange_IsValid;

	private static int OverrideProperty_posFlickRange_Offset;

	private static FFieldAddress OverrideProperty_posFlickRange_PropertyAddress;

	private static bool ReceiveBeginPlay_IsValid;

	private static IntPtr ReceiveBeginPlay_FunctionAddress;

	private static int ReceiveBeginPlay_ParamsSize;

	private static bool TickComponentInCS_IsValid;

	private static IntPtr TickComponentInCS_FunctionAddress;

	private static int TickComponentInCS_ParamsSize;

	private static bool TickComponentInCS_DeltaTime_IsValid;

	private static int TickComponentInCS_DeltaTime_Offset;

	[UMeta(MDProp.ClampMax, 100f)]
	[UMeta(MDProp.ClampMin, 0f)]
	[DisplayName("灯光亮度抖动范围")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[UProperty]
	[Tooltip("0表示完全不抖动，100表示亮度抖动范围跟灯光亮度一致")]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:FlickRange")]
	public float FlickRange
	{
		get
		{
			CheckDestroyed();
			if (!FlickRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickRange");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlickRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlickRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickRange");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlickRange_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("抖动频率最小值")]
	[Tooltip("一般不调")]
	[UMeta(MDProp.ClampMin, 0.01f)]
	[UMeta(MDProp.ClampMax, 1f)]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMin")]
	public float FlickTimeRandomMin
	{
		get
		{
			CheckDestroyed();
			if (!FlickTimeRandomMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMin");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlickTimeRandomMin_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlickTimeRandomMin_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMin");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlickTimeRandomMin_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[UProperty]
	[BlueprintReadWrite]
	[DisplayName("抖动频率最大值，单位为秒")]
	[Tooltip("数值越小，抖动越快，数值越大，抖动越慢")]
	[UMeta(MDProp.ClampMin, 0.01f)]
	[UMeta(MDProp.ClampMax, 1f)]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMax")]
	public float FlickTimeRandomMax
	{
		get
		{
			CheckDestroyed();
			if (!FlickTimeRandomMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMax");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, FlickTimeRandomMax_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!FlickTimeRandomMax_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:FlickTimeRandomMax");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, FlickTimeRandomMax_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("值越大，越倾向于用FlickTimeRandomMin，反之亦反,1为没有偏向的值")]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:RandomRemapPower")]
	public float RandomRemapPower
	{
		get
		{
			CheckDestroyed();
			if (!RandomRemapPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:RandomRemapPower");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, RandomRemapPower_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!RandomRemapPower_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:RandomRemapPower");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, RandomRemapPower_Offset), value);
			}
		}
	}

	[Tooltip("默认为0，表示永远不自杀")]
	[DisplayName("灯光自杀时间")]
	[BlueprintReadWrite]
	[UProperty]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:DestroyTime")]
	public float DestroyTime
	{
		get
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:DestroyTime");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, DestroyTime_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!DestroyTime_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:DestroyTime");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, DestroyTime_Offset), value);
			}
		}
	}

	[UProperty]
	[Tooltip("单位为厘米")]
	[DisplayName("灯光位置抖动范围")]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:PosFlickRange")]
	public FVector PosFlickRange
	{
		get
		{
			CheckDestroyed();
			if (!PosFlickRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:PosFlickRange");
				return default(FVector);
			}
			return BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(base.Address, PosFlickRange_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!PosFlickRange_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGULightFlickerComp:PosFlickRange");
			}
			else
			{
				BlittableTypeMarshaler<FVector>.ToNative(IntPtr.Add(base.Address, PosFlickRange_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		FlickRange = 20f;
		FlickTimeRandomMin = 0.016f;
		FlickTimeRandomMax = 0.3f;
		RandomRemapPower = 1f;
		DestroyTime = 0f;
		PosFlickRange = FVector.ZeroVector;
	}

	[BlueprintCallable]
	[UFunction]
	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:OverrideProperty")]
	public void OverrideProperty(float flickRange, float flickTimeRandomMin, float flickTimeRandomMax, float randomRemapPower, float destroyTime, FVector posFlickRange)
	{
		FlickRange = flickRange;
		FlickTimeRandomMin = flickTimeRandomMin;
		FlickTimeRandomMax = flickTimeRandomMax;
		RandomRemapPower = randomRemapPower;
		DestroyTime = destroyTime;
		PosFlickRange = posFlickRange;
		UGSE_AnimFuncLib.MarkDirty(this);
	}

	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:ReceiveBeginPlay")]
	protected override void ReceiveBeginPlay_Implementation()
	{
		bInit = false;
		base.ReceiveBeginPlay_Implementation();
		Init();
	}

	private void Init()
	{
		Owner = GetOwner();
		if (Owner != null && !Owner.IsPendingKill)
		{
			LightComp = Owner.GetComponentByClass<ULightComponent>();
			if (LightComp != null)
			{
				DefaultPos = LightComp.GetWorldLocation();
				TargetPos = DefaultPos;
				CurPos = DefaultPos;
				OrigIntensity = LightComp.Intensity;
				NextIntensity = OrigIntensity;
				CurIntensity = OrigIntensity;
				FlickTimeRandomMin = FMath.Clamp(FlickTimeRandomMin, 0.01f, 1f);
				FlickTimeRandomMax = FMath.Max3(0.01f, FMath.Clamp(FlickTimeRandomMax, 0.01f, 1f), FlickTimeRandomMin);
				FlickTimeRandomMinOrg = FlickTimeRandomMin;
				ThisFlickTime = MathLib.RandomFloatInRange(FlickTimeRandomMin, FlickTimeRandomMax);
				RandomRange = new FVector2D(FlickTimeRandomMin, FlickTimeRandomMax);
				if (!PosFlickRange.IsNearlyZero())
				{
					RandomPosBox = new FBox(DefaultPos - PosFlickRange, DefaultPos + PosFlickRange);
				}
			}
		}
		bInit = true;
	}

	[USharpPath("/Script/b1-Managed.BGULightFlickerComp:TickComponentInCS")]
	protected override void TickComponentInCS_Implementation(float DeltaTime)
	{
		base.TickComponentInCS_Implementation(DeltaTime);
		if (!bInit)
		{
			Init();
		}
		TickLightFlicker(DeltaTime);
	}

	private void TickLightFlicker(float DeltaTime)
	{
		if (LightComp == null || Owner == null || Owner.IsPendingKill || FMath.IsNearlyZero(OrigIntensity) || !LightComp.AffectsWorld)
		{
			return;
		}
		bool bNextPass = TickIntensity(DeltaTime);
		TickPos(DeltaTime, bNextPass);
		if (!FMath.IsNearlyZero(DestroyTime))
		{
			TickedTime += DeltaTime;
			if (TickedTime > DestroyTime)
			{
				Owner.DestroyActor();
			}
		}
	}

	private bool TickIntensity(float DeltaTime)
	{
		bool result = false;
		Owner.World.GetWorldDeltaSeconds();
		float num = FMath.Max(ThisFlickTime, 0.01f);
		CurIntensity += (NextIntensity - CurIntensity) * FMath.Clamp(DeltaTime / num, 0f, 1f);
		ThisFlickTime -= DeltaTime;
		LightComp.SetIntensity(CurIntensity);
		if (FlickTimeRandomMin <= DeltaTime)
		{
			FlickTimeRandomMin = DeltaTime;
		}
		else
		{
			FlickTimeRandomMin = FlickTimeRandomMinOrg;
		}
		if ((double)ThisFlickTime < (double)DeltaTime * 1.5)
		{
			result = true;
			ThisFlickTime = MathLib.RandomFloatInRange(FlickTimeRandomMin, FlickTimeRandomMax);
			ThisFlickTime = FMath.GetMappedRangeValueClamped(RandomRange, Vector0To1, ThisFlickTime);
			ThisFlickTime = FMath.Pow(ThisFlickTime, RandomRemapPower);
			ThisFlickTime = FMath.GetMappedRangeValueClamped(Vector0To1, RandomRange, ThisFlickTime);
			float num2 = FMath.Lerp(0f, OrigIntensity, FlickRange / 100f);
			NextIntensity = MathLib.RandomFloatInRange(OrigIntensity + num2, OrigIntensity - num2);
		}
		return result;
	}

	private void TickPos(float DeltaTime, bool bNextPass)
	{
		if (!PosFlickRange.IsNearlyZero())
		{
			_ = RandomPosBox;
			Owner.World.GetWorldDeltaSeconds();
			float num = FMath.Max(ThisFlickTime, 0.016f);
			CurPos += (TargetPos - CurPos) / num * DeltaTime;
			LightComp.SetWorldLocation(CurPos, bSweep: false, out var _, bTeleport: false);
			if (bNextPass)
			{
				TargetPos = FMath.RandPointInBox(RandomPosBox);
			}
		}
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULightFlickerComp:OverrideProperty")]
	private static void OverrideProperty__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULightFlickerComp bGULightFlickerComp = GCHelper.Find<BGULightFlickerComp>(obj);
		float flickRange = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideProperty_flickRange_Offset));
		float flickTimeRandomMin = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideProperty_flickTimeRandomMin_Offset));
		float flickTimeRandomMax = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideProperty_flickTimeRandomMax_Offset));
		float randomRemapPower = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideProperty_randomRemapPower_Offset));
		float destroyTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, OverrideProperty_destroyTime_Offset));
		FVector posFlickRange = BlittableTypeMarshaler<FVector>.FromNative(IntPtr.Add(buffer, OverrideProperty_posFlickRange_Offset));
		bGULightFlickerComp.OverrideProperty(flickRange, flickTimeRandomMin, flickTimeRandomMax, randomRemapPower, destroyTime, posFlickRange);
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULightFlickerComp:ReceiveBeginPlay")]
	private static void ReceiveBeginPlay__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULightFlickerComp bGULightFlickerComp = GCHelper.Find<BGULightFlickerComp>(obj);
		bGULightFlickerComp.ReceiveBeginPlay_Implementation();
	}

	[UFunctionInvoker("/Script/b1-Managed.BGULightFlickerComp:TickComponentInCS")]
	private static void TickComponentInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		BGULightFlickerComp bGULightFlickerComp = GCHelper.Find<BGULightFlickerComp>(obj);
		float deltaTime = BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(buffer, TickComponentInCS_DeltaTime_Offset));
		bGULightFlickerComp.TickComponentInCS_Implementation(deltaTime);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BGULightFlickerComp");
		FlickRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlickRange");
		FlickRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlickRange", Classes.FFloatProperty);
		FlickTimeRandomMin_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlickTimeRandomMin");
		FlickTimeRandomMin_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlickTimeRandomMin", Classes.FFloatProperty);
		FlickTimeRandomMax_Offset = NativeReflection.GetPropertyOffset(intPtr, "FlickTimeRandomMax");
		FlickTimeRandomMax_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "FlickTimeRandomMax", Classes.FFloatProperty);
		RandomRemapPower_Offset = NativeReflection.GetPropertyOffset(intPtr, "RandomRemapPower");
		RandomRemapPower_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "RandomRemapPower", Classes.FFloatProperty);
		DestroyTime_Offset = NativeReflection.GetPropertyOffset(intPtr, "DestroyTime");
		DestroyTime_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "DestroyTime", Classes.FFloatProperty);
		PosFlickRange_Offset = NativeReflection.GetPropertyOffset(intPtr, "PosFlickRange");
		PosFlickRange_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "PosFlickRange", Classes.FStructProperty);
		OverrideProperty_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "OverrideProperty");
		OverrideProperty_ParamsSize = NativeReflection.GetFunctionParamsSize(OverrideProperty_FunctionAddress);
		OverrideProperty_flickRange_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "flickRange");
		OverrideProperty_flickRange_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "flickRange", Classes.FFloatProperty);
		OverrideProperty_flickTimeRandomMin_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "flickTimeRandomMin");
		OverrideProperty_flickTimeRandomMin_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "flickTimeRandomMin", Classes.FFloatProperty);
		OverrideProperty_flickTimeRandomMax_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "flickTimeRandomMax");
		OverrideProperty_flickTimeRandomMax_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "flickTimeRandomMax", Classes.FFloatProperty);
		OverrideProperty_randomRemapPower_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "randomRemapPower");
		OverrideProperty_randomRemapPower_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "randomRemapPower", Classes.FFloatProperty);
		OverrideProperty_destroyTime_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "destroyTime");
		OverrideProperty_destroyTime_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "destroyTime", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref OverrideProperty_posFlickRange_PropertyAddress, OverrideProperty_FunctionAddress, "posFlickRange");
		OverrideProperty_posFlickRange_Offset = NativeReflection.GetPropertyOffset(OverrideProperty_FunctionAddress, "posFlickRange");
		OverrideProperty_posFlickRange_IsValid = NativeReflection.ValidatePropertyClass(OverrideProperty_FunctionAddress, "posFlickRange", Classes.FStructProperty);
		OverrideProperty_IsValid = OverrideProperty_FunctionAddress != IntPtr.Zero && OverrideProperty_flickRange_IsValid && OverrideProperty_flickTimeRandomMin_IsValid && OverrideProperty_flickTimeRandomMax_IsValid && OverrideProperty_randomRemapPower_IsValid && OverrideProperty_destroyTime_IsValid && OverrideProperty_posFlickRange_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULightFlickerComp:OverrideProperty", OverrideProperty_IsValid);
		ReceiveBeginPlay_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "ReceiveBeginPlay");
		ReceiveBeginPlay_ParamsSize = NativeReflection.GetFunctionParamsSize(ReceiveBeginPlay_FunctionAddress);
		ReceiveBeginPlay_IsValid = ReceiveBeginPlay_FunctionAddress != IntPtr.Zero;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULightFlickerComp:ReceiveBeginPlay", ReceiveBeginPlay_IsValid);
		TickComponentInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "TickComponentInCS");
		TickComponentInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(TickComponentInCS_FunctionAddress);
		TickComponentInCS_DeltaTime_Offset = NativeReflection.GetPropertyOffset(TickComponentInCS_FunctionAddress, "DeltaTime");
		TickComponentInCS_DeltaTime_IsValid = NativeReflection.ValidatePropertyClass(TickComponentInCS_FunctionAddress, "DeltaTime", Classes.FFloatProperty);
		TickComponentInCS_IsValid = TickComponentInCS_FunctionAddress != IntPtr.Zero && TickComponentInCS_DeltaTime_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BGULightFlickerComp:TickComponentInCS", TickComponentInCS_IsValid);
	}

	static BGULightFlickerComp()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGULightFlickerComp)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGULightFlickerComp));
	}
}
