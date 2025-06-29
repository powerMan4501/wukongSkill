using System;
using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[BlueprintSpawnableComponent]
[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor")]
public class BGUSpiderNavPointActor : AActor
{
	private static bool Root_IsValid;

	private static int Root_Offset;

	private static bool Arrow_IsValid;

	private static int Arrow_Offset;

	private static bool LinkRadius_IsValid;

	private static int LinkRadius_Offset;

	private static bool LinkAngle_IsValid;

	private static int LinkAngle_Offset;

	private static bool IsGroundPoint_IsValid;

	private static int IsGroundPoint_Offset;

	private static FFieldAddress IsGroundPoint_PropertyAddress;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor:Root")]
	public UStaticMeshComponent Root
	{
		get
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:Root");
				return null;
			}
			return UObjectMarshaler<UStaticMeshComponent>.FromNative(IntPtr.Add(base.Address, Root_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Root_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:Root");
			}
			else
			{
				UObjectMarshaler<UStaticMeshComponent>.ToNative(IntPtr.Add(base.Address, Root_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor:Arrow")]
	public UArrowComponent Arrow
	{
		get
		{
			CheckDestroyed();
			if (!Arrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:Arrow");
				return null;
			}
			return UObjectMarshaler<UArrowComponent>.FromNative(IntPtr.Add(base.Address, Arrow_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Arrow_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:Arrow");
			}
			else
			{
				UObjectMarshaler<UArrowComponent>.ToNative(IntPtr.Add(base.Address, Arrow_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor:LinkRadius")]
	public float LinkRadius
	{
		get
		{
			CheckDestroyed();
			if (!LinkRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:LinkRadius");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinkRadius_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinkRadius_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:LinkRadius");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinkRadius_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor:LinkAngle")]
	public float LinkAngle
	{
		get
		{
			CheckDestroyed();
			if (!LinkAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:LinkAngle");
				return 0f;
			}
			return BlittableTypeMarshaler<float>.FromNative(IntPtr.Add(base.Address, LinkAngle_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!LinkAngle_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:LinkAngle");
			}
			else
			{
				BlittableTypeMarshaler<float>.ToNative(IntPtr.Add(base.Address, LinkAngle_Offset), value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[DisplayName("上墙点")]
	[USharpPath("/Script/b1-Managed.BGUSpiderNavPointActor:IsGroundPoint")]
	public bool IsGroundPoint
	{
		get
		{
			CheckDestroyed();
			if (!IsGroundPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:IsGroundPoint");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, IsGroundPoint_Offset), 0, IsGroundPoint_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!IsGroundPoint_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUSpiderNavPointActor:IsGroundPoint");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, IsGroundPoint_Offset), 0, IsGroundPoint_PropertyAddress.Address, value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUSpiderNavPointActor");
		Root_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Root");
		Root_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Root", Classes.FObjectProperty);
		Arrow_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Arrow");
		Arrow_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Arrow", Classes.FObjectProperty);
		LinkRadius_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LinkRadius");
		LinkRadius_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LinkRadius", Classes.FFloatProperty);
		LinkAngle_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "LinkAngle");
		LinkAngle_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "LinkAngle", Classes.FFloatProperty);
		NativeReflection.GetPropertyRef(ref IsGroundPoint_PropertyAddress, unrealStruct, "IsGroundPoint");
		IsGroundPoint_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "IsGroundPoint");
		IsGroundPoint_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "IsGroundPoint", Classes.FBoolProperty);
	}

	static BGUSpiderNavPointActor()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BGUSpiderNavPointActor)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BGUSpiderNavPointActor));
	}
}
