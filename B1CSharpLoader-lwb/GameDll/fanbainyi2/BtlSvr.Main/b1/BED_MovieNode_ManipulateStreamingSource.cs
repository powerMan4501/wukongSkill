using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(true)]
[DisplayName("注册/注销流加载源")]
[UClass]
[USharpPath("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource")]
internal class BED_MovieNode_ManipulateStreamingSource : BED_MovieNode
{
	private static bool bEnable_IsValid;

	private static int bEnable_Offset;

	private static FFieldAddress bEnable_PropertyAddress;

	private static bool StreamingSourcePositions_IsValid;

	private static int StreamingSourcePositions_Offset;

	private static FFieldAddress StreamingSourcePositions_PropertyAddress;

	private TArrayReadWriteMarshaler<FVector> StreamingSourcePositions_Marshaler;

	private static bool GetNodeDescriptionInCS_IsValid;

	private static IntPtr GetNodeDescriptionInCS_FunctionAddress;

	private static int GetNodeDescriptionInCS_ParamsSize;

	private static bool GetNodeDescriptionInCS_ReturnValue_IsValid;

	private static int GetNodeDescriptionInCS_ReturnValue_Offset;

	private static FFieldAddress GetNodeDescriptionInCS_ReturnValue_PropertyAddress;

	[Tooltip("勾选表示创建流加载源，不勾表示注销所有流加载源")]
	[DisplayName("注册流加载源/注销流加载源")]
	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:bEnable")]
	public bool bEnable
	{
		get
		{
			CheckDestroyed();
			if (!bEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:bEnable");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bEnable_Offset), 0, bEnable_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bEnable_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:bEnable");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bEnable_Offset), 0, bEnable_PropertyAddress.Address, value);
			}
		}
	}

	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[DisplayName("需要产生加载源的位置")]
	[Tooltip("需要注册为流加载源的位置")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:StreamingSourcePositions")]
	public TArrayReadWrite<FVector> StreamingSourcePositions
	{
		get
		{
			CheckDestroyed();
			if (!StreamingSourcePositions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:StreamingSourcePositions");
				return null;
			}
			if (StreamingSourcePositions_Marshaler == null)
			{
				StreamingSourcePositions_Marshaler = new TArrayReadWriteMarshaler<FVector>(1, StreamingSourcePositions_PropertyAddress, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.FromNative, CachedMarshalingDelegates<FVector, BlittableTypeMarshaler<FVector>>.ToNative);
			}
			return StreamingSourcePositions_Marshaler.FromNative(IntPtr.Add(base.Address, StreamingSourcePositions_Offset));
		}
	}

	public override void Initialize(FObjectInitializer Initializer)
	{
		base.Initialize(Initializer);
		bEnable = true;
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.ActivateOrDeactivateStreamingSource;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (bEnable)
		{
			return "注册流加载源";
		}
		return "注销流加载源";
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_ActivateOrDeactivateStreamingSource movieCustom_ActivateOrDeactivateStreamingSource = new MovieCustom_ActivateOrDeactivateStreamingSource();
		movieCustom_ActivateOrDeactivateStreamingSource.IsEnable = bEnable;
		foreach (FVector streamingSourcePosition in StreamingSourcePositions)
		{
			movieCustom_ActivateOrDeactivateStreamingSource.TransformX.Add(streamingSourcePosition.X);
			movieCustom_ActivateOrDeactivateStreamingSource.TransformY.Add(streamingSourcePosition.Y);
			movieCustom_ActivateOrDeactivateStreamingSource.TransformZ.Add(streamingSourcePosition.Z);
		}
		return movieCustom_ActivateOrDeactivateStreamingSource.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_ManipulateStreamingSource bED_MovieNode_ManipulateStreamingSource = GCHelper.Find<b1.BED_MovieNode_ManipulateStreamingSource>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_ManipulateStreamingSource.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource");
		NativeReflection.GetPropertyRef(ref bEnable_PropertyAddress, intPtr, "bEnable");
		bEnable_Offset = NativeReflection.GetPropertyOffset(intPtr, "bEnable");
		bEnable_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bEnable", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StreamingSourcePositions_PropertyAddress, intPtr, "StreamingSourcePositions");
		StreamingSourcePositions_Offset = NativeReflection.GetPropertyOffset(intPtr, "StreamingSourcePositions");
		StreamingSourcePositions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StreamingSourcePositions", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_ManipulateStreamingSource:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_ManipulateStreamingSource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_ManipulateStreamingSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_ManipulateStreamingSource));
	}
}
