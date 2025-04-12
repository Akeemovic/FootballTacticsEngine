using System;

public class OnPlayerHasBall
{
    public HoldUpBall? HoldUpBall { get; set; }
    public FlankMovement? FlankMovement { get; set; }
    public ShootingRate? ShootingRate { get; set; }
    public DribblingRate? DribblingRate { get; set; }
    public CrossingRate? CrossingRate { get; set; }
    public CrossDistance? CrossDistance { get; set; }
    public CrossAim? CrossAim { get; set; }
    public PassingStyle? PassingStyle { get; set; }
    public RiskyPassing? RiskyPassing { get; set; }

    public bool HoldUpBallRequired { get; private set; } = false;
    public bool FlankMovementRequired { get; private set; } = false;
    public bool ShootingRateRequired { get; private set; } = false;
    public bool DribblingRateRequired { get; private set; } = false;
    public bool CrossingRateRequired { get; private set; } = false;
    public bool CrossDistanceRequired { get; private set; } = false;
    public bool CrossAimRequired { get; private set; } = false;
    public bool PassingStyleRequired { get; private set; } = false;
    public bool RiskyPassingRequired { get; private set; } = false;

    public OnPlayerHasBall()
    {
        // All options are unavailable unless explicitly set, so null values indicate that 
        HoldUpBall = null;
        FlankMovement = null;
        ShootingRate = null;
        DribblingRate = null;
        CrossingRate = null;
        CrossDistance = null;
        CrossAim = null;
        PassingStyle = null;
        RiskyPassing = null;
    }

    public OnPlayerHasBall(
        HoldUpBall? holdUpBall = null,
        FlankMovement? flankMovement = null,
        ShootingRate? shootingRate = null,
        DribblingRate? dribblingRate = null,
        CrossingRate? crossingRate = null,
        CrossDistance? crossDistance = null,
        CrossAim? crossAim = null,
        PassingStyle? passingStyle = null,
        RiskyPassing? riskyPassing = null)
    {
        // Assign the values
        HoldUpBall = holdUpBall;
        FlankMovement = flankMovement;
        ShootingRate = shootingRate;
        DribblingRate = dribblingRate;
        CrossingRate = crossingRate;
        CrossDistance = crossDistance;
        CrossAim = crossAim;
        PassingStyle = passingStyle;
        RiskyPassing = riskyPassing;

        // Set the required flags to true for each attribute
        if (holdUpBall != null) HoldUpBallRequired = true;
        if (flankMovement != null) FlankMovementRequired = true;
        if (shootingRate != null) ShootingRateRequired = true;
        if (dribblingRate != null) DribblingRateRequired = true;
        if (crossingRate != null) CrossingRateRequired = true;
        if (crossDistance != null) CrossDistanceRequired = true;
        if (crossAim != null) CrossAimRequired = true;
        if (passingStyle != null) PassingStyleRequired = true;
        if (riskyPassing != null) RiskyPassingRequired = true;
    }

    public void SetRequiredDefault<T>(T option)
    {
        switch (option)
        {
            case HoldUpBall holdUpBallOption:
                HoldUpBall = holdUpBallOption;
                HoldUpBallRequired = true;
                break;
            case FlankMovement flankMovementOption:
                FlankMovement = flankMovementOption;
                FlankMovementRequired = true;
                break;
            case ShootingRate shootingRateOption:
                ShootingRate = shootingRateOption;
                ShootingRateRequired = true;
                break;
            case DribblingRate dribblingRateOption:
                DribblingRate = dribblingRateOption;
                DribblingRateRequired = true;
                break;
            case CrossingRate crossingRateOption:
                CrossingRate = crossingRateOption;
                CrossingRateRequired = true;
                break;
            case CrossDistance crossDistanceOption:
                CrossDistance = crossDistanceOption;
                CrossDistanceRequired = true;
                break;
            case CrossAim crossAimOption:
                CrossAim = crossAimOption;
                CrossAimRequired = true;
                break;
            case PassingStyle passingStyleOption:
                PassingStyle = passingStyleOption;
                PassingStyleRequired = true;
                break;
            case RiskyPassing riskyPassingOption:
                RiskyPassing = riskyPassingOption;
                RiskyPassingRequired = true;
                break;
            default:
                throw new ArgumentException("Invalid option type.");
        }
    }
    
    
    public void Set<T>(T option)
    {
        switch (option)
        {
            case HoldUpBall _ when (HoldUpBall == null || HoldUpBallRequired):
                throw new InvalidOperationException("HoldUpBall is not available.");
            case FlankMovement _ when (FlankMovement == null || FlankMovementRequired):
                throw new InvalidOperationException("FlankMovement is not available.");
            case ShootingRate _ when (ShootingRate == null || ShootingRateRequired):
                throw new InvalidOperationException("ShootingRate is not available.");
            case DribblingRate _ when (DribblingRate == null || DribblingRateRequired):
                throw new InvalidOperationException("DribblingRate is not available.");
            case CrossingRate _ when (CrossingRate == null || CrossingRateRequired):
                throw new InvalidOperationException("CrossingRate is not available.");
            case CrossDistance _ when (CrossDistance == null || CrossDistanceRequired):
                throw new InvalidOperationException("CrossDistance is not available.");
            case CrossAim _ when (CrossAim == null || CrossAimRequired):
                throw new InvalidOperationException("CrossAim is not available.");
            case PassingStyle _ when (PassingStyle == null || PassingStyleRequired):
                throw new InvalidOperationException("PassingStyle is not available.");
            case RiskyPassing _ when (RiskyPassing == null || RiskyPassingRequired):
                throw new InvalidOperationException("RiskyPassing is not available.");
        }
    }
    
    
    
      public void MakeAvailable<T>()
    {
        switch (typeof(T).Name)
        {
            case nameof(HoldUpBall):
                HoldUpBall = HoldUpBall.None;
                HoldUpBallRequired = false; // Set the required flag to false
                break;
            case nameof(FlankMovement):
                FlankMovement = FlankMovement.None;
                FlankMovementRequired = false; // Set the required flag to false
                break;
            case nameof(ShootingRate):
                ShootingRate = ShootingRate.None;
                ShootingRateRequired = false; // Set the required flag to false
                break;
            case nameof(DribblingRate):
                DribblingRate = DribblingRate.None;
                DribblingRateRequired = false; // Set the required flag to false
                break;
            case nameof(CrossingRate):
                CrossingRate = CrossingRate.None;
                CrossingRateRequired = false; // Set the required flag to false
                break;
            case nameof(CrossDistance):
                CrossDistance = CrossDistance.None;
                CrossDistanceRequired = false; // Set the required flag to false
                break;
            case nameof(CrossAim):
                CrossAim = CrossAim.None;
                CrossAimRequired = false; // Set the required flag to false
                break;
            case nameof(PassingStyle):
                PassingStyle = PassingStyle.None;
                PassingStyleRequired = false; // Set the required flag to false
                break;
            case nameof(RiskyPassing):
                RiskyPassing = RiskyPassing.None;
                RiskyPassingRequired = false; // Set the required flag to false
                break;
            default:
                throw new ArgumentException("Invalid option type.");
        }
    }
    
    public void MakeUnavailable<T>()
    {
        switch (typeof(T).Name)
        {
            case nameof(HoldUpBall):
                HoldUpBall = null;
                HoldUpBallRequired = true; // Set the required flag to true
                break;
            case nameof(FlankMovement):
                FlankMovement = null;
                FlankMovementRequired = true; // Set the required flag to true
                break;
            case nameof(ShootingRate):
                ShootingRate = null;
                ShootingRateRequired = true; // Set the required flag to true
                break;
            case nameof(DribblingRate):
                DribblingRate = null;
                DribblingRateRequired = true; // Set the required flag to true
                break;
            case nameof(CrossingRate):
                CrossingRate = null;
                CrossingRateRequired = true; // Set the required flag to true
                break;
            case nameof(CrossDistance):
                CrossDistance = null;
                CrossDistanceRequired = true; // Set the required flag to true
                break;
            case nameof(CrossAim):
                CrossAim = null;
                CrossAimRequired = true; // Set the required flag to true
                break;
            case nameof(PassingStyle):
                PassingStyle = null;
                PassingStyleRequired = true; // Set the required flag to true
                break;
            case nameof(RiskyPassing):
                RiskyPassing = null;
                RiskyPassingRequired = true; // Set the required flag to true
                break;
            default:
                throw new ArgumentException("Invalid option type.");
        }
    }

}
