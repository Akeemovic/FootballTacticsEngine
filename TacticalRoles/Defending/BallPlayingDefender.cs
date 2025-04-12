using System;
using System.Collections.Generic;

public class BallPlayingDefender : TacticalRole {
    public BallPlayingDefender() : base(
        roleName: "Ball Playing Defender",
        roleNameShort: "BPD",
        roleDescription: "They will still have the main duty of being a defender and stop opposition attacks, but they are encouraged to play long balls or start moving forward with splitting balls and passes.", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.D_Center 
            },
        availableDuties: new List<TacticalDutyOption> { 
               TacticalDutyOption.Defend, TacticalDutyOption.Cover, TacticalDutyOption.Stopper 
            }
        )
    {
        // Contructor body
    }

    public override Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty) 
    {
        return null;    
    }
}
