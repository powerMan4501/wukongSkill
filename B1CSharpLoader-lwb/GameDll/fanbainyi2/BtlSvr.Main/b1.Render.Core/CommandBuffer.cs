namespace b1.Render.Core;

internal class CommandBuffer
{
	public void CreateGPUFence()
	{
	}

	public void CreateGraphicsFence()
	{
	}

	public void DispatchCompute(b1.Render.Core.ComputeShader Shader, int KernelIndex, int X, int Y, int Z)
	{
	}

	public void SetGlobalBuffer(int NameID, b1.Render.Core.ComputeBuffer Value)
	{
	}

	public void WaitOnGPUFence()
	{
	}
}
