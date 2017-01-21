// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Enums/ActivityType.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Enums {

  /// <summary>Holder for reflection information generated from POGOProtos/Enums/ActivityType.proto</summary>
  public static partial class ActivityTypeReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Enums/ActivityType.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ActivityTypeReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiNQT0dPUHJvdG9zL0VudW1zL0FjdGl2aXR5VHlwZS5wcm90bxIQUE9HT1By",
            "b3Rvcy5FbnVtcyrrBgoMQWN0aXZpdHlUeXBlEhQKEEFDVElWSVRZX1VOS05P",
            "V04QABIaChZBQ1RJVklUWV9DQVRDSF9QT0tFTU9OEAESIQodQUNUSVZJVFlf",
            "Q0FUQ0hfTEVHRU5EX1BPS0VNT04QAhIZChVBQ1RJVklUWV9GTEVFX1BPS0VN",
            "T04QAxIYChRBQ1RJVklUWV9ERUZFQVRfRk9SVBAEEhsKF0FDVElWSVRZX0VW",
            "T0xWRV9QT0tFTU9OEAUSFgoSQUNUSVZJVFlfSEFUQ0hfRUdHEAYSFAoQQUNU",
            "SVZJVFlfV0FMS19LTRAHEh4KGkFDVElWSVRZX1BPS0VERVhfRU5UUllfTkVX",
            "EAgSHgoaQUNUSVZJVFlfQ0FUQ0hfRklSU1RfVEhST1cQCRIdChlBQ1RJVklU",
            "WV9DQVRDSF9OSUNFX1RIUk9XEAoSHgoaQUNUSVZJVFlfQ0FUQ0hfR1JFQVRf",
            "VEhST1cQCxIiCh5BQ1RJVklUWV9DQVRDSF9FWENFTExFTlRfVEhST1cQDBIc",
            "ChhBQ1RJVklUWV9DQVRDSF9DVVJWRUJBTEwQDRIlCiFBQ1RJVklUWV9DQVRD",
            "SF9GSVJTVF9DQVRDSF9PRl9EQVkQDhIcChhBQ1RJVklUWV9DQVRDSF9NSUxF",
            "U1RPTkUQDxIaChZBQ1RJVklUWV9UUkFJTl9QT0tFTU9OEBASGAoUQUNUSVZJ",
            "VFlfU0VBUkNIX0ZPUlQQERIcChhBQ1RJVklUWV9SRUxFQVNFX1BPS0VNT04Q",
            "EhIiCh5BQ1RJVklUWV9IQVRDSF9FR0dfU01BTExfQk9OVVMQExIjCh9BQ1RJ",
            "VklUWV9IQVRDSF9FR0dfTUVESVVNX0JPTlVTEBQSIgoeQUNUSVZJVFlfSEFU",
            "Q0hfRUdHX0xBUkdFX0JPTlVTEBUSIAocQUNUSVZJVFlfREVGRUFUX0dZTV9E",
            "RUZFTkRFUhAWEh4KGkFDVElWSVRZX0RFRkVBVF9HWU1fTEVBREVSEBcSKwon",
            "QUNUSVZJVFlfQ0FUQ0hfRklSU1RfQ0FUQ0hfU1RSRUFLX0JPTlVTEBgSKQol",
            "QUNUSVZJVFlfU0VBUkNIX0ZPUlRfRklSU1RfT0ZfVEhFX0RBWRAZEiUKIUFD",
            "VElWSVRZX1NFQVJDSF9GT1JUX1NUUkVBS19CT05VUxAaYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(new[] {typeof(global::POGOProtos.Enums.ActivityType), }, null));
    }
    #endregion

  }
  #region Enums
  public enum ActivityType {
    [pbr::OriginalName("ACTIVITY_UNKNOWN")] ActivityUnknown = 0,
    [pbr::OriginalName("ACTIVITY_CATCH_POKEMON")] ActivityCatchPokemon = 1,
    [pbr::OriginalName("ACTIVITY_CATCH_LEGEND_POKEMON")] ActivityCatchLegendPokemon = 2,
    [pbr::OriginalName("ACTIVITY_FLEE_POKEMON")] ActivityFleePokemon = 3,
    [pbr::OriginalName("ACTIVITY_DEFEAT_FORT")] ActivityDefeatFort = 4,
    [pbr::OriginalName("ACTIVITY_EVOLVE_POKEMON")] ActivityEvolvePokemon = 5,
    [pbr::OriginalName("ACTIVITY_HATCH_EGG")] ActivityHatchEgg = 6,
    [pbr::OriginalName("ACTIVITY_WALK_KM")] ActivityWalkKm = 7,
    [pbr::OriginalName("ACTIVITY_POKEDEX_ENTRY_NEW")] ActivityPokedexEntryNew = 8,
    [pbr::OriginalName("ACTIVITY_CATCH_FIRST_THROW")] ActivityCatchFirstThrow = 9,
    [pbr::OriginalName("ACTIVITY_CATCH_NICE_THROW")] ActivityCatchNiceThrow = 10,
    [pbr::OriginalName("ACTIVITY_CATCH_GREAT_THROW")] ActivityCatchGreatThrow = 11,
    [pbr::OriginalName("ACTIVITY_CATCH_EXCELLENT_THROW")] ActivityCatchExcellentThrow = 12,
    [pbr::OriginalName("ACTIVITY_CATCH_CURVEBALL")] ActivityCatchCurveball = 13,
    [pbr::OriginalName("ACTIVITY_CATCH_FIRST_CATCH_OF_DAY")] ActivityCatchFirstCatchOfDay = 14,
    [pbr::OriginalName("ACTIVITY_CATCH_MILESTONE")] ActivityCatchMilestone = 15,
    [pbr::OriginalName("ACTIVITY_TRAIN_POKEMON")] ActivityTrainPokemon = 16,
    [pbr::OriginalName("ACTIVITY_SEARCH_FORT")] ActivitySearchFort = 17,
    [pbr::OriginalName("ACTIVITY_RELEASE_POKEMON")] ActivityReleasePokemon = 18,
    [pbr::OriginalName("ACTIVITY_HATCH_EGG_SMALL_BONUS")] ActivityHatchEggSmallBonus = 19,
    [pbr::OriginalName("ACTIVITY_HATCH_EGG_MEDIUM_BONUS")] ActivityHatchEggMediumBonus = 20,
    [pbr::OriginalName("ACTIVITY_HATCH_EGG_LARGE_BONUS")] ActivityHatchEggLargeBonus = 21,
    [pbr::OriginalName("ACTIVITY_DEFEAT_GYM_DEFENDER")] ActivityDefeatGymDefender = 22,
    [pbr::OriginalName("ACTIVITY_DEFEAT_GYM_LEADER")] ActivityDefeatGymLeader = 23,
    [pbr::OriginalName("ACTIVITY_CATCH_FIRST_CATCH_STREAK_BONUS")] ActivityCatchFirstCatchStreakBonus = 24,
    [pbr::OriginalName("ACTIVITY_SEARCH_FORT_FIRST_OF_THE_DAY")] ActivitySearchFortFirstOfTheDay = 25,
    [pbr::OriginalName("ACTIVITY_SEARCH_FORT_STREAK_BONUS")] ActivitySearchFortStreakBonus = 26,
  }

  #endregion

}

#endregion Designer generated code
