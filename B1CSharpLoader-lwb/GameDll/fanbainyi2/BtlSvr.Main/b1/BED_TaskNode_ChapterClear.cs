using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[DisplayName("通关表演")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_TaskNode_ChapterClear")]
public class BED_TaskNode_ChapterClear : BED_TaskNode
{
	private static bool ChapterID_IsValid;

	private static int ChapterID_Offset;

	[DisplayName("章节ID")]
	[Category("Comm")]
	[BlueprintReadWrite]
	[EditAnywhere]
	[UProperty]
	[USharpPath("/Script/b1-Managed.BED_TaskNode_ChapterClear:ChapterID")]
	public int ChapterID
	{
		get
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ChapterClear:ChapterID");
				return 0;
			}
			return BlittableTypeMarshaler<int>.FromNative(IntPtr.Add(base.Address, ChapterID_Offset));
		}
		set
		{
			CheckDestroyed();
			if (!ChapterID_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_TaskNode_ChapterClear:ChapterID");
			}
			else
			{
				BlittableTypeMarshaler<int>.ToNative(IntPtr.Add(base.Address, ChapterID_Offset), value);
			}
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		SetNodeCategory("Gameplay");
		SetNodeStyle(ECalliopeNodeStyle.Latent);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.TaskNode.ChapterClear;
	}

	public override byte[] GetCustomData()
	{
		return new TaskCustom_ChapterClear
		{
			ChapterId = ChapterID
		}.ToByteArray();
	}

	private static void LoadNativeType()
	{
		IntPtr unrealStruct = NativeReflection.GetClass("/Script/b1-Managed.BED_TaskNode_ChapterClear");
		ChapterID_Offset = NativeReflection.GetPropertyOffset(unrealStruct, "ChapterID");
		ChapterID_IsValid = NativeReflection.ValidatePropertyClass(unrealStruct, "ChapterID", Classes.FIntProperty);
	}

	static BED_TaskNode_ChapterClear()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(BED_TaskNode_ChapterClear)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(BED_TaskNode_ChapterClear));
	}
}
