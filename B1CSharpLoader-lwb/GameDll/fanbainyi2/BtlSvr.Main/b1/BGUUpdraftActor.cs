using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUUpdraftActor")]
internal class BGUUpdraftActor : BGUActorBaseCS
{
	private static bool UpdraftVolume_IsValid;

	private static int UpdraftVolume_Offset;

	private static bool UpVelocity_IsValid;

	private static int UpVelocity_Offset;

	private static bool CD_IsValid;

	private static int CD_Offset;

	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUUpdraftActor:UpdraftVolume")]
	public UBoxComponent UpdraftVolume
	{
		get
		{
			CheckDestroyed();
			if (!UpdraftVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:UpdraftVolume");
				return null;
			}
			return UObjectMarshaler<UBoxComponent>.FromNative(IntPtr.Add(base.Address, UpdraftVolume_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpdraftVolume_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:UpdraftVolume");
			}
			else
			{
				UObjectMarshaler<UBoxComponent>.ToNative(IntPtr.Add(base.Address, UpdraftVolume_Offset), value);
			}
		}
	}

	[Category("Default")]
	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[Tooltip("速度方向为上升气流的Z正方向")]
	[DisplayName("附加上升速度值")]
	[USharpPath("/Script/b1-Managed.BGUUpdraftActor:UpVelocity")]
	public float UpVelocity
	{
		get
		{
			CheckDestroyed();
			if (!UpVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:UpVelocity");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, UpVelocity_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!UpVelocity_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:UpVelocity");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, UpVelocity_Offset), value);
			}
		}
	}

	[EditAnywhere]
	[DisplayName("冷却时间")]
	[BlueprintReadWrite]
	[Category("Default")]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BGUUpdraftActor:CD")]
	public float CD
	{
		get
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:CD");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, CD_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!CD_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUUpdraftActor:CD");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, CD_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		UpdraftVolume = initializer.CreateDefaultSubobject<UBoxComponent>(this, B1GlobalFNames.UpdraftVolume);
		UpdraftVolume.SetCollisionProfileName(B1GlobalFNames.DispInteractAreaVolume);
		SetRootComponentCS(UpdraftVolume);
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddCompUObj<BUS_UpdraftComp>();
	}

	protected override void CreateDataContainer(FObjectInitializer initializer)
	{
		base.DataComp = initializer.CreateDefaultSubobject<BUS_UpdraftDataComp>(this, B1GlobalFNames.UpdraftDataComp);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUUpdraftActor");
		UpdraftVolume_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpdraftVolume");
		UpdraftVolume_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpdraftVolume", Classes.FObjectProperty);
		UpVelocity_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "UpVelocity");
		UpVelocity_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "UpVelocity", Classes.FFloatProperty);
		CD_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "CD");
		CD_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "CD", Classes.FFloatProperty);
	}

	static BGUUpdraftActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUUpdraftActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUUpdraftActor));
	}
}
