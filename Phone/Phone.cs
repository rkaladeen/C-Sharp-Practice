namespace Phone {
  public abstract class Phone {
    protected string _versionNumber;
    protected int _batteryPercentage;
    protected string _carrier;
    protected string _ringTone;
    public Phone(string versionNumber, int batteryPercentage, string carrier, string ringTone) {
      _versionNumber = versionNumber;
      _batteryPercentage = batteryPercentage;
      _carrier = carrier;
      _ringTone = ringTone;
    }
    public abstract string DisplayInfo();
  }
}