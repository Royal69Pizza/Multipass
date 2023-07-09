using System;

[Serializable]
public class Password
{
    private string name;
    private string id;
    private string pwd;

    public Password(string aName, string aID, string aPWD)
    {
        name = aName;
        id = aID;
        pwd = aPWD;
    }

    public string Name { get => name; private set => name = value; }
    public string ID { get => id; private set => id = value; }
    public string PWD { get => pwd; private set => pwd = value; }
}