using System;
using CommB1;
using Google.Protobuf;
using UnrealEngine.Runtime;

namespace b1;

[UClass]
[USharpPath("/Script/b1-Managed.MovieNodeInstance_SetStreamingManagerViewSource")]
public class MovieNodeInstance_SetStreamingManagerViewSource : MovieNodeInstance
{
	private static int GrassTickInterval_Handle;

	private float Duration = -1f;

	private MovieCustom_SetStreamingManagerViewSource CustomData { get; set; }

	public override void PostCreate()
	{
		CustomData = new MovieCustom_SetStreamingManagerViewSource();
		CustomData.MergeFrom(base.Node.NodeData);
	}

	public override void TriggerInput(string InputPin = "")
	{
		base.TriggerInput(InputPin);
		GrassTickInterval_Handle = ((GrassTickInterval_Handle == -1) ? CVarFuncLib.CreateHandle("grass.TickInterval") : GrassTickInterval_Handle);
		if (CustomData.IsAlive)
		{
			CVarFuncLib.SetByHandle(GrassTickInterval_Handle, 2f);
			Duration = float.MaxValue;
		}
		else
		{
			CVarFuncLib.DestroyHandle(GrassTickInterval_Handle);
			GrassTickInterval_Handle = -1;
			Duration = -1f;
		}
		if (CustomData.TransformX.Count > 0)
		{
			for (int i = 0; i < CustomData.TransformX.Count; i++)
			{
				UBGUWCStreamingFuncLib.SetStreamingManagerViewSource(new FVector(CustomData.TransformX[i], CustomData.TransformY[i], CustomData.TransformZ[i]), Duration);
			}
		}
		TriggerFirstOutput();
	}

	static MovieNodeInstance_SetStreamingManagerViewSource()
	{
		if (UnrealTypes.CanLazyLoadManagedType(typeof(MovieNodeInstance_SetStreamingManagerViewSource)))
		{
			LoadNativeType();
		}
		UnrealTypes.OnCCtorCalled(typeof(MovieNodeInstance_SetStreamingManagerViewSource));
		GrassTickInterval_Handle = -1;
	}

	private static void LoadNativeType()
	{
		IntPtr intPtr = NativeReflection.GetClass("/Script/b1-Managed.MovieNodeInstance_SetStreamingManagerViewSource");
	}
}
