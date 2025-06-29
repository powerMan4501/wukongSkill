using System;
using b1.Plugins.Calliope;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[Placeable(true)]
[UClass]
[DisplayName("注册/注销StreamingManager加载源")]
[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource")]
internal class BED_MovieNode_SetStreamingManagerViewSource : BED_MovieNode
{
	private static bool bAlive_IsValid;

	private static int bAlive_Offset;

	private static FFieldAddress bAlive_PropertyAddress;

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

	[DisplayName("注册流加载源/注销流加载源")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[Category("Config")]
	[Tooltip("勾选表示创建流加载源，不勾表示注销加载源")]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:bAlive")]
	public bool bAlive
	{
		get
		{
			CheckDestroyed();
			if (!bAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:bAlive");
				return false;
			}
			return BoolMarshaler.FromNative(IntPtr.Add(base.Address, bAlive_Offset), 0, bAlive_PropertyAddress.Address);
		}
		set
		{
			CheckDestroyed();
			if (!bAlive_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:bAlive");
			}
			else
			{
				BoolMarshaler.ToNative(IntPtr.Add(base.Address, bAlive_Offset), 0, bAlive_PropertyAddress.Address, value);
			}
		}
	}

	[Tooltip("需要注册为流加载源的位置")]
	[DisplayName("需要产生加载源的位置")]
	[Category("Config")]
	[UProperty]
	[EditAnywhere]
	[BlueprintReadWrite]
	[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:StreamingSourcePositions")]
	public TArrayReadWrite<FVector> StreamingSourcePositions
	{
		get
		{
			CheckDestroyed();
			if (!StreamingSourcePositions_IsValid)
			{
				NativeReflection.LogInvalidPropertyAccessed("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:StreamingSourcePositions");
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
		bAlive = true;
		SetNodeCategory("Action");
		SetNodeStyle(ECalliopeNodeStyle.InOut);
	}

	public override string GetNodeName()
	{
		return B1CalliopeDef.MovieNode.SetStreamingManagerViewSource;
	}

	[USharpPath("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:GetNodeDescriptionInCS")]
	protected override string GetNodeDescriptionInCS_Implementation()
	{
		if (bAlive)
		{
			return "注册StreamingManager加载源";
		}
		return "注销StreamingManager加载源";
	}

	public override byte[] GetCustomData()
	{
		MovieCustom_SetStreamingManagerViewSource movieCustom_SetStreamingManagerViewSource = new MovieCustom_SetStreamingManagerViewSource();
		movieCustom_SetStreamingManagerViewSource.IsAlive = bAlive;
		foreach (FVector streamingSourcePosition in StreamingSourcePositions)
		{
			movieCustom_SetStreamingManagerViewSource.TransformX.Add(streamingSourcePosition.X);
			movieCustom_SetStreamingManagerViewSource.TransformY.Add(streamingSourcePosition.Y);
			movieCustom_SetStreamingManagerViewSource.TransformZ.Add(streamingSourcePosition.Z);
		}
		return movieCustom_SetStreamingManagerViewSource.ToByteArray();
	}

	[UFunctionInvoker("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:GetNodeDescriptionInCS")]
	private static void GetNodeDescriptionInCS__Invoker(IntPtr buffer, IntPtr obj)
	{
		b1.BED_MovieNode_SetStreamingManagerViewSource bED_MovieNode_SetStreamingManagerViewSource = GCHelper.Find<b1.BED_MovieNode_SetStreamingManagerViewSource>(obj);
		string nodeDescriptionInCS_Implementation = bED_MovieNode_SetStreamingManagerViewSource.GetNodeDescriptionInCS_Implementation();
		FStringMarshaler.ToNative(IntPtr.Add(buffer, GetNodeDescriptionInCS_ReturnValue_Offset), nodeDescriptionInCS_Implementation);
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource");
		NativeReflection.GetPropertyRef(ref bAlive_PropertyAddress, intPtr, "bAlive");
		bAlive_Offset = NativeReflection.GetPropertyOffset(intPtr, "bAlive");
		bAlive_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "bAlive", Classes.FBoolProperty);
		NativeReflection.GetPropertyRef(ref StreamingSourcePositions_PropertyAddress, intPtr, "StreamingSourcePositions");
		StreamingSourcePositions_Offset = NativeReflection.GetPropertyOffset(intPtr, "StreamingSourcePositions");
		StreamingSourcePositions_IsValid = NativeReflection.ValidatePropertyClass(intPtr, "StreamingSourcePositions", Classes.FArrayProperty);
		GetNodeDescriptionInCS_FunctionAddress = NativeReflectionCached.GetFunction(intPtr, "GetNodeDescriptionInCS");
		GetNodeDescriptionInCS_ParamsSize = NativeReflection.GetFunctionParamsSize(GetNodeDescriptionInCS_FunctionAddress);
		NativeReflection.GetPropertyRef(ref GetNodeDescriptionInCS_ReturnValue_PropertyAddress, GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_Offset = NativeReflection.GetPropertyOffset(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue");
		GetNodeDescriptionInCS_ReturnValue_IsValid = NativeReflection.ValidatePropertyClass(GetNodeDescriptionInCS_FunctionAddress, "ReturnValue", Classes.FStrProperty);
		GetNodeDescriptionInCS_IsValid = GetNodeDescriptionInCS_FunctionAddress != IntPtr.Zero && GetNodeDescriptionInCS_ReturnValue_IsValid;
		NativeReflection.LogFunctionIsValid("/Script/b1-Managed.BED_MovieNode_SetStreamingManagerViewSource:GetNodeDescriptionInCS", GetNodeDescriptionInCS_IsValid);
	}

	static BED_MovieNode_SetStreamingManagerViewSource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(b1.BED_MovieNode_SetStreamingManagerViewSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(b1.BED_MovieNode_SetStreamingManagerViewSource));
	}
}
