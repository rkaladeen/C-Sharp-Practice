namespace Phone {
  public class Galaxy : Phone, IRingable {
    public Galaxy(string versionNumber, int batteryPercentage, string carrier, string ringTone)
      : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring() {
      string output = "";
      output += $"\n... {_ringTone} ...\n";
      return output;
    }
    public string Unlock() {
      string output = "";
      output += $"\nGalaxy {_versionNumber} unlocked with fingerprint scanner\n";
      return output;
    }
    public override string DisplayInfo() {
      string output = "";
      output += "##########################";
      output += "\nGalaxy " + _versionNumber;
      output += "\nBattery Percentage: " + _batteryPercentage;
      output += "\nCarrier: " + _carrier;
      output += "\nRingtone: " + _ringTone;
      output += "\n##########################";
      return output;
    }
  }
}