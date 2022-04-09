
using Sandbox;

namespace Surf.Players;

internal class Camera : CameraMode
{

	public override void Update()
	{
		var pawn = Local.Pawn;
		if ( pawn == null ) return;

		Position = pawn.EyePosition;
		Rotation = pawn.EyeRotation;

		Viewer = pawn;
	}

}
