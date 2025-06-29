using UnrealEngine.Engine;
using UnrealEngine.Runtime;

namespace b1;

public class GrobalRTWrap
{
	private TStrongObjectPtr<UTextureRenderTarget2D> _RTPing = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> _RTPong = new TStrongObjectPtr<UTextureRenderTarget2D>();

	private TStrongObjectPtr<UTextureRenderTarget2D> _RTResult = new TStrongObjectPtr<UTextureRenderTarget2D>();

	public UTextureRenderTarget2D RTPing
	{
		get
		{
			return _RTPing.Get();
		}
		set
		{
			_RTPing.Set(value);
		}
	}

	public UTextureRenderTarget2D RTPong
	{
		get
		{
			return _RTPong.Get();
		}
		set
		{
			_RTPong.Set(value);
		}
	}

	public UTextureRenderTarget2D RTResult
	{
		get
		{
			return _RTResult.Get();
		}
		set
		{
			_RTResult.Set(value);
		}
	}
}
