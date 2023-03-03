namespace BandsMVC.Models
{
    class DataService
    {
        List<Band> bands = new List<Band>
        {
            new Band { Id = 1, Name = "Rammstein", Description = "German synth"},
            new Band { Id = 32, Name = "Infected Mushroom", Description = "PsyTrance"},
            new Band { Id = 53, Name = "One Direction ", Description = "Pop"},
            new Band { Id = 76, Name = "Astrix", Description = "Psytrance"},
            new Band { Id = 101, Name = "Kreator", Description = "Metal"},
            new Band { Id = 232, Name = "Björnarna", Description = "Punk"}
        };

        public Band? GetBandById(int id)
        {
            return bands.FirstOrDefault(a => a.Id == id);
        }

        public Band[] GetAllBands()
        {
            return bands.ToArray();
        }
    }
}