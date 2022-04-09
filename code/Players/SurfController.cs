
using Sandbox;
using System;

namespace Surf.Players;

class SurfController : WalkController
{

	public override void AirMove()
	{
		SurfaceFriction = 1f;

		base.AirMove();
	}

}

