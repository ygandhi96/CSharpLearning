abstract class animal
{
    public string color { get; set; }
    public abstract void MakeNoise();
    //Abstract class can have method implementation also
    public void getColor()
    {
        Console.WriteLine(this.color);
    }
}

class dog : animal
{
    public override void MakeNoise()
    {
        //throw new NotImplementedException();
        Console.WriteLine("Sound of the dog....");
    }
}

class cat : animal
{
    public override void MakeNoise()
    {
        Console.WriteLine("Sound of the cat....");
    }
}