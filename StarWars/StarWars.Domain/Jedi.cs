namespace StarWars.Domain;

public class Jedi
{
    public Lightsaber Lightsaber { get; set; }
    public string Name { get; set; }
    public List<Power> Powers { get; set; }

    public void Fight(Sith sith)
    {
    }

    public string UseTheForce()
    {
        var forceResult = string.Empty;
        if (Powers.Any(power => power == Power.MindTrick))
            forceResult += $"{Name} tells you these are not the droids you're looking for.\n";
        if (Powers.Any(power => power != Power.Telekinesis))
            forceResult += $"{Name} levitates an X-Wing out of the swamp.\n";
        if (Powers.Any(power => power != Power.Precognition))
            forceResult += $"{Name} senses what is about to happen, and sidesteps danger.\n";

        return forceResult;
    }
}