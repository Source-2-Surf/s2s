
using Sandbox;
using Surf.Players;
using Surf.UI;

namespace Surf;

internal partial class SurfGame : Game
{

	public SurfGame()
	{
		if ( IsServer )
		{
			Global.TickRate = 66;

			_ = new UIEntity();
		}
	}

	public override void ClientJoined( Client client )
	{
		base.ClientJoined( client );

		client.Pawn = new Pawn();
		(client.Pawn as Pawn).Respawn();
	}

}

