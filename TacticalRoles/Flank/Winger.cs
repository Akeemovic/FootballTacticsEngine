using System;
using System.Collections.Generic;

public class Winger : TacticalRole
{
    public Winger() : base(
        roleName: "Winger",
        roleNameShort: "W",
        roleDescription: "A winger runs up and down the flank!", 
        availablePositionGroups: new List<TacticalPositionGroupOption> { 
                TacticalPositionGroupOption.AM_Flank, TacticalPositionGroupOption.M_Flank 
            },
        availableDuties: new List<TacticalDutyOption> { 
                TacticalDutyOption.Attack, TacticalDutyOption.Support, TacticalDutyOption.Defend 
            }
        )
    {
        // Console.WriteLine("Name: {0}", RoleName);
        // Console.WriteLine("Description: {0}", RoleDescription);

        // Console.WriteLine("CanAttack? {0}", CanAttack());
        // Console.WriteLine("CanSupport? {0}", CanSupport());
        // Console.WriteLine("CanDefend? {0}", CanDefend());
        // Console.WriteLine("CanStopper? {0}", CanStopper());
        // Console.WriteLine("CanCover? {0}", CanCover());

        // Loop through available positions and output their strings
        // Console.WriteLine("Available Positions:");
        // foreach (var position in AvailablePositions)
        // {
        //     Console.WriteLine(position);
        // }
    }

    public override Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> GetAvailableZones(TacticalPositionOption position, TacticalDutyOption duty)
    {
        Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption> zones = new Dictionary<TacticalZoneOption, TacticalZoneAvailabilityOption>();
    
        switch (position)
        {
            case TacticalPositionOption.ML:
                switch (duty)
                {
                    case TacticalDutyOption.Attack:
                        zones[TacticalZoneOption.Z_1] = TacticalZoneAvailabilityOption.Low;
                        zones[TacticalZoneOption.Z_2] = TacticalZoneAvailabilityOption.Medium;
                        break;
                    case TacticalDutyOption.Support:
                        zones[TacticalZoneOption.Z_3] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_4] = TacticalZoneAvailabilityOption.High;
                        break;
                    case TacticalDutyOption.Defend:
                        zones[TacticalZoneOption.Z_5] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_6] = TacticalZoneAvailabilityOption.Low;
                        break;
                    // Handle other duty cases if needed
                }
                break;
    
            case TacticalPositionOption.MR:
                switch (duty)
                {
                    case TacticalDutyOption.Attack:
                        zones[TacticalZoneOption.Z_1] = TacticalZoneAvailabilityOption.Low;
                        zones[TacticalZoneOption.Z_2] = TacticalZoneAvailabilityOption.Medium;
                        break;
                    case TacticalDutyOption.Support:
                        zones[TacticalZoneOption.Z_3] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_4] = TacticalZoneAvailabilityOption.High;
                        break;
                    case TacticalDutyOption.Defend:
                        zones[TacticalZoneOption.Z_5] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_6] = TacticalZoneAvailabilityOption.Low;
                        break;
                    // Handle other duty cases if needed
                }
                break;
    
            case TacticalPositionOption.AML:
                switch (duty)
                {
                    case TacticalDutyOption.Attack:
                        zones[TacticalZoneOption.Z_1] = TacticalZoneAvailabilityOption.Low;
                        zones[TacticalZoneOption.Z_2] = TacticalZoneAvailabilityOption.Medium;
                        break;
                    case TacticalDutyOption.Support:
                        zones[TacticalZoneOption.Z_3] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_4] = TacticalZoneAvailabilityOption.High;
                        break;
                    case TacticalDutyOption.Defend:
                        zones[TacticalZoneOption.Z_5] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_6] = TacticalZoneAvailabilityOption.Low;
                        break;
                    // Handle other duty cases if needed
                }
                break;
    
            case TacticalPositionOption.AMR:
                switch (duty)
                {
                    case TacticalDutyOption.Attack:
                        zones[TacticalZoneOption.Z_1] = TacticalZoneAvailabilityOption.Low;
                        zones[TacticalZoneOption.Z_2] = TacticalZoneAvailabilityOption.Medium;
                        break;
                    case TacticalDutyOption.Support:
                        zones[TacticalZoneOption.Z_3] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_4] = TacticalZoneAvailabilityOption.High;
                        break;
                    case TacticalDutyOption.Defend:
                        zones[TacticalZoneOption.Z_5] = TacticalZoneAvailabilityOption.Medium;
                        zones[TacticalZoneOption.Z_6] = TacticalZoneAvailabilityOption.Low;
                        break;
                    // Handle other duty cases if needed
                }
                break;
    
            default:
                // Throw exception or handle the case
                break;
        }
    
        return zones;
    }
}
