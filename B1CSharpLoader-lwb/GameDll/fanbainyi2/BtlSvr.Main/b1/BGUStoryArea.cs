using System;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.BGUStoryArea")]
internal class BGUStoryArea : BGUAreaBase
{
	private static bool AreaID_IsValid;

	private static int AreaID_Offset;

	private static bool Pority_IsValid;

	private static int Pority_Offset;

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[USharpPath("/Script/b1-Managed.BGUStoryArea:AreaID")]
	public int AreaID
	{
		get
		{
			CheckDestroyed();
			if (!AreaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStoryArea:AreaID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, AreaID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!AreaID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStoryArea:AreaID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, AreaID_Offset), value);
			}
		}
	}

	[UProperty]
	[BlueprintReadWrite]
	[EditAnywhere]
	[DisplayName("优先级_值越大优先级越高")]
	[UMeta(MDProp.ClampMin, 0)]
	[USharpPath("/Script/b1-Managed.BGUStoryArea:Pority")]
	public int Pority
	{
		get
		{
			CheckDestroyed();
			if (!Pority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStoryArea:Pority");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, Pority_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!Pority_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BGUStoryArea:Pority");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, Pority_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer initializer)
	{
		base.Initialize(initializer);
		base.BasicConfigInfoComp.AreaType = EAreaType.Volume;
	}

	public override void InitAllComp()
	{
		base.InitAllComp();
		base.ActorCompContainerCS.AddComp(new BUS_StoryAreaLogicComp());
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BGUStoryArea");
		AreaID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "AreaID");
		AreaID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "AreaID", Classes.FIntProperty);
		Pority_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "Pority");
		Pority_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "Pority", Classes.FIntProperty);
	}

	static BGUStoryArea()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BGUStoryArea)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BGUStoryArea));
	}
}
