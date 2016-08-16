// Generated by the protocol buffer compiler.  DO NOT EDIT!
// source: POGOProtos/Data/Player/ContactSettings.proto
#pragma warning disable 1591, 0612, 3021
#region Designer generated code

using pb = global::Google.Protobuf;
using pbc = global::Google.Protobuf.Collections;
using pbr = global::Google.Protobuf.Reflection;
using scg = global::System.Collections.Generic;
namespace POGOProtos.Data.Player {

  /// <summary>Holder for reflection information generated from POGOProtos/Data/Player/ContactSettings.proto</summary>
  public static partial class ContactSettingsReflection {

    #region Descriptor
    /// <summary>File descriptor for POGOProtos/Data/Player/ContactSettings.proto</summary>
    public static pbr::FileDescriptor Descriptor {
      get { return descriptor; }
    }
    private static pbr::FileDescriptor descriptor;

    static ContactSettingsReflection() {
      byte[] descriptorData = global::System.Convert.FromBase64String(
          string.Concat(
            "CixQT0dPUHJvdG9zL0RhdGEvUGxheWVyL0NvbnRhY3RTZXR0aW5ncy5wcm90",
            "bxIWUE9HT1Byb3Rvcy5EYXRhLlBsYXllciJRCg9Db250YWN0U2V0dGluZ3MS",
            "HQoVc2VuZF9tYXJrZXRpbmdfZW1haWxzGAEgASgIEh8KF3NlbmRfcHVzaF9u",
            "b3RpZmljYXRpb25zGAIgASgIYgZwcm90bzM="));
      descriptor = pbr::FileDescriptor.FromGeneratedCode(descriptorData,
          new pbr::FileDescriptor[] { },
          new pbr::GeneratedClrTypeInfo(null, new pbr::GeneratedClrTypeInfo[] {
            new pbr::GeneratedClrTypeInfo(typeof(global::POGOProtos.Data.Player.ContactSettings), global::POGOProtos.Data.Player.ContactSettings.Parser, new[]{ "SendMarketingEmails", "SendPushNotifications" }, null, null, null)
          }));
    }
    #endregion

  }
  #region Messages
  public sealed partial class ContactSettings : pb::IMessage<ContactSettings> {
    private static readonly pb::MessageParser<ContactSettings> _parser = new pb::MessageParser<ContactSettings>(() => new ContactSettings());
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pb::MessageParser<ContactSettings> Parser { get { return _parser; } }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public static pbr::MessageDescriptor Descriptor {
      get { return global::POGOProtos.Data.Player.ContactSettingsReflection.Descriptor.MessageTypes[0]; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    pbr::MessageDescriptor pb::IMessage.Descriptor {
      get { return Descriptor; }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactSettings() {
      OnConstruction();
    }

    partial void OnConstruction();

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactSettings(ContactSettings other) : this() {
      sendMarketingEmails_ = other.sendMarketingEmails_;
      sendPushNotifications_ = other.sendPushNotifications_;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public ContactSettings Clone() {
      return new ContactSettings(this);
    }

    /// <summary>Field number for the "send_marketing_emails" field.</summary>
    public const int SendMarketingEmailsFieldNumber = 1;
    private bool sendMarketingEmails_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SendMarketingEmails {
      get { return sendMarketingEmails_; }
      set {
        sendMarketingEmails_ = value;
      }
    }

    /// <summary>Field number for the "send_push_notifications" field.</summary>
    public const int SendPushNotificationsFieldNumber = 2;
    private bool sendPushNotifications_;
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool SendPushNotifications {
      get { return sendPushNotifications_; }
      set {
        sendPushNotifications_ = value;
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override bool Equals(object other) {
      return Equals(other as ContactSettings);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public bool Equals(ContactSettings other) {
      if (ReferenceEquals(other, null)) {
        return false;
      }
      if (ReferenceEquals(other, this)) {
        return true;
      }
      if (SendMarketingEmails != other.SendMarketingEmails) return false;
      if (SendPushNotifications != other.SendPushNotifications) return false;
      return true;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override int GetHashCode() {
      int hash = 1;
      if (SendMarketingEmails != false) hash ^= SendMarketingEmails.GetHashCode();
      if (SendPushNotifications != false) hash ^= SendPushNotifications.GetHashCode();
      return hash;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public override string ToString() {
      return pb::JsonFormatter.ToDiagnosticString(this);
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void WriteTo(pb::CodedOutputStream output) {
      if (SendMarketingEmails != false) {
        output.WriteRawTag(8);
        output.WriteBool(SendMarketingEmails);
      }
      if (SendPushNotifications != false) {
        output.WriteRawTag(16);
        output.WriteBool(SendPushNotifications);
      }
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public int CalculateSize() {
      int size = 0;
      if (SendMarketingEmails != false) {
        size += 1 + 1;
      }
      if (SendPushNotifications != false) {
        size += 1 + 1;
      }
      return size;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute]
    public void MergeFrom(ContactSettings other) {
      if (other == null) {
        return;
      }
      if (other.SendMarketingEmails != false) {
        SendMarketingEmails = other.SendMarketingEmails;
      }
      if (other.SendPushNotifications != false) {
        SendPushNotifications = other.SendPushNotifications;
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
            SendMarketingEmails = input.ReadBool();
            break;
          }
          case 16: {
            SendPushNotifications = input.ReadBool();
            break;
          }
        }
      }
    }

  }

  #endregion

}

#endregion Designer generated code