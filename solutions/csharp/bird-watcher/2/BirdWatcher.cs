class BirdCount
{


    private int[] birdsPerDay;

    public BirdCount(int[] birdsPerDay)
    {
        this.birdsPerDay = birdsPerDay;
    }

    public static int[] LastWeek() => new int[] {0, 2, 5, 3, 7, 8, 4};
    

    public int Today() =>birdsPerDay[^1];

    public void IncrementTodaysCount()
    {
        birdsPerDay[^1] += 1;
    }

    public bool HasDayWithoutBirds()
    {
        bool n = false;
        foreach(int i in birdsPerDay ){
            n = i ==0? true: false;
            if (n == true) break; 
        }
        return n;
    }

    public int CountForFirstDays(int numberOfDays)
    {
        int sum = 0;
        for(int i = 0; i< numberOfDays; i++){
            sum += birdsPerDay[i];
        }
        return sum;
    }

    public int BusyDays()
    {
        int c = 0;
        foreach(int i in birdsPerDay ){
            if(i >=5){
                c+=1;
            }
        }
        return c; 
    }
}
