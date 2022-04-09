
using Hammer;
using Sandbox;

namespace Surf.Map;

public partial class BaseZone : BaseTrigger 
{ 

}

[EntityTool("test", "test2")]
[Library( "surf_linear_start", Description = "Where the timer will start" )]
public partial class LinearStart : BaseZone
{

}

[Library( "surf_linear_end", Description = "Where the timer will end" )]
internal partial class LinearEnd : BaseZone
{

}

[Library( "surf_linear_checkpoint", Description = "Where the timer will set a checkpoint (linear)" )]
internal partial class LinearCheckpoint : BaseZone
{

}

[Library( "surf_stage_start", Description = "Where the timer will begin a stage" )]
internal partial class StageStart : BaseZone 
{

}

[Library( "surf_stage_end", Description = "Where the timer will end a stage" )]
internal partial class StageEnd : BaseZone
{

}
