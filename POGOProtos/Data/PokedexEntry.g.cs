// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/PokedexEntry.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/PokedexEntry.proto</summary>
  public static partial class PokedexEntryReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/PokedexEntry.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static PokedexEntryReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CiJQT0dPUHJvdG9zL0RhdGEvUG9rZWRleEVudHJ5LnByb3RvEg9QT0dPUHJv",
            "dG9zLkRhdGEaHlBPR09Qcm90b3MvRW51bXMvQ29zdHVtZS5wcm90bxobUE9H",
            "T1Byb3Rvcy9FbnVtcy9Gb3JtLnByb3RvGh1QT0dPUHJvdG9zL0VudW1zL0dl",
            "bmRlci5wcm90bxogUE9HT1Byb3Rvcy9FbnVtcy9Qb2tlbW9uSWQucHJvdG8i",
            "3gIKDFBva2VkZXhFbnRyeRIvCgpwb2tlbW9uX2lkGAEgASgOMhsuUE9HT1By",
            "b3Rvcy5FbnVtcy5Qb2tlbW9uSWQSGQoRdGltZXNfZW5jb3VudGVyZWQYAiAB",
            "KAUSFgoOdGltZXNfY2FwdHVyZWQYAyABKAUSHgoWZXZvbHV0aW9uX3N0b25l",
            "X3BpZWNlcxgEIAEoBRIYChBldm9sdXRpb25fc3RvbmVzGAUgASgFEjQKEWNh",
            "cHR1cmVkX2Nvc3R1bWVzGAYgAygOMhkuUE9HT1Byb3Rvcy5FbnVtcy5Db3N0",
            "dW1lEi4KDmNhcHR1cmVkX2Zvcm1zGAcgAygOMhYuUE9HT1Byb3Rvcy5FbnVt",
            "cy5Gb3JtEjIKEGNhcHR1cmVkX2dlbmRlcnMYCCADKA4yGC5QT0dPUHJvdG9z",
            "LkVudW1zLkdlbmRlchIWCg5jYXB0dXJlZF9zaGlueRgJIAEoCGIGcHJvdG8z"));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { global::POGOProtos.Enums.CostumeReflection.Descriptor, global::POGOProtos.Enums.FormReflection.Descriptor, global::POGOProtos.Enums.GenderReflection.Descriptor, global::POGOProtos.Enums.PokemonIdReflection.Descriptor, },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.PokedexEntry), global::POGOProtos.Data.PokedexEntry.Parser, new[]{ "PokemonId", "TimesEncountered", "TimesCaptured", "EvolutionStonePieces", "EvolutionStones", "CapturedCostumes", "CapturedForms", "CapturedGenders", "CapturedShiny" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class PokedexEntry : pb::IMessage<PokedexEntry> {
    private static readonly pb::MessageParser<PokedexEntry> _parser = new pb::MessageParser<PokedexEntry>(() => new PokedexEntry());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<PokedexEntry> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.PokedexEntryReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokedexEntry() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokedexEntry(PokedexEntry other) : this() {
      pokemonId_ = other.pokemonId_;
      timesEncountered_ = other.timesEncountered_;
      timesCaptured_ = other.timesCaptured_;
      evolutionStonePieces_ = other.evolutionStonePieces_;
      evolutionStones_ = other.evolutionStones_;
      capturedCostumes_ = other.capturedCostumes_.Clone();
      capturedForms_ = other.capturedForms_.Clone();
      capturedGenders_ = other.capturedGenders_.Clone();
      capturedShiny_ = other.capturedShiny_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public PokedexEntry Clone() {
      return new PokedexEntry(this);
    }

    /// <summary>Field number for the "pokemon_id" field.</summary>
    public const int PokemonIdFieldNumber = 1;
    private global::POGOProtos.Enums.PokemonId pokemonId_ = 0;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public global::POGOProtos.Enums.PokemonId PokemonId {
      get { return pokemonId_; }
      set {
        pokemonId_ = value;
      }
    }

    /// <summary>Field number for the "times_encountered" field.</summary>
    public const int TimesEncounteredFieldNumber = 2;
    private int timesEncountered_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TimesEncountered {
      get { return timesEncountered_; }
      set {
        timesEncountered_ = value;
      }
    }

    /// <summary>Field number for the "times_captured" field.</summary>
    public const int TimesCapturedFieldNumber = 3;
    private int timesCaptured_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int TimesCaptured {
      get { return timesCaptured_; }
      set {
        timesCaptured_ = value;
      }
    }

    /// <summary>Field number for the "evolution_stone_pieces" field.</summary>
    public const int EvolutionStonePiecesFieldNumber = 4;
    private int evolutionStonePieces_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EvolutionStonePieces {
      get { return evolutionStonePieces_; }
      set {
        evolutionStonePieces_ = value;
      }
    }

    /// <summary>Field number for the "evolution_stones" field.</summary>
    public const int EvolutionStonesFieldNumber = 5;
    private int evolutionStones_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int EvolutionStones {
      get { return evolutionStones_; }
      set {
        evolutionStones_ = value;
      }
    }

    /// <summary>Field number for the "captured_costumes" field.</summary>
    public const int CapturedCostumesFieldNumber = 6;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.Costume> _repeated_capturedCostumes_codec
        = pb::FieldCodec.ForEnum(50, x => (int) x, x => (global::POGOProtos.Enums.Costume) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.Costume> capturedCostumes_ = new pbc::RepeatedField<global::POGOProtos.Enums.Costume>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.Costume> CapturedCostumes {
      get { return capturedCostumes_; }
    }

    /// <summary>Field number for the "captured_forms" field.</summary>
    public const int CapturedFormsFieldNumber = 7;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.Form> _repeated_capturedForms_codec
        = pb::FieldCodec.ForEnum(58, x => (int) x, x => (global::POGOProtos.Enums.Form) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.Form> capturedForms_ = new pbc::RepeatedField<global::POGOProtos.Enums.Form>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.Form> CapturedForms {
      get { return capturedForms_; }
    }

    /// <summary>Field number for the "captured_genders" field.</summary>
    public const int CapturedGendersFieldNumber = 8;
    private static readonly pb::FieldCodec<global::POGOProtos.Enums.Gender> _repeated_capturedGenders_codec
        = pb::FieldCodec.ForEnum(66, x => (int) x, x => (global::POGOProtos.Enums.Gender) x);
    private readonly pbc::RepeatedField<global::POGOProtos.Enums.Gender> capturedGenders_ = new pbc::RepeatedField<global::POGOProtos.Enums.Gender>();
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public pbc::RepeatedField<global::POGOProtos.Enums.Gender> CapturedGenders {
      get { return capturedGenders_; }
    }

    /// <summary>Field number for the "captured_shiny" field.</summary>
    public const int CapturedShinyFieldNumber = 9;
    private bool capturedShiny_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool CapturedShiny {
      get { return capturedShiny_; }
      set {
        capturedShiny_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as PokedexEntry);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(PokedexEntry other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (PokemonId != other.PokemonId) return false;
      if (TimesEncountered != other.TimesEncountered) return false;
      if (TimesCaptured != other.TimesCaptured) return false;
      if (EvolutionStonePieces != other.EvolutionStonePieces) return false;
      if (EvolutionStones != other.EvolutionStones) return false;
      if(!capturedCostumes_.Equals(other.capturedCostumes_)) return false;
      if(!capturedForms_.Equals(other.capturedForms_)) return false;
      if(!capturedGenders_.Equals(other.capturedGenders_)) return false;
      if (CapturedShiny != other.CapturedShiny) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (PokemonId != 0) hash ^= PokemonId.GetHashCode();
      if (TimesEncountered != 0) hash ^= TimesEncountered.GetHashCode();
      if (TimesCaptured != 0) hash ^= TimesCaptured.GetHashCode();
      if (EvolutionStonePieces != 0) hash ^= EvolutionStonePieces.GetHashCode();
      if (EvolutionStones != 0) hash ^= EvolutionStones.GetHashCode();
      hash ^= capturedCostumes_.GetHashCode();
      hash ^= capturedForms_.GetHashCode();
      hash ^= capturedGenders_.GetHashCode();
      if (CapturedShiny != false) hash ^= CapturedShiny.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (PokemonId != 0) {
        output.WriteRawTag(8);
        output.WriteEnum((int) PokemonId);
      }
      if (TimesEncountered != 0) {
        output.WriteRawTag(16);
        output.WriteInt32(TimesEncountered);
      }
      if (TimesCaptured != 0) {
        output.WriteRawTag(24);
        output.WriteInt32(TimesCaptured);
      }
      if (EvolutionStonePieces != 0) {
        output.WriteRawTag(32);
        output.WriteInt32(EvolutionStonePieces);
      }
      if (EvolutionStones != 0) {
        output.WriteRawTag(40);
        output.WriteInt32(EvolutionStones);
      }
      capturedCostumes_.WriteTo(output, _repeated_capturedCostumes_codec);
      capturedForms_.WriteTo(output, _repeated_capturedForms_codec);
      capturedGenders_.WriteTo(output, _repeated_capturedGenders_codec);
      if (CapturedShiny != false) {
        output.WriteRawTag(72);
        output.WriteBool(CapturedShiny);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (PokemonId != 0) {
        size += 1 + pb::CodedOutputStream.ComputeEnumSize((int) PokemonId);
      }
      if (TimesEncountered != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesEncountered);
      }
      if (TimesCaptured != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(TimesCaptured);
      }
      if (EvolutionStonePieces != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStonePieces);
      }
      if (EvolutionStones != 0) {
        size += 1 + pb::CodedOutputStream.ComputeInt32Size(EvolutionStones);
      }
      size += capturedCostumes_.CalculateSize(_repeated_capturedCostumes_codec);
      size += capturedForms_.CalculateSize(_repeated_capturedForms_codec);
      size += capturedGenders_.CalculateSize(_repeated_capturedGenders_codec);
      if (CapturedShiny != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(PokedexEntry other) {
      if (other == null) {
        return;
      }
      if (other.PokemonId != 0) {
        PokemonId = other.PokemonId;
      }
      if (other.TimesEncountered != 0) {
        TimesEncountered = other.TimesEncountered;
      }
      if (other.TimesCaptured != 0) {
        TimesCaptured = other.TimesCaptured;
      }
      if (other.EvolutionStonePieces != 0) {
        EvolutionStonePieces = other.EvolutionStonePieces;
      }
      if (other.EvolutionStones != 0) {
        EvolutionStones = other.EvolutionStones;
      }
      capturedCostumes_.Add(other.capturedCostumes_);
      capturedForms_.Add(other.capturedForms_);
      capturedGenders_.Add(other.capturedGenders_);
      if (other.CapturedShiny != false) {
        CapturedShiny = other.CapturedShiny;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(pb::CodedInputStream input) {
      uint tag;
      while ((tag = input.ReadTag()) != 0) {
        switch(tag) {
          default:
            input.SkipLastField();
            break;
          case 8: {
            pokemonId_ = (global::POGOProtos.Enums.PokemonId) input.ReadEnum();
            break;
          }
          case 16: {
            TimesEncountered = input.ReadInt32();
            break;
          }
          case 24: {
            TimesCaptured = input.ReadInt32();
            break;
          }
          case 32: {
            EvolutionStonePieces = input.ReadInt32();
            break;
          }
          case 40: {
            EvolutionStones = input.ReadInt32();
            break;
          }
          case 50:
          case 48: {
            capturedCostumes_.AddEntriesFrom(input, _repeated_capturedCostumes_codec);
            break;
          }
          case 58:
          case 56: {
            capturedForms_.AddEntriesFrom(input, _repeated_capturedForms_codec);
            break;
          }
          case 66:
          case 64: {
            capturedGenders_.AddEntriesFrom(input, _repeated_capturedGenders_codec);
            break;
          }
          case 72: {
            CapturedShiny = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code
