interface IModel
{
    string modelName { get; set; }
    string GetEngineSpecs();
}

interface IVehicle
{
    string name { get; set; }
    void GoForward();
    void GoBackward();
}

class Car : IVehicle, IModel
{
    public string name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }
    public string modelName { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

    public string GetEngineSpecs()
    {
        throw new NotImplementedException();
    }

    public void GoBackward()
    {
        throw new NotImplementedException();
    }

    public void GoForward()
    {
        throw new NotImplementedException();
    }
}