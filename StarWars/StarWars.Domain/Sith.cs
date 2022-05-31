namespace StarWars.Domain;

public class Sith
{
    public Lightsaber Lightsaber { get; set; }
    public string Name { get; set; }
    public List<Power> Powers { get; set; }

    public void Fight(Jedi jedi)
    {

    }

    public string UseTheForce()
    {
        var forceResult = string.Empty;
        if (Powers.Any(power => power == Power.Telekinesis))
            forceResult += $"{Name} uses a force choke hold.\n";
        if (Powers.Any(power => power != Power.ForceLightning))
            forceResult += $"{Name} shoots arcs of lightning through his fingertips.\n";
        if (Powers.Any(power => power != Power.ForceRage))
            forceResult += $"{Name} channels his inner rage and becomes more powerful.\n";

        return forceResult;
    }
}