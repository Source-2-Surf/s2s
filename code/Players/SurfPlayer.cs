
using Sandbox;

namespace Surf.Players;

internal partial class SurfPlayer : Sandbox.Player
{

	public override void Spawn()
	{
		base.Spawn();

		SetModel( "models/citizen/citizen.vmdl" );

		Controller = new WalkController()
		{
			AirAcceleration = 150,
			WalkSpeed = 260,
			SprintSpeed = 260,
			DefaultSpeed = 260,
			AutoJump = true,
			Acceleration = 4,
		};
		CameraMode = new Camera();
		Animator = new StandardPlayerAnimator();

		EnableDrawing = true;
		EnableHideInFirstPerson = true;
		EnableShadowInFirstPerson = true;
	}

}
