using System;
using System.Collections.Generic;

public class FullBack : TacticalRole
{
    public FullBack() : base(
        roleName: "Full Back",
        roleNameShort: "FB",
        roleDescription: "A Full Back is full of back", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.D_Flank 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Automatic, TacticalDutyOption.Attack, TacticalDutyOption.Support, TacticalDutyOption.Defend 
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
