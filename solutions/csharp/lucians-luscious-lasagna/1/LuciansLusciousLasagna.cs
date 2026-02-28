class Lasagna
{
    public int ExpectedMinutesInOven() => 40;
    public int RemainingMinutesInOven(int passed) => 40-passed;
    public int PreparationTimeInMinutes(int layers) => layers*2;
    public int ElapsedTimeInMinutes(int layers, int been) => 2*layers + been;
}
