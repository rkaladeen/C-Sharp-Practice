namespace Phone {
  public class Nokia : Phone, IRingable {
    public Nokia(string versionNumber, int batteryPercentage, string carrier, string ringTone)
      : base(versionNumber, batteryPercentage, carrier, ringTone) { }
    public string Ring() {
      string output = "";
      output += $"\n... {_ringTone} ...\n";
      return output;
    }
    public string Unlock() {
      string output = "";
      output += $"\nNokia {_versionNumber} unlocked with fingerprint scanner\n";
      return output;
    }
    public override string DisplayInfo() {
      string output = "";
      output += "$$$$$$$$$$$$$$$$$$$$$$$$$$";
      output += "\nNokia " + _versionNumber;
      output += "\nBattery Percentage: " + _batteryPercentage;
      output += "\nCarrier: " + _carrier;
      output += "\nRingtone: " + _ringTone;
      output += "\n$$$$$$$$$$$$$$$$$$$$$$$$$$";
      return output;
    }
  }
}